namespace ExampleClient.Source
{
    partial class AccessPointManagerForm
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
            this.lvAccessPointManager = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.btnRelations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvAccessPointManager
            // 
            this.lvAccessPointManager.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chId,
            this.chState,
            this.chType,
            this.chStatus});
            this.lvAccessPointManager.FullRowSelect = true;
            this.lvAccessPointManager.GridLines = true;
            this.lvAccessPointManager.HideSelection = false;
            this.lvAccessPointManager.Location = new System.Drawing.Point(12, 12);
            this.lvAccessPointManager.MultiSelect = false;
            this.lvAccessPointManager.Name = "lvAccessPointManager";
            this.lvAccessPointManager.Size = new System.Drawing.Size(703, 320);
            this.lvAccessPointManager.TabIndex = 0;
            this.lvAccessPointManager.UseCompatibleStateImageBehavior = false;
            this.lvAccessPointManager.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 135;
            // 
            // chId
            // 
            this.chId.Text = "ID";
            this.chId.Width = 224;
            // 
            // chState
            // 
            this.chState.Text = "State";
            this.chState.Width = 78;
            // 
            // chType
            // 
            this.chType.Text = "Type";
            this.chType.Width = 75;
            // 
            // chStatus
            // 
            this.chStatus.Text = "Status";
            this.chStatus.Width = 150;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(721, 128);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(89, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(721, 12);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(89, 23);
            this.btnModify.TabIndex = 13;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.ButtonModify_Click);
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(721, 41);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(89, 23);
            this.btnLock.TabIndex = 14;
            this.btnLock.Text = "Lock";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.ButtonLock_Click);
            // 
            // btnUnlock
            // 
            this.btnUnlock.Location = new System.Drawing.Point(721, 70);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(89, 23);
            this.btnUnlock.TabIndex = 15;
            this.btnUnlock.Text = "Unlock";
            this.btnUnlock.UseVisualStyleBackColor = true;
            this.btnUnlock.Click += new System.EventHandler(this.ButtonUnlock_Click);
            // 
            // btnRelations
            // 
            this.btnRelations.Location = new System.Drawing.Point(721, 99);
            this.btnRelations.Name = "btnRelations";
            this.btnRelations.Size = new System.Drawing.Size(89, 23);
            this.btnRelations.TabIndex = 16;
            this.btnRelations.Text = "Relations";
            this.btnRelations.UseVisualStyleBackColor = true;
            this.btnRelations.Click += new System.EventHandler(this.ButtonRelations_Click);
            // 
            // AccessPointManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 350);
            this.Controls.Add(this.btnRelations);
            this.Controls.Add(this.btnUnlock);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lvAccessPointManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccessPointManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Access Point Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvAccessPointManager;
        private System.Windows.Forms.ColumnHeader chStatus;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.ColumnHeader chState;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.Button btnRelations;
    }
}