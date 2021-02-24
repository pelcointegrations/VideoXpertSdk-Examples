namespace ExampleClient.Source
{
    partial class ModifyAnalyticConfigForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxSize = new System.Windows.Forms.GroupBox();
            this.nudSizeHeight = new System.Windows.Forms.NumericUpDown();
            this.lblSizeWidth = new System.Windows.Forms.Label();
            this.nudSizeWidth = new System.Windows.Forms.NumericUpDown();
            this.lblSizeHeight = new System.Windows.Forms.Label();
            this.gbxPtzPresetName = new System.Windows.Forms.GroupBox();
            this.cbxPresets = new System.Windows.Forms.ComboBox();
            this.gbxMinConfidence = new System.Windows.Forms.GroupBox();
            this.nudMinConfidence = new System.Windows.Forms.NumericUpDown();
            this.gbxSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeWidth)).BeginInit();
            this.gbxPtzPresetName.SuspendLayout();
            this.gbxMinConfidence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinConfidence)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(338, 144);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(257, 144);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // gbxSize
            // 
            this.gbxSize.Controls.Add(this.nudSizeHeight);
            this.gbxSize.Controls.Add(this.lblSizeWidth);
            this.gbxSize.Controls.Add(this.nudSizeWidth);
            this.gbxSize.Controls.Add(this.lblSizeHeight);
            this.gbxSize.Location = new System.Drawing.Point(245, 12);
            this.gbxSize.Name = "gbxSize";
            this.gbxSize.Size = new System.Drawing.Size(168, 75);
            this.gbxSize.TabIndex = 24;
            this.gbxSize.TabStop = false;
            this.gbxSize.Text = "Size";
            // 
            // nudSizeHeight
            // 
            this.nudSizeHeight.Location = new System.Drawing.Point(58, 19);
            this.nudSizeHeight.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudSizeHeight.Name = "nudSizeHeight";
            this.nudSizeHeight.Size = new System.Drawing.Size(89, 20);
            this.nudSizeHeight.TabIndex = 11;
            // 
            // lblSizeWidth
            // 
            this.lblSizeWidth.AutoSize = true;
            this.lblSizeWidth.Location = new System.Drawing.Point(11, 47);
            this.lblSizeWidth.Name = "lblSizeWidth";
            this.lblSizeWidth.Size = new System.Drawing.Size(38, 13);
            this.lblSizeWidth.TabIndex = 14;
            this.lblSizeWidth.Text = "Width:";
            // 
            // nudSizeWidth
            // 
            this.nudSizeWidth.Location = new System.Drawing.Point(58, 45);
            this.nudSizeWidth.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudSizeWidth.Name = "nudSizeWidth";
            this.nudSizeWidth.Size = new System.Drawing.Size(89, 20);
            this.nudSizeWidth.TabIndex = 12;
            // 
            // lblSizeHeight
            // 
            this.lblSizeHeight.AutoSize = true;
            this.lblSizeHeight.Location = new System.Drawing.Point(11, 23);
            this.lblSizeHeight.Name = "lblSizeHeight";
            this.lblSizeHeight.Size = new System.Drawing.Size(41, 13);
            this.lblSizeHeight.TabIndex = 13;
            this.lblSizeHeight.Text = "Height:";
            // 
            // gbxPtzPresetName
            // 
            this.gbxPtzPresetName.Controls.Add(this.cbxPresets);
            this.gbxPtzPresetName.Location = new System.Drawing.Point(12, 76);
            this.gbxPtzPresetName.Name = "gbxPtzPresetName";
            this.gbxPtzPresetName.Size = new System.Drawing.Size(215, 58);
            this.gbxPtzPresetName.TabIndex = 23;
            this.gbxPtzPresetName.TabStop = false;
            this.gbxPtzPresetName.Text = "PTZ Preset Name";
            // 
            // cbxPresets
            // 
            this.cbxPresets.FormattingEnabled = true;
            this.cbxPresets.Location = new System.Drawing.Point(6, 19);
            this.cbxPresets.Name = "cbxPresets";
            this.cbxPresets.Size = new System.Drawing.Size(203, 21);
            this.cbxPresets.TabIndex = 0;
            // 
            // gbxMinConfidence
            // 
            this.gbxMinConfidence.Controls.Add(this.nudMinConfidence);
            this.gbxMinConfidence.Location = new System.Drawing.Point(12, 12);
            this.gbxMinConfidence.Name = "gbxMinConfidence";
            this.gbxMinConfidence.Size = new System.Drawing.Size(215, 58);
            this.gbxMinConfidence.TabIndex = 22;
            this.gbxMinConfidence.TabStop = false;
            this.gbxMinConfidence.Text = "Minimum Confidence";
            // 
            // nudMinConfidence
            // 
            this.nudMinConfidence.DecimalPlaces = 2;
            this.nudMinConfidence.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMinConfidence.Location = new System.Drawing.Point(6, 23);
            this.nudMinConfidence.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinConfidence.Name = "nudMinConfidence";
            this.nudMinConfidence.Size = new System.Drawing.Size(89, 20);
            this.nudMinConfidence.TabIndex = 12;
            // 
            // ModifyAnalyticConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 175);
            this.Controls.Add(this.gbxSize);
            this.Controls.Add(this.gbxPtzPresetName);
            this.Controls.Add(this.gbxMinConfidence);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyAnalyticConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modify Analytic Config";
            this.gbxSize.ResumeLayout(false);
            this.gbxSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeWidth)).EndInit();
            this.gbxPtzPresetName.ResumeLayout(false);
            this.gbxMinConfidence.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMinConfidence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbxSize;
        private System.Windows.Forms.NumericUpDown nudSizeHeight;
        private System.Windows.Forms.Label lblSizeWidth;
        private System.Windows.Forms.NumericUpDown nudSizeWidth;
        private System.Windows.Forms.Label lblSizeHeight;
        private System.Windows.Forms.GroupBox gbxPtzPresetName;
        private System.Windows.Forms.ComboBox cbxPresets;
        private System.Windows.Forms.GroupBox gbxMinConfidence;
        private System.Windows.Forms.NumericUpDown nudMinConfidence;
    }
}