using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The FileRecoveryManagerForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to manage file recovery on a recorder.</remarks>
    public partial class FileRecoveryManagerForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FileRecoveryManagerForm" /> class.
        /// </summary>
        /// <param name="storageConfig">The storage config to retrieve the file recovery from.</param>
        public FileRecoveryManagerForm(Configuration.Storage storageConfig)
        {
            InitializeComponent();
            SelectedStorageConfig = storageConfig;

            PopulateFileRecoveryInfo();
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// Gets or sets the SelectedStorageConfig property.
        /// </summary>
        /// <value>The selected storage config.</value>
        public Configuration.Storage SelectedStorageConfig { get; set; }

        #endregion Public Properties

        #region Private Methods

        /// <summary>
        /// The ButtonHalt_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonHalt_Click(object sender, EventArgs args)
        {
            SelectedStorageConfig.FileRecoveryResource.Halt();
            PopulateFileRecoveryInfo();
        }

        /// <summary>
        /// The ButtonRefresh_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRefresh_Click(object sender, EventArgs args)
        {
            PopulateFileRecoveryInfo();
        }

        /// <summary>
        /// The ButtonTrigger_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonTrigger_Click(object sender, EventArgs args)
        {
            using (var fileRecoveryManagerForm = new TriggerFileRecoveryForm(SelectedStorageConfig))
            {
                if (fileRecoveryManagerForm.ShowDialog() == DialogResult.OK)
                {
                    SelectedStorageConfig.FileRecoveryResource.Trigger(fileRecoveryManagerForm.VolumeId, fileRecoveryManagerForm.StartTime, fileRecoveryManagerForm.EndTime);
                    PopulateFileRecoveryInfo();
                }
            }
        }

        /// <summary>
        /// The PopulateFileRecoveryInfo method.
        /// </summary>
        private void PopulateFileRecoveryInfo()
        {
            FileRecovery fileRecovery = SelectedStorageConfig.FileRecoveryResource;

            tbxStatus.Text = fileRecovery.Status.ToString();
            tbxFilesRecovered.Text = fileRecovery.FilesRecovered.ToString();
            tbxStatusMessage.Text = fileRecovery.StatusMessage;
        }

        #endregion Private Methods
    }
}