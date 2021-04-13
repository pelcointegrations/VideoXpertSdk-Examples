namespace ExampleClient.Source
{
    partial class ExportConfigurationForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.gbxGlobalExportPassword = new System.Windows.Forms.GroupBox();
            this.chbxForceProtect = new System.Windows.Forms.CheckBox();
            this.gbxGlobalExportPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(102, 92);
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
            this.btnCancel.Location = new System.Drawing.Point(12, 92);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(9, 19);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(144, 20);
            this.tbxPassword.TabIndex = 1;
            // 
            // gbxGlobalExportPassword
            // 
            this.gbxGlobalExportPassword.Controls.Add(this.tbxPassword);
            this.gbxGlobalExportPassword.Location = new System.Drawing.Point(13, 35);
            this.gbxGlobalExportPassword.Name = "gbxGlobalExportPassword";
            this.gbxGlobalExportPassword.Size = new System.Drawing.Size(162, 51);
            this.gbxGlobalExportPassword.TabIndex = 32;
            this.gbxGlobalExportPassword.TabStop = false;
            this.gbxGlobalExportPassword.Text = "Global Export Password";
            // 
            // chbxForceProtect
            // 
            this.chbxForceProtect.AutoSize = true;
            this.chbxForceProtect.Location = new System.Drawing.Point(24, 11);
            this.chbxForceProtect.Name = "chbxForceProtect";
            this.chbxForceProtect.Size = new System.Drawing.Size(140, 17);
            this.chbxForceProtect.TabIndex = 0;
            this.chbxForceProtect.Text = "Force Protected Exports";
            this.chbxForceProtect.UseVisualStyleBackColor = true;
            this.chbxForceProtect.CheckedChanged += new System.EventHandler(this.CheckboxForceProtect_CheckedChanged);
            // 
            // ExportConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 125);
            this.Controls.Add(this.gbxGlobalExportPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.chbxForceProtect);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export Configuration";
            this.gbxGlobalExportPassword.ResumeLayout(false);
            this.gbxGlobalExportPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.GroupBox gbxGlobalExportPassword;
        private System.Windows.Forms.CheckBox chbxForceProtect;
    }
}