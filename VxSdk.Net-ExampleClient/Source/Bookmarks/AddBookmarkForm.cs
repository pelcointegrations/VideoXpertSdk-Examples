using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The AddBookmarkForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to select the settings
    /// that will be used to create a new bookmark.</remarks>
    public partial class AddBookmarkForm : Form
    {
        #region Private Fields

        /// <summary>
        /// The _lastItemChecked field.
        /// </summary>
        /// <remarks>Holds the last item checked in the BookmarkManager list view.</remarks>
        private ListViewItem _lastItemChecked;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AddBookmarkForm" /> class.
        /// </summary>
        public AddBookmarkForm()
        {
            InitializeComponent();

            dtpLockStartTime.Value = dtpTime.Value.AddSeconds(-30);
            dtpLockEndTime.Value = dtpTime.Value.AddSeconds(30);
            foreach (DataGridViewRow row in MainForm.Instance.dgvDataSources.Rows)
            {
                var ds = (DataSource)row.Tag;
                var lvItem = new ListViewItem(string.Empty);
                lvItem.SubItems.Add(ds.Number.ToString());
                lvItem.SubItems.Add(ds.Name);
                lvItem.Tag = ds;
                lvDataSources.Items.Add(lvItem);
            }
        }

        #endregion Public Constructors

        #region Private Methods

        /// <summary>
        /// The ButtonAdd_Click method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ButtonAdd_Click(object sender, EventArgs args)
        {
            if (lvDataSources.CheckedItems.Count == 0)
                return;

            var dataSource = (DataSource)lvDataSources.CheckedItems[0].Tag;
            var newBookmark = new NewBookmark
            {
                Description = tbxDescription.Text,
                Name = tbxName.Text,
                Time = dtpTime.Value.ToUniversalTime(),
                DataSourceId = dataSource.Id
            };

            if (chbxLockEnabled.Checked)
            {
                newBookmark.IsLocked = true;
                newBookmark.LockStartTime = dtpLockStartTime.Value.ToUniversalTime();
                newBookmark.LockEndTime = dtpLockEndTime.Value.ToUniversalTime();
            }

            try
            {
                MainForm.CurrentSystem.AddBookmark(newBookmark);
            }
            catch (Exception ex)
            {
                MainForm.Instance.WriteToLog($"Error creating bookmark: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// The CheckboxLockEnabled_CheckedChanged method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void CheckboxLockEnabled_CheckedChanged(object sender, EventArgs args)
        {
            gbxLockStartTime.Enabled = chbxLockEnabled.Checked;
            gbxLockEndTime.Enabled = chbxLockEnabled.Checked;
        }

        /// <summary>
        /// The DateTimePickerLockTime_ValueChanged method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void DateTimePickerLockTime_ValueChanged(object sender, EventArgs args)
        {
            if (dtpLockEndTime.Value <= dtpLockStartTime.Value)
            {
                dtpLockEndTime.Value = dtpLockStartTime.Value.AddSeconds(1);
            }
        }

        /// <summary>
        /// The ListViewDataSources_ItemCheck method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ListViewDataSources_ItemCheck(object sender, ItemCheckEventArgs args)
        {
            // If we have the lastItem set as checked, and it is different
            // item than the one that fired the event, uncheck it.
            if (_lastItemChecked != null && _lastItemChecked.Checked
                                         && _lastItemChecked != lvDataSources.Items[args.Index])
            {
                // Uncheck the last item and store the new one.
                _lastItemChecked.Checked = false;
            }

            // Store the current item.
            _lastItemChecked = lvDataSources.Items[args.Index];
        }

        #endregion Private Methods
    }
}