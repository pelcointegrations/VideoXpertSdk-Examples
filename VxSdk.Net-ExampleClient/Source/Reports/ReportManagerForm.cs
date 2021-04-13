using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The ReportManagerForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to view, create and delete
    /// reports and report templates from the VideoXpert system.</remarks>
    public partial class ReportManagerForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportManagerForm" /> class.
        /// </summary>
        public ReportManagerForm()
        {
            InitializeComponent();

            PopulateReportTemplates();
            PopulateReports();
        }

        #endregion Public Constructors

        #region Private Methods

        /// <summary>
        /// The ButtonAdd_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonAdd_Click(object sender, EventArgs args)
        {
            // Show the ModifyReportTemplateForm dialog.
            using (var modifyReportTemplateForm = new ModifyReportTemplateForm())
            {
                if (modifyReportTemplateForm.ShowDialog() != DialogResult.OK)
                    return;
            }

            // Refresh the items in the list view.
            PopulateReportTemplates();
        }

        /// <summary>
        /// The ButtonDeleteReport_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonDeleteReport_Click(object sender, EventArgs args)
        {
            if (lvReports.SelectedItems.Count == 0 || !(lvReports.SelectedItems[0].Tag is Report selectedReport))
                return;

            MainForm.CurrentSystem.DeleteReport(selectedReport);
            PopulateReports();
        }

        /// <summary>
        /// The ButtonDeleteTemplate_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonDeleteTemplate_Click(object sender, EventArgs args)
        {
            if (lvTemplates.SelectedItems.Count == 0 || !(lvTemplates.SelectedItems[0].Tag is ReportTemplate selectedReportTemplate))
                return;

            MainForm.CurrentSystem.DeleteReportTemplate(selectedReportTemplate);
            PopulateReportTemplates();
        }

        /// <summary>
        /// The ButtonDownload_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonDownload_Click(object sender, EventArgs args)
        {
            if (lvReports.SelectedItems.Count == 0 || !(lvReports.SelectedItems[0].Tag is Report report) || string.IsNullOrEmpty(report.ReportEndpoint))
                return;

            var reportFilename = $"{report.Name}.{report.Format}";
            var invalidChars = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            reportFilename = invalidChars.Aggregate(reportFilename, (current, invalidChar) => current.Replace(invalidChar.ToString(), "_"));

            // Open a save file dialog for the user to select a filename for the report download.
            using (var saveFileDialog = new SaveFileDialog { FileName = reportFilename })
            {
                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    return;

                using (var downloadForm = new DownloadProgressForm(new Uri(report.ReportEndpoint), saveFileDialog.FileName, 0))
                {
                    downloadForm.StartDownload();
                    downloadForm.ShowDialog();
                }
            }
        }

        /// <summary>
        /// The ButtonGenerate_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonGenerate_Click(object sender, EventArgs args)
        {
            if (lvTemplates.SelectedItems.Count == 0 || !(lvTemplates.SelectedItems[0].Tag is ReportTemplate selectedTemplate))
                return;

            var newReport = new NewReport
            {
                TemplateId = selectedTemplate.Id,
                Name = string.IsNullOrEmpty(tbxReportName.Text) ? selectedTemplate.Name : tbxReportName.Text
            };

            MainForm.CurrentSystem.AddReport(newReport);
            PopulateReports();
        }

        /// <summary>
        /// The ButtonModify_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonModify_Click(object sender, EventArgs args)
        {
            if (lvTemplates.SelectedItems.Count == 0 || !(lvTemplates.SelectedItems[0].Tag is ReportTemplate selectedTemplate))
                return;

            // Show the ModifyReportTemplateForm dialog.
            using (var modifyReportTemplateForm = new ModifyReportTemplateForm(selectedTemplate))
            {
                if (modifyReportTemplateForm.ShowDialog() != DialogResult.OK)
                    return;
            }

            // Refresh the items in the list view.
            PopulateReportTemplates();
        }

        /// <summary>
        /// The ButtonRefresh_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRefresh_Click(object sender, EventArgs args)
        {
            // Refresh the items in the list view.
            lvReports.Items.Clear();
            PopulateReports();
            lvReports.Refresh();
        }

        /// <summary>
        /// The ListViewTemplates_SelectedIndexChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ListViewTemplates_SelectedIndexChanged(object sender, EventArgs args)
        {
            btnGenerate.Enabled = false;
            tbxReportName.Text = string.Empty;
            tvFields.Nodes.Clear();
            tbxInclude.Clear();
            gbxIncludeRows.Text = "Include (rows)";

            if (lvTemplates.SelectedItems.Count == 0)
                return;

            var selectedTemplate = lvTemplates.SelectedItems[0].Tag as ReportTemplate;
            if (selectedTemplate == null)
                return;

            var includeType = string.Empty;
            var filterType = ReportFilter.ReportFilterType.Unknown;
            switch (selectedTemplate.Type)
            {
                case NewReportTemplate.ReportType.LineCount:
                    includeType = "Counting Lines";
                    filterType = ReportFilter.ReportFilterType.AnalyticBehavior;
                    break;
                case NewReportTemplate.ReportType.Storage:
                    includeType = "Storage";
                    filterType = ReportFilter.ReportFilterType.DataStorage;
                    break;
                case NewReportTemplate.ReportType.Device:
                case NewReportTemplate.ReportType.SystemStatus:
                    includeType = "Devices";
                    filterType = ReportFilter.ReportFilterType.Device;
                    break;
                case NewReportTemplate.ReportType.Role:
                case NewReportTemplate.ReportType.CameraRoleAccess:
                    includeType = "Roles";
                    filterType = ReportFilter.ReportFilterType.Role;
                    break;
                case NewReportTemplate.ReportType.User:
                case NewReportTemplate.ReportType.UserAction:
                    includeType = "Users";
                    filterType = ReportFilter.ReportFilterType.User;
                    break;
                case NewReportTemplate.ReportType.Event:
                    includeType = "Events";
                    filterType = ReportFilter.ReportFilterType.Situation;
                    break;
                case NewReportTemplate.ReportType.Camera:
                case NewReportTemplate.ReportType.RecordingGap:
                    includeType = "Cameras";
                    filterType = ReportFilter.ReportFilterType.DataSource;
                    break;
            }

            gbxIncludeRows.Text = $"Include {includeType} (rows)";
            gbxIncludeRows.Tag = filterType;
            btnGenerate.Enabled = true;
            tbxReportName.Text = selectedTemplate.Name;
            if (selectedTemplate.Filters.Count == 0)
                tbxInclude.Text = $"  All {includeType}";
            else
                LoadResources(selectedTemplate.Filters);
            
            foreach (var field in selectedTemplate.Fields.Where(field => field.IsEnabled))
            {
                var node = tvFields.Nodes.Add(field.Name);
                if (field.Subfields.Count <= 0)
                    continue;

                foreach (var subfield in field.Subfields.Where(subfield => subfield.IsEnabled))
                    node.Nodes.Add(subfield.Name);

                node.Expand();
            }
        }

        /// <summary>
        /// The LoadResources method.
        /// </summary>
        private void LoadResources(List<ReportFilter> filterList)
        {
            var filterType = (ReportFilter.ReportFilterType)gbxIncludeRows.Tag;
            tbxInclude.Text = string.Empty;

            switch (filterType)
            {
                case ReportFilter.ReportFilterType.AnalyticBehavior:
                    foreach (var behavior in from dataSource in MainForm.CurrentSystem.DataSources from analyticConfig in dataSource.AnalyticConfigs from behavior in analyticConfig.AnalyticBehaviors from filter in filterList where filter.FilterIds.Contains(behavior.Id) select behavior)
                        tbxInclude.Text += $"  {(string.IsNullOrEmpty(behavior.Name) ? behavior.Id : behavior.Name)}{Environment.NewLine}";
                    
                    break;
                case ReportFilter.ReportFilterType.DataSource:
                    foreach (var dataSource in from dataSource in MainForm.CurrentSystem.DataSources from filter in filterList where filter.FilterIds.Contains(dataSource.Id) select dataSource)
                        tbxInclude.Text += $"  {(string.IsNullOrEmpty(dataSource.Name) ? dataSource.Id : dataSource.Name)}{Environment.NewLine}";
                    
                    break;
                case ReportFilter.ReportFilterType.DataStorage:
                    foreach (var dataStorage in from dataStorage in MainForm.CurrentSystem.DataStorages from filter in filterList where filter.FilterIds.Contains(dataStorage.Id) select dataStorage)
                    {
                        string name;
                        if (!string.IsNullOrEmpty(dataStorage.Name))
                            name = dataStorage.Name;
                        else if (!string.IsNullOrEmpty(dataStorage.HostDevice?.Name))
                            name = dataStorage.HostDevice.Name;
                        else
                            name = dataStorage.Id;

                        tbxInclude.Text += $"  {name}{Environment.NewLine}";
                    }

                    break;
                case ReportFilter.ReportFilterType.Device:
                    foreach (var device in from device in MainForm.CurrentSystem.Devices from filter in filterList where filter.FilterIds.Contains(device.Id) select device)
                        tbxInclude.Text += $"  {(string.IsNullOrEmpty(device.Name) ? device.Id : device.Name)}{Environment.NewLine}";
                    
                    break;
                case ReportFilter.ReportFilterType.Role:
                    foreach (var role in from role in MainForm.CurrentSystem.Roles from filter in filterList where filter.FilterIds.Contains(role.Id) select role)
                        tbxInclude.Text += $"  {(string.IsNullOrEmpty(role.Name) ? role.Id : role.Name)}{Environment.NewLine}";

                    break;
                case ReportFilter.ReportFilterType.Situation:
                    foreach (var situation in from situation in MainForm.CurrentSystem.Situations from filter in filterList where filter.FilterIds.Contains(situation.Type) select situation)
                        tbxInclude.Text += $"  {(string.IsNullOrEmpty(situation.Name) ? situation.Type : situation.Name)}{Environment.NewLine}";
                    
                    break;
                case ReportFilter.ReportFilterType.User:
                    foreach (var user in from user in MainForm.CurrentSystem.Users from filter in filterList where filter.FilterIds.Contains(user.Id) select user)
                        tbxInclude.Text += $"  {(string.IsNullOrEmpty(user.Name) ? user.Id : user.Name)}{Environment.NewLine}";
                    
                    break;
            }
        }

        /// <summary>
        /// The PopulateReports method.
        /// </summary>
        private void PopulateReports()
        {
            lvReports.Items.Clear();

            // Get the existing reports from the VideoXpert system and add them to the list view.
            foreach (var report in MainForm.CurrentSystem.Reports)
            {
                var lvItem = new ListViewItem(report.Name);
                lvItem.SubItems.Add(report.Time.ToString("u"));
                lvItem.SubItems.Add(report.Format);
                lvItem.SubItems.Add(report.StatusReason != Report.ReportStatusReason.Unknown ? $"{report.Status} - {report.StatusReason}" : $"{report.Status}");
                lvItem.Tag = report;
                lvReports.Items.Add(lvItem);
            }
        }

        /// <summary>
        /// The PopulateReportTemplates method.
        /// </summary>
        private void PopulateReportTemplates()
        {
            lvTemplates.Items.Clear();
            tbxInclude.Text = string.Empty;
            tvFields.Nodes.Clear();
            tbxReportName.Text = string.Empty;

            // Get the existing report templates from the VideoXpert system and add them to the list view.
            foreach (var reportTemplate in MainForm.CurrentSystem.ReportTemplates)
            {
                var lvItem = new ListViewItem(string.IsNullOrEmpty(reportTemplate.Name) ? reportTemplate.Type.ToString() : reportTemplate.Name);
                lvItem.SubItems.Add(reportTemplate.Type.ToString());
                lvItem.Tag = reportTemplate;
                lvTemplates.Items.Add(lvItem);
            }
        }

        #endregion Private Methods
    }
}