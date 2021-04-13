namespace ExampleClient.Source
{
    partial class AddRuleForm
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
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTimeTable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvTimeTables = new System.Windows.Forms.ListView();
            this.gbxTimeTables = new System.Windows.Forms.GroupBox();
            this.chbxIsEnabled = new System.Windows.Forms.CheckBox();
            this.chSource = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxSettings = new System.Windows.Forms.GroupBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.chSituationType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemove = new System.Windows.Forms.Button();
            this.lvRuleTriggers = new System.Windows.Forms.ListView();
            this.chSelection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxRuleTriggers = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxRuleResponses = new System.Windows.Forms.GroupBox();
            this.btnRemoveResponse = new System.Windows.Forms.Button();
            this.lvRuleResponses = new System.Windows.Forms.ListView();
            this.chSelectionResponse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chResponse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddResponse = new System.Windows.Forms.Button();
            this.gbxTimeTables.SuspendLayout();
            this.gbxSettings.SuspendLayout();
            this.gbxRuleTriggers.SuspendLayout();
            this.gbxRuleResponses.SuspendLayout();
            this.SuspendLayout();
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 199;
            // 
            // chTimeTable
            // 
            this.chTimeTable.Text = "";
            this.chTimeTable.Width = 24;
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
            this.lvTimeTables.Location = new System.Drawing.Point(7, 19);
            this.lvTimeTables.MultiSelect = false;
            this.lvTimeTables.Name = "lvTimeTables";
            this.lvTimeTables.Size = new System.Drawing.Size(377, 207);
            this.lvTimeTables.TabIndex = 0;
            this.lvTimeTables.UseCompatibleStateImageBehavior = false;
            this.lvTimeTables.View = System.Windows.Forms.View.Details;
            // 
            // gbxTimeTables
            // 
            this.gbxTimeTables.Controls.Add(this.lvTimeTables);
            this.gbxTimeTables.Location = new System.Drawing.Point(12, 73);
            this.gbxTimeTables.Name = "gbxTimeTables";
            this.gbxTimeTables.Size = new System.Drawing.Size(391, 232);
            this.gbxTimeTables.TabIndex = 51;
            this.gbxTimeTables.TabStop = false;
            this.gbxTimeTables.Text = "Time Tables";
            // 
            // chbxIsEnabled
            // 
            this.chbxIsEnabled.AutoSize = true;
            this.chbxIsEnabled.Location = new System.Drawing.Point(319, 26);
            this.chbxIsEnabled.Name = "chbxIsEnabled";
            this.chbxIsEnabled.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chbxIsEnabled.Size = new System.Drawing.Size(65, 17);
            this.chbxIsEnabled.TabIndex = 44;
            this.chbxIsEnabled.Text = "Enabled";
            this.chbxIsEnabled.UseVisualStyleBackColor = true;
            // 
            // chSource
            // 
            this.chSource.Text = "Source";
            this.chSource.Width = 150;
            // 
            // gbxSettings
            // 
            this.gbxSettings.Controls.Add(this.tbxName);
            this.gbxSettings.Controls.Add(this.chbxIsEnabled);
            this.gbxSettings.Controls.Add(this.lblName);
            this.gbxSettings.Location = new System.Drawing.Point(12, 8);
            this.gbxSettings.Name = "gbxSettings";
            this.gbxSettings.Size = new System.Drawing.Size(391, 59);
            this.gbxSettings.TabIndex = 52;
            this.gbxSettings.TabStop = false;
            this.gbxSettings.Text = "Settings";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(55, 23);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(240, 20);
            this.tbxName.TabIndex = 36;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(16, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 35;
            this.lblName.Text = "Name: ";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chSituationType
            // 
            this.chSituationType.Text = "Situation Type";
            this.chSituationType.Width = 199;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(7, 268);
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
            this.lvRuleTriggers.Location = new System.Drawing.Point(7, 19);
            this.lvRuleTriggers.MultiSelect = false;
            this.lvRuleTriggers.Name = "lvRuleTriggers";
            this.lvRuleTriggers.Size = new System.Drawing.Size(377, 243);
            this.lvRuleTriggers.TabIndex = 0;
            this.lvRuleTriggers.UseCompatibleStateImageBehavior = false;
            this.lvRuleTriggers.View = System.Windows.Forms.View.Details;
            // 
            // chSelection
            // 
            this.chSelection.Text = "";
            this.chSelection.Width = 24;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(321, 268);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(63, 23);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // gbxRuleTriggers
            // 
            this.gbxRuleTriggers.Controls.Add(this.btnRemove);
            this.gbxRuleTriggers.Controls.Add(this.lvRuleTriggers);
            this.gbxRuleTriggers.Controls.Add(this.btnAdd);
            this.gbxRuleTriggers.Location = new System.Drawing.Point(409, 8);
            this.gbxRuleTriggers.Name = "gbxRuleTriggers";
            this.gbxRuleTriggers.Size = new System.Drawing.Size(391, 297);
            this.gbxRuleTriggers.TabIndex = 50;
            this.gbxRuleTriggers.TabStop = false;
            this.gbxRuleTriggers.Text = "Rule Triggers";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(1136, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(1046, 316);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 49;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // gbxRuleResponses
            // 
            this.gbxRuleResponses.Controls.Add(this.btnRemoveResponse);
            this.gbxRuleResponses.Controls.Add(this.lvRuleResponses);
            this.gbxRuleResponses.Controls.Add(this.btnAddResponse);
            this.gbxRuleResponses.Location = new System.Drawing.Point(806, 8);
            this.gbxRuleResponses.Name = "gbxRuleResponses";
            this.gbxRuleResponses.Size = new System.Drawing.Size(405, 302);
            this.gbxRuleResponses.TabIndex = 53;
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
            // AddRuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 347);
            this.Controls.Add(this.gbxRuleResponses);
            this.Controls.Add(this.gbxTimeTables);
            this.Controls.Add(this.gbxSettings);
            this.Controls.Add(this.gbxRuleTriggers);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Rule";
            this.gbxTimeTables.ResumeLayout(false);
            this.gbxSettings.ResumeLayout(false);
            this.gbxSettings.PerformLayout();
            this.gbxRuleTriggers.ResumeLayout(false);
            this.gbxRuleResponses.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chTimeTable;
        private System.Windows.Forms.ListView lvTimeTables;
        private System.Windows.Forms.GroupBox gbxTimeTables;
        private System.Windows.Forms.CheckBox chbxIsEnabled;
        private System.Windows.Forms.ColumnHeader chSource;
        private System.Windows.Forms.GroupBox gbxSettings;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ColumnHeader chSituationType;
        private System.Windows.Forms.Button btnRemove;
        public System.Windows.Forms.ListView lvRuleTriggers;
        private System.Windows.Forms.ColumnHeader chSelection;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxRuleTriggers;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbxRuleResponses;
        private System.Windows.Forms.Button btnRemoveResponse;
        public System.Windows.Forms.ListView lvRuleResponses;
        private System.Windows.Forms.ColumnHeader chSelectionResponse;
        private System.Windows.Forms.ColumnHeader chResponse;
        private System.Windows.Forms.Button btnAddResponse;
    }
}