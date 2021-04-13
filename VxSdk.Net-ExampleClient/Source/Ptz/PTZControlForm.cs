using System;
using System.Linq;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The PTZControlForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that contains the PTZ controls for a
    /// device that has PTZ enabled.</remarks>
    public partial class PtzControlForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PtzControlForm" /> class.
        /// </summary>
        public PtzControlForm()
        {
            InitializeComponent();
            Instance = this;
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// Gets the Instance property.
        /// </summary>
        /// <value>The current <see cref="PtzControlForm"/> instance.</value>
        public static PtzControlForm Instance { get; private set; }

        /// <summary>
        /// Gets the <see cref="VxSdkNet.PtzLock" />.
        /// </summary>
        /// <value>The associated <see cref="VxSdkNet.PtzLock"/>.</value>
        public static PtzLock PtzLock => ControlManager.Instance.States.PtzControl?.PTZLock;

        #endregion Public Properties

        #region Public Methods

        /// <summary>
        /// The GetPatterns method.
        /// </summary>
        /// <remarks>Gets all of the patterns from the VideoXpert system for the selected
        /// device and adds them to the patterns combo box.</remarks>
        public static void GetPatterns()
        {
            if (Instance.cbxPatterns.Items.Count > 0)
            {
                Instance.cbxPatterns.DataSource = null;
                Instance.cbxPatterns.Items.Clear();
            }

            if (ControlManager.Instance.States.PtzControl == null)
                return;

            var patterns = ControlManager.Instance.States.PtzControl.Patterns.Select(pattern =>
                new { Id = pattern, Text = pattern.Name }).ToList();
            Instance.cbxPatterns.ValueMember = "Id";
            Instance.cbxPatterns.DisplayMember = "Text";
            Instance.cbxPatterns.DataSource = patterns;
        }

        /// <summary>
        /// The GetPresets method.
        /// </summary>
        /// <remarks>Gets all of the presets from the VideoXpert system for the selected
        /// device and adds them to the presets combo box.</remarks>
        public static void GetPresets()
        {
            if (Instance.cbxPresets.Items.Count > 0)
            {
                Instance.cbxPresets.DataSource = null;
                Instance.cbxPresets.Items.Clear();
            }

            if (ControlManager.Instance.States.PtzControl == null)
                return;

            var presets = ControlManager.Instance.States.PtzControl.Presets.Select(preset =>
                new { Id = preset, Text = preset.Index == 0 ? preset.Name : preset.Index.ToString() + " - " + preset.Name }).ToList();
            Instance.cbxPresets.ValueMember = "Id";
            Instance.cbxPresets.DisplayMember = "Text";
            Instance.cbxPresets.DataSource = presets;
        }

        /// <summary>
        /// The LoadLimits method.
        /// </summary>
        /// <remarks>
        /// Gets the PTZ limits from the PTZ controller and applies the values to the UI controls.
        /// </remarks>
        public static void LoadLimits()
        {
            // Reset the UI elements that use the limit values
            Instance.lblPanSpeedMin.Text = Instance.lblPanSpeedMax.Text = string.Empty;
            Instance.lblTiltSpeedMin.Text = Instance.lblTiltSpeedMax.Text = string.Empty;
            Instance.lblZoomSpeedMin.Text = Instance.lblZoomSpeedMax.Text = string.Empty;
            Instance.lblFocusSpeedMin.Text = Instance.lblFocusSpeedMax.Text = string.Empty;
            Instance.lblIrisSpeedMin.Text = Instance.lblIrisSpeedMax.Text = string.Empty;
            Instance.tbPanSpeed.Minimum = Instance.tbTiltSpeed.Minimum = Instance.tbZoomSpeed.Minimum = Instance.tbFocusSpeed.Minimum = Instance.tbIrisSpeed.Minimum = -10;
            Instance.tbPanSpeed.Maximum = Instance.tbTiltSpeed.Maximum = Instance.tbZoomSpeed.Maximum = Instance.tbFocusSpeed.Maximum = Instance.tbIrisSpeed.Maximum = 10;
            Instance.tbPanSpeed.Value = Instance.tbTiltSpeed.Value = Instance.tbZoomSpeed.Value = Instance.tbFocusSpeed.Value = Instance.tbIrisSpeed.Value = 0;
            Instance.nudPanSpeed.Minimum = Instance.nudTiltSpeed.Minimum = Instance.nudZoomSpeed.Minimum = Instance.nudFocusSpeed.Minimum = Instance.nudIrisSpeed.Minimum = -10;
            Instance.nudPanSpeed.Maximum = Instance.nudTiltSpeed.Maximum = Instance.nudZoomSpeed.Maximum = Instance.nudFocusSpeed.Maximum = Instance.nudIrisSpeed.Maximum = 10;
            Instance.nudPanSpeed.Value = Instance.nudTiltSpeed.Value = Instance.nudZoomSpeed.Value = Instance.nudFocusSpeed.Value = Instance.nudIrisSpeed.Value = 0;
            Instance.gbMoveSpeed.Enabled = Instance.gbFocusSpeed.Enabled = Instance.gbIrisSpeed.Enabled = false;

            var limits = ControlManager.Instance.States.PtzControl?.PTZLimits;
            if (limits == null || (!limits.HasLimitSpeedX && !limits.HasLimitSpeedY && !limits.HasLimitSpeedZ))
                return;

            // Enable the UI elements that have limit values
            Instance.gbMoveSpeed.Enabled = limits.HasLimitSpeedX || limits.HasLimitSpeedY || limits.HasLimitSpeedZ;
            Instance.gbPanSpeed.Enabled = limits.HasLimitSpeedX;
            Instance.gbTiltSpeed.Enabled = limits.HasLimitSpeedY;
            Instance.gbZoomSpeed.Enabled = limits.HasLimitSpeedZ;
            Instance.gbFocusSpeed.Enabled = limits.HasLimitSpeedFocus;
            Instance.gbIrisSpeed.Enabled = limits.HasLimitSpeedIris;

            if (limits.HasLimitSpeedX)
            {
                Instance.lblPanSpeedMin.Text = limits.MinSpeedX.ToString();
                Instance.lblPanSpeedMax.Text = limits.MaxSpeedX.ToString();
                Instance.nudPanSpeed.Minimum = Instance.tbPanSpeed.Minimum = limits.MinSpeedX;
                Instance.nudPanSpeed.Maximum = Instance.tbPanSpeed.Maximum = limits.MaxSpeedX;
                Instance.nudPanSpeed.Value = Instance.tbPanSpeed.Value = 0;
            }

            if (limits.HasLimitSpeedY)
            {
                Instance.lblTiltSpeedMin.Text = limits.MinSpeedY.ToString();
                Instance.lblTiltSpeedMax.Text = limits.MaxSpeedY.ToString();
                Instance.nudTiltSpeed.Minimum = Instance.tbTiltSpeed.Minimum = limits.MinSpeedY;
                Instance.nudTiltSpeed.Maximum = Instance.tbTiltSpeed.Maximum = limits.MaxSpeedY;
                Instance.nudTiltSpeed.Value = Instance.tbTiltSpeed.Value = 0;
            }

            if (limits.HasLimitSpeedZ)
            {
                Instance.lblZoomSpeedMin.Text = limits.MinSpeedZ.ToString();
                Instance.lblZoomSpeedMax.Text = limits.MaxSpeedZ.ToString();
                Instance.nudZoomSpeed.Minimum = Instance.tbZoomSpeed.Minimum = limits.MinSpeedZ;
                Instance.nudZoomSpeed.Maximum = Instance.tbZoomSpeed.Maximum = limits.MaxSpeedZ;
                Instance.nudZoomSpeed.Value = Instance.tbZoomSpeed.Value = limits.MinSpeedZ > 0 ? limits.MinSpeedZ : 0;
            }

            if (limits.HasLimitSpeedFocus)
            {
                Instance.lblFocusSpeedMin.Text = limits.MinSpeedFocus.ToString();
                Instance.lblFocusSpeedMax.Text = limits.MaxSpeedFocus.ToString();
                Instance.nudFocusSpeed.Minimum = Instance.tbFocusSpeed.Minimum = limits.MinSpeedFocus;
                Instance.nudFocusSpeed.Maximum = Instance.tbFocusSpeed.Maximum = limits.MaxSpeedFocus;
                Instance.nudFocusSpeed.Value = Instance.tbFocusSpeed.Value = 0;
            }

            if (limits.HasLimitSpeedIris)
            {
                Instance.lblIrisSpeedMin.Text = limits.MinSpeedIris.ToString();
                Instance.lblIrisSpeedMax.Text = limits.MaxSpeedIris.ToString();
                Instance.nudIrisSpeed.Minimum = Instance.tbIrisSpeed.Minimum = limits.MinSpeedIris;
                Instance.nudIrisSpeed.Maximum = Instance.tbIrisSpeed.Maximum = limits.MaxSpeedIris;
                Instance.nudIrisSpeed.Value = Instance.tbIrisSpeed.Value = 0;
            }
        }

        /// <summary>
        /// The TryParseNullable method.
        /// </summary>
        /// <param name="value">The PTZ Controller.</param>
        /// <returns>An <c>int</c> if valid, otherwise <c>null</c>.</returns>
        public static int? TryParseNullable(string value)
        {
            return int.TryParse(value, out var outValue) ? (int?)outValue : null;
        }

        /// <summary>
        /// The UpdatePtzLockInfo method.
        /// </summary>
        /// <remarks>Updates the ptz lock info.</remarks>
        public static void UpdatePtzLockInfo()
        {
            if (PtzLock != null)
            {
                Instance.btnLock.Text = PtzLock.IsLocked ? @"Unlock" : @"Lock";
                Instance.lblLockOwner.Text = PtzLock.IsLocked ? $@"Owner: {(string.IsNullOrEmpty(PtzLock.Owner) ? "N/A" : PtzLock.Owner)}" : string.Empty;
                Instance.lblExpireTime.Text = PtzLock.IsLocked ? $@"Expires: {(PtzLock.ExpireTime > 0 ? PtzLock.ExpireTime.ToString() : "N/A")}" : string.Empty;
                Instance.btnLock.Enabled = true;
                Instance.btnRefreshLock.Enabled = true;
            }
            else
            {
                Instance.lblLockOwner.Text = Instance.tlpMainWindow.Enabled ? @"No PTZ lock found." : string.Empty;
                Instance.lblExpireTime.Text = string.Empty;
                Instance.btnLock.Enabled = false;
                Instance.btnRefreshLock.Enabled = false;
            }
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// The ButtonDeletePreset_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonDeletePreset_Click(object sender, EventArgs args)
        {
            if (ControlManager.Instance.States.PtzControl == null || cbxPresets.SelectedItem == null)
                return;

            ControlManager.Instance.States.PtzControl.DeletePreset((Preset)cbxPresets.SelectedValue);
            GetPresets();
        }

        /// <summary>
        /// The ButtonExecute_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonExecute_Click(object sender, EventArgs args)
        {
            if (ControlManager.Instance.States.PtzControl == null || !(sender is Button button))
                return;

            switch (button.Name)
            {
                case nameof(btnExecuteSpeed):
                    ControlManager.Instance.States.PtzControl.ContinuousMoveAtSpeed(tbPanSpeed.Value, tbTiltSpeed.Value, tbZoomSpeed.Value);
                    break;
                case nameof(btnExecuteFocusSpeed):
                    ControlManager.Instance.States.PtzControl.ContinuousFocusAtSpeed(tbFocusSpeed.Value);
                    break;
                case nameof(btnExecuteIrisSpeed):
                    ControlManager.Instance.States.PtzControl.ContinuousIrisAtSpeed(tbIrisSpeed.Value);
                    break;
            }
        }

        /// <summary>
        /// The ButtonExpander_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonExpander_Click(object sender, EventArgs args)
        {
            tlpAdvanced.Visible = !tlpAdvanced.Visible;
            btnExpander.Text = tlpAdvanced.Visible ? "◀" : "▶";
        }

        /// <summary>
        /// The ButtonGetPosition_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonGetPosition_Click(object sender, EventArgs args)
        {
            if (ControlManager.Instance.States.PtzControl == null)
                return;

            txbxAbsX.Text = ControlManager.Instance.States.PtzControl.X.ToString();
            txbxAbsY.Text = ControlManager.Instance.States.PtzControl.Y.ToString();
            txbxAbsZ.Text = ControlManager.Instance.States.PtzControl.Z.ToString();
        }

        /// <summary>
        /// The ButtonLockClick method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonLockClick(object sender, EventArgs args)
        {
            if (ControlManager.Instance.States.PtzControl == null)
                return;

            if (PtzLock != null)
            {
                if (PtzLock.IsLocked)
                    PtzLock.Unlock();
                else
                    PtzLock.Lock(300);
            }

            UpdatePtzLockInfo();
        }

        /// <summary>
        /// The ButtonMove_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonMove_Click(object sender, EventArgs args)
        {
            if (ControlManager.Instance.States.PtzControl == null)
                return;

            int valueX = int.TryParse(txbxRelX.Text, out valueX) ? valueX : 0;
            int valueY = int.TryParse(txbxRelY.Text, out valueY) ? valueY : 0;
            int valueZ = int.TryParse(txbxRelZ.Text, out valueZ) ? valueZ : 0;

            ControlManager.Instance.States.PtzControl.RelativeMove(valueX, valueY, valueZ);
        }

        /// <summary>
        /// The ButtonNewPreset_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonNewPreset_Click(object sender, EventArgs args)
        {
            if (ControlManager.Instance.States.PtzControl == null)
                return;

            decimal value = 1;
            if (InputBox.Show("Add Preset Using Current Position", "Preset Index:", ref value, 1, 9999) != DialogResult.OK)
                return;

            ControlManager.Instance.States.PtzControl.AddPreset((int)value);
            GetPresets();
        }

        /// <summary>
        /// The ButtonPtzControl_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonPtzControl_Click(object sender, MouseEventArgs args)
        {
            if (ControlManager.Instance.States.PtzControl == null || !(sender is Button button))
                return;

            switch (button.Name)
            {
                case nameof(btnPtzUL):
                    ControlManager.Instance.States.PtzControl.ContinuousMove(-100, 100, PtzController.ZoomDirections.None);
                    break;
                case nameof(btnPtzU):
                    ControlManager.Instance.States.PtzControl.ContinuousMove(0, 100, PtzController.ZoomDirections.None);
                    break;
                case nameof(btnPtzUR):
                    ControlManager.Instance.States.PtzControl.ContinuousMove(100, 100, PtzController.ZoomDirections.None);
                    break;
                case nameof(btnPtzR):
                    ControlManager.Instance.States.PtzControl.ContinuousMove(100, 0, PtzController.ZoomDirections.None);
                    break;
                case nameof(btnPtzDR):
                    ControlManager.Instance.States.PtzControl.ContinuousMove(100, -100, PtzController.ZoomDirections.None);
                    break;
                case nameof(btnPtzD):
                    ControlManager.Instance.States.PtzControl.ContinuousMove(0, -100, PtzController.ZoomDirections.None);
                    break;
                case nameof(btnPtzDL):
                    ControlManager.Instance.States.PtzControl.ContinuousMove(-100, -100, PtzController.ZoomDirections.None);
                    break;
                case nameof(btnPtzL):
                    ControlManager.Instance.States.PtzControl.ContinuousMove(-100, 0, PtzController.ZoomDirections.None);
                    break;
                case nameof(btnPtzZoomIn):
                    ControlManager.Instance.States.PtzControl.ContinuousMove(0, 0, PtzController.ZoomDirections.In);
                    break;
                case nameof(btnPtzZoomOut):
                    ControlManager.Instance.States.PtzControl.ContinuousMove(0, 0, PtzController.ZoomDirections.Out);
                    break;
                case nameof(btnPtzFocusNear):
                    ControlManager.Instance.States.PtzControl.ContinuousFocus(PtzController.FocusDirections.Near);
                    break;
                case nameof(btnPtzFocusFar):
                    ControlManager.Instance.States.PtzControl.ContinuousFocus(PtzController.FocusDirections.Far);
                    break;
                case nameof(btnPtzIrisOpen):
                    ControlManager.Instance.States.PtzControl.ContinuousIris(PtzController.IrisDirections.Open);
                    break;
                case nameof(btnPtzIrisClose):
                    ControlManager.Instance.States.PtzControl.ContinuousIris(PtzController.IrisDirections.Close);
                    break;
            }
        }

        /// <summary>
        /// The ButtonRefreshLock_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRefreshLock_Click(object sender, EventArgs args)
        {
            if (ControlManager.Instance.States.PtzControl == null)
                return;

            UpdatePtzLockInfo();
        }

        /// <summary>
        /// The ButtonRepositionPreset_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRepositionPreset_Click(object sender, EventArgs args)
        {
            if (ControlManager.Instance.States.PtzControl != null && cbxPresets.SelectedItem != null)
                ControlManager.Instance.States.PtzControl.RepositionPreset((Preset)cbxPresets.SelectedValue);
        }

        /// <summary>
        /// The ButtonSetPosition_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonSetPosition_Click(object sender, EventArgs args)
        {
            if (ControlManager.Instance.States.PtzControl == null)
                return;

            var panValue = TryParseNullable(txbxAbsX.Text);
            var tiltValue = TryParseNullable(txbxAbsY.Text);
            var zoomValue = TryParseNullable(txbxAbsZ.Text);

            // If only a Pan value was provided, call <see cref="AbsolutePan"/>.
            if (panValue.HasValue && !tiltValue.HasValue && !zoomValue.HasValue)
            {
                ControlManager.Instance.States.PtzControl.AbsolutePan(Convert.ToInt32(txbxAbsX.Text));
                return;
            }

            // If only a Tilt value was provided, call <see cref="AbsoluteTilt"/>.
            if (!panValue.HasValue && tiltValue.HasValue && !zoomValue.HasValue)
            {
                ControlManager.Instance.States.PtzControl.AbsoluteTilt(Convert.ToInt32(txbxAbsY.Text));
                return;
            }

            // If only a Zoom value was provided, call <see cref="AbsoluteZoom"/>.
            if (!panValue.HasValue && !tiltValue.HasValue && zoomValue.HasValue)
            {
                ControlManager.Instance.States.PtzControl.AbsoluteZoom(Convert.ToInt32(txbxAbsZ.Text));
                return;
            }

            // Call the appropriate AbsoluteMove method if the values needed are present.
            if (TryAbsoluteMove(panValue, tiltValue, zoomValue))
                return;

            MainForm.Instance.WriteToLog("Invalid amount of values.");
        }

        /// <summary>
        /// The ButtonTriggerPattern_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonTriggerPattern_Click(object sender, EventArgs args)
        {
            if (ControlManager.Instance.States.PtzControl != null && cbxPatterns.SelectedItem != null)
                ControlManager.Instance.States.PtzControl.TriggerPattern((Pattern)cbxPatterns.SelectedValue);
        }

        /// <summary>
        /// The ButtonTriggerPreset_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonTriggerPreset_Click(object sender, EventArgs args)
        {
            if (ControlManager.Instance.States.PtzControl != null && cbxPresets.SelectedItem != null)
                ControlManager.Instance.States.PtzControl.TriggerPreset((Preset)cbxPresets.SelectedValue);
        }

        /// <summary>
        /// The NumericUpDownSpeed_ValueChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void NumericUpDownSpeed_ValueChanged(object sender, EventArgs args)
        {
            if (ControlManager.Instance.States.PtzControl == null || !(sender is NumericUpDown nud))
                return;

            switch (nud.Name)
            {
                case nameof(nudPanSpeed):
                    tbPanSpeed.Value = (int)nudPanSpeed.Value;
                    break;
                case nameof(nudTiltSpeed):
                    tbTiltSpeed.Value = (int)nudTiltSpeed.Value;
                    break;
                case nameof(nudZoomSpeed):
                    tbZoomSpeed.Value = (int)nudZoomSpeed.Value;
                    break;
                case nameof(nudFocusSpeed):
                    tbFocusSpeed.Value = (int)nudFocusSpeed.Value;
                    break;
                case nameof(nudIrisSpeed):
                    tbIrisSpeed.Value = (int)nudIrisSpeed.Value;
                    break;
            }
        }

        /// <summary>
        /// The OnFormClosing method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void OnFormClosing(object sender, FormClosingEventArgs args)
        {
            // Hide the form and cancel the close event so it can be reopened later.
            Hide();
            args.Cancel = true;
        }

        /// <summary>
        /// The StopPtz method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        /// <remarks>Called when the mouse up event occurs from a PTZ control button.  The stop call
        /// will stop all PTZ actions.</remarks>
        private void StopPtz(object sender, MouseEventArgs args)
        {
            ControlManager.Instance.States.PtzControl?.Stop();
        }

        /// <summary>
        /// The TrackBarSpeed_Scroll method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void TrackBarSpeed_Scroll(object sender, EventArgs args)
        {
            if (ControlManager.Instance.States.PtzControl == null || !(sender is TrackBar trackBar))
                return;

            switch (trackBar.Name)
            {
                case nameof(tbPanSpeed):
                    nudPanSpeed.Value = tbPanSpeed.Value;
                    break;
                case nameof(tbTiltSpeed):
                    nudTiltSpeed.Value = tbTiltSpeed.Value;
                    break;
                case nameof(tbZoomSpeed):
                    nudZoomSpeed.Value = tbZoomSpeed.Value;
                    break;
                case nameof(tbFocusSpeed):
                    nudFocusSpeed.Value = tbFocusSpeed.Value;
                    break;
                case nameof(tbIrisSpeed):
                    nudIrisSpeed.Value = tbIrisSpeed.Value;
                    break;
            }
        }

        /// <summary>
        /// Calls appropriate AbsoluteMove method if the values needed are present.
        /// </summary>
        /// <param name="panValue">The pan amount if present, otherwise <c>null</c>.</param>
        /// <param name="tiltValue">The tilt amount if present, otherwise <c>null</c>.</param>
        /// <param name="zoomValue">The zoom amount if present, otherwise <c>null</c>.</param>
        /// <returns><c>true</c> if AbsoluteMove was called, otherwise <c>false</c>.</returns>
        private static bool TryAbsoluteMove(int? panValue, int? tiltValue, int? zoomValue)
        {
            if (!panValue.HasValue || !tiltValue.HasValue)
                return false;

            if (zoomValue.HasValue)
                ControlManager.Instance.States.PtzControl.AbsoluteMove(panValue.Value, tiltValue.Value, zoomValue.Value);
            else
                ControlManager.Instance.States.PtzControl.AbsoluteMove(panValue.Value, tiltValue.Value);

            return true;
        }

        #endregion Private Methods
    }
}