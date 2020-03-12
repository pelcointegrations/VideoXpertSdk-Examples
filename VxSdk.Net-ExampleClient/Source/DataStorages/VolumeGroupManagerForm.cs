using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The VolumeGroupManagerForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to view and modify data storages
    /// on the VideoXpert system.</remarks>
    public partial class VolumeGroupManagerForm : Form
    {
        private Configuration.Storage _storageConfig;

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeGroupManagerForm" /> class.
        /// </summary>
        public VolumeGroupManagerForm(DataStorage dataStorage)
        {
            _storageConfig = dataStorage.Configuration;

            InitializeComponent();

            PopulateVolumeGroups();
        }

        #endregion Public Constructors

        #region Private Methods

        /// <summary>
        /// The ButtonAddGroup_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonAddGroup_Click(object sender, EventArgs args)
        {
            // Show the AddEditVolumeGroupForm dialog.
            using (var addEditVolumeGroupForm = new AddEditVolumeGroupForm(_storageConfig, null))
            {
                addEditVolumeGroupForm.ShowDialog();
            }

            ButtonRefresh_Click(this, null);
        }

        /// <summary>
        /// The ButtonDeleteGroup_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonDeleteGroup_Click(object sender, EventArgs args)
        {
            if (lvVolumeGroups.SelectedItems.Count < 1)
                return;

            var volumeGroup = (VolumeGroup)lvVolumeGroups.SelectedItems[0].Tag;
            _storageConfig.DeleteVolumeGroup(volumeGroup);
            ButtonRefresh_Click(this, null);
        }

        /// <summary>
        /// The ButtonModifyGroup_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonModifyGroup_Click(object sender, EventArgs args)
        {
            if (lvVolumeGroups.SelectedItems.Count < 1)
                return;

            var volumeGroup = (VolumeGroup)lvVolumeGroups.SelectedItems[0].Tag;

            // Show the AddEditVolumeGroupForm dialog.
            using (var addEditVolumeGroupForm = new AddEditVolumeGroupForm(_storageConfig, volumeGroup))
            {
                addEditVolumeGroupForm.ShowDialog();
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
            lvVolumeGroups.Items.Clear();
            PopulateVolumeGroups();
            lvVolumeGroups.Refresh();
        }

        /// <summary>
        /// The PopulateVolumeGroups method.
        /// </summary>
        private void PopulateVolumeGroups()
        {
            // Get the volume groups from the data storage and add
            // them to the list view.
            foreach (var volumeGroup in _storageConfig.VolumeGroups)
            {
                var lvItem = new ListViewItem(volumeGroup.Name);
                lvItem.SubItems.Add(volumeGroup.Id);
                lvItem.SubItems.Add(volumeGroup.IsArchiveGroup.ToString());
                lvItem.SubItems.Add(volumeGroup.Volumes.Count.ToString());
                lvItem.SubItems.Add(volumeGroup.GetVolumeRelations(null).Count.ToString());
                lvItem.Tag = volumeGroup;
                lvVolumeGroups.Items.Add(lvItem);
            }
        }

        #endregion Private Methods
    }
}