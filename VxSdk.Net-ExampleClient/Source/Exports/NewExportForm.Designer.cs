using System;

namespace ExampleClient.Source
{
    partial class NewExportForm
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
            this.btnAddClip = new System.Windows.Forms.Button();
            this.btnRemoveClip = new System.Windows.Forms.Button();
            this.lvDataSources = new System.Windows.Forms.ListView();
            this.colHeadName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvAvailableClips = new System.Windows.Forms.ListView();
            this.colHeadType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadEndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvAddedClips = new System.Windows.Forms.ListView();
            this.colHeadAddType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadAddStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadAddEndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxName = new System.Windows.Forms.GroupBox();
            this.tbxExportName = new System.Windows.Forms.TextBox();
            this.gbxPassword = new System.Windows.Forms.GroupBox();
            this.tbxExportPassword = new System.Windows.Forms.TextBox();
            this.btnEstimateExport = new System.Windows.Forms.Button();
            this.gbxExportEstimate = new System.Windows.Forms.GroupBox();
            this.lblSizeValue = new System.Windows.Forms.Label();
            this.lblTooLargeValue = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblTooLarge = new System.Windows.Forms.Label();
            this.gbxName.SuspendLayout();
            this.gbxPassword.SuspendLayout();
            this.gbxExportEstimate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddClip
            // 
            this.btnAddClip.Location = new System.Drawing.Point(670, 173);
            this.btnAddClip.Name = "btnAddClip";
            this.btnAddClip.Size = new System.Drawing.Size(75, 23);
            this.btnAddClip.TabIndex = 5;
            this.btnAddClip.Text = "Add >>";
            this.btnAddClip.UseVisualStyleBackColor = true;
            this.btnAddClip.Click += new System.EventHandler(this.ButtonAddClip_Click);
            // 
            // btnRemoveClip
            // 
            this.btnRemoveClip.Location = new System.Drawing.Point(670, 202);
            this.btnRemoveClip.Name = "btnRemoveClip";
            this.btnRemoveClip.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveClip.TabIndex = 11;
            this.btnRemoveClip.Text = "<< Remove";
            this.btnRemoveClip.UseVisualStyleBackColor = true;
            this.btnRemoveClip.Click += new System.EventHandler(this.ButtonRemoveClip_Click);
            // 
            // lvDataSources
            // 
            this.lvDataSources.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadName});
            this.lvDataSources.HideSelection = false;
            this.lvDataSources.Location = new System.Drawing.Point(12, 13);
            this.lvDataSources.MultiSelect = false;
            this.lvDataSources.Name = "lvDataSources";
            this.lvDataSources.Size = new System.Drawing.Size(210, 345);
            this.lvDataSources.TabIndex = 15;
            this.lvDataSources.UseCompatibleStateImageBehavior = false;
            this.lvDataSources.View = System.Windows.Forms.View.Details;
            this.lvDataSources.SelectedIndexChanged += new System.EventHandler(this.ListViewDevices_ItemSelected);
            // 
            // colHeadName
            // 
            this.colHeadName.Text = "Name";
            this.colHeadName.Width = 206;
            // 
            // lvAvailableClips
            // 
            this.lvAvailableClips.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadType,
            this.colHeadStartTime,
            this.colHeadEndTime});
            this.lvAvailableClips.HideSelection = false;
            this.lvAvailableClips.Location = new System.Drawing.Point(228, 13);
            this.lvAvailableClips.MultiSelect = false;
            this.lvAvailableClips.Name = "lvAvailableClips";
            this.lvAvailableClips.Size = new System.Drawing.Size(436, 345);
            this.lvAvailableClips.TabIndex = 16;
            this.lvAvailableClips.UseCompatibleStateImageBehavior = false;
            this.lvAvailableClips.View = System.Windows.Forms.View.Details;
            // 
            // colHeadType
            // 
            this.colHeadType.Text = "Type";
            this.colHeadType.Width = 112;
            // 
            // colHeadStartTime
            // 
            this.colHeadStartTime.Text = "Start Time";
            this.colHeadStartTime.Width = 160;
            // 
            // colHeadEndTime
            // 
            this.colHeadEndTime.Text = "End Time";
            this.colHeadEndTime.Width = 160;
            // 
            // lvAddedClips
            // 
            this.lvAddedClips.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadAddType,
            this.colHeadAddStartTime,
            this.colHeadAddEndTime});
            this.lvAddedClips.HideSelection = false;
            this.lvAddedClips.Location = new System.Drawing.Point(753, 13);
            this.lvAddedClips.MultiSelect = false;
            this.lvAddedClips.Name = "lvAddedClips";
            this.lvAddedClips.Size = new System.Drawing.Size(436, 345);
            this.lvAddedClips.TabIndex = 17;
            this.lvAddedClips.UseCompatibleStateImageBehavior = false;
            this.lvAddedClips.View = System.Windows.Forms.View.Details;
            // 
            // colHeadAddType
            // 
            this.colHeadAddType.Text = "Type";
            this.colHeadAddType.Width = 112;
            // 
            // colHeadAddStartTime
            // 
            this.colHeadAddStartTime.Text = "Start Time";
            this.colHeadAddStartTime.Width = 160;
            // 
            // colHeadAddEndTime
            // 
            this.colHeadAddEndTime.Text = "End Time";
            this.colHeadAddEndTime.Width = 160;
            // 
            // btnExport
            // 
            this.btnExport.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnExport.Location = new System.Drawing.Point(1379, 335);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 18;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.ButtonExport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(1195, 335);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // gbxName
            // 
            this.gbxName.Controls.Add(this.tbxExportName);
            this.gbxName.Location = new System.Drawing.Point(1195, 13);
            this.gbxName.Name = "gbxName";
            this.gbxName.Size = new System.Drawing.Size(260, 51);
            this.gbxName.TabIndex = 20;
            this.gbxName.TabStop = false;
            this.gbxName.Text = "Export Name";
            // 
            // tbxExportName
            // 
            this.tbxExportName.Location = new System.Drawing.Point(6, 19);
            this.tbxExportName.Name = "tbxExportName";
            this.tbxExportName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxExportName.Size = new System.Drawing.Size(248, 20);
            this.tbxExportName.TabIndex = 8;
            this.tbxExportName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbxPassword
            // 
            this.gbxPassword.Controls.Add(this.tbxExportPassword);
            this.gbxPassword.Location = new System.Drawing.Point(1195, 70);
            this.gbxPassword.Name = "gbxPassword";
            this.gbxPassword.Size = new System.Drawing.Size(260, 51);
            this.gbxPassword.TabIndex = 19;
            this.gbxPassword.TabStop = false;
            this.gbxPassword.Text = "Export Password";
            // 
            // tbxExportPassword
            // 
            this.tbxExportPassword.Location = new System.Drawing.Point(6, 19);
            this.tbxExportPassword.Name = "tbxExportPassword";
            this.tbxExportPassword.Size = new System.Drawing.Size(248, 20);
            this.tbxExportPassword.TabIndex = 8;
            // 
            // btnEstimateExport
            // 
            this.btnEstimateExport.Location = new System.Drawing.Point(1287, 335);
            this.btnEstimateExport.Name = "btnEstimateExport";
            this.btnEstimateExport.Size = new System.Drawing.Size(75, 23);
            this.btnEstimateExport.TabIndex = 21;
            this.btnEstimateExport.Text = "Estimate";
            this.btnEstimateExport.UseVisualStyleBackColor = true;
            this.btnEstimateExport.Click += new System.EventHandler(this.ButtonEstimateExport_Click);
            // 
            // gbxExportEstimate
            // 
            this.gbxExportEstimate.Controls.Add(this.lblSizeValue);
            this.gbxExportEstimate.Controls.Add(this.lblTooLargeValue);
            this.gbxExportEstimate.Controls.Add(this.lblSize);
            this.gbxExportEstimate.Controls.Add(this.lblTooLarge);
            this.gbxExportEstimate.Location = new System.Drawing.Point(1195, 127);
            this.gbxExportEstimate.Name = "gbxExportEstimate";
            this.gbxExportEstimate.Size = new System.Drawing.Size(260, 48);
            this.gbxExportEstimate.TabIndex = 20;
            this.gbxExportEstimate.TabStop = false;
            this.gbxExportEstimate.Text = "Export Estimate";
            // 
            // lblSizeValue
            // 
            this.lblSizeValue.AutoSize = true;
            this.lblSizeValue.Location = new System.Drawing.Point(151, 20);
            this.lblSizeValue.Name = "lblSizeValue";
            this.lblSizeValue.Size = new System.Drawing.Size(0, 13);
            this.lblSizeValue.TabIndex = 3;
            // 
            // lblTooLargeValue
            // 
            this.lblTooLargeValue.AutoSize = true;
            this.lblTooLargeValue.Location = new System.Drawing.Point(65, 20);
            this.lblTooLargeValue.Name = "lblTooLargeValue";
            this.lblTooLargeValue.Size = new System.Drawing.Size(0, 13);
            this.lblTooLargeValue.TabIndex = 2;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(121, 20);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(30, 13);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Size:";
            // 
            // lblTooLarge
            // 
            this.lblTooLarge.AutoSize = true;
            this.lblTooLarge.Location = new System.Drawing.Point(7, 20);
            this.lblTooLarge.Name = "lblTooLarge";
            this.lblTooLarge.Size = new System.Drawing.Size(59, 13);
            this.lblTooLarge.TabIndex = 0;
            this.lblTooLarge.Text = "Too Large:";
            // 
            // NewExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 366);
            this.Controls.Add(this.gbxExportEstimate);
            this.Controls.Add(this.btnEstimateExport);
            this.Controls.Add(this.gbxPassword);
            this.Controls.Add(this.gbxName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lvAddedClips);
            this.Controls.Add(this.lvAvailableClips);
            this.Controls.Add(this.lvDataSources);
            this.Controls.Add(this.btnRemoveClip);
            this.Controls.Add(this.btnAddClip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewExportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export Clips";
            this.gbxName.ResumeLayout(false);
            this.gbxName.PerformLayout();
            this.gbxPassword.ResumeLayout(false);
            this.gbxPassword.PerformLayout();
            this.gbxExportEstimate.ResumeLayout(false);
            this.gbxExportEstimate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddClip;
        private System.Windows.Forms.Button btnRemoveClip;
        private System.Windows.Forms.ListView lvDataSources;
        private System.Windows.Forms.ColumnHeader colHeadName;
        private System.Windows.Forms.ColumnHeader colHeadType;
        private System.Windows.Forms.ColumnHeader colHeadStartTime;
        private System.Windows.Forms.ColumnHeader colHeadEndTime;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ColumnHeader colHeadAddType;
        private System.Windows.Forms.ColumnHeader colHeadAddStartTime;
        private System.Windows.Forms.ColumnHeader colHeadAddEndTime;
        public System.Windows.Forms.ListView lvAvailableClips;
        public System.Windows.Forms.ListView lvAddedClips;
        private System.Windows.Forms.GroupBox gbxName;
        private System.Windows.Forms.TextBox tbxExportName;
        private System.Windows.Forms.GroupBox gbxPassword;
        private System.Windows.Forms.TextBox tbxExportPassword;
        private System.Windows.Forms.Button btnEstimateExport;
        private System.Windows.Forms.GroupBox gbxExportEstimate;
        private System.Windows.Forms.Label lblSizeValue;
        private System.Windows.Forms.Label lblTooLargeValue;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblTooLarge;
    }
}