using ExampleClient.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The MainForm class.
    /// </summary>
    /// <remarks>This class contains the main UI form.</remarks>
    public partial class MainForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm" /> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            scOuter.Panel2Collapsed = true;
            Instance = this;
            PtzForm = new PtzControlForm();
            Control = ControlManager.Instance;
            RecordingBasePath = Environment.GetFolderPath(Environment.SpecialFolder.CommonVideos) + "\\";
            SnapshotBasePath = Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures) + "\\";
            bgWorker.DoWork += Utilities.BackgroundWorker_DoWork;
            bgWorker.ProgressChanged += Utilities.BackgroundWorker_ProgressChanged;
            bgWorker.RunWorkerCompleted += Utilities.BackgroundWorker_RunWorkerCompleted;
            LogPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Pelco\\VxSdk\\Logs";
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// Gets or sets the CurrentDataSources property.
        /// </summary>
        /// <value>The current list of data sources found on the VideoXpert system.</value>
        public static List<DataSource> CurrentDataSources { get; set; }

        /// <summary>
        /// Gets or sets the CurrentDevices property.
        /// </summary>
        /// <value>The current list of devices found on the VideoXpert system.</value>
        public static List<Device> CurrentDevices { get; set; }

        /// <summary>
        /// Gets or sets the CurrentPassword property.
        /// </summary>
        /// <value>The current VideoXpert system password.</value>
        public static string CurrentPassword { get; set; }

        /// <summary>
        /// Gets or sets the CurrentSystem property.
        /// </summary>
        /// <value>The current VideoXpert system.</value>
        public static VXSystem CurrentSystem { get; set; }

        /// <summary>
        /// Gets or sets the CurrentUserName property.
        /// </summary>
        /// <value>The current VideoXpert system user name.</value>
        public static string CurrentUserName { get; set; }

        /// <summary>
        /// Gets the Instance property.
        /// </summary>
        /// <value>The current <see cref="MainForm"/> instance.</value>
        public static MainForm Instance { get; private set; }

        /// <summary>
        /// Gets or sets the LogPath property.
        /// </summary>
        /// <value>The logging directory for the VxSDK.</value>
        public static string LogPath { get; set; }

        /// <summary>
        /// Gets or sets the PtzForm property.
        /// </summary>
        /// <value>A <see cref="PtzControlForm"/>.</value>
        public static PtzControlForm PtzForm { get; set; }

        /// <summary>
        /// Gets or sets the RecordingBasePath property.
        /// </summary>
        /// <value>The directory to save local recorded videos.</value>
        public static string RecordingBasePath { get; set; }

        /// <summary>
        /// Gets or sets the SnapshotBasePath property.
        /// </summary>
        /// <value>The directory to save snapshots.</value>
        public static string SnapshotBasePath { get; set; }

        /// <summary>
        /// Gets or sets the Control property.
        /// </summary>
        /// <value>A <see cref="ControlManager"/>.</value>
        public ControlManager Control { get; set; }

        #endregion Public Properties

        #region Private Properties

        private DataSource SelectedDataSource
        {
            get
            {
                DataSource dataSource = null;
                if (dgvDataSources.SelectedRows.Count >= 1)
                    dataSource = (DataSource)dgvDataSources.SelectedRows[0].Tag;
                return dataSource;
            }
        }

        #endregion Private Properties

        #region Public Methods

        public void MainInvoke(Action action)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<Action>(MainInvoke), action);
                return;
            }
            action();
        }

        public void MainBeginInvoke(Action action)
        {
            BeginInvoke(action);
        }

        public void EnableModeByState()
        {
            switch (Control.States.VcrState)
            {
                case ControlManager.VcrMode.Live:
                    EnableLiveMode();
                    break;

                case ControlManager.VcrMode.Paused:
                    EnablePauseMode();
                    break;

                case ControlManager.VcrMode.Playback:
                    EnablePlaybackMode();
                    break;

                case ControlManager.VcrMode.Stopped:
                    EnableStopMode();
                    break;
            }
        }

        /// <summary>
        /// The OnInternalEvent method.
        /// </summary>
        /// <param name="internalEvent">The <paramref name="internalEvent"/> parameter.</param>
        public void OnInternalEvent(InternalEvent internalEvent)
        {
            WriteToLog(internalEvent.Type.ToString());
            if (internalEvent.Type == InternalEvent.EventType.GraceLicenseExpired || internalEvent.Type == InternalEvent.EventType.SystemLicenseExpired)
            {
                MainBeginInvoke(Logout);
            }
        }

        /// <summary>
        /// The OnSystemEvent method.
        /// </summary>
        /// <param name="systemEvent">The <paramref name="systemEvent"/> parameter.</param>
        public void OnSystemEvent(Event systemEvent)
        {
            var type = EventDisplayForm.FormatText(systemEvent.SituationType.Split('/').Last());
            var severity = Math.Abs(systemEvent.Severity - 11);
            Device device = null;
            foreach (var dev in CurrentDevices.Where(dev => dev.Id == systemEvent.SourceDeviceId))
                device = dev;

            var devName = device != null ? device.Name : systemEvent.SourceDeviceId;
            WriteToLog(string.Format(Resources.EventHeaderFormatString, severity, type, devName));

            if (displayEventDialogsToolStripMenuItem.Checked)
            {
                MainInvoke(() =>
                {
                    var eventForm = new EventDisplayForm(systemEvent);
                    eventForm.Show(Instance);
                });
            }
        }

        /// <summary>
        /// The SendRequest method.
        /// </summary>
        /// <param name="uri">The request <c>Uri</c>.</param>
        /// <returns>The response message.</returns>
        public async Task<HttpResponseMessage> SendRequest(Uri uri)
        {
            HttpResponseMessage response = null;
            // Create a new WebClient instance.
            using (var client = new HttpClient())
            {
                // Supply the username and password that was used to create the VideoXpert system.
                var request = new HttpRequestMessage(HttpMethod.Get, uri);
                request.Headers.Add("X-Serenity-User", EncodeToBase64(CurrentUserName));
                request.Headers.Add("X-Serenity-Password", EncodeToBase64(CurrentPassword));

                if (ServicePointManager.SecurityProtocol != (SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls | SecurityProtocolType.Ssl3))
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls | SecurityProtocolType.Ssl3;

                // Forces the WebClient to trust the security certificate handed back from the VideoXpert server.
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                response = await client.SendAsync(request);
            }
            return response;
        }

        /// <summary>
        /// The ShowLicenseWarning method.
        /// </summary>
        /// <param name="expirationTime">The grace license expiration time.</param>
        public void ShowLicenseWarning(DateTime expirationTime)
        {
            var message =
                "This system has not been licensed to run this integration.  The grace period for this license\n is active but will" +
                $" expire on:\n\n {expirationTime.ToLocalTime().ToShortDateString()} at {expirationTime.ToLocalTime().ToShortTimeString()}.\n\nThis integration will cease to function if the system remains unlicensed when the grace period expires.";

            var form = new Form
            {
                TopMost = true,
                Text = @"System License Warning",
                ClientSize = new Size(500, 137),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent,
                MinimizeBox = false,
                MaximizeBox = false
            };

            var label = new Label
            {
                Text = message,
                TextAlign = ContentAlignment.MiddleCenter,
                Bounds = new Rectangle(9, 10, 480, 50),
                AutoSize = true
            };

            var buttonOk = new Button
            {
                Text = @"OK",
                Bounds = new Rectangle(228, 102, 75, 23),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
                DialogResult = DialogResult.OK
            };

            buttonOk.Click += (sender, args) => form.Close();
            form.AcceptButton = buttonOk;
            form.Controls.AddRange(new Control[] { label, buttonOk });
            form.ShowDialog();
        }

        /// <summary>
        /// The StopStream method.
        /// </summary>
        public void StopStream()
        {
            try
            {
                if (Control.States.MediaController == null) return;

                if (Control.States.IsReconnecting)
                {
                    Control.States.IsReconnecting = false;
                    Control.States.VideoLossLabel.Visible = false;
                }

                Control.RemovePlaybackProgress();
                Control.States.MediaController.Stop();

                Control.UnsubscribeToTimestamps();
                Control.UnsubscribeToStreamEvents();

                Control.States.TimestampLabel.Text = string.Empty;
                Control.States.StreamPanel.Refresh();

                Control.States.PtzControl = null;
                Control.States.VideoDataSource = null;
                Control.States.ManualRecording = null;
                btnManualRecord.Text = @"Record";
                btnManualRecord.Enabled = false;
                nudPostRecord.Enabled = false;
                nudPreRecord.Enabled = false;
                Control.ChangePtzFormState(false);

                if (btnLocalRecord.Text == @"Stop Local Record")
                    btnLocalRecord.Text = @"Start Local Record";

                Control.States.MediaController.Dispose();
                Control.States.MediaController = null;
            }
            catch (Exception ex)
            {
                WriteToLog($@"Error: {ex.Message}\n");
            }
        }

        /// <summary>
        /// Subscribes to internal VxSDK events.
        /// </summary>
        public void SubscribeToInternalEvents()
        {
            CurrentSystem.InternalEvent += OnInternalEvent;
        }

        /// <summary>
        /// The WriteToLog method.
        /// </summary>
        /// <param name="message">The <paramref name="message"/> parameter.</param>
        public void WriteToLog(string message)
        {
            var time = DateTime.Now;
            MainBeginInvoke(() => txbxLog.AppendText(time.ToLongTimeString() + ": " + message + "\n"));
        }

        #endregion Public Methods

        #region Protected Methods

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            StopAllStreams();
            base.OnFormClosing(e);
        }

        #endregion Protected Methods

        #region Private Methods

        /// <summary>
        /// The EncodeToBase64 method.
        /// </summary>
        /// <param name="toEncode">The string to encode to Base64.</param>
        /// <returns>The Base64 encoded string.</returns>
        private static string EncodeToBase64(string toEncode)
        {
            var toEncodeAsBytes = Encoding.ASCII.GetBytes(toEncode);
            var returnValue = Convert.ToBase64String(toEncodeAsBytes);
            return returnValue;
        }

        /// <summary>
        /// The SelectDataInterface method.
        /// </summary>
        /// <param name="selProtocol">The selected protocol.</param>
        /// <param name="dataSource">The selected data source.</param>
        /// <param name="showWindow">Selects the first available stream if False.</param>
        /// <param name="useRtspTcp">Only valid if protocol is RtspRtp.  Selects TCP or UDP transport</param>
        /// <param name="recordDateTime">Only show the data intefaces with recording if using playback</param>
        /// <returns>The currently selected data interface.</returns>
        private static DataInterface SelectDataInterface(DataInterface.StreamProtocols selProtocol, DataSource dataSource, bool showWindow, bool useRtspTcp, DateTime recordDateTime)
        {
            DataInterface dataInterface;
            if (selProtocol == DataInterface.StreamProtocols.RtspRtp)
            {
                var interfaceList = dataSource.DataInterfaces.Where(iface =>
                    iface.Protocol == DataInterface.StreamProtocols.RtspRtp).ToList();

                if (useRtspTcp == true)
                {
                    interfaceList = interfaceList.Where(iface => iface.SupportsMulticast == false).ToList();
                }

                if (recordDateTime != default(DateTime))
                {
                    // Need to figure out which interfaces have the clip for the time you want
                    interfaceList.Clear();
                    var clips = dataSource.Clips;
                    foreach (var clip in clips)
                    {
                        if ((recordDateTime >= clip.StartTime) && (recordDateTime < clip.EndTime))
                        {
                            // There is a problem in that the data interface on playback also includes a start time
                            //   that will be used instead of the seek time to the seek call.
                            //  So, go ahead and select the first interface, unless there is more than one
                            interfaceList = clip.DataInterfaces;
                            if (interfaceList.Count == 1)
                            {
                                interfaceList[0] = dataSource.DataInterfaces[0];
                            }
                            break;
                        }
                    }
                }
                if (interfaceList.Count == 0)
                    return null;

                if (!showWindow)
                    return interfaceList[0];

                if (interfaceList.Count > 1)
                {
                    using (var streamSelectionForm = new StreamSelectionForm(interfaceList))
                    {
                        streamSelectionForm.ShowDialog();
                        if (streamSelectionForm.SelectedInterface == null)
                            return null;
                        dataInterface = streamSelectionForm.SelectedInterface;
                    }
                }
                else
                    dataInterface = interfaceList[0];
            }
            else
            {
                dataInterface = dataSource.DataInterfaces.First(iface =>
                    iface.Protocol == DataInterface.StreamProtocols.MjpegPull);
            }

            return dataInterface;
        }

        /// <summary>
        /// The ShowSnapshotDialog method.
        /// </summary>
        /// <param name="fileName">The file name of the snapshot image.</param>
        private static void ShowSnapshotDialog(string fileName)
        {
            var message = $"Snapshot saved: {fileName}\n\n View snapshot?";
            var result = MessageBox.Show(message, @"View Snapshot", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Process.Start(fileName);
        }

        /// <summary>
        /// The ButtonLive_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonLive_Click(object sender, EventArgs args)
        {
            if (SelectedDataSource == null) return;

            StartStream();
            EnableLiveMode();
        }

        /// <summary>
        /// The ButtonManualRecord_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonLocalRecord_Click(object sender, EventArgs args)
        {
            if (Control.States.MediaController == null || Control.States.VideoDataSource == null)
                return;

            if (btnLocalRecord.Text == @"Stop Local Record")
            {
                Control.States.MediaController.StopLocalRecording();
                var message = $"Video saved to: {RecordingBasePath}";
                MessageBox.Show(message, @"Recording Complete");
                btnLocalRecord.Text = @"Start Local Record";
            }
            else
            {
                var temp = Control.States.VideoDataSource.Name + "-" + DateTime.Now.ToString("yyyyMMddTHHmmss");
                var safeFileName = string.Join("_", temp.Split(Path.GetInvalidFileNameChars()));

                if (Control.States.MediaController.StartLocalRecording(RecordingBasePath, safeFileName))
                    btnLocalRecord.Text = @"Stop Local Record";
                else
                    WriteToLog("Unable to start local recording.");
            }
        }

        /// <summary>
        /// The ButtonManualRecord_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonManualRecord_Click(object sender, EventArgs args)
        {
            if (Control.States.MediaController == null)
                return;

            if (Control.States.VideoDataSource == null)
                return;

            if (Control.States.ManualRecording == null)
            {
                var newManualRecording = new NewManualRecording { DataSourceId = Control.States.VideoDataSource.Id };

                Control.States.ManualRecording = CurrentSystem.AddManualRecording(newManualRecording);
                if (Control.States.ManualRecording == null)
                {
                    WriteToLog("Unable to start manual recording.");
                    return;
                }

                WriteToLog($"Started manual recording on {Control.States.VideoDataSource.Name}.");
                btnManualRecord.Text = @"Stop";
                nudPreRecord.Enabled = false;
                nudPostRecord.Enabled = false;
            }
            else
            {
                var result = CurrentSystem.DeleteManualRecording(Control.States.ManualRecording);
                if (result != Results.Value.OK)
                    WriteToLog($"Error: {result}.");

                WriteToLog($"Stopped manual recording on {Control.States.VideoDataSource.Name}.");
                Control.States.ManualRecording = null;
                btnManualRecord.Text = @"Record";
                if (Control.States.MediaController.Mode != MediaControl.Modes.Live)
                    return;

                nudPreRecord.Enabled = true;
                nudPostRecord.Enabled = true;
            }
        }

        /// <summary>
        /// The ButtonPause_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonPause_Click(object sender, EventArgs args)
        {
            if (SelectedDataSource == null || Control.States.MediaController == null) return;

            if (Control.States.VcrState != ControlManager.VcrMode.Paused)
            {
                Control.States.MediaController.Pause();
                EnablePauseMode();
            }
            else
            {
                if (Control.States.MediaController.Mode == MediaControl.Modes.Live)
                {
                    Control.States.MediaController.GoToLive();
                    EnableLiveMode();
                }
                else
                {
                    Control.States.MediaController.Play((float)nudSpeed.Value);
                    EnablePlaybackMode();
                }
            }
        }

        /// <summary>
        /// The ButtonRefreshDataSources_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRefreshDataSources_Click(object sender, EventArgs args)
        {
            bgWorker.WorkerReportsProgress = true;
            bgWorker.RunWorkerAsync();
        }

        /// <summary>
        /// The ButtonSeek_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonSeek_Click(object sender, EventArgs args)
        {
            if (SelectedDataSource == null) return;

            // Want to cache the clips to avoid extra server calls
            var clips = SelectedDataSource.Clips;
            if (clips.Count == 0)
            {
                // No data clips - so nothing to show
                MessageBox.Show("This Camera contains no recordings");
                return;
            }

            // Note, if there is a storage time, the start time may be changing while you are selecting
            //   your start time.
            SeekSelectForm seekSelectForm = new SeekSelectForm(clips[0].StartTime.ToLocalTime(), clips[clips.Count - 1].EndTime.ToLocalTime());
            seekSelectForm.ShowDialog();

            if (seekSelectForm.DialogResult == DialogResult.OK)
            {
                // You may have selected a gap - check this case, let the user know,
                //   and adjust
                DateTime startTimeToUse = seekSelectForm.StartTime;
                for (int i = 0; i < clips.Count; i++)
                {
                    // The exact start time may return a 404 not found from the server, add a second
                    var clip = clips[i];
                    if (startTimeToUse.ToUniversalTime().Equals(clip.StartTime))
                        startTimeToUse = startTimeToUse.AddSeconds(1);

                    if (i + 1 < clips.Count)
                    {
                        if ((startTimeToUse.ToUniversalTime() >= clip.EndTime) && (startTimeToUse.ToUniversalTime() < clips[i + 1].StartTime))
                        {
                            // in a gap - round up to the next clip start
                            startTimeToUse = clips[i + 1].StartTime.AddSeconds(1).ToLocalTime();
                            MessageBox.Show("Start Time in gap:  will start at " + startTimeToUse.ToString());
                            break;
                        }
                    }
                }

                DateTime endTimeToUse = seekSelectForm.EndTime;
                for (int i = 0; i < clips.Count - 1; i++)
                {
                    var clip = clips[i];
                    if ((endTimeToUse.ToUniversalTime() > clip.EndTime) && (endTimeToUse.ToUniversalTime() <= clips[i + 1].StartTime))
                    {
                        // in a gap - round down to the last clip end
                        endTimeToUse = clips[i].EndTime.ToLocalTime();
                        MessageBox.Show("End Time in gap:  will start at " + endTimeToUse.ToLocalTime().ToString());
                        break;
                    }
                }

                // The time values must be in UTC format.
                WriteToLog("Info:  Skip Gaps Set To:  " + skipGapsToolStripMenuItem.Checked.ToString());
                StartStream(startTimeToUse.ToUniversalTime(), endTimeToUse.ToUniversalTime());
            }

            EnablePlaybackMode();
        }

        /// <summary>
        /// The ButtonSnapshot_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonSnapshot_Click(object sender, EventArgs args)
        {
            if (Control.States.MediaController == null) return;

            var dataSource = Control.States.MediaController.CurrentDataSource;
            if (Control.States.MediaController.Mode == MediaControl.Modes.Live)
                SaveSnapshotLive(dataSource);

            if (Control.States.MediaController.Mode == MediaControl.Modes.Playback)
                SaveSnapshotRecorded(dataSource);
        }

        /// <summary>
        /// The ButtonSnapshotFromVideo_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonSnapshotFromVideo_Click(object sender, EventArgs e)
        {
            if (Control.States.MediaController == null) return;

            var imageTime = Control.States.TimestampLabel.Text.Replace(":", string.Empty);
            var filename = "LiveFromVideo-" + imageTime;
            if (!Directory.Exists(SnapshotBasePath))
            {
                WriteToLog($"Unable to take snapshot, path no longer exists {SnapshotBasePath}.");
                return;
            }
            Control.States.MediaController.SnapShot(SnapshotBasePath, filename);
            ShowSnapshotDialog(SnapshotBasePath + filename + ".jpg");
        }

        /// <summary>
        /// The ButtonStop_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonStop_Click(object sender, EventArgs args)
        {
            if (Control.States.MediaController == null) return;

            StopStream();
            EnableStopMode();
        }

        private void EnableLiveMode()
        {
            if (Control.States.MediaController == null) return;

            Control.States.VcrState = ControlManager.VcrMode.Live;
            btnLive.Enabled = false;
            btnPause.Enabled = true;
            btnSeek.Enabled = true;
            btnStop.Enabled = true;

            ptzToolStripMenuItem.Enabled = true;
            streamsToolStripMenuItem.Enabled = true;
            btnSnapshot.Enabled = true;
            btnSnapshotFromVideo.Enabled = true;
            btnRefreshDataSources.Enabled = true;
            btnLocalRecord.Enabled = true;
            nudSpeed.Enabled = false;
            btnPause.Text = "Pause";
            nudSpeed.Value = 1.0m;
            SetManualRecordingStatus();
            Control.ChangePtzFormState(Control.States.PtzControl != null);
        }

        private void EnableLoggedOutMode()
        {
            Control.SetVcrStates(ControlManager.VcrMode.Unknown);
            btnLive.Enabled = false;
            btnPause.Enabled = false;
            btnSeek.Enabled = false;
            btnStop.Enabled = false;

            ptzToolStripMenuItem.Enabled = false;
            streamsToolStripMenuItem.Enabled = false;
            btnSnapshot.Enabled = false;
            btnSnapshotFromVideo.Enabled = false;
            btnRefreshDataSources.Enabled = false;
            btnLocalRecord.Enabled = false;
            nudSpeed.Enabled = false;
            btnPause.Text = "Pause";
            nudSpeed.Value = 1.0m;
            SetManualRecordingStatus();
        }

        private void EnablePauseMode()
        {
            if (Control.States.MediaController == null) return;

            Control.States.VcrState = ControlManager.VcrMode.Paused;
            btnLive.Enabled = true;
            btnPause.Enabled = true;
            btnSeek.Enabled = true;
            btnStop.Enabled = true;
            btnManualRecord.Enabled = false;
            nudPostRecord.Enabled = false;
            nudPreRecord.Enabled = false;

            ptzToolStripMenuItem.Enabled = true;
            streamsToolStripMenuItem.Enabled = true;
            btnSnapshot.Enabled = true;
            btnSnapshotFromVideo.Enabled = true;
            btnRefreshDataSources.Enabled = true;
            btnLocalRecord.Enabled = true;
            nudSpeed.Enabled = true;
            btnPause.Text = "Play";
            Control.ChangePtzFormState(false);
        }

        private void EnablePlaybackMode()
        {
            if (Control.States.MediaController == null) return;

            Control.States.VcrState = ControlManager.VcrMode.Playback;
            btnLive.Enabled = true;
            btnPause.Enabled = true;
            btnSeek.Enabled = true;
            btnStop.Enabled = true;

            ptzToolStripMenuItem.Enabled = true;
            streamsToolStripMenuItem.Enabled = true;
            btnSnapshot.Enabled = true;
            btnSnapshotFromVideo.Enabled = true;
            btnRefreshDataSources.Enabled = true;
            btnLocalRecord.Enabled = true;
            nudSpeed.Enabled = false;
            btnPause.Text = "Pause";
            SetManualRecordingStatus();
        }

        private void EnableStopMode()
        {
            Control.States.VcrState = ControlManager.VcrMode.Stopped;
            btnLive.Enabled = true;
            btnPause.Enabled = false;
            btnSeek.Enabled = true;
            btnStop.Enabled = false;

            ptzToolStripMenuItem.Enabled = true;
            streamsToolStripMenuItem.Enabled = true;
            btnSnapshot.Enabled = false;
            btnSnapshotFromVideo.Enabled = false;
            btnRefreshDataSources.Enabled = true;
            btnLocalRecord.Enabled = false;
            nudSpeed.Enabled = true;
            btnPause.Text = "Pause";
            SetManualRecordingStatus();
        }

        /// <summary>
        /// The GridViewDataSources_CellDoubleClick method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void GridViewDataSources_CellDoubleClick(object sender, DataGridViewCellEventArgs args)
        {
            StartStream();
            EnableLiveMode();
        }

        /// <summary>
        /// The Logout method.
        /// </summary>
        private void Logout()
        {
            StopAllStreams();
            CurrentSystem.SystemEvent -= OnSystemEvent;
            CurrentSystem.InternalEvent -= OnInternalEvent;
            dgvDataSources.Rows.Clear();
            CurrentUserName = string.Empty;
            CurrentPassword = string.Empty;
            CurrentDataSources?.Clear();
            CurrentDevices?.Clear();

            CurrentDataSources = null;
            CurrentDevices = null;
            eventsToolStripMenuItem.Enabled = false;
            manageToolStripMenuItem.Enabled = false;

            EnableLoggedOutMode();
        }

        /// <summary>
        /// The MainForm_Shown method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MainForm_Shown(object sender, EventArgs args)
        {
            if (Program.LicenseString == "ENTER_LICENSE_KEY_HERE")
                MessageBox.Show(Instance, Resources.LicenseStringMissingText, @"Default License Key", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// The MenuItemAcknowledgeAllEvents_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemAcknowledgeAllEvents_Click(object sender, EventArgs args)
        {
            var result = MessageBox.Show(@"This will acknowledge all events on the system.  Do you wish to proceed?", @"Acknowledge All Events",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            var ackResult = CurrentSystem.AcknowledgeAllEvents();
            var messageIcon = ackResult != Results.Value.OK ? MessageBoxIcon.Error : MessageBoxIcon.None;
            var messageCaption = ackResult != Results.Value.OK ? "Action Failed" : "Action Successful";
            var message = ackResult != Results.Value.OK ? $"Failed to acknowledge all events.\nError returned was: {ackResult.ToString()}"
                : "Successfully acknowledged all events.";

            MessageBox.Show(message, messageCaption, MessageBoxButtons.OK, messageIcon);
        }

        /// <summary>
        /// The MenuItemAlarmInputManager_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemAlarmInputManager_Click(object sender, EventArgs args)
        {
            using (var alarmInputManagerForm = new AlarmInputManagerForm())
            {
                alarmInputManagerForm.ShowDialog();
            }
        }

        private void MenuItemAspectRatio_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            if (item == null)
                return;

            Control.States.AspectRatio = (MediaControl.AspectRatios)item.Tag;
            UpdateSelectedAspectRatio();

            if (Control.States.MediaController != null)
                Control.States.MediaController.AspectRatio = Control.States.AspectRatio;
        }

        /// <summary>
        /// The MenuItemBookmarkManager_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemBookmarkManager_Click(object sender, EventArgs args)
        {
            using (var bookmarkForm = new BookmarkManagerForm())
            {
                bookmarkForm.ShowDialog();
            }
        }

        /// <summary>
        /// The MenuItemClusterConfig_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemClusterConfig_Click(object sender, EventArgs args)
        {
            using (var clusterConfigDetailsForm = new ClusterConfigDetailsForm())
            {
                clusterConfigDetailsForm.GetClusterConfig(CurrentSystem);
                clusterConfigDetailsForm.ShowDialog();
            }
        }

        /// <summary>
        /// The MenuItemConnect_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemConnect_Click(object sender, EventArgs args)
        {
            using (var connectForm = new ConnectForm())
            {
                connectForm.ShowDialog();
            }
        }

        /// <summary>
        /// The MenuItemDataObjectManager_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemDataObjectManager_Click(object sender, EventArgs args)
        {
            using (var dataObjectManager = new DataObjectManagerForm())
            {
                dataObjectManager.ShowDialog();
            }
        }

        /// <summary>
        /// The MenuItemDataSourceManager_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemDataSourceManager_Click(object sender, EventArgs args)
        {
            using (var dataSourceManagerForm = new DataSourceManagerForm())
            {
                dataSourceManagerForm.ShowDialog();
            }
        }

        /// <summary>
        /// The MenuItemDataStorageManager_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemDataStorageManager_Click(object sender, EventArgs args)
        {
            using (var dataStorageManager = new DataStorageManagerForm())
            {
                dataStorageManager.ShowDialog();
            }
        }

        /// <summary>
        /// The MenuItemDeviceManager_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemDeviceManager_Click(object sender, EventArgs args)
        {
            using (var deviceManagerForm = new DeviceManagerForm())
            {
                deviceManagerForm.ShowDialog();
            }
        }

        /// <summary>
        /// The MenuItemDisplayEventDialogs_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemDisplayEventDialogs_Click(object sender, EventArgs args)
        {
            displayEventDialogsToolStripMenuItem.Checked = !displayEventDialogsToolStripMenuItem.Checked;
        }

        /// <summary>
        /// The MenuItemDrawingManager_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemDrawingManager_Click(object sender, EventArgs args)
        {
            using (var drawingManagerForm = new DrawingManagerForm())
            {
                drawingManagerForm.ShowDialog();
            }
        }

        /// <summary>
        /// The MenuItemExit_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemExit_Click(object sender, EventArgs args)
        {
            Close();
        }

        /// <summary>
        /// The MenuItemExportLocal_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemExportLocal_Click(object sender, EventArgs e)
        {
            using (var localExportForm = new Exports.LocalExportSelect())
            {
                localExportForm.ShowDialog();
            }
        }

        /// <summary>
        /// The MenuItemExportManager_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemExportManager_Click(object sender, EventArgs args)
        {
            using (var exportForm = new ExportManagerForm())
            {
                exportForm.ShowDialog();
            }
        }

        /// <summary>
        /// The MenuItemInsertEvent_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemInsertEvent_Click(object sender, EventArgs args)
        {
            using (var addEventForm = new AddEventForm())
            {
                addEventForm.ShowDialog();
            }
        }

        /// <summary>
        /// The MenuItemLicenseDetails_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemLicenseDetails_Click(object sender, EventArgs args)
        {
            using (var licenseDetailsForm = new LicenseDetailsForm())
            {
                licenseDetailsForm.ShowDialog();
            }
        }

        /// <summary>
        /// The MenuItemLog_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemLog_Click(object sender, EventArgs args)
        {
            if (scOuter.Panel2Collapsed)
            {
                showLogToolStripMenuItem.Text = @"Hide Log";
                ClientSize = new Size(ClientSize.Width, ClientSize.Height + 90);
                scOuter.Panel2Collapsed = false;
            }
            else
            {
                showLogToolStripMenuItem.Text = @"Show Log";
                ClientSize = new Size(ClientSize.Width, ClientSize.Height - 90);
                scOuter.Panel2Collapsed = true;
            }
        }

        /// <summary>
        /// The MenuItemLogLevel_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemLogLevel_Click(object sender, EventArgs args)
        {
            var item = sender as ToolStripMenuItem;
            if (item == null)
                return;

            logTraceToolStripMenuItem.Checked = item == logTraceToolStripMenuItem;
            logDebugToolStripMenuItem.Checked = item == logDebugToolStripMenuItem;
            logInfoToolStripMenuItem.Checked = item == logInfoToolStripMenuItem;
            logWarningToolStripMenuItem.Checked = item == logWarningToolStripMenuItem;
            logErrorToolStripMenuItem.Checked = item == logErrorToolStripMenuItem;
            logFatalToolStripMenuItem.Checked = item == logFatalToolStripMenuItem;
            logDisableToolStripMenuItem.Checked = item == logDisableToolStripMenuItem;

            VxGlobal.SetLogLevel((LogLevel.Value)item.Tag);
        }

        /// <summary>
        /// The MenuItemLogout_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemLogout_Click(object sender, EventArgs args)
        {
            var name = CurrentSystem.Name;
            Logout();
            WriteToLog("Info: Logged out from " + name + ".");
        }

        /// <summary>
        /// The MenuItemModifyLoggingPath_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemModifyLoggingPath_Click(object sender, EventArgs args)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.SelectedPath = LogPath;
                folderDialog.Description = @"Choose Logging Path...";

                var result = folderDialog.ShowDialog();
                if (result != DialogResult.OK)
                    return;

                LogPath = folderDialog.SelectedPath;
                VxGlobal.SetLogPath(LogPath.Replace(@"\", @"\\"));
                WriteToLog($"Logging Path changed to: {folderDialog.SelectedPath}");
            }
        }

        /// <summary>
        /// The MenuItemMonitors_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemMonitors_Click(object sender, EventArgs args)
        {
            using (var monitorManagerForm = new MonitorManagerForm())
            {
                monitorManagerForm.ShowDialog();
            }
        }

        /// <summary>
        /// The MenuItemMonitorWalls_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemMonitorWalls_Click(object sender, EventArgs args)
        {
            using (var monitorWallManagerForm = new MonitorWallManagerForm())
            {
                monitorWallManagerForm.ShowDialog();
            }
        }

        /// <summary>
        /// The MenuItemPixelSearch_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemPixelSearch_Click(object sender, EventArgs args)
        {
            using (var newPixelSearchForm = new NewPixelSearchForm())
            {
                newPixelSearchForm.ShowDialog();
            }
        }

        /// <summary>
        /// The MenuItemPlaybackOptions_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemPlaybackOptions_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            if (item != null && item.Text == @"Skip Gaps")
            {
                normalToolStripMenuItem.Checked = false;
                skipGapsToolStripMenuItem.Checked = true;
            }
            else
            {
                normalToolStripMenuItem.Checked = true;
                skipGapsToolStripMenuItem.Checked = false;
            }

            StopAllStreams();
            Control.SetVcrStates(ControlManager.VcrMode.Stopped);
            EnableModeByState();
        }

        /// <summary>
        /// The MenuItemProtocol_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemProtocol_Click(object sender, EventArgs args)
        {
            var item = sender as ToolStripMenuItem;
            if (item != null)
            {
                if (item.Text == @"JPEG Pull")
                {
                    rtspUdpToolStripMenuItem.Checked = false;
                    rtspTcpToolStripMenuItem.Checked = false;
                    jpegPullToolStripMenuItem.Checked = true;
                }
                else if (item.Text == @"RTSP TCP")
                {
                    rtspUdpToolStripMenuItem.Checked = false;
                    rtspTcpToolStripMenuItem.Checked = true;
                    jpegPullToolStripMenuItem.Checked = false;
                }
                else
                {
                    rtspUdpToolStripMenuItem.Checked = true;
                    rtspTcpToolStripMenuItem.Checked = false;
                    jpegPullToolStripMenuItem.Checked = false;
                }
            }

            StopAllStreams();
            Control.SetVcrStates(ControlManager.VcrMode.Stopped);
            EnableModeByState();
        }

        /// <summary>
        /// The MenuItemRecordingPath_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemRecordingPath_Click(object sender, EventArgs args)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.SelectedPath = RecordingBasePath;
                folderDialog.Description = @"Choose Recorded Video Save Path...";

                var result = folderDialog.ShowDialog();
                if (result != DialogResult.OK)
                    return;

                RecordingBasePath = folderDialog.SelectedPath + "\\";
                var message = $"Recorded Video Path changed: {folderDialog.SelectedPath}";
                MessageBox.Show(message, @"Recorded Video Path");
            }
        }

        /// <summary>
        /// The MenuItemRelayOutputManager_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemRelayOutputManager_Click(object sender, EventArgs args)
        {
            using (var relayOutputManagerForm = new RelayOutputManagerForm())
            {
                relayOutputManagerForm.ShowDialog();
            }
        }

        /// <summary>
        /// The MenuItemRoleManager_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemRoleManager_Click(object sender, EventArgs args)
        {
            using (var roleForm = new RoleManagerForm())
            {
                roleForm.ShowDialog();
            }
        }

        /// <summary>
        /// The MenuItemRuleManager_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemRuleManager_Click(object sender, EventArgs args)
        {
            using (var ruleManagerForm = new RuleManagerForm())
            {
                ruleManagerForm.ShowDialog();
            }
        }

        /// <summary>
        /// The MenuItemScheduleManager_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemScheduleManager_Click(object sender, EventArgs args)
        {
            using (var scheduleForm = new ScheduleManagerForm())
            {
                scheduleForm.ShowDialog();
            }
        }

        /// <summary>
        /// The MenuItemScheduleManager_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemSearchEvents_Click(object sender, EventArgs args)
        {
            using (var eventSearchForm = new EventSearchForm())
            {
                eventSearchForm.ShowDialog();
            }
        }

        /// <summary>
        /// The MenuItemShowPtzControls_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemShowPtzControls_Click(object sender, EventArgs args)
        {
            PtzForm.Show();
        }

        /// <summary>
        /// The MenuItemSituationManager_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemSituationManager_Click(object sender, EventArgs args)
        {
            using (var situationForm = new SituationManagerForm())
            {
                situationForm.ShowDialog();
            }
        }

        /// <summary>
        /// The MenuItemSnapshotPath_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemSnapshotPath_Click(object sender, EventArgs args)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.SelectedPath = SnapshotBasePath;
                folderDialog.Description = @"Choose Snapshot Save Path...";

                var result = folderDialog.ShowDialog();
                if (result != DialogResult.OK)
                    return;

                SnapshotBasePath = folderDialog.SelectedPath + "\\";
                var message = $"Snapshot Path changed: {folderDialog.SelectedPath}";
                MessageBox.Show(message, @"Snapshot Path");
            }
        }

        private void MenuItemStretchToFit_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            if (item == null)
                return;

            Control.States.StretchToFit = item.Checked;

            if (Control.States.MediaController != null)
                Control.States.MediaController.StretchToFit = Control.States.StretchToFit;
        }

        /// <summary>
        /// The MenuItemSubscribe_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemSubscribe_Click(object sender, EventArgs args)
        {
            if (!subscribeToSystemEventsToolStripMenuItem.Checked)
            {
                // Only one subscription can be active at once.  So unsubscribe to the system
                // events if it is active.
                if (subscribeToSystemEventsByTypeToolStripMenuItem.Checked)
                {
                    CurrentSystem.SystemEvent -= OnSystemEvent;
                    subscribeToSystemEventsByTypeToolStripMenuItem.Checked = false;
                }

                CurrentSystem.SystemEvent += OnSystemEvent;
                subscribeToSystemEventsToolStripMenuItem.Checked = true;
                WriteToLog("Subscribed to events.");
            }
            else
            {
                CurrentSystem.SystemEvent -= OnSystemEvent;
                subscribeToSystemEventsToolStripMenuItem.Checked = false;
                WriteToLog("Unsubscribed to events.");
            }
        }

        /// <summary>
        /// The MenuItemSubscribeByType_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemSubscribeByType_Click(object sender, EventArgs args)
        {
            if (!subscribeToSystemEventsByTypeToolStripMenuItem.Checked)
            {
                // Only one subscription can be active at once.  So unsubscribe to the type specific
                // system events if it is active.
                if (subscribeToSystemEventsToolStripMenuItem.Checked)
                {
                    CurrentSystem.SystemEvent -= OnSystemEvent;
                    subscribeToSystemEventsToolStripMenuItem.Checked = false;
                }

                using (var situationTypeSelectionForm = new SituationTypeSelectionForm())
                {
                    situationTypeSelectionForm.ShowDialog();
                }

                subscribeToSystemEventsByTypeToolStripMenuItem.Checked = true;
            }
            else
            {
                CurrentSystem.SystemEvent -= OnSystemEvent;
                subscribeToSystemEventsByTypeToolStripMenuItem.Checked = false;
                WriteToLog("Unsubscribed to events.");
            }
        }

        /// <summary>
        /// The MenuItemTagManager_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemTagManager_Click(object sender, EventArgs args)
        {
            using (var tagForm = new TagManagerForm())
            {
                tagForm.ShowDialog();
            }
        }

        /// <summary>
        /// The MenuItemTimeTables_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemTimeTables_Click(object sender, EventArgs args)
        {
            using (var timeTableManagerForm = new TimeTableManagerForm())
            {
                timeTableManagerForm.ShowDialog();
            }
        }

        /// <summary>
        /// The MenuItemUserManager_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MenuItemUserManager_Click(object sender, EventArgs args)
        {
            using (var userForm = new UserManagerForm())
            {
                userForm.ShowDialog();
            }
        }

        /// <summary>
        /// The PanelVideoStream_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void PanelVideoStream_Click(object sender, EventArgs args)
        {
            var panel = sender as Panel;
            if (panel == null)
                return;

            if (Control.States.StreamPanel != panel)
                return;

            var point = panel.PointToClient(Cursor.Position);
            if (Control.States.PtzControl == null)
                return;

            float relX;
            float relY;
            var xMidPoint = (float)panel.Width / 2;
            if (point.X > xMidPoint)
            {
                var adjustedX = point.X - xMidPoint;
                relX = adjustedX / xMidPoint * 100;
            }
            else
            {
                var adjustedX = xMidPoint - point.X;
                relX = adjustedX / xMidPoint * -100;
            }

            var yMidPoint = (float)panel.Height / 2;
            if (point.Y > yMidPoint)
            {
                var adjustedY = yMidPoint - point.Y;
                relY = adjustedY / yMidPoint * 100;
            }
            else
            {
                var adjustedY = point.Y - yMidPoint;
                relY = adjustedY / yMidPoint * -100;
            }

            var result = Control.States.PtzControl.RelativePercentageMove((int)relX, (int)relY);
            if (result != Results.Value.OK)
                WriteToLog($"Error: {result}.");
        }

        /// <summary>
        /// The PanelVideoStream_MouseEnter method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void PanelVideoStream_MouseEnter(object sender, EventArgs args)
        {
            var panel = sender as Panel;
            if (panel == null)
                return;

            if (Control.States.StreamPanel != panel)
                return;

            if (Control.States.PtzControl == null)
                return;

            panel.Cursor = Cursors.Cross;
        }

        /// <summary>
        /// The PanelVideoStream_MouseLeave method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void PanelVideoStream_MouseLeave(object sender, EventArgs args)
        {
            var panel = sender as Panel;
            if (panel == null)
                return;

            if (Control.States.StreamPanel != panel)
                return;

            if (Control.States.PtzControl == null)
                return;

            panel.Cursor = Cursors.Default;
        }

        /// <summary>
        /// The PanelVideoStream_MouseWheel method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void PanelVideoStream_MouseWheel(object sender, MouseEventArgs args)
        {
            var panel = sender as Panel;
            if (panel == null)
                return;

            if (Control.States.StreamPanel != panel)
                return;

            if (Control.States.PtzControl == null)
                return;

            var zoomLevel = (float)args.Delta / 2;
            var result = Control.States.PtzControl.RelativeMove(0, 0, (int)zoomLevel);
            if (result != Results.Value.OK)
                WriteToLog($"Error: {result}.");
        }

        /// <summary>
        /// The PanelVideoStreamLeft_MouseClick method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void PanelVideoStreamLeft_MouseClick(object sender, EventArgs args)
        {
            Control.SelectControl(ControlManager.Controls.Left);
            UpdateSelectedAspectRatio();
            stretchToFitToolStripMenuItem.Checked = Control.States.StretchToFit;

            if (Control.States.VcrState != ControlManager.VcrMode.Unknown)
                EnableModeByState();

            if (Control.States.PtzControl == null)
                return;

            Control.States.StreamPanel.Cursor = Cursors.Cross;
        }

        /// <summary>
        /// The PanelVideoStreamRight_MouseClick method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void PanelVideoStreamRight_MouseClick(object sender, EventArgs args)
        {
            Control.SelectControl(ControlManager.Controls.Right);
            UpdateSelectedAspectRatio();
            stretchToFitToolStripMenuItem.Checked = Control.States.StretchToFit;

            if (Control.States.VcrState != ControlManager.VcrMode.Unknown)
                EnableModeByState();

            if (Control.States.PtzControl == null)
                return;

            Control.States.StreamPanel.Cursor = Cursors.Cross;
        }

        /// <summary>
        /// The SaveSnapshotLive method.
        /// </summary>
        /// <param name="dataSource">The data source to use for the snapshot.</param>
        private async void SaveSnapshotLive(DataSource dataSource)
        {
            var uri = new Uri(dataSource.SnapshotUri);
            var response = await SendRequest(uri);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                WriteToLog($"Unable to take snapshot, server returned {response.StatusCode}.");
                return;
            }

            var bytes = await response.Content.ReadAsByteArrayAsync();
            var imageTime = Control.States.TimestampLabel.Text.Replace(":", string.Empty);
            var filename = SnapshotBasePath + "Live-" + imageTime + ".jpg";
            if (!Directory.Exists(SnapshotBasePath))
            {
                WriteToLog($"Unable to take snapshot, path no longer exists {SnapshotBasePath}.");
                return;
            }

            BinaryWriter binWriter = null;
            try
            {
                binWriter = new BinaryWriter(new FileStream(filename, FileMode.Append, FileAccess.Write));
                binWriter.Write(bytes);
                binWriter.Close();
            }
            finally
            {
                binWriter?.Dispose();
            }

            ShowSnapshotDialog(filename);
        }

        /// <summary>
        /// The SaveSnapshotRecorded method.
        /// </summary>
        /// <param name="dataSource">The data source to use for the snapshot.</param>
        private async void SaveSnapshotRecorded(DataSource dataSource)
        {
            var listBytes = new List<ImageByteArray>();
            var clips = dataSource.Clips;

            // Find the clip that contains the section of video currently playing.
            Clip currentClip = null;
            foreach (var clip in clips)
            {
                var time = DateTime.Parse(Control.States.TimestampLabel.Text).ToUniversalTime();
                if (time > clip.StartTime && time < clip.EndTime)
                    currentClip = clip;
            }

            // Exit if no clip was found.
            if (currentClip == null)
            {
                WriteToLog("Error: Unable to find clip.");
                return;
            }

            var filter = new SnapshotFilter
            {
                StartTime = DateTime.Parse(Control.States.TimestampLabel.Text).ToUniversalTime(),
                EndTime = DateTime.Parse(Control.States.TimestampLabel.Text).ToUniversalTime().AddSeconds(1),
                Offset = 10
            };

            var uri = new Uri(currentClip.GetSnapshotEndpoint(filter));
            var response = await SendRequest(uri);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                WriteToLog($"Unable to take snapshot, server returned {response.StatusCode}.");
                return;
            }

            var mpmsp = await response.Content.ReadAsMultipartAsync();
            foreach (var content in mpmsp.Contents)
            {
                var bytes = await content.ReadAsByteArrayAsync();
                if (bytes == null)
                    continue;

                var imgByteArray = new ImageByteArray(bytes, content.Headers);
                listBytes.Add(imgByteArray);
            }

            foreach (var byteArray in listBytes)
            {
                var imageTime = byteArray.ImageTime.ToString("s").Replace(":", string.Empty);
                var filename = SnapshotBasePath + "Recorded-" + imageTime + ".jpg";
                if (!Directory.Exists(SnapshotBasePath))
                {
                    WriteToLog($"Unable to take snapshot, path no longer exists {SnapshotBasePath}.");
                    return;
                }

                BinaryWriter binWriter = null;
                try
                {
                    binWriter = new BinaryWriter(new FileStream(filename, FileMode.Append, FileAccess.Write));
                    binWriter.Write(byteArray.Bytes);
                    binWriter.Close();
                }
                finally
                {
                    binWriter?.Dispose();
                }

                ShowSnapshotDialog(filename);
            }
        }

        private void scInner_Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        /// <summary>
        /// Select the audio data source and data interfaces from the MainForm.CurrentDataSources
        /// </summary>
        /// <param name="videoSource">Video data source</param>
        /// <param name="showWindow">Specifies wheather to show the window or not</param>
        /// <param name="audioSource">Out parameter for audio data source</param>
        /// <param name="audioInterface">Out parameter for audio data interface</param>
        private void SelectAudioData(DataSource videoSource, bool showWindow, out DataSource audioSource, out DataInterface audioInterface, bool useTCP)
        {
            audioSource = null;
            audioInterface = null;

            foreach (var ds in CurrentDataSources)
            {
                if (videoSource.Name != ds.Name || ds.Type != DataSource.Types.Audio)
                    continue;

                audioInterface = SelectDataInterface(DataInterface.StreamProtocols.RtspRtp, ds, showWindow, useTCP, default(DateTime));
                if (audioInterface == null)
                {
                    WriteToLog("Error: No audio data interface found for selected camera.\n");
                    return;
                }

                audioSource = ds;
            }
        }

        /// <summary>
        /// Sets the state of the manual recording UI elements based on the manual recording status of the current stream.
        /// </summary>
        private void SetManualRecordingStatus()
        {
            if (Control.States.VideoDataSource == null)
            {
                btnManualRecord.Text = @"Record";
                btnManualRecord.Enabled = false;
                nudPreRecord.Enabled = false;
                nudPostRecord.Enabled = false;
                return;
            }

            var userUpn = CurrentSystem.Currentuser.Name + "@" + CurrentSystem.Currentuser.Domain;
            foreach (var manualRecording in CurrentSystem.ManualRecordings)
            {
                if (manualRecording.DataSourceId != Control.States.VideoDataSource.Id || manualRecording.OwnerName != userUpn)
                    continue;

                Control.States.ManualRecording = manualRecording;
                btnManualRecord.Text = @"Stop";
                btnManualRecord.Enabled = true;
                nudPreRecord.Enabled = false;
                nudPostRecord.Enabled = false;
                return;
            }

            btnManualRecord.Text = @"Record";
            btnManualRecord.Enabled = Control.States.MediaController.Mode == MediaControl.Modes.Live;
            nudPreRecord.Enabled = Control.States.MediaController.Mode == MediaControl.Modes.Live;
            nudPostRecord.Enabled = Control.States.MediaController.Mode == MediaControl.Modes.Live;
        }

        /// <summary>
        /// The SetupPtzControls method.
        /// </summary>
        /// <param name="dataSource">The <paramref name="dataSource"/> parameter.</param>
        /// <remarks>Checks if PTZ is enabled on the device.  If enabled, it also gets the
        /// available presets and patterns for the device.</remarks>
        private void SetupPtzControls(DataSource dataSource)
        {
            if (dataSource.IsPTZ && Control.States.MediaController.Mode == MediaControl.Modes.Live)
                Control.States.PtzControl = dataSource.PTZController;
            else
                Control.States.PtzControl = null;

            Control.ChangePtzFormState(dataSource.PTZController != null);
        }

        /// <summary>
        /// The StartStream method.
        /// </summary>
        /// <param name="seekTime">The <paramref name="seekTime"/> in UTC format.  If no value or a default
        /// DateTime object is given then the stream is started in live mode.</param>
        /// <param name="endTime">The endTime in UTC format.  This value is only used in playback mode.  The
        /// playback video will stop when the endtime is reached.  This allows a progress bar.</param>
        private void StartStream(DateTime seekTime = default(DateTime), DateTime endTime = default(DateTime))
        {
            try
            {
                // Get the data sources for the selected device.
                var protocol = jpegPullToolStripMenuItem.Checked ? DataInterface.StreamProtocols.MjpegPull : DataInterface.StreamProtocols.RtspRtp;
                var showWindow = true;

                bool startingLiveStream = seekTime.Equals(default(DateTime));
                bool changingDataSource = Control.States.VideoDataSource == null || SelectedDataSource.Id != Control.States.VideoDataSource.Id;

                StopStream();

                if (Control.States.MediaController != null)
                {
                    if (Control.States.MediaController.Mode == MediaControl.Modes.Live && nudSpeed.Value < 0 && startingLiveStream)
                    {
                        WriteToLog("Warning: Reverse playback from live not supported.\n");
                        return;
                    }
                    showWindow = Control.States.MediaController.Mode == MediaControl.Modes.Stopped;
                }

                var dataInterface = SelectDataInterface(protocol, SelectedDataSource, showWindow, rtspTcpToolStripMenuItem.Checked, seekTime);
                if (dataInterface == null)
                {
                    WriteToLog("Error: No data interface found for selected camera and/or the seek time requested.\n");
                    return;
                }

                DataSource audioDataSource;
                DataInterface audioDataInterface;
                var audioLink = SelectedDataSource.LinkedAudioRelation;
                if (audioLink != null)
                {
                    audioDataSource = audioLink.Resource;
                    audioDataInterface = SelectDataInterface(DataInterface.StreamProtocols.RtspRtp, audioDataSource, false, rtspTcpToolStripMenuItem.Checked, default(DateTime));
                }
                else
                    SelectAudioData(SelectedDataSource, showWindow, out audioDataSource, out audioDataInterface, rtspTcpToolStripMenuItem.Checked);

                // If the audioDataInterface is null, you cannot play audio
                if (audioDataInterface == null)
                {
                    audioDataSource = null;
                }

                // If the media controller exists then a stream is running and the user is
                // requesting a new action on it.  If it's null then this is either the
                // first run or an existing stream has been stopped.  So a new media controller
                // instance is needed.
                if (Control.States.MediaController == null)
                {
                    Control.States.MediaController = new MediaControl(SelectedDataSource, dataInterface, audioDataSource, audioDataInterface);
                    Control.SubscribeToTimestamps();
                    Control.SubscribeToStreamEvents();
                    Control.States.MediaController.SetVideoWindow(Control.States.StreamPanel.Handle);
                    Control.States.MediaController.AspectRatio = Control.States.AspectRatio;
                    Control.States.MediaController.StretchToFit = Control.States.StretchToFit;
                }
                else
                {
                    // If a new device has been selected while another stream is running, stop the
                    // old stream and set up the new stream using the new data source.
                    if (changingDataSource)
                    {
                        Control.States.MediaController.Stop();
                        Control.States.MediaController.SetDataSource(SelectedDataSource, dataInterface, audioDataSource, audioDataInterface);
                    }
                }

                // Getting the clip informatoin is necessary to skip gaps on playback, but is not something
                //   we want to do in the timestamp callback as it takes too long.  So, cache the clip information
                //   before starting the video
                Control.States.CachedClips = SelectedDataSource.Clips;
                Control.States.SkipPlayback = skipGapsToolStripMenuItem.Checked;
                // Print the clips as info
                for (int i = 0; i < Control.States.CachedClips.Count; i++)
                {
                    WriteToLog("Info:  Clip Number " + i + " Start:  " + Control.States.CachedClips[i].StartTime.ToLocalTime() + "  End:  " + Control.States.CachedClips[i].EndTime.ToLocalTime());
                }

                Control.RemovePlaybackProgress();
                var transport = (rtspTcpToolStripMenuItem.Checked == true) ? MediaControl.RTSPNetworkTransports.RTPOverRTSP : MediaControl.RTSPNetworkTransports.UDP;

                var dataStorage = SelectedDataSource.AllDataStorages.FirstOrDefault(ds => ds.Type != DataStorage.DataStorageTypes.Edge && ds.Type != DataStorage.DataStorageTypes.Unknown);
                string recorder = "None";
                if (dataStorage != null)
                    recorder = dataStorage.Name;

                // Add date time stamp.
                //   See https://en.cppreference.com/w/cpp/io/manip/put_time
                string overlayString = "  %Y-%m-%d %H:%M:%S\n";
                overlayString += $"Camera: {SelectedDataSource.Name}\n";
                overlayString += $"Recorder: {recorder}";
                Control.States.MediaController.AddVideoOverlayData(overlayString, MediaControl.VideoOverlayDataPositions.BottomLeft, true);

                if (startingLiveStream)
                {
                    if (!Control.States.MediaController.Play((float)nudSpeed.Value, transport))
                    {
                        WriteToLog(
                            $"Error: Unable to {(Control.States.MediaController.Mode == MediaControl.Modes.Playback ? "resume" : "start")} stream.\n");
                        if (Control.States.MediaController.IsPipelineActive)
                        {
                            StopStream();
                            return;
                        }

                        Control.States.MediaController.Dispose();
                        Control.States.MediaController = null;
                        Control.States.StreamPanel.Refresh();
                        return;
                    }
                }
                else
                {
                    // In playback, we force TCP since it's the better protocol for the job
                    transport = MediaControl.RTSPNetworkTransports.RTPOverRTSP;

                    // In this case, demonstrate how to get the storage information for the clip
                    foreach (Clip clip in Control.States.CachedClips)
                    {
                        if ((seekTime >= clip.StartTime) && (seekTime < clip.EndTime))
                        {
                            overlayString += $"\nStorage ID: {clip.DataStorageId}";
                            break;
                        }
                    }
                    Control.States.MediaController.AddVideoOverlayData(overlayString, MediaControl.VideoOverlayDataPositions.BottomLeft, true);

                    Control.EnablePlaybackProgress(seekTime, endTime);
                    TimeSpan ts = (seekTime - new DateTime(1970, 1, 1, 0, 0, 0));
                    double timePassedIn = ts.TotalSeconds;
                    if (!Control.States.MediaController.Seek(seekTime, (float)nudSpeed.Value, transport))
                    {
                        WriteToLog("Error: Unable to start recorded stream.\n");
                        if (Control.States.MediaController.IsPipelineActive)
                        {
                            StopStream();
                            return;
                        }

                        Control.States.TimestampLabel.Text = string.Empty;
                        Control.States.MediaController.Dispose();
                        Control.States.MediaController = null;
                        Control.States.StreamPanel.Refresh();
                        return;
                    }
                }

                Control.States.PlayingIndex = dgvDataSources.SelectedRows[0].Index;
                SetupPtzControls(SelectedDataSource);
                Control.States.VideoDataSource = SelectedDataSource;
                Control.States.VideoDataInterface = dataInterface;
                Control.States.Transport = transport;
                Control.States.AudioDataSource = audioDataSource;
                Control.States.AudioDataInterface = audioDataInterface;
                SetManualRecordingStatus();
            }
            catch (Exception ex)
            {
                WriteToLog($@"Error: {ex.Message}\n");
            }
        }

        /// <summary>
        /// The StopAllStreams method.
        /// </summary>
        private void StopAllStreams()
        {
            try
            {
                var selControl = Control.SelectedControl;
                Control.SelectControl(ControlManager.Controls.Left);
                StopStream();
                Control.SelectControl(ControlManager.Controls.Right);
                StopStream();
                Control.SelectControl(selControl);
            }
            catch (Exception ex)
            {
                WriteToLog($@"Error: {ex.Message}\n");
            }
        }

        private void txbxLog_TextChanged(object sender, EventArgs e)
        { }

        private void UpdateSelectedAspectRatio()
        {
            ratio16x9ToolStripMenuItem.Checked = Control.States.AspectRatio == MediaControl.AspectRatios.k16x9;
            ratio4x3ToolStripMenuItem.Checked = Control.States.AspectRatio == MediaControl.AspectRatios.k4x3;
            ratio1x1ToolStripMenuItem.Checked = Control.States.AspectRatio == MediaControl.AspectRatios.k1x1;
            ratio3x2ToolStripMenuItem.Checked = Control.States.AspectRatio == MediaControl.AspectRatios.k3x2;
            ratio5x4ToolStripMenuItem.Checked = Control.States.AspectRatio == MediaControl.AspectRatios.k5x4;
        }

        #endregion Private Methods
    }
}