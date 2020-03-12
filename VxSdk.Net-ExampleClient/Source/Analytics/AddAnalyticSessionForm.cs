using System;
using System.Linq;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The AddAnalyticSessioForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to select the settings
    /// that will be used to create a new bookmark.</remarks>
    public partial class AddAnalyticSessionForm : Form
    {
        #region Private Fields

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AddAnalyticSessionForm" /> class.
        /// </summary>
        public AddAnalyticSessionForm()
        {
            InitializeComponent();

            var analyticServerDevices = MainForm.CurrentSystem.Devices.Where(dev => dev.Type == Device.Types.AnalyticServer);
            foreach (Device device in analyticServerDevices)
            {
                cbxDevice.Items.Add(new ComboboxItem { Text = device.Name, Value = device.Id });
            }

            foreach (DataSource dataSource in MainForm.CurrentSystem.DataSources)
            {
                cbxDataSource.Items.Add(new ComboboxItem { Text = dataSource.Name, Value = dataSource.Id });
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
            if (cbxDataSource.SelectedItem == null || cbxDevice.SelectedItem == null)
                return;

            try
            {
                var newAnalyticSession = new NewAnalyticSession();
                newAnalyticSession.DataSourceId = ((ComboboxItem)cbxDataSource.SelectedItem).Value.ToString();
                newAnalyticSession.DeviceId = ((ComboboxItem)cbxDevice.SelectedItem).Value.ToString();
                newAnalyticSession.DataEncodingId = tbxDataEncodingId.Text;
                newAnalyticSession.Id = tbxId.Text;
                newAnalyticSession.Source = tbxSource.Text;

                MainForm.CurrentSystem.AddAnalyticSession(newAnalyticSession);
            }
            catch (Exception ex)
            {
                MainForm.Instance.WriteToLog($"Error creating analytic session: {ex.Message}");
                throw;
            }
        }

        #endregion Private Methods
    }
}