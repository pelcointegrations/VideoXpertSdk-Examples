using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The ExportStreamForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to manage and view export streams.</remarks>
    public partial class ExportStreamForm : Form
    {
        #region Private Fields

        /// <summary>
        /// The CurrentExportStream field.
        /// </summary>
        /// <remarks>Holds the export stream for last item checked in the ExportManager list view.</remarks>
        private ExportStream CurrentExportStream { get; set; }

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportStreamForm" /> class.
        /// </summary>
        /// <param name="exportStream">The selected export stream.</param>
        public ExportStreamForm(ExportStream exportStream)
        {
            InitializeComponent();

            CurrentExportStream = exportStream;
            RefreshExportStreamInfo(true);
        }

        #endregion Public Constructors

        #region Private Methods

        /// <summary>
        /// The ButtonHalt_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonHalt_Click(object sender, EventArgs args)
        {
            CurrentExportStream.Halt();
            RefreshExportStreamInfo();
        }

        /// <summary>
        /// The ButtonPrepare_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonPrepare_Click(object sender, EventArgs args)
        {
            CurrentExportStream.Prepare();
            RefreshExportStreamInfo();
        }

        /// <summary>
        /// The ButtonRefresh_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRefresh_Click(object sender, EventArgs args)
        {
            RefreshExportStreamInfo(true);
        }

        /// <summary>
        /// Refreshes the export stream info.
        /// </summary>
        /// <param name="refreshClips"><c>true</c> to also refresh the clips.</param>
        private void RefreshExportStreamInfo(bool refreshClips = false)
        {
            CurrentExportStream.Refresh();
            switch (CurrentExportStream.Status)
            {
                case ExportStream.States.Failed:
                    btnPrepare.Enabled = true;
                    btnHalt.Enabled = false;
                    lblStatus.Text = @"Failed";
                    break;
                case ExportStream.States.NeedsPreparation:
                    btnPrepare.Enabled = true;
                    btnHalt.Enabled = false;
                    lblStatus.Text = @"Needs Preparation";
                    break;
                case ExportStream.States.Preparing:
                    btnPrepare.Enabled = false;
                    btnHalt.Enabled = true;
                    lblStatus.Text = @"Preparing";
                    break;
                case ExportStream.States.Ready:
                    btnPrepare.Enabled = false;
                    btnHalt.Enabled = false;
                    lblStatus.Text = @"Ready";
                    break;
                default:
                    btnPrepare.Enabled = true;
                    btnHalt.Enabled = true;
                    lblStatus.Text = @"Unknown";
                    break;
            }

            switch (CurrentExportStream.StatusReason)
            {
                case ExportStream.StateReasons.ExportDataUnretrievable:
                    lblReason.Text = @"The export data is unretrievable";
                    break;
                case ExportStream.StateReasons.ExportTempStorageFull:
                    lblReason.Text = @"The temporary export storage is full";
                    break;
                default:
                    lblReason.Text = @"";
                    break;
            }

            lblProgress.Text = Math.Round(CurrentExportStream.PercentComplete) + @"%";
            lblTimeLeft.Text = CurrentExportStream.SecondsRemaining + @"sec.";

            if (!refreshClips)
                return;

            dgvClips.Rows.Clear();
            foreach (var clip in CurrentExportStream.ExportStreamClips)
            {
                dgvClips.Rows.Add(clip.StartTime.ToString("u"), clip.EndTime.ToString("u"), clip.RenderType.ToString(), clip.VideoUrl, clip.AudioUrl);
            }
        }

        #endregion Private Methods
    }
}