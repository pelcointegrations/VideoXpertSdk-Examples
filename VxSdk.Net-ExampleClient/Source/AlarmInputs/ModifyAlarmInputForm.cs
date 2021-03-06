﻿using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The ModifyAlarmInputForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to modify an alarm input.</remarks>
    public partial class ModifyAlarmInputForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyAlarmInputForm" /> class.
        /// </summary>
        /// <param name="alarmInput">The <paramref name="alarmInput"/> parameter.</param>
        public ModifyAlarmInputForm(AlarmInput alarmInput)
        {
            InitializeComponent();
            SelectedAlarmInput = alarmInput;
            tbxName.Text = alarmInput.Name;
            tbxDescription.Text = alarmInput.Description;
            cbxType.SelectedIndex = (int)alarmInput.Type;
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Gets or sets the SelectedAlarmInput property.
        /// </summary>
        /// <value>The currently selected alarm input.</value>
        private AlarmInput SelectedAlarmInput { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonSave_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            if (!string.IsNullOrEmpty(tbxName.Text) && SelectedAlarmInput.Name != tbxName.Text)
                SelectedAlarmInput.Name = tbxName.Text;

            if (!string.IsNullOrEmpty(tbxDescription.Text) && SelectedAlarmInput.Description != tbxDescription.Text)
                SelectedAlarmInput.Description = tbxDescription.Text;

            if ((int)SelectedAlarmInput.Type != cbxType.SelectedIndex)
                SelectedAlarmInput.Type = (AlarmInput.AlarmInputTypes)cbxType.SelectedIndex;
        }

        #endregion Private Methods
    }
}