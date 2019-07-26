namespace ExampleClient.Source.Exports
{
    partial class ExportDownloadProgess
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
            this.button_cancel = new System.Windows.Forms.Button();
            this.textBox_status = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(160, 130);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 0;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.Button_cancel_Click);
            // 
            // textBox_status
            // 
            this.textBox_status.Enabled = false;
            this.textBox_status.Location = new System.Drawing.Point(12, 12);
            this.textBox_status.Multiline = true;
            this.textBox_status.Name = "textBox_status";
            this.textBox_status.Size = new System.Drawing.Size(347, 98);
            this.textBox_status.TabIndex = 1;
            this.textBox_status.TabStop = false;
            // 
            // ExportDownloadProgess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 205);
            this.ControlBox = false;
            this.Controls.Add(this.textBox_status);
            this.Controls.Add(this.button_cancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportDownloadProgess";
            this.ShowIcon = false;
            this.Text = "ExportDownloadProgess";
            this.Load += new System.EventHandler(this.ExportDownloadProgess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cancel;
        public System.Windows.Forms.TextBox textBox_status;
    }
}