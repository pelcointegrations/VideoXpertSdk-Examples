namespace ExampleClient.Source
{
    partial class AuthConfigForm
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
            this.gbxPasswordExpiration = new System.Windows.Forms.GroupBox();
            this.nudPasswordExpiration = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chbxPasswordExpiration = new System.Windows.Forms.CheckBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.gbxPasswordExpiration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasswordExpiration)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPasswordExpiration
            // 
            this.gbxPasswordExpiration.Controls.Add(this.lblDays);
            this.gbxPasswordExpiration.Controls.Add(this.chbxPasswordExpiration);
            this.gbxPasswordExpiration.Controls.Add(this.nudPasswordExpiration);
            this.gbxPasswordExpiration.Location = new System.Drawing.Point(12, 12);
            this.gbxPasswordExpiration.Name = "gbxPasswordExpiration";
            this.gbxPasswordExpiration.Size = new System.Drawing.Size(247, 58);
            this.gbxPasswordExpiration.TabIndex = 6;
            this.gbxPasswordExpiration.TabStop = false;
            this.gbxPasswordExpiration.Text = "Password Expiration";
            // 
            // nudPasswordExpiration
            // 
            this.nudPasswordExpiration.Location = new System.Drawing.Point(158, 19);
            this.nudPasswordExpiration.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudPasswordExpiration.Name = "nudPasswordExpiration";
            this.nudPasswordExpiration.Size = new System.Drawing.Size(83, 20);
            this.nudPasswordExpiration.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(184, 76);
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
            this.btnCancel.Location = new System.Drawing.Point(103, 76);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // chbxPasswordExpiration
            // 
            this.chbxPasswordExpiration.AutoSize = true;
            this.chbxPasswordExpiration.Location = new System.Drawing.Point(18, 21);
            this.chbxPasswordExpiration.Name = "chbxPasswordExpiration";
            this.chbxPasswordExpiration.Size = new System.Drawing.Size(65, 17);
            this.chbxPasswordExpiration.TabIndex = 0;
            this.chbxPasswordExpiration.Text = "Enabled";
            this.chbxPasswordExpiration.UseVisualStyleBackColor = true;
            this.chbxPasswordExpiration.CheckedChanged += new System.EventHandler(this.CheckboxPasswordExpiration_CheckedChanged);
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(118, 23);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(34, 13);
            this.lblDays.TabIndex = 1;
            this.lblDays.Text = "Days:";
            // 
            // AuthConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 113);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxPasswordExpiration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Authentication Config";
            this.gbxPasswordExpiration.ResumeLayout(false);
            this.gbxPasswordExpiration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasswordExpiration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxPasswordExpiration;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nudPasswordExpiration;
        private System.Windows.Forms.CheckBox chbxPasswordExpiration;
        private System.Windows.Forms.Label lblDays;
    }
}