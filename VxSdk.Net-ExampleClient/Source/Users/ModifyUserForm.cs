using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    using System.Linq;

    /// <summary>
    /// The AddUserForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to modify a user.</remarks>
    public partial class ModifyUserForm : Form
    {
        /// <summary>
        /// Gets or sets the CurrentNumberList property.
        /// </summary>
        /// <value>The list of roles for the currently selected phone numbers.</value>
        private List<KeyValuePair<User.PhoneType, string>> CurrentNumberList { get; set; }

        /// <summary>
        /// Gets or sets the CurrentRoleList property.
        /// </summary>
        /// <value>The list of roles for the currently selected user.</value>
        private List<string> CurrentRoleList { get; set; }

        /// <summary>
        /// Gets or sets the SelectedUser property.
        /// </summary>
        /// <value>The currently selected user.</value>
        private User SelectedUser { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyUserForm" /> class.
        /// </summary>
        /// <param name="user">The <paramref name="user"/> parameter.</param>
        public ModifyUserForm(User user)
        {
            InitializeComponent();
            SelectedUser = user;
            ckbxAccountEnabled.Checked = SelectedUser.AccountState;
            tbxName.Text = SelectedUser.Name;
            tbxFirstName.Text = SelectedUser.FirstName;
            tbxLastName.Text = SelectedUser.LastName;
            tbxEmployeeId.Text = SelectedUser.EmployeeId;
            tbxEmailAddress.Text = SelectedUser.Email;
            tbxDomain.Text = SelectedUser.Domain;
            tbxNotes.Text = SelectedUser.Note;
            PopulateRoles();
            PopulateNumbers();
        }

        /// <summary>
        /// The ButtonAdd_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonAdd_Click(object sender, EventArgs args)
        {
            // Show the ModifyPhoneNumberForm dialog.
            using (var modifyPhoneNumberForm = new ModifyPhoneNumberForm())
            {
                if (modifyPhoneNumberForm.ShowDialog() != DialogResult.OK)
                    return;

                var lvItem = new ListViewItem(modifyPhoneNumberForm.NumberInfo.Value);
                lvItem.SubItems.Add(modifyPhoneNumberForm.NumberInfo.Key.ToString());
                lvItem.Tag = modifyPhoneNumberForm.NumberInfo;
                lvPhoneNumbers.Items.Add(lvItem);
                lvPhoneNumbers.Refresh();
            }
        }

        /// <summary>
        /// The ButtonDelete_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonDelete_Click(object sender, EventArgs args)
        {
            if (lvPhoneNumbers.SelectedItems.Count == 0)
                return;

            lvPhoneNumbers.Items.Remove(lvPhoneNumbers.SelectedItems[0]);
        }

        /// <summary>
        /// The ButtonEdit_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonEdit_Click(object sender, EventArgs args)
        {
            if (lvPhoneNumbers.SelectedItems.Count == 0)
                return;

            var phoneNumber = (KeyValuePair<User.PhoneType, string>) lvPhoneNumbers.SelectedItems[0].Tag;

            // Show the ModifyPhoneNumberForm dialog.
            using (var modifyPhoneNumberForm = new ModifyPhoneNumberForm(phoneNumber))
            {
                if (modifyPhoneNumberForm.ShowDialog() != DialogResult.OK)
                    return;

                lvPhoneNumbers.SelectedItems[0].SubItems.Clear();
                lvPhoneNumbers.SelectedItems[0].Text = modifyPhoneNumberForm.NumberInfo.Value;
                lvPhoneNumbers.SelectedItems[0].SubItems.Add(modifyPhoneNumberForm.NumberInfo.Key.ToString());
                lvPhoneNumbers.SelectedItems[0].Tag = modifyPhoneNumberForm.NumberInfo;
                lvPhoneNumbers.Refresh();
            }
        }

        /// <summary>
        /// The ButtonSave_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            if (tbxNewPassword.Text.Length > 0 && tbxNewPassword.Text.Length < 8)
            {
                MessageBox.Show(@"New password must contain more than 7 characters.", @"Invalid Password", MessageBoxButtons.OK);
                DialogResult = DialogResult.None;
                return;
            }

            if (tbxNewPassword.Text.Length == 0 && ckbxChangePassword.Checked)
            {
                MessageBox.Show(@"'Must Change Password' requires a new password to be set.", @"New Password Required", MessageBoxButtons.OK);
                DialogResult = DialogResult.None;
                return;
            }

            if (tbxNewPassword.Text.Length > 7)
                SelectedUser.SetPassword(tbxNewPassword.Text, ckbxChangePassword.Checked);

            if (ckbxAccountEnabled.Checked != SelectedUser.AccountState)
                SelectedUser.AccountState = ckbxAccountEnabled.Checked;

            if (ckbxAccountEnabled.Checked != SelectedUser.AccountState)
                SelectedUser.AccountState = ckbxAccountEnabled.Checked;
            
            if(SelectedUser.FirstName != tbxFirstName.Text)
                SelectedUser.FirstName = tbxFirstName.Text;
            
            if(SelectedUser.LastName != tbxLastName.Text)
                SelectedUser.LastName = tbxLastName.Text;

            if(SelectedUser.EmployeeId != tbxEmployeeId.Text)
                SelectedUser.EmployeeId = tbxEmployeeId.Text;

            if(SelectedUser.Email != tbxEmailAddress.Text)
                SelectedUser.Email = tbxEmailAddress.Text;

            if(SelectedUser.Domain != tbxDomain.Text)
                SelectedUser.Domain = tbxDomain.Text;

            if(SelectedUser.Note != tbxNotes.Text)
                SelectedUser.Note = tbxNotes.Text;

            var numbers = new List<KeyValuePair<User.PhoneType, string>>();
            foreach (ListViewItem item in lvPhoneNumbers.Items)
            {
                numbers.Add((KeyValuePair<User.PhoneType, string>)item.Tag);
            }

            SelectedUser.PhoneNumbers = numbers;

            LinkRoles();
        }

        /// <summary>
        /// The PopulateNumbers method.
        /// </summary>
        private void PopulateNumbers()
        {
            CurrentNumberList = new List<KeyValuePair<User.PhoneType, string>>();
            foreach (var number in SelectedUser.PhoneNumbers)
                CurrentNumberList.Add(number);

            // Add numbers to lvPhoneNumbers.
            foreach (var number in CurrentNumberList)
            {
                var lvItem = new ListViewItem(number.Value);
                lvItem.SubItems.Add(number.Key.ToString());
                lvItem.Tag = number;
                lvPhoneNumbers.Items.Add(lvItem);
            }
        }

        /// <summary>
        /// The PopulateRoles method.
        /// </summary>
        private void PopulateRoles()
        {
            CurrentRoleList = new List<string>();
            foreach (var role in SelectedUser.Roles)
                CurrentRoleList.Add(role.Id);

            // Get all roles and add them to lvUserRoles, checking them if they are
            // assigned to this user.
            foreach (var role in MainForm.CurrentSystem.Roles)
            {
                var lvItem = new ListViewItem(string.Empty);
                lvItem.SubItems.Add(role.Name);
                lvItem.Tag = role;
                if (CurrentRoleList.Any(s => role.Id.Contains(s)))
                    lvItem.Checked = true;

                lvUserRoles.Items.Add(lvItem);
            }
        }

        /// <summary>
        /// The LinkRoles method.
        /// </summary>
        private void LinkRoles()
        {
            foreach (ListViewItem item in lvUserRoles.Items)
            {
                var role = (Role)item.Tag;

                if (item.Checked)
                {
                    if (!CurrentRoleList.Any(s => role.Id.Contains(s)))
                        SelectedUser.AddToRole(role);
                }
                else
                {
                    if (CurrentRoleList.Any(s => role.Id.Contains(s)))
                        SelectedUser.RemoveFromRole(role);
                }
            }
        }
    }
}
