namespace ExampleClient.Source
{
    partial class UserAccountForm
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
            this.ckbxAccountEnabled = new System.Windows.Forms.CheckBox();
            this.gbxAccountSettings = new System.Windows.Forms.GroupBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblAccountEnabled = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ckbxAllowLdapBypass = new System.Windows.Forms.CheckBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.ckbxPasswordExpirationDisabled = new System.Windows.Forms.CheckBox();
            this.gbxAccountSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckbxAccountEnabled
            // 
            this.ckbxAccountEnabled.AutoSize = true;
            this.ckbxAccountEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbxAccountEnabled.Location = new System.Drawing.Point(193, 19);
            this.ckbxAccountEnabled.Name = "ckbxAccountEnabled";
            this.ckbxAccountEnabled.Size = new System.Drawing.Size(15, 14);
            this.ckbxAccountEnabled.TabIndex = 0;
            this.ckbxAccountEnabled.UseVisualStyleBackColor = true;
            // 
            // gbxAccountSettings
            // 
            this.gbxAccountSettings.Controls.Add(this.ckbxPasswordExpirationDisabled);
            this.gbxAccountSettings.Controls.Add(this.lblUsername);
            this.gbxAccountSettings.Controls.Add(this.lblAccountEnabled);
            this.gbxAccountSettings.Controls.Add(this.lblFirstName);
            this.gbxAccountSettings.Controls.Add(this.ckbxAccountEnabled);
            this.gbxAccountSettings.Controls.Add(this.ckbxAllowLdapBypass);
            this.gbxAccountSettings.Location = new System.Drawing.Point(12, 12);
            this.gbxAccountSettings.Name = "gbxAccountSettings";
            this.gbxAccountSettings.Size = new System.Drawing.Size(214, 109);
            this.gbxAccountSettings.TabIndex = 7;
            this.gbxAccountSettings.TabStop = false;
            this.gbxAccountSettings.Text = "Account Settings";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(84, 43);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(103, 13);
            this.lblUsername.TabIndex = 22;
            this.lblUsername.Text = "Allow LDAP Bypass:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAccountEnabled
            // 
            this.lblAccountEnabled.AutoSize = true;
            this.lblAccountEnabled.Location = new System.Drawing.Point(95, 17);
            this.lblAccountEnabled.Name = "lblAccountEnabled";
            this.lblAccountEnabled.Size = new System.Drawing.Size(92, 13);
            this.lblAccountEnabled.TabIndex = 16;
            this.lblAccountEnabled.Text = "Account Enabled:";
            this.lblAccountEnabled.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(70, 127);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(151, 127);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ckbxAllowLdapBypass
            // 
            this.ckbxAllowLdapBypass.AutoSize = true;
            this.ckbxAllowLdapBypass.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbxAllowLdapBypass.Location = new System.Drawing.Point(193, 43);
            this.ckbxAllowLdapBypass.Name = "ckbxAllowLdapBypass";
            this.ckbxAllowLdapBypass.Size = new System.Drawing.Size(15, 14);
            this.ckbxAllowLdapBypass.TabIndex = 4;
            this.ckbxAllowLdapBypass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbxAllowLdapBypass.UseVisualStyleBackColor = true;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(38, 70);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(149, 13);
            this.lblFirstName.TabIndex = 13;
            this.lblFirstName.Text = "Password Expiration Disabled:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ckbxPasswordExpirationDisabled
            // 
            this.ckbxPasswordExpirationDisabled.AutoSize = true;
            this.ckbxPasswordExpirationDisabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbxPasswordExpirationDisabled.Location = new System.Drawing.Point(193, 69);
            this.ckbxPasswordExpirationDisabled.Name = "ckbxPasswordExpirationDisabled";
            this.ckbxPasswordExpirationDisabled.Size = new System.Drawing.Size(15, 14);
            this.ckbxPasswordExpirationDisabled.TabIndex = 23;
            this.ckbxPasswordExpirationDisabled.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbxPasswordExpirationDisabled.UseVisualStyleBackColor = true;
            // 
            // UserAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 161);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxAccountSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Account";
            this.gbxAccountSettings.ResumeLayout(false);
            this.gbxAccountSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbxAccountEnabled;
        private System.Windows.Forms.GroupBox gbxAccountSettings;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAccountEnabled;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.CheckBox ckbxPasswordExpirationDisabled;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.CheckBox ckbxAllowLdapBypass;
    }
}