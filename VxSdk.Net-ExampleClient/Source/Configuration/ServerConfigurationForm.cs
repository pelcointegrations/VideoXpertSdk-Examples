using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source.Misc
{
    /// <summary>
    /// The ServerConfigurationForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to modify the server configuration.</remarks>
    public partial class ServerConfigurationForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerConfigurationForm" /> class.
        /// </summary>
        public ServerConfigurationForm()
        {
            InitializeComponent();
            ServerConfig = MainForm.CurrentSystem.ServerConfig;

            cbxReverseDnsLookup.Checked = ServerConfig.IsReverseDnsLookupEnabled;
            nudHttpPort.Value = ServerConfig.HttpPort;
            nudHttpsPort.Value = ServerConfig.HttpsPort;
            nudRtspPort.Value = ServerConfig.RtspPort;
        }

        #endregion

        #region Private Properties

        /// <summary>
        /// Gets or sets the ServerConfig property.
        /// </summary>
        /// <value>The current server configuration.</value>
        private Configuration.Server ServerConfig { get; }

        #endregion Private Properties

        #region Private Methods

        private void ButtonRestartServer_Click(object sender, EventArgs args)
        {
            var result = MessageBox.Show($@"Are you sure you wish to restart the server? The current connection will be lost!", @"Restart Server", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                ServerConfig.Restart();
                Close();
            }
        }

        /// <summary>
        /// The ButtonSave_Click method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            if (ServerConfig.IsReverseDnsLookupEnabled != cbxReverseDnsLookup.Checked)
                ServerConfig.IsReverseDnsLookupEnabled = cbxReverseDnsLookup.Checked;

            if (ServerConfig.HttpPort != nudHttpPort.Value)
                ServerConfig.HttpPort = (int)nudHttpPort.Value;

            if (ServerConfig.HttpsPort != nudHttpsPort.Value)
                ServerConfig.HttpsPort = (int)nudHttpsPort.Value;

            if (ServerConfig.RtspPort != nudRtspPort.Value)
                ServerConfig.RtspPort = (int)nudRtspPort.Value;
        }

        #endregion
    }
}
