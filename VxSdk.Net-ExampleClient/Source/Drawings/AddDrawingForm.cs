using System;
using System.Windows.Forms;

namespace ExampleClient.Source
{
    /// <summary>
    /// The AddDrawingForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to select the settings
    /// that will be used to create a new Drawing.</remarks>
    public partial class AddDrawingForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AddDrawingForm" /> class.
        /// </summary>
        public AddDrawingForm()
        {
            InitializeComponent();
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
            try
            {
                if (string.IsNullOrEmpty(tbxName.Text))
                    return;

                MainForm.CurrentSystem.AddDrawing(tbxName.Text);
            }
            catch (Exception ex)
            {
                MainForm.Instance.WriteToLog($"Error creating Drawing: {ex.Message}");
                throw;
            }
        }

        #endregion Private Methods
    }
}