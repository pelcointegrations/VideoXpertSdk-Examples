using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The ModifyReportTemplateForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to add or modify a report template.</remarks>
    public partial class ModifyReportTemplateForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyReportTemplateForm" /> class.
        /// </summary>
        /// <param name="reportTemplate">The <paramref name="reportTemplate"/> parameter.</param>
        public ModifyReportTemplateForm(ReportTemplate reportTemplate = null)
        {
            InitializeComponent();
            SelectedReportTemplate = reportTemplate;

            var index = -1;
            foreach (var defaultTemplate in MainForm.CurrentSystem.AvailableReportTemplates)
            {
                DefaultReportTemplates.Add(defaultTemplate);
                var cbxItem = new ComboboxItem { Text = defaultTemplate.Type.ToString(), Value = defaultTemplate };
                var tempIndex = cbxReportType.Items.Add(cbxItem);

                if (SelectedReportTemplate != null && SelectedReportTemplate.Type == defaultTemplate.Type)
                    index = tempIndex;
            }

            if (index >= 0)
            {
                this.Text = "Modify Report Template";
                cbxReportType.Enabled = false;
                cbxReportType.SelectedIndex = index;
                LoadExistingTemplate();
            }
            else
            {
                chbxSelectAll.Checked = true;
                lvFilters.Enabled = false;
                btnModifySelection.Enabled = false;
            }
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Gets or sets the AreFilterNodesChanging property.
        /// </summary>
        /// <value><c>true</c> if the filter tree view nodes are being modified.</value>
        private bool AreFilterNodesChanging { get; set; }

        /// <summary>
        /// Gets the DefaultReportTemplates property.
        /// </summary>
        /// <value>The list of default report templates.</value>
        private List<NewReportTemplate> DefaultReportTemplates { get; } = new List<NewReportTemplate>();

        /// <summary>
        /// Gets or sets the RecurrenceChanged property.
        /// </summary>
        /// <value><c>true</c> if the recurrence options have been changed.</value>
        private bool RecurrenceChanged { get; set; }

        /// <summary>
        /// Gets the SelectedReportTemplate property.
        /// </summary>
        /// <value>The currently selected report template.</value>
        private ReportTemplate SelectedReportTemplate { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonModifySelection_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonModifySelection_Click(object sender, EventArgs args)
        {
            var type = (ReportFilter.ReportFilterType)gbxIncludeRows.Tag;
            if (type == ReportFilter.ReportFilterType.Unknown)
                return;

            var filterList = SelectedReportTemplate == null ? new List<ReportFilter>() : SelectedReportTemplate.Filters;

            // Show the ReportFilterSelectionForm dialog.
            using (var reportFilterSelectionForm = new ReportFilterSelectionForm(filterList, type))
            {
                var result = reportFilterSelectionForm.ShowDialog();

                // If the dialog was closed without clicking OK then skip the refresh.
                if (result != DialogResult.OK || !reportFilterSelectionForm.HasChanged)
                    return;

                LoadFilters(reportFilterSelectionForm.NewFilterList);
            }
        }

        /// <summary>
        /// The ButtonSave_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            if (SelectedReportTemplate == null)
            {
                var selected = cbxReportType.SelectedItem as ComboboxItem;
                var newReportTemplate = (NewReportTemplate)selected?.Value;
                if (newReportTemplate == null)
                    return;

                newReportTemplate.Name = tbxName.Text;
                newReportTemplate.Format = tbxFormat.Text;
                newReportTemplate.Fields = GetFieldList();

                if (cbxLanguage.SelectedIndex >= 0)
                    newReportTemplate.Language = (NewReportTemplate.VxLanguage)cbxLanguage.SelectedIndex + 1;

                if (!chbxSelectAll.Checked && lvFilters.Items.Count > 0)
                    newReportTemplate.Filters = GetFilterList();

                if (chbxAutoExport.Checked)
                    newReportTemplate.StorageLocation = new NetworkStorageInfo { Path = tbxPath.Text, Username = tbxUsername.Text, Password = tbxPassword.Text };

                if (cbxInterval.Enabled && cbxInterval.SelectedIndex >= 0)
                    newReportTemplate.Interval = GetIntervalSetting();

                if (chbxAutoGenerate.Checked)
                {
                    var recurrence = GetRecurrenceSettings();
                    if (recurrence.Count > 0)
                    {
                        newReportTemplate.Recurrence = recurrence;
                        newReportTemplate.RecurrenceTime = dtpAtTime.Value.ToUniversalTime();
                    }
                }

                if (cbxTimeRange.Enabled && cbxTimeRange.SelectedIndex >= 0)
                {
                    newReportTemplate.Duration = GetDurationSetting();
                    if (cbxTimeRange.SelectedIndex == 4)
                        newReportTemplate.EndTime = dtpEndTime.Value.ToUniversalTime();
                }

                MainForm.CurrentSystem.AddReportTemplate(newReportTemplate);
            }
            else
            {
                if (!string.IsNullOrEmpty(tbxName.Text) && SelectedReportTemplate.Name != tbxName.Text)
                    SelectedReportTemplate.Name = tbxName.Text;

                if (!string.IsNullOrEmpty(tbxFormat.Text) && SelectedReportTemplate.Format != tbxFormat.Text)
                    SelectedReportTemplate.Format = tbxFormat.Text;

                if (cbxLanguage.SelectedIndex >= 0 && SelectedReportTemplate.Language != (NewReportTemplate.VxLanguage)cbxLanguage.SelectedIndex + 1)
                    SelectedReportTemplate.Language = (NewReportTemplate.VxLanguage)cbxLanguage.SelectedIndex + 1;

                if (chbxSelectAll.Checked && SelectedReportTemplate.Filters.Count > 0)
                    SelectedReportTemplate.Filters = new List<ReportFilter>();
                else if (!chbxSelectAll.Checked && lvFilters.Items.Count > 0)
                    SelectedReportTemplate.Filters = GetFilterList();
                
                var fieldsChanged = false;
                foreach (TreeNode node in tvFields.Nodes)
                {
                    if (node.Checked != ((ReportField)node.Tag).IsEnabled)
                        fieldsChanged = true;

                    foreach (TreeNode subNode in node.Nodes)
                        if (subNode.Checked != ((ReportField)subNode.Tag).IsEnabled)
                            fieldsChanged = true;
                }

                if (fieldsChanged)
                    SelectedReportTemplate.Fields = GetFieldList();

                if (chbxAutoExport.Checked && SelectedReportTemplate.StorageLocation.Path != tbxPath.Text || SelectedReportTemplate.StorageLocation.Username != tbxUsername.Text || !string.IsNullOrEmpty(tbxPassword.Text))
                    SelectedReportTemplate.StorageLocation = new NetworkStorageInfo { Path = tbxPath.Text, Username = tbxUsername.Text, Password = tbxPassword.Text };
                
                if (!chbxAutoExport.Checked && !string.IsNullOrEmpty(SelectedReportTemplate.StorageLocation.Path) || !string.IsNullOrEmpty(SelectedReportTemplate.StorageLocation.Username))
                    SelectedReportTemplate.StorageLocation = new NetworkStorageInfo();

                if (chbxAutoGenerate.Checked && RecurrenceChanged)
                {
                    SelectedReportTemplate.Recurrence = GetRecurrenceSettings();
                    SelectedReportTemplate.RecurrenceTime = dtpAtTime.Value;
                }
                else if (RecurrenceChanged)
                {
                    if (SelectedReportTemplate.Recurrence.Count > 0)
                        SelectedReportTemplate.Recurrence = new List<TimeRange.DayOfWeek>();

                    if (!SelectedReportTemplate.RecurrenceTime.Equals(default))
                        SelectedReportTemplate.RecurrenceTime = default;
                }

                if (cbxInterval.Enabled && cbxInterval.SelectedIndex >= 0)
                {
                    var selectedInterval = GetIntervalSetting();
                    if (SelectedReportTemplate.Interval != selectedInterval)
                        SelectedReportTemplate.Interval = selectedInterval;
                }

                if (cbxTimeRange.Enabled && cbxTimeRange.SelectedIndex >= 0)
                {
                    var selectedDuration = GetDurationSetting();
                    if (SelectedReportTemplate.Duration != selectedDuration)
                        SelectedReportTemplate.Duration = selectedDuration;

                    if (cbxTimeRange.SelectedIndex == 4 && SelectedReportTemplate.EndTime != dtpEndTime.Value.ToUniversalTime())
                        SelectedReportTemplate.EndTime = dtpEndTime.Value.ToUniversalTime();
                }
            }
        }

        /// <summary>
        /// The CheckBox_CheckedChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void CheckBox_CheckedChanged(object sender, EventArgs args)
        {
            pnlAutoExport.Enabled = chbxAutoExport.Checked;
            lvFilters.Enabled = !chbxSelectAll.Checked;
            btnModifySelection.Enabled = !chbxSelectAll.Checked;
        }

        /// <summary>
        /// The CheckBoxRecurrence_CheckedChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void CheckBoxRecurrence_CheckedChanged(object sender, EventArgs args)
        {
            pnlAutoGenerate.Enabled = chbxAutoGenerate.Checked;
            var checkbox = (CheckBox)sender;
            if (SelectedReportTemplate == null || checkbox == null)
                return;

            switch (checkbox.Name)
            {
                case nameof(chbxMon) when chbxMon.Checked != SelectedReportTemplate.Recurrence.Contains(TimeRange.DayOfWeek.Monday):
                case nameof(chbxTue) when chbxTue.Checked != SelectedReportTemplate.Recurrence.Contains(TimeRange.DayOfWeek.Tuesday):
                case nameof(chbxWed) when chbxWed.Checked != SelectedReportTemplate.Recurrence.Contains(TimeRange.DayOfWeek.Wednesday):
                case nameof(chbxThu) when chbxThu.Checked != SelectedReportTemplate.Recurrence.Contains(TimeRange.DayOfWeek.Thursday):
                case nameof(chbxFri) when chbxFri.Checked != SelectedReportTemplate.Recurrence.Contains(TimeRange.DayOfWeek.Friday):
                case nameof(chbxSat) when chbxSat.Checked != SelectedReportTemplate.Recurrence.Contains(TimeRange.DayOfWeek.Saturday):
                case nameof(chbxSun) when chbxSun.Checked != SelectedReportTemplate.Recurrence.Contains(TimeRange.DayOfWeek.Sunday):
                    RecurrenceChanged = true;
                    break;
            }
        }

        /// <summary>
        /// The ComboBoxReportType_SelectedIndexChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ComboBoxReportType_SelectedIndexChanged(object sender, EventArgs args)
        {
            if (cbxReportType.SelectedItem is ComboboxItem selected && SelectedReportTemplate == null)
                LoadDefaultTemplate((NewReportTemplate)selected.Value);
        }

        /// <summary>
        /// The ComboBoxTimeRange_SelectedIndexChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ComboBoxTimeRange_SelectedIndexChanged(object sender, EventArgs args)
        {
            pnlTimes.Enabled = cbxTimeRange.SelectedIndex == 4;
        }

        /// <summary>
        /// The DateTimePickerAtTime_ValueChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void DateTimePickerAtTime_ValueChanged(object sender, EventArgs args)
        {
            if (SelectedReportTemplate != null && SelectedReportTemplate.RecurrenceTime != dtpAtTime.Value)
                RecurrenceChanged = true;
        }

        /// <summary>
        /// The FormatFieldName method.
        /// </summary>
        /// <param name="fieldType">The <paramref name="fieldType"/> parameter.</param>
        /// <returns>The formatted field name string.</returns>
        private string FormatFieldName(ReportField.ReportFieldType fieldType)
        {
            var name = Regex.Replace(fieldType.ToString(), "(\\B[A-Z])", " $1");
            name = name.Replace("Camera Stream ", "");
            name = name.Replace("Datasource", "Camera");
            name = name.Replace("Line Counter Name", "Name");
            name = name.Replace("Line Counter ", "");
            name = name.Replace("Situation Name", "Event Name");
            name = name.Replace("Property Mods", "Modification Properties");
            name = name.Replace("Datastorage", "Storage");
            name = name.Replace("Id", "ID");

            return name;
        }

        /// <summary>
        /// The GetDurationSetting method.
        /// </summary>
        /// <returns>The selected duration.</returns>
        private int GetDurationSetting()
        {
            switch (cbxTimeRange.SelectedIndex)
            {
                case 1:
                    return 168;
                case 2:
                    return 720;
                case 3:
                    return 8760;
                case 4:
                    return (int)(dtpEndTime.Value.ToUniversalTime() - dtpStartTime.Value.ToUniversalTime()).TotalHours;
                default:
                    return 24;
            }
        }

        /// <summary>
        /// The GetRecurrenceSettings method.
        /// </summary>
        /// <returns>The current list of fields.</returns>
        private List<ReportField> GetFieldList()
        {
            var fieldList = new List<ReportField>();
            foreach (TreeNode node in tvFields.Nodes)
            {
                if (!(node.Tag is ReportField field) || node.Parent != null)
                    continue;

                if (node.Nodes.Count > 0)
                {
                    field.Subfields.Clear();
                    foreach (TreeNode subNode in node.Nodes)
                    {
                        if (!(subNode.Tag is ReportField subfield))
                            continue;

                        subfield.IsEnabled = subNode.Checked;
                        subfield.Name = subNode.Text;
                        field.Subfields.Add(subfield);
                    }
                }

                field.IsEnabled = node.Checked;
                field.Name = node.Text;
                fieldList.Add(field);
            }

            return fieldList;
        }

        /// <summary>
        /// The GetRecurrenceSettings method.
        /// </summary>
        /// <returns>The current list of filters.</returns>
        private List<ReportFilter> GetFilterList()
        {
            var filterList = new List<ReportFilter>();
            var reportFilter = new ReportFilter { Type = (ReportFilter.ReportFilterType)gbxIncludeRows.Tag };
            foreach (ListViewItem lvItem in lvFilters.Items)
                reportFilter.FilterIds.Add((string)lvItem.Tag);

            filterList.Add(reportFilter);

            return filterList;
        }

        /// <summary>
        /// The GetIntervalSetting method.
        /// </summary>
        /// <returns>The selected time interval.</returns>
        private LineCountingRequest.TimeInterval GetIntervalSetting()
        {
            switch (cbxInterval.SelectedIndex)
            {
                case 1:
                    return LineCountingRequest.TimeInterval.Day;
                case 2:
                    return LineCountingRequest.TimeInterval.Month;
                default:
                    return LineCountingRequest.TimeInterval.Hour;
            }
        }

        /// <summary>
        /// The GetRecurrenceSettings method.
        /// </summary>
        /// <returns>The list of recurrence days.</returns>
        private List<TimeRange.DayOfWeek> GetRecurrenceSettings()
        {
            var recurrence = new List<TimeRange.DayOfWeek>();
            if (chbxMon.Checked)
                recurrence.Add(TimeRange.DayOfWeek.Monday);

            if (chbxTue.Checked)
                recurrence.Add(TimeRange.DayOfWeek.Tuesday);

            if (chbxWed.Checked)
                recurrence.Add(TimeRange.DayOfWeek.Wednesday);

            if (chbxThu.Checked)
                recurrence.Add(TimeRange.DayOfWeek.Thursday);

            if (chbxFri.Checked)
                recurrence.Add(TimeRange.DayOfWeek.Friday);

            if (chbxSat.Checked)
                recurrence.Add(TimeRange.DayOfWeek.Saturday);

            if (chbxSun.Checked)
                recurrence.Add(TimeRange.DayOfWeek.Sunday);

            return recurrence;
        }

        /// <summary>
        /// The LoadDefaultTemplate method.
        /// </summary>
        /// <param name="selectedTemplate">The <paramref name="selectedTemplate"/> parameter.</param>
        private void LoadDefaultTemplate(NewReportTemplate selectedTemplate)
        {
            SetFilterType(selectedTemplate.Filters.FirstOrDefault()?.Type ?? ReportFilter.ReportFilterType.Unknown);
            pnlTimeRange.Enabled = pnlGeneral.Enabled = true;
            chbxAutoGenerate.Enabled = chbxAutoExport.Enabled = true;
            gbxIncludeColumns.Enabled = gbxIncludeRows.Enabled = true;

            var hasDuration = selectedTemplate.Type == NewReportTemplate.ReportType.UserAction ||
                               selectedTemplate.Type == NewReportTemplate.ReportType.Event ||
                               selectedTemplate.Type == NewReportTemplate.ReportType.RecordingGap ||
                               selectedTemplate.Type == NewReportTemplate.ReportType.LineCount;

            pnlTimeRange.Enabled = hasDuration;
            pnlTimes.Enabled = hasDuration && cbxTimeRange.SelectedIndex >= 0;

            pnlInterval.Enabled = selectedTemplate.Type == NewReportTemplate.ReportType.LineCount;
            tbxFormat.Text = selectedTemplate.Format;
            if (string.IsNullOrEmpty(tbxName.Text))
                tbxName.Text = "New Unsaved Template";

            LoadFilters(null);

            tvFields.AfterCheck -= TreeViewFields_AfterCheck;
            tvFields.Nodes.Clear();
            foreach (var field in selectedTemplate.Fields)
            {
                if (field.Subfields.Count == 0)
                {
                    var newNode = tvFields.Nodes.Add(FormatFieldName(field.Type));
                    newNode.Checked = field.IsEnabled;
                    newNode.Tag = field;
                }
                else
                {
                    var node = tvFields.Nodes.Add("Field Group");
                    node.Checked = field.IsEnabled;
                    node.Tag = field;
                    foreach (var subfield in field.Subfields)
                    {
                        var newNode = node.Nodes.Add(FormatFieldName(subfield.Type));
                        newNode.Checked = subfield.IsEnabled;
                        newNode.Tag = subfield;
                    }

                    node.Expand();
                }
            }

            tvFields.AfterCheck += TreeViewFields_AfterCheck;
        }

        /// <summary>
        /// The LoadExistingTemplate method.
        /// </summary>
        private void LoadExistingTemplate()
        {
            if (SelectedReportTemplate.Filters.Count == 0)
            {
                var match = DefaultReportTemplates.FirstOrDefault(template => template.Type == SelectedReportTemplate.Type);
                SetFilterType(match?.Filters.FirstOrDefault()?.Type ?? ReportFilter.ReportFilterType.Unknown);
            }
            else
                SetFilterType(SelectedReportTemplate.Filters[0].Type);

            pnlTimeRange.Enabled = pnlTimes.Enabled = pnlGeneral.Enabled = true;
            chbxAutoGenerate.Enabled = chbxAutoExport.Enabled = true;
            gbxIncludeColumns.Enabled = gbxIncludeRows.Enabled = true;

            var durationLimit = SelectedReportTemplate.Limits.IntegerLimits.FirstOrDefault(limit => limit.FieldName == "duration");
            var hasDuration = durationLimit != null;

            pnlInterval.Enabled = SelectedReportTemplate.Type == NewReportTemplate.ReportType.LineCount;
            if (SelectedReportTemplate.Type == NewReportTemplate.ReportType.LineCount)
            {
                switch (SelectedReportTemplate.Interval)
                {
                    case LineCountingRequest.TimeInterval.Day:
                        cbxInterval.SelectedIndex = 1;
                        break;
                    case LineCountingRequest.TimeInterval.Month:
                        cbxInterval.SelectedIndex = 2;
                        break;
                    default:
                        cbxInterval.SelectedIndex = 0;
                        break;
                }
            }

            tbxName.Text = SelectedReportTemplate.Name;
            cbxLanguage.SelectedIndex = (int)SelectedReportTemplate.Language - 1;
            tbxFormat.Text = SelectedReportTemplate.Format;

            if (hasDuration)
            {
                switch (SelectedReportTemplate.Duration)
                {
                    case 24:
                        //Last 24 hours
                        cbxTimeRange.SelectedIndex = 0; 
                        break;
                    case 168:
                        // Last week
                        cbxTimeRange.SelectedIndex = 1; 
                        break;
                    case 720:
                        // Last month
                        cbxTimeRange.SelectedIndex = 2; 
                        break;
                    case 8760:
                        // Last year
                        cbxTimeRange.SelectedIndex = 3; 
                        break;
                    default:
                        // Custom
                        cbxTimeRange.SelectedIndex = 4; 
                        break;
                }
            }
            else
            {
                pnlTimes.Enabled = pnlTimeRange.Enabled = false;
            }

            if (cbxTimeRange.SelectedIndex == 4)
            {
                dtpEndTime.Value = SelectedReportTemplate.EndTime.ToLocalTime();
                dtpStartTime.Value = SelectedReportTemplate.EndTime.AddHours(SelectedReportTemplate.Duration * -1).ToLocalTime();
            }
            else
            {
                pnlTimes.Enabled = false;
            }

            chbxAutoGenerate.Checked = SelectedReportTemplate.Recurrence.Count > 0;
            foreach (var dayOfWeek in SelectedReportTemplate.Recurrence)
            {
                switch (dayOfWeek)
                {
                    case TimeRange.DayOfWeek.Monday:
                        chbxMon.Checked = true;
                        break;
                    case TimeRange.DayOfWeek.Tuesday:
                        chbxTue.Checked = true;
                        break;
                    case TimeRange.DayOfWeek.Wednesday:
                        chbxWed.Checked = true;
                        break;
                    case TimeRange.DayOfWeek.Thursday:
                        chbxThu.Checked = true;
                        break;
                    case TimeRange.DayOfWeek.Friday:
                        chbxFri.Checked = true;
                        break;
                    case TimeRange.DayOfWeek.Saturday:
                        chbxSat.Checked = true;
                        break;
                    default:
                        chbxSun.Checked = true;
                        break;
                }
            }

            if (!SelectedReportTemplate.RecurrenceTime.Equals(default))
                dtpAtTime.Value = SelectedReportTemplate.RecurrenceTime;

            dtpAtTime.ValueChanged += DateTimePickerAtTime_ValueChanged;
            chbxAutoExport.Checked = !string.IsNullOrEmpty(SelectedReportTemplate.StorageLocation.Path);
            if (chbxAutoExport.Checked)
            {
                tbxPath.Text = SelectedReportTemplate.StorageLocation.Path;
                tbxUsername.Text = SelectedReportTemplate.StorageLocation.Username;
                tbxPassword.Text = SelectedReportTemplate.StorageLocation.Password;
            }

            if (SelectedReportTemplate.Filters.Count == 0)
            {
                chbxSelectAll.Checked = true;
                lvFilters.Enabled = false;
                btnModifySelection.Enabled = false;
            }
            else
            {
                chbxSelectAll.Checked = false;
                lvFilters.Enabled = true;
                btnModifySelection.Enabled = true;
                LoadFilters(SelectedReportTemplate.Filters);
            }

            foreach (var field in SelectedReportTemplate.Fields)
            {
                if (field.Subfields.Count == 0)
                {
                    var newNode = tvFields.Nodes.Add(field.Name);
                    newNode.Tag = field;
                    newNode.Checked = field.IsEnabled;
                }
                else
                {
                    var node = tvFields.Nodes.Add(field.Name);
                    node.Checked = field.IsEnabled;
                    node.Tag = field;
                    foreach (var subfield in field.Subfields)
                    {
                        var newNode = node.Nodes.Add(subfield.Name);
                        newNode.Tag = subfield;
                        newNode.Checked = subfield.IsEnabled;
                    }

                    node.Expand();
                }
            }

            tvFields.AfterCheck += TreeViewFields_AfterCheck;
        }

        /// <summary>
        /// The LoadFilters method.
        /// </summary>
        /// <param name="filterList">The <paramref name="filterList"/> parameter.</param>
        private void LoadFilters(List<ReportFilter> filterList)
        {
            lvFilters.Items.Clear();
            var filterType = (ReportFilter.ReportFilterType)gbxIncludeRows.Tag;
            if (filterType == ReportFilter.ReportFilterType.Unknown || filterList == null)
                return;

            switch (filterType)
            {
                case ReportFilter.ReportFilterType.AnalyticBehavior:
                    foreach (var behavior in from dataSource in MainForm.CurrentSystem.DataSources from analyticConfig in dataSource.AnalyticConfigs
                        from behavior in analyticConfig.AnalyticBehaviors from filter in filterList where filter.FilterIds.Contains(behavior.Id) select behavior)
                        lvFilters.Items.Add(new ListViewItem(string.IsNullOrEmpty(behavior.Name) ? behavior.Id : behavior.Name) { Tag = behavior.Id });

                    break;
                case ReportFilter.ReportFilterType.DataSource:
                    foreach (var dataSource in from dataSource in MainForm.CurrentSystem.DataSources from filter in filterList where filter.FilterIds.Contains(dataSource.Id) select dataSource)
                        lvFilters.Items.Add(new ListViewItem(string.IsNullOrEmpty(dataSource.Name) ? dataSource.Id : dataSource.Name) { Tag = dataSource.Id });

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

                        lvFilters.Items.Add(new ListViewItem(name) { Tag = dataStorage.Id });
                    }

                    break;
                case ReportFilter.ReportFilterType.Device:
                    foreach (var device in from device in MainForm.CurrentSystem.Devices from filter in filterList where filter.FilterIds.Contains(device.Id) select device)
                        lvFilters.Items.Add(new ListViewItem(string.IsNullOrEmpty(device.Name) ? device.Id : device.Name) { Tag = device.Id });

                    break;
                case ReportFilter.ReportFilterType.Role:
                    foreach (var role in from role in MainForm.CurrentSystem.Roles from filter in filterList where filter.FilterIds.Contains(role.Id) select role)
                        lvFilters.Items.Add(new ListViewItem(string.IsNullOrEmpty(role.Name) ? role.Id : role.Name) { Tag = role.Id });

                    break;
                case ReportFilter.ReportFilterType.Situation:
                    foreach (var situation in from situation in MainForm.CurrentSystem.Situations from filter in filterList where filter.FilterIds.Contains(situation.Type) select situation)
                        lvFilters.Items.Add(new ListViewItem(string.IsNullOrEmpty(situation.Name) ? situation.Type : situation.Name) { Tag = situation.Type });

                    break;
                case ReportFilter.ReportFilterType.User:
                    foreach (var user in from user in MainForm.CurrentSystem.Users from filter in filterList where filter.FilterIds.Contains(user.Id) select user)
                        lvFilters.Items.Add(new ListViewItem(string.IsNullOrEmpty(user.Name) ? user.Id : user.Name) { Tag = user.Id });
                    
                    break;
            }
        }

        /// <summary>
        /// The SetFilterType method.
        /// </summary>
        /// <param name="type">The <paramref name="type"/> parameter.</param>
        private void SetFilterType(ReportFilter.ReportFilterType type)
        {
            switch (type)
            {
                case ReportFilter.ReportFilterType.AnalyticBehavior:
                    gbxIncludeRows.Text = "Include Counting Lines (rows)";
                    gbxIncludeRows.Tag = ReportFilter.ReportFilterType.AnalyticBehavior;
                    break;
                case ReportFilter.ReportFilterType.DataSource:
                    gbxIncludeRows.Text = "Include Cameras (rows)";
                    gbxIncludeRows.Tag = ReportFilter.ReportFilterType.DataSource;
                    break;
                case ReportFilter.ReportFilterType.DataStorage:
                    gbxIncludeRows.Text = "Include Storage (rows)";
                    gbxIncludeRows.Tag = ReportFilter.ReportFilterType.DataStorage;
                    break;
                case ReportFilter.ReportFilterType.Device:
                    gbxIncludeRows.Text = "Include Devices (rows)";
                    gbxIncludeRows.Tag = ReportFilter.ReportFilterType.Device;
                    break;
                case ReportFilter.ReportFilterType.Role:
                    gbxIncludeRows.Text = "Include Role (rows)";
                    gbxIncludeRows.Tag = ReportFilter.ReportFilterType.Role;
                    break;
                case ReportFilter.ReportFilterType.Situation:
                    gbxIncludeRows.Text = "Include Events (rows)";
                    gbxIncludeRows.Tag = ReportFilter.ReportFilterType.Situation;
                    break;
                case ReportFilter.ReportFilterType.User:
                    gbxIncludeRows.Text = "Include User (rows)";
                    gbxIncludeRows.Tag = ReportFilter.ReportFilterType.User;
                    break;
                default:
                    gbxIncludeRows.Text = "Include (rows)";
                    gbxIncludeRows.Tag = ReportFilter.ReportFilterType.Unknown;
                    break;
            }
        }

        /// <summary>
        /// The TreeViewFields_AfterCheck method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void TreeViewFields_AfterCheck(object sender, TreeViewEventArgs args)
        {
            if (AreFilterNodesChanging)
                return;

            if (args.Node.Nodes.Count > 0)
            {
                AreFilterNodesChanging = true;
                foreach (TreeNode node in args.Node.Nodes)
                    node.Checked = args.Node.Checked;
            }
            else
            {
                AreFilterNodesChanging = true;
                if (args.Node.Parent != null)
                {
                    var areChecked = false;
                    foreach (TreeNode subNode in args.Node.Parent.Nodes)
                        if (subNode.Checked)
                            areChecked = true;

                    args.Node.Parent.Checked = areChecked;
                }
            }

            AreFilterNodesChanging = false;
        }

        #endregion Private Methods
    }
}