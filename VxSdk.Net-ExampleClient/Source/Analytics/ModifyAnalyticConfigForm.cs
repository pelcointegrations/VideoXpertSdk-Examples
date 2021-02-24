using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The ModifyAnalyticConfigForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to modify a analytic config.</remarks>
    public partial class ModifyAnalyticConfigForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyAnalyticConfigForm" /> class.
        /// </summary>
        /// <param name="analyticConfig">The <paramref name="analyticConfig"/> parameter.</param>
        /// <param name="dataSource">The <paramref name="dataSource"/> parameter.</param>
        public ModifyAnalyticConfigForm(AnalyticConfig analyticConfig, DataSource dataSource)
        {
            InitializeComponent();
            SelectedAnalyticConfig = analyticConfig;

            if (dataSource.IsPTZ)
            {
                var presets = dataSource.PTZController.Presets;
                foreach (var preset in presets)
                {
                    cbxPresets.Items.Add(preset.Name);
                }
            }

            nudMinConfidence.Value = (decimal)SelectedAnalyticConfig.MinConfidence;
            nudSizeHeight.Value = SelectedAnalyticConfig.Size.Height;
            nudSizeWidth.Value = SelectedAnalyticConfig.Size.Width;
            cbxPresets.SelectedItem = SelectedAnalyticConfig.PtzPresetName;
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Gets or sets the SelectedAnalyticConfig property.
        /// </summary>
        /// <value>The currently selected analytic config.</value>
        private AnalyticConfig SelectedAnalyticConfig { get; }

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
                if (SelectedAnalyticConfig.MinConfidence != (float)nudMinConfidence.Value)
                    SelectedAnalyticConfig.MinConfidence = (float)nudMinConfidence.Value;

                if (SelectedAnalyticConfig.Size.Width != nudSizeWidth.Value || SelectedAnalyticConfig.Size.Height != nudSizeHeight.Value)
                    SelectedAnalyticConfig.Size = new Resolution { Height = (int)nudSizeHeight.Value, Width = (int)nudSizeWidth.Value };

                if (SelectedAnalyticConfig.PtzPresetName != (string)cbxPresets.SelectedItem)
                    SelectedAnalyticConfig.PtzPresetName = (string)cbxPresets.SelectedItem;

            }
            catch (Exception ex)
            {
                MainForm.Instance.WriteToLog($"Error modifying analytic config: {ex.Message}");
            }
        }

        #endregion Private Methods
    }
}