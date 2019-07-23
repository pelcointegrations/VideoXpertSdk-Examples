using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleClient
{
    public partial class SeekSelectForm : Form
    {
        private DateTimePicker dateTimePicker_Start;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePicker_End;
        private Button button_start;
        private GroupBox groupBox1;

        private DateTime _startTime;
        private DateTime _endTime;

        public DateTime StartTime
        {
            get { return _startTime; }
        }
        public DateTime EndTime
        {
            get { return _endTime; }
        }

        public SeekSelectForm(DateTime start, DateTime end)
        {
            InitializeComponent();
            _startTime = start;
            _endTime = end;
            dateTimePicker_Start.MinDate = _startTime;
            dateTimePicker_Start.MaxDate = _endTime.AddSeconds(-5);
            dateTimePicker_Start.Value = _startTime;

            dateTimePicker_End.MinDate = _startTime.AddSeconds(5);
            dateTimePicker_End.MaxDate = _endTime;
            dateTimePicker_End.Value = _endTime;
        }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.button_start = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker_Start);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Start time";
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.CustomFormat = "HH:mm:ss  MM/dd/yyyy";
            this.dateTimePicker_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Start.Location = new System.Drawing.Point(6, 28);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(175, 20);
            this.dateTimePicker_Start.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker_End);
            this.groupBox2.Location = new System.Drawing.Point(12, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 70);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "End Time";
            // 
            // dateTimePicker_End
            // 
            this.dateTimePicker_End.CustomFormat = "HH:mm:ss  MM/dd/yyyy";
            this.dateTimePicker_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_End.Location = new System.Drawing.Point(6, 28);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.Size = new System.Drawing.Size(175, 20);
            this.dateTimePicker_End.TabIndex = 0;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(47, 192);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(109, 23);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "Start Playback";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // SeekSelectForm
            // 
            this.ClientSize = new System.Drawing.Size(223, 227);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeekSelectForm";
            this.Text = "Seek Select Times";
            this.Load += new System.EventHandler(this.SeekSelectForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void SeekSelectForm_Load(object sender, EventArgs e)
        {

        }

        private void button_start_Click(object sender, EventArgs e)
        {
            _startTime = dateTimePicker_Start.Value;
            _endTime = dateTimePicker_End.Value;
            if (_startTime < _endTime)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("End Time must be after Start Time");
            }
        }
    }
}
