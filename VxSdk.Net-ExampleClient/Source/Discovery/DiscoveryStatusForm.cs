using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The DiscoveryStatusForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to trigger and view the current discovery status.</remarks>
    public partial class DiscoveryStatusForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoveryStatusForm" /> class.
        /// </summary>
        public DiscoveryStatusForm()
        {
            InitializeComponent();

            DiscoveryStatus = MainForm.CurrentSystem.DiscoveryStatus;
            UpdateStatus();
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Gets or sets the DiscoveryStatus property.
        /// </summary>
        /// <value>The current discovery status.</value>
        private Discovery DiscoveryStatus { get; set; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonAdd_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonAdd_Click(object sender, EventArgs args)
        {
            using (var addDeviceSearchForm = new AddDeviceSearchForm())
            {
                if (addDeviceSearchForm.ShowDialog() == DialogResult.OK)
                {
                    var lvItem = new ListViewItem("");
                    lvItem.SubItems.Add(addDeviceSearchForm.DeviceSearchItem.Host);
                    lvItem.SubItems.Add(addDeviceSearchForm.DeviceSearchItem.Port.ToString());
                    lvItem.SubItems.Add(addDeviceSearchForm.DeviceSearchItem.Username);
                    lvItem.SubItems.Add(addDeviceSearchForm.DeviceSearchItem.Password);
                    lvItem.SubItems.Add(addDeviceSearchForm.DeviceSearchItem.DriverType);
                    lvItem.Tag = addDeviceSearchForm.DeviceSearchItem;
                    lvDeviceSearch.Items.Add(lvItem);
                    lvDeviceSearch.Refresh();
                }

            }
        }

        /// <summary>
        /// The ButtonRefresh_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRefresh_Click(object sender, EventArgs args)
        {
            if (DiscoveryStatus == null)
                return;

            UpdateStatus(true);
        }

        /// <summary>
        /// The ButtonRemove_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRemove_Click(object sender, EventArgs args)
        {
            var remItems = lvDeviceSearch.CheckedItems;
            foreach (ListViewItem item in remItems)
                lvDeviceSearch.Items.Remove(item);

            lvDeviceSearch.Refresh();
        }

        /// <summary>
        /// The ButtonTrigger_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonTrigger_Click(object sender, EventArgs args)
        {
            var discoveryRequest = new DiscoveryRequest();
            discoveryRequest.ShouldExtend = chbxExtend.Checked;

            if (rbQuickDiscovery.Checked)
            {
                if (chbxSsdp.Checked)
                    discoveryRequest.Protocols.Add(DiscoveryRequest.DiscoveryProtocol.Ssdp);

                if (chbxWsDiscovery.Checked)
                    discoveryRequest.Protocols.Add(DiscoveryRequest.DiscoveryProtocol.kWsDiscovery);

                if (!string.IsNullOrEmpty(tbxStartingAddress.Text) && !string.IsNullOrEmpty(tbxEndingAddress.Text))
                {
                    discoveryRequest.SearchAt.Add(new DeviceSearch { IpStartAddress = tbxStartingAddress.Text, IpEndAddress = tbxEndingAddress.Text });
                }

            }
            else
            {
                foreach (ListViewItem item in lvDeviceSearch.Items)
                {
                    var deviceSearchItem = (DeviceSearch)item.Tag;
                    if (deviceSearchItem == null)
                        continue;

                    discoveryRequest.SearchAt.Add(deviceSearchItem);
                }
            }

            MainForm.CurrentSystem.DiscoveryStatus.TriggerDiscovery(discoveryRequest);
            UpdateStatus(true);
        }

        /// <summary>
        /// The RadioButton_CheckedChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void RadioButton_CheckedChanged(object sender, EventArgs args)
        {
            gbxQuickDiscovery.Enabled = rbQuickDiscovery.Checked;
            gbxDiscoverByHost.Enabled = rbDiscoverByHost.Checked;
        }

        /// <summary>
        /// The UpdateStatus method.
        /// </summary>
        private void UpdateStatus(bool doRefresh = false)
        {
            lblIsDiscovering.Text = string.Empty;
            lblIsInitializing.Text = string.Empty;
            lblInitiated.Text = string.Empty;
            lblDiscovered.Text = string.Empty;
            lblInitialized.Text = string.Empty;
            lblInitializationErrors.Text = string.Empty;

            if (doRefresh)
                DiscoveryStatus = MainForm.CurrentSystem.DiscoveryStatus;

            lblIsDiscovering.Text = DiscoveryStatus.IsDiscovering.ToString();
            lblIsInitializing.Text = DiscoveryStatus.IsInitializing.ToString();
            lblInitiated.Text = DiscoveryStatus.Initiated.ToLocalTime().ToString("MM-dd-yyyy hh:mm:ss tt");
            lblDiscovered.Text = DiscoveryStatus.Initialized.ToString();
            lblInitialized.Text = DiscoveryStatus.Discovered.ToString();
            lblInitializationErrors.Text = DiscoveryStatus.InitializationErrors.ToString();
        }

        #endregion Private Methods
    }
}