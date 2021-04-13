using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The ReportFilterSelectionForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to select resources for a report filter.</remarks>
    public partial class ReportFilterSelectionForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportFilterSelectionForm" /> class.
        /// </summary>
        /// <param name="filterList">The <paramref name="filterList"/> parameter.</param>
        /// <param name="filterType">The <paramref name="filterType"/> parameter.</param>
        public ReportFilterSelectionForm(List<ReportFilter> filterList, ReportFilter.ReportFilterType filterType)
        {
            InitializeComponent();

            FilterType = filterType;
            LoadResources(filterList);
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// Gets or sets the HasChanged property.
        /// </summary>
        /// <value><c>true</c> if the list of report filters have been modified.</value>
        public bool HasChanged { get; set; }

        /// <summary>
        /// Gets or sets the NewFilterList property.
        /// </summary>
        /// <value>The list of modified report filters.</value>
        public List<ReportFilter> NewFilterList { get; set; } = new List<ReportFilter>();

        #endregion Public Properties

        #region Private Properties

        /// <summary>
        /// Gets the FilterType property.
        /// </summary>
        /// <value>The report filter type to use for listing resources.</value>
        private ReportFilter.ReportFilterType FilterType { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonSave_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            if (!HasChanged)
                return;

            var reportFilter = new ReportFilter { Type = FilterType };
            foreach (ListViewItem item in lvFilterItems.Items)
            {
                if (item.Checked)
                    reportFilter.FilterIds.Add((string)item.Tag);
            }

            NewFilterList.Add(reportFilter);
        }

        /// <summary>
        /// The LoadResources method.
        /// </summary>
        /// <param name="filterList">The <paramref name="filterList"/> parameter.</param>
        private void LoadResources(List<ReportFilter> filterList)
        {
            switch (FilterType)
            {
                case ReportFilter.ReportFilterType.AnalyticBehavior:
                {
                    Text = "Select Counting Lines";
                    foreach (var dataSource in MainForm.CurrentSystem.DataSources)
                    {
                        foreach (var analyticConfig in dataSource.AnalyticConfigs)
                        {
                            foreach (var behavior in analyticConfig.AnalyticBehaviors)
                            {
                                var lvItem = new ListViewItem("");
                                lvItem.SubItems.Add(string.IsNullOrEmpty(behavior.Name) ? behavior.Id : behavior.Name);
                                lvItem.Tag = behavior.Id;
                                lvFilterItems.Items.Add(lvItem);
                            }
                        }
                    }

                    break;
                }
                case ReportFilter.ReportFilterType.DataSource:
                {
                    Text = "Select Cameras";
                    foreach (var dataSource in MainForm.CurrentSystem.DataSources)
                    {
                        var lvItem = new ListViewItem("");
                        lvItem.SubItems.Add(string.IsNullOrEmpty(dataSource.Name) ? dataSource.Id : dataSource.Name);
                        lvItem.SubItems.Add(dataSource.Name);
                        lvItem.Tag = dataSource.Id;
                        lvFilterItems.Items.Add(lvItem);
                    }

                    break;
                }
                case ReportFilter.ReportFilterType.DataStorage:
                {
                    Text = "Select Storage";
                    foreach (var dataStorage in MainForm.CurrentSystem.DataStorages)
                    {
                        var lvItem = new ListViewItem("");
                        string name;
                        if (!string.IsNullOrEmpty(dataStorage.Name))
                            name = dataStorage.Name;
                        else if (!string.IsNullOrEmpty(dataStorage.HostDevice?.Name))
                            name = dataStorage.HostDevice.Name;
                        else
                            name = dataStorage.Id;

                        lvItem.SubItems.Add(name);
                        lvItem.SubItems.Add(dataStorage.Name);
                        lvItem.Tag = dataStorage.Id;
                        lvFilterItems.Items.Add(lvItem);
                    }

                    break;
                }
                case ReportFilter.ReportFilterType.Device:
                {
                    Text = "Select Devices";
                    foreach (var device in MainForm.CurrentSystem.Devices)
                    {
                        var lvItem = new ListViewItem("");
                        lvItem.SubItems.Add(string.IsNullOrEmpty(device.Name) ? device.Id : device.Name);
                        lvItem.Tag = device.Id;
                        lvFilterItems.Items.Add(lvItem);
                    }

                    break;
                }
                case ReportFilter.ReportFilterType.Role:
                {
                    Text = "Select Roles";
                    foreach (var role in MainForm.CurrentSystem.Roles)
                    {
                        var lvItem = new ListViewItem("");
                        lvItem.SubItems.Add(string.IsNullOrEmpty(role.Name) ? role.Id : role.Name);
                        lvItem.Tag = role.Id;
                        lvFilterItems.Items.Add(lvItem);
                    }

                    break;
                }
                case ReportFilter.ReportFilterType.Situation:
                {
                    Text = "Select Events";
                    foreach (var situation in MainForm.CurrentSystem.Situations)
                    {
                        var lvItem = new ListViewItem("");
                        lvItem.SubItems.Add(string.IsNullOrEmpty(situation.Name) ? situation.Type : situation.Name);
                        lvItem.Tag = situation.Type;
                        lvFilterItems.Items.Add(lvItem);
                    }

                    break;
                }
                case ReportFilter.ReportFilterType.User:
                {
                    Text = "Select Users";
                    foreach (var user in MainForm.CurrentSystem.Users)
                    {
                        var lvItem = new ListViewItem("");
                        lvItem.SubItems.Add(string.IsNullOrEmpty(user.Name) ? user.Id : user.Name);
                        lvItem.Tag = user.Id;
                        lvFilterItems.Items.Add(lvItem);
                    }

                    break;
                }
            }

            foreach (ListViewItem item in lvFilterItems.Items)
                foreach (var filter in filterList)
                    foreach (var filterId in filter.FilterIds)
                        if ((string) item.Tag == filterId)
                            item.Checked = true;

            lvFilterItems.ItemChecked += (sender, args) => HasChanged = true;
        }

        #endregion Private Methods
    }
}