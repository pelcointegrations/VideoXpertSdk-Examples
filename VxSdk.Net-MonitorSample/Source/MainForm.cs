using System;
using System.Windows.Forms;
using MonitorSample.Properties;
using VxSdkNet;

namespace MonitorSample
{
    /// <summary>
    /// The main form used to display the UI.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class. 
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The button1X1 Click event handler.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The event args.</param>
        private async void Button1X1Click(object sender, EventArgs e)
        {
            var monitor = listBoxMonitors.SelectedItem as Monitor;
            if (monitor == null)
            {
                labelMessage.Text = Resources.EnsureMonitorSelected;
                return;
            }

            await VxUtils.ChangeLayout(monitor, VxUtils.VxLayout.Layout1X1);
            UpdateCellsList(1);
        }

        /// <summary>
        /// The button2X2 Click event handler.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The event args.</param>
        private async void Button2X2Click(object sender, EventArgs e)
        {
            var monitor = listBoxMonitors.SelectedItem as Monitor;
            if (monitor == null)
            {
                labelMessage.Text = Resources.EnsureMonitorSelected;
                return;
            }

            await VxUtils.ChangeLayout(monitor, VxUtils.VxLayout.Layout2X2);
            UpdateCellsList(4);
        }

        /// <summary>
        /// The button3X3 Click event handler.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The event args.</param>
        private async void Button3X3Click(object sender, EventArgs e)
        {
            var monitor = listBoxMonitors.SelectedItem as Monitor;
            if (monitor == null)
            {
                labelMessage.Text = Resources.EnsureMonitorSelected;
                return;
            }

            await VxUtils.ChangeLayout(monitor, VxUtils.VxLayout.Layout3X3);
            UpdateCellsList(9);
        }

        /// <summary>
        /// The button4X4 Click event handler.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The event args.</param>
        private async void Button4X4Click(object sender, EventArgs e)
        {
            var monitor = listBoxMonitors.SelectedItem as Monitor;
            if (monitor == null)
            {
                labelMessage.Text = Resources.EnsureMonitorSelected;
                return;
            }

            await VxUtils.ChangeLayout(monitor, VxUtils.VxLayout.Layout4X4);
            UpdateCellsList(16);
        }

        /// <summary>
        /// The buttonLogin Click event handler.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The event args.</param>
        private async void ButtonLoginClick(object sender, EventArgs e)
        {
            labelMessage.Text = string.Empty;

            var ip = textBoxIp.Text;
            var user = textBoxUsername.Text;
            var passwd = textBoxPassword.Text;

            var retVal = await VxUtils.Init(ip, user, passwd);
            if (retVal == Results.Value.SdkLicenseGracePeriodActive)
            {
                var message = string.Format(Resources.LicenseWarningMessage, VxUtils.ExpirationDate.ToString(Resources.DateTimeFormat));
                MessageBox.Show(message, Resources.LicenseWarningHeader, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (retVal != Results.Value.OK)
            {
                if (retVal == Results.Value.SdkLicenseGracePeriodExpired)
                    labelMessage.Text = Resources.LicenseLoginErrorMessage;
                else
                    labelMessage.Text = Resources.LoginErrorMessage + retVal;

                return;
            }

            await VxUtils.GetMonitors();
            await VxUtils.GetCameras();
            this.ListBoxMonitorsSelectedIndexChanged(this, null);
        }

        /// <summary>
        /// The buttonShowVideo Click event handler.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The event args.</param>
        private async void ButtonShowVideoClick(object sender, EventArgs e)
        {
            var monitor = listBoxMonitors.SelectedItem as Monitor;
            var cellIdx = listBoxCells.SelectedIndex;
            var camera = listBoxCameras.SelectedItem as DataSource;
            var time = checkBoxLive.Checked ? default(DateTime) : dateTimePickerRecorded.Value;

            if (monitor == null || cellIdx == -1 || camera == null)
            {
                labelMessage.Text = Resources.EnsureCellAndCameraAreSelected;
                return;
            }

            labelMessage.Text = string.Empty;
            await VxUtils.PlayVideoInCell(monitor, cellIdx, camera, time);
        }

        /// <summary>
        /// The checkBoxLive CheckedChanged event handler.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The event args.</param>
        private void CheckBoxLiveCheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerRecorded.Enabled = !checkBoxLive.Checked;
        }

        /// <summary>
        /// The listBoxMonitors SelectedIndexChanged event handler.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The event args.</param>
        private void ListBoxMonitorsSelectedIndexChanged(object sender, EventArgs e)
        {
            var monitor = listBoxMonitors.SelectedItem as Monitor;
            if (monitor == null)
                return;

            UpdateCellsList(monitor.MonitorCells.Count);
        }

        /// <summary>
        /// The MainForm Load event handler.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">The event args.</param>
        private void MainFormLoad(object sender, EventArgs e)
        {
            listBoxMonitors.DataSource = VxUtils.Monitors;
            listBoxMonitors.DisplayMember = Resources.DisplayValue;
            listBoxCameras.DataSource = VxUtils.Cameras;
            listBoxCameras.DisplayMember = Resources.DisplayValue;

            if (VxUtils.LicenseKey == Resources.DefaultLicenseKey)
                MessageBox.Show(this, Resources.DefaultLicenseMessage, Resources.DefaultLicenseHeader, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// Updates the selectable cells in listBoxCells.
        /// </summary>
        /// <param name="count">The amount of selectable cells to display.</param>
        private void UpdateCellsList(int count)
        {
            listBoxCells.Items.Clear();
            for (var i = 0; i < count; i++)
                listBoxCells.Items.Add("__ " + (i + 1) + " __");

            if (listBoxCells.Items.Count > 0)
                listBoxCells.SelectedIndex = 0;
        }
    }
}
