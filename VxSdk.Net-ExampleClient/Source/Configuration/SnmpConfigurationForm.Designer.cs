namespace ExampleClient.Source.Misc
{
    partial class SnmpConfigurationForm
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
            this.nudSnmpPort = new System.Windows.Forms.NumericUpDown();
            this.lblSnmpPort = new System.Windows.Forms.Label();
            this.tbxReadCommString = new System.Windows.Forms.TextBox();
            this.tbxReadUsername = new System.Windows.Forms.TextBox();
            this.lblReadCommString = new System.Windows.Forms.Label();
            this.lblReadUsername = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbxSnmpVersion = new System.Windows.Forms.ComboBox();
            this.lblSnmpVersion = new System.Windows.Forms.Label();
            this.gbxSnmpV2C = new System.Windows.Forms.GroupBox();
            this.gbxSnmpV3 = new System.Windows.Forms.GroupBox();
            this.lblAuthProtocol = new System.Windows.Forms.Label();
            this.lblPrivacyProtocol = new System.Windows.Forms.Label();
            this.cbxAuthProtocol = new System.Windows.Forms.ComboBox();
            this.cbxPrivacyProtocol = new System.Windows.Forms.ComboBox();
            this.lblReadPrivacyPassword = new System.Windows.Forms.Label();
            this.tbxReadPrivacyPassword = new System.Windows.Forms.TextBox();
            this.tbxReadAuthPassword = new System.Windows.Forms.TextBox();
            this.lblReadAuthPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSnmpPort)).BeginInit();
            this.gbxSnmpV2C.SuspendLayout();
            this.gbxSnmpV3.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudSnmpPort
            // 
            this.nudSnmpPort.Location = new System.Drawing.Point(95, 12);
            this.nudSnmpPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudSnmpPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSnmpPort.Name = "nudSnmpPort";
            this.nudSnmpPort.Size = new System.Drawing.Size(71, 20);
            this.nudSnmpPort.TabIndex = 5;
            this.nudSnmpPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSnmpPort
            // 
            this.lblSnmpPort.AutoSize = true;
            this.lblSnmpPort.Location = new System.Drawing.Point(24, 16);
            this.lblSnmpPort.Name = "lblSnmpPort";
            this.lblSnmpPort.Size = new System.Drawing.Size(63, 13);
            this.lblSnmpPort.TabIndex = 6;
            this.lblSnmpPort.Text = "SNMP Port:";
            // 
            // tbxReadCommString
            // 
            this.tbxReadCommString.Location = new System.Drawing.Point(139, 19);
            this.tbxReadCommString.Name = "tbxReadCommString";
            this.tbxReadCommString.Size = new System.Drawing.Size(222, 20);
            this.tbxReadCommString.TabIndex = 7;
            // 
            // tbxReadUsername
            // 
            this.tbxReadUsername.Location = new System.Drawing.Point(139, 22);
            this.tbxReadUsername.Name = "tbxReadUsername";
            this.tbxReadUsername.Size = new System.Drawing.Size(222, 20);
            this.tbxReadUsername.TabIndex = 8;
            // 
            // lblReadCommString
            // 
            this.lblReadCommString.AutoSize = true;
            this.lblReadCommString.Location = new System.Drawing.Point(13, 22);
            this.lblReadCommString.Name = "lblReadCommString";
            this.lblReadCommString.Size = new System.Drawing.Size(120, 13);
            this.lblReadCommString.TabIndex = 16;
            this.lblReadCommString.Text = "Read Community String:";
            // 
            // lblReadUsername
            // 
            this.lblReadUsername.AutoSize = true;
            this.lblReadUsername.Location = new System.Drawing.Point(46, 25);
            this.lblReadUsername.Name = "lblReadUsername";
            this.lblReadUsername.Size = new System.Drawing.Size(87, 13);
            this.lblReadUsername.TabIndex = 17;
            this.lblReadUsername.Text = "Read Username:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(303, 276);
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
            this.btnCancel.Location = new System.Drawing.Point(222, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbxSnmpVersion
            // 
            this.cbxSnmpVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSnmpVersion.FormattingEnabled = true;
            this.cbxSnmpVersion.Items.AddRange(new object[] {
            "None",
            "SNMPv2c",
            "SNMPv3"});
            this.cbxSnmpVersion.Location = new System.Drawing.Point(257, 12);
            this.cbxSnmpVersion.Name = "cbxSnmpVersion";
            this.cbxSnmpVersion.Size = new System.Drawing.Size(115, 21);
            this.cbxSnmpVersion.TabIndex = 35;
            this.cbxSnmpVersion.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSnmpVersion_SelectedIndexChanged);
            // 
            // lblSnmpVersion
            // 
            this.lblSnmpVersion.AutoSize = true;
            this.lblSnmpVersion.Location = new System.Drawing.Point(172, 16);
            this.lblSnmpVersion.Name = "lblSnmpVersion";
            this.lblSnmpVersion.Size = new System.Drawing.Size(79, 13);
            this.lblSnmpVersion.TabIndex = 36;
            this.lblSnmpVersion.Text = "SNMP Version:";
            // 
            // gbxSnmpV2C
            // 
            this.gbxSnmpV2C.Controls.Add(this.tbxReadCommString);
            this.gbxSnmpV2C.Controls.Add(this.lblReadCommString);
            this.gbxSnmpV2C.Enabled = false;
            this.gbxSnmpV2C.Location = new System.Drawing.Point(11, 46);
            this.gbxSnmpV2C.Name = "gbxSnmpV2C";
            this.gbxSnmpV2C.Size = new System.Drawing.Size(367, 53);
            this.gbxSnmpV2C.TabIndex = 37;
            this.gbxSnmpV2C.TabStop = false;
            this.gbxSnmpV2C.Text = "SNMP v2c";
            // 
            // gbxSnmpV3
            // 
            this.gbxSnmpV3.Controls.Add(this.lblAuthProtocol);
            this.gbxSnmpV3.Controls.Add(this.lblPrivacyProtocol);
            this.gbxSnmpV3.Controls.Add(this.cbxAuthProtocol);
            this.gbxSnmpV3.Controls.Add(this.cbxPrivacyProtocol);
            this.gbxSnmpV3.Controls.Add(this.lblReadPrivacyPassword);
            this.gbxSnmpV3.Controls.Add(this.tbxReadPrivacyPassword);
            this.gbxSnmpV3.Controls.Add(this.tbxReadAuthPassword);
            this.gbxSnmpV3.Controls.Add(this.lblReadAuthPassword);
            this.gbxSnmpV3.Controls.Add(this.tbxReadUsername);
            this.gbxSnmpV3.Controls.Add(this.lblReadUsername);
            this.gbxSnmpV3.Enabled = false;
            this.gbxSnmpV3.Location = new System.Drawing.Point(11, 105);
            this.gbxSnmpV3.Name = "gbxSnmpV3";
            this.gbxSnmpV3.Size = new System.Drawing.Size(367, 165);
            this.gbxSnmpV3.TabIndex = 38;
            this.gbxSnmpV3.TabStop = false;
            this.gbxSnmpV3.Text = "SNMP v3";
            // 
            // lblAuthProtocol
            // 
            this.lblAuthProtocol.AutoSize = true;
            this.lblAuthProtocol.Location = new System.Drawing.Point(59, 51);
            this.lblAuthProtocol.Name = "lblAuthProtocol";
            this.lblAuthProtocol.Size = new System.Drawing.Size(74, 13);
            this.lblAuthProtocol.TabIndex = 25;
            this.lblAuthProtocol.Text = "Auth Protocol:";
            // 
            // lblPrivacyProtocol
            // 
            this.lblPrivacyProtocol.AutoSize = true;
            this.lblPrivacyProtocol.Location = new System.Drawing.Point(46, 104);
            this.lblPrivacyProtocol.Name = "lblPrivacyProtocol";
            this.lblPrivacyProtocol.Size = new System.Drawing.Size(87, 13);
            this.lblPrivacyProtocol.TabIndex = 24;
            this.lblPrivacyProtocol.Text = "Privacy Protocol:";
            // 
            // cbxAuthProtocol
            // 
            this.cbxAuthProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAuthProtocol.FormattingEnabled = true;
            this.cbxAuthProtocol.Items.AddRange(new object[] {
            "MD5",
            "None",
            "SHA"});
            this.cbxAuthProtocol.Location = new System.Drawing.Point(139, 48);
            this.cbxAuthProtocol.Name = "cbxAuthProtocol";
            this.cbxAuthProtocol.Size = new System.Drawing.Size(222, 21);
            this.cbxAuthProtocol.TabIndex = 23;
            // 
            // cbxPrivacyProtocol
            // 
            this.cbxPrivacyProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPrivacyProtocol.FormattingEnabled = true;
            this.cbxPrivacyProtocol.Items.AddRange(new object[] {
            "AES",
            "DES",
            "None"});
            this.cbxPrivacyProtocol.Location = new System.Drawing.Point(139, 101);
            this.cbxPrivacyProtocol.Name = "cbxPrivacyProtocol";
            this.cbxPrivacyProtocol.Size = new System.Drawing.Size(222, 21);
            this.cbxPrivacyProtocol.TabIndex = 22;
            // 
            // lblReadPrivacyPassword
            // 
            this.lblReadPrivacyPassword.AutoSize = true;
            this.lblReadPrivacyPassword.Location = new System.Drawing.Point(10, 131);
            this.lblReadPrivacyPassword.Name = "lblReadPrivacyPassword";
            this.lblReadPrivacyPassword.Size = new System.Drawing.Size(123, 13);
            this.lblReadPrivacyPassword.TabIndex = 21;
            this.lblReadPrivacyPassword.Text = "Read Privacy Password:";
            // 
            // tbxReadPrivacyPassword
            // 
            this.tbxReadPrivacyPassword.Location = new System.Drawing.Point(139, 128);
            this.tbxReadPrivacyPassword.Name = "tbxReadPrivacyPassword";
            this.tbxReadPrivacyPassword.Size = new System.Drawing.Size(222, 20);
            this.tbxReadPrivacyPassword.TabIndex = 20;
            // 
            // tbxReadAuthPassword
            // 
            this.tbxReadAuthPassword.Location = new System.Drawing.Point(139, 75);
            this.tbxReadAuthPassword.Name = "tbxReadAuthPassword";
            this.tbxReadAuthPassword.Size = new System.Drawing.Size(222, 20);
            this.tbxReadAuthPassword.TabIndex = 18;
            // 
            // lblReadAuthPassword
            // 
            this.lblReadAuthPassword.AutoSize = true;
            this.lblReadAuthPassword.Location = new System.Drawing.Point(23, 78);
            this.lblReadAuthPassword.Name = "lblReadAuthPassword";
            this.lblReadAuthPassword.Size = new System.Drawing.Size(110, 13);
            this.lblReadAuthPassword.TabIndex = 19;
            this.lblReadAuthPassword.Text = "Read Auth Password:";
            // 
            // SnmpConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 311);
            this.Controls.Add(this.gbxSnmpV3);
            this.Controls.Add(this.gbxSnmpV2C);
            this.Controls.Add(this.lblSnmpVersion);
            this.Controls.Add(this.cbxSnmpVersion);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.nudSnmpPort);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSnmpPort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SnmpConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SNMP Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.nudSnmpPort)).EndInit();
            this.gbxSnmpV2C.ResumeLayout(false);
            this.gbxSnmpV2C.PerformLayout();
            this.gbxSnmpV3.ResumeLayout(false);
            this.gbxSnmpV3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudSnmpPort;
        private System.Windows.Forms.Label lblSnmpPort;
        private System.Windows.Forms.TextBox tbxReadCommString;
        private System.Windows.Forms.TextBox tbxReadUsername;
        private System.Windows.Forms.Label lblReadCommString;
        private System.Windows.Forms.Label lblReadUsername;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbxSnmpVersion;
        private System.Windows.Forms.Label lblSnmpVersion;
        private System.Windows.Forms.GroupBox gbxSnmpV2C;
        private System.Windows.Forms.GroupBox gbxSnmpV3;
        private System.Windows.Forms.Label lblAuthProtocol;
        private System.Windows.Forms.Label lblPrivacyProtocol;
        private System.Windows.Forms.ComboBox cbxAuthProtocol;
        private System.Windows.Forms.ComboBox cbxPrivacyProtocol;
        private System.Windows.Forms.Label lblReadPrivacyPassword;
        private System.Windows.Forms.TextBox tbxReadPrivacyPassword;
        private System.Windows.Forms.TextBox tbxReadAuthPassword;
        private System.Windows.Forms.Label lblReadAuthPassword;
    }
}