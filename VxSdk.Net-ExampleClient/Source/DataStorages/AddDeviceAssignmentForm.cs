using System.Linq;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The AddDeviceAssignmentForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to add a new device assignment to
    /// a data storage.</remarks>
    public partial class AddDeviceAssignmentForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AddDeviceAssignmentForm" /> class.
        /// </summary>
        /// <param name="dataStorage">The selected data storage.</param>
        public AddDeviceAssignmentForm(DataStorage dataStorage)
        {
            InitializeComponent();
            SelectedDataStorage = dataStorage;

            PopulateStorageInfo();
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// Gets or sets the SelectedDataStorage property.
        /// </summary>
        /// <value>The selected data storage.</value>
        public DataStorage SelectedDataStorage { get; set; }

        #endregion Public Properties

        #region Private Methods

        /// <summary>
        /// The ButtonAdd_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonAdd_Click(object sender, System.EventArgs args)
        {
            // Create a new device assignment.
            var newDeviceAssignment = new NewDeviceAssignment();
            var device = ((ComboboxItem)cbxDevices.SelectedItem).Value as Device;
            if (device != null)
                newDeviceAssignment.DeviceId = device.Id;

            // Add any selected data sources to the new assignment.
            foreach (var dataSource in from ListViewItem item in lvDataSources.CheckedItems select (DataSource)item.Tag)
                newDeviceAssignment.DataSourceIds.Add(dataSource.Id);

            var cbxItem = cbxVolumeGroups.SelectedItem as ComboboxItem;
            if (cbxItem?.Value != null)
            {
                newDeviceAssignment.VolumeGroupId = (string)cbxItem.Value;
            }

            // Assign the device.
            var result = SelectedDataStorage.AssignDevice(newDeviceAssignment);
            if (result != Results.Value.OK)
                MainForm.Instance.WriteToLog($"Warning: UnassignDevice returned {result}");
        }

        /// <summary>
        /// The ComboBoxDevices_SelectedIndexChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ComboBoxDevices_SelectedIndexChanged(object sender, System.EventArgs args)
        {
            lvDataSources.Items.Clear();
            var device = ((ComboboxItem)cbxDevices.SelectedItem).Value as Device;

            if (device == null)
                return;

            // Add each data source to lvDataSources.
            foreach (var dataSource in device.DataSources)
            {
                var lvItem = new ListViewItem(string.Empty);
                lvItem.SubItems.Add(dataSource.Name);
                lvItem.Tag = dataSource;
                lvDataSources.Items.Add(lvItem);
            }
        }

        /// <summary>
        /// The PopulateStorageInfo method.
        /// </summary>
        private void PopulateStorageInfo()
        {
            var hostIds = SelectedDataStorage.DataSources.Select(dataSource => dataSource.HostDevice.Id).ToList();

            // Iterate through each device on the VxSystem.  This will allow us to filter for assigned data sources.
            foreach (var device in MainForm.CurrentDevices)
            {
                // Check if the device has its data source assigned and that it is a camera.
                if (hostIds.Any(hostId => hostId == device.Id) || device.Type != Device.Types.Camera)
                    continue;

                cbxDevices.Items.Add(new ComboboxItem { Text = device.Name, Value = device });
            }

            cbxVolumeGroups.Items.Add(new ComboboxItem { Text = "None", Value = null });
            var volumeGroups = SelectedDataStorage.Configuration?.VolumeGroups;
            if (volumeGroups != null)
            {
                foreach (var group in volumeGroups)
                {
                    cbxVolumeGroups.Items.Add(new ComboboxItem {Text = group.Name, Value = group.Id});
                }
            }

            cbxVolumeGroups.SelectedIndex = 0;

            UpdateControls();
        }

        /// <summary>
        /// The UpdateControls method.
        /// </summary>
        private void UpdateControls()
        {
            // Disable the device drop down and add button if no devices are found.
            if (cbxDevices.Items.Count < 1)
            {
                cbxDevices.Enabled = false;
                btnAdd.Enabled = false;
                lblNoUnassignedDevices.Visible = true;
            }
            else
                cbxDevices.SelectedIndex = 0;
        }

        #endregion Private Methods
    }
}