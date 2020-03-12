﻿using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The BookmarkManagerForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to view, create and delete
    /// bookmarks from the VideoXpert system.</remarks>
    public partial class BookmarkManagerForm : Form
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
        /// Initializes a new instance of the <see cref="BookmarkManagerForm" /> class.
        /// </summary>
        public BookmarkManagerForm()
        {
            InitializeComponent();

            PopulateBookmarks();
        }

        #endregion Public Constructors

        #region Private Methods

        /// <summary>
        /// The ButtonConfigureBookmarks_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonConfigureBookmarks_Click(object sender, EventArgs args)
        {
            if (MainForm.CurrentSystem.BookmarkConfig == null)
                return;

            // Show the BookmarkConfigForm dialog.
            using (var bookmarkConfigForm = new BookmarkConfigForm())
            {
                bookmarkConfigForm.ShowDialog();
            }
        }

        /// <summary>
        /// The ButtonDelete_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonDelete_Click(object sender, EventArgs args)
        {
            if (lvBookmarkManager.CheckedItems.Count == 0)
                return;

            // Get the associated bookmark object from the selected item and delete
            // it from the VideoXpert system.
            var bookmark = (Bookmark)lvBookmarkManager.CheckedItems[0].Tag;
            MainForm.CurrentSystem.DeleteBookmark(bookmark);
            lvBookmarkManager.CheckedItems[0].Remove();
        }

        /// <summary>
        /// The ButtonModify_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonModify_Click(object sender, EventArgs args)
        {
            if (lvBookmarkManager.CheckedItems.Count == 0)
                return;

            var bookmark = (Bookmark)lvBookmarkManager.CheckedItems[0].Tag;
            // Show the ModifyBookmarkForm dialog.
            DialogResult result;
            using (var modifyBookmarkForm = new ModifyBookmarkForm(bookmark))
            {
                result = modifyBookmarkForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result != DialogResult.OK)
                return;

            // Refresh the items in the list view to include the newly modified bookmark.
            lvBookmarkManager.Items.Clear();
            PopulateBookmarks();
            lvBookmarkManager.Refresh();
        }

        /// <summary>
        /// The ButtonNewBookmark_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonNewBookmark_Click(object sender, EventArgs args)
        {
            // Show the AddBookmarkForm dialog.
            DialogResult result;
            using (var bookmarkForm = new AddBookmarkForm())
            {
                result = bookmarkForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result != DialogResult.OK)
                return;

            // Refresh the items in the list view to include the newly added bookmark.
            lvBookmarkManager.Items.Clear();
            PopulateBookmarks();
            lvBookmarkManager.Refresh();
        }

        /// <summary>
        /// The ButtonRefresh_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRefresh_Click(object sender, EventArgs args)
        {
            // Refresh the items in the list view to include the newly added bookmark.
            lvBookmarkManager.Items.Clear();
            PopulateBookmarks();
            lvBookmarkManager.Refresh();
        }

        /// <summary>
        /// The ListViewBookmarkManager_ItemCheck method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ListViewBookmarkManager_ItemCheck(object sender, ItemCheckEventArgs args)
        {
            // If we have the lastItem set as checked, and it is different
            // item than the one that fired the event, uncheck it.
            if (_lastItemChecked != null && _lastItemChecked.Checked
                && _lastItemChecked != lvBookmarkManager.Items[args.Index])
            {
                // Uncheck the last item and store the new one.
                _lastItemChecked.Checked = false;
            }

            // Store the current item.
            _lastItemChecked = lvBookmarkManager.Items[args.Index];
        }

        /// <summary>
        /// The ListViewBookmarkManager_SelectedIndexChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ListViewBookmarkManager_SelectedIndexChanged(object sender, EventArgs args)
        {
            if (lvBookmarkManager.SelectedItems.Count == 0)
                return;

            lvBookmarkManager.SelectedItems[0].Checked = true;
        }

        /// <summary>
        /// The PopulateBookmarks method.
        /// </summary>
        private void PopulateBookmarks()
        {
            // Get the existing bookmarks from the VideoXpert system and add
            // them to the list view.
            foreach (var bookmark in MainForm.CurrentSystem.Bookmarks)
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