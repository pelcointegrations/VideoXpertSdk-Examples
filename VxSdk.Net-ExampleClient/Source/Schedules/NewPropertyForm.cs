using System;
using System.Windows.Forms;

namespace ExampleClient.Source
{
    /// <summary>
    /// The NewPropertyForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to add a new property.</remarks>
    public partial class NewPropertyForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="NewPropertyForm" /> class.
        /// </summary>
        /// <param name="listView">The <paramref name="listView"/> parameter.</param>
        public NewPropertyForm(ListView listView)
        {
            InitializeComponent();
            PropertyListView = listView;
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Gets or sets the PropertyListView property.
        /// </summary>
        /// <value>The list view to add the new property to.</value>
        private ListView PropertyListView { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonAddSave_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonAddSave_Click(object sender, EventArgs args)
        {
            var lvItem = new ListViewItem(tbxKey.Text);
            lvItem.SubItems.Add(tbxValue.Text);
            PropertyListView.Items.Add(lvItem);
        }

        #endregion Private Methods
    }
}