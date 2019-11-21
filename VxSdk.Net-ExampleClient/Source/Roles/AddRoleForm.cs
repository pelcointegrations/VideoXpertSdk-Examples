using System;
using System.Windows.Forms;

namespace ExampleClient.Source
{
    /// <summary>
    /// The AddRoleForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to create a new role.</remarks>
    public partial class AddRoleForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AddRoleForm" /> class.
        /// </summary>
        public AddRoleForm()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Private Methods

        /// <summary>
        /// The ButtonOk_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonOk_Click(object sender, EventArgs args)
        {
            try
            {
                MainForm.CurrentSystem.AddRole(txbxName.Text);
            }
            catch (Exception ex)
            {
                MainForm.Instance.WriteToLog($"Error creating role: {ex.Message}");
                throw;
            }
        }

        #endregion Private Methods
    }
}