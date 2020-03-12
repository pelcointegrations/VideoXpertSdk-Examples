using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The TriggerFileRecoveryForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to select the values to use for
    /// triggering a file recovery.</remarks>
    public partial class TriggerFileRecoveryForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerFileRecoveryForm" /> class.
        /// </summary>
        public TriggerFileRecoveryForm(Configuration.Storage storageConfig)
        {
            InitializeComponent();

            // Get the volumes from the VxStorage and add them to the combobox.
            foreach (var volume in storageConfig.Volumes)
                cbxVolume.Items.Add(new ComboboxItem { Text = volume.Path, Value = volume.Id });
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// Gets or sets the EndTime property.
        /// </summary>
        /// <value>The selected end time.</value>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Gets or sets the StartTime property.
        /// </summary>
        /// <value>The selected start time.</value>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the VolumeId property.
        /// </summary>
        /// <value>The selected volume ID.</value>
        public string VolumeId { get; set; }

        #endregion Public Properties

        #region Private Methods

        /// <summary>
        /// The ButtonTrigger_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ButtonTrigger_Click(object sender, EventArgs args)
        {
            StartTime = dtpStartDate.Value;
            EndTime = dtpEndDate.Value;
            var cbItem = (ComboboxItem)cbxVolume.SelectedItem;
            VolumeId = (string)cbItem?.Value;
        }

        /// <summary>
        /// The ComboboxVolume_SelectedIndexChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ComboboxVolume_SelectedIndexChanged(object sender, EventArgs args)
        {
            btnTrigger.Enabled = cbxVolume.SelectedItem != null;
        }

        #endregion Private Methods
    }
}