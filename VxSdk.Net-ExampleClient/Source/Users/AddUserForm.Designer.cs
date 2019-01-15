namespace ExampleClient.Source
{
    partial class AddUserForm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.gbxPhoneNumbers = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lvPhoneNumbers = new System.Windows.Forms.ListView();
            this.chNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxAccountSettings = new System.Windows.Forms.GroupBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblDomain = new System.Windows.Forms.Label();
            this.tbxDomain = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.tbxNotes = new System.Windows.Forms.TextBox();
            this.lblChangePassword = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxEmailAddress = new System.Windows.Forms.TextBox();
            this.tbxEmployeeId = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.ckbxChangePassword = new System.Windows.Forms.CheckBox();
            this.gbxPhoneNumbers.SuspendLayout();
            this.gbxAccountSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(710, 260);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(59, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(775, 260);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(59, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // gbxPhoneNumbers
            // 
            this.gbxPhoneNumbers.Controls.Add(this.btnDelete);
            this.gbxPhoneNumbers.Controls.Add(this.btnEdit);
            this.gbxPhoneNumbers.Controls.Add(this.lvPhoneNumbers);
            this.gbxPhoneNumbers.Controls.Add(this.btnAdd);
            this.gbxPhoneNumbers.Location = new System.Drawing.Point(584, 12);
            this.gbxPhoneNumbers.Name = "gbxPhoneNumbers";
            this.gbxPhoneNumbers.Size = new System.Drawing.Size(250, 242);
            this.gbxPhoneNumbers.TabIndex = 9;
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
            this.lvPhoneNumbers.Size = new System.Drawing.Size(237, 183);
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
            // gbxAccountSettings
            // 
            this.gbxAccountSettings.Controls.Add(this.lblUsername);
            this.gbxAccountSettings.Controls.Add(this.tbxName);
            this.gbxAccountSettings.Controls.Add(this.lblDomain);
            this.gbxAccountSettings.Controls.Add(this.tbxDomain);
            this.gbxAccountSettings.Controls.Add(this.lblNotes);
            this.gbxAccountSettings.Controls.Add(this.tbxNotes);
            this.gbxAccountSettings.Controls.Add(this.lblChangePassword);
            this.gbxAccountSettings.Controls.Add(this.lblLastName);
            this.gbxAccountSettings.Controls.Add(this.lblFirstName);
            this.gbxAccountSettings.Controls.Add(this.lblEmailAddress);
            this.gbxAccountSettings.Controls.Add(this.lblEmployeeId);
            this.gbxAccountSettings.Controls.Add(this.tbxLastName);
            this.gbxAccountSettings.Controls.Add(this.tbxFirstName);
            this.gbxAccountSettings.Controls.Add(this.tbxEmailAddress);
            this.gbxAccountSettings.Controls.Add(this.tbxEmployeeId);
            this.gbxAccountSettings.Controls.Add(this.tbxPassword);
            this.gbxAccountSettings.Controls.Add(this.lblPassword);
            this.gbxAccountSettings.Controls.Add(this.ckbxChangePassword);
            this.gbxAccountSettings.Location = new System.Drawing.Point(12, 12);
            this.gbxAccountSettings.Name = "gbxAccountSettings";
            this.gbxAccountSettings.Size = new System.Drawing.Size(556, 242);
            this.gbxAccountSettings.TabIndex = 10;
            this.gbxAccountSettings.TabStop = false;
            this.gbxAccountSettings.Text = "Account Settings";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(65, 30);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(63, 13);
            this.lblUsername.TabIndex = 22;
            this.lblUsername.Text = "User Name:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(131, 27);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(163, 20);
            this.tbxName.TabIndex = 21;
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point(82, 189);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(46, 13);
            this.lblDomain.TabIndex = 20;
            this.lblDomain.Text = "Domain:";
            this.lblDomain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxDomain
            // 
            this.tbxDomain.Location = new System.Drawing.Point(131, 186);
            this.tbxDomain.Name = "tbxDomain";
            this.tbxDomain.Size = new System.Drawing.Size(163, 20);
            this.tbxDomain.TabIndex = 19;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(309, 18);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(38, 13);
            this.lblNotes.TabIndex = 18;
            this.lblNotes.Text = "Notes:";
            // 
            // tbxNotes
            // 
            this.tbxNotes.Location = new System.Drawing.Point(309, 39);
            this.tbxNotes.Multiline = true;
            this.tbxNotes.Name = "tbxNotes";
            this.tbxNotes.Size = new System.Drawing.Size(235, 167);
            this.tbxNotes.TabIndex = 17;
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.Location = new System.Drawing.Point(6, 213);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(122, 13);
            this.lblChangePassword.TabIndex = 15;
            this.lblChangePassword.Text = "Must Change Password:";
            this.lblChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(67, 109);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(68, 82);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 13;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(52, 164);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(76, 13);
            this.lblEmailAddress.TabIndex = 12;
            this.lblEmailAddress.Text = "Email Address:";
            this.lblEmailAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(58, 137);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(70, 13);
            this.lblEmployeeId.TabIndex = 11;
            this.lblEmployeeId.Text = "Employee ID:";
            this.lblEmployeeId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(131, 106);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(163, 20);
            this.tbxLastName.TabIndex = 10;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(131, 79);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(163, 20);
            this.tbxFirstName.TabIndex = 9;
            // 
            // tbxEmailAddress
            // 
            this.tbxEmailAddress.Location = new System.Drawing.Point(131, 160);
            this.tbxEmailAddress.Name = "tbxEmailAddress";
            this.tbxEmailAddress.Size = new System.Drawing.Size(163, 20);
            this.tbxEmailAddress.TabIndex = 8;
            // 
            // tbxEmployeeId
            // 
            this.tbxEmployeeId.Location = new System.Drawing.Point(131, 133);
            this.tbxEmployeeId.Name = "tbxEmployeeId";
            this.tbxEmployeeId.Size = new System.Drawing.Size(163, 20);
            this.tbxEmployeeId.TabIndex = 7;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(131, 53);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(163, 20);
            this.tbxPassword.TabIndex = 6;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(69, 56);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password: ";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ckbxChangePassword
            // 
            this.ckbxChangePassword.AutoSize = true;
            this.ckbxChangePassword.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbxChangePassword.Location = new System.Drawing.Point(131, 213);
            this.ckbxChangePassword.Name = "ckbxChangePassword";
            this.ckbxChangePassword.Size = new System.Drawing.Size(15, 14);
            this.ckbxChangePassword.TabIndex = 4;
            this.ckbxChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbxChangePassword.UseVisualStyleBackColor = true;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 293);
            this.Controls.Add(this.gbxPhoneNumbers);
            this.Controls.Add(this.gbxAccountSettings);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add User";
            this.gbxPhoneNumbers.ResumeLayout(false);
            this.gbxAccountSettings.ResumeLayout(false);
            this.gbxAccountSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox gbxPhoneNumbers;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ListView lvPhoneNumbers;
        private System.Windows.Forms.ColumnHeader chNumber;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxAccountSettings;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.TextBox tbxDomain;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox tbxNotes;
        private System.Windows.Forms.Label lblChangePassword;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxEmailAddress;
        private System.Windows.Forms.TextBox tbxEmployeeId;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox ckbxChangePassword;
    }
}