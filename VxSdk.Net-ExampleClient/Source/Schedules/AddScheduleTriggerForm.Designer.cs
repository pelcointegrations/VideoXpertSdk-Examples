namespace ExampleClient.Source
{
    partial class AddScheduleTriggerForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.nudPreRecord = new System.Windows.Forms.NumericUpDown();
            this.nudPostRecord = new System.Windows.Forms.NumericUpDown();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.cbxFramerate = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.gbxRecordingSettings = new System.Windows.Forms.GroupBox();
            this.cbxTimeTables = new System.Windows.Forms.ComboBox();
            this.lblTimeTable = new System.Windows.Forms.Label();
            this.lblFramerate = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblPostRecord = new System.Windows.Forms.Label();
            this.lblPreRecord = new System.Windows.Forms.Label();
            this.gbxEventSettings = new System.Windows.Forms.GroupBox();
            this.gbxEventProperties = new System.Windows.Forms.GroupBox();
            this.lvEventProperties = new System.Windows.Forms.ListView();
            this.chKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddEventProperty = new System.Windows.Forms.Button();
            this.btnRemoveEventProperty = new System.Windows.Forms.Button();
            this.lblEvent = new System.Windows.Forms.Label();
            this.cbxEvent = new System.Windows.Forms.ComboBox();
            this.gbxGeneralSettings = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPostRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            this.gbxRecordingSettings.SuspendLayout();
            this.gbxEventSettings.SuspendLayout();
            this.gbxEventProperties.SuspendLayout();
            this.gbxGeneralSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(207, 469);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(288, 469);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(38, 22);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(200, 20);
            this.tbxId.TabIndex = 33;
            // 
            // nudPreRecord
            // 
            this.nudPreRecord.Location = new System.Drawing.Point(93, 20);
            this.nudPreRecord.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudPreRecord.Name = "nudPreRecord";
            this.nudPreRecord.Size = new System.Drawing.Size(71, 20);
            this.nudPreRecord.TabIndex = 34;
            // 
            // nudPostRecord
            // 
            this.nudPostRecord.Location = new System.Drawing.Point(242, 22);
            this.nudPostRecord.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudPostRecord.Name = "nudPostRecord";
            this.nudPostRecord.Size = new System.Drawing.Size(83, 20);
            this.nudPostRecord.TabIndex = 35;
            // 
            // nudDuration
            // 
            this.nudDuration.Location = new System.Drawing.Point(93, 51);
            this.nudDuration.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(71, 20);
            this.nudDuration.TabIndex = 36;
            // 
            // cbxFramerate
            // 
            this.cbxFramerate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFramerate.FormattingEnabled = true;
            this.cbxFramerate.Items.AddRange(new object[] {
            "Low",
            "Normal"});
            this.cbxFramerate.Location = new System.Drawing.Point(230, 48);
            this.cbxFramerate.Name = "cbxFramerate";
            this.cbxFramerate.Size = new System.Drawing.Size(95, 21);
            this.cbxFramerate.TabIndex = 37;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(10, 25);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 34;
            this.lblId.Text = "Id";
            // 
            // gbxRecordingSettings
            // 
            this.gbxRecordingSettings.Controls.Add(this.cbxTimeTables);
            this.gbxRecordingSettings.Controls.Add(this.lblTimeTable);
            this.gbxRecordingSettings.Controls.Add(this.lblFramerate);
            this.gbxRecordingSettings.Controls.Add(this.lblDuration);
            this.gbxRecordingSettings.Controls.Add(this.lblPostRecord);
            this.gbxRecordingSettings.Controls.Add(this.lblPreRecord);
            this.gbxRecordingSettings.Controls.Add(this.nudPreRecord);
            this.gbxRecordingSettings.Controls.Add(this.nudPostRecord);
            this.gbxRecordingSettings.Controls.Add(this.cbxFramerate);
            this.gbxRecordingSettings.Controls.Add(this.nudDuration);
            this.gbxRecordingSettings.Location = new System.Drawing.Point(12, 83);
            this.gbxRecordingSettings.Name = "gbxRecordingSettings";
            this.gbxRecordingSettings.Size = new System.Drawing.Size(351, 125);
            this.gbxRecordingSettings.TabIndex = 39;
            this.gbxRecordingSettings.TabStop = false;
            this.gbxRecordingSettings.Text = "Recording Settings";
            // 
            // cbxTimeTables
            // 
            this.cbxTimeTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTimeTables.FormattingEnabled = true;
            this.cbxTimeTables.Items.AddRange(new object[] {
            "None"});
            this.cbxTimeTables.Location = new System.Drawing.Point(122, 83);
            this.cbxTimeTables.Name = "cbxTimeTables";
            this.cbxTimeTables.Size = new System.Drawing.Size(203, 21);
            this.cbxTimeTables.TabIndex = 37;
            // 
            // lblTimeTable
            // 
            this.lblTimeTable.AutoSize = true;
            this.lblTimeTable.Location = new System.Drawing.Point(10, 86);
            this.lblTimeTable.Name = "lblTimeTable";
            this.lblTimeTable.Size = new System.Drawing.Size(106, 13);
            this.lblTimeTable.TabIndex = 42;
            this.lblTimeTable.Text = "Assigned Time Table";
            // 
            // lblFramerate
            // 
            this.lblFramerate.AutoSize = true;
            this.lblFramerate.Location = new System.Drawing.Point(170, 51);
            this.lblFramerate.Name = "lblFramerate";
            this.lblFramerate.Size = new System.Drawing.Size(54, 13);
            this.lblFramerate.TabIndex = 42;
            this.lblFramerate.Text = "Framerate";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(40, 53);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(47, 13);
            this.lblDuration.TabIndex = 41;
            this.lblDuration.Text = "Duration";
            // 
            // lblPostRecord
            // 
            this.lblPostRecord.AutoSize = true;
            this.lblPostRecord.Location = new System.Drawing.Point(170, 22);
            this.lblPostRecord.Name = "lblPostRecord";
            this.lblPostRecord.Size = new System.Drawing.Size(66, 13);
            this.lblPostRecord.TabIndex = 40;
            this.lblPostRecord.Text = "Post-Record";
            // 
            // lblPreRecord
            // 
            this.lblPreRecord.AutoSize = true;
            this.lblPreRecord.Location = new System.Drawing.Point(26, 22);
            this.lblPreRecord.Name = "lblPreRecord";
            this.lblPreRecord.Size = new System.Drawing.Size(61, 13);
            this.lblPreRecord.TabIndex = 39;
            this.lblPreRecord.Text = "Pre-Record";
            // 
            // gbxEventSettings
            // 
            this.gbxEventSettings.Controls.Add(this.gbxEventProperties);
            this.gbxEventSettings.Controls.Add(this.lblEvent);
            this.gbxEventSettings.Controls.Add(this.cbxEvent);
            this.gbxEventSettings.Location = new System.Drawing.Point(12, 214);
            this.gbxEventSettings.Name = "gbxEventSettings";
            this.gbxEventSettings.Size = new System.Drawing.Size(351, 249);
            this.gbxEventSettings.TabIndex = 41;
            this.gbxEventSettings.TabStop = false;
            this.gbxEventSettings.Text = "Event Settings";
            // 
            // gbxEventProperties
            // 
            this.gbxEventProperties.Controls.Add(this.lvEventProperties);
            this.gbxEventProperties.Controls.Add(this.btnAddEventProperty);
            this.gbxEventProperties.Controls.Add(this.btnRemoveEventProperty);
            this.gbxEventProperties.Enabled = false;
            this.gbxEventProperties.Location = new System.Drawing.Point(15, 57);
            this.gbxEventProperties.Name = "gbxEventProperties";
            this.gbxEventProperties.Size = new System.Drawing.Size(320, 178);
            this.gbxEventProperties.TabIndex = 45;
            this.gbxEventProperties.TabStop = false;
            this.gbxEventProperties.Text = "Event Properties";
            // 
            // lvEventProperties
            // 
            this.lvEventProperties.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chKey,
            this.chValue});
            this.lvEventProperties.FullRowSelect = true;
            this.lvEventProperties.Location = new System.Drawing.Point(6, 19);
            this.lvEventProperties.MultiSelect = false;
            this.lvEventProperties.Name = "lvEventProperties";
            this.lvEventProperties.Size = new System.Drawing.Size(308, 121);
            this.lvEventProperties.TabIndex = 2;
            this.lvEventProperties.UseCompatibleStateImageBehavior = false;
            this.lvEventProperties.View = System.Windows.Forms.View.Details;
            // 
            // chKey
            // 
            this.chKey.Text = "Key";
            this.chKey.Width = 139;
            // 
            // chValue
            // 
            this.chValue.Text = "Value";
            this.chValue.Width = 139;
            // 
            // btnAddEventProperty
            // 
            this.btnAddEventProperty.Location = new System.Drawing.Point(6, 147);
            this.btnAddEventProperty.Name = "btnAddEventProperty";
            this.btnAddEventProperty.Size = new System.Drawing.Size(75, 23);
            this.btnAddEventProperty.TabIndex = 3;
            this.btnAddEventProperty.Text = "Add";
            this.btnAddEventProperty.UseVisualStyleBackColor = true;
            this.btnAddEventProperty.Click += new System.EventHandler(this.ButtonAddEventProperty_Click);
            // 
            // btnRemoveEventProperty
            // 
            this.btnRemoveEventProperty.Location = new System.Drawing.Point(239, 147);
            this.btnRemoveEventProperty.Name = "btnRemoveEventProperty";
            this.btnRemoveEventProperty.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveEventProperty.TabIndex = 4;
            this.btnRemoveEventProperty.Text = "Remove";
            this.btnRemoveEventProperty.UseVisualStyleBackColor = true;
            this.btnRemoveEventProperty.Click += new System.EventHandler(this.ButtonRemoveEventProperty_Click);
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(20, 27);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(35, 13);
            this.lblEvent.TabIndex = 43;
            this.lblEvent.Text = "Event";
            // 
            // cbxEvent
            // 
            this.cbxEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEvent.FormattingEnabled = true;
            this.cbxEvent.Items.AddRange(new object[] {
            "None"});
            this.cbxEvent.Location = new System.Drawing.Point(59, 23);
            this.cbxEvent.Name = "cbxEvent";
            this.cbxEvent.Size = new System.Drawing.Size(276, 21);
            this.cbxEvent.TabIndex = 0;
            this.cbxEvent.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEvent_SelectedIndexChanged);
            // 
            // gbxGeneralSettings
            // 
            this.gbxGeneralSettings.Controls.Add(this.btnGenerate);
            this.gbxGeneralSettings.Controls.Add(this.tbxId);
            this.gbxGeneralSettings.Controls.Add(this.lblId);
            this.gbxGeneralSettings.Location = new System.Drawing.Point(13, 13);
            this.gbxGeneralSettings.Name = "gbxGeneralSettings";
            this.gbxGeneralSettings.Size = new System.Drawing.Size(350, 64);
            this.gbxGeneralSettings.TabIndex = 42;
            this.gbxGeneralSettings.TabStop = false;
            this.gbxGeneralSettings.Text = "General Settings";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(263, 20);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(68, 23);
            this.btnGenerate.TabIndex = 35;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // AddScheduleTriggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 502);
            this.Controls.Add(this.gbxGeneralSettings);
            this.Controls.Add(this.gbxEventSettings);
            this.Controls.Add(this.gbxRecordingSettings);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddScheduleTriggerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Schedule Trigger";
            ((System.ComponentModel.ISupportInitialize)(this.nudPreRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPostRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            this.gbxRecordingSettings.ResumeLayout(false);
            this.gbxRecordingSettings.PerformLayout();
            this.gbxEventSettings.ResumeLayout(false);
            this.gbxEventSettings.PerformLayout();
            this.gbxEventProperties.ResumeLayout(false);
            this.gbxGeneralSettings.ResumeLayout(false);
            this.gbxGeneralSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.NumericUpDown nudPreRecord;
        private System.Windows.Forms.NumericUpDown nudPostRecord;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.ComboBox cbxFramerate;
        private System.Windows.Forms.GroupBox gbxRecordingSettings;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblFramerate;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblPostRecord;
        private System.Windows.Forms.Label lblPreRecord;
        private System.Windows.Forms.GroupBox gbxEventSettings;
        private System.Windows.Forms.GroupBox gbxEventProperties;
        private System.Windows.Forms.ColumnHeader chKey;
        private System.Windows.Forms.ColumnHeader chValue;
        private System.Windows.Forms.Button btnAddEventProperty;
        private System.Windows.Forms.Button btnRemoveEventProperty;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.ComboBox cbxEvent;
        private System.Windows.Forms.GroupBox gbxGeneralSettings;
        private System.Windows.Forms.Button btnGenerate;
        public System.Windows.Forms.ListView lvEventProperties;
        private System.Windows.Forms.Label lblTimeTable;
        private System.Windows.Forms.ComboBox cbxTimeTables;
    }
}