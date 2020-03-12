using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The VolumeManagerForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to view and modify volumes.</remarks>
    public partial class VolumeManagerForm : Form
    {
        private Configuration.Storage _storageConfig;

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeManagerForm" /> class.
        /// </summary>
        public VolumeManagerForm(DataStorage dataStorage)
        {
            _storageConfig = dataStorage.Configuration;

            InitializeComponent();

            PopulateVolumes();
        }

        #endregion Public Constructors

        #region Private Methods

        /// <summary>
        /// The ButtonAddVolume_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonAddVolume_Click(object sender, EventArgs args)
        {
            // Show the AddEditVolumeForm dialog.
            using (var addEditVolumeForm = new AddEditVolumeForm(_storageConfig, null))
            {
                addEditVolumeForm.ShowDialog();
            }

            ButtonRefresh_Click(this, null);
        }

        /// <summary>
        /// The ButtonDeleteVolume_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonDeleteVolume_Click(object sender, EventArgs args)
        {
            if (lvVolumes.SelectedItems.Count < 1)
                return;

            var volume = (Volume)lvVolumes.SelectedItems[0].Tag;
            _storageConfig.DeleteVolume(volume);
            ButtonRefresh_Click(this, null);
        }

        /// <summary>
        /// The ButtonModifyVolume_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonModifyVolume_Click(object sender, EventArgs args)
        {
            if (lvVolumes.SelectedItems.Count < 1)
                return;

            var volume = (Volume)lvVolumes.SelectedItems[0].Tag;

            // Show the AddEditVolumeForm dialog.
            using (var addEditVolumeForm = new AddEditVolumeForm(_storageConfig, volume))
            {
                addEditVolumeForm.ShowDialog();
            }

            ButtonRefresh_Click(this, null);
        }

        /// <summary>
        /// The ButtonRefresh_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRefresh_Click(object sender, EventArgs args)
        {
            // Refresh the items in the list view.
            lvVolumes.Items.Clear();
            PopulateVolumes();
            lvVolumes.Refresh();
        }

        /// <summary>
        /// The PopulateVolumes method.
        /// </summary>
        private void PopulateVolumes()
        {
            // Add the volumes to the list view.
            foreach (var volume in _storageConfig.Volumes)
            {
                var lvItem = new ListViewItem(volume.Id);
                lvItem.SubItems.Add(volume.Path);
                lvItem.SubItems.Add(volume.Domain);
                lvItem.SubItems.Add(volume.Username);
                lvItem.SubItems.Add(volume.Buffer.ToString());
                lvItem.SubItems.Add(volume.Used.ToString());
                lvItem.SubItems.Add(volume.Total.ToString());
                lvItem.SubItems.Add(volume.IsOnline.ToString());
                lvItem.SubItems.Add(volume.IsBandwidthReserved.ToString());
                lvItem.SubItems.Add(volume.VolumeGroup?.Name);
                lvItem.Tag = volume;
                lvVolumes.Items.Add(lvItem);
            }
        }

        #endregion Private Methods
    }
}