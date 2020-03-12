using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source.Misc
{
    /// <summary>
    /// The SmtpConfigurationForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to modify the SMTP configuration.</remarks>
    public partial class SmtpConfigurationForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SmtpConfigurationForm" /> class.
        /// </summary>
        public SmtpConfigurationForm()
        {
            InitializeComponent();
            SmtpConfig = MainForm.CurrentSystem.SmtpConfig;

            tbxSmtpHost.Text = SmtpConfig.Host;
            tbxFromAddress.Text = SmtpConfig.FromAddress;
            tbxUsername.Text = SmtpConfig.Username;
            nudSmtpPort.Value = SmtpConfig.SmtpPort;
            nudTimeout.Value = SmtpConfig.Timeout;
            cbxValidateCert.Checked = SmtpConfig.IsValidateCertEnabled;
            cbxUseSmtps.Checked = SmtpConfig.UseSmtps;
        }

        #endregion

        #region Private Properties

        /// <summary>
        /// Gets or sets the SmtpConfig property.
        /// </summary>
        /// <value>The current SMTP configuration.</value>
        private Configuration.Smtp SmtpConfig { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonSave_Click method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            if (SmtpConfig.Host != tbxSmtpHost.Text)
                SmtpConfig.Host = tbxSmtpHost.Text;

            if (SmtpConfig.FromAddress != tbxFromAddress.Text)
                SmtpConfig.FromAddress = tbxFromAddress.Text;

            if (SmtpConfig.Username != tbxUsername.Text)
                SmtpConfig.Username = tbxUsername.Text;

            if (!string.IsNullOrEmpty(tbxPassword.Text))
                SmtpConfig.Password = tbxPassword.Text;

            if (SmtpConfig.SmtpPort != nudSmtpPort.Value)
                SmtpConfig.SmtpPort = (int)nudSmtpPort.Value;

            if (SmtpConfig.Timeout != nudTimeout.Value)
                SmtpConfig.Timeout = (int)nudTimeout.Value;

            if (SmtpConfig.IsValidateCertEnabled != cbxValidateCert.Checked)
                SmtpConfig.IsValidateCertEnabled = cbxValidateCert.Checked;

            if (SmtpConfig.UseSmtps != cbxUseSmtps.Checked)
                SmtpConfig.UseSmtps = cbxUseSmtps.Checked;
        }

        /// <summary>
        /// The ButtonValidate_Click method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ButtonValidate_Click(object sender, EventArgs args)
        {
            var toAddress = string.Empty;
            var result = InputBox.Show("Test Email", "Please enter the address to send the test email to: ", ref toAddress);
            if (result != DialogResult.OK || string.IsNullOrEmpty(toAddress))
                return;

            var smtpInfo = new SmtpInfo
            {
                FromAddress = tbxFromAddress.Text,
                Host = tbxSmtpHost.Text,
                Username = tbxUsername.Text,
                Password = tbxPassword.Text,
                SmtpPort = (int)nudSmtpPort.Value,
                Timeout = (int)nudTimeout.Value,
                UseSmtps = cbxUseSmtps.Checked,
                ToAddress = toAddress
            };

            bool isValid = SmtpConfig.ValidateSmtpInfo(smtpInfo);
            MessageBox.Show($@"SMTP test email returned: {(isValid ? "Success" : "Failure")}", @"SMTP Test Email Result");
        }

        #endregion
    }
}
