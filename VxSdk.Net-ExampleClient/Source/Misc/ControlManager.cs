using System.Collections.Generic;
using System.Drawing;
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
        public enum VcrMode
        {
            Unknown,
            Stopped,
            Paused,
            Live,
            Playback
        }

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

        /// <summary>
        /// Initializes a new instance of the <see cref="ControlManager" /> class.
        /// </summary>
        private ControlManager()
        {
            _skipRecordingGaps = false;
            Task.Run(Init);
        }

        private void Init()
        {
            SelectControl(Controls.Left);
        }

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
        /// Gets the Instance property.
        /// </summary>
        /// <value>The current <see cref="ControlManager"/> instance.</value>
        private static ControlManager _instance;

        private static readonly object _instanceLock = new object();

        public bool SkipPlayback
        {
            get { return _skipRecordingGaps; }
            set { _skipRecordingGaps = value; }
        }

        public List<Clip> CachedClips
        {
            set
            {
                if (SelectedControl == Controls.Left)
                {
                    _cachedClipsLeft = value;
                    _justJumpedLeftTime = new System.DateTime(1970, 1, 1);
                }
                else
                {
                    _cachedClipsRight = value;
                    _justJumpedRightTime = new System.DateTime(1970, 1, 1);
                }
            }
            get
            {
                if (SelectedControl == Controls.Left)
                {
                    return _cachedClipsLeft;
                }
                else
                {
                    return _cachedClipsRight;
                }
            }
        }

        public bool EnablePlaybackProgress(System.DateTime startTime, System.DateTime endTime)
        {
            // Note:  Progress bars will go from 1 to 1000 - need to scale
            if (SelectedControl == Controls.Left)
            {
                _startTimeLeft = startTime;
                _endTimeLeft = endTime;
                MainForm.Instance.progressBar_left.Enabled = true;
                MainForm.Instance.progressBar_left.Visible = true;
                MainForm.Instance.progressBar_left.Value = 0;
            }
            else
            {
                _startTimeRight = startTime;
                _endTimeRight = endTime;
                MainForm.Instance.progressBar_right.Enabled = true;
                MainForm.Instance.progressBar_right.Visible = true;
                MainForm.Instance.progressBar_left.Value = 0;
            }
            return true;
        }

        public bool RemovePlaybackProgress()
        {
            if (SelectedControl == Controls.Left)
            {
                MainForm.Instance.progressBar_left.Visible = false;
            }
            else
            {
                MainForm.Instance.progressBar_right.Visible = false;
            }
            return true;
        }


        /// <summary>
        /// Gets or sets the SelectedControl property.
        /// </summary>
        /// <value>A <see cref="Controls"/>.</value>
        public Controls SelectedControl { get; set; }

        /// <summary>
        /// The SubscribeToTimestamps method.
        /// </summary>
        public void SubscribeToTimestamps()
        {
            if (SelectedControl == Controls.Left)
                Current.TimestampEvent += OnTimestampEventLeft;
            else
                Current.TimestampEvent += OnTimestampEventRight;
        }

        /// <summary>
        /// The UnsubscribeToTimestamps method.
        /// </summary>
        public void UnsubscribeToTimestamps()
        {
            if (SelectedControl == Controls.Left)
                Current.TimestampEvent -= OnTimestampEventLeft;
            else
                Current.TimestampEvent -= OnTimestampEventRight;
        }

        /// <summary>
        /// The SubscribeToStreamEvents method.
        /// </summary>
        public void SubscribeToStreamEvents()
        {
            if (SelectedControl == Controls.Left)
                Current.StreamEvent += OnStreamEventLeft;
            else
                Current.StreamEvent += OnStreamEventRight;
        }

        /// <summary>
        /// The UnsubscribeToStreamEvents method.
        /// </summary>
        public void UnsubscribeToStreamEvents()
        {
            if (SelectedControl == Controls.Left)
                Current.StreamEvent -= OnStreamEventLeft;
            else
                Current.StreamEvent -= OnStreamEventRight;
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
                ChangePtzFormState(PtzControl != null);
                if (MainForm.Instance.dgvDataSources.RowCount > 0)
                    MainForm.Instance.dgvDataSources.Rows[_playingIndexLeft].Selected = true;
            }
            else
            {
                SelectedControl = Controls.Right;
                MainForm.Instance.scVideoPanels.Panel1.BackColor = SystemColors.ControlDark;
                MainForm.Instance.scVideoPanels.Panel2.BackColor = Color.FromArgb(0, 125, 197);
                ChangePtzFormState(PtzControl != null);
                if (MainForm.Instance.dgvDataSources.RowCount > 0)
                    MainForm.Instance.dgvDataSources.Rows[_playingIndexRight].Selected = true;
            }
        }

        /// <summary>
        /// The ChangePtzFormState method.
        /// </summary>
        /// <param name="enabled">The state to set the <c>PTZControlForm</c> controls.</param>
        public void ChangePtzFormState(bool enabled)
        {
            var isEnabled = enabled;
            if (Current != null && Current.Mode != MediaControl.Modes.Live)
                isEnabled = false;

            foreach (Control control in PtzControlForm.Instance.Controls)
                control.Enabled = isEnabled;

            PtzControlForm.GetPatterns();
            PtzControlForm.GetPresets();
        }

        /// <summary>
        /// The SetPlayingIndex method.
        /// </summary>
        public void SetPlayingIndex()
        {
            if (SelectedControl == Controls.Left)
                _playingIndexLeft = MainForm.Instance.dgvDataSources.SelectedRows[0].Index;
            else
                _playingIndexRight = MainForm.Instance.dgvDataSources.SelectedRows[0].Index;
        }

        /// <summary>
        /// Gets or sets the Current property.
        /// </summary>
        /// <value>A <see cref="MediaControl"/>.</value>
        public MediaControl Current
        {
            get
            {
                return SelectedControl == Controls.Left ? _mediaControllerLeft : _mediaControllerRight;
            }

            set
            {
                if (SelectedControl == Controls.Left)
                    _mediaControllerLeft = value;
                else
                    _mediaControllerRight = value;
            }
        }

        /// <summary>
        /// Gets or sets the CurrentDataSource property.
        /// </summary>
        /// <value>A <see cref="DataSource"/>.</value>
        public DataSource CurrentDataSource
        {
            get
            {
                return SelectedControl == Controls.Left ? _dataSourceLeft : _dataSourceRight;
            }

            set
            {
                if (SelectedControl == Controls.Left)
                    _dataSourceLeft = value;
                else
                    _dataSourceRight = value;
            }
        }

        /// <summary>
        /// Gets or sets the CurrentManualRecording property.
        /// </summary>
        /// <value>A <see cref="ManualRecording"/>.</value>
        public ManualRecording CurrentManualRecording
        {
            get
            {
                return SelectedControl == Controls.Left ? _manualRecordingLeft : _manualRecordingRight;
            }

            set
            {
                if (SelectedControl == Controls.Left)
                    _manualRecordingLeft = value;
                else
                    _manualRecordingRight = value;
            }
        }

        /// <summary>
        /// Gets or sets the PtzControl property.
        /// </summary>
        /// <value>A <see cref="PtzController"/>.</value>
        public PtzController PtzControl
        {
            get
            {
                return SelectedControl == Controls.Left ? _ptzCtrlLeft : _ptzCtrlRight;
            }

            set
            {
                if (SelectedControl == Controls.Left)
                    _ptzCtrlLeft = value;
                else
                    _ptzCtrlRight = value;
            }
        }

        /// <summary>
        /// Gets the SelectedPanel property.
        /// </summary>
        /// <value>The selected <see cref="Panel"/>.</value>
        public Panel SelectedPanel => SelectedControl == Controls.Left ?
            MainForm.Instance.panelVideoStreamLeft : MainForm.Instance.panelVideoStreamRight;

        /// <summary>
        /// Gets the SelectedPanelTime property.
        /// </summary>
        /// <value>The current time of the selected <see cref="Panel"/>.</value>
        public string SelectedPanelTime => SelectedControl == Controls.Left ?
            MainForm.Instance.lblTimestampLeft.Text : MainForm.Instance.lblTimestampRight.Text;

        /// <summary>
        /// Gets the SelectedLabel property.
        /// </summary>
        /// <value>The selected <see cref="Label"/>.</value>
        public Label SelectedLabel => SelectedControl == Controls.Left ?
            MainForm.Instance.lblTimestampLeft : MainForm.Instance.lblTimestampRight;

        /// <summary>
        /// The OnTimestampEventLeft method.
        /// </summary>
        /// <param name="timeEvent">The <paramref name="timeEvent"/> parameter.</param>
        /// 
        // For some synching
        static System.DateTime _justJumpedLeftTime;
        static System.DateTime _justJumpedRightTime;

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
            if (Instance._mediaControllerLeft.Mode == MediaControl.Modes.Playback)
            {
                if (timeEvent.Timestamp.Ticks >= Instance._endTimeLeft.Ticks)
                {
                    // We are done - so Pause and show progress at 100%
                    MainForm.Instance.progressBar_left.BeginInvoke((MethodInvoker)delegate
                    {
                        MainForm.Instance.progressBar_left.Value = 1000;
                    });
                    Instance._mediaControllerLeft.Pause();
                    return;
                }
                MainForm.Instance.progressBar_left.BeginInvoke((MethodInvoker)delegate
                {
                    if (ticksIn < Instance._startTimeLeft.Ticks)
                    {
                        ticksIn = Instance._startTimeLeft.Ticks;
                    }
                    double ticksDone = (double)ticksIn - Instance._startTimeLeft.Ticks;
                    ticksDone /= (Instance._endTimeLeft.Ticks - Instance._startTimeLeft.Ticks);
                    MainForm.Instance.progressBar_left.Value = (int)(ticksDone * 1000);
                });
            }
            // Skip a gap if necessary
            if ((Instance.SkipPlayback == true) && (Instance._mediaControllerLeft.Mode == MediaControl.Modes.Playback) && (_justJumpedLeftTime.AddSeconds(1) < timeEvent.Timestamp))
            {
                // Are we in a gap? - If so seek to the next play time
                // clips are ordered from oldest to newest
                var clips = Instance._cachedClipsLeft;
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
                                invokeArray[0] = Instance._mediaControllerLeft;
                                invokeArray[1] = startTime;
                                invokeArray[2] = speed;
                                invokeArray[3] = transport;
                                _justJumpedLeftTime = timeEvent.Timestamp;
                                MainForm.Instance.BeginInvoke(new SeekSkipGapDelegate(SeekSkipGapMethod), invokeArray);
                                break;
                            }
                        }
                    }
                }
            }
        }
        public delegate void SeekSkipGapDelegate(MediaControl mediaControl, System.DateTime startTime, float speed, MediaControl.RTSPNetworkTransports transport);

        public static void SeekSkipGapMethod(MediaControl mediaControl, System.DateTime startTime, float speed, MediaControl.RTSPNetworkTransports transport)
        {
            mediaControl.Stop();
            MainForm.Instance.WriteToLog("Info:  Skipping Gap.  Next Seek Time:  " + startTime.ToLocalTime().ToString());
            mediaControl.Seek(startTime.AddSeconds(1), speed, transport);
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
            if (Instance._mediaControllerRight.Mode == MediaControl.Modes.Playback)
            {
                if (timeEvent.Timestamp.Ticks >= Instance._endTimeRight.Ticks)
                {
                    // We are done - so Pause and show progress at 100%
                    MainForm.Instance.progressBar_right.BeginInvoke((MethodInvoker)delegate
                    {
                        MainForm.Instance.progressBar_right.Value = 1000;
                    });
                    Instance._mediaControllerRight.Pause();
                    return;
                }
                MainForm.Instance.progressBar_right.BeginInvoke((MethodInvoker)delegate
                {
                    if (ticksIn < Instance._startTimeRight.Ticks)
                    {
                        ticksIn = Instance._startTimeRight.Ticks;
                    }
                    double ticksDone = (double)ticksIn - Instance._startTimeRight.Ticks;
                    ticksDone /= (Instance._endTimeRight.Ticks - Instance._startTimeRight.Ticks);
                    MainForm.Instance.progressBar_right.Value = (int)(ticksDone * 1000);
                });
            }

            // Skip a gap if necessary
            if ((Instance.SkipPlayback == true) && (Instance._mediaControllerRight.Mode == MediaControl.Modes.Playback) && (_justJumpedRightTime.AddSeconds(1) < timeEvent.Timestamp))
            {
                // Are we in a gap? - If so seek to the next play time
                // clips are ordered from oldest to newest
                var clips = Instance._cachedClipsRight;
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
                                invokeArray[0] = Instance._mediaControllerRight;
                                invokeArray[1] = startTime;
                                invokeArray[2] = speed;
                                invokeArray[3] = transport;
                                _justJumpedRightTime = timeEvent.Timestamp;
                                MainForm.Instance.BeginInvoke(new SeekSkipGapDelegate(SeekSkipGapMethod), invokeArray);
                                break;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// The OnStreamEventLeft method.
        /// </summary>
        /// <param name="streamEvent">The <paramref name="streamEvent"/> parameter.</param>
        private static void OnStreamEventLeft(StreamingEvent streamEvent)
        {
            MainForm.Instance.BeginInvoke((MethodInvoker)delegate
            {
                MainForm.Instance.WriteToLog("Stream Connection Lost.");
                var currControl = MainForm.Instance.Control.SelectedControl;
                MainForm.Instance.Control.SelectControl(Controls.Left);
                MainForm.Instance.StopStream();
                MainForm.Instance.Control.SelectControl(currControl);
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
                var currControl = MainForm.Instance.Control.SelectedControl;
                MainForm.Instance.Control.SelectControl(Controls.Right);
                MainForm.Instance.StopStream();
                MainForm.Instance.Control.SelectControl(currControl);
            });
        }

        public VcrMode VcrState
        {
            get => SelectedControl == Controls.Left ? _vcrStateLeft : _vcrStateRight;
            set
            {
                if (SelectedControl == Controls.Left)
                    _vcrStateLeft = value;
                else
                    _vcrStateRight = value;
            }
        }

        private VcrMode _vcrStateLeft;
        private VcrMode _vcrStateRight;

        /// <summary>
        /// The _dataSourceLeft field.
        /// </summary>  
        private DataSource _dataSourceLeft;

        /// <summary>
        /// The _dataSourceRight field.
        /// </summary>  
        private DataSource _dataSourceRight;

        /// <summary>
        /// The _manualRecordingLeft field.
        /// </summary>  
        private ManualRecording _manualRecordingLeft;

        /// <summary>
        /// The _manualRecordingRight field.
        /// </summary>  
        private ManualRecording _manualRecordingRight;

        /// <summary>
        /// The _mediaControllerLeft field.
        /// </summary>  
        private MediaControl _mediaControllerLeft;

        /// <summary>
        /// The _mediaControllerRight field.
        /// </summary>  
        private MediaControl _mediaControllerRight;

        /// <summary>
        /// The _ptzCtrlLeft field.
        /// </summary>  
        private PtzController _ptzCtrlLeft;

        /// <summary>
        /// The _ptzCtrlRight field.
        /// </summary>  
        private PtzController _ptzCtrlRight;

        /// <summary>
        /// The _playingIndexLeft field.
        /// </summary>  
        private int _playingIndexLeft;

        /// <summary>
        /// The _playingIndexRight field.
        /// </summary>  
        private int _playingIndexRight;

        /// <summary>
        /// Used to determine if we should skip gaps on recorded video (during playback)
        /// </summary>
        private bool _skipRecordingGaps;

        /// <summary>
        /// Cache clips as getting them can take too long
        /// </summary>
        private List<Clip> _cachedClipsLeft;
        private List<Clip> _cachedClipsRight;

        private System.DateTime _startTimeLeft;
        private System.DateTime _startTimeRight;
        private System.DateTime _endTimeLeft;
        private System.DateTime _endTimeRight;
    }
}
