using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The AnalyticSessionManagerForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to view, create and delete
    /// analytic sessions from the VideoXpert system.</remarks>
    public partial class AnalyticSessionManagerForm : Form
    {
        #region Private Fields

        /// <summary>
        /// The _lastItemChecked field.
        /// </summary>
        /// <remarks>Holds the last item checked in the AnalyticSessionManager list view.</remarks>
        private ListViewItem _lastItemChecked;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticSessionManagerForm" /> class.
        /// </summary>
        public AnalyticSessionManagerForm()
        {
            InitializeComponent();

            PopulateAnalyticSessions();
        }

        #endregion Public Constructors

        #region Private Methods

        /// <summary>
        /// The ButtonConfig_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonConfig_Click(object sender, EventArgs args)
        {
            if (lvAnalyticSessionManager.CheckedItems.Count == 0)
                return;

            var analyticSession = (AnalyticSession)lvAnalyticSessionManager.CheckedItems[0].Tag;

            // Show the AnalyticConfigManagerForm dialog.
            using (var analyticConfigManagerForm = new AnalyticConfigManagerForm(analyticSession.AnalyticConfig))
            {
                analyticConfigManagerForm.ShowDialog();
            }

            // Refresh the items in the list view to include the newly added analytic session.
            lvAnalyticSessionManager.Items.Clear();
            PopulateAnalyticSessions();
            lvAnalyticSessionManager.Refresh();
        }

        /// <summary>
        /// The ButtonDelete_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonDelete_Click(object sender, EventArgs args)
        {
            if (lvAnalyticSessionManager.CheckedItems.Count == 0)
                return;

            // Get the associated analytic session object from the selected item and delete
            // it from the VideoXpert system.
            var analyticSession = (AnalyticSession)lvAnalyticSessionManager.CheckedItems[0].Tag;
            MainForm.CurrentSystem.DeleteAnalyticSession(analyticSession);
            lvAnalyticSessionManager.CheckedItems[0].Remove();
        }

        /// <summary>
        /// The ButtonModify_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonModify_Click(object sender, EventArgs args)
        {
            if (lvAnalyticSessionManager.CheckedItems.Count == 0)
                return;

            var analyticSession = (AnalyticSession)lvAnalyticSessionManager.CheckedItems[0].Tag;
            // Show the ModifyAnalyticSessionForm dialog.
            DialogResult result;
            using (var modifyAnalyticSessionForm = new ModifyAnalyticSessionForm(analyticSession))
            {
                result = modifyAnalyticSessionForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result != DialogResult.OK)
                return;

            // Refresh the items in the list view to include the newly modified analytic session.
            lvAnalyticSessionManager.Items.Clear();
            PopulateAnalyticSessions();
            lvAnalyticSessionManager.Refresh();
        }

        /// <summary>
        /// The ButtonNewBookmark_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonNewBookmark_Click(object sender, EventArgs args)
        {
            // Show the AddAnalyticSessionForm dialog.
            DialogResult result;
            using (var addAnalyticSessionForm = new AddAnalyticSessionForm())
            {
                result = addAnalyticSessionForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result != DialogResult.OK)
                return;

            // Refresh the items in the list view to include the newly added analytic session.
            lvAnalyticSessionManager.Items.Clear();
            PopulateAnalyticSessions();
            lvAnalyticSessionManager.Refresh();
        }

        /// <summary>
        /// The ButtonRefresh_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRefresh_Click(object sender, EventArgs args)
        {
            // Refresh the items in the list view to include the newly added analytic session.
            lvAnalyticSessionManager.Items.Clear();
            PopulateAnalyticSessions();
            lvAnalyticSessionManager.Refresh();
        }

        /// <summary>
        /// The ListViewBookmarkManager_ItemCheck method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ListViewBookmarkManager_ItemCheck(object sender, ItemCheckEventArgs args)
        {
            // If we have the lastItem set as checked, and it is different
            // item than the one that fired the event, uncheck it.
            if (_lastItemChecked != null && _lastItemChecked.Checked
                && _lastItemChecked != lvAnalyticSessionManager.Items[args.Index])
            {
                // Uncheck the last item and store the new one.
                _lastItemChecked.Checked = false;
            }

            // Store the current item.
            _lastItemChecked = lvAnalyticSessionManager.Items[args.Index];
        }

        /// <summary>
        /// The ListViewBookmarkManager_SelectedIndexChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ListViewBookmarkManager_SelectedIndexChanged(object sender, EventArgs args)
        {
            if (lvAnalyticSessionManager.SelectedItems.Count == 0)
                return;

            lvAnalyticSessionManager.SelectedItems[0].Checked = true;
        }

        /// <summary>
        /// The PopulateAnalyticSessions method.
        /// </summary>
        private void PopulateAnalyticSessions()
        {
            // Get the existing analytic sessions from the VideoXpert system and add
            // them to the list view.
            foreach (var analyticSession in MainForm.CurrentSystem.AnalyticSessions)
            {
                var lvItem = new ListViewItem(string.Empty);
                lvItem.SubItems.Add(analyticSession.Id);
                lvItem.SubItems.Add(analyticSession.DataEncodingId);
                lvItem.SubItems.Add(analyticSession.Source);
                lvItem.SubItems.Add(analyticSession.HostDevice?.Name);
                lvItem.SubItems.Add(analyticSession.DataSource?.Name);
                lvItem.SubItems.Add(analyticSession.AnalyticConfig?.AnalyticBehaviors?.Count.ToString() ?? "0");
                lvItem.Tag = analyticSession;
                lvAnalyticSessionManager.Items.Add(lvItem);
            }
        }

        #endregion Private Methods
    }
}