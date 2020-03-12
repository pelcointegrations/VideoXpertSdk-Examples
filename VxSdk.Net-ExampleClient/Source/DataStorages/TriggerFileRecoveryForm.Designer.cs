namespace ExampleClient.Source
{
    partial class TriggerFileRecoveryForm
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
            this.btnTrigger = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxVolume = new System.Windows.Forms.GroupBox();
            this.cbxVolume = new System.Windows.Forms.ComboBox();
            this.gbxEndTime.SuspendLayout();
            this.gbxStartTime.SuspendLayout();
            this.gbxVolume.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxEndTime
            // 
            this.gbxEndTime.Controls.Add(this.dtpEndDate);
            this.gbxEndTime.Location = new System.Drawing.Point(12, 140);
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
            this.gbxStartTime.Location = new System.Drawing.Point(12, 76);
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
            // btnTrigger
            // 
            this.btnTrigger.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTrigger.Enabled = false;
            this.btnTrigger.Location = new System.Drawing.Point(152, 204);
            this.btnTrigger.Name = "btnTrigger";
            this.btnTrigger.Size = new System.Drawing.Size(75, 23);
            this.btnTrigger.TabIndex = 7;
            this.btnTrigger.Text = "Trigger";
            this.btnTrigger.UseVisualStyleBackColor = true;
            this.btnTrigger.Click += new System.EventHandler(this.ButtonTrigger_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(71, 204);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // gbxVolume
            // 
            this.gbxVolume.Controls.Add(this.cbxVolume);
            this.gbxVolume.Location = new System.Drawing.Point(12, 12);
            this.gbxVolume.Name = "gbxVolume";
            this.gbxVolume.Size = new System.Drawing.Size(215, 58);
            this.gbxVolume.TabIndex = 6;
            this.gbxVolume.TabStop = false;
            this.gbxVolume.Text = "Volume";
            // 
            // cbxVolume
            // 
            this.cbxVolume.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVolume.FormattingEnabled = true;
            this.cbxVolume.Location = new System.Drawing.Point(7, 21);
            this.cbxVolume.Name = "cbxVolume";
            this.cbxVolume.Size = new System.Drawing.Size(202, 21);
            this.cbxVolume.TabIndex = 0;
            this.cbxVolume.SelectedIndexChanged += new System.EventHandler(this.ComboboxVolume_SelectedIndexChanged);
            // 
            // TriggerFileRecoveryForm
            // 
            this.AcceptButton = this.btnTrigger;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(243, 237);
            this.Controls.Add(this.gbxVolume);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTrigger);
            this.Controls.Add(this.gbxEndTime);
            this.Controls.Add(this.gbxStartTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TriggerFileRecoveryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trigger File Recovery";
            this.gbxEndTime.ResumeLayout(false);
            this.gbxStartTime.ResumeLayout(false);
            this.gbxVolume.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxEndTime;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.GroupBox gbxStartTime;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Button btnTrigger;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbxVolume;
        private System.Windows.Forms.ComboBox cbxVolume;
    }
}