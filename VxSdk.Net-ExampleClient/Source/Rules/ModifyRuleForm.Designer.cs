namespace ExampleClient.Source
{
    partial class ModifyRuleForm
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
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.gbxRuleTriggers = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lvRuleTriggers = new System.Windows.Forms.ListView();
            this.chSelection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSituationType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSource = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.chbxIsEnabled = new System.Windows.Forms.CheckBox();
            this.gbxTimeTables = new System.Windows.Forms.GroupBox();
            this.lvTimeTables = new System.Windows.Forms.ListView();
            this.chTimeTable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxSettings = new System.Windows.Forms.GroupBox();
            this.gbxRuleResponses = new System.Windows.Forms.GroupBox();
            this.btnRemoveResponse = new System.Windows.Forms.Button();
            this.lvRuleResponses = new System.Windows.Forms.ListView();
            this.chSelectionResponse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chResponse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddResponse = new System.Windows.Forms.Button();
            this.gbxRuleTriggers.SuspendLayout();
            this.gbxTimeTables.SuspendLayout();
            this.gbxSettings.SuspendLayout();
            this.gbxRuleResponses.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(1074, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(1164, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(57, 20);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(188, 20);
            this.tbxName.TabIndex = 36;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(13, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 35;
            this.lblName.Text = "Name: ";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbxRuleTriggers
            // 
            this.gbxRuleTriggers.Controls.Add(this.btnRemove);
            this.gbxRuleTriggers.Controls.Add(this.lvRuleTriggers);
            this.gbxRuleTriggers.Controls.Add(this.btnAdd);
            this.gbxRuleTriggers.Location = new System.Drawing.Point(423, 12);
            this.gbxRuleTriggers.Name = "gbxRuleTriggers";
            this.gbxRuleTriggers.Size = new System.Drawing.Size(405, 302);
            this.gbxRuleTriggers.TabIndex = 42;
            this.gbxRuleTriggers.TabStop = false;
            this.gbxRuleTriggers.Text = "Rule Triggers";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(14, 269);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(63, 23);
            this.btnRemove.TabIndex = 24;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // lvRuleTriggers
            // 
            this.lvRuleTriggers.CheckBoxes = true;
            this.lvRuleTriggers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSelection,
            this.chSituationType,
            this.chSource});
            this.lvRuleTriggers.FullRowSelect = true;
            this.lvRuleTriggers.GridLines = true;
            this.lvRuleTriggers.HideSelection = false;
            this.lvRuleTriggers.Location = new System.Drawing.Point(14, 19);
            this.lvRuleTriggers.MultiSelect = false;
            this.lvRuleTriggers.Name = "lvRuleTriggers";
            this.lvRuleTriggers.Size = new System.Drawing.Size(377, 244);
            this.lvRuleTriggers.TabIndex = 0;
            this.lvRuleTriggers.UseCompatibleStateImageBehavior = false;
            this.lvRuleTriggers.View = System.Windows.Forms.View.Details;
            // 
            // chSelection
            // 
            this.chSelection.Text = "";
            this.chSelection.Width = 24;
            // 
            // chSituationType
            // 
            this.chSituationType.Text = "Situation Type";
            this.chSituationType.Width = 199;
            // 
            // chSource
            // 
            this.chSource.Text = "Source";
            this.chSource.Width = 150;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(328, 269);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(63, 23);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // chbxIsEnabled
            // 
            this.chbxIsEnabled.AutoSize = true;
            this.chbxIsEnabled.Location = new System.Drawing.Point(269, 23);
            this.chbxIsEnabled.Name = "chbxIsEnabled";
            this.chbxIsEnabled.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chbxIsEnabled.Size = new System.Drawing.Size(65, 17);
            this.chbxIsEnabled.TabIndex = 44;
            this.chbxIsEnabled.Text = "Enabled";
            this.chbxIsEnabled.UseVisualStyleBackColor = true;
            // 
            // gbxTimeTables
            // 
            this.gbxTimeTables.Controls.Add(this.lvTimeTables);
            this.gbxTimeTables.Location = new System.Drawing.Point(12, 72);
            this.gbxTimeTables.Name = "gbxTimeTables";
            this.gbxTimeTables.Size = new System.Drawing.Size(405, 242);
            this.gbxTimeTables.TabIndex = 43;
            this.gbxTimeTables.TabStop = false;
            this.gbxTimeTables.Text = "Time Tables";
            // 
            // lvTimeTables
            // 
            this.lvTimeTables.CheckBoxes = true;
            this.lvTimeTables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTimeTable,
            this.chName});
            this.lvTimeTables.FullRowSelect = true;
            this.lvTimeTables.GridLines = true;
            this.lvTimeTables.HideSelection = false;
            this.lvTimeTables.Location = new System.Drawing.Point(14, 19);
            this.lvTimeTables.MultiSelect = false;
            this.lvTimeTables.Name = "lvTimeTables";
            this.lvTimeTables.Size = new System.Drawing.Size(377, 213);
            this.lvTimeTables.TabIndex = 0;
            this.lvTimeTables.UseCompatibleStateImageBehavior = false;
            this.lvTimeTables.View = System.Windows.Forms.View.Details;
            // 
            // chTimeTable
            // 
            this.chTimeTable.Text = "";
            this.chTimeTable.Width = 24;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 199;
            // 
            // gbxSettings
            // 
            this.gbxSettings.Controls.Add(this.tbxName);
            this.gbxSettings.Controls.Add(this.chbxIsEnabled);
            this.gbxSettings.Controls.Add(this.lblName);
            this.gbxSettings.Location = new System.Drawing.Point(12, 12);
            this.gbxSettings.Name = "gbxSettings";
            this.gbxSettings.Size = new System.Drawing.Size(405, 58);
            this.gbxSettings.TabIndex = 46;
            this.gbxSettings.TabStop = false;
            this.gbxSettings.Text = "Settings";
            // 
            // gbxRuleResponses
            // 
            this.gbxRuleResponses.Controls.Add(this.btnRemoveResponse);
            this.gbxRuleResponses.Controls.Add(this.lvRuleResponses);
            this.gbxRuleResponses.Controls.Add(this.btnAddResponse);
            this.gbxRuleResponses.Location = new System.Drawing.Point(834, 12);
            this.gbxRuleResponses.Name = "gbxRuleResponses";
            this.gbxRuleResponses.Size = new System.Drawing.Size(405, 302);
            this.gbxRuleResponses.TabIndex = 43;
            this.gbxRuleResponses.TabStop = false;
            this.gbxRuleResponses.Text = "Rule Responses";
            // 
            // btnRemoveResponse
            // 
            this.btnRemoveResponse.Location = new System.Drawing.Point(14, 269);
            this.btnRemoveResponse.Name = "btnRemoveResponse";
            this.btnRemoveResponse.Size = new System.Drawing.Size(63, 23);
            this.btnRemoveResponse.TabIndex = 24;
            this.btnRemoveResponse.Text = "Remove";
            this.btnRemoveResponse.UseVisualStyleBackColor = true;
            this.btnRemoveResponse.Click += new System.EventHandler(this.ButtonRemoveResponse_Click);
            // 
            // lvRuleResponses
            // 
            this.lvRuleResponses.CheckBoxes = true;
            this.lvRuleResponses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSelectionResponse,
            this.chResponse});
            this.lvRuleResponses.FullRowSelect = true;
            this.lvRuleResponses.GridLines = true;
            this.lvRuleResponses.HideSelection = false;
            this.lvRuleResponses.Location = new System.Drawing.Point(14, 19);
            this.lvRuleResponses.MultiSelect = false;
            this.lvRuleResponses.Name = "lvRuleResponses";
            this.lvRuleResponses.Size = new System.Drawing.Size(377, 244);
            this.lvRuleResponses.TabIndex = 0;
            this.lvRuleResponses.UseCompatibleStateImageBehavior = false;
            this.lvRuleResponses.View = System.Windows.Forms.View.Details;
            // 
            // chSelectionResponse
            // 
            this.chSelectionResponse.Text = "";
            this.chSelectionResponse.Width = 24;
            // 
            // chResponse
            // 
            this.chResponse.Text = "Response Info";
            this.chResponse.Width = 349;
            // 
            // btnAddResponse
            // 
            this.btnAddResponse.Location = new System.Drawing.Point(328, 269);
            this.btnAddResponse.Name = "btnAddResponse";
            this.btnAddResponse.Size = new System.Drawing.Size(63, 23);
            this.btnAddResponse.TabIndex = 22;
            this.btnAddResponse.Text = "Add";
            this.btnAddResponse.UseVisualStyleBackColor = true;
            this.btnAddResponse.Click += new System.EventHandler(this.ButtonAddResponse_Click);
            // 
            // ModifyRuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 354);
            this.Controls.Add(this.gbxRuleResponses);
            this.Controls.Add(this.gbxSettings);
            this.Controls.Add(this.gbxTimeTables);
            this.Controls.Add(this.gbxRuleTriggers);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyRuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modify Rule";
            this.gbxRuleTriggers.ResumeLayout(false);
            this.gbxTimeTables.ResumeLayout(false);
            this.gbxSettings.ResumeLayout(false);
            this.gbxSettings.PerformLayout();
            this.gbxRuleResponses.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbxRuleTriggers;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.ListView lvRuleTriggers;
        private System.Windows.Forms.ColumnHeader chSelection;
        private System.Windows.Forms.ColumnHeader chSituationType;
        private System.Windows.Forms.ColumnHeader chSource;
        private System.Windows.Forms.CheckBox chbxIsEnabled;
        private System.Windows.Forms.GroupBox gbxTimeTables;
        private System.Windows.Forms.ListView lvTimeTables;
        private System.Windows.Forms.ColumnHeader chTimeTable;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.GroupBox gbxSettings;
        private System.Windows.Forms.GroupBox gbxRuleResponses;
        private System.Windows.Forms.Button btnRemoveResponse;
        public System.Windows.Forms.ListView lvRuleResponses;
        private System.Windows.Forms.ColumnHeader chSelectionResponse;
        private System.Windows.Forms.ColumnHeader chResponse;
        private System.Windows.Forms.Button btnAddResponse;
    }
}