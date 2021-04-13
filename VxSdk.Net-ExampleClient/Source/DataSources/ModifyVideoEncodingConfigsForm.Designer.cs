namespace ExampleClient.Source
{
    partial class ModifyVideoEncodingConfigsForm
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.lvStreams = new System.Windows.Forms.ListView();
            this.chStream = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nudBitrate = new System.Windows.Forms.NumericUpDown();
            this.nudGop = new System.Windows.Forms.NumericUpDown();
            this.nudMulticastPort = new System.Windows.Forms.NumericUpDown();
            this.lblBitrate = new System.Windows.Forms.Label();
            this.lblFramerate = new System.Windows.Forms.Label();
            this.lblGop = new System.Windows.Forms.Label();
            this.lblMulticastPort = new System.Windows.Forms.Label();
            this.tbxMulticastIp = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblMulticastIp = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cbxFormat = new System.Windows.Forms.ComboBox();
            this.lblFormat = new System.Windows.Forms.Label();
            this.lblProfile = new System.Windows.Forms.Label();
            this.cbxProfile = new System.Windows.Forms.ComboBox();
            this.lblResolution = new System.Windows.Forms.Label();
            this.cbxResolution = new System.Windows.Forms.ComboBox();
            this.cbxFramerate = new System.Windows.Forms.ComboBox();
            this.gbxSettings = new System.Windows.Forms.GroupBox();
            this.tlpSettings = new System.Windows.Forms.TableLayoutPanel();
            this.lblApplyWarning = new System.Windows.Forms.Label();
            this.lblRateControl = new System.Windows.Forms.Label();
            this.cbxRateControl = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudBitrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMulticastPort)).BeginInit();
            this.gbxSettings.SuspendLayout();
            this.tlpSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(78, 293);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(60, 23);
            this.btnReset.TabIndex = 32;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(155, 293);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(60, 23);
            this.btnApply.TabIndex = 31;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.ButtonApply_Click);
            // 
            // lvStreams
            // 
            this.lvStreams.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chStream});
            this.lvStreams.FullRowSelect = true;
            this.lvStreams.GridLines = true;
            this.lvStreams.HideSelection = false;
            this.lvStreams.Location = new System.Drawing.Point(12, 10);
            this.lvStreams.MultiSelect = false;
            this.lvStreams.Name = "lvStreams";
            this.lvStreams.Size = new System.Drawing.Size(103, 326);
            this.lvStreams.TabIndex = 33;
            this.lvStreams.UseCompatibleStateImageBehavior = false;
            this.lvStreams.View = System.Windows.Forms.View.Details;
            this.lvStreams.SelectedIndexChanged += new System.EventHandler(this.ListViewStreams_SelectedIndexChanged);
            // 
            // chStream
            // 
            this.chStream.Text = "Stream";
            this.chStream.Width = 99;
            // 
            // nudBitrate
            // 
            this.nudBitrate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudBitrate.Location = new System.Drawing.Point(83, 83);
            this.nudBitrate.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudBitrate.Name = "nudBitrate";
            this.nudBitrate.Size = new System.Drawing.Size(122, 20);
            this.nudBitrate.TabIndex = 34;
            // 
            // nudGop
            // 
            this.nudGop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudGop.Location = new System.Drawing.Point(83, 109);
            this.nudGop.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudGop.Name = "nudGop";
            this.nudGop.Size = new System.Drawing.Size(122, 20);
            this.nudGop.TabIndex = 36;
            // 
            // nudMulticastPort
            // 
            this.nudMulticastPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudMulticastPort.Location = new System.Drawing.Point(83, 215);
            this.nudMulticastPort.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudMulticastPort.Name = "nudMulticastPort";
            this.nudMulticastPort.Size = new System.Drawing.Size(122, 20);
            this.nudMulticastPort.TabIndex = 37;
            // 
            // lblBitrate
            // 
            this.lblBitrate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBitrate.Location = new System.Drawing.Point(3, 80);
            this.lblBitrate.Name = "lblBitrate";
            this.lblBitrate.Size = new System.Drawing.Size(74, 26);
            this.lblBitrate.TabIndex = 38;
            this.lblBitrate.Text = "Bitrate";
            this.lblBitrate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFramerate
            // 
            this.lblFramerate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFramerate.Location = new System.Drawing.Point(3, 132);
            this.lblFramerate.Name = "lblFramerate";
            this.lblFramerate.Size = new System.Drawing.Size(74, 27);
            this.lblFramerate.TabIndex = 39;
            this.lblFramerate.Text = "Framerate";
            this.lblFramerate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGop
            // 
            this.lblGop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGop.Location = new System.Drawing.Point(3, 106);
            this.lblGop.Name = "lblGop";
            this.lblGop.Size = new System.Drawing.Size(74, 26);
            this.lblGop.TabIndex = 40;
            this.lblGop.Text = "GOP";
            this.lblGop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMulticastPort
            // 
            this.lblMulticastPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMulticastPort.Location = new System.Drawing.Point(3, 212);
            this.lblMulticastPort.Name = "lblMulticastPort";
            this.lblMulticastPort.Size = new System.Drawing.Size(74, 26);
            this.lblMulticastPort.TabIndex = 41;
            this.lblMulticastPort.Text = "Multicast Port";
            this.lblMulticastPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxMulticastIp
            // 
            this.tbxMulticastIp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxMulticastIp.Location = new System.Drawing.Point(83, 189);
            this.tbxMulticastIp.Name = "tbxMulticastIp";
            this.tbxMulticastIp.Size = new System.Drawing.Size(122, 20);
            this.tbxMulticastIp.TabIndex = 42;
            // 
            // tbxName
            // 
            this.tbxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxName.Location = new System.Drawing.Point(83, 30);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(122, 20);
            this.tbxName.TabIndex = 43;
            // 
            // lblMulticastIp
            // 
            this.lblMulticastIp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMulticastIp.Location = new System.Drawing.Point(3, 186);
            this.lblMulticastIp.Name = "lblMulticastIp";
            this.lblMulticastIp.Size = new System.Drawing.Size(74, 26);
            this.lblMulticastIp.TabIndex = 44;
            this.lblMulticastIp.Text = "Multicast IP";
            this.lblMulticastIp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(3, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 26);
            this.lblName.TabIndex = 45;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxFormat
            // 
            this.cbxFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFormat.FormattingEnabled = true;
            this.cbxFormat.Location = new System.Drawing.Point(83, 3);
            this.cbxFormat.Name = "cbxFormat";
            this.cbxFormat.Size = new System.Drawing.Size(122, 21);
            this.cbxFormat.TabIndex = 46;
            this.cbxFormat.DropDownClosed += new System.EventHandler(this.ComboBoxFormat_DropDownClosed);
            // 
            // lblFormat
            // 
            this.lblFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFormat.Location = new System.Drawing.Point(3, 0);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(74, 27);
            this.lblFormat.TabIndex = 47;
            this.lblFormat.Text = "Format";
            this.lblFormat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProfile
            // 
            this.lblProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProfile.Location = new System.Drawing.Point(3, 53);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(74, 27);
            this.lblProfile.TabIndex = 49;
            this.lblProfile.Text = "Profile";
            this.lblProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxProfile
            // 
            this.cbxProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProfile.FormattingEnabled = true;
            this.cbxProfile.Location = new System.Drawing.Point(83, 56);
            this.cbxProfile.Name = "cbxProfile";
            this.cbxProfile.Size = new System.Drawing.Size(122, 21);
            this.cbxProfile.TabIndex = 48;
            // 
            // lblResolution
            // 
            this.lblResolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResolution.Location = new System.Drawing.Point(3, 159);
            this.lblResolution.Name = "lblResolution";
            this.lblResolution.Size = new System.Drawing.Size(74, 27);
            this.lblResolution.TabIndex = 51;
            this.lblResolution.Text = "Resolution";
            this.lblResolution.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxResolution
            // 
            this.cbxResolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxResolution.FormattingEnabled = true;
            this.cbxResolution.Location = new System.Drawing.Point(83, 162);
            this.cbxResolution.Name = "cbxResolution";
            this.cbxResolution.Size = new System.Drawing.Size(122, 21);
            this.cbxResolution.TabIndex = 50;
            // 
            // cbxFramerate
            // 
            this.cbxFramerate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxFramerate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFramerate.FormattingEnabled = true;
            this.cbxFramerate.Location = new System.Drawing.Point(83, 135);
            this.cbxFramerate.Name = "cbxFramerate";
            this.cbxFramerate.Size = new System.Drawing.Size(122, 21);
            this.cbxFramerate.TabIndex = 52;
            // 
            // gbxSettings
            // 
            this.gbxSettings.Controls.Add(this.tlpSettings);
            this.gbxSettings.Controls.Add(this.btnReset);
            this.gbxSettings.Controls.Add(this.btnApply);
            this.gbxSettings.Controls.Add(this.lblApplyWarning);
            this.gbxSettings.Enabled = false;
            this.gbxSettings.Location = new System.Drawing.Point(121, 12);
            this.gbxSettings.Name = "gbxSettings";
            this.gbxSettings.Size = new System.Drawing.Size(223, 324);
            this.gbxSettings.TabIndex = 53;
            this.gbxSettings.TabStop = false;
            // 
            // tlpSettings
            // 
            this.tlpSettings.ColumnCount = 2;
            this.tlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSettings.Controls.Add(this.nudMulticastPort, 1, 8);
            this.tlpSettings.Controls.Add(this.cbxFramerate, 1, 5);
            this.tlpSettings.Controls.Add(this.tbxName, 1, 1);
            this.tlpSettings.Controls.Add(this.lblMulticastPort, 0, 8);
            this.tlpSettings.Controls.Add(this.tbxMulticastIp, 1, 7);
            this.tlpSettings.Controls.Add(this.lblMulticastIp, 0, 7);
            this.tlpSettings.Controls.Add(this.lblFormat, 0, 0);
            this.tlpSettings.Controls.Add(this.cbxFormat, 1, 0);
            this.tlpSettings.Controls.Add(this.lblName, 0, 1);
            this.tlpSettings.Controls.Add(this.nudBitrate, 1, 3);
            this.tlpSettings.Controls.Add(this.cbxResolution, 1, 6);
            this.tlpSettings.Controls.Add(this.lblResolution, 0, 6);
            this.tlpSettings.Controls.Add(this.lblProfile, 0, 2);
            this.tlpSettings.Controls.Add(this.cbxProfile, 1, 2);
            this.tlpSettings.Controls.Add(this.lblFramerate, 0, 5);
            this.tlpSettings.Controls.Add(this.lblBitrate, 0, 3);
            this.tlpSettings.Controls.Add(this.lblGop, 0, 4);
            this.tlpSettings.Controls.Add(this.nudGop, 1, 4);
            this.tlpSettings.Controls.Add(this.lblRateControl, 0, 9);
            this.tlpSettings.Controls.Add(this.cbxRateControl, 1, 9);
            this.tlpSettings.Location = new System.Drawing.Point(7, 19);
            this.tlpSettings.Name = "tlpSettings";
            this.tlpSettings.RowCount = 11;
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSettings.Size = new System.Drawing.Size(208, 268);
            this.tlpSettings.TabIndex = 54;
            // 
            // lblApplyWarning
            // 
            this.lblApplyWarning.Location = new System.Drawing.Point(17, 122);
            this.lblApplyWarning.Name = "lblApplyWarning";
            this.lblApplyWarning.Size = new System.Drawing.Size(181, 49);
            this.lblApplyWarning.TabIndex = 53;
            this.lblApplyWarning.Text = "New format must be applied before configuring the settings.";
            this.lblApplyWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblApplyWarning.Visible = false;
            // 
            // lblRateControl
            // 
            this.lblRateControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRateControl.Location = new System.Drawing.Point(3, 238);
            this.lblRateControl.Name = "lblRateControl";
            this.lblRateControl.Size = new System.Drawing.Size(74, 27);
            this.lblRateControl.TabIndex = 53;
            this.lblRateControl.Text = "Rate Control";
            this.lblRateControl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxRateControl
            // 
            this.cbxRateControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxRateControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRateControl.FormattingEnabled = true;
            this.cbxRateControl.Location = new System.Drawing.Point(83, 241);
            this.cbxRateControl.Name = "cbxRateControl";
            this.cbxRateControl.Size = new System.Drawing.Size(122, 21);
            this.cbxRateControl.TabIndex = 54;
            // 
            // ModifyVideoEncodingConfigsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 344);
            this.Controls.Add(this.gbxSettings);
            this.Controls.Add(this.lvStreams);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyVideoEncodingConfigsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modify Video Encoding Configs";
            ((System.ComponentModel.ISupportInitialize)(this.nudBitrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMulticastPort)).EndInit();
            this.gbxSettings.ResumeLayout(false);
            this.tlpSettings.ResumeLayout(false);
            this.tlpSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ListView lvStreams;
        private System.Windows.Forms.ColumnHeader chStream;
        private System.Windows.Forms.NumericUpDown nudBitrate;
        private System.Windows.Forms.NumericUpDown nudGop;
        private System.Windows.Forms.NumericUpDown nudMulticastPort;
        private System.Windows.Forms.Label lblBitrate;
        private System.Windows.Forms.Label lblFramerate;
        private System.Windows.Forms.Label lblGop;
        private System.Windows.Forms.Label lblMulticastPort;
        private System.Windows.Forms.TextBox tbxMulticastIp;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblMulticastIp;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cbxFormat;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.ComboBox cbxProfile;
        private System.Windows.Forms.Label lblResolution;
        private System.Windows.Forms.ComboBox cbxResolution;
        private System.Windows.Forms.ComboBox cbxFramerate;
        private System.Windows.Forms.GroupBox gbxSettings;
        private System.Windows.Forms.Label lblApplyWarning;
        private System.Windows.Forms.TableLayoutPanel tlpSettings;
        private System.Windows.Forms.Label lblRateControl;
        private System.Windows.Forms.ComboBox cbxRateControl;
    }
}