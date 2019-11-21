using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The AddUserForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to create a new user.</remarks>
    public partial class AddUserForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AddUserForm" /> class.
        /// </summary>
        public AddUserForm()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Private Methods

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

            var phoneNumber = (KeyValuePair<User.PhoneType, string>)lvPhoneNumbers.SelectedItems[0].Tag;

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
        /// The ButtonOk_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonOk_Click(object sender, EventArgs args)
        {
            try
            {
                if (tbxPassword.Text.Length > 0 && tbxPassword.Text.Length < 8)
                {
                    MessageBox.Show(@"New password must contain more than 7 characters.", @"Invalid Password", MessageBoxButtons.OK);
                    DialogResult = DialogResult.None;
                    return;
                }

                var newUser = new NewUser
                {
                    Name = tbxName.Text,
                    Password = tbxPassword.Text,
                    Domain = tbxDomain.Text,
                    MustChangePassword = ckbxChangePassword.Checked,
                    FirstName = tbxFirstName.Text,
                    LastName = tbxLastName.Text,
                    EmployeeId = tbxEmployeeId.Text,
                    Email = tbxEmailAddress.Text,
                    Note = tbxNotes.Text
                };

                foreach (ListViewItem item in lvPhoneNumbers.Items)
                    newUser.PhoneNumbers.Add((KeyValuePair<User.PhoneType, string>)item.Tag);

                var result = MainForm.CurrentSystem.AddUser(newUser);
                if (result == Results.Value.OK)
                    return;

                MessageBox.Show(@"Unable to add new user: " + result, @"Error Adding User", MessageBoxButtons.OK);
                DialogResult = DialogResult.None;
            }
            catch (Exception ex)
            {
                MainForm.Instance.WriteToLog($"Error creating user: {ex.Message}");
                throw;
            }
        }

        #endregion Private Methods
    }
}