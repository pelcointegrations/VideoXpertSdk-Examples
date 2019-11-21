using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The NotificationManagerForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to view, create and delete
    /// notifications from the VideoXpert system.</remarks>
    public partial class NotificationManagerForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationManagerForm" /> class.
        /// </summary>
        public NotificationManagerForm(Situation situation)
        {
            InitializeComponent();
            SelectedSituation = situation;

            PopulateNotifications();
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Gets or sets the SelectedSituation property.
        /// </summary>
        /// <value>The currently selected situation.</value>
        private Situation SelectedSituation { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonDelete_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonDelete_Click(object sender, EventArgs args)
        {
            if (lvNotificationManager.SelectedItems.Count == 0)
                return;

            // Get the associated notification object from the selected item and delete
            // it from the VideoXpert system.
            var notification = (Notification)lvNotificationManager.SelectedItems[0].Tag;
            SelectedSituation.RemoveNotification(notification);
            lvNotificationManager.SelectedItems[0].Remove();
        }

        /// <summary>
        /// The ButtonModifyNotification_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonModifyNotification_Click(object sender, EventArgs args)
        {
            // Show the ModifyNotificationForm dialog.
            DialogResult result;
            var notification = (Notification)lvNotificationManager.SelectedItems[0].Tag;
            using (var modifyNotificationForm = new ModifyNotificationForm(notification))
            {
                result = modifyNotificationForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result != DialogResult.OK)
                return;

            // Refresh the items in the list view to include the modified notification.
            lvNotificationManager.Items.Clear();
            PopulateNotifications();
            lvNotificationManager.Refresh();
        }

        /// <summary>
        /// The ButtonNewNotification_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonNewNotification_Click(object sender, EventArgs args)
        {
            // Show the AddNotificationForm dialog.
            DialogResult result;
            using (var addNotificationForm = new AddNotificationForm(SelectedSituation))
            {
                addNotificationForm.PopulateRoles();
                result = addNotificationForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result != DialogResult.OK)
                return;

            // Refresh the items in the list view to include the newly added notification.
            lvNotificationManager.Items.Clear();
            PopulateNotifications();
            lvNotificationManager.Refresh();
        }

        /// <summary>
        /// The ButtonRefresh_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRefresh_Click(object sender, EventArgs args)
        {
            // Refresh the items in the list view to include the newly added notification.
            lvNotificationManager.Items.Clear();
            PopulateNotifications();
            lvNotificationManager.Refresh();
        }

        /// <summary>
        /// The PopulateNotifications method.
        /// </summary>
        private void PopulateNotifications()
        {
            // Get the existing notifications from the VideoXpert system and add
            // them to the list view.
            var notifications = SelectedSituation.Notifications;
            var roles = MainForm.CurrentSystem.Roles;
            foreach (var notification in notifications)
            {
                var nameList = new List<string>();
                foreach (var roleId in notification.RoleIds)
                {
                    var matchingRole = roles.FirstOrDefault(role => role.Id == roleId);
                    nameList.Add(matchingRole != null ? matchingRole.Name : roleId);
                }
                var names = string.Join(", ", nameList);

                var lvItem = new ListViewItem(notification.Id);
                lvItem.SubItems.Add(names);
                lvItem.Tag = notification;
                lvNotificationManager.Items.Add(lvItem);
            }
        }

        #endregion Private Methods
    }
}