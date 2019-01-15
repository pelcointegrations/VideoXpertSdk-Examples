using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The PixelSearchResultsForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to view pixel search results.</remarks>
    public partial class PixelSearchResultsForm : Form
    {
        /// <summary>
        /// Gets or sets the CurrentPixelSearch property.
        /// </summary>
        /// <value>The current pixel search.</value>
        private PixelSearch CurrentPixelSearch { get; }

        /// <summary>
        /// Gets or sets the SelectedDataSource property.
        /// </summary>
        /// <value>The selected data source.</value>
        private DataSource SelectedDataSource { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PixelSearchResultsForm" /> class.
        /// </summary>
        /// <param name="newPixelSearch">The <paramref name="newPixelSearch"/> parameter.</param>
        /// <param name="dataSource">The <paramref name="dataSource"/> parameter.</param>
        public PixelSearchResultsForm(NewPixelSearch newPixelSearch, DataSource dataSource)
        {
            InitializeComponent();
            SelectedDataSource = dataSource;
            CurrentPixelSearch = dataSource.CreatePixelSearch(newPixelSearch);
            if (CurrentPixelSearch == null)
            {
                lblStatus.Text = @"Failed";
                btnRefresh.Enabled = false;
                return;
            }

            lblStatus.Text = CurrentPixelSearch.Status.ToString();
            UpdateClips();
        }

        /// <summary>
        /// The ButtonOk_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonOk_Click(object sender, EventArgs args)
        {
            if (CurrentPixelSearch != null)
                SelectedDataSource.DeletePixelSearch(CurrentPixelSearch);

            Close();
        }

        /// <summary>
        /// The ButtonRefresh_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRefresh_Click(object sender, EventArgs args)
        {
            if (CurrentPixelSearch == null)
                return;

            lblStatus.Text = CurrentPixelSearch.Status.ToString();
            UpdateClips();
        }

        /// <summary>
        /// The UpdateClips method.
        /// </summary>
        private void UpdateClips()
        {
            lvClips.Items.Clear();
            foreach (var clip in CurrentPixelSearch.Clips)
            {
                var lvItem = new ListViewItem(clip.EventType.ToString());
                lvItem.SubItems.Add(clip.StartTime.ToString("s"));
                lvItem.SubItems.Add(clip.EndTime.ToString("s"));
                lvItem.Tag = clip;
                lvClips.Items.Add(lvItem);
            }
            lvClips.Refresh();
        }
    }
}
