namespace ExampleClient.Source.Misc
{
    partial class SmtpConfigurationForm
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
            this.cbxValidateCert = new System.Windows.Forms.CheckBox();
            this.cbxUseSmtps = new System.Windows.Forms.CheckBox();
            this.nudSmtpPort = new System.Windows.Forms.NumericUpDown();
            this.lblSmtpPort = new System.Windows.Forms.Label();
            this.tbxFromAddress = new System.Windows.Forms.TextBox();
            this.tbxSmtpHost = new System.Windows.Forms.TextBox();
            this.lblFromAddress = new System.Windows.Forms.Label();
            this.lblSmtpHost = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.lblTimeout = new System.Windows.Forms.Label();
            this.nudTimeout = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudSmtpPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxValidateCert
            // 
            this.cbxValidateCert.AutoSize = true;
            this.cbxValidateCert.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxValidateCert.Location = new System.Drawing.Point(126, 12);
            this.cbxValidateCert.Name = "cbxValidateCert";
            this.cbxValidateCert.Size = new System.Drawing.Size(154, 17);
            this.cbxValidateCert.TabIndex = 0;
            this.cbxValidateCert.Text = "Validate Server Certificate: ";
            this.cbxValidateCert.UseVisualStyleBackColor = true;
            // 
            // cbxUseSmtps
            // 
            this.cbxUseSmtps.AutoSize = true;
            this.cbxUseSmtps.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxUseSmtps.Location = new System.Drawing.Point(12, 12);
            this.cbxUseSmtps.Name = "cbxUseSmtps";
            this.cbxUseSmtps.Size = new System.Drawing.Size(91, 17);
            this.cbxUseSmtps.TabIndex = 1;
            this.cbxUseSmtps.Text = "Use SMTPS: ";
            this.cbxUseSmtps.UseVisualStyleBackColor = true;
            // 
            // nudSmtpPort
            // 
            this.nudSmtpPort.Location = new System.Drawing.Point(88, 65);
            this.nudSmtpPort.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudSmtpPort.Name = "nudSmtpPort";
            this.nudSmtpPort.Size = new System.Drawing.Size(71, 20);
            this.nudSmtpPort.TabIndex = 5;
            // 
            // lblSmtpPort
            // 
            this.lblSmtpPort.AutoSize = true;
            this.lblSmtpPort.Location = new System.Drawing.Point(17, 67);
            this.lblSmtpPort.Name = "lblSmtpPort";
            this.lblSmtpPort.Size = new System.Drawing.Size(65, 13);
            this.lblSmtpPort.TabIndex = 6;
            this.lblSmtpPort.Text = "SMTP  Port:";
            // 
            // tbxFromAddress
            // 
            this.tbxFromAddress.Location = new System.Drawing.Point(88, 91);
            this.tbxFromAddress.Name = "tbxFromAddress";
            this.tbxFromAddress.Size = new System.Drawing.Size(192, 20);
            this.tbxFromAddress.TabIndex = 7;
            // 
            // tbxSmtpHost
            // 
            this.tbxSmtpHost.Location = new System.Drawing.Point(88, 37);
            this.tbxSmtpHost.Name = "tbxSmtpHost";
            this.tbxSmtpHost.Size = new System.Drawing.Size(192, 20);
            this.tbxSmtpHost.TabIndex = 8;
            // 
            // lblFromAddress
            // 
            this.lblFromAddress.AutoSize = true;
            this.lblFromAddress.Location = new System.Drawing.Point(8, 94);
            this.lblFromAddress.Name = "lblFromAddress";
            this.lblFromAddress.Size = new System.Drawing.Size(74, 13);
            this.lblFromAddress.TabIndex = 16;
            this.lblFromAddress.Text = "From Address:";
            // 
            // lblSmtpHost
            // 
            this.lblSmtpHost.AutoSize = true;
            this.lblSmtpHost.Location = new System.Drawing.Point(17, 39);
            this.lblSmtpHost.Name = "lblSmtpHost";
            this.lblSmtpHost.Size = new System.Drawing.Size(65, 13);
            this.lblSmtpHost.TabIndex = 17;
            this.lblSmtpHost.Text = "SMTP Host:";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(467, 129);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(386, 129);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(12, 129);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(108, 23);
            this.btnValidate.TabIndex = 27;
            this.btnValidate.Text = "Send Test Email";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.ButtonValidate_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(288, 67);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 31;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(286, 39);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 30;
            this.lblUsername.Text = "Username:";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(350, 64);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(192, 20);
            this.tbxPassword.TabIndex = 29;
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(350, 36);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(192, 20);
            this.tbxUsername.TabIndex = 28;
            // 
            // lblTimeout
            // 
            this.lblTimeout.AutoSize = true;
            this.lblTimeout.Location = new System.Drawing.Point(296, 11);
            this.lblTimeout.Name = "lblTimeout";
            this.lblTimeout.Size = new System.Drawing.Size(48, 13);
            this.lblTimeout.TabIndex = 34;
            this.lblTimeout.Text = "Timeout:";
            // 
            // nudTimeout
            // 
            this.nudTimeout.Location = new System.Drawing.Point(350, 9);
            this.nudTimeout.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudTimeout.Name = "nudTimeout";
            this.nudTimeout.Size = new System.Drawing.Size(71, 20);
            this.nudTimeout.TabIndex = 33;
            // 
            // SmtpConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 164);
            this.Controls.Add(this.tbxFromAddress);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.lblFromAddress);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.nudSmtpPort);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTimeout);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.lblSmtpHost);
            this.Controls.Add(this.nudTimeout);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.cbxValidateCert);
            this.Controls.Add(this.lblSmtpPort);
            this.Controls.Add(this.tbxSmtpHost);
            this.Controls.Add(this.cbxUseSmtps);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SmtpConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SMTP Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.nudSmtpPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxValidateCert;
        private System.Windows.Forms.CheckBox cbxUseSmtps;
        private System.Windows.Forms.NumericUpDown nudSmtpPort;
        private System.Windows.Forms.Label lblSmtpPort;
        private System.Windows.Forms.TextBox tbxFromAddress;
        private System.Windows.Forms.TextBox tbxSmtpHost;
        private System.Windows.Forms.Label lblFromAddress;
        private System.Windows.Forms.Label lblSmtpHost;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label lblTimeout;
        private System.Windows.Forms.NumericUpDown nudTimeout;
    }
}