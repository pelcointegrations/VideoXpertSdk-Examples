namespace ExampleClient.Source
{
    partial class ModifyTimeTableForm
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
            if (disposing && (components != null))
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.gbxTimeRanges = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvTimeRanges = new System.Windows.Forms.ListView();
            this.chSelection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chbxDisableStartDate = new System.Windows.Forms.CheckBox();
            this.chbxDisableEndDate = new System.Windows.Forms.CheckBox();
            this.gbxTimeRanges.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(214, 389);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(304, 389);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(82, 47);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(216, 20);
            this.tbxName.TabIndex = 36;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(15, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 13);
            this.lblName.TabIndex = 35;
            this.lblName.Text = "Name: ";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(82, 12);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(216, 20);
            this.tbxId.TabIndex = 38;
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(15, 15);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(61, 13);
            this.lblId.TabIndex = 37;
            this.lblId.Text = "ID: ";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(304, 10);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 39;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "dddd, dd MMMM yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(82, 117);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(216, 20);
            this.dtpEndDate.TabIndex = 2;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.DateTimePickerDates_ValueChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "dddd, dd MMMM yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(82, 82);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(216, 20);
            this.dtpStartDate.TabIndex = 2;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.DateTimePickerDates_ValueChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.Location = new System.Drawing.Point(15, 85);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(61, 13);
            this.lblStartDate.TabIndex = 40;
            this.lblStartDate.Text = "Start Date: ";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEndDate
            // 
            this.lblEndDate.Location = new System.Drawing.Point(15, 120);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(61, 13);
            this.lblEndDate.TabIndex = 41;
            this.lblEndDate.Text = "End Date: ";
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbxTimeRanges
            // 
            this.gbxTimeRanges.Controls.Add(this.btnRemove);
            this.gbxTimeRanges.Controls.Add(this.btnAdd);
            this.gbxTimeRanges.Controls.Add(this.lvTimeRanges);
            this.gbxTimeRanges.Location = new System.Drawing.Point(18, 154);
            this.gbxTimeRanges.Name = "gbxTimeRanges";
            this.gbxTimeRanges.Size = new System.Drawing.Size(361, 229);
            this.gbxTimeRanges.TabIndex = 42;
            this.gbxTimeRanges.TabStop = false;
            this.gbxTimeRanges.Text = "Time Ranges";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(286, 48);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(63, 23);
            this.btnRemove.TabIndex = 24;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(286, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(63, 23);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // lvTimeRanges
            // 
            this.lvTimeRanges.CheckBoxes = true;
            this.lvTimeRanges.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSelection,
            this.chDay,
            this.chFrom,
            this.chTo});
            this.lvTimeRanges.FullRowSelect = true;
            this.lvTimeRanges.GridLines = true;
            this.lvTimeRanges.Location = new System.Drawing.Point(6, 19);
            this.lvTimeRanges.MultiSelect = false;
            this.lvTimeRanges.Name = "lvTimeRanges";
            this.lvTimeRanges.Size = new System.Drawing.Size(274, 196);
            this.lvTimeRanges.TabIndex = 0;
            this.lvTimeRanges.UseCompatibleStateImageBehavior = false;
            this.lvTimeRanges.View = System.Windows.Forms.View.Details;
            // 
            // chSelection
            // 
            this.chSelection.Text = "";
            this.chSelection.Width = 24;
            // 
            // chDay
            // 
            this.chDay.Text = "Day";
            this.chDay.Width = 100;
            // 
            // chFrom
            // 
            this.chFrom.Text = "From";
            this.chFrom.Width = 67;
            // 
            // chTo
            // 
            this.chTo.Text = "To";
            this.chTo.Width = 73;
            // 
            // chbxDisableStartDate
            // 
            this.chbxDisableStartDate.AutoSize = true;
            this.chbxDisableStartDate.Location = new System.Drawing.Point(304, 84);
            this.chbxDisableStartDate.Name = "chbxDisableStartDate";
            this.chbxDisableStartDate.Size = new System.Drawing.Size(61, 17);
            this.chbxDisableStartDate.TabIndex = 43;
            this.chbxDisableStartDate.Text = "Disable";
            this.chbxDisableStartDate.UseVisualStyleBackColor = true;
            this.chbxDisableStartDate.CheckedChanged += new System.EventHandler(this.CheckBoxDisableStartDate_CheckedChanged);
            // 
            // chbxDisableEndDate
            // 
            this.chbxDisableEndDate.AutoSize = true;
            this.chbxDisableEndDate.Location = new System.Drawing.Point(304, 119);
            this.chbxDisableEndDate.Name = "chbxDisableEndDate";
            this.chbxDisableEndDate.Size = new System.Drawing.Size(61, 17);
            this.chbxDisableEndDate.TabIndex = 44;
            this.chbxDisableEndDate.Text = "Disable";
            this.chbxDisableEndDate.UseVisualStyleBackColor = true;
            this.chbxDisableEndDate.CheckedChanged += new System.EventHandler(this.CheckBoxDisableEndDate_CheckedChanged);
            // 
            // ModifyTimeTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 423);
            this.Controls.Add(this.chbxDisableEndDate);
            this.Controls.Add(this.chbxDisableStartDate);
            this.Controls.Add(this.gbxTimeRanges);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyTimeTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Time Table";
            this.gbxTimeRanges.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.GroupBox gbxTimeRanges;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvTimeRanges;
        private System.Windows.Forms.ColumnHeader chSelection;
        private System.Windows.Forms.ColumnHeader chDay;
        private System.Windows.Forms.ColumnHeader chFrom;
        private System.Windows.Forms.ColumnHeader chTo;
        private System.Windows.Forms.CheckBox chbxDisableStartDate;
        private System.Windows.Forms.CheckBox chbxDisableEndDate;
    }
}