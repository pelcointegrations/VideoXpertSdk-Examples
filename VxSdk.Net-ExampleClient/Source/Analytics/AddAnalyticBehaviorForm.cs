using System;
using System.Globalization;
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
                ckbxIsEnabled.Checked = _selectedAnalyticBehavior.IsEnabled;
                nudSeverity.Value = _selectedAnalyticBehavior.Severity;

                if (_selectedAnalyticBehavior.ObjectLineCounter != null)
                {
                    nudEndPointX.Value = (decimal)_selectedAnalyticBehavior.ObjectLineCounter.EndPoint.X;
                    nudEndPointY.Value = (decimal)_selectedAnalyticBehavior.ObjectLineCounter.EndPoint.Y;
                    nudStartPointX.Value = (decimal)_selectedAnalyticBehavior.ObjectLineCounter.StartPoint.X;
                    nudStartPointY.Value = (decimal)_selectedAnalyticBehavior.ObjectLineCounter.StartPoint.Y;
                    cbxLineCounterTypes.SelectedIndex = (int)_selectedAnalyticBehavior.ObjectLineCounter.LineCounterType - 1;
                    ckbxIsEventsEnabled.Checked = _selectedAnalyticBehavior.ObjectLineCounter.EventsEnabled;
                    nudEventWindow.Value = _selectedAnalyticBehavior.ObjectLineCounter.EventWindowSecs;
                    nudMaxCountThreshold.Value = _selectedAnalyticBehavior.ObjectLineCounter.MaxCountThreshold;
                    tbxLeftCountLabel.Text = _selectedAnalyticBehavior.ObjectLineCounter.LeftCountLabel;
                    tbxRightCountLabel.Text = _selectedAnalyticBehavior.ObjectLineCounter.RightCountLabel;
                }

                if (_selectedAnalyticBehavior.ObjectInZone != null)
                {
                    foreach (var point in _selectedAnalyticBehavior.ObjectInZone.Vertices)
                    {
                        var lvItem = new ListViewItem(string.Empty);
                        lvItem.SubItems.Add(point.X.ToString(CultureInfo.InvariantCulture));
                        lvItem.SubItems.Add(point.Y.ToString(CultureInfo.InvariantCulture));
                        lvObjectInZonePoints.Items.Add(lvItem);
                    }
                }

                if (_selectedAnalyticBehavior.ObjectWrongWayZone != null)
                {
                    nudMinTriggerAngle.Value = _selectedAnalyticBehavior.ObjectWrongWayZone.MinTriggerAngle;
                    nudVectorAngle.Value = _selectedAnalyticBehavior.ObjectWrongWayZone.Vector.Angle;
                    nudVectorX.Value = (decimal)_selectedAnalyticBehavior.ObjectWrongWayZone.Vector.X;
                    nudVectorY.Value = (decimal)_selectedAnalyticBehavior.ObjectWrongWayZone.Vector.Y;

                    foreach (var point in _selectedAnalyticBehavior.ObjectWrongWayZone.Zone)
                    {
                        var lvItem = new ListViewItem(string.Empty);
                        lvItem.SubItems.Add(point.X.ToString(CultureInfo.InvariantCulture));
                        lvItem.SubItems.Add(point.Y.ToString(CultureInfo.InvariantCulture));
                        lvObjectWrongWayZonePoints.Items.Add(lvItem);
                    }
                }

                cbxObjectType.SelectedIndex = (int)_selectedAnalyticBehavior.ObjectType - 1;
                cbxBehaviorType.SelectedIndex = (int)_selectedAnalyticBehavior.BehaviorType - 1;
                cbxBehaviorType.Enabled = false;
                if (_selectedAnalyticBehavior.ObjectLineCounter?.LineCounterType != null)
                    cbxLineCounterTypes.SelectedIndex = (int)_selectedAnalyticBehavior.ObjectLineCounter.LineCounterType - 1;
                else
                    cbxLineCounterTypes.SelectedIndex = 0;
            }
            else
            {
                cbxObjectType.SelectedIndex = 0;
                cbxBehaviorType.SelectedIndex = 0;
                cbxLineCounterTypes.SelectedIndex = 0;
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

                    if (_selectedAnalyticBehavior.Severity != (int)nudSeverity.Value)
                        _selectedAnalyticBehavior.Severity = (int)nudSeverity.Value;

                    if (_selectedAnalyticBehavior.BehaviorType == AnalyticBehavior.AnalyticBehaviorType.ObjectLineCounter)
                    {
                        var objectLineCounter = new ObjectLineCounter
                        {
                            EndPoint = { X = (float)nudEndPointX.Value, Y = (float)nudEndPointY.Value },
                            StartPoint = { X = (float)nudStartPointX.Value, Y = (float)nudStartPointY.Value },
                            LineCounterType = (ObjectLineCounter.LineCounterTypes)cbxLineCounterTypes.SelectedIndex + 1,
                            EventsEnabled = ckbxIsEventsEnabled.Checked,
                            EventWindowSecs = (int)nudEventWindow.Value,
                            MaxCountThreshold = (int)nudMaxCountThreshold.Value,
                            LeftCountLabel = tbxLeftCountLabel.Text,
                            RightCountLabel = tbxRightCountLabel.Text
                        };

                        _selectedAnalyticBehavior.ObjectLineCounter = objectLineCounter;
                    }
                    else if (_selectedAnalyticBehavior.BehaviorType == AnalyticBehavior.AnalyticBehaviorType.ObjectWrongWay)
                    {
                        var objectWrongWayZone = new ObjectWrongWayZone
                        {
                            MinTriggerAngle = (int)nudMinTriggerAngle.Value,
                            Vector = new ZoneVector
                            {
                                Angle = (int)nudVectorAngle.Value,
                                X = (float)nudVectorX.Value,
                                Y = (float)nudVectorY.Value
                            }
                        };

                        foreach (ListViewItem item in lvObjectWrongWayZonePoints.Items)
                        {
                            var x = Convert.ToDecimal(item.SubItems[1].Text);
                            var y = Convert.ToDecimal(item.SubItems[2].Text);
                            objectWrongWayZone.Zone.Add(new GridPoint { X = (float)x, Y = (float)y });
                        }

                        _selectedAnalyticBehavior.ObjectWrongWayZone = objectWrongWayZone;
                    }
                    else
                    {
                        var objectInZone = new ObjectInZone();
                        foreach (ListViewItem item in lvObjectInZonePoints.Items)
                        {
                            var x = Convert.ToDecimal(item.SubItems[1].Text);
                            var y = Convert.ToDecimal(item.SubItems[2].Text);
                            objectInZone.Vertices.Add(new GridPoint { X = (float)x, Y = (float)y });
                        }

                        _selectedAnalyticBehavior.ObjectInZone = objectInZone;
                    }
                }
                else
                {
                    var newAnalyticBehavior = new NewAnalyticBehavior
                    {
                        BehaviorType = (AnalyticBehavior.AnalyticBehaviorType) cbxBehaviorType.SelectedIndex + 1,
                        ObjectType = (AnalyticBehavior.AnalyticObjectType) cbxObjectType.SelectedIndex + 1,
                        Name = tbxName.Text,
                        IsEnabled = ckbxIsEnabled.Checked,
                        Severity = (int) nudSeverity.Value
                    };

                    if (newAnalyticBehavior.BehaviorType == AnalyticBehavior.AnalyticBehaviorType.ObjectLineCounter)
                    {
                        var objectLineCounter = new ObjectLineCounter
                        {
                            EndPoint = {X = (float) nudEndPointX.Value, Y = (float) nudEndPointY.Value},
                            StartPoint = {X = (float) nudStartPointX.Value, Y = (float) nudStartPointY.Value},
                            LineCounterType = (ObjectLineCounter.LineCounterTypes) cbxLineCounterTypes.SelectedIndex + 1,
                            EventsEnabled = ckbxIsEventsEnabled.Checked,
                            EventWindowSecs = (int)nudEventWindow.Value,
                            MaxCountThreshold = (int)nudMaxCountThreshold.Value,
                            LeftCountLabel = tbxLeftCountLabel.Text,
                            RightCountLabel = tbxRightCountLabel.Text
                        };

                        newAnalyticBehavior.ObjectLineCounter = objectLineCounter;
                    }
                    else if (newAnalyticBehavior.BehaviorType == AnalyticBehavior.AnalyticBehaviorType.ObjectWrongWay)
                    {
                        var objectWrongWayZone = new ObjectWrongWayZone
                        {
                            MinTriggerAngle = (int)nudMinTriggerAngle.Value,
                            Vector = new ZoneVector
                            {
                                Angle = (int)nudVectorAngle.Value,
                                X = (float)nudVectorX.Value,
                                Y = (float)nudVectorY.Value
                            }
                        };

                        foreach (ListViewItem item in lvObjectWrongWayZonePoints.Items)
                        {
                            var x = Convert.ToDecimal(item.SubItems[1].Text);
                            var y = Convert.ToDecimal(item.SubItems[2].Text);
                            objectWrongWayZone.Zone.Add(new GridPoint { X = (float)x, Y = (float)y });
                        }

                        newAnalyticBehavior.ObjectWrongWayZone = objectWrongWayZone;
                    }
                    else
                    {
                        var objectInZone = new ObjectInZone();
                        foreach (ListViewItem item in lvObjectInZonePoints.Items)
                        {
                            var x = Convert.ToDecimal(item.SubItems[1].Text);
                            var y = Convert.ToDecimal(item.SubItems[2].Text);
                            objectInZone.Vertices.Add(new GridPoint {X = (float)x, Y = (float)y });
                        }

                        newAnalyticBehavior.ObjectInZone = objectInZone;
                    }

                    _selectedAnalyticConfig.AddAnalyticBehavior(newAnalyticBehavior);
                }
            }
            catch (Exception ex)
            {
                MainForm.Instance.WriteToLog($"Error creating analytic behavior: {ex.Message}");
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

            var lvItem = new ListViewItem(string.Empty);
            lvItem.SubItems.Add(x.ToString(CultureInfo.InvariantCulture));
            lvItem.SubItems.Add(y.ToString(CultureInfo.InvariantCulture));
            lvObjectInZonePoints.Items.Add(lvItem);
        }

        /// <summary>
        /// The ButtonAddZonePoint_Click method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ButtonAddZonePoint_Click(object sender, EventArgs args)
        {
            decimal x = 0;
            decimal y = 0;
            var result = InputBox.Show("Enter Point Values", "X", "Y", ref x, ref y, 0, 99999);
            if (result != DialogResult.OK)
                return;

            var lvItem = new ListViewItem(string.Empty);
            lvItem.SubItems.Add(x.ToString(CultureInfo.InvariantCulture));
            lvItem.SubItems.Add(y.ToString(CultureInfo.InvariantCulture));
            lvObjectWrongWayZonePoints.Items.Add(lvItem);
        }

        /// <summary>
        /// The ButtonRemovePoint_Click method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ButtonRemovePoint_Click(object sender, EventArgs args)
        {
            if (lvObjectInZonePoints.SelectedItems.Count == 0)
                return;

            lvObjectInZonePoints.Items.Remove(lvObjectInZonePoints.SelectedItems[0]);
            lvObjectInZonePoints.Refresh();
        }

        /// <summary>
        /// The ButtonRemoveZonePoint_Click method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ButtonRemoveZonePoint_Click(object sender, EventArgs args)
        {
            if (lvObjectWrongWayZonePoints.SelectedItems.Count == 0)
                return;

            lvObjectWrongWayZonePoints.Items.Remove(lvObjectWrongWayZonePoints.SelectedItems[0]);
            lvObjectWrongWayZonePoints.Refresh();
        }

        /// <summary>
        /// The CheckboxBehaviorType_SelectedIndexChanged method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void CheckboxBehaviorType_SelectedIndexChanged(object sender, EventArgs args)
        {
            gbxObjectCounter.Visible = cbxBehaviorType.SelectedIndex == 0;
            gbxObjectInZone.Visible = cbxBehaviorType.SelectedIndex == 1;
            gbxObjectWrongWayZone.Visible = cbxBehaviorType.SelectedIndex == 2;
        }

        #endregion Private Methods
    }
}