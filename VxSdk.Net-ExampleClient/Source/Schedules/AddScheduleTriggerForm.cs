using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The AddScheduleTriggerForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to select the settings
    /// that will be used to create a new schedule trigger.</remarks>
    public partial class AddScheduleTriggerForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AddScheduleTriggerForm" /> class.
        /// </summary>
        /// <param name="listView">The <paramref name="listView"/> parameter.</param>
        public AddScheduleTriggerForm(ListView listView)
        {
            InitializeComponent();
            ScheduleTriggerListView = listView;
            cbxFramerate.SelectedIndex = 1;
            cbxEvent.SelectedIndex = 0;
            cbxEventInactive.SelectedIndex = 0;
            cbxTimeTables.SelectedIndex = 0;
            cbxAction.SelectedIndex = 1;
            foreach (var situation in MainForm.CurrentSystem.Situations)
            {
                cbxEvent.Items.Add(situation.Type);
                cbxEventInactive.Items.Add(situation.Type);
            }

            foreach (var timeTable in MainForm.CurrentSystem.TimeTables)
                cbxTimeTables.Items.Add(new ComboboxItem { Text = timeTable.Name, Value = timeTable });
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// Gets or sets the ScheduleTriggerListView property.
        /// </summary>
        /// <value>The list view to add the new schedule trigger to.</value>
        public ListView ScheduleTriggerListView { get; set; }

        #endregion Public Properties

        #region Private Methods

        /// <summary>
        /// The AddEventDetails method.
        /// </summary>
        /// <param name="scheduleTrigger">The new schedule trigger to add info to.</param>
        private void AddEventDetails(NewScheduleTrigger scheduleTrigger)
        {
            // Set the situation type based on the selection.
            scheduleTrigger.EventSituationType = cbxEvent.SelectedItem.ToString();
            scheduleTrigger.InactiveEventSituationType = cbxEventInactive.SelectedItem.ToString();

            // Set the event properties if they have been added.
            var eventProperties = new List<KeyValuePair<string, string>>();
            foreach (ListViewItem item in lvEventProperties.Items)
                eventProperties.Add(new KeyValuePair<string, string>(item.SubItems[0].Text, item.SubItems[1].Text));

            scheduleTrigger.EventProperties = eventProperties;
        }

        /// <summary>
        /// The ButtonAdd_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonAdd_Click(object sender, EventArgs args)
        {
            // Create a new schedule trigger using the form info.
            var scheduleTrigger = new NewScheduleTrigger
            {
                Id = tbxId.Text,
                Framerate = (Clip.RecordingFramerates)cbxFramerate.SelectedIndex + 1,
                PreTrigger = (int)nudPreRecord.Value,
                PostTrigger = (int)nudPostRecord.Value,
                Timeout = (int)nudDuration.Value,
                Action = (ScheduleTrigger.Actions)cbxAction.SelectedIndex + 1
            };

            var timeTableName = string.Empty;
            if (cbxTimeTables.SelectedIndex != 0)
            {
                var timeTable = ((ComboboxItem)cbxTimeTables.SelectedItem).Value as TimeTable;
                if (timeTable != null)
                {
                    timeTableName = cbxTimeTables.SelectedItem.ToString();
                    scheduleTrigger.TimeTableId = timeTable.Id;
                }
            }

            // If an event is selected add the event settings to the schedule trigger.
            if (cbxEvent.SelectedIndex != 0)
                AddEventDetails(scheduleTrigger);

            // Add the schedule trigger to the list view.
            var lvItem = new ListViewItem(string.Empty);
            lvItem.SubItems.Add(scheduleTrigger.Id);
            lvItem.SubItems.Add(scheduleTrigger.EventSituationType);
            lvItem.SubItems.Add(scheduleTrigger.InactiveEventSituationType);
            lvItem.SubItems.Add(scheduleTrigger.EventProperties.Count.ToString());
            lvItem.SubItems.Add(scheduleTrigger.Framerate.ToString());
            lvItem.SubItems.Add(scheduleTrigger.PreTrigger.ToString());
            lvItem.SubItems.Add(scheduleTrigger.PostTrigger.ToString());
            lvItem.SubItems.Add(scheduleTrigger.Timeout.ToString());
            lvItem.SubItems.Add(timeTableName);
            lvItem.SubItems.Add(scheduleTrigger.Action.ToString());
            lvItem.Tag = scheduleTrigger;
            ScheduleTriggerListView.Items.Add(lvItem);
        }

        /// <summary>
        /// The ButtonAddEventProperty_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonAddEventProperty_Click(object sender, EventArgs args)
        {
            // Show the NewPropertyForm dialog.
            using (var newPropertyForm = new NewPropertyForm(lvEventProperties))
            {
                newPropertyForm.ShowDialog();
            }

            // Refresh the items in the list view.
            lvEventProperties.Refresh();
        }

        /// <summary>
        /// The ButtonGenerate_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonGenerate_Click(object sender, EventArgs args)
        {
            tbxId.Clear();
            tbxId.Text = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// The ButtonRemoveEventProperty_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRemoveEventProperty_Click(object sender, EventArgs args)
        {
            if (lvEventProperties.SelectedItems.Count > 0)
                lvEventProperties.SelectedItems[0].Remove();
        }

        /// <summary>
        /// The ComboBoxEvent_SelectedIndexChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ComboBoxEvent_SelectedIndexChanged(object sender, EventArgs args)
        {
            gbxEventProperties.Enabled = cbxEvent.SelectedIndex != 0;
        }

        #endregion Private Methods
    }
}