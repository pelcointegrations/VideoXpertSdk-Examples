namespace ExampleClient.Source
{
    partial class MemberManagerForm
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
            this.lvMemberManager = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCapabilities = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.chPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBandwidth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvMemberManager
            // 
            this.lvMemberManager.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chId,
            this.chHost,
            this.chPort,
            this.chUsername,
            this.chBandwidth,
            this.chState,
            this.chCapabilities});
            this.lvMemberManager.FullRowSelect = true;
            this.lvMemberManager.GridLines = true;
            this.lvMemberManager.HideSelection = false;
            this.lvMemberManager.Location = new System.Drawing.Point(12, 12);
            this.lvMemberManager.MultiSelect = false;
            this.lvMemberManager.Name = "lvMemberManager";
            this.lvMemberManager.Size = new System.Drawing.Size(906, 320);
            this.lvMemberManager.TabIndex = 0;
            this.lvMemberManager.UseCompatibleStateImageBehavior = false;
            this.lvMemberManager.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 156;
            // 
            // chHost
            // 
            this.chHost.Text = "Host";
            this.chHost.Width = 127;
            // 
            // chId
            // 
            this.chId.Text = "ID";
            this.chId.Width = 224;
            // 
            // chState
            // 
            this.chState.Text = "State";
            this.chState.Width = 100;
            // 
            // chCapabilities
            // 
            this.chCapabilities.Text = "Capabilities";
            this.chCapabilities.Width = 95;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(924, 99);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(89, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(924, 70);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(89, 23);
            this.btnModify.TabIndex = 13;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.ButtonModify_Click);
            // 
            // chPort
            // 
            this.chPort.Text = "Port";
            // 
            // chUsername
            // 
            this.chUsername.Text = "Username";
            this.chUsername.Width = 68;
            // 
            // chBandwidth
            // 
            this.chBandwidth.Text = "Bandwidth";
            this.chBandwidth.Width = 72;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(924, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(924, 41);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(89, 23);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // MemberManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 350);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lvMemberManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MemberManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Member System Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvMemberManager;
        private System.Windows.Forms.ColumnHeader chHost;
        private System.Windows.Forms.ColumnHeader chState;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.ColumnHeader chCapabilities;
        private System.Windows.Forms.ColumnHeader chPort;
        private System.Windows.Forms.ColumnHeader chUsername;
        private System.Windows.Forms.ColumnHeader chBandwidth;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
    }
}