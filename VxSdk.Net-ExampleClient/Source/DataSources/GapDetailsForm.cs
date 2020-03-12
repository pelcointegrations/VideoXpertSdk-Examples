using System.Linq;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The GapDetailsForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that contains the info for any gaps found on the selected data source.</remarks>
    public partial class GapDetailsForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GapDetailsForm" /> class.
        /// </summary>
        /// <param name="dataSource">The <paramref name="dataSource"/> parameter.</param>
        public GapDetailsForm(DataSource dataSource)
        {
            InitializeComponent();
            SelectedDataSource = dataSource;
            PopulateGapInfo();
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
            PopulateGapInfo();
        }

        /// <summary>
        /// The PopulateGapInfo method.
        /// </summary>
        private void PopulateGapInfo()
        {
            lvGapInfo.Items.Clear();

            foreach (var gap in SelectedDataSource.Gaps)
            {
                var lvItem = new ListViewItem(gap.Reason.ToString());
                lvItem.SubItems.Add(gap.StartTime.ToString("s"));
                lvItem.SubItems.Add(gap.EndTime.ToString("s"));
                lvItem.SubItems.Add(gap.GapFillingStatus.ToString());
                lvItem.SubItems.Add(gap.DataStorageId);
                if (gap.ReasonData.Count > 0)
                {
                    var reasons = (from kvp in gap.ReasonData select kvp.Value).ToList();
                    lvItem.SubItems.Add(string.Join(", ", reasons));
                }
                lvGapInfo.Items.Add(lvItem);
            }
        }

        #endregion Private Methods
    }
}