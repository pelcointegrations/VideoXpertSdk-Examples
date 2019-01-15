namespace ExampleClient.Source
{
    partial class PixelSearchResultsForm
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
            this.lblTitleStatus = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lvClips = new System.Windows.Forms.ListView();
            this.colHeadAddType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadAddStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadAddEndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Results = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.Results.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(393, 257);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 31;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // lblTitleStatus
            // 
            this.lblTitleStatus.AutoSize = true;
            this.lblTitleStatus.Location = new System.Drawing.Point(12, 9);
            this.lblTitleStatus.Name = "lblTitleStatus";
            this.lblTitleStatus.Size = new System.Drawing.Size(40, 13);
            this.lblTitleStatus.TabIndex = 33;
            this.lblTitleStatus.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(69, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 34;
            // 
            // lvClips
            // 
            this.lvClips.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadAddType,
            this.colHeadAddStartTime,
            this.colHeadAddEndTime});
            this.lvClips.HideSelection = false;
            this.lvClips.Location = new System.Drawing.Point(6, 19);
            this.lvClips.MultiSelect = false;
            this.lvClips.Name = "lvClips";
            this.lvClips.Size = new System.Drawing.Size(436, 192);
            this.lvClips.TabIndex = 35;
            this.lvClips.UseCompatibleStateImageBehavior = false;
            this.lvClips.View = System.Windows.Forms.View.Details;
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
            // Results
            // 
            this.Results.Controls.Add(this.lvClips);
            this.Results.Location = new System.Drawing.Point(12, 34);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(456, 217);
            this.Results.TabIndex = 36;
            this.Results.TabStop = false;
            this.Results.Text = "Results";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(382, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(86, 23);
            this.btnRefresh.TabIndex = 36;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // PixelSearchResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 288);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTitleStatus);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PixelSearchResultsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pixel Search Results";
            this.Results.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblTitleStatus;
        private System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.ListView lvClips;
        private System.Windows.Forms.ColumnHeader colHeadAddType;
        private System.Windows.Forms.ColumnHeader colHeadAddStartTime;
        private System.Windows.Forms.ColumnHeader colHeadAddEndTime;
        private System.Windows.Forms.GroupBox Results;
        private System.Windows.Forms.Button btnRefresh;
    }
}