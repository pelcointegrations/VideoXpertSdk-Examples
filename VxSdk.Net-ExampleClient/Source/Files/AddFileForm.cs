using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The AddFileForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to add a new file.</remarks>
    public partial class AddFileForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AddFileForm" /> class.
        /// </summary>
        public AddFileForm()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Private Methods

        /// <summary>
        /// The ButtonAdd_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonAdd_Click(object sender, EventArgs args)
        {
            try
            {
                if (string.IsNullOrEmpty(tbxFilePath.Text) || string.IsNullOrEmpty(tbxFilename.Text))
                    return;

                MainForm.CurrentSystem.AddFile(tbxFilePath.Text, tbxFilename.Text);
            }
            catch (Exception ex)
            {
                MainForm.Instance.WriteToLog($"Error adding file: {ex.Message}");
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// The ButtonBrowse_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonBrowse_Click(object sender, EventArgs args)
        {
            var ofdSelectFile = new OpenFileDialog();

            if (ofdSelectFile.ShowDialog() != DialogResult.OK)
                return;

            tbxFilePath.Text = ofdSelectFile.FileName;
        }

        #endregion Private Methods
    }
}