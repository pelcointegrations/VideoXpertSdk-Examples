using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The LimitDetailsForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that contains the limits info for a resource.</remarks>
    public partial class LimitDetailsForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LimitDetailsForm" /> class.
        /// </summary>
        public LimitDetailsForm(ResourceLimits limits, string name)
        {
            InitializeComponent();

            GetLimitsInfo(limits, name);
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// The GetLimitsInfo method.
        /// </summary>
        /// <param name="limits">The <paramref name="limits"/> to get the info for.</param>
        public void GetLimitsInfo(ResourceLimits limits, string name)
        {
            if (limits == null)
                return;

            TreeNode topNode = tvLimits.Nodes.Add(name);
            topNode.Expand();

            if (limits.BooleanLimits.Count > 0)
            {
                var node = topNode.Nodes.Add("Boolean Limits");
                foreach (var booleanLimit in limits.BooleanLimits)
                    AddPropertyInfo(booleanLimit, booleanLimit.FieldName, node);
            }

            if (limits.FloatLimits.Count > 0)
            {
                var node = topNode.Nodes.Add("Float Limits");
                foreach (var floatLimit in limits.FloatLimits)
                    AddPropertyInfo(floatLimit, floatLimit.FieldName, node);
            }

            if (limits.IntegerLimits.Count > 0)
            {
                var node = topNode.Nodes.Add("Integer Limits");
                foreach (var integerLimit in limits.IntegerLimits)
                    AddPropertyInfo(integerLimit, integerLimit.FieldName, node);
            }

            if (limits.ListLimits.Count > 0)
            {
                var node = topNode.Nodes.Add("List Limits");
                foreach (var listLimit in limits.ListLimits)
                    AddPropertyInfo(listLimit, listLimit.FieldName, node);
            }

            if (limits.ObjectLimits.Count > 0)
            {
                var node = topNode.Nodes.Add("Object Limits");
                foreach (var objectLimit in limits.ObjectLimits)
                    AddPropertyInfo(objectLimit, objectLimit.FieldName, node);
            }

            if (limits.StringLimits.Count > 0)
            {
                var node = topNode.Nodes.Add("String Limits");
                foreach (var stringLimit in limits.StringLimits)
                    AddPropertyInfo(stringLimit, stringLimit.FieldName, node);
            }

            limits.Dispose();
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// The AddPropertyInfo method.
        /// </summary>
        /// <param name="limitObject">The <paramref name="limitObject"/> to add the properties for.</param>
        /// <param name="id">The device ID to use for the root node, if any.</param>
        /// <param name="parentNode">The parent node for this property.</param>
        private void AddPropertyInfo(object limitObject, string id, TreeNode parentNode)
        {
            TreeNode topNode = parentNode;
            if (!string.IsNullOrEmpty(id))
                topNode = parentNode.Nodes.Add(id);

            var type = limitObject.GetType();
            if (type == typeof(ResourceLimits.BooleanLimit))
            {
                var limit = (ResourceLimits.BooleanLimit)limitObject;
                topNode.Nodes.Add("Default Value: " + (limit.HasDefaultValue ? limit.DefaultValue.ToString() : "None"));
                topNode.Nodes.Add("Options: " + (limit.Options.Count > 0 ? string.Join(", ", limit.Options) : "None"));
            }
            else if (type == typeof(ResourceLimits.FloatLimit))
            {
                var limit = (ResourceLimits.FloatLimit)limitObject;
                topNode.Nodes.Add("Default Value: " + (limit.HasDefaultValue ? limit.DefaultValue.ToString() : "None"));
                topNode.Nodes.Add("Max Value: " + (limit.HasMaxValue ? limit.MaxValue.ToString() : "None"));
                topNode.Nodes.Add("Min Value: " + (limit.HasMinValue ? limit.MinValue.ToString() : "None"));
            }
            else if (type == typeof(ResourceLimits.IntegerLimit))
            {
                var limit = (ResourceLimits.IntegerLimit)limitObject;
                topNode.Nodes.Add("Default Value: " + (limit.HasDefaultValue ? limit.DefaultValue.ToString() : "None"));
                topNode.Nodes.Add("Max Value: " + (limit.HasMaxValue ? limit.MaxValue.ToString() : "None"));
                topNode.Nodes.Add("Min Value: " + (limit.HasMinValue ? limit.MinValue.ToString() : "None"));
            }
            else if (type == typeof(ResourceLimits.ListLimit))
            {
                var limit = (ResourceLimits.ListLimit)limitObject;
                topNode.Nodes.Add("Max Items: " + (limit.HasMaxItems ? limit.MaxItems.ToString() : "None"));
                topNode.Nodes.Add("Min Items: " + (limit.HasMinItems ? limit.MinItems.ToString() : "None"));
            }
            if (type == typeof(ResourceLimits.StringLimit))
            {
                var limit = (ResourceLimits.StringLimit)limitObject;
                topNode.Nodes.Add("Default Value: " + (limit.HasDefaultValue ? limit.DefaultValue : "None"));
                topNode.Nodes.Add("Options: " + (limit.Options.Count > 0 ? string.Join(", ", limit.Options) : "None"));
            }
        }

        /// <summary>
        /// The ButtonCollapseAll_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonCollapseAll_Click(object sender, EventArgs args)
        {
            tvLimits.CollapseAll();
        }

        /// <summary>
        /// The ButtonExpandAll_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonExpandAll_Click(object sender, EventArgs args)
        {
            tvLimits.ExpandAll();
        }

        #endregion Private Methods
    }
}