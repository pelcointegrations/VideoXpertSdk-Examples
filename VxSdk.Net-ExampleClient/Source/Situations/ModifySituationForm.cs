using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The ModifySituationForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to modify a
    /// situation on the VideoXpert system.</remarks>
    public partial class ModifySituationForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifySituationForm" /> class.
        /// </summary>
        public ModifySituationForm(Situation situation)
        {
            InitializeComponent();
            SelectedSituation = situation;

            ckbxAckNeeded.Checked = SelectedSituation.IsAckNeeded;
            nudAudibleLoopDelay.Value = SelectedSituation.AudibleLoopDelay;
            nudAudiblePlayCount.Value = SelectedSituation.AudiblePlayCount;
            ckbxAudibleNotify.Checked = SelectedSituation.ShouldAudiblyNotify;
            nudAutoAcknowledge.Value = SelectedSituation.AutoAcknowledge;
            ckbxExpandBanner.Checked = SelectedSituation.ShouldExpandBanner;
            ckbxLog.Checked = SelectedSituation.ShouldLog;
            ckbxNotify.Checked = SelectedSituation.ShouldNotify;
            chbxPopupBanner.Checked = SelectedSituation.ShouldPopupBanner;
            txbxName.Text = SelectedSituation.Name;
            nudSeverity.Value = Math.Abs(SelectedSituation.Severity - 11);

            var count = 0;
            foreach (var interval in SelectedSituation.SnoozeIntervals)
            {
                if (count == 0)
                    nudSnoozeIntervals1.Value = interval;
                else if (count == 1)
                    nudSnoozeIntervals2.Value = interval;
                else if (count == 2)
                    nudSnoozeIntervals3.Value = interval;
                else
                    break;

                count++;
            }
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Gets or sets the SelectedBookmark property.
        /// </summary>
        /// <value>The currently selected bookmark.</value>
        private Situation SelectedSituation { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonSave_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            if (SelectedSituation.IsAckNeeded != ckbxAckNeeded.Checked)
                SelectedSituation.IsAckNeeded = ckbxAckNeeded.Checked;

            if (SelectedSituation.AudibleLoopDelay != (int)nudAudibleLoopDelay.Value)
                SelectedSituation.AudibleLoopDelay = (int)nudAudibleLoopDelay.Value;

            if (SelectedSituation.ShouldAudiblyNotify != ckbxAudibleNotify.Checked)
                SelectedSituation.ShouldAudiblyNotify = ckbxAudibleNotify.Checked;

            if (SelectedSituation.AudiblePlayCount != (int)nudAudiblePlayCount.Value)
                SelectedSituation.AudiblePlayCount = (int)nudAudiblePlayCount.Value;

            if (SelectedSituation.AutoAcknowledge != (int)nudAutoAcknowledge.Value)
                SelectedSituation.AutoAcknowledge = (int)nudAutoAcknowledge.Value;

            if (SelectedSituation.ShouldExpandBanner != ckbxExpandBanner.Checked)
                SelectedSituation.ShouldExpandBanner = ckbxExpandBanner.Checked;

            if (SelectedSituation.ShouldPopupBanner != chbxPopupBanner.Checked)
                SelectedSituation.ShouldPopupBanner = chbxPopupBanner.Checked;

            if (SelectedSituation.ShouldLog != ckbxLog.Checked)
                SelectedSituation.ShouldLog = ckbxLog.Checked;

            if (SelectedSituation.Name != txbxName.Text)
                SelectedSituation.Name = txbxName.Text;

            if (SelectedSituation.ShouldNotify != ckbxNotify.Checked)
                SelectedSituation.ShouldNotify = ckbxNotify.Checked;

            if (Math.Abs(SelectedSituation.Severity - 11) != nudSeverity.Value)
                SelectedSituation.Severity = (int)Math.Abs(nudSeverity.Value - 11);

            var intervalList = new List<int>();
            if (nudSnoozeIntervals1.Value != 0)
                intervalList.Add((int)nudSnoozeIntervals1.Value);

            if (nudSnoozeIntervals2.Value != 0)
                intervalList.Add((int)nudSnoozeIntervals2.Value);

            if (nudSnoozeIntervals3.Value != 0)
                intervalList.Add((int)nudSnoozeIntervals3.Value);

            if (!intervalList.Equals(SelectedSituation.SnoozeIntervals))
                SelectedSituation.SnoozeIntervals = intervalList;
        }

        #endregion Private Methods
    }
}