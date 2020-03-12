namespace ExampleClient.Source
{
    partial class AddScheduleForm
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
            this.tbxId = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.ckbxUseAllDataSources = new System.Windows.Forms.CheckBox();
            this.lvScheduleTriggers = new System.Windows.Forms.ListView();
            this.chCheckBox = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEventType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chInactiveEventType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEventProperties = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFrameRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPreTrigger = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPostTrigger = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTimeout = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTimeTable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxScheduleTriggers = new System.Windows.Forms.GroupBox();
            this.btnRemoveScheduleTrigger = new System.Windows.Forms.Button();
            this.btnAddScheduleTrigger = new System.Windows.Forms.Button();
            this.gbxGeneralSettings = new System.Windows.Forms.GroupBox();
            this.chAction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxScheduleTriggers.SuspendLayout();
            this.gbxGeneralSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(391, 22);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(293, 20);
            this.tbxId.TabIndex = 1;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(47, 22);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(159, 20);
            this.tbxName.TabIndex = 2;
            // 
            // ckbxUseAllDataSources
            // 
            this.ckbxUseAllDataSources.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbxUseAllDataSources.Location = new System.Drawing.Point(992, 22);
            this.ckbxUseAllDataSources.Name = "ckbxUseAllDataSources";
            this.ckbxUseAllDataSources.Size = new System.Drawing.Size(127, 20);
            this.ckbxUseAllDataSources.TabIndex = 3;
            this.ckbxUseAllDataSources.Text = "Use All Data Sources";
            this.ckbxUseAllDataSources.UseVisualStyleBackColor = true;
            // 
            // lvScheduleTriggers
            // 
            this.lvScheduleTriggers.CheckBoxes = true;
            this.lvScheduleTriggers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCheckBox,
            this.chId,
            this.chEventType,
            this.chInactiveEventType,
            this.chEventProperties,
            this.chFrameRate,
            this.chPreTrigger,
            this.chPostTrigger,
            this.chTimeout,
            this.chTimeTable,
            this.chAction});
            this.lvScheduleTriggers.FullRowSelect = true;
            this.lvScheduleTriggers.GridLines = true;
            this.lvScheduleTriggers.HideSelection = false;
            this.lvScheduleTriggers.Location = new System.Drawing.Point(9, 19);
            this.lvScheduleTriggers.MultiSelect = false;
            this.lvScheduleTriggers.Name = "lvScheduleTriggers";
            this.lvScheduleTriggers.Size = new System.Drawing.Size(1110, 172);
            this.lvScheduleTriggers.TabIndex = 6;
            this.lvScheduleTriggers.UseCompatibleStateImageBehavior = false;
            this.lvScheduleTriggers.View = System.Windows.Forms.View.Details;
            this.lvScheduleTriggers.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.ListViewScheduleTriggers_ItemChecked);
            // 
            // chCheckBox
            // 
            this.chCheckBox.Text = " ";
            this.chCheckBox.Width = 30;
            // 
            // chId
            // 
            this.chId.Text = "ID";
            this.chId.Width = 190;
            // 
            // chEventType
            // 
            this.chEventType.Text = "Event Type";
            this.chEventType.Width = 200;
            // 
            // chInactiveEventType
            // 
            this.chInactiveEventType.Text = "Inactive Event Type";
            this.chInactiveEventType.Width = 200;
            // 
            // chEventProperties
            // 
            this.chEventProperties.Text = "Event Properties";
            this.chEventProperties.Width = 100;
            // 
            // chFrameRate
            // 
            this.chFrameRate.Text = "Framerate";
            // 
            // chPreTrigger
            // 
            this.chPreTrigger.Text = "Pre";
            this.chPreTrigger.Width = 28;
            // 
            // chPostTrigger
            // 
            this.chPostTrigger.Text = "Post";
            this.chPostTrigger.Width = 34;
            // 
            // chTimeout
            // 
            this.chTimeout.Text = "Duration";
            this.chTimeout.Width = 53;
            // 
            // chTimeTable
            // 
            this.chTimeTable.Text = "Time Table";
            this.chTimeTable.Width = 150;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(690, 21);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(68, 23);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(367, 26);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(981, 307);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(1062, 307);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // gbxScheduleTriggers
            // 
            this.gbxScheduleTriggers.Controls.Add(this.btnRemoveScheduleTrigger);
            this.gbxScheduleTriggers.Controls.Add(this.btnAddScheduleTrigger);
            this.gbxScheduleTriggers.Controls.Add(this.lvScheduleTriggers);
            this.gbxScheduleTriggers.Location = new System.Drawing.Point(12, 73);
            this.gbxScheduleTriggers.Name = "gbxScheduleTriggers";
            this.gbxScheduleTriggers.Size = new System.Drawing.Size(1125, 228);
            this.gbxScheduleTriggers.TabIndex = 27;
            this.gbxScheduleTriggers.TabStop = false;
            this.gbxScheduleTriggers.Text = "Schedule Triggers";
            // 
            // btnRemoveScheduleTrigger
            // 
            this.btnRemoveScheduleTrigger.Enabled = false;
            this.btnRemoveScheduleTrigger.Location = new System.Drawing.Point(90, 197);
            this.btnRemoveScheduleTrigger.Name = "btnRemoveScheduleTrigger";
            this.btnRemoveScheduleTrigger.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveScheduleTrigger.TabIndex = 8;
            this.btnRemoveScheduleTrigger.Text = "Remove";
            this.btnRemoveScheduleTrigger.UseVisualStyleBackColor = true;
            this.btnRemoveScheduleTrigger.Click += new System.EventHandler(this.ButtonRemoveScheduleTrigger_Click);
            // 
            // btnAddScheduleTrigger
            // 
            this.btnAddScheduleTrigger.Location = new System.Drawing.Point(9, 197);
            this.btnAddScheduleTrigger.Name = "btnAddScheduleTrigger";
            this.btnAddScheduleTrigger.Size = new System.Drawing.Size(75, 23);
            this.btnAddScheduleTrigger.TabIndex = 7;
            this.btnAddScheduleTrigger.Text = "Add";
            this.btnAddScheduleTrigger.UseVisualStyleBackColor = true;
            this.btnAddScheduleTrigger.Click += new System.EventHandler(this.ButtonAddScheduleTrigger_Click);
            // 
            // gbxGeneralSettings
            // 
            this.gbxGeneralSettings.Controls.Add(this.lblName);
            this.gbxGeneralSettings.Controls.Add(this.tbxId);
            this.gbxGeneralSettings.Controls.Add(this.tbxName);
            this.gbxGeneralSettings.Controls.Add(this.ckbxUseAllDataSources);
            this.gbxGeneralSettings.Controls.Add(this.btnGenerate);
            this.gbxGeneralSettings.Controls.Add(this.lblId);
            this.gbxGeneralSettings.Location = new System.Drawing.Point(12, 12);
            this.gbxGeneralSettings.Name = "gbxGeneralSettings";
            this.gbxGeneralSettings.Size = new System.Drawing.Size(1125, 55);
            this.gbxGeneralSettings.TabIndex = 28;
            this.gbxGeneralSettings.TabStop = false;
            this.gbxGeneralSettings.Text = "General Settings";
            // 
            // chAction
            // 
            this.chAction.Text = "Action";
            // 
            // AddScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 340);
            this.Controls.Add(this.gbxGeneralSettings);
            this.Controls.Add(this.gbxScheduleTriggers);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddScheduleForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Schedule";
            this.gbxScheduleTriggers.ResumeLayout(false);
            this.gbxGeneralSettings.ResumeLayout(false);
            this.gbxGeneralSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.CheckBox ckbxUseAllDataSources;
        private System.Windows.Forms.ListView lvScheduleTriggers;
        private System.Windows.Forms.ColumnHeader chCheckBox;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxScheduleTriggers;
        private System.Windows.Forms.Button btnRemoveScheduleTrigger;
        private System.Windows.Forms.Button btnAddScheduleTrigger;
        private System.Windows.Forms.GroupBox gbxGeneralSettings;
        private System.Windows.Forms.ColumnHeader chEventType;
        private System.Windows.Forms.ColumnHeader chPreTrigger;
        private System.Windows.Forms.ColumnHeader chPostTrigger;
        private System.Windows.Forms.ColumnHeader chTimeout;
        private System.Windows.Forms.ColumnHeader chEventProperties;
        private System.Windows.Forms.ColumnHeader chFrameRate;
        private System.Windows.Forms.ColumnHeader chTimeTable;
        private System.Windows.Forms.ColumnHeader chInactiveEventType;
        private System.Windows.Forms.ColumnHeader chAction;
    }
}