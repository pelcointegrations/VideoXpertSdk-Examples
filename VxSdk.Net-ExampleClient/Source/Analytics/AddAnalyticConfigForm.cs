using System;
using System.Linq;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The AddAnalyticConfigForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to select the settings
    /// that will be used to create a new bookmark.</remarks>
    public partial class AddAnalyticConfigForm : Form
    {
        #region Private Fields

        /// <summary>
        /// The _selectedDataSource field.
        /// </summary>
        /// <remarks>The selected data source.</remarks>
        private readonly DataSource _selectedDataSource;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AddAnalyticConfigForm" /> class.
        /// </summary>
        public AddAnalyticConfigForm(DataSource dataSource)
        {
            InitializeComponent();

            _selectedDataSource = dataSource;
            if (dataSource.IsPTZ)
            {
                var presets = dataSource.PTZController.Presets;
                foreach (var preset in presets)
                {
                    cbxPresets.Items.Add(new ComboboxItem {Text = preset.Name, Value = preset.Name});
                }
            }

        }

        #endregion Public Constructors

        #region Private Methods

        /// <summary>
        /// The ButtonAdd_Click method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ButtonAdd_Click(object sender, EventArgs args)
        {


            try
            {
                var newAnalyticConfig = new NewAnalyticConfig();
                if (cbxPresets.SelectedItem != null)
                    newAnalyticConfig.PtzPresetName = ((ComboboxItem)cbxPresets.SelectedItem).Value.ToString();

                newAnalyticConfig.MinConfidence = (float)nudMinConfidence.Value;
                newAnalyticConfig.Size = new Resolution();
                newAnalyticConfig.Size.Height = (int)nudSizeHeight.Value;
                newAnalyticConfig.Size.Width = (int)nudSizeWidth.Value;

                _selectedDataSource.AddAnalyticConfig(newAnalyticConfig);
            }
            catch (Exception ex)
            {
                MainForm.Instance.WriteToLog($"Error creating analytic config: {ex.Message}");
                throw;
            }
        }

        #endregion Private Methods
    }
}