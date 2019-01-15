using System;
using System.Linq;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The TagManagerForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to view, create and delete
    /// tags from the VideoXpert system.</remarks>
    public partial class TagManagerForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagManagerForm" /> class.
        /// </summary>
        public TagManagerForm()
        {
            InitializeComponent();

            PopulateTags();
        }

        /// <summary>
        /// The PopulateTags method.
        /// </summary>
        private void PopulateTags()
        {
            tvTags.Nodes.Clear();
            lvDataSources.Items.Clear();
            lvDevices.Items.Clear();

            // Get the existing tags from the VideoXpert system
            var tags = MainForm.CurrentSystem.Tags;

            // Add any top level folder tags to the root of the tree
            foreach (var tag in tags.Where(t => t.IsFolder && t.Parent == null))
            {
                var newNode = tvTags.Nodes.Add(tag.Id, tag.Name);
                newNode.Tag = tag;
            }

            // Add any sub-folder tags to the parent tags
            var loopNodes = true;
            while (loopNodes)
            {
                // Start with the loop ready to exit
                loopNodes = false;
                
                // Iterate each folder tag that has a parent tag
                foreach (var tag in tags.Where(t => t.IsFolder && t.Parent != null))
                {
                    // Continue if the tag has already been added to the tree
                    if (tvTags.Nodes.Find(tag.Id, true).Length > 0)
                        continue;

                    // Look for the parent tag node.  If found, add it as a child node.
                    // Otherwise, the current tag is a nested folder and the parent tag
                    // still needs to be added.  So set loopNodes to true to try again
                    // after subsequent tags in the list have been added.
                    var parentNode = tvTags.Nodes.Find(tag.Parent.Id, true);
                    if (parentNode.Length > 0)
                    {
                        var newNode = parentNode[0].Nodes.Add(tag.Id, tag.Name);
                        newNode.Tag = tag;
                    }
                    else
                    {
                        loopNodes = true;
                    }
                }
            }

            // Add all non-folder tags to the tree.
            foreach (var tag in tags.Where(t => !t.IsFolder))
            {
                var parentNode = tvTags.Nodes.Find(tag.Id, true);
                if (parentNode.Length > 0)
                {
                    var newNode = parentNode[0].Nodes.Add(tag.Id, tag.Name);
                    newNode.Tag = tag;
                }
                else
                {
                    var newNode = tvTags.Nodes.Add(tag.Id, tag.Name);
                    newNode.Tag = tag;
                }
            }
        }

        /// <summary>
        /// The ButtonDelete_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonDelete_Click(object sender, EventArgs args)
        {
            if (tvTags.SelectedNode == null)
                return;

            // Get the associated tag object from the selected item and delete
            // it from the VideoXpert system.
            var tag = (Tag)tvTags.SelectedNode.Tag;
            MainForm.CurrentSystem.DeleteTag(tag);
            PopulateTags();
        }

        /// <summary>
        /// The ButtonModify_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonModify_Click(object sender, EventArgs args)
        {
            if (tvTags.SelectedNode == null)
                return;

            var tag = (Tag)tvTags.SelectedNode.Tag;

            // Show the ModifyTagForm dialog.
            DialogResult result;
            using (var modifyTagForm = new ModifyTagForm(tag))
            {
                result = modifyTagForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result != DialogResult.OK)
                return;

            // Refresh the items in the list view.
            PopulateTags();
        }

        /// <summary>
        /// The ButtonMerge_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonMerge_Click(object sender, EventArgs args)
        {
            if (tvTags.SelectedNode == null)
                return;

            var tag = (Tag)tvTags.SelectedNode.Tag;

            // Show the MergeTagForm dialog.
            DialogResult result;
            using (var mergeTagForm = new MergeTagForm(tag))
            {
                result = mergeTagForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result != DialogResult.OK)
                return;

            // Refresh the items in the list view.
            PopulateTags();
        }

        /// <summary>
        /// The ButtonNewChildTag_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonNewChildTag_Click(object sender, EventArgs args)
        {
            if (tvTags.SelectedNode == null)
                return;

            var tag = (Tag)tvTags.SelectedNode.Tag;

            // Show the AddTagForm dialog.
            DialogResult result;
            using (var tagForm = new AddTagForm(tag))
            {
                result = tagForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result != DialogResult.OK)
                return;

            // Refresh the items in the list view to include the newly added tag.
            PopulateTags();
        }

        /// <summary>
        /// The ButtonNewTag_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonNewTag_Click(object sender, EventArgs args)
        {
            // Show the AddTagForm dialog.
            DialogResult result;
            using (var tagForm = new AddTagForm())
            {
                result = tagForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result != DialogResult.OK)
                return;

            // Refresh the items in the list view to include the newly added tag.
            PopulateTags();
        }

        /// <summary>
        /// The ButtonRefresh_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRefresh_Click(object sender, EventArgs args)
        {
            PopulateTags();
        } 

        /// <summary>
        /// The TreeViewTags_AfterSelect method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void TreeViewTags_AfterSelect(object sender, TreeViewEventArgs args)
        {
            lvDataSources.Items.Clear();
            lvDevices.Items.Clear();

            if (tvTags.SelectedNode == null)
                return;

            // Get the selected tag.
            var tag = (Tag)tvTags.SelectedNode.Tag;

            foreach (var datasource in tag.LinkedDataSources)
            {
                var lvItem = new ListViewItem(datasource.Name);
                lvDataSources.Items.Add(lvItem);
            }

            foreach (var device in tag.LinkedDevices)
            {
                var lvItem = new ListViewItem(device.Name);
                lvDevices.Items.Add(lvItem);
            }
        }
    }
}
