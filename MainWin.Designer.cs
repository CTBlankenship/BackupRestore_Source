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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openBakFile = new System.Windows.Forms.OpenFileDialog();
            this.saveBakFile = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolstripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dgvDatabases = new System.Windows.Forms.DataGridView();
            this.colDBSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDBName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDBBackupZipName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdConfigureConn = new System.Windows.Forms.Button();
            this.lblConnection = new System.Windows.Forms.Label();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.lblBackupScript = new System.Windows.Forms.Label();
            this.txtBackupScript = new System.Windows.Forms.TextBox();
            this.cmdShrinkLogFile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBackupDb = new System.Windows.Forms.Button();
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
            this.tabDevelopment = new System.Windows.Forms.TabPage();
            this.chkSkipPDBFiles = new System.Windows.Forms.CheckBox();
            this.lblDevZipName = new System.Windows.Forms.Label();
            this.txtDevZipName = new System.Windows.Forms.TextBox();
            this.chkSkipDLLS = new System.Windows.Forms.CheckBox();
            this.cmdBackupDevelopmentDirectories = new System.Windows.Forms.Button();
            this.dgvDevelopmentDirectories = new System.Windows.Forms.DataGridView();
            this.colSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDirectoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.nudEmailOutgoingPortNumber = new System.Windows.Forms.NumericUpDown();
            this.txtSMTPServer = new System.Windows.Forms.TextBox();
            this.txtFromEmail = new System.Windows.Forms.TextBox();
            this.lblSuccessEmail = new System.Windows.Forms.Label();
            this.lblFailureEmail = new System.Windows.Forms.Label();
            this.txtFailureEmail = new System.Windows.Forms.TextBox();
            this.txtSuccessEmail = new System.Windows.Forms.TextBox();
            this.lblMonths = new System.Windows.Forms.Label();
            this.gbWorkingDirectories = new System.Windows.Forms.GroupBox();
            this.cmdDevFilesLocation = new System.Windows.Forms.Button();
            this.lblDevFilesLocation = new System.Windows.Forms.Label();
            this.txtDevFilesLocation = new System.Windows.Forms.TextBox();
            this.cmdDevelopmentZips = new System.Windows.Forms.Button();
            this.lblDevelopmentZips = new System.Windows.Forms.Label();
            this.txtDevelopmentZips = new System.Windows.Forms.TextBox();
            this.cmdSQLDBFiles = new System.Windows.Forms.Button();
            this.cmdScratch = new System.Windows.Forms.Button();
            this.cmdBackupZips = new System.Windows.Forms.Button();
            this.lblSqlDBFiles = new System.Windows.Forms.Label();
            this.lblDBBackupZips = new System.Windows.Forms.Label();
            this.lblScratch = new System.Windows.Forms.Label();
            this.txtBackupZips = new System.Windows.Forms.TextBox();
            this.txtScratchPad = new System.Windows.Forms.TextBox();
            this.txtSQLFileLocations = new System.Windows.Forms.TextBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.nudDays = new System.Windows.Forms.NumericUpDown();
            this.nudMonths = new System.Windows.Forms.NumericUpDown();
            this.lblHowLongTokeep = new System.Windows.Forms.Label();
            this.tabFTPSchduler = new System.Windows.Forms.TabPage();
            this.grpScheduleJog = new System.Windows.Forms.GroupBox();
            this.lblWTSJobStart = new System.Windows.Forms.Label();
            this.lblJobStart = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chkScheduleToRunDaily = new System.Windows.Forms.CheckBox();
            this.grbFTP = new System.Windows.Forms.GroupBox();
            this.cmdTestFTPTransfer = new System.Windows.Forms.Button();
            this.chkFTPWriteSessionLog = new System.Windows.Forms.CheckBox();
            this.chkFTPUseFTPSettings = new System.Windows.Forms.CheckBox();
            this.lblRemoteFolder = new System.Windows.Forms.Label();
            this.txtFTPRemoteFolder = new System.Windows.Forms.TextBox();
            this.lblFTPPort = new System.Windows.Forms.Label();
            this.nudFTPPort = new System.Windows.Forms.NumericUpDown();
            this.lblFTPPassword = new System.Windows.Forms.Label();
            this.txtFTPPassword = new System.Windows.Forms.TextBox();
            this.lblFTPUserName = new System.Windows.Forms.Label();
            this.txtFTPUserName = new System.Windows.Forms.TextBox();
            this.lblFTPExample = new System.Windows.Forms.Label();
            this.lblFTPHostAddress = new System.Windows.Forms.Label();
            this.txtFTPHostAddress = new System.Windows.Forms.TextBox();
            this.lblFTPMonths = new System.Windows.Forms.Label();
            this.lblFTPDays = new System.Windows.Forms.Label();
            this.nudFTPDays = new System.Windows.Forms.NumericUpDown();
            this.nudFTPMonths = new System.Windows.Forms.NumericUpDown();
            this.lblHowLogToKeepFTPFiles = new System.Windows.Forms.Label();
            this.fbdBackupZips = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdSQLDBFiles = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdScratch = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdDevFileLocations = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdMailboxDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdDevelopmentZips = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1.SuspendLayout();
            this.tacMain.SuspendLayout();
            this.tabBackupRestore.SuspendLayout();
            this.grpBackup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabRestore.SuspendLayout();
            this.grpRestore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabDevelopment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevelopmentDirectories)).BeginInit();
            this.tabConfiguration.SuspendLayout();
            this.grpEmailConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmailOutgoingPortNumber)).BeginInit();
            this.gbWorkingDirectories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonths)).BeginInit();
            this.tabFTPSchduler.SuspendLayout();
            this.grpScheduleJog.SuspendLayout();
            this.grbFTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFTPPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFTPDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFTPMonths)).BeginInit();
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
            this.statusStrip1.BackColor = System.Drawing.Color.Silver;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.progBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 562);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(605, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolstripMenuItem,
            this.quitToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(54, 20);
            this.toolStripSplitButton1.Text = "Menu";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeyDisplayString = "Alt+O";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // saveToolstripMenuItem
            // 
            this.saveToolstripMenuItem.Name = "saveToolstripMenuItem";
            this.saveToolstripMenuItem.ShortcutKeyDisplayString = "Alt+S";
            this.saveToolstripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.saveToolstripMenuItem.Text = "&Save";
            this.saveToolstripMenuItem.Click += new System.EventHandler(this.saveToolstripMenuItem_Click);
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
            this.progBar.BackColor = System.Drawing.SystemColors.ControlLight;
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
            this.txtLogFile.Location = new System.Drawing.Point(12, 441);
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
            this.lblLogFile.Location = new System.Drawing.Point(9, 416);
            this.lblLogFile.Name = "lblLogFile";
            this.lblLogFile.Size = new System.Drawing.Size(40, 13);
            this.lblLogFile.TabIndex = 5;
            this.lblLogFile.Text = "LogFile";
            // 
            // cmdShow
            // 
            this.cmdShow.Location = new System.Drawing.Point(53, 412);
            this.cmdShow.Name = "cmdShow";
            this.cmdShow.Size = new System.Drawing.Size(75, 23);
            this.cmdShow.TabIndex = 6;
            this.cmdShow.Text = "Show";
            this.cmdShow.UseVisualStyleBackColor = true;
            this.cmdShow.Click += new System.EventHandler(this.cmdShow_Click);
            // 
            // cmdViewInNotepad
            // 
            this.cmdViewInNotepad.Location = new System.Drawing.Point(134, 412);
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
            this.tacMain.Controls.Add(this.tabDevelopment);
            this.tacMain.Controls.Add(this.tabConfiguration);
            this.tacMain.Controls.Add(this.tabFTPSchduler);
            this.tacMain.Location = new System.Drawing.Point(12, 12);
            this.tacMain.Name = "tacMain";
            this.tacMain.SelectedIndex = 0;
            this.tacMain.Size = new System.Drawing.Size(580, 394);
            this.tacMain.TabIndex = 8;
            this.tacMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tacMain_Selected);
            // 
            // tabBackupRestore
            // 
            this.tabBackupRestore.Controls.Add(this.grpBackup);
            this.tabBackupRestore.Location = new System.Drawing.Point(4, 22);
            this.tabBackupRestore.Name = "tabBackupRestore";
            this.tabBackupRestore.Padding = new System.Windows.Forms.Padding(3);
            this.tabBackupRestore.Size = new System.Drawing.Size(572, 368);
            this.tabBackupRestore.TabIndex = 0;
            this.tabBackupRestore.Text = "Backup";
            this.tabBackupRestore.UseVisualStyleBackColor = true;
            // 
            // grpBackup
            // 
            this.grpBackup.Controls.Add(this.dgvDatabases);
            this.grpBackup.Controls.Add(this.cmdConfigureConn);
            this.grpBackup.Controls.Add(this.lblConnection);
            this.grpBackup.Controls.Add(this.txtConnectionString);
            this.grpBackup.Controls.Add(this.lblBackupScript);
            this.grpBackup.Controls.Add(this.txtBackupScript);
            this.grpBackup.Controls.Add(this.cmdShrinkLogFile);
            this.grpBackup.Controls.Add(this.pictureBox1);
            this.grpBackup.Controls.Add(this.btnBackupDb);
            this.grpBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBackup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpBackup.Location = new System.Drawing.Point(3, 3);
            this.grpBackup.Name = "grpBackup";
            this.grpBackup.Size = new System.Drawing.Size(566, 362);
            this.grpBackup.TabIndex = 1;
            this.grpBackup.TabStop = false;
            this.grpBackup.Text = "Backup";
            // 
            // dgvDatabases
            // 
            this.dgvDatabases.AllowUserToAddRows = false;
            this.dgvDatabases.AllowUserToDeleteRows = false;
            this.dgvDatabases.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDatabases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatabases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDBSelected,
            this.colDBName,
            this.colDBBackupZipName});
            this.dgvDatabases.Location = new System.Drawing.Point(73, 49);
            this.dgvDatabases.Name = "dgvDatabases";
            this.dgvDatabases.RowHeadersVisible = false;
            this.dgvDatabases.Size = new System.Drawing.Size(482, 152);
            this.dgvDatabases.TabIndex = 16;
            // 
            // colDBSelected
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.NullValue = false;
            this.colDBSelected.DefaultCellStyle = dataGridViewCellStyle1;
            this.colDBSelected.FalseValue = "false";
            this.colDBSelected.HeaderText = "Select";
            this.colDBSelected.Name = "colDBSelected";
            this.colDBSelected.TrueValue = "true";
            this.colDBSelected.Width = 50;
            // 
            // colDBName
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDBName.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDBName.HeaderText = "DB Name";
            this.colDBName.Name = "colDBName";
            this.colDBName.ReadOnly = true;
            this.colDBName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDBName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDBName.Width = 125;
            // 
            // colDBBackupZipName
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDBBackupZipName.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDBBackupZipName.HeaderText = "DB Backup Zipfile Name";
            this.colDBBackupZipName.Name = "colDBBackupZipName";
            this.colDBBackupZipName.ReadOnly = true;
            this.colDBBackupZipName.Width = 303;
            // 
            // cmdConfigureConn
            // 
            this.cmdConfigureConn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmdConfigureConn.Location = new System.Drawing.Point(488, 20);
            this.cmdConfigureConn.Name = "cmdConfigureConn";
            this.cmdConfigureConn.Size = new System.Drawing.Size(67, 23);
            this.cmdConfigureConn.TabIndex = 15;
            this.cmdConfigureConn.Text = "Configure";
            this.cmdConfigureConn.UseVisualStyleBackColor = true;
            this.cmdConfigureConn.Click += new System.EventHandler(this.cmdConfigureConn_Click);
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblConnection.Location = new System.Drawing.Point(70, 20);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(65, 13);
            this.lblConnection.TabIndex = 14;
            this.lblConnection.Text = "Connection:";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtConnectionString.Location = new System.Drawing.Point(141, 20);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.ReadOnly = true;
            this.txtConnectionString.Size = new System.Drawing.Size(341, 21);
            this.txtConnectionString.TabIndex = 13;
            // 
            // lblBackupScript
            // 
            this.lblBackupScript.AutoSize = true;
            this.lblBackupScript.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBackupScript.Location = new System.Drawing.Point(7, 220);
            this.lblBackupScript.Name = "lblBackupScript";
            this.lblBackupScript.Size = new System.Drawing.Size(71, 13);
            this.lblBackupScript.TabIndex = 12;
            this.lblBackupScript.Text = "Backup Script";
            // 
            // txtBackupScript
            // 
            this.txtBackupScript.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBackupScript.Location = new System.Drawing.Point(10, 236);
            this.txtBackupScript.Multiline = true;
            this.txtBackupScript.Name = "txtBackupScript";
            this.txtBackupScript.ReadOnly = true;
            this.txtBackupScript.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBackupScript.Size = new System.Drawing.Size(545, 120);
            this.txtBackupScript.TabIndex = 11;
            // 
            // cmdShrinkLogFile
            // 
            this.cmdShrinkLogFile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmdShrinkLogFile.Location = new System.Drawing.Point(386, 207);
            this.cmdShrinkLogFile.Name = "cmdShrinkLogFile";
            this.cmdShrinkLogFile.Size = new System.Drawing.Size(96, 23);
            this.cmdShrinkLogFile.TabIndex = 7;
            this.cmdShrinkLogFile.Text = "Shrink Log File";
            this.cmdShrinkLogFile.UseVisualStyleBackColor = true;
            this.cmdShrinkLogFile.Click += new System.EventHandler(this.cmdShrinkLogFile_Click);
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
            // btnBackupDb
            // 
            this.btnBackupDb.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackupDb.Location = new System.Drawing.Point(488, 207);
            this.btnBackupDb.Name = "btnBackupDb";
            this.btnBackupDb.Size = new System.Drawing.Size(67, 23);
            this.btnBackupDb.TabIndex = 3;
            this.btnBackupDb.Text = "Backup";
            this.btnBackupDb.UseVisualStyleBackColor = true;
            this.btnBackupDb.Click += new System.EventHandler(this.btnBackupDb_Click);
            // 
            // tabRestore
            // 
            this.tabRestore.Controls.Add(this.grpRestore);
            this.tabRestore.Location = new System.Drawing.Point(4, 22);
            this.tabRestore.Name = "tabRestore";
            this.tabRestore.Padding = new System.Windows.Forms.Padding(3);
            this.tabRestore.Size = new System.Drawing.Size(572, 368);
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
            this.grpRestore.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpRestore.Location = new System.Drawing.Point(3, 3);
            this.grpRestore.Name = "grpRestore";
            this.grpRestore.Size = new System.Drawing.Size(566, 362);
            this.grpRestore.TabIndex = 2;
            this.grpRestore.TabStop = false;
            this.grpRestore.Text = "Restore";
            // 
            // lblRestoreScript
            // 
            this.lblRestoreScript.AutoSize = true;
            this.lblRestoreScript.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRestoreScript.Location = new System.Drawing.Point(13, 148);
            this.lblRestoreScript.Name = "lblRestoreScript";
            this.lblRestoreScript.Size = new System.Drawing.Size(75, 13);
            this.lblRestoreScript.TabIndex = 14;
            this.lblRestoreScript.Text = "Restore Script";
            // 
            // txtRestoreScript
            // 
            this.txtRestoreScript.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRestoreScript.Location = new System.Drawing.Point(10, 166);
            this.txtRestoreScript.Multiline = true;
            this.txtRestoreScript.Name = "txtRestoreScript";
            this.txtRestoreScript.ReadOnly = true;
            this.txtRestoreScript.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRestoreScript.Size = new System.Drawing.Size(542, 148);
            this.txtRestoreScript.TabIndex = 13;
            // 
            // cmdGetZipFile
            // 
            this.cmdGetZipFile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.chckReplace.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.btnRestore.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestore.Location = new System.Drawing.Point(153, 115);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(67, 23);
            this.btnRestore.TabIndex = 3;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // txtFileToRestore
            // 
            this.txtFileToRestore.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFileToRestore.Location = new System.Drawing.Point(83, 88);
            this.txtFileToRestore.Name = "txtFileToRestore";
            this.txtFileToRestore.ReadOnly = true;
            this.txtFileToRestore.Size = new System.Drawing.Size(459, 21);
            this.txtFileToRestore.TabIndex = 2;
            // 
            // lblBackupFile
            // 
            this.lblBackupFile.AutoSize = true;
            this.lblBackupFile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBackupFile.Location = new System.Drawing.Point(14, 92);
            this.lblBackupFile.Name = "lblBackupFile";
            this.lblBackupFile.Size = new System.Drawing.Size(64, 13);
            this.lblBackupFile.TabIndex = 0;
            this.lblBackupFile.Text = "Backup File:";
            // 
            // tabDevelopment
            // 
            this.tabDevelopment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabDevelopment.Controls.Add(this.chkSkipPDBFiles);
            this.tabDevelopment.Controls.Add(this.lblDevZipName);
            this.tabDevelopment.Controls.Add(this.txtDevZipName);
            this.tabDevelopment.Controls.Add(this.chkSkipDLLS);
            this.tabDevelopment.Controls.Add(this.cmdBackupDevelopmentDirectories);
            this.tabDevelopment.Controls.Add(this.dgvDevelopmentDirectories);
            this.tabDevelopment.Location = new System.Drawing.Point(4, 22);
            this.tabDevelopment.Name = "tabDevelopment";
            this.tabDevelopment.Padding = new System.Windows.Forms.Padding(3);
            this.tabDevelopment.Size = new System.Drawing.Size(572, 368);
            this.tabDevelopment.TabIndex = 4;
            this.tabDevelopment.Text = "Development Backups";
            // 
            // chkSkipPDBFiles
            // 
            this.chkSkipPDBFiles.AutoSize = true;
            this.chkSkipPDBFiles.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkSkipPDBFiles.Location = new System.Drawing.Point(383, 301);
            this.chkSkipPDBFiles.Name = "chkSkipPDBFiles";
            this.chkSkipPDBFiles.Size = new System.Drawing.Size(91, 17);
            this.chkSkipPDBFiles.TabIndex = 44;
            this.chkSkipPDBFiles.Text = "Skip PDB Tiles";
            this.chkSkipPDBFiles.UseVisualStyleBackColor = true;
            // 
            // lblDevZipName
            // 
            this.lblDevZipName.AutoSize = true;
            this.lblDevZipName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDevZipName.Location = new System.Drawing.Point(70, 248);
            this.lblDevZipName.Name = "lblDevZipName";
            this.lblDevZipName.Size = new System.Drawing.Size(140, 13);
            this.lblDevZipName.TabIndex = 43;
            this.lblDevZipName.Text = "Development Zip File Name:";
            // 
            // txtDevZipName
            // 
            this.txtDevZipName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDevZipName.Location = new System.Drawing.Point(73, 267);
            this.txtDevZipName.Name = "txtDevZipName";
            this.txtDevZipName.Size = new System.Drawing.Size(415, 21);
            this.txtDevZipName.TabIndex = 42;
            // 
            // chkSkipDLLS
            // 
            this.chkSkipDLLS.AutoSize = true;
            this.chkSkipDLLS.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkSkipDLLS.Location = new System.Drawing.Point(288, 301);
            this.chkSkipDLLS.Name = "chkSkipDLLS";
            this.chkSkipDLLS.Size = new System.Drawing.Size(89, 17);
            this.chkSkipDLLS.TabIndex = 41;
            this.chkSkipDLLS.Text = "Skip DLL Tiles";
            this.chkSkipDLLS.UseVisualStyleBackColor = true;
            // 
            // cmdBackupDevelopmentDirectories
            // 
            this.cmdBackupDevelopmentDirectories.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmdBackupDevelopmentDirectories.Location = new System.Drawing.Point(96, 297);
            this.cmdBackupDevelopmentDirectories.Name = "cmdBackupDevelopmentDirectories";
            this.cmdBackupDevelopmentDirectories.Size = new System.Drawing.Size(186, 23);
            this.cmdBackupDevelopmentDirectories.TabIndex = 34;
            this.cmdBackupDevelopmentDirectories.Text = "Backup Development Directories";
            this.cmdBackupDevelopmentDirectories.UseVisualStyleBackColor = true;
            this.cmdBackupDevelopmentDirectories.Click += new System.EventHandler(this.cmdBackupDevelopmentDirectories_Click);
            // 
            // dgvDevelopmentDirectories
            // 
            this.dgvDevelopmentDirectories.AllowUserToAddRows = false;
            this.dgvDevelopmentDirectories.AllowUserToDeleteRows = false;
            this.dgvDevelopmentDirectories.AllowUserToOrderColumns = true;
            this.dgvDevelopmentDirectories.AllowUserToResizeRows = false;
            this.dgvDevelopmentDirectories.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDevelopmentDirectories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevelopmentDirectories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelected,
            this.colDirectoryName});
            this.dgvDevelopmentDirectories.Location = new System.Drawing.Point(73, 18);
            this.dgvDevelopmentDirectories.Name = "dgvDevelopmentDirectories";
            this.dgvDevelopmentDirectories.RowHeadersVisible = false;
            this.dgvDevelopmentDirectories.Size = new System.Drawing.Size(415, 218);
            this.dgvDevelopmentDirectories.TabIndex = 33;
            // 
            // colSelected
            // 
            this.colSelected.FalseValue = "false";
            this.colSelected.HeaderText = "Select";
            this.colSelected.Name = "colSelected";
            this.colSelected.TrueValue = "true";
            this.colSelected.Width = 40;
            // 
            // colDirectoryName
            // 
            this.colDirectoryName.HeaderText = "Directory Name";
            this.colDirectoryName.Name = "colDirectoryName";
            this.colDirectoryName.Width = 372;
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
            this.tabConfiguration.Size = new System.Drawing.Size(572, 368);
            this.tabConfiguration.TabIndex = 2;
            this.tabConfiguration.Text = "Configuration (Directories and Email)";
            // 
            // grpEmailConfiguration
            // 
            this.grpEmailConfiguration.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.grpEmailConfiguration.Controls.Add(this.nudEmailOutgoingPortNumber);
            this.grpEmailConfiguration.Controls.Add(this.txtSMTPServer);
            this.grpEmailConfiguration.Controls.Add(this.txtFromEmail);
            this.grpEmailConfiguration.Controls.Add(this.lblSuccessEmail);
            this.grpEmailConfiguration.Controls.Add(this.lblFailureEmail);
            this.grpEmailConfiguration.Controls.Add(this.txtFailureEmail);
            this.grpEmailConfiguration.Controls.Add(this.txtSuccessEmail);
            this.grpEmailConfiguration.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpEmailConfiguration.Location = new System.Drawing.Point(10, 217);
            this.grpEmailConfiguration.Name = "grpEmailConfiguration";
            this.grpEmailConfiguration.Size = new System.Drawing.Size(556, 145);
            this.grpEmailConfiguration.TabIndex = 23;
            this.grpEmailConfiguration.TabStop = false;
            this.grpEmailConfiguration.Text = "Email Configuration";
            // 
            // chkConfigureEmails
            // 
            this.chkConfigureEmails.AutoSize = true;
            this.chkConfigureEmails.Location = new System.Drawing.Point(125, 1);
            this.chkConfigureEmails.Name = "chkConfigureEmails";
            this.chkConfigureEmails.Size = new System.Drawing.Size(15, 14);
            this.chkConfigureEmails.TabIndex = 43;
            this.chkConfigureEmails.UseVisualStyleBackColor = true;
            // 
            // cmdSendTestEmail
            // 
            this.cmdSendTestEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmdSendTestEmail.Location = new System.Drawing.Point(6, 112);
            this.cmdSendTestEmail.Name = "cmdSendTestEmail";
            this.cmdSendTestEmail.Size = new System.Drawing.Size(149, 23);
            this.cmdSendTestEmail.TabIndex = 42;
            this.cmdSendTestEmail.Text = "Send Test Email";
            this.cmdSendTestEmail.UseVisualStyleBackColor = true;
            this.cmdSendTestEmail.Click += new System.EventHandler(this.cmdSendTestEmail_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.Location = new System.Drawing.Point(201, 120);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 13);
            this.lblPassword.TabIndex = 41;
            this.lblPassword.Text = "Password:";
            // 
            // txtEmailLoginUserPassword
            // 
            this.txtEmailLoginUserPassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEmailLoginUserPassword.Location = new System.Drawing.Point(262, 117);
            this.txtEmailLoginUserPassword.Name = "txtEmailLoginUserPassword";
            this.txtEmailLoginUserPassword.Size = new System.Drawing.Size(143, 21);
            this.txtEmailLoginUserPassword.TabIndex = 40;
            // 
            // lblUserNameEmail
            // 
            this.lblUserNameEmail.AutoSize = true;
            this.lblUserNameEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserNameEmail.Location = new System.Drawing.Point(157, 95);
            this.lblUserNameEmail.Name = "lblUserNameEmail";
            this.lblUserNameEmail.Size = new System.Drawing.Size(101, 13);
            this.lblUserNameEmail.TabIndex = 39;
            this.lblUserNameEmail.Text = "User Name / E-Mail:";
            // 
            // txtEmailLoginUserName
            // 
            this.txtEmailLoginUserName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEmailLoginUserName.Location = new System.Drawing.Point(262, 90);
            this.txtEmailLoginUserName.Name = "txtEmailLoginUserName";
            this.txtEmailLoginUserName.Size = new System.Drawing.Size(286, 21);
            this.txtEmailLoginUserName.TabIndex = 38;
            // 
            // lblSMTPServer
            // 
            this.lblSMTPServer.AutoSize = true;
            this.lblSMTPServer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSMTPServer.Location = new System.Drawing.Point(186, 47);
            this.lblSMTPServer.Name = "lblSMTPServer";
            this.lblSMTPServer.Size = new System.Drawing.Size(72, 13);
            this.lblSMTPServer.TabIndex = 37;
            this.lblSMTPServer.Text = "SMTP Server:";
            // 
            // lblFromEmail
            // 
            this.lblFromEmail.AutoSize = true;
            this.lblFromEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFromEmail.Location = new System.Drawing.Point(196, 20);
            this.lblFromEmail.Name = "lblFromEmail";
            this.lblFromEmail.Size = new System.Drawing.Size(62, 13);
            this.lblFromEmail.TabIndex = 36;
            this.lblFromEmail.Text = "From Email:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPort.Location = new System.Drawing.Point(411, 48);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(91, 13);
            this.lblPort.TabIndex = 35;
            this.lblPort.Text = "Port (25 default):";
            // 
            // chkEnableSSL
            // 
            this.chkEnableSSL.AutoSize = true;
            this.chkEnableSSL.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.chkServerRequiresAuth.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkServerRequiresAuth.Location = new System.Drawing.Point(262, 69);
            this.chkServerRequiresAuth.Name = "chkServerRequiresAuth";
            this.chkServerRequiresAuth.Size = new System.Drawing.Size(188, 17);
            this.chkServerRequiresAuth.TabIndex = 33;
            this.chkServerRequiresAuth.Text = "My server requires authentication";
            this.chkServerRequiresAuth.UseVisualStyleBackColor = true;
            // 
            // nudEmailOutgoingPortNumber
            // 
            this.nudEmailOutgoingPortNumber.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudEmailOutgoingPortNumber.Location = new System.Drawing.Point(503, 44);
            this.nudEmailOutgoingPortNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudEmailOutgoingPortNumber.Name = "nudEmailOutgoingPortNumber";
            this.nudEmailOutgoingPortNumber.Size = new System.Drawing.Size(47, 21);
            this.nudEmailOutgoingPortNumber.TabIndex = 32;
            this.nudEmailOutgoingPortNumber.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // txtSMTPServer
            // 
            this.txtSMTPServer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSMTPServer.Location = new System.Drawing.Point(262, 43);
            this.txtSMTPServer.Name = "txtSMTPServer";
            this.txtSMTPServer.Size = new System.Drawing.Size(143, 21);
            this.txtSMTPServer.TabIndex = 31;
            // 
            // txtFromEmail
            // 
            this.txtFromEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFromEmail.Location = new System.Drawing.Point(262, 16);
            this.txtFromEmail.Name = "txtFromEmail";
            this.txtFromEmail.Size = new System.Drawing.Size(285, 21);
            this.txtFromEmail.TabIndex = 30;
            // 
            // lblSuccessEmail
            // 
            this.lblSuccessEmail.AutoSize = true;
            this.lblSuccessEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSuccessEmail.Location = new System.Drawing.Point(6, 22);
            this.lblSuccessEmail.Name = "lblSuccessEmail";
            this.lblSuccessEmail.Size = new System.Drawing.Size(88, 13);
            this.lblSuccessEmail.TabIndex = 29;
            this.lblSuccessEmail.Text = "Successful Email:";
            // 
            // lblFailureEmail
            // 
            this.lblFailureEmail.AutoSize = true;
            this.lblFailureEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFailureEmail.Location = new System.Drawing.Point(5, 65);
            this.lblFailureEmail.Name = "lblFailureEmail";
            this.lblFailureEmail.Size = new System.Drawing.Size(70, 13);
            this.lblFailureEmail.TabIndex = 27;
            this.lblFailureEmail.Text = "Failure Email:";
            // 
            // txtFailureEmail
            // 
            this.txtFailureEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFailureEmail.Location = new System.Drawing.Point(6, 83);
            this.txtFailureEmail.Name = "txtFailureEmail";
            this.txtFailureEmail.Size = new System.Drawing.Size(149, 21);
            this.txtFailureEmail.TabIndex = 28;
            // 
            // txtSuccessEmail
            // 
            this.txtSuccessEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSuccessEmail.Location = new System.Drawing.Point(6, 40);
            this.txtSuccessEmail.Name = "txtSuccessEmail";
            this.txtSuccessEmail.Size = new System.Drawing.Size(150, 21);
            this.txtSuccessEmail.TabIndex = 27;
            // 
            // lblMonths
            // 
            this.lblMonths.AutoSize = true;
            this.lblMonths.Location = new System.Drawing.Point(213, 189);
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.Size = new System.Drawing.Size(42, 13);
            this.lblMonths.TabIndex = 22;
            this.lblMonths.Text = "Months";
            // 
            // gbWorkingDirectories
            // 
            this.gbWorkingDirectories.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbWorkingDirectories.Controls.Add(this.cmdDevFilesLocation);
            this.gbWorkingDirectories.Controls.Add(this.lblDevFilesLocation);
            this.gbWorkingDirectories.Controls.Add(this.txtDevFilesLocation);
            this.gbWorkingDirectories.Controls.Add(this.cmdDevelopmentZips);
            this.gbWorkingDirectories.Controls.Add(this.lblDevelopmentZips);
            this.gbWorkingDirectories.Controls.Add(this.txtDevelopmentZips);
            this.gbWorkingDirectories.Controls.Add(this.cmdSQLDBFiles);
            this.gbWorkingDirectories.Controls.Add(this.cmdScratch);
            this.gbWorkingDirectories.Controls.Add(this.cmdBackupZips);
            this.gbWorkingDirectories.Controls.Add(this.lblSqlDBFiles);
            this.gbWorkingDirectories.Controls.Add(this.lblDBBackupZips);
            this.gbWorkingDirectories.Controls.Add(this.lblScratch);
            this.gbWorkingDirectories.Controls.Add(this.txtBackupZips);
            this.gbWorkingDirectories.Controls.Add(this.txtScratchPad);
            this.gbWorkingDirectories.Controls.Add(this.txtSQLFileLocations);
            this.gbWorkingDirectories.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbWorkingDirectories.Location = new System.Drawing.Point(10, 6);
            this.gbWorkingDirectories.Name = "gbWorkingDirectories";
            this.gbWorkingDirectories.Size = new System.Drawing.Size(556, 176);
            this.gbWorkingDirectories.TabIndex = 21;
            this.gbWorkingDirectories.TabStop = false;
            this.gbWorkingDirectories.Text = "Working Directories";
            // 
            // cmdDevFilesLocation
            // 
            this.cmdDevFilesLocation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmdDevFilesLocation.Location = new System.Drawing.Point(513, 130);
            this.cmdDevFilesLocation.Name = "cmdDevFilesLocation";
            this.cmdDevFilesLocation.Size = new System.Drawing.Size(38, 23);
            this.cmdDevFilesLocation.TabIndex = 33;
            this.cmdDevFilesLocation.Text = "...";
            this.cmdDevFilesLocation.UseVisualStyleBackColor = true;
            this.cmdDevFilesLocation.Click += new System.EventHandler(this.cmdDevFilesLocation_Click);
            // 
            // lblDevFilesLocation
            // 
            this.lblDevFilesLocation.AutoSize = true;
            this.lblDevFilesLocation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDevFilesLocation.Location = new System.Drawing.Point(2, 136);
            this.lblDevFilesLocation.Name = "lblDevFilesLocation";
            this.lblDevFilesLocation.Size = new System.Drawing.Size(97, 13);
            this.lblDevFilesLocation.TabIndex = 32;
            this.lblDevFilesLocation.Text = "Dev. Files Location";
            // 
            // txtDevFilesLocation
            // 
            this.txtDevFilesLocation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDevFilesLocation.Location = new System.Drawing.Point(104, 132);
            this.txtDevFilesLocation.Name = "txtDevFilesLocation";
            this.txtDevFilesLocation.Size = new System.Drawing.Size(403, 21);
            this.txtDevFilesLocation.TabIndex = 31;
            // 
            // cmdDevelopmentZips
            // 
            this.cmdDevelopmentZips.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmdDevelopmentZips.Location = new System.Drawing.Point(513, 103);
            this.cmdDevelopmentZips.Name = "cmdDevelopmentZips";
            this.cmdDevelopmentZips.Size = new System.Drawing.Size(38, 23);
            this.cmdDevelopmentZips.TabIndex = 30;
            this.cmdDevelopmentZips.Text = "...";
            this.cmdDevelopmentZips.UseVisualStyleBackColor = true;
            this.cmdDevelopmentZips.Click += new System.EventHandler(this.cmdDevelopmentZips_Click);
            // 
            // lblDevelopmentZips
            // 
            this.lblDevelopmentZips.AutoSize = true;
            this.lblDevelopmentZips.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDevelopmentZips.Location = new System.Drawing.Point(3, 109);
            this.lblDevelopmentZips.Name = "lblDevelopmentZips";
            this.lblDevelopmentZips.Size = new System.Drawing.Size(96, 13);
            this.lblDevelopmentZips.TabIndex = 29;
            this.lblDevelopmentZips.Text = "Development Zips:";
            // 
            // txtDevelopmentZips
            // 
            this.txtDevelopmentZips.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDevelopmentZips.Location = new System.Drawing.Point(104, 105);
            this.txtDevelopmentZips.Name = "txtDevelopmentZips";
            this.txtDevelopmentZips.Size = new System.Drawing.Size(403, 21);
            this.txtDevelopmentZips.TabIndex = 28;
            // 
            // cmdSQLDBFiles
            // 
            this.cmdSQLDBFiles.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmdSQLDBFiles.Location = new System.Drawing.Point(513, 76);
            this.cmdSQLDBFiles.Name = "cmdSQLDBFiles";
            this.cmdSQLDBFiles.Size = new System.Drawing.Size(38, 23);
            this.cmdSQLDBFiles.TabIndex = 26;
            this.cmdSQLDBFiles.Text = "...";
            this.cmdSQLDBFiles.UseVisualStyleBackColor = true;
            this.cmdSQLDBFiles.Click += new System.EventHandler(this.cmdSQLDBFiles_Click);
            // 
            // cmdScratch
            // 
            this.cmdScratch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmdScratch.Location = new System.Drawing.Point(513, 49);
            this.cmdScratch.Name = "cmdScratch";
            this.cmdScratch.Size = new System.Drawing.Size(38, 23);
            this.cmdScratch.TabIndex = 25;
            this.cmdScratch.Text = "...";
            this.cmdScratch.UseVisualStyleBackColor = true;
            this.cmdScratch.Click += new System.EventHandler(this.cmdScratch_Click);
            // 
            // cmdBackupZips
            // 
            this.cmdBackupZips.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmdBackupZips.Location = new System.Drawing.Point(513, 24);
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
            this.lblSqlDBFiles.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSqlDBFiles.Location = new System.Drawing.Point(29, 81);
            this.lblSqlDBFiles.Name = "lblSqlDBFiles";
            this.lblSqlDBFiles.Size = new System.Drawing.Size(70, 13);
            this.lblSqlDBFiles.TabIndex = 23;
            this.lblSqlDBFiles.Text = "SQL DB Files:";
            // 
            // lblDBBackupZips
            // 
            this.lblDBBackupZips.AutoSize = true;
            this.lblDBBackupZips.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDBBackupZips.Location = new System.Drawing.Point(16, 28);
            this.lblDBBackupZips.Name = "lblDBBackupZips";
            this.lblDBBackupZips.Size = new System.Drawing.Size(83, 13);
            this.lblDBBackupZips.TabIndex = 22;
            this.lblDBBackupZips.Text = "DB Backup Zips:";
            // 
            // lblScratch
            // 
            this.lblScratch.AutoSize = true;
            this.lblScratch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScratch.ForeColor = System.Drawing.Color.Maroon;
            this.lblScratch.Location = new System.Drawing.Point(31, 54);
            this.lblScratch.Name = "lblScratch";
            this.lblScratch.Size = new System.Drawing.Size(68, 13);
            this.lblScratch.TabIndex = 21;
            this.lblScratch.Text = "Scratch Pad:";
            // 
            // txtBackupZips
            // 
            this.txtBackupZips.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBackupZips.Location = new System.Drawing.Point(104, 24);
            this.txtBackupZips.Name = "txtBackupZips";
            this.txtBackupZips.Size = new System.Drawing.Size(403, 21);
            this.txtBackupZips.TabIndex = 18;
            // 
            // txtScratchPad
            // 
            this.txtScratchPad.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtScratchPad.Location = new System.Drawing.Point(104, 51);
            this.txtScratchPad.Name = "txtScratchPad";
            this.txtScratchPad.Size = new System.Drawing.Size(403, 21);
            this.txtScratchPad.TabIndex = 20;
            // 
            // txtSQLFileLocations
            // 
            this.txtSQLFileLocations.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSQLFileLocations.Location = new System.Drawing.Point(104, 78);
            this.txtSQLFileLocations.Name = "txtSQLFileLocations";
            this.txtSQLFileLocations.Size = new System.Drawing.Size(403, 21);
            this.txtSQLFileLocations.TabIndex = 19;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(298, 192);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(31, 13);
            this.lblDays.TabIndex = 17;
            this.lblDays.Text = "Days";
            // 
            // nudDays
            // 
            this.nudDays.Location = new System.Drawing.Point(257, 188);
            this.nudDays.Name = "nudDays";
            this.nudDays.Size = new System.Drawing.Size(36, 21);
            this.nudDays.TabIndex = 16;
            // 
            // nudMonths
            // 
            this.nudMonths.Location = new System.Drawing.Point(172, 188);
            this.nudMonths.Name = "nudMonths";
            this.nudMonths.Size = new System.Drawing.Size(36, 21);
            this.nudMonths.TabIndex = 14;
            // 
            // lblHowLongTokeep
            // 
            this.lblHowLongTokeep.AutoSize = true;
            this.lblHowLongTokeep.Location = new System.Drawing.Point(13, 192);
            this.lblHowLongTokeep.Name = "lblHowLongTokeep";
            this.lblHowLongTokeep.Size = new System.Drawing.Size(153, 13);
            this.lblHowLongTokeep.TabIndex = 13;
            this.lblHowLongTokeep.Text = "How long to keep backup files:";
            // 
            // tabFTPSchduler
            // 
            this.tabFTPSchduler.Controls.Add(this.grpScheduleJog);
            this.tabFTPSchduler.Controls.Add(this.grbFTP);
            this.tabFTPSchduler.Location = new System.Drawing.Point(4, 22);
            this.tabFTPSchduler.Name = "tabFTPSchduler";
            this.tabFTPSchduler.Padding = new System.Windows.Forms.Padding(3);
            this.tabFTPSchduler.Size = new System.Drawing.Size(572, 368);
            this.tabFTPSchduler.TabIndex = 3;
            this.tabFTPSchduler.Text = "FTP and Scheduler";
            this.tabFTPSchduler.UseVisualStyleBackColor = true;
            // 
            // grpScheduleJog
            // 
            this.grpScheduleJog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpScheduleJog.Controls.Add(this.lblWTSJobStart);
            this.grpScheduleJog.Controls.Add(this.lblJobStart);
            this.grpScheduleJog.Controls.Add(this.dateTimePicker1);
            this.grpScheduleJog.Controls.Add(this.chkScheduleToRunDaily);
            this.grpScheduleJog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpScheduleJog.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpScheduleJog.Location = new System.Drawing.Point(3, 251);
            this.grpScheduleJog.Name = "grpScheduleJog";
            this.grpScheduleJog.Size = new System.Drawing.Size(566, 114);
            this.grpScheduleJog.TabIndex = 1;
            this.grpScheduleJog.TabStop = false;
            this.grpScheduleJog.Text = "Scheduling";
            // 
            // lblWTSJobStart
            // 
            this.lblWTSJobStart.AutoSize = true;
            this.lblWTSJobStart.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWTSJobStart.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblWTSJobStart.Location = new System.Drawing.Point(265, 62);
            this.lblWTSJobStart.Name = "lblWTSJobStart";
            this.lblWTSJobStart.Size = new System.Drawing.Size(205, 13);
            this.lblWTSJobStart.TabIndex = 45;
            this.lblWTSJobStart.Text = "Windows Task Scheduler will start the job";
            // 
            // lblJobStart
            // 
            this.lblJobStart.AutoSize = true;
            this.lblJobStart.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblJobStart.Location = new System.Drawing.Point(102, 62);
            this.lblJobStart.Name = "lblJobStart";
            this.lblJobStart.Size = new System.Drawing.Size(55, 13);
            this.lblJobStart.TabIndex = 43;
            this.lblJobStart.Text = "Job Start:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(164, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 21);
            this.dateTimePicker1.TabIndex = 44;
            // 
            // chkScheduleToRunDaily
            // 
            this.chkScheduleToRunDaily.AutoSize = true;
            this.chkScheduleToRunDaily.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkScheduleToRunDaily.Location = new System.Drawing.Point(106, 35);
            this.chkScheduleToRunDaily.Name = "chkScheduleToRunDaily";
            this.chkScheduleToRunDaily.Size = new System.Drawing.Size(164, 17);
            this.chkScheduleToRunDaily.TabIndex = 43;
            this.chkScheduleToRunDaily.Text = "Schedule to run this job daily";
            this.chkScheduleToRunDaily.UseVisualStyleBackColor = true;
            // 
            // grbFTP
            // 
            this.grbFTP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grbFTP.Controls.Add(this.cmdTestFTPTransfer);
            this.grbFTP.Controls.Add(this.chkFTPWriteSessionLog);
            this.grbFTP.Controls.Add(this.chkFTPUseFTPSettings);
            this.grbFTP.Controls.Add(this.lblRemoteFolder);
            this.grbFTP.Controls.Add(this.txtFTPRemoteFolder);
            this.grbFTP.Controls.Add(this.lblFTPPort);
            this.grbFTP.Controls.Add(this.nudFTPPort);
            this.grbFTP.Controls.Add(this.lblFTPPassword);
            this.grbFTP.Controls.Add(this.txtFTPPassword);
            this.grbFTP.Controls.Add(this.lblFTPUserName);
            this.grbFTP.Controls.Add(this.txtFTPUserName);
            this.grbFTP.Controls.Add(this.lblFTPExample);
            this.grbFTP.Controls.Add(this.lblFTPHostAddress);
            this.grbFTP.Controls.Add(this.txtFTPHostAddress);
            this.grbFTP.Controls.Add(this.lblFTPMonths);
            this.grbFTP.Controls.Add(this.lblFTPDays);
            this.grbFTP.Controls.Add(this.nudFTPDays);
            this.grbFTP.Controls.Add(this.nudFTPMonths);
            this.grbFTP.Controls.Add(this.lblHowLogToKeepFTPFiles);
            this.grbFTP.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbFTP.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbFTP.Location = new System.Drawing.Point(3, 3);
            this.grbFTP.Name = "grbFTP";
            this.grbFTP.Size = new System.Drawing.Size(566, 242);
            this.grbFTP.TabIndex = 0;
            this.grbFTP.TabStop = false;
            this.grbFTP.Text = "FTP Settings";
            // 
            // cmdTestFTPTransfer
            // 
            this.cmdTestFTPTransfer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmdTestFTPTransfer.Location = new System.Drawing.Point(419, 66);
            this.cmdTestFTPTransfer.Name = "cmdTestFTPTransfer";
            this.cmdTestFTPTransfer.Size = new System.Drawing.Size(120, 23);
            this.cmdTestFTPTransfer.TabIndex = 43;
            this.cmdTestFTPTransfer.Text = "Test FTP Transfer";
            this.cmdTestFTPTransfer.UseVisualStyleBackColor = true;
            this.cmdTestFTPTransfer.Click += new System.EventHandler(this.cmdTestFTPTransfer_Click);
            // 
            // chkFTPWriteSessionLog
            // 
            this.chkFTPWriteSessionLog.AutoSize = true;
            this.chkFTPWriteSessionLog.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkFTPWriteSessionLog.Location = new System.Drawing.Point(117, 205);
            this.chkFTPWriteSessionLog.Name = "chkFTPWriteSessionLog";
            this.chkFTPWriteSessionLog.Size = new System.Drawing.Size(132, 17);
            this.chkFTPWriteSessionLog.TabIndex = 41;
            this.chkFTPWriteSessionLog.Text = "Write FTP Session Log";
            this.chkFTPWriteSessionLog.UseVisualStyleBackColor = true;
            // 
            // chkFTPUseFTPSettings
            // 
            this.chkFTPUseFTPSettings.AutoSize = true;
            this.chkFTPUseFTPSettings.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkFTPUseFTPSettings.Location = new System.Drawing.Point(90, 0);
            this.chkFTPUseFTPSettings.Name = "chkFTPUseFTPSettings";
            this.chkFTPUseFTPSettings.Size = new System.Drawing.Size(15, 14);
            this.chkFTPUseFTPSettings.TabIndex = 40;
            this.chkFTPUseFTPSettings.UseVisualStyleBackColor = true;
            // 
            // lblRemoteFolder
            // 
            this.lblRemoteFolder.AutoSize = true;
            this.lblRemoteFolder.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRemoteFolder.Location = new System.Drawing.Point(38, 177);
            this.lblRemoteFolder.Name = "lblRemoteFolder";
            this.lblRemoteFolder.Size = new System.Drawing.Size(74, 13);
            this.lblRemoteFolder.TabIndex = 39;
            this.lblRemoteFolder.Text = "RemoteFolder";
            // 
            // txtFTPRemoteFolder
            // 
            this.txtFTPRemoteFolder.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFTPRemoteFolder.Location = new System.Drawing.Point(117, 173);
            this.txtFTPRemoteFolder.Name = "txtFTPRemoteFolder";
            this.txtFTPRemoteFolder.Size = new System.Drawing.Size(295, 21);
            this.txtFTPRemoteFolder.TabIndex = 38;
            // 
            // lblFTPPort
            // 
            this.lblFTPPort.AutoSize = true;
            this.lblFTPPort.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFTPPort.Location = new System.Drawing.Point(81, 146);
            this.lblFTPPort.Name = "lblFTPPort";
            this.lblFTPPort.Size = new System.Drawing.Size(31, 13);
            this.lblFTPPort.TabIndex = 37;
            this.lblFTPPort.Text = "Port:";
            // 
            // nudFTPPort
            // 
            this.nudFTPPort.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudFTPPort.Location = new System.Drawing.Point(114, 143);
            this.nudFTPPort.Name = "nudFTPPort";
            this.nudFTPPort.Size = new System.Drawing.Size(70, 21);
            this.nudFTPPort.TabIndex = 35;
            this.nudFTPPort.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // lblFTPPassword
            // 
            this.lblFTPPassword.AutoSize = true;
            this.lblFTPPassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFTPPassword.Location = new System.Drawing.Point(211, 117);
            this.lblFTPPassword.Name = "lblFTPPassword";
            this.lblFTPPassword.Size = new System.Drawing.Size(57, 13);
            this.lblFTPPassword.TabIndex = 34;
            this.lblFTPPassword.Text = "Password:";
            // 
            // txtFTPPassword
            // 
            this.txtFTPPassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFTPPassword.Location = new System.Drawing.Point(270, 114);
            this.txtFTPPassword.Name = "txtFTPPassword";
            this.txtFTPPassword.Size = new System.Drawing.Size(139, 21);
            this.txtFTPPassword.TabIndex = 33;
            // 
            // lblFTPUserName
            // 
            this.lblFTPUserName.AutoSize = true;
            this.lblFTPUserName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFTPUserName.Location = new System.Drawing.Point(49, 117);
            this.lblFTPUserName.Name = "lblFTPUserName";
            this.lblFTPUserName.Size = new System.Drawing.Size(63, 13);
            this.lblFTPUserName.TabIndex = 32;
            this.lblFTPUserName.Text = "User Name:";
            // 
            // txtFTPUserName
            // 
            this.txtFTPUserName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFTPUserName.Location = new System.Drawing.Point(114, 114);
            this.txtFTPUserName.Name = "txtFTPUserName";
            this.txtFTPUserName.Size = new System.Drawing.Size(91, 21);
            this.txtFTPUserName.TabIndex = 31;
            // 
            // lblFTPExample
            // 
            this.lblFTPExample.AutoSize = true;
            this.lblFTPExample.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFTPExample.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFTPExample.Location = new System.Drawing.Point(114, 92);
            this.lblFTPExample.Name = "lblFTPExample";
            this.lblFTPExample.Size = new System.Drawing.Size(246, 13);
            this.lblFTPExample.TabIndex = 30;
            this.lblFTPExample.Text = "e.g. MyFTPServer.com or ftp://MyFTPServer.com";
            // 
            // lblFTPHostAddress
            // 
            this.lblFTPHostAddress.AutoSize = true;
            this.lblFTPHostAddress.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFTPHostAddress.Location = new System.Drawing.Point(37, 71);
            this.lblFTPHostAddress.Name = "lblFTPHostAddress";
            this.lblFTPHostAddress.Size = new System.Drawing.Size(75, 13);
            this.lblFTPHostAddress.TabIndex = 29;
            this.lblFTPHostAddress.Text = "Host Address:";
            // 
            // txtFTPHostAddress
            // 
            this.txtFTPHostAddress.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFTPHostAddress.Location = new System.Drawing.Point(114, 68);
            this.txtFTPHostAddress.Name = "txtFTPHostAddress";
            this.txtFTPHostAddress.Size = new System.Drawing.Size(295, 21);
            this.txtFTPHostAddress.TabIndex = 28;
            // 
            // lblFTPMonths
            // 
            this.lblFTPMonths.AutoSize = true;
            this.lblFTPMonths.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFTPMonths.Location = new System.Drawing.Point(222, 43);
            this.lblFTPMonths.Name = "lblFTPMonths";
            this.lblFTPMonths.Size = new System.Drawing.Size(42, 13);
            this.lblFTPMonths.TabIndex = 27;
            this.lblFTPMonths.Text = "Months";
            // 
            // lblFTPDays
            // 
            this.lblFTPDays.AutoSize = true;
            this.lblFTPDays.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFTPDays.Location = new System.Drawing.Point(307, 43);
            this.lblFTPDays.Name = "lblFTPDays";
            this.lblFTPDays.Size = new System.Drawing.Size(31, 13);
            this.lblFTPDays.TabIndex = 26;
            this.lblFTPDays.Text = "Days";
            // 
            // nudFTPDays
            // 
            this.nudFTPDays.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudFTPDays.Location = new System.Drawing.Point(266, 39);
            this.nudFTPDays.Name = "nudFTPDays";
            this.nudFTPDays.Size = new System.Drawing.Size(36, 21);
            this.nudFTPDays.TabIndex = 25;
            // 
            // nudFTPMonths
            // 
            this.nudFTPMonths.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudFTPMonths.Location = new System.Drawing.Point(181, 39);
            this.nudFTPMonths.Name = "nudFTPMonths";
            this.nudFTPMonths.Size = new System.Drawing.Size(36, 21);
            this.nudFTPMonths.TabIndex = 24;
            // 
            // lblHowLogToKeepFTPFiles
            // 
            this.lblHowLogToKeepFTPFiles.AutoSize = true;
            this.lblHowLogToKeepFTPFiles.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHowLogToKeepFTPFiles.Location = new System.Drawing.Point(22, 43);
            this.lblHowLogToKeepFTPFiles.Name = "lblHowLogToKeepFTPFiles";
            this.lblHowLogToKeepFTPFiles.Size = new System.Drawing.Size(139, 13);
            this.lblHowLogToKeepFTPFiles.TabIndex = 23;
            this.lblHowLogToKeepFTPFiles.Text = "How long to keep FTP Files:";
            // 
            // fbdDevelopmentZips
            // 
            this.fbdDevelopmentZips.HelpRequest += new System.EventHandler(this.dbdDevZipDirectory_HelpRequest);
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(605, 584);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabRestore.ResumeLayout(false);
            this.grpRestore.ResumeLayout(false);
            this.grpRestore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabDevelopment.ResumeLayout(false);
            this.tabDevelopment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevelopmentDirectories)).EndInit();
            this.tabConfiguration.ResumeLayout(false);
            this.tabConfiguration.PerformLayout();
            this.grpEmailConfiguration.ResumeLayout(false);
            this.grpEmailConfiguration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmailOutgoingPortNumber)).EndInit();
            this.gbWorkingDirectories.ResumeLayout(false);
            this.gbWorkingDirectories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonths)).EndInit();
            this.tabFTPSchduler.ResumeLayout(false);
            this.grpScheduleJog.ResumeLayout(false);
            this.grpScheduleJog.PerformLayout();
            this.grbFTP.ResumeLayout(false);
            this.grbFTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFTPPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFTPDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFTPMonths)).EndInit();
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
        private System.Windows.Forms.Button btnBackupDb;
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
        private System.Windows.Forms.Label lblDBBackupZips;
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
        private System.Windows.Forms.NumericUpDown nudEmailOutgoingPortNumber;
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
        private System.Windows.Forms.CheckBox chkFTPWriteSessionLog;
        private System.Windows.Forms.CheckBox chkFTPUseFTPSettings;
        private System.Windows.Forms.Label lblRemoteFolder;
        private System.Windows.Forms.TextBox txtFTPRemoteFolder;
        private System.Windows.Forms.Label lblFTPPort;
        private System.Windows.Forms.NumericUpDown nudFTPPort;
        private System.Windows.Forms.Label lblFTPPassword;
        private System.Windows.Forms.TextBox txtFTPPassword;
        private System.Windows.Forms.Label lblFTPUserName;
        private System.Windows.Forms.TextBox txtFTPUserName;
        private System.Windows.Forms.Label lblFTPExample;
        private System.Windows.Forms.Label lblFTPHostAddress;
        private System.Windows.Forms.TextBox txtFTPHostAddress;
        private System.Windows.Forms.Label lblFTPMonths;
        private System.Windows.Forms.Label lblFTPDays;
        private System.Windows.Forms.NumericUpDown nudFTPDays;
        private System.Windows.Forms.NumericUpDown nudFTPMonths;
        private System.Windows.Forms.Label lblHowLogToKeepFTPFiles;
        private System.Windows.Forms.TabPage tabDevelopment;
        private System.Windows.Forms.FolderBrowserDialog fbdDevFileLocations;
        private System.Windows.Forms.FolderBrowserDialog fbdMailboxDirectory;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolstripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvDevelopmentDirectories;
        private System.Windows.Forms.Button cmdTestFTPTransfer;
        private System.Windows.Forms.Button cmdBackupDevelopmentDirectories;
        private System.Windows.Forms.CheckBox chkSkipDLLS;
        private System.Windows.Forms.Label lblDevZipName;
        private System.Windows.Forms.TextBox txtDevZipName;
        private System.Windows.Forms.DataGridView dgvDatabases;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDirectoryName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDBSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDBName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDBBackupZipName;
        private System.Windows.Forms.Button cmdDevelopmentZips;
        private System.Windows.Forms.Label lblDevelopmentZips;
        private System.Windows.Forms.TextBox txtDevelopmentZips;
        private System.Windows.Forms.Button cmdDevFilesLocation;
        private System.Windows.Forms.Label lblDevFilesLocation;
        private System.Windows.Forms.TextBox txtDevFilesLocation;
        private System.Windows.Forms.FolderBrowserDialog fbdDevelopmentZips;
        private System.Windows.Forms.CheckBox chkSkipPDBFiles;
    }
}