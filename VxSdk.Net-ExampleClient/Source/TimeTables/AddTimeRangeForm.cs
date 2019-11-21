using System;
using System.Globalization;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The AddTimeRangeForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user create a new time range.</remarks>
    public partial class AddTimeRangeForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTimeRangeForm" /> class.
        /// </summary>
        /// <param name="listView">The <paramref name="listView"/> parameter.</param>
        public AddTimeRangeForm(ListView listView)
        {
            InitializeComponent();
            cbxDay.SelectedIndex = 0;
            TimeRangesListView = listView;
            dtpFrom.Value = DateTime.ParseExact("08:00:00", "HH:mm:ss", CultureInfo.InvariantCulture);
            dtpTo.Value = DateTime.ParseExact("17:00:00", "HH:mm:ss", CultureInfo.InvariantCulture);
            dtpFrom.ValueChanged += DateTimePickerTime_ValueChanged;
            dtpTo.ValueChanged += DateTimePickerTime_ValueChanged;
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Gets or sets the TimeRangesListView property.
        /// </summary>
        /// <value>The time ranges ListView.</value>
        private ListView TimeRangesListView { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonSave_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            var timeRange = new TimeRange
            {
                Day = (TimeRange.DayOfWeek)cbxDay.SelectedIndex + 1,
                StartTime = dtpFrom.Value,
                EndTime = dtpTo.Value
            };

            // Add the time range to the list view.
            var lvItem = new ListViewItem(string.Empty);
            lvItem.SubItems.Add(timeRange.Day.ToString().TrimStart('k'));
            lvItem.SubItems.Add(timeRange.StartTime.ToString("HH:mm:ss"));
            lvItem.SubItems.Add(timeRange.EndTime.ToString("HH:mm:ss"));
            lvItem.Tag = timeRange;
            TimeRangesListView.Items.Add(lvItem);
        }

        /// <summary>
        /// The DateTimePickerTime_ValueChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void DateTimePickerTime_ValueChanged(object sender, EventArgs args)
        {
            var dtp = sender as DateTimePicker;
            if (dtp != null && dtp.Name == "dtpFrom" && dtpFrom.Value >= dtpTo.Value)
            {
                var maxTime = DateTime.ParseExact("23:59:59", "HH:mm:ss", CultureInfo.InvariantCulture);
                if (dtpFrom.Value == maxTime)
                {
                    dtpFrom.Value = maxTime.AddSeconds(-1);
                    dtpTo.Value = maxTime;
                }
                else
                    dtpTo.Value = dtpFrom.Value.AddSeconds(1);
            }
            else if (dtp != null && dtp.Name == "dtpTo" && dtpFrom.Value >= dtpTo.Value)
            {
                var minTime = DateTime.ParseExact("00:00:00", "HH:mm:ss", CultureInfo.InvariantCulture);
                if (dtpTo.Value == minTime)
                {
                    dtpTo.Value = minTime.AddSeconds(1);
                    dtpFrom.Value = minTime;
                }
                else
                    dtpFrom.Value = dtpTo.Value.AddSeconds(-1);
            }
        }

        #endregion Private Methods
    }
}