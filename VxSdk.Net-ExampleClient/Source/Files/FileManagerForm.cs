using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The FileManagerForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to view, create and delete
    /// files from the VideoXpert system.</remarks>
    public partial class FileManagerForm : Form
    {
        #region Private Fields

        /// <summary>
        /// The _lastItemChecked field.
        /// </summary>
        /// <remarks>Holds the last item checked in the FileManager list view.</remarks>
        private ListViewItem _lastItemChecked;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FileManagerForm" /> class.
        /// </summary>
        public FileManagerForm()
        {
            InitializeComponent();

            PopulateFiles();
        }

        #endregion Public Constructors

        #region Private Methods

        /// <summary>
        /// The ButtonAddFile_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonAddFile_Click(object sender, EventArgs args)
        {
            // Show the AddFileForm dialog.
            DialogResult result;
            using (var addFileForm = new AddFileForm())
            {
                result = addFileForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result != DialogResult.OK)
                return;

            // Refresh the items in the list view to include the newly added file.
            lvFileManager.Items.Clear();
            PopulateFiles();
            lvFileManager.Refresh();
        }

        /// <summary>
        /// The ButtonDelete_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonDelete_Click(object sender, EventArgs args)
        {
            if (lvFileManager.CheckedItems.Count == 0)
                return;

            // Get the associated File object from the selected item and delete
            // it from the VideoXpert system.
            var file = (VxFile)lvFileManager.CheckedItems[0].Tag;
            MainForm.CurrentSystem.DeleteFile(file);
            lvFileManager.CheckedItems[0].Remove();
        }

        /// <summary>
        /// The ButtonDownload_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonDownload_Click(object sender, EventArgs args)
        {
            if (lvFileManager.CheckedItems.Count == 0)
                return;

            // Get the associated File object from the selected item.
            var file = (VxFile)lvFileManager.CheckedItems[0].Tag;

            // Open a save file dialog for the user to select a filename for the
            // file download.
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = file.Filename;
            var result = saveFileDialog.ShowDialog();
            saveFileDialog.Dispose();

            if (result != DialogResult.OK)
                return;

            using (var downloadForm = new DownloadProgressForm(new Uri(file.FileEndpoint), saveFileDialog.FileName, 0))
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
            // Refresh the items in the list view.
            lvFileManager.Items.Clear();
            PopulateFiles();
            lvFileManager.Refresh();
        }

        /// <summary>
        /// The ListViewFileManager_ItemCheck method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ListViewFileManager_ItemCheck(object sender, ItemCheckEventArgs args)
        {
            // If we have the lastItem set as checked, and it is different
            // item than the one that fired the event, uncheck it.
            if (_lastItemChecked != null && _lastItemChecked.Checked
                && _lastItemChecked != lvFileManager.Items[args.Index])
            {
                // Uncheck the last item and store the new one.
                _lastItemChecked.Checked = false;
            }

            // Store the current item.
            _lastItemChecked = lvFileManager.Items[args.Index];
        }

        /// <summary>
        /// The PopulateFiles method.
        /// </summary>
        private void PopulateFiles()
        {
            // Get the existing files from the VideoXpert system and add
            // them to the list view.
            foreach (var file in MainForm.CurrentSystem.Files)
            {
                var lvItem = new ListViewItem(string.Empty);
                lvItem.SubItems.Add(file.Id);
                lvItem.SubItems.Add(file.Filename);
                lvItem.Tag = file;
                lvFileManager.Items.Add(lvItem);
            }
        }

        #endregion Private Methods

    }
}