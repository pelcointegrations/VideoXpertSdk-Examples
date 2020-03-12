namespace ExampleClient.Source
{
    partial class ExportStreamForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxExportStreamStatus = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnHalt = new System.Windows.Forms.Button();
            this.btnPrepare = new System.Windows.Forms.Button();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.lblTimeLeftTitle = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblProgressTitle = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblReasonTitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.gbxClips = new System.Windows.Forms.GroupBox();
            this.dgvClips = new System.Windows.Forms.DataGridView();
            this.chStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chRenderType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chVideoUri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chAudioUri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxExportStreamStatus.SuspendLayout();
            this.gbxClips.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClips)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(1392, 332);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // gbxExportStreamStatus
            // 
            this.gbxExportStreamStatus.Controls.Add(this.btnRefresh);
            this.gbxExportStreamStatus.Controls.Add(this.btnHalt);
            this.gbxExportStreamStatus.Controls.Add(this.btnPrepare);
            this.gbxExportStreamStatus.Controls.Add(this.lblTimeLeft);
            this.gbxExportStreamStatus.Controls.Add(this.lblTimeLeftTitle);
            this.gbxExportStreamStatus.Controls.Add(this.lblProgress);
            this.gbxExportStreamStatus.Controls.Add(this.lblProgressTitle);
            this.gbxExportStreamStatus.Controls.Add(this.lblReason);
            this.gbxExportStreamStatus.Controls.Add(this.lblReasonTitle);
            this.gbxExportStreamStatus.Controls.Add(this.lblStatus);
            this.gbxExportStreamStatus.Controls.Add(this.lblStatusTitle);
            this.gbxExportStreamStatus.Location = new System.Drawing.Point(12, 12);
            this.gbxExportStreamStatus.Name = "gbxExportStreamStatus";
            this.gbxExportStreamStatus.Size = new System.Drawing.Size(281, 314);
            this.gbxExportStreamStatus.TabIndex = 9;
            this.gbxExportStreamStatus.TabStop = false;
            this.gbxExportStreamStatus.Text = "Export Stream Status";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(198, 100);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(55, 23);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // btnHalt
            // 
            this.btnHalt.Enabled = false;
            this.btnHalt.Location = new System.Drawing.Point(104, 100);
            this.btnHalt.Name = "btnHalt";
            this.btnHalt.Size = new System.Drawing.Size(55, 23);
            this.btnHalt.TabIndex = 13;
            this.btnHalt.Text = "Halt";
            this.btnHalt.UseVisualStyleBackColor = true;
            this.btnHalt.Click += new System.EventHandler(this.ButtonHalt_Click);
            // 
            // btnPrepare
            // 
            this.btnPrepare.Enabled = false;
            this.btnPrepare.Location = new System.Drawing.Point(10, 100);
            this.btnPrepare.Name = "btnPrepare";
            this.btnPrepare.Size = new System.Drawing.Size(55, 23);
            this.btnPrepare.TabIndex = 12;
            this.btnPrepare.Text = "Prepare";
            this.btnPrepare.UseVisualStyleBackColor = true;
            this.btnPrepare.Click += new System.EventHandler(this.ButtonPrepare_Click);
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Location = new System.Drawing.Point(181, 72);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(0, 13);
            this.lblTimeLeft.TabIndex = 11;
            this.lblTimeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTimeLeftTitle
            // 
            this.lblTimeLeftTitle.AutoSize = true;
            this.lblTimeLeftTitle.Location = new System.Drawing.Point(125, 72);
            this.lblTimeLeftTitle.Name = "lblTimeLeftTitle";
            this.lblTimeLeftTitle.Size = new System.Drawing.Size(54, 13);
            this.lblTimeLeftTitle.TabIndex = 10;
            this.lblTimeLeftTitle.Text = "Time Left:";
            this.lblTimeLeftTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(76, 72);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(0, 13);
            this.lblProgress.TabIndex = 5;
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProgressTitle
            // 
            this.lblProgressTitle.AutoSize = true;
            this.lblProgressTitle.Location = new System.Drawing.Point(19, 72);
            this.lblProgressTitle.Name = "lblProgressTitle";
            this.lblProgressTitle.Size = new System.Drawing.Size(51, 13);
            this.lblProgressTitle.TabIndex = 4;
            this.lblProgressTitle.Text = "Progress:";
            this.lblProgressTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(76, 48);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(0, 13);
            this.lblReason.TabIndex = 3;
            this.lblReason.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReasonTitle
            // 
            this.lblReasonTitle.AutoSize = true;
            this.lblReasonTitle.Location = new System.Drawing.Point(23, 48);
            this.lblReasonTitle.Name = "lblReasonTitle";
            this.lblReasonTitle.Size = new System.Drawing.Size(47, 13);
            this.lblReasonTitle.TabIndex = 2;
            this.lblReasonTitle.Text = "Reason:";
            this.lblReasonTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(76, 23);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.AutoSize = true;
            this.lblStatusTitle.Location = new System.Drawing.Point(30, 23);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(40, 13);
            this.lblStatusTitle.TabIndex = 0;
            this.lblStatusTitle.Text = "Status:";
            this.lblStatusTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbxClips
            // 
            this.gbxClips.Controls.Add(this.dgvClips);
            this.gbxClips.Location = new System.Drawing.Point(299, 12);
            this.gbxClips.Name = "gbxClips";
            this.gbxClips.Size = new System.Drawing.Size(1152, 314);
            this.gbxClips.TabIndex = 12;
            this.gbxClips.TabStop = false;
            this.gbxClips.Text = "Clips";
            // 
            // dgvClips
            // 
            this.dgvClips.AllowUserToAddRows = false;
            this.dgvClips.AllowUserToDeleteRows = false;
            this.dgvClips.AllowUserToResizeRows = false;
            this.dgvClips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClips.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chStartTime,
            this.chEndTime,
            this.chRenderType,
            this.chVideoUri,
            this.chAudioUri});
            this.dgvClips.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClips.Location = new System.Drawing.Point(3, 16);
            this.dgvClips.MultiSelect = false;
            this.dgvClips.Name = "dgvClips";
            this.dgvClips.RowHeadersVisible = false;
            this.dgvClips.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvClips.ShowCellErrors = false;
            this.dgvClips.ShowCellToolTips = false;
            this.dgvClips.ShowEditingIcon = false;
            this.dgvClips.ShowRowErrors = false;
            this.dgvClips.Size = new System.Drawing.Size(1146, 295);
            this.dgvClips.TabIndex = 0;
            // 
            // chStartTime
            // 
            this.chStartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.chStartTime.HeaderText = "Start TIme";
            this.chStartTime.MinimumWidth = 80;
            this.chStartTime.Name = "chStartTime";
            this.chStartTime.ReadOnly = true;
            this.chStartTime.Width = 81;
            // 
            // chEndTime
            // 
            this.chEndTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.chEndTime.HeaderText = "End Time";
            this.chEndTime.MinimumWidth = 100;
            this.chEndTime.Name = "chEndTime";
            this.chEndTime.ReadOnly = true;
            // 
            // chRenderType
            // 
            this.chRenderType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.chRenderType.HeaderText = "Render Type";
            this.chRenderType.Name = "chRenderType";
            this.chRenderType.ReadOnly = true;
            this.chRenderType.Width = 94;
            // 
            // chVideoUri
            // 
            this.chVideoUri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.chVideoUri.HeaderText = "Video URI";
            this.chVideoUri.Name = "chVideoUri";
            this.chVideoUri.Width = 81;
            // 
            // chAudioUri
            // 
            this.chAudioUri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.chAudioUri.HeaderText = "Audio URI";
            this.chAudioUri.MinimumWidth = 250;
            this.chAudioUri.Name = "chAudioUri";
            this.chAudioUri.Width = 250;
            // 
            // ExportStreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 366);
            this.Controls.Add(this.gbxClips);
            this.Controls.Add(this.gbxExportStreamStatus);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportStreamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export Stream Manager";
            this.gbxExportStreamStatus.ResumeLayout(false);
            this.gbxExportStreamStatus.PerformLayout();
            this.gbxClips.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClips)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbxExportStreamStatus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnHalt;
        private System.Windows.Forms.Button btnPrepare;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label lblTimeLeftTitle;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblProgressTitle;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Label lblReasonTitle;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.GroupBox gbxClips;
        private System.Windows.Forms.DataGridView dgvClips;
        private System.Windows.Forms.DataGridViewTextBoxColumn chStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn chEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn chRenderType;
        private System.Windows.Forms.DataGridViewTextBoxColumn chVideoUri;
        private System.Windows.Forms.DataGridViewTextBoxColumn chAudioUri;
    }
}