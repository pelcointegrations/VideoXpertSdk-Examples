using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The DatabaseBackupManagerForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to view and manage database backups.</remarks>
    public partial class DatabaseBackupManagerForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseBackupManagerForm" /> class.
        /// </summary>
        /// <param name="device">The <paramref name="device"/> parameter.</param>
        public DatabaseBackupManagerForm(Device device)
        {
            InitializeComponent();
            SelectedDevice = device;
            PopulateDatabaseBackupsSettings();
            PopulateDatabaseBackups();
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Gets or sets the SelectedDbBackups property.
        /// </summary>
        /// <value>The currently selected DbBackups object.</value>
        private Device SelectedDevice { get; }

        /// <summary>
        /// Gets or sets the SelectedDbBackups property.
        /// </summary>
        /// <value>The currently selected DbBackups object.</value>
        private string LastPassword { get; set; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonTrigger_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonTrigger_Click(object sender, EventArgs args)
        {
            SelectedDevice?.DatabaseBackups?.TriggerBackup();

            // Refresh the items in the list view to include the newly added backup.
            PopulateDatabaseBackups();
        }

        /// <summary>
        /// The ButtonDelete_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonDelete_Click(object sender, EventArgs args)
        {
            if (lvDatabaseBackups.SelectedItems.Count == 0)
                return;

            // Get the associated backup object from the selected item and delete it.
            var backup = (DbBackup)lvDatabaseBackups.SelectedItems[0].Tag;
            SelectedDevice?.DatabaseBackups?.DeleteDatabaseBackup(backup);
            PopulateDatabaseBackups();
        }

        /// <summary>
        /// The ButtonHalt_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonHalt_Click(object sender, EventArgs args)
        {
            if (lvDatabaseBackups.SelectedItems.Count == 0)
                return;

            var backup = (DbBackup)lvDatabaseBackups.SelectedItems[0].Tag;
            backup?.Halt();
            PopulateDatabaseBackups();
        }

        /// <summary>
        /// The ButtonRefresh_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRefresh_Click(object sender, EventArgs args)
        {
            PopulateDatabaseBackups();
        }

        /// <summary>
        /// The ButtonRestore_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRestore_Click(object sender, EventArgs args)
        {
            if (lvDatabaseBackups.SelectedItems.Count == 0)
                return;

            var backup = (DbBackup)lvDatabaseBackups.SelectedItems[0].Tag;
            backup?.Restore();
            PopulateDatabaseBackups();
        }

        /// <summary>
        /// The ButtonSaveAll_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonSaveAll_Click(object sender, EventArgs args)
        {
            var dbBackups = SelectedDevice?.DatabaseBackups;
            if (dbBackups == null)
                return;

            if (tbxBackupPath.Text != dbBackups.BackupPath)
                dbBackups.BackupPath = tbxBackupPath.Text;

            if (tbxUsername.Text != dbBackups.BackupPathUsername)
                dbBackups.BackupPathUsername = tbxUsername.Text;

            if (tbxPassword.Text != LastPassword)
                dbBackups.BackupPathPassword = LastPassword = tbxPassword.Text;

            if ((int)nudBackupInterval.Value != dbBackups.BackupInterval)
                dbBackups.BackupInterval = (int)nudBackupInterval.Value;

            if ((int)nudMaxBackups.Value != dbBackups.MaxBackupsToKeep)
                dbBackups.MaxBackupsToKeep = (int)nudMaxBackups.Value;

            if (dtpBackupTime.Value.ToString("T") != dbBackups.BackupTime.ToString("T"))
                dbBackups.BackupTime = dtpBackupTime.Value;

            PopulateDatabaseBackupsSettings();
        }

        /// <summary>
        /// The ButtonValidate_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonValidate_Click(object sender, EventArgs args)
        {
            var isValid = SelectedDevice?.DatabaseBackups?.ValidateBackupPath(tbxBackupPath.Text, tbxUsername.Text, tbxPassword.Text) ?? false;
            MessageBox.Show($@"Backup path validation returned: {(isValid ? "Valid" : "Not Valid")}", @"Validation Result");
        }

        /// <summary>
        /// The PopulateDatabaseBackups method.
        /// </summary>
        private void PopulateDatabaseBackups()
        {
            lvDatabaseBackups.Items.Clear();

            // Get the existing backups and add them to the list view.
            var backups = SelectedDevice?.DatabaseBackups?.DatabaseBackups;
            if (backups == null)
                return;

            foreach (var backup in backups)
            {
                var lvItem = new ListViewItem(backup.Id);
                lvItem.SubItems.Add(backup.Initiated.ToString("U"));
                lvItem.SubItems.Add(backup.Completed.ToString("U"));
                lvItem.SubItems.Add(backup.Status.ToString());
                lvItem.SubItems.Add(backup.StatusReason.ToString());
                lvItem.Tag = backup;
                lvDatabaseBackups.Items.Add(lvItem);
            }
        }

        /// <summary>
        /// The PopulateDatabaseBackupsSettings method.
        /// </summary>
        private void PopulateDatabaseBackupsSettings()
        {
            var dbBackups = SelectedDevice?.DatabaseBackups;
            if (dbBackups == null)
                return;

            tbxBackupPath.Text = dbBackups.BackupPath;
            tbxUsername.Text = dbBackups.BackupPathUsername;
            nudBackupInterval.Value = dbBackups.BackupInterval;
            nudMaxBackups.Value = dbBackups.MaxBackupsToKeep;
            dtpBackupTime.Value = dbBackups.BackupTime;
        }

        #endregion Private Methods

    }
}