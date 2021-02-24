using System;
using System.Linq;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The DataSourceManagerForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to view, create and delete
    /// devices from the VideoXpert system.</remarks>
    public partial class DataSourceManagerForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceManagerForm" /> class.
        /// </summary>
        public DataSourceManagerForm()
        {
            InitializeComponent();

            PopulateDataSources();
        }

        #endregion Public Constructors

        #region Private Methods

        /// <summary>
        /// The ButtonAnalytics_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonAnalytics_Click(object sender, EventArgs args)
        {
            if (lvDataSources.SelectedItems.Count == 0)
                return;

            var dataSource = (DataSource)lvDataSources.SelectedItems[0].Tag;
            
            // Show the AnalyticConfigManagerForm dialog.
            using (var analyticConfigManagerForm = new AnalyticConfigsManagerForm(dataSource))
            {
                analyticConfigManagerForm.ShowDialog();
            }
        }

        /// <summary>
        /// The ButtonAutoNumber_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonAutoNumber_Click(object sender, EventArgs args)
        {
            decimal value = 1;
            if (InputBox.Show("Auto-Number", "Automatically number all data sources that do not have a number already set.\n\nStarting Number:", ref value, 1, 999999) != DialogResult.OK)
                return;

            var currentNum = (int)value;
            var dataSources = MainForm.CurrentSystem.DataSources.OrderBy(x => x.Type);
            foreach (var dataSource in dataSources.Where(x => x.Number == 0))
            {
                while (dataSources.Any(x => x.Number == currentNum))
                {
                    currentNum++;
                }
                dataSource.Number = currentNum;
                currentNum++;
            }

            // Refresh the items in the list view.
            PopulateDataSources();
        }

        /// <summary>
        /// The ButtonGapInfo_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonGapInfo_Click(object sender, EventArgs args)
        {
            if (lvDataSources.SelectedItems.Count == 0)
                return;

            var dataSource = (DataSource)lvDataSources.SelectedItems[0].Tag;

            // Show the GapDetailsForm dialog.
            using (var gapDetailsForm = new GapDetailsForm(dataSource))
            {
                gapDetailsForm.ShowDialog();
            }
        }

        /// <summary>
        /// The ButtonLimits_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonLimits_Click(object sender, EventArgs args)
        {
            if (lvDataSources.SelectedItems.Count == 0)
                return;

            var dataSource = (DataSource)lvDataSources.SelectedItems[0].Tag;

            // Show the LimitDetailsForm dialog.
            using (var limitDetailsForm = new LimitDetailsForm(dataSource.Limits, dataSource.Name))
            {
                limitDetailsForm.ShowDialog();
            }
        }

        /// <summary>
        /// The ButtonManageLinks_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonManageLinks_Click(object sender, EventArgs args)
        {
            if (lvDataSources.SelectedItems.Count == 0)
                return;

            var dataSource = (DataSource)lvDataSources.SelectedItems[0].Tag;

            // Show the ManageDataSourceLinksForm dialog.
            using (var manageDataSourceLinksForm = new ManageDataSourceLinksForm(dataSource))
            {
                manageDataSourceLinksForm.ShowDialog();
            }
        }

        /// <summary>
        /// The ButtonMetadata_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonMetadata_Click(object sender, EventArgs args)
        {
            if (lvDataSources.SelectedItems.Count == 0)
                return;

            var dataSource = (DataSource)lvDataSources.SelectedItems[0].Tag;

            using (var metadataDetailsForm = new MetadataDetailsForm(dataSource))
            {
                metadataDetailsForm.ShowDialog();
            }
        }

        /// <summary>
        /// The ButtonModify_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonModify_Click(object sender, EventArgs args)
        {
            if (lvDataSources.SelectedItems.Count == 0)
                return;

            var dataSource = (DataSource)lvDataSources.SelectedItems[0].Tag;

            // Show the ModifyDataSourceForm dialog.
            DialogResult result;
            using (var modifyDataSourceForm = new ModifyDataSourceForm(dataSource))
            {
                result = modifyDataSourceForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result != DialogResult.OK)
                return;

            // Refresh the items in the list view.
            PopulateDataSources();
        }

        /// <summary>
        /// The ButtonMotionConfig_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonMotionConfig_Click(object sender, EventArgs args)
        {
            if (lvDataSources.SelectedItems.Count == 0)
                return;

            var dataSource = (DataSource)lvDataSources.SelectedItems[0].Tag;
            var motionConfig = dataSource.MotionConfiguration;
            if (motionConfig == null)
                return;

            // Show the ModifyMotionConfigForm dialog.
            DialogResult result;
            using (var modifyMotionConfigForm = new ModifyMotionConfigForm(motionConfig))
            {
                result = modifyMotionConfigForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result != DialogResult.OK)
                return;

            // Refresh the items in the list view.
            PopulateDataSources();
        }

        /// <summary>
        /// The ButtonViewPtzLinkInfo_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonViewPtzLinkInfo_Click(object sender, EventArgs args)
        {
            if (lvDataSources.SelectedItems.Count == 0)
                return;

            var dataSource = (DataSource)lvDataSources.SelectedItems[0].Tag;

            using (var ptzLinkDetailsForm = new PtzLinkDetailsForm(dataSource))
            {
                ptzLinkDetailsForm.ShowDialog();
            }
        }

        /// <summary>
        /// The ButtonRefresh_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRefresh_Click(object sender, EventArgs args)
        {
            PopulateDataSources();
        }

        /// <summary>
        /// The ButtonViewBookmarks_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonViewBookmarks_Click(object sender, EventArgs args)
        {
            if (lvDataSources.SelectedItems.Count == 0)
                return;

            var dataSource = (DataSource)lvDataSources.SelectedItems[0].Tag;

            using (var bookmarkDetailsForm = new BookmarkDetailsForm(dataSource))
            {
                bookmarkDetailsForm.ShowDialog();
            }
        }

        /// <summary>
        /// The ButtonViewerInfo_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonViewerInfo_Click(object sender, EventArgs args)
        {
            if (lvDataSources.SelectedItems.Count == 0)
                return;

            var dataSource = (DataSource)lvDataSources.SelectedItems[0].Tag;

            // Show the MultiviewDetailsForm dialog.
            using (var multiviewDetailsForm = new MultiviewDetailsForm(dataSource))
            {
                multiviewDetailsForm.ShowDialog();
            }
        }

        /// <summary>
        /// The ButtonViewTags_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonViewTags_Click(object sender, EventArgs args)
        {
            if (lvDataSources.SelectedItems.Count == 0)
                return;

            var dataSource = (DataSource)lvDataSources.SelectedItems[0].Tag;

            using (var tagDetailsForm = new TagDetailsForm(dataSource))
            {
                tagDetailsForm.ShowDialog();
            }
        }

        /// <summary>
        /// The PopulateDataSources method.
        /// </summary>
        private void PopulateDataSources()
        {
            lvDataSources.Items.Clear();

            // Get the existing data sources from the VideoXpert system and add them
            // to the list view.
            foreach (var dataSource in MainForm.CurrentSystem.DataSources.OrderByDescending(x => x.Type))
            {
                var lvItem = new ListViewItem(dataSource.Number.ToString());
                lvItem.SubItems.Add(dataSource.Type.ToString());
                lvItem.SubItems.Add(dataSource.Name);
                lvItem.SubItems.Add(dataSource.Ip);
                lvItem.SubItems.Add(dataSource.Id);
                lvItem.SubItems.Add(dataSource.State.ToString());
                lvItem.SubItems.Add(dataSource.RetentionLimit.ToString());
                lvItem.SubItems.Add(dataSource.MotionConfiguration == null ? "N/A" : dataSource.MotionConfiguration.Mode.ToString());
                lvItem.SubItems.Add(dataSource.IsManuallyRecording.ToString());
                lvItem.SubItems.Add(dataSource.IsEnabled.ToString());
                lvItem.SubItems.Add(string.Join(", ", dataSource.Capabilities));
                lvItem.Tag = dataSource;
                lvDataSources.Items.Add(lvItem);
            }
        }

        #endregion Private Methods


    }
}