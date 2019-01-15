﻿using System.Drawing;
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
        public ControlManager()
        {
            Instance = this;
            SelectControl(Controls.Left);
        }

        /// <summary>
        /// Gets the Instance property.
        /// </summary>
        /// <value>The current <see cref="ControlManager"/> instance.</value>
        public static ControlManager Instance { get; private set; }

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

            if (Current != null) 
                MainForm.Instance.btnLive.Enabled = Current.Mode == MediaControl.Modes.Playback;
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
        private static void OnTimestampEventLeft(MediaEvent timeEvent)
        {
            // Note that the timestamp is in UTC by default, so you must convert it to local time
            // if that is the format required.
            var timestamp = timeEvent.Timestamp.ToLocalTime().ToString("s");
            MainForm.Instance.lblTimestampLeft.BeginInvoke((MethodInvoker)delegate
            {
                MainForm.Instance.lblTimestampLeft.Text = timestamp;
            });
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
    }
}
