using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The MemberManagerForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to view member systems.</remarks>
    public partial class MemberManagerForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MemberManagerForm" /> class.
        /// </summary>
        public MemberManagerForm()
        {
            InitializeComponent();

            PopulateMembers();
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
            // Show the ModifyMemberForm dialog.
            DialogResult result;
            using (var modifyMemberForm = new ModifyMemberForm(null))
            {
                result = modifyMemberForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result != DialogResult.OK)
                return;

            // Refresh the items in the list view.
            PopulateMembers();
            lvMemberManager.Refresh();
        }

        /// <summary>
        /// The ButtonModify_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonModify_Click(object sender, EventArgs args)
        {
            if (lvMemberManager.SelectedItems.Count == 0)
                return;

            var member = (Member)lvMemberManager.SelectedItems[0].Tag;

            // Show the ModifyMemberForm dialog.
            DialogResult result;
            using (var modifyMemberForm = new ModifyMemberForm(member))
            {
                result = modifyMemberForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result != DialogResult.OK)
                return;

            // Refresh the items in the list view.
            PopulateMembers();
            lvMemberManager.Refresh();
        }

        /// <summary>
        /// The ButtonRemove_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRemove_Click(object sender, EventArgs args)
        {
            if (lvMemberManager.SelectedItems.Count == 0)
                return;

            var member = (Member)lvMemberManager.SelectedItems[0].Tag;
            MainForm.CurrentSystem.RemoveMember(member);
            PopulateMembers();
            lvMemberManager.Refresh();
        }

        /// <summary>
        /// The ButtonRefresh_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRefresh_Click(object sender, EventArgs args)
        {
            // Refresh the items in the list view.
            PopulateMembers();
            lvMemberManager.Refresh();
        }

        /// <summary>
        /// The PopulateMembers method.
        /// </summary>
        private void PopulateMembers()
        {
            // Get the existing members from the VideoXpert system and add
            // them to the list view.
            lvMemberManager.Items.Clear();
            var members = MainForm.CurrentSystem.Members;
            foreach (var member in members)
            {
                var lvItem = new ListViewItem(member.Name);
                lvItem.SubItems.Add(member.Id);
                lvItem.SubItems.Add(member.Host);
                lvItem.SubItems.Add(member.Port.ToString());
                lvItem.SubItems.Add(member.Username);
                lvItem.SubItems.Add(member.Bandwidth.ToString());
                lvItem.SubItems.Add(member.State.ToString());
                lvItem.SubItems.Add(member.RtspCapabilities.ToString());
                lvItem.Tag = member;
                lvMemberManager.Items.Add(lvItem);
            }
        }

        #endregion Private Methods

    }
}