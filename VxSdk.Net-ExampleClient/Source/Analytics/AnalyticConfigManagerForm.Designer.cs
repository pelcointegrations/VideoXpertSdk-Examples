namespace ExampleClient.Source
{
    partial class AnalyticConfigManagerForm
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
            this.lvAnalyticBehaviors = new System.Windows.Forms.ListView();
            this.chChecked = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIsEnabled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBehaviorType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chObjectType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSensitivity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSeverity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNewBookmark = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.gbxBehaviors = new System.Windows.Forms.GroupBox();
            this.gbxAnalyticConfig = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblIdTitle = new System.Windows.Forms.Label();
            this.gbxSize = new System.Windows.Forms.GroupBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.gbxBehaviors.SuspendLayout();
            this.gbxAnalyticConfig.SuspendLayout();
            this.gbxSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            this.SuspendLayout();
            // 
            // lvAnalyticBehaviors
            // 
            this.lvAnalyticBehaviors.CheckBoxes = true;
            this.lvAnalyticBehaviors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chChecked,
            this.chId,
            this.chName,
            this.chIsEnabled,
            this.chBehaviorType,
            this.chObjectType,
            this.chSensitivity,
            this.chSeverity});
            this.lvAnalyticBehaviors.FullRowSelect = true;
            this.lvAnalyticBehaviors.GridLines = true;
            this.lvAnalyticBehaviors.HideSelection = false;
            this.lvAnalyticBehaviors.Location = new System.Drawing.Point(6, 19);
            this.lvAnalyticBehaviors.MultiSelect = false;
            this.lvAnalyticBehaviors.Name = "lvAnalyticBehaviors";
            this.lvAnalyticBehaviors.Size = new System.Drawing.Size(780, 186);
            this.lvAnalyticBehaviors.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvAnalyticBehaviors.TabIndex = 0;
            this.lvAnalyticBehaviors.UseCompatibleStateImageBehavior = false;
            this.lvAnalyticBehaviors.View = System.Windows.Forms.View.Details;
            this.lvAnalyticBehaviors.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ListViewAnalyticBehaviors_ItemCheck);
            this.lvAnalyticBehaviors.SelectedIndexChanged += new System.EventHandler(this.ListViewAnalyticBehaviors_SelectedIndexChanged);
            // 
            // chChecked
            // 
            this.chChecked.Text = "";
            this.chChecked.Width = 20;
            // 
            // chId
            // 
            this.chId.Text = "ID";
            this.chId.Width = 224;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 130;
            // 
            // chIsEnabled
            // 
            this.chIsEnabled.Text = "Enabled";
            // 
            // chBehaviorType
            // 
            this.chBehaviorType.Text = "Behavior Type";
            this.chBehaviorType.Width = 110;
            // 
            // chObjectType
            // 
            this.chObjectType.Text = "Object Type";
            this.chObjectType.Width = 110;
            // 
            // chSensitivity
            // 
            this.chSensitivity.Text = "Sensitivity";
            // 
            // chSeverity
            // 
            this.chSeverity.Text = "Severity";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(792, 77);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // btnNewBookmark
            // 
            this.btnNewBookmark.Location = new System.Drawing.Point(792, 19);
            this.btnNewBookmark.Name = "btnNewBookmark";
            this.btnNewBookmark.Size = new System.Drawing.Size(90, 23);
            this.btnNewBookmark.TabIndex = 3;
            this.btnNewBookmark.Text = "New Behavior";
            this.btnNewBookmark.UseVisualStyleBackColor = true;
            this.btnNewBookmark.Click += new System.EventHandler(this.ButtonNewBehavior_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(792, 106);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(89, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(792, 48);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(90, 23);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.ButtonModify_Click);
            // 
            // gbxBehaviors
            // 
            this.gbxBehaviors.Controls.Add(this.lvAnalyticBehaviors);
            this.gbxBehaviors.Controls.Add(this.btnModify);
            this.gbxBehaviors.Controls.Add(this.btnNewBookmark);
            this.gbxBehaviors.Controls.Add(this.btnRefresh);
            this.gbxBehaviors.Controls.Add(this.btnDelete);
            this.gbxBehaviors.Location = new System.Drawing.Point(12, 129);
            this.gbxBehaviors.Name = "gbxBehaviors";
            this.gbxBehaviors.Size = new System.Drawing.Size(890, 214);
            this.gbxBehaviors.TabIndex = 6;
            this.gbxBehaviors.TabStop = false;
            this.gbxBehaviors.Text = "Analytic Behaviors";
            // 
            // gbxAnalyticConfig
            // 
            this.gbxAnalyticConfig.Controls.Add(this.lblId);
            this.gbxAnalyticConfig.Controls.Add(this.lblIdTitle);
            this.gbxAnalyticConfig.Controls.Add(this.gbxSize);
            this.gbxAnalyticConfig.Location = new System.Drawing.Point(12, 12);
            this.gbxAnalyticConfig.Name = "gbxAnalyticConfig";
            this.gbxAnalyticConfig.Size = new System.Drawing.Size(890, 111);
            this.gbxAnalyticConfig.TabIndex = 7;
            this.gbxAnalyticConfig.TabStop = false;
            this.gbxAnalyticConfig.Text = "Analytic Config";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(42, 20);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 11;
            // 
            // lblIdTitle
            // 
            this.lblIdTitle.AutoSize = true;
            this.lblIdTitle.Location = new System.Drawing.Point(15, 20);
            this.lblIdTitle.Name = "lblIdTitle";
            this.lblIdTitle.Size = new System.Drawing.Size(21, 13);
            this.lblIdTitle.TabIndex = 10;
            this.lblIdTitle.Text = "ID:";
            // 
            // gbxSize
            // 
            this.gbxSize.Controls.Add(this.btnSet);
            this.gbxSize.Controls.Add(this.nudX);
            this.gbxSize.Controls.Add(this.lblY);
            this.gbxSize.Controls.Add(this.lblX);
            this.gbxSize.Controls.Add(this.nudY);
            this.gbxSize.Location = new System.Drawing.Point(6, 50);
            this.gbxSize.Name = "gbxSize";
            this.gbxSize.Size = new System.Drawing.Size(358, 55);
            this.gbxSize.TabIndex = 9;
            this.gbxSize.TabStop = false;
            this.gbxSize.Text = "Size";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(265, 16);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 4;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.ButtonSet_Click);
            // 
            // nudX
            // 
            this.nudX.Location = new System.Drawing.Point(36, 19);
            this.nudX.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(89, 20);
            this.nudX.TabIndex = 7;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(136, 21);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 13);
            this.lblY.TabIndex = 8;
            this.lblY.Text = "Y:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(13, 21);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 13);
            this.lblX.TabIndex = 6;
            this.lblX.Text = "X:";
            // 
            // nudY
            // 
            this.nudY.Location = new System.Drawing.Point(159, 19);
            this.nudY.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(89, 20);
            this.nudY.TabIndex = 5;
            // 
            // AnalyticConfigManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 357);
            this.Controls.Add(this.gbxAnalyticConfig);
            this.Controls.Add(this.gbxBehaviors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnalyticConfigManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Analytic Config Manager";
            this.gbxBehaviors.ResumeLayout(false);
            this.gbxAnalyticConfig.ResumeLayout(false);
            this.gbxAnalyticConfig.PerformLayout();
            this.gbxSize.ResumeLayout(false);
            this.gbxSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvAnalyticBehaviors;
        private System.Windows.Forms.ColumnHeader chBehaviorType;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNewBookmark;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ColumnHeader chIsEnabled;
        private System.Windows.Forms.ColumnHeader chObjectType;
        private System.Windows.Forms.ColumnHeader chChecked;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.ColumnHeader chSensitivity;
        private System.Windows.Forms.ColumnHeader chSeverity;
        private System.Windows.Forms.GroupBox gbxBehaviors;
        private System.Windows.Forms.GroupBox gbxAnalyticConfig;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblIdTitle;
        private System.Windows.Forms.GroupBox gbxSize;
    }
}