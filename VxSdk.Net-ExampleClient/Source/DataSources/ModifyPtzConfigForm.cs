using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The ModifyPtzConfigForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to modify the ptz config for a data source.</remarks>
    public partial class ModifyPtzConfigForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyPtzConfigForm" /> class.
        /// </summary>
        /// <param name="ptzConfig">The <paramref name="ptzConfig"/> parameter.</param>
        public ModifyPtzConfigForm(DataSourceConfig.Ptz ptzConfig)
        {
            InitializeComponent();
            SelectedPtzConfig = ptzConfig;
            switch (ptzConfig.Protocol)
            {
                case DataSourceConfig.PtzControlProtocol.Coaxitron:
                    rbCoaxitron.Checked = true;
                    break;

                case DataSourceConfig.PtzControlProtocol.ProtocolD:
                    rbProtocolD.Checked = true;
                    break;

                case DataSourceConfig.PtzControlProtocol.ExtendedCoaxitron:
                    rbExtendedCoaxitron.Checked = true;
                    break;

                case DataSourceConfig.PtzControlProtocol.ProtocolP:
                    rbProtocolP.Checked = true;
                    break;

                default:
                    rbDisabled.Checked = true;
                    break;
            }
        }

        #endregion Public Constructors

        #region Private Properties
        /// <summary>
        /// Gets or sets the SelectedPtzConfig property.
        /// </summary>
        /// <value>The currently selected ptz config.</value>
        private DataSourceConfig.Ptz SelectedPtzConfig { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonSave_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            if (rbCoaxitron.Checked && SelectedPtzConfig.Protocol != DataSourceConfig.PtzControlProtocol.Coaxitron)
                SelectedPtzConfig.Protocol = DataSourceConfig.PtzControlProtocol.Coaxitron;
            else if (rbProtocolD.Checked && SelectedPtzConfig.Protocol != DataSourceConfig.PtzControlProtocol.ProtocolD)
                SelectedPtzConfig.Protocol = DataSourceConfig.PtzControlProtocol.ProtocolD;
            else if (rbExtendedCoaxitron.Checked && SelectedPtzConfig.Protocol != DataSourceConfig.PtzControlProtocol.ExtendedCoaxitron)
                SelectedPtzConfig.Protocol = DataSourceConfig.PtzControlProtocol.ExtendedCoaxitron;
            else if (rbProtocolP.Checked && SelectedPtzConfig.Protocol != DataSourceConfig.PtzControlProtocol.ProtocolP)
                SelectedPtzConfig.Protocol = DataSourceConfig.PtzControlProtocol.ProtocolP;
            else if (rbDisabled.Checked && SelectedPtzConfig.Protocol != DataSourceConfig.PtzControlProtocol.Disabled)
                SelectedPtzConfig.Protocol = DataSourceConfig.PtzControlProtocol.Disabled;
        }

        #endregion Private Methods
    }
}