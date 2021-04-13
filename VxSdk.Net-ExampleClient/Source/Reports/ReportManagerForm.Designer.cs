namespace ExampleClient.Source
{
    partial class ReportManagerForm
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
            this.lvReports = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGenerated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFileType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOk = new System.Windows.Forms.Button();
            this.gbxReports = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnDeleteReport = new System.Windows.Forms.Button();
            this.gbxReportTemplates = new System.Windows.Forms.GroupBox();
            this.btnDeleteTemplate = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvTemplates = new System.Windows.Forms.ListView();
            this.chTemplateName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTemplateType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxSettings = new System.Windows.Forms.GroupBox();
            this.gbxIncludeRows = new System.Windows.Forms.GroupBox();
            this.tbxInclude = new System.Windows.Forms.TextBox();
            this.gbxIncludeColumns = new System.Windows.Forms.GroupBox();
            this.tvFields = new System.Windows.Forms.TreeView();
            this.lblReportName = new System.Windows.Forms.Label();
            this.tbxReportName = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.gbxReports.SuspendLayout();
            this.gbxReportTemplates.SuspendLayout();
            this.gbxSettings.SuspendLayout();
            this.gbxIncludeRows.SuspendLayout();
            this.gbxIncludeColumns.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvReports
            // 
            this.lvReports.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chGenerated,
            this.chFileType,
            this.chStatus});
            this.lvReports.FullRowSelect = true;
            this.lvReports.GridLines = true;
            this.lvReports.HideSelection = false;
            this.lvReports.Location = new System.Drawing.Point(6, 19);
            this.lvReports.MultiSelect = false;
            this.lvReports.Name = "lvReports";
            this.lvReports.Size = new System.Drawing.Size(868, 150);
            this.lvReports.TabIndex = 0;
            this.lvReports.UseCompatibleStateImageBehavior = false;
            this.lvReports.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 362;
            // 
            // chGenerated
            // 
            this.chGenerated.Text = "Date / Time Generated";
            this.chGenerated.Width = 177;
            // 
            // chFileType
            // 
            this.chFileType.Text = "File Type";
            this.chFileType.Width = 59;
            // 
            // chStatus
            // 
            this.chStatus.Text = "Generation Status";
            this.chStatus.Width = 264;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(902, 550);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(89, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // gbxReports
            // 
            this.gbxReports.Controls.Add(this.btnRefresh);
            this.gbxReports.Controls.Add(this.btnDownload);
            this.gbxReports.Controls.Add(this.btnDeleteReport);
            this.gbxReports.Controls.Add(this.lvReports);
            this.gbxReports.Location = new System.Drawing.Point(12, 364);
            this.gbxReports.Name = "gbxReports";
            this.gbxReports.Size = new System.Drawing.Size(979, 180);
            this.gbxReports.TabIndex = 7;
            this.gbxReports.TabStop = false;
            this.gbxReports.Text = "Generated Reports";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(880, 48);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(89, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(880, 19);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(89, 23);
            this.btnDownload.TabIndex = 10;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.ButtonDownload_Click);
            // 
            // btnDeleteReport
            // 
            this.btnDeleteReport.Location = new System.Drawing.Point(880, 77);
            this.btnDeleteReport.Name = "btnDeleteReport";
            this.btnDeleteReport.Size = new System.Drawing.Size(89, 23);
            this.btnDeleteReport.TabIndex = 9;
            this.btnDeleteReport.Text = "Delete";
            this.btnDeleteReport.UseVisualStyleBackColor = true;
            this.btnDeleteReport.Click += new System.EventHandler(this.ButtonDeleteReport_Click);
            // 
            // gbxReportTemplates
            // 
            this.gbxReportTemplates.Controls.Add(this.btnDeleteTemplate);
            this.gbxReportTemplates.Controls.Add(this.btnModify);
            this.gbxReportTemplates.Controls.Add(this.btnAdd);
            this.gbxReportTemplates.Controls.Add(this.lvTemplates);
            this.gbxReportTemplates.Location = new System.Drawing.Point(12, 12);
            this.gbxReportTemplates.Name = "gbxReportTemplates";
            this.gbxReportTemplates.Size = new System.Drawing.Size(369, 346);
            this.gbxReportTemplates.TabIndex = 8;
            this.gbxReportTemplates.TabStop = false;
            this.gbxReportTemplates.Text = "Report Templates";
            // 
            // btnDeleteTemplate
            // 
            this.btnDeleteTemplate.Location = new System.Drawing.Point(266, 317);
            this.btnDeleteTemplate.Name = "btnDeleteTemplate";
            this.btnDeleteTemplate.Size = new System.Drawing.Size(89, 23);
            this.btnDeleteTemplate.TabIndex = 13;
            this.btnDeleteTemplate.Text = "Delete";
            this.btnDeleteTemplate.UseVisualStyleBackColor = true;
            this.btnDeleteTemplate.Click += new System.EventHandler(this.ButtonDeleteTemplate_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(137, 317);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(89, 23);
            this.btnModify.TabIndex = 12;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.ButtonModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 317);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // lvTemplates
            // 
            this.lvTemplates.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTemplateName,
            this.chTemplateType});
            this.lvTemplates.FullRowSelect = true;
            this.lvTemplates.GridLines = true;
            this.lvTemplates.HideSelection = false;
            this.lvTemplates.Location = new System.Drawing.Point(8, 19);
            this.lvTemplates.MultiSelect = false;
            this.lvTemplates.Name = "lvTemplates";
            this.lvTemplates.Size = new System.Drawing.Size(345, 292);
            this.lvTemplates.TabIndex = 0;
            this.lvTemplates.UseCompatibleStateImageBehavior = false;
            this.lvTemplates.View = System.Windows.Forms.View.Details;
            this.lvTemplates.SelectedIndexChanged += new System.EventHandler(this.ListViewTemplates_SelectedIndexChanged);
            // 
            // chTemplateName
            // 
            this.chTemplateName.Text = "Name";
            this.chTemplateName.Width = 214;
            // 
            // chTemplateType
            // 
            this.chTemplateType.Text = "Type";
            this.chTemplateType.Width = 127;
            // 
            // gbxSettings
            // 
            this.gbxSettings.Controls.Add(this.gbxIncludeRows);
            this.gbxSettings.Controls.Add(this.gbxIncludeColumns);
            this.gbxSettings.Controls.Add(this.lblReportName);
            this.gbxSettings.Controls.Add(this.tbxReportName);
            this.gbxSettings.Controls.Add(this.btnGenerate);
            this.gbxSettings.Location = new System.Drawing.Point(387, 12);
            this.gbxSettings.Name = "gbxSettings";
            this.gbxSettings.Size = new System.Drawing.Size(604, 346);
            this.gbxSettings.TabIndex = 15;
            this.gbxSettings.TabStop = false;
            this.gbxSettings.Text = "Template Settings";
            // 
            // gbxIncludeRows
            // 
            this.gbxIncludeRows.Controls.Add(this.tbxInclude);
            this.gbxIncludeRows.Location = new System.Drawing.Point(10, 19);
            this.gbxIncludeRows.Name = "gbxIncludeRows";
            this.gbxIncludeRows.Size = new System.Drawing.Size(335, 292);
            this.gbxIncludeRows.TabIndex = 40;
            this.gbxIncludeRows.TabStop = false;
            this.gbxIncludeRows.Text = "Include (rows)";
            // 
            // tbxInclude
            // 
            this.tbxInclude.BackColor = System.Drawing.SystemColors.Control;
            this.tbxInclude.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxInclude.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbxInclude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxInclude.Location = new System.Drawing.Point(3, 16);
            this.tbxInclude.Multiline = true;
            this.tbxInclude.Name = "tbxInclude";
            this.tbxInclude.ReadOnly = true;
            this.tbxInclude.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxInclude.Size = new System.Drawing.Size(329, 273);
            this.tbxInclude.TabIndex = 41;
            this.tbxInclude.WordWrap = false;
            // 
            // gbxIncludeColumns
            // 
            this.gbxIncludeColumns.Controls.Add(this.tvFields);
            this.gbxIncludeColumns.Location = new System.Drawing.Point(351, 19);
            this.gbxIncludeColumns.Name = "gbxIncludeColumns";
            this.gbxIncludeColumns.Size = new System.Drawing.Size(243, 292);
            this.gbxIncludeColumns.TabIndex = 39;
            this.gbxIncludeColumns.TabStop = false;
            this.gbxIncludeColumns.Text = "Include Info (columns)";
            // 
            // tvFields
            // 
            this.tvFields.BackColor = System.Drawing.SystemColors.Control;
            this.tvFields.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFields.Location = new System.Drawing.Point(3, 16);
            this.tvFields.Name = "tvFields";
            this.tvFields.Size = new System.Drawing.Size(237, 273);
            this.tvFields.TabIndex = 19;
            // 
            // lblReportName
            // 
            this.lblReportName.AutoSize = true;
            this.lblReportName.Location = new System.Drawing.Point(144, 324);
            this.lblReportName.Name = "lblReportName";
            this.lblReportName.Size = new System.Drawing.Size(73, 13);
            this.lblReportName.TabIndex = 38;
            this.lblReportName.Text = "Report Name:";
            // 
            // tbxReportName
            // 
            this.tbxReportName.Location = new System.Drawing.Point(223, 320);
            this.tbxReportName.Name = "tbxReportName";
            this.tbxReportName.Size = new System.Drawing.Size(266, 20);
            this.tbxReportName.TabIndex = 33;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Enabled = false;
            this.btnGenerate.Location = new System.Drawing.Point(495, 317);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(99, 23);
            this.btnGenerate.TabIndex = 14;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // ReportManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 582);
            this.Controls.Add(this.gbxSettings);
            this.Controls.Add(this.gbxReportTemplates);
            this.Controls.Add(this.gbxReports);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report Manager";
            this.gbxReports.ResumeLayout(false);
            this.gbxReportTemplates.ResumeLayout(false);
            this.gbxSettings.ResumeLayout(false);
            this.gbxSettings.PerformLayout();
            this.gbxIncludeRows.ResumeLayout(false);
            this.gbxIncludeRows.PerformLayout();
            this.gbxIncludeColumns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvReports;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chGenerated;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox gbxReports;
        private System.Windows.Forms.GroupBox gbxReportTemplates;
        private System.Windows.Forms.ListView lvTemplates;
        private System.Windows.Forms.ColumnHeader chTemplateName;
        private System.Windows.Forms.ColumnHeader chTemplateType;
        private System.Windows.Forms.ColumnHeader chFileType;
        private System.Windows.Forms.ColumnHeader chStatus;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnDeleteReport;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnDeleteTemplate;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxSettings;
        private System.Windows.Forms.TreeView tvFields;
        private System.Windows.Forms.Label lblReportName;
        private System.Windows.Forms.TextBox tbxReportName;
        private System.Windows.Forms.GroupBox gbxIncludeRows;
        private System.Windows.Forms.TextBox tbxInclude;
        private System.Windows.Forms.GroupBox gbxIncludeColumns;
        private System.Windows.Forms.Button btnRefresh;
    }
}