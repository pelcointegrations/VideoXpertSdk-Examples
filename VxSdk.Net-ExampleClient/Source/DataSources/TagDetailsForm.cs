using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The TagDetailsForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that contains the info for any tags found on the selected data source.</remarks>
    public partial class TagDetailsForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TagDetailsForm" /> class.
        /// </summary>
        /// <param name="dataSource">The <paramref name="dataSource"/> parameter.</param>
        public TagDetailsForm(DataSource dataSource)
        {
            InitializeComponent();
            SelectedDataSource = dataSource;
            PopulateTagInfo();
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
        /// The ButtonRefresh_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRefresh_Click(object sender, System.EventArgs args)
        {
            PopulateTagInfo();
        }

        /// <summary>
        /// The PopulateTagInfo method.
        /// </summary>
        private void PopulateTagInfo()
        {
            lvTags.Items.Clear();

            foreach (var tag in SelectedDataSource.Tags)
            {
                var lvItem = new ListViewItem(tag.Name);
                lvItem.SubItems.Add(tag.Id);
                lvItem.SubItems.Add(tag.OwnerName);
                lvTags.Items.Add(lvItem);
            }
        }

        #endregion Private Methods
    }
}