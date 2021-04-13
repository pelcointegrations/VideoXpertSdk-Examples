namespace ExampleClient.Source
{
    partial class ModifyReportTemplateForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cbxReportType = new System.Windows.Forms.ComboBox();
            this.lblReportType = new System.Windows.Forms.Label();
            this.lblFormat = new System.Windows.Forms.Label();
            this.tbxFormat = new System.Windows.Forms.TextBox();
            this.tvFields = new System.Windows.Forms.TreeView();
            this.gbxIncludeColumns = new System.Windows.Forms.GroupBox();
            this.lvFilters = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxIncludeRows = new System.Windows.Forms.GroupBox();
            this.btnModifySelection = new System.Windows.Forms.Button();
            this.chbxSelectAll = new System.Windows.Forms.CheckBox();
            this.cbxTimeRange = new System.Windows.Forms.ComboBox();
            this.lblTimeRange = new System.Windows.Forms.Label();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.cbxLanguage = new System.Windows.Forms.ComboBox();
            this.chbxAutoGenerate = new System.Windows.Forms.CheckBox();
            this.chbxMon = new System.Windows.Forms.CheckBox();
            this.chbxTue = new System.Windows.Forms.CheckBox();
            this.chbxWed = new System.Windows.Forms.CheckBox();
            this.chbxThu = new System.Windows.Forms.CheckBox();
            this.chbxFri = new System.Windows.Forms.CheckBox();
            this.chbxSun = new System.Windows.Forms.CheckBox();
            this.chbxSat = new System.Windows.Forms.CheckBox();
            this.lblEvery = new System.Windows.Forms.Label();
            this.lblAt = new System.Windows.Forms.Label();
            this.dtpAtTime = new System.Windows.Forms.DateTimePicker();
            this.tbxPath = new System.Windows.Forms.TextBox();
            this.chbxAutoExport = new System.Windows.Forms.CheckBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblInterval = new System.Windows.Forms.Label();
            this.cbxInterval = new System.Windows.Forms.ComboBox();
            this.pnlAutoGenerate = new System.Windows.Forms.Panel();
            this.pnlAutoExport = new System.Windows.Forms.Panel();
            this.pnlTimes = new System.Windows.Forms.Panel();
            this.pnlTimeRange = new System.Windows.Forms.Panel();
            this.pnlInterval = new System.Windows.Forms.Panel();
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.gbxIncludeColumns.SuspendLayout();
            this.gbxIncludeRows.SuspendLayout();
            this.pnlAutoGenerate.SuspendLayout();
            this.pnlAutoExport.SuspendLayout();
            this.pnlTimes.SuspendLayout();
            this.pnlTimeRange.SuspendLayout();
            this.pnlInterval.SuspendLayout();
            this.pnlGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(469, 568);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(550, 568);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(89, 2);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(175, 20);
            this.tbxName.TabIndex = 36;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(22, 5);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 13);
            this.lblName.TabIndex = 35;
            this.lblName.Text = "Name: ";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxReportType
            // 
            this.cbxReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxReportType.FormattingEnabled = true;
            this.cbxReportType.Location = new System.Drawing.Point(108, 6);
            this.cbxReportType.Name = "cbxReportType";
            this.cbxReportType.Size = new System.Drawing.Size(175, 21);
            this.cbxReportType.TabIndex = 37;
            this.cbxReportType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxReportType_SelectedIndexChanged);
            // 
            // lblReportType
            // 
            this.lblReportType.Location = new System.Drawing.Point(12, 9);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(90, 13);
            this.lblReportType.TabIndex = 38;
            this.lblReportType.Text = "Report Type: ";
            this.lblReportType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFormat
            // 
            this.lblFormat.Location = new System.Drawing.Point(22, 31);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(61, 13);
            this.lblFormat.TabIndex = 39;
            this.lblFormat.Text = "Format: ";
            this.lblFormat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxFormat
            // 
            this.tbxFormat.Location = new System.Drawing.Point(89, 28);
            this.tbxFormat.Name = "tbxFormat";
            this.tbxFormat.Size = new System.Drawing.Size(175, 20);
            this.tbxFormat.TabIndex = 40;
            // 
            // tvFields
            // 
            this.tvFields.CheckBoxes = true;
            this.tvFields.Location = new System.Drawing.Point(6, 19);
            this.tvFields.Name = "tvFields";
            this.tvFields.Size = new System.Drawing.Size(258, 304);
            this.tvFields.TabIndex = 41;
            // 
            // gbxIncludeColumns
            // 
            this.gbxIncludeColumns.Controls.Add(this.tvFields);
            this.gbxIncludeColumns.Enabled = false;
            this.gbxIncludeColumns.Location = new System.Drawing.Point(31, 233);
            this.gbxIncludeColumns.Name = "gbxIncludeColumns";
            this.gbxIncludeColumns.Size = new System.Drawing.Size(270, 329);
            this.gbxIncludeColumns.TabIndex = 42;
            this.gbxIncludeColumns.TabStop = false;
            this.gbxIncludeColumns.Text = "Include Info (columns)";
            // 
            // lvFilters
            // 
            this.lvFilters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName});
            this.lvFilters.GridLines = true;
            this.lvFilters.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvFilters.Location = new System.Drawing.Point(6, 19);
            this.lvFilters.MultiSelect = false;
            this.lvFilters.Name = "lvFilters";
            this.lvFilters.Size = new System.Drawing.Size(303, 281);
            this.lvFilters.TabIndex = 43;
            this.lvFilters.UseCompatibleStateImageBehavior = false;
            this.lvFilters.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "";
            this.chName.Width = 298;
            // 
            // gbxIncludeRows
            // 
            this.gbxIncludeRows.Controls.Add(this.btnModifySelection);
            this.gbxIncludeRows.Controls.Add(this.chbxSelectAll);
            this.gbxIncludeRows.Controls.Add(this.lvFilters);
            this.gbxIncludeRows.Enabled = false;
            this.gbxIncludeRows.Location = new System.Drawing.Point(307, 233);
            this.gbxIncludeRows.Name = "gbxIncludeRows";
            this.gbxIncludeRows.Size = new System.Drawing.Size(319, 329);
            this.gbxIncludeRows.TabIndex = 44;
            this.gbxIncludeRows.TabStop = false;
            this.gbxIncludeRows.Text = "Include (rows)";
            // 
            // btnModifySelection
            // 
            this.btnModifySelection.Location = new System.Drawing.Point(201, 302);
            this.btnModifySelection.Name = "btnModifySelection";
            this.btnModifySelection.Size = new System.Drawing.Size(108, 23);
            this.btnModifySelection.TabIndex = 75;
            this.btnModifySelection.Text = "Modify Selection";
            this.btnModifySelection.UseVisualStyleBackColor = true;
            this.btnModifySelection.Click += new System.EventHandler(this.ButtonModifySelection_Click);
            // 
            // chbxSelectAll
            // 
            this.chbxSelectAll.AutoSize = true;
            this.chbxSelectAll.Location = new System.Drawing.Point(15, 306);
            this.chbxSelectAll.Name = "chbxSelectAll";
            this.chbxSelectAll.Size = new System.Drawing.Size(101, 17);
            this.chbxSelectAll.TabIndex = 74;
            this.chbxSelectAll.Text = "Use All Sources";
            this.chbxSelectAll.UseVisualStyleBackColor = true;
            this.chbxSelectAll.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // cbxTimeRange
            // 
            this.cbxTimeRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTimeRange.FormattingEnabled = true;
            this.cbxTimeRange.Items.AddRange(new object[] {
            "Last 24 hours",
            "Last week",
            "Last month",
            "Last year",
            "Custom"});
            this.cbxTimeRange.Location = new System.Drawing.Point(89, 3);
            this.cbxTimeRange.Name = "cbxTimeRange";
            this.cbxTimeRange.Size = new System.Drawing.Size(175, 21);
            this.cbxTimeRange.TabIndex = 45;
            this.cbxTimeRange.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTimeRange_SelectedIndexChanged);
            // 
            // lblTimeRange
            // 
            this.lblTimeRange.AutoSize = true;
            this.lblTimeRange.Location = new System.Drawing.Point(15, 6);
            this.lblTimeRange.Name = "lblTimeRange";
            this.lblTimeRange.Size = new System.Drawing.Size(68, 13);
            this.lblTimeRange.TabIndex = 46;
            this.lblTimeRange.Text = "Time Range:";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "hh:mm:ss tt  MM/dd/yyyy";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(89, 3);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(175, 20);
            this.dtpStartTime.TabIndex = 47;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "hh:mm:ss tt  MM/dd/yyyy";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(89, 29);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(175, 20);
            this.dtpEndTime.TabIndex = 48;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(25, 7);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(58, 13);
            this.lblStartTime.TabIndex = 49;
            this.lblStartTime.Text = "Start Time:";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(28, 33);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(55, 13);
            this.lblEndTime.TabIndex = 50;
            this.lblEndTime.Text = "End Time:";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(25, 58);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(58, 13);
            this.lblLanguage.TabIndex = 52;
            this.lblLanguage.Text = "Language:";
            // 
            // cbxLanguage
            // 
            this.cbxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLanguage.FormattingEnabled = true;
            this.cbxLanguage.Items.AddRange(new object[] {
            "Arabic",
            "Bulgarian",
            "Chinese",
            "Croatian",
            "Czech",
            "English",
            "French",
            "German",
            "Hungarian",
            "Italian",
            "Japanese",
            "Korean",
            "Polish",
            "Portuguese",
            "Romanian",
            "Russian",
            "Spanish",
            "Turkish"});
            this.cbxLanguage.Location = new System.Drawing.Point(89, 54);
            this.cbxLanguage.Name = "cbxLanguage";
            this.cbxLanguage.Size = new System.Drawing.Size(175, 21);
            this.cbxLanguage.TabIndex = 51;
            // 
            // chbxAutoGenerate
            // 
            this.chbxAutoGenerate.AutoSize = true;
            this.chbxAutoGenerate.Enabled = false;
            this.chbxAutoGenerate.Location = new System.Drawing.Point(307, 2);
            this.chbxAutoGenerate.Name = "chbxAutoGenerate";
            this.chbxAutoGenerate.Size = new System.Drawing.Size(189, 17);
            this.chbxAutoGenerate.TabIndex = 53;
            this.chbxAutoGenerate.Text = "Automatically Generate this Report";
            this.chbxAutoGenerate.UseVisualStyleBackColor = true;
            this.chbxAutoGenerate.CheckedChanged += new System.EventHandler(this.CheckBoxRecurrence_CheckedChanged);
            // 
            // chbxMon
            // 
            this.chbxMon.AutoSize = true;
            this.chbxMon.Location = new System.Drawing.Point(45, 8);
            this.chbxMon.Name = "chbxMon";
            this.chbxMon.Size = new System.Drawing.Size(50, 17);
            this.chbxMon.TabIndex = 54;
            this.chbxMon.Text = "Mon.";
            this.chbxMon.UseVisualStyleBackColor = true;
            this.chbxMon.CheckedChanged += new System.EventHandler(this.CheckBoxRecurrence_CheckedChanged);
            // 
            // chbxTue
            // 
            this.chbxTue.AutoSize = true;
            this.chbxTue.Location = new System.Drawing.Point(100, 8);
            this.chbxTue.Name = "chbxTue";
            this.chbxTue.Size = new System.Drawing.Size(48, 17);
            this.chbxTue.TabIndex = 55;
            this.chbxTue.Text = "Tue.";
            this.chbxTue.UseVisualStyleBackColor = true;
            this.chbxTue.CheckedChanged += new System.EventHandler(this.CheckBoxRecurrence_CheckedChanged);
            // 
            // chbxWed
            // 
            this.chbxWed.AutoSize = true;
            this.chbxWed.Location = new System.Drawing.Point(153, 8);
            this.chbxWed.Name = "chbxWed";
            this.chbxWed.Size = new System.Drawing.Size(52, 17);
            this.chbxWed.TabIndex = 56;
            this.chbxWed.Text = "Wed.";
            this.chbxWed.UseVisualStyleBackColor = true;
            this.chbxWed.CheckedChanged += new System.EventHandler(this.CheckBoxRecurrence_CheckedChanged);
            // 
            // chbxThu
            // 
            this.chbxThu.AutoSize = true;
            this.chbxThu.Location = new System.Drawing.Point(210, 8);
            this.chbxThu.Name = "chbxThu";
            this.chbxThu.Size = new System.Drawing.Size(48, 17);
            this.chbxThu.TabIndex = 57;
            this.chbxThu.Text = "Thu.";
            this.chbxThu.UseVisualStyleBackColor = true;
            this.chbxThu.CheckedChanged += new System.EventHandler(this.CheckBoxRecurrence_CheckedChanged);
            // 
            // chbxFri
            // 
            this.chbxFri.AutoSize = true;
            this.chbxFri.Location = new System.Drawing.Point(45, 31);
            this.chbxFri.Name = "chbxFri";
            this.chbxFri.Size = new System.Drawing.Size(40, 17);
            this.chbxFri.TabIndex = 58;
            this.chbxFri.Text = "Fri.";
            this.chbxFri.UseVisualStyleBackColor = true;
            this.chbxFri.CheckedChanged += new System.EventHandler(this.CheckBoxRecurrence_CheckedChanged);
            // 
            // chbxSun
            // 
            this.chbxSun.AutoSize = true;
            this.chbxSun.Location = new System.Drawing.Point(153, 31);
            this.chbxSun.Name = "chbxSun";
            this.chbxSun.Size = new System.Drawing.Size(48, 17);
            this.chbxSun.TabIndex = 59;
            this.chbxSun.Text = "Sun.";
            this.chbxSun.UseVisualStyleBackColor = true;
            this.chbxSun.CheckedChanged += new System.EventHandler(this.CheckBoxRecurrence_CheckedChanged);
            // 
            // chbxSat
            // 
            this.chbxSat.AutoSize = true;
            this.chbxSat.Location = new System.Drawing.Point(100, 31);
            this.chbxSat.Name = "chbxSat";
            this.chbxSat.Size = new System.Drawing.Size(45, 17);
            this.chbxSat.TabIndex = 60;
            this.chbxSat.Text = "Sat.";
            this.chbxSat.UseVisualStyleBackColor = true;
            this.chbxSat.CheckedChanged += new System.EventHandler(this.CheckBoxRecurrence_CheckedChanged);
            // 
            // lblEvery
            // 
            this.lblEvery.AutoSize = true;
            this.lblEvery.Location = new System.Drawing.Point(3, 8);
            this.lblEvery.Name = "lblEvery";
            this.lblEvery.Size = new System.Drawing.Size(37, 13);
            this.lblEvery.TabIndex = 61;
            this.lblEvery.Text = "Every:";
            // 
            // lblAt
            // 
            this.lblAt.AutoSize = true;
            this.lblAt.Location = new System.Drawing.Point(19, 63);
            this.lblAt.Name = "lblAt";
            this.lblAt.Size = new System.Drawing.Size(20, 13);
            this.lblAt.TabIndex = 63;
            this.lblAt.Text = "At:";
            // 
            // dtpAtTime
            // 
            this.dtpAtTime.CustomFormat = "HH:mm:ss ";
            this.dtpAtTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpAtTime.Location = new System.Drawing.Point(45, 59);
            this.dtpAtTime.Name = "dtpAtTime";
            this.dtpAtTime.ShowUpDown = true;
            this.dtpAtTime.Size = new System.Drawing.Size(86, 20);
            this.dtpAtTime.TabIndex = 62;
            // 
            // tbxPath
            // 
            this.tbxPath.Location = new System.Drawing.Point(84, 3);
            this.tbxPath.Name = "tbxPath";
            this.tbxPath.Size = new System.Drawing.Size(204, 20);
            this.tbxPath.TabIndex = 64;
            // 
            // chbxAutoExport
            // 
            this.chbxAutoExport.AutoSize = true;
            this.chbxAutoExport.Enabled = false;
            this.chbxAutoExport.Location = new System.Drawing.Point(307, 110);
            this.chbxAutoExport.Name = "chbxAutoExport";
            this.chbxAutoExport.Size = new System.Drawing.Size(121, 17);
            this.chbxAutoExport.TabIndex = 66;
            this.chbxAutoExport.Text = "Automatically Export";
            this.chbxAutoExport.UseVisualStyleBackColor = true;
            this.chbxAutoExport.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(6, 7);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(75, 13);
            this.lblPath.TabIndex = 67;
            this.lblPath.Text = "Network Path:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(36, 36);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(113, 13);
            this.lblUsername.TabIndex = 69;
            this.lblUsername.Text = "Username (if required):";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(153, 33);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(135, 20);
            this.tbxUsername.TabIndex = 68;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(38, 63);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(111, 13);
            this.lblPassword.TabIndex = 71;
            this.lblPassword.Text = "Password (if required):";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(153, 60);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(135, 20);
            this.tbxPassword.TabIndex = 70;
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(38, 7);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(45, 13);
            this.lblInterval.TabIndex = 73;
            this.lblInterval.Text = "Interval:";
            // 
            // cbxInterval
            // 
            this.cbxInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxInterval.FormattingEnabled = true;
            this.cbxInterval.Items.AddRange(new object[] {
            "1 Hour",
            "1 Day",
            "1 Month"});
            this.cbxInterval.Location = new System.Drawing.Point(89, 4);
            this.cbxInterval.Name = "cbxInterval";
            this.cbxInterval.Size = new System.Drawing.Size(175, 21);
            this.cbxInterval.TabIndex = 72;
            // 
            // pnlAutoGenerate
            // 
            this.pnlAutoGenerate.Controls.Add(this.lblEvery);
            this.pnlAutoGenerate.Controls.Add(this.chbxMon);
            this.pnlAutoGenerate.Controls.Add(this.chbxTue);
            this.pnlAutoGenerate.Controls.Add(this.chbxWed);
            this.pnlAutoGenerate.Controls.Add(this.chbxThu);
            this.pnlAutoGenerate.Controls.Add(this.chbxFri);
            this.pnlAutoGenerate.Controls.Add(this.chbxSun);
            this.pnlAutoGenerate.Controls.Add(this.chbxSat);
            this.pnlAutoGenerate.Controls.Add(this.dtpAtTime);
            this.pnlAutoGenerate.Controls.Add(this.lblAt);
            this.pnlAutoGenerate.Enabled = false;
            this.pnlAutoGenerate.Location = new System.Drawing.Point(322, 18);
            this.pnlAutoGenerate.Name = "pnlAutoGenerate";
            this.pnlAutoGenerate.Size = new System.Drawing.Size(259, 83);
            this.pnlAutoGenerate.TabIndex = 74;
            // 
            // pnlAutoExport
            // 
            this.pnlAutoExport.Controls.Add(this.lblPath);
            this.pnlAutoExport.Controls.Add(this.tbxPath);
            this.pnlAutoExport.Controls.Add(this.tbxUsername);
            this.pnlAutoExport.Controls.Add(this.lblUsername);
            this.pnlAutoExport.Controls.Add(this.lblPassword);
            this.pnlAutoExport.Controls.Add(this.tbxPassword);
            this.pnlAutoExport.Enabled = false;
            this.pnlAutoExport.Location = new System.Drawing.Point(322, 135);
            this.pnlAutoExport.Name = "pnlAutoExport";
            this.pnlAutoExport.Size = new System.Drawing.Size(303, 86);
            this.pnlAutoExport.TabIndex = 75;
            // 
            // pnlTimes
            // 
            this.pnlTimes.Controls.Add(this.dtpStartTime);
            this.pnlTimes.Controls.Add(this.dtpEndTime);
            this.pnlTimes.Controls.Add(this.lblStartTime);
            this.pnlTimes.Controls.Add(this.lblEndTime);
            this.pnlTimes.Enabled = false;
            this.pnlTimes.Location = new System.Drawing.Point(19, 172);
            this.pnlTimes.Name = "pnlTimes";
            this.pnlTimes.Size = new System.Drawing.Size(282, 55);
            this.pnlTimes.TabIndex = 76;
            // 
            // pnlTimeRange
            // 
            this.pnlTimeRange.Controls.Add(this.cbxTimeRange);
            this.pnlTimeRange.Controls.Add(this.lblTimeRange);
            this.pnlTimeRange.Enabled = false;
            this.pnlTimeRange.Location = new System.Drawing.Point(19, 141);
            this.pnlTimeRange.Name = "pnlTimeRange";
            this.pnlTimeRange.Size = new System.Drawing.Size(282, 28);
            this.pnlTimeRange.TabIndex = 77;
            // 
            // pnlInterval
            // 
            this.pnlInterval.Controls.Add(this.lblInterval);
            this.pnlInterval.Controls.Add(this.cbxInterval);
            this.pnlInterval.Enabled = false;
            this.pnlInterval.Location = new System.Drawing.Point(19, 110);
            this.pnlInterval.Name = "pnlInterval";
            this.pnlInterval.Size = new System.Drawing.Size(282, 29);
            this.pnlInterval.TabIndex = 78;
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.Controls.Add(this.lblName);
            this.pnlGeneral.Controls.Add(this.tbxName);
            this.pnlGeneral.Controls.Add(this.tbxFormat);
            this.pnlGeneral.Controls.Add(this.lblFormat);
            this.pnlGeneral.Controls.Add(this.cbxLanguage);
            this.pnlGeneral.Controls.Add(this.lblLanguage);
            this.pnlGeneral.Enabled = false;
            this.pnlGeneral.Location = new System.Drawing.Point(19, 29);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(282, 78);
            this.pnlGeneral.TabIndex = 79;
            // 
            // ModifyReportTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 596);
            this.Controls.Add(this.pnlGeneral);
            this.Controls.Add(this.pnlInterval);
            this.Controls.Add(this.pnlTimeRange);
            this.Controls.Add(this.pnlTimes);
            this.Controls.Add(this.pnlAutoExport);
            this.Controls.Add(this.pnlAutoGenerate);
            this.Controls.Add(this.chbxAutoExport);
            this.Controls.Add(this.chbxAutoGenerate);
            this.Controls.Add(this.gbxIncludeRows);
            this.Controls.Add(this.gbxIncludeColumns);
            this.Controls.Add(this.lblReportType);
            this.Controls.Add(this.cbxReportType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyReportTemplateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Report Template";
            this.gbxIncludeColumns.ResumeLayout(false);
            this.gbxIncludeRows.ResumeLayout(false);
            this.gbxIncludeRows.PerformLayout();
            this.pnlAutoGenerate.ResumeLayout(false);
            this.pnlAutoGenerate.PerformLayout();
            this.pnlAutoExport.ResumeLayout(false);
            this.pnlAutoExport.PerformLayout();
            this.pnlTimes.ResumeLayout(false);
            this.pnlTimes.PerformLayout();
            this.pnlTimeRange.ResumeLayout(false);
            this.pnlTimeRange.PerformLayout();
            this.pnlInterval.ResumeLayout(false);
            this.pnlInterval.PerformLayout();
            this.pnlGeneral.ResumeLayout(false);
            this.pnlGeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cbxReportType;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.TextBox tbxFormat;
        private System.Windows.Forms.TreeView tvFields;
        private System.Windows.Forms.GroupBox gbxIncludeColumns;
        private System.Windows.Forms.ListView lvFilters;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.GroupBox gbxIncludeRows;
        private System.Windows.Forms.ComboBox cbxTimeRange;
        private System.Windows.Forms.Label lblTimeRange;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.ComboBox cbxLanguage;
        private System.Windows.Forms.CheckBox chbxAutoGenerate;
        private System.Windows.Forms.CheckBox chbxMon;
        private System.Windows.Forms.CheckBox chbxTue;
        private System.Windows.Forms.CheckBox chbxWed;
        private System.Windows.Forms.CheckBox chbxThu;
        private System.Windows.Forms.CheckBox chbxFri;
        private System.Windows.Forms.CheckBox chbxSun;
        private System.Windows.Forms.CheckBox chbxSat;
        private System.Windows.Forms.Label lblEvery;
        private System.Windows.Forms.Label lblAt;
        private System.Windows.Forms.DateTimePicker dtpAtTime;
        private System.Windows.Forms.TextBox tbxPath;
        private System.Windows.Forms.CheckBox chbxAutoExport;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.CheckBox chbxSelectAll;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.ComboBox cbxInterval;
        private System.Windows.Forms.Panel pnlAutoGenerate;
        private System.Windows.Forms.Panel pnlAutoExport;
        private System.Windows.Forms.Button btnModifySelection;
        private System.Windows.Forms.Panel pnlTimes;
        private System.Windows.Forms.Panel pnlTimeRange;
        private System.Windows.Forms.Panel pnlInterval;
        private System.Windows.Forms.Panel pnlGeneral;
    }
}