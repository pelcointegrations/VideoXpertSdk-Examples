using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The LineCountRequestForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to request and view line counts.</remarks>
    public partial class LineCountRequestForm : Form
    {
        #region Private Fields

        /// <summary>
        /// The _selectedDataSource field.
        /// </summary>
        /// <remarks>The selected data source.</remarks>
        private readonly DataSource _selectedDataSource;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LineCountRequestForm" /> class.
        /// </summary>
        /// <param name="dataSource">The data source to get line counts from.</param>
        public LineCountRequestForm(DataSource dataSource)
        {
            InitializeComponent();
            _selectedDataSource = dataSource;
            rbDay.Checked = true;
            dtpStartTime.Value = DateTime.Now.AddDays(-1);
            dtpEndTime.Value = DateTime.Now;
            PopulateAnalyticBehaviors();
        }

        #endregion Public Constructors

        #region Private Methods

        /// <summary>
        /// The ButtonGetLineCounts_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonGetLineCounts_Click(object sender, EventArgs args)
        {
            lvResults.Items.Clear();
            lvResults.Visible = true;
            if (lvAnalyticBehaviors.CheckedItems.Count == 0)
                return;

            var behaviorId = lvAnalyticBehaviors.CheckedItems[0].Tag as string;
            if (string.IsNullOrEmpty(behaviorId))
                return;

            var lineRequest = new LineCountingRequest();
            lineRequest.AnalyticBehaviorIds.Add(behaviorId);
            lineRequest.EndTime = dtpEndTime.Value.ToUniversalTime();
            lineRequest.StartTime = dtpStartTime.Value.ToUniversalTime();
            if (rbHour.Checked)
                lineRequest.Interval = LineCountingRequest.TimeInterval.Hour;
            else if (rbDay.Checked)
                lineRequest.Interval = LineCountingRequest.TimeInterval.Day;
            else
                lineRequest.Interval = LineCountingRequest.TimeInterval.Month;

            var response = _selectedDataSource.GetLineCounts(lineRequest);
            if (response == null || response.Count == 0)
            {
                lvResults.Visible = false;
                return;
            }

            foreach (var lineCount in response)
            {
                var lvItem = new ListViewItem(lineCount.StartTime.ToLocalTime().ToString("s"));
                lvItem.SubItems.Add(lineCount.EndTime.ToLocalTime().ToString("s"));
                lvItem.SubItems.Add($"{lineCount.Count}");
                lvItem.SubItems.Add($"{lineCount.CountCorrection}");
                lvItem.SubItems.Add($"{lineCount.InCount}");
                lvItem.SubItems.Add($"{lineCount.InCountCorrection}");
                lvItem.SubItems.Add($"{lineCount.OutCount}");
                lvItem.SubItems.Add($"{lineCount.OutCountCorrection}");
                lvResults.Items.Add(lvItem);
            }
        }

        /// <summary>
        /// The ListViewAnalyticBehaviors_ItemChecked method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ListViewAnalyticBehaviors_ItemChecked(object sender, ItemCheckedEventArgs args)
        {
            if (!args.Item.Checked)
                return;

            foreach (ListViewItem item in lvAnalyticBehaviors.Items)
            {
                if (item.Checked && item != args.Item)
                    item.Checked = false;
            }
        }

        /// <summary>
        /// The PopulateAnalyticBehaviors method.
        /// </summary>
        private void PopulateAnalyticBehaviors()
        {
            // Get the existing analytic behaviors from the data source and add
            // them to the list view.
            foreach (var config in _selectedDataSource.AnalyticConfigs)
            {
                foreach (var behavior in config.AnalyticBehaviors)
                {
                    if (behavior.BehaviorType != AnalyticBehavior.AnalyticBehaviorType.ObjectLineCounter)
                        continue;

                    var lvItem = new ListViewItem(string.Empty);
                    lvItem.SubItems.Add(behavior.Id);
                    lvItem.SubItems.Add(behavior.Name);
                    lvItem.SubItems.Add(behavior.ObjectLineCounter.LineCounterType.ToString());
                    lvItem.SubItems.Add(behavior.ObjectType.ToString());
                    lvItem.Tag = behavior.Id;
                    lvAnalyticBehaviors.Items.Add(lvItem);
                }
            }
        }

        #endregion Private Methods
    }
}