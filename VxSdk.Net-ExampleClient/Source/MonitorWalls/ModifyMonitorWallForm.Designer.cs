namespace ExampleClient.Source
{
    partial class ModifyMonitorWallForm
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
            this.colHeadName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.lblMonitorList = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lvMonitors
            // 
            this.lvMonitors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadNumber,
            this.colHeadName});
            this.lvMonitors.FullRowSelect = true;
            this.lvMonitors.HideSelection = false;
            this.lvMonitors.Location = new System.Drawing.Point(748, 27);
            this.lvMonitors.MultiSelect = false;
            this.lvMonitors.Name = "lvMonitors";
            this.lvMonitors.Size = new System.Drawing.Size(230, 609);
            this.lvMonitors.TabIndex = 2;
            this.lvMonitors.UseCompatibleStateImageBehavior = false;
            this.lvMonitors.View = System.Windows.Forms.View.Details;
            this.lvMonitors.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.ListViewDataSources_OnItemDrag);
            // 
            // colHeadName
            // 
            this.colHeadName.Text = "Name";
            this.colHeadName.Width = 176;
            // 
            // colHeadNumber
            // 
            this.colHeadNumber.Text = "#";
            this.colHeadNumber.Width = 50;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(925, 642);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(870, 642);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(748, 642);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(117, 23);
            this.btnRename.TabIndex = 7;
            this.btnRename.Text = "Rename Monitor Wall";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.ButtonRename_Click);
            // 
            // lblMonitorList
            // 
            this.lblMonitorList.AutoSize = true;
            this.lblMonitorList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonitorList.Location = new System.Drawing.Point(808, 9);
            this.lblMonitorList.Name = "lblMonitorList";
            this.lblMonitorList.Size = new System.Drawing.Size(93, 13);
            this.lblMonitorList.TabIndex = 8;
            this.lblMonitorList.Text = "Available Monitors";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Black;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMain.Location = new System.Drawing.Point(12, 9);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(730, 656);
            this.pnlMain.TabIndex = 9;
            this.pnlMain.DragDrop += new System.Windows.Forms.DragEventHandler(this.PanelMain_OnDragDrop);
            this.pnlMain.DragEnter += new System.Windows.Forms.DragEventHandler(this.PanelMain_OnDragEnter);
            // 
            // ModifyMonitorWallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 669);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lblMonitorList);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lvMonitors);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyMonitorWallForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ListView lvMonitors;
        private System.Windows.Forms.ColumnHeader colHeadName;
        private System.Windows.Forms.ColumnHeader colHeadNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Label lblMonitorList;
        private System.Windows.Forms.Panel pnlMain;
    }
}