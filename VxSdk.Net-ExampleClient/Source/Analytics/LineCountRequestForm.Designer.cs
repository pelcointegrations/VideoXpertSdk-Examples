namespace ExampleClient.Source
{
    partial class LineCountRequestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvAnalyticBehaviors = new System.Windows.Forms.ListView();
            this.chChecked = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chObjectType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxBehaviors = new System.Windows.Forms.GroupBox();
            this.rbHour = new System.Windows.Forms.RadioButton();
            this.rbDay = new System.Windows.Forms.RadioButton();
            this.rbMonth = new System.Windows.Forms.RadioButton();
            this.gbxInterval = new System.Windows.Forms.GroupBox();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.gbxStartTimeRequest = new System.Windows.Forms.GroupBox();
            this.gbxEndTimeRequest = new System.Windows.Forms.GroupBox();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.gbxLineCountResults = new System.Windows.Forms.GroupBox();
            this.lvResults = new System.Windows.Forms.ListView();
            this.chStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCountCorrection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chInCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chInCountCorrection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOutCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOutCountCorrection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblNoResults = new System.Windows.Forms.Label();
            this.gbxLineCountRequest = new System.Windows.Forms.GroupBox();
            this.btnGetLineCounts = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.gbxBehaviors.SuspendLayout();
            this.gbxInterval.SuspendLayout();
            this.gbxStartTimeRequest.SuspendLayout();
            this.gbxEndTimeRequest.SuspendLayout();
            this.gbxLineCountResults.SuspendLayout();
            this.gbxLineCountRequest.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvAnalyticBehaviors
            // 
            this.lvAnalyticBehaviors.CheckBoxes = true;
            this.lvAnalyticBehaviors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chChecked,
            this.chId,
            this.chName,
            this.chType,
            this.chObjectType});
            this.lvAnalyticBehaviors.FullRowSelect = true;
            this.lvAnalyticBehaviors.GridLines = true;
            this.lvAnalyticBehaviors.Location = new System.Drawing.Point(9, 19);
            this.lvAnalyticBehaviors.MultiSelect = false;
            this.lvAnalyticBehaviors.Name = "lvAnalyticBehaviors";
            this.lvAnalyticBehaviors.Size = new System.Drawing.Size(645, 186);
            this.lvAnalyticBehaviors.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvAnalyticBehaviors.TabIndex = 0;
            this.lvAnalyticBehaviors.UseCompatibleStateImageBehavior = false;
            this.lvAnalyticBehaviors.View = System.Windows.Forms.View.Details;
            this.lvAnalyticBehaviors.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.ListViewAnalyticBehaviors_ItemChecked);
            // 
            // chChecked
            // 
            this.chChecked.Text = "";
            this.chChecked.Width = 20;
            // 
            // chId
            // 
            this.chId.Text = "ID";
            this.chId.Width = 224;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 130;
            // 
            // chType
            // 
            this.chType.Text = "Type";
            this.chType.Width = 99;
            // 
            // chObjectType
            // 
            this.chObjectType.Text = "Object Type";
            this.chObjectType.Width = 70;
            // 
            // gbxBehaviors
            // 
            this.gbxBehaviors.Controls.Add(this.lvAnalyticBehaviors);
            this.gbxBehaviors.Location = new System.Drawing.Point(0, 87);
            this.gbxBehaviors.Name = "gbxBehaviors";
            this.gbxBehaviors.Size = new System.Drawing.Size(660, 214);
            this.gbxBehaviors.TabIndex = 6;
            this.gbxBehaviors.TabStop = false;
            this.gbxBehaviors.Text = "Line Counter";
            // 
            // rbHour
            // 
            this.rbHour.AutoSize = true;
            this.rbHour.Location = new System.Drawing.Point(6, 18);
            this.rbHour.Name = "rbHour";
            this.rbHour.Size = new System.Drawing.Size(48, 17);
            this.rbHour.TabIndex = 9;
            this.rbHour.TabStop = true;
            this.rbHour.Text = "Hour";
            this.rbHour.UseVisualStyleBackColor = true;
            // 
            // rbDay
            // 
            this.rbDay.AutoSize = true;
            this.rbDay.Location = new System.Drawing.Point(78, 18);
            this.rbDay.Name = "rbDay";
            this.rbDay.Size = new System.Drawing.Size(44, 17);
            this.rbDay.TabIndex = 10;
            this.rbDay.TabStop = true;
            this.rbDay.Text = "Day";
            this.rbDay.UseVisualStyleBackColor = true;
            // 
            // rbMonth
            // 
            this.rbMonth.AutoSize = true;
            this.rbMonth.Location = new System.Drawing.Point(139, 18);
            this.rbMonth.Name = "rbMonth";
            this.rbMonth.Size = new System.Drawing.Size(55, 17);
            this.rbMonth.TabIndex = 11;
            this.rbMonth.TabStop = true;
            this.rbMonth.Text = "Month";
            this.rbMonth.UseVisualStyleBackColor = true;
            // 
            // gbxInterval
            // 
            this.gbxInterval.Controls.Add(this.rbHour);
            this.gbxInterval.Controls.Add(this.rbMonth);
            this.gbxInterval.Controls.Add(this.rbDay);
            this.gbxInterval.Location = new System.Drawing.Point(415, 33);
            this.gbxInterval.Name = "gbxInterval";
            this.gbxInterval.Size = new System.Drawing.Size(200, 48);
            this.gbxInterval.TabIndex = 12;
            this.gbxInterval.TabStop = false;
            this.gbxInterval.Text = "Interval";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "HH:mm:ss  MM/dd/yyyy";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(6, 19);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(153, 20);
            this.dtpStartTime.TabIndex = 15;
            // 
            // gbxStartTimeRequest
            // 
            this.gbxStartTimeRequest.Controls.Add(this.dtpStartTime);
            this.gbxStartTimeRequest.Location = new System.Drawing.Point(55, 30);
            this.gbxStartTimeRequest.Name = "gbxStartTimeRequest";
            this.gbxStartTimeRequest.Size = new System.Drawing.Size(172, 51);
            this.gbxStartTimeRequest.TabIndex = 17;
            this.gbxStartTimeRequest.TabStop = false;
            this.gbxStartTimeRequest.Text = "Start Time";
            // 
            // gbxEndTimeRequest
            // 
            this.gbxEndTimeRequest.Controls.Add(this.dtpEndTime);
            this.gbxEndTimeRequest.Location = new System.Drawing.Point(235, 30);
            this.gbxEndTimeRequest.Name = "gbxEndTimeRequest";
            this.gbxEndTimeRequest.Size = new System.Drawing.Size(172, 51);
            this.gbxEndTimeRequest.TabIndex = 18;
            this.gbxEndTimeRequest.TabStop = false;
            this.gbxEndTimeRequest.Text = "End Time";
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "HH:mm:ss  MM/dd/yyyy";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(6, 19);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(153, 20);
            this.dtpEndTime.TabIndex = 15;
            // 
            // gbxLineCountResults
            // 
            this.gbxLineCountResults.Controls.Add(this.lvResults);
            this.gbxLineCountResults.Controls.Add(this.lblNoResults);
            this.gbxLineCountResults.Location = new System.Drawing.Point(12, 362);
            this.gbxLineCountResults.Name = "gbxLineCountResults";
            this.gbxLineCountResults.Size = new System.Drawing.Size(665, 178);
            this.gbxLineCountResults.TabIndex = 34;
            this.gbxLineCountResults.TabStop = false;
            this.gbxLineCountResults.Text = "Line Count Results";
            // 
            // lvResults
            // 
            this.lvResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chStartTime,
            this.chEndTime,
            this.chCount,
            this.chCountCorrection,
            this.chInCount,
            this.chInCountCorrection,
            this.chOutCount,
            this.chOutCountCorrection});
            this.lvResults.FullRowSelect = true;
            this.lvResults.GridLines = true;
            this.lvResults.HideSelection = false;
            this.lvResults.Location = new System.Drawing.Point(6, 19);
            this.lvResults.MultiSelect = false;
            this.lvResults.Name = "lvResults";
            this.lvResults.Size = new System.Drawing.Size(654, 147);
            this.lvResults.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvResults.TabIndex = 1;
            this.lvResults.UseCompatibleStateImageBehavior = false;
            this.lvResults.View = System.Windows.Forms.View.Details;
            // 
            // chStartTime
            // 
            this.chStartTime.Text = "Start Time";
            this.chStartTime.Width = 125;
            // 
            // chEndTime
            // 
            this.chEndTime.Text = "End Time";
            this.chEndTime.Width = 125;
            // 
            // chCount
            // 
            this.chCount.Text = "Count";
            this.chCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chCount.Width = 62;
            // 
            // chCountCorrection
            // 
            this.chCountCorrection.Text = "Correction";
            this.chCountCorrection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chCountCorrection.Width = 62;
            // 
            // chInCount
            // 
            this.chInCount.Text = "In Count";
            this.chInCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chInCount.Width = 62;
            // 
            // chInCountCorrection
            // 
            this.chInCountCorrection.Text = "Correction";
            this.chInCountCorrection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chInCountCorrection.Width = 62;
            // 
            // chOutCount
            // 
            this.chOutCount.Text = "Out Count";
            this.chOutCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chOutCount.Width = 62;
            // 
            // chOutCountCorrection
            // 
            this.chOutCountCorrection.Text = "Correction";
            this.chOutCountCorrection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chOutCountCorrection.Width = 62;
            // 
            // lblNoResults
            // 
            this.lblNoResults.AutoSize = true;
            this.lblNoResults.Location = new System.Drawing.Point(286, 83);
            this.lblNoResults.Name = "lblNoResults";
            this.lblNoResults.Size = new System.Drawing.Size(92, 13);
            this.lblNoResults.TabIndex = 2;
            this.lblNoResults.Text = "No Results Found";
            // 
            // gbxLineCountRequest
            // 
            this.gbxLineCountRequest.Controls.Add(this.btnGetLineCounts);
            this.gbxLineCountRequest.Controls.Add(this.gbxStartTimeRequest);
            this.gbxLineCountRequest.Controls.Add(this.gbxBehaviors);
            this.gbxLineCountRequest.Controls.Add(this.gbxEndTimeRequest);
            this.gbxLineCountRequest.Controls.Add(this.gbxInterval);
            this.gbxLineCountRequest.Location = new System.Drawing.Point(12, 12);
            this.gbxLineCountRequest.Name = "gbxLineCountRequest";
            this.gbxLineCountRequest.Size = new System.Drawing.Size(665, 344);
            this.gbxLineCountRequest.TabIndex = 35;
            this.gbxLineCountRequest.TabStop = false;
            this.gbxLineCountRequest.Text = "Line Count Request";
            // 
            // btnGetLineCounts
            // 
            this.btnGetLineCounts.Location = new System.Drawing.Point(283, 307);
            this.btnGetLineCounts.Name = "btnGetLineCounts";
            this.btnGetLineCounts.Size = new System.Drawing.Size(98, 23);
            this.btnGetLineCounts.TabIndex = 19;
            this.btnGetLineCounts.Text = "Get Line Counts";
            this.btnGetLineCounts.UseVisualStyleBackColor = true;
            this.btnGetLineCounts.Click += new System.EventHandler(this.ButtonGetLineCounts_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(602, 546);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 36;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // LineCountRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 575);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbxLineCountRequest);
            this.Controls.Add(this.gbxLineCountResults);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LineCountRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Request Line Counts";
            this.gbxBehaviors.ResumeLayout(false);
            this.gbxInterval.ResumeLayout(false);
            this.gbxInterval.PerformLayout();
            this.gbxStartTimeRequest.ResumeLayout(false);
            this.gbxEndTimeRequest.ResumeLayout(false);
            this.gbxLineCountResults.ResumeLayout(false);
            this.gbxLineCountResults.PerformLayout();
            this.gbxLineCountRequest.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvAnalyticBehaviors;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader chObjectType;
        private System.Windows.Forms.ColumnHeader chChecked;
        private System.Windows.Forms.GroupBox gbxBehaviors;
        private System.Windows.Forms.RadioButton rbHour;
        private System.Windows.Forms.RadioButton rbDay;
        private System.Windows.Forms.RadioButton rbMonth;
        private System.Windows.Forms.GroupBox gbxInterval;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.GroupBox gbxStartTimeRequest;
        private System.Windows.Forms.GroupBox gbxEndTimeRequest;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.GroupBox gbxLineCountResults;
        private System.Windows.Forms.GroupBox gbxLineCountRequest;
        private System.Windows.Forms.Button btnGetLineCounts;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ListView lvResults;
        private System.Windows.Forms.ColumnHeader chStartTime;
        private System.Windows.Forms.ColumnHeader chEndTime;
        private System.Windows.Forms.ColumnHeader chCount;
        private System.Windows.Forms.ColumnHeader chInCount;
        private System.Windows.Forms.ColumnHeader chOutCount;
        private System.Windows.Forms.ColumnHeader chCountCorrection;
        private System.Windows.Forms.ColumnHeader chInCountCorrection;
        private System.Windows.Forms.ColumnHeader chOutCountCorrection;
        private System.Windows.Forms.Label lblNoResults;
    }
}