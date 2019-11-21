using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;

namespace ExampleClient.Source
{
    /// <summary>
    /// The DownloadProgressForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that displays the current progress of a
    /// newly created export.</remarks>
    public partial class DownloadProgressForm : Form
    {
        #region Private Fields

        /// <summary>
        /// The _dataUri field.
        /// </summary>
        /// <remarks>The <c>Uri</c> of the export file to download.</remarks>
        private readonly Uri _dataUri;

        /// <summary>
        /// The _fileName field.
        /// </summary>
        /// <remarks>The name to use for the downloaded export file.</remarks>
        private readonly string _fileName;

        /// <summary>
        /// The _fileSize field.
        /// </summary>
        /// <remarks>Used to calculate the download completion percentage of the export.</remarks>
        private double _fileSizeKb;

        /// <summary>
        /// The _webClient field.
        /// </summary>
        /// <remarks>Used to download the export file once it has completed.</remarks>
        private WebClient _webClient;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadProgressForm" /> class.
        /// </summary>
        /// <param name="dataUri">The <c>Uri</c> of the export file to download.</param>
        /// <param name="fileName">The name to use for the downloaded export file.</param>
        /// <param name="fileSizeKb">The size of the file to be downloaded.</param>
        public DownloadProgressForm(Uri dataUri, string fileName, int fileSizeKb)
        {
            _dataUri = dataUri;
            _fileName = fileName;
            _fileSizeKb = fileSizeKb * 1024;
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// The StartDownload method.
        /// </summary>
        public void StartDownload()
        {
            lblDownloading.Text = $@"Downloading file to {_fileName}";

            // Create a new WebClient instance.
            _webClient = new WebClient();

            // Sets the WebClient to use the correct SecurityProtocol for the VideoXpert server.
            if (ServicePointManager.SecurityProtocol != (SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls | SecurityProtocolType.Ssl3))
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls | SecurityProtocolType.Ssl3;

            // Forces the WebClient to trust the security certificate handed back from the VideoXpert server.
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            // Supply the username and password that was used to create the VideoXpert system.
            _webClient.Headers.Add("X-Serenity-User", EncodeToBase64(MainForm.CurrentUserName));
            _webClient.Headers.Add("X-Serenity-Password", EncodeToBase64(MainForm.CurrentPassword));

            // Subscribe to the download events.
            _webClient.DownloadProgressChanged += WebClientDownloadProgressChanged;
            _webClient.DownloadFileCompleted += WebClientDownloadFileCompleted;
            _webClient.DownloadFileAsync(_dataUri, _fileName);
        }

        /// <summary>
        /// The WebClientDownloadFileCompleted method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        /// <remarks>Checks to see if the download completed event was due to an error or cancellation.</remarks>
        public void WebClientDownloadFileCompleted(object sender, AsyncCompletedEventArgs args)
        {
            if (args?.Error == null)
                return;

            // Notify the user that the download has either been cancelled or had an error.
            lblDownloading.Text = args.Cancelled ?
                "Download cancelled." : $"Error: {args.Error.Message}";

            btnCancel.Text = @"Close";
            if (_webClient == null)
                return;

            _webClient.DownloadProgressChanged -= WebClientDownloadProgressChanged;
            _webClient.DownloadFileCompleted -= WebClientDownloadFileCompleted;
            _webClient.Dispose();
        }

        /// <summary>
        /// The WebClientDownloadProgressChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        public void WebClientDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs args)
        {
            if (args.BytesReceived > 0)
            {
                lblDownloaded.Visible = true;
                var kb = args.BytesReceived / 1024;
                if (kb < 1024)
                    lblBytes.Text = kb + @" KB";
                else if (kb < 1048576)
                    lblBytes.Text = Math.Round((double)kb / 1024, 1) + @" MB";
                else
                    lblBytes.Text = Math.Round((double)kb / 1024 / 1024, 1) + @" GB";
            }

            if (_fileSizeKb <= 0)
            {
                if (args.TotalBytesToReceive > 0)
                    _fileSizeKb = args.TotalBytesToReceive;
                else
                    return;
            }

            // Calculate the download percentage and update the progress bar value.
            var percentComplete = args.BytesReceived / _fileSizeKb * 100;
            progressBar.Value = (int)percentComplete;
            if (percentComplete < 100)
                return;

            // Notify the user of completion and unsubscribe from the notification events.
            lblDownloading.Text = @"Download complete.";
            _webClient.DownloadProgressChanged -= WebClientDownloadProgressChanged;
            _webClient.DownloadFileCompleted -= WebClientDownloadFileCompleted;
            _webClient.Dispose();
            btnCancel.Text = @"Close";
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// The EncodeToBase64 method.
        /// </summary>
        /// <param name="toEncode">The string to encode to Base64.</param>
        /// <returns>The Base64 encoded string.</returns>
        private static string EncodeToBase64(string toEncode)
        {
            var toEncodeAsBytes = System.Text.Encoding.ASCII.GetBytes(toEncode);
            var returnValue = Convert.ToBase64String(toEncodeAsBytes);
            return returnValue;
        }

        /// <summary>
        /// The ButtonCancel_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonCancel_Click(object sender, EventArgs args)
        {
            if (_webClient != null)
            {
                _webClient.CancelAsync();
                return;
            }

            Close();
        }

        #endregion Private Methods
    }
}