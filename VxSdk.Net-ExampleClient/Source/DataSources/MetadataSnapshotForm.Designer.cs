namespace ExampleClient.Source
{
    partial class MetadataSnapshotForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnGetSnapshot = new System.Windows.Forms.Button();
            this.tbxMetadata = new System.Windows.Forms.TextBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.chbxCustomTime = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(505, 411);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnGetSnapshot
            // 
            this.btnGetSnapshot.Location = new System.Drawing.Point(493, 7);
            this.btnGetSnapshot.Name = "btnGetSnapshot";
            this.btnGetSnapshot.Size = new System.Drawing.Size(87, 23);
            this.btnGetSnapshot.TabIndex = 11;
            this.btnGetSnapshot.Text = "Get Snapshot";
            this.btnGetSnapshot.UseVisualStyleBackColor = true;
            this.btnGetSnapshot.Click += new System.EventHandler(this.ButtonGetSnapshot_Click);
            // 
            // tbxMetadata
            // 
            this.tbxMetadata.Location = new System.Drawing.Point(12, 35);
            this.tbxMetadata.Multiline = true;
            this.tbxMetadata.Name = "tbxMetadata";
            this.tbxMetadata.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxMetadata.Size = new System.Drawing.Size(568, 370);
            this.tbxMetadata.TabIndex = 12;
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            this.dtpTime.Enabled = false;
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(105, 8);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(200, 20);
            this.dtpTime.TabIndex = 13;
            // 
            // chbxCustomTime
            // 
            this.chbxCustomTime.AutoSize = true;
            this.chbxCustomTime.Location = new System.Drawing.Point(12, 10);
            this.chbxCustomTime.Name = "chbxCustomTime";
            this.chbxCustomTime.Size = new System.Drawing.Size(87, 17);
            this.chbxCustomTime.TabIndex = 14;
            this.chbxCustomTime.Text = "Custom Time";
            this.chbxCustomTime.UseVisualStyleBackColor = true;
            this.chbxCustomTime.CheckedChanged += new System.EventHandler(this.CheckBoxCustomTime_CheckedChanged);
            // 
            // MetadataSnapshotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 440);
            this.Controls.Add(this.chbxCustomTime);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.tbxMetadata);
            this.Controls.Add(this.btnGetSnapshot);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MetadataSnapshotForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Metadata Snapshots";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGetSnapshot;
        private System.Windows.Forms.TextBox tbxMetadata;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.CheckBox chbxCustomTime;
    }
}