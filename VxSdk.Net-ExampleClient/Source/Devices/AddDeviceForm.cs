using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The AddDeviceForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to create a new device.</remarks>
    public partial class AddDeviceForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddDeviceForm" /> class.
        /// </summary>
        public AddDeviceForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The PopulateDrivers method.
        /// </summary>
        private void PopulateDrivers()
        {
            cbxDriverType.Items.Clear();

            // Get the drivers from the data storage and add them to the combo box.
            foreach (var driver in MainForm.CurrentSystem.Drivers)
            {
                var item = new ComboboxItem
                {
                    Text = driver.Name,
                    Value = driver.Type
                };

                cbxDriverType.Items.Add(item);
            }

            if (cbxDriverType.Items.Count > 0)
                cbxDriverType.SelectedIndex = 0;
        }

        /// <summary>
        /// The ButtonOk_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonOk_Click(object sender, EventArgs args)
        {
            if (string.IsNullOrEmpty(cbxDeviceType.Text))
                return;

            try
            {
                var newDevice = new NewDevice
                {
                    Ip = tbxIp.Text,
                    Name = tbxName.Text,
                    Username = tbxUsername.Text,
                    Password = tbxPassword.Text,
                    ShouldAutoCommission = ckbxAutoCommission.Checked
                };

                if (cbxDeviceType.SelectedIndex > 11)
                    newDevice.Type = (Device.Types)cbxDeviceType.SelectedIndex + 1;
                else
                    newDevice.Type = (Device.Types)cbxDeviceType.SelectedIndex;

                if (cbxDriverType.Enabled)
                {
                    var driverTypeItem = cbxDriverType.SelectedItem as ComboboxItem;
                    if (driverTypeItem != null)
                    {
                        var driverType = driverTypeItem.Value.ToString();
                        if (!string.IsNullOrEmpty(driverType))
                            newDevice.DriverType = driverType;
                    }
                }

                MainForm.CurrentSystem.AddDevice(newDevice);
            }
            catch (Exception ex)
            {
                MainForm.Instance.WriteToLog($"Error adding device: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// The ComboBoxDeviceType_SelectedIndexChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ComboBoxDeviceType_SelectedIndexChanged(object sender, EventArgs args)
        {
            if (cbxDeviceType.Text == @"Camera" || cbxDeviceType.Text == @"Encoder")
            {
                cbxDriverType.Enabled = true;
                PopulateDrivers();
            }
            else
            {
                cbxDriverType.Enabled = false;
                cbxDriverType.Items.Clear();
                cbxDriverType.Text = string.Empty;
            }
        }
    }
}
