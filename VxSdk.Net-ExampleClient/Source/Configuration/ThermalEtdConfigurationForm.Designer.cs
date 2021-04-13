namespace ExampleClient.Source
{
    partial class ThermalEtdConfigurationForm
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
            this.cbxEnabled = new System.Windows.Forms.CheckBox();
            this.nudUpperBound = new System.Windows.Forms.NumericUpDown();
            this.lblUpperBound = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblLowerBound = new System.Windows.Forms.Label();
            this.nudLowerBound = new System.Windows.Forms.NumericUpDown();
            this.lblTimeout = new System.Windows.Forms.Label();
            this.nudTimeout = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpperBound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowerBound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxEnabled
            // 
            this.cbxEnabled.AutoSize = true;
            this.cbxEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxEnabled.Location = new System.Drawing.Point(132, 9);
            this.cbxEnabled.Name = "cbxEnabled";
            this.cbxEnabled.Size = new System.Drawing.Size(71, 17);
            this.cbxEnabled.TabIndex = 0;
            this.cbxEnabled.Text = "Enabled: ";
            this.cbxEnabled.UseVisualStyleBackColor = true;
            this.cbxEnabled.CheckedChanged += new System.EventHandler(this.CheckBoxEnabled_CheckedChanged);
            // 
            // nudUpperBound
            // 
            this.nudUpperBound.Enabled = false;
            this.nudUpperBound.Location = new System.Drawing.Point(190, 58);
            this.nudUpperBound.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudUpperBound.Name = "nudUpperBound";
            this.nudUpperBound.Size = new System.Drawing.Size(71, 20);
            this.nudUpperBound.TabIndex = 5;
            // 
            // lblUpperBound
            // 
            this.lblUpperBound.AutoSize = true;
            this.lblUpperBound.Enabled = false;
            this.lblUpperBound.Location = new System.Drawing.Point(7, 60);
            this.lblUpperBound.Name = "lblUpperBound";
            this.lblUpperBound.Size = new System.Drawing.Size(178, 13);
            this.lblUpperBound.TabIndex = 6;
            this.lblUpperBound.Text = "Normal Range Upper Boundary (°C):";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(186, 127);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(105, 127);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblLowerBound
            // 
            this.lblLowerBound.AutoSize = true;
            this.lblLowerBound.Enabled = false;
            this.lblLowerBound.Location = new System.Drawing.Point(7, 34);
            this.lblLowerBound.Name = "lblLowerBound";
            this.lblLowerBound.Size = new System.Drawing.Size(178, 13);
            this.lblLowerBound.TabIndex = 29;
            this.lblLowerBound.Text = "Normal Range Lower Boundary (°C):";
            // 
            // nudLowerBound
            // 
            this.nudLowerBound.Enabled = false;
            this.nudLowerBound.Location = new System.Drawing.Point(190, 32);
            this.nudLowerBound.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudLowerBound.Name = "nudLowerBound";
            this.nudLowerBound.Size = new System.Drawing.Size(71, 20);
            this.nudLowerBound.TabIndex = 28;
            // 
            // lblTimeout
            // 
            this.lblTimeout.AutoSize = true;
            this.lblTimeout.Enabled = false;
            this.lblTimeout.Location = new System.Drawing.Point(81, 86);
            this.lblTimeout.Name = "lblTimeout";
            this.lblTimeout.Size = new System.Drawing.Size(104, 13);
            this.lblTimeout.TabIndex = 31;
            this.lblTimeout.Text = "New Event Timeout:";
            // 
            // nudTimeout
            // 
            this.nudTimeout.Enabled = false;
            this.nudTimeout.Location = new System.Drawing.Point(190, 84);
            this.nudTimeout.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudTimeout.Name = "nudTimeout";
            this.nudTimeout.Size = new System.Drawing.Size(71, 20);
            this.nudTimeout.TabIndex = 30;
            // 
            // ThermalEtdConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 160);
            this.Controls.Add(this.nudUpperBound);
            this.Controls.Add(this.lblUpperBound);
            this.Controls.Add(this.nudLowerBound);
            this.Controls.Add(this.nudTimeout);
            this.Controls.Add(this.lblLowerBound);
            this.Controls.Add(this.lblTimeout);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbxEnabled);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThermalEtdConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thermal ETD Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.nudUpperBound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowerBound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxEnabled;
        private System.Windows.Forms.NumericUpDown nudUpperBound;
        private System.Windows.Forms.Label lblUpperBound;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblLowerBound;
        private System.Windows.Forms.NumericUpDown nudLowerBound;
        private System.Windows.Forms.Label lblTimeout;
        private System.Windows.Forms.NumericUpDown nudTimeout;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}