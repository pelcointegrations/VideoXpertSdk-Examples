using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The AnalyticConfigManagerForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to manage analytic configurations.</remarks>
    public partial class AnalyticConfigsManagerForm : Form
    {
        #region Private Fields

        /// <summary>
        /// The _selectedDataSource field.
        /// </summary>
        /// <remarks>The selected data source.</remarks>
        private readonly DataSource _selectedDataSource;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticConfigsManagerForm" /> class.
        /// </summary>
        /// <param name="dataSource">The data source that contains the analytic configs to manage.</param>
        public AnalyticConfigsManagerForm(DataSource dataSource)
        {
            InitializeComponent();
            _selectedDataSource = dataSource;

            PopulateAnalyticConfigs();
        }

        #endregion Public Constructors

        #region Private Methods

        /// <summary>
        /// The ButtonDeleteConfig_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonDeleteConfig_Click(object sender, EventArgs args)
        {
            if (lvAnalyticConfigs.SelectedItems.Count == 0)
                return;

            // Get the associated analytic config object from the selected item and delete it.
            var analyticConfig = (AnalyticConfig)lvAnalyticConfigs.SelectedItems[0].Tag;
            _selectedDataSource.DeleteAnalyticConfig(analyticConfig);

            // Refresh the items in the list view.
            lvAnalyticConfigs.Items.Clear();
            PopulateAnalyticConfigs();
            lvAnalyticConfigs.Refresh();
        }

        /// <summary>
        /// The ButtonGetLineCounts_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonGetLineCounts_Click(object sender, EventArgs args)
        {
            // Show the LineCountRequestForm dialog.
            using (var lineCountRequestForm = new LineCountRequestForm(_selectedDataSource))
            {
                lineCountRequestForm.ShowDialog();
            }
        }

        /// <summary>
        /// The ButtonManageBehaviors_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonManageBehaviors_Click(object sender, EventArgs args)
        {
            if (lvAnalyticConfigs.SelectedItems.Count == 0)
                return;

            var analyticConfig = (AnalyticConfig)lvAnalyticConfigs.SelectedItems[0].Tag;

            // Show the AnalyticBehaviorManagerForm dialog.
            using (var analyticBehaviorManagerForm = new AnalyticBehaviorManagerForm(analyticConfig))
            {
                analyticBehaviorManagerForm.ShowDialog();
            }

            // Refresh the items in the list view.
            lvAnalyticConfigs.Items.Clear();
            PopulateAnalyticConfigs();
            lvAnalyticConfigs.Refresh();
        }

        /// <summary>
        /// The ButtonModifyConfig_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonModifyConfig_Click(object sender, EventArgs args)
        {
            if (lvAnalyticConfigs.SelectedItems.Count == 0)
                return;

            var analyticConfig = (AnalyticConfig)lvAnalyticConfigs.SelectedItems[0].Tag;

            // Show the ModifyAnalyticConfigForm dialog.
            DialogResult result;
            using (var modifyAnalyticConfigForm = new ModifyAnalyticConfigForm(analyticConfig, _selectedDataSource))
            {
                result = modifyAnalyticConfigForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result != DialogResult.OK)
                return;

            // Refresh the items in the list view to include the newly modified analytic config.
            lvAnalyticConfigs.Items.Clear();
            PopulateAnalyticConfigs();
            lvAnalyticConfigs.Refresh();
        }

        /// <summary>
        /// The ButtonNewConfig_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonNewConfig_Click(object sender, EventArgs args)
        {
            // Show the AddAnalyticConfigForm dialog.
            DialogResult result;
            using (var addAnalyticConfigForm = new AddAnalyticConfigForm(_selectedDataSource))
            {
                result = addAnalyticConfigForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result != DialogResult.OK)
                return;

            // Refresh the items in the list view to include the newly added analytic config.
            lvAnalyticConfigs.Items.Clear();
            PopulateAnalyticConfigs();
            lvAnalyticConfigs.Refresh();
        }

        /// <summary>
        /// The ButtonRefresh_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRefresh_Click(object sender, EventArgs args)
        {
            // Refresh the items in the list view.
            lvAnalyticConfigs.Items.Clear();
            PopulateAnalyticConfigs();
            lvAnalyticConfigs.Refresh();
        }

        /// <summary>
        /// The PopulateAnalyticConfigs method.
        /// </summary>
        private void PopulateAnalyticConfigs()
        {
            var availableTypes = _selectedDataSource.AvailableAnalyticBehaviorTypes;
            btnNewConfig.Enabled = btnModifyConfig.Enabled = btnDeleteConfig.Enabled = btnManageBehaviors.Enabled = availableTypes.Count > 0;
            btnGetLineCounts.Enabled = availableTypes.Contains(DataSource.AnalyticBehaviorType.ObjectLineCounter);

            lblObjectInZoneCheck.Text = availableTypes.Contains(DataSource.AnalyticBehaviorType.ObjectInZone) ? "✓" : "X";
            lblObjectInZoneCheck.ForeColor = availableTypes.Contains(DataSource.AnalyticBehaviorType.ObjectInZone) ? Color.Green : Color.Red;

            lblObjectLineCounterCheck.Text = availableTypes.Contains(DataSource.AnalyticBehaviorType.ObjectLineCounter) ? "✓" : "X";
            lblObjectLineCounterCheck.ForeColor = availableTypes.Contains(DataSource.AnalyticBehaviorType.ObjectLineCounter) ? Color.Green : Color.Red;

            lblObjectWrongWayCheck.Text = availableTypes.Contains(DataSource.AnalyticBehaviorType.ObjectWrongWay) ? "✓" : "X";
            lblObjectWrongWayCheck.ForeColor = availableTypes.Contains(DataSource.AnalyticBehaviorType.ObjectWrongWay) ? Color.Green : Color.Red;

            var analyticCapabilities = _selectedDataSource.AnalyticCapabilities;
            lblObjectLineCounterEventsCheck.Text = analyticCapabilities.Contains(DataSource.AnalyticCapability.ObjectLineCounterEvents) ? "✓" : "X";
            lblObjectLineCounterEventsCheck.ForeColor = analyticCapabilities.Contains(DataSource.AnalyticCapability.ObjectLineCounterEvents) ? Color.Green : Color.Red;

            lblObjectLineCounterResetCheck.Text = analyticCapabilities.Contains(DataSource.AnalyticCapability.ObjectLineCounterReset) ? "✓" : "X";
            lblObjectLineCounterResetCheck.ForeColor = analyticCapabilities.Contains(DataSource.AnalyticCapability.ObjectLineCounterReset) ? Color.Green : Color.Red;

            // Get the existing analytic configs from the VideoXpert system and add
            // them to the list view.
            foreach (var analyticConfig in _selectedDataSource.AnalyticConfigs)
            {
                var lvItem = new ListViewItem(analyticConfig.Id);
                lvItem.SubItems.Add(analyticConfig.MinConfidence.ToString(CultureInfo.InvariantCulture));
                lvItem.SubItems.Add(analyticConfig.PtzPresetName);
                lvItem.SubItems.Add(analyticConfig.Size.Height.ToString());
                lvItem.SubItems.Add(analyticConfig.Size.Width.ToString());
                lvItem.SubItems.Add(analyticConfig.AnalyticBehaviors.Count.ToString());
                
                lvItem.Tag = analyticConfig;
                lvAnalyticConfigs.Items.Add(lvItem);
            }
        }

        #endregion Private Methods
    }
}