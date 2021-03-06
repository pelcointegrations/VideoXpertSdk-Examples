﻿namespace ExampleClient.Source
{
    partial class DeviceManagerForm
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvDevices = new System.Windows.Forms.ListView();
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDriver = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCommissioned = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCommission = new System.Windows.Forms.Button();
            this.btnDecommission = new System.Windows.Forms.Button();
            this.btnManageLogs = new System.Windows.Forms.Button();
            this.btnSilence = new System.Windows.Forms.Button();
            this.btnDiagnostics = new System.Windows.Forms.Button();
            this.btnLicenseInfo = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDbBackups = new System.Windows.Forms.Button();
            this.btnLimits = new System.Windows.Forms.Button();
            this.btnTimeConfig = new System.Windows.Forms.Button();
            this.btnUpdateSoftware = new System.Windows.Forms.Button();
            this.btnThermalEtd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1213, 447);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 23);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(1213, 70);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(83, 23);
            this.btnModify.TabIndex = 11;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.ButtonModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1213, 41);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1213, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add Device";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // lvDevices
            // 
            this.lvDevices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chType,
            this.chName,
            this.chIp,
            this.chPort,
            this.chId,
            this.chModel,
            this.chState,
            this.chDriver,
            this.chVersion,
            this.chCommissioned});
            this.lvDevices.FullRowSelect = true;
            this.lvDevices.HideSelection = false;
            this.lvDevices.Location = new System.Drawing.Point(12, 12);
            this.lvDevices.MultiSelect = false;
            this.lvDevices.Name = "lvDevices";
            this.lvDevices.Size = new System.Drawing.Size(1195, 458);
            this.lvDevices.TabIndex = 8;
            this.lvDevices.UseCompatibleStateImageBehavior = false;
            this.lvDevices.View = System.Windows.Forms.View.Details;
            this.lvDevices.SelectedIndexChanged += new System.EventHandler(this.ListViewDevices_SelectedIndexChanged);
            // 
            // chType
            // 
            this.chType.Text = "Type";
            this.chType.Width = 100;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 186;
            // 
            // chIp
            // 
            this.chIp.Text = "IP";
            this.chIp.Width = 120;
            // 
            // chPort
            // 
            this.chPort.Text = "Port";
            this.chPort.Width = 50;
            // 
            // chId
            // 
            this.chId.Text = "ID";
            this.chId.Width = 274;
            // 
            // chModel
            // 
            this.chModel.Text = "Model";
            this.chModel.Width = 94;
            // 
            // chState
            // 
            this.chState.Text = "State";
            // 
            // chDriver
            // 
            this.chDriver.Text = "Driver";
            this.chDriver.Width = 90;
            // 
            // chVersion
            // 
            this.chVersion.Text = "Version";
            this.chVersion.Width = 137;
            // 
            // chCommissioned
            // 
            this.chCommissioned.Text = "Commissioned";
            this.chCommissioned.Width = 79;
            // 
            // btnCommission
            // 
            this.btnCommission.Location = new System.Drawing.Point(1213, 99);
            this.btnCommission.Name = "btnCommission";
            this.btnCommission.Size = new System.Drawing.Size(83, 23);
            this.btnCommission.TabIndex = 14;
            this.btnCommission.Text = "Commission";
            this.btnCommission.UseVisualStyleBackColor = true;
            this.btnCommission.Click += new System.EventHandler(this.ButtonCommission_Click);
            // 
            // btnDecommission
            // 
            this.btnDecommission.Location = new System.Drawing.Point(1213, 128);
            this.btnDecommission.Name = "btnDecommission";
            this.btnDecommission.Size = new System.Drawing.Size(83, 23);
            this.btnDecommission.TabIndex = 15;
            this.btnDecommission.Text = "Decommission";
            this.btnDecommission.UseVisualStyleBackColor = true;
            this.btnDecommission.Click += new System.EventHandler(this.ButtonDecommission_Click);
            // 
            // btnManageLogs
            // 
            this.btnManageLogs.Enabled = false;
            this.btnManageLogs.Location = new System.Drawing.Point(1213, 157);
            this.btnManageLogs.Name = "btnManageLogs";
            this.btnManageLogs.Size = new System.Drawing.Size(83, 23);
            this.btnManageLogs.TabIndex = 18;
            this.btnManageLogs.Text = "Manage Logs";
            this.btnManageLogs.UseVisualStyleBackColor = true;
            this.btnManageLogs.Click += new System.EventHandler(this.ButtonManageLogs_Click);
            // 
            // btnSilence
            // 
            this.btnSilence.Location = new System.Drawing.Point(1213, 186);
            this.btnSilence.Name = "btnSilence";
            this.btnSilence.Size = new System.Drawing.Size(83, 23);
            this.btnSilence.TabIndex = 19;
            this.btnSilence.Text = "Silence";
            this.btnSilence.UseVisualStyleBackColor = true;
            this.btnSilence.Click += new System.EventHandler(this.ButtonSilence_Click);
            // 
            // btnDiagnostics
            // 
            this.btnDiagnostics.Enabled = false;
            this.btnDiagnostics.Location = new System.Drawing.Point(1213, 215);
            this.btnDiagnostics.Name = "btnDiagnostics";
            this.btnDiagnostics.Size = new System.Drawing.Size(83, 23);
            this.btnDiagnostics.TabIndex = 20;
            this.btnDiagnostics.Text = "Diagnostics";
            this.btnDiagnostics.UseVisualStyleBackColor = true;
            this.btnDiagnostics.Click += new System.EventHandler(this.ButtonDiagnostics_Click);
            // 
            // btnLicenseInfo
            // 
            this.btnLicenseInfo.Enabled = false;
            this.btnLicenseInfo.Location = new System.Drawing.Point(1213, 273);
            this.btnLicenseInfo.Name = "btnLicenseInfo";
            this.btnLicenseInfo.Size = new System.Drawing.Size(83, 23);
            this.btnLicenseInfo.TabIndex = 21;
            this.btnLicenseInfo.Text = "License Info";
            this.btnLicenseInfo.UseVisualStyleBackColor = true;
            this.btnLicenseInfo.Click += new System.EventHandler(this.ButtonLicenseInfo_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1213, 331);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 23);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // btnDbBackups
            // 
            this.btnDbBackups.Enabled = false;
            this.btnDbBackups.Location = new System.Drawing.Point(1213, 302);
            this.btnDbBackups.Name = "btnDbBackups";
            this.btnDbBackups.Size = new System.Drawing.Size(83, 23);
            this.btnDbBackups.TabIndex = 23;
            this.btnDbBackups.Text = "DB Backups";
            this.btnDbBackups.UseVisualStyleBackColor = true;
            this.btnDbBackups.Click += new System.EventHandler(this.ButtonDbBackups_Click);
            // 
            // btnLimits
            // 
            this.btnLimits.Location = new System.Drawing.Point(1213, 244);
            this.btnLimits.Name = "btnLimits";
            this.btnLimits.Size = new System.Drawing.Size(83, 23);
            this.btnLimits.TabIndex = 24;
            this.btnLimits.Text = "Limits";
            this.btnLimits.UseVisualStyleBackColor = true;
            this.btnLimits.Click += new System.EventHandler(this.ButtonLimits_Click);
            // 
            // btnTimeConfig
            // 
            this.btnTimeConfig.Enabled = false;
            this.btnTimeConfig.Location = new System.Drawing.Point(1213, 389);
            this.btnTimeConfig.Name = "btnTimeConfig";
            this.btnTimeConfig.Size = new System.Drawing.Size(83, 23);
            this.btnTimeConfig.TabIndex = 25;
            this.btnTimeConfig.Text = "Time Config";
            this.btnTimeConfig.UseVisualStyleBackColor = true;
            this.btnTimeConfig.Click += new System.EventHandler(this.ButtonTimeConfig_Click);
            // 
            // btnUpdateSoftware
            // 
            this.btnUpdateSoftware.Location = new System.Drawing.Point(1213, 418);
            this.btnUpdateSoftware.Name = "btnUpdateSoftware";
            this.btnUpdateSoftware.Size = new System.Drawing.Size(83, 23);
            this.btnUpdateSoftware.TabIndex = 26;
            this.btnUpdateSoftware.Text = "Update SW";
            this.btnUpdateSoftware.UseVisualStyleBackColor = true;
            this.btnUpdateSoftware.Click += new System.EventHandler(this.ButtonUpdateSoftware_Click);
            // 
            // btnThermalEtd
            // 
            this.btnThermalEtd.Enabled = false;
            this.btnThermalEtd.Location = new System.Drawing.Point(1213, 360);
            this.btnThermalEtd.Name = "btnThermalEtd";
            this.btnThermalEtd.Size = new System.Drawing.Size(83, 23);
            this.btnThermalEtd.TabIndex = 27;
            this.btnThermalEtd.Text = "Thermal ETD";
            this.btnThermalEtd.UseVisualStyleBackColor = true;
            this.btnThermalEtd.Click += new System.EventHandler(this.ButtonThermalEtd_Click);
            // 
            // DeviceManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 474);
            this.Controls.Add(this.btnThermalEtd);
            this.Controls.Add(this.btnUpdateSoftware);
            this.Controls.Add(this.btnTimeConfig);
            this.Controls.Add(this.btnLimits);
            this.Controls.Add(this.btnDbBackups);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnLicenseInfo);
            this.Controls.Add(this.btnDiagnostics);
            this.Controls.Add(this.btnSilence);
            this.Controls.Add(this.btnManageLogs);
            this.Controls.Add(this.btnDecommission);
            this.Controls.Add(this.btnCommission);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvDevices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeviceManagerForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Device Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvDevices;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chModel;
        private System.Windows.Forms.ColumnHeader chState;
        private System.Windows.Forms.ColumnHeader chVersion;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader chIp;
        private System.Windows.Forms.ColumnHeader chCommissioned;
        private System.Windows.Forms.Button btnCommission;
        private System.Windows.Forms.Button btnDecommission;
        private System.Windows.Forms.Button btnManageLogs;
        private System.Windows.Forms.Button btnSilence;
        private System.Windows.Forms.ColumnHeader chPort;
        private System.Windows.Forms.ColumnHeader chDriver;
        private System.Windows.Forms.Button btnDiagnostics;
        private System.Windows.Forms.Button btnLicenseInfo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDbBackups;
        private System.Windows.Forms.Button btnLimits;
        private System.Windows.Forms.Button btnTimeConfig;
        private System.Windows.Forms.Button btnUpdateSoftware;
        private System.Windows.Forms.Button btnThermalEtd;
    }
}