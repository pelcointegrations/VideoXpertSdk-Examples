using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The ModifyVideoEncodingConfigsForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to modify the video encoding configs for a data source.</remarks>
    public partial class ModifyVideoEncodingConfigsForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyVideoEncodingConfigsForm" /> class.
        /// </summary>
        /// <param name="dataSource">The <paramref name="dataSource"/> parameter.</param>
        public ModifyVideoEncodingConfigsForm(DataSource dataSource)
        {
            InitializeComponent();
            SelectedDataSource = dataSource;
            VideoEncodingConfigs = SelectedDataSource.VideoEncodingConfigurations;
            foreach (var config in VideoEncodingConfigs)
                lvStreams.Items.Add(new ListViewItem(config.Stream.ToString()) { Tag = config });
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Gets or sets the VideoEncodingConfigs property.
        /// </summary>
        /// <value>The list of video encoding configs.</value>
        private List<DataSourceConfig.VideoEncoding> VideoEncodingConfigs { get; set; }

        /// <summary>
        /// Gets or sets the SelectedDataSource property.
        /// </summary>
        /// <value>The currently selected data source.</value>
        private DataSource SelectedDataSource { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonApply_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonApply_Click(object sender, EventArgs args)
        {
            var videoEncoding = (DataSourceConfig.VideoEncoding)lvStreams.SelectedItems[0].Tag;
            if (videoEncoding == null)
                return;

            if (lblApplyWarning.Visible)
            {
                videoEncoding.Format = (DataInterface.StreamFormats)cbxFormat.SelectedItem;
                VideoEncodingConfigs = SelectedDataSource.VideoEncodingConfigurations;
                
                foreach (var config in VideoEncodingConfigs)
                {
                    foreach (ListViewItem lvStreamsItem in lvStreams.Items)
                    {
                        if (((DataSourceConfig.VideoEncoding)lvStreamsItem.Tag).Stream == config.Stream)
                            lvStreamsItem.Tag = config;
                    }
                }
            }
            else
            {
                if (cbxProfile.Visible)
                {
                    var value = (cbxProfile.SelectedItem as ComboboxItem)?.Value;
                    if (value != null)
                    {
                        var profile = value as VideoEncodingOption.EncoderProfile? ?? VideoEncodingOption.EncoderProfile.Unknown;
                        if (profile != videoEncoding.Profile)
                            videoEncoding.Profile = profile;
                    }
                }

                if (cbxFramerate.Visible && Math.Abs((float)cbxFramerate.SelectedItem - videoEncoding.Framerate) > .2)
                    videoEncoding.Framerate = (float)cbxFramerate.SelectedItem;

                if (cbxRateControl.Visible)
                {
                    var rateControl = (string)cbxRateControl.SelectedItem;
                    if (!string.IsNullOrEmpty(rateControl) && rateControl.ToLower() != videoEncoding.RateControl.ToLower())
                        videoEncoding.RateControl = rateControl;
                }

                if (cbxResolution.Visible)
                {
                    var resolution = (Resolution)(cbxResolution.SelectedItem as ComboboxItem)?.Value;
                    if (resolution != null && (resolution.Width != videoEncoding.StreamResolution.Width || resolution.Height != videoEncoding.StreamResolution.Height))
                        videoEncoding.StreamResolution = resolution;
                }

                if (tbxName.Visible && tbxName.Text != videoEncoding.Name)
                    videoEncoding.Name = tbxName.Text;

                if (tbxMulticastIp.Visible && tbxMulticastIp.Text != videoEncoding.MulticastIp)
                    videoEncoding.MulticastIp = tbxMulticastIp.Text;

                if (nudBitrate.Visible && nudBitrate.Value != videoEncoding.Bitrate)
                    videoEncoding.Bitrate = (int)nudBitrate.Value;

                if (nudGop.Visible && nudGop.Value != videoEncoding.Gop)
                    videoEncoding.Gop = (int)nudGop.Value;

                if (nudMulticastPort.Visible && nudMulticastPort.Value != videoEncoding.MulticastPort)
                    videoEncoding.MulticastPort = (int)nudMulticastPort.Value;
            }

            PopulateVideoEncodingConfig();
        }

        /// <summary>
        /// The ButtonReset_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonReset_Click(object sender, EventArgs args)
        {
            PopulateVideoEncodingConfig();
        }

        /// <summary>
        /// The ComboBoxFormat_DropDownClosed method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ComboBoxFormat_DropDownClosed(object sender, EventArgs args)
        {
            var videoEncoding = (DataSourceConfig.VideoEncoding)lvStreams.SelectedItems[0].Tag;
            if (videoEncoding == null || cbxFormat.SelectedItem == null)
                return;

            PopulateVideoEncodingConfig(false);
        }

        /// <summary>
        /// The GetProfileString method.
        /// </summary>
        private string GetProfileString(VideoEncodingOption.EncoderProfile profile)
        {
            switch (profile)
            {
                case VideoEncodingOption.EncoderProfile.AdvancedSimple:
                    return "Advanced Simple";
                case VideoEncodingOption.EncoderProfile.Baseline:
                    return "Baseline";
                case VideoEncodingOption.EncoderProfile.Extended:
                    return "Extended";
                case VideoEncodingOption.EncoderProfile.High:
                    return "High";
                case VideoEncodingOption.EncoderProfile.Main10:
                    return "Main10";
                case VideoEncodingOption.EncoderProfile.Simple:
                    return "Simple";
                default:
                    return "Main";
            }
        }

        /// <summary>
        /// The ListViewStreams_SelectedIndexChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ListViewStreams_SelectedIndexChanged(object sender, EventArgs args)
        {
            if (lvStreams.SelectedItems.Count == 0)
            {
                gbxSettings.Text = string.Empty;
                gbxSettings.Enabled = false;
                return;
            }

            PopulateVideoEncodingConfig();
        }

        /// <summary>
        /// The PopulateVideoEncodingConfig method.
        /// </summary>
        private void PopulateVideoEncodingConfig(bool fullUpdate = true)
        {
            if (fullUpdate)
                cbxFormat.Items.Clear();

            cbxProfile.Items.Clear();
            cbxFramerate.Items.Clear();
            cbxRateControl.Items.Clear();
            cbxResolution.Items.Clear();
            tbxName.Text = string.Empty;
            tbxMulticastIp.Text = string.Empty;
            nudBitrate.Minimum = nudGop.Minimum = int.MinValue;
            nudBitrate.Maximum = nudGop.Maximum = int.MaxValue;
            nudBitrate.Value = nudGop.Value = 0;
            nudMulticastPort.Value = 0;
            var videoEncoding = lvStreams.SelectedItems[0].Tag as DataSourceConfig.VideoEncoding;
            if (videoEncoding == null)
                return;

            gbxSettings.Text = $"{videoEncoding.Stream} Stream Settings";
            gbxSettings.Enabled = true;
            foreach (var option in videoEncoding.ConfigurationOptions)
            {
                var formatIndex = 0;
                if (fullUpdate)
                    formatIndex = cbxFormat.Items.Add(option.Format);

                if (option.Format != videoEncoding.Format)
                    continue;

                if (fullUpdate)
                    cbxFormat.SelectedIndex = formatIndex;

                if (!option.HasOptions)
                    continue;

                nudBitrate.Minimum = option.MinBitrate;
                nudBitrate.Maximum = option.MaxBitrate;
                nudGop.Minimum = option.MinGop;
                nudGop.Maximum = option.MaxGop;

                foreach (var profile in option.Profiles)
                {
                    var profileIndex = cbxProfile.Items.Add(new ComboboxItem { Text = GetProfileString(profile), Value = profile });
                    if (profile == videoEncoding.Profile)
                    {
                        cbxProfile.SelectedIndex = profileIndex;
                    }
                }

                foreach (var framerate in option.Framerates)
                {
                    var framerateIndex = cbxFramerate.Items.Add(framerate);
                    if (Math.Abs(framerate - videoEncoding.Framerate) < .2)
                    {
                        cbxFramerate.SelectedIndex = framerateIndex;
                    }
                }

                foreach (var rateControl in option.RateControls)
                {
                    var rateControlIndex = cbxRateControl.Items.Add(rateControl);
                    if (rateControl.ToLower() == videoEncoding.RateControl.ToLower())
                    {
                        cbxFramerate.SelectedIndex = rateControlIndex;
                    }
                }

                foreach (var resolution in option.Resolutions)
                {
                    var resolutionIndex = cbxResolution.Items.Add(new ComboboxItem { Text = $"{resolution.Width}x{resolution.Height}", Value = resolution });
                    if (videoEncoding.StreamResolution.Height == resolution.Height && videoEncoding.StreamResolution.Width == resolution.Width)
                    {
                        cbxResolution.SelectedIndex = resolutionIndex;
                    }
                }
            }

            ShowOrHideWarning();
            lblProfile.Visible = cbxResolution.Visible = cbxResolution.Items.Count > 0;
            lblFormat.Visible = cbxFormat.Visible = cbxFormat.Items.Count > 0;
            lblProfile.Visible = cbxProfile.Visible = cbxProfile.Items.Count > 0;
            lblFramerate.Visible = cbxFramerate.Visible = cbxFramerate.Items.Count > 0;
            lblRateControl.Visible = cbxRateControl.Visible = cbxRateControl.Items.Count > 0;

            tbxName.Text = videoEncoding.Name;
            tbxMulticastIp.Text = videoEncoding.MulticastIp;
            lblMulticastIp.Visible = tbxMulticastIp.Visible = !string.IsNullOrEmpty(videoEncoding.MulticastIp);

            if (videoEncoding.Bitrate > nudBitrate.Maximum)
                nudBitrate.Maximum = videoEncoding.Bitrate;

            if (videoEncoding.Bitrate < nudBitrate.Minimum)
                nudBitrate.Minimum = videoEncoding.Bitrate;

            nudBitrate.Value = videoEncoding.Bitrate;
            lblBitrate.Visible = nudBitrate.Visible = videoEncoding.Bitrate > 0;

            if (videoEncoding.Gop > nudGop.Maximum)
                nudGop.Maximum = videoEncoding.Gop;

            if (videoEncoding.Gop < nudGop.Minimum)
                nudGop.Minimum = videoEncoding.Gop;

            nudGop.Value = videoEncoding.Gop;
            lblGop.Visible = nudGop.Visible = videoEncoding.Gop > 0;

            nudMulticastPort.Value = videoEncoding.MulticastPort;
            lblMulticastPort.Visible = nudMulticastPort.Visible = videoEncoding.MulticastPort > 0;
        }

        /// <summary>
        /// The ShowOrHideWarning method.
        /// </summary>
        private void ShowOrHideWarning()
        {
            var videoEncoding = (DataSourceConfig.VideoEncoding)lvStreams.SelectedItems[0].Tag;
            if (videoEncoding == null || cbxFormat.SelectedItem == null)
                return;

            foreach (var option in videoEncoding.ConfigurationOptions.Where(option => option.Format == (DataInterface.StreamFormats)cbxFormat.SelectedItem))
            {
                lblApplyWarning.Visible = !option.HasOptions;
                tlpSettings.Visible = option.HasOptions;
            }
        }

        #endregion Private Methods
    }
}