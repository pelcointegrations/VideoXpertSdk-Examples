namespace ExampleClient.Source
{
    partial class AddBookmarkForm
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
            this.lvDataSources = new System.Windows.Forms.ListView();
            this.chCheckbox = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxTime = new System.Windows.Forms.GroupBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.gbxDescription = new System.Windows.Forms.GroupBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxName = new System.Windows.Forms.GroupBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.gbxLockStartTime = new System.Windows.Forms.GroupBox();
            this.dtpLockStartTime = new System.Windows.Forms.DateTimePicker();
            this.gbxLockEndTime = new System.Windows.Forms.GroupBox();
            this.dtpLockEndTime = new System.Windows.Forms.DateTimePicker();
            this.gbxLock = new System.Windows.Forms.GroupBox();
            this.chbxLockEnabled = new System.Windows.Forms.CheckBox();
            this.gbxDataSources = new System.Windows.Forms.GroupBox();
            this.gbxTime.SuspendLayout();
            this.gbxDescription.SuspendLayout();
            this.gbxName.SuspendLayout();
            this.gbxLockStartTime.SuspendLayout();
            this.gbxLockEndTime.SuspendLayout();
            this.gbxLock.SuspendLayout();
            this.gbxDataSources.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvDataSources
            // 
            this.lvDataSources.CheckBoxes = true;
            this.lvDataSources.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCheckbox,
            this.chNumber,
            this.chName});
            this.lvDataSources.HideSelection = false;
            this.lvDataSources.Location = new System.Drawing.Point(6, 19);
            this.lvDataSources.MultiSelect = false;
            this.lvDataSources.Name = "lvDataSources";
            this.lvDataSources.Size = new System.Drawing.Size(335, 377);
            this.lvDataSources.TabIndex = 16;
            this.lvDataSources.UseCompatibleStateImageBehavior = false;
            this.lvDataSources.View = System.Windows.Forms.View.Details;
            this.lvDataSources.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ListViewDataSources_ItemCheck);
            // 
            // chCheckbox
            // 
            this.chCheckbox.Text = "";
            this.chCheckbox.Width = 20;
            // 
            // chNumber
            // 
            this.chNumber.Text = "#";
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 250;
            // 
            // gbxTime
            // 
            this.gbxTime.Controls.Add(this.dtpTime);
            this.gbxTime.Location = new System.Drawing.Point(365, 140);
            this.gbxTime.Name = "gbxTime";
            this.gbxTime.Size = new System.Drawing.Size(215, 58);
            this.gbxTime.TabIndex = 18;
            this.gbxTime.TabStop = false;
            this.gbxTime.Text = "Time";
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm:ss  MM/dd/yyyy";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(6, 23);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(204, 20);
            this.dtpTime.TabIndex = 2;
            // 
            // gbxDescription
            // 
            this.gbxDescription.Controls.Add(this.tbxDescription);
            this.gbxDescription.Location = new System.Drawing.Point(365, 12);
            this.gbxDescription.Name = "gbxDescription";
            this.gbxDescription.Size = new System.Drawing.Size(215, 58);
            this.gbxDescription.TabIndex = 6;
            this.gbxDescription.TabStop = false;
            this.gbxDescription.Text = "Description";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(6, 19);
            this.tbxDescription.MaxLength = 255;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(203, 20);
            this.tbxDescription.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(505, 391);
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
            this.btnCancel.Location = new System.Drawing.Point(424, 391);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // gbxName
            // 
            this.gbxName.Controls.Add(this.tbxName);
            this.gbxName.Location = new System.Drawing.Point(365, 76);
            this.gbxName.Name = "gbxName";
            this.gbxName.Size = new System.Drawing.Size(215, 58);
            this.gbxName.TabIndex = 7;
            this.gbxName.TabStop = false;
            this.gbxName.Text = "Name";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(6, 19);
            this.tbxName.MaxLength = 64;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(203, 20);
            this.tbxName.TabIndex = 0;
            // 
            // gbxLockStartTime
            // 
            this.gbxLockStartTime.Controls.Add(this.dtpLockStartTime);
            this.gbxLockStartTime.Enabled = false;
            this.gbxLockStartTime.Location = new System.Drawing.Point(365, 260);
            this.gbxLockStartTime.Name = "gbxLockStartTime";
            this.gbxLockStartTime.Size = new System.Drawing.Size(215, 58);
            this.gbxLockStartTime.TabIndex = 19;
            this.gbxLockStartTime.TabStop = false;
            this.gbxLockStartTime.Text = "Lock Start Time";
            // 
            // dtpLockStartTime
            // 
            this.dtpLockStartTime.CustomFormat = "HH:mm:ss  MM/dd/yyyy";
            this.dtpLockStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLockStartTime.Location = new System.Drawing.Point(6, 23);
            this.dtpLockStartTime.Name = "dtpLockStartTime";
            this.dtpLockStartTime.Size = new System.Drawing.Size(204, 20);
            this.dtpLockStartTime.TabIndex = 2;
            this.dtpLockStartTime.ValueChanged += new System.EventHandler(this.DateTimePickerLockTime_ValueChanged);
            // 
            // gbxLockEndTime
            // 
            this.gbxLockEndTime.Controls.Add(this.dtpLockEndTime);
            this.gbxLockEndTime.Enabled = false;
            this.gbxLockEndTime.Location = new System.Drawing.Point(365, 324);
            this.gbxLockEndTime.Name = "gbxLockEndTime";
            this.gbxLockEndTime.Size = new System.Drawing.Size(215, 58);
            this.gbxLockEndTime.TabIndex = 20;
            this.gbxLockEndTime.TabStop = false;
            this.gbxLockEndTime.Text = "Lock End Time";
            // 
            // dtpLockEndTime
            // 
            this.dtpLockEndTime.CustomFormat = "HH:mm:ss  MM/dd/yyyy";
            this.dtpLockEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLockEndTime.Location = new System.Drawing.Point(6, 23);
            this.dtpLockEndTime.Name = "dtpLockEndTime";
            this.dtpLockEndTime.Size = new System.Drawing.Size(204, 20);
            this.dtpLockEndTime.TabIndex = 2;
            this.dtpLockEndTime.ValueChanged += new System.EventHandler(this.DateTimePickerLockTime_ValueChanged);
            // 
            // gbxLock
            // 
            this.gbxLock.Controls.Add(this.chbxLockEnabled);
            this.gbxLock.Location = new System.Drawing.Point(365, 204);
            this.gbxLock.Name = "gbxLock";
            this.gbxLock.Size = new System.Drawing.Size(215, 50);
            this.gbxLock.TabIndex = 19;
            this.gbxLock.TabStop = false;
            this.gbxLock.Text = "Lock";
            // 
            // chbxLockEnabled
            // 
            this.chbxLockEnabled.AutoSize = true;
            this.chbxLockEnabled.Location = new System.Drawing.Point(8, 21);
            this.chbxLockEnabled.Name = "chbxLockEnabled";
            this.chbxLockEnabled.Size = new System.Drawing.Size(65, 17);
            this.chbxLockEnabled.TabIndex = 0;
            this.chbxLockEnabled.Text = "Enabled";
            this.chbxLockEnabled.UseVisualStyleBackColor = true;
            this.chbxLockEnabled.CheckedChanged += new System.EventHandler(this.CheckboxLockEnabled_CheckedChanged);
            // 
            // gbxDataSources
            // 
            this.gbxDataSources.Controls.Add(this.lvDataSources);
            this.gbxDataSources.Location = new System.Drawing.Point(12, 12);
            this.gbxDataSources.Name = "gbxDataSources";
            this.gbxDataSources.Size = new System.Drawing.Size(347, 402);
            this.gbxDataSources.TabIndex = 21;
            this.gbxDataSources.TabStop = false;
            this.gbxDataSources.Text = "Data Source";
            // 
            // AddBookmarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 426);
            this.Controls.Add(this.gbxDataSources);
            this.Controls.Add(this.gbxLock);
            this.Controls.Add(this.gbxLockEndTime);
            this.Controls.Add(this.gbxLockStartTime);
            this.Controls.Add(this.gbxName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbxDescription);
            this.Controls.Add(this.gbxTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBookmarkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Bookmark";
            this.gbxTime.ResumeLayout(false);
            this.gbxDescription.ResumeLayout(false);
            this.gbxDescription.PerformLayout();
            this.gbxName.ResumeLayout(false);
            this.gbxName.PerformLayout();
            this.gbxLockStartTime.ResumeLayout(false);
            this.gbxLockEndTime.ResumeLayout(false);
            this.gbxLock.ResumeLayout(false);
            this.gbxLock.PerformLayout();
            this.gbxDataSources.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvDataSources;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.GroupBox gbxTime;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.GroupBox gbxDescription;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbxName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.GroupBox gbxLockStartTime;
        private System.Windows.Forms.DateTimePicker dtpLockStartTime;
        private System.Windows.Forms.GroupBox gbxLockEndTime;
        private System.Windows.Forms.DateTimePicker dtpLockEndTime;
        private System.Windows.Forms.GroupBox gbxLock;
        private System.Windows.Forms.CheckBox chbxLockEnabled;
        private System.Windows.Forms.ColumnHeader chNumber;
        private System.Windows.Forms.ColumnHeader chCheckbox;
        private System.Windows.Forms.GroupBox gbxDataSources;
    }
}