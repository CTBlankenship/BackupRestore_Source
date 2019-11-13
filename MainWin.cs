using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Net;
using System.Net.Mail;


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
        private string _dbFileLocation = String.Empty;
        private string _devFilesLocation = String.Empty;
        private string _developmentZips = string.Empty;
        private string _zipFileName = String.Empty;
        private string _databaseFileName = String.Empty;
        private string _databaseLogFileName = string.Empty;
        private string _messageBoxCaption = "SQL Backup and Restore Utility";
        private string _archiveFileName = String.Empty;

        // -----------------------------------------------------------------
        // Encryption key has to be 16 characters in length ...
        // If you use this app, change your encryption key to something else
        // -----------------------------------------------------------------
        private string _encryptionKey = "LazyDog";
        private Dictionary<string,string> _configurationSettings = new Dictionary<string, string>();
        private string _settingsFileName = Environment.CurrentDirectory + @"\ConfigurationSettings.sbu";

        public MainWin()
        {
            InitializeComponent();
            openBakFile.InitialDirectory = Application.StartupPath;
            saveBakFile.InitialDirectory = Application.StartupPath;
            try
            {
                // ---------------------------------------------------------------
                // #2: Update the connection strings which apply to your situation
                // ---------------------------------------------------------------
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

                PopulateGridWithDatabasesToBeBackedUp();
                InitializeConfigurationSettings();
                ReadConfigurationSettings();
                GenerateApplicationFileNames(_dbName);
                LoadDevelopmentDirectories();
            }
            catch (Exception exc)
            {
                MessageBox.Show($@"Exception occured. Message: {exc.Message}", _messageBoxCaption);
                Logger.LogMessage($@"Exception occured. Message: {exc.Message}");
            }
        }


        public void PopulateGridWithDatabasesToBeBackedUp()
        {
            if (_sqlServer.Databases.Count > 0)
            {
                foreach (Database db in _sqlServer.Databases)
                {
                    if (db.Name == "master" || db.Name == "tempdb" || db.Name == "model" || db.Name == "msdb")
                    {
                        // Do not display system databases //
                    }
                    else
                    {
                        dgvDatabases.Rows.Add(0, db.Name, GenerateDBBackupFileName(db.Name) + ".zip");
                    }
                }
            }
        }

        // --------------- 
        // CTB: 2019/10/29
        // ------------------------------------------------------------------
        // Sometimes the program might leave a stray file in the scratch pad.
        // Makes sure the scratch pad is free of files so we don't have file
        // collision during this new running of the program
        // ------------------------------------------------------------------
        private void CleanUpScratchPadBakFiles()
        {
            if (Directory.Exists(txtScratchPad.Text))
            {
                string[] files = Directory.GetFiles(txtScratchPad.Text);
                foreach (string file in files)
                {
                    // --------------
                    // CTB 2019:10:31
                    //----------------------------------------------------------
                    // WARNING: this method deletes ALL of the files in the 
                    //          specified folder. We MUST filter to erase
                    //          ONLY .bak files or we'll empty a folder
                    //          of any files in it ... think of what would happen
                    //          if the user selected C:\Temp ... yikes.
                    // ----------------------------------------------------------
                    if (file.Contains(".bak"))
                    {
                        File.Delete(file);
                    }
                }
            }
        }

        private void saveBakFile_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void openBakFile_FileOk(object sender, CancelEventArgs e)
        {
            txtFileToRestore.Text = openBakFile.FileName;
        }

        private void btnBackupDb_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvDatabases.Rows.Count; i++)
            {
                DataGridViewRow row = dgvDatabases.Rows[i];
                string value = row.Cells["colDBSelected"].Value.ToString();

                if (value == "true")
                {

                    string databaseName = (string)(dgvDatabases.Rows[i].Cells["colDBName"].Value);
                    _dbName = databaseName;
                    string dbDevice = (string) (dgvDatabases.Rows[i].Cells["colDBBackupZipName"].Value);
                    dbDevice = dbDevice.Replace("zip", "bak");
                    
                    BackupDb(databaseName, dbDevice);

                    CompressDbBackupFile(txtBackupZips.Text + (string)(dgvDatabases.Rows[i].Cells["colDBBackupZipName"].Value), dbDevice);
                }
            }
        }

        private void ShrinkDatabaseLogFile(string dbName)
        {
            string shortLogFileName = dbName + "_log";

            string sqlCommand = "USE " + dbName;
            sqlCommand += " ALTER DATABASE " + dbName;
            sqlCommand += " SET RECOVERY SIMPLE";
            sqlCommand += " DBCC SHRINKFILE (" + shortLogFileName + ", 1)";
            sqlCommand += " ALTER DATABASE " + dbName;
            sqlCommand += " SET RECOVERY FULL";
            Logger.LogMessage("Shrink Log File Script: " + sqlCommand);
            txtBackupScript.Text = sqlCommand;

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
            _backupFileName = zipFile.Replace(txtBackupZips.Text, txtScratchPad.Text);
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

            ZipFile.ExtractToDirectory(zipFile, txtScratchPad.Text);
        }

        private void CompressDbBackupFile(string dbDBBAckupZipFile, string dbBackupFile)
        {
            // ---------------
            // CTB: 2019/10/28
            // -------------------------------------------------------
            // Zip files are named by HH:MM:SS ... if the user presses
            // the backup button more than once in a minute, erase
            // the existing .zip file and recreate it
            // -------------------------------------------------------
            if (File.Exists(dbDBBAckupZipFile))
            {
                File.Delete(dbDBBAckupZipFile);
            }

            // ---------------
            // CTB: 2019/10/27
            // ----------------------------------------------------
            // ZipFile only allows backing up of ALL the files in
            // a specified directory, therefore, use a scratch pad
            // directory where the .bak file is initially created,
            // perform the compression and then erase the .BAK file
            // ----------------------------------------------------
            ZipFile.CreateFromDirectory(txtScratchPad.Text, dbDBBAckupZipFile);
            File.Delete(dbBackupFile);
        }

        private void BackupDb(string dbName, string fileToBackupTo)
        {
            Backup dbBackup = new Backup();

            try
            {
                fileToBackupTo = txtScratchPad.Text + fileToBackupTo;

                dbBackup.Action = BackupActionType.Database;
                dbBackup.Database = dbName;
                dbBackup.BackupSetName = $"{_dbName} backup set.";
                dbBackup.BackupSetDescription = $"Database: {dbName}:Date: {DateTime.Now:dd.MM.yyyy hh:mm}.";
                dbBackup.MediaDescription = "Disk";

                BackupDeviceItem device = new BackupDeviceItem(fileToBackupTo, DeviceType.File);
                dbBackup.Devices.Add(device);

                txtBackupScript.Text = dbBackup.Script(_sqlServer);
                Logger.LogMessage("SQL Backup Script: " + txtBackupScript.Text);
                progBar.Visible = true;
                progBar.Value = 0;

                dbBackup.Complete += dbBackup_Complete;
                dbBackup.PercentCompleteNotification = 10;
                dbBackup.PercentComplete += PercentComplete;
                // ----------------------------
                dbBackup.SqlBackup(_sqlServer);
                // ----------------------------
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
            MessageBox.Show(@"Backup of database " + _dbName + " is complete!!!", _messageBoxCaption);
            Logger.LogMessage($@"Backup complete!!!");
            Logger.LogMessage("----------");

        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_backupFileName))
            {
                MessageBox.Show(@"Please select a .zip file first", _messageBoxCaption);
            }
            else
            {
                if (File.Exists(_backupFileName))
                {
                    RestoreDb();
                }
                else
                {
                    MessageBox.Show(@"The .zip file you specified does not exist!!!", _messageBoxCaption);
                    Logger.LogMessage("The .zip file you specified does not exist." );
                }
            }

            btnRestore.Enabled = false;
            txtFileToRestore.Text = String.Empty;
        }



        private void RestoreDb()
        {
            string[] dbNameFragments = _backupFileName.Split('_');
            string _dbName = dbNameFragments[0].Replace(txtScratchPad.Text, "");

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
                    logRf.PhysicalFileName = _dbFileLocation + _databaseLogFileName;
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

                txtRestoreScript.Text = sql;
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
                Logger.LogMessage($"RestoreDb(): Exception occured. Message: {exc.Message}");
                MessageBox.Show(@"RestoreDb(): Exception occured. Message:" + exc.Message, _messageBoxCaption);
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

        private string GenerateDBBackupFileName(string dbName)
        {
            string dbBackupFileName = string.Format("{6}DB_{0}{1}{2}_{3}{4}{5}",
                DateTime.Now.Year.ToString().PadLeft(4, '0'),
                DateTime.Now.Month.ToString().PadLeft(2, '0'),
                DateTime.Now.Day.ToString().PadLeft(2, '0'),
                DateTime.Now.Hour.ToString().PadLeft(2, '0'),
                DateTime.Now.Minute.ToString().PadLeft(2, '0'),
                DateTime.Now.Second.ToString().PadLeft(2, '0'),
                dbName);
            return dbBackupFileName;
        }

        private void GenerateApplicationFileNames(string dbName)
        {
            string baseFileName = GenerateDBBackupFileName(dbName);

            bool validDirectoryStructures = true;

            if (!Directory.Exists(txtBackupZips.Text))
            {
                Logger.LogMessage("The backup destination directory " + txtBackupZips.Text + " does not exist.");
                validDirectoryStructures = false;
            }

            if (!Directory.Exists(txtScratchPad.Text))
            {
                Logger.LogMessage("The scratch pad directory " + txtScratchPad.Text + " does not exist.");
                validDirectoryStructures = false;
            }

            if (!Directory.Exists(txtScratchPad.Text))
            {
                Logger.LogMessage("The database file directory " + _dbFileLocation + " does not exist.");
                validDirectoryStructures = false;
            }

            if (!validDirectoryStructures)
            {
                cmdShrinkLogFile.Enabled = false;
                btnBackupDb.Enabled = false;
                btnRestore.Enabled = false;
                cmdGetZipFile.Enabled = false;

                MessageBox.Show(
                    @"The directory structures for the application are invlid. Please see log file for details.  Make the changes, recompile then redeploy the application.", _messageBoxCaption);
                Logger.LogMessage("----------");

            }

            _backupFileName = txtScratchPad.Text + baseFileName + ".bak";
            _zipFileName = txtBackupZips.Text + baseFileName + ".zip";
            _databaseFileName = _dbFileLocation + dbName + ".mdf";
            _databaseLogFileName = _dbFileLocation + dbName + "_Log.ldf";

            Logger.LogMessage("Backup File Name: " + _backupFileName);
            Logger.LogMessage("Zip File Name: " + _zipFileName);
            Logger.LogMessage("Database File Name: " + _databaseFileName);
            Logger.LogMessage("Database Log File Name: " + _databaseLogFileName);
            Logger.LogMessage("----------");
        }

        private void MainWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_sqlConn.State == ConnectionState.Open)
            {
                _sqlConn.Close();
            }
            _sqlConn.Dispose();

            CleanUpScratchPadBakFiles();
        }

        private void cmdGetZipFile_Click(object sender, EventArgs e)
        {
            ofdRestoreZips.InitialDirectory = txtBackupZips.Text;
            ofdRestoreZips.RestoreDirectory = true;
            ofdRestoreZips.Title = "Select a .zip file containg the .bak file of the DB to restore";
            ofdRestoreZips.ValidateNames = true;
            ofdRestoreZips.AddExtension = true;
            ofdRestoreZips.Filter = "zip files (*.zip)|";
            ofdRestoreZips.ShowHelp = false;
            ofdRestoreZips.FileName = "";

            DialogResult result = ofdRestoreZips.ShowDialog();
            if (string.IsNullOrEmpty(ofdRestoreZips.FileName))
            {
                MessageBox.Show(@"Please select a .zip file first!!!", _messageBoxCaption);
            }
            else
            {
                if (result == DialogResult.OK)
                {
                    if (RestoreWarning(ofdRestoreZips.FileName))
                    {
                        ExtractBackupFile(ofdRestoreZips.FileName);
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

            for (int i = 0; i < dgvDatabases.Rows.Count; i++)
            {
                DataGridViewRow row = dgvDatabases.Rows[i];
                string value = row.Cells["colDBSelected"].Value.ToString();

                if (value == "true")
                {
                    string databaseName = (string)(dgvDatabases.Rows[i].Cells["colDBName"].Value);
                    ShrinkDatabaseLogFile(databaseName);
                }
            }

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

        private void SaveConfigurationSettings()
        {
            _configurationSettings.Clear();
            _configurationSettings.Add("BackupZips", txtBackupZips.Text);
            _configurationSettings.Add("ScratchPad", txtScratchPad.Text);
            _configurationSettings.Add("DbFileLocations", txtSQLFileLocations.Text);
            _configurationSettings.Add("DevFilesLocation", txtDevFilesLocation.Text);
            _configurationSettings.Add("DevelopmentDirectory", txtDevelopmentZips.Text);
            _configurationSettings.Add("ConnectionString", txtConnectionString.Text);
            _configurationSettings.Add("SourceBackupSkipDLLs", (chkSkipDLLS.Checked)?"false": "true");
            _configurationSettings.Add("LocalRetentionMonths", nudMonths.Value.ToString(CultureInfo.InvariantCulture));
            _configurationSettings.Add("LocalRetentionDays", nudDays.Value.ToString(CultureInfo.InvariantCulture));

            _configurationSettings.Add("EmailUseEmailSettings", (chkConfigureEmails.Checked) ? "true" : "false");
            _configurationSettings.Add("EmailFromEmail", txtFromEmail.Text);
            _configurationSettings.Add("EmailSuccessEmail", txtSuccessEmail.Text);
            _configurationSettings.Add("EmailFailureEmail", txtFailureEmail.Text);
            _configurationSettings.Add("EmailSMTPOutgoingServer", txtSMTPServer.Text);
            _configurationSettings.Add("EmailOutgoingPortNumber", nudEmailOutgoingPortNumber.Value.ToString(CultureInfo.InvariantCulture));
            _configurationSettings.Add("EmailLoginUserName", txtEmailLoginUserName.Text);
            _configurationSettings.Add("EmailLoginUserPassword", txtEmailLoginUserPassword.Text);
            _configurationSettings.Add("EmailRequiresSSL", (chkServerRequiresAuth.Checked) ? "true" : "false");
            _configurationSettings.Add("EmailEnableSSL", (chkEnableSSL.Checked) ? "true" : "false");

            _configurationSettings.Add("FTPUseFTPSettings", (chkFTPUseFTPSettings.Checked) ? "true" : "false");
            _configurationSettings.Add("FTPRetentionMonths", nudFTPMonths.Value.ToString(CultureInfo.InvariantCulture));
            _configurationSettings.Add("FTPRetentionDays", nudFTPDays.Value.ToString(CultureInfo.InvariantCulture));
            _configurationSettings.Add("FTPHostAddress", txtFTPHostAddress.Text);
            _configurationSettings.Add("FTPUserName", txtFTPUserName.Text);
            _configurationSettings.Add("FTPPassword", txtFTPPassword.Text);
            _configurationSettings.Add("FTPPort", nudFTPPort.Value.ToString(CultureInfo.InvariantCulture));
            _configurationSettings.Add("FTPDataConnection", "Passive(PASV)");
            _configurationSettings.Add("FTPRemoteFolder", txtFTPRemoteFolder.Text);
            _configurationSettings.Add("FTPWriteSessionToLog", (chkFTPWriteSessionLog.Checked) ? "true" : "false");

            if (File.Exists(_settingsFileName))
            {
                File.Delete((_settingsFileName));
            }

            FileStream fs = new FileStream(_settingsFileName, FileMode.Append);

            foreach (KeyValuePair<string, string> setting in _configurationSettings)
            {
                // -------------------------------------------------------
                // This time let's encrypt only the data, delimit with a :
                // -------------------------------------------------------
                string encryptedConfigLine = setting.Key + ":" + CryptographyCBC.EncryptString(setting.Value, _encryptionKey) +
                                             Environment.NewLine;
                byte[] bConfigLine = Encoding.Default.GetBytes(encryptedConfigLine);
                fs.Write(bConfigLine, 0, bConfigLine.Length);
            }
            fs.Close();
        }

        private void ReadConfigurationSettings()
        {
            if (File.Exists(_settingsFileName))
            {
                _configurationSettings.Clear();
                string[] configurationLines = File.ReadAllLines(_settingsFileName);
                string configLine = String.Empty;
                string[] splitKeyValue;

                string splitValue;
                string decryptedValue;
                string decryptedKey;


                foreach (string configSettingPair in configurationLines)
                {
                    splitKeyValue = configSettingPair.Split(':');
                    decryptedKey = splitKeyValue[0];

                    splitValue = splitKeyValue[1]; // this is still encrypted
                    decryptedValue = CryptographyCBC.DecryptString(splitValue, _encryptionKey);
                    
                    _configurationSettings.Add(decryptedKey, decryptedValue);
                }

                _configurationSettings.TryGetValue("BackupZips", out string backupZipDirectory);
                txtBackupZips.Text = backupZipDirectory;

                _configurationSettings.TryGetValue("ScratchPad", out string scratchPadDirectory);
                txtScratchPad.Text = scratchPadDirectory;

                _configurationSettings.TryGetValue("DbFileLocations", out string dbFileDirectory);
                txtSQLFileLocations.Text = dbFileDirectory;

                _configurationSettings.TryGetValue("DevFilesLocation", out string devFileLocation);
                txtDevFilesLocation.Text = devFileLocation;

                _configurationSettings.TryGetValue("DevelopmentDirectory", out string developmentDirectory);
                txtDevelopmentZips.Text = developmentDirectory;

                _configurationSettings.TryGetValue("ConnectionString", out string connectionString);
                txtConnectionString.Text = connectionString;
                
                _configurationSettings.TryGetValue("SourceBackupSkipDLLs", out string SourceBackupSkipDLLs);
                chkSkipDLLS.Checked = Convert.ToBoolean(SourceBackupSkipDLLs == "true");

                _configurationSettings.TryGetValue("LocalRetentionMonths", out string months);
                nudMonths.Value = Convert.ToInt32(months);

                _configurationSettings.TryGetValue("LocalRetentionDays", out string days);
                nudDays.Value = Convert.ToInt32(days);

                _configurationSettings.TryGetValue("EmailSuccessEmail", out string successfulEmail);
                txtSuccessEmail.Text = successfulEmail;

                _configurationSettings.TryGetValue("EmailFailureEmail", out string failureEmail);
                txtFailureEmail.Text = failureEmail;

                _configurationSettings.TryGetValue("EmailUseEmailSettings", out string useEMailSettigns);
                chkConfigureEmails.Checked = Convert.ToBoolean(useEMailSettigns == "true");

                _configurationSettings.TryGetValue("EmailFromEmail", out string emailFromEmail);
                txtFromEmail.Text = emailFromEmail;

                _configurationSettings.TryGetValue("EmailSMTPOutgoingServer", out string smtpOutgoingServer);
                txtSMTPServer.Text = smtpOutgoingServer;

                _configurationSettings.TryGetValue("EmailSMTPPort", out string emailSmtpPort);
                nudFTPPort.Value = Convert.ToInt32(emailSmtpPort);

                _configurationSettings.TryGetValue("EmailRequiresSSL", out string emailRequiresSsl);
                chkServerRequiresAuth.Checked = Convert.ToBoolean(emailRequiresSsl == "true");

                _configurationSettings.TryGetValue("EmailEnableSSL", out string emailEnableSsl);
                chkEnableSSL.Checked = Convert.ToBoolean(emailEnableSsl == "true");

                _configurationSettings.TryGetValue("EmailLoginUserName", out string emailLoginUserName);
                txtEmailLoginUserName.Text = emailLoginUserName;

                _configurationSettings.TryGetValue("EmailLoginUserPassword", out string emailLoginUserPassword);
                txtEmailLoginUserPassword.Text = emailLoginUserPassword;
                
                _configurationSettings.TryGetValue("EmailOutgoingPortNumber", out string emailOutgoingPortNumber);
                nudEmailOutgoingPortNumber.Value = Convert.ToInt32(emailOutgoingPortNumber);

                _configurationSettings.TryGetValue("FTPUseFTPSettings", out string ftpUseFtpSettings);
                chkFTPUseFTPSettings.Checked = Convert.ToBoolean(ftpUseFtpSettings == "true");

                _configurationSettings.TryGetValue("FTPRetentionMonths", out string ftpRetentionMonths);
                nudFTPMonths.Value = Convert.ToInt32(ftpRetentionMonths);

                _configurationSettings.TryGetValue("FTPRetentionDays", out string ftpRetentionDays);
                nudFTPDays.Value = Convert.ToInt32(ftpRetentionDays);

                _configurationSettings.TryGetValue("FTPHostAddress", out string ftpHostAddress);
                txtFTPHostAddress.Text = ftpHostAddress;

                _configurationSettings.TryGetValue("FTPUserName", out string ftpUserName);
                txtFTPUserName.Text = ftpUserName;

                _configurationSettings.TryGetValue("FTPPassword", out string ftpPassword);
                txtFTPPassword.Text = ftpPassword;

                _configurationSettings.TryGetValue("FTPPort", out string ftpPort);
                nudFTPPort.Value = Convert.ToInt32(ftpPort);

                _configurationSettings.TryGetValue("FTPRemoteFolder",out string ftpRemoteFolder);
                txtFTPRemoteFolder.Text = ftpRemoteFolder;

                _configurationSettings.TryGetValue("EmailEnableSSL", out string ftpWriteSessionToLog);
                chkFTPWriteSessionLog.Checked = Convert.ToBoolean(ftpWriteSessionToLog == "true");
            }
        }

        private void InitializeConfigurationSettings()
        {

            if (!File.Exists(_settingsFileName))
            {
                _configurationSettings.Add("BackupZips", @"C:\NovantBackups\SQLBackups\");
                _configurationSettings.Add("ScratchPad", @"C:\NovantBackups\Scratch\");
                _configurationSettings.Add("DbFileLocations", @"C:\Program Files\Microsoft SQL Server\MSSQL13.SQLSVR_2016\MSSQL\DATA\");
                _configurationSettings.Add("DevFilesLocation",@"E:\Development\");
                _configurationSettings.Add("DevelopmentZips",@"I:\NovantBackups\");
                _configurationSettings.Add("ConnectionString", "Server=CTB-MAXIMUS-PC;Database=master;Trusted_Connection=True");
                _configurationSettings.Add("SourceBackupSkipDLLs","true");
                _configurationSettings.Add("LocalRetentionMonths", "6");
                _configurationSettings.Add("LocalRetentionDays", "0");

                _configurationSettings.Add("EmailUseEmailSettings", "false");
                _configurationSettings.Add("EmailFromEmail", "no-reply@novantconsulting.com");
                _configurationSettings.Add("EmailSuccessEmail", "ct@novantconsulting.com");
                _configurationSettings.Add("EmailFailureEmail", "ct@novantconsulting.com");
                _configurationSettings.Add("EmailSMTPOutgoingServer", "smtpout.secureserver.net");
                _configurationSettings.Add("EmailOutgoingPortNumber", "25");
                _configurationSettings.Add("EmailLoginUserName", "ct@novantconsulting.com");
                _configurationSettings.Add("EmailLoginUserPassword", "YouDontGetToSeeThis");
                _configurationSettings.Add("EmailRequiresSSL", "true");
                _configurationSettings.Add("EmailEnableSSL", "true");

                _configurationSettings.Add("FTPUseFTPSettings", "false");
                _configurationSettings.Add("FTPRetentionMonths", "6");
                _configurationSettings.Add("FTPRetentionDays", "0");
                _configurationSettings.Add("FTPHostAddress", @"ftp://50.62.160.129");
                _configurationSettings.Add("FTPUserName", "CTBlankenship75");
                _configurationSettings.Add("FTPPassword", "YouDontGetToSeeThis");
                _configurationSettings.Add("FTPPort", "21");
                _configurationSettings.Add("FTPDataConnection", "Passive(PASV)");
                _configurationSettings.Add("FTPRemoteFolder", @"ftp://50.62.160.129/SQLBackups");
                _configurationSettings.Add("FTPWriteSessionToLog", "true");

                FileStream fs = new FileStream(_settingsFileName, FileMode.Append);

                foreach (KeyValuePair<string, string> setting in _configurationSettings)
                {

                    // -------------------------------------------------------
                    // This time let's encrypt only the data, delimit with a :
                    // -------------------------------------------------------
                    string encryptedConfigLine = setting.Key + ":" + CryptographyCBC.EncryptString(setting.Value, _encryptionKey) +
                                                 Environment.NewLine;
                    byte[] bConfigLine = Encoding.Default.GetBytes(encryptedConfigLine);
                    fs.Write(bConfigLine, 0, bConfigLine.Length);
                }
                fs.Close();
            }
        }

        private void cmdBackupZips_Click(object sender, EventArgs e)
        {
            fbdBackupZips.SelectedPath = txtBackupZips.Text;
            fbdBackupZips.ShowNewFolderButton = true;
            fbdBackupZips.Description = "Select a path to store the backup .zip files";
            if (fbdBackupZips.ShowDialog() == DialogResult.OK)
            {
                txtBackupZips.Text = fbdBackupZips.SelectedPath + @"\";
            }
        }

        private void cmdScratch_Click(object sender, EventArgs e)
        {
            fbdScratch.SelectedPath = txtScratchPad.Text;
            fbdScratch.ShowNewFolderButton = true;
            fbdBackupZips.Description = "Select a path to store temporary .bak files";
            if (fbdScratch.ShowDialog() == DialogResult.OK)
            {
                txtScratchPad.Text = fbdScratch.SelectedPath + @"\";
            }
        }

        private void cmdSQLDBFiles_Click(object sender, EventArgs e)
        {
            fbdSQLDBFiles.SelectedPath = _dbFileLocation;
            fbdSQLDBFiles.ShowNewFolderButton = true;
            fbdSQLDBFiles.Description = "Select the location of the SQL Server data files";
            if (fbdSQLDBFiles.ShowDialog() == DialogResult.OK)
            {
                txtSQLFileLocations.Text = fbdSQLDBFiles.SelectedPath + @"\";
            }
        }

        private void cmdSendTestEmail_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient smtp = new SmtpClient
                {
                    Host = txtSMTPServer.Text,
                    Port = 25, //Convert.ToInt32(nudEmailOutgoingPortNumber.Value),
                    EnableSsl = chkEnableSSL.Checked,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(txtEmailLoginUserName.Text, txtEmailLoginUserPassword.Text),
                    Timeout = 30000, // 30 seconds
                    DeliveryMethod = SmtpDeliveryMethod.Network
                };

                MailMessage message = new MailMessage
                {
                    From = new MailAddress(txtFromEmail.Text),
                    Subject = "Test message from SQL Backup / Restore Utility",
                    IsBodyHtml = true,
                    Body = "This is a test ... and only a test!"
                };
                message.To.Add(new MailAddress(txtSuccessEmail.Text));

                txtLogFile.Text += "Test message send begun ..." + Environment.NewLine;
                Logger.LogMessage("Test message send begun ...");

                // ================
                smtp.Send(message);
                // ================

                txtLogFile.Text += "Test message send complete ... success!" + Environment.NewLine;
                Logger.LogMessage("Test message send complete ... success!");
                Logger.LogMessage("----------");
            }
            catch (Exception ex)
            {
                txtLogFile.Text += "Test message attempt failed!" + Environment.NewLine; 
                txtLogFile.Text += ex.ToString() + Environment.NewLine;
                Logger.LogMessage("Test meesage attempt failed!");
                Logger.LogMessage(ex.ToString());
                Logger.LogMessage("----------");

                MessageBox.Show(ex.ToString(), _messageBoxCaption);
            }
        }

        private void cmdBrowseDevelopmentDirectories_Click(object sender, EventArgs e)
        {
            fbdDevFileLocations.SelectedPath = Environment.CurrentDirectory;
            fbdDevFileLocations.ShowNewFolderButton = false;
            fbdDevFileLocations.Description = "Select the location of your development files";
            if (fbdDevFileLocations.ShowDialog() == DialogResult.OK)
            {
                txtDevelopmentZips.Text = fbdDevFileLocations.SelectedPath + @"\";
                _devFilesLocation = txtSQLFileLocations.Text;
                BuildDevelopmentDirectoriesTreeView();
            }
        }

        private void BuildDevelopmentDirectoriesTreeView()
        {
            if (Directory.Exists(_devFilesLocation))
            {
                var directories = Directory.GetDirectories(_devFilesLocation);
            }
        }

        private void cmdTestFTPTransfer_Click(object sender, EventArgs e)
        {
            progBar.Visible = true;
            progBar.Value = 0;
            _configurationSettings.TryGetValue("FTPUserName", out string FTPUserName);
            _configurationSettings.TryGetValue("FTPUserPassword", out string FTPUserPassword);

            try
            {
                WebClient client = new WebClient();
                client.Credentials = new NetworkCredential(txtFTPUserName.Text, txtFTPPassword.Text);
                client.UploadProgressChanged += new UploadProgressChangedEventHandler(UploadProgressChangedEventHandler);
                client.UploadFileCompleted += new UploadFileCompletedEventHandler(UploadFileCompletedEventHandler);
                progBar.Visible = true;
                progBar.Value = 0;
                client.UploadFileAsync( new Uri(@"ftp://novantconsulting.com/SQLBackups/Novant/StrataFrame.bak"), @"E:\Strataframe.bak");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void UploadProgressChangedEventHandler(object sender, UploadProgressChangedEventArgs e)
        {
            progBar.Value = e.ProgressPercentage;
        }

        private void UploadFileCompletedEventHandler(object sender, UploadFileCompletedEventArgs e)
        {
            progBar.Value = 100;
            if (MessageBox.Show(@"Upload completed!!!", _messageBoxCaption) == DialogResult.OK)
            {
                progBar.Visible = false;
            }
        }

        private void LoadDevelopmentDirectories()
        {
            if (Directory.Exists(_devFilesLocation))
            {
                string[] directories = Directory.GetDirectories(_devFilesLocation);
                foreach (string directory in directories)
                {
                    dgvDevelopmentDirectories.Rows.Add(0, directory);
                }
            }
        }

        private void cmdBackupDevelopmentDirectories_Click(object sender, EventArgs e)
        {
            try
            {
                CopyEachDevelopmentDirectory();
                CreateDevelopmentZipFiles();
                DeleteScratchFiles();
                MessageBox.Show(@"Backup of development complete!!!", _messageBoxCaption);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void CopyEachDevelopmentDirectory()
        {

            for (int i = 0; i < dgvDevelopmentDirectories.Rows.Count; i++)
            {
                DataGridViewRow row = dgvDevelopmentDirectories.Rows[i];
                string value  = row.Cells["colSelected"].Value.ToString();

                if (value=="true")
                {
                    string sourceDirectoryName = (string)(dgvDevelopmentDirectories.Rows[i].Cells["colDirectoryName"].Value);
                    string destinationDirectoryName = txtScratchPad.Text + sourceDirectoryName.Substring(3) + @"\";

                    if (!Directory.Exists(destinationDirectoryName))
                    {
                        Directory.CreateDirectory(destinationDirectoryName);
                    }
                    CopyFolderContents(sourceDirectoryName, destinationDirectoryName);
                }
            }
        }

        private bool CopyFolderContents(string SourcePath, string DestinationPath)
        {
            SourcePath = SourcePath.EndsWith(@"\") ? SourcePath : SourcePath + @"\";
            DestinationPath = DestinationPath.EndsWith(@"\") ? DestinationPath : DestinationPath + @"\";

            try
            {
                if (Directory.Exists(SourcePath))
                {
                    if (Directory.Exists(DestinationPath) == false)
                    {
                        Directory.CreateDirectory(DestinationPath);
                    }

                    foreach (string file in Directory.GetFiles(SourcePath))
                    {
                        FileInfo fileInfo = new FileInfo(file) {IsReadOnly = false};

                        if ( fileInfo.Name.Contains(".dll") || fileInfo.Name.Contains(".pdb"))
                        {
                            if (chkSkipDLLS.Checked)
                            {
                                // ------------------------------------------
                                //Don't do anything ... skip all .dlls files'
                                // ------------------------------------------
                            }
                            else if (chkSkipPDBFiles.Checked)
                            {
                                // ------------------------------------------
                                // Don't do anything ... skip all .pdb files'
                                // ------------------------------------------
                            }
                            else
                            {
                                // -------------------------------------------------------
                                // Copy the file as if none of the checkboxes were checked
                                // -------------------------------------------------------
                                fileInfo.CopyTo(string.Format(@"{0}\{1}", DestinationPath, fileInfo.Name), true);
                            }
                        }
                        else 
                        {
                            fileInfo.CopyTo(string.Format(@"{0}\{1}", DestinationPath, fileInfo.Name), true);
                        }
                    }

                    foreach (string drs in Directory.GetDirectories(SourcePath))
                    {
                        DirectoryInfo directoryInfo = new DirectoryInfo(drs);
                        if (CopyFolderContents(drs, DestinationPath + directoryInfo.Name) == false)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string blah = ex.ToString();
                return false;
            }
        }

        private void CreateDevelopmentZipFileNames()
        {
            _archiveFileName = _developmentZips + string.Format("{6}DEV_{0}{1}{2}_{3}{4}{5}",
                                   DateTime.Now.Year.ToString().PadLeft(4, '0'),
                                   DateTime.Now.Month.ToString().PadLeft(2, '0'),
                                   DateTime.Now.Day.ToString().PadLeft(2, '0'),
                                   DateTime.Now.Hour.ToString().PadLeft(2, '0'),
                                   DateTime.Now.Minute.ToString().PadLeft(2, '0'),
                                   DateTime.Now.Second.ToString().PadLeft(2, '0') + ".zip",
                                   "DevelopmentBackup");

            txtDevZipName.Text = _archiveFileName;
        }

        private void CreateDevelopmentZipFiles()
        {

            ZipFile.CreateFromDirectory(txtScratchPad.Text, txtDevZipName.Text);

        }

        private void DeleteScratchFiles()
        {
            string message = "You are about to delete all of the directories and files in the " + txtScratchPad.Text +
                             " directory.  Are you sure you want to do this?";
            if (MessageBox.Show(message, _messageBoxCaption, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (string directory in Directory.GetDirectories(txtScratchPad.Text))
                {
                    DeleteDirectory(directory);
                }
            }
        }

        private void DeleteDirectory(string path)
        {
            if (Directory.Exists(path))
            {
                try
                {
                    foreach (string file in Directory.GetFiles(path))
                    {
                        File.Delete(file);
                    }
                    //Delete all child Directories
                    foreach (string directory in Directory.GetDirectories(path))
                    {
                        DeleteDirectory(directory);
                    }
                    //Delete a Directory
                    Directory.Delete(path);
                }
                catch (Exception e)
                {
                    throw;
                }
            }
        }

        private void saveToolstripMenuItem_Click(object sender, EventArgs e)
        {
            SaveConfigurationSettings();
        }

        private void tacMain_Selected(object sender, TabControlEventArgs e)
        {
            if (tacMain.SelectedIndex == 2)
            {
                CreateDevelopmentZipFileNames();
            }
        }

        private void cmdDevFilesLocation_Click(object sender, EventArgs e)
        {
            fbdDevFileLocations.SelectedPath = Environment.CurrentDirectory;
            fbdDevFileLocations.ShowNewFolderButton = false;
            fbdDevFileLocations.Description = "Select the location of your development backup .zip files";
            if (fbdDevFileLocations.ShowDialog() == DialogResult.OK)
            {
                txtDevFilesLocation.Text = fbdDevFileLocations.SelectedPath + @"\";
                _devFilesLocation = txtDevFilesLocation.Text;
                BuildDevelopmentDirectoriesTreeView();
            }
        }

        private void cmdDevelopmentZips_Click(object sender, EventArgs e)
        {
            fbdDevelopmentZips.SelectedPath = Environment.CurrentDirectory;
            fbdDevelopmentZips.ShowNewFolderButton = false;
            fbdDevelopmentZips.Description = "Select the location of your development backup .zip files";
            if (fbdDevelopmentZips.ShowDialog() == DialogResult.OK)
            {
                txtDevelopmentZips.Text = fbdDevelopmentZips.SelectedPath + @"\";
                _developmentZips = txtDevelopmentZips.Text;
                BuildDevelopmentDirectoriesTreeView();
            }
        }

        private void dbdDevZipDirectory_HelpRequest(object sender, EventArgs e)
        {

        }

        private void cmdConfigureConn_Click(object sender, EventArgs e)
        {
            using (frmConfigureSqlConn oCSN = new frmConfigureSqlConn())
            {
                oCSN.ShowDialog();
                if (oCSN.ConnectionString != String.Empty)
                {
                    _sqlConn = new SqlConnection(oCSN.ConnectionString);
                    _sqlServer = new Server(new ServerConnection(_sqlConn));
                    PopulateGridWithDatabasesToBeBackedUp();
                }
            }
        }
    }
}
