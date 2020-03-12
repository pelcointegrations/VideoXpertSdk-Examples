namespace ExampleClient.Source
{
    partial class BookmarkConfigForm
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
            this.gbxAutoUnlock = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxRetentionLimit = new System.Windows.Forms.GroupBox();
            this.gbxRetentionPolicy = new System.Windows.Forms.GroupBox();
            this.nudAutoUnlock = new System.Windows.Forms.NumericUpDown();
            this.nudRetentionLimit = new System.Windows.Forms.NumericUpDown();
            this.cbxRetentionPolicy = new System.Windows.Forms.ComboBox();
            this.gbxAutoUnlock.SuspendLayout();
            this.gbxRetentionLimit.SuspendLayout();
            this.gbxRetentionPolicy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoUnlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRetentionLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxAutoUnlock
            // 
            this.gbxAutoUnlock.Controls.Add(this.nudAutoUnlock);
            this.gbxAutoUnlock.Location = new System.Drawing.Point(12, 12);
            this.gbxAutoUnlock.Name = "gbxAutoUnlock";
            this.gbxAutoUnlock.Size = new System.Drawing.Size(117, 58);
            this.gbxAutoUnlock.TabIndex = 6;
            this.gbxAutoUnlock.TabStop = false;
            this.gbxAutoUnlock.Text = "Auto Unlock (Days)";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(184, 140);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(103, 140);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // gbxRetentionLimit
            // 
            this.gbxRetentionLimit.Controls.Add(this.nudRetentionLimit);
            this.gbxRetentionLimit.Location = new System.Drawing.Point(135, 12);
            this.gbxRetentionLimit.Name = "gbxRetentionLimit";
            this.gbxRetentionLimit.Size = new System.Drawing.Size(124, 58);
            this.gbxRetentionLimit.TabIndex = 7;
            this.gbxRetentionLimit.TabStop = false;
            this.gbxRetentionLimit.Text = "Retention Limit (Days)";
            // 
            // gbxRetentionPolicy
            // 
            this.gbxRetentionPolicy.Controls.Add(this.cbxRetentionPolicy);
            this.gbxRetentionPolicy.Location = new System.Drawing.Point(12, 76);
            this.gbxRetentionPolicy.Name = "gbxRetentionPolicy";
            this.gbxRetentionPolicy.Size = new System.Drawing.Size(247, 58);
            this.gbxRetentionPolicy.TabIndex = 20;
            this.gbxRetentionPolicy.TabStop = false;
            this.gbxRetentionPolicy.Text = "Retention Policy";
            // 
            // nudAutoUnlock
            // 
            this.nudAutoUnlock.Location = new System.Drawing.Point(6, 19);
            this.nudAutoUnlock.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudAutoUnlock.Name = "nudAutoUnlock";
            this.nudAutoUnlock.Size = new System.Drawing.Size(83, 20);
            this.nudAutoUnlock.TabIndex = 0;
            // 
            // nudRetentionLimit
            // 
            this.nudRetentionLimit.Location = new System.Drawing.Point(14, 19);
            this.nudRetentionLimit.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudRetentionLimit.Name = "nudRetentionLimit";
            this.nudRetentionLimit.Size = new System.Drawing.Size(75, 20);
            this.nudRetentionLimit.TabIndex = 0;
            // 
            // cbxRetentionPolicy
            // 
            this.cbxRetentionPolicy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRetentionPolicy.FormattingEnabled = true;
            this.cbxRetentionPolicy.Items.AddRange(new object[] {
            "Delete After Limit",
            "Delete After Recording",
            "Never Delete"});
            this.cbxRetentionPolicy.Location = new System.Drawing.Point(6, 20);
            this.cbxRetentionPolicy.Name = "cbxRetentionPolicy";
            this.cbxRetentionPolicy.Size = new System.Drawing.Size(235, 21);
            this.cbxRetentionPolicy.TabIndex = 0;
            // 
            // BookmarkConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 173);
            this.Controls.Add(this.gbxRetentionPolicy);
            this.Controls.Add(this.gbxRetentionLimit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxAutoUnlock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookmarkConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bookmark Config";
            this.gbxAutoUnlock.ResumeLayout(false);
            this.gbxRetentionLimit.ResumeLayout(false);
            this.gbxRetentionPolicy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoUnlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRetentionLimit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxAutoUnlock;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbxRetentionLimit;
        private System.Windows.Forms.GroupBox gbxRetentionPolicy;
        private System.Windows.Forms.NumericUpDown nudAutoUnlock;
        private System.Windows.Forms.NumericUpDown nudRetentionLimit;
        private System.Windows.Forms.ComboBox cbxRetentionPolicy;
    }
}