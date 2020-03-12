namespace ExampleClient.Source
{
    partial class ModifyMotionConfigForm
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
            this.lblSensitivity = new System.Windows.Forms.Label();
            this.nudSensitivity = new System.Windows.Forms.NumericUpDown();
            this.rbDisabled = new System.Windows.Forms.RadioButton();
            this.rbCamera = new System.Windows.Forms.RadioButton();
            this.rbRecorder = new System.Windows.Forms.RadioButton();
            this.lblMotionDetectionMode = new System.Windows.Forms.Label();
            this.nudThreshold = new System.Windows.Forms.NumericUpDown();
            this.lblThreshold = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSensitivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(186, 68);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(267, 68);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // lblSensitivity
            // 
            this.lblSensitivity.Location = new System.Drawing.Point(59, 38);
            this.lblSensitivity.Name = "lblSensitivity";
            this.lblSensitivity.Size = new System.Drawing.Size(61, 13);
            this.lblSensitivity.TabIndex = 33;
            this.lblSensitivity.Text = "Sensitivity: ";
            this.lblSensitivity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudSensitivity
            // 
            this.nudSensitivity.Location = new System.Drawing.Point(123, 34);
            this.nudSensitivity.Margin = new System.Windows.Forms.Padding(2);
            this.nudSensitivity.Name = "nudSensitivity";
            this.nudSensitivity.Size = new System.Drawing.Size(50, 20);
            this.nudSensitivity.TabIndex = 37;
            // 
            // rbDisabled
            // 
            this.rbDisabled.AutoSize = true;
            this.rbDisabled.Location = new System.Drawing.Point(139, 11);
            this.rbDisabled.Name = "rbDisabled";
            this.rbDisabled.Size = new System.Drawing.Size(66, 17);
            this.rbDisabled.TabIndex = 40;
            this.rbDisabled.TabStop = true;
            this.rbDisabled.Text = "Disabled";
            this.rbDisabled.UseVisualStyleBackColor = true;
            this.rbDisabled.Click += new System.EventHandler(this.RadioButtonMode_Click);
            // 
            // rbCamera
            // 
            this.rbCamera.AutoSize = true;
            this.rbCamera.Location = new System.Drawing.Point(211, 11);
            this.rbCamera.Name = "rbCamera";
            this.rbCamera.Size = new System.Drawing.Size(61, 17);
            this.rbCamera.TabIndex = 41;
            this.rbCamera.TabStop = true;
            this.rbCamera.Text = "Camera";
            this.rbCamera.UseVisualStyleBackColor = true;
            this.rbCamera.Click += new System.EventHandler(this.RadioButtonMode_Click);
            // 
            // rbRecorder
            // 
            this.rbRecorder.AutoSize = true;
            this.rbRecorder.Location = new System.Drawing.Point(278, 11);
            this.rbRecorder.Name = "rbRecorder";
            this.rbRecorder.Size = new System.Drawing.Size(69, 17);
            this.rbRecorder.TabIndex = 42;
            this.rbRecorder.TabStop = true;
            this.rbRecorder.Text = "Recorder";
            this.rbRecorder.UseVisualStyleBackColor = true;
            this.rbRecorder.Click += new System.EventHandler(this.RadioButtonMode_Click);
            // 
            // lblMotionDetectionMode
            // 
            this.lblMotionDetectionMode.AutoSize = true;
            this.lblMotionDetectionMode.Location = new System.Drawing.Point(12, 13);
            this.lblMotionDetectionMode.Name = "lblMotionDetectionMode";
            this.lblMotionDetectionMode.Size = new System.Drawing.Size(124, 13);
            this.lblMotionDetectionMode.TabIndex = 43;
            this.lblMotionDetectionMode.Text = "Motion Detection Mode: ";
            this.lblMotionDetectionMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudThreshold
            // 
            this.nudThreshold.Location = new System.Drawing.Point(245, 34);
            this.nudThreshold.Margin = new System.Windows.Forms.Padding(2);
            this.nudThreshold.Name = "nudThreshold";
            this.nudThreshold.Size = new System.Drawing.Size(50, 20);
            this.nudThreshold.TabIndex = 45;
            // 
            // lblThreshold
            // 
            this.lblThreshold.Location = new System.Drawing.Point(181, 38);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(61, 13);
            this.lblThreshold.TabIndex = 44;
            this.lblThreshold.Text = "Threshold: ";
            this.lblThreshold.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ModifyMotionConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 100);
            this.Controls.Add(this.nudThreshold);
            this.Controls.Add(this.lblThreshold);
            this.Controls.Add(this.lblMotionDetectionMode);
            this.Controls.Add(this.rbRecorder);
            this.Controls.Add(this.rbCamera);
            this.Controls.Add(this.nudSensitivity);
            this.Controls.Add(this.rbDisabled);
            this.Controls.Add(this.lblSensitivity);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyMotionConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modify Motion Config";
            ((System.ComponentModel.ISupportInitialize)(this.nudSensitivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSensitivity;
        private System.Windows.Forms.NumericUpDown nudSensitivity;
        private System.Windows.Forms.RadioButton rbDisabled;
        private System.Windows.Forms.RadioButton rbRecorder;
        private System.Windows.Forms.RadioButton rbCamera;
        private System.Windows.Forms.Label lblMotionDetectionMode;
        private System.Windows.Forms.NumericUpDown nudThreshold;
        private System.Windows.Forms.Label lblThreshold;
    }
}