namespace ExampleClient.Source
{
    partial class AnalyticSessionManagerForm
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
            this.lvAnalyticSessionManager = new System.Windows.Forms.ListView();
            this.chChecked = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDataEncodingId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSource = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDevice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDataSource = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNewBookmark = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.chBehaviors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvAnalyticSessionManager
            // 
            this.lvAnalyticSessionManager.CheckBoxes = true;
            this.lvAnalyticSessionManager.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chChecked,
            this.chId,
            this.chDataEncodingId,
            this.chSource,
            this.chDevice,
            this.chDataSource,
            this.chBehaviors});
            this.lvAnalyticSessionManager.FullRowSelect = true;
            this.lvAnalyticSessionManager.GridLines = true;
            this.lvAnalyticSessionManager.HideSelection = false;
            this.lvAnalyticSessionManager.Location = new System.Drawing.Point(12, 12);
            this.lvAnalyticSessionManager.MultiSelect = false;
            this.lvAnalyticSessionManager.Name = "lvAnalyticSessionManager";
            this.lvAnalyticSessionManager.Size = new System.Drawing.Size(1028, 320);
            this.lvAnalyticSessionManager.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvAnalyticSessionManager.TabIndex = 0;
            this.lvAnalyticSessionManager.UseCompatibleStateImageBehavior = false;
            this.lvAnalyticSessionManager.View = System.Windows.Forms.View.Details;
            this.lvAnalyticSessionManager.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ListViewBookmarkManager_ItemCheck);
            this.lvAnalyticSessionManager.SelectedIndexChanged += new System.EventHandler(this.ListViewBookmarkManager_SelectedIndexChanged);
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
            // chDataEncodingId
            // 
            this.chDataEncodingId.Text = "Data Encoding";
            this.chDataEncodingId.Width = 130;
            // 
            // chSource
            // 
            this.chSource.Text = "Source";
            this.chSource.Width = 260;
            // 
            // chDevice
            // 
            this.chDevice.Text = "Device";
            this.chDevice.Width = 165;
            // 
            // chDataSource
            // 
            this.chDataSource.Text = "Data Source";
            this.chDataSource.Width = 165;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1046, 70);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // btnNewBookmark
            // 
            this.btnNewBookmark.Location = new System.Drawing.Point(1046, 12);
            this.btnNewBookmark.Name = "btnNewBookmark";
            this.btnNewBookmark.Size = new System.Drawing.Size(90, 23);
            this.btnNewBookmark.TabIndex = 3;
            this.btnNewBookmark.Text = "New Session";
            this.btnNewBookmark.UseVisualStyleBackColor = true;
            this.btnNewBookmark.Click += new System.EventHandler(this.ButtonNewBookmark_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1046, 128);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(89, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(1046, 41);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(90, 23);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.ButtonModify_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(1047, 99);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(89, 23);
            this.btnConfig.TabIndex = 6;
            this.btnConfig.Text = "Config";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.ButtonConfig_Click);
            // 
            // chBehaviors
            // 
            this.chBehaviors.Text = "Behaviors";
            // 
            // AnalyticSessionManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 350);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnNewBookmark);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lvAnalyticSessionManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnalyticSessionManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Analytic Session Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvAnalyticSessionManager;
        private System.Windows.Forms.ColumnHeader chDevice;
        private System.Windows.Forms.ColumnHeader chDataEncodingId;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNewBookmark;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ColumnHeader chSource;
        private System.Windows.Forms.ColumnHeader chDataSource;
        private System.Windows.Forms.ColumnHeader chChecked;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.ColumnHeader chBehaviors;
    }
}