namespace ExampleClient.Source
{
    partial class FileRecoveryManagerForm
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
            this.lblStatusLabel = new System.Windows.Forms.Label();
            this.lblStatusMessageLabel = new System.Windows.Forms.Label();
            this.lblFilesRecoveredLabel = new System.Windows.Forms.Label();
            this.tbxStatusMessage = new System.Windows.Forms.TextBox();
            this.tbxStatus = new System.Windows.Forms.TextBox();
            this.tbxFilesRecovered = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnHalt = new System.Windows.Forms.Button();
            this.btnTrigger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStatusLabel
            // 
            this.lblStatusLabel.AutoSize = true;
            this.lblStatusLabel.Location = new System.Drawing.Point(55, 11);
            this.lblStatusLabel.Name = "lblStatusLabel";
            this.lblStatusLabel.Size = new System.Drawing.Size(40, 13);
            this.lblStatusLabel.TabIndex = 0;
            this.lblStatusLabel.Text = "Status:";
            // 
            // lblStatusMessageLabel
            // 
            this.lblStatusMessageLabel.AutoSize = true;
            this.lblStatusMessageLabel.Location = new System.Drawing.Point(9, 60);
            this.lblStatusMessageLabel.Name = "lblStatusMessageLabel";
            this.lblStatusMessageLabel.Size = new System.Drawing.Size(86, 13);
            this.lblStatusMessageLabel.TabIndex = 1;
            this.lblStatusMessageLabel.Text = "Status Message:";
            // 
            // lblFilesRecoveredLabel
            // 
            this.lblFilesRecoveredLabel.AutoSize = true;
            this.lblFilesRecoveredLabel.Location = new System.Drawing.Point(8, 37);
            this.lblFilesRecoveredLabel.Name = "lblFilesRecoveredLabel";
            this.lblFilesRecoveredLabel.Size = new System.Drawing.Size(87, 13);
            this.lblFilesRecoveredLabel.TabIndex = 2;
            this.lblFilesRecoveredLabel.Text = "Files Recovered:";
            // 
            // tbxStatusMessage
            // 
            this.tbxStatusMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxStatusMessage.Enabled = false;
            this.tbxStatusMessage.Location = new System.Drawing.Point(100, 60);
            this.tbxStatusMessage.Multiline = true;
            this.tbxStatusMessage.Name = "tbxStatusMessage";
            this.tbxStatusMessage.ReadOnly = true;
            this.tbxStatusMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxStatusMessage.Size = new System.Drawing.Size(228, 82);
            this.tbxStatusMessage.TabIndex = 6;
            // 
            // tbxStatus
            // 
            this.tbxStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxStatus.Enabled = false;
            this.tbxStatus.Location = new System.Drawing.Point(100, 11);
            this.tbxStatus.Name = "tbxStatus";
            this.tbxStatus.ReadOnly = true;
            this.tbxStatus.Size = new System.Drawing.Size(228, 13);
            this.tbxStatus.TabIndex = 9;
            // 
            // tbxFilesRecovered
            // 
            this.tbxFilesRecovered.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxFilesRecovered.Enabled = false;
            this.tbxFilesRecovered.Location = new System.Drawing.Point(100, 37);
            this.tbxFilesRecovered.Name = "tbxFilesRecovered";
            this.tbxFilesRecovered.ReadOnly = true;
            this.tbxFilesRecovered.Size = new System.Drawing.Size(228, 13);
            this.tbxFilesRecovered.TabIndex = 10;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(334, 11);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // btnHalt
            // 
            this.btnHalt.Location = new System.Drawing.Point(334, 40);
            this.btnHalt.Name = "btnHalt";
            this.btnHalt.Size = new System.Drawing.Size(75, 23);
            this.btnHalt.TabIndex = 10;
            this.btnHalt.Text = "Halt";
            this.btnHalt.UseVisualStyleBackColor = true;
            this.btnHalt.Click += new System.EventHandler(this.ButtonHalt_Click);
            // 
            // btnTrigger
            // 
            this.btnTrigger.Location = new System.Drawing.Point(334, 69);
            this.btnTrigger.Name = "btnTrigger";
            this.btnTrigger.Size = new System.Drawing.Size(75, 23);
            this.btnTrigger.TabIndex = 11;
            this.btnTrigger.Text = "Trigger";
            this.btnTrigger.UseVisualStyleBackColor = true;
            this.btnTrigger.Click += new System.EventHandler(this.ButtonTrigger_Click);
            // 
            // FileRecoveryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 154);
            this.Controls.Add(this.tbxFilesRecovered);
            this.Controls.Add(this.btnTrigger);
            this.Controls.Add(this.tbxStatus);
            this.Controls.Add(this.btnHalt);
            this.Controls.Add(this.tbxStatusMessage);
            this.Controls.Add(this.lblFilesRecoveredLabel);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblStatusMessageLabel);
            this.Controls.Add(this.lblStatusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileRecoveryManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "File Recovery Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxStatusMessage;
        private System.Windows.Forms.Label lblFilesRecoveredLabel;
        private System.Windows.Forms.Label lblStatusMessageLabel;
        private System.Windows.Forms.Label lblStatusLabel;
        private System.Windows.Forms.TextBox tbxFilesRecovered;
        private System.Windows.Forms.TextBox tbxStatus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnHalt;
        private System.Windows.Forms.Button btnTrigger;
    }
}