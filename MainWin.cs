using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.IO.Compression;


// --------------------------------------------------------------------
// To Use:
// -------
// 1. Update App.Config with the working directories for your application
// 2. Update the connection strings which apply to your situation
// 3. Set the name of the databases to only those the user should be able
//    to backup and restore
// 4. For some reason this application needs Version 11 of the library
//    Microsoft.SqlServer.Management.Sdk.Sfc ... I had to hack the 
//    GAC of my development machine to get a copy to install on my
//    client's machine which only had newer versions ... I'm pretty
//    sure it is installed with Microsoft SQL Server 2012 but his
//    server only had MS SQL 2016 installed. Maybe some of you out there
//    can figure out why this animal is insistent upon Version 11.
// --------------------------------------------------------------------
namespace NC.Util.SqlSrv.BackupRestore
{
    [SuppressMessage("ReSharper", "FieldCanBeMadeReadOnly.Local")]
    [SuppressMessage("ReSharper", "RedundantDelegateCreation")]
    public partial class MainWin : Form
    {
        private string _dbName = string.Empty;
        private string _backupFileName = String.Empty;
        private SqlConnection _sqlConn;
        private Server _sqlServer;
        private List<Database> _dbList = new List<Database>();
        private string _backupZips = @"C:\NovantBackups\SQLBackups\";
        private string _scratchPad = @"C:\NovantBackups\Scratch\";
        private string _DbFileLocation = @"C:\Program Files\Microsoft SQL Server\MSSQL13.SQLSVR_2016\MSSQL\DATA\";
        private string _zipFileName = String.Empty;
        private string _databaseFileName = String.Empty;
        private string _databaseLogFileName = string.Empty;
        private string _messageBoxCaption = "SQL Backup and Restore Utility";

        public MainWin()
        {
            InitializeComponent();
            openBakFile.InitialDirectory = Application.StartupPath;
            saveBakFile.InitialDirectory = Application.StartupPath;

            try
            {
                switch (Environment.MachineName)
                {
                    case "CTB-MAXIMUS-PC":
                        _sqlConn = new SqlConnection("Server=CTB-MAXIMUS-PC;Database=master;Trusted_Connection=True");
                        break;
                    case "SEP-JT":
                        _sqlConn = new SqlConnection("Data Source=SEP-JT;Database=master;User ID=sa;Password=Babylon5");
                        break;
                    case "SEP":
                        _sqlConn = new SqlConnection("Data Source=SEP;Database=master;User ID=sa;Password=Babylon5");
                        break;
                }

                _sqlServer = new Server(new ServerConnection(_sqlConn));

                //----------------
                //CTB: 2019/10/29:
                //----------------
                // Use this to limit the DB list to only those you want
                // the executor of this program to have access to
                // ----------------------------------------------------
                _dbList = new List<Database>();
                foreach (Database db in _sqlServer.Databases)
                {
                    if (db.Name == "Crucible" || db.Name == "CrucibleTARS" || db.Name == "StrataFrame" || db.Name == "BackupRestoreTest")
                    {
                        _dbList.Add(db);
                    }
                }

                cmbBackupDb.DataSource = _dbList;
                cmbBackupMode.SelectedIndex = 0;
                _dbName = cmbBackupDb.Text;
                GenerateApplicationFileNames(_dbName);
                txtFileToBackUp.Text = _backupFileName;

            }
            catch (Exception exc)
            {
                MessageBox.Show($@"Exception occured. Message: {exc.Message}", _messageBoxCaption);
                Logger.LogMessage($@"Exception occured. Message: {exc.Message}");
            }
        }
        // --------------- 
        // CTB: 2019/10/29
        // ------------------------------------------------------------------
        // Sometimes the program might leave a stray file in the scratch pad.
        // Makes sure the scratch pad is free of files so we don't have file
        // collision during this new running of the program
        // ------------------------------------------------------------------
        private void CleanUpScratchPadFiles()
        {
            if (Directory.Exists(_scratchPad))
            {
                string[] files = Directory.GetFiles(_scratchPad);
                foreach (string file in files)
                {
                    File.Delete(file);
                }
            }
        }

        private void saveBakFile_FileOk(object sender, CancelEventArgs e)
        {
            txtFileToBackUp.Text = saveBakFile.FileName;
        }

        private void openBakFile_FileOk(object sender, CancelEventArgs e)
        {
            txtFileToRestore.Text = openBakFile.FileName;
        }

        private void btnBackupDb_Click(object sender, EventArgs e)
        {
            BackupDb();
            CompressDbBackupFile();
        }

        private void ShrinkDatabaseLogFile()
        {
            string shortLogFileName = cmbBackupDb.Text + "_log";

            string sqlCommand = "USE " + cmbBackupDb.Text;
            sqlCommand += " ALTER DATABASE " + cmbBackupDb.Text;
            sqlCommand += " SET RECOVERY SIMPLE";
            sqlCommand += " DBCC SHRINKFILE (" + shortLogFileName + ", 1)";
            sqlCommand += " ALTER DATABASE " + cmbBackupDb.Text;
            sqlCommand += " SET RECOVERY FULL";
            Logger.LogMessage("Shrink Log File Script: " + sqlCommand);
            txtBackupSql.Text = sqlCommand;

            try
            {
                using (SqlCommand command = new SqlCommand(sqlCommand, _sqlConn))
                {
                    command.ExecuteNonQuery();
                }
                MessageBox.Show(@"Shrink Log File succeeded!!!", _messageBoxCaption);
                Logger.LogMessage(@"Shrink Log File succeeded!!!");
                Logger.LogMessage("----------");
            }
            catch (Exception e)
            {
                MessageBox.Show(@"Shrink database log file failed, please see log file for details ...", _messageBoxCaption);
                Logger.LogMessage(@"ShrinkDatabaseLogFile() failed: " + e);
                Logger.LogMessage(@"----------");

                MessageBox.Show(e.ToString(), _messageBoxCaption);
            }
        }

        private void ExtractBackupFile(string zipFile)
        {
            _backupFileName = zipFile.Replace(_backupZips, _scratchPad);
            _backupFileName = _backupFileName.Replace(".zip", ".bak");
            
            // ----------------
            // CTB: 2019/10/28:
            // ----------------------------------------------------------
            // Used only to display the name of the .bak file to the user
            // ----------------------------------------------------------
            txtFileToRestore.Text = _backupFileName;

            if (File.Exists(_backupFileName))
            {
                File.Delete(_backupFileName);
            }

            ZipFile.ExtractToDirectory(zipFile, _scratchPad);
        }

        private void CompressDbBackupFile()
        {
            // ---------------
            // CTB: 2019/10/28
            // -------------------------------------------------------
            // Zip files are named by HH:MM:SS ... if the user presses
            // the backup button more than once in a minute, erase
            // the existing .zip file and recreate it
            // -------------------------------------------------------
            if (File.Exists(_zipFileName))
            {
                File.Delete(_zipFileName);
            }

            // ---------------
            // CTB: 2019/10/27
            // ----------------------------------------------------
            // ZipFile only allows backing up of ALL the files in
            // a specified directory, therefore, use a scratch pad
            // directory where the .bak file is initially created,
            // perform the compression and then erase the .BAK file
            // ----------------------------------------------------
            ZipFile.CreateFromDirectory(_scratchPad, _zipFileName);
            File.Delete(_backupFileName);
        }

        private void BackupDb()
        {
            _dbName = ((Database)cmbBackupDb.SelectedItem).Name;
            Backup dbBackup = new Backup();

            try
            {
                dbBackup.Action = BackupActionType.Database;
                dbBackup.Database = _dbName;
                dbBackup.BackupSetName = $"{_dbName} backup set.";
                dbBackup.BackupSetDescription = $"Database: {_dbName}:Date: {DateTime.Now:dd.MM.yyyy hh:mm}.";
                dbBackup.MediaDescription = "Disk";

                BackupDeviceItem device = new BackupDeviceItem(txtFileToBackUp.Text, DeviceType.File);
                dbBackup.Devices.Add(device);

                txtBackupSql.Text = dbBackup.Script(_sqlServer);
                Logger.LogMessage("SQL Backup Script: " + txtBackupSql.Text);
                progBar.Visible = true;
                progBar.Value = 0;

                dbBackup.Complete += dbBackup_Complete;
                dbBackup.PercentCompleteNotification = 10;
                dbBackup.PercentComplete += PercentComplete;

                dbBackup.SqlBackup(_sqlServer);
            }
            catch (Exception exc)
            {
                dbBackup.Abort();
                Logger.LogMessage($@"Exception occured. Message: {exc.Message}");
            }

            progBar.Visible = false;
        }

        void dbBackup_Complete(object sender, ServerMessageEventArgs e)
        {
            MessageBox.Show(@"Backup complete!!!", _messageBoxCaption);
            Logger.LogMessage($@"Backup complete!!!");
            Logger.LogMessage("----------");

        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_backupFileName))
            {
                MessageBox.Show("Please select a .zip file first", _messageBoxCaption);
            }
            else
            {
                if (File.Exists(_backupFileName))
                {
                    RestoreDb();
                }
                else
                {
                    MessageBox.Show("The .zip file you specified does not exist!!!", _messageBoxCaption);
                    Logger.LogMessage("The .zip file you specified does not exist." );
                }
            }

            btnRestore.Enabled = false;
            txtFileToRestore.Text = String.Empty;
        }



        private void RestoreDb()
        {
            string[] dbNameFragments = _backupFileName.Split('_');
            string _dbName = dbNameFragments[0].Replace(_scratchPad, "");

            Restore dbRestore = new Restore();
            dbRestore.Database = _dbName;
            dbRestore.Action = RestoreActionType.Database;
            dbRestore.ReplaceDatabase = true;

            try
            {
                BackupDeviceItem device = new BackupDeviceItem(_backupFileName, DeviceType.File);
                dbRestore.Devices.Add(device);
                DataTable dtFiles = dbRestore.ReadFileList(_sqlServer);
                string backupDbLogicalName = dtFiles.Rows[0]["LogicalName"].ToString();

                RelocateFile dbRf = new RelocateFile(backupDbLogicalName, _databaseFileName);
                RelocateFile logRf = new RelocateFile($"{backupDbLogicalName}_log", _databaseLogFileName);
                dbRestore.RelocateFiles.Add(dbRf);
                dbRestore.RelocateFiles.Add(logRf);

                if (!logRf.PhysicalFileName.Contains(@"C:\"))
                {
                    logRf.PhysicalFileName = _DbFileLocation + _databaseLogFileName;
                }

                Logger.LogMessage("Physical Log File: " + logRf.PhysicalFileName);
                Logger.LogMessage("Physical DB File: " + dbRf.PhysicalFileName);


                string sql = string.Empty;
                StringCollection scriptColl = dbRestore.Script(_sqlServer);
                foreach (string str in scriptColl)
                {
                    sql += str;
                }

                sql = "USE master ALTER DATABASE " + _dbName + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE " + sql;
                sql += " ALTER DATABASE " + _dbName + " SET MULTI_USER ";

                txtBackupSql.Text = sql;
                Logger.LogMessage("SQL Restore Script: " + sql);
                progBar.Visible = true;
                progBar.Value = 0;

                dbRestore.Complete += new ServerMessageEventHandler(dbRestore_Complete);
                dbRestore.PercentComplete += new PercentCompleteEventHandler(PercentComplete);
                dbRestore.SqlRestore(_sqlServer);
            }
            catch (Exception exc)
            {
                dbRestore.Abort();
                Logger.LogMessage($"RestoreDb(): Exception occured.\nMessage: {exc.Message}");
                MessageBox.Show("RestoreDb(): Exception occured.\nMessage:" + exc.Message, _messageBoxCaption);
                ;
            }
            finally
            {
                if (File.Exists(_backupFileName))
                {
                    File.Delete(_backupFileName);
                }
            }

            progBar.Visible = false;
        }

        void PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            if (progBar.Value < progBar.Maximum)
            {
                if ((progBar.Value + e.Percent) <= 100)
                {
                    progBar.Value += e.Percent;
                }
                else
                    progBar.Value = 100;
            }
        }

        void dbRestore_Complete(object sender, ServerMessageEventArgs e)
        {
            MessageBox.Show(@"Restore complete", _messageBoxCaption);
            Logger.LogMessage(@"Restore complete ... no errors.");
            Logger.LogMessage(@"----------");

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GenerateApplicationFileNames(string _dbName)
        {
            string baseFileName = string.Format("{6}_{0}{1}{2}_{3}{4}{5}",
                DateTime.Now.Year.ToString().PadLeft(4, '0'),
                DateTime.Now.Month.ToString().PadLeft(2, '0'),
                DateTime.Now.Day.ToString().PadLeft(2, '0'),
                DateTime.Now.Hour.ToString().PadLeft(2, '0'),
                DateTime.Now.Minute.ToString().PadLeft(2, '0'),
                DateTime.Now.Second.ToString().PadLeft(2, '0'),
                _dbName);

            // ---------------
            // CTB: 2019.10.30
            // --------------------------------------------------------------
            // Check to make sure the directories defined in app.config exist
            // --------------------------------------------------------------
            bool validDirectoryStructures = true;

            if (!Directory.Exists(_backupZips))
            {
                Logger.LogMessage("The backup destination directory " + _backupZips + " does not exist.");
                validDirectoryStructures = false;
            }

            if (!Directory.Exists(_scratchPad))
            {
                Logger.LogMessage("The scratch pad directory " + _scratchPad + " does not exist.");
                validDirectoryStructures = false;
            }

            if (!Directory.Exists(_scratchPad))
            {
                Logger.LogMessage("The database file directory " + _DbFileLocation + " does not exist.");
                validDirectoryStructures = false;
            }

            if (!validDirectoryStructures)
            {
                cmdShrinkLogFile.Enabled = false;
                btnBackupDb.Enabled = false;
                btnRestore.Enabled = false;
                cmdGetZipFile.Enabled = false;
                cmbBackupDb.Enabled = false;


                MessageBox.Show(
                    "The directory structures for the application are invlid. Please see log file for details.  Make the changes, recompile then redeploy the application.", _messageBoxCaption);
                Logger.LogMessage("----------");

            }

            _backupFileName = _scratchPad + baseFileName + ".bak";
            _zipFileName = _backupZips + baseFileName + ".zip";
            _databaseFileName = _DbFileLocation + _dbName + ".mdf";
            _databaseLogFileName = _DbFileLocation + _dbName + "_Log.ldf";

            Logger.LogMessage("Backup File Name: " + _backupFileName);
            Logger.LogMessage("Zip File Name: " + _zipFileName);
            Logger.LogMessage("Database File Name: " + _databaseFileName);
            Logger.LogMessage("Database Log File Name: " + _databaseLogFileName);
            Logger.LogMessage("----------");

            txtFileToBackUp.Text = _backupFileName;

        }

        private void cmbBackupDb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GenerateApplicationFileNames(cmbBackupDb.Text);
            _dbName = cmbBackupDb.Text;

        }

        private void MainWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_sqlConn.State == ConnectionState.Open)
            {
                _sqlConn.Close();
            }
            _sqlConn.Dispose();

            CleanUpScratchPadFiles();
        }

        private void cmdGetZipFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = _backupZips;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Select a .zip file containg the .bak file of the DB to restore";
            openFileDialog1.ValidateNames = true;
            openFileDialog1.AddExtension = true;
            openFileDialog1.Filter = "zip files (*.zip)|";
            openFileDialog1.ShowHelp = false;

            DialogResult result = openFileDialog1.ShowDialog();
            if (string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                MessageBox.Show("Please select a .zip file first!!!", _messageBoxCaption);
            }
            else
            {
                if (result == DialogResult.OK)
                {
                    if (RestoreWarning(openFileDialog1.FileName))
                    {
                        ExtractBackupFile(openFileDialog1.FileName);
                    }
                }
            }

            btnRestore.Enabled = true;
        }

        private bool RestoreWarning(string fileName)
        {
            bool isOk =false;
            int fileAge = DateTime.Now.Subtract(File.GetCreationTime(fileName)).Hours;
            string message = String.Empty;
            if (fileAge <= 1)
            {
                message = @"The backup .zip file you selected is approximately one hour old. If you restore from this file you will lose at the very least one hour of transactions. Press OK if you are sure you want to restore from this file.";
                if (MessageBox.Show(message, 
                        @"!!! CAUTION !!! " + _messageBoxCaption,
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Exclamation) == DialogResult.OK )
                {
                    isOk = true;
                }
            }
            else
            {
                message = @"The backup .zip file you selected is " + fileAge.ToString() +
                          " hours old. You will lose at the very least that many hours of transactions if you restore from this file. Press OK if you are ABSOLUTELY sure you want to restore from this file.";
                if (MessageBox.Show(message,
                        @"!!! WARNING !!! " + _messageBoxCaption,
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    isOk = true;
                }

            }

            return isOk;
        }

        private void cmdShrinkLogFile_Click(object sender, EventArgs e)
        {
            ShrinkDatabaseLogFile();
        }

        private void cmdShow_Click(object sender, EventArgs e)
        {
            ShowLogFile();
        }

        private void ShowLogFile()
        {
            string logFileName = Environment.CurrentDirectory + @"\LogFile.txt";
            string logFileContents = string.Empty;
            if (File.Exists(logFileName))
            {
                string[] contents = File.ReadAllLines(logFileName);
                foreach (string line in contents)
                {
                    logFileContents += (line + Environment.NewLine);
                }
                txtLogFile.Text = logFileContents;
            }
        }
        private void cmdClear_Click(object sender, EventArgs e)
        {
            string logFileName = Environment.CurrentDirectory + @"\LogFile.txt";

            if (File.Exists(logFileName))
            {
                // ----------------------------------------------
                // Recreate the log file by simply overwriting it
                // ----------------------------------------------
                File.Create(logFileName);
                txtLogFile.Text = String.Empty;
            }
        }

        private void cmdViewInNotepad_Click(object sender, EventArgs e)
        {
            CommandLineHelper.LaunchNotepadToViewLogFile();
        }
    }
}