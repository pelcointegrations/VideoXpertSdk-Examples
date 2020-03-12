using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The AddAnalyticBehaviorForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to select the settings
    /// that will be used to create or modify an analytic behavior.</remarks>
    public partial class AddAnalyticBehaviorForm : Form
    {
        #region Private Fields

        /// <summary>
        /// The SelectedAnalyticBehavior field.
        /// </summary>
        /// <remarks>The selected SelectedAnalyticBehavior.</remarks>
        private readonly AnalyticBehavior _selectedAnalyticBehavior;

        /// <summary>
        /// The SelectedAnalyticConfig field.
        /// </summary>
        /// <remarks>The selected AnalyticConfig.</remarks>
        private readonly AnalyticConfig _selectedAnalyticConfig;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AddAnalyticBehaviorForm" /> class.
        /// </summary>
        /// <param name="analyticConfig">The selected analytic config.</param>
        /// <param name="analyticBehavior">The analytic behavior to modify, if any.</param>
        public AddAnalyticBehaviorForm(AnalyticConfig analyticConfig, AnalyticBehavior analyticBehavior = null)
        {
            InitializeComponent();
            _selectedAnalyticConfig = analyticConfig;
            _selectedAnalyticBehavior = analyticBehavior;

            if (_selectedAnalyticBehavior != null)
            {
                Text = @"Modify Analytic Behavior";
                btnAdd.Text = @"Save";
                tbxName.Text = _selectedAnalyticBehavior.Name;
                tbxId.Text = _selectedAnalyticBehavior.Id;
                tbxId.Enabled = false;
                ckbxIsEnabled.Checked = _selectedAnalyticBehavior.IsEnabled;
                nudSensitivity.Value = _selectedAnalyticBehavior.Sensitivity;
                nudSeverity.Value = _selectedAnalyticBehavior.Severity;

                if (_selectedAnalyticBehavior.ObjectCounter != null)
                {
                    nudEndPointX.Value = _selectedAnalyticBehavior.ObjectCounter.EndPoint.X;
                    nudEndPointY.Value = _selectedAnalyticBehavior.ObjectCounter.EndPoint.Y;
                    nudStartPointX.Value = _selectedAnalyticBehavior.ObjectCounter.StartPoint.X;
                    nudStartPointY.Value = _selectedAnalyticBehavior.ObjectCounter.StartPoint.Y;
                    cbxIntersectionArea.SelectedIndex = (int)_selectedAnalyticBehavior.ObjectCounter.IntersectionArea - 1;
                }

                if (_selectedAnalyticBehavior.ObjectZone != null)
                {
                    foreach (var point in _selectedAnalyticBehavior.ObjectZone.Vertices)
                    {
                        var lvitem = new ListViewItem(string.Empty);
                        lvitem.SubItems.Add(point.X.ToString());
                        lvitem.SubItems.Add(point.Y.ToString());
                        lvObjectZonePoints.Items.Add(lvitem);
                    }
                }

                cbxObjectType.SelectedIndex = (int)_selectedAnalyticBehavior.ObjectType - 1;
                cbxBehaviorType.SelectedIndex = (int)_selectedAnalyticBehavior.BehaviorType - 1;
                cbxBehaviorType.Enabled = false;
                if (_selectedAnalyticBehavior.ObjectCounter?.IntersectionArea != null)
                    cbxIntersectionArea.SelectedIndex = (int)_selectedAnalyticBehavior.ObjectCounter.IntersectionArea - 1;
                else
                    cbxIntersectionArea.SelectedIndex = 0;
            }
            else
            {
                cbxObjectType.SelectedIndex = 0;
                cbxBehaviorType.SelectedIndex = 0;
                cbxIntersectionArea.SelectedIndex = 0;
            }
        }

        #endregion Public Constructors

        #region Private Methods

        /// <summary>
        /// The ButtonAdd_Click method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ButtonAdd_Click(object sender, EventArgs args)
        {
            try
            {
                if (_selectedAnalyticBehavior != null)
                {
                    if (_selectedAnalyticBehavior.ObjectType != (AnalyticBehavior.AnalyticObjectType)cbxObjectType.SelectedIndex + 1)
                        _selectedAnalyticBehavior.ObjectType = (AnalyticBehavior.AnalyticObjectType)cbxObjectType.SelectedIndex + 1;

                    if (_selectedAnalyticBehavior.Name != tbxName.Text)
                        _selectedAnalyticBehavior.Name = tbxName.Text;

                    if (_selectedAnalyticBehavior.IsEnabled != ckbxIsEnabled.Checked)
                        _selectedAnalyticBehavior.IsEnabled = ckbxIsEnabled.Checked;

                    if (_selectedAnalyticBehavior.Sensitivity != (int)nudSensitivity.Value)
                        _selectedAnalyticBehavior.Sensitivity = (int)nudSensitivity.Value;

                    if (_selectedAnalyticBehavior.Severity != (int)nudSeverity.Value)
                        _selectedAnalyticBehavior.Severity = (int)nudSeverity.Value;

                    if (_selectedAnalyticBehavior.BehaviorType == AnalyticBehavior.AnalyticBehaviorType.ObjectCounter)
                    {
                        var objectCounter = new ObjectCounter
                        {
                            EndPoint = { X = (int)nudEndPointX.Value, Y = (int)nudEndPointY.Value },
                            StartPoint = { X = (int)nudStartPointX.Value, Y = (int)nudStartPointY.Value },
                            IntersectionArea = (ObjectCounter.IntersectionAreas)cbxIntersectionArea.SelectedIndex + 1
                        };

                        _selectedAnalyticBehavior.ObjectCounter = objectCounter;
                    }
                    else
                    {
                        var objectZone = new ObjectZone();
                        foreach (ListViewItem item in lvObjectZonePoints.Items)
                        {
                            int x = Convert.ToInt32(item.SubItems[1].Text);
                            int y = Convert.ToInt32(item.SubItems[2].Text);
                            objectZone.Vertices.Add(new GridPoint { X = x, Y = y });
                        }

                        _selectedAnalyticBehavior.ObjectZone = objectZone;
                    }
                }
                else
                {
                    var newAnalyticBehavior = new NewAnalyticBehavior();
                    newAnalyticBehavior.BehaviorType = (AnalyticBehavior.AnalyticBehaviorType) cbxBehaviorType.SelectedIndex + 1;
                    newAnalyticBehavior.ObjectType = (AnalyticBehavior.AnalyticObjectType) cbxObjectType.SelectedIndex + 1;
                    newAnalyticBehavior.Name = tbxName.Text;
                    newAnalyticBehavior.Id = tbxId.Text;
                    newAnalyticBehavior.IsEnabled = ckbxIsEnabled.Checked;
                    newAnalyticBehavior.Sensitivity = (int) nudSensitivity.Value;
                    newAnalyticBehavior.Severity = (int) nudSeverity.Value;

                    if (newAnalyticBehavior.BehaviorType == AnalyticBehavior.AnalyticBehaviorType.ObjectCounter)
                    {
                        var objectCounter = new ObjectCounter
                        {
                            EndPoint = {X = (int) nudEndPointX.Value, Y = (int) nudEndPointY.Value},
                            StartPoint = {X = (int) nudStartPointX.Value, Y = (int) nudStartPointY.Value},
                            IntersectionArea = (ObjectCounter.IntersectionAreas) cbxIntersectionArea.SelectedIndex + 1
                        };

                        newAnalyticBehavior.ObjectCounter = objectCounter;
                    }
                    else
                    {
                        var objectZone = new ObjectZone();
                        foreach (ListViewItem item in lvObjectZonePoints.Items)
                        {
                            int x = Convert.ToInt32(item.SubItems[1].Text);
                            int y = Convert.ToInt32(item.SubItems[2].Text);
                            objectZone.Vertices.Add(new GridPoint {X = x, Y = y});
                        }

                        newAnalyticBehavior.ObjectZone = objectZone;
                    }

                    _selectedAnalyticConfig.AddAnalyticBehavior(newAnalyticBehavior);
                }
            }
            catch (Exception ex)
            {
                MainForm.Instance.WriteToLog($"Error creating analytic session: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// The ButtonAddPoint_Click method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ButtonAddPoint_Click(object sender, EventArgs args)
        {
            decimal x = 0;
            decimal y = 0;
            var result = InputBox.Show("Enter Point Values", "X", "Y", ref x, ref y, 0, 99999);
            if (result != DialogResult.OK)
                return;

            var lvitem = new ListViewItem(string.Empty);
            lvitem.SubItems.Add(x.ToString());
            lvitem.SubItems.Add(y.ToString());
            lvObjectZonePoints.Items.Add(lvitem);
        }

        /// <summary>
        /// The ButtonRemovePoint_Click method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ButtonRemovePoint_Click(object sender, EventArgs args)
        {
            if (lvObjectZonePoints.SelectedItems.Count == 0)
                return;

            lvObjectZonePoints.Items.Remove(lvObjectZonePoints.SelectedItems[0]);
            lvObjectZonePoints.Refresh();
        }

        /// <summary>
        /// The CheckboxBehaviorType_SelectedIndexChanged method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void CheckboxBehaviorType_SelectedIndexChanged(object sender, EventArgs args)
        {
            gbxObjectCounter.Enabled = cbxBehaviorType.SelectedIndex == 0;
            gbxObjectZone.Enabled = cbxBehaviorType.SelectedIndex == 1;
        }
        #endregion Private Methods
    }
}