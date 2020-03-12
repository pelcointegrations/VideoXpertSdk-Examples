namespace ExampleClient.Source
{
    partial class ModifyAnalyticSessionForm
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
            this.gbxDataEncodingId = new System.Windows.Forms.GroupBox();
            this.tbxDataEncodingId = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxSource = new System.Windows.Forms.GroupBox();
            this.tbxSource = new System.Windows.Forms.TextBox();
            this.gbxDataEncodingId.SuspendLayout();
            this.gbxSource.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDataEncodingId
            // 
            this.gbxDataEncodingId.Controls.Add(this.tbxDataEncodingId);
            this.gbxDataEncodingId.Location = new System.Drawing.Point(12, 12);
            this.gbxDataEncodingId.Name = "gbxDataEncodingId";
            this.gbxDataEncodingId.Size = new System.Drawing.Size(215, 58);
            this.gbxDataEncodingId.TabIndex = 6;
            this.gbxDataEncodingId.TabStop = false;
            this.gbxDataEncodingId.Text = "Data Encoding Id";
            // 
            // tbxDataEncodingId
            // 
            this.tbxDataEncodingId.Location = new System.Drawing.Point(6, 19);
            this.tbxDataEncodingId.MaxLength = 255;
            this.tbxDataEncodingId.Name = "tbxDataEncodingId";
            this.tbxDataEncodingId.Size = new System.Drawing.Size(203, 20);
            this.tbxDataEncodingId.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(560, 76);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(479, 76);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // gbxSource
            // 
            this.gbxSource.Controls.Add(this.tbxSource);
            this.gbxSource.Location = new System.Drawing.Point(233, 12);
            this.gbxSource.Name = "gbxSource";
            this.gbxSource.Size = new System.Drawing.Size(402, 58);
            this.gbxSource.TabIndex = 7;
            this.gbxSource.TabStop = false;
            this.gbxSource.Text = "Source";
            // 
            // tbxSource
            // 
            this.tbxSource.Location = new System.Drawing.Point(6, 19);
            this.tbxSource.MaxLength = 64;
            this.tbxSource.Name = "tbxSource";
            this.tbxSource.Size = new System.Drawing.Size(390, 20);
            this.tbxSource.TabIndex = 0;
            // 
            // ModifyAnalyticSessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 110);
            this.Controls.Add(this.gbxSource);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxDataEncodingId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyAnalyticSessionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modify Analytic Session";
            this.gbxDataEncodingId.ResumeLayout(false);
            this.gbxDataEncodingId.PerformLayout();
            this.gbxSource.ResumeLayout(false);
            this.gbxSource.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxDataEncodingId;
        private System.Windows.Forms.TextBox tbxDataEncodingId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbxSource;
        private System.Windows.Forms.TextBox tbxSource;
    }
}