namespace ExampleClient.Source
{
    partial class ModifyMemberForm
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbxHost = new System.Windows.Forms.TextBox();
            this.lblHost = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.cbxRtspCapabilities = new System.Windows.Forms.ComboBox();
            this.lblRtspCapabilities = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.nudPort = new System.Windows.Forms.NumericUpDown();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblBandwidth = new System.Windows.Forms.Label();
            this.nudBandwidth = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBandwidth)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(72, 182);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(153, 182);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(12, 61);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(89, 13);
            this.lblUsername.TabIndex = 33;
            this.lblUsername.Text = "Username:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxHost
            // 
            this.tbxHost.Location = new System.Drawing.Point(107, 6);
            this.tbxHost.Name = "tbxHost";
            this.tbxHost.Size = new System.Drawing.Size(121, 20);
            this.tbxHost.TabIndex = 36;
            // 
            // lblHost
            // 
            this.lblHost.Location = new System.Drawing.Point(12, 9);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(89, 13);
            this.lblHost.TabIndex = 35;
            this.lblHost.Text = "Host: ";
            this.lblHost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(107, 58);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(121, 20);
            this.tbxUsername.TabIndex = 37;
            // 
            // cbxRtspCapabilities
            // 
            this.cbxRtspCapabilities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRtspCapabilities.FormattingEnabled = true;
            this.cbxRtspCapabilities.Items.AddRange(new object[] {
            "Tcp",
            "Tcp & Udp",
            "Tcp, Udp & Multicast"});
            this.cbxRtspCapabilities.Location = new System.Drawing.Point(107, 136);
            this.cbxRtspCapabilities.Name = "cbxRtspCapabilities";
            this.cbxRtspCapabilities.Size = new System.Drawing.Size(121, 21);
            this.cbxRtspCapabilities.TabIndex = 38;
            // 
            // lblRtspCapabilities
            // 
            this.lblRtspCapabilities.Location = new System.Drawing.Point(12, 139);
            this.lblRtspCapabilities.Name = "lblRtspCapabilities";
            this.lblRtspCapabilities.Size = new System.Drawing.Size(89, 13);
            this.lblRtspCapabilities.TabIndex = 39;
            this.lblRtspCapabilities.Text = "Rtsp Capabilities: ";
            this.lblRtspCapabilities.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(108, 84);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(120, 20);
            this.tbxPassword.TabIndex = 41;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(12, 87);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(89, 13);
            this.lblPassword.TabIndex = 40;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudPort
            // 
            this.nudPort.Location = new System.Drawing.Point(107, 32);
            this.nudPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudPort.Name = "nudPort";
            this.nudPort.Size = new System.Drawing.Size(121, 20);
            this.nudPort.TabIndex = 42;
            // 
            // lblPort
            // 
            this.lblPort.Location = new System.Drawing.Point(12, 35);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(89, 13);
            this.lblPort.TabIndex = 43;
            this.lblPort.Text = "Port:";
            this.lblPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBandwidth
            // 
            this.lblBandwidth.Location = new System.Drawing.Point(12, 113);
            this.lblBandwidth.Name = "lblBandwidth";
            this.lblBandwidth.Size = new System.Drawing.Size(89, 13);
            this.lblBandwidth.TabIndex = 45;
            this.lblBandwidth.Text = "Bandwidth:";
            this.lblBandwidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudBandwidth
            // 
            this.nudBandwidth.Location = new System.Drawing.Point(107, 110);
            this.nudBandwidth.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudBandwidth.Name = "nudBandwidth";
            this.nudBandwidth.Size = new System.Drawing.Size(121, 20);
            this.nudBandwidth.TabIndex = 44;
            // 
            // ModifyMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 218);
            this.Controls.Add(this.lblBandwidth);
            this.Controls.Add(this.nudBandwidth);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.nudPort);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblRtspCapabilities);
            this.Controls.Add(this.cbxRtspCapabilities);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.tbxHost);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyMemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modify Member";
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBandwidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbxHost;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.ComboBox cbxRtspCapabilities;
        private System.Windows.Forms.Label lblRtspCapabilities;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.NumericUpDown nudPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblBandwidth;
        private System.Windows.Forms.NumericUpDown nudBandwidth;
    }
}