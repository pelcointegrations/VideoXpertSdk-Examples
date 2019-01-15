using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The MetadataDetailsForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that contains the info for any metadata relations found on the selected data source.</remarks>
    public partial class MetadataDetailsForm : Form
    {
        /// <summary>
        /// Gets or sets the SelectedDataSource property.
        /// </summary>
        /// <value>The currently selected dataSource.</value>
        private DataSource SelectedDataSource { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataDetailsForm" /> class.
        /// </summary>
        /// <param name="dataSource">The <paramref name="dataSource"/> parameter.</param>
        public MetadataDetailsForm(DataSource dataSource)
        {
            InitializeComponent();
            SelectedDataSource = dataSource;
            PopulateMetadataInfo();
        }

        /// <summary>
        /// The PopulateMetadataInfo method.
        /// </summary>
        private void PopulateMetadataInfo()
        {
            lvMetadataInfo.Items.Clear();

            foreach (var metadata in SelectedDataSource.MetadataRelations)
            {
                var lvItem = new ListViewItem(metadata.Resource.Name);
                lvItem.SubItems.Add(metadata.Resource.Id);
                lvMetadataInfo.Items.Add(lvItem);
            }
        }

        /// <summary>
        /// The ButtonRefresh_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRefresh_Click(object sender, System.EventArgs args)
        {
            PopulateMetadataInfo();
        }
    }
}
