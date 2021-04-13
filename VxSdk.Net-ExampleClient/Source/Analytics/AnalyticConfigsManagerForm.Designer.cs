namespace ExampleClient.Source
{
    partial class AnalyticConfigsManagerForm
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
            this.lvAnalyticConfigs = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMinConfidence = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPtzPresetName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chWidth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAnalyticBehaviors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnManageBehaviors = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gbxConfigs = new System.Windows.Forms.GroupBox();
            this.btnGetLineCounts = new System.Windows.Forms.Button();
            this.btnModifyConfig = new System.Windows.Forms.Button();
            this.btnDeleteConfig = new System.Windows.Forms.Button();
            this.btnNewConfig = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblObjectLineCounterCheck = new System.Windows.Forms.Label();
            this.lblObjectWrongWayCheck = new System.Windows.Forms.Label();
            this.lblObjectInZoneCheck = new System.Windows.Forms.Label();
            this.lblObjectLineCounter = new System.Windows.Forms.Label();
            this.lblObjectWrongWay = new System.Windows.Forms.Label();
            this.lblObjectInZone = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblObjectLineCounterResetCheck = new System.Windows.Forms.Label();
            this.lblObjectLineCounterReset = new System.Windows.Forms.Label();
            this.lblObjectLineCounterEventsCheck = new System.Windows.Forms.Label();
            this.lblObjectLineCounterEvents = new System.Windows.Forms.Label();
            this.gbxConfigs.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvAnalyticConfigs
            // 
            this.lvAnalyticConfigs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chMinConfidence,
            this.chPtzPresetName,
            this.chHeight,
            this.chWidth,
            this.chAnalyticBehaviors});
            this.lvAnalyticConfigs.FullRowSelect = true;
            this.lvAnalyticConfigs.GridLines = true;
            this.lvAnalyticConfigs.HideSelection = false;
            this.lvAnalyticConfigs.Location = new System.Drawing.Point(6, 19);
            this.lvAnalyticConfigs.MultiSelect = false;
            this.lvAnalyticConfigs.Name = "lvAnalyticConfigs";
            this.lvAnalyticConfigs.Size = new System.Drawing.Size(743, 152);
            this.lvAnalyticConfigs.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvAnalyticConfigs.TabIndex = 0;
            this.lvAnalyticConfigs.UseCompatibleStateImageBehavior = false;
            this.lvAnalyticConfigs.View = System.Windows.Forms.View.Details;
            // 
            // chId
            // 
            this.chId.Text = "ID";
            this.chId.Width = 251;
            // 
            // chMinConfidence
            // 
            this.chMinConfidence.Text = "Min. Confidence";
            this.chMinConfidence.Width = 100;
            // 
            // chPtzPresetName
            // 
            this.chPtzPresetName.Text = "PTZ Preset Name";
            this.chPtzPresetName.Width = 158;
            // 
            // chHeight
            // 
            this.chHeight.Text = "Height";
            // 
            // chWidth
            // 
            this.chWidth.Text = "Width";
            this.chWidth.Width = 57;
            // 
            // chAnalyticBehaviors
            // 
            this.chAnalyticBehaviors.Text = "Analytic Behaviors";
            this.chAnalyticBehaviors.Width = 110;
            // 
            // btnManageBehaviors
            // 
            this.btnManageBehaviors.Location = new System.Drawing.Point(755, 69);
            this.btnManageBehaviors.Name = "btnManageBehaviors";
            this.btnManageBehaviors.Size = new System.Drawing.Size(106, 23);
            this.btnManageBehaviors.TabIndex = 3;
            this.btnManageBehaviors.Text = "Manage Behaviors";
            this.btnManageBehaviors.UseVisualStyleBackColor = true;
            this.btnManageBehaviors.Click += new System.EventHandler(this.ButtonManageBehaviors_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(755, 148);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(106, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // gbxConfigs
            // 
            this.gbxConfigs.Controls.Add(this.btnGetLineCounts);
            this.gbxConfigs.Controls.Add(this.btnModifyConfig);
            this.gbxConfigs.Controls.Add(this.btnDeleteConfig);
            this.gbxConfigs.Controls.Add(this.btnNewConfig);
            this.gbxConfigs.Controls.Add(this.lvAnalyticConfigs);
            this.gbxConfigs.Controls.Add(this.btnManageBehaviors);
            this.gbxConfigs.Controls.Add(this.btnRefresh);
            this.gbxConfigs.Location = new System.Drawing.Point(218, 12);
            this.gbxConfigs.Name = "gbxConfigs";
            this.gbxConfigs.Size = new System.Drawing.Size(873, 177);
            this.gbxConfigs.TabIndex = 6;
            this.gbxConfigs.TabStop = false;
            this.gbxConfigs.Text = "Analytic Configs";
            // 
            // btnGetLineCounts
            // 
            this.btnGetLineCounts.Location = new System.Drawing.Point(755, 119);
            this.btnGetLineCounts.Name = "btnGetLineCounts";
            this.btnGetLineCounts.Size = new System.Drawing.Size(106, 23);
            this.btnGetLineCounts.TabIndex = 9;
            this.btnGetLineCounts.Text = "Get Line Counts";
            this.btnGetLineCounts.UseVisualStyleBackColor = true;
            this.btnGetLineCounts.Click += new System.EventHandler(this.ButtonGetLineCounts_Click);
            // 
            // btnModifyConfig
            // 
            this.btnModifyConfig.Location = new System.Drawing.Point(755, 44);
            this.btnModifyConfig.Name = "btnModifyConfig";
            this.btnModifyConfig.Size = new System.Drawing.Size(106, 23);
            this.btnModifyConfig.TabIndex = 8;
            this.btnModifyConfig.Text = "Modify";
            this.btnModifyConfig.UseVisualStyleBackColor = true;
            this.btnModifyConfig.Click += new System.EventHandler(this.ButtonModifyConfig_Click);
            // 
            // btnDeleteConfig
            // 
            this.btnDeleteConfig.Location = new System.Drawing.Point(755, 94);
            this.btnDeleteConfig.Name = "btnDeleteConfig";
            this.btnDeleteConfig.Size = new System.Drawing.Size(106, 23);
            this.btnDeleteConfig.TabIndex = 7;
            this.btnDeleteConfig.Text = "Delete";
            this.btnDeleteConfig.UseVisualStyleBackColor = true;
            this.btnDeleteConfig.Click += new System.EventHandler(this.ButtonDeleteConfig_Click);
            // 
            // btnNewConfig
            // 
            this.btnNewConfig.Location = new System.Drawing.Point(755, 19);
            this.btnNewConfig.Name = "btnNewConfig";
            this.btnNewConfig.Size = new System.Drawing.Size(106, 23);
            this.btnNewConfig.TabIndex = 6;
            this.btnNewConfig.Text = "New Config";
            this.btnNewConfig.UseVisualStyleBackColor = true;
            this.btnNewConfig.Click += new System.EventHandler(this.ButtonNewConfig_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblObjectLineCounterCheck);
            this.groupBox1.Controls.Add(this.lblObjectWrongWayCheck);
            this.groupBox1.Controls.Add(this.lblObjectInZoneCheck);
            this.groupBox1.Controls.Add(this.lblObjectLineCounter);
            this.groupBox1.Controls.Add(this.lblObjectWrongWay);
            this.groupBox1.Controls.Add(this.lblObjectInZone);
            this.groupBox1.Location = new System.Drawing.Point(18, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 86);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Available Analytic Behavior Types";
            // 
            // lblObjectLineCounterCheck
            // 
            this.lblObjectLineCounterCheck.AutoSize = true;
            this.lblObjectLineCounterCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblObjectLineCounterCheck.Location = new System.Drawing.Point(6, 62);
            this.lblObjectLineCounterCheck.Name = "lblObjectLineCounterCheck";
            this.lblObjectLineCounterCheck.Size = new System.Drawing.Size(14, 13);
            this.lblObjectLineCounterCheck.TabIndex = 14;
            this.lblObjectLineCounterCheck.Text = "X";
            // 
            // lblObjectWrongWayCheck
            // 
            this.lblObjectWrongWayCheck.AutoSize = true;
            this.lblObjectWrongWayCheck.Location = new System.Drawing.Point(6, 42);
            this.lblObjectWrongWayCheck.Name = "lblObjectWrongWayCheck";
            this.lblObjectWrongWayCheck.Size = new System.Drawing.Size(14, 13);
            this.lblObjectWrongWayCheck.TabIndex = 13;
            this.lblObjectWrongWayCheck.Text = "X";
            // 
            // lblObjectInZoneCheck
            // 
            this.lblObjectInZoneCheck.AutoSize = true;
            this.lblObjectInZoneCheck.Location = new System.Drawing.Point(6, 22);
            this.lblObjectInZoneCheck.Name = "lblObjectInZoneCheck";
            this.lblObjectInZoneCheck.Size = new System.Drawing.Size(14, 13);
            this.lblObjectInZoneCheck.TabIndex = 9;
            this.lblObjectInZoneCheck.Text = "X";
            // 
            // lblObjectLineCounter
            // 
            this.lblObjectLineCounter.AutoSize = true;
            this.lblObjectLineCounter.Location = new System.Drawing.Point(20, 62);
            this.lblObjectLineCounter.Name = "lblObjectLineCounter";
            this.lblObjectLineCounter.Size = new System.Drawing.Size(101, 13);
            this.lblObjectLineCounter.TabIndex = 12;
            this.lblObjectLineCounter.Text = "Object Line Counter";
            // 
            // lblObjectWrongWay
            // 
            this.lblObjectWrongWay.AutoSize = true;
            this.lblObjectWrongWay.Location = new System.Drawing.Point(20, 42);
            this.lblObjectWrongWay.Name = "lblObjectWrongWay";
            this.lblObjectWrongWay.Size = new System.Drawing.Size(98, 13);
            this.lblObjectWrongWay.TabIndex = 10;
            this.lblObjectWrongWay.Text = "Object Wrong Way";
            // 
            // lblObjectInZone
            // 
            this.lblObjectInZone.AutoSize = true;
            this.lblObjectInZone.Location = new System.Drawing.Point(20, 22);
            this.lblObjectInZone.Name = "lblObjectInZone";
            this.lblObjectInZone.Size = new System.Drawing.Size(78, 13);
            this.lblObjectInZone.TabIndex = 0;
            this.lblObjectInZone.Text = "Object In Zone";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblObjectLineCounterResetCheck);
            this.groupBox2.Controls.Add(this.lblObjectLineCounterReset);
            this.groupBox2.Controls.Add(this.lblObjectLineCounterEventsCheck);
            this.groupBox2.Controls.Add(this.lblObjectLineCounterEvents);
            this.groupBox2.Location = new System.Drawing.Point(18, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 86);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Analytic Capabilities";
            // 
            // lblObjectLineCounterResetCheck
            // 
            this.lblObjectLineCounterResetCheck.AutoSize = true;
            this.lblObjectLineCounterResetCheck.Location = new System.Drawing.Point(6, 42);
            this.lblObjectLineCounterResetCheck.Name = "lblObjectLineCounterResetCheck";
            this.lblObjectLineCounterResetCheck.Size = new System.Drawing.Size(14, 13);
            this.lblObjectLineCounterResetCheck.TabIndex = 18;
            this.lblObjectLineCounterResetCheck.Text = "X";
            // 
            // lblObjectLineCounterReset
            // 
            this.lblObjectLineCounterReset.AutoSize = true;
            this.lblObjectLineCounterReset.Location = new System.Drawing.Point(20, 42);
            this.lblObjectLineCounterReset.Name = "lblObjectLineCounterReset";
            this.lblObjectLineCounterReset.Size = new System.Drawing.Size(132, 13);
            this.lblObjectLineCounterReset.TabIndex = 17;
            this.lblObjectLineCounterReset.Text = "Object Line Counter Reset";
            // 
            // lblObjectLineCounterEventsCheck
            // 
            this.lblObjectLineCounterEventsCheck.AutoSize = true;
            this.lblObjectLineCounterEventsCheck.Location = new System.Drawing.Point(6, 22);
            this.lblObjectLineCounterEventsCheck.Name = "lblObjectLineCounterEventsCheck";
            this.lblObjectLineCounterEventsCheck.Size = new System.Drawing.Size(14, 13);
            this.lblObjectLineCounterEventsCheck.TabIndex = 16;
            this.lblObjectLineCounterEventsCheck.Text = "X";
            // 
            // lblObjectLineCounterEvents
            // 
            this.lblObjectLineCounterEvents.AutoSize = true;
            this.lblObjectLineCounterEvents.Location = new System.Drawing.Point(20, 22);
            this.lblObjectLineCounterEvents.Name = "lblObjectLineCounterEvents";
            this.lblObjectLineCounterEvents.Size = new System.Drawing.Size(137, 13);
            this.lblObjectLineCounterEvents.TabIndex = 15;
            this.lblObjectLineCounterEvents.Text = "Object Line Counter Events";
            // 
            // AnalyticConfigsManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 201);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxConfigs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnalyticConfigsManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Analytic Config Manager";
            this.gbxConfigs.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvAnalyticConfigs;
        private System.Windows.Forms.ColumnHeader chWidth;
        private System.Windows.Forms.ColumnHeader chPtzPresetName;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.Button btnManageBehaviors;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ColumnHeader chHeight;
        private System.Windows.Forms.ColumnHeader chAnalyticBehaviors;
        private System.Windows.Forms.GroupBox gbxConfigs;
        private System.Windows.Forms.Button btnModifyConfig;
        private System.Windows.Forms.Button btnDeleteConfig;
        private System.Windows.Forms.Button btnNewConfig;
        private System.Windows.Forms.ColumnHeader chMinConfidence;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblObjectInZone;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblObjectLineCounter;
        private System.Windows.Forms.Label lblObjectWrongWay;
        private System.Windows.Forms.Label lblObjectLineCounterCheck;
        private System.Windows.Forms.Label lblObjectWrongWayCheck;
        private System.Windows.Forms.Label lblObjectInZoneCheck;
        private System.Windows.Forms.Label lblObjectLineCounterResetCheck;
        private System.Windows.Forms.Label lblObjectLineCounterReset;
        private System.Windows.Forms.Label lblObjectLineCounterEventsCheck;
        private System.Windows.Forms.Label lblObjectLineCounterEvents;
        private System.Windows.Forms.Button btnGetLineCounts;
    }
}