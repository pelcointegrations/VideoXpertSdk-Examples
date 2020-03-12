using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The UserManagerForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to view, create and delete
    /// users from the VideoXpert system.</remarks>
    public partial class UserManagerForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="UserManagerForm" /> class.
        /// </summary>
        public UserManagerForm()
        {
            InitializeComponent();

            PopulateUsers();
        }

        #endregion Public Constructors

        #region Private Methods

        /// <summary>
        /// The ButtonConfiguration_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonConfiguration_Click(object sender, EventArgs args)
        {
            if (MainForm.CurrentSystem.AuthConfig == null)
                return;

            // Show the AuthConfigForm dialog.
            using (var authConfigForm = new AuthConfigForm())
            {
                authConfigForm.ShowDialog();
            }
        }

        /// <summary>
        /// The ButtonDelete_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonDelete_Click(object sender, EventArgs args)
        {
            if (lvUsers.SelectedItems.Count == 0)
                return;

            // Get the associated user object from the selected item and delete
            // it from the VideoXpert system.
            var user = (User)lvUsers.SelectedItems[0].Tag;
            MainForm.CurrentSystem.DeleteUser(user);
            PopulateUsers();
        }

        /// <summary>
        /// The ButtonModify_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonModify_Click(object sender, EventArgs args)
        {
            if (lvUsers.SelectedItems.Count == 0)
                return;

            var user = (User)lvUsers.SelectedItems[0].Tag;

            // Show the modifyUserForm dialog.
            DialogResult result;
            using (var modifyUserForm = new ModifyUserForm(user))
            {
                result = modifyUserForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result != DialogResult.OK)
                return;

            // Refresh the items in the list view.
            PopulateUsers();
        }

        /// <summary>
        /// The ButtonNewUser_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonNewUser_Click(object sender, EventArgs args)
        {
            // Show the AddUserForm dialog.
            DialogResult result;
            using (var userForm = new AddUserForm())
            {
                result = userForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result != DialogResult.OK)
                return;

            // Refresh the items in the list view to include the newly added user.
            PopulateUsers();
        }

        /// <summary>
        /// The ButtonRefresh_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRefresh_Click(object sender, EventArgs args)
        {
            PopulateUsers();
        }

        /// <summary>
        /// The ButtonUserAccount_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonUserAccount_Click(object sender, EventArgs args)
        {
            if (lvUsers.SelectedItems.Count == 0)
                return;

            var user = (User)lvUsers.SelectedItems[0].Tag;

            if (user.Account == null)
            {
                MessageBox.Show($@"Unable to retrieve the user account.", @"Error");
                return;
            }

            // Show the UserAccountForm dialog.
            using (var userAccountForm = new UserAccountForm(user.Account))
            {
                userAccountForm.ShowDialog();
            }
        }

        /// <summary>
        /// The PopulateUsers method.
        /// </summary>
        private void PopulateUsers()
        {
            lvUsers.Items.Clear();

            // Get the existing users from the VideoXpert system and add
            // them to the list view.
            foreach (var user in MainForm.CurrentSystem.Users)
            {
                var passwordExpireDate = user.PasswordExpiration == default(DateTime) ?
                    "Never" : user.PasswordExpiration.ToString("d");

                var lvItem = new ListViewItem(user.Name);
                lvItem.SubItems.Add(user.Id);
                lvItem.SubItems.Add(user.Domain);
                lvItem.SubItems.Add(user.AccountState ? "Enabled" : "Disabled");
                lvItem.SubItems.Add(passwordExpireDate);
                lvItem.SubItems.Add(user.PhoneNumbers.Count.ToString());
                lvItem.Tag = user;
                lvUsers.Items.Add(lvItem);
            }
        }

        #endregion Private Methods
    }
}