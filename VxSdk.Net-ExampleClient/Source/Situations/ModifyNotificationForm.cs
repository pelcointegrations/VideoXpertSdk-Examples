using System;
using System.Linq;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The ModifyNotificationForm class.
    /// </summary>
    /// <remarks>
    /// Provides a dialog window that allows the user to modify a notification.
    /// </remarks>
    public partial class ModifyNotificationForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyNotificationForm" /> class.
        /// </summary>
        public ModifyNotificationForm(Notification notification)
        {
            InitializeComponent();
            SelectedNotification = notification;
            PopulateRoles();
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Gets or sets the SelectedNotification property.
        /// </summary>
        /// <value>The currently selected notification.</value>
        private Notification SelectedNotification { get; }

        #endregion Private Properties

        #region Public Methods

        /// <summary>
        /// The PopulateRoles method.
        /// </summary>
        public void PopulateRoles()
        {
            lvRoles.Items.Clear();

            // Get the existing roles from the VideoXpert system and add them to the list box.
            var currentRoleIds = SelectedNotification.RoleIds;
            foreach (var role in MainForm.CurrentSystem.Roles)
            {
                var lvItem = new ListViewItem(string.Empty);
                lvItem.SubItems.Add(role.Id);
                lvItem.SubItems.Add(role.Name);
                lvItem.Checked = currentRoleIds.Any(roleId => roleId == role.Id);
                lvItem.Tag = role;
                lvRoles.Items.Add(lvItem);
            }
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// The ButtonSave_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            var currentRoleIds = SelectedNotification.RoleIds;
            foreach (ListViewItem roleItem in lvRoles.Items)
            {
                var role = roleItem.Tag as Role;
                if (role == null)
                    continue;

                if (!roleItem.Checked && currentRoleIds.Any(roleId => roleId == role.Id))
                {
                    SelectedNotification.RemoveRole(role);
                    continue;
                }

                if (roleItem.Checked && currentRoleIds.All(roleId => roleId != role.Id))
                {
                    SelectedNotification.AddRole(role);
                }
            }
        }

        #endregion Private Methods
    }
}