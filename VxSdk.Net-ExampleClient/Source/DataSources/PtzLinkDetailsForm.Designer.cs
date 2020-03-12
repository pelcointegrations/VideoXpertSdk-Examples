namespace ExampleClient.Source
{
    partial class PtzLinkDetailsForm
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lvPtzLinkInfo = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(541, 186);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(460, 185);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // lvPtzLinkInfo
            // 
            this.lvPtzLinkInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chIp});
            this.lvPtzLinkInfo.FullRowSelect = true;
            this.lvPtzLinkInfo.HideSelection = false;
            this.lvPtzLinkInfo.Location = new System.Drawing.Point(12, 12);
            this.lvPtzLinkInfo.MultiSelect = false;
            this.lvPtzLinkInfo.Name = "lvPtzLinkInfo";
            this.lvPtzLinkInfo.Size = new System.Drawing.Size(604, 168);
            this.lvPtzLinkInfo.TabIndex = 12;
            this.lvPtzLinkInfo.UseCompatibleStateImageBehavior = false;
            this.lvPtzLinkInfo.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 300;
            // 
            // chIp
            // 
            this.chIp.Text = "IP Address";
            this.chIp.Width = 300;
            // 
            // PtzLinkDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 218);
            this.Controls.Add(this.lvPtzLinkInfo);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PtzLinkDetailsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PTZ Link Info";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListView lvPtzLinkInfo;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chIp;
    }
}