namespace ExampleClient.Source
{
    partial class AddAnalyticSessionForm
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
            this.gbxSource = new System.Windows.Forms.GroupBox();
            this.tbxSource = new System.Windows.Forms.TextBox();
            this.gbxDataEncodingId = new System.Windows.Forms.GroupBox();
            this.tbxDataEncodingId = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxId = new System.Windows.Forms.GroupBox();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.gbxDataSourceId = new System.Windows.Forms.GroupBox();
            this.cbxDataSource = new System.Windows.Forms.ComboBox();
            this.gbxDevice = new System.Windows.Forms.GroupBox();
            this.cbxDevice = new System.Windows.Forms.ComboBox();
            this.gbxSource.SuspendLayout();
            this.gbxDataEncodingId.SuspendLayout();
            this.gbxId.SuspendLayout();
            this.gbxDataSourceId.SuspendLayout();
            this.gbxDevice.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSource
            // 
            this.gbxSource.Controls.Add(this.tbxSource);
            this.gbxSource.Location = new System.Drawing.Point(12, 140);
            this.gbxSource.Name = "gbxSource";
            this.gbxSource.Size = new System.Drawing.Size(436, 58);
            this.gbxSource.TabIndex = 18;
            this.gbxSource.TabStop = false;
            this.gbxSource.Text = "Source";
            // 
            // tbxSource
            // 
            this.tbxSource.Location = new System.Drawing.Point(6, 19);
            this.tbxSource.MaxLength = 64;
            this.tbxSource.Name = "tbxSource";
            this.tbxSource.Size = new System.Drawing.Size(424, 20);
            this.tbxSource.TabIndex = 1;
            // 
            // gbxDataEncodingId
            // 
            this.gbxDataEncodingId.Controls.Add(this.tbxDataEncodingId);
            this.gbxDataEncodingId.Location = new System.Drawing.Point(12, 12);
            this.gbxDataEncodingId.Name = "gbxDataEncodingId";
            this.gbxDataEncodingId.Size = new System.Drawing.Size(215, 58);
            this.gbxDataEncodingId.TabIndex = 6;
            this.gbxDataEncodingId.TabStop = false;
            this.gbxDataEncodingId.Text = "Data Encoding ID";
            // 
            // tbxDataEncodingId
            // 
            this.tbxDataEncodingId.Location = new System.Drawing.Point(6, 19);
            this.tbxDataEncodingId.MaxLength = 255;
            this.tbxDataEncodingId.Name = "tbxDataEncodingId";
            this.tbxDataEncodingId.Size = new System.Drawing.Size(203, 20);
            this.tbxDataEncodingId.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(373, 204);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(292, 204);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // gbxId
            // 
            this.gbxId.Controls.Add(this.tbxId);
            this.gbxId.Location = new System.Drawing.Point(239, 12);
            this.gbxId.Name = "gbxId";
            this.gbxId.Size = new System.Drawing.Size(215, 58);
            this.gbxId.TabIndex = 7;
            this.gbxId.TabStop = false;
            this.gbxId.Text = "ID";
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(6, 19);
            this.tbxId.MaxLength = 64;
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(203, 20);
            this.tbxId.TabIndex = 0;
            // 
            // gbxDataSourceId
            // 
            this.gbxDataSourceId.Controls.Add(this.cbxDataSource);
            this.gbxDataSourceId.Location = new System.Drawing.Point(12, 76);
            this.gbxDataSourceId.Name = "gbxDataSourceId";
            this.gbxDataSourceId.Size = new System.Drawing.Size(215, 58);
            this.gbxDataSourceId.TabIndex = 19;
            this.gbxDataSourceId.TabStop = false;
            this.gbxDataSourceId.Text = "Data Source";
            // 
            // cbxDataSource
            // 
            this.cbxDataSource.FormattingEnabled = true;
            this.cbxDataSource.Location = new System.Drawing.Point(6, 19);
            this.cbxDataSource.Name = "cbxDataSource";
            this.cbxDataSource.Size = new System.Drawing.Size(203, 21);
            this.cbxDataSource.TabIndex = 0;
            // 
            // gbxDevice
            // 
            this.gbxDevice.Controls.Add(this.cbxDevice);
            this.gbxDevice.Location = new System.Drawing.Point(233, 76);
            this.gbxDevice.Name = "gbxDevice";
            this.gbxDevice.Size = new System.Drawing.Size(215, 58);
            this.gbxDevice.TabIndex = 20;
            this.gbxDevice.TabStop = false;
            this.gbxDevice.Text = "Device";
            // 
            // cbxDevice
            // 
            this.cbxDevice.FormattingEnabled = true;
            this.cbxDevice.Location = new System.Drawing.Point(6, 19);
            this.cbxDevice.Name = "cbxDevice";
            this.cbxDevice.Size = new System.Drawing.Size(203, 21);
            this.cbxDevice.TabIndex = 1;
            // 
            // AddAnalyticSessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 238);
            this.Controls.Add(this.gbxDevice);
            this.Controls.Add(this.gbxDataSourceId);
            this.Controls.Add(this.gbxId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbxDataEncodingId);
            this.Controls.Add(this.gbxSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAnalyticSessionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Analytic Session";
            this.gbxSource.ResumeLayout(false);
            this.gbxSource.PerformLayout();
            this.gbxDataEncodingId.ResumeLayout(false);
            this.gbxDataEncodingId.PerformLayout();
            this.gbxId.ResumeLayout(false);
            this.gbxId.PerformLayout();
            this.gbxDataSourceId.ResumeLayout(false);
            this.gbxDevice.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxSource;
        private System.Windows.Forms.GroupBox gbxDataEncodingId;
        private System.Windows.Forms.TextBox tbxDataEncodingId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbxId;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.GroupBox gbxDataSourceId;
        private System.Windows.Forms.GroupBox gbxDevice;
        private System.Windows.Forms.TextBox tbxSource;
        private System.Windows.Forms.ComboBox cbxDataSource;
        private System.Windows.Forms.ComboBox cbxDevice;
    }
}