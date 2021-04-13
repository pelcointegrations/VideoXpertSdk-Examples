using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The AddDeviceSearchForm class.
    /// </summary>
    /// <remarks>
    /// Provides a dialog window that allows the user to enter device information to be added to a device discovery request.
    /// </remarks>
    public partial class AddDeviceSearchForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AddDeviceSearchForm" /> class.
        /// </summary>
        public AddDeviceSearchForm()
        {
            InitializeComponent();

            foreach (var driver in MainForm.CurrentSystem.Drivers)
            {
                cbxDriver.Items.Add(new ComboboxItem {Text = driver.Name, Value = driver.Type});
            }

            DeviceSearchItem =  new DeviceSearch();
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// Gets or sets the DeviceSearchItem property.
        /// </summary>
        /// <value>The device search item to return.</value>
        public DeviceSearch DeviceSearchItem { get; }

        #endregion Public Properties

        #region Private Methods

        /// <summary>
        /// The ButtonOk_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonOk_Click(object sender, EventArgs args)
        {
            DeviceSearchItem.Host = tbxHostname.Text;
            DeviceSearchItem.Port = (int)nudPort.Value; 
            DeviceSearchItem.Username = tbxUsername.Text;
            DeviceSearchItem.Password = tbxPassword.Text;
            if (cbxDriver.SelectedIndex >= 0)
            {
                DeviceSearchItem.DriverType = (string) ((ComboboxItem) cbxDriver.SelectedItem).Value;
            }
        }

        #endregion Private Methods

    }
}