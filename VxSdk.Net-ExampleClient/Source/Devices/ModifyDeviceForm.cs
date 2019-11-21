using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The ModifyDeviceForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to modify a device.</remarks>
    public partial class ModifyDeviceForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyDeviceForm" /> class.
        /// </summary>
        /// <param name="device">The <paramref name="device"/> parameter.</param>
        public ModifyDeviceForm(Device device)
        {
            InitializeComponent();
            SelectedDevice = device;
            tbxName.Text = device.Name;
            tbxUsername.Text = device.Username;
            tbxIp.Text = device.Ip;
            nudPort.Value = device.Port;
            tbxVersion.Text = device.Version;

            var index = 0;
            var count = 0;
            foreach (var driver in MainForm.CurrentSystem.Drivers)
            {
                if (device.DriverTypeId == driver.Type)
                    index = count;

                cbxDriver.Items.Add(new ComboboxItem { Text = driver.Name, Value = driver.Type });
                count++;
            }

            cbxDriver.SelectedIndex = index;
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Gets or sets the SelectedDevice property.
        /// </summary>
        /// <value>The currently selected device.</value>
        private Device SelectedDevice { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonSave_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            if (!string.IsNullOrEmpty(tbxName.Text) && SelectedDevice.Name != tbxName.Text)
                SelectedDevice.Name = tbxName.Text;

            if (!string.IsNullOrEmpty(tbxUsername.Text) && SelectedDevice.Username != tbxUsername.Text)
                SelectedDevice.Username = tbxUsername.Text;

            if (!string.IsNullOrEmpty(tbxPassword.Text))
                SelectedDevice.Password = tbxPassword.Text;

            if (!string.IsNullOrEmpty(tbxIp.Text) && SelectedDevice.Ip != tbxIp.Text)
                SelectedDevice.Ip = tbxIp.Text;

            if (!string.IsNullOrEmpty(tbxVersion.Text) && SelectedDevice.Version != tbxVersion.Text)
                SelectedDevice.Version = tbxVersion.Text;

            if (nudPort.Value >= 80 && SelectedDevice.Port != nudPort.Value)
                SelectedDevice.Port = (int)nudPort.Value;

            if (cbxDriver.Items.Count <= 0 || cbxDriver.SelectedIndex < 0)
                return;

            if (SelectedDevice.DriverTypeId != (string)((ComboboxItem)cbxDriver.SelectedItem).Value)
                SelectedDevice.DriverTypeId = (string)((ComboboxItem)cbxDriver.SelectedItem).Value;
        }

        #endregion Private Methods
    }
}