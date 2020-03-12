using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ExampleClient.Properties;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The ManageMonitorSelectionsForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to modify a monitor wall.</remarks>
    public partial class ManageMonitorSelectionsForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ManageMonitorSelectionsForm" /> class.
        /// </summary>
        /// <param name="monitorWall">The monitor wall to edit.</param>
        public ManageMonitorSelectionsForm(MonitorWall monitorWall)
        {
            CurrentMonitorWall = monitorWall;
            CurrentMonitorSelections = new List<MonitorSelection>();

            InitializeComponent();
            pnlMain.AllowDrop = true;

            RefreshSelections(true);

            Refresh();
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Gets or sets the CurrentMonitorSelections property.
        /// </summary>
        /// <value>The current monitor selections.</value>
        private List<MonitorSelection> CurrentMonitorSelections { get; set; }

        /// <summary>
        /// Gets or sets the CurrentMonitorWall property.
        /// </summary>
        /// <value>The current monitor wall.</value>
        private MonitorWall CurrentMonitorWall { get; }

        /// <summary>
        /// Gets or sets the CurrentMonitorWall property.
        /// </summary>
        /// <value>The current monitor wall.</value>
        private int CurrentMonitorIndex { get; set; }

        /// <summary>
        /// Gets or sets the CurrentMonitorWall property.
        /// </summary>
        /// <value>The current monitor wall.</value>
        private int CurrentCellIndex { get; set; }

        public MonitorSelection.CellInputMode CurrentInputMode { get; set; }

        #endregion Private Properties

        #region Public Methods

        public void RefreshSelections(bool redraw = false)
        {
            CurrentMonitorSelections.Clear();
            CurrentMonitorSelections = CurrentMonitorWall.GetMonitorSelections();

            lvMonitors.Items.Clear();
            foreach (var selection in CurrentMonitorSelections)
            {
                var lvItem = new ListViewItem(selection.Owner.Split('@')[0]);
                lvItem.SubItems.Add(selection.Monitor.ToString());
                lvItem.SubItems.Add(selection.Cell.ToString());
                lvItem.SubItems.Add(selection.InputMode.ToString());
                lvItem.Tag = selection;
                lvMonitors.Items.Add(lvItem);
            }

            if (redraw)
            {
                pnlMain.Controls.Clear();
                foreach (var position in CurrentMonitorWall.MonitorPositions)
                    DisplayMonitorPosition(position);
            }

            Refresh();
        }

        /// <summary>
        /// The AddMonitorSelectionPanel method.
        /// </summary>
        /// <param name="monitorPanel">The panel to add.</param>
        /// <param name="monitorName">The name of the monitor.</param>
        public void AddMonitorSelectionPanel(MonitorSelectionPanel monitorPanel, string monitorName)
        {
            var monitorLabel = new Label
            {
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = monitorName,
                Location = Point.Empty,
                Dock = DockStyle.Fill,
                AutoSize = false,
                Size = monitorPanel.Size,
                Tag = monitorPanel
            };

            monitorPanel.BackColor = SystemColors.ControlDarkDark;
            monitorPanel.Controls.Add(monitorLabel);
            pnlMain.Controls.Add(monitorPanel);
        }

        /// <summary>
        /// The DisplayMonitorPosition method.
        /// </summary>
        /// <param name="position">The monitor position to display.</param>
        public void DisplayMonitorPosition(MonitorPosition position)
        {
            var width = position.Position.Width / 2;
            var height = position.Position.Height / 2;

            int left = 0;
            if (position.Position.Left > 0)
                left = position.Position.Left / 2;

            int top = 0;
            if (position.Position.Top > 0)
                top = position.Position.Top / 2;

            if (position.Position.Width < 10)
                width = 10;

            if (position.Position.Height < 10)
                height = 10;

            var monitors = CurrentMonitorWall.Monitors;
            var monitor = monitors.FirstOrDefault(mon => mon.Id == position.MonitorId);
            var monitorIndex = monitors.IndexOf(monitor) + 1;
            Monitor.Layouts layout = monitor?.Layout ?? Monitor.Layouts.CellLayout4x4;

            CurrentCellIndex = 0;
            foreach (MonitorSelection selection in CurrentMonitorSelections)
            {
                if (selection.Owner.Split('@')[0] == MainForm.CurrentUserName && selection.Monitor == monitorIndex)
                {
                    CurrentCellIndex = selection.Cell;
                    CurrentMonitorIndex = selection.Monitor;
                    CurrentInputMode = selection.InputMode;
                }
            }

            var panel = new MonitorSelectionPanel(this, layout, CurrentCellIndex)
            {
                Tag = position,
                Location = new Point(left, top),
                Size = new Size(width, height),
                BorderStyle = BorderStyle.FixedSingle
            };

            foreach (MonitorSelection selection in CurrentMonitorSelections)
            {
                if (selection.Owner.Split('@')[0] != MainForm.CurrentUserName && selection.Monitor == monitorIndex)
                {
                    panel.SelectCell(selection.Cell, selection.Owner.Split('@')[0], CurrentInputMode);
                }
            }

            var monitorIdFilter = new Dictionary<Filters.Value, string> { { Filters.Value.Id, position.MonitorId } };
            var monitorName = MainForm.CurrentSystem.GetMonitors(monitorIdFilter).FirstOrDefault()?.Name ?? position.MonitorId;
            AddMonitorSelectionPanel(panel, monitorName);
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// The SelectionChanged method.
        /// </summary>
        /// <param name="cellIndex">The <paramref name="cellIndex"/> parameter.</param>
        /// <param name="monitorIndex">The <paramref name="monitorIndex"/> parameter.</param>
        public void SelectionChanged(int cellIndex, int monitorIndex)
        {
            CurrentCellIndex = cellIndex;
            CurrentMonitorIndex = monitorIndex;
            CurrentMonitorWall.SetMonitorSelection(cellIndex, monitorIndex, CurrentInputMode);
            RefreshSelections();
        }

        /// <summary>
        /// The ButtonRefresh_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRefresh_Click(object sender, EventArgs args)
        {
            RefreshSelections(true);
        }

        /// <summary>
        /// The ButtonClear_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonClear_Click(object sender, EventArgs args)
        {
            CurrentMonitorWall.ClearMonitorSelection();
            RefreshSelections(true);
        }

        /// <summary>
        /// The ButtonChangeMode_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonChangeMode_Click(object sender, EventArgs args)
        {
            var comboBox = new ComboBox();
            comboBox.Items.Add(MonitorSelection.CellInputMode.Unknown.ToString());
            comboBox.Items.Add(MonitorSelection.CellInputMode.DigitalPtz.ToString());
            comboBox.Items.Add(MonitorSelection.CellInputMode.Navigation.ToString());
            comboBox.Items.Add(MonitorSelection.CellInputMode.Playback.ToString());
            comboBox.Items.Add(MonitorSelection.CellInputMode.Ptz.ToString());
            
            var inputModeValue = (int)CurrentInputMode;
            comboBox.SelectedIndex = inputModeValue;
            InputBox.Show("Cell Input Mode", "Select a new cell input mode:", comboBox, ref inputModeValue);
            var selectedMode = (MonitorSelection.CellInputMode) inputModeValue;
            if (CurrentInputMode != selectedMode)
            {
                CurrentInputMode = selectedMode;
                CurrentMonitorWall.SetMonitorSelection(CurrentCellIndex, CurrentMonitorIndex, CurrentInputMode);
                RefreshSelections(true);
            }
        }

        #endregion Private Methods
    }

    [System.ComponentModel.DesignerCategory("Code")]
    public class MonitorSelectionPanel : Panel
    {
        private readonly TableLayoutPanel _tlpCells = new TableLayoutPanel();
        private readonly Panel _pnlCell01 = new Panel();
        private readonly Label _lblCell01 = new Label();
        private readonly Panel _pnlCell02 = new Panel();
        private readonly Label _lblCell02 = new Label();
        private readonly Panel _pnlCell03 = new Panel();
        private readonly Label _lblCell03 = new Label();
        private readonly Panel _pnlCell04 = new Panel();
        private readonly Label _lblCell04 = new Label();
        private readonly Panel _pnlCell05 = new Panel();
        private readonly Label _lblCell05 = new Label();
        private readonly Panel _pnlCell06 = new Panel();
        private readonly Label _lblCell06 = new Label();
        private readonly Panel _pnlCell07 = new Panel();
        private readonly Label _lblCell07 = new Label();
        private readonly Panel _pnlCell08 = new Panel();
        private readonly Label _lblCell08 = new Label();
        private readonly Panel _pnlCell09 = new Panel();
        private readonly Label _lblCell09 = new Label();
        private readonly Panel _pnlCell10 = new Panel();
        private readonly Label _lblCell10 = new Label();
        private readonly Panel _pnlCell11 = new Panel();
        private readonly Label _lblCell11 = new Label();
        private readonly Panel _pnlCell12 = new Panel();
        private readonly Label _lblCell12 = new Label();
        private readonly Panel _pnlCell13 = new Panel();
        private readonly Label _lblCell13 = new Label();
        private readonly Panel _pnlCell14 = new Panel();
        private readonly Label _lblCell14 = new Label();
        private readonly Panel _pnlCell15 = new Panel();
        private readonly Label _lblCell15 = new Label();
        private readonly Panel _pnlCell16 = new Panel();
        private readonly Label _lblCell16 = new Label();

        #region Public Constructors

        public MonitorSelectionPanel(ManageMonitorSelectionsForm form, Monitor.Layouts layout, int cellIndex)
        {
            ParentForm = form;
            SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            _tlpCells.BackColor = Color.FromArgb(64, 64, 64);
            _tlpCells.ColumnCount = 4;
            _tlpCells.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            _tlpCells.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            _tlpCells.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            _tlpCells.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            _tlpCells.Controls.Add(_pnlCell01, 0, 0);
            _tlpCells.Controls.Add(_pnlCell02, 1, 0);
            _tlpCells.Controls.Add(_pnlCell03, 2, 0);
            _tlpCells.Controls.Add(_pnlCell04, 3, 0);
            _tlpCells.Controls.Add(_pnlCell05, 0, 1);
            _tlpCells.Controls.Add(_pnlCell06, 1, 1);
            _tlpCells.Controls.Add(_pnlCell07, 2, 1);
            _tlpCells.Controls.Add(_pnlCell08, 3, 1);
            _tlpCells.Controls.Add(_pnlCell09, 0, 2);
            _tlpCells.Controls.Add(_pnlCell10, 1, 2);
            _tlpCells.Controls.Add(_pnlCell11, 2, 2);
            _tlpCells.Controls.Add(_pnlCell12, 3, 2);
            _tlpCells.Controls.Add(_pnlCell13, 0, 3);
            _tlpCells.Controls.Add(_pnlCell14, 1, 3);
            _tlpCells.Controls.Add(_pnlCell15, 2, 3);
            _tlpCells.Controls.Add(_pnlCell16, 3, 3);
            _tlpCells.Dock = DockStyle.Fill;
            _tlpCells.Name = "tlpCells";
            _tlpCells.RowCount = 4;
            _tlpCells.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            _tlpCells.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            _tlpCells.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            _tlpCells.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            _tlpCells.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _tlpCells.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));

            // 
            // pnlCell_01
            // 
            _pnlCell01.BackColor = Color.Black;
            _pnlCell01.BackgroundImageLayout = ImageLayout.Center;
            _pnlCell01.Controls.Add(_lblCell01);
            _pnlCell01.Dock = DockStyle.Fill;
            _pnlCell01.Location = new Point(1, 1);
            _pnlCell01.Margin = new Padding(1);
            _pnlCell01.Name = "pnlCell_01";
            _pnlCell01.Padding = new Padding(1);
            _pnlCell01.Size = new Size(158, 158);
            _pnlCell01.TabIndex = 0;
            // 
            // lblCell_01
            // 
            _lblCell01.AllowDrop = true;
            _lblCell01.BackColor = Color.Black;
            _lblCell01.Dock = DockStyle.Fill;
            _lblCell01.ForeColor = Color.White;
            _lblCell01.Image = Resources.CellLogo;
            _lblCell01.Location = new Point(1, 1);
            _lblCell01.Margin = new Padding(1);
            _lblCell01.Name = "lblCell_01";
            _lblCell01.Size = new Size(156, 156);
            _lblCell01.TabIndex = 0;
            _lblCell01.TextAlign = ContentAlignment.MiddleCenter;
            _lblCell01.Click += LabelCell_Click;
            // 
            // pnlCell_02
            // 
            _pnlCell02.BackColor = Color.Black;
            _pnlCell02.BackgroundImageLayout = ImageLayout.Center;
            _pnlCell02.Controls.Add(_lblCell02);
            _pnlCell02.Dock = DockStyle.Fill;
            _pnlCell02.Location = new Point(161, 1);
            _pnlCell02.Margin = new Padding(1);
            _pnlCell02.Name = "pnlCell_02";
            _pnlCell02.Padding = new Padding(1);
            _pnlCell02.Size = new Size(158, 158);
            _pnlCell02.TabIndex = 1;
            // 
            // lblCell_02
            // 
            _lblCell02.AllowDrop = true;
            _lblCell02.BackColor = Color.Black;
            _lblCell02.Dock = DockStyle.Fill;
            _lblCell02.ForeColor = Color.White;
            _lblCell02.Image = Resources.CellLogo;
            _lblCell02.Location = new Point(1, 1);
            _lblCell02.Margin = new Padding(1);
            _lblCell02.Name = "lblCell_02";
            _lblCell02.Size = new Size(156, 156);
            _lblCell02.TabIndex = 1;
            _lblCell02.TextAlign = ContentAlignment.MiddleCenter;
            _lblCell02.Click += LabelCell_Click;
            // 
            // pnlCell_03
            // 
            _pnlCell03.BackColor = Color.Black;
            _pnlCell03.BackgroundImageLayout = ImageLayout.Center;
            _pnlCell03.Controls.Add(_lblCell03);
            _pnlCell03.Dock = DockStyle.Fill;
            _pnlCell03.Location = new Point(321, 1);
            _pnlCell03.Margin = new Padding(1);
            _pnlCell03.Name = "pnlCell_03";
            _pnlCell03.Padding = new Padding(1);
            _pnlCell03.Size = new Size(158, 158);
            _pnlCell03.TabIndex = 2;
            // 
            // lblCell_03
            // 
            _lblCell03.AllowDrop = true;
            _lblCell03.BackColor = Color.Black;
            _lblCell03.Dock = DockStyle.Fill;
            _lblCell03.ForeColor = Color.White;
            _lblCell03.Image = Resources.CellLogo;
            _lblCell03.Location = new Point(1, 1);
            _lblCell03.Margin = new Padding(1);
            _lblCell03.Name = "lblCell_03";
            _lblCell03.Size = new Size(156, 156);
            _lblCell03.TabIndex = 1;
            _lblCell03.TextAlign = ContentAlignment.MiddleCenter;
            _lblCell03.Click += LabelCell_Click;
            // 
            // pnlCell_04
            // 
            _pnlCell04.BackColor = Color.Black;
            _pnlCell04.BackgroundImageLayout = ImageLayout.Center;
            _pnlCell04.Controls.Add(_lblCell04);
            _pnlCell04.Dock = DockStyle.Fill;
            _pnlCell04.Location = new Point(481, 1);
            _pnlCell04.Margin = new Padding(1);
            _pnlCell04.Name = "pnlCell_04";
            _pnlCell04.Padding = new Padding(1);
            _pnlCell04.Size = new Size(158, 158);
            _pnlCell04.TabIndex = 3;
            // 
            // lblCell_04
            // 
            _lblCell04.AllowDrop = true;
            _lblCell04.BackColor = Color.Black;
            _lblCell04.Dock = DockStyle.Fill;
            _lblCell04.ForeColor = Color.White;
            _lblCell04.Image = Resources.CellLogo;
            _lblCell04.Location = new Point(1, 1);
            _lblCell04.Margin = new Padding(1);
            _lblCell04.Name = "lblCell_04";
            _lblCell04.Size = new Size(156, 156);
            _lblCell04.TabIndex = 1;
            _lblCell04.TextAlign = ContentAlignment.MiddleCenter;
            _lblCell04.Click += LabelCell_Click;
            // 
            // pnlCell_05
            // 
            _pnlCell05.BackColor = Color.Black;
            _pnlCell05.BackgroundImageLayout = ImageLayout.Center;
            _pnlCell05.Controls.Add(_lblCell05);
            _pnlCell05.Dock = DockStyle.Fill;
            _pnlCell05.Location = new Point(1, 161);
            _pnlCell05.Margin = new Padding(1);
            _pnlCell05.Name = "pnlCell_05";
            _pnlCell05.Padding = new Padding(1);
            _pnlCell05.Size = new Size(158, 158);
            _pnlCell05.TabIndex = 4;
            // 
            // lblCell_05
            // 
            _lblCell05.AllowDrop = true;
            _lblCell05.BackColor = Color.Black;
            _lblCell05.Dock = DockStyle.Fill;
            _lblCell05.ForeColor = Color.White;
            _lblCell05.Image = Resources.CellLogo;
            _lblCell05.Location = new Point(1, 1);
            _lblCell05.Margin = new Padding(1);
            _lblCell05.Name = "lblCell_05";
            _lblCell05.Size = new Size(156, 156);
            _lblCell05.TabIndex = 1;
            _lblCell05.TextAlign = ContentAlignment.MiddleCenter;
            _lblCell05.Click += LabelCell_Click;
            // 
            // pnlCell_06
            // 
            _pnlCell06.BackColor = Color.Black;
            _pnlCell06.BackgroundImageLayout = ImageLayout.Center;
            _pnlCell06.Controls.Add(_lblCell06);
            _pnlCell06.Dock = DockStyle.Fill;
            _pnlCell06.Location = new Point(161, 161);
            _pnlCell06.Margin = new Padding(1);
            _pnlCell06.Name = "pnlCell_06";
            _pnlCell06.Padding = new Padding(1);
            _pnlCell06.Size = new Size(158, 158);
            _pnlCell06.TabIndex = 5;
            // 
            // lblCell_06
            // 
            _lblCell06.AllowDrop = true;
            _lblCell06.BackColor = Color.Black;
            _lblCell06.Dock = DockStyle.Fill;
            _lblCell06.ForeColor = Color.White;
            _lblCell06.Image = Resources.CellLogo;
            _lblCell06.Location = new Point(1, 1);
            _lblCell06.Margin = new Padding(1);
            _lblCell06.Name = "lblCell_06";
            _lblCell06.Size = new Size(156, 156);
            _lblCell06.TabIndex = 1;
            _lblCell06.TextAlign = ContentAlignment.MiddleCenter;
            _lblCell06.Click += LabelCell_Click;
            // 
            // pnlCell_07
            // 
            _pnlCell07.BackColor = Color.Black;
            _pnlCell07.BackgroundImageLayout = ImageLayout.Center;
            _pnlCell07.Controls.Add(_lblCell07);
            _pnlCell07.Dock = DockStyle.Fill;
            _pnlCell07.Location = new Point(321, 161);
            _pnlCell07.Margin = new Padding(1);
            _pnlCell07.Name = "pnlCell_07";
            _pnlCell07.Padding = new Padding(1);
            _pnlCell07.Size = new Size(158, 158);
            _pnlCell07.TabIndex = 6;
            // 
            // lblCell_07
            // 
            _lblCell07.AllowDrop = true;
            _lblCell07.BackColor = Color.Black;
            _lblCell07.Dock = DockStyle.Fill;
            _lblCell07.ForeColor = Color.White;
            _lblCell07.Image = Resources.CellLogo;
            _lblCell07.Location = new Point(1, 1);
            _lblCell07.Margin = new Padding(1);
            _lblCell07.Name = "lblCell_07";
            _lblCell07.Size = new Size(156, 156);
            _lblCell07.TabIndex = 1;
            _lblCell07.TextAlign = ContentAlignment.MiddleCenter;
            _lblCell07.Click += LabelCell_Click;
            // 
            // pnlCell_08
            // 
            _pnlCell08.BackColor = Color.Black;
            _pnlCell08.BackgroundImageLayout = ImageLayout.Center;
            _pnlCell08.Controls.Add(_lblCell08);
            _pnlCell08.Dock = DockStyle.Fill;
            _pnlCell08.Location = new Point(481, 161);
            _pnlCell08.Margin = new Padding(1);
            _pnlCell08.Name = "pnlCell_08";
            _pnlCell08.Padding = new Padding(1);
            _pnlCell08.Size = new Size(158, 158);
            _pnlCell08.TabIndex = 7;
            // 
            // lblCell_08
            // 
            _lblCell08.AllowDrop = true;
            _lblCell08.BackColor = Color.Black;
            _lblCell08.Dock = DockStyle.Fill;
            _lblCell08.ForeColor = Color.White;
            _lblCell08.Image = Resources.CellLogo;
            _lblCell08.Location = new Point(1, 1);
            _lblCell08.Margin = new Padding(1);
            _lblCell08.Name = "lblCell_08";
            _lblCell08.Size = new Size(156, 156);
            _lblCell08.TabIndex = 1;
            _lblCell08.TextAlign = ContentAlignment.MiddleCenter;
            _lblCell08.Click += LabelCell_Click;
            // 
            // pnlCell_09
            // 
            _pnlCell09.BackColor = Color.Black;
            _pnlCell09.BackgroundImageLayout = ImageLayout.Center;
            _pnlCell09.Controls.Add(_lblCell09);
            _pnlCell09.Dock = DockStyle.Fill;
            _pnlCell09.Location = new Point(1, 321);
            _pnlCell09.Margin = new Padding(1);
            _pnlCell09.Name = "pnlCell_09";
            _pnlCell09.Padding = new Padding(1);
            _pnlCell09.Size = new Size(158, 158);
            _pnlCell09.TabIndex = 8;
            // 
            // lblCell_09
            // 
            _lblCell09.AllowDrop = true;
            _lblCell09.BackColor = Color.Black;
            _lblCell09.Dock = DockStyle.Fill;
            _lblCell09.ForeColor = Color.White;
            _lblCell09.Image = Resources.CellLogo;
            _lblCell09.Location = new Point(1, 1);
            _lblCell09.Margin = new Padding(1);
            _lblCell09.Name = "lblCell_09";
            _lblCell09.Size = new Size(156, 156);
            _lblCell09.TabIndex = 1;
            _lblCell09.TextAlign = ContentAlignment.MiddleCenter;
            _lblCell09.Click += LabelCell_Click;
            // 
            // pnlCell_10
            // 
            _pnlCell10.BackColor = Color.Black;
            _pnlCell10.BackgroundImageLayout = ImageLayout.Center;
            _pnlCell10.Controls.Add(_lblCell10);
            _pnlCell10.Dock = DockStyle.Fill;
            _pnlCell10.Location = new Point(161, 321);
            _pnlCell10.Margin = new Padding(1);
            _pnlCell10.Name = "pnlCell_10";
            _pnlCell10.Padding = new Padding(1);
            _pnlCell10.Size = new Size(158, 158);
            _pnlCell10.TabIndex = 9;
            // 
            // lblCell_10
            // 
            _lblCell10.AllowDrop = true;
            _lblCell10.BackColor = Color.Black;
            _lblCell10.Dock = DockStyle.Fill;
            _lblCell10.ForeColor = Color.White;
            _lblCell10.Image = Resources.CellLogo;
            _lblCell10.Location = new Point(1, 1);
            _lblCell10.Margin = new Padding(1);
            _lblCell10.Name = "lblCell_10";
            _lblCell10.Size = new Size(156, 156);
            _lblCell10.TabIndex = 1;
            _lblCell10.TextAlign = ContentAlignment.MiddleCenter;
            _lblCell10.Click += LabelCell_Click;
            // 
            // pnlCell_11
            // 
            _pnlCell11.BackColor = Color.Black;
            _pnlCell11.BackgroundImageLayout = ImageLayout.Center;
            _pnlCell11.Controls.Add(_lblCell11);
            _pnlCell11.Dock = DockStyle.Fill;
            _pnlCell11.Location = new Point(321, 321);
            _pnlCell11.Margin = new Padding(1);
            _pnlCell11.Name = "pnlCell_11";
            _pnlCell11.Padding = new Padding(1);
            _pnlCell11.Size = new Size(158, 158);
            _pnlCell11.TabIndex = 10;
            // 
            // lblCell_11
            // 
            _lblCell11.AllowDrop = true;
            _lblCell11.BackColor = Color.Black;
            _lblCell11.Dock = DockStyle.Fill;
            _lblCell11.ForeColor = Color.White;
            _lblCell11.Image = Resources.CellLogo;
            _lblCell11.Location = new Point(1, 1);
            _lblCell11.Margin = new Padding(1);
            _lblCell11.Name = "lblCell_11";
            _lblCell11.Size = new Size(156, 156);
            _lblCell11.TabIndex = 1;
            _lblCell11.TextAlign = ContentAlignment.MiddleCenter;
            _lblCell11.Click += LabelCell_Click;
            // 
            // pnlCell_12
            // 
            _pnlCell12.BackColor = Color.Black;
            _pnlCell12.BackgroundImageLayout = ImageLayout.Center;
            _pnlCell12.Controls.Add(_lblCell12);
            _pnlCell12.Dock = DockStyle.Fill;
            _pnlCell12.Location = new Point(481, 321);
            _pnlCell12.Margin = new Padding(1);
            _pnlCell12.Name = "pnlCell_12";
            _pnlCell12.Padding = new Padding(1);
            _pnlCell12.Size = new Size(158, 158);
            _pnlCell12.TabIndex = 11;
            // 
            // lblCell_12
            // 
            _lblCell12.AllowDrop = true;
            _lblCell12.BackColor = Color.Black;
            _lblCell12.Dock = DockStyle.Fill;
            _lblCell12.ForeColor = Color.White;
            _lblCell12.Image = Resources.CellLogo;
            _lblCell12.Location = new Point(1, 1);
            _lblCell12.Margin = new Padding(1);
            _lblCell12.Name = "lblCell_12";
            _lblCell12.Size = new Size(156, 156);
            _lblCell12.TabIndex = 1;
            _lblCell12.TextAlign = ContentAlignment.MiddleCenter;
            _lblCell12.Click += LabelCell_Click;
            // 
            // pnlCell_13
            // 
            _pnlCell13.BackColor = Color.Black;
            _pnlCell13.BackgroundImageLayout = ImageLayout.Center;
            _pnlCell13.Controls.Add(_lblCell13);
            _pnlCell13.Dock = DockStyle.Fill;
            _pnlCell13.Location = new Point(1, 481);
            _pnlCell13.Margin = new Padding(1);
            _pnlCell13.Name = "pnlCell_13";
            _pnlCell13.Padding = new Padding(1);
            _pnlCell13.Size = new Size(158, 158);
            _pnlCell13.TabIndex = 12;
            // 
            // lblCell_13
            // 
            _lblCell13.AllowDrop = true;
            _lblCell13.BackColor = Color.Black;
            _lblCell13.Dock = DockStyle.Fill;
            _lblCell13.ForeColor = Color.White;
            _lblCell13.Image = Resources.CellLogo;
            _lblCell13.Location = new Point(1, 1);
            _lblCell13.Margin = new Padding(1);
            _lblCell13.Name = "lblCell_13";
            _lblCell13.Size = new Size(156, 156);
            _lblCell13.TabIndex = 1;
            _lblCell13.TextAlign = ContentAlignment.MiddleCenter;
            _lblCell13.Click += LabelCell_Click;
            // 
            // pnlCell_14
            // 
            _pnlCell14.BackColor = Color.Black;
            _pnlCell14.BackgroundImageLayout = ImageLayout.Center;
            _pnlCell14.Controls.Add(_lblCell14);
            _pnlCell14.Dock = DockStyle.Fill;
            _pnlCell14.Location = new Point(161, 481);
            _pnlCell14.Margin = new Padding(1);
            _pnlCell14.Name = "pnlCell_14";
            _pnlCell14.Padding = new Padding(1);
            _pnlCell14.Size = new Size(158, 158);
            _pnlCell14.TabIndex = 13;
            // 
            // lblCell_14
            // 
            _lblCell14.AllowDrop = true;
            _lblCell14.BackColor = Color.Black;
            _lblCell14.Dock = DockStyle.Fill;
            _lblCell14.ForeColor = Color.White;
            _lblCell14.Image = Resources.CellLogo;
            _lblCell14.Location = new Point(1, 1);
            _lblCell14.Margin = new Padding(1);
            _lblCell14.Name = "lblCell_14";
            _lblCell14.Size = new Size(156, 156);
            _lblCell14.TabIndex = 1;
            _lblCell14.TextAlign = ContentAlignment.MiddleCenter;
            _lblCell14.Click += LabelCell_Click;
            // 
            // pnlCell_15
            // 
            _pnlCell15.BackColor = Color.Black;
            _pnlCell15.BackgroundImageLayout = ImageLayout.Center;
            _pnlCell15.Controls.Add(_lblCell15);
            _pnlCell15.Dock = DockStyle.Fill;
            _pnlCell15.Location = new Point(321, 481);
            _pnlCell15.Margin = new Padding(1);
            _pnlCell15.Name = "pnlCell_15";
            _pnlCell15.Padding = new Padding(1);
            _pnlCell15.Size = new Size(158, 158);
            _pnlCell15.TabIndex = 14;
            // 
            // lblCell_15
            // 
            _lblCell15.AllowDrop = true;
            _lblCell15.BackColor = Color.Black;
            _lblCell15.Dock = DockStyle.Fill;
            _lblCell15.ForeColor = Color.White;
            _lblCell15.Image = Resources.CellLogo;
            _lblCell15.Location = new Point(1, 1);
            _lblCell15.Margin = new Padding(1);
            _lblCell15.Name = "lblCell_15";
            _lblCell15.Size = new Size(156, 156);
            _lblCell15.TabIndex = 1;
            _lblCell15.TextAlign = ContentAlignment.MiddleCenter;
            _lblCell15.Click += LabelCell_Click;
            // 
            // pnlCell_16
            // 
            _pnlCell16.BackColor = Color.Black;
            _pnlCell16.BackgroundImageLayout = ImageLayout.Center;
            _pnlCell16.Controls.Add(_lblCell16);
            _pnlCell16.Dock = DockStyle.Fill;
            _pnlCell16.Location = new Point(481, 481);
            _pnlCell16.Margin = new Padding(1);
            _pnlCell16.Name = "pnlCell_16";
            _pnlCell16.Padding = new Padding(1);
            _pnlCell16.Size = new Size(158, 158);
            _pnlCell16.TabIndex = 15;
            // 
            // lblCell_16
            // 
            _lblCell16.AllowDrop = true;
            _lblCell16.BackColor = Color.Black;
            _lblCell16.Dock = DockStyle.Fill;
            _lblCell16.ForeColor = Color.White;
            _lblCell16.Image = Resources.CellLogo;
            _lblCell16.Location = new Point(1, 1);
            _lblCell16.Margin = new Padding(1);
            _lblCell16.Name = "lblCell_16";
            _lblCell16.Size = new Size(156, 156);
            _lblCell16.TabIndex = 1;
            _lblCell16.TextAlign = ContentAlignment.MiddleCenter;
            _lblCell16.Click += LabelCell_Click;

            Controls.Add(_tlpCells);

            SetCellLayout(layout);
            SelectCell(cellIndex, MainForm.CurrentUserName, ParentForm.CurrentInputMode);
        }

        #endregion Public Constructors

        /// <summary>
        /// Gets or sets the LastSelectedPanel property.
        /// </summary>
        /// <value>The last panel selected by the user.</value>
        public Dictionary<string, Panel> SelectedPanels { get; set; } = new Dictionary<string, Panel>();

        private ManageMonitorSelectionsForm ParentForm { get; set; }

        /// <summary>
        /// The LabelCell_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void LabelCell_Click(object sender, EventArgs args)
        {
            // Get the label that was clicked.
            var label = sender as Label;

            // Get the parent panel of the label.
            var panel = label?.Parent as Panel;
            if (panel == null)
                return;

            // Set the highlight for the selected panel.
            SelectCell(panel.TabIndex + 1, MainForm.CurrentUserName, ParentForm.CurrentInputMode);
            ParentForm.SelectionChanged(panel.TabIndex + 1, 1);
        }

        private Color GetBorderColor(MonitorSelection.CellInputMode inputMode)
        {
            switch (inputMode)
            {
                case MonitorSelection.CellInputMode.DigitalPtz:
                    return Color.MediumPurple;
                case MonitorSelection.CellInputMode.Playback:
                    return Color.Orange;
                case MonitorSelection.CellInputMode.Ptz:
                    return Color.SteelBlue;
                default:
                    return Color.ForestGreen;
            }
        }

        /// <summary>
        /// The LabelCell_Click method.
        /// </summary>
        /// <param name="cellIndex">The <paramref name="cellIndex"/> parameter.</param>
        public void SelectCell(int cellIndex, string userName, MonitorSelection.CellInputMode inputMode)
        {
            var currentUserColor = GetBorderColor(inputMode);
            var panel = _tlpCells.Controls.OfType<Panel>().FirstOrDefault(ctrl => ctrl.TabIndex == cellIndex - 1);
            if (panel != null)
            {
                // Set the highlight for the selected panel.
                if (SelectedPanels.ContainsKey(userName))
                {
                    if (SelectedPanels[userName] == panel)
                        return;

                    var currlabel = panel.Controls[0] as Label;
                    if (userName == MainForm.CurrentUserName)
                    {
                        currlabel.Text = userName;
                        panel.BackColor = currentUserColor;
                    }
                    else
                    {
                        if (panel.BackColor != currentUserColor)
                        {
                            currlabel.Text = userName;
                            panel.BackColor = Color.White;
                        }
                    }


                    var oldUserName = SelectedPanels[userName].Tag as string;
                    var prevLabel = SelectedPanels[userName].Controls[0] as Label;
                    if (oldUserName == null)
                    {
                        prevLabel.Text = string.Empty;
                        SelectedPanels[userName].BackColor = Color.Black;
                    }
                    else
                    {
                        prevLabel.Text = oldUserName;
                        SelectedPanels[userName].BackColor = Color.White;
                    }

                    SelectedPanels[userName] = panel;
                }
                else
                {
                    if (userName == MainForm.CurrentUserName)
                        panel.BackColor = currentUserColor;
                    else
                    {
                        panel.Tag = userName;
                        if (panel.BackColor != currentUserColor)
                            panel.BackColor = Color.White;
                    }

                    var label = panel.Controls[0] as Label;
                    if (label != null)
                    {
                        label.Text = userName;
                    }

                    SelectedPanels.Add(userName, panel);
                }
            }
        }

        #region Protected Methods

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var brush = new SolidBrush(BackColor))
                e.Graphics.FillRectangle(brush, ClientRectangle);
            e.Graphics.DrawRectangle(Pens.White, 0, 0, ClientSize.Width - 2, ClientSize.Height - 2);
        }

        /// <summary>
        /// Adjusts the cells within the table layout panel based on the selected monitor layout.
        /// </summary>
        private void SetCellLayout(Monitor.Layouts layout)
        {
            // Adjust the table layout panel cells based on the layout.
            switch (layout)
            {
                case Monitor.Layouts.CellLayout1x1:
                    _tlpCells.ColumnCount = 1;
                    _tlpCells.ColumnStyles[0].Width = 100;
                    _tlpCells.RowStyles[0].Height = 100;
                    DisableExtraRows(1);
                    break;

                case Monitor.Layouts.CellLayout1x2:
                    _tlpCells.ColumnCount = 1;
                    _tlpCells.ColumnStyles[0].Width = 100;
                    _tlpCells.RowStyles[0].Height = 50;
                    _tlpCells.RowStyles[1].Height = 50;
                    DisableExtraRows(2);
                    break;

                case Monitor.Layouts.CellLayout2x1:
                    _tlpCells.ColumnCount = 2;
                    _tlpCells.ColumnStyles[0].Width = 50;
                    _tlpCells.ColumnStyles[1].Width = 50;
                    _tlpCells.RowStyles[0].Height = 100;
                    DisableExtraRows(1);
                    break;

                case Monitor.Layouts.CellLayout2x2:
                    _tlpCells.ColumnCount = 2;
                    _tlpCells.ColumnStyles[0].Width = 50;
                    _tlpCells.ColumnStyles[1].Width = 50;
                    _tlpCells.RowStyles[0].Height = 50;
                    _tlpCells.RowStyles[1].Height = 50;
                    DisableExtraRows(2);
                    break;

                case Monitor.Layouts.CellLayout2x3:
                    _tlpCells.ColumnCount = 2;
                    _tlpCells.ColumnStyles[0].Width = 50;
                    _tlpCells.ColumnStyles[1].Width = 50;
                    _tlpCells.RowStyles[0].Height = 33.3f;
                    _tlpCells.RowStyles[1].Height = 33.3f;
                    _tlpCells.RowStyles[2].Height = 33.3f;
                    DisableExtraRows(3);
                    break;

                case Monitor.Layouts.CellLayout3x2:
                    _tlpCells.ColumnCount = 3;
                    _tlpCells.ColumnStyles[0].Width = 33.3f;
                    _tlpCells.ColumnStyles[1].Width = 33.3f;
                    _tlpCells.ColumnStyles[2].Width = 33.3f;
                    _tlpCells.RowStyles[0].Height = 50;
                    _tlpCells.RowStyles[1].Height = 50;
                    DisableExtraRows(2);
                    break;

                case Monitor.Layouts.CellLayout3x3:
                    _tlpCells.ColumnCount = 3;
                    _tlpCells.ColumnStyles[0].Width = 33.3f;
                    _tlpCells.ColumnStyles[1].Width = 33.3f;
                    _tlpCells.ColumnStyles[2].Width = 33.3f;
                    _tlpCells.RowStyles[0].Height = 33.3f;
                    _tlpCells.RowStyles[1].Height = 33.3f;
                    _tlpCells.RowStyles[2].Height = 33.3f;
                    DisableExtraRows(3);
                    break;

                case Monitor.Layouts.CellLayout4x3:
                    _tlpCells.ColumnStyles[0].Width = 25;
                    _tlpCells.ColumnStyles[1].Width = 25;
                    _tlpCells.ColumnStyles[2].Width = 25;
                    _tlpCells.ColumnStyles[3].Width = 25;
                    _tlpCells.RowStyles[0].Height = 33.3f;
                    _tlpCells.RowStyles[1].Height = 33.3f;
                    _tlpCells.RowStyles[2].Height = 33.3f;
                    DisableExtraRows(3);
                    break;

                case Monitor.Layouts.CellLayout4x4:
                    _tlpCells.ColumnStyles[0].Width = 25;
                    _tlpCells.ColumnStyles[1].Width = 25;
                    _tlpCells.ColumnStyles[2].Width = 25;
                    _tlpCells.ColumnStyles[3].Width = 25;
                    _tlpCells.RowStyles[0].Height = 25;
                    _tlpCells.RowStyles[1].Height = 25;
                    _tlpCells.RowStyles[2].Height = 25;
                    _tlpCells.RowStyles[3].Height = 25;
                    break;

                case Monitor.Layouts.CellLayout1plus12:
                    _tlpCells.SetColumnSpan(_pnlCell01, 2);
                    _tlpCells.SetRowSpan(_pnlCell01, 2);
                    _tlpCells.ColumnStyles[0].Width = 25;
                    _tlpCells.ColumnStyles[1].Width = 25;
                    _tlpCells.ColumnStyles[2].Width = 25;
                    _tlpCells.ColumnStyles[3].Width = 25;
                    _tlpCells.RowStyles[0].Height = 25;
                    _tlpCells.RowStyles[1].Height = 25;
                    _tlpCells.RowStyles[2].Height = 25;
                    _tlpCells.RowStyles[3].Height = 25;
                    DisableExtraRows(4);
                    break;

                case Monitor.Layouts.CellLayout2plus8:
                    _tlpCells.SetColumnSpan(_pnlCell01, 2);
                    _tlpCells.SetColumnSpan(_pnlCell02, 2);
                    _tlpCells.SetRowSpan(_pnlCell01, 2);
                    _tlpCells.SetRowSpan(_pnlCell02, 2);
                    _tlpCells.ColumnStyles[0].Width = 25;
                    _tlpCells.ColumnStyles[1].Width = 25;
                    _tlpCells.ColumnStyles[2].Width = 25;
                    _tlpCells.ColumnStyles[3].Width = 25;
                    _tlpCells.RowStyles[0].Height = 25;
                    _tlpCells.RowStyles[1].Height = 25;
                    _tlpCells.RowStyles[2].Height = 25;
                    _tlpCells.RowStyles[3].Height = 25;
                    DisableExtraRows(4);
                    break;

                case Monitor.Layouts.CellLayout3plus4:
                    _tlpCells.SetColumnSpan(_pnlCell01, 2);
                    _tlpCells.SetColumnSpan(_pnlCell02, 2);
                    _tlpCells.SetColumnSpan(_pnlCell03, 2);
                    _tlpCells.SetRowSpan(_pnlCell01, 2);
                    _tlpCells.SetRowSpan(_pnlCell02, 2);
                    _tlpCells.SetRowSpan(_pnlCell03, 2);
                    _tlpCells.ColumnStyles[0].Width = 25;
                    _tlpCells.ColumnStyles[1].Width = 25;
                    _tlpCells.ColumnStyles[2].Width = 25;
                    _tlpCells.ColumnStyles[3].Width = 25;
                    _tlpCells.RowStyles[0].Height = 25;
                    _tlpCells.RowStyles[1].Height = 25;
                    _tlpCells.RowStyles[2].Height = 25;
                    _tlpCells.RowStyles[3].Height = 25;
                    DisableExtraRows(4);
                    break;

                case Monitor.Layouts.CellLayout1plus5:
                    _tlpCells.ColumnCount = 3;
                    _tlpCells.SetColumnSpan(_pnlCell01, 2);
                    _tlpCells.SetRowSpan(_pnlCell01, 2);
                    _tlpCells.ColumnStyles[0].Width = 33.3f;
                    _tlpCells.ColumnStyles[1].Width = 33.3f;
                    _tlpCells.ColumnStyles[2].Width = 33.3f;
                    _tlpCells.RowStyles[0].Height = 33.3f;
                    _tlpCells.RowStyles[1].Height = 33.3f;
                    _tlpCells.RowStyles[2].Height = 33.3f;
                    DisableExtraRows(3);
                    break;

                case Monitor.Layouts.CellLayout1plus7:
                    _tlpCells.SetColumnSpan(_pnlCell01, 3);
                    _tlpCells.SetRowSpan(_pnlCell01, 3);
                    _tlpCells.ColumnStyles[0].Width = 25;
                    _tlpCells.ColumnStyles[1].Width = 25;
                    _tlpCells.ColumnStyles[2].Width = 25;
                    _tlpCells.ColumnStyles[3].Width = 25;
                    _tlpCells.RowStyles[0].Height = 25;
                    _tlpCells.RowStyles[1].Height = 25;
                    _tlpCells.RowStyles[2].Height = 25;
                    _tlpCells.RowStyles[3].Height = 25;
                    DisableExtraRows(4);
                    break;

                case Monitor.Layouts.CellLayout12plus1:
                    _tlpCells.SetColumnSpan(_pnlCell06, 2);
                    _tlpCells.SetRowSpan(_pnlCell06, 2);
                    _tlpCells.ColumnStyles[0].Width = 25;
                    _tlpCells.ColumnStyles[1].Width = 25;
                    _tlpCells.ColumnStyles[2].Width = 25;
                    _tlpCells.ColumnStyles[3].Width = 25;
                    _tlpCells.RowStyles[0].Height = 25;
                    _tlpCells.RowStyles[1].Height = 25;
                    _tlpCells.RowStyles[2].Height = 25;
                    _tlpCells.RowStyles[3].Height = 25;
                    DisableExtraRows(4);
                    break;

                case Monitor.Layouts.CellLayout8plus2:
                    _tlpCells.SetColumnSpan(_pnlCell05, 2);
                    _tlpCells.SetColumnSpan(_pnlCell06, 2);
                    _tlpCells.SetRowSpan(_pnlCell05, 2);
                    _tlpCells.SetRowSpan(_pnlCell06, 2);
                    _tlpCells.ColumnStyles[0].Width = 25;
                    _tlpCells.ColumnStyles[1].Width = 25;
                    _tlpCells.ColumnStyles[2].Width = 25;
                    _tlpCells.ColumnStyles[3].Width = 25;
                    _tlpCells.RowStyles[0].Height = 25;
                    _tlpCells.RowStyles[1].Height = 25;
                    _tlpCells.RowStyles[2].Height = 25;
                    _tlpCells.RowStyles[3].Height = 25;
                    DisableExtraRows(4);
                    break;

                case Monitor.Layouts.CellLayout1plus4tall:
                    _tlpCells.SetColumnSpan(_pnlCell01, 3);
                    _tlpCells.SetRowSpan(_pnlCell01, 4);
                    _tlpCells.ColumnStyles[0].Width = 25;
                    _tlpCells.ColumnStyles[1].Width = 25;
                    _tlpCells.ColumnStyles[2].Width = 25;
                    _tlpCells.ColumnStyles[3].Width = 25;
                    _tlpCells.RowStyles[0].Height = 25;
                    _tlpCells.RowStyles[1].Height = 25;
                    _tlpCells.RowStyles[2].Height = 25;
                    _tlpCells.RowStyles[3].Height = 25;
                    DisableExtraRows(4);
                    break;

                case Monitor.Layouts.CellLayout1plus4wide:
                    _tlpCells.SetColumnSpan(_pnlCell01, 4);
                    _tlpCells.SetRowSpan(_pnlCell01, 3);
                    _tlpCells.ColumnStyles[0].Width = 25;
                    _tlpCells.ColumnStyles[1].Width = 25;
                    _tlpCells.ColumnStyles[2].Width = 25;
                    _tlpCells.ColumnStyles[3].Width = 25;
                    _tlpCells.RowStyles[0].Height = 25;
                    _tlpCells.RowStyles[1].Height = 25;
                    _tlpCells.RowStyles[2].Height = 25;
                    _tlpCells.RowStyles[3].Height = 25;
                    DisableExtraRows(4);
                    break;

                default:
                    MainForm.Instance.WriteToLog("Unknown Monitor Layout Selected.");
                    break;
            }

            // Set the labels for the cells and refresh the UI.
            Refresh();
        }

        /// <summary>
        /// Adjusts the cells within the table layout panel based on the selected monitor layout.
        /// </summary>
        private void DisableExtraRows(int startingRowIndex)
        {
            // Set the height for each row beyond the start index to 0.
            for (var i = 0; i <= _tlpCells.RowStyles.Count; i++)
                if (i > startingRowIndex)
                    _tlpCells.RowStyles[i - 1].Height = 0;
        }

        #endregion Protected Methods
    }
}