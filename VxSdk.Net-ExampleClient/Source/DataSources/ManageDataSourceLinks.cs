using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The ManageDataSourceLinksForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to modify a data sources linked resources.</remarks>
    public partial class ManageDataSourceLinksForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ManageDataSourceLinksForm" /> class.
        /// </summary>
        /// <param name="dataSource">The <paramref name="dataSource"/> parameter.</param>
        public ManageDataSourceLinksForm(DataSource dataSource)
        {
            InitializeComponent();
            SelectedDataSource = dataSource;
            PopulateLinkedDataSources();
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Gets or sets the SelectedDataSource property.
        /// </summary>
        /// <value>The currently selected dataSource.</value>
        private DataSource SelectedDataSource { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonLink_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonLink_Click(object sender, EventArgs args)
        {
            if (lvDataSources.SelectedItems.Count == 0)
                return;

            var resource = (ResourceRel)lvDataSources.SelectedItems[0].Tag;
            resource.IsLinked = !resource.IsLinked;

            PopulateLinkedDataSources();
        }

        /// <summary>
        /// The ListViewDataSources_SelectedIndexChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ListViewDataSources_SelectedIndexChanged(object sender, EventArgs args)
        {
            if (lvDataSources.SelectedItems.Count == 0)
                return;

            var resource = (ResourceRel)lvDataSources.SelectedItems[0].Tag;
            btnLink.Text = resource.IsLinked ? "Unlink" : "Link";
        }

        /// <summary>
        /// The PopulateDataSources method.
        /// </summary>
        private void PopulateLinkedDataSources()
        {
            lvDataSources.Items.Clear();

            // Get the existing data sources from the VideoXpert system and add
            // them to the list view.
            var resources = SelectedDataSource.Type == DataSource.Types.Audio ? SelectedDataSource.VideoRelations : SelectedDataSource.AudioRelations;

            foreach (var resource in resources)
            {
                var dataSource = resource.Resource;
                var lvItem = new ListViewItem(dataSource.Number.ToString());
                lvItem.SubItems.Add(dataSource.Name);
                lvItem.SubItems.Add(dataSource.Ip);
                lvItem.SubItems.Add(resource.IsLinked.ToString());
                lvItem.Tag = resource;
                lvDataSources.Items.Add(lvItem);
            }
        }

        #endregion Private Methods
    }
}