using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The DataStorageManagerForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to view and modify data storages
    /// on the VideoXpert system.</remarks>
    public partial class DataStorageManagerForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataStorageManagerForm" /> class.
        /// </summary>
        public DataStorageManagerForm()
        {
            InitializeComponent();

            PopulateDataStorages();
        }

        /// <summary>
        /// The ButtonAddClip_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonAddClip_Click(object sender, EventArgs args)
        {
            if (lvDataStorageManager.SelectedItems.Count < 1)
                return;

            var dataStorage = (DataStorage)lvDataStorageManager.SelectedItems[0].Tag;
            if (dataStorage.Type != DataStorage.DataStorageTypes.VideoXpertStorage)
                return;

            // Show the AddEdgeClipForm dialog.
            using (var addEdgeClipForm = new AddEdgeClipForm(dataStorage))
            {
                addEdgeClipForm.ShowDialog();
            }
        }

        /// <summary>
        /// The ButtonAssignDevice_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonAssignDevice_Click(object sender, EventArgs args)
        {
            if (lvDataStorageManager.SelectedItems.Count < 1)
                return;

            var dataStorage = (DataStorage)lvDataStorageManager.SelectedItems[0].Tag;

            // Show the AddDeviceAssignmentForm dialog.
            DialogResult result;
            using (var addDeviceAssignmentForm = new AddDeviceAssignmentForm(dataStorage))
            {
                result = addDeviceAssignmentForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result != DialogResult.OK)
                return;

            // Refresh the items in the list view.
            lvDataStorageManager.Items.Clear();
            PopulateDataStorages();
            lvDataStorageManager.Refresh();
        }

        /// <summary>
        /// The ButtonUnassignDevice_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonUnassignDevice_Click(object sender, EventArgs args)
        {
            if (lvDataStorageManager.SelectedItems.Count < 1)
                return;

            var dataStorage = (DataStorage)lvDataStorageManager.SelectedItems[0].Tag;

            // Show the RemoveDeviceAssignmentForm dialog.
            DialogResult result;
            using (var removeDeviceAssignmentForm = new RemoveDeviceAssignmentForm(dataStorage))
            {
                result = removeDeviceAssignmentForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result != DialogResult.OK)
                return;

            // Refresh the items in the list view.
            lvDataStorageManager.Items.Clear();
            PopulateDataStorages();
            lvDataStorageManager.Refresh();
        }

        /// <summary>
        /// The ButtonViewDetails_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonViewDetails_Click(object sender, EventArgs args)
        {
            if (lvDataStorageManager.SelectedItems.Count < 1)
                return;

            var dataStorage = (DataStorage)lvDataStorageManager.SelectedItems[0].Tag;

            using (var dataStorageDetailsForm = new DataStorageDetailsForm())
            {
                dataStorageDetailsForm.GetDataStorageInfo(dataStorage);
                dataStorageDetailsForm.ShowDialog();
            }
        }

        /// <summary>
        /// The ListViewDataStorageManager_SelectedIndexChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ListViewDataStorageManager_SelectedIndexChanged(object sender, EventArgs args)
        {
            if (lvDataStorageManager.SelectedItems.Count < 1)
                return;

            var dataStorage = (DataStorage)lvDataStorageManager.SelectedItems[0].Tag;
            btnAddClip.Enabled = dataStorage.Type == DataStorage.DataStorageTypes.VideoXpertStorage;
        }

        /// <summary>
        /// The PopulateDataStorages method.
        /// </summary>
        private void PopulateDataStorages()
        {
            // Get the data storages from the VideoXpert system and add
            // them to the list view.
            foreach (var dataStorage in MainForm.CurrentSystem.DataStorages)
            {
                var isEdge = dataStorage.Type == DataStorage.DataStorageTypes.Edge;
                var lvItem = new ListViewItem(dataStorage.Name);
                lvItem.SubItems.Add(dataStorage.Id);
                lvItem.SubItems.Add(dataStorage.Type.ToString());
                lvItem.SubItems.Add(dataStorage.HostDevice.Name);
                lvItem.SubItems.Add(isEdge ? "N/A" : dataStorage.DeviceAssignments.Count.ToString());
                lvItem.Tag = dataStorage;
                lvDataStorageManager.Items.Add(lvItem);
            }
        }
    }
}
