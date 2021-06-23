using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The FileSelectionForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to update a device.</remarks>
    public partial class FileSelectionForm : Form
    {
        #region Private Fields

        /// <summary>
        /// Gets the SelectedDevice property.
        /// </summary>
        /// <value>The currently selected device.</value>
        private Device SelectedDevice { get; }

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSelectionForm" /> class.
        /// </summary>
        public FileSelectionForm(Device device)
        {
            InitializeComponent();
            SelectedDevice = device;

            PopulateFiles();
        }

        #endregion Public Constructors

        #region Private Methods

        /// <summary>
        /// The ButtonUpdate_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonUpdate_Click(object sender, EventArgs args)
        {
            if (lvFileManager.SelectedItems.Count == 0)
                return;

            var file = (VxFile)lvFileManager.SelectedItems[0].Tag;
            SelectedDevice.UpdateSoftware(file);
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
                var lvItem = new ListViewItem(file.Id);
                lvItem.SubItems.Add(file.Filename);
                lvItem.Tag = file;
                lvFileManager.Items.Add(lvItem);
            }
        }

        #endregion Private Methods

    }
}