﻿namespace ExampleClient.Source
{
    partial class UserManagerForm
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.lvUsers = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDomain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPasswordExpiration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPhoneNumbers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUserAccount = new System.Windows.Forms.Button();
            this.btnConfiguration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(833, 157);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 23);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(833, 70);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(80, 23);
            this.btnModify.TabIndex = 11;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.ButtonModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(833, 41);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(833, 12);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(80, 23);
            this.btnNewUser.TabIndex = 9;
            this.btnNewUser.Text = "New User";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.ButtonNewUser_Click);
            // 
            // lvUsers
            // 
            this.lvUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chId,
            this.chDomain,
            this.chState,
            this.chPasswordExpiration,
            this.chPhoneNumbers});
            this.lvUsers.FullRowSelect = true;
            this.lvUsers.HideSelection = false;
            this.lvUsers.Location = new System.Drawing.Point(12, 12);
            this.lvUsers.MultiSelect = false;
            this.lvUsers.Name = "lvUsers";
            this.lvUsers.Size = new System.Drawing.Size(815, 168);
            this.lvUsers.TabIndex = 8;
            this.lvUsers.UseCompatibleStateImageBehavior = false;
            this.lvUsers.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 168;
            // 
            // chId
            // 
            this.chId.Text = "ID";
            this.chId.Width = 274;
            // 
            // chDomain
            // 
            this.chDomain.Text = "Domain";
            this.chDomain.Width = 94;
            // 
            // chState
            // 
            this.chState.Text = "State";
            // 
            // chPasswordExpiration
            // 
            this.chPasswordExpiration.Text = "Password Expiration";
            this.chPasswordExpiration.Width = 137;
            // 
            // chPhoneNumbers
            // 
            this.chPhoneNumbers.Text = "Phone Nums";
            this.chPhoneNumbers.Width = 77;
            // 
            // btnUserAccount
            // 
            this.btnUserAccount.Location = new System.Drawing.Point(833, 99);
            this.btnUserAccount.Name = "btnUserAccount";
            this.btnUserAccount.Size = new System.Drawing.Size(80, 23);
            this.btnUserAccount.TabIndex = 13;
            this.btnUserAccount.Text = "User Account";
            this.btnUserAccount.UseVisualStyleBackColor = true;
            this.btnUserAccount.Click += new System.EventHandler(this.ButtonUserAccount_Click);
            // 
            // btnConfiguration
            // 
            this.btnConfiguration.Location = new System.Drawing.Point(833, 128);
            this.btnConfiguration.Name = "btnConfiguration";
            this.btnConfiguration.Size = new System.Drawing.Size(80, 23);
            this.btnConfiguration.TabIndex = 14;
            this.btnConfiguration.Text = "Configuration";
            this.btnConfiguration.UseVisualStyleBackColor = true;
            this.btnConfiguration.Click += new System.EventHandler(this.ButtonConfiguration_Click);
            // 
            // UserManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 187);
            this.Controls.Add(this.btnConfiguration);
            this.Controls.Add(this.btnUserAccount);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.lvUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.ListView lvUsers;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chDomain;
        private System.Windows.Forms.ColumnHeader chState;
        private System.Windows.Forms.ColumnHeader chPasswordExpiration;
        private System.Windows.Forms.ColumnHeader chPhoneNumbers;
        private System.Windows.Forms.Button btnUserAccount;
        private System.Windows.Forms.Button btnConfiguration;
    }
}