namespace ExampleClient.Source
{
    partial class ModifyNotificationForm
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
            this.gbxRoles = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lvRoles = new System.Windows.Forms.ListView();
            this.chChecked = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxRoles.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxRoles
            // 
            this.gbxRoles.Controls.Add(this.lvRoles);
            this.gbxRoles.Location = new System.Drawing.Point(12, 12);
            this.gbxRoles.Name = "gbxRoles";
            this.gbxRoles.Size = new System.Drawing.Size(484, 263);
            this.gbxRoles.TabIndex = 28;
            this.gbxRoles.TabStop = false;
            this.gbxRoles.Text = "User Roles to Notify";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(340, 281);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(421, 281);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // lvRoles
            // 
            this.lvRoles.CheckBoxes = true;
            this.lvRoles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chChecked,
            this.chId,
            this.chName});
            this.lvRoles.FullRowSelect = true;
            this.lvRoles.GridLines = true;
            this.lvRoles.Location = new System.Drawing.Point(6, 19);
            this.lvRoles.MultiSelect = false;
            this.lvRoles.Name = "lvRoles";
            this.lvRoles.Size = new System.Drawing.Size(472, 237);
            this.lvRoles.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvRoles.TabIndex = 29;
            this.lvRoles.UseCompatibleStateImageBehavior = false;
            this.lvRoles.View = System.Windows.Forms.View.Details;
            // 
            // chChecked
            // 
            this.chChecked.Text = "";
            this.chChecked.Width = 20;
            // 
            // chId
            // 
            this.chId.Text = "ID";
            this.chId.Width = 224;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 220;
            // 
            // ModifyNotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 311);
            this.Controls.Add(this.gbxRoles);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyNotificationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modify Notification";
            this.gbxRoles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxRoles;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView lvRoles;
        private System.Windows.Forms.ColumnHeader chChecked;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chName;
    }
}