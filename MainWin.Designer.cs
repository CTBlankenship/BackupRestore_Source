namespace NC.Util.SqlSrv.BackupRestore
{
    partial class MainWin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
            this.openBakFile = new System.Windows.Forms.OpenFileDialog();
            this.saveBakFile = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progBar = new System.Windows.Forms.ToolStripProgressBar();
            this.ofdRestoreZips = new System.Windows.Forms.OpenFileDialog();
            this.txtLogFile = new System.Windows.Forms.TextBox();
            this.lblLogFile = new System.Windows.Forms.Label();
            this.cmdShow = new System.Windows.Forms.Button();
            this.cmdViewInNotepad = new System.Windows.Forms.Button();
            this.tacMain = new System.Windows.Forms.TabControl();
            this.tabBackupRestore = new System.Windows.Forms.TabPage();
            this.grpBackup = new System.Windows.Forms.GroupBox();
            this.lblBackupScript = new System.Windows.Forms.Label();
            this.txtBackupScript = new System.Windows.Forms.TextBox();
            this.cmdShrinkLogFile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbBackupMode = new System.Windows.Forms.ComboBox();
            this.btnBackupDb = new System.Windows.Forms.Button();
            this.txtFileToBackUp = new System.Windows.Forms.TextBox();
            this.cmbBackupDb = new System.Windows.Forms.ComboBox();
            this.lblBackupMode = new System.Windows.Forms.Label();
            this.lblBackupFileName = new System.Windows.Forms.Label();
            this.lblDb = new System.Windows.Forms.Label();
            this.tabRestore = new System.Windows.Forms.TabPage();
            this.grpRestore = new System.Windows.Forms.GroupBox();
            this.lblRestoreScript = new System.Windows.Forms.Label();
            this.txtRestoreScript = new System.Windows.Forms.TextBox();
            this.cmdGetZipFile = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chckReplace = new System.Windows.Forms.CheckBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.txtFileToRestore = new System.Windows.Forms.TextBox();
            this.lblBackupFile = new System.Windows.Forms.Label();
            this.tabConfiguration = new System.Windows.Forms.TabPage();
            this.grpEmailConfiguration = new System.Windows.Forms.GroupBox();
            this.chkConfigureEmails = new System.Windows.Forms.CheckBox();
            this.cmdSendTestEmail = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmailLoginUserPassword = new System.Windows.Forms.TextBox();
            this.lblUserNameEmail = new System.Windows.Forms.Label();
            this.txtEmailLoginUserName = new System.Windows.Forms.TextBox();
            this.lblSMTPServer = new System.Windows.Forms.Label();
            this.lblFromEmail = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.chkEnableSSL = new System.Windows.Forms.CheckBox();
            this.chkServerRequiresAuth = new System.Windows.Forms.CheckBox();
            this.nudPort = new System.Windows.Forms.NumericUpDown();
            this.txtSMTPServer = new System.Windows.Forms.TextBox();
            this.txtFromEmail = new System.Windows.Forms.TextBox();
            this.lblSuccessEmail = new System.Windows.Forms.Label();
            this.lblFailureEmail = new System.Windows.Forms.Label();
            this.txtFailureEmail = new System.Windows.Forms.TextBox();
            this.txtSuccessEmail = new System.Windows.Forms.TextBox();
            this.lblMonths = new System.Windows.Forms.Label();
            this.gbWorkingDirectories = new System.Windows.Forms.GroupBox();
            this.cmdSQLDBFiles = new System.Windows.Forms.Button();
            this.cmdScratch = new System.Windows.Forms.Button();
            this.cmdBackupZips = new System.Windows.Forms.Button();
            this.lblSqlDBFiles = new System.Windows.Forms.Label();
            this.lblBackupZips = new System.Windows.Forms.Label();
            this.lblScratch = new System.Windows.Forms.Label();
            this.txtBackupZips = new System.Windows.Forms.TextBox();
            this.txtScratchPad = new System.Windows.Forms.TextBox();
            this.txtSQLFileLocations = new System.Windows.Forms.TextBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.nudDays = new System.Windows.Forms.NumericUpDown();
            this.nudMonths = new System.Windows.Forms.NumericUpDown();
            this.lblHowLongTokeep = new System.Windows.Forms.Label();
            this.fbdBackupZips = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdSQLDBFiles = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdScratch = new System.Windows.Forms.FolderBrowserDialog();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.lblConnection = new System.Windows.Forms.Label();
            this.cmdConfigureConn = new System.Windows.Forms.Button();
            this.tabFTPSchduler = new System.Windows.Forms.TabPage();
            this.grbFTP = new System.Windows.Forms.GroupBox();
            this.lblFTPMonths = new System.Windows.Forms.Label();
            this.lblFTPDays = new System.Windows.Forms.Label();
            this.nudFTPDays = new System.Windows.Forms.NumericUpDown();
            this.nudFTPMonths = new System.Windows.Forms.NumericUpDown();
            this.lblHowLogToKeepFTPFiles = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblFTPHostAddress = new System.Windows.Forms.Label();
            this.lblFTPExample = new System.Windows.Forms.Label();
            this.lblFTPUserName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblFTPPassword = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.nudFTPPort = new System.Windows.Forms.NumericUpDown();
            this.lblFTPPort = new System.Windows.Forms.Label();
            this.cboDataConnection = new System.Windows.Forms.ComboBox();
            this.lblRemoteFolder = new System.Windows.Forms.Label();
            this.txtRemoteFolder = new System.Windows.Forms.TextBox();
            this.chkUseFTP = new System.Windows.Forms.CheckBox();
            this.chkWriteFTPSessionLog = new System.Windows.Forms.CheckBox();
            this.lblDataConnection = new System.Windows.Forms.Label();
            this.grpScheduleJog = new System.Windows.Forms.GroupBox();
            this.chkScheduleToRunDaily = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblJobStart = new System.Windows.Forms.Label();
            this.lblWTSJobStart = new System.Windows.Forms.Label();
            this.nudEmailOutgoingPortNumber = new System.Windows.Forms.NumericUpDown();
            this.lblEmailOutgoingPortNumber = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.tacMain.SuspendLayout();
            this.tabBackupRestore.SuspendLayout();
            this.grpBackup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabRestore.SuspendLayout();
            this.grpRestore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabConfiguration.SuspendLayout();
            this.grpEmailConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            this.gbWorkingDirectories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonths)).BeginInit();
            this.tabFTPSchduler.SuspendLayout();
            this.grbFTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFTPDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFTPMonths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFTPPort)).BeginInit();
            this.grpScheduleJog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmailOutgoingPortNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // openBakFile
            // 
            this.openBakFile.Filter = "Backup Files (*.bak, *.trn)|*.bak;*.trn|All files (*)|*.*";
            this.openBakFile.Title = "Select Backup File";
            this.openBakFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openBakFile_FileOk);
            // 
            // saveBakFile
            // 
            this.saveBakFile.Filter = "Backup Files (*.bak, *.trn)|*.bak;*.trn|All files (*)|*.*";
            this.saveBakFile.Title = "Select file for saving backup";
            this.saveBakFile.FileOk += new System.ComponentModel.CancelEventHandler(this.saveBakFile_FileOk);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.progBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 508);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(605, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(54, 20);
            this.toolStripSplitButton1.Text = "Menu";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // progBar
            // 
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(250, 16);
            this.progBar.Visible = false;
            // 
            // ofdRestoreZips
            // 
            this.ofdRestoreZips.FileName = "openFileDialog1";
            // 
            // txtLogFile
            // 
            this.txtLogFile.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogFile.Location = new System.Drawing.Point(16, 382);
            this.txtLogFile.Multiline = true;
            this.txtLogFile.Name = "txtLogFile";
            this.txtLogFile.ReadOnly = true;
            this.txtLogFile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLogFile.Size = new System.Drawing.Size(572, 109);
            this.txtLogFile.TabIndex = 4;
            this.txtLogFile.WordWrap = false;
            // 
            // lblLogFile
            // 
            this.lblLogFile.AutoSize = true;
            this.lblLogFile.Location = new System.Drawing.Point(16, 359);
            this.lblLogFile.Name = "lblLogFile";
            this.lblLogFile.Size = new System.Drawing.Size(40, 13);
            this.lblLogFile.TabIndex = 5;
            this.lblLogFile.Text = "LogFile";
            // 
            // cmdShow
            // 
            this.cmdShow.Location = new System.Drawing.Point(60, 355);
            this.cmdShow.Name = "cmdShow";
            this.cmdShow.Size = new System.Drawing.Size(75, 23);
            this.cmdShow.TabIndex = 6;
            this.cmdShow.Text = "Show";
            this.cmdShow.UseVisualStyleBackColor = true;
            this.cmdShow.Click += new System.EventHandler(this.cmdShow_Click);
            // 
            // cmdViewInNotepad
            // 
            this.cmdViewInNotepad.Location = new System.Drawing.Point(141, 355);
            this.cmdViewInNotepad.Name = "cmdViewInNotepad";
            this.cmdViewInNotepad.Size = new System.Drawing.Size(113, 23);
            this.cmdViewInNotepad.TabIndex = 7;
            this.cmdViewInNotepad.Text = "View In Notepad";
            this.cmdViewInNotepad.UseVisualStyleBackColor = true;
            this.cmdViewInNotepad.Click += new System.EventHandler(this.cmdViewInNotepad_Click);
            // 
            // tacMain
            // 
            this.tacMain.Controls.Add(this.tabBackupRestore);
            this.tacMain.Controls.Add(this.tabRestore);
            this.tacMain.Controls.Add(this.tabConfiguration);
            this.tacMain.Controls.Add(this.tabFTPSchduler);
            this.tacMain.Location = new System.Drawing.Point(12, 12);
            this.tacMain.Name = "tacMain";
            this.tacMain.SelectedIndex = 0;
            this.tacMain.Size = new System.Drawing.Size(580, 337);
            this.tacMain.TabIndex = 8;
            // 
            // tabBackupRestore
            // 
            this.tabBackupRestore.Controls.Add(this.grpBackup);
            this.tabBackupRestore.Location = new System.Drawing.Point(4, 22);
            this.tabBackupRestore.Name = "tabBackupRestore";
            this.tabBackupRestore.Padding = new System.Windows.Forms.Padding(3);
            this.tabBackupRestore.Size = new System.Drawing.Size(572, 311);
            this.tabBackupRestore.TabIndex = 0;
            this.tabBackupRestore.Text = "Backup";
            this.tabBackupRestore.UseVisualStyleBackColor = true;
            // 
            // grpBackup
            // 
            this.grpBackup.Controls.Add(this.cmdConfigureConn);
            this.grpBackup.Controls.Add(this.lblConnection);
            this.grpBackup.Controls.Add(this.txtConnectionString);
            this.grpBackup.Controls.Add(this.lblBackupScript);
            this.grpBackup.Controls.Add(this.txtBackupScript);
            this.grpBackup.Controls.Add(this.cmdShrinkLogFile);
            this.grpBackup.Controls.Add(this.pictureBox1);
            this.grpBackup.Controls.Add(this.cmbBackupMode);
            this.grpBackup.Controls.Add(this.btnBackupDb);
            this.grpBackup.Controls.Add(this.txtFileToBackUp);
            this.grpBackup.Controls.Add(this.cmbBackupDb);
            this.grpBackup.Controls.Add(this.lblBackupMode);
            this.grpBackup.Controls.Add(this.lblBackupFileName);
            this.grpBackup.Controls.Add(this.lblDb);
            this.grpBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBackup.Location = new System.Drawing.Point(3, 3);
            this.grpBackup.Name = "grpBackup";
            this.grpBackup.Size = new System.Drawing.Size(566, 305);
            this.grpBackup.TabIndex = 1;
            this.grpBackup.TabStop = false;
            this.grpBackup.Text = "Backup";
            // 
            // lblBackupScript
            // 
            this.lblBackupScript.AutoSize = true;
            this.lblBackupScript.Location = new System.Drawing.Point(13, 195);
            this.lblBackupScript.Name = "lblBackupScript";
            this.lblBackupScript.Size = new System.Drawing.Size(71, 13);
            this.lblBackupScript.TabIndex = 12;
            this.lblBackupScript.Text = "Backup Script";
            // 
            // txtBackupScript
            // 
            this.txtBackupScript.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackupScript.Location = new System.Drawing.Point(10, 213);
            this.txtBackupScript.Multiline = true;
            this.txtBackupScript.Name = "txtBackupScript";
            this.txtBackupScript.ReadOnly = true;
            this.txtBackupScript.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBackupScript.Size = new System.Drawing.Size(545, 80);
            this.txtBackupScript.TabIndex = 11;
            // 
            // cmdShrinkLogFile
            // 
            this.cmdShrinkLogFile.Location = new System.Drawing.Point(136, 159);
            this.cmdShrinkLogFile.Name = "cmdShrinkLogFile";
            this.cmdShrinkLogFile.Size = new System.Drawing.Size(96, 23);
            this.cmdShrinkLogFile.TabIndex = 7;
            this.cmdShrinkLogFile.Text = "Shrink Log File";
            this.cmdShrinkLogFile.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NC.Util.SqlSrv.BackupRestore.Properties.Resources.database_down;
            this.pictureBox1.Location = new System.Drawing.Point(10, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // cmbBackupMode
            // 
            this.cmbBackupMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBackupMode.Enabled = false;
            this.cmbBackupMode.FormattingEnabled = true;
            this.cmbBackupMode.Items.AddRange(new object[] {
            "Overwrite",
            "Append"});
            this.cmbBackupMode.Location = new System.Drawing.Point(136, 129);
            this.cmbBackupMode.Name = "cmbBackupMode";
            this.cmbBackupMode.Size = new System.Drawing.Size(125, 21);
            this.cmbBackupMode.TabIndex = 5;
            // 
            // btnBackupDb
            // 
            this.btnBackupDb.Location = new System.Drawing.Point(236, 159);
            this.btnBackupDb.Name = "btnBackupDb";
            this.btnBackupDb.Size = new System.Drawing.Size(67, 23);
            this.btnBackupDb.TabIndex = 3;
            this.btnBackupDb.Text = "Backup";
            this.btnBackupDb.UseVisualStyleBackColor = true;
            // 
            // txtFileToBackUp
            // 
            this.txtFileToBackUp.Location = new System.Drawing.Point(136, 102);
            this.txtFileToBackUp.Name = "txtFileToBackUp";
            this.txtFileToBackUp.ReadOnly = true;
            this.txtFileToBackUp.Size = new System.Drawing.Size(423, 21);
            this.txtFileToBackUp.TabIndex = 2;
            // 
            // cmbBackupDb
            // 
            this.cmbBackupDb.DisplayMember = "Name";
            this.cmbBackupDb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBackupDb.FormattingEnabled = true;
            this.cmbBackupDb.Location = new System.Drawing.Point(136, 75);
            this.cmbBackupDb.Name = "cmbBackupDb";
            this.cmbBackupDb.Size = new System.Drawing.Size(184, 21);
            this.cmbBackupDb.TabIndex = 1;
            this.cmbBackupDb.ValueMember = "ID";
            this.cmbBackupDb.SelectionChangeCommitted += new System.EventHandler(this.cmbBackupDb_SelectionChangeCommitted);
            // 
            // lblBackupMode
            // 
            this.lblBackupMode.AutoSize = true;
            this.lblBackupMode.Location = new System.Drawing.Point(56, 132);
            this.lblBackupMode.Name = "lblBackupMode";
            this.lblBackupMode.Size = new System.Drawing.Size(74, 13);
            this.lblBackupMode.TabIndex = 0;
            this.lblBackupMode.Text = "Backup mode:";
            // 
            // lblBackupFileName
            // 
            this.lblBackupFileName.AutoSize = true;
            this.lblBackupFileName.Location = new System.Drawing.Point(36, 105);
            this.lblBackupFileName.Name = "lblBackupFileName";
            this.lblBackupFileName.Size = new System.Drawing.Size(94, 13);
            this.lblBackupFileName.TabIndex = 0;
            this.lblBackupFileName.Text = "Backup File Name:";
            // 
            // lblDb
            // 
            this.lblDb.AutoSize = true;
            this.lblDb.Location = new System.Drawing.Point(75, 78);
            this.lblDb.Name = "lblDb";
            this.lblDb.Size = new System.Drawing.Size(55, 13);
            this.lblDb.TabIndex = 0;
            this.lblDb.Text = "Select db:";
            // 
            // tabRestore
            // 
            this.tabRestore.Controls.Add(this.grpRestore);
            this.tabRestore.Location = new System.Drawing.Point(4, 22);
            this.tabRestore.Name = "tabRestore";
            this.tabRestore.Padding = new System.Windows.Forms.Padding(3);
            this.tabRestore.Size = new System.Drawing.Size(572, 311);
            this.tabRestore.TabIndex = 1;
            this.tabRestore.Text = "Restore";
            this.tabRestore.UseVisualStyleBackColor = true;
            // 
            // grpRestore
            // 
            this.grpRestore.Controls.Add(this.lblRestoreScript);
            this.grpRestore.Controls.Add(this.txtRestoreScript);
            this.grpRestore.Controls.Add(this.cmdGetZipFile);
            this.grpRestore.Controls.Add(this.pictureBox2);
            this.grpRestore.Controls.Add(this.chckReplace);
            this.grpRestore.Controls.Add(this.btnRestore);
            this.grpRestore.Controls.Add(this.txtFileToRestore);
            this.grpRestore.Controls.Add(this.lblBackupFile);
            this.grpRestore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRestore.Location = new System.Drawing.Point(3, 3);
            this.grpRestore.Name = "grpRestore";
            this.grpRestore.Size = new System.Drawing.Size(566, 305);
            this.grpRestore.TabIndex = 2;
            this.grpRestore.TabStop = false;
            this.grpRestore.Text = "Restore";
            // 
            // lblRestoreScript
            // 
            this.lblRestoreScript.AutoSize = true;
            this.lblRestoreScript.Location = new System.Drawing.Point(13, 187);
            this.lblRestoreScript.Name = "lblRestoreScript";
            this.lblRestoreScript.Size = new System.Drawing.Size(75, 13);
            this.lblRestoreScript.TabIndex = 14;
            this.lblRestoreScript.Text = "Restore Script";
            // 
            // txtRestoreScript
            // 
            this.txtRestoreScript.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestoreScript.Location = new System.Drawing.Point(10, 205);
            this.txtRestoreScript.Multiline = true;
            this.txtRestoreScript.Name = "txtRestoreScript";
            this.txtRestoreScript.ReadOnly = true;
            this.txtRestoreScript.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRestoreScript.Size = new System.Drawing.Size(542, 80);
            this.txtRestoreScript.TabIndex = 13;
            // 
            // cmdGetZipFile
            // 
            this.cmdGetZipFile.Location = new System.Drawing.Point(83, 59);
            this.cmdGetZipFile.Name = "cmdGetZipFile";
            this.cmdGetZipFile.Size = new System.Drawing.Size(139, 23);
            this.cmdGetZipFile.TabIndex = 7;
            this.cmdGetZipFile.Text = "Select Bakup Zip File";
            this.cmdGetZipFile.UseVisualStyleBackColor = true;
            this.cmdGetZipFile.Click += new System.EventHandler(this.cmdGetZipFile_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NC.Util.SqlSrv.BackupRestore.Properties.Resources.database_up;
            this.pictureBox2.Location = new System.Drawing.Point(10, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // chckReplace
            // 
            this.chckReplace.AutoSize = true;
            this.chckReplace.Checked = true;
            this.chckReplace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckReplace.Enabled = false;
            this.chckReplace.Location = new System.Drawing.Point(83, 118);
            this.chckReplace.Name = "chckReplace";
            this.chckReplace.Size = new System.Drawing.Size(64, 17);
            this.chckReplace.TabIndex = 5;
            this.chckReplace.Text = "Replace";
            this.chckReplace.UseVisualStyleBackColor = true;
            // 
            // btnRestore
            // 
            this.btnRestore.Enabled = false;
            this.btnRestore.Location = new System.Drawing.Point(153, 115);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(67, 23);
            this.btnRestore.TabIndex = 3;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            // 
            // txtFileToRestore
            // 
            this.txtFileToRestore.Location = new System.Drawing.Point(83, 88);
            this.txtFileToRestore.Name = "txtFileToRestore";
            this.txtFileToRestore.ReadOnly = true;
            this.txtFileToRestore.Size = new System.Drawing.Size(459, 21);
            this.txtFileToRestore.TabIndex = 2;
            // 
            // lblBackupFile
            // 
            this.lblBackupFile.AutoSize = true;
            this.lblBackupFile.Location = new System.Drawing.Point(14, 92);
            this.lblBackupFile.Name = "lblBackupFile";
            this.lblBackupFile.Size = new System.Drawing.Size(64, 13);
            this.lblBackupFile.TabIndex = 0;
            this.lblBackupFile.Text = "Backup File:";
            // 
            // tabConfiguration
            // 
            this.tabConfiguration.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabConfiguration.Controls.Add(this.grpEmailConfiguration);
            this.tabConfiguration.Controls.Add(this.lblMonths);
            this.tabConfiguration.Controls.Add(this.gbWorkingDirectories);
            this.tabConfiguration.Controls.Add(this.lblDays);
            this.tabConfiguration.Controls.Add(this.nudDays);
            this.tabConfiguration.Controls.Add(this.nudMonths);
            this.tabConfiguration.Controls.Add(this.lblHowLongTokeep);
            this.tabConfiguration.Location = new System.Drawing.Point(4, 22);
            this.tabConfiguration.Name = "tabConfiguration";
            this.tabConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfiguration.Size = new System.Drawing.Size(572, 311);
            this.tabConfiguration.TabIndex = 2;
            this.tabConfiguration.Text = "Configuration (Directories and Email)";
            // 
            // grpEmailConfiguration
            // 
            this.grpEmailConfiguration.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpEmailConfiguration.Controls.Add(this.lblEmailOutgoingPortNumber);
            this.grpEmailConfiguration.Controls.Add(this.nudEmailOutgoingPortNumber);
            this.grpEmailConfiguration.Controls.Add(this.chkConfigureEmails);
            this.grpEmailConfiguration.Controls.Add(this.cmdSendTestEmail);
            this.grpEmailConfiguration.Controls.Add(this.lblPassword);
            this.grpEmailConfiguration.Controls.Add(this.txtEmailLoginUserPassword);
            this.grpEmailConfiguration.Controls.Add(this.lblUserNameEmail);
            this.grpEmailConfiguration.Controls.Add(this.txtEmailLoginUserName);
            this.grpEmailConfiguration.Controls.Add(this.lblSMTPServer);
            this.grpEmailConfiguration.Controls.Add(this.lblFromEmail);
            this.grpEmailConfiguration.Controls.Add(this.lblPort);
            this.grpEmailConfiguration.Controls.Add(this.chkEnableSSL);
            this.grpEmailConfiguration.Controls.Add(this.chkServerRequiresAuth);
            this.grpEmailConfiguration.Controls.Add(this.nudPort);
            this.grpEmailConfiguration.Controls.Add(this.txtSMTPServer);
            this.grpEmailConfiguration.Controls.Add(this.txtFromEmail);
            this.grpEmailConfiguration.Controls.Add(this.lblSuccessEmail);
            this.grpEmailConfiguration.Controls.Add(this.lblFailureEmail);
            this.grpEmailConfiguration.Controls.Add(this.txtFailureEmail);
            this.grpEmailConfiguration.Controls.Add(this.txtSuccessEmail);
            this.grpEmailConfiguration.Location = new System.Drawing.Point(7, 155);
            this.grpEmailConfiguration.Name = "grpEmailConfiguration";
            this.grpEmailConfiguration.Size = new System.Drawing.Size(556, 145);
            this.grpEmailConfiguration.TabIndex = 23;
            this.grpEmailConfiguration.TabStop = false;
            this.grpEmailConfiguration.Text = "Email Configuration";
            // 
            // chkConfigureEmails
            // 
            this.chkConfigureEmails.AutoSize = true;
            this.chkConfigureEmails.Location = new System.Drawing.Point(109, 1);
            this.chkConfigureEmails.Name = "chkConfigureEmails";
            this.chkConfigureEmails.Size = new System.Drawing.Size(15, 14);
            this.chkConfigureEmails.TabIndex = 43;
            this.chkConfigureEmails.UseVisualStyleBackColor = true;
            // 
            // cmdSendTestEmail
            // 
            this.cmdSendTestEmail.Location = new System.Drawing.Point(6, 112);
            this.cmdSendTestEmail.Name = "cmdSendTestEmail";
            this.cmdSendTestEmail.Size = new System.Drawing.Size(149, 23);
            this.cmdSendTestEmail.TabIndex = 42;
            this.cmdSendTestEmail.Text = "Send Test Email";
            this.cmdSendTestEmail.UseVisualStyleBackColor = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(201, 118);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 13);
            this.lblPassword.TabIndex = 41;
            this.lblPassword.Text = "Password:";
            // 
            // txtEmailLoginUserPassword
            // 
            this.txtEmailLoginUserPassword.Location = new System.Drawing.Point(262, 115);
            this.txtEmailLoginUserPassword.Name = "txtEmailLoginUserPassword";
            this.txtEmailLoginUserPassword.Size = new System.Drawing.Size(110, 21);
            this.txtEmailLoginUserPassword.TabIndex = 40;
            // 
            // lblUserNameEmail
            // 
            this.lblUserNameEmail.AutoSize = true;
            this.lblUserNameEmail.Location = new System.Drawing.Point(157, 95);
            this.lblUserNameEmail.Name = "lblUserNameEmail";
            this.lblUserNameEmail.Size = new System.Drawing.Size(101, 13);
            this.lblUserNameEmail.TabIndex = 39;
            this.lblUserNameEmail.Text = "User Name / E-Mail:";
            // 
            // txtEmailLoginUserName
            // 
            this.txtEmailLoginUserName.Location = new System.Drawing.Point(262, 90);
            this.txtEmailLoginUserName.Name = "txtEmailLoginUserName";
            this.txtEmailLoginUserName.Size = new System.Drawing.Size(286, 21);
            this.txtEmailLoginUserName.TabIndex = 38;
            // 
            // lblSMTPServer
            // 
            this.lblSMTPServer.AutoSize = true;
            this.lblSMTPServer.Location = new System.Drawing.Point(186, 45);
            this.lblSMTPServer.Name = "lblSMTPServer";
            this.lblSMTPServer.Size = new System.Drawing.Size(72, 13);
            this.lblSMTPServer.TabIndex = 37;
            this.lblSMTPServer.Text = "SMTP Server:";
            // 
            // lblFromEmail
            // 
            this.lblFromEmail.AutoSize = true;
            this.lblFromEmail.Location = new System.Drawing.Point(196, 20);
            this.lblFromEmail.Name = "lblFromEmail";
            this.lblFromEmail.Size = new System.Drawing.Size(62, 13);
            this.lblFromEmail.TabIndex = 36;
            this.lblFromEmail.Text = "From Email:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(411, 45);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(91, 13);
            this.lblPort.TabIndex = 35;
            this.lblPort.Text = "Port (25 default):";
            // 
            // chkEnableSSL
            // 
            this.chkEnableSSL.AutoSize = true;
            this.chkEnableSSL.Location = new System.Drawing.Point(471, 69);
            this.chkEnableSSL.Name = "chkEnableSSL";
            this.chkEnableSSL.Size = new System.Drawing.Size(78, 17);
            this.chkEnableSSL.TabIndex = 34;
            this.chkEnableSSL.Text = "Enable SSL";
            this.chkEnableSSL.UseVisualStyleBackColor = true;
            // 
            // chkServerRequiresAuth
            // 
            this.chkServerRequiresAuth.AutoSize = true;
            this.chkServerRequiresAuth.Location = new System.Drawing.Point(262, 69);
            this.chkServerRequiresAuth.Name = "chkServerRequiresAuth";
            this.chkServerRequiresAuth.Size = new System.Drawing.Size(188, 17);
            this.chkServerRequiresAuth.TabIndex = 33;
            this.chkServerRequiresAuth.Text = "My server requires authentication";
            this.chkServerRequiresAuth.UseVisualStyleBackColor = true;
            // 
            // nudPort
            // 
            this.nudPort.Location = new System.Drawing.Point(503, 41);
            this.nudPort.Name = "nudPort";
            this.nudPort.Size = new System.Drawing.Size(43, 21);
            this.nudPort.TabIndex = 32;
            this.nudPort.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // txtSMTPServer
            // 
            this.txtSMTPServer.Location = new System.Drawing.Point(262, 41);
            this.txtSMTPServer.Name = "txtSMTPServer";
            this.txtSMTPServer.Size = new System.Drawing.Size(143, 21);
            this.txtSMTPServer.TabIndex = 31;
            // 
            // txtFromEmail
            // 
            this.txtFromEmail.Location = new System.Drawing.Point(262, 16);
            this.txtFromEmail.Name = "txtFromEmail";
            this.txtFromEmail.Size = new System.Drawing.Size(285, 21);
            this.txtFromEmail.TabIndex = 30;
            // 
            // lblSuccessEmail
            // 
            this.lblSuccessEmail.AutoSize = true;
            this.lblSuccessEmail.Location = new System.Drawing.Point(6, 22);
            this.lblSuccessEmail.Name = "lblSuccessEmail";
            this.lblSuccessEmail.Size = new System.Drawing.Size(88, 13);
            this.lblSuccessEmail.TabIndex = 29;
            this.lblSuccessEmail.Text = "Successful Email:";
            // 
            // lblFailureEmail
            // 
            this.lblFailureEmail.AutoSize = true;
            this.lblFailureEmail.Location = new System.Drawing.Point(5, 65);
            this.lblFailureEmail.Name = "lblFailureEmail";
            this.lblFailureEmail.Size = new System.Drawing.Size(70, 13);
            this.lblFailureEmail.TabIndex = 27;
            this.lblFailureEmail.Text = "Failure Email:";
            // 
            // txtFailureEmail
            // 
            this.txtFailureEmail.Location = new System.Drawing.Point(6, 83);
            this.txtFailureEmail.Name = "txtFailureEmail";
            this.txtFailureEmail.Size = new System.Drawing.Size(149, 21);
            this.txtFailureEmail.TabIndex = 28;
            // 
            // txtSuccessEmail
            // 
            this.txtSuccessEmail.Location = new System.Drawing.Point(6, 40);
            this.txtSuccessEmail.Name = "txtSuccessEmail";
            this.txtSuccessEmail.Size = new System.Drawing.Size(150, 21);
            this.txtSuccessEmail.TabIndex = 27;
            // 
            // lblMonths
            // 
            this.lblMonths.AutoSize = true;
            this.lblMonths.Location = new System.Drawing.Point(215, 129);
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.Size = new System.Drawing.Size(42, 13);
            this.lblMonths.TabIndex = 22;
            this.lblMonths.Text = "Months";
            // 
            // gbWorkingDirectories
            // 
            this.gbWorkingDirectories.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbWorkingDirectories.Controls.Add(this.cmdSQLDBFiles);
            this.gbWorkingDirectories.Controls.Add(this.cmdScratch);
            this.gbWorkingDirectories.Controls.Add(this.cmdBackupZips);
            this.gbWorkingDirectories.Controls.Add(this.lblSqlDBFiles);
            this.gbWorkingDirectories.Controls.Add(this.lblBackupZips);
            this.gbWorkingDirectories.Controls.Add(this.lblScratch);
            this.gbWorkingDirectories.Controls.Add(this.txtBackupZips);
            this.gbWorkingDirectories.Controls.Add(this.txtScratchPad);
            this.gbWorkingDirectories.Controls.Add(this.txtSQLFileLocations);
            this.gbWorkingDirectories.Location = new System.Drawing.Point(10, 6);
            this.gbWorkingDirectories.Name = "gbWorkingDirectories";
            this.gbWorkingDirectories.Size = new System.Drawing.Size(556, 114);
            this.gbWorkingDirectories.TabIndex = 21;
            this.gbWorkingDirectories.TabStop = false;
            this.gbWorkingDirectories.Text = "Working Directories";
            // 
            // cmdSQLDBFiles
            // 
            this.cmdSQLDBFiles.Location = new System.Drawing.Point(497, 76);
            this.cmdSQLDBFiles.Name = "cmdSQLDBFiles";
            this.cmdSQLDBFiles.Size = new System.Drawing.Size(38, 23);
            this.cmdSQLDBFiles.TabIndex = 26;
            this.cmdSQLDBFiles.Text = "...";
            this.cmdSQLDBFiles.UseVisualStyleBackColor = true;
            this.cmdSQLDBFiles.Click += new System.EventHandler(this.cmdSQLDBFiles_Click);
            // 
            // cmdScratch
            // 
            this.cmdScratch.Location = new System.Drawing.Point(497, 49);
            this.cmdScratch.Name = "cmdScratch";
            this.cmdScratch.Size = new System.Drawing.Size(38, 23);
            this.cmdScratch.TabIndex = 25;
            this.cmdScratch.Text = "...";
            this.cmdScratch.UseVisualStyleBackColor = true;
            this.cmdScratch.Click += new System.EventHandler(this.cmdScratch_Click);
            // 
            // cmdBackupZips
            // 
            this.cmdBackupZips.Location = new System.Drawing.Point(497, 24);
            this.cmdBackupZips.Name = "cmdBackupZips";
            this.cmdBackupZips.Size = new System.Drawing.Size(38, 23);
            this.cmdBackupZips.TabIndex = 24;
            this.cmdBackupZips.Text = "...";
            this.cmdBackupZips.UseVisualStyleBackColor = true;
            this.cmdBackupZips.Click += new System.EventHandler(this.cmdBackupZips_Click);
            // 
            // lblSqlDBFiles
            // 
            this.lblSqlDBFiles.AutoSize = true;
            this.lblSqlDBFiles.Location = new System.Drawing.Point(16, 81);
            this.lblSqlDBFiles.Name = "lblSqlDBFiles";
            this.lblSqlDBFiles.Size = new System.Drawing.Size(70, 13);
            this.lblSqlDBFiles.TabIndex = 23;
            this.lblSqlDBFiles.Text = "SQL DB Files:";
            // 
            // lblBackupZips
            // 
            this.lblBackupZips.AutoSize = true;
            this.lblBackupZips.Location = new System.Drawing.Point(19, 27);
            this.lblBackupZips.Name = "lblBackupZips";
            this.lblBackupZips.Size = new System.Drawing.Size(67, 13);
            this.lblBackupZips.TabIndex = 22;
            this.lblBackupZips.Text = "Backup Zips:";
            // 
            // lblScratch
            // 
            this.lblScratch.AutoSize = true;
            this.lblScratch.Location = new System.Drawing.Point(18, 54);
            this.lblScratch.Name = "lblScratch";
            this.lblScratch.Size = new System.Drawing.Size(68, 13);
            this.lblScratch.TabIndex = 21;
            this.lblScratch.Text = "Scratch Pad:";
            // 
            // txtBackupZips
            // 
            this.txtBackupZips.Location = new System.Drawing.Point(88, 24);
            this.txtBackupZips.Name = "txtBackupZips";
            this.txtBackupZips.Size = new System.Drawing.Size(403, 21);
            this.txtBackupZips.TabIndex = 18;
            // 
            // txtScratchPad
            // 
            this.txtScratchPad.Location = new System.Drawing.Point(88, 51);
            this.txtScratchPad.Name = "txtScratchPad";
            this.txtScratchPad.Size = new System.Drawing.Size(403, 21);
            this.txtScratchPad.TabIndex = 20;
            // 
            // txtSQLFileLocations
            // 
            this.txtSQLFileLocations.Location = new System.Drawing.Point(88, 78);
            this.txtSQLFileLocations.Name = "txtSQLFileLocations";
            this.txtSQLFileLocations.Size = new System.Drawing.Size(403, 21);
            this.txtSQLFileLocations.TabIndex = 19;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(300, 129);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(31, 13);
            this.lblDays.TabIndex = 17;
            this.lblDays.Text = "Days";
            // 
            // nudDays
            // 
            this.nudDays.Location = new System.Drawing.Point(259, 125);
            this.nudDays.Name = "nudDays";
            this.nudDays.Size = new System.Drawing.Size(36, 21);
            this.nudDays.TabIndex = 16;
            // 
            // nudMonths
            // 
            this.nudMonths.Location = new System.Drawing.Point(174, 125);
            this.nudMonths.Name = "nudMonths";
            this.nudMonths.Size = new System.Drawing.Size(36, 21);
            this.nudMonths.TabIndex = 14;
            // 
            // lblHowLongTokeep
            // 
            this.lblHowLongTokeep.AutoSize = true;
            this.lblHowLongTokeep.Location = new System.Drawing.Point(15, 129);
            this.lblHowLongTokeep.Name = "lblHowLongTokeep";
            this.lblHowLongTokeep.Size = new System.Drawing.Size(153, 13);
            this.lblHowLongTokeep.TabIndex = 13;
            this.lblHowLongTokeep.Text = "How long to keep backup files:";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(136, 47);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.ReadOnly = true;
            this.txtConnectionString.Size = new System.Drawing.Size(348, 21);
            this.txtConnectionString.TabIndex = 13;
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Location = new System.Drawing.Point(66, 50);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(65, 13);
            this.lblConnection.TabIndex = 14;
            this.lblConnection.Text = "Connection:";
            // 
            // cmdConfigureConn
            // 
            this.cmdConfigureConn.Location = new System.Drawing.Point(490, 45);
            this.cmdConfigureConn.Name = "cmdConfigureConn";
            this.cmdConfigureConn.Size = new System.Drawing.Size(67, 23);
            this.cmdConfigureConn.TabIndex = 15;
            this.cmdConfigureConn.Text = "Configure";
            this.cmdConfigureConn.UseVisualStyleBackColor = true;
            // 
            // tabFTPSchduler
            // 
            this.tabFTPSchduler.Controls.Add(this.grpScheduleJog);
            this.tabFTPSchduler.Controls.Add(this.grbFTP);
            this.tabFTPSchduler.Location = new System.Drawing.Point(4, 22);
            this.tabFTPSchduler.Name = "tabFTPSchduler";
            this.tabFTPSchduler.Padding = new System.Windows.Forms.Padding(3);
            this.tabFTPSchduler.Size = new System.Drawing.Size(572, 311);
            this.tabFTPSchduler.TabIndex = 3;
            this.tabFTPSchduler.Text = "FTP and Scheduler";
            this.tabFTPSchduler.UseVisualStyleBackColor = true;
            // 
            // grbFTP
            // 
            this.grbFTP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grbFTP.Controls.Add(this.lblDataConnection);
            this.grbFTP.Controls.Add(this.chkWriteFTPSessionLog);
            this.grbFTP.Controls.Add(this.chkUseFTP);
            this.grbFTP.Controls.Add(this.lblRemoteFolder);
            this.grbFTP.Controls.Add(this.txtRemoteFolder);
            this.grbFTP.Controls.Add(this.lblFTPPort);
            this.grbFTP.Controls.Add(this.cboDataConnection);
            this.grbFTP.Controls.Add(this.nudFTPPort);
            this.grbFTP.Controls.Add(this.lblFTPPassword);
            this.grbFTP.Controls.Add(this.textBox3);
            this.grbFTP.Controls.Add(this.lblFTPUserName);
            this.grbFTP.Controls.Add(this.textBox2);
            this.grbFTP.Controls.Add(this.lblFTPExample);
            this.grbFTP.Controls.Add(this.lblFTPHostAddress);
            this.grbFTP.Controls.Add(this.textBox1);
            this.grbFTP.Controls.Add(this.lblFTPMonths);
            this.grbFTP.Controls.Add(this.lblFTPDays);
            this.grbFTP.Controls.Add(this.nudFTPDays);
            this.grbFTP.Controls.Add(this.nudFTPMonths);
            this.grbFTP.Controls.Add(this.lblHowLogToKeepFTPFiles);
            this.grbFTP.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbFTP.Location = new System.Drawing.Point(3, 3);
            this.grbFTP.Name = "grbFTP";
            this.grbFTP.Size = new System.Drawing.Size(566, 234);
            this.grbFTP.TabIndex = 0;
            this.grbFTP.TabStop = false;
            this.grbFTP.Text = "FTP";
            // 
            // lblFTPMonths
            // 
            this.lblFTPMonths.AutoSize = true;
            this.lblFTPMonths.Location = new System.Drawing.Point(217, 23);
            this.lblFTPMonths.Name = "lblFTPMonths";
            this.lblFTPMonths.Size = new System.Drawing.Size(42, 13);
            this.lblFTPMonths.TabIndex = 27;
            this.lblFTPMonths.Text = "Months";
            // 
            // lblFTPDays
            // 
            this.lblFTPDays.AutoSize = true;
            this.lblFTPDays.Location = new System.Drawing.Point(302, 23);
            this.lblFTPDays.Name = "lblFTPDays";
            this.lblFTPDays.Size = new System.Drawing.Size(31, 13);
            this.lblFTPDays.TabIndex = 26;
            this.lblFTPDays.Text = "Days";
            // 
            // nudFTPDays
            // 
            this.nudFTPDays.Location = new System.Drawing.Point(261, 19);
            this.nudFTPDays.Name = "nudFTPDays";
            this.nudFTPDays.Size = new System.Drawing.Size(36, 21);
            this.nudFTPDays.TabIndex = 25;
            // 
            // nudFTPMonths
            // 
            this.nudFTPMonths.Location = new System.Drawing.Point(176, 19);
            this.nudFTPMonths.Name = "nudFTPMonths";
            this.nudFTPMonths.Size = new System.Drawing.Size(36, 21);
            this.nudFTPMonths.TabIndex = 24;
            // 
            // lblHowLogToKeepFTPFiles
            // 
            this.lblHowLogToKeepFTPFiles.AutoSize = true;
            this.lblHowLogToKeepFTPFiles.Location = new System.Drawing.Point(17, 23);
            this.lblHowLogToKeepFTPFiles.Name = "lblHowLogToKeepFTPFiles";
            this.lblHowLogToKeepFTPFiles.Size = new System.Drawing.Size(139, 13);
            this.lblHowLogToKeepFTPFiles.TabIndex = 23;
            this.lblHowLogToKeepFTPFiles.Text = "How long to keep FTP Files:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 21);
            this.textBox1.TabIndex = 28;
            // 
            // lblFTPHostAddress
            // 
            this.lblFTPHostAddress.AutoSize = true;
            this.lblFTPHostAddress.Location = new System.Drawing.Point(32, 51);
            this.lblFTPHostAddress.Name = "lblFTPHostAddress";
            this.lblFTPHostAddress.Size = new System.Drawing.Size(75, 13);
            this.lblFTPHostAddress.TabIndex = 29;
            this.lblFTPHostAddress.Text = "Host Address:";
            // 
            // lblFTPExample
            // 
            this.lblFTPExample.AutoSize = true;
            this.lblFTPExample.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFTPExample.Location = new System.Drawing.Point(109, 72);
            this.lblFTPExample.Name = "lblFTPExample";
            this.lblFTPExample.Size = new System.Drawing.Size(246, 13);
            this.lblFTPExample.TabIndex = 30;
            this.lblFTPExample.Text = "e.g. MyFTPServer.com or ftp://MyFTPServer.com";
            // 
            // lblFTPUserName
            // 
            this.lblFTPUserName.AutoSize = true;
            this.lblFTPUserName.Location = new System.Drawing.Point(44, 97);
            this.lblFTPUserName.Name = "lblFTPUserName";
            this.lblFTPUserName.Size = new System.Drawing.Size(63, 13);
            this.lblFTPUserName.TabIndex = 32;
            this.lblFTPUserName.Text = "User Name:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(91, 21);
            this.textBox2.TabIndex = 31;
            // 
            // lblFTPPassword
            // 
            this.lblFTPPassword.AutoSize = true;
            this.lblFTPPassword.Location = new System.Drawing.Point(206, 97);
            this.lblFTPPassword.Name = "lblFTPPassword";
            this.lblFTPPassword.Size = new System.Drawing.Size(57, 13);
            this.lblFTPPassword.TabIndex = 34;
            this.lblFTPPassword.Text = "Password:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(265, 94);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 21);
            this.textBox3.TabIndex = 33;
            // 
            // nudFTPPort
            // 
            this.nudFTPPort.Location = new System.Drawing.Point(109, 123);
            this.nudFTPPort.Name = "nudFTPPort";
            this.nudFTPPort.Size = new System.Drawing.Size(70, 21);
            this.nudFTPPort.TabIndex = 35;
            this.nudFTPPort.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // lblFTPPort
            // 
            this.lblFTPPort.AutoSize = true;
            this.lblFTPPort.Location = new System.Drawing.Point(76, 126);
            this.lblFTPPort.Name = "lblFTPPort";
            this.lblFTPPort.Size = new System.Drawing.Size(31, 13);
            this.lblFTPPort.TabIndex = 37;
            this.lblFTPPort.Text = "Port:";
            // 
            // cboDataConnection
            // 
            this.cboDataConnection.FormattingEnabled = true;
            this.cboDataConnection.Location = new System.Drawing.Point(112, 151);
            this.cboDataConnection.Name = "cboDataConnection";
            this.cboDataConnection.Size = new System.Drawing.Size(185, 21);
            this.cboDataConnection.TabIndex = 36;
            // 
            // lblRemoteFolder
            // 
            this.lblRemoteFolder.AutoSize = true;
            this.lblRemoteFolder.Location = new System.Drawing.Point(33, 182);
            this.lblRemoteFolder.Name = "lblRemoteFolder";
            this.lblRemoteFolder.Size = new System.Drawing.Size(74, 13);
            this.lblRemoteFolder.TabIndex = 39;
            this.lblRemoteFolder.Text = "RemoteFolder";
            // 
            // txtRemoteFolder
            // 
            this.txtRemoteFolder.Location = new System.Drawing.Point(112, 178);
            this.txtRemoteFolder.Name = "txtRemoteFolder";
            this.txtRemoteFolder.Size = new System.Drawing.Size(295, 21);
            this.txtRemoteFolder.TabIndex = 38;
            // 
            // chkUseFTP
            // 
            this.chkUseFTP.AutoSize = true;
            this.chkUseFTP.Location = new System.Drawing.Point(35, 0);
            this.chkUseFTP.Name = "chkUseFTP";
            this.chkUseFTP.Size = new System.Drawing.Size(15, 14);
            this.chkUseFTP.TabIndex = 40;
            this.chkUseFTP.UseVisualStyleBackColor = true;
            // 
            // chkWriteFTPSessionLog
            // 
            this.chkWriteFTPSessionLog.AutoSize = true;
            this.chkWriteFTPSessionLog.Location = new System.Drawing.Point(112, 205);
            this.chkWriteFTPSessionLog.Name = "chkWriteFTPSessionLog";
            this.chkWriteFTPSessionLog.Size = new System.Drawing.Size(132, 17);
            this.chkWriteFTPSessionLog.TabIndex = 41;
            this.chkWriteFTPSessionLog.Text = "Write FTP Session Log";
            this.chkWriteFTPSessionLog.UseVisualStyleBackColor = true;
            // 
            // lblDataConnection
            // 
            this.lblDataConnection.AutoSize = true;
            this.lblDataConnection.Location = new System.Drawing.Point(14, 155);
            this.lblDataConnection.Name = "lblDataConnection";
            this.lblDataConnection.Size = new System.Drawing.Size(91, 13);
            this.lblDataConnection.TabIndex = 42;
            this.lblDataConnection.Text = "Data Connection:";
            // 
            // grpScheduleJog
            // 
            this.grpScheduleJog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpScheduleJog.Controls.Add(this.lblWTSJobStart);
            this.grpScheduleJog.Controls.Add(this.lblJobStart);
            this.grpScheduleJog.Controls.Add(this.dateTimePicker1);
            this.grpScheduleJog.Controls.Add(this.chkScheduleToRunDaily);
            this.grpScheduleJog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpScheduleJog.Location = new System.Drawing.Point(3, 243);
            this.grpScheduleJog.Name = "grpScheduleJog";
            this.grpScheduleJog.Size = new System.Drawing.Size(566, 65);
            this.grpScheduleJog.TabIndex = 1;
            this.grpScheduleJog.TabStop = false;
            this.grpScheduleJog.Text = "Scheduling";
            // 
            // chkScheduleToRunDaily
            // 
            this.chkScheduleToRunDaily.AutoSize = true;
            this.chkScheduleToRunDaily.Location = new System.Drawing.Point(68, 2);
            this.chkScheduleToRunDaily.Name = "chkScheduleToRunDaily";
            this.chkScheduleToRunDaily.Size = new System.Drawing.Size(164, 17);
            this.chkScheduleToRunDaily.TabIndex = 43;
            this.chkScheduleToRunDaily.Text = "Schedule to run this job daily";
            this.chkScheduleToRunDaily.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 21);
            this.dateTimePicker1.TabIndex = 44;
            // 
            // lblJobStart
            // 
            this.lblJobStart.AutoSize = true;
            this.lblJobStart.Location = new System.Drawing.Point(78, 32);
            this.lblJobStart.Name = "lblJobStart";
            this.lblJobStart.Size = new System.Drawing.Size(55, 13);
            this.lblJobStart.TabIndex = 43;
            this.lblJobStart.Text = "Job Start:";
            // 
            // lblWTSJobStart
            // 
            this.lblWTSJobStart.AutoSize = true;
            this.lblWTSJobStart.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblWTSJobStart.Location = new System.Drawing.Point(241, 32);
            this.lblWTSJobStart.Name = "lblWTSJobStart";
            this.lblWTSJobStart.Size = new System.Drawing.Size(205, 13);
            this.lblWTSJobStart.TabIndex = 45;
            this.lblWTSJobStart.Text = "Windows Task Scheduler will start the job";
            // 
            // nudEmailOutgoingPortNumber
            // 
            this.nudEmailOutgoingPortNumber.Location = new System.Drawing.Point(503, 115);
            this.nudEmailOutgoingPortNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudEmailOutgoingPortNumber.Name = "nudEmailOutgoingPortNumber";
            this.nudEmailOutgoingPortNumber.Size = new System.Drawing.Size(43, 21);
            this.nudEmailOutgoingPortNumber.TabIndex = 44;
            this.nudEmailOutgoingPortNumber.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // lblEmailOutgoingPortNumber
            // 
            this.lblEmailOutgoingPortNumber.AutoSize = true;
            this.lblEmailOutgoingPortNumber.Location = new System.Drawing.Point(378, 119);
            this.lblEmailOutgoingPortNumber.Name = "lblEmailOutgoingPortNumber";
            this.lblEmailOutgoingPortNumber.Size = new System.Drawing.Size(118, 13);
            this.lblEmailOutgoingPortNumber.TabIndex = 45;
            this.lblEmailOutgoingPortNumber.Text = "Outgoing Port Number:";
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 530);
            this.Controls.Add(this.cmdViewInNotepad);
            this.Controls.Add(this.cmdShow);
            this.Controls.Add(this.lblLogFile);
            this.Controls.Add(this.txtLogFile);
            this.Controls.Add(this.tacMain);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWin";
            this.Text = "SqlServer Backup/Restore Utility";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWin_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tacMain.ResumeLayout(false);
            this.tabBackupRestore.ResumeLayout(false);
            this.grpBackup.ResumeLayout(false);
            this.grpBackup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabRestore.ResumeLayout(false);
            this.grpRestore.ResumeLayout(false);
            this.grpRestore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabConfiguration.ResumeLayout(false);
            this.tabConfiguration.PerformLayout();
            this.grpEmailConfiguration.ResumeLayout(false);
            this.grpEmailConfiguration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
            this.gbWorkingDirectories.ResumeLayout(false);
            this.gbWorkingDirectories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonths)).EndInit();
            this.tabFTPSchduler.ResumeLayout(false);
            this.grbFTP.ResumeLayout(false);
            this.grbFTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFTPDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFTPMonths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFTPPort)).EndInit();
            this.grpScheduleJog.ResumeLayout(false);
            this.grpScheduleJog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmailOutgoingPortNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openBakFile;
        private System.Windows.Forms.SaveFileDialog saveBakFile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar progBar;
        private System.Windows.Forms.OpenFileDialog ofdRestoreZips;
        private System.Windows.Forms.TextBox txtLogFile;
        private System.Windows.Forms.Label lblLogFile;
        private System.Windows.Forms.Button cmdShow;
        private System.Windows.Forms.Button cmdViewInNotepad;
        private System.Windows.Forms.TabControl tacMain;
        private System.Windows.Forms.TabPage tabBackupRestore;
        private System.Windows.Forms.GroupBox grpBackup;
        private System.Windows.Forms.Button cmdShrinkLogFile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbBackupMode;
        private System.Windows.Forms.Button btnBackupDb;
        private System.Windows.Forms.TextBox txtFileToBackUp;
        private System.Windows.Forms.ComboBox cmbBackupDb;
        private System.Windows.Forms.Label lblBackupMode;
        private System.Windows.Forms.Label lblBackupFileName;
        private System.Windows.Forms.Label lblDb;
        private System.Windows.Forms.TabPage tabRestore;
        private System.Windows.Forms.GroupBox grpRestore;
        private System.Windows.Forms.Button cmdGetZipFile;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox chckReplace;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.TextBox txtFileToRestore;
        private System.Windows.Forms.Label lblBackupFile;
        private System.Windows.Forms.TabPage tabConfiguration;
        private System.Windows.Forms.Label lblBackupScript;
        private System.Windows.Forms.TextBox txtBackupScript;
        private System.Windows.Forms.Label lblRestoreScript;
        private System.Windows.Forms.TextBox txtRestoreScript;
        private System.Windows.Forms.GroupBox gbWorkingDirectories;
        private System.Windows.Forms.Button cmdSQLDBFiles;
        private System.Windows.Forms.Button cmdScratch;
        private System.Windows.Forms.Button cmdBackupZips;
        private System.Windows.Forms.Label lblSqlDBFiles;
        private System.Windows.Forms.Label lblBackupZips;
        private System.Windows.Forms.Label lblScratch;
        private System.Windows.Forms.TextBox txtBackupZips;
        private System.Windows.Forms.TextBox txtScratchPad;
        private System.Windows.Forms.TextBox txtSQLFileLocations;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.NumericUpDown nudDays;
        private System.Windows.Forms.NumericUpDown nudMonths;
        private System.Windows.Forms.Label lblHowLongTokeep;
        private System.Windows.Forms.FolderBrowserDialog fbdBackupZips;
        private System.Windows.Forms.FolderBrowserDialog fbdSQLDBFiles;
        private System.Windows.Forms.FolderBrowserDialog fbdScratch;
        private System.Windows.Forms.Label lblMonths;
        private System.Windows.Forms.GroupBox grpEmailConfiguration;
        private System.Windows.Forms.Label lblSuccessEmail;
        private System.Windows.Forms.Label lblFailureEmail;
        private System.Windows.Forms.TextBox txtFailureEmail;
        private System.Windows.Forms.TextBox txtSuccessEmail;
        private System.Windows.Forms.Button cmdSendTestEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtEmailLoginUserPassword;
        private System.Windows.Forms.Label lblUserNameEmail;
        private System.Windows.Forms.TextBox txtEmailLoginUserName;
        private System.Windows.Forms.Label lblSMTPServer;
        private System.Windows.Forms.Label lblFromEmail;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.CheckBox chkEnableSSL;
        private System.Windows.Forms.CheckBox chkServerRequiresAuth;
        private System.Windows.Forms.NumericUpDown nudPort;
        private System.Windows.Forms.TextBox txtSMTPServer;
        private System.Windows.Forms.TextBox txtFromEmail;
        private System.Windows.Forms.CheckBox chkConfigureEmails;
        private System.Windows.Forms.Button cmdConfigureConn;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.TabPage tabFTPSchduler;
        private System.Windows.Forms.GroupBox grpScheduleJog;
        private System.Windows.Forms.Label lblWTSJobStart;
        private System.Windows.Forms.Label lblJobStart;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox chkScheduleToRunDaily;
        private System.Windows.Forms.GroupBox grbFTP;
        private System.Windows.Forms.Label lblDataConnection;
        private System.Windows.Forms.CheckBox chkWriteFTPSessionLog;
        private System.Windows.Forms.CheckBox chkUseFTP;
        private System.Windows.Forms.Label lblRemoteFolder;
        private System.Windows.Forms.TextBox txtRemoteFolder;
        private System.Windows.Forms.Label lblFTPPort;
        private System.Windows.Forms.ComboBox cboDataConnection;
        private System.Windows.Forms.NumericUpDown nudFTPPort;
        private System.Windows.Forms.Label lblFTPPassword;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblFTPUserName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblFTPExample;
        private System.Windows.Forms.Label lblFTPHostAddress;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFTPMonths;
        private System.Windows.Forms.Label lblFTPDays;
        private System.Windows.Forms.NumericUpDown nudFTPDays;
        private System.Windows.Forms.NumericUpDown nudFTPMonths;
        private System.Windows.Forms.Label lblHowLogToKeepFTPFiles;
        private System.Windows.Forms.Label lblEmailOutgoingPortNumber;
        private System.Windows.Forms.NumericUpDown nudEmailOutgoingPortNumber;
    }
}