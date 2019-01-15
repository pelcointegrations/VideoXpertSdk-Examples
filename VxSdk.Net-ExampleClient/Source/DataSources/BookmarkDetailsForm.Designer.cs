namespace ExampleClient.Source
{
    partial class BookmarkDetailsForm
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
            this.lvBookmarkManager = new System.Windows.Forms.ListView();
            this.chChecked = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLockStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLockEndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(905, 316);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(824, 315);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // lvBookmarkManager
            // 
            this.lvBookmarkManager.CheckBoxes = true;
            this.lvBookmarkManager.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chChecked,
            this.chId,
            this.chTime,
            this.chName,
            this.chDescription,
            this.chLock,
            this.chLockStartTime,
            this.chLockEndTime});
            this.lvBookmarkManager.FullRowSelect = true;
            this.lvBookmarkManager.GridLines = true;
            this.lvBookmarkManager.Location = new System.Drawing.Point(12, 12);
            this.lvBookmarkManager.MultiSelect = false;
            this.lvBookmarkManager.Name = "lvBookmarkManager";
            this.lvBookmarkManager.Size = new System.Drawing.Size(968, 298);
            this.lvBookmarkManager.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvBookmarkManager.TabIndex = 12;
            this.lvBookmarkManager.UseCompatibleStateImageBehavior = false;
            this.lvBookmarkManager.View = System.Windows.Forms.View.Details;
            // 
            // chChecked
            // 
            this.chChecked.Text = "";
            this.chChecked.Width = 20;
            // 
            // chId
            // 
            this.chId.Text = "ID";
            this.chId.Width = 224;
            // 
            // chTime
            // 
            this.chTime.Text = "Time";
            this.chTime.Width = 120;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 135;
            // 
            // chDescription
            // 
            this.chDescription.Text = "Description";
            this.chDescription.Width = 155;
            // 
            // chLock
            // 
            this.chLock.Text = "Lock";
            // 
            // chLockStartTime
            // 
            this.chLockStartTime.Text = "Lock Start Time";
            this.chLockStartTime.Width = 120;
            // 
            // chLockEndTime
            // 
            this.chLockEndTime.Text = "Lock End Time";
            this.chLockEndTime.Width = 120;
            // 
            // BookmarkDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 351);
            this.Controls.Add(this.lvBookmarkManager);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookmarkDetailsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bookmarks";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListView lvBookmarkManager;
        private System.Windows.Forms.ColumnHeader chChecked;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chDescription;
        private System.Windows.Forms.ColumnHeader chLock;
        private System.Windows.Forms.ColumnHeader chLockStartTime;
        private System.Windows.Forms.ColumnHeader chLockEndTime;
    }
}