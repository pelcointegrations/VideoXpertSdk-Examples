using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The ModifyAnalyticSessionForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to modify a analytic session.</remarks>
    public partial class ModifyAnalyticSessionForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyAnalyticSessionForm" /> class.
        /// </summary>
        /// <param name="analyticSession">The <paramref name="analyticSession"/> parameter.</param>
        public ModifyAnalyticSessionForm(AnalyticSession analyticSession)
        {
            InitializeComponent();
            SelectedAnalyticSession = analyticSession;

            tbxDataEncodingId.Text = SelectedAnalyticSession.DataEncodingId;
            tbxSource.Text = SelectedAnalyticSession.Source;
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Gets or sets the SelectedAnalyticSession property.
        /// </summary>
        /// <value>The currently selected analytic session.</value>
        private AnalyticSession SelectedAnalyticSession { get; }

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
                if (SelectedAnalyticSession.DataEncodingId != tbxDataEncodingId.Text)
                    SelectedAnalyticSession.DataEncodingId = tbxDataEncodingId.Text;

                if (SelectedAnalyticSession.Source != tbxSource.Text)
                    SelectedAnalyticSession.Source = tbxSource.Text;

            }
            catch (Exception ex)
            {
                MainForm.Instance.WriteToLog($"Error modifying analytic session: {ex.Message}");
            }
        }

        #endregion Private Methods
    }
}