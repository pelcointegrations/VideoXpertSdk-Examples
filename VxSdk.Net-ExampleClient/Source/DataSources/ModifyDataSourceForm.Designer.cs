namespace ExampleClient.Source
{
    partial class ModifyDataSourceForm
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.nudRetentionLimit = new System.Windows.Forms.NumericUpDown();
            this.lblRetentionLimit = new System.Windows.Forms.Label();
            this.chbxEnabled = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRetentionLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(153, 109);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(234, 109);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.Location = new System.Drawing.Point(32, 47);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(61, 13);
            this.lblNumber.TabIndex = 33;
            this.lblNumber.Text = "Number: ";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(99, 13);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(210, 20);
            this.tbxName.TabIndex = 36;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(32, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 13);
            this.lblName.TabIndex = 35;
            this.lblName.Text = "Name: ";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudNumber
            // 
            this.nudNumber.Location = new System.Drawing.Point(99, 45);
            this.nudNumber.Margin = new System.Windows.Forms.Padding(2);
            this.nudNumber.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(90, 20);
            this.nudNumber.TabIndex = 37;
            // 
            // nudRetentionLimit
            // 
            this.nudRetentionLimit.Location = new System.Drawing.Point(99, 76);
            this.nudRetentionLimit.Margin = new System.Windows.Forms.Padding(2);
            this.nudRetentionLimit.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudRetentionLimit.Name = "nudRetentionLimit";
            this.nudRetentionLimit.Size = new System.Drawing.Size(90, 20);
            this.nudRetentionLimit.TabIndex = 39;
            // 
            // lblRetentionLimit
            // 
            this.lblRetentionLimit.Location = new System.Drawing.Point(7, 78);
            this.lblRetentionLimit.Name = "lblRetentionLimit";
            this.lblRetentionLimit.Size = new System.Drawing.Size(86, 13);
            this.lblRetentionLimit.TabIndex = 38;
            this.lblRetentionLimit.Text = "Retention Limit: ";
            this.lblRetentionLimit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chbxEnabled
            // 
            this.chbxEnabled.AutoSize = true;
            this.chbxEnabled.Location = new System.Drawing.Point(229, 79);
            this.chbxEnabled.Name = "chbxEnabled";
            this.chbxEnabled.Size = new System.Drawing.Size(65, 17);
            this.chbxEnabled.TabIndex = 40;
            this.chbxEnabled.Text = "Enabled";
            this.chbxEnabled.UseVisualStyleBackColor = true;
            // 
            // ModifyDataSourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 144);
            this.Controls.Add(this.chbxEnabled);
            this.Controls.Add(this.nudRetentionLimit);
            this.Controls.Add(this.lblRetentionLimit);
            this.Controls.Add(this.nudNumber);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyDataSourceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modify Data Source";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRetentionLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.NumericUpDown nudRetentionLimit;
        private System.Windows.Forms.Label lblRetentionLimit;
        private System.Windows.Forms.CheckBox chbxEnabled;
    }
}