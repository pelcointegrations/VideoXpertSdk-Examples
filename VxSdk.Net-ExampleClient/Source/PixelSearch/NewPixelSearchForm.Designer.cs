namespace ExampleClient.Source
{
    partial class NewPixelSearchForm
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
            this.lvZones = new System.Windows.Forms.ListView();
            this.chSelection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLeft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chWidth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.gbxSearchStartTime = new System.Windows.Forms.GroupBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.nudRows = new System.Windows.Forms.NumericUpDown();
            this.nudColumns = new System.Windows.Forms.NumericUpDown();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblColumns = new System.Windows.Forms.Label();
            this.gbxSearchGrid = new System.Windows.Forms.GroupBox();
            this.btnAddZone = new System.Windows.Forms.Button();
            this.gbxSearchEndTime = new System.Windows.Forms.GroupBox();
            this.gbxSearchZones = new System.Windows.Forms.GroupBox();
            this.btnRemoveZone = new System.Windows.Forms.Button();
            this.gbxDataSource = new System.Windows.Forms.GroupBox();
            this.cbxDataSources = new System.Windows.Forms.ComboBox();
            this.gbxSearchStartTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).BeginInit();
            this.gbxSearchGrid.SuspendLayout();
            this.gbxSearchEndTime.SuspendLayout();
            this.gbxSearchZones.SuspendLayout();
            this.gbxDataSource.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvZones
            // 
            this.lvZones.CheckBoxes = true;
            this.lvZones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSelection,
            this.chLeft,
            this.chTop,
            this.chWidth,
            this.chHeight});
            this.lvZones.FullRowSelect = true;
            this.lvZones.GridLines = true;
            this.lvZones.Location = new System.Drawing.Point(6, 19);
            this.lvZones.MultiSelect = false;
            this.lvZones.Name = "lvZones";
            this.lvZones.Size = new System.Drawing.Size(219, 242);
            this.lvZones.TabIndex = 0;
            this.lvZones.UseCompatibleStateImageBehavior = false;
            this.lvZones.View = System.Windows.Forms.View.Details;
            // 
            // chSelection
            // 
            this.chSelection.Text = "";
            this.chSelection.Width = 30;
            // 
            // chLeft
            // 
            this.chLeft.Text = "Left";
            this.chLeft.Width = 45;
            // 
            // chTop
            // 
            this.chTop.Text = "Top";
            this.chTop.Width = 45;
            // 
            // chWidth
            // 
            this.chWidth.Text = "Width";
            this.chWidth.Width = 45;
            // 
            // chHeight
            // 
            this.chHeight.Text = "Height";
            this.chHeight.Width = 45;
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(481, 285);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "HH:mm:ss  MM/dd/yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(12, 24);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(216, 20);
            this.dtpEndDate.TabIndex = 2;
            // 
            // gbxSearchStartTime
            // 
            this.gbxSearchStartTime.Controls.Add(this.dtpStartDate);
            this.gbxSearchStartTime.Enabled = false;
            this.gbxSearchStartTime.Location = new System.Drawing.Point(12, 77);
            this.gbxSearchStartTime.Name = "gbxSearchStartTime";
            this.gbxSearchStartTime.Size = new System.Drawing.Size(249, 63);
            this.gbxSearchStartTime.TabIndex = 15;
            this.gbxSearchStartTime.TabStop = false;
            this.gbxSearchStartTime.Text = "Start Time";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "HH:mm:ss  MM/dd/yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(12, 26);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(216, 20);
            this.dtpStartDate.TabIndex = 2;
            // 
            // nudRows
            // 
            this.nudRows.Location = new System.Drawing.Point(175, 29);
            this.nudRows.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRows.Name = "nudRows";
            this.nudRows.Size = new System.Drawing.Size(53, 20);
            this.nudRows.TabIndex = 17;
            this.nudRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudColumns
            // 
            this.nudColumns.Location = new System.Drawing.Point(62, 29);
            this.nudColumns.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudColumns.Name = "nudColumns";
            this.nudColumns.Size = new System.Drawing.Size(53, 20);
            this.nudColumns.TabIndex = 18;
            this.nudColumns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(135, 32);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(34, 13);
            this.lblRows.TabIndex = 19;
            this.lblRows.Text = "Rows";
            this.lblRows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(9, 32);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(47, 13);
            this.lblColumns.TabIndex = 20;
            this.lblColumns.Text = "Columns";
            this.lblColumns.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbxSearchGrid
            // 
            this.gbxSearchGrid.Controls.Add(this.lblColumns);
            this.gbxSearchGrid.Controls.Add(this.nudRows);
            this.gbxSearchGrid.Controls.Add(this.lblRows);
            this.gbxSearchGrid.Controls.Add(this.nudColumns);
            this.gbxSearchGrid.Enabled = false;
            this.gbxSearchGrid.Location = new System.Drawing.Point(12, 211);
            this.gbxSearchGrid.Name = "gbxSearchGrid";
            this.gbxSearchGrid.Size = new System.Drawing.Size(252, 68);
            this.gbxSearchGrid.TabIndex = 21;
            this.gbxSearchGrid.TabStop = false;
            this.gbxSearchGrid.Text = "Search Grid";
            // 
            // btnAddZone
            // 
            this.btnAddZone.Location = new System.Drawing.Point(231, 19);
            this.btnAddZone.Name = "btnAddZone";
            this.btnAddZone.Size = new System.Drawing.Size(63, 23);
            this.btnAddZone.TabIndex = 22;
            this.btnAddZone.Text = "Add";
            this.btnAddZone.UseVisualStyleBackColor = true;
            this.btnAddZone.Click += new System.EventHandler(this.ButtonAddZone_Click);
            // 
            // gbxSearchEndTime
            // 
            this.gbxSearchEndTime.Controls.Add(this.dtpEndDate);
            this.gbxSearchEndTime.Enabled = false;
            this.gbxSearchEndTime.Location = new System.Drawing.Point(12, 146);
            this.gbxSearchEndTime.Name = "gbxSearchEndTime";
            this.gbxSearchEndTime.Size = new System.Drawing.Size(249, 59);
            this.gbxSearchEndTime.TabIndex = 16;
            this.gbxSearchEndTime.TabStop = false;
            this.gbxSearchEndTime.Text = "End Time";
            // 
            // gbxSearchZones
            // 
            this.gbxSearchZones.Controls.Add(this.btnRemoveZone);
            this.gbxSearchZones.Controls.Add(this.btnAddZone);
            this.gbxSearchZones.Controls.Add(this.lvZones);
            this.gbxSearchZones.Enabled = false;
            this.gbxSearchZones.Location = new System.Drawing.Point(270, 12);
            this.gbxSearchZones.Name = "gbxSearchZones";
            this.gbxSearchZones.Size = new System.Drawing.Size(300, 267);
            this.gbxSearchZones.TabIndex = 22;
            this.gbxSearchZones.TabStop = false;
            this.gbxSearchZones.Text = "Zones";
            // 
            // btnRemoveZone
            // 
            this.btnRemoveZone.Location = new System.Drawing.Point(231, 48);
            this.btnRemoveZone.Name = "btnRemoveZone";
            this.btnRemoveZone.Size = new System.Drawing.Size(63, 23);
            this.btnRemoveZone.TabIndex = 24;
            this.btnRemoveZone.Text = "Remove";
            this.btnRemoveZone.UseVisualStyleBackColor = true;
            this.btnRemoveZone.Click += new System.EventHandler(this.ButtonRemoveZone_Click);
            // 
            // gbxDataSource
            // 
            this.gbxDataSource.Controls.Add(this.cbxDataSources);
            this.gbxDataSource.Location = new System.Drawing.Point(12, 12);
            this.gbxDataSource.Name = "gbxDataSource";
            this.gbxDataSource.Size = new System.Drawing.Size(249, 59);
            this.gbxDataSource.TabIndex = 17;
            this.gbxDataSource.TabStop = false;
            this.gbxDataSource.Text = "Data Source";
            // 
            // cbxDataSources
            // 
            this.cbxDataSources.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDataSources.FormattingEnabled = true;
            this.cbxDataSources.Location = new System.Drawing.Point(6, 24);
            this.cbxDataSources.Name = "cbxDataSources";
            this.cbxDataSources.Size = new System.Drawing.Size(236, 21);
            this.cbxDataSources.TabIndex = 0;
            this.cbxDataSources.SelectedIndexChanged += new System.EventHandler(this.ComboboxDataSources_SelectedIndexChanged);
            // 
            // NewPixelSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 317);
            this.Controls.Add(this.gbxDataSource);
            this.Controls.Add(this.gbxSearchZones);
            this.Controls.Add(this.gbxSearchEndTime);
            this.Controls.Add(this.gbxSearchGrid);
            this.Controls.Add(this.gbxSearchStartTime);
            this.Controls.Add(this.btnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewPixelSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pixel Search";
            this.gbxSearchStartTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).EndInit();
            this.gbxSearchGrid.ResumeLayout(false);
            this.gbxSearchGrid.PerformLayout();
            this.gbxSearchEndTime.ResumeLayout(false);
            this.gbxSearchZones.ResumeLayout(false);
            this.gbxDataSource.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvZones;
        private System.Windows.Forms.ColumnHeader chTop;
        private System.Windows.Forms.ColumnHeader chLeft;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ColumnHeader chSelection;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.GroupBox gbxSearchStartTime;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.NumericUpDown nudRows;
        private System.Windows.Forms.NumericUpDown nudColumns;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.GroupBox gbxSearchGrid;
        private System.Windows.Forms.ColumnHeader chWidth;
        private System.Windows.Forms.ColumnHeader chHeight;
        private System.Windows.Forms.Button btnAddZone;
        private System.Windows.Forms.GroupBox gbxSearchEndTime;
        private System.Windows.Forms.GroupBox gbxSearchZones;
        private System.Windows.Forms.Button btnRemoveZone;
        private System.Windows.Forms.GroupBox gbxDataSource;
        private System.Windows.Forms.ComboBox cbxDataSources;
    }
}