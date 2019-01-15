namespace ExampleClient.Source
{
    partial class ModifyUserForm
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
            this.gbxRoleAssociations = new System.Windows.Forms.GroupBox();
            this.lvUserRoles = new System.Windows.Forms.ListView();
            this.chCheckBox = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDeviceName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.tbxNewPassword = new System.Windows.Forms.TextBox();
            this.gbxAccountSettings = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbxPhoneNumbers = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lvPhoneNumbers = new System.Windows.Forms.ListView();
            this.chNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxEmployeeId = new System.Windows.Forms.TextBox();
            this.tbxEmailAddress = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.ckbxChangePassword = new System.Windows.Forms.CheckBox();
            this.lblChangePassword = new System.Windows.Forms.Label();
            this.lblAccountEnabled = new System.Windows.Forms.Label();
            this.tbxNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblDomain = new System.Windows.Forms.Label();
            this.tbxDomain = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.gbxRoleAssociations.SuspendLayout();
            this.gbxAccountSettings.SuspendLayout();
            this.gbxPhoneNumbers.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckbxAccountEnabled
            // 
            this.ckbxAccountEnabled.AutoSize = true;
            this.ckbxAccountEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbxAccountEnabled.Location = new System.Drawing.Point(131, 27);
            this.ckbxAccountEnabled.Name = "ckbxAccountEnabled";
            this.ckbxAccountEnabled.Size = new System.Drawing.Size(15, 14);
            this.ckbxAccountEnabled.TabIndex = 0;
            this.ckbxAccountEnabled.UseVisualStyleBackColor = true;
            // 
            // gbxRoleAssociations
            // 
            this.gbxRoleAssociations.Controls.Add(this.lvUserRoles);
            this.gbxRoleAssociations.Location = new System.Drawing.Point(14, 283);
            this.gbxRoleAssociations.Name = "gbxRoleAssociations";
            this.gbxRoleAssociations.Size = new System.Drawing.Size(308, 281);
            this.gbxRoleAssociations.TabIndex = 3;
            this.gbxRoleAssociations.TabStop = false;
            this.gbxRoleAssociations.Text = "Role Associations";
            // 
            // lvUserRoles
            // 
            this.lvUserRoles.CheckBoxes = true;
            this.lvUserRoles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCheckBox,
            this.chDeviceName});
            this.lvUserRoles.Location = new System.Drawing.Point(6, 19);
            this.lvUserRoles.Name = "lvUserRoles";
            this.lvUserRoles.Size = new System.Drawing.Size(296, 256);
            this.lvUserRoles.TabIndex = 3;
            this.lvUserRoles.UseCompatibleStateImageBehavior = false;
            this.lvUserRoles.View = System.Windows.Forms.View.Details;
            // 
            // chCheckBox
            // 
            this.chCheckBox.Text = "";
            this.chCheckBox.Width = 25;
            // 
            // chDeviceName
            // 
            this.chDeviceName.Text = "Name";
            this.chDeviceName.Width = 267;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(44, 231);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(84, 13);
            this.lblNewPassword.TabIndex = 5;
            this.lblNewPassword.Text = "New Password: ";
            this.lblNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxNewPassword
            // 
            this.tbxNewPassword.Location = new System.Drawing.Point(131, 228);
            this.tbxNewPassword.Name = "tbxNewPassword";
            this.tbxNewPassword.Size = new System.Drawing.Size(163, 20);
            this.tbxNewPassword.TabIndex = 6;
            // 
            // gbxAccountSettings
            // 
            this.gbxAccountSettings.Controls.Add(this.lblUsername);
            this.gbxAccountSettings.Controls.Add(this.tbxName);
            this.gbxAccountSettings.Controls.Add(this.lblDomain);
            this.gbxAccountSettings.Controls.Add(this.tbxDomain);
            this.gbxAccountSettings.Controls.Add(this.lblNotes);
            this.gbxAccountSettings.Controls.Add(this.tbxNotes);
            this.gbxAccountSettings.Controls.Add(this.lblAccountEnabled);
            this.gbxAccountSettings.Controls.Add(this.lblChangePassword);
            this.gbxAccountSettings.Controls.Add(this.lblLastName);
            this.gbxAccountSettings.Controls.Add(this.lblFirstName);
            this.gbxAccountSettings.Controls.Add(this.lblEmailAddress);
            this.gbxAccountSettings.Controls.Add(this.lblEmployeeId);
            this.gbxAccountSettings.Controls.Add(this.tbxLastName);
            this.gbxAccountSettings.Controls.Add(this.tbxFirstName);
            this.gbxAccountSettings.Controls.Add(this.tbxEmailAddress);
            this.gbxAccountSettings.Controls.Add(this.tbxEmployeeId);
            this.gbxAccountSettings.Controls.Add(this.ckbxAccountEnabled);
            this.gbxAccountSettings.Controls.Add(this.tbxNewPassword);
            this.gbxAccountSettings.Controls.Add(this.lblNewPassword);
            this.gbxAccountSettings.Controls.Add(this.ckbxChangePassword);
            this.gbxAccountSettings.Location = new System.Drawing.Point(12, 12);
            this.gbxAccountSettings.Name = "gbxAccountSettings";
            this.gbxAccountSettings.Size = new System.Drawing.Size(566, 265);
            this.gbxAccountSettings.TabIndex = 7;
            this.gbxAccountSettings.TabStop = false;
            this.gbxAccountSettings.Text = "Account Settings";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(422, 570);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(503, 570);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // gbxPhoneNumbers
            // 
            this.gbxPhoneNumbers.Controls.Add(this.btnDelete);
            this.gbxPhoneNumbers.Controls.Add(this.btnEdit);
            this.gbxPhoneNumbers.Controls.Add(this.lvPhoneNumbers);
            this.gbxPhoneNumbers.Controls.Add(this.btnAdd);
            this.gbxPhoneNumbers.Location = new System.Drawing.Point(328, 283);
            this.gbxPhoneNumbers.Name = "gbxPhoneNumbers";
            this.gbxPhoneNumbers.Size = new System.Drawing.Size(250, 281);
            this.gbxPhoneNumbers.TabIndex = 4;
            this.gbxPhoneNumbers.TabStop = false;
            this.gbxPhoneNumbers.Text = "Phone Numbers";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(169, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(88, 19);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 34;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // lvPhoneNumbers
            // 
            this.lvPhoneNumbers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNumber,
            this.chType});
            this.lvPhoneNumbers.Location = new System.Drawing.Point(7, 53);
            this.lvPhoneNumbers.Name = "lvPhoneNumbers";
            this.lvPhoneNumbers.Size = new System.Drawing.Size(237, 222);
            this.lvPhoneNumbers.TabIndex = 3;
            this.lvPhoneNumbers.UseCompatibleStateImageBehavior = false;
            this.lvPhoneNumbers.View = System.Windows.Forms.View.Details;
            // 
            // chNumber
            // 
            this.chNumber.Text = "Number";
            this.chNumber.Width = 146;
            // 
            // chType
            // 
            this.chType.Text = "Type";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // tbxEmployeeId
            // 
            this.tbxEmployeeId.Location = new System.Drawing.Point(131, 128);
            this.tbxEmployeeId.Name = "tbxEmployeeId";
            this.tbxEmployeeId.Size = new System.Drawing.Size(163, 20);
            this.tbxEmployeeId.TabIndex = 7;
            // 
            // tbxEmailAddress
            // 
            this.tbxEmailAddress.Location = new System.Drawing.Point(131, 155);
            this.tbxEmailAddress.Name = "tbxEmailAddress";
            this.tbxEmailAddress.Size = new System.Drawing.Size(163, 20);
            this.tbxEmailAddress.TabIndex = 8;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(131, 74);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(163, 20);
            this.tbxFirstName.TabIndex = 9;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(131, 101);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(163, 20);
            this.tbxLastName.TabIndex = 10;
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(58, 132);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(70, 13);
            this.lblEmployeeId.TabIndex = 11;
            this.lblEmployeeId.Text = "Employee ID:";
            this.lblEmployeeId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(52, 159);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(76, 13);
            this.lblEmailAddress.TabIndex = 12;
            this.lblEmailAddress.Text = "Email Address:";
            this.lblEmailAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(68, 77);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 13;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(67, 104);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ckbxChangePassword
            // 
            this.ckbxChangePassword.AutoSize = true;
            this.ckbxChangePassword.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbxChangePassword.Location = new System.Drawing.Point(131, 207);
            this.ckbxChangePassword.Name = "ckbxChangePassword";
            this.ckbxChangePassword.Size = new System.Drawing.Size(15, 14);
            this.ckbxChangePassword.TabIndex = 4;
            this.ckbxChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbxChangePassword.UseVisualStyleBackColor = true;
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.Location = new System.Drawing.Point(6, 207);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(122, 13);
            this.lblChangePassword.TabIndex = 15;
            this.lblChangePassword.Text = "Must Change Password:";
            this.lblChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAccountEnabled
            // 
            this.lblAccountEnabled.AutoSize = true;
            this.lblAccountEnabled.Location = new System.Drawing.Point(36, 25);
            this.lblAccountEnabled.Name = "lblAccountEnabled";
            this.lblAccountEnabled.Size = new System.Drawing.Size(92, 13);
            this.lblAccountEnabled.TabIndex = 16;
            this.lblAccountEnabled.Text = "Account Enabled:";
            this.lblAccountEnabled.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxNotes
            // 
            this.tbxNotes.Location = new System.Drawing.Point(316, 48);
            this.tbxNotes.Multiline = true;
            this.tbxNotes.Name = "tbxNotes";
            this.tbxNotes.Size = new System.Drawing.Size(235, 200);
            this.tbxNotes.TabIndex = 17;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(316, 27);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(38, 13);
            this.lblNotes.TabIndex = 18;
            this.lblNotes.Text = "Notes:";
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point(82, 184);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(46, 13);
            this.lblDomain.TabIndex = 20;
            this.lblDomain.Text = "Domain:";
            this.lblDomain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxDomain
            // 
            this.tbxDomain.Location = new System.Drawing.Point(131, 181);
            this.tbxDomain.Name = "tbxDomain";
            this.tbxDomain.Size = new System.Drawing.Size(163, 20);
            this.tbxDomain.TabIndex = 19;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(65, 51);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(63, 13);
            this.lblUsername.TabIndex = 22;
            this.lblUsername.Text = "User Name:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxName
            // 
            this.tbxName.Enabled = false;
            this.tbxName.Location = new System.Drawing.Point(131, 48);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(163, 20);
            this.tbxName.TabIndex = 21;
            // 
            // ModifyUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 600);
            this.Controls.Add(this.gbxPhoneNumbers);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxAccountSettings);
            this.Controls.Add(this.gbxRoleAssociations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modify User";
            this.gbxRoleAssociations.ResumeLayout(false);
            this.gbxAccountSettings.ResumeLayout(false);
            this.gbxAccountSettings.PerformLayout();
            this.gbxPhoneNumbers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbxAccountEnabled;
        private System.Windows.Forms.GroupBox gbxRoleAssociations;
        private System.Windows.Forms.ListView lvUserRoles;
        private System.Windows.Forms.ColumnHeader chCheckBox;
        private System.Windows.Forms.ColumnHeader chDeviceName;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox tbxNewPassword;
        private System.Windows.Forms.GroupBox gbxAccountSettings;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbxPhoneNumbers;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ListView lvPhoneNumbers;
        private System.Windows.Forms.ColumnHeader chNumber;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAccountEnabled;
        private System.Windows.Forms.Label lblChangePassword;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxEmailAddress;
        private System.Windows.Forms.TextBox tbxEmployeeId;
        private System.Windows.Forms.CheckBox ckbxChangePassword;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox tbxNotes;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.TextBox tbxDomain;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbxName;
    }
}