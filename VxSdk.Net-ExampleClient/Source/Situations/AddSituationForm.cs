using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The AddSituationForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to add a new
    /// situation to the VideoXpert system.</remarks>
    public partial class AddSituationForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddSituationForm" /> class.
        /// </summary>
        public AddSituationForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The ButtonAdd_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param> 
        private void ButtonAdd_Click(object sender, EventArgs args)
        {
            var situation = new NewSituation
            {
                IsAckNeeded = ckbxAckNeeded.Checked,
                AudibleLoopDelay = (int)nudAudibleLoopDelay.Value,
                ShouldAudiblyNotify = ckbxAudibleNotify.Checked,
                AudiblePlayCount = (int)nudAudiblePlayCount.Value,
                AutoAcknowledge = (int)nudAutoAcknowledge.Value,
                ShouldExpandBanner = ckbxExpandBanner.Checked,
                ShouldPopupBanner = chbxPopupBanner.Checked,
                ShouldLog = ckbxLog.Checked,
                Name = txbxName.Text,
                ShouldNotify = ckbxNotify.Checked,
                Severity = (int) Math.Abs(nudSeverity.Value - 11),
                SourceDeviceId = txbxSourceDeviceId.Text,
                Type = txbxType.Text
            };

            var intervalList = new List<int>();
            if (nudSnoozeIntervals1.Value != 0)
                intervalList.Add((int)nudSnoozeIntervals1.Value);

            if (nudSnoozeIntervals2.Value != 0)
                intervalList.Add((int)nudSnoozeIntervals2.Value);

            if (nudSnoozeIntervals3.Value != 0)
                intervalList.Add((int)nudSnoozeIntervals3.Value);

            situation.SnoozeIntervals = intervalList;
            MainForm.CurrentSystem.AddSituation(situation);
        }
    }
}
