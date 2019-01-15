namespace MonitorSample
{
    partial class MainForm
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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxMonitors = new System.Windows.Forms.GroupBox();
            this.listBoxMonitors = new System.Windows.Forms.ListBox();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelLoginInfo = new System.Windows.Forms.TableLayoutPanel();
            this.labelIP = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxIp = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.groupBoxLayouts = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1x1 = new System.Windows.Forms.Button();
            this.button2x2 = new System.Windows.Forms.Button();
            this.button3x3 = new System.Windows.Forms.Button();
            this.button4x4 = new System.Windows.Forms.Button();
            this.groupBoxCells = new System.Windows.Forms.GroupBox();
            this.listBoxCells = new System.Windows.Forms.ListBox();
            this.groupBoxCameras = new System.Windows.Forms.GroupBox();
            this.listBoxCameras = new System.Windows.Forms.ListBox();
            this.groupBoxTime = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelTime = new System.Windows.Forms.TableLayoutPanel();
            this.labelRecorded = new System.Windows.Forms.Label();
            this.labelLive = new System.Windows.Forms.Label();
            this.checkBoxLive = new System.Windows.Forms.CheckBox();
            this.dateTimePickerRecorded = new System.Windows.Forms.DateTimePicker();
            this.buttonShowVideo = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain.SuspendLayout();
            this.groupBoxMonitors.SuspendLayout();
            this.groupBoxLogin.SuspendLayout();
            this.tableLayoutPanelLoginInfo.SuspendLayout();
            this.groupBoxLayouts.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.groupBoxCells.SuspendLayout();
            this.groupBoxCameras.SuspendLayout();
            this.groupBoxTime.SuspendLayout();
            this.tableLayoutPanelTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 6;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxMonitors, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxLogin, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxLayouts, 2, 0);
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxCells, 2, 1);
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxCameras, 3, 0);
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxTime, 4, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(755, 283);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // groupBoxMonitors
            // 
            this.groupBoxMonitors.Controls.Add(this.listBoxMonitors);
            this.groupBoxMonitors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMonitors.Location = new System.Drawing.Point(191, 3);
            this.groupBoxMonitors.Name = "groupBoxMonitors";
            this.tableLayoutPanelMain.SetRowSpan(this.groupBoxMonitors, 2);
            this.groupBoxMonitors.Size = new System.Drawing.Size(151, 277);
            this.groupBoxMonitors.TabIndex = 0;
            this.groupBoxMonitors.TabStop = false;
            this.groupBoxMonitors.Text = "Select Monitor";
            // 
            // listBoxMonitors
            // 
            this.listBoxMonitors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxMonitors.FormattingEnabled = true;
            this.listBoxMonitors.Location = new System.Drawing.Point(3, 16);
            this.listBoxMonitors.Name = "listBoxMonitors";
            this.listBoxMonitors.Size = new System.Drawing.Size(145, 258);
            this.listBoxMonitors.TabIndex = 0;
            this.listBoxMonitors.SelectedIndexChanged += new System.EventHandler(this.ListBoxMonitorsSelectedIndexChanged);
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxLogin.Controls.Add(this.tableLayoutPanelLoginInfo);
            this.groupBoxLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxLogin.Location = new System.Drawing.Point(3, 3);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.tableLayoutPanelMain.SetRowSpan(this.groupBoxLogin, 2);
            this.groupBoxLogin.Size = new System.Drawing.Size(182, 277);
            this.groupBoxLogin.TabIndex = 1;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "VideoXpert Login";
            // 
            // tableLayoutPanelLoginInfo
            // 
            this.tableLayoutPanelLoginInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelLoginInfo.ColumnCount = 2;
            this.tableLayoutPanelLoginInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelLoginInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLoginInfo.Controls.Add(this.labelIP, 0, 0);
            this.tableLayoutPanelLoginInfo.Controls.Add(this.labelUsername, 0, 1);
            this.tableLayoutPanelLoginInfo.Controls.Add(this.labelPassword, 0, 2);
            this.tableLayoutPanelLoginInfo.Controls.Add(this.textBoxIp, 1, 0);
            this.tableLayoutPanelLoginInfo.Controls.Add(this.textBoxUsername, 1, 1);
            this.tableLayoutPanelLoginInfo.Controls.Add(this.textBoxPassword, 1, 2);
            this.tableLayoutPanelLoginInfo.Controls.Add(this.buttonLogin, 1, 3);
            this.tableLayoutPanelLoginInfo.Controls.Add(this.labelMessage, 0, 4);
            this.tableLayoutPanelLoginInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLoginInfo.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelLoginInfo.Name = "tableLayoutPanelLoginInfo";
            this.tableLayoutPanelLoginInfo.RowCount = 5;
            this.tableLayoutPanelLoginInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLoginInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLoginInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLoginInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelLoginInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelLoginInfo.Size = new System.Drawing.Size(176, 258);
            this.tableLayoutPanelLoginInfo.TabIndex = 0;
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(5, 5);
            this.labelIP.Margin = new System.Windows.Forms.Padding(5);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(17, 13);
            this.labelIP.TabIndex = 0;
            this.labelIP.Text = "IP";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(5, 31);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(5);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(5, 57);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(5);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password";
            // 
            // textBoxIp
            // 
            this.textBoxIp.Location = new System.Drawing.Point(68, 3);
            this.textBoxIp.Name = "textBoxIp";
            this.textBoxIp.Size = new System.Drawing.Size(100, 20);
            this.textBoxIp.TabIndex = 3;
            this.textBoxIp.Text = "192.168.1.57";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(68, 29);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsername.TabIndex = 4;
            this.textBoxUsername.Text = "admin";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(68, 55);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.Text = "admin123";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(68, 81);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLoginClick);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.tableLayoutPanelLoginInfo.SetColumnSpan(this.labelMessage, 2);
            this.labelMessage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelMessage.Location = new System.Drawing.Point(5, 112);
            this.labelMessage.Margin = new System.Windows.Forms.Padding(5);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(16, 13);
            this.labelMessage.TabIndex = 7;
            this.labelMessage.Text = "...";
            // 
            // groupBoxLayouts
            // 
            this.groupBoxLayouts.Controls.Add(this.flowLayoutPanel);
            this.groupBoxLayouts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxLayouts.Location = new System.Drawing.Point(348, 3);
            this.groupBoxLayouts.Name = "groupBoxLayouts";
            this.groupBoxLayouts.Size = new System.Drawing.Size(88, 179);
            this.groupBoxLayouts.TabIndex = 2;
            this.groupBoxLayouts.TabStop = false;
            this.groupBoxLayouts.Text = "Select Layout";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.button1x1);
            this.flowLayoutPanel.Controls.Add(this.button2x2);
            this.flowLayoutPanel.Controls.Add(this.button3x3);
            this.flowLayoutPanel.Controls.Add(this.button4x4);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(82, 160);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // button1x1
            // 
            this.button1x1.Location = new System.Drawing.Point(3, 3);
            this.button1x1.Name = "button1x1";
            this.button1x1.Size = new System.Drawing.Size(75, 23);
            this.button1x1.TabIndex = 0;
            this.button1x1.Text = "1x1";
            this.button1x1.UseVisualStyleBackColor = true;
            this.button1x1.Click += new System.EventHandler(this.Button1X1Click);
            // 
            // button2x2
            // 
            this.button2x2.Location = new System.Drawing.Point(3, 32);
            this.button2x2.Name = "button2x2";
            this.button2x2.Size = new System.Drawing.Size(75, 23);
            this.button2x2.TabIndex = 1;
            this.button2x2.Text = "2x2";
            this.button2x2.UseVisualStyleBackColor = true;
            this.button2x2.Click += new System.EventHandler(this.Button2X2Click);
            // 
            // button3x3
            // 
            this.button3x3.Location = new System.Drawing.Point(3, 61);
            this.button3x3.Name = "button3x3";
            this.button3x3.Size = new System.Drawing.Size(75, 23);
            this.button3x3.TabIndex = 2;
            this.button3x3.Text = "3x3";
            this.button3x3.UseVisualStyleBackColor = true;
            this.button3x3.Click += new System.EventHandler(this.Button3X3Click);
            // 
            // button4x4
            // 
            this.button4x4.Location = new System.Drawing.Point(3, 90);
            this.button4x4.Name = "button4x4";
            this.button4x4.Size = new System.Drawing.Size(75, 23);
            this.button4x4.TabIndex = 3;
            this.button4x4.Text = "4x4";
            this.button4x4.UseVisualStyleBackColor = true;
            this.button4x4.Click += new System.EventHandler(this.Button4X4Click);
            // 
            // groupBoxCells
            // 
            this.groupBoxCells.Controls.Add(this.listBoxCells);
            this.groupBoxCells.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCells.Location = new System.Drawing.Point(348, 188);
            this.groupBoxCells.Name = "groupBoxCells";
            this.groupBoxCells.Size = new System.Drawing.Size(88, 92);
            this.groupBoxCells.TabIndex = 3;
            this.groupBoxCells.TabStop = false;
            this.groupBoxCells.Text = "Select Cell";
            // 
            // listBoxCells
            // 
            this.listBoxCells.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCells.FormattingEnabled = true;
            this.listBoxCells.Location = new System.Drawing.Point(3, 16);
            this.listBoxCells.Name = "listBoxCells";
            this.listBoxCells.Size = new System.Drawing.Size(82, 73);
            this.listBoxCells.TabIndex = 0;
            // 
            // groupBoxCameras
            // 
            this.groupBoxCameras.Controls.Add(this.listBoxCameras);
            this.groupBoxCameras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCameras.Location = new System.Drawing.Point(442, 3);
            this.groupBoxCameras.Name = "groupBoxCameras";
            this.tableLayoutPanelMain.SetRowSpan(this.groupBoxCameras, 2);
            this.groupBoxCameras.Size = new System.Drawing.Size(151, 277);
            this.groupBoxCameras.TabIndex = 4;
            this.groupBoxCameras.TabStop = false;
            this.groupBoxCameras.Text = "Select Camera";
            // 
            // listBoxCameras
            // 
            this.listBoxCameras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCameras.FormattingEnabled = true;
            this.listBoxCameras.Location = new System.Drawing.Point(3, 16);
            this.listBoxCameras.Name = "listBoxCameras";
            this.listBoxCameras.Size = new System.Drawing.Size(145, 258);
            this.listBoxCameras.TabIndex = 0;
            // 
            // groupBoxTime
            // 
            this.groupBoxTime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxTime.Controls.Add(this.tableLayoutPanelTime);
            this.groupBoxTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTime.Location = new System.Drawing.Point(599, 3);
            this.groupBoxTime.Name = "groupBoxTime";
            this.tableLayoutPanelMain.SetRowSpan(this.groupBoxTime, 2);
            this.groupBoxTime.Size = new System.Drawing.Size(153, 277);
            this.groupBoxTime.TabIndex = 5;
            this.groupBoxTime.TabStop = false;
            this.groupBoxTime.Text = "Select Time";
            // 
            // tableLayoutPanelTime
            // 
            this.tableLayoutPanelTime.ColumnCount = 2;
            this.tableLayoutPanelTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelTime.Controls.Add(this.labelRecorded, 0, 1);
            this.tableLayoutPanelTime.Controls.Add(this.labelLive, 0, 0);
            this.tableLayoutPanelTime.Controls.Add(this.checkBoxLive, 1, 0);
            this.tableLayoutPanelTime.Controls.Add(this.dateTimePickerRecorded, 0, 2);
            this.tableLayoutPanelTime.Controls.Add(this.buttonShowVideo, 0, 3);
            this.tableLayoutPanelTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTime.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelTime.Name = "tableLayoutPanelTime";
            this.tableLayoutPanelTime.RowCount = 4;
            this.tableLayoutPanelTime.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTime.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTime.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelTime.Size = new System.Drawing.Size(147, 258);
            this.tableLayoutPanelTime.TabIndex = 0;
            // 
            // labelRecorded
            // 
            this.labelRecorded.AutoSize = true;
            this.labelRecorded.Location = new System.Drawing.Point(5, 29);
            this.labelRecorded.Margin = new System.Windows.Forms.Padding(5);
            this.labelRecorded.Name = "labelRecorded";
            this.labelRecorded.Size = new System.Drawing.Size(54, 13);
            this.labelRecorded.TabIndex = 4;
            this.labelRecorded.Text = "Recorded";
            // 
            // labelLive
            // 
            this.labelLive.AutoSize = true;
            this.labelLive.Location = new System.Drawing.Point(5, 5);
            this.labelLive.Margin = new System.Windows.Forms.Padding(5);
            this.labelLive.Name = "labelLive";
            this.labelLive.Size = new System.Drawing.Size(27, 13);
            this.labelLive.TabIndex = 2;
            this.labelLive.Text = "Live";
            // 
            // checkBoxLive
            // 
            this.checkBoxLive.AutoSize = true;
            this.checkBoxLive.Checked = true;
            this.checkBoxLive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLive.Location = new System.Drawing.Point(69, 5);
            this.checkBoxLive.Margin = new System.Windows.Forms.Padding(5);
            this.checkBoxLive.Name = "checkBoxLive";
            this.checkBoxLive.Size = new System.Drawing.Size(15, 14);
            this.checkBoxLive.TabIndex = 3;
            this.checkBoxLive.UseVisualStyleBackColor = true;
            this.checkBoxLive.CheckedChanged += new System.EventHandler(this.CheckBoxLiveCheckedChanged);
            // 
            // dateTimePickerRecorded
            // 
            this.tableLayoutPanelTime.SetColumnSpan(this.dateTimePickerRecorded, 2);
            this.dateTimePickerRecorded.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerRecorded.Enabled = false;
            this.dateTimePickerRecorded.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerRecorded.Location = new System.Drawing.Point(3, 50);
            this.dateTimePickerRecorded.Name = "dateTimePickerRecorded";
            this.dateTimePickerRecorded.Size = new System.Drawing.Size(141, 20);
            this.dateTimePickerRecorded.TabIndex = 5;
            // 
            // buttonShowVideo
            // 
            this.tableLayoutPanelTime.SetColumnSpan(this.buttonShowVideo, 2);
            this.buttonShowVideo.Location = new System.Drawing.Point(3, 76);
            this.buttonShowVideo.Name = "buttonShowVideo";
            this.buttonShowVideo.Size = new System.Drawing.Size(141, 53);
            this.buttonShowVideo.TabIndex = 6;
            this.buttonShowVideo.Text = "Show Video";
            this.buttonShowVideo.UseVisualStyleBackColor = true;
            this.buttonShowVideo.Click += new System.EventHandler(this.ButtonShowVideoClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 283);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.MinimumSize = new System.Drawing.Size(771, 322);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VxSdk.Net Monitor Example";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.groupBoxMonitors.ResumeLayout(false);
            this.groupBoxLogin.ResumeLayout(false);
            this.tableLayoutPanelLoginInfo.ResumeLayout(false);
            this.tableLayoutPanelLoginInfo.PerformLayout();
            this.groupBoxLayouts.ResumeLayout(false);
            this.flowLayoutPanel.ResumeLayout(false);
            this.groupBoxCells.ResumeLayout(false);
            this.groupBoxCameras.ResumeLayout(false);
            this.groupBoxTime.ResumeLayout(false);
            this.tableLayoutPanelTime.ResumeLayout(false);
            this.tableLayoutPanelTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.GroupBox groupBoxMonitors;
        private System.Windows.Forms.ListBox listBoxMonitors;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLoginInfo;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxIp;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.GroupBox groupBoxLayouts;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button button1x1;
        private System.Windows.Forms.Button button2x2;
        private System.Windows.Forms.Button button3x3;
        private System.Windows.Forms.Button button4x4;
        private System.Windows.Forms.GroupBox groupBoxCells;
        private System.Windows.Forms.ListBox listBoxCells;
        private System.Windows.Forms.GroupBox groupBoxCameras;
        private System.Windows.Forms.ListBox listBoxCameras;
        private System.Windows.Forms.GroupBox groupBoxTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTime;
        private System.Windows.Forms.Label labelRecorded;
        private System.Windows.Forms.Label labelLive;
        private System.Windows.Forms.CheckBox checkBoxLive;
        private System.Windows.Forms.DateTimePicker dateTimePickerRecorded;
        private System.Windows.Forms.Button buttonShowVideo;
    }
}

