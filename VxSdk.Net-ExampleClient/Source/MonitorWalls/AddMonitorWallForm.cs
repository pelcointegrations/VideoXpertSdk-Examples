using System;
using System.Windows.Forms;

namespace ExampleClient.Source
{
    /// <summary>
    /// The AddMonitorWallForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to create a new monitor wall.</remarks> 
    public partial class AddMonitorWallForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddMonitorWallForm" /> class.
        /// </summary>
        public AddMonitorWallForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The ButtonAdd_Click method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ButtonAdd_Click(object sender, EventArgs args)
        {
            try
            {
                if (!string.IsNullOrEmpty(tbxName.Text))
                    MainForm.CurrentSystem.AddMonitorWall(tbxName.Text);
            }
            catch (Exception ex)
            {
                MainForm.Instance.WriteToLog($"Error creating Monitor Wall: {ex.Message}");
                throw;
            }
        }
    }
}
