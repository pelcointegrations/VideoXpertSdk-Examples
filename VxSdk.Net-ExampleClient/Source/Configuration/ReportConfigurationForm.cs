using System;
using System.IO;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The ReportConfigurationForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to modify the report configuration.</remarks>
    public partial class ReportConfigurationForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportConfigurationForm" /> class.
        /// </summary>
        public ReportConfigurationForm()
        {
            InitializeComponent();
            ReportConfig = MainForm.CurrentSystem.ReportConfig;

            nudMaxAge.Value = ReportConfig.MaxAge;
            tbxPath.Text = ReportConfig.StorageLocation.Path;
            tbxUsername.Text = ReportConfig.StorageLocation.Username;
            tbxPassword.Text = ReportConfig.StorageLocation.Password;
        }

        #endregion

        #region Private Properties

        /// <summary>
        /// Gets or sets the ReportConfig property.
        /// </summary>
        /// <value>The current report configuration.</value>
        private Configuration.Report ReportConfig { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonBrowse_Click method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ButtonBrowse_Click(object sender, EventArgs args)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) + "\\";
            if (!string.IsNullOrEmpty(tbxPath.Text))
            {
                var tempPath = Path.GetDirectoryName(tbxPath.Text);
                if (!string.IsNullOrEmpty(tempPath))
                    path = tempPath;
            }

            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.SelectedPath = path;
                folderDialog.Description = @"Choose Storage Location Path...";

                var result = folderDialog.ShowDialog();
                if (result != DialogResult.OK)
                    return;

                tbxPath.Text = folderDialog.SelectedPath;
            }
        }

        /// <summary>
        /// The ButtonSave_Click method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            if (nudMaxAge.Value != ReportConfig.MaxAge)
                ReportConfig.MaxAge = (int)nudMaxAge.Value;

            if (tbxPath.Text != ReportConfig.StorageLocation.Path || tbxUsername.Text != ReportConfig.StorageLocation.Username || tbxPassword.Text != ReportConfig.StorageLocation.Password)
            {
                var newInfo = new NetworkStorageInfo
                {
                    Path = tbxPath.Text,
                    Username = tbxUsername.Text,
                    Password = tbxPassword.Text
                };

                ReportConfig.StorageLocation = newInfo;
            }
        }

        #endregion
    }
}
