namespace ExampleClient.Source
{
    partial class VolumeGroupManagerForm
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
            this.lvVolumeGroups = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIsArchive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chVolumes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRelations = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnModifyGroup = new System.Windows.Forms.Button();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.btnDeleteGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvVolumeGroups
            // 
            this.lvVolumeGroups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chId,
            this.chIsArchive,
            this.chVolumes,
            this.chRelations});
            this.lvVolumeGroups.FullRowSelect = true;
            this.lvVolumeGroups.GridLines = true;
            this.lvVolumeGroups.HideSelection = false;
            this.lvVolumeGroups.Location = new System.Drawing.Point(12, 12);
            this.lvVolumeGroups.MultiSelect = false;
            this.lvVolumeGroups.Name = "lvVolumeGroups";
            this.lvVolumeGroups.Size = new System.Drawing.Size(754, 320);
            this.lvVolumeGroups.TabIndex = 10;
            this.lvVolumeGroups.UseCompatibleStateImageBehavior = false;
            this.lvVolumeGroups.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 200;
            // 
            // chId
            // 
            this.chId.Text = "ID";
            this.chId.Width = 200;
            // 
            // chIsArchive
            // 
            this.chIsArchive.Text = "Archive Group";
            this.chIsArchive.Width = 100;
            // 
            // chVolumes
            // 
            this.chVolumes.Text = "Volumes";
            this.chVolumes.Width = 110;
            // 
            // chRelations
            // 
            this.chRelations.Text = "Volume Relations";
            this.chRelations.Width = 110;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(772, 99);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 23);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // btnModifyGroup
            // 
            this.btnModifyGroup.Location = new System.Drawing.Point(772, 41);
            this.btnModifyGroup.Name = "btnModifyGroup";
            this.btnModifyGroup.Size = new System.Drawing.Size(100, 23);
            this.btnModifyGroup.TabIndex = 15;
            this.btnModifyGroup.Text = "Modify Group";
            this.btnModifyGroup.UseVisualStyleBackColor = true;
            this.btnModifyGroup.Click += new System.EventHandler(this.ButtonModifyGroup_Click);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Location = new System.Drawing.Point(772, 12);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(100, 23);
            this.btnAddGroup.TabIndex = 17;
            this.btnAddGroup.Text = "Create Group";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.ButtonAddGroup_Click);
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.Location = new System.Drawing.Point(772, 70);
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteGroup.TabIndex = 18;
            this.btnDeleteGroup.Text = "Delete Group";
            this.btnDeleteGroup.UseVisualStyleBackColor = true;
            this.btnDeleteGroup.Click += new System.EventHandler(this.ButtonDeleteGroup_Click);
            // 
            // VolumeGroupManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 349);
            this.Controls.Add(this.btnDeleteGroup);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnModifyGroup);
            this.Controls.Add(this.lvVolumeGroups);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VolumeGroupManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Volume Group Manager";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvVolumeGroups;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chIsArchive;
        private System.Windows.Forms.ColumnHeader chVolumes;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chRelations;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnModifyGroup;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.Button btnDeleteGroup;
    }
}