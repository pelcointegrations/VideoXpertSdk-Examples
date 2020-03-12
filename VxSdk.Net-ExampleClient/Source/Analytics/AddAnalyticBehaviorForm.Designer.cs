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
            this.tbxId = new System.Windows.Forms.TextBox();
            this.gbxSettings = new System.Windows.Forms.GroupBox();
            this.lblBehaviorType = new System.Windows.Forms.Label();
            this.lblObjectType = new System.Windows.Forms.Label();
            this.cbxBehaviorType = new System.Windows.Forms.ComboBox();
            this.cbxObjectType = new System.Windows.Forms.ComboBox();
            this.lblSeverity = new System.Windows.Forms.Label();
            this.lblSensitivity = new System.Windows.Forms.Label();
            this.nudSeverity = new System.Windows.Forms.NumericUpDown();
            this.nudSensitivity = new System.Windows.Forms.NumericUpDown();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.ckbxIsEnabled = new System.Windows.Forms.CheckBox();
            this.gbxObjectCounter = new System.Windows.Forms.GroupBox();
            this.cbxIntersectionArea = new System.Windows.Forms.ComboBox();
            this.gbxEndPoint = new System.Windows.Forms.GroupBox();
            this.nudEndPointX = new System.Windows.Forms.NumericUpDown();
            this.lblEndPointY = new System.Windows.Forms.Label();
            this.nudEndPointY = new System.Windows.Forms.NumericUpDown();
            this.lblEndPointX = new System.Windows.Forms.Label();
            this.gbxStartPoint = new System.Windows.Forms.GroupBox();
            this.nudStartPointX = new System.Windows.Forms.NumericUpDown();
            this.lblStartPointY = new System.Windows.Forms.Label();
            this.nudStartPointY = new System.Windows.Forms.NumericUpDown();
            this.lblStartPointX = new System.Windows.Forms.Label();
            this.lblIntersectionArea = new System.Windows.Forms.Label();
            this.gbxObjectZone = new System.Windows.Forms.GroupBox();
            this.lvObjectZonePoints = new System.Windows.Forms.ListView();
            this.chBlank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.btnRemovePoint = new System.Windows.Forms.Button();
            this.gbxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeverity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSensitivity)).BeginInit();
            this.gbxObjectCounter.SuspendLayout();
            this.gbxEndPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndPointY)).BeginInit();
            this.gbxStartPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartPointY)).BeginInit();
            this.gbxObjectZone.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(94, 20);
            this.tbxName.MaxLength = 255;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(203, 20);
            this.tbxName.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(669, 246);
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
            this.btnCancel.Location = new System.Drawing.Point(588, 246);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(94, 50);
            this.tbxId.MaxLength = 64;
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(203, 20);
            this.tbxId.TabIndex = 0;
            // 
            // gbxSettings
            // 
            this.gbxSettings.Controls.Add(this.lblBehaviorType);
            this.gbxSettings.Controls.Add(this.lblObjectType);
            this.gbxSettings.Controls.Add(this.cbxBehaviorType);
            this.gbxSettings.Controls.Add(this.cbxObjectType);
            this.gbxSettings.Controls.Add(this.lblSeverity);
            this.gbxSettings.Controls.Add(this.lblSensitivity);
            this.gbxSettings.Controls.Add(this.nudSeverity);
            this.gbxSettings.Controls.Add(this.nudSensitivity);
            this.gbxSettings.Controls.Add(this.lblId);
            this.gbxSettings.Controls.Add(this.lblName);
            this.gbxSettings.Controls.Add(this.tbxId);
            this.gbxSettings.Controls.Add(this.tbxName);
            this.gbxSettings.Controls.Add(this.ckbxIsEnabled);
            this.gbxSettings.Location = new System.Drawing.Point(12, 12);
            this.gbxSettings.Name = "gbxSettings";
            this.gbxSettings.Size = new System.Drawing.Size(320, 228);
            this.gbxSettings.TabIndex = 21;
            this.gbxSettings.TabStop = false;
            this.gbxSettings.Text = "Settings";
            // 
            // lblBehaviorType
            // 
            this.lblBehaviorType.AutoSize = true;
            this.lblBehaviorType.Location = new System.Drawing.Point(9, 201);
            this.lblBehaviorType.Name = "lblBehaviorType";
            this.lblBehaviorType.Size = new System.Drawing.Size(79, 13);
            this.lblBehaviorType.TabIndex = 10;
            this.lblBehaviorType.Text = "Behavior Type:";
            // 
            // lblObjectType
            // 
            this.lblObjectType.AutoSize = true;
            this.lblObjectType.Location = new System.Drawing.Point(20, 170);
            this.lblObjectType.Name = "lblObjectType";
            this.lblObjectType.Size = new System.Drawing.Size(68, 13);
            this.lblObjectType.TabIndex = 9;
            this.lblObjectType.Text = "Object Type:";
            // 
            // cbxBehaviorType
            // 
            this.cbxBehaviorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBehaviorType.FormattingEnabled = true;
            this.cbxBehaviorType.Items.AddRange(new object[] {
            "Object Counter",
            "Object In Zone"});
            this.cbxBehaviorType.Location = new System.Drawing.Point(94, 198);
            this.cbxBehaviorType.Name = "cbxBehaviorType";
            this.cbxBehaviorType.Size = new System.Drawing.Size(189, 21);
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
            this.cbxObjectType.Location = new System.Drawing.Point(94, 167);
            this.cbxObjectType.Name = "cbxObjectType";
            this.cbxObjectType.Size = new System.Drawing.Size(189, 21);
            this.cbxObjectType.TabIndex = 7;
            // 
            // lblSeverity
            // 
            this.lblSeverity.AutoSize = true;
            this.lblSeverity.Location = new System.Drawing.Point(40, 139);
            this.lblSeverity.Name = "lblSeverity";
            this.lblSeverity.Size = new System.Drawing.Size(48, 13);
            this.lblSeverity.TabIndex = 6;
            this.lblSeverity.Text = "Severity:";
            // 
            // lblSensitivity
            // 
            this.lblSensitivity.AutoSize = true;
            this.lblSensitivity.Location = new System.Drawing.Point(31, 109);
            this.lblSensitivity.Name = "lblSensitivity";
            this.lblSensitivity.Size = new System.Drawing.Size(57, 13);
            this.lblSensitivity.TabIndex = 5;
            this.lblSensitivity.Text = "Sensitivity:";
            // 
            // nudSeverity
            // 
            this.nudSeverity.Location = new System.Drawing.Point(94, 137);
            this.nudSeverity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSeverity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSeverity.Name = "nudSeverity";
            this.nudSeverity.Size = new System.Drawing.Size(89, 20);
            this.nudSeverity.TabIndex = 4;
            this.nudSeverity.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudSensitivity
            // 
            this.nudSensitivity.Location = new System.Drawing.Point(94, 107);
            this.nudSensitivity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSensitivity.Name = "nudSensitivity";
            this.nudSensitivity.Size = new System.Drawing.Size(89, 20);
            this.nudSensitivity.TabIndex = 3;
            this.nudSensitivity.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(67, 53);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(50, 23);
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
            this.ckbxIsEnabled.Location = new System.Drawing.Point(39, 80);
            this.ckbxIsEnabled.Name = "ckbxIsEnabled";
            this.ckbxIsEnabled.Size = new System.Drawing.Size(68, 17);
            this.ckbxIsEnabled.TabIndex = 0;
            this.ckbxIsEnabled.Text = "Enabled:";
            this.ckbxIsEnabled.UseVisualStyleBackColor = true;
            // 
            // gbxObjectCounter
            // 
            this.gbxObjectCounter.Controls.Add(this.cbxIntersectionArea);
            this.gbxObjectCounter.Controls.Add(this.gbxEndPoint);
            this.gbxObjectCounter.Controls.Add(this.gbxStartPoint);
            this.gbxObjectCounter.Controls.Add(this.lblIntersectionArea);
            this.gbxObjectCounter.Location = new System.Drawing.Point(338, 12);
            this.gbxObjectCounter.Name = "gbxObjectCounter";
            this.gbxObjectCounter.Size = new System.Drawing.Size(200, 228);
            this.gbxObjectCounter.TabIndex = 22;
            this.gbxObjectCounter.TabStop = false;
            this.gbxObjectCounter.Text = "Object Counter Settings";
            // 
            // cbxIntersectionArea
            // 
            this.cbxIntersectionArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIntersectionArea.FormattingEnabled = true;
            this.cbxIntersectionArea.Items.AddRange(new object[] {
            "East-bound Left",
            "East-bound Pedestrian",
            "East-bound Right",
            "East-bound Through",
            "North-bound Left",
            "North-bound Pedestrian",
            "North-bound Right",
            "North-bound Through",
            "South-bound Left",
            "South-bound Pedestrian",
            "South-bound Right",
            "South-bound Through",
            "West-bound Left",
            "West-bound Pedestrian",
            "West-bound Right",
            "West-bound Through"});
            this.cbxIntersectionArea.Location = new System.Drawing.Point(19, 198);
            this.cbxIntersectionArea.Name = "cbxIntersectionArea";
            this.cbxIntersectionArea.Size = new System.Drawing.Size(175, 21);
            this.cbxIntersectionArea.TabIndex = 18;
            // 
            // gbxEndPoint
            // 
            this.gbxEndPoint.Controls.Add(this.nudEndPointX);
            this.gbxEndPoint.Controls.Add(this.lblEndPointY);
            this.gbxEndPoint.Controls.Add(this.nudEndPointY);
            this.gbxEndPoint.Controls.Add(this.lblEndPointX);
            this.gbxEndPoint.Location = new System.Drawing.Point(19, 100);
            this.gbxEndPoint.Name = "gbxEndPoint";
            this.gbxEndPoint.Size = new System.Drawing.Size(144, 72);
            this.gbxEndPoint.TabIndex = 16;
            this.gbxEndPoint.TabStop = false;
            this.gbxEndPoint.Text = "End Point";
            // 
            // nudEndPointX
            // 
            this.nudEndPointX.Location = new System.Drawing.Point(34, 19);
            this.nudEndPointX.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudEndPointX.Name = "nudEndPointX";
            this.nudEndPointX.Size = new System.Drawing.Size(89, 20);
            this.nudEndPointX.TabIndex = 11;
            // 
            // lblEndPointY
            // 
            this.lblEndPointY.AutoSize = true;
            this.lblEndPointY.Location = new System.Drawing.Point(11, 47);
            this.lblEndPointY.Name = "lblEndPointY";
            this.lblEndPointY.Size = new System.Drawing.Size(17, 13);
            this.lblEndPointY.TabIndex = 14;
            this.lblEndPointY.Text = "Y:";
            // 
            // nudEndPointY
            // 
            this.nudEndPointY.Location = new System.Drawing.Point(34, 45);
            this.nudEndPointY.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudEndPointY.Name = "nudEndPointY";
            this.nudEndPointY.Size = new System.Drawing.Size(89, 20);
            this.nudEndPointY.TabIndex = 12;
            // 
            // lblEndPointX
            // 
            this.lblEndPointX.AutoSize = true;
            this.lblEndPointX.Location = new System.Drawing.Point(11, 23);
            this.lblEndPointX.Name = "lblEndPointX";
            this.lblEndPointX.Size = new System.Drawing.Size(17, 13);
            this.lblEndPointX.TabIndex = 13;
            this.lblEndPointX.Text = "X:";
            // 
            // gbxStartPoint
            // 
            this.gbxStartPoint.Controls.Add(this.nudStartPointX);
            this.gbxStartPoint.Controls.Add(this.lblStartPointY);
            this.gbxStartPoint.Controls.Add(this.nudStartPointY);
            this.gbxStartPoint.Controls.Add(this.lblStartPointX);
            this.gbxStartPoint.Location = new System.Drawing.Point(19, 19);
            this.gbxStartPoint.Name = "gbxStartPoint";
            this.gbxStartPoint.Size = new System.Drawing.Size(144, 75);
            this.gbxStartPoint.TabIndex = 15;
            this.gbxStartPoint.TabStop = false;
            this.gbxStartPoint.Text = "Start Point";
            // 
            // nudStartPointX
            // 
            this.nudStartPointX.Location = new System.Drawing.Point(34, 19);
            this.nudStartPointX.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudStartPointX.Name = "nudStartPointX";
            this.nudStartPointX.Size = new System.Drawing.Size(89, 20);
            this.nudStartPointX.TabIndex = 11;
            // 
            // lblStartPointY
            // 
            this.lblStartPointY.AutoSize = true;
            this.lblStartPointY.Location = new System.Drawing.Point(11, 47);
            this.lblStartPointY.Name = "lblStartPointY";
            this.lblStartPointY.Size = new System.Drawing.Size(17, 13);
            this.lblStartPointY.TabIndex = 14;
            this.lblStartPointY.Text = "Y:";
            // 
            // nudStartPointY
            // 
            this.nudStartPointY.Location = new System.Drawing.Point(34, 45);
            this.nudStartPointY.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudStartPointY.Name = "nudStartPointY";
            this.nudStartPointY.Size = new System.Drawing.Size(89, 20);
            this.nudStartPointY.TabIndex = 12;
            // 
            // lblStartPointX
            // 
            this.lblStartPointX.AutoSize = true;
            this.lblStartPointX.Location = new System.Drawing.Point(11, 23);
            this.lblStartPointX.Name = "lblStartPointX";
            this.lblStartPointX.Size = new System.Drawing.Size(17, 13);
            this.lblStartPointX.TabIndex = 13;
            this.lblStartPointX.Text = "X:";
            // 
            // lblIntersectionArea
            // 
            this.lblIntersectionArea.AutoSize = true;
            this.lblIntersectionArea.Location = new System.Drawing.Point(16, 179);
            this.lblIntersectionArea.Name = "lblIntersectionArea";
            this.lblIntersectionArea.Size = new System.Drawing.Size(90, 13);
            this.lblIntersectionArea.TabIndex = 17;
            this.lblIntersectionArea.Text = "Intersection Area:";
            // 
            // gbxObjectZone
            // 
            this.gbxObjectZone.Controls.Add(this.lvObjectZonePoints);
            this.gbxObjectZone.Controls.Add(this.btnAddPoint);
            this.gbxObjectZone.Controls.Add(this.btnRemovePoint);
            this.gbxObjectZone.Location = new System.Drawing.Point(544, 12);
            this.gbxObjectZone.Name = "gbxObjectZone";
            this.gbxObjectZone.Size = new System.Drawing.Size(200, 228);
            this.gbxObjectZone.TabIndex = 23;
            this.gbxObjectZone.TabStop = false;
            this.gbxObjectZone.Text = "Object Zone Settings";
            // 
            // lvObjectZonePoints
            // 
            this.lvObjectZonePoints.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBlank,
            this.chX,
            this.chY});
            this.lvObjectZonePoints.FullRowSelect = true;
            this.lvObjectZonePoints.GridLines = true;
            this.lvObjectZonePoints.HideSelection = false;
            this.lvObjectZonePoints.Location = new System.Drawing.Point(6, 19);
            this.lvObjectZonePoints.MultiSelect = false;
            this.lvObjectZonePoints.Name = "lvObjectZonePoints";
            this.lvObjectZonePoints.Size = new System.Drawing.Size(185, 173);
            this.lvObjectZonePoints.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvObjectZonePoints.TabIndex = 24;
            this.lvObjectZonePoints.UseCompatibleStateImageBehavior = false;
            this.lvObjectZonePoints.View = System.Windows.Forms.View.Details;
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
            this.btnAddPoint.Location = new System.Drawing.Point(101, 198);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(90, 23);
            this.btnAddPoint.TabIndex = 26;
            this.btnAddPoint.Text = "Add Point";
            this.btnAddPoint.UseVisualStyleBackColor = true;
            this.btnAddPoint.Click += new System.EventHandler(this.ButtonAddPoint_Click);
            // 
            // btnRemovePoint
            // 
            this.btnRemovePoint.Location = new System.Drawing.Point(6, 198);
            this.btnRemovePoint.Name = "btnRemovePoint";
            this.btnRemovePoint.Size = new System.Drawing.Size(89, 23);
            this.btnRemovePoint.TabIndex = 25;
            this.btnRemovePoint.Text = "Remove Point";
            this.btnRemovePoint.UseVisualStyleBackColor = true;
            this.btnRemovePoint.Click += new System.EventHandler(this.ButtonRemovePoint_Click);
            // 
            // AddAnalyticBehaviorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 276);
            this.Controls.Add(this.gbxObjectZone);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudSensitivity)).EndInit();
            this.gbxObjectCounter.ResumeLayout(false);
            this.gbxObjectCounter.PerformLayout();
            this.gbxEndPoint.ResumeLayout(false);
            this.gbxEndPoint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndPointY)).EndInit();
            this.gbxStartPoint.ResumeLayout(false);
            this.gbxStartPoint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartPointY)).EndInit();
            this.gbxObjectZone.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.GroupBox gbxSettings;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckBox ckbxIsEnabled;
        private System.Windows.Forms.Label lblSeverity;
        private System.Windows.Forms.Label lblSensitivity;
        private System.Windows.Forms.NumericUpDown nudSeverity;
        private System.Windows.Forms.NumericUpDown nudSensitivity;
        private System.Windows.Forms.Label lblBehaviorType;
        private System.Windows.Forms.Label lblObjectType;
        private System.Windows.Forms.ComboBox cbxBehaviorType;
        private System.Windows.Forms.ComboBox cbxObjectType;
        private System.Windows.Forms.GroupBox gbxObjectCounter;
        private System.Windows.Forms.Label lblStartPointY;
        private System.Windows.Forms.NumericUpDown nudStartPointX;
        private System.Windows.Forms.Label lblStartPointX;
        private System.Windows.Forms.NumericUpDown nudStartPointY;
        private System.Windows.Forms.ComboBox cbxIntersectionArea;
        private System.Windows.Forms.GroupBox gbxEndPoint;
        private System.Windows.Forms.NumericUpDown nudEndPointX;
        private System.Windows.Forms.Label lblEndPointY;
        private System.Windows.Forms.NumericUpDown nudEndPointY;
        private System.Windows.Forms.Label lblEndPointX;
        private System.Windows.Forms.GroupBox gbxStartPoint;
        private System.Windows.Forms.Label lblIntersectionArea;
        private System.Windows.Forms.GroupBox gbxObjectZone;
        private System.Windows.Forms.ListView lvObjectZonePoints;
        private System.Windows.Forms.ColumnHeader chY;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.Button btnRemovePoint;
        private System.Windows.Forms.ColumnHeader chBlank;
        private System.Windows.Forms.ColumnHeader chX;
    }
}