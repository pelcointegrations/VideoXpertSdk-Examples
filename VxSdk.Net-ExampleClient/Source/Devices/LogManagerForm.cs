using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The LogManagerForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to view, create and delete
    /// logs from a device.</remarks>
    public partial class LogManagerForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LogManagerForm" /> class.
        /// </summary>
        /// <param name="device">The <paramref name="device"/> parameter.</param>
        public LogManagerForm(Device device)
        {
            InitializeComponent();
            SelectedDevice = device;
            PopulateLogs();
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
        /// The ButtonAdd_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonAdd_Click(object sender, EventArgs args)
        {
            SelectedDevice.CreateLog();

            // Refresh the items in the list view to include the newly added log.
            PopulateLogs();
        }

        /// <summary>
        /// The ButtonDelete_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonDelete_Click(object sender, EventArgs args)
        {
            if (lvLogs.SelectedItems.Count == 0)
                return;

            // Get the associated log object from the selected item and delete
            // it from the device.
            var log = (Log)lvLogs.SelectedItems[0].Tag;
            SelectedDevice.DeleteLog(log);
            PopulateLogs();
        }

        /// <summary>
        /// The ButtonDownload_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonDownload_Click(object sender, EventArgs args)
        {
            if (lvLogs.SelectedItems.Count == 0)
                return;

            var log = (Log)lvLogs.SelectedItems[0].Tag;
            var endpoint = log.LogEndpoint;

            // Open a save file dialog for the user to select a filename for the
            // log download.
            saveFileDialog.FileName = "Log-" + log.Id + ".zip";
            var result = saveFileDialog.ShowDialog();
            saveFileDialog.Dispose();

            if (result != DialogResult.OK)
                return;

            using (var downloadForm = new DownloadProgressForm(new Uri(endpoint), saveFileDialog.FileName, 0))
            {
                downloadForm.StartDownload();
                downloadForm.ShowDialog();
            }
        }

        /// <summary>
        /// The ButtonRefresh_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRefresh_Click(object sender, EventArgs args)
        {
            PopulateLogs();
        }

        /// <summary>
        /// The PopulateLogs method.
        /// </summary>
        private void PopulateLogs()
        {
            lvLogs.Items.Clear();

            // Get the existing logs from the device and add
            // them to the list view.
            var logs = SelectedDevice.Logs;
            foreach (var log in logs)
            {
                var lvItem = new ListViewItem(log.Id);
                lvItem.SubItems.Add(log.Initiated.ToString("U"));
                lvItem.SubItems.Add(log.Completed.ToString("U"));
                lvItem.Tag = log;
                lvLogs.Items.Add(lvItem);
            }
        }

        #endregion Private Methods
    }
}