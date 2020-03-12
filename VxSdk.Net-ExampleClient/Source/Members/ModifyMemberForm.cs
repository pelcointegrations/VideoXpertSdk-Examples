using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The ModifyMemberForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to add or modify a member system.</remarks>
    public partial class ModifyMemberForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyMemberForm" /> class.
        /// </summary>
        /// <param name="member">The <paramref name="member"/> parameter.</param>
        public ModifyMemberForm(Member member)
        {
            InitializeComponent();
            SelectedMember = member;
            if (SelectedMember == null)
            {
                Text = @"Add Member";
            }
            else
            {
                tbxHost.Text = member.Host;
                nudPort.Value = member.Port;
                tbxUsername.Text = member.Username;
                nudBandwidth.Value = member.Bandwidth;
                cbxRtspCapabilities.SelectedIndex = (int) member.RtspCapabilities - 1;
            }
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Gets or sets the SelectedMember property.
        /// </summary>
        /// <value>The currently selected member.</value>
        private Member SelectedMember { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonSave_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            if (SelectedMember == null)
            {
                DialogResult = DialogResult.None;
                if (string.IsNullOrEmpty(tbxHost.Text))
                {
                    MessageBox.Show(@"Host can not be empty.");
                }
                else if (string.IsNullOrEmpty(tbxUsername.Text))
                {
                    MessageBox.Show(@"Username can not be empty.");
                }
                else if(string.IsNullOrEmpty(tbxPassword.Text))
                {
                    MessageBox.Show(@"Password can not be empty.");
                }
                else if (nudPort.Value <= 0)
                {
                    MessageBox.Show(@"Port can not be 0.");
                }
                else if (nudBandwidth.Value <= 0)
                {
                    MessageBox.Show(@"Bandwidth can not be 0.");
                }
                else
                {
                    DialogResult = DialogResult.OK;
                    var newMember = new NewMember
                    {
                        Host = tbxHost.Text,
                        Username = tbxUsername.Text,
                        Password = tbxPassword.Text,
                        Port = (int) nudPort.Value,
                        Bandwidth = (int) nudBandwidth.Value,
                        RtspCapabilities = (Member.RtspCapability) cbxRtspCapabilities.SelectedIndex + 1
                    };

                    MainForm.CurrentSystem.AddMember(newMember);
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(tbxHost.Text) && SelectedMember.Host != tbxHost.Text)
                    SelectedMember.Host = tbxHost.Text;

                if (!string.IsNullOrEmpty(tbxUsername.Text) && SelectedMember.Username != tbxUsername.Text)
                    SelectedMember.Username = tbxUsername.Text;

                if (!string.IsNullOrEmpty(tbxPassword.Text))
                    SelectedMember.Password = tbxPassword.Text;

                if (nudPort.Value > 0 && SelectedMember.Port != nudPort.Value)
                    SelectedMember.Port = (int) nudPort.Value;

                if (nudBandwidth.Value > 0 && SelectedMember.Bandwidth != nudBandwidth.Value)
                    SelectedMember.Bandwidth = (int) nudBandwidth.Value;

                if ((int) SelectedMember.RtspCapabilities != cbxRtspCapabilities.SelectedIndex)
                    SelectedMember.RtspCapabilities = (Member.RtspCapability) cbxRtspCapabilities.SelectedIndex + 1;
            }
        }

        #endregion Private Methods
    }
}