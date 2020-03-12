namespace ExampleClient.Source
{
    partial class DatabaseBackupManagerForm
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnTrigger = new System.Windows.Forms.Button();
            this.lvDatabaseBackups = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chInitiated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCompleted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatusReason = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHalt = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.tbxBackupPath = new System.Windows.Forms.TextBox();
            this.lblBackupPath = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblMaxBackups = new System.Windows.Forms.Label();
            this.lblBackupsInterval = new System.Windows.Forms.Label();
            this.lblBackupTime = new System.Windows.Forms.Label();
            this.dtpBackupTime = new System.Windows.Forms.DateTimePicker();
            this.nudBackupInterval = new System.Windows.Forms.NumericUpDown();
            this.nudMaxBackups = new System.Windows.Forms.NumericUpDown();
            this.btnValidate = new System.Windows.Forms.Button();
            this.gbxDatabaseBackupSettings = new System.Windows.Forms.GroupBox();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.gbxDtabaseBackups = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudBackupInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxBackups)).BeginInit();
            this.gbxDatabaseBackupSettings.SuspendLayout();
            this.gbxDtabaseBackups.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(749, 135);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 23);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(748, 48);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // btnTrigger
            // 
            this.btnTrigger.Location = new System.Drawing.Point(747, 19);
            this.btnTrigger.Name = "btnTrigger";
            this.btnTrigger.Size = new System.Drawing.Size(83, 23);
            this.btnTrigger.TabIndex = 9;
            this.btnTrigger.Text = "Trigger";
            this.btnTrigger.UseVisualStyleBackColor = true;
            this.btnTrigger.Click += new System.EventHandler(this.ButtonTrigger_Click);
            // 
            // lvDatabaseBackups
            // 
            this.lvDatabaseBackups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chInitiated,
            this.chCompleted,
            this.chStatus,
            this.chStatusReason});
            this.lvDatabaseBackups.FullRowSelect = true;
            this.lvDatabaseBackups.HideSelection = false;
            this.lvDatabaseBackups.Location = new System.Drawing.Point(6, 19);
            this.lvDatabaseBackups.MultiSelect = false;
            this.lvDatabaseBackups.Name = "lvDatabaseBackups";
            this.lvDatabaseBackups.Size = new System.Drawing.Size(735, 260);
            this.lvDatabaseBackups.TabIndex = 8;
            this.lvDatabaseBackups.UseCompatibleStateImageBehavior = false;
            this.lvDatabaseBackups.View = System.Windows.Forms.View.Details;
            // 
            // chId
            // 
            this.chId.Text = "ID";
            this.chId.Width = 208;
            // 
            // chInitiated
            // 
            this.chInitiated.Text = "Initiated";
            this.chInitiated.Width = 143;
            // 
            // chCompleted
            // 
            this.chCompleted.Text = "Completed";
            this.chCompleted.Width = 143;
            // 
            // chStatus
            // 
            this.chStatus.Text = "Status";
            this.chStatus.Width = 65;
            // 
            // chStatusReason
            // 
            this.chStatusReason.Text = "Status Reason";
            this.chStatusReason.Width = 171;
            // 
            // btnHalt
            // 
            this.btnHalt.Location = new System.Drawing.Point(748, 77);
            this.btnHalt.Name = "btnHalt";
            this.btnHalt.Size = new System.Drawing.Size(83, 23);
            this.btnHalt.TabIndex = 15;
            this.btnHalt.Text = "Halt";
            this.btnHalt.UseVisualStyleBackColor = true;
            this.btnHalt.Click += new System.EventHandler(this.ButtonHalt_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(749, 106);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(83, 23);
            this.btnRestore.TabIndex = 16;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.ButtonRestore_Click);
            // 
            // tbxBackupPath
            // 
            this.tbxBackupPath.Location = new System.Drawing.Point(81, 17);
            this.tbxBackupPath.Name = "tbxBackupPath";
            this.tbxBackupPath.Size = new System.Drawing.Size(297, 20);
            this.tbxBackupPath.TabIndex = 17;
            // 
            // lblBackupPath
            // 
            this.lblBackupPath.AutoSize = true;
            this.lblBackupPath.Location = new System.Drawing.Point(8, 21);
            this.lblBackupPath.Name = "lblBackupPath";
            this.lblBackupPath.Size = new System.Drawing.Size(69, 13);
            this.lblBackupPath.TabIndex = 18;
            this.lblBackupPath.Text = "Backup Path";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(386, 21);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 19;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(553, 21);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 20;
            this.lblPassword.Text = "Password";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(441, 17);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(104, 20);
            this.tbxUsername.TabIndex = 21;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(606, 17);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(104, 20);
            this.tbxPassword.TabIndex = 22;
            // 
            // lblMaxBackups
            // 
            this.lblMaxBackups.AutoSize = true;
            this.lblMaxBackups.Location = new System.Drawing.Point(528, 63);
            this.lblMaxBackups.Name = "lblMaxBackups";
            this.lblMaxBackups.Size = new System.Drawing.Size(72, 13);
            this.lblMaxBackups.TabIndex = 25;
            this.lblMaxBackups.Text = "Max Backups";
            // 
            // lblBackupsInterval
            // 
            this.lblBackupsInterval.AutoSize = true;
            this.lblBackupsInterval.Location = new System.Drawing.Point(247, 63);
            this.lblBackupsInterval.Name = "lblBackupsInterval";
            this.lblBackupsInterval.Size = new System.Drawing.Size(82, 13);
            this.lblBackupsInterval.TabIndex = 24;
            this.lblBackupsInterval.Text = "Backup Interval";
            // 
            // lblBackupTime
            // 
            this.lblBackupTime.AutoSize = true;
            this.lblBackupTime.Location = new System.Drawing.Point(7, 63);
            this.lblBackupTime.Name = "lblBackupTime";
            this.lblBackupTime.Size = new System.Drawing.Size(70, 13);
            this.lblBackupTime.TabIndex = 23;
            this.lblBackupTime.Text = "Backup Time";
            // 
            // dtpBackupTime
            // 
            this.dtpBackupTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpBackupTime.Location = new System.Drawing.Point(81, 59);
            this.dtpBackupTime.Name = "dtpBackupTime";
            this.dtpBackupTime.ShowUpDown = true;
            this.dtpBackupTime.Size = new System.Drawing.Size(100, 20);
            this.dtpBackupTime.TabIndex = 26;
            // 
            // nudBackupInterval
            // 
            this.nudBackupInterval.Location = new System.Drawing.Point(335, 59);
            this.nudBackupInterval.Name = "nudBackupInterval";
            this.nudBackupInterval.Size = new System.Drawing.Size(100, 20);
            this.nudBackupInterval.TabIndex = 27;
            // 
            // nudMaxBackups
            // 
            this.nudMaxBackups.Location = new System.Drawing.Point(606, 59);
            this.nudMaxBackups.Name = "nudMaxBackups";
            this.nudMaxBackups.Size = new System.Drawing.Size(100, 20);
            this.nudMaxBackups.TabIndex = 28;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(718, 16);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(119, 23);
            this.btnValidate.TabIndex = 29;
            this.btnValidate.Text = "Validate Path Settings";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.ButtonValidate_Click);
            // 
            // gbxDatabaseBackupSettings
            // 
            this.gbxDatabaseBackupSettings.Controls.Add(this.btnSaveAll);
            this.gbxDatabaseBackupSettings.Controls.Add(this.tbxUsername);
            this.gbxDatabaseBackupSettings.Controls.Add(this.nudMaxBackups);
            this.gbxDatabaseBackupSettings.Controls.Add(this.btnValidate);
            this.gbxDatabaseBackupSettings.Controls.Add(this.nudBackupInterval);
            this.gbxDatabaseBackupSettings.Controls.Add(this.tbxBackupPath);
            this.gbxDatabaseBackupSettings.Controls.Add(this.dtpBackupTime);
            this.gbxDatabaseBackupSettings.Controls.Add(this.lblMaxBackups);
            this.gbxDatabaseBackupSettings.Controls.Add(this.lblBackupPath);
            this.gbxDatabaseBackupSettings.Controls.Add(this.lblBackupsInterval);
            this.gbxDatabaseBackupSettings.Controls.Add(this.lblUsername);
            this.gbxDatabaseBackupSettings.Controls.Add(this.lblBackupTime);
            this.gbxDatabaseBackupSettings.Controls.Add(this.lblPassword);
            this.gbxDatabaseBackupSettings.Controls.Add(this.tbxPassword);
            this.gbxDatabaseBackupSettings.Location = new System.Drawing.Point(12, 12);
            this.gbxDatabaseBackupSettings.Name = "gbxDatabaseBackupSettings";
            this.gbxDatabaseBackupSettings.Size = new System.Drawing.Size(843, 94);
            this.gbxDatabaseBackupSettings.TabIndex = 30;
            this.gbxDatabaseBackupSettings.TabStop = false;
            this.gbxDatabaseBackupSettings.Text = "Database Backup Settings";
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Location = new System.Drawing.Point(718, 59);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(119, 23);
            this.btnSaveAll.TabIndex = 30;
            this.btnSaveAll.Text = "Save All Settings";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.ButtonSaveAll_Click);
            // 
            // gbxDtabaseBackups
            // 
            this.gbxDtabaseBackups.Controls.Add(this.lvDatabaseBackups);
            this.gbxDtabaseBackups.Controls.Add(this.btnTrigger);
            this.gbxDtabaseBackups.Controls.Add(this.btnRestore);
            this.gbxDtabaseBackups.Controls.Add(this.btnDelete);
            this.gbxDtabaseBackups.Controls.Add(this.btnHalt);
            this.gbxDtabaseBackups.Controls.Add(this.btnRefresh);
            this.gbxDtabaseBackups.Location = new System.Drawing.Point(12, 112);
            this.gbxDtabaseBackups.Name = "gbxDtabaseBackups";
            this.gbxDtabaseBackups.Size = new System.Drawing.Size(843, 287);
            this.gbxDtabaseBackups.TabIndex = 31;
            this.gbxDtabaseBackups.TabStop = false;
            this.gbxDtabaseBackups.Text = "Dtabase Backups";
            // 
            // DatabaseBackupManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 405);
            this.Controls.Add(this.gbxDtabaseBackups);
            this.Controls.Add(this.gbxDatabaseBackupSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatabaseBackupManagerForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Database Backup Manager";
            ((System.ComponentModel.ISupportInitialize)(this.nudBackupInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxBackups)).EndInit();
            this.gbxDatabaseBackupSettings.ResumeLayout(false);
            this.gbxDatabaseBackupSettings.PerformLayout();
            this.gbxDtabaseBackups.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnTrigger;
        private System.Windows.Forms.ListView lvDatabaseBackups;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chInitiated;
        private System.Windows.Forms.ColumnHeader chCompleted;
        private System.Windows.Forms.Button btnHalt;
        private System.Windows.Forms.ColumnHeader chStatus;
        private System.Windows.Forms.ColumnHeader chStatusReason;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.TextBox tbxBackupPath;
        private System.Windows.Forms.Label lblBackupPath;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblMaxBackups;
        private System.Windows.Forms.Label lblBackupsInterval;
        private System.Windows.Forms.Label lblBackupTime;
        private System.Windows.Forms.DateTimePicker dtpBackupTime;
        private System.Windows.Forms.NumericUpDown nudBackupInterval;
        private System.Windows.Forms.NumericUpDown nudMaxBackups;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.GroupBox gbxDatabaseBackupSettings;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.GroupBox gbxDtabaseBackups;
    }
}