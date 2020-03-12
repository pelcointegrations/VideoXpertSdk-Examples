namespace ExampleClient.Source
{
    partial class ModifyDeviceForm
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
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.nudPort = new System.Windows.Forms.NumericUpDown();
            this.lblPort = new System.Windows.Forms.Label();
            this.cbxDriver = new System.Windows.Forms.ComboBox();
            this.tbxIp = new System.Windows.Forms.TextBox();
            this.lblIp = new System.Windows.Forms.Label();
            this.tbxVersion = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDriver = new System.Windows.Forms.Label();
            this.tbxHostname = new System.Windows.Forms.TextBox();
            this.lblHostname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(5, 69);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password: ";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(72, 66);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(175, 20);
            this.tbxPassword.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(91, 238);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(172, 238);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(72, 39);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(175, 20);
            this.tbxUsername.TabIndex = 34;
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(5, 42);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(61, 13);
            this.lblUsername.TabIndex = 33;
            this.lblUsername.Text = "Username: ";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(72, 12);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(175, 20);
            this.tbxName.TabIndex = 36;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(5, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 13);
            this.lblName.TabIndex = 35;
            this.lblName.Text = "Name: ";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudPort
            // 
            this.nudPort.Location = new System.Drawing.Point(72, 145);
            this.nudPort.Name = "nudPort";
            this.nudPort.Size = new System.Drawing.Size(120, 20);
            this.nudPort.TabIndex = 37;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(37, 148);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 38;
            this.lblPort.Text = "Port:";
            this.lblPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxDriver
            // 
            this.cbxDriver.FormattingEnabled = true;
            this.cbxDriver.Location = new System.Drawing.Point(72, 199);
            this.cbxDriver.Name = "cbxDriver";
            this.cbxDriver.Size = new System.Drawing.Size(175, 21);
            this.cbxDriver.TabIndex = 39;
            // 
            // tbxIp
            // 
            this.tbxIp.Location = new System.Drawing.Point(72, 93);
            this.tbxIp.Name = "tbxIp";
            this.tbxIp.Size = new System.Drawing.Size(175, 20);
            this.tbxIp.TabIndex = 43;
            // 
            // lblIp
            // 
            this.lblIp.Location = new System.Drawing.Point(5, 96);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(61, 13);
            this.lblIp.TabIndex = 42;
            this.lblIp.Text = "IP: ";
            this.lblIp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxVersion
            // 
            this.tbxVersion.Location = new System.Drawing.Point(72, 172);
            this.tbxVersion.Name = "tbxVersion";
            this.tbxVersion.Size = new System.Drawing.Size(175, 20);
            this.tbxVersion.TabIndex = 41;
            // 
            // lblVersion
            // 
            this.lblVersion.Location = new System.Drawing.Point(5, 175);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(61, 13);
            this.lblVersion.TabIndex = 40;
            this.lblVersion.Text = "Version: ";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDriver
            // 
            this.lblDriver.Location = new System.Drawing.Point(5, 202);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(61, 13);
            this.lblDriver.TabIndex = 44;
            this.lblDriver.Text = "Driver: ";
            this.lblDriver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxHostname
            // 
            this.tbxHostname.Location = new System.Drawing.Point(72, 119);
            this.tbxHostname.Name = "tbxHostname";
            this.tbxHostname.Size = new System.Drawing.Size(175, 20);
            this.tbxHostname.TabIndex = 46;
            // 
            // lblHostname
            // 
            this.lblHostname.Location = new System.Drawing.Point(5, 122);
            this.lblHostname.Name = "lblHostname";
            this.lblHostname.Size = new System.Drawing.Size(61, 13);
            this.lblHostname.TabIndex = 45;
            this.lblHostname.Text = "Hostname: ";
            this.lblHostname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ModifyDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 269);
            this.Controls.Add(this.tbxHostname);
            this.Controls.Add(this.lblHostname);
            this.Controls.Add(this.lblDriver);
            this.Controls.Add(this.tbxIp);
            this.Controls.Add(this.lblIp);
            this.Controls.Add(this.tbxVersion);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.cbxDriver);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.nudPort);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyDeviceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modify Device";
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.NumericUpDown nudPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.ComboBox cbxDriver;
        private System.Windows.Forms.TextBox tbxIp;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.TextBox tbxVersion;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.TextBox tbxHostname;
        private System.Windows.Forms.Label lblHostname;
    }
}