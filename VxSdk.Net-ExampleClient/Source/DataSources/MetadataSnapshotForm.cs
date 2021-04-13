using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The MetadataSnapshotForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to view metadata snapshots for the selected data source.</remarks>
    public partial class MetadataSnapshotForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSnapshotForm" /> class.
        /// </summary>
        /// <param name="dataSource">The <paramref name="dataSource"/> parameter.</param>
        public MetadataSnapshotForm(DataSource dataSource)
        {
            InitializeComponent();
            SelectedDataSource = dataSource;
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Gets or sets the SelectedDataSource property.
        /// </summary>
        /// <value>The currently selected dataSource.</value>
        private DataSource SelectedDataSource { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonGetSnapshot_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonGetSnapshot_Click(object sender, System.EventArgs args)
        {
            tbxMetadata.Text = string.Empty;
            
            var snapshotEndpoint = chbxCustomTime.Checked ? SelectedDataSource.GetMetadataSnapshotEndpoint(dtpTime.Value.ToUniversalTime()) : SelectedDataSource.GetMetadataSnapshotEndpoint(null);
            if (!string.IsNullOrEmpty(snapshotEndpoint))
                PrintEndpointData(new Uri(snapshotEndpoint));

            if (string.IsNullOrEmpty(tbxMetadata.Text))
                tbxMetadata.Text = "Failed to retrieve metadata snapshot.";
        }

        /// <summary>
        /// The CheckBoxCustomTime_CheckedChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void CheckBoxCustomTime_CheckedChanged(object sender, System.EventArgs args)
        {
            dtpTime.Enabled = chbxCustomTime.Checked;
        }

        /// <summary>
        /// The PrintEndpointData method.
        /// </summary>
        public async void PrintEndpointData(Uri dataUri)
        {
            var response = await MainForm.Instance.SendRequest(dataUri);
            if (response.StatusCode != HttpStatusCode.OK)
                return;

            var multipartContent = await response.Content.ReadAsMultipartAsync();
            foreach (var content in multipartContent.Contents)
            {
                if (content.Headers.ContentType.MediaType != "application/vnd.onvif.metadata")
                    continue;

                var memStream = new MemoryStream();
                var writer = new XmlTextWriter(memStream, Encoding.Unicode);
                var document = new XmlDocument();

                try
                {
                    document.LoadXml(await content.ReadAsStringAsync());
                    writer.Formatting = Formatting.Indented;
                    document.WriteContentTo(writer);
                    writer.Flush();
                    memStream.Flush();
                    memStream.Position = 0;

                    var streamReader = new StreamReader(memStream);
                    tbxMetadata.Text += await streamReader.ReadToEndAsync();
                }
                catch (XmlException)
                {
                    // ignored
                }

                memStream.Close();
                writer.Close();
            }
        }

        #endregion Private Methods
    }
}