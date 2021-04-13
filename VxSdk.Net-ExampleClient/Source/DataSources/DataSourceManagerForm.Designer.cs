namespace ExampleClient.Source
{
    partial class DataSourceManagerForm
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
            this.lvDataSources = new System.Windows.Forms.ListView();
            this.chNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRetentionLimit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMotionMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chManualRecord = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEnabled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCapabilities = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnManageLinks = new System.Windows.Forms.Button();
            this.btnAutoNumber = new System.Windows.Forms.Button();
            this.btnViewerInfo = new System.Windows.Forms.Button();
            this.btnGapInfo = new System.Windows.Forms.Button();
            this.btnMotionConfig = new System.Windows.Forms.Button();
            this.btnViewBookmarks = new System.Windows.Forms.Button();
            this.btnMetadata = new System.Windows.Forms.Button();
            this.btnViewTags = new System.Windows.Forms.Button();
            this.btnViewPtzLinkInfo = new System.Windows.Forms.Button();
            this.btnLimits = new System.Windows.Forms.Button();
            this.btnAnalytics = new System.Windows.Forms.Button();
            this.btnPtzConfig = new System.Windows.Forms.Button();
            this.btnSmartCompression = new System.Windows.Forms.Button();
            this.btnVideoEncodings = new System.Windows.Forms.Button();
            this.btnMetadataSnapshot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1193, 478);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(108, 23);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(1195, 12);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(108, 23);
            this.btnModify.TabIndex = 11;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.ButtonModify_Click);
            // 
            // lvDataSources
            // 
            this.lvDataSources.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNumber,
            this.chType,
            this.chName,
            this.chIp,
            this.chId,
            this.chState,
            this.chRetentionLimit,
            this.chMotionMode,
            this.chManualRecord,
            this.chEnabled,
            this.chCapabilities});
            this.lvDataSources.FullRowSelect = true;
            this.lvDataSources.HideSelection = false;
            this.lvDataSources.Location = new System.Drawing.Point(12, 12);
            this.lvDataSources.MultiSelect = false;
            this.lvDataSources.Name = "lvDataSources";
            this.lvDataSources.Size = new System.Drawing.Size(1175, 489);
            this.lvDataSources.TabIndex = 8;
            this.lvDataSources.UseCompatibleStateImageBehavior = false;
            this.lvDataSources.View = System.Windows.Forms.View.Details;
            // 
            // chNumber
            // 
            this.chNumber.Text = "Number";
            this.chNumber.Width = 64;
            // 
            // chType
            // 
            this.chType.Text = "Type";
            this.chType.Width = 50;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 253;
            // 
            // chIp
            // 
            this.chIp.Text = "IP";
            this.chIp.Width = 100;
            // 
            // chId
            // 
            this.chId.Text = "ID";
            this.chId.Width = 225;
            // 
            // chState
            // 
            this.chState.Text = "State";
            this.chState.Width = 45;
            // 
            // chRetentionLimit
            // 
            this.chRetentionLimit.Text = "Retention Limit";
            this.chRetentionLimit.Width = 90;
            // 
            // chMotionMode
            // 
            this.chMotionMode.Text = "Motion Mode";
            this.chMotionMode.Width = 75;
            // 
            // chManualRecord
            // 
            this.chManualRecord.Text = "Manual Rec.";
            this.chManualRecord.Width = 74;
            // 
            // chEnabled
            // 
            this.chEnabled.Text = "Enabled";
            // 
            // chCapabilities
            // 
            this.chCapabilities.Text = "Capabilities";
            this.chCapabilities.Width = 135;
            // 
            // btnManageLinks
            // 
            this.btnManageLinks.Location = new System.Drawing.Point(1195, 41);
            this.btnManageLinks.Name = "btnManageLinks";
            this.btnManageLinks.Size = new System.Drawing.Size(108, 23);
            this.btnManageLinks.TabIndex = 13;
            this.btnManageLinks.Text = "Manage Links";
            this.btnManageLinks.UseVisualStyleBackColor = true;
            this.btnManageLinks.Click += new System.EventHandler(this.ButtonManageLinks_Click);
            // 
            // btnAutoNumber
            // 
            this.btnAutoNumber.Location = new System.Drawing.Point(1195, 70);
            this.btnAutoNumber.Name = "btnAutoNumber";
            this.btnAutoNumber.Size = new System.Drawing.Size(108, 23);
            this.btnAutoNumber.TabIndex = 14;
            this.btnAutoNumber.Text = "Auto-Number";
            this.btnAutoNumber.UseVisualStyleBackColor = true;
            this.btnAutoNumber.Click += new System.EventHandler(this.ButtonAutoNumber_Click);
            // 
            // btnViewerInfo
            // 
            this.btnViewerInfo.Location = new System.Drawing.Point(1195, 99);
            this.btnViewerInfo.Name = "btnViewerInfo";
            this.btnViewerInfo.Size = new System.Drawing.Size(108, 23);
            this.btnViewerInfo.TabIndex = 15;
            this.btnViewerInfo.Text = "Viewer Info";
            this.btnViewerInfo.UseVisualStyleBackColor = true;
            this.btnViewerInfo.Click += new System.EventHandler(this.ButtonViewerInfo_Click);
            // 
            // btnGapInfo
            // 
            this.btnGapInfo.Location = new System.Drawing.Point(1195, 128);
            this.btnGapInfo.Name = "btnGapInfo";
            this.btnGapInfo.Size = new System.Drawing.Size(108, 23);
            this.btnGapInfo.TabIndex = 16;
            this.btnGapInfo.Text = "Gap Info";
            this.btnGapInfo.UseVisualStyleBackColor = true;
            this.btnGapInfo.Click += new System.EventHandler(this.ButtonGapInfo_Click);
            // 
            // btnMotionConfig
            // 
            this.btnMotionConfig.Location = new System.Drawing.Point(1195, 157);
            this.btnMotionConfig.Name = "btnMotionConfig";
            this.btnMotionConfig.Size = new System.Drawing.Size(108, 23);
            this.btnMotionConfig.TabIndex = 17;
            this.btnMotionConfig.Text = "Motion Config";
            this.btnMotionConfig.UseVisualStyleBackColor = true;
            this.btnMotionConfig.Click += new System.EventHandler(this.ButtonMotionConfig_Click);
            // 
            // btnViewBookmarks
            // 
            this.btnViewBookmarks.Location = new System.Drawing.Point(1195, 273);
            this.btnViewBookmarks.Name = "btnViewBookmarks";
            this.btnViewBookmarks.Size = new System.Drawing.Size(108, 23);
            this.btnViewBookmarks.TabIndex = 18;
            this.btnViewBookmarks.Text = "View Bookmarks";
            this.btnViewBookmarks.UseVisualStyleBackColor = true;
            this.btnViewBookmarks.Click += new System.EventHandler(this.ButtonViewBookmarks_Click);
            // 
            // btnMetadata
            // 
            this.btnMetadata.Location = new System.Drawing.Point(1195, 302);
            this.btnMetadata.Name = "btnMetadata";
            this.btnMetadata.Size = new System.Drawing.Size(108, 23);
            this.btnMetadata.TabIndex = 19;
            this.btnMetadata.Text = "Metadata Rels.";
            this.btnMetadata.UseVisualStyleBackColor = true;
            this.btnMetadata.Click += new System.EventHandler(this.ButtonMetadata_Click);
            // 
            // btnViewTags
            // 
            this.btnViewTags.Location = new System.Drawing.Point(1195, 331);
            this.btnViewTags.Name = "btnViewTags";
            this.btnViewTags.Size = new System.Drawing.Size(108, 23);
            this.btnViewTags.TabIndex = 20;
            this.btnViewTags.Text = "View Tags";
            this.btnViewTags.UseVisualStyleBackColor = true;
            this.btnViewTags.Click += new System.EventHandler(this.ButtonViewTags_Click);
            // 
            // btnViewPtzLinkInfo
            // 
            this.btnViewPtzLinkInfo.Location = new System.Drawing.Point(1195, 360);
            this.btnViewPtzLinkInfo.Name = "btnViewPtzLinkInfo";
            this.btnViewPtzLinkInfo.Size = new System.Drawing.Size(108, 23);
            this.btnViewPtzLinkInfo.TabIndex = 21;
            this.btnViewPtzLinkInfo.Text = "View PTZ Links";
            this.btnViewPtzLinkInfo.UseVisualStyleBackColor = true;
            this.btnViewPtzLinkInfo.Click += new System.EventHandler(this.ButtonViewPtzLinkInfo_Click);
            // 
            // btnLimits
            // 
            this.btnLimits.Location = new System.Drawing.Point(1195, 389);
            this.btnLimits.Name = "btnLimits";
            this.btnLimits.Size = new System.Drawing.Size(108, 23);
            this.btnLimits.TabIndex = 22;
            this.btnLimits.Text = "Limits";
            this.btnLimits.UseVisualStyleBackColor = true;
            this.btnLimits.Click += new System.EventHandler(this.ButtonLimits_Click);
            // 
            // btnAnalytics
            // 
            this.btnAnalytics.Location = new System.Drawing.Point(1195, 418);
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.Size = new System.Drawing.Size(108, 23);
            this.btnAnalytics.TabIndex = 23;
            this.btnAnalytics.Text = "Analytics";
            this.btnAnalytics.UseVisualStyleBackColor = true;
            this.btnAnalytics.Click += new System.EventHandler(this.ButtonAnalytics_Click);
            // 
            // btnPtzConfig
            // 
            this.btnPtzConfig.Location = new System.Drawing.Point(1195, 186);
            this.btnPtzConfig.Name = "btnPtzConfig";
            this.btnPtzConfig.Size = new System.Drawing.Size(108, 23);
            this.btnPtzConfig.TabIndex = 24;
            this.btnPtzConfig.Text = "PTZ Config";
            this.btnPtzConfig.UseVisualStyleBackColor = true;
            this.btnPtzConfig.Click += new System.EventHandler(this.ButtonPtzConfig_Click);
            // 
            // btnSmartCompression
            // 
            this.btnSmartCompression.Location = new System.Drawing.Point(1195, 215);
            this.btnSmartCompression.Name = "btnSmartCompression";
            this.btnSmartCompression.Size = new System.Drawing.Size(108, 23);
            this.btnSmartCompression.TabIndex = 25;
            this.btnSmartCompression.Text = "Smart Compression";
            this.btnSmartCompression.UseVisualStyleBackColor = true;
            this.btnSmartCompression.Click += new System.EventHandler(this.ButtonSmartCompression_Click);
            // 
            // btnVideoEncodings
            // 
            this.btnVideoEncodings.Location = new System.Drawing.Point(1195, 244);
            this.btnVideoEncodings.Name = "btnVideoEncodings";
            this.btnVideoEncodings.Size = new System.Drawing.Size(108, 23);
            this.btnVideoEncodings.TabIndex = 26;
            this.btnVideoEncodings.Text = "Video Encodings";
            this.btnVideoEncodings.UseVisualStyleBackColor = true;
            this.btnVideoEncodings.Click += new System.EventHandler(this.ButtonVideoEncodings_Click);
            // 
            // btnMetadataSnapshot
            // 
            this.btnMetadataSnapshot.Location = new System.Drawing.Point(1193, 447);
            this.btnMetadataSnapshot.Name = "btnMetadataSnapshot";
            this.btnMetadataSnapshot.Size = new System.Drawing.Size(108, 23);
            this.btnMetadataSnapshot.TabIndex = 27;
            this.btnMetadataSnapshot.Text = "Metadata Snapshot";
            this.btnMetadataSnapshot.UseVisualStyleBackColor = true;
            this.btnMetadataSnapshot.Click += new System.EventHandler(this.ButtonMetadataSnapshot_Click);
            // 
            // DataSourceManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 506);
            this.Controls.Add(this.btnMetadataSnapshot);
            this.Controls.Add(this.btnVideoEncodings);
            this.Controls.Add(this.btnSmartCompression);
            this.Controls.Add(this.btnPtzConfig);
            this.Controls.Add(this.btnAnalytics);
            this.Controls.Add(this.btnLimits);
            this.Controls.Add(this.btnViewPtzLinkInfo);
            this.Controls.Add(this.btnViewTags);
            this.Controls.Add(this.btnMetadata);
            this.Controls.Add(this.btnViewBookmarks);
            this.Controls.Add(this.btnMotionConfig);
            this.Controls.Add(this.btnGapInfo);
            this.Controls.Add(this.btnViewerInfo);
            this.Controls.Add(this.btnAutoNumber);
            this.Controls.Add(this.btnManageLinks);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.lvDataSources);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataSourceManagerForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Data Source Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.ListView lvDataSources;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chNumber;
        private System.Windows.Forms.ColumnHeader chState;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader chIp;
        private System.Windows.Forms.Button btnManageLinks;
        private System.Windows.Forms.Button btnAutoNumber;
        private System.Windows.Forms.Button btnViewerInfo;
        private System.Windows.Forms.ColumnHeader chRetentionLimit;
        private System.Windows.Forms.Button btnGapInfo;
        private System.Windows.Forms.Button btnMotionConfig;
        private System.Windows.Forms.ColumnHeader chMotionMode;
        private System.Windows.Forms.Button btnViewBookmarks;
        private System.Windows.Forms.Button btnMetadata;
        private System.Windows.Forms.ColumnHeader chManualRecord;
        private System.Windows.Forms.ColumnHeader chEnabled;
        private System.Windows.Forms.Button btnViewTags;
        private System.Windows.Forms.ColumnHeader chCapabilities;
        private System.Windows.Forms.Button btnViewPtzLinkInfo;
        private System.Windows.Forms.Button btnLimits;
        private System.Windows.Forms.Button btnAnalytics;
        private System.Windows.Forms.Button btnPtzConfig;
        private System.Windows.Forms.Button btnSmartCompression;
        private System.Windows.Forms.Button btnVideoEncodings;
        private System.Windows.Forms.Button btnMetadataSnapshot;
    }
}