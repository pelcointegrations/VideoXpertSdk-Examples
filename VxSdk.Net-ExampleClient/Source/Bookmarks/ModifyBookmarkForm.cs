using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The ModifyBookmarkForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to modify a bookmark.</remarks>
    public partial class ModifyBookmarkForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyBookmarkForm" /> class.
        /// </summary>
        /// <param name="bookmark">The <paramref name="bookmark"/> parameter.</param>
        public ModifyBookmarkForm(Bookmark bookmark)
        {
            InitializeComponent();
            SelectedBookmark = bookmark;

            tbxDescription.Text = SelectedBookmark.Description;
            tbxName.Text = SelectedBookmark.Name;
            chbxLockEnabled.Checked = SelectedBookmark.Lock.IsEnabled;
            dtpLockStartTime.Value = SelectedBookmark.Lock.StartTime.ToLocalTime();
            dtpLockEndTime.Value = SelectedBookmark.Lock.EndTime.ToLocalTime();
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Gets or sets the SelectedBookmark property.
        /// </summary>
        /// <value>The currently selected bookmark.</value>
        private Bookmark SelectedBookmark { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonSave_Click method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            try
            {
                if (SelectedBookmark.Name != tbxName.Text)
                    SelectedBookmark.Name = tbxName.Text;

                if (SelectedBookmark.Description != tbxDescription.Text)
                    SelectedBookmark.Description = tbxDescription.Text;

                if (SelectedBookmark.Lock.IsEnabled != chbxLockEnabled.Checked)
                    SelectedBookmark.Lock.IsEnabled = chbxLockEnabled.Checked;

                if (!chbxLockEnabled.Checked)
                    return;

                if (SelectedBookmark.Lock.StartTime != dtpLockStartTime.Value.ToUniversalTime())
                    SelectedBookmark.Lock.StartTime = dtpLockStartTime.Value.ToUniversalTime();

                if (SelectedBookmark.Lock.EndTime != dtpLockEndTime.Value.ToUniversalTime())
                    SelectedBookmark.Lock.EndTime = dtpLockEndTime.Value.ToUniversalTime();
            }
            catch (Exception ex)
            {
                MainForm.Instance.WriteToLog($"Error modifying bookmark: {ex.Message}");
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

        #endregion Private Methods
    }
}