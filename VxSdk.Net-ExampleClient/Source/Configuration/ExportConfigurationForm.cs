using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The ExportConfigurationForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to modify the export configuration.</remarks>
    public partial class ExportConfigurationForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportConfigurationForm" /> class.
        /// </summary>
        public ExportConfigurationForm()
        {
            InitializeComponent();
            ExportConfig = MainForm.CurrentSystem.ExportConfig;

            gbxGlobalExportPassword.Enabled = chbxForceProtect.Checked = ExportConfig.ForceProtect;
        }

        #endregion

        #region Private Properties

        /// <summary>
        /// Gets or sets the ExportConfig property.
        /// </summary>
        /// <value>The current export configuration.</value>
        private Configuration.Export ExportConfig { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonSave_Click method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            if (chbxForceProtect.Checked != ExportConfig.ForceProtect)
                ExportConfig.ForceProtect = chbxForceProtect.Checked;

            if (chbxForceProtect.Checked && !string.IsNullOrEmpty(tbxPassword.Text))
                ExportConfig.SetProtectPassword(tbxPassword.Text);
        }

        /// <summary>
        /// The CheckboxForceProtect_CheckedChanged method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void CheckboxForceProtect_CheckedChanged(object sender, EventArgs args)
        {
            gbxGlobalExportPassword.Enabled = chbxForceProtect.Checked;
        }

        #endregion
    }
}
