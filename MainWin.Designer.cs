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
            this.grpBackup = new System.Windows.Forms.GroupBox();
            this.cmdShrinkLogFile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbBackupMode = new System.Windows.Forms.ComboBox();
            this.btnBackupDb = new System.Windows.Forms.Button();
            this.txtFileToBackUp = new System.Windows.Forms.TextBox();
            this.cmbBackupDb = new System.Windows.Forms.ComboBox();
            this.lblBackupMode = new System.Windows.Forms.Label();
            this.lblBackupFileName = new System.Windows.Forms.Label();
            this.lblDb = new System.Windows.Forms.Label();
            this.txtBackupSql = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpRestore = new System.Windows.Forms.GroupBox();
            this.cmdGetZipFile = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chckReplace = new System.Windows.Forms.CheckBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.txtFileToRestore = new System.Windows.Forms.TextBox();
            this.lblBackupFile = new System.Windows.Forms.Label();
            this.openBakFile = new System.Windows.Forms.OpenFileDialog();
            this.saveBakFile = new System.Windows.Forms.SaveFileDialog();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progBar = new System.Windows.Forms.ToolStripProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtLogFile = new System.Windows.Forms.TextBox();
            this.lblLogFile = new System.Windows.Forms.Label();
            this.cmdShow = new System.Windows.Forms.Button();
            this.cmdViewInNotepad = new System.Windows.Forms.Button();
            this.lblHowLongTokeep = new System.Windows.Forms.Label();
            this.nudMonths = new System.Windows.Forms.NumericUpDown();
            this.lblMonths = new System.Windows.Forms.Label();
            this.nudDays = new System.Windows.Forms.NumericUpDown();
            this.lblDays = new System.Windows.Forms.Label();
            this.grpBackup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpRestore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpStatus.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBackup
            // 
            this.grpBackup.Controls.Add(this.lblDays);
            this.grpBackup.Controls.Add(this.nudDays);
            this.grpBackup.Controls.Add(this.lblMonths);
            this.grpBackup.Controls.Add(this.nudMonths);
            this.grpBackup.Controls.Add(this.lblHowLongTokeep);
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
            this.grpBackup.Size = new System.Drawing.Size(419, 164);
            this.grpBackup.TabIndex = 0;
            this.grpBackup.TabStop = false;
            this.grpBackup.Text = "Backup";
            // 
            // cmdShrinkLogFile
            // 
            this.cmdShrinkLogFile.Location = new System.Drawing.Point(160, 104);
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
            this.pictureBox1.Location = new System.Drawing.Point(9, 20);
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
            this.cmbBackupMode.Location = new System.Drawing.Point(161, 74);
            this.cmbBackupMode.Name = "cmbBackupMode";
            this.cmbBackupMode.Size = new System.Drawing.Size(125, 21);
            this.cmbBackupMode.TabIndex = 5;
            // 
            // btnBackupDb
            // 
            this.btnBackupDb.Location = new System.Drawing.Point(262, 104);
            this.btnBackupDb.Name = "btnBackupDb";
            this.btnBackupDb.Size = new System.Drawing.Size(67, 23);
            this.btnBackupDb.TabIndex = 3;
            this.btnBackupDb.Text = "Backup";
            this.btnBackupDb.UseVisualStyleBackColor = true;
            this.btnBackupDb.Click += new System.EventHandler(this.btnBackupDb_Click);
            // 
            // txtFileToBackUp
            // 
            this.txtFileToBackUp.Location = new System.Drawing.Point(161, 47);
            this.txtFileToBackUp.Name = "txtFileToBackUp";
            this.txtFileToBackUp.ReadOnly = true;
            this.txtFileToBackUp.Size = new System.Drawing.Size(257, 21);
            this.txtFileToBackUp.TabIndex = 2;
            // 
            // cmbBackupDb
            // 
            this.cmbBackupDb.DisplayMember = "Name";
            this.cmbBackupDb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBackupDb.FormattingEnabled = true;
            this.cmbBackupDb.Location = new System.Drawing.Point(161, 20);
            this.cmbBackupDb.Name = "cmbBackupDb";
            this.cmbBackupDb.Size = new System.Drawing.Size(184, 21);
            this.cmbBackupDb.TabIndex = 1;
            this.cmbBackupDb.ValueMember = "ID";
            this.cmbBackupDb.SelectionChangeCommitted += new System.EventHandler(this.cmbBackupDb_SelectionChangeCommitted);
            // 
            // lblBackupMode
            // 
            this.lblBackupMode.AutoSize = true;
            this.lblBackupMode.Location = new System.Drawing.Point(82, 77);
            this.lblBackupMode.Name = "lblBackupMode";
            this.lblBackupMode.Size = new System.Drawing.Size(74, 13);
            this.lblBackupMode.TabIndex = 0;
            this.lblBackupMode.Text = "Backup mode:";
            // 
            // lblBackupFileName
            // 
            this.lblBackupFileName.AutoSize = true;
            this.lblBackupFileName.Location = new System.Drawing.Point(62, 50);
            this.lblBackupFileName.Name = "lblBackupFileName";
            this.lblBackupFileName.Size = new System.Drawing.Size(94, 13);
            this.lblBackupFileName.TabIndex = 0;
            this.lblBackupFileName.Text = "Backup File Name:";
            // 
            // lblDb
            // 
            this.lblDb.AutoSize = true;
            this.lblDb.Location = new System.Drawing.Point(101, 23);
            this.lblDb.Name = "lblDb";
            this.lblDb.Size = new System.Drawing.Size(55, 13);
            this.lblDb.TabIndex = 0;
            this.lblDb.Text = "Select db:";
            // 
            // txtBackupSql
            // 
            this.txtBackupSql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBackupSql.Location = new System.Drawing.Point(3, 17);
            this.txtBackupSql.Multiline = true;
            this.txtBackupSql.Name = "txtBackupSql";
            this.txtBackupSql.ReadOnly = true;
            this.txtBackupSql.Size = new System.Drawing.Size(844, 106);
            this.txtBackupSql.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.grpBackup, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpRestore, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(850, 170);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // grpRestore
            // 
            this.grpRestore.Controls.Add(this.cmdGetZipFile);
            this.grpRestore.Controls.Add(this.pictureBox2);
            this.grpRestore.Controls.Add(this.chckReplace);
            this.grpRestore.Controls.Add(this.btnRestore);
            this.grpRestore.Controls.Add(this.txtFileToRestore);
            this.grpRestore.Controls.Add(this.lblBackupFile);
            this.grpRestore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRestore.Location = new System.Drawing.Point(428, 3);
            this.grpRestore.Name = "grpRestore";
            this.grpRestore.Size = new System.Drawing.Size(419, 164);
            this.grpRestore.TabIndex = 1;
            this.grpRestore.TabStop = false;
            this.grpRestore.Text = "Restore";
            // 
            // cmdGetZipFile
            // 
            this.cmdGetZipFile.Location = new System.Drawing.Point(133, 18);
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
            this.pictureBox2.Location = new System.Drawing.Point(6, 20);
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
            this.chckReplace.Location = new System.Drawing.Point(133, 74);
            this.chckReplace.Name = "chckReplace";
            this.chckReplace.Size = new System.Drawing.Size(64, 17);
            this.chckReplace.TabIndex = 5;
            this.chckReplace.Text = "Replace";
            this.chckReplace.UseVisualStyleBackColor = true;
            // 
            // btnRestore
            // 
            this.btnRestore.Enabled = false;
            this.btnRestore.Location = new System.Drawing.Point(130, 97);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(67, 23);
            this.btnRestore.TabIndex = 3;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // txtFileToRestore
            // 
            this.txtFileToRestore.Location = new System.Drawing.Point(133, 47);
            this.txtFileToRestore.Name = "txtFileToRestore";
            this.txtFileToRestore.ReadOnly = true;
            this.txtFileToRestore.Size = new System.Drawing.Size(277, 21);
            this.txtFileToRestore.TabIndex = 2;
            // 
            // lblBackupFile
            // 
            this.lblBackupFile.AutoSize = true;
            this.lblBackupFile.Location = new System.Drawing.Point(64, 51);
            this.lblBackupFile.Name = "lblBackupFile";
            this.lblBackupFile.Size = new System.Drawing.Size(64, 13);
            this.lblBackupFile.TabIndex = 0;
            this.lblBackupFile.Text = "Backup File:";
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
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.txtBackupSql);
            this.grpStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpStatus.Location = new System.Drawing.Point(0, 170);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(850, 126);
            this.grpStatus.TabIndex = 2;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Sql script";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.progBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 488);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(850, 22);
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtLogFile
            // 
            this.txtLogFile.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogFile.Location = new System.Drawing.Point(3, 323);
            this.txtLogFile.Multiline = true;
            this.txtLogFile.Name = "txtLogFile";
            this.txtLogFile.ReadOnly = true;
            this.txtLogFile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLogFile.Size = new System.Drawing.Size(844, 148);
            this.txtLogFile.TabIndex = 4;
            this.txtLogFile.WordWrap = false;
            // 
            // lblLogFile
            // 
            this.lblLogFile.AutoSize = true;
            this.lblLogFile.Location = new System.Drawing.Point(6, 302);
            this.lblLogFile.Name = "lblLogFile";
            this.lblLogFile.Size = new System.Drawing.Size(40, 13);
            this.lblLogFile.TabIndex = 5;
            this.lblLogFile.Text = "LogFile";
            // 
            // cmdShow
            // 
            this.cmdShow.Location = new System.Drawing.Point(50, 296);
            this.cmdShow.Name = "cmdShow";
            this.cmdShow.Size = new System.Drawing.Size(75, 23);
            this.cmdShow.TabIndex = 6;
            this.cmdShow.Text = "Show";
            this.cmdShow.UseVisualStyleBackColor = true;
            this.cmdShow.Click += new System.EventHandler(this.cmdShow_Click);
            // 
            // cmdViewInNotepad
            // 
            this.cmdViewInNotepad.Location = new System.Drawing.Point(131, 296);
            this.cmdViewInNotepad.Name = "cmdViewInNotepad";
            this.cmdViewInNotepad.Size = new System.Drawing.Size(113, 23);
            this.cmdViewInNotepad.TabIndex = 7;
            this.cmdViewInNotepad.Text = "View In Notepad";
            this.cmdViewInNotepad.UseVisualStyleBackColor = true;
            this.cmdViewInNotepad.Click += new System.EventHandler(this.cmdViewInNotepad_Click);
            // 
            // lblHowLongTokeep
            // 
            this.lblHowLongTokeep.AutoSize = true;
            this.lblHowLongTokeep.Location = new System.Drawing.Point(6, 136);
            this.lblHowLongTokeep.Name = "lblHowLongTokeep";
            this.lblHowLongTokeep.Size = new System.Drawing.Size(149, 13);
            this.lblHowLongTokeep.TabIndex = 8;
            this.lblHowLongTokeep.Text = "How long to keep backup files";
            // 
            // nudMonths
            // 
            this.nudMonths.Location = new System.Drawing.Point(162, 134);
            this.nudMonths.Name = "nudMonths";
            this.nudMonths.Size = new System.Drawing.Size(36, 21);
            this.nudMonths.TabIndex = 9;
            // 
            // lblMonths
            // 
            this.lblMonths.AutoSize = true;
            this.lblMonths.Location = new System.Drawing.Point(201, 136);
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.Size = new System.Drawing.Size(42, 13);
            this.lblMonths.TabIndex = 10;
            this.lblMonths.Text = "Months";
            // 
            // nudDays
            // 
            this.nudDays.Location = new System.Drawing.Point(250, 134);
            this.nudDays.Name = "nudDays";
            this.nudDays.Size = new System.Drawing.Size(36, 21);
            this.nudDays.TabIndex = 11;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(292, 136);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(31, 13);
            this.lblDays.TabIndex = 12;
            this.lblDays.Text = "Days";
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 510);
            this.Controls.Add(this.cmdViewInNotepad);
            this.Controls.Add(this.cmdShow);
            this.Controls.Add(this.lblLogFile);
            this.Controls.Add(this.txtLogFile);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpStatus);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWin";
            this.Text = "SqlServer Backup/Restore Utility";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWin_FormClosing);
            this.grpBackup.ResumeLayout(false);
            this.grpBackup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpRestore.ResumeLayout(false);
            this.grpRestore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBackup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpRestore;
        private System.Windows.Forms.ComboBox cmbBackupDb;
        private System.Windows.Forms.Label lblDb;
        private System.Windows.Forms.OpenFileDialog openBakFile;
        private System.Windows.Forms.TextBox txtFileToBackUp;
        private System.Windows.Forms.Label lblBackupFileName;
        private System.Windows.Forms.SaveFileDialog saveBakFile;
        private System.Windows.Forms.TextBox txtFileToRestore;
        private System.Windows.Forms.Label lblBackupFile;
        private System.Windows.Forms.Button btnBackupDb;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.ComboBox cmbBackupMode;
        private System.Windows.Forms.TextBox txtBackupSql;
        private System.Windows.Forms.Label lblBackupMode;
        private System.Windows.Forms.CheckBox chckReplace;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar progBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button cmdGetZipFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button cmdShrinkLogFile;
        private System.Windows.Forms.TextBox txtLogFile;
        private System.Windows.Forms.Label lblLogFile;
        private System.Windows.Forms.Button cmdShow;
        private System.Windows.Forms.Button cmdViewInNotepad;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.NumericUpDown nudDays;
        private System.Windows.Forms.Label lblMonths;
        private System.Windows.Forms.NumericUpDown nudMonths;
        private System.Windows.Forms.Label lblHowLongTokeep;
    }
}