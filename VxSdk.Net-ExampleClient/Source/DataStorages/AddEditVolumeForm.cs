using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The AddEditVolumeForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to add or edit volumes.</remarks>
    public partial class AddEditVolumeForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AddEditVolumeForm" /> class.
        /// </summary>
        /// <param name="currentStorageConfig">The selected storage config.</param>
        /// <param name="selectedVolume">The selected volume.</param>
        public AddEditVolumeForm(Configuration.Storage currentStorageConfig, Volume selectedVolume)
        {
            InitializeComponent();
            SelectedVolume = selectedVolume;
            CurrentStorageConfig = currentStorageConfig;

            if (SelectedVolume != null)
            { 
                Text = @"Edit Volume";
                btnAdd.Text = @"Save";
                PopulateVolumeInfo();
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
        /// Gets the SelectedVolume property.
        /// </summary>
        /// <value>The selected volume.</value>
        private Volume SelectedVolume { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonAdd_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonAdd_Click(object sender, System.EventArgs args)
        {
            if (string.IsNullOrEmpty(tbxPath.Text))
                return;

            if (SelectedVolume != null)
            {
                if (SelectedVolume.Path != tbxPath.Text)
                    SelectedVolume.Path = tbxPath.Text;

                if (SelectedVolume.Username != tbxUsername.Text)
                    SelectedVolume.Username = tbxUsername.Text;

                if (!string.IsNullOrEmpty(tbxPassword.Text))
                    SelectedVolume.Password = tbxPassword.Text;

                if (SelectedVolume.Domain != tbxDomain.Text)
                    SelectedVolume.Domain = tbxDomain.Text;

                if (Math.Abs(SelectedVolume.Buffer - (float)nudBuffer.Value) > 0)
                    SelectedVolume.Buffer = (float)nudBuffer.Value;

                if (SelectedVolume.IsBandwidthReserved != cbxReserveBandwidth.Checked)
                    SelectedVolume.IsBandwidthReserved = cbxReserveBandwidth.Checked;
            }
            else
            {
                var newVolume = new NewVolume();
                newVolume.Path = tbxPath.Text;
                newVolume.Username = tbxUsername.Text;
                newVolume.Password = tbxPassword.Text;
                newVolume.Domain = tbxDomain.Text;
                newVolume.Buffer = (float)nudBuffer.Value;
                newVolume.IsBandwidthReserved = cbxReserveBandwidth.Checked;
                CurrentStorageConfig.CreateVolume(newVolume);
            }
        }

        /// <summary>
        /// The PopulateVolumeInfo method.
        /// </summary>
        private void PopulateVolumeInfo()
        {
            tbxPath.Text = SelectedVolume.Path;
            tbxUsername.Text = SelectedVolume.Username;
            tbxDomain.Text = SelectedVolume.Domain;
            nudBuffer.Value = (decimal)SelectedVolume.Buffer;
            cbxReserveBandwidth.Checked = SelectedVolume.IsBandwidthReserved;
        }

        #endregion Private Methods
    }
}