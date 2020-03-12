namespace ExampleClient.Source.Misc
{
    partial class LdapConfigurationForm
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
            this.cbxEnable = new System.Windows.Forms.CheckBox();
            this.cbxServerTls = new System.Windows.Forms.CheckBox();
            this.cbxSso = new System.Windows.Forms.CheckBox();
            this.cbxTwoStageBinding = new System.Windows.Forms.CheckBox();
            this.cbxLdapUserAndRoleManagement = new System.Windows.Forms.CheckBox();
            this.nudServerPort = new System.Windows.Forms.NumericUpDown();
            this.lblServerPort = new System.Windows.Forms.Label();
            this.tbxBaseDn = new System.Windows.Forms.TextBox();
            this.tbxObjectClasses = new System.Windows.Forms.TextBox();
            this.tbxSearchAttributes = new System.Windows.Forms.TextBox();
            this.tbxSearchDnAccount = new System.Windows.Forms.TextBox();
            this.tbxServerHostName = new System.Windows.Forms.TextBox();
            this.tbsSsoDomain = new System.Windows.Forms.TextBox();
            this.tbxVxRootDn = new System.Windows.Forms.TextBox();
            this.tbxVxSystemDn = new System.Windows.Forms.TextBox();
            this.tbxSearchDnPassword = new System.Windows.Forms.TextBox();
            this.lblBaseDn = new System.Windows.Forms.Label();
            this.lblObjectClasses = new System.Windows.Forms.Label();
            this.lblSearchAttributes = new System.Windows.Forms.Label();
            this.lblSearchDnAccount = new System.Windows.Forms.Label();
            this.lblServerHostName = new System.Windows.Forms.Label();
            this.lblSsoDomain = new System.Windows.Forms.Label();
            this.lblVxRootDn = new System.Windows.Forms.Label();
            this.lblVxSystemDn = new System.Windows.Forms.Label();
            this.lblSearchDnPassword = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.gbxSettings = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudServerPort)).BeginInit();
            this.gbxSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxEnable
            // 
            this.cbxEnable.AutoSize = true;
            this.cbxEnable.Location = new System.Drawing.Point(12, 8);
            this.cbxEnable.Name = "cbxEnable";
            this.cbxEnable.Size = new System.Drawing.Size(90, 17);
            this.cbxEnable.TabIndex = 0;
            this.cbxEnable.Text = "Enable LDAP";
            this.cbxEnable.UseVisualStyleBackColor = true;
            this.cbxEnable.CheckedChanged += new System.EventHandler(this.CheckBoxEnable_CheckedChanged);
            // 
            // cbxServerTls
            // 
            this.cbxServerTls.AutoSize = true;
            this.cbxServerTls.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxServerTls.Location = new System.Drawing.Point(29, 48);
            this.cbxServerTls.Name = "cbxServerTls";
            this.cbxServerTls.Size = new System.Drawing.Size(116, 17);
            this.cbxServerTls.TabIndex = 1;
            this.cbxServerTls.Text = "Enable Server TLS";
            this.cbxServerTls.UseVisualStyleBackColor = true;
            // 
            // cbxSso
            // 
            this.cbxSso.AutoSize = true;
            this.cbxSso.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxSso.Location = new System.Drawing.Point(13, 69);
            this.cbxSso.Name = "cbxSso";
            this.cbxSso.Size = new System.Drawing.Size(132, 17);
            this.cbxSso.TabIndex = 2;
            this.cbxSso.Text = "Enable Single Sign-On";
            this.cbxSso.UseVisualStyleBackColor = true;
            // 
            // cbxTwoStageBinding
            // 
            this.cbxTwoStageBinding.AutoSize = true;
            this.cbxTwoStageBinding.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxTwoStageBinding.Location = new System.Drawing.Point(179, 46);
            this.cbxTwoStageBinding.Name = "cbxTwoStageBinding";
            this.cbxTwoStageBinding.Size = new System.Drawing.Size(152, 17);
            this.cbxTwoStageBinding.TabIndex = 3;
            this.cbxTwoStageBinding.Text = "Enable Two Stage Binding";
            this.cbxTwoStageBinding.UseVisualStyleBackColor = true;
            // 
            // cbxLdapUserAndRoleManagement
            // 
            this.cbxLdapUserAndRoleManagement.AutoSize = true;
            this.cbxLdapUserAndRoleManagement.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxLdapUserAndRoleManagement.Location = new System.Drawing.Point(151, 69);
            this.cbxLdapUserAndRoleManagement.Name = "cbxLdapUserAndRoleManagement";
            this.cbxLdapUserAndRoleManagement.Size = new System.Drawing.Size(180, 17);
            this.cbxLdapUserAndRoleManagement.TabIndex = 4;
            this.cbxLdapUserAndRoleManagement.Text = "Enable LDAP User Management";
            this.cbxLdapUserAndRoleManagement.UseVisualStyleBackColor = true;
            // 
            // nudServerPort
            // 
            this.nudServerPort.Location = new System.Drawing.Point(260, 19);
            this.nudServerPort.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudServerPort.Name = "nudServerPort";
            this.nudServerPort.Size = new System.Drawing.Size(71, 20);
            this.nudServerPort.TabIndex = 5;
            // 
            // lblServerPort
            // 
            this.lblServerPort.AutoSize = true;
            this.lblServerPort.Location = new System.Drawing.Point(225, 21);
            this.lblServerPort.Name = "lblServerPort";
            this.lblServerPort.Size = new System.Drawing.Size(29, 13);
            this.lblServerPort.TabIndex = 6;
            this.lblServerPort.Text = "Port:";
            // 
            // tbxBaseDn
            // 
            this.tbxBaseDn.Location = new System.Drawing.Point(139, 92);
            this.tbxBaseDn.Name = "tbxBaseDn";
            this.tbxBaseDn.Size = new System.Drawing.Size(192, 20);
            this.tbxBaseDn.TabIndex = 7;
            // 
            // tbxObjectClasses
            // 
            this.tbxObjectClasses.Location = new System.Drawing.Point(139, 118);
            this.tbxObjectClasses.Name = "tbxObjectClasses";
            this.tbxObjectClasses.Size = new System.Drawing.Size(192, 20);
            this.tbxObjectClasses.TabIndex = 8;
            // 
            // tbxSearchAttributes
            // 
            this.tbxSearchAttributes.Location = new System.Drawing.Point(139, 144);
            this.tbxSearchAttributes.Name = "tbxSearchAttributes";
            this.tbxSearchAttributes.Size = new System.Drawing.Size(192, 20);
            this.tbxSearchAttributes.TabIndex = 9;
            // 
            // tbxSearchDnAccount
            // 
            this.tbxSearchDnAccount.Location = new System.Drawing.Point(139, 170);
            this.tbxSearchDnAccount.Name = "tbxSearchDnAccount";
            this.tbxSearchDnAccount.Size = new System.Drawing.Size(192, 20);
            this.tbxSearchDnAccount.TabIndex = 10;
            // 
            // tbxServerHostName
            // 
            this.tbxServerHostName.Location = new System.Drawing.Point(87, 18);
            this.tbxServerHostName.Name = "tbxServerHostName";
            this.tbxServerHostName.Size = new System.Drawing.Size(123, 20);
            this.tbxServerHostName.TabIndex = 11;
            // 
            // tbsSsoDomain
            // 
            this.tbsSsoDomain.Location = new System.Drawing.Point(139, 274);
            this.tbsSsoDomain.Name = "tbsSsoDomain";
            this.tbsSsoDomain.Size = new System.Drawing.Size(192, 20);
            this.tbsSsoDomain.TabIndex = 12;
            // 
            // tbxVxRootDn
            // 
            this.tbxVxRootDn.Location = new System.Drawing.Point(139, 222);
            this.tbxVxRootDn.Name = "tbxVxRootDn";
            this.tbxVxRootDn.Size = new System.Drawing.Size(192, 20);
            this.tbxVxRootDn.TabIndex = 13;
            // 
            // tbxVxSystemDn
            // 
            this.tbxVxSystemDn.Location = new System.Drawing.Point(139, 248);
            this.tbxVxSystemDn.Name = "tbxVxSystemDn";
            this.tbxVxSystemDn.Size = new System.Drawing.Size(192, 20);
            this.tbxVxSystemDn.TabIndex = 14;
            // 
            // tbxSearchDnPassword
            // 
            this.tbxSearchDnPassword.Location = new System.Drawing.Point(139, 196);
            this.tbxSearchDnPassword.Name = "tbxSearchDnPassword";
            this.tbxSearchDnPassword.Size = new System.Drawing.Size(192, 20);
            this.tbxSearchDnPassword.TabIndex = 15;
            // 
            // lblBaseDn
            // 
            this.lblBaseDn.AutoSize = true;
            this.lblBaseDn.Location = new System.Drawing.Point(80, 96);
            this.lblBaseDn.Name = "lblBaseDn";
            this.lblBaseDn.Size = new System.Drawing.Size(53, 13);
            this.lblBaseDn.TabIndex = 16;
            this.lblBaseDn.Text = "Base DN:";
            // 
            // lblObjectClasses
            // 
            this.lblObjectClasses.AutoSize = true;
            this.lblObjectClasses.Location = new System.Drawing.Point(53, 122);
            this.lblObjectClasses.Name = "lblObjectClasses";
            this.lblObjectClasses.Size = new System.Drawing.Size(80, 13);
            this.lblObjectClasses.TabIndex = 17;
            this.lblObjectClasses.Text = "Object Classes:";
            // 
            // lblSearchAttributes
            // 
            this.lblSearchAttributes.AutoSize = true;
            this.lblSearchAttributes.Location = new System.Drawing.Point(42, 148);
            this.lblSearchAttributes.Name = "lblSearchAttributes";
            this.lblSearchAttributes.Size = new System.Drawing.Size(91, 13);
            this.lblSearchAttributes.TabIndex = 18;
            this.lblSearchAttributes.Text = "Search Attributes:";
            // 
            // lblSearchDnAccount
            // 
            this.lblSearchDnAccount.AutoSize = true;
            this.lblSearchDnAccount.Location = new System.Drawing.Point(27, 174);
            this.lblSearchDnAccount.Name = "lblSearchDnAccount";
            this.lblSearchDnAccount.Size = new System.Drawing.Size(106, 13);
            this.lblSearchDnAccount.TabIndex = 19;
            this.lblSearchDnAccount.Text = "Search DN Account:";
            // 
            // lblServerHostName
            // 
            this.lblServerHostName.AutoSize = true;
            this.lblServerHostName.Location = new System.Drawing.Point(18, 21);
            this.lblServerHostName.Name = "lblServerHostName";
            this.lblServerHostName.Size = new System.Drawing.Size(63, 13);
            this.lblServerHostName.TabIndex = 20;
            this.lblServerHostName.Text = "Host Name:";
            // 
            // lblSsoDomain
            // 
            this.lblSsoDomain.AutoSize = true;
            this.lblSsoDomain.Location = new System.Drawing.Point(14, 278);
            this.lblSsoDomain.Name = "lblSsoDomain";
            this.lblSsoDomain.Size = new System.Drawing.Size(119, 13);
            this.lblSsoDomain.TabIndex = 21;
            this.lblSsoDomain.Text = "Single Sign-On Domain:";
            // 
            // lblVxRootDn
            // 
            this.lblVxRootDn.AutoSize = true;
            this.lblVxRootDn.Location = new System.Drawing.Point(64, 226);
            this.lblVxRootDn.Name = "lblVxRootDn";
            this.lblVxRootDn.Size = new System.Drawing.Size(69, 13);
            this.lblVxRootDn.TabIndex = 22;
            this.lblVxRootDn.Text = "VX Root DN:";
            // 
            // lblVxSystemDn
            // 
            this.lblVxSystemDn.AutoSize = true;
            this.lblVxSystemDn.Location = new System.Drawing.Point(53, 252);
            this.lblVxSystemDn.Name = "lblVxSystemDn";
            this.lblVxSystemDn.Size = new System.Drawing.Size(80, 13);
            this.lblVxSystemDn.TabIndex = 23;
            this.lblVxSystemDn.Text = "VX System DN:";
            // 
            // lblSearchDnPassword
            // 
            this.lblSearchDnPassword.AutoSize = true;
            this.lblSearchDnPassword.Location = new System.Drawing.Point(21, 200);
            this.lblSearchDnPassword.Name = "lblSearchDnPassword";
            this.lblSearchDnPassword.Size = new System.Drawing.Size(112, 13);
            this.lblSearchDnPassword.TabIndex = 24;
            this.lblSearchDnPassword.Text = "Search DN Password:";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(274, 343);
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
            this.btnCancel.Location = new System.Drawing.Point(193, 343);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(12, 343);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 27;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.ButtonValidate_Click);
            // 
            // gbxSettings
            // 
            this.gbxSettings.Controls.Add(this.tbxServerHostName);
            this.gbxSettings.Controls.Add(this.tbxVxSystemDn);
            this.gbxSettings.Controls.Add(this.lblServerHostName);
            this.gbxSettings.Controls.Add(this.tbxBaseDn);
            this.gbxSettings.Controls.Add(this.nudServerPort);
            this.gbxSettings.Controls.Add(this.tbxObjectClasses);
            this.gbxSettings.Controls.Add(this.lblServerPort);
            this.gbxSettings.Controls.Add(this.tbxSearchAttributes);
            this.gbxSettings.Controls.Add(this.cbxServerTls);
            this.gbxSettings.Controls.Add(this.tbxSearchDnAccount);
            this.gbxSettings.Controls.Add(this.cbxTwoStageBinding);
            this.gbxSettings.Controls.Add(this.lblSsoDomain);
            this.gbxSettings.Controls.Add(this.cbxLdapUserAndRoleManagement);
            this.gbxSettings.Controls.Add(this.cbxSso);
            this.gbxSettings.Controls.Add(this.lblSearchDnPassword);
            this.gbxSettings.Controls.Add(this.tbsSsoDomain);
            this.gbxSettings.Controls.Add(this.tbxVxRootDn);
            this.gbxSettings.Controls.Add(this.lblVxSystemDn);
            this.gbxSettings.Controls.Add(this.tbxSearchDnPassword);
            this.gbxSettings.Controls.Add(this.lblVxRootDn);
            this.gbxSettings.Controls.Add(this.lblBaseDn);
            this.gbxSettings.Controls.Add(this.lblObjectClasses);
            this.gbxSettings.Controls.Add(this.lblSearchDnAccount);
            this.gbxSettings.Controls.Add(this.lblSearchAttributes);
            this.gbxSettings.Location = new System.Drawing.Point(12, 31);
            this.gbxSettings.Name = "gbxSettings";
            this.gbxSettings.Size = new System.Drawing.Size(337, 306);
            this.gbxSettings.TabIndex = 29;
            this.gbxSettings.TabStop = false;
            this.gbxSettings.Text = "Settings";
            // 
            // LdapConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 372);
            this.Controls.Add(this.gbxSettings);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxEnable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LdapConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LDAP Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.nudServerPort)).EndInit();
            this.gbxSettings.ResumeLayout(false);
            this.gbxSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxEnable;
        private System.Windows.Forms.CheckBox cbxServerTls;
        private System.Windows.Forms.CheckBox cbxSso;
        private System.Windows.Forms.CheckBox cbxTwoStageBinding;
        private System.Windows.Forms.CheckBox cbxLdapUserAndRoleManagement;
        private System.Windows.Forms.NumericUpDown nudServerPort;
        private System.Windows.Forms.Label lblServerPort;
        private System.Windows.Forms.TextBox tbxBaseDn;
        private System.Windows.Forms.TextBox tbxObjectClasses;
        private System.Windows.Forms.TextBox tbxSearchAttributes;
        private System.Windows.Forms.TextBox tbxSearchDnAccount;
        private System.Windows.Forms.TextBox tbxServerHostName;
        private System.Windows.Forms.TextBox tbsSsoDomain;
        private System.Windows.Forms.TextBox tbxVxRootDn;
        private System.Windows.Forms.TextBox tbxVxSystemDn;
        private System.Windows.Forms.TextBox tbxSearchDnPassword;
        private System.Windows.Forms.Label lblBaseDn;
        private System.Windows.Forms.Label lblObjectClasses;
        private System.Windows.Forms.Label lblSearchAttributes;
        private System.Windows.Forms.Label lblSearchDnAccount;
        private System.Windows.Forms.Label lblServerHostName;
        private System.Windows.Forms.Label lblSsoDomain;
        private System.Windows.Forms.Label lblVxRootDn;
        private System.Windows.Forms.Label lblVxSystemDn;
        private System.Windows.Forms.Label lblSearchDnPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.GroupBox gbxSettings;
    }
}