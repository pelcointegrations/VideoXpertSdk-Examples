using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The RelationDetailsForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that contains the info for any relations found on the selected access point.</remarks>
    public partial class RelationDetailsForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RelationDetailsForm" /> class.
        /// </summary>
        /// <param name="accessPoint">The <paramref name="accessPoint"/> parameter.</param>
        public RelationDetailsForm(AccessPoint accessPoint)
        {
            InitializeComponent();
            SelectedAccessPoint = accessPoint;
            PopulateRelationInfo();
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Gets or sets the SelectedAccessPoint property.
        /// </summary>
        /// <value>The currently selected access point.</value>
        private AccessPoint SelectedAccessPoint { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonRefresh_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRefresh_Click(object sender, System.EventArgs args)
        {
            PopulateRelationInfo();
        }

        /// <summary>
        /// The PopulateRelationInfo method.
        /// </summary>
        private void PopulateRelationInfo()
        {
            lvRelationInfo.Items.Clear();

            foreach (var relation in SelectedAccessPoint.LinkedRelations)
            {
                var lvItem = new ListViewItem(relation.Resource.Name);
                lvItem.SubItems.Add(relation.Resource.Id);
                lvRelationInfo.Items.Add(lvItem);
            }
        }

        #endregion Private Methods
    }
}