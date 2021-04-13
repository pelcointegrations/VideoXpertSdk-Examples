using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TimeZoneConverter;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The TimeConfigurationForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to modify the time configuration.</remarks>
    public partial class TimeConfigurationForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeConfigurationForm" /> class.
        /// </summary>
        public TimeConfigurationForm(Configuration.Time timeConfig)
        {
            InitializeComponent();
            TimeConfig = timeConfig;

            if (TimeConfig.TimeServerSourceType == Configuration.TimeServerSource.Auto)
                rbAuto.Checked = true;
            else if(TimeConfig.TimeServerSourceType == Configuration.TimeServerSource.Manual)
                rbManual.Checked = true;
            else
                rbNone.Checked = true;

            var timeZone = TimeZoneInfo.Utc;
            if (!string.IsNullOrEmpty(TimeConfig.TimeZone))
                timeZone = TZConvert.GetTimeZoneInfo(TimeConfig.TimeZone);

            var timeZones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var zone in timeZones)
            {
                var cbxItem = new ComboboxItem { Text = zone.DisplayName, Value = zone};
                cbxTimeZone.Items.Add(cbxItem);
                if (timeZone.Id == zone.Id)
                    cbxTimeZone.SelectedItem = cbxItem;
            }

            if (cbxTimeZone.SelectedItem == null)
                cbxTimeZone.SelectedIndex = 0;

            foreach (var host in TimeConfig.ExternalTimeServers)
                lvExternalTimeServers.Items.Add(new ListViewItem(host));
        }

        #endregion

        #region Private Properties

        /// <summary>
        /// Gets or sets the ExternalTimeServersChanged property.
        /// </summary>
        /// <value><c>true</c> if the external time server list has changed, otherwise <c>false</c>.</value>
        private bool ExternalTimeServersChanged { get; set; }

        /// <summary>
        /// Gets or sets the TimeConfig property.
        /// </summary>
        /// <value>The current time configuration.</value>
        private Configuration.Time TimeConfig { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonAdd_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonAdd_Click(object sender, EventArgs args)
        {
            var hostAddress = string.Empty;
            var usernameResult = InputBox.Show("Add External Time Server", "Please enter the host address: ", ref hostAddress);
            if (usernameResult != DialogResult.OK || string.IsNullOrEmpty(hostAddress))
                return;

            ExternalTimeServersChanged = true;
            var lvItem = new ListViewItem(hostAddress);
            lvExternalTimeServers.Items.Add(lvItem);
            lvExternalTimeServers.Refresh();
        }

        /// <summary>
        /// The ButtonDelete_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonDelete_Click(object sender, EventArgs args)
        {
            if (lvExternalTimeServers.SelectedItems.Count == 0)
                return;

            ExternalTimeServersChanged = true;
            lvExternalTimeServers.Items.Remove(lvExternalTimeServers.SelectedItems[0]);
        }

        /// <summary>
        /// The ButtonEdit_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonEdit_Click(object sender, EventArgs args)
        {
            if (lvExternalTimeServers.SelectedItems.Count == 0)
                return;

            var hostAddress = lvExternalTimeServers.SelectedItems[0].Text;
            var usernameResult = InputBox.Show("Edit External Time Server", "Please enter the host address: ", ref hostAddress);
            if (usernameResult != DialogResult.OK || string.IsNullOrEmpty(hostAddress))
                return;

            ExternalTimeServersChanged = true;
            lvExternalTimeServers.SelectedItems[0].Text = hostAddress;
            lvExternalTimeServers.Refresh();
        }

        /// <summary>
        /// The ButtonSave_Click method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            if (rbAuto.Checked && TimeConfig.TimeServerSourceType != Configuration.TimeServerSource.Auto)
                TimeConfig.TimeServerSourceType = Configuration.TimeServerSource.Auto;
            else if (rbManual.Checked && TimeConfig.TimeServerSourceType != Configuration.TimeServerSource.Manual)
                TimeConfig.TimeServerSourceType = Configuration.TimeServerSource.Manual;
            else if(rbNone.Checked && TimeConfig.TimeServerSourceType != Configuration.TimeServerSource.None)
                TimeConfig.TimeServerSourceType = Configuration.TimeServerSource.None;

            if (ExternalTimeServersChanged)
            {
                var hosts = new List<string>();
                foreach (ListViewItem item in lvExternalTimeServers.Items)
                    hosts.Add(item.Text);

                TimeConfig.ExternalTimeServers = hosts;
            }

            var selectedZone = cbxTimeZone.SelectedItem as ComboboxItem;
            var zoneInfo = (TimeZoneInfo)selectedZone?.Value;
            if (zoneInfo == null)
                return;

            if (zoneInfo.Id != (TZConvert.GetTimeZoneInfo(TimeConfig.TimeZone)).Id)
                TimeConfig.TimeZone = TZConvert.WindowsToIana(zoneInfo.Id);

        }

        /// <summary>
        /// The RadioButtonSourceType_CheckedChanged method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void RadioButtonSourceType_CheckedChanged(object sender, EventArgs args)
        {
            gbxExternalTimeServers.Enabled = !rbNone.Checked;
            gbxTimeZone.Enabled = !rbNone.Checked;
        }

        #endregion
    }
}
