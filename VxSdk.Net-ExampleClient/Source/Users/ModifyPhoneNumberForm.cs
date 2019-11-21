using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The ModifyPhoneNumberForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to add or edit the phone number for a user.</remarks>
    public partial class ModifyPhoneNumberForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyPhoneNumberForm" /> class.
        /// </summary>
        /// <param name="number">The phone number.</param>
        public ModifyPhoneNumberForm(KeyValuePair<User.PhoneType, string> number)
        {
            InitializeComponent();
            Text = @"Modify Phone Number";
            cbxType.SelectedIndex = (int)number.Key;
            tbxNumber.Text = number.Value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyPhoneNumberForm" /> class.
        /// </summary>
        public ModifyPhoneNumberForm()
        {
            InitializeComponent();
            cbxType.SelectedIndex = 1;
            Text = @"Add Phone Number";
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// Gets or sets the NumberInfo property.
        /// </summary>
        /// <value>The phone number info.</value>
        public KeyValuePair<User.PhoneType, string> NumberInfo { get; set; }

        #endregion Public Properties

        #region Private Methods

        /// <summary>
        /// The ButtonOk_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonOk_Click(object sender, EventArgs args)
        {
            NumberInfo = new KeyValuePair<User.PhoneType, string>((User.PhoneType)cbxType.SelectedIndex, tbxNumber.Text);
        }

        #endregion Private Methods
    }
}