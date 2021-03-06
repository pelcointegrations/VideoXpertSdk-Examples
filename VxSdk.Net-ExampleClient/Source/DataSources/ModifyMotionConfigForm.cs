﻿using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The ModifyMotionConfigForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to modify the motion config for a data source.</remarks>
    public partial class ModifyMotionConfigForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyMotionConfigForm" /> class.
        /// </summary>
        /// <param name="motionConfiguration">The <paramref name="motionConfiguration"/> parameter.</param>
        public ModifyMotionConfigForm(Configuration.Motion motionConfiguration)
        {
            InitializeComponent();
            SelectedMotionConfiguration = motionConfiguration;
            nudSensitivity.Value = motionConfiguration.Sensitivity;
            nudThreshold.Value = motionConfiguration.Threshold;
            switch (motionConfiguration.Mode)
            {
                case Configuration.MotionMode.Camera:
                    rbCamera.Checked = true;
                    break;

                case Configuration.MotionMode.Recorder:
                    rbRecorder.Checked = true;
                    break;

                default:
                    rbDisabled.Checked = true;
                    break;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyMotionConfigForm" /> class.
        /// </summary>
        /// <param name="motionConfig">The <paramref name="motionConfig"/> parameter.</param>
        public ModifyMotionConfigForm(DataSourceConfig.Motion motionConfig)
        {
            InitializeComponent();
            SelectedMotionConfig = motionConfig;
            nudSensitivity.Value = motionConfig.Sensitivity;
            nudThreshold.Value = motionConfig.Threshold;
            switch (motionConfig.Mode)
            {
                case Configuration.MotionMode.Camera:
                    rbCamera.Checked = true;
                    break;

                case Configuration.MotionMode.Recorder:
                    rbRecorder.Checked = true;
                    break;

                default:
                    rbDisabled.Checked = true;
                    break;
            }
        }

        #endregion Public Constructors

        #region Private Properties
        /// <summary>
        /// Gets or sets the SelectedMotionConfig property.
        /// </summary>
        /// <value>The currently selected motion config.</value>
        private DataSourceConfig.Motion SelectedMotionConfig { get; }

        /// <summary>
        /// Gets or sets the SelectedMotionConfiguration property.
        /// </summary>
        /// <value>The currently selected motion configuration.</value>
        private Configuration.Motion SelectedMotionConfiguration { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonSave_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            var selectedMode = Configuration.MotionMode.Disabled;
            if (rbCamera.Checked)
                selectedMode = Configuration.MotionMode.Camera;
            else if (rbRecorder.Checked)
                selectedMode = Configuration.MotionMode.Recorder;

            if (SelectedMotionConfig != null)
            {
                if (SelectedMotionConfig.Mode != selectedMode)
                    SelectedMotionConfig.Mode = selectedMode;

                if (selectedMode == Configuration.MotionMode.Disabled)
                    return;

                if (SelectedMotionConfig.Sensitivity != (int) nudSensitivity.Value)
                    SelectedMotionConfig.Sensitivity = (int) nudSensitivity.Value;

                if (SelectedMotionConfig.Threshold != (int) nudThreshold.Value)
                    SelectedMotionConfig.Threshold = (int) nudThreshold.Value;
            }
            else
            {
                if (SelectedMotionConfiguration.Mode != selectedMode)
                    SelectedMotionConfiguration.Mode = selectedMode;

                if (selectedMode == Configuration.MotionMode.Disabled)
                    return;

                if (SelectedMotionConfiguration.Sensitivity != (int)nudSensitivity.Value)
                    SelectedMotionConfiguration.Sensitivity = (int)nudSensitivity.Value;

                if (SelectedMotionConfiguration.Threshold != (int)nudThreshold.Value)
                    SelectedMotionConfiguration.Threshold = (int)nudThreshold.Value;
            }
        }

        /// <summary>
        /// The RadioButtonMode_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void RadioButtonMode_Click(object sender, EventArgs args)
        {
            lblSensitivity.Enabled = !rbDisabled.Checked;
            nudSensitivity.Enabled = !rbDisabled.Checked;
            nudThreshold.Enabled = !rbDisabled.Checked;
        }

        #endregion Private Methods
    }
}