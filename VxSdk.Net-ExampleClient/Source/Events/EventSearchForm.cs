using System;
using System.Linq;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    using System.Collections.Generic;

    /// <summary>
    /// The EventSearchForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to search for events.</remarks>
    public partial class EventSearchForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="EventSearchForm" /> class.
        /// </summary>
        public EventSearchForm()
        {
            InitializeComponent();

            // Get the situations available on the VideoXpert system and use
            // them to pre-populate the type drop down.
            foreach (var situation in MainForm.CurrentSystem.Situations.Where(situation => !string.IsNullOrEmpty(situation.Type)))
            {
                cbxSituationType.Items.Add(situation.Type);
                situation.Dispose();
            }

            cbxSituationType.SelectedIndex = 0;
            dtpStartDate.Value = DateTime.Now - TimeSpan.FromDays(1);
            StartIndex = 0;
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Gets or sets the StartIndex property.
        /// </summary>
        /// <value>The index of the first element returned in current page of the collection.</value>
        private int StartIndex { get; set; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonAck_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonAck_Click(object sender, EventArgs args)
        {
            if (lvEvents.SelectedItems.Count == 0)
                return;

            // Get the associated event object from the selected item and acknowledge it.
            var idFilter = new Dictionary<Filters.Value, string> { { Filters.Value.Id, (string)lvEvents.SelectedItems[0].Tag } };
            var selEvent = MainForm.CurrentSystem.GetEvents(idFilter).FirstOrDefault();
            selEvent?.Acknowledge();
            selEvent?.Dispose();
        }

        /// <summary>
        /// The ButtonClear_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonClear_Click(object sender, EventArgs args)
        {
            btnNextPage.Enabled = false;
            btnPreviousPage.Enabled = false;
            lvEvents.Items.Clear();
        }

        /// <summary>
        /// The ButtonNextPage_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonNextPage_Click(object sender, EventArgs args)
        {
            btnNextPage.Enabled = false;
            StartIndex += (int)nudResultsPerPage.Value;
            Search();
        }

        /// <summary>
        /// The ButtonPreviousPage_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonPreviousPage_Click(object sender, EventArgs args)
        {
            btnPreviousPage.Enabled = false;
            StartIndex -= (int)nudResultsPerPage.Value;
            if (StartIndex < 0)
                StartIndex = 0;

            Search();
        }

        /// <summary>
        /// The ButtonSearch_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonSearch_Click(object sender, EventArgs args)
        {
            StartIndex = 0;
            btnPreviousPage.Enabled = false;
            btnNextPage.Enabled = false;
            Search();
        }

        /// <summary>
        /// The ButtonSilence_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonSilence_Click(object sender, EventArgs args)
        {
            if (lvEvents.SelectedItems.Count == 0)
                return;

            // Get the associated event object from the selected item and silence it.
            var idFilter = new Dictionary<Filters.Value, string> { { Filters.Value.Id, (string)lvEvents.SelectedItems[0].Tag } };
            var selEvent = MainForm.CurrentSystem.GetEvents(idFilter).FirstOrDefault();

            decimal value = 0;
            if (InputBox.Show("Silence", "Wake Time:", ref value) == DialogResult.OK)
                selEvent?.Silence((int)value);

            selEvent?.Dispose();
        }

        /// <summary>
        /// Perform an event search.
        /// </summary>
        private void Search()
        {
            var type = string.Empty;
            if (cbxSituationType.SelectedIndex != 0)
                type = cbxSituationType.SelectedItem.ToString();

            var start = dtpStartDate.Value.ToUniversalTime();
            var end = dtpEndDate.Value.ToUniversalTime();
            var count = (int)nudResultsPerPage.Value;

            var eventFilter = new Dictionary<Filters.Value, string>
                {
                    { Filters.Value.SituationType, type },
                    { Filters.Value.SearchStartTime, start.ToString("yyyy-MM-dd'T'HH:mm:ss.fff'Z'") },
                    { Filters.Value.SearchEndTime, end.ToString("yyyy-MM-dd'T'HH:mm:ss.fff'Z'") },
                    { Filters.Value.Count, count.ToString() }
                };

            var events = MainForm.CurrentSystem.GetEvents(eventFilter);
            if (events.Count > 0)
            {
                lvEvents.Items.Clear();
                if (events.Count >= (int)nudResultsPerPage.Value)
                    btnNextPage.Enabled = true;

                if (StartIndex > 0)
                    btnPreviousPage.Enabled = true;
            }
            else
                btnNextPage.Enabled = false;

            foreach (var vxEvent in events)
            {
                var lvItem = new ListViewItem(vxEvent.Time.ToLocalTime().ToString("u"));
                lvItem.SubItems.Add(vxEvent.SituationType);
                lvItem.SubItems.Add(vxEvent.Id);
                lvItem.SubItems.Add(vxEvent.Severity.ToString());
                lvItem.SubItems.Add(vxEvent.AckState.ToString());
                lvItem.Tag = vxEvent.Id;
                lvEvents.Items.Add(lvItem);
                vxEvent.Dispose();
            }

            events.Clear();
        }

        #endregion Private Methods
    }
}