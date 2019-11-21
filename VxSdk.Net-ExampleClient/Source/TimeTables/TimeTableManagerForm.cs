using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The TimeTableManagerForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to view and modify time tables on the VideoXpert system.</remarks>
    public partial class TimeTableManagerForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeTableManagerForm" /> class.
        /// </summary>
        public TimeTableManagerForm()
        {
            InitializeComponent();

            PopulateTimeTables();
        }

        #endregion Public Constructors

        #region Private Methods

        /// <summary>
        /// The ButtonAdd_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonAdd_Click(object sender, EventArgs args)
        {
            // Show the ModifyTimeTableForm dialog.
            DialogResult result;
            using (var modifyTimeTableForm = new ModifyTimeTableForm(new NewTimeTable()))
            {
                result = modifyTimeTableForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result != DialogResult.OK)
                return;

            // Refresh the items in the list view.
            PopulateTimeTables();
        }

        /// <summary>
        /// The ButtonDelete_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonDelete_Click(object sender, EventArgs args)
        {
            if (lvTimeTableManager.SelectedItems.Count == 0)
                return;

            var timeTable = (TimeTable)lvTimeTableManager.SelectedItems[0].Tag;
            var result = MainForm.CurrentSystem.DeleteTimeTable(timeTable);
            if (result != Results.Value.OK)
                return;

            // Refresh the items in the list view.
            PopulateTimeTables();
            lvTimeTableManager.Refresh();
        }

        /// <summary>
        /// The ButtonModify_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonModify_Click(object sender, EventArgs args)
        {
            if (lvTimeTableManager.SelectedItems.Count == 0)
                return;

            var timeTable = (TimeTable)lvTimeTableManager.SelectedItems[0].Tag;

            // Show the ModifyTimeTableForm dialog.
            DialogResult result;
            using (var modifyTimeTableForm = new ModifyTimeTableForm(timeTable))
            {
                result = modifyTimeTableForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result != DialogResult.OK)
                return;

            // Refresh the items in the list view.
            PopulateTimeTables();
        }

        /// <summary>
        /// The PopulateTimeTables method.
        /// </summary>
        private void PopulateTimeTables()
        {
            // Get the existing time tables from the VideoXpert system and add
            // them to the list view.
            lvTimeTableManager.Items.Clear();
            foreach (var timeTable in MainForm.CurrentSystem.TimeTables)
            {
                var lvItem = new ListViewItem(timeTable.Name);
                lvItem.SubItems.Add(timeTable.Id);
                lvItem.SubItems.Add(timeTable.StartDate == DateTime.MinValue ? @"Disabled" : timeTable.StartDate.ToString("s"));
                lvItem.SubItems.Add(timeTable.EndDate == DateTime.MinValue ? @"Disabled" : timeTable.EndDate.ToString("s"));
                lvItem.SubItems.Add(timeTable.WeeklyTimeRanges.Count.ToString());
                lvItem.Tag = timeTable;
                lvTimeTableManager.Items.Add(lvItem);
            }
        }

        #endregion Private Methods
    }
}