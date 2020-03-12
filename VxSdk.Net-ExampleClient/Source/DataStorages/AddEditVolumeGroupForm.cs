using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The AddEditVolumeGroupForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to add or edit volume groups.</remarks>
    public partial class AddEditVolumeGroupForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AddEditVolumeGroupForm" /> class.
        /// </summary>
        /// <param name="currentStorageConfig">The selected storage config.</param>
        /// <param name="selectedVolumeGroup">The selected volume group.</param>
        public AddEditVolumeGroupForm(Configuration.Storage currentStorageConfig, VolumeGroup selectedVolumeGroup)
        {
            InitializeComponent();
            SelectedVolumeGroup = selectedVolumeGroup;
            CurrentStorageConfig = currentStorageConfig;

            if (SelectedVolumeGroup != null)
            { 
                Text = @"Edit Volume Group";
                btnAdd.Text = @"Save";
                PopulateVolumeGroupInfo();
            }
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Gets the CurrentStorageConfig property.
        /// </summary>
        /// <value>The current storage config.</value>
        private Configuration.Storage CurrentStorageConfig { get; }

        /// <summary>
        /// Gets the SelectedVolumeGroup property.
        /// </summary>
        /// <value>The selected volume group.</value>
        private VolumeGroup SelectedVolumeGroup { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonAdd_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonAdd_Click(object sender, System.EventArgs args)
        {
            if (string.IsNullOrEmpty(tbxName.Text))
                return;

            if (SelectedVolumeGroup != null)
            {
                if (SelectedVolumeGroup.Name != tbxName.Text)
                    SelectedVolumeGroup.Name = tbxName.Text;

                if (SelectedVolumeGroup.IsArchiveGroup != cbxArchiveGroup.Checked)
                    SelectedVolumeGroup.IsArchiveGroup = cbxArchiveGroup.Checked;
            }
            else
            {
                var newVolumeGroup = new NewVolumeGroup();
                newVolumeGroup.Name = tbxName.Text;
                newVolumeGroup.IsArchiveGroup = cbxArchiveGroup.Checked;
                CurrentStorageConfig.CreateVolumeGroup(newVolumeGroup);
            }
        }

        /// <summary>
        /// The PopulateVolumeGroupInfo method.
        /// </summary>
        private void PopulateVolumeGroupInfo()
        {
            tbxName.Text = SelectedVolumeGroup.Name;
            cbxArchiveGroup.Checked = SelectedVolumeGroup.IsArchiveGroup;
        }

        #endregion Private Methods
    }
}