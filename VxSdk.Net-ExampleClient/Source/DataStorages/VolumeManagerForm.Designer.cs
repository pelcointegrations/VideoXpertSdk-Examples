namespace ExampleClient.Source
{
    partial class VolumeManagerForm
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
            this.lvVolumes = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDomain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBuffer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUsed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIsOnline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIsBandwidthReserved = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chVolumeGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDeleteVolume = new System.Windows.Forms.Button();
            this.btnAddVolume = new System.Windows.Forms.Button();
            this.btnModifyVolume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvVolumes
            // 
            this.lvVolumes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chPath,
            this.chDomain,
            this.chUsername,
            this.chBuffer,
            this.chUsed,
            this.chTotal,
            this.chIsOnline,
            this.chIsBandwidthReserved,
            this.chVolumeGroup});
            this.lvVolumes.FullRowSelect = true;
            this.lvVolumes.GridLines = true;
            this.lvVolumes.HideSelection = false;
            this.lvVolumes.Location = new System.Drawing.Point(12, 12);
            this.lvVolumes.MultiSelect = false;
            this.lvVolumes.Name = "lvVolumes";
            this.lvVolumes.Size = new System.Drawing.Size(1029, 320);
            this.lvVolumes.TabIndex = 10;
            this.lvVolumes.UseCompatibleStateImageBehavior = false;
            this.lvVolumes.View = System.Windows.Forms.View.Details;
            // 
            // chId
            // 
            this.chId.Text = "ID";
            this.chId.Width = 180;
            // 
            // chPath
            // 
            this.chPath.Text = "Path";
            this.chPath.Width = 167;
            // 
            // chDomain
            // 
            this.chDomain.Text = "Domain";
            this.chDomain.Width = 106;
            // 
            // chUsername
            // 
            this.chUsername.Text = "Username";
            this.chUsername.Width = 106;
            // 
            // chBuffer
            // 
            this.chBuffer.Text = "Buffer";
            this.chBuffer.Width = 71;
            // 
            // chUsed
            // 
            this.chUsed.Text = "Used";
            // 
            // chTotal
            // 
            this.chTotal.Text = "Total";
            // 
            // chIsOnline
            // 
            this.chIsOnline.Text = "Online";
            // 
            // chIsBandwidthReserved
            // 
            this.chIsBandwidthReserved.Text = "Bandwidth Rsv.";
            this.chIsBandwidthReserved.Width = 100;
            // 
            // chVolumeGroup
            // 
            this.chVolumeGroup.Text = "Volume Group";
            this.chVolumeGroup.Width = 110;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1047, 99);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 23);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // btnDeleteVolume
            // 
            this.btnDeleteVolume.Location = new System.Drawing.Point(1047, 70);
            this.btnDeleteVolume.Name = "btnDeleteVolume";
            this.btnDeleteVolume.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteVolume.TabIndex = 22;
            this.btnDeleteVolume.Text = "Delete Volume";
            this.btnDeleteVolume.UseVisualStyleBackColor = true;
            this.btnDeleteVolume.Click += new System.EventHandler(this.ButtonDeleteVolume_Click);
            // 
            // btnAddVolume
            // 
            this.btnAddVolume.Location = new System.Drawing.Point(1047, 12);
            this.btnAddVolume.Name = "btnAddVolume";
            this.btnAddVolume.Size = new System.Drawing.Size(100, 23);
            this.btnAddVolume.TabIndex = 21;
            this.btnAddVolume.Text = "Create Volume";
            this.btnAddVolume.UseVisualStyleBackColor = true;
            this.btnAddVolume.Click += new System.EventHandler(this.ButtonAddVolume_Click);
            // 
            // btnModifyVolume
            // 
            this.btnModifyVolume.Location = new System.Drawing.Point(1047, 41);
            this.btnModifyVolume.Name = "btnModifyVolume";
            this.btnModifyVolume.Size = new System.Drawing.Size(100, 23);
            this.btnModifyVolume.TabIndex = 19;
            this.btnModifyVolume.Text = "Modify Volume";
            this.btnModifyVolume.UseVisualStyleBackColor = true;
            this.btnModifyVolume.Click += new System.EventHandler(this.ButtonModifyVolume_Click);
            // 
            // VolumeManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 349);
            this.Controls.Add(this.btnDeleteVolume);
            this.Controls.Add(this.btnAddVolume);
            this.Controls.Add(this.btnModifyVolume);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lvVolumes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VolumeManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Volume Manager";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvVolumes;
        private System.Windows.Forms.ColumnHeader chPath;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chDomain;
        private System.Windows.Forms.ColumnHeader chUsername;
        private System.Windows.Forms.ColumnHeader chBuffer;
        private System.Windows.Forms.ColumnHeader chUsed;
        private System.Windows.Forms.ColumnHeader chTotal;
        private System.Windows.Forms.ColumnHeader chIsOnline;
        private System.Windows.Forms.ColumnHeader chIsBandwidthReserved;
        private System.Windows.Forms.ColumnHeader chVolumeGroup;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDeleteVolume;
        private System.Windows.Forms.Button btnAddVolume;
        private System.Windows.Forms.Button btnModifyVolume;
    }
}