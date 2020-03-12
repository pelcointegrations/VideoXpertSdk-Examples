using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The ModifyAccessPointForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to modify an access point.</remarks>
    public partial class ModifyAccessPointForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyAccessPointForm" /> class.
        /// </summary>
        /// <param name="accessPoint">The <paramref name="accessPoint"/> parameter.</param>
        public ModifyAccessPointForm(AccessPoint accessPoint)
        {
            InitializeComponent();
            SelectedAccessPoint = accessPoint;
            tbxName.Text = accessPoint.Name;
            cbxType.SelectedIndex = (int)accessPoint.Type;
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
        /// The ButtonSave_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            if (!string.IsNullOrEmpty(tbxName.Text) && SelectedAccessPoint.Name != tbxName.Text)
                SelectedAccessPoint.Name = tbxName.Text;

            var selectedType = (AccessPoint.AccessPointType) cbxType.SelectedIndex;
            if (SelectedAccessPoint.Type != selectedType)
                SelectedAccessPoint.Type = selectedType;
        }

        #endregion Private Methods
    }
}