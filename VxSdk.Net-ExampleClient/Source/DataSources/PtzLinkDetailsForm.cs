using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The PtzLinkDetailsForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that contains the PTZ link info for the selected data source.</remarks>
    public partial class PtzLinkDetailsForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PtzLinkDetailsForm" /> class.
        /// </summary>
        /// <param name="dataSource">The <paramref name="dataSource"/> parameter.</param>
        public PtzLinkDetailsForm(DataSource dataSource)
        {
            InitializeComponent();
            SelectedDataSource = dataSource;
            PopulatePtzLinkInfo();
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
            PopulatePtzLinkInfo();
        }

        /// <summary>
        /// The PopulatePtzLinkInfo method.
        /// </summary>
        private void PopulatePtzLinkInfo()
        {
            lvPtzLinkInfo.Items.Clear();

            foreach (var ptzLinkInfo in SelectedDataSource.VxLinkedPtzInfo)
            {
                var lvItem = new ListViewItem(ptzLinkInfo.Name);
                lvItem.SubItems.Add(ptzLinkInfo.Ip);
                lvPtzLinkInfo.Items.Add(lvItem);
            }
        }

        #endregion Private Methods
    }
}