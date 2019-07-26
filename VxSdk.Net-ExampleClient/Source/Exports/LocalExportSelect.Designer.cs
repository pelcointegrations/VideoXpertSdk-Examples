namespace ExampleClient.Source.Exports
{
    partial class LocalExportSelect
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
            this.listView_dataSources = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_export = new System.Windows.Forms.Button();
            this.textBox_fileName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_fileSave = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_dataSources
            // 
            this.listView_dataSources.HideSelection = false;
            this.listView_dataSources.Location = new System.Drawing.Point(6, 26);
            this.listView_dataSources.MultiSelect = false;
            this.listView_dataSources.Name = "listView_dataSources";
            this.listView_dataSources.Size = new System.Drawing.Size(159, 223);
            this.listView_dataSources.TabIndex = 0;
            this.listView_dataSources.UseCompatibleStateImageBehavior = false;
            this.listView_dataSources.View = System.Windows.Forms.View.List;
            this.listView_dataSources.SelectedIndexChanged += new System.EventHandler(this.listView_dataSources_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source";
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.CustomFormat = "HH:mm:ss  MM/dd/yyyy";
            this.dateTimePicker_start.Enabled = false;
            this.dateTimePicker_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_start.Location = new System.Drawing.Point(183, 26);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(177, 20);
            this.dateTimePicker_start.TabIndex = 2;
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.CustomFormat = "HH:mm:ss  MM/dd/yyyy";
            this.dateTimePicker_end.Enabled = false;
            this.dateTimePicker_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_end.Location = new System.Drawing.Point(183, 82);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(177, 20);
            this.dateTimePicker_end.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(171, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 49);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Start";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(171, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 53);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "End";
            // 
            // button_export
            // 
            this.button_export.Enabled = false;
            this.button_export.Location = new System.Drawing.Point(229, 226);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(75, 23);
            this.button_export.TabIndex = 5;
            this.button_export.Text = "Export";
            this.button_export.UseVisualStyleBackColor = true;
            this.button_export.Click += new System.EventHandler(this.button_export_Click);
            // 
            // textBox_fileName
            // 
            this.textBox_fileName.Location = new System.Drawing.Point(6, 31);
            this.textBox_fileName.Name = "textBox_fileName";
            this.textBox_fileName.Size = new System.Drawing.Size(154, 20);
            this.textBox_fileName.TabIndex = 6;
            this.textBox_fileName.TextChanged += new System.EventHandler(this.textBox_fileName_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_fileSave);
            this.groupBox3.Controls.Add(this.textBox_fileName);
            this.groupBox3.Location = new System.Drawing.Point(171, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 76);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "File Name";
            // 
            // button_fileSave
            // 
            this.button_fileSave.Location = new System.Drawing.Point(166, 29);
            this.button_fileSave.Name = "button_fileSave";
            this.button_fileSave.Size = new System.Drawing.Size(29, 23);
            this.button_fileSave.TabIndex = 7;
            this.button_fileSave.Text = "...";
            this.button_fileSave.UseVisualStyleBackColor = true;
            this.button_fileSave.Click += new System.EventHandler(this.button_fileSave_Click);
            // 
            // LocalExportSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 256);
            this.Controls.Add(this.button_export);
            this.Controls.Add(this.dateTimePicker_end);
            this.Controls.Add(this.dateTimePicker_start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_dataSources);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LocalExportSelect";
            this.ShowIcon = false;
            this.Text = "Local Export Setup";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_dataSources;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_export;
        private System.Windows.Forms.TextBox textBox_fileName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_fileSave;
    }
}