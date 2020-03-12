namespace ExampleClient.Source.Misc
{
    partial class ServerConfigurationForm
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
            this.cbxReverseDnsLookup = new System.Windows.Forms.CheckBox();
            this.nudHttpsPort = new System.Windows.Forms.NumericUpDown();
            this.lblHttpsPort = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblHttpPort = new System.Windows.Forms.Label();
            this.nudHttpPort = new System.Windows.Forms.NumericUpDown();
            this.lblRtspPort = new System.Windows.Forms.Label();
            this.nudRtspPort = new System.Windows.Forms.NumericUpDown();
            this.gbxServerSettings = new System.Windows.Forms.GroupBox();
            this.btnRestartServer = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudHttpsPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHttpPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRtspPort)).BeginInit();
            this.gbxServerSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxReverseDnsLookup
            // 
            this.cbxReverseDnsLookup.AutoSize = true;
            this.cbxReverseDnsLookup.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxReverseDnsLookup.Location = new System.Drawing.Point(6, 95);
            this.cbxReverseDnsLookup.Name = "cbxReverseDnsLookup";
            this.cbxReverseDnsLookup.Size = new System.Drawing.Size(179, 17);
            this.cbxReverseDnsLookup.TabIndex = 0;
            this.cbxReverseDnsLookup.Text = "Reverse DNS Lookup Enabled: ";
            this.cbxReverseDnsLookup.UseVisualStyleBackColor = true;
            // 
            // nudHttpsPort
            // 
            this.nudHttpsPort.Location = new System.Drawing.Point(171, 43);
            this.nudHttpsPort.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudHttpsPort.Name = "nudHttpsPort";
            this.nudHttpsPort.Size = new System.Drawing.Size(71, 20);
            this.nudHttpsPort.TabIndex = 5;
            // 
            // lblHttpsPort
            // 
            this.lblHttpsPort.AutoSize = true;
            this.lblHttpsPort.Location = new System.Drawing.Point(97, 45);
            this.lblHttpsPort.Name = "lblHttpsPort";
            this.lblHttpsPort.Size = new System.Drawing.Size(68, 13);
            this.lblHttpsPort.TabIndex = 6;
            this.lblHttpsPort.Text = "HTTPS Port:";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(192, 142);
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
            this.btnCancel.Location = new System.Drawing.Point(111, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblHttpPort
            // 
            this.lblHttpPort.AutoSize = true;
            this.lblHttpPort.Location = new System.Drawing.Point(104, 19);
            this.lblHttpPort.Name = "lblHttpPort";
            this.lblHttpPort.Size = new System.Drawing.Size(61, 13);
            this.lblHttpPort.TabIndex = 29;
            this.lblHttpPort.Text = "HTTP Port:";
            // 
            // nudHttpPort
            // 
            this.nudHttpPort.Location = new System.Drawing.Point(171, 17);
            this.nudHttpPort.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudHttpPort.Name = "nudHttpPort";
            this.nudHttpPort.Size = new System.Drawing.Size(71, 20);
            this.nudHttpPort.TabIndex = 28;
            // 
            // lblRtspPort
            // 
            this.lblRtspPort.AutoSize = true;
            this.lblRtspPort.Location = new System.Drawing.Point(104, 71);
            this.lblRtspPort.Name = "lblRtspPort";
            this.lblRtspPort.Size = new System.Drawing.Size(61, 13);
            this.lblRtspPort.TabIndex = 31;
            this.lblRtspPort.Text = "RTSP Port:";
            // 
            // nudRtspPort
            // 
            this.nudRtspPort.Location = new System.Drawing.Point(171, 69);
            this.nudRtspPort.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudRtspPort.Name = "nudRtspPort";
            this.nudRtspPort.Size = new System.Drawing.Size(71, 20);
            this.nudRtspPort.TabIndex = 30;
            // 
            // gbxServerSettings
            // 
            this.gbxServerSettings.Controls.Add(this.nudRtspPort);
            this.gbxServerSettings.Controls.Add(this.lblRtspPort);
            this.gbxServerSettings.Controls.Add(this.cbxReverseDnsLookup);
            this.gbxServerSettings.Controls.Add(this.nudHttpsPort);
            this.gbxServerSettings.Controls.Add(this.lblHttpPort);
            this.gbxServerSettings.Controls.Add(this.lblHttpsPort);
            this.gbxServerSettings.Controls.Add(this.nudHttpPort);
            this.gbxServerSettings.Location = new System.Drawing.Point(12, 12);
            this.gbxServerSettings.Name = "gbxServerSettings";
            this.gbxServerSettings.Size = new System.Drawing.Size(255, 124);
            this.gbxServerSettings.TabIndex = 32;
            this.gbxServerSettings.TabStop = false;
            this.gbxServerSettings.Text = "Server Settings";
            // 
            // btnRestartServer
            // 
            this.btnRestartServer.Location = new System.Drawing.Point(12, 142);
            this.btnRestartServer.Name = "btnRestartServer";
            this.btnRestartServer.Size = new System.Drawing.Size(93, 23);
            this.btnRestartServer.TabIndex = 35;
            this.btnRestartServer.Text = "Restart Server";
            this.btnRestartServer.UseVisualStyleBackColor = true;
            this.btnRestartServer.Click += new System.EventHandler(this.ButtonRestartServer_Click);
            // 
            // ServerConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 181);
            this.Controls.Add(this.btnRestartServer);
            this.Controls.Add(this.gbxServerSettings);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServerConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Server Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.nudHttpsPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHttpPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRtspPort)).EndInit();
            this.gbxServerSettings.ResumeLayout(false);
            this.gbxServerSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxReverseDnsLookup;
        private System.Windows.Forms.NumericUpDown nudHttpsPort;
        private System.Windows.Forms.Label lblHttpsPort;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblHttpPort;
        private System.Windows.Forms.NumericUpDown nudHttpPort;
        private System.Windows.Forms.Label lblRtspPort;
        private System.Windows.Forms.NumericUpDown nudRtspPort;
        private System.Windows.Forms.GroupBox gbxServerSettings;
        private System.Windows.Forms.Button btnRestartServer;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}