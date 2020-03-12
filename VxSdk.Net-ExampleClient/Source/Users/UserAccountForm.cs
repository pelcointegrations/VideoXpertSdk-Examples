using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The UserAccountForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to view and modify a user account.</remarks>
    public partial class UserAccountForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="UserAccountForm" /> class.
        /// </summary>
        /// <param name="userAccount">The <paramref name="userAccount"/> parameter.</param>
        public UserAccountForm(UserAccount userAccount)
        {
            InitializeComponent();
            SelectedUserAccount = userAccount;
            ckbxAllowLdapBypass.Checked = SelectedUserAccount.CanBypassLdap;
            ckbxAccountEnabled.Checked = SelectedUserAccount.IsEnabled;
            ckbxPasswordExpirationDisabled.Checked = SelectedUserAccount.IsPasswordExpirationDisabled;
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Gets or sets the SelectedUserAccount property.
        /// </summary>
        /// <value>The currently selected user account.</value>
        private UserAccount SelectedUserAccount { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonSave_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            if (ckbxAllowLdapBypass.Checked != SelectedUserAccount.CanBypassLdap)
                SelectedUserAccount.CanBypassLdap = ckbxAllowLdapBypass.Checked;

            if (ckbxAccountEnabled.Checked != SelectedUserAccount.IsEnabled)
                SelectedUserAccount.IsEnabled = ckbxAccountEnabled.Checked;

            if (ckbxPasswordExpirationDisabled.Checked != SelectedUserAccount.IsPasswordExpirationDisabled)
                SelectedUserAccount.IsPasswordExpirationDisabled = ckbxPasswordExpirationDisabled.Checked;
        }


        #endregion Private Methods
    }
}