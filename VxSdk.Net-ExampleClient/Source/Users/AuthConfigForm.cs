using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The AuthConfigForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to modify the authorization configuration.</remarks>
    public partial class AuthConfigForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthConfigForm" /> class.
        /// </summary>
        public AuthConfigForm()
        {
            InitializeComponent();
            AuthConfig = MainForm.CurrentSystem.AuthConfig;

            nudPasswordExpiration.Enabled = chbxPasswordExpiration.Checked;
            nudPasswordExpiration.Value = AuthConfig.PasswordExpiration;
            chbxPasswordExpiration.Checked = AuthConfig.IsPasswordExpirationEnabled;
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Gets or sets the AuthConfig property.
        /// </summary>
        /// <value>The current authorization configuration.</value>
        private Configuration.Auth AuthConfig { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonSave_Click method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            try
            {
                if (AuthConfig.IsPasswordExpirationEnabled != chbxPasswordExpiration.Checked)
                    AuthConfig.IsPasswordExpirationEnabled = chbxPasswordExpiration.Checked;

                if (AuthConfig.PasswordExpiration != nudPasswordExpiration.Value)
                    AuthConfig.PasswordExpiration = (int)nudPasswordExpiration.Value;
            }
            catch (Exception ex)
            {
                MainForm.Instance.WriteToLog($"Error modifying authentication config: {ex.Message}");
            }
        }

        /// <summary>
        /// The CheckboxPasswordExpiration_CheckedChanged method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void CheckboxPasswordExpiration_CheckedChanged(object sender, EventArgs args)
        {
            nudPasswordExpiration.Enabled = chbxPasswordExpiration.Checked;
        }

        #endregion Private Methods
    }
}