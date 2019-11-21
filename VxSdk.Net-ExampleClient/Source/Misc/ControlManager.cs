using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The ControlManager class.
    /// </summary>
    /// <remarks>Manages the UI controls based on the selected video panel.</remarks>
    public class ControlManager
    {
        #region Public Delegates

        public delegate void SeekSkipGapDelegate(MediaControl mediaControl, System.DateTime startTime, float speed, MediaControl.RTSPNetworkTransports transport);

        #endregion Public Delegates

        #region Private Fields

        private static readonly object _instanceLock = new object();

        /// <summary>
        /// Gets the Instance property.
        /// </summary>
        /// <value>The current <see cref="ControlManager"/> instance.</value>
        private static ControlManager _instance;

        private States _statesLeft = new States(true);

        private States _statesRight = new States(false);

        #endregion Private Fields

        #region Private Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ControlManager" /> class.
        /// </summary>
        private ControlManager()
        {
            Task.Run(new Action(Init));
        }

        #endregion Private Constructors

        #region Public Enums

        /// <summary>
        /// The Controls enumeration.
        /// </summary>
        /// <remarks>The left or right control.</remarks>
        public enum Controls
        {
            /// <summary>The left control.</summary>
            Left,

            /// <summary>The right control.</summary>
            Right
        }

        public enum VcrMode
        {
            Unknown,
            Stopped,
            Paused,
            Live,
            Playback
        }

        #endregion Public Enums

        #region Public Properties

        public static ControlManager Instance
        {
            get
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                        _instance = new ControlManager();
                    return _instance;
                }
            }
        }

        /// <summary>
        /// Gets or sets the SelectedControl property.
        /// </summary>
        /// <value>A <see cref="Controls"/>.</value>
        public Controls SelectedControl { get; set; }

        public States States
        {
            get => SelectedControl == Controls.Left ? _statesLeft : _statesRight;
            set
            {
                if (SelectedControl == Controls.Left)
                    _statesLeft = value;
                else
                    _statesRight = value;
            }
        }

        #endregion Public Properties

        #region Public Methods

        public void SetVcrStates(VcrMode vcrState)
        {
            _statesLeft.VcrState = vcrState;
            _statesRight.VcrState = vcrState;
        }

        public static void SeekSkipGapMethod(MediaControl mediaControl, System.DateTime startTime, float speed, MediaControl.RTSPNetworkTransports transport)
        {
            mediaControl.Stop();
            MainForm.Instance.WriteToLog("Info:  Skipping Gap.  Next Seek Time:  " + startTime.ToLocalTime().ToString());
            mediaControl.Seek(startTime.AddSeconds(1), speed, transport);
        }

        /// <summary>
        /// The ChangePtzFormState method.
        /// </summary>
        /// <param name="enabled">The state to set the <c>PTZControlForm</c> controls.</param>
        public void ChangePtzFormState(bool enabled)
        {
            var isEnabled = enabled;
            if (States.MediaController != null && States.MediaController.Mode != MediaControl.Modes.Live)
                isEnabled = false;

            foreach (Control control in PtzControlForm.Instance.Controls)
                control.Enabled = isEnabled;

            PtzControlForm.GetPatterns();
            PtzControlForm.GetPresets();
        }

        public bool EnablePlaybackProgress(System.DateTime startTime, System.DateTime endTime)
        {
            States.StartTime = startTime;
            States.EndTime = endTime;
            States.ProgressBar.Enabled = true;
            States.ProgressBar.Visible = true;
            States.ProgressBar.Value = 0;

            return true;
        }

        public bool RemovePlaybackProgress()
        {
            States.ProgressBar.Visible = false;
            return true;
        }

        public void RestartStream(Controls control)
        {
            States state = control == Controls.Left ? _statesLeft : _statesRight;
            if (state.VcrState != VcrMode.Live)
            {
                var selControl = SelectedControl;
                SelectControl(control);
                MainForm.Instance.BeginInvoke((MethodInvoker)delegate { MainForm.Instance.StopStream(); });
                SelectControl(selControl);
                return;
            }

            state.IsReconnecting = true;
            MainForm.Instance.BeginInvoke((MethodInvoker)delegate { state.StreamPanel.Refresh(); });
            MainForm.Instance.BeginInvoke((MethodInvoker)delegate { state.VideoLossLabel.Visible = true; });

            var retryCount = 0;
            while (state.IsReconnecting)
            {
                try
                {
                    retryCount += 1;
                    MainForm.Instance.BeginInvoke((MethodInvoker)delegate { state.VideoLossLabel.Text = $"Stream Connection Lost: Attempting to reconnect... (attempt #{retryCount})"; });
                    state.MediaController.Stop();
                    state.MediaController.SetDataSource(state.VideoDataSource, state.VideoDataInterface, state.AudioDataSource, state.AudioDataInterface);
                    state.IsReconnecting = !state.MediaController.Play(1.0f, state.Transport);
                    if (!state.IsReconnecting)
                        continue;

                    var counter = 0;
                    while (counter < 10)
                    {
                        counter += 1;
                        if (!state.IsReconnecting) continue;
                        Thread.Sleep(1000);
                    }
                }
                catch (Exception ex)
                {
                    MainForm.Instance.BeginInvoke((MethodInvoker)delegate { MainForm.Instance.WriteToLog($@"Error: {ex.Message}\n"); });
                }
            }

            MainForm.Instance.BeginInvoke((MethodInvoker)delegate { state.VideoLossLabel.Visible = false; });
        }

        /// <summary>
        /// The SelectControl method.
        /// </summary>
        /// <param name="control">The <paramref name="control"/> to select.</param>
        public void SelectControl(Controls control)
        {
            if (control == Controls.Left)
            {
                SelectedControl = Controls.Left;
                MainForm.Instance.scVideoPanels.Panel1.BackColor = Color.FromArgb(0, 125, 197);
                MainForm.Instance.scVideoPanels.Panel2.BackColor = SystemColors.ControlDark;
                ChangePtzFormState(States.PtzControl != null);
                if (MainForm.Instance.dgvDataSources.RowCount > 0)
                    MainForm.Instance.dgvDataSources.Rows[States.PlayingIndex].Selected = true;
            }
            else
            {
                SelectedControl = Controls.Right;
                MainForm.Instance.scVideoPanels.Panel1.BackColor = SystemColors.ControlDark;
                MainForm.Instance.scVideoPanels.Panel2.BackColor = Color.FromArgb(0, 125, 197);
                ChangePtzFormState(States.PtzControl != null);
                if (MainForm.Instance.dgvDataSources.RowCount > 0)
                    MainForm.Instance.dgvDataSources.Rows[States.PlayingIndex].Selected = true;
            }
        }

        /// <summary>
        /// The SubscribeToStreamEvents method.
        /// </summary>
        public void SubscribeToStreamEvents()
        {
            if (SelectedControl == Controls.Left)
                States.MediaController.StreamEvent += OnStreamEventLeft;
            else
                States.MediaController.StreamEvent += OnStreamEventRight;
        }

        /// <summary>
        /// The SubscribeToTimestamps method.
        /// </summary>
        public void SubscribeToTimestamps()
        {
            if (SelectedControl == Controls.Left)
                States.MediaController.TimestampEvent += OnTimestampEventLeft;
            else
                States.MediaController.TimestampEvent += OnTimestampEventRight;
        }

        /// <summary>
        /// The UnsubscribeToStreamEvents method.
        /// </summary>
        public void UnsubscribeToStreamEvents()
        {
            if (SelectedControl == Controls.Left)
                States.MediaController.StreamEvent -= OnStreamEventLeft;
            else
                States.MediaController.StreamEvent -= OnStreamEventRight;
        }

        /// <summary>
        /// The UnsubscribeToTimestamps method.
        /// </summary>
        public void UnsubscribeToTimestamps()
        {
            if (SelectedControl == Controls.Left)
                States.MediaController.TimestampEvent -= OnTimestampEventLeft;
            else
                States.MediaController.TimestampEvent -= OnTimestampEventRight;
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// The OnStreamEventLeft method.
        /// </summary>
        /// <param name="streamEvent">The <paramref name="streamEvent"/> parameter.</param>
        private static void OnStreamEventLeft(StreamingEvent streamEvent)
        {
            MainForm.Instance.BeginInvoke((MethodInvoker)delegate
            {
                MainForm.Instance.WriteToLog("Stream Connection Lost.");
                Task.Run(() => Instance.RestartStream(Controls.Left));
            });
        }

        /// <summary>
        /// The OnStreamEventRight method.
        /// </summary>
        /// <param name="streamEvent">The <paramref name="streamEvent"/> parameter.</param>
        private static void OnStreamEventRight(StreamingEvent streamEvent)
        {
            MainForm.Instance.BeginInvoke((MethodInvoker)delegate
            {
                MainForm.Instance.WriteToLog("Stream Connection Lost.");
                Task.Run(() => Instance.RestartStream(Controls.Right));
            });
        }

        private static void OnTimestampEventLeft(MediaEvent timeEvent)
        {
            // Note that the timestamp is in UTC by default, so you must convert it to local time
            // if that is the format required.
            var timestamp = timeEvent.Timestamp.ToLocalTime().ToString("s");
            MainForm.Instance.lblTimestampLeft.BeginInvoke((MethodInvoker)delegate
            {
                MainForm.Instance.lblTimestampLeft.Text = timestamp;
            });

            var ticksIn = timeEvent.Timestamp.Ticks;
            if (Instance._statesLeft.MediaController.Mode == MediaControl.Modes.Playback)
            {
                if (timeEvent.Timestamp.Ticks >= Instance._statesLeft.EndTime.Ticks)
                {
                    // We are done - so Pause and show progress at 100%
                    MainForm.Instance.progressBar_left.BeginInvoke((MethodInvoker)delegate
                    {
                        MainForm.Instance.progressBar_left.Value = 1000;
                    });
                    Instance._statesLeft.MediaController.Pause();
                    return;
                }
                MainForm.Instance.progressBar_left.BeginInvoke((MethodInvoker)delegate
                {
                    if (ticksIn < Instance._statesLeft.StartTime.Ticks)
                    {
                        ticksIn = Instance._statesLeft.StartTime.Ticks;
                    }
                    double ticksDone = (double)ticksIn - Instance._statesLeft.StartTime.Ticks;
                    ticksDone /= (Instance._statesLeft.EndTime.Ticks - Instance._statesLeft.StartTime.Ticks);
                    MainForm.Instance.progressBar_left.Value = (int)(ticksDone * 1000);
                });
            }
            // Skip a gap if necessary
            if ((Instance.States.SkipPlayback == true) && (Instance._statesLeft.MediaController.Mode == MediaControl.Modes.Playback) && (Instance._statesLeft.JustJumpedTime.AddSeconds(1) < timeEvent.Timestamp))
            {
                // Are we in a gap? - If so seek to the next play time
                // clips are ordered from oldest to newest
                var clips = Instance._statesLeft.CachedClips;
                int i = 0;
                for (; i < clips.Count; i++)
                {
                    var clip = clips[i];
                    // Which direction?
                    decimal currentSpeed = 1;
                    MainForm.Instance.nudSpeed.BeginInvoke((MethodInvoker)delegate { currentSpeed = MainForm.Instance.nudSpeed.Value; });
                    if (currentSpeed > 0)
                    {
                        if (timeEvent.Timestamp.AddSeconds(2) >= clip.EndTime)
                        {
                            // Look at the next Timestamp
                            if (i == (clips.Count - 1)) { break; } // This should not happen
                            if (timeEvent.Timestamp.AddSeconds(3) < clips[i + 1].StartTime)
                            {
                                // In a gap - seek to the start time of the next clip
                                var transport = (MainForm.Instance.rtspTcpToolStripMenuItem.Checked == true) ? MediaControl.RTSPNetworkTransports.RTPOverRTSP : MediaControl.RTSPNetworkTransports.UDP;
                                System.DateTime startTime = clips[i + 1].StartTime;
                                float speed = (float)MainForm.Instance.nudSpeed.Value;
                                object[] invokeArray = new object[4];
                                invokeArray[0] = Instance._statesLeft.MediaController;
                                invokeArray[1] = startTime;
                                invokeArray[2] = speed;
                                invokeArray[3] = transport;
                                Instance._statesLeft.JustJumpedTime = timeEvent.Timestamp;
                                MainForm.Instance.BeginInvoke(new SeekSkipGapDelegate(SeekSkipGapMethod), invokeArray);
                                break;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// The OnTimestampEventRight method.
        /// </summary>
        /// <param name="timeEvent">The <paramref name="timeEvent"/> parameter.</param>
        private static void OnTimestampEventRight(MediaEvent timeEvent)
        {
            // Note that the timestamp is in UTC by default, so you must convert it to local time
            // if that is the format required.
            var timestamp = timeEvent.Timestamp.ToLocalTime().ToString("s");
            MainForm.Instance.lblTimestampRight.BeginInvoke((MethodInvoker)delegate
            {
                MainForm.Instance.lblTimestampRight.Text = timestamp;
            });

            var ticksIn = timeEvent.Timestamp.Ticks;
            if (Instance._statesRight.MediaController.Mode == MediaControl.Modes.Playback)
            {
                if (timeEvent.Timestamp.Ticks >= Instance._statesRight.EndTime.Ticks)
                {
                    // We are done - so Pause and show progress at 100%
                    MainForm.Instance.progressBar_right.BeginInvoke((MethodInvoker)delegate
                    {
                        MainForm.Instance.progressBar_right.Value = 1000;
                    });
                    Instance._statesRight.MediaController.Pause();
                    return;
                }
                MainForm.Instance.progressBar_right.BeginInvoke((MethodInvoker)delegate
                {
                    if (ticksIn < Instance._statesRight.StartTime.Ticks)
                    {
                        ticksIn = Instance._statesRight.StartTime.Ticks;
                    }
                    double ticksDone = (double)ticksIn - Instance._statesRight.StartTime.Ticks;
                    ticksDone /= (Instance._statesRight.EndTime.Ticks - Instance._statesRight.StartTime.Ticks);
                    MainForm.Instance.progressBar_right.Value = (int)(ticksDone * 1000);
                });
            }

            // Skip a gap if necessary
            if ((Instance.States.SkipPlayback == true) && (Instance._statesRight.MediaController.Mode == MediaControl.Modes.Playback) && (Instance._statesRight.JustJumpedTime.AddSeconds(1) < timeEvent.Timestamp))
            {
                // Are we in a gap? - If so seek to the next play time
                // clips are ordered from oldest to newest
                var clips = Instance._statesRight.CachedClips;
                int i = 0;
                for (; i < clips.Count; i++)
                {
                    var clip = clips[i];
                    // Which direction?
                    if (MainForm.Instance.nudSpeed.Value > 0)
                    {
                        if (timeEvent.Timestamp.AddSeconds(1) >= clip.EndTime)
                        {
                            // Look at the next Timestamp
                            if (i == (clips.Count - 1)) { break; } // This should not happen
                            if (timeEvent.Timestamp.AddSeconds(2) < clips[i + 1].StartTime)
                            {
                                // In a gap - seek to the start time of the next clip
                                var transport = (MainForm.Instance.rtspTcpToolStripMenuItem.Checked == true) ? MediaControl.RTSPNetworkTransports.RTPOverRTSP : MediaControl.RTSPNetworkTransports.UDP;
                                System.DateTime startTime = clips[i + 1].StartTime;
                                float speed = (float)MainForm.Instance.nudSpeed.Value;
                                object[] invokeArray = new object[4];
                                invokeArray[0] = Instance._statesRight.MediaController;
                                invokeArray[1] = startTime;
                                invokeArray[2] = speed;
                                invokeArray[3] = transport;
                                Instance._statesRight.JustJumpedTime = timeEvent.Timestamp;
                                MainForm.Instance.BeginInvoke(new SeekSkipGapDelegate(SeekSkipGapMethod), invokeArray);
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void Init()
        {
            SelectControl(Controls.Left);
        }

        #endregion Private Methods
    }

    /// <summary>
    /// The States class.
    /// </summary>
    /// <remarks>Holds the various states for a control.</remarks>
    public class States
    {
        #region Private Fields

        private List<Clip> _cachedClips = new List<Clip>();

        #endregion Private Fields

        #region Public Constructors

        public States(bool isLeft)
        {
            IsLeft = isLeft;
        }

        #endregion Public Constructors

        #region Public Properties

        public MediaControl.AspectRatios AspectRatio { get; set; }
        public DataInterface AudioDataInterface { get; set; }
        public DataSource AudioDataSource { get; set; }

        public List<Clip> CachedClips
        {
            get => _cachedClips;
            set
            {
                _cachedClips = value;
                JustJumpedTime = new DateTime(1970, 1, 1);
            }
        }

        public DateTime EndTime { get; set; }
        public bool IsLeft { get; set; }
        public bool IsReconnecting { set; get; }
        public DateTime JustJumpedTime { get; set; }
        public ManualRecording ManualRecording { get; set; }
        public MediaControl MediaController { get; set; }
        public int PlayingIndex { get; set; }
        public ProgressBar ProgressBar => IsLeft ? MainForm.Instance.progressBar_left : MainForm.Instance.progressBar_right;
        public PtzController PtzControl { get; set; }
        public bool SkipPlayback { get; set; }
        public DateTime StartTime { get; set; }
        public Panel StreamPanel => IsLeft ? MainForm.Instance.panelVideoStreamLeft : MainForm.Instance.panelVideoStreamRight;
        public bool StretchToFit { get; set; }
        public Label TimestampLabel => IsLeft ? MainForm.Instance.lblTimestampLeft : MainForm.Instance.lblTimestampRight;
        public MediaControl.RTSPNetworkTransports Transport { get; set; }
        public ControlManager.VcrMode VcrState { get; set; }
        public DataInterface VideoDataInterface { get; set; }
        public DataSource VideoDataSource { get; set; }
        public Label VideoLossLabel => IsLeft ? MainForm.Instance.lblStreamLossLeft : MainForm.Instance.lblStreamLossRight;

        #endregion Public Properties
    }
}