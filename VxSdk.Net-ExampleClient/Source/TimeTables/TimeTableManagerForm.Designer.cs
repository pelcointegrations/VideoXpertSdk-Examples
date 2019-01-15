namespace ExampleClient.Source
{
    partial class TimeTableManagerForm
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
            this.lvTimeTableManager = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.chTimeRanges = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvTimeTableManager
            // 
            this.lvTimeTableManager.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chId,
            this.chStartDate,
            this.chEndDate,
            this.chTimeRanges});
            this.lvTimeTableManager.FullRowSelect = true;
            this.lvTimeTableManager.GridLines = true;
            this.lvTimeTableManager.Location = new System.Drawing.Point(12, 12);
            this.lvTimeTableManager.MultiSelect = false;
            this.lvTimeTableManager.Name = "lvTimeTableManager";
            this.lvTimeTableManager.Size = new System.Drawing.Size(703, 320);
            this.lvTimeTableManager.TabIndex = 0;
            this.lvTimeTableManager.UseCompatibleStateImageBehavior = false;
            this.lvTimeTableManager.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 135;
            // 
            // chStartDate
            // 
            this.chStartDate.Text = "Start Date";
            this.chStartDate.Width = 135;
            // 
            // chId
            // 
            this.chId.Text = "ID";
            this.chId.Width = 212;
            // 
            // chEndDate
            // 
            this.chEndDate.Text = "End Date";
            this.chEndDate.Width = 135;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(721, 70);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(721, 41);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(89, 23);
            this.btnModify.TabIndex = 13;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.ButtonModify_Click);
            // 
            // chTimeRanges
            // 
            this.chTimeRanges.Text = "Time Ranges";
            this.chTimeRanges.Width = 80;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(721, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // TimeTableManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 350);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lvTimeTableManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimeTableManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Time Table Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvTimeTableManager;
        private System.Windows.Forms.ColumnHeader chStartDate;
        private System.Windows.Forms.ColumnHeader chEndDate;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.ColumnHeader chTimeRanges;
        private System.Windows.Forms.Button btnAdd;
    }
}