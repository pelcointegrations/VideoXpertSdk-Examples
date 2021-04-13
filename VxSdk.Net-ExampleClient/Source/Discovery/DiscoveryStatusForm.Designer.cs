namespace ExampleClient.Source
{
    partial class DiscoveryStatusForm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.lblIsIsnitializingTitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblIsDiscoveringTitle = new System.Windows.Forms.Label();
            this.lblInitiatedTitle = new System.Windows.Forms.Label();
            this.lblInitializedTitle = new System.Windows.Forms.Label();
            this.lblDiscoveredTitle = new System.Windows.Forms.Label();
            this.lblInitializationErrorsTitle = new System.Windows.Forms.Label();
            this.lblInitializationErrors = new System.Windows.Forms.Label();
            this.lblDiscovered = new System.Windows.Forms.Label();
            this.lblInitialized = new System.Windows.Forms.Label();
            this.lblInitiated = new System.Windows.Forms.Label();
            this.lblIsDiscovering = new System.Windows.Forms.Label();
            this.lblIsInitializing = new System.Windows.Forms.Label();
            this.btnTrigger = new System.Windows.Forms.Button();
            this.rbDiscoverByHost = new System.Windows.Forms.RadioButton();
            this.rbQuickDiscovery = new System.Windows.Forms.RadioButton();
            this.gbxDiscoverByHost = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lvDeviceSearch = new System.Windows.Forms.ListView();
            this.chSelection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDriverType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxQuickDiscovery = new System.Windows.Forms.GroupBox();
            this.lblStartingAddress = new System.Windows.Forms.Label();
            this.lblEndingAddress = new System.Windows.Forms.Label();
            this.tbxStartingAddress = new System.Windows.Forms.TextBox();
            this.chbxSsdp = new System.Windows.Forms.CheckBox();
            this.chbxWsDiscovery = new System.Windows.Forms.CheckBox();
            this.tbxEndingAddress = new System.Windows.Forms.TextBox();
            this.chbxExtend = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbxDiscoverByHost.SuspendLayout();
            this.gbxQuickDiscovery.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(500, 461);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(57, 23);
            this.btnOk.TabIndex = 31;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // lblIsIsnitializingTitle
            // 
            this.lblIsIsnitializingTitle.AutoSize = true;
            this.lblIsIsnitializingTitle.Location = new System.Drawing.Point(181, 16);
            this.lblIsIsnitializingTitle.Name = "lblIsIsnitializingTitle";
            this.lblIsIsnitializingTitle.Size = new System.Drawing.Size(66, 13);
            this.lblIsIsnitializingTitle.TabIndex = 33;
            this.lblIsIsnitializingTitle.Text = "Is Initializing:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(212, 11);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 34;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(244, 71);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(57, 23);
            this.btnRefresh.TabIndex = 36;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // lblIsDiscoveringTitle
            // 
            this.lblIsDiscoveringTitle.AutoSize = true;
            this.lblIsDiscoveringTitle.Location = new System.Drawing.Point(20, 16);
            this.lblIsDiscoveringTitle.Name = "lblIsDiscoveringTitle";
            this.lblIsDiscoveringTitle.Size = new System.Drawing.Size(77, 13);
            this.lblIsDiscoveringTitle.TabIndex = 37;
            this.lblIsDiscoveringTitle.Text = "Is Discovering:";
            // 
            // lblInitiatedTitle
            // 
            this.lblInitiatedTitle.AutoSize = true;
            this.lblInitiatedTitle.Location = new System.Drawing.Point(321, 16);
            this.lblInitiatedTitle.Name = "lblInitiatedTitle";
            this.lblInitiatedTitle.Size = new System.Drawing.Size(73, 13);
            this.lblInitiatedTitle.TabIndex = 38;
            this.lblInitiatedTitle.Text = "Time Initiated:";
            // 
            // lblInitializedTitle
            // 
            this.lblInitializedTitle.AutoSize = true;
            this.lblInitializedTitle.Location = new System.Drawing.Point(228, 47);
            this.lblInitializedTitle.Name = "lblInitializedTitle";
            this.lblInitializedTitle.Size = new System.Drawing.Size(53, 13);
            this.lblInitializedTitle.TabIndex = 39;
            this.lblInitializedTitle.Text = "Initialized:";
            // 
            // lblDiscoveredTitle
            // 
            this.lblDiscoveredTitle.AutoSize = true;
            this.lblDiscoveredTitle.Location = new System.Drawing.Point(25, 47);
            this.lblDiscoveredTitle.Name = "lblDiscoveredTitle";
            this.lblDiscoveredTitle.Size = new System.Drawing.Size(64, 13);
            this.lblDiscoveredTitle.TabIndex = 40;
            this.lblDiscoveredTitle.Text = "Discovered:";
            // 
            // lblInitializationErrorsTitle
            // 
            this.lblInitializationErrorsTitle.AutoSize = true;
            this.lblInitializationErrorsTitle.Location = new System.Drawing.Point(395, 47);
            this.lblInitializationErrorsTitle.Name = "lblInitializationErrorsTitle";
            this.lblInitializationErrorsTitle.Size = new System.Drawing.Size(94, 13);
            this.lblInitializationErrorsTitle.TabIndex = 41;
            this.lblInitializationErrorsTitle.Text = "Initialization Errors:";
            // 
            // lblInitializationErrors
            // 
            this.lblInitializationErrors.AutoSize = true;
            this.lblInitializationErrors.Location = new System.Drawing.Point(495, 47);
            this.lblInitializationErrors.Name = "lblInitializationErrors";
            this.lblInitializationErrors.Size = new System.Drawing.Size(25, 13);
            this.lblInitializationErrors.TabIndex = 47;
            this.lblInitializationErrors.Text = "000";
            // 
            // lblDiscovered
            // 
            this.lblDiscovered.AutoSize = true;
            this.lblDiscovered.Location = new System.Drawing.Point(95, 47);
            this.lblDiscovered.Name = "lblDiscovered";
            this.lblDiscovered.Size = new System.Drawing.Size(25, 13);
            this.lblDiscovered.TabIndex = 46;
            this.lblDiscovered.Text = "000";
            // 
            // lblInitialized
            // 
            this.lblInitialized.AutoSize = true;
            this.lblInitialized.Location = new System.Drawing.Point(287, 47);
            this.lblInitialized.Name = "lblInitialized";
            this.lblInitialized.Size = new System.Drawing.Size(25, 13);
            this.lblInitialized.TabIndex = 45;
            this.lblInitialized.Text = "000";
            // 
            // lblInitiated
            // 
            this.lblInitiated.AutoSize = true;
            this.lblInitiated.Location = new System.Drawing.Point(400, 16);
            this.lblInitiated.Name = "lblInitiated";
            this.lblInitiated.Size = new System.Drawing.Size(125, 13);
            this.lblInitiated.TabIndex = 44;
            this.lblInitiated.Text = "0000-00-00 00:00:00 AM";
            // 
            // lblIsDiscovering
            // 
            this.lblIsDiscovering.AutoSize = true;
            this.lblIsDiscovering.Location = new System.Drawing.Point(107, 16);
            this.lblIsDiscovering.Name = "lblIsDiscovering";
            this.lblIsDiscovering.Size = new System.Drawing.Size(32, 13);
            this.lblIsDiscovering.TabIndex = 43;
            this.lblIsDiscovering.Text = "False";
            // 
            // lblIsInitializing
            // 
            this.lblIsInitializing.AutoSize = true;
            this.lblIsInitializing.Location = new System.Drawing.Point(257, 16);
            this.lblIsInitializing.Name = "lblIsInitializing";
            this.lblIsInitializing.Size = new System.Drawing.Size(32, 13);
            this.lblIsInitializing.TabIndex = 42;
            this.lblIsInitializing.Text = "False";
            // 
            // btnTrigger
            // 
            this.btnTrigger.Location = new System.Drawing.Point(475, 24);
            this.btnTrigger.Name = "btnTrigger";
            this.btnTrigger.Size = new System.Drawing.Size(57, 23);
            this.btnTrigger.TabIndex = 48;
            this.btnTrigger.Text = "Trigger";
            this.btnTrigger.UseVisualStyleBackColor = true;
            this.btnTrigger.Click += new System.EventHandler(this.ButtonTrigger_Click);
            // 
            // rbDiscoverByHost
            // 
            this.rbDiscoverByHost.AutoSize = true;
            this.rbDiscoverByHost.Location = new System.Drawing.Point(303, 27);
            this.rbDiscoverByHost.Name = "rbDiscoverByHost";
            this.rbDiscoverByHost.Size = new System.Drawing.Size(157, 17);
            this.rbDiscoverByHost.TabIndex = 59;
            this.rbDiscoverByHost.Text = "Discover by IP or Hostname";
            this.rbDiscoverByHost.UseVisualStyleBackColor = true;
            this.rbDiscoverByHost.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbQuickDiscovery
            // 
            this.rbQuickDiscovery.AutoSize = true;
            this.rbQuickDiscovery.Checked = true;
            this.rbQuickDiscovery.Location = new System.Drawing.Point(185, 27);
            this.rbQuickDiscovery.Name = "rbQuickDiscovery";
            this.rbQuickDiscovery.Size = new System.Drawing.Size(103, 17);
            this.rbQuickDiscovery.TabIndex = 58;
            this.rbQuickDiscovery.TabStop = true;
            this.rbQuickDiscovery.Text = "Quick Discovery";
            this.rbQuickDiscovery.UseVisualStyleBackColor = true;
            this.rbQuickDiscovery.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // gbxDiscoverByHost
            // 
            this.gbxDiscoverByHost.Controls.Add(this.btnRemove);
            this.gbxDiscoverByHost.Controls.Add(this.lvDeviceSearch);
            this.gbxDiscoverByHost.Controls.Add(this.btnAdd);
            this.gbxDiscoverByHost.Enabled = false;
            this.gbxDiscoverByHost.Location = new System.Drawing.Point(9, 162);
            this.gbxDiscoverByHost.Name = "gbxDiscoverByHost";
            this.gbxDiscoverByHost.Size = new System.Drawing.Size(523, 169);
            this.gbxDiscoverByHost.TabIndex = 57;
            this.gbxDiscoverByHost.TabStop = false;
            this.gbxDiscoverByHost.Text = "Discover by IP or Hostname";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(195, 140);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(63, 23);
            this.btnRemove.TabIndex = 24;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // lvDeviceSearch
            // 
            this.lvDeviceSearch.CheckBoxes = true;
            this.lvDeviceSearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSelection,
            this.chHost,
            this.chPort,
            this.chUsername,
            this.chPassword,
            this.chDriverType});
            this.lvDeviceSearch.FullRowSelect = true;
            this.lvDeviceSearch.GridLines = true;
            this.lvDeviceSearch.HideSelection = false;
            this.lvDeviceSearch.Location = new System.Drawing.Point(7, 19);
            this.lvDeviceSearch.MultiSelect = false;
            this.lvDeviceSearch.Name = "lvDeviceSearch";
            this.lvDeviceSearch.Size = new System.Drawing.Size(507, 116);
            this.lvDeviceSearch.TabIndex = 0;
            this.lvDeviceSearch.UseCompatibleStateImageBehavior = false;
            this.lvDeviceSearch.View = System.Windows.Forms.View.Details;
            // 
            // chSelection
            // 
            this.chSelection.Text = "";
            this.chSelection.Width = 24;
            // 
            // chHost
            // 
            this.chHost.Text = "Host";
            this.chHost.Width = 88;
            // 
            // chPort
            // 
            this.chPort.Text = "Port";
            // 
            // chUsername
            // 
            this.chUsername.Text = "Username";
            this.chUsername.Width = 100;
            // 
            // chPassword
            // 
            this.chPassword.Text = "Password";
            this.chPassword.Width = 95;
            // 
            // chDriverType
            // 
            this.chDriverType.Text = "Driver Type";
            this.chDriverType.Width = 135;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(264, 140);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(63, 23);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // gbxQuickDiscovery
            // 
            this.gbxQuickDiscovery.Controls.Add(this.lblStartingAddress);
            this.gbxQuickDiscovery.Controls.Add(this.lblEndingAddress);
            this.gbxQuickDiscovery.Controls.Add(this.tbxStartingAddress);
            this.gbxQuickDiscovery.Controls.Add(this.chbxSsdp);
            this.gbxQuickDiscovery.Controls.Add(this.chbxWsDiscovery);
            this.gbxQuickDiscovery.Controls.Add(this.tbxEndingAddress);
            this.gbxQuickDiscovery.Location = new System.Drawing.Point(9, 59);
            this.gbxQuickDiscovery.Name = "gbxQuickDiscovery";
            this.gbxQuickDiscovery.Size = new System.Drawing.Size(523, 87);
            this.gbxQuickDiscovery.TabIndex = 56;
            this.gbxQuickDiscovery.TabStop = false;
            this.gbxQuickDiscovery.Text = "Quick Discovery";
            // 
            // lblStartingAddress
            // 
            this.lblStartingAddress.AutoSize = true;
            this.lblStartingAddress.Location = new System.Drawing.Point(53, 60);
            this.lblStartingAddress.Name = "lblStartingAddress";
            this.lblStartingAddress.Size = new System.Drawing.Size(97, 13);
            this.lblStartingAddress.TabIndex = 53;
            this.lblStartingAddress.Text = "IP Starting Address";
            // 
            // lblEndingAddress
            // 
            this.lblEndingAddress.AutoSize = true;
            this.lblEndingAddress.Location = new System.Drawing.Point(270, 60);
            this.lblEndingAddress.Name = "lblEndingAddress";
            this.lblEndingAddress.Size = new System.Drawing.Size(94, 13);
            this.lblEndingAddress.TabIndex = 54;
            this.lblEndingAddress.Text = "IP Ending Address";
            // 
            // tbxStartingAddress
            // 
            this.tbxStartingAddress.Location = new System.Drawing.Point(159, 57);
            this.tbxStartingAddress.Name = "tbxStartingAddress";
            this.tbxStartingAddress.Size = new System.Drawing.Size(100, 20);
            this.tbxStartingAddress.TabIndex = 36;
            // 
            // chbxSsdp
            // 
            this.chbxSsdp.AutoSize = true;
            this.chbxSsdp.Checked = true;
            this.chbxSsdp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbxSsdp.Location = new System.Drawing.Point(173, 19);
            this.chbxSsdp.Name = "chbxSsdp";
            this.chbxSsdp.Size = new System.Drawing.Size(55, 17);
            this.chbxSsdp.TabIndex = 33;
            this.chbxSsdp.Text = "SSDP";
            this.chbxSsdp.UseVisualStyleBackColor = true;
            // 
            // chbxWsDiscovery
            // 
            this.chbxWsDiscovery.AutoSize = true;
            this.chbxWsDiscovery.Checked = true;
            this.chbxWsDiscovery.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbxWsDiscovery.Location = new System.Drawing.Point(256, 19);
            this.chbxWsDiscovery.Name = "chbxWsDiscovery";
            this.chbxWsDiscovery.Size = new System.Drawing.Size(94, 17);
            this.chbxWsDiscovery.TabIndex = 34;
            this.chbxWsDiscovery.Text = "WS-Discovery";
            this.chbxWsDiscovery.UseVisualStyleBackColor = true;
            // 
            // tbxEndingAddress
            // 
            this.tbxEndingAddress.Location = new System.Drawing.Point(370, 57);
            this.tbxEndingAddress.Name = "tbxEndingAddress";
            this.tbxEndingAddress.Size = new System.Drawing.Size(100, 20);
            this.tbxEndingAddress.TabIndex = 35;
            // 
            // chbxExtend
            // 
            this.chbxExtend.AutoSize = true;
            this.chbxExtend.Location = new System.Drawing.Point(17, 28);
            this.chbxExtend.Name = "chbxExtend";
            this.chbxExtend.Size = new System.Drawing.Size(153, 17);
            this.chbxExtend.TabIndex = 55;
            this.chbxExtend.Text = "Extend Previous Discovery";
            this.chbxExtend.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblInitiated);
            this.groupBox1.Controls.Add(this.lblInitiatedTitle);
            this.groupBox1.Controls.Add(this.lblIsDiscovering);
            this.groupBox1.Controls.Add(this.lblIsDiscoveringTitle);
            this.groupBox1.Controls.Add(this.lblIsIsnitializingTitle);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lblIsInitializing);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.lblInitializationErrors);
            this.groupBox1.Controls.Add(this.lblDiscoveredTitle);
            this.groupBox1.Controls.Add(this.lblInitializationErrorsTitle);
            this.groupBox1.Controls.Add(this.lblInitialized);
            this.groupBox1.Controls.Add(this.lblDiscovered);
            this.groupBox1.Controls.Add(this.lblInitializedTitle);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 100);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Status";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gbxQuickDiscovery);
            this.groupBox2.Controls.Add(this.chbxExtend);
            this.groupBox2.Controls.Add(this.btnTrigger);
            this.groupBox2.Controls.Add(this.rbDiscoverByHost);
            this.groupBox2.Controls.Add(this.gbxDiscoverByHost);
            this.groupBox2.Controls.Add(this.rbQuickDiscovery);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 337);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Discovery Settings";
            // 
            // DiscoveryStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiscoveryStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Device Discovery Status";
            this.gbxDiscoverByHost.ResumeLayout(false);
            this.gbxQuickDiscovery.ResumeLayout(false);
            this.gbxQuickDiscovery.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblIsIsnitializingTitle;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblIsDiscoveringTitle;
        private System.Windows.Forms.Label lblInitiatedTitle;
        private System.Windows.Forms.Label lblInitializedTitle;
        private System.Windows.Forms.Label lblDiscoveredTitle;
        private System.Windows.Forms.Label lblInitializationErrorsTitle;
        private System.Windows.Forms.Label lblInitializationErrors;
        private System.Windows.Forms.Label lblDiscovered;
        private System.Windows.Forms.Label lblInitialized;
        private System.Windows.Forms.Label lblInitiated;
        private System.Windows.Forms.Label lblIsDiscovering;
        private System.Windows.Forms.Label lblIsInitializing;
        private System.Windows.Forms.Button btnTrigger;
        private System.Windows.Forms.RadioButton rbDiscoverByHost;
        private System.Windows.Forms.RadioButton rbQuickDiscovery;
        private System.Windows.Forms.GroupBox gbxDiscoverByHost;
        private System.Windows.Forms.Button btnRemove;
        public System.Windows.Forms.ListView lvDeviceSearch;
        private System.Windows.Forms.ColumnHeader chSelection;
        private System.Windows.Forms.ColumnHeader chHost;
        private System.Windows.Forms.ColumnHeader chPort;
        private System.Windows.Forms.ColumnHeader chUsername;
        private System.Windows.Forms.ColumnHeader chPassword;
        private System.Windows.Forms.ColumnHeader chDriverType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxQuickDiscovery;
        private System.Windows.Forms.Label lblStartingAddress;
        private System.Windows.Forms.Label lblEndingAddress;
        private System.Windows.Forms.TextBox tbxStartingAddress;
        private System.Windows.Forms.CheckBox chbxSsdp;
        private System.Windows.Forms.CheckBox chbxWsDiscovery;
        private System.Windows.Forms.TextBox tbxEndingAddress;
        private System.Windows.Forms.CheckBox chbxExtend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}