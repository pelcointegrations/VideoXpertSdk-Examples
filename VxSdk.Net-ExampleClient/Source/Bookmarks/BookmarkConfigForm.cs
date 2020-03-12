using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The BookmarkConfigForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to modify the bookmark configuration.</remarks>
    public partial class BookmarkConfigForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyBookmarkForm" /> class.
        /// </summary>
        public BookmarkConfigForm()
        {
            InitializeComponent();
            BookmarkConfig = MainForm.CurrentSystem.BookmarkConfig;


            nudAutoUnlock.Value = BookmarkConfig.AutoUnlock;
            nudRetentionLimit.Value = BookmarkConfig.RetentionLimit;
            if (BookmarkConfig.RetentionPolicy != Configuration.BookmarkRetentionPolicy.Unknown)
            {
                cbxRetentionPolicy.SelectedIndex = (int) BookmarkConfig.RetentionPolicy - 1;
            }
            else
            {
                cbxRetentionPolicy.SelectedIndex = 0;
            }
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Gets or sets the SelectedBookmark property.
        /// </summary>
        /// <value>The currently selected bookmark.</value>
        private Configuration.Bookmark BookmarkConfig { get; }

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
                if (BookmarkConfig.AutoUnlock != nudAutoUnlock.Value)
                    BookmarkConfig.AutoUnlock = (int)nudAutoUnlock.Value;

                if (BookmarkConfig.RetentionLimit != nudRetentionLimit.Value)
                    BookmarkConfig.RetentionLimit = (int)nudRetentionLimit.Value;

                if (BookmarkConfig.RetentionPolicy != (Configuration.BookmarkRetentionPolicy)cbxRetentionPolicy.SelectedIndex + 1)
                    BookmarkConfig.RetentionPolicy = (Configuration.BookmarkRetentionPolicy)cbxRetentionPolicy.SelectedIndex + 1;
            }
            catch (Exception ex)
            {
                MainForm.Instance.WriteToLog($"Error modifying bookmark config: {ex.Message}");
            }
        }

        #endregion Private Methods
    }
}