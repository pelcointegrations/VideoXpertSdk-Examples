using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source.Misc
{
    /// <summary>
    /// The LdapConfigurationForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to modify the LDAP configuration.</remarks>
    public partial class LdapConfigurationForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LdapConfigurationForm" /> class.
        /// </summary>
        public LdapConfigurationForm()
        {
            InitializeComponent();
            LdapConfig = MainForm.CurrentSystem.LdapConfig;

            cbxEnable.Checked = LdapConfig.IsEnabled;
            cbxServerTls.Checked = LdapConfig.IsServerTlsEnabled;
            cbxSso.Checked = LdapConfig.IsSsoEnabled;
            cbxTwoStageBinding.Checked = LdapConfig.IsTwoStageBindingEnabled;
            cbxLdapUserAndRoleManagement.Checked = LdapConfig.UseLdapUsersAndRoles;
            nudServerPort.Value = LdapConfig.ServerPort;
            tbxBaseDn.Text = LdapConfig.BaseDn;
            tbxObjectClasses.Text = LdapConfig.ObjectClasses;
            tbsSsoDomain.Text = LdapConfig.SsoDomain;
            tbxSearchAttributes.Text = LdapConfig.SearchAttributes;
            tbxSearchDnAccount.Text = LdapConfig.SearchDnAccount;
            tbxServerHostName.Text = LdapConfig.ServerName;
            tbxVxRootDn.Text = LdapConfig.VxRootDn;
            tbxVxSystemDn.Text = LdapConfig.VxSystemDn;

            gbxSettings.Enabled = cbxEnable.Checked;
            btnValidate.Enabled = cbxEnable.Checked;
        }

        #endregion

        #region Private Properties

        /// <summary>
        /// Gets or sets the LdapConfig property.
        /// </summary>
        /// <value>The current LDAP configuration.</value>
        private Configuration.Ldap LdapConfig { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonSave_Click method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            if (LdapConfig.BaseDn != tbxBaseDn.Text)
                LdapConfig.BaseDn = tbxBaseDn.Text;

            if (LdapConfig.ObjectClasses != tbxObjectClasses.Text)
                LdapConfig.ObjectClasses = tbxObjectClasses.Text;

            if (LdapConfig.SsoDomain != tbsSsoDomain.Text)
                LdapConfig.SsoDomain = tbsSsoDomain.Text;

            if (LdapConfig.SearchAttributes != tbxSearchAttributes.Text)
                LdapConfig.SearchAttributes = tbxSearchAttributes.Text;

            if (LdapConfig.SearchDnAccount != tbxSearchDnAccount.Text)
                LdapConfig.SearchDnAccount = tbxSearchDnAccount.Text;

            if (LdapConfig.ServerName != tbxServerHostName.Text)
                LdapConfig.ServerName = tbxServerHostName.Text;

            if (LdapConfig.VxRootDn != tbxVxRootDn.Text)
                LdapConfig.VxRootDn = tbxVxRootDn.Text;

            if (LdapConfig.VxSystemDn != tbxVxSystemDn.Text)
                LdapConfig.VxSystemDn = tbxVxSystemDn.Text;

            if (!string.IsNullOrEmpty(tbxSearchDnPassword.Text))
                LdapConfig.SearchDnPassword = tbxSearchDnPassword.Text;

            if (LdapConfig.ServerPort != nudServerPort.Value)
                LdapConfig.ServerPort = (int)nudServerPort.Value;

            if (LdapConfig.IsEnabled != cbxEnable.Checked)
                LdapConfig.IsEnabled = cbxEnable.Checked;

            if (LdapConfig.IsServerTlsEnabled != cbxServerTls.Checked)
                LdapConfig.IsServerTlsEnabled = cbxServerTls.Checked;

            if (LdapConfig.IsSsoEnabled != cbxSso.Checked)
                LdapConfig.IsSsoEnabled = cbxSso.Checked;

            if (LdapConfig.IsTwoStageBindingEnabled != cbxTwoStageBinding.Checked)
                LdapConfig.IsTwoStageBindingEnabled = cbxTwoStageBinding.Checked;

            if (LdapConfig.UseLdapUsersAndRoles != cbxLdapUserAndRoleManagement.Checked)
                LdapConfig.UseLdapUsersAndRoles = cbxLdapUserAndRoleManagement.Checked;
        }

        /// <summary>
        /// The ButtonValidate_Click method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ButtonValidate_Click(object sender, EventArgs args)
        {
            var ldapUsername = string.Empty;
            var usernameResult = InputBox.Show("LDAP Username", "Please enter the user login name to validate: ", ref ldapUsername);
            if (usernameResult != DialogResult.OK || string.IsNullOrEmpty(ldapUsername))
                return;

            var ldapPassword = string.Empty;
            var passwordResult = InputBox.Show("LDAP Password", "Please enter the user password to validate: ", ref ldapPassword);
            if (passwordResult != DialogResult.OK || string.IsNullOrEmpty(ldapPassword))
                return;

            var validationCreds = new LdapValidationCredentials
            {
                BaseDn = tbxBaseDn.Text,
                ObjectClasses = tbxObjectClasses.Text,
                SsoDomain = tbsSsoDomain.Text,
                SearchAttributes = tbxSearchAttributes.Text,
                SearchDnAccount = tbxSearchDnAccount.Text,
                ServerName = tbxServerHostName.Text,
                VxRootDn = tbxVxRootDn.Text,
                VxSystemDn = tbxVxSystemDn.Text,
                SearchDnPassword = tbxSearchDnPassword.Text,
                ServerPort = (int) nudServerPort.Value,
                IsServerTlsEnabled = cbxServerTls.Checked,
                IsSsoEnabled = cbxSso.Checked,
                IsTwoStageBindingEnabled = cbxTwoStageBinding.Checked,
                UseLdapUsersAndRoles = cbxLdapUserAndRoleManagement.Checked,
                Password = ldapPassword,
                Username = ldapUsername
            };

            bool isValid = LdapConfig.ValidateLdapCredentials(validationCreds);
            MessageBox.Show($@"LDAP validation returned: {(isValid ? "Valid" : "Not Valid")}", @"Validation Result");
        }

        /// <summary>
        /// The CheckBoxEnable_CheckedChanged method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void CheckBoxEnable_CheckedChanged(object sender, EventArgs args)
        {
            gbxSettings.Enabled = cbxEnable.Checked;
            btnValidate.Enabled = cbxEnable.Checked;
        }

        #endregion
    }
}
