using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source.Misc
{
    /// <summary>
    /// The SnmpConfigurationForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to modify the SNMP agent configuration.</remarks>
    public partial class SnmpConfigurationForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SnmpConfigurationForm" /> class.
        /// </summary>
        public SnmpConfigurationForm()
        {
            InitializeComponent();
            SnmpConfig = MainForm.CurrentSystem.SnmpConfig;

            nudSnmpPort.Value = SnmpConfig.SnmpPort;
            tbxReadCommString.Text = SnmpConfig.V2cReadCommunityString;
            tbxReadUsername.Text = SnmpConfig.V3ReadUsername;
            cbxSnmpVersion.SelectedIndex = SnmpConfig.Version != Configuration.SnmpVersion.Unknown ? (int)SnmpConfig.Version - 1 : 0;
            cbxPrivacyProtocol.SelectedIndex = SnmpConfig.V3PrivacyProtocol != Configuration.PrivacyProtocol.Unknown ? (int)SnmpConfig.V3PrivacyProtocol - 1 : 0;
            cbxAuthProtocol.SelectedIndex = SnmpConfig.V3AuthProtocol != Configuration.AuthProtocol.Unknown ? (int)SnmpConfig.V3AuthProtocol - 1 : 0;
        }

        #endregion

        #region Private Properties

        /// <summary>
        /// Gets or sets the SnmpConfig property.
        /// </summary>
        /// <value>The current SNMP configuration.</value>
        private Configuration.Snmp SnmpConfig { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonSave_Click method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            if (!string.IsNullOrEmpty(tbxReadAuthPassword.Text) && tbxReadAuthPassword.Text.Length < 7)
            {
                MessageBox.Show($@"Read Auth Password must be at least 7 characters in length.", @"Invalid Value");
                return;
            }

            if (!string.IsNullOrEmpty(tbxReadPrivacyPassword.Text) && tbxReadPrivacyPassword.Text.Length < 7)
            {
                MessageBox.Show($@"Read Privacy Password must be at least 7 characters in length.", @"Invalid Value");
                return;
            }

            if (SnmpConfig.V2cReadCommunityString != tbxReadCommString.Text)
                SnmpConfig.V2cReadCommunityString = tbxReadCommString.Text;

            if (SnmpConfig.V3ReadUsername != tbxReadUsername.Text)
                SnmpConfig.V3ReadUsername = tbxReadUsername.Text;

            if (!string.IsNullOrEmpty(tbxReadAuthPassword.Text))
                SnmpConfig.V3ReadAuthPassword = tbxReadAuthPassword.Text;

            if (!string.IsNullOrEmpty(tbxReadPrivacyPassword.Text))
                SnmpConfig.V3ReadPrivacyPassword = tbxReadPrivacyPassword.Text;

            if (SnmpConfig.SnmpPort != nudSnmpPort.Value)
                SnmpConfig.SnmpPort = (int)nudSnmpPort.Value;

            if (SnmpConfig.Version != (Configuration.SnmpVersion)cbxSnmpVersion.SelectedIndex + 1)
                SnmpConfig.Version = (Configuration.SnmpVersion)cbxSnmpVersion.SelectedIndex + 1;

            if (SnmpConfig.V3PrivacyProtocol != (Configuration.PrivacyProtocol)cbxPrivacyProtocol.SelectedIndex + 1)
                SnmpConfig.V3PrivacyProtocol = (Configuration.PrivacyProtocol)cbxPrivacyProtocol.SelectedIndex + 1;

            if (SnmpConfig.V3AuthProtocol != (Configuration.AuthProtocol)cbxAuthProtocol.SelectedIndex + 1)
                SnmpConfig.V3AuthProtocol = (Configuration.AuthProtocol)cbxAuthProtocol.SelectedIndex + 1;

            Close();
        }

        /// <summary>
        /// The ComboBoxSnmpVersion_SelectedIndexChanged method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ComboBoxSnmpVersion_SelectedIndexChanged(object sender, EventArgs args)
        {
            gbxSnmpV2C.Enabled = cbxSnmpVersion.SelectedIndex == 1;
            gbxSnmpV3.Enabled = cbxSnmpVersion.SelectedIndex == 2;
        }

        #endregion
    }
}
