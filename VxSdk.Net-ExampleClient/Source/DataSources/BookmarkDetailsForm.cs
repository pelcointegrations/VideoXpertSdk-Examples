using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The BookmarkDetailsForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that contains the info for any bookmarks found on the selected data source.</remarks>
    public partial class BookmarkDetailsForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BookmarkDetailsForm" /> class.
        /// </summary>
        /// <param name="dataSource">The <paramref name="dataSource"/> parameter.</param>
        public BookmarkDetailsForm(DataSource dataSource)
        {
            InitializeComponent();
            SelectedDataSource = dataSource;
            PopulateBookmarks();
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Gets or sets the SelectedDataSource property.
        /// </summary>
        /// <value>The currently selected dataSource.</value>
        private DataSource SelectedDataSource { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonRefresh_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRefresh_Click(object sender, System.EventArgs args)
        {
            PopulateBookmarks();
        }

        /// <summary>
        /// The PopulateBookmarks method.
        /// </summary>
        private void PopulateBookmarks()
        {
            // Get the existing bookmarks from the VideoXpert system and add
            // them to the list view.
            var bookmarks = SelectedDataSource.Bookmarks;
            foreach (var bookmark in bookmarks)
            {
                var bookmarkLock = bookmark.Lock;
                var lvItem = new ListViewItem(string.Empty);
                lvItem.SubItems.Add(bookmark.Id);
                lvItem.SubItems.Add(bookmark.Time.ToLocalTime().ToString("s"));
                lvItem.SubItems.Add(bookmark.Name);
                lvItem.SubItems.Add(bookmark.Description);
                lvItem.SubItems.Add(bookmarkLock.IsEnabled ? "Enabled" : "Disabled");
                lvItem.SubItems.Add(bookmarkLock.StartTime.ToLocalTime().ToString("s"));
                lvItem.SubItems.Add(bookmarkLock.EndTime.ToLocalTime().ToString("s"));
                lvItem.Tag = bookmark;
                lvBookmarkManager.Items.Add(lvItem);
            }
        }

        #endregion Private Methods
    }
}