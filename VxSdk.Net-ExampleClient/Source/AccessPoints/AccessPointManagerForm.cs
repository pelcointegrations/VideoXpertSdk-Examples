using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The AccessPointManagerForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to view access points on the VideoXpert system.</remarks>
    public partial class AccessPointManagerForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessPointManagerForm" /> class.
        /// </summary>
        public AccessPointManagerForm()
        {
            InitializeComponent();

            PopulateAccessPoints();
        }

        #endregion Public Constructors

        #region Private Methods

        /// <summary>
        /// The ButtonModify_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonModify_Click(object sender, EventArgs args)
        {
            if (lvAccessPointManager.SelectedItems.Count == 0)
                return;

            var accessPoint = (AccessPoint)lvAccessPointManager.SelectedItems[0].Tag;

            // Show the ModifyAccessPointForm dialog.
            DialogResult result;
            using (var modifyAccessPointForm = new ModifyAccessPointForm(accessPoint))
            {
                result = modifyAccessPointForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result != DialogResult.OK)
                return;

            // Refresh the items in the list view.
            PopulateAccessPoints();
        }

        /// <summary>
        /// The ButtonLock_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonLock_Click(object sender, EventArgs args)
        {
            if (lvAccessPointManager.SelectedItems.Count == 0)
                return;

            var accessPoint = (AccessPoint)lvAccessPointManager.SelectedItems[0].Tag;

            decimal value = MainForm.CurrentSystem.BookmarkAutoUnlockTime;
            if (InputBox.Show("Lock Access Point", "Lock the access point for the given amount of time (in seconds). If 0, Access Point will stay locked indefinitely.\n\nLock Seconds:", ref value, 0, 999999) != DialogResult.OK)
                return;

            accessPoint.Lock((int)value);
        }

        /// <summary>
        /// The ButtonRefresh_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRefresh_Click(object sender, EventArgs args)
        {
            // Refresh the items in the list view.
            PopulateAccessPoints();
            lvAccessPointManager.Refresh();
        }

        /// <summary>
        /// The ButtonRelations_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRelations_Click(object sender, EventArgs args)
        {
            if (lvAccessPointManager.SelectedItems.Count == 0)
                return;

            var accessPoint = (AccessPoint)lvAccessPointManager.SelectedItems[0].Tag;

            using (var relationDetailsForm = new RelationDetailsForm(accessPoint))
            {
                relationDetailsForm.ShowDialog();
            }
        }

        /// <summary>
        /// The ButtonUnlock_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonUnlock_Click(object sender, EventArgs args)
        {
            if (lvAccessPointManager.SelectedItems.Count == 0)
                return;

            var accessPoint = (AccessPoint)lvAccessPointManager.SelectedItems[0].Tag;

            decimal value = MainForm.CurrentSystem.BookmarkAutoUnlockTime;
            if (InputBox.Show("Unlock Access Point", "Unlock the access point for the given amount of time (in seconds). If 0, Access Point will stay unlocked indefinitely.\n\nUnlock Seconds:", ref value, 0, 999999) != DialogResult.OK)
                return;

            accessPoint.Unlock((int)value);
        }

        /// <summary>
        /// The PopulateAccessPoints method.
        /// </summary>
        private void PopulateAccessPoints(Device device = null)
        {
            // Get the existing access points from the VideoXpert system and add
            // them to the list view.
            lvAccessPointManager.Items.Clear();
            var accessPoints = MainForm.CurrentSystem.AccessPoints;
            foreach (var accessPoint in accessPoints)
            {
                var lvItem = new ListViewItem(accessPoint.Name);
                lvItem.SubItems.Add(accessPoint.Id);
                lvItem.SubItems.Add(accessPoint.State.ToString());
                lvItem.SubItems.Add(accessPoint.Type.ToString());
                lvItem.SubItems.Add(string.Join(", ", accessPoint.Status));
                lvItem.Tag = accessPoint;
                lvAccessPointManager.Items.Add(lvItem);
            }
        }

        #endregion Private Methods
    }
}