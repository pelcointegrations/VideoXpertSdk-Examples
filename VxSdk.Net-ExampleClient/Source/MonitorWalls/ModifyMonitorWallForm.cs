using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The ModifyMonitorWallForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to modify a monitor wall.</remarks>
    public partial class ModifyMonitorWallForm : Form
    {
        /// <summary>
        /// Gets or sets the CurrentMonitorWall property.
        /// </summary>
        /// <value>The current monitor wall.</value>
        private MonitorWall CurrentMonitorWall { get; }

        /// <summary>
        /// Gets or sets the CurrentMonitorPositions property.
        /// </summary>
        /// <value>The current monitor positions.</value>
        private List<MonitorPosition> CurrentMonitorPositions { get; }

        /// <summary>
        /// Gets or sets the NewMonitorWallName property.
        /// </summary>
        /// <value>The name to use for renaming the monitor wall.</value>
        private string NewMonitorWallName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the mouse is clicked.
        /// </summary>
        /// <value>The current mouse down status.</value>
        private bool IsMouseDown { get; set; }

        /// <summary>
        /// Gets or sets the LastX property.
        /// </summary>
        /// <value>The last X coordinate.</value>
        private int LastX { get; set; }

        /// <summary>
        /// Gets or sets the LastY property.
        /// </summary>
        /// <value>The last Y coordinate.</value>
        private int LastY { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyMonitorWallForm" /> class.
        /// </summary>
        /// <param name="monitorWall">The monitor wall to edit.</param>
        public ModifyMonitorWallForm(MonitorWall monitorWall)
        {
            CurrentMonitorWall = monitorWall;
            CurrentMonitorPositions = monitorWall.MonitorPositions;

            InitializeComponent();
            Text = $@"Edit {CurrentMonitorWall.Name}";
            pnlMain.AllowDrop = true;

            foreach (var monitor in MainForm.CurrentSystem.Monitors)
            {
                var lvItem = new ListViewItem(monitor.Name);
                lvItem.SubItems.Add(monitor.Number.ToString());
                lvItem.Tag = monitor;
                lvMonitors.Items.Add(lvItem);
            }

            if (CurrentMonitorPositions.Count == 0)
                return;

            foreach (var position in CurrentMonitorPositions)
                DisplayMonitorPosition(position);

            Refresh();
        }


        /// <summary>
        /// The DisplayMonitorPosition method.
        /// </summary>
        /// <param name="position">The monitor position to display.</param>
        public void DisplayMonitorPosition(MonitorPosition position)
        {
            var width = position.Position.Width;
            var height = position.Position.Height;

            if (position.Position.Width < 10)
                width = 10;

            if (position.Position.Height < 10)
                height = 10;

            var panel = new MonitorPanel
            {
                Tag = position,
                Location = new Point(position.Position.Left, position.Position.Top),
                Size = new Size(width, height),
                BorderStyle = BorderStyle.FixedSingle
            };

            var monitorIdFilter = new Dictionary<Filters.Value, string> { { Filters.Value.Id, position.MonitorId } };
            var monitorName = MainForm.CurrentSystem.GetMonitors(monitorIdFilter).FirstOrDefault()?.Name ?? position.MonitorId;
            AddMonitorPanel(panel, monitorName);
        }

        /// <summary>
        /// The DisplayNewMonitor method.
        /// </summary>
        /// <param name="monitor">The monitor to display.</param>
        /// <param name="location">The location of the new monitor.</param>
        public void DisplayNewMonitor(Monitor monitor, Point location)
        {
            var newPosition = new MonitorPosition
            {
                MonitorId = monitor.Id,
                Position = new Rect
                {
                    Left = location.X,
                    Top = location.Y,
                    Height = 60,
                    Width = 80
                }
            };
            CurrentMonitorPositions.Add(newPosition);

            var monitorPanel = new MonitorPanel
            {
                Tag = newPosition,
                Location = new Point(location.X, location.Y),
                Size = new Size(80, 60),
                BorderStyle = BorderStyle.FixedSingle
            };

            AddMonitorPanel(monitorPanel, monitor.Name);
        }

        /// <summary>
        /// The AddMonitorPanel method.
        /// </summary>
        /// <param name="monitorPanel">The panel to add.</param>
        /// <param name="monitorName">The name of the monitor.</param>
        public void AddMonitorPanel(MonitorPanel monitorPanel, string monitorName)
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
                Size = monitorPanel.Size
            };

            monitorLabel.MouseClick += MonitorLabel_Click;
            monitorLabel.MouseDown += MonitorLabel_MouseDown;
            monitorLabel.MouseMove += MonitorLabel_MouseMove;
            monitorLabel.MouseUp += MonitorLabel_MouseUp;

            var menuStrip = new ContextMenuStrip();
            var itemRemove = menuStrip.Items.Add("Remove monitor");
            itemRemove.Tag = monitorPanel;
            itemRemove.Click += ItemRemoveMonitor_Click;
            var itemResize = menuStrip.Items.Add("Resize monitor");
            itemResize.Tag = monitorPanel;
            itemResize.Click += ItemResizeMonitor_Click;
            monitorLabel.ContextMenuStrip = menuStrip;

            monitorPanel.BackColor = SystemColors.ControlDarkDark;
            monitorPanel.Controls.Add(monitorLabel);
            pnlMain.Controls.Add(monitorPanel);
        }

        /// <summary>
        /// The MonitorLabel_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private static void MonitorLabel_Click(object sender, MouseEventArgs args)
        {
            if (args.Button != MouseButtons.Right)
                return;

            var monitorLabel = sender as Label;
            monitorLabel?.ContextMenuStrip.Show();
        }

        /// <summary>
        /// The IsMonitorUsed method.
        /// </summary>
        /// <param name="monitor">The monitor to check.</param>
        /// <returns><c>true</c> if a monitor already exists within the current
        /// monitor positions, otherwise <c>false</c>.</returns>
        private bool IsMonitorUsed(Monitor monitor)
        {
            foreach (var monitorPanel in pnlMain.Controls.OfType<Panel>())
            {
                if (monitorPanel.Tag.GetType() != typeof(MonitorPosition))
                    continue;

                var monitorPosition = monitorPanel.Tag as MonitorPosition;
                if (monitorPosition == null)
                    return false;

                if (monitor.Id == monitorPosition.MonitorId)
                    return true;
            }

            return false;
        }

        /// <summary>
        /// The ButtonRename_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRename_Click(object sender, EventArgs args)
        {
            var prompt = new Form
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = @"Enter new name:",
                StartPosition = FormStartPosition.CenterScreen
            };

            var textLabel = new Label
            {
                Left = 50,
                Top = 20,
                Text = @"Rename Monitor Wall"
            };

            var textBox = new TextBox
            {
                Left = 50,
                Top = 50,
                Width = 400
            };

            var confirmation = new Button
            {
                Text = @"Ok",
                Left = 350,
                Width = 100,
                Top = 70,
                DialogResult = DialogResult.OK
            };

            confirmation.Click += (s, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            var name = prompt.ShowDialog() == DialogResult.OK ? textBox.Text : string.Empty;
            if (string.IsNullOrEmpty(name))
                return;

            Text = $@"Edit {name}";
            NewMonitorWallName = name;
        }

        /// <summary>
        /// The ButtonSave_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            if (!string.IsNullOrEmpty(NewMonitorWallName))
                CurrentMonitorWall.Name = NewMonitorWallName;


            CurrentMonitorWall.MonitorPositions = CurrentMonitorPositions;
        }

        /// <summary>
        /// The ItemRemoveMonitor_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ItemRemoveMonitor_Click(object sender, EventArgs args)
        {
            var toolStripItem = (ToolStripItem)sender;
            var monitorPanel = toolStripItem.Tag as MonitorPanel;
            if (monitorPanel == null)
                return;


            var monitorPosition = (MonitorPosition)monitorPanel.Tag;
            if (monitorPosition != null)
                CurrentMonitorPositions.Remove(monitorPosition);

            monitorPanel.Dispose();
            Refresh();
        }

        /// <summary>
        /// The ItemResizeMonitor_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ItemResizeMonitor_Click(object sender, EventArgs args)
        {
            var toolStripItem = (ToolStripItem)sender;
            var monitorPanel = toolStripItem.Tag as MonitorPanel;

            var monitorPosition = (MonitorPosition) monitorPanel?.Tag;
            if (monitorPosition == null)
                return;

            var heightValue = (decimal)monitorPosition.Position.Height;
            InputBox.Show("Resize Monitor", "Enter new height value:", ref heightValue, 10, 300);
            monitorPosition.Position.Height = (int)heightValue;

            var widthValue = (decimal)monitorPosition.Position.Width;
            InputBox.Show("Resize Monitor", "Enter new width value:", ref widthValue, 10, 400);
            monitorPosition.Position.Width = (int)widthValue;

            monitorPanel.Size = new Size(monitorPosition.Position.Width, monitorPosition.Position.Height);
            Refresh();
        }

        /// <summary>
        /// The ListViewDataSources_OnItemDrag method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ListViewDataSources_OnItemDrag(object sender, ItemDragEventArgs args)
        {
            DoDragDrop(args.Item, DragDropEffects.Move);
        }

        /// <summary>
        /// The MonitorLabel_MouseDown method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MonitorLabel_MouseDown(object sender, MouseEventArgs args)
        {
            IsMouseDown = true;

            LastX = args.X;
            LastY = args.Y;
        }

        /// <summary>
        /// The MonitorLabel_MouseMove method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MonitorLabel_MouseMove(object sender, MouseEventArgs args)
        {
            if (!IsMouseDown)
                return;

            var monitorLabel = (Label)sender;
            var monitorPanel = monitorLabel.Parent as MonitorPanel;
            if (monitorPanel == null)
                return;

            monitorPanel.Location = new Point(monitorPanel.Location.X - (LastX - args.X), monitorPanel.Location.Y - (LastY - args.Y));
            var monitorPosition = (MonitorPosition)monitorPanel.Tag;
            if (monitorPosition == null)
                return;

            monitorPosition.Position.Left = monitorPanel.Location.X;
            monitorPosition.Position.Top = monitorPanel.Location.Y;

            Refresh();
        }

        /// <summary>
        /// The MonitorLabel_MouseUp method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void MonitorLabel_MouseUp(object sender, MouseEventArgs args)
        {
            IsMouseDown = false;
        }

        /// <summary>
        /// The PanelMain_OnDragDrop method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void PanelMain_OnDragDrop(object sender, DragEventArgs args)
        {
            var panelPoint = pnlMain.PointToClient(new Point(args.X, args.Y));
            if (!args.Data.GetDataPresent(typeof(ListViewItem)))
                return;
            
            var lvItem = args.Data.GetData(typeof(ListViewItem)) as ListViewItem;
            if (lvItem != null)
            {
                var monitor = lvItem.Tag as Monitor;
                if (monitor == null)
                    return;

                if (IsMonitorUsed(monitor))
                {
                    MessageBox.Show(this, $@"Monitor {monitor.Name} already in use.");
                    return;
                }

                DisplayNewMonitor(monitor, panelPoint);
            }

            Refresh();
        }

        /// <summary>
        /// The PanelMain_OnDragEnter method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void PanelMain_OnDragEnter(object sender, DragEventArgs args)
        {
            if (args.Data.GetDataPresent(typeof(ListViewItem)))
            {
                args.Effect = DragDropEffects.Move;
            }
        }
    }

    [System.ComponentModel.DesignerCategory("Code")]
    public class MonitorPanel : Panel
    {
        public MonitorPanel() 
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var brush = new SolidBrush(BackColor))
                e.Graphics.FillRectangle(brush, ClientRectangle);
            e.Graphics.DrawRectangle(Pens.White, 0, 0, ClientSize.Width - 2, ClientSize.Height - 2);
        }

    }
}
