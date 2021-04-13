namespace ExampleClient.Source
{
    partial class ReportConfigurationForm
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
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbxPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblMaxAge = new System.Windows.Forms.Label();
            this.nudMaxAge = new System.Windows.Forms.NumericUpDown();
            this.gbxStorageLocation = new System.Windows.Forms.GroupBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxAge)).BeginInit();
            this.gbxStorageLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(419, 115);
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
            this.btnCancel.Location = new System.Drawing.Point(329, 115);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbxPath
            // 
            this.tbxPath.Location = new System.Drawing.Point(70, 19);
            this.tbxPath.Name = "tbxPath";
            this.tbxPath.Size = new System.Drawing.Size(342, 20);
            this.tbxPath.TabIndex = 37;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(418, 18);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(55, 23);
            this.btnBrowse.TabIndex = 36;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // lblMaxAge
            // 
            this.lblMaxAge.AutoSize = true;
            this.lblMaxAge.Location = new System.Drawing.Point(12, 9);
            this.lblMaxAge.Name = "lblMaxAge";
            this.lblMaxAge.Size = new System.Drawing.Size(52, 13);
            this.lblMaxAge.TabIndex = 35;
            this.lblMaxAge.Text = "Max Age:";
            // 
            // nudMaxAge
            // 
            this.nudMaxAge.Location = new System.Drawing.Point(70, 7);
            this.nudMaxAge.Name = "nudMaxAge";
            this.nudMaxAge.Size = new System.Drawing.Size(120, 20);
            this.nudMaxAge.TabIndex = 34;
            // 
            // gbxStorageLocation
            // 
            this.gbxStorageLocation.Controls.Add(this.lblPath);
            this.gbxStorageLocation.Controls.Add(this.lblPassword);
            this.gbxStorageLocation.Controls.Add(this.lblUsername);
            this.gbxStorageLocation.Controls.Add(this.tbxUsername);
            this.gbxStorageLocation.Controls.Add(this.tbxPassword);
            this.gbxStorageLocation.Controls.Add(this.btnBrowse);
            this.gbxStorageLocation.Controls.Add(this.tbxPath);
            this.gbxStorageLocation.Location = new System.Drawing.Point(12, 33);
            this.gbxStorageLocation.Name = "gbxStorageLocation";
            this.gbxStorageLocation.Size = new System.Drawing.Size(482, 76);
            this.gbxStorageLocation.TabIndex = 39;
            this.gbxStorageLocation.TabStop = false;
            this.gbxStorageLocation.Text = "Storage Location";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(284, 45);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(128, 20);
            this.tbxPassword.TabIndex = 38;
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(70, 45);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(128, 20);
            this.tbxUsername.TabIndex = 39;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(6, 49);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 40;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(222, 49);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 41;
            this.lblPassword.Text = "Password:";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(32, 23);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(32, 13);
            this.lblPath.TabIndex = 42;
            this.lblPath.Text = "Path:";
            // 
            // ReportConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 148);
            this.Controls.Add(this.gbxStorageLocation);
            this.Controls.Add(this.lblMaxAge);
            this.Controls.Add(this.nudMaxAge);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxAge)).EndInit();
            this.gbxStorageLocation.ResumeLayout(false);
            this.gbxStorageLocation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbxPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblMaxAge;
        private System.Windows.Forms.NumericUpDown nudMaxAge;
        private System.Windows.Forms.GroupBox gbxStorageLocation;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPassword;
    }
}