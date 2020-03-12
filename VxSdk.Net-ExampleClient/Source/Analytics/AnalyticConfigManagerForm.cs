using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The AnalyticConfigManagerForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to manage an analytic configuration.</remarks>
    public partial class AnalyticConfigManagerForm : Form
    {
        #region Private Fields

        /// <summary>
        /// The _lastItemChecked field.
        /// </summary>
        /// <remarks>Holds the last item checked in the AnalyticConfigManager list view.</remarks>
        private ListViewItem _lastItemChecked;

        /// <summary>
        /// The _selectedAnalyticConfig field.
        /// </summary>
        /// <remarks>The selected analytic config.</remarks>
        private readonly AnalyticConfig _selectedAnalyticConfig;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticConfigManagerForm" /> class.
        /// </summary>
        /// <param name="analyticConfig">The analytic config to manage.</param>
        public AnalyticConfigManagerForm(AnalyticConfig analyticConfig)
        {
            InitializeComponent();
            _selectedAnalyticConfig = analyticConfig;

            PopulateAnalyticConfig();
        }

        #endregion Public Constructors

        #region Private Methods

        /// <summary>
        /// The ButtonDelete_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonDelete_Click(object sender, EventArgs args)
        {
            if (lvAnalyticBehaviors.CheckedItems.Count == 0)
                return;

            // Get the associated analytic behavior object from the selected item and delete it.
            var analyticBehavior = (AnalyticBehavior)lvAnalyticBehaviors.CheckedItems[0].Tag;
            _selectedAnalyticConfig.DeleteAnalyticBehavior(analyticBehavior);
            lvAnalyticBehaviors.CheckedItems[0].Remove();
        }

        /// <summary>
        /// The ButtonModify_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonModify_Click(object sender, EventArgs args)
        {
            if (lvAnalyticBehaviors.CheckedItems.Count == 0)
                return;

            var analyticBehavior = (AnalyticBehavior)lvAnalyticBehaviors.CheckedItems[0].Tag;

            // Show the ModifyAnalyticSessionForm dialog.
            DialogResult result;
            using (var modifyAnalyticSessionForm = new AddAnalyticBehaviorForm(_selectedAnalyticConfig, analyticBehavior))
            {
                result = modifyAnalyticSessionForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result != DialogResult.OK)
                return;

            // Refresh the items in the list view to include the newly modified analytic behavior.
            lvAnalyticBehaviors.Items.Clear();
            PopulateAnalyticConfig();
            lvAnalyticBehaviors.Refresh();
        }

        /// <summary>
        /// The ButtonNewBehavior_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonNewBehavior_Click(object sender, EventArgs args)
        {
            // Show the AddAnalyticBehaviorForm dialog.
            DialogResult result;
            using (var addAnalyticBehaviorForm = new AddAnalyticBehaviorForm(_selectedAnalyticConfig))
            {
                result = addAnalyticBehaviorForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result != DialogResult.OK)
                return;

            // Refresh the items in the list view to include the newly added analytic behavior.
            lvAnalyticBehaviors.Items.Clear();
            PopulateAnalyticConfig();
            lvAnalyticBehaviors.Refresh();
        }

        /// <summary>
        /// The ButtonRefresh_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRefresh_Click(object sender, EventArgs args)
        {
            // Refresh the items in the list view to include the newly added analytic behavior.
            lvAnalyticBehaviors.Items.Clear();
            PopulateAnalyticConfig();
            lvAnalyticBehaviors.Refresh();
        }

        /// <summary>
        /// The ButtonSet_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonSet_Click(object sender, EventArgs args)
        {
            if (nudX.Value != _selectedAnalyticConfig.Size.X || nudY.Value != _selectedAnalyticConfig.Size.Y)
            {
                var point = new GridPoint {X = (int) nudX.Value, Y = (int) nudY.Value};
                _selectedAnalyticConfig.Size = point;
            }
        }

        /// <summary>
        /// The ListViewAnalyticBehaviors_ItemCheck method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ListViewAnalyticBehaviors_ItemCheck(object sender, ItemCheckEventArgs args)
        {
            // If we have the lastItem set as checked, and it is different
            // item than the one that fired the event, uncheck it.
            if (_lastItemChecked != null && _lastItemChecked.Checked
                && _lastItemChecked != lvAnalyticBehaviors.Items[args.Index])
            {
                // Uncheck the last item and store the new one.
                _lastItemChecked.Checked = false;
            }

            // Store the current item.
            _lastItemChecked = lvAnalyticBehaviors.Items[args.Index];
        }

        /// <summary>
        /// The ListViewAnalyticBehaviors_SelectedIndexChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ListViewAnalyticBehaviors_SelectedIndexChanged(object sender, EventArgs args)
        {
            if (lvAnalyticBehaviors.SelectedItems.Count == 0)
                return;

            lvAnalyticBehaviors.SelectedItems[0].Checked = true;
        }

        /// <summary>
        /// The PopulateAnalyticConfig method.
        /// </summary>
        private void PopulateAnalyticConfig()
        {
            nudX.Value = _selectedAnalyticConfig.Size.X;
            nudY.Value = _selectedAnalyticConfig.Size.Y;
            lblId.Text = _selectedAnalyticConfig.Id;

            // Get the existing analytic behaviors from the VideoXpert system and add
            // them to the list view.
            foreach (var analyticBehavior in _selectedAnalyticConfig.AnalyticBehaviors)
            {
                var lvItem = new ListViewItem(string.Empty);
                lvItem.SubItems.Add(analyticBehavior.Id);
                lvItem.SubItems.Add(analyticBehavior.Name);
                lvItem.SubItems.Add(analyticBehavior.IsEnabled.ToString());
                lvItem.SubItems.Add(analyticBehavior.BehaviorType.ToString());
                lvItem.SubItems.Add(analyticBehavior.ObjectType.ToString());
                lvItem.SubItems.Add(analyticBehavior.Sensitivity.ToString());
                lvItem.SubItems.Add(analyticBehavior.Severity.ToString());
                lvItem.Tag = analyticBehavior;
                lvAnalyticBehaviors.Items.Add(lvItem);
            }
        }

        #endregion Private Methods
    }
}