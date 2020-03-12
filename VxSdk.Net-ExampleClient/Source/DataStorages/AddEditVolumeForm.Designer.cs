namespace ExampleClient.Source
{
    partial class AddEditVolumeForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblDomain = new System.Windows.Forms.Label();
            this.tbxDomain = new System.Windows.Forms.TextBox();
            this.nudBuffer = new System.Windows.Forms.NumericUpDown();
            this.lblBuffer = new System.Windows.Forms.Label();
            this.cbxReserveBandwidth = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudBuffer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(264, 118);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(345, 118);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // tbxPath
            // 
            this.tbxPath.Location = new System.Drawing.Point(73, 8);
            this.tbxPath.Name = "tbxPath";
            this.tbxPath.Size = new System.Drawing.Size(347, 20);
            this.tbxPath.TabIndex = 26;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(37, 12);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(32, 13);
            this.lblPath.TabIndex = 27;
            this.lblPath.Text = "Path:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(11, 65);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 29;
            this.lblUsername.Text = "Username:";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(73, 61);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(156, 20);
            this.tbxUsername.TabIndex = 28;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(13, 91);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 31;
            this.lblPassword.Text = "Password:";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(73, 87);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(156, 20);
            this.tbxPassword.TabIndex = 30;
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point(23, 39);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(46, 13);
            this.lblDomain.TabIndex = 33;
            this.lblDomain.Text = "Domain:";
            // 
            // tbxDomain
            // 
            this.tbxDomain.Location = new System.Drawing.Point(73, 35);
            this.tbxDomain.Name = "tbxDomain";
            this.tbxDomain.Size = new System.Drawing.Size(156, 20);
            this.tbxDomain.TabIndex = 32;
            // 
            // nudBuffer
            // 
            this.nudBuffer.Location = new System.Drawing.Point(356, 34);
            this.nudBuffer.Name = "nudBuffer";
            this.nudBuffer.Size = new System.Drawing.Size(64, 20);
            this.nudBuffer.TabIndex = 34;
            // 
            // lblBuffer
            // 
            this.lblBuffer.AutoSize = true;
            this.lblBuffer.Location = new System.Drawing.Point(312, 38);
            this.lblBuffer.Name = "lblBuffer";
            this.lblBuffer.Size = new System.Drawing.Size(38, 13);
            this.lblBuffer.TabIndex = 35;
            this.lblBuffer.Text = "Buffer:";
            // 
            // cbxReserveBandwidth
            // 
            this.cbxReserveBandwidth.AutoSize = true;
            this.cbxReserveBandwidth.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxReserveBandwidth.Location = new System.Drawing.Point(249, 64);
            this.cbxReserveBandwidth.Name = "cbxReserveBandwidth";
            this.cbxReserveBandwidth.Size = new System.Drawing.Size(122, 17);
            this.cbxReserveBandwidth.TabIndex = 36;
            this.cbxReserveBandwidth.Text = "Reserve Bandwidth:";
            this.cbxReserveBandwidth.UseVisualStyleBackColor = true;
            // 
            // AddEditVolumeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 145);
            this.Controls.Add(this.cbxReserveBandwidth);
            this.Controls.Add(this.lblBuffer);
            this.Controls.Add(this.nudBuffer);
            this.Controls.Add(this.lblDomain);
            this.Controls.Add(this.tbxDomain);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.tbxPath);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditVolumeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Volume";
            ((System.ComponentModel.ISupportInitialize)(this.nudBuffer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.TextBox tbxDomain;
        private System.Windows.Forms.NumericUpDown nudBuffer;
        private System.Windows.Forms.Label lblBuffer;
        private System.Windows.Forms.CheckBox cbxReserveBandwidth;
    }
}