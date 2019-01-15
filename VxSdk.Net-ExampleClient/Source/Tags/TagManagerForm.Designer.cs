namespace ExampleClient.Source
{
    partial class TagManagerForm
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
            this.gbxLinkedDevices = new System.Windows.Forms.GroupBox();
            this.lvDevices = new System.Windows.Forms.ListView();
            this.chDeviceName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxLinkedDataSources = new System.Windows.Forms.GroupBox();
            this.lvDataSources = new System.Windows.Forms.ListView();
            this.chDataSourceName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNewTag = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.tvTags = new System.Windows.Forms.TreeView();
            this.gbxTags = new System.Windows.Forms.GroupBox();
            this.btnNewChildTag = new System.Windows.Forms.Button();
            this.gbxLinkedDevices.SuspendLayout();
            this.gbxLinkedDataSources.SuspendLayout();
            this.gbxTags.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLinkedDevices
            // 
            this.gbxLinkedDevices.Controls.Add(this.lvDevices);
            this.gbxLinkedDevices.Location = new System.Drawing.Point(304, 12);
            this.gbxLinkedDevices.Name = "gbxLinkedDevices";
            this.gbxLinkedDevices.Size = new System.Drawing.Size(309, 190);
            this.gbxLinkedDevices.TabIndex = 0;
            this.gbxLinkedDevices.TabStop = false;
            this.gbxLinkedDevices.Text = "Linked Devices";
            // 
            // lvDevices
            // 
            this.lvDevices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDeviceName});
            this.lvDevices.Location = new System.Drawing.Point(6, 19);
            this.lvDevices.Name = "lvDevices";
            this.lvDevices.Size = new System.Drawing.Size(297, 165);
            this.lvDevices.TabIndex = 3;
            this.lvDevices.UseCompatibleStateImageBehavior = false;
            this.lvDevices.View = System.Windows.Forms.View.Details;
            // 
            // chDeviceName
            // 
            this.chDeviceName.Text = "Name";
            this.chDeviceName.Width = 293;
            // 
            // gbxLinkedDataSources
            // 
            this.gbxLinkedDataSources.Controls.Add(this.lvDataSources);
            this.gbxLinkedDataSources.Location = new System.Drawing.Point(304, 208);
            this.gbxLinkedDataSources.Name = "gbxLinkedDataSources";
            this.gbxLinkedDataSources.Size = new System.Drawing.Size(309, 190);
            this.gbxLinkedDataSources.TabIndex = 1;
            this.gbxLinkedDataSources.TabStop = false;
            this.gbxLinkedDataSources.Text = "Linked Data Sources";
            // 
            // lvDataSources
            // 
            this.lvDataSources.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDataSourceName});
            this.lvDataSources.Location = new System.Drawing.Point(6, 19);
            this.lvDataSources.Name = "lvDataSources";
            this.lvDataSources.Size = new System.Drawing.Size(297, 161);
            this.lvDataSources.TabIndex = 2;
            this.lvDataSources.UseCompatibleStateImageBehavior = false;
            this.lvDataSources.View = System.Windows.Forms.View.Details;
            // 
            // chDataSourceName
            // 
            this.chDataSourceName.Text = "Name";
            this.chDataSourceName.Width = 292;
            // 
            // btnNewTag
            // 
            this.btnNewTag.Location = new System.Drawing.Point(619, 12);
            this.btnNewTag.Name = "btnNewTag";
            this.btnNewTag.Size = new System.Drawing.Size(85, 23);
            this.btnNewTag.TabIndex = 3;
            this.btnNewTag.Text = "New Tag";
            this.btnNewTag.UseVisualStyleBackColor = true;
            this.btnNewTag.Click += new System.EventHandler(this.ButtonNewTag_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(619, 70);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(618, 128);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(85, 23);
            this.btnMerge.TabIndex = 5;
            this.btnMerge.Text = "Merge";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.ButtonMerge_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(618, 157);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(619, 99);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(85, 23);
            this.btnModify.TabIndex = 7;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.ButtonModify_Click);
            // 
            // tvTags
            // 
            this.tvTags.Location = new System.Drawing.Point(6, 19);
            this.tvTags.Name = "tvTags";
            this.tvTags.Size = new System.Drawing.Size(270, 357);
            this.tvTags.TabIndex = 8;
            this.tvTags.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewTags_AfterSelect);
            // 
            // gbxTags
            // 
            this.gbxTags.Controls.Add(this.tvTags);
            this.gbxTags.Location = new System.Drawing.Point(12, 12);
            this.gbxTags.Name = "gbxTags";
            this.gbxTags.Size = new System.Drawing.Size(286, 386);
            this.gbxTags.TabIndex = 9;
            this.gbxTags.TabStop = false;
            this.gbxTags.Text = "Tags";
            // 
            // btnNewChildTag
            // 
            this.btnNewChildTag.Location = new System.Drawing.Point(619, 41);
            this.btnNewChildTag.Name = "btnNewChildTag";
            this.btnNewChildTag.Size = new System.Drawing.Size(85, 23);
            this.btnNewChildTag.TabIndex = 10;
            this.btnNewChildTag.Text = "New Child Tag";
            this.btnNewChildTag.UseVisualStyleBackColor = true;
            this.btnNewChildTag.Click += new System.EventHandler(this.ButtonNewChildTag_Click);
            // 
            // TagManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 409);
            this.Controls.Add(this.btnNewChildTag);
            this.Controls.Add(this.gbxTags);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNewTag);
            this.Controls.Add(this.gbxLinkedDataSources);
            this.Controls.Add(this.gbxLinkedDevices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TagManagerForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tag Manager";
            this.gbxLinkedDevices.ResumeLayout(false);
            this.gbxLinkedDataSources.ResumeLayout(false);
            this.gbxTags.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLinkedDevices;
        private System.Windows.Forms.ListView lvDevices;
        private System.Windows.Forms.GroupBox gbxLinkedDataSources;
        private System.Windows.Forms.ListView lvDataSources;
        private System.Windows.Forms.Button btnNewTag;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ColumnHeader chDeviceName;
        private System.Windows.Forms.ColumnHeader chDataSourceName;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TreeView tvTags;
        private System.Windows.Forms.GroupBox gbxTags;
        private System.Windows.Forms.Button btnNewChildTag;
    }
}