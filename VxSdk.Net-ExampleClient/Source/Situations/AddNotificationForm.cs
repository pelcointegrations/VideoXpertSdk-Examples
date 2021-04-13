using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The AddNotificationForm class.
    /// </summary>
    /// <remarks>
    /// Provides a dialog window that allows the user to add a notification to the VideoXpert system.
    /// </remarks>
    public partial class AddNotificationForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AddNotificationForm" /> class.
        /// </summary>
        public AddNotificationForm(Situation situation)
        {
            InitializeComponent();
            SelectedSituation = situation;
            PopulateRoles();
            PopulateUsers();
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Gets or sets the SelectedSituation property.
        /// </summary>
        /// <value>The currently selected situation.</value>
        private Situation SelectedSituation { get; }

        #endregion Private Properties

        #region Public Methods

        /// <summary>
        /// The PopulateRoles method.
        /// </summary>
        public void PopulateRoles()
        {
            lvRoles.Items.Clear();

            // Get the existing roles from the VideoXpert system and add them to the list box.
            foreach (var role in MainForm.CurrentSystem.Roles)
            {
                var lvItem = new ListViewItem(string.Empty);
                lvItem.SubItems.Add(role.Id);
                lvItem.SubItems.Add(role.Name);
                lvItem.Tag = role;
                lvRoles.Items.Add(lvItem);
            }
        }

        /// <summary>
        /// The PopulateUsers method.
        /// </summary>
        public void PopulateUsers()
        {
            lvUsers.Items.Clear();

            // Get the existing users from the VideoXpert system and add them to the list box.
            foreach (var user in MainForm.CurrentSystem.Users)
            {
                var lvItem = new ListViewItem(string.Empty);
                lvItem.SubItems.Add(user.Id);
                lvItem.SubItems.Add(user.Name);
                lvItem.Tag = user;
                lvUsers.Items.Add(lvItem);
            }
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// The ButtonAdd_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonAdd_Click(object sender, EventArgs args)
        {
            var newNotification = new NewNotification();
            foreach (ListViewItem roleItem in lvRoles.Items)
            {
                if (!roleItem.Checked)
                    continue;

                var role = roleItem.Tag as Role;
                if (role == null)
                    continue;

                newNotification.Roles.Add(role);
            }

            foreach (ListViewItem userItem in lvUsers.Items)
            {
                if (!userItem.Checked)
                    continue;

                var user = userItem.Tag as User;
                if (user == null)
                    continue;

                newNotification.Users.Add(user);
            }

            SelectedSituation.AddNotification(newNotification);
        }

        #endregion Private Methods
    }
}