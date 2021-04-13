using System;
using System.Linq;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The DeviceManagerForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to view, create and delete
    /// devices from the VideoXpert system.</remarks>
    public partial class DeviceManagerForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceManagerForm" /> class.
        /// </summary>
        public DeviceManagerForm()
        {
            InitializeComponent();

            PopulateDevices();
        }

        #endregion Public Constructors

        #region Private Methods

        /// <summary>
        /// The ButtonAdd_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonAdd_Click(object sender, EventArgs args)
        {
            // Show the AddDeviceForm dialog.
            DialogResult result;
            using (var addDeviceForm = new AddDeviceForm())
            {
                result = addDeviceForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result != DialogResult.OK)
                return;

            // Refresh the items in the list view to include the newly added Device.
            PopulateDevices();
        }

        /// <summary>
        /// The ButtonCommission_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonCommission_Click(object sender, EventArgs args)
        {
            if (lvDevices.SelectedItems.Count == 0)
                return;

            var device = (Device)lvDevices.SelectedItems[0].Tag;
            MainForm.CurrentSystem.CommissionDevice(device);
            PopulateDevices();
        }

        /// <summary>
        /// The ButtonDbBackups_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonDbBackups_Click(object sender, EventArgs args)
        {
            if (lvDevices.SelectedItems.Count == 0)
                return;

            var device = (Device)lvDevices.SelectedItems[0].Tag;

            // Show the DatabaseBackupManagerForm dialog.
            using (var databaseBackupManagerForm = new DatabaseBackupManagerForm(device))
            {
                databaseBackupManagerForm.ShowDialog();
            }
        }

        /// <summary>
        /// The ButtonDecommission_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonDecommission_Click(object sender, EventArgs args)
        {
            if (lvDevices.SelectedItems.Count == 0)
                return;

            var device = (Device)lvDevices.SelectedItems[0].Tag;
            MainForm.CurrentSystem.DecommissionDevice(device);
            PopulateDevices();
        }

        /// <summary>
        /// The ButtonDelete_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonDelete_Click(object sender, EventArgs args)
        {
            if (lvDevices.SelectedItems.Count == 0)
                return;

            // Get the associated Device object from the selected item and delete
            // it from the VideoXpert system.
            var device = (Device)lvDevices.SelectedItems[0].Tag;
            MainForm.CurrentSystem.DeleteDevice(device);
            PopulateDevices();
        }

        /// <summary>
        /// The ButtonDiagnostics_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonDiagnostics_Click(object sender, EventArgs args)
        {
            if (lvDevices.SelectedItems.Count == 0)
                return;

            var device = (Device)lvDevices.SelectedItems[0].Tag;

            // Show the DiagnosticDetailsForm dialog.
            using (var diagnosticDetailsForm = new DiagnosticDetailsForm(device))
            {
                diagnosticDetailsForm.ShowDialog();
            }
        }

        /// <summary>
        /// The ButtonLicenseInfo_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonLicenseInfo_Click(object sender, EventArgs args)
        {
            if (lvDevices.SelectedItems.Count == 0)
                return;

            var device = (Device)lvDevices.SelectedItems[0].Tag;

            // Show the LicenseFeatureDetailsForm dialog.
            using (var licenseFeatureDetailsForm = new LicenseFeatureDetailsForm(device))
            {
                licenseFeatureDetailsForm.ShowDialog();
            }
        }

        /// <summary>
        /// The ButtonLimits_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonLimits_Click(object sender, EventArgs args)
        {
            if (lvDevices.SelectedItems.Count == 0)
                return;

            var device = (Device)lvDevices.SelectedItems[0].Tag;

            // Show the LimitDetailsForm dialog.
            using (var limitDetailsForm = new LimitDetailsForm(device.Limits, device.Name))
            {
                limitDetailsForm.ShowDialog();
            }
        }

        /// <summary>
        /// The ButtonManageLogs_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonManageLogs_Click(object sender, EventArgs args)
        {
            if (lvDevices.SelectedItems.Count == 0)
                return;

            var device = (Device)lvDevices.SelectedItems[0].Tag;

            // Show the LogManagerForm dialog.
            using (var logManagerForm = new LogManagerForm(device))
            {
                logManagerForm.ShowDialog();
            }
        }

        /// <summary>
        /// The ButtonModify_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonModify_Click(object sender, EventArgs args)
        {
            if (lvDevices.SelectedItems.Count == 0)
                return;

            var device = (Device)lvDevices.SelectedItems[0].Tag;

            // Show the ModifyDeviceForm dialog.
            DialogResult result;
            using (var modifyDeviceForm = new ModifyDeviceForm(device))
            {
                result = modifyDeviceForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result != DialogResult.OK)
                return;

            // Refresh the items in the list view.
            PopulateDevices();
        }

        /// <summary>
        /// The ButtonRefresh_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRefresh_Click(object sender, EventArgs args)
        {
            PopulateDevices();
        }

        /// <summary>
        /// The ButtonSilence_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonSilence_Click(object sender, EventArgs args)
        {
            if (lvDevices.SelectedItems.Count == 0)
                return;

            var device = (Device)lvDevices.SelectedItems[0].Tag;
            device.Silence();
        }

        /// <summary>
        /// The ButtonUpdate_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonUpdate_Click(object sender, EventArgs args)
        {
            if (lvDevices.SelectedItems.Count == 0)
                return;

            var device = (Device)lvDevices.SelectedItems[0].Tag;
            device.TriggerRefresh();
        }

        /// <summary>
        /// The ButtonUpdateSoftware_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonUpdateSoftware_Click(object sender, EventArgs args)
        {
            if (lvDevices.SelectedItems.Count == 0)
                return;

            var device = (Device)lvDevices.SelectedItems[0].Tag;

            // Show the FileSelectionForm dialog.
            using (var fileSelectionForm = new FileSelectionForm(device))
            {
                fileSelectionForm.ShowDialog();
            }
        }

        /// <summary>
        /// The ButtonThermalEtd_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonThermalEtd_Click(object sender, EventArgs args)
        {
            if (lvDevices.SelectedItems.Count == 0)
                return;

            var device = (Device)lvDevices.SelectedItems[0].Tag;
            var thermalEtdConfig = device.ThermalEtdConfig;
            if (thermalEtdConfig == null)
                return;

            // Show the ThermalEtdConfigurationForm dialog.
            using (var thermalEtdConfigurationForm = new ThermalEtdConfigurationForm(thermalEtdConfig))
            {
                thermalEtdConfigurationForm.ShowDialog();
            }
        }

        /// <summary>
        /// The ButtonTimeConfig_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonTimeConfig_Click(object sender, EventArgs args)
        {
            if (lvDevices.SelectedItems.Count == 0)
                return;

            var device = (Device)lvDevices.SelectedItems[0].Tag;
            var timeConfig = device.TimeConfig;
            if (timeConfig == null)
                return;

            // Show the TimeConfigurationForm dialog.
            using (var timeConfigurationForm = new TimeConfigurationForm(timeConfig))
            {
                timeConfigurationForm.ShowDialog();
            }
        }

        /// <summary>
        /// The ListViewDevices_SelectedIndexChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ListViewDevices_SelectedIndexChanged(object sender, EventArgs args)
        {
            if (lvDevices.SelectedItems.Count == 0)
                return;

            var device = (Device)lvDevices.SelectedItems[0].Tag;
            btnManageLogs.Enabled = device.CanCreateLogs;
            btnDiagnostics.Enabled = device.HasDeviceDiagnostics;
            btnLicenseInfo.Enabled = device.LicensableFeatures.Count > 0 || device.LicensedFeatures.Count > 0;
            btnDbBackups.Enabled = device.DatabaseBackups != null;
            btnThermalEtd.Enabled = device.ThermalEtdConfig != null;
            btnTimeConfig.Enabled = device.TimeConfig != null;
        }

        /// <summary>
        /// The PopulateDevices method.
        /// </summary>
        private void PopulateDevices()
        {
            lvDevices.Items.Clear();

            // Get the existing Devices from the VideoXpert system and add
            // them to the list view.
            var drivers = MainForm.CurrentSystem.Drivers;
            foreach (var device in MainForm.CurrentSystem.Devices)
            {
                string type;
                switch (device.Type)
                {
                    case Device.Types.Acc:
                        type = "Accessory Server";
                        break;

                    case Device.Types.AllInOne:
                        type = "VxPro";
                        break;

                    case Device.Types.Mg:
                        type = "MediaGateway";
                        break;

                    case Device.Types.Ui:
                        type = "User Interface";
                        break;

                    default:
                        type = device.Type.ToString();
                        break;
                }

                var lvItem = new ListViewItem(type);
                lvItem.SubItems.Add(device.Name);
                lvItem.SubItems.Add(device.Ip);
                lvItem.SubItems.Add(device.Port.ToString());
                lvItem.SubItems.Add(device.Id);
                lvItem.SubItems.Add(device.Model);
                lvItem.SubItems.Add(device.State.ToString());
                if (!string.IsNullOrEmpty(device.DriverTypeId) && drivers.Any(drvr => drvr.Type == device.DriverTypeId))
                    lvItem.SubItems.Add(drivers.First(driver => driver.Type == device.DriverTypeId).Name);
                else
                    lvItem.SubItems.Add(string.Empty);

                lvItem.SubItems.Add(device.Version);
                lvItem.SubItems.Add(device.IsCommissioned ? "Yes" : "No");
                lvItem.Tag = device;
                lvDevices.Items.Add(lvItem);
            }
        }


        #endregion Private Methods

    }
}