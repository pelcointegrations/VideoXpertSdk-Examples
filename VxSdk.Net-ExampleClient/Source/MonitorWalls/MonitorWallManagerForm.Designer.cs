namespace ExampleClient.Source
{
    partial class MonitorWallManagerForm
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
            if(disposing && (components != null))
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
            this.lvMonitorWallManager = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMonitorCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNewMonitorWall = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnManageSelections = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvMonitorWallManager
            // 
            this.lvMonitorWallManager.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chMonitorCount});
            this.lvMonitorWallManager.FullRowSelect = true;
            this.lvMonitorWallManager.GridLines = true;
            this.lvMonitorWallManager.HideSelection = false;
            this.lvMonitorWallManager.Location = new System.Drawing.Point(9, 10);
            this.lvMonitorWallManager.MultiSelect = false;
            this.lvMonitorWallManager.Name = "lvMonitorWallManager";
            this.lvMonitorWallManager.Size = new System.Drawing.Size(387, 197);
            this.lvMonitorWallManager.TabIndex = 0;
            this.lvMonitorWallManager.UseCompatibleStateImageBehavior = false;
            this.lvMonitorWallManager.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 302;
            // 
            // chMonitorCount
            // 
            this.chMonitorCount.Text = "Monitor Count";
            this.chMonitorCount.Width = 81;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(403, 97);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // btnNewMonitorWall
            // 
            this.btnNewMonitorWall.Location = new System.Drawing.Point(402, 10);
            this.btnNewMonitorWall.Name = "btnNewMonitorWall";
            this.btnNewMonitorWall.Size = new System.Drawing.Size(113, 23);
            this.btnNewMonitorWall.TabIndex = 3;
            this.btnNewMonitorWall.Text = "New Monitor Wall";
            this.btnNewMonitorWall.UseVisualStyleBackColor = true;
            this.btnNewMonitorWall.Click += new System.EventHandler(this.ButtonNewMonitorWall_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(403, 126);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(402, 39);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(113, 23);
            this.btnModify.TabIndex = 6;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.ButtonModify_Click);
            // 
            // btnManageSelections
            // 
            this.btnManageSelections.Location = new System.Drawing.Point(403, 68);
            this.btnManageSelections.Name = "btnManageSelections";
            this.btnManageSelections.Size = new System.Drawing.Size(112, 23);
            this.btnManageSelections.TabIndex = 7;
            this.btnManageSelections.Text = "Manage Selections";
            this.btnManageSelections.UseVisualStyleBackColor = true;
            this.btnManageSelections.Click += new System.EventHandler(this.ButtonManageSelections_Click);
            // 
            // MonitorWallManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 217);
            this.Controls.Add(this.btnManageSelections);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnNewMonitorWall);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lvMonitorWallManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MonitorWallManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Monitor Wall Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvMonitorWallManager;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chMonitorCount;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNewMonitorWall;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnManageSelections;
    }
}