using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The ThermalEtdConfigurationForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to modify the thermal elevated temperature detection configuration.</remarks>
    public partial class ThermalEtdConfigurationForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ThermalEtdConfigurationForm" /> class.
        /// </summary>
        /// <param name="config">The thermal ETD config to modify.</param>
        public ThermalEtdConfigurationForm(Configuration.ThermalEtd config)
        {
            InitializeComponent();
            ThermalEtdConfig = config;

            cbxEnabled.Checked = ThermalEtdConfig.IsEnabled;
            nudLowerBound.Value = (decimal)ThermalEtdConfig.NormalRangeLowerBound;
            nudUpperBound.Value = (decimal)ThermalEtdConfig.NormalRangeUpperBound;
            nudTimeout.Value = ThermalEtdConfig.Timeout;
        }

        #endregion

        #region Private Properties

        /// <summary>
        /// Gets or sets the ThermalEtdConfig property.
        /// </summary>
        /// <value>The current thermal ETD configuration.</value>
        private Configuration.ThermalEtd ThermalEtdConfig { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonSave_Click method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            if (ThermalEtdConfig.IsEnabled != cbxEnabled.Checked)
                ThermalEtdConfig.IsEnabled = cbxEnabled.Checked;

            if (Math.Abs(ThermalEtdConfig.NormalRangeLowerBound - (float)nudLowerBound.Value) > 0.01)
                ThermalEtdConfig.NormalRangeLowerBound = (float)nudLowerBound.Value;

            if (Math.Abs(ThermalEtdConfig.NormalRangeUpperBound - (float)nudUpperBound.Value) > 0.01)
                ThermalEtdConfig.NormalRangeUpperBound = (float)nudUpperBound.Value;

            if (ThermalEtdConfig.Timeout != nudTimeout.Value)
                ThermalEtdConfig.Timeout = (int)nudTimeout.Value;
        }

        /// <summary>
        /// The CheckBoxEnabled_CheckedChanged method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void CheckBoxEnabled_CheckedChanged(object sender, EventArgs args)
        {
            lblLowerBound.Enabled = nudLowerBound.Enabled = cbxEnabled.Checked;
            lblUpperBound.Enabled = nudUpperBound.Enabled = cbxEnabled.Checked;
            lblTimeout.Enabled = nudTimeout.Enabled = cbxEnabled.Checked;
        }

        #endregion
    }
}
