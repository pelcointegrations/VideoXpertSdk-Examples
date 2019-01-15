namespace ExampleClient.Source
{
    partial class AddEdgeClipForm
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
            this.gbxEndTime = new System.Windows.Forms.GroupBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.gbxStartTime = new System.Windows.Forms.GroupBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lvDataStorages = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHostType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvEdgeClips = new System.Windows.Forms.ListView();
            this.chRecordingType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFrameRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblNoClips = new System.Windows.Forms.Label();
            this.gbxEndTime.SuspendLayout();
            this.gbxStartTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxEndTime
            // 
            this.gbxEndTime.Controls.Add(this.dtpEndDate);
            this.gbxEndTime.Enabled = false;
            this.gbxEndTime.Location = new System.Drawing.Point(923, 89);
            this.gbxEndTime.Name = "gbxEndTime";
            this.gbxEndTime.Size = new System.Drawing.Size(215, 58);
            this.gbxEndTime.TabIndex = 6;
            this.gbxEndTime.TabStop = false;
            this.gbxEndTime.Text = "End Time";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "HH:mm:ss  MM/dd/yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(6, 23);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(204, 20);
            this.dtpEndDate.TabIndex = 2;
            // 
            // gbxStartTime
            // 
            this.gbxStartTime.Controls.Add(this.dtpStartDate);
            this.gbxStartTime.Enabled = false;
            this.gbxStartTime.Location = new System.Drawing.Point(923, 12);
            this.gbxStartTime.Name = "gbxStartTime";
            this.gbxStartTime.Size = new System.Drawing.Size(215, 58);
            this.gbxStartTime.TabIndex = 5;
            this.gbxStartTime.TabStop = false;
            this.gbxStartTime.Text = "Start Time";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "HH:mm:ss  MM/dd/yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(6, 23);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(204, 20);
            this.dtpStartDate.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(1058, 188);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(977, 188);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lvDataStorages
            // 
            this.lvDataStorages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chHostType});
            this.lvDataStorages.FullRowSelect = true;
            this.lvDataStorages.Location = new System.Drawing.Point(12, 12);
            this.lvDataStorages.Name = "lvDataStorages";
            this.lvDataStorages.Size = new System.Drawing.Size(398, 199);
            this.lvDataStorages.TabIndex = 15;
            this.lvDataStorages.UseCompatibleStateImageBehavior = false;
            this.lvDataStorages.View = System.Windows.Forms.View.Details;
            this.lvDataStorages.SelectedIndexChanged += new System.EventHandler(this.ListViewDataStorages_SelectedIndexChanged);
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 277;
            // 
            // chHostType
            // 
            this.chHostType.Text = "Device Type";
            this.chHostType.Width = 116;
            // 
            // lvEdgeClips
            // 
            this.lvEdgeClips.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chRecordingType,
            this.chFrameRate,
            this.chStartTime,
            this.chEndTime});
            this.lvEdgeClips.FullRowSelect = true;
            this.lvEdgeClips.Location = new System.Drawing.Point(422, 12);
            this.lvEdgeClips.Name = "lvEdgeClips";
            this.lvEdgeClips.Size = new System.Drawing.Size(501, 199);
            this.lvEdgeClips.TabIndex = 16;
            this.lvEdgeClips.UseCompatibleStateImageBehavior = false;
            this.lvEdgeClips.View = System.Windows.Forms.View.Details;
            this.lvEdgeClips.SelectedIndexChanged += new System.EventHandler(this.ListViewEdgeClips_SelectedIndexChanged);
            // 
            // chRecordingType
            // 
            this.chRecordingType.Text = "Type";
            this.chRecordingType.Width = 100;
            // 
            // chFrameRate
            // 
            this.chFrameRate.Text = "Framerate";
            this.chFrameRate.Width = 95;
            // 
            // chStartTime
            // 
            this.chStartTime.Text = "Start Time";
            this.chStartTime.Width = 150;
            // 
            // chEndTime
            // 
            this.chEndTime.Text = "End Time";
            this.chEndTime.Width = 150;
            // 
            // lblNoClips
            // 
            this.lblNoClips.AutoSize = true;
            this.lblNoClips.BackColor = System.Drawing.Color.White;
            this.lblNoClips.Location = new System.Drawing.Point(633, 106);
            this.lblNoClips.Name = "lblNoClips";
            this.lblNoClips.Size = new System.Drawing.Size(79, 13);
            this.lblNoClips.TabIndex = 17;
            this.lblNoClips.Text = "No Clips Found";
            this.lblNoClips.Visible = false;
            // 
            // AddEdgeClipForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1155, 225);
            this.Controls.Add(this.lblNoClips);
            this.Controls.Add(this.lvEdgeClips);
            this.Controls.Add(this.lvDataStorages);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbxEndTime);
            this.Controls.Add(this.gbxStartTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEdgeClipForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Clip";
            this.gbxEndTime.ResumeLayout(false);
            this.gbxStartTime.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxEndTime;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.GroupBox gbxStartTime;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView lvDataStorages;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chHostType;
        private System.Windows.Forms.ListView lvEdgeClips;
        private System.Windows.Forms.ColumnHeader chRecordingType;
        private System.Windows.Forms.ColumnHeader chFrameRate;
        private System.Windows.Forms.ColumnHeader chStartTime;
        private System.Windows.Forms.ColumnHeader chEndTime;
        private System.Windows.Forms.Label lblNoClips;
    }
}