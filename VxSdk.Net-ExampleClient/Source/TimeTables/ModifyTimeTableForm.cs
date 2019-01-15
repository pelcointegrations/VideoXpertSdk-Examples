using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The ModifyTimeTableForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to add or modify a time table.</remarks>
    public partial class ModifyTimeTableForm : Form
    {
        /// <summary>
        /// Gets or sets the AddTimeTable property.
        /// </summary>
        /// <value>The time table to add.</value>
        private NewTimeTable AddTimeTable { get; }

        /// <summary>
        /// Gets the IsAdd property.
        /// </summary>
        /// <value><c>true</c> if this form is adding a time table, otherwise <c>false</c>.</value>
        private bool IsAdd => tbxId.Enabled;

        /// <summary>
        /// Gets the HaveTimeRangesChanged property.
        /// </summary>
        /// <value><c>true</c> if the weekly time ranges have been modified, otherwise <c>false</c>.</value>
        private bool HaveTimeRangesChanged { get; set; }

        /// <summary>
        /// Gets or sets the SelectedTimeTable property.
        /// </summary>
        /// <value>The currently selected time table.</value>
        private TimeTable SelectedTimeTable { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyTimeTableForm" /> class.
        /// </summary>
        /// <param name="newTimeTable">The <paramref name="newTimeTable"/> parameter.</param>
        public ModifyTimeTableForm(NewTimeTable newTimeTable)
        {
            InitializeComponent();
            HaveTimeRangesChanged = false;
            Text = @"Add Time Table";
            AddTimeTable = newTimeTable;
            dtpStartDate.Value = DateTime.Now.AddDays(1);
            dtpEndDate.Value = DateTime.Now.AddDays(8);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyTimeTableForm" /> class.
        /// </summary>
        /// <param name="timeTable">The <paramref name="timeTable"/> parameter.</param>
        public ModifyTimeTableForm(TimeTable timeTable)
        {
            InitializeComponent();
            Text = @"Modify Time Table";
            tbxId.Enabled = false;
            btnGenerate.Visible = false;
            SelectedTimeTable = timeTable;
            tbxName.Text = timeTable.Name;
            tbxId.Text = timeTable.Id;
            chbxDisableStartDate.Checked = timeTable.StartDate == DateTime.MinValue;
            chbxDisableEndDate.Checked = timeTable.EndDate == DateTime.MinValue;
            dtpStartDate.Value = chbxDisableStartDate.Checked ? DateTime.Now.AddDays(1) : timeTable.StartDate;
            dtpEndDate.Value = chbxDisableEndDate.Checked ? DateTime.Now.AddDays(8) : timeTable.EndDate;
            foreach (var timeRange in timeTable.WeeklyTimeRanges)
            {
                var lvItem = new ListViewItem(string.Empty);
                lvItem.SubItems.Add(timeRange.Day.ToString().TrimStart('k'));
                lvItem.SubItems.Add(timeRange.StartTime.ToString("HH:mm:ss"));
                lvItem.SubItems.Add(timeRange.EndTime.ToString("HH:mm:ss"));
                lvItem.Tag = timeRange;
                lvTimeRanges.Items.Add(lvItem);
            }
        }

        /// <summary>
        /// The ButtonAdd_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonAdd_Click(object sender, EventArgs args)
        {
            using (var addTimeRangeForm = new AddTimeRangeForm(lvTimeRanges))
            {
                if (addTimeRangeForm.ShowDialog() != DialogResult.OK)
                    return;

                HaveTimeRangesChanged = true;
                lvTimeRanges.Refresh();
            }
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
        /// The ButtonRemove_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRemove_Click(object sender, EventArgs args)
        {
            var remItems = lvTimeRanges.CheckedItems;
            if (remItems.Count > 0)
                HaveTimeRangesChanged = true;

            foreach (ListViewItem item in remItems)
                lvTimeRanges.Items.Remove(item);

            lvTimeRanges.Refresh();
        }

        /// <summary>
        /// The ButtonSave_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            if (IsAdd)
            {
                AddTimeTable.Name = tbxName.Text;
                AddTimeTable.Id = tbxId.Text;
                AddTimeTable.StartDate = chbxDisableStartDate.Checked ? DateTime.MinValue : dtpStartDate.Value;
                AddTimeTable.EndDate = chbxDisableEndDate.Checked ? DateTime.MinValue : dtpEndDate.Value;
                foreach (ListViewItem timeRangeItem in lvTimeRanges.Items)
                {
                    var timeRange = timeRangeItem.Tag as TimeRange;
                    if (timeRange != null)
                        AddTimeTable.WeeklyTimeRanges.Add(timeRange);
                }

                MainForm.CurrentSystem.AddTimeTable(AddTimeTable);
            }
            else
            {
                if (!string.IsNullOrEmpty(tbxName.Text) && SelectedTimeTable.Name != tbxName.Text)
                    SelectedTimeTable.Name = tbxName.Text;

                var startDate = DateTime.MinValue;
                if (!chbxDisableStartDate.Checked)
                    startDate = dtpStartDate.Value;

                if (SelectedTimeTable.StartDate != startDate)
                    SelectedTimeTable.StartDate = startDate;

                var endDate = DateTime.MinValue;
                if (!chbxDisableEndDate.Checked)
                    endDate = dtpEndDate.Value;

                if (SelectedTimeTable.EndDate != endDate)
                    SelectedTimeTable.EndDate = endDate;

                if (!HaveTimeRangesChanged)
                    return;

                var timeRanges = new List<TimeRange>();
                foreach (ListViewItem timeRangeItem in lvTimeRanges.Items)
                {
                    var timeRange = timeRangeItem.Tag as TimeRange;
                    if (timeRange == null)
                        continue;

                    timeRanges.Add(timeRange);
                }

                SelectedTimeTable.WeeklyTimeRanges = timeRanges;
            }
        }

        /// <summary>
        /// The ButtonSave_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void CheckBoxDisableEndDate_CheckedChanged(object sender, EventArgs args)
        {
            dtpEndDate.Enabled = !chbxDisableEndDate.Checked;
        }

        /// <summary>
        /// The ButtonSave_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void CheckBoxDisableStartDate_CheckedChanged(object sender, EventArgs args)
        {
            dtpStartDate.Enabled = !chbxDisableStartDate.Checked;
        }

        /// <summary>
        /// The DateTimePickerDates_ValueChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void DateTimePickerDates_ValueChanged(object sender, EventArgs args)
        {
            if (dtpStartDate.Value >= dtpEndDate.Value)
                dtpStartDate.Value = dtpEndDate.Value.AddDays(1);
        }
    }
}
