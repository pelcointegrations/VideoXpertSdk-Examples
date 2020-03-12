namespace ExampleClient.Source
{
    partial class ManageMonitorSelectionsForm
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
            this.lvMonitors = new System.Windows.Forms.ListView();
            this.colHeadUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadMonitor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadCell = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadInputMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnChangeMode = new System.Windows.Forms.Button();
            this.gbxCurrentSelections = new System.Windows.Forms.GroupBox();
            this.gbxCurrentSelections.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvMonitors
            // 
            this.lvMonitors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadUser,
            this.colHeadMonitor,
            this.colHeadCell,
            this.colHeadInputMode});
            this.lvMonitors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMonitors.FullRowSelect = true;
            this.lvMonitors.HideSelection = false;
            this.lvMonitors.Location = new System.Drawing.Point(3, 16);
            this.lvMonitors.MultiSelect = false;
            this.lvMonitors.Name = "lvMonitors";
            this.lvMonitors.Size = new System.Drawing.Size(289, 749);
            this.lvMonitors.TabIndex = 2;
            this.lvMonitors.UseCompatibleStateImageBehavior = false;
            this.lvMonitors.View = System.Windows.Forms.View.Details;
            // 
            // colHeadUser
            // 
            this.colHeadUser.Text = "User";
            this.colHeadUser.Width = 100;
            // 
            // colHeadMonitor
            // 
            this.colHeadMonitor.Text = "Monitor";
            this.colHeadMonitor.Width = 50;
            // 
            // colHeadCell
            // 
            this.colHeadCell.Text = "Cell";
            this.colHeadCell.Width = 50;
            // 
            // colHeadInputMode
            // 
            this.colHeadInputMode.Text = "Mode";
            this.colHeadInputMode.Width = 85;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(1263, 786);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1081, 786);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear Selection";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1018, 786);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(57, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Black;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMain.Location = new System.Drawing.Point(12, 9);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1000, 800);
            this.pnlMain.TabIndex = 9;
            // 
            // btnChangeMode
            // 
            this.btnChangeMode.Location = new System.Drawing.Point(1174, 786);
            this.btnChangeMode.Name = "btnChangeMode";
            this.btnChangeMode.Size = new System.Drawing.Size(83, 23);
            this.btnChangeMode.TabIndex = 10;
            this.btnChangeMode.Text = "Change Mode";
            this.btnChangeMode.UseVisualStyleBackColor = true;
            this.btnChangeMode.Click += new System.EventHandler(this.ButtonChangeMode_Click);
            // 
            // gbxCurrentSelections
            // 
            this.gbxCurrentSelections.Controls.Add(this.lvMonitors);
            this.gbxCurrentSelections.Location = new System.Drawing.Point(1018, 12);
            this.gbxCurrentSelections.Name = "gbxCurrentSelections";
            this.gbxCurrentSelections.Size = new System.Drawing.Size(295, 768);
            this.gbxCurrentSelections.TabIndex = 11;
            this.gbxCurrentSelections.TabStop = false;
            this.gbxCurrentSelections.Text = "Current Selections";
            // 
            // ManageMonitorSelectionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 820);
            this.Controls.Add(this.btnChangeMode);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbxCurrentSelections);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageMonitorSelectionsForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Monitor Wall Selections";
            this.gbxCurrentSelections.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public  System.Windows.Forms.ListView lvMonitors;
        private System.Windows.Forms.ColumnHeader colHeadMonitor;
        private System.Windows.Forms.ColumnHeader colHeadUser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ColumnHeader colHeadCell;
        private System.Windows.Forms.ColumnHeader colHeadInputMode;
        private System.Windows.Forms.Button btnChangeMode;
        private System.Windows.Forms.GroupBox gbxCurrentSelections;
    }
}