using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The AddTagForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to create a new tag.</remarks>
    public partial class AddTagForm : Form
    {
        /// <summary>
        /// Gets or sets the SelectedTag property.
        /// </summary>
        /// <value>The currently selected tag.</value>
        private Tag SelectedTag { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTagForm" /> class.
        /// </summary>
        public AddTagForm(Tag tag)
        {
            InitializeComponent();
            SelectedTag = tag;
            Text = $@"Add tag to {SelectedTag.Name}";
            ckbxIsPublic.Visible = false;
            ckbxIsFolder.Visible = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTagForm" /> class.
        /// </summary>
        public AddTagForm()
        {
            InitializeComponent();
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
                var newTag = new NewTag { Name = txbxName.Text  };
                if (SelectedTag != null)
                {
                    newTag.IsFolder = true;
                    newTag.ParentId = SelectedTag.Id;
                }
                else
                {
                    newTag.IsFolder = ckbxIsFolder.Checked;
                    newTag.IsPublic = ckbxIsPublic.Checked;
                }

                MainForm.CurrentSystem.AddTag(newTag);
            }
            catch (Exception ex)
            {
                MainForm.Instance.WriteToLog($"Error creating tag: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// The CheckboxIsFolder_CheckedChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void CheckboxIsFolder_CheckedChanged(object sender, EventArgs args)
        {
            ckbxIsPublic.Enabled = !ckbxIsFolder.Checked;
        }
    }
}
