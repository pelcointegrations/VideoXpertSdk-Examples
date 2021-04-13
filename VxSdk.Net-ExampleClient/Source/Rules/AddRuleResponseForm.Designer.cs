namespace ExampleClient.Source
{
    partial class AddRuleResponseForm
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
            this.lblSituationType = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxSourceEventFields = new System.Windows.Forms.GroupBox();
            this.chbxProperties = new System.Windows.Forms.CheckBox();
            this.chbxSourceDeviceId = new System.Windows.Forms.CheckBox();
            this.chbxSeverity = new System.Windows.Forms.CheckBox();
            this.rbCustomScript = new System.Windows.Forms.RadioButton();
            this.rbGenerateEvent = new System.Windows.Forms.RadioButton();
            this.gbxResponseType = new System.Windows.Forms.GroupBox();
            this.gbxScript = new System.Windows.Forms.GroupBox();
            this.gbxEventSettings = new System.Windows.Forms.GroupBox();
            this.tbxSituationType = new System.Windows.Forms.TextBox();
            this.tbxScript = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbxSourceEventFields.SuspendLayout();
            this.gbxResponseType.SuspendLayout();
            this.gbxScript.SuspendLayout();
            this.gbxEventSettings.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSituationType
            // 
            this.lblSituationType.AutoSize = true;
            this.lblSituationType.Location = new System.Drawing.Point(6, 23);
            this.lblSituationType.Name = "lblSituationType";
            this.lblSituationType.Size = new System.Drawing.Size(78, 13);
            this.lblSituationType.TabIndex = 11;
            this.lblSituationType.Text = "Situation Type:";
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(517, 467);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(436, 467);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // gbxSourceEventFields
            // 
            this.gbxSourceEventFields.Controls.Add(this.chbxProperties);
            this.gbxSourceEventFields.Controls.Add(this.chbxSourceDeviceId);
            this.gbxSourceEventFields.Controls.Add(this.chbxSeverity);
            this.gbxSourceEventFields.Location = new System.Drawing.Point(9, 55);
            this.gbxSourceEventFields.Name = "gbxSourceEventFields";
            this.gbxSourceEventFields.Size = new System.Drawing.Size(438, 51);
            this.gbxSourceEventFields.TabIndex = 21;
            this.gbxSourceEventFields.TabStop = false;
            this.gbxSourceEventFields.Text = "Source Event Fields To Copy";
            // 
            // chbxProperties
            // 
            this.chbxProperties.AutoSize = true;
            this.chbxProperties.Location = new System.Drawing.Point(359, 19);
            this.chbxProperties.Name = "chbxProperties";
            this.chbxProperties.Size = new System.Drawing.Size(73, 17);
            this.chbxProperties.TabIndex = 25;
            this.chbxProperties.Text = "Properties";
            this.chbxProperties.UseVisualStyleBackColor = true;
            // 
            // chbxSourceDeviceId
            // 
            this.chbxSourceDeviceId.AutoSize = true;
            this.chbxSourceDeviceId.Location = new System.Drawing.Point(162, 19);
            this.chbxSourceDeviceId.Name = "chbxSourceDeviceId";
            this.chbxSourceDeviceId.Size = new System.Drawing.Size(111, 17);
            this.chbxSourceDeviceId.TabIndex = 24;
            this.chbxSourceDeviceId.Text = "Source Device ID";
            this.chbxSourceDeviceId.UseVisualStyleBackColor = true;
            // 
            // chbxSeverity
            // 
            this.chbxSeverity.AutoSize = true;
            this.chbxSeverity.Location = new System.Drawing.Point(12, 19);
            this.chbxSeverity.Name = "chbxSeverity";
            this.chbxSeverity.Size = new System.Drawing.Size(64, 17);
            this.chbxSeverity.TabIndex = 23;
            this.chbxSeverity.Text = "Severity";
            this.chbxSeverity.UseVisualStyleBackColor = true;
            // 
            // rbCustomScript
            // 
            this.rbCustomScript.AutoSize = true;
            this.rbCustomScript.Checked = true;
            this.rbCustomScript.Location = new System.Drawing.Point(6, 18);
            this.rbCustomScript.Name = "rbCustomScript";
            this.rbCustomScript.Size = new System.Drawing.Size(90, 17);
            this.rbCustomScript.TabIndex = 22;
            this.rbCustomScript.TabStop = true;
            this.rbCustomScript.Text = "Custom Script";
            this.rbCustomScript.UseVisualStyleBackColor = true;
            this.rbCustomScript.CheckedChanged += new System.EventHandler(this.RadioButtonResponseType_CheckedChanged);
            // 
            // rbGenerateEvent
            // 
            this.rbGenerateEvent.AutoSize = true;
            this.rbGenerateEvent.Location = new System.Drawing.Point(6, 41);
            this.rbGenerateEvent.Name = "rbGenerateEvent";
            this.rbGenerateEvent.Size = new System.Drawing.Size(100, 17);
            this.rbGenerateEvent.TabIndex = 23;
            this.rbGenerateEvent.TabStop = true;
            this.rbGenerateEvent.Text = "Generate Event";
            this.rbGenerateEvent.UseVisualStyleBackColor = true;
            // 
            // gbxResponseType
            // 
            this.gbxResponseType.Controls.Add(this.rbCustomScript);
            this.gbxResponseType.Controls.Add(this.rbGenerateEvent);
            this.gbxResponseType.Location = new System.Drawing.Point(8, 15);
            this.gbxResponseType.Name = "gbxResponseType";
            this.gbxResponseType.Size = new System.Drawing.Size(125, 72);
            this.gbxResponseType.TabIndex = 24;
            this.gbxResponseType.TabStop = false;
            this.gbxResponseType.Text = "Response Type";
            // 
            // gbxScript
            // 
            this.gbxScript.Controls.Add(this.tbxScript);
            this.gbxScript.Location = new System.Drawing.Point(3, 3);
            this.gbxScript.Name = "gbxScript";
            this.gbxScript.Size = new System.Drawing.Size(450, 439);
            this.gbxScript.TabIndex = 25;
            this.gbxScript.TabStop = false;
            this.gbxScript.Text = "Script";
            // 
            // gbxEventSettings
            // 
            this.gbxEventSettings.AutoSize = true;
            this.gbxEventSettings.Controls.Add(this.tbxSituationType);
            this.gbxEventSettings.Controls.Add(this.lblSituationType);
            this.gbxEventSettings.Controls.Add(this.gbxSourceEventFields);
            this.gbxEventSettings.Location = new System.Drawing.Point(459, 3);
            this.gbxEventSettings.Name = "gbxEventSettings";
            this.gbxEventSettings.Size = new System.Drawing.Size(453, 125);
            this.gbxEventSettings.TabIndex = 26;
            this.gbxEventSettings.TabStop = false;
            this.gbxEventSettings.Text = "Event Settings";
            // 
            // tbxSituationType
            // 
            this.tbxSituationType.Location = new System.Drawing.Point(90, 19);
            this.tbxSituationType.Name = "tbxSituationType";
            this.tbxSituationType.Size = new System.Drawing.Size(357, 20);
            this.tbxSituationType.TabIndex = 22;
            // 
            // tbxScript
            // 
            this.tbxScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxScript.Location = new System.Drawing.Point(3, 16);
            this.tbxScript.Multiline = true;
            this.tbxScript.Name = "tbxScript";
            this.tbxScript.Size = new System.Drawing.Size(444, 420);
            this.tbxScript.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.gbxScript, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbxEventSettings, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(139, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(917, 449);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // AddRuleResponseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 497);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gbxResponseType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRuleResponseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Rule Response";
            this.gbxSourceEventFields.ResumeLayout(false);
            this.gbxSourceEventFields.PerformLayout();
            this.gbxResponseType.ResumeLayout(false);
            this.gbxResponseType.PerformLayout();
            this.gbxScript.ResumeLayout(false);
            this.gbxScript.PerformLayout();
            this.gbxEventSettings.ResumeLayout(false);
            this.gbxEventSettings.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSituationType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbxSourceEventFields;
        private System.Windows.Forms.CheckBox chbxSeverity;
        private System.Windows.Forms.CheckBox chbxProperties;
        private System.Windows.Forms.CheckBox chbxSourceDeviceId;
        private System.Windows.Forms.RadioButton rbCustomScript;
        private System.Windows.Forms.RadioButton rbGenerateEvent;
        private System.Windows.Forms.GroupBox gbxResponseType;
        private System.Windows.Forms.GroupBox gbxScript;
        private System.Windows.Forms.TextBox tbxScript;
        private System.Windows.Forms.GroupBox gbxEventSettings;
        private System.Windows.Forms.TextBox tbxSituationType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}