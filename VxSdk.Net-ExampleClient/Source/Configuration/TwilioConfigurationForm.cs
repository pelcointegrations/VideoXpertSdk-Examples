using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source.Misc
{
    /// <summary>
    /// The TwilioConfigurationForm class.
    /// </summary>
    /// <remarks>
    /// Provides a dialog window that allows the user to modify the Twilio (twilio.com) SMS account configuration.
    /// </remarks>
    public partial class TwilioConfigurationForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TwilioConfigurationForm" /> class.
        /// </summary>
        public TwilioConfigurationForm()
        {
            InitializeComponent();
            TwilioConfig = MainForm.CurrentSystem.TwilioConfig;

            cbxEnabled.Checked = TwilioConfig.IsEnabled;
            tbxAccountSid.Text = TwilioConfig.AccountSid;
            tbxFromNumber.Text = TwilioConfig.FromNumber;
        }

        #endregion

        #region Private Properties

        /// <summary>
        /// Gets or sets the TwilioConfig property.
        /// </summary>
        /// <value>The current Twilio SMS configuration.</value>
        private Configuration.Twilio TwilioConfig { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonSave_Click method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            if (TwilioConfig.IsEnabled != cbxEnabled.Checked)
                TwilioConfig.IsEnabled = cbxEnabled.Checked;

            if (!cbxEnabled.Checked)
                return;

            if (TwilioConfig.AccountSid != tbxAccountSid.Text)
                TwilioConfig.AccountSid = tbxAccountSid.Text;

            if (TwilioConfig.FromNumber != tbxFromNumber.Text)
                TwilioConfig.FromNumber = tbxFromNumber.Text;

            if (!string.IsNullOrEmpty(tbxAuthToken.Text))
                TwilioConfig.AuthToken = tbxAuthToken.Text;
        }

        /// <summary>
        /// The ButtonValidate_Click method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ButtonValidate_Click(object sender, EventArgs args)
        {
            var toNumber = string.Empty;
            var result = InputBox.Show("Test SMS", "Please enter the phone number to send the test SMS to (e.g., +15595551234): ", ref toNumber);
            if (result != DialogResult.OK || string.IsNullOrEmpty(toNumber))
                return;


            bool isValid = TwilioConfig.ValidateTwilioInfo(tbxAccountSid.Text, tbxAuthToken.Text, tbxFromNumber.Text, toNumber);
            MessageBox.Show($@"Twilio test SMS returned: {(isValid ? "Success" : "Failure")}", @"Twilio Test SMS Result");
        }

        /// <summary>
        /// The CheckBoxEnabled_CheckedChanged method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void CheckBoxEnabled_CheckedChanged(object sender, EventArgs args)
        {
            tbxAccountSid.Enabled = cbxEnabled.Checked;
            tbxFromNumber.Enabled = cbxEnabled.Checked;
            tbxAuthToken.Enabled = cbxEnabled.Checked;
            btnValidate.Enabled = cbxEnabled.Checked;
        }

        #endregion
    }
}
