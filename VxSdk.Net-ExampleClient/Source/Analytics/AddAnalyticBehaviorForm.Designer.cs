namespace ExampleClient.Source
{
    partial class AddAnalyticBehaviorForm
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
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxSettings = new System.Windows.Forms.GroupBox();
            this.lblBehaviorType = new System.Windows.Forms.Label();
            this.lblObjectType = new System.Windows.Forms.Label();
            this.cbxBehaviorType = new System.Windows.Forms.ComboBox();
            this.cbxObjectType = new System.Windows.Forms.ComboBox();
            this.lblSeverity = new System.Windows.Forms.Label();
            this.nudSeverity = new System.Windows.Forms.NumericUpDown();
            this.lblName = new System.Windows.Forms.Label();
            this.ckbxIsEnabled = new System.Windows.Forms.CheckBox();
            this.gbxObjectCounter = new System.Windows.Forms.GroupBox();
            this.cbxLineCounterTypes = new System.Windows.Forms.ComboBox();
            this.lblRightCountLabel = new System.Windows.Forms.Label();
            this.tbxRightCountLabel = new System.Windows.Forms.TextBox();
            this.lblLeftCountLabel = new System.Windows.Forms.Label();
            this.lblLineCounterType = new System.Windows.Forms.Label();
            this.ckbxIsEventsEnabled = new System.Windows.Forms.CheckBox();
            this.gbxStartPoint = new System.Windows.Forms.GroupBox();
            this.nudStartPointX = new System.Windows.Forms.NumericUpDown();
            this.lblStartPointY = new System.Windows.Forms.Label();
            this.nudStartPointY = new System.Windows.Forms.NumericUpDown();
            this.lblStartPointX = new System.Windows.Forms.Label();
            this.tbxLeftCountLabel = new System.Windows.Forms.TextBox();
            this.nudMaxCountThreshold = new System.Windows.Forms.NumericUpDown();
            this.lblMaxCountThreshold = new System.Windows.Forms.Label();
            this.nudEventWindow = new System.Windows.Forms.NumericUpDown();
            this.lblEventWindow = new System.Windows.Forms.Label();
            this.gbxEndPoint = new System.Windows.Forms.GroupBox();
            this.nudEndPointX = new System.Windows.Forms.NumericUpDown();
            this.lblEndPointY = new System.Windows.Forms.Label();
            this.nudEndPointY = new System.Windows.Forms.NumericUpDown();
            this.lblEndPointX = new System.Windows.Forms.Label();
            this.gbxObjectInZone = new System.Windows.Forms.GroupBox();
            this.gbxVertices = new System.Windows.Forms.GroupBox();
            this.lvObjectInZonePoints = new System.Windows.Forms.ListView();
            this.chBlank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.btnRemovePoint = new System.Windows.Forms.Button();
            this.gbxObjectWrongWayZone = new System.Windows.Forms.GroupBox();
            this.gbxZonePoints = new System.Windows.Forms.GroupBox();
            this.lvObjectWrongWayZonePoints = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemoveZonePoint = new System.Windows.Forms.Button();
            this.btnAddZonePoint = new System.Windows.Forms.Button();
            this.gbxZoneVector = new System.Windows.Forms.GroupBox();
            this.nudVectorY = new System.Windows.Forms.NumericUpDown();
            this.nudVectorAngle = new System.Windows.Forms.NumericUpDown();
            this.lblVectorY = new System.Windows.Forms.Label();
            this.lblVectorAngle = new System.Windows.Forms.Label();
            this.nudVectorX = new System.Windows.Forms.NumericUpDown();
            this.lblVectorX = new System.Windows.Forms.Label();
            this.nudMinTriggerAngle = new System.Windows.Forms.NumericUpDown();
            this.lblMinTriggerAngle = new System.Windows.Forms.Label();
            this.gbxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeverity)).BeginInit();
            this.gbxObjectCounter.SuspendLayout();
            this.gbxStartPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartPointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxCountThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEventWindow)).BeginInit();
            this.gbxEndPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndPointY)).BeginInit();
            this.gbxObjectInZone.SuspendLayout();
            this.gbxVertices.SuspendLayout();
            this.gbxObjectWrongWayZone.SuspendLayout();
            this.gbxZonePoints.SuspendLayout();
            this.gbxZoneVector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVectorY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVectorAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVectorX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinTriggerAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(74, 18);
            this.tbxName.MaxLength = 255;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(149, 20);
            this.tbxName.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(172, 581);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(91, 581);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // gbxSettings
            // 
            this.gbxSettings.Controls.Add(this.lblBehaviorType);
            this.gbxSettings.Controls.Add(this.lblObjectType);
            this.gbxSettings.Controls.Add(this.cbxBehaviorType);
            this.gbxSettings.Controls.Add(this.cbxObjectType);
            this.gbxSettings.Controls.Add(this.lblSeverity);
            this.gbxSettings.Controls.Add(this.nudSeverity);
            this.gbxSettings.Controls.Add(this.lblName);
            this.gbxSettings.Controls.Add(this.tbxName);
            this.gbxSettings.Controls.Add(this.ckbxIsEnabled);
            this.gbxSettings.Location = new System.Drawing.Point(13, 12);
            this.gbxSettings.Name = "gbxSettings";
            this.gbxSettings.Size = new System.Drawing.Size(234, 155);
            this.gbxSettings.TabIndex = 21;
            this.gbxSettings.TabStop = false;
            this.gbxSettings.Text = "Settings";
            // 
            // lblBehaviorType
            // 
            this.lblBehaviorType.AutoSize = true;
            this.lblBehaviorType.Location = new System.Drawing.Point(19, 131);
            this.lblBehaviorType.Name = "lblBehaviorType";
            this.lblBehaviorType.Size = new System.Drawing.Size(52, 13);
            this.lblBehaviorType.TabIndex = 10;
            this.lblBehaviorType.Text = "Behavior:";
            // 
            // lblObjectType
            // 
            this.lblObjectType.AutoSize = true;
            this.lblObjectType.Location = new System.Drawing.Point(3, 101);
            this.lblObjectType.Name = "lblObjectType";
            this.lblObjectType.Size = new System.Drawing.Size(68, 13);
            this.lblObjectType.TabIndex = 9;
            this.lblObjectType.Text = "Object Type:";
            this.lblObjectType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxBehaviorType
            // 
            this.cbxBehaviorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBehaviorType.FormattingEnabled = true;
            this.cbxBehaviorType.Items.AddRange(new object[] {
            "Object Line Counter",
            "Object In Zone",
            "Object Wrong Way Zone"});
            this.cbxBehaviorType.Location = new System.Drawing.Point(74, 128);
            this.cbxBehaviorType.Name = "cbxBehaviorType";
            this.cbxBehaviorType.Size = new System.Drawing.Size(149, 21);
            this.cbxBehaviorType.TabIndex = 8;
            this.cbxBehaviorType.SelectedIndexChanged += new System.EventHandler(this.CheckboxBehaviorType_SelectedIndexChanged);
            // 
            // cbxObjectType
            // 
            this.cbxObjectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxObjectType.FormattingEnabled = true;
            this.cbxObjectType.Items.AddRange(new object[] {
            "Person",
            "Vehicle"});
            this.cbxObjectType.Location = new System.Drawing.Point(74, 98);
            this.cbxObjectType.Name = "cbxObjectType";
            this.cbxObjectType.Size = new System.Drawing.Size(73, 21);
            this.cbxObjectType.TabIndex = 7;
            // 
            // lblSeverity
            // 
            this.lblSeverity.AutoSize = true;
            this.lblSeverity.Location = new System.Drawing.Point(23, 71);
            this.lblSeverity.Name = "lblSeverity";
            this.lblSeverity.Size = new System.Drawing.Size(48, 13);
            this.lblSeverity.TabIndex = 6;
            this.lblSeverity.Text = "Severity:";
            // 
            // nudSeverity
            // 
            this.nudSeverity.Location = new System.Drawing.Point(74, 69);
            this.nudSeverity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSeverity.Name = "nudSeverity";
            this.nudSeverity.Size = new System.Drawing.Size(40, 20);
            this.nudSeverity.TabIndex = 4;
            this.nudSeverity.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(33, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // ckbxIsEnabled
            // 
            this.ckbxIsEnabled.AutoSize = true;
            this.ckbxIsEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbxIsEnabled.Checked = true;
            this.ckbxIsEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbxIsEnabled.Location = new System.Drawing.Point(21, 46);
            this.ckbxIsEnabled.Name = "ckbxIsEnabled";
            this.ckbxIsEnabled.Size = new System.Drawing.Size(68, 17);
            this.ckbxIsEnabled.TabIndex = 0;
            this.ckbxIsEnabled.Text = "Enabled:";
            this.ckbxIsEnabled.UseVisualStyleBackColor = true;
            // 
            // gbxObjectCounter
            // 
            this.gbxObjectCounter.Controls.Add(this.cbxLineCounterTypes);
            this.gbxObjectCounter.Controls.Add(this.lblRightCountLabel);
            this.gbxObjectCounter.Controls.Add(this.tbxRightCountLabel);
            this.gbxObjectCounter.Controls.Add(this.lblLeftCountLabel);
            this.gbxObjectCounter.Controls.Add(this.lblLineCounterType);
            this.gbxObjectCounter.Controls.Add(this.ckbxIsEventsEnabled);
            this.gbxObjectCounter.Controls.Add(this.gbxStartPoint);
            this.gbxObjectCounter.Controls.Add(this.tbxLeftCountLabel);
            this.gbxObjectCounter.Controls.Add(this.nudMaxCountThreshold);
            this.gbxObjectCounter.Controls.Add(this.lblMaxCountThreshold);
            this.gbxObjectCounter.Controls.Add(this.nudEventWindow);
            this.gbxObjectCounter.Controls.Add(this.lblEventWindow);
            this.gbxObjectCounter.Controls.Add(this.gbxEndPoint);
            this.gbxObjectCounter.Location = new System.Drawing.Point(13, 173);
            this.gbxObjectCounter.Name = "gbxObjectCounter";
            this.gbxObjectCounter.Size = new System.Drawing.Size(234, 402);
            this.gbxObjectCounter.TabIndex = 22;
            this.gbxObjectCounter.TabStop = false;
            this.gbxObjectCounter.Text = "Object Line Counter Settings";
            // 
            // cbxLineCounterTypes
            // 
            this.cbxLineCounterTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLineCounterTypes.FormattingEnabled = true;
            this.cbxLineCounterTypes.Items.AddRange(new object[] {
            "Unidirectional",
            "Bidirectional",
            "Omnidirectional"});
            this.cbxLineCounterTypes.Location = new System.Drawing.Point(100, 190);
            this.cbxLineCounterTypes.MaxDropDownItems = 3;
            this.cbxLineCounterTypes.Name = "cbxLineCounterTypes";
            this.cbxLineCounterTypes.Size = new System.Drawing.Size(128, 21);
            this.cbxLineCounterTypes.TabIndex = 18;
            // 
            // lblRightCountLabel
            // 
            this.lblRightCountLabel.AutoSize = true;
            this.lblRightCountLabel.Location = new System.Drawing.Point(3, 254);
            this.lblRightCountLabel.Name = "lblRightCountLabel";
            this.lblRightCountLabel.Size = new System.Drawing.Size(95, 13);
            this.lblRightCountLabel.TabIndex = 20;
            this.lblRightCountLabel.Text = "Right Count Label:";
            this.lblRightCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxRightCountLabel
            // 
            this.tbxRightCountLabel.Location = new System.Drawing.Point(100, 251);
            this.tbxRightCountLabel.MaxLength = 255;
            this.tbxRightCountLabel.Name = "tbxRightCountLabel";
            this.tbxRightCountLabel.Size = new System.Drawing.Size(128, 20);
            this.tbxRightCountLabel.TabIndex = 19;
            // 
            // lblLeftCountLabel
            // 
            this.lblLeftCountLabel.AutoSize = true;
            this.lblLeftCountLabel.Location = new System.Drawing.Point(6, 224);
            this.lblLeftCountLabel.Name = "lblLeftCountLabel";
            this.lblLeftCountLabel.Size = new System.Drawing.Size(88, 13);
            this.lblLeftCountLabel.TabIndex = 12;
            this.lblLeftCountLabel.Text = "Left Count Label:";
            this.lblLeftCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLineCounterType
            // 
            this.lblLineCounterType.AutoSize = true;
            this.lblLineCounterType.Location = new System.Drawing.Point(3, 194);
            this.lblLineCounterType.Name = "lblLineCounterType";
            this.lblLineCounterType.Size = new System.Drawing.Size(97, 13);
            this.lblLineCounterType.TabIndex = 17;
            this.lblLineCounterType.Text = "Line Counter Type:";
            this.lblLineCounterType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ckbxIsEventsEnabled
            // 
            this.ckbxIsEventsEnabled.AutoSize = true;
            this.ckbxIsEventsEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbxIsEventsEnabled.Checked = true;
            this.ckbxIsEventsEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbxIsEventsEnabled.Location = new System.Drawing.Point(39, 103);
            this.ckbxIsEventsEnabled.Name = "ckbxIsEventsEnabled";
            this.ckbxIsEventsEnabled.Size = new System.Drawing.Size(104, 17);
            this.ckbxIsEventsEnabled.TabIndex = 11;
            this.ckbxIsEventsEnabled.Text = "Events Enabled:";
            this.ckbxIsEventsEnabled.UseVisualStyleBackColor = true;
            // 
            // gbxStartPoint
            // 
            this.gbxStartPoint.Controls.Add(this.nudStartPointX);
            this.gbxStartPoint.Controls.Add(this.lblStartPointY);
            this.gbxStartPoint.Controls.Add(this.nudStartPointY);
            this.gbxStartPoint.Controls.Add(this.lblStartPointX);
            this.gbxStartPoint.Location = new System.Drawing.Point(6, 20);
            this.gbxStartPoint.Name = "gbxStartPoint";
            this.gbxStartPoint.Size = new System.Drawing.Size(108, 75);
            this.gbxStartPoint.TabIndex = 15;
            this.gbxStartPoint.TabStop = false;
            this.gbxStartPoint.Text = "Start Point";
            // 
            // nudStartPointX
            // 
            this.nudStartPointX.DecimalPlaces = 4;
            this.nudStartPointX.Location = new System.Drawing.Point(30, 19);
            this.nudStartPointX.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudStartPointX.Name = "nudStartPointX";
            this.nudStartPointX.Size = new System.Drawing.Size(72, 20);
            this.nudStartPointX.TabIndex = 11;
            // 
            // lblStartPointY
            // 
            this.lblStartPointY.Location = new System.Drawing.Point(7, 45);
            this.lblStartPointY.Name = "lblStartPointY";
            this.lblStartPointY.Size = new System.Drawing.Size(17, 20);
            this.lblStartPointY.TabIndex = 14;
            this.lblStartPointY.Text = "Y:";
            this.lblStartPointY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudStartPointY
            // 
            this.nudStartPointY.DecimalPlaces = 4;
            this.nudStartPointY.Location = new System.Drawing.Point(30, 45);
            this.nudStartPointY.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudStartPointY.Name = "nudStartPointY";
            this.nudStartPointY.Size = new System.Drawing.Size(72, 20);
            this.nudStartPointY.TabIndex = 12;
            // 
            // lblStartPointX
            // 
            this.lblStartPointX.Location = new System.Drawing.Point(7, 19);
            this.lblStartPointX.Name = "lblStartPointX";
            this.lblStartPointX.Size = new System.Drawing.Size(17, 20);
            this.lblStartPointX.TabIndex = 13;
            this.lblStartPointX.Text = "X:";
            this.lblStartPointX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxLeftCountLabel
            // 
            this.tbxLeftCountLabel.Location = new System.Drawing.Point(100, 221);
            this.tbxLeftCountLabel.MaxLength = 255;
            this.tbxLeftCountLabel.Name = "tbxLeftCountLabel";
            this.tbxLeftCountLabel.Size = new System.Drawing.Size(128, 20);
            this.tbxLeftCountLabel.TabIndex = 11;
            // 
            // nudMaxCountThreshold
            // 
            this.nudMaxCountThreshold.Location = new System.Drawing.Point(129, 160);
            this.nudMaxCountThreshold.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudMaxCountThreshold.Name = "nudMaxCountThreshold";
            this.nudMaxCountThreshold.Size = new System.Drawing.Size(99, 20);
            this.nudMaxCountThreshold.TabIndex = 17;
            // 
            // lblMaxCountThreshold
            // 
            this.lblMaxCountThreshold.AutoSize = true;
            this.lblMaxCountThreshold.Location = new System.Drawing.Point(14, 163);
            this.lblMaxCountThreshold.Name = "lblMaxCountThreshold";
            this.lblMaxCountThreshold.Size = new System.Drawing.Size(111, 13);
            this.lblMaxCountThreshold.TabIndex = 18;
            this.lblMaxCountThreshold.Text = "Max Count Threshold:";
            this.lblMaxCountThreshold.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudEventWindow
            // 
            this.nudEventWindow.Location = new System.Drawing.Point(129, 130);
            this.nudEventWindow.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudEventWindow.Name = "nudEventWindow";
            this.nudEventWindow.Size = new System.Drawing.Size(99, 20);
            this.nudEventWindow.TabIndex = 15;
            // 
            // lblEventWindow
            // 
            this.lblEventWindow.AutoSize = true;
            this.lblEventWindow.Location = new System.Drawing.Point(14, 133);
            this.lblEventWindow.Name = "lblEventWindow";
            this.lblEventWindow.Size = new System.Drawing.Size(111, 13);
            this.lblEventWindow.TabIndex = 16;
            this.lblEventWindow.Text = "Event Window (Sec.):";
            this.lblEventWindow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbxEndPoint
            // 
            this.gbxEndPoint.Controls.Add(this.nudEndPointX);
            this.gbxEndPoint.Controls.Add(this.lblEndPointY);
            this.gbxEndPoint.Controls.Add(this.nudEndPointY);
            this.gbxEndPoint.Controls.Add(this.lblEndPointX);
            this.gbxEndPoint.Location = new System.Drawing.Point(120, 20);
            this.gbxEndPoint.Name = "gbxEndPoint";
            this.gbxEndPoint.Size = new System.Drawing.Size(108, 75);
            this.gbxEndPoint.TabIndex = 16;
            this.gbxEndPoint.TabStop = false;
            this.gbxEndPoint.Text = "End Point";
            // 
            // nudEndPointX
            // 
            this.nudEndPointX.DecimalPlaces = 4;
            this.nudEndPointX.Location = new System.Drawing.Point(30, 19);
            this.nudEndPointX.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudEndPointX.Name = "nudEndPointX";
            this.nudEndPointX.Size = new System.Drawing.Size(72, 20);
            this.nudEndPointX.TabIndex = 11;
            // 
            // lblEndPointY
            // 
            this.lblEndPointY.Location = new System.Drawing.Point(7, 45);
            this.lblEndPointY.Name = "lblEndPointY";
            this.lblEndPointY.Size = new System.Drawing.Size(17, 20);
            this.lblEndPointY.TabIndex = 14;
            this.lblEndPointY.Text = "Y:";
            this.lblEndPointY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudEndPointY
            // 
            this.nudEndPointY.DecimalPlaces = 4;
            this.nudEndPointY.Location = new System.Drawing.Point(30, 45);
            this.nudEndPointY.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudEndPointY.Name = "nudEndPointY";
            this.nudEndPointY.Size = new System.Drawing.Size(72, 20);
            this.nudEndPointY.TabIndex = 12;
            // 
            // lblEndPointX
            // 
            this.lblEndPointX.Location = new System.Drawing.Point(7, 19);
            this.lblEndPointX.Name = "lblEndPointX";
            this.lblEndPointX.Size = new System.Drawing.Size(17, 20);
            this.lblEndPointX.TabIndex = 13;
            this.lblEndPointX.Text = "X:";
            this.lblEndPointX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbxObjectInZone
            // 
            this.gbxObjectInZone.Controls.Add(this.gbxVertices);
            this.gbxObjectInZone.Location = new System.Drawing.Point(13, 173);
            this.gbxObjectInZone.Name = "gbxObjectInZone";
            this.gbxObjectInZone.Size = new System.Drawing.Size(234, 402);
            this.gbxObjectInZone.TabIndex = 23;
            this.gbxObjectInZone.TabStop = false;
            this.gbxObjectInZone.Text = "Object In Zone Settings";
            // 
            // gbxVertices
            // 
            this.gbxVertices.Controls.Add(this.lvObjectInZonePoints);
            this.gbxVertices.Controls.Add(this.btnAddPoint);
            this.gbxVertices.Controls.Add(this.btnRemovePoint);
            this.gbxVertices.Location = new System.Drawing.Point(17, 22);
            this.gbxVertices.Name = "gbxVertices";
            this.gbxVertices.Size = new System.Drawing.Size(200, 368);
            this.gbxVertices.TabIndex = 0;
            this.gbxVertices.TabStop = false;
            this.gbxVertices.Text = "Vertices";
            // 
            // lvObjectInZonePoints
            // 
            this.lvObjectInZonePoints.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBlank,
            this.chX,
            this.chY});
            this.lvObjectInZonePoints.FullRowSelect = true;
            this.lvObjectInZonePoints.GridLines = true;
            this.lvObjectInZonePoints.HideSelection = false;
            this.lvObjectInZonePoints.Location = new System.Drawing.Point(6, 19);
            this.lvObjectInZonePoints.MultiSelect = false;
            this.lvObjectInZonePoints.Name = "lvObjectInZonePoints";
            this.lvObjectInZonePoints.Size = new System.Drawing.Size(185, 314);
            this.lvObjectInZonePoints.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvObjectInZonePoints.TabIndex = 24;
            this.lvObjectInZonePoints.UseCompatibleStateImageBehavior = false;
            this.lvObjectInZonePoints.View = System.Windows.Forms.View.Details;
            // 
            // chBlank
            // 
            this.chBlank.Text = "";
            this.chBlank.Width = 0;
            // 
            // chX
            // 
            this.chX.Text = "X";
            this.chX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chX.Width = 90;
            // 
            // chY
            // 
            this.chY.Text = "Y";
            this.chY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chY.Width = 90;
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.Location = new System.Drawing.Point(104, 339);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(90, 23);
            this.btnAddPoint.TabIndex = 26;
            this.btnAddPoint.Text = "Add Point";
            this.btnAddPoint.UseVisualStyleBackColor = true;
            this.btnAddPoint.Click += new System.EventHandler(this.ButtonAddPoint_Click);
            // 
            // btnRemovePoint
            // 
            this.btnRemovePoint.Location = new System.Drawing.Point(9, 339);
            this.btnRemovePoint.Name = "btnRemovePoint";
            this.btnRemovePoint.Size = new System.Drawing.Size(89, 23);
            this.btnRemovePoint.TabIndex = 25;
            this.btnRemovePoint.Text = "Remove Point";
            this.btnRemovePoint.UseVisualStyleBackColor = true;
            this.btnRemovePoint.Click += new System.EventHandler(this.ButtonRemovePoint_Click);
            // 
            // gbxObjectWrongWayZone
            // 
            this.gbxObjectWrongWayZone.Controls.Add(this.gbxZonePoints);
            this.gbxObjectWrongWayZone.Controls.Add(this.gbxZoneVector);
            this.gbxObjectWrongWayZone.Controls.Add(this.nudMinTriggerAngle);
            this.gbxObjectWrongWayZone.Controls.Add(this.lblMinTriggerAngle);
            this.gbxObjectWrongWayZone.Location = new System.Drawing.Point(13, 173);
            this.gbxObjectWrongWayZone.Name = "gbxObjectWrongWayZone";
            this.gbxObjectWrongWayZone.Size = new System.Drawing.Size(234, 402);
            this.gbxObjectWrongWayZone.TabIndex = 27;
            this.gbxObjectWrongWayZone.TabStop = false;
            this.gbxObjectWrongWayZone.Text = "Object Wrong Way Zone Settings";
            // 
            // gbxZonePoints
            // 
            this.gbxZonePoints.Controls.Add(this.lvObjectWrongWayZonePoints);
            this.gbxZonePoints.Controls.Add(this.btnRemoveZonePoint);
            this.gbxZonePoints.Controls.Add(this.btnAddZonePoint);
            this.gbxZonePoints.Location = new System.Drawing.Point(15, 135);
            this.gbxZonePoints.Name = "gbxZonePoints";
            this.gbxZonePoints.Size = new System.Drawing.Size(200, 229);
            this.gbxZonePoints.TabIndex = 28;
            this.gbxZonePoints.TabStop = false;
            this.gbxZonePoints.Text = "Zone Points";
            // 
            // lvObjectWrongWayZonePoints
            // 
            this.lvObjectWrongWayZonePoints.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvObjectWrongWayZonePoints.FullRowSelect = true;
            this.lvObjectWrongWayZonePoints.GridLines = true;
            this.lvObjectWrongWayZonePoints.HideSelection = false;
            this.lvObjectWrongWayZonePoints.Location = new System.Drawing.Point(6, 20);
            this.lvObjectWrongWayZonePoints.MultiSelect = false;
            this.lvObjectWrongWayZonePoints.Name = "lvObjectWrongWayZonePoints";
            this.lvObjectWrongWayZonePoints.Size = new System.Drawing.Size(185, 173);
            this.lvObjectWrongWayZonePoints.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvObjectWrongWayZonePoints.TabIndex = 24;
            this.lvObjectWrongWayZonePoints.UseCompatibleStateImageBehavior = false;
            this.lvObjectWrongWayZonePoints.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "X";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Y";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 90;
            // 
            // btnRemoveZonePoint
            // 
            this.btnRemoveZonePoint.Location = new System.Drawing.Point(6, 199);
            this.btnRemoveZonePoint.Name = "btnRemoveZonePoint";
            this.btnRemoveZonePoint.Size = new System.Drawing.Size(89, 23);
            this.btnRemoveZonePoint.TabIndex = 25;
            this.btnRemoveZonePoint.Text = "Remove Point";
            this.btnRemoveZonePoint.UseVisualStyleBackColor = true;
            this.btnRemoveZonePoint.Click += new System.EventHandler(this.ButtonRemoveZonePoint_Click);
            // 
            // btnAddZonePoint
            // 
            this.btnAddZonePoint.Location = new System.Drawing.Point(101, 199);
            this.btnAddZonePoint.Name = "btnAddZonePoint";
            this.btnAddZonePoint.Size = new System.Drawing.Size(90, 23);
            this.btnAddZonePoint.TabIndex = 26;
            this.btnAddZonePoint.Text = "Add Point";
            this.btnAddZonePoint.UseVisualStyleBackColor = true;
            this.btnAddZonePoint.Click += new System.EventHandler(this.ButtonAddZonePoint_Click);
            // 
            // gbxZoneVector
            // 
            this.gbxZoneVector.Controls.Add(this.nudVectorY);
            this.gbxZoneVector.Controls.Add(this.nudVectorAngle);
            this.gbxZoneVector.Controls.Add(this.lblVectorY);
            this.gbxZoneVector.Controls.Add(this.lblVectorAngle);
            this.gbxZoneVector.Controls.Add(this.nudVectorX);
            this.gbxZoneVector.Controls.Add(this.lblVectorX);
            this.gbxZoneVector.Location = new System.Drawing.Point(15, 22);
            this.gbxZoneVector.Name = "gbxZoneVector";
            this.gbxZoneVector.Size = new System.Drawing.Size(200, 107);
            this.gbxZoneVector.TabIndex = 28;
            this.gbxZoneVector.TabStop = false;
            this.gbxZoneVector.Text = "Zone Vector";
            // 
            // nudVectorY
            // 
            this.nudVectorY.DecimalPlaces = 4;
            this.nudVectorY.Location = new System.Drawing.Point(119, 72);
            this.nudVectorY.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudVectorY.Name = "nudVectorY";
            this.nudVectorY.Size = new System.Drawing.Size(72, 20);
            this.nudVectorY.TabIndex = 7;
            // 
            // nudVectorAngle
            // 
            this.nudVectorAngle.Location = new System.Drawing.Point(119, 16);
            this.nudVectorAngle.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudVectorAngle.Name = "nudVectorAngle";
            this.nudVectorAngle.Size = new System.Drawing.Size(72, 20);
            this.nudVectorAngle.TabIndex = 3;
            // 
            // lblVectorY
            // 
            this.lblVectorY.Location = new System.Drawing.Point(6, 72);
            this.lblVectorY.Name = "lblVectorY";
            this.lblVectorY.Size = new System.Drawing.Size(114, 20);
            this.lblVectorY.TabIndex = 6;
            this.lblVectorY.Text = "Starting Y Coordinate:";
            this.lblVectorY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVectorAngle
            // 
            this.lblVectorAngle.Location = new System.Drawing.Point(9, 16);
            this.lblVectorAngle.Name = "lblVectorAngle";
            this.lblVectorAngle.Size = new System.Drawing.Size(111, 20);
            this.lblVectorAngle.TabIndex = 2;
            this.lblVectorAngle.Text = "Angle:";
            this.lblVectorAngle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudVectorX
            // 
            this.nudVectorX.DecimalPlaces = 4;
            this.nudVectorX.Location = new System.Drawing.Point(119, 44);
            this.nudVectorX.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudVectorX.Name = "nudVectorX";
            this.nudVectorX.Size = new System.Drawing.Size(72, 20);
            this.nudVectorX.TabIndex = 5;
            // 
            // lblVectorX
            // 
            this.lblVectorX.Location = new System.Drawing.Point(6, 44);
            this.lblVectorX.Name = "lblVectorX";
            this.lblVectorX.Size = new System.Drawing.Size(114, 20);
            this.lblVectorX.TabIndex = 4;
            this.lblVectorX.Text = "Starting X Coordinate:";
            this.lblVectorX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudMinTriggerAngle
            // 
            this.nudMinTriggerAngle.Location = new System.Drawing.Point(144, 370);
            this.nudMinTriggerAngle.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudMinTriggerAngle.Name = "nudMinTriggerAngle";
            this.nudMinTriggerAngle.Size = new System.Drawing.Size(52, 20);
            this.nudMinTriggerAngle.TabIndex = 1;
            this.nudMinTriggerAngle.Value = new decimal(new int[] {
            110,
            0,
            0,
            0});
            // 
            // lblMinTriggerAngle
            // 
            this.lblMinTriggerAngle.Location = new System.Drawing.Point(21, 370);
            this.lblMinTriggerAngle.Name = "lblMinTriggerAngle";
            this.lblMinTriggerAngle.Size = new System.Drawing.Size(117, 20);
            this.lblMinTriggerAngle.TabIndex = 0;
            this.lblMinTriggerAngle.Text = "Minimum Trigger Angle:";
            this.lblMinTriggerAngle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddAnalyticBehaviorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 613);
            this.Controls.Add(this.gbxObjectWrongWayZone);
            this.Controls.Add(this.gbxObjectInZone);
            this.Controls.Add(this.gbxObjectCounter);
            this.Controls.Add(this.gbxSettings);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAnalyticBehaviorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Analytic Behavior";
            this.gbxSettings.ResumeLayout(false);
            this.gbxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeverity)).EndInit();
            this.gbxObjectCounter.ResumeLayout(false);
            this.gbxObjectCounter.PerformLayout();
            this.gbxStartPoint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudStartPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartPointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxCountThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEventWindow)).EndInit();
            this.gbxEndPoint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudEndPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndPointY)).EndInit();
            this.gbxObjectInZone.ResumeLayout(false);
            this.gbxVertices.ResumeLayout(false);
            this.gbxObjectWrongWayZone.ResumeLayout(false);
            this.gbxZonePoints.ResumeLayout(false);
            this.gbxZoneVector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudVectorY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVectorAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVectorX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinTriggerAngle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbxSettings;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckBox ckbxIsEnabled;
        private System.Windows.Forms.Label lblSeverity;
        private System.Windows.Forms.NumericUpDown nudSeverity;
        private System.Windows.Forms.Label lblBehaviorType;
        private System.Windows.Forms.Label lblObjectType;
        private System.Windows.Forms.ComboBox cbxBehaviorType;
        private System.Windows.Forms.ComboBox cbxObjectType;
        private System.Windows.Forms.GroupBox gbxObjectCounter;
        private System.Windows.Forms.Label lblStartPointY;
        private System.Windows.Forms.NumericUpDown nudStartPointX;
        private System.Windows.Forms.Label lblStartPointX;
        private System.Windows.Forms.NumericUpDown nudStartPointY;
        private System.Windows.Forms.GroupBox gbxEndPoint;
        private System.Windows.Forms.NumericUpDown nudEndPointX;
        private System.Windows.Forms.Label lblEndPointY;
        private System.Windows.Forms.NumericUpDown nudEndPointY;
        private System.Windows.Forms.Label lblEndPointX;
        private System.Windows.Forms.GroupBox gbxStartPoint;
        private System.Windows.Forms.GroupBox gbxObjectInZone;
        private System.Windows.Forms.ListView lvObjectInZonePoints;
        private System.Windows.Forms.ColumnHeader chY;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.Button btnRemovePoint;
        private System.Windows.Forms.ColumnHeader chBlank;
        private System.Windows.Forms.ColumnHeader chX;
        private System.Windows.Forms.GroupBox gbxObjectWrongWayZone;
        private System.Windows.Forms.NumericUpDown nudVectorY;
        private System.Windows.Forms.Label lblVectorY;
        private System.Windows.Forms.NumericUpDown nudVectorX;
        private System.Windows.Forms.Label lblVectorX;
        private System.Windows.Forms.NumericUpDown nudVectorAngle;
        private System.Windows.Forms.Label lblVectorAngle;
        private System.Windows.Forms.NumericUpDown nudMinTriggerAngle;
        private System.Windows.Forms.Label lblMinTriggerAngle;
        private System.Windows.Forms.ListView lvObjectWrongWayZonePoints;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnAddZonePoint;
        private System.Windows.Forms.Button btnRemoveZonePoint;
        private System.Windows.Forms.GroupBox gbxZonePoints;
        private System.Windows.Forms.GroupBox gbxZoneVector;
        private System.Windows.Forms.GroupBox gbxVertices;
        private System.Windows.Forms.ComboBox cbxLineCounterTypes;
        private System.Windows.Forms.Label lblRightCountLabel;
        private System.Windows.Forms.TextBox tbxRightCountLabel;
        private System.Windows.Forms.Label lblLeftCountLabel;
        private System.Windows.Forms.Label lblLineCounterType;
        private System.Windows.Forms.CheckBox ckbxIsEventsEnabled;
        private System.Windows.Forms.TextBox tbxLeftCountLabel;
        private System.Windows.Forms.NumericUpDown nudMaxCountThreshold;
        private System.Windows.Forms.Label lblMaxCountThreshold;
        private System.Windows.Forms.NumericUpDown nudEventWindow;
        private System.Windows.Forms.Label lblEventWindow;
    }
}