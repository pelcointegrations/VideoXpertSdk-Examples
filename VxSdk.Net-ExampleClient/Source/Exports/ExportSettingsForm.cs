using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The ExportSettingsForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to select the settings
    /// that will be used to create a new export file.</remarks> 
    public partial class ExportSettingsForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportSettingsForm" /> class.
        /// </summary>
        public ExportSettingsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The ButtonStartExport_Click method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ButtonStartExport_Click(object sender, EventArgs args)
        {
            if (string.IsNullOrEmpty(tbxExportName.Text))
                return;

            var newExport = new NewExport();
            foreach (ListViewItem item in NewExportForm.Instance.lvAddedClips.Items)
            {
                var clip = (NewExportClip)item.Tag;
                newExport.Clips.Add(clip);
            }
            newExport.Format = Export.Formats.MkvZip;
            newExport.Name = tbxExportName.Text;
            newExport.Password = tbxExportPassword.Text;
            MainForm.CurrentSystem.AddExport(newExport);

            Close();
        }
    }
}
