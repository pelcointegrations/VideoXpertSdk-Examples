namespace ExampleClient.Source
{
    partial class EventConfigurationForm
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
            this.nudLocalEventLimit = new System.Windows.Forms.NumericUpDown();
            this.lblLocalEventLimit = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAggregatedEventLimit = new System.Windows.Forms.Label();
            this.nudAggregatedEventLimit = new System.Windows.Forms.NumericUpDown();
            this.lblMaxEvents = new System.Windows.Forms.Label();
            this.nudMaxEvents = new System.Windows.Forms.NumericUpDown();
            this.gbxServerSettings = new System.Windows.Forms.GroupBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tlpEventConfig = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nudLocalEventLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAggregatedEventLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxEvents)).BeginInit();
            this.gbxServerSettings.SuspendLayout();
            this.tlpEventConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudLocalEventLimit
            // 
            this.nudLocalEventLimit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudLocalEventLimit.Location = new System.Drawing.Point(160, 29);
            this.nudLocalEventLimit.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudLocalEventLimit.Name = "nudLocalEventLimit";
            this.nudLocalEventLimit.Size = new System.Drawing.Size(72, 20);
            this.nudLocalEventLimit.TabIndex = 5;
            // 
            // lblLocalEventLimit
            // 
            this.lblLocalEventLimit.AutoSize = true;
            this.lblLocalEventLimit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLocalEventLimit.Location = new System.Drawing.Point(3, 26);
            this.lblLocalEventLimit.Name = "lblLocalEventLimit";
            this.lblLocalEventLimit.Size = new System.Drawing.Size(151, 26);
            this.lblLocalEventLimit.TabIndex = 6;
            this.lblLocalEventLimit.Text = "Local Event Limit (days):";
            this.lblLocalEventLimit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(185, 122);
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
            this.btnCancel.Location = new System.Drawing.Point(104, 122);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblAggregatedEventLimit
            // 
            this.lblAggregatedEventLimit.AutoSize = true;
            this.lblAggregatedEventLimit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAggregatedEventLimit.Location = new System.Drawing.Point(3, 0);
            this.lblAggregatedEventLimit.Name = "lblAggregatedEventLimit";
            this.lblAggregatedEventLimit.Size = new System.Drawing.Size(151, 26);
            this.lblAggregatedEventLimit.TabIndex = 29;
            this.lblAggregatedEventLimit.Text = "Aggregated Event Limit (days):";
            this.lblAggregatedEventLimit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudAggregatedEventLimit
            // 
            this.nudAggregatedEventLimit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudAggregatedEventLimit.Location = new System.Drawing.Point(160, 3);
            this.nudAggregatedEventLimit.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudAggregatedEventLimit.Name = "nudAggregatedEventLimit";
            this.nudAggregatedEventLimit.Size = new System.Drawing.Size(72, 20);
            this.nudAggregatedEventLimit.TabIndex = 28;
            // 
            // lblMaxEvents
            // 
            this.lblMaxEvents.AutoSize = true;
            this.lblMaxEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaxEvents.Location = new System.Drawing.Point(3, 52);
            this.lblMaxEvents.Name = "lblMaxEvents";
            this.lblMaxEvents.Size = new System.Drawing.Size(151, 26);
            this.lblMaxEvents.TabIndex = 31;
            this.lblMaxEvents.Text = "Maximum Total Events:";
            this.lblMaxEvents.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudMaxEvents
            // 
            this.nudMaxEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudMaxEvents.Location = new System.Drawing.Point(160, 55);
            this.nudMaxEvents.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudMaxEvents.Name = "nudMaxEvents";
            this.nudMaxEvents.Size = new System.Drawing.Size(72, 20);
            this.nudMaxEvents.TabIndex = 30;
            // 
            // gbxServerSettings
            // 
            this.gbxServerSettings.Controls.Add(this.tlpEventConfig);
            this.gbxServerSettings.Location = new System.Drawing.Point(9, 12);
            this.gbxServerSettings.Name = "gbxServerSettings";
            this.gbxServerSettings.Size = new System.Drawing.Size(251, 104);
            this.gbxServerSettings.TabIndex = 32;
            this.gbxServerSettings.TabStop = false;
            this.gbxServerSettings.Text = "Event Retention";
            // 
            // tlpEventConfig
            // 
            this.tlpEventConfig.ColumnCount = 2;
            this.tlpEventConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEventConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEventConfig.Controls.Add(this.lblAggregatedEventLimit, 0, 0);
            this.tlpEventConfig.Controls.Add(this.lblMaxEvents, 0, 2);
            this.tlpEventConfig.Controls.Add(this.lblLocalEventLimit, 0, 1);
            this.tlpEventConfig.Controls.Add(this.nudMaxEvents, 1, 2);
            this.tlpEventConfig.Controls.Add(this.nudAggregatedEventLimit, 1, 0);
            this.tlpEventConfig.Controls.Add(this.nudLocalEventLimit, 1, 1);
            this.tlpEventConfig.Location = new System.Drawing.Point(6, 19);
            this.tlpEventConfig.Name = "tlpEventConfig";
            this.tlpEventConfig.RowCount = 4;
            this.tlpEventConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEventConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEventConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEventConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEventConfig.Size = new System.Drawing.Size(235, 78);
            this.tlpEventConfig.TabIndex = 33;
            // 
            // EventConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 152);
            this.Controls.Add(this.gbxServerSettings);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Event Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.nudLocalEventLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAggregatedEventLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxEvents)).EndInit();
            this.gbxServerSettings.ResumeLayout(false);
            this.tlpEventConfig.ResumeLayout(false);
            this.tlpEventConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudLocalEventLimit;
        private System.Windows.Forms.Label lblLocalEventLimit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAggregatedEventLimit;
        private System.Windows.Forms.NumericUpDown nudAggregatedEventLimit;
        private System.Windows.Forms.Label lblMaxEvents;
        private System.Windows.Forms.NumericUpDown nudMaxEvents;
        private System.Windows.Forms.GroupBox gbxServerSettings;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TableLayoutPanel tlpEventConfig;
    }
}