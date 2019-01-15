namespace ExampleClient.Source
{
    partial class GapDetailsForm
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
            this.lvGapInfo = new System.Windows.Forms.ListView();
            this.chReason = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDataStorageId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chReasonData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvGapInfo
            // 
            this.lvGapInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chReason,
            this.chStartTime,
            this.chEndTime,
            this.chDataStorageId,
            this.chReasonData});
            this.lvGapInfo.FullRowSelect = true;
            this.lvGapInfo.Location = new System.Drawing.Point(12, 12);
            this.lvGapInfo.MultiSelect = false;
            this.lvGapInfo.Name = "lvGapInfo";
            this.lvGapInfo.Size = new System.Drawing.Size(1101, 299);
            this.lvGapInfo.TabIndex = 9;
            this.lvGapInfo.UseCompatibleStateImageBehavior = false;
            this.lvGapInfo.View = System.Windows.Forms.View.Details;
            // 
            // chReason
            // 
            this.chReason.Text = "Reason";
            this.chReason.Width = 150;
            // 
            // chStartTime
            // 
            this.chStartTime.Text = "Start Time";
            this.chStartTime.Width = 120;
            // 
            // chEndTime
            // 
            this.chEndTime.Text = "End Time";
            this.chEndTime.Width = 120;
            // 
            // chDataStorageId
            // 
            this.chDataStorageId.Text = "Data Storage ID";
            this.chDataStorageId.Width = 150;
            // 
            // chReasonData
            // 
            this.chReasonData.Text = "Reason Data";
            this.chReasonData.Width = 555;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(1037, 317);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(956, 316);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // GapDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 351);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lvGapInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GapDetailsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Recording Gaps";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvGapInfo;
        private System.Windows.Forms.ColumnHeader chReason;
        private System.Windows.Forms.ColumnHeader chStartTime;
        private System.Windows.Forms.ColumnHeader chEndTime;
        private System.Windows.Forms.ColumnHeader chDataStorageId;
        private System.Windows.Forms.ColumnHeader chReasonData;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
    }
}