namespace ExampleClient.Source
{
    partial class AddRuleTriggerForm
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
            this.cbxSituationType = new System.Windows.Forms.ComboBox();
            this.cbxSource = new System.Windows.Forms.ComboBox();
            this.lblSituationType = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSourceType = new System.Windows.Forms.Label();
            this.gbxResourceRef = new System.Windows.Forms.GroupBox();
            this.chbxEnabled = new System.Windows.Forms.CheckBox();
            this.lblType = new System.Windows.Forms.Label();
            this.gbxResourceRef.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxSituationType
            // 
            this.cbxSituationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSituationType.FormattingEnabled = true;
            this.cbxSituationType.Location = new System.Drawing.Point(94, 12);
            this.cbxSituationType.Name = "cbxSituationType";
            this.cbxSituationType.Size = new System.Drawing.Size(273, 21);
            this.cbxSituationType.TabIndex = 1;
            this.cbxSituationType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSituationType_SelectedIndexChanged);
            // 
            // cbxSource
            // 
            this.cbxSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSource.Enabled = false;
            this.cbxSource.FormattingEnabled = true;
            this.cbxSource.Location = new System.Drawing.Point(83, 47);
            this.cbxSource.Name = "cbxSource";
            this.cbxSource.Size = new System.Drawing.Size(256, 21);
            this.cbxSource.TabIndex = 2;
            // 
            // lblSituationType
            // 
            this.lblSituationType.AutoSize = true;
            this.lblSituationType.Location = new System.Drawing.Point(8, 16);
            this.lblSituationType.Name = "lblSituationType";
            this.lblSituationType.Size = new System.Drawing.Size(78, 13);
            this.lblSituationType.TabIndex = 11;
            this.lblSituationType.Text = "Situation Type:";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Enabled = false;
            this.lblSource.Location = new System.Drawing.Point(33, 50);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(44, 13);
            this.lblSource.TabIndex = 12;
            this.lblSource.Text = "Source:";
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(292, 132);
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
            this.btnCancel.Location = new System.Drawing.Point(211, 132);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblSourceType
            // 
            this.lblSourceType.AutoSize = true;
            this.lblSourceType.Enabled = false;
            this.lblSourceType.Location = new System.Drawing.Point(6, 23);
            this.lblSourceType.Name = "lblSourceType";
            this.lblSourceType.Size = new System.Drawing.Size(71, 13);
            this.lblSourceType.TabIndex = 20;
            this.lblSourceType.Text = "Source Type:";
            // 
            // gbxResourceRef
            // 
            this.gbxResourceRef.Controls.Add(this.lblType);
            this.gbxResourceRef.Controls.Add(this.chbxEnabled);
            this.gbxResourceRef.Controls.Add(this.lblSourceType);
            this.gbxResourceRef.Controls.Add(this.cbxSource);
            this.gbxResourceRef.Controls.Add(this.lblSource);
            this.gbxResourceRef.Location = new System.Drawing.Point(11, 44);
            this.gbxResourceRef.Name = "gbxResourceRef";
            this.gbxResourceRef.Size = new System.Drawing.Size(356, 83);
            this.gbxResourceRef.TabIndex = 21;
            this.gbxResourceRef.TabStop = false;
            this.gbxResourceRef.Text = "Source Filter";
            // 
            // chbxEnabled
            // 
            this.chbxEnabled.AutoSize = true;
            this.chbxEnabled.Location = new System.Drawing.Point(274, 23);
            this.chbxEnabled.Name = "chbxEnabled";
            this.chbxEnabled.Size = new System.Drawing.Size(65, 17);
            this.chbxEnabled.TabIndex = 23;
            this.chbxEnabled.Text = "Enabled";
            this.chbxEnabled.UseVisualStyleBackColor = true;
            this.chbxEnabled.CheckedChanged += new System.EventHandler(this.CheckBoxEnabled_CheckedChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Enabled = false;
            this.lblType.Location = new System.Drawing.Point(83, 23);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(0, 13);
            this.lblType.TabIndex = 24;
            // 
            // AddRuleTriggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 161);
            this.Controls.Add(this.gbxResourceRef);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSituationType);
            this.Controls.Add(this.cbxSituationType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRuleTriggerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Rule Trigger";
            this.gbxResourceRef.ResumeLayout(false);
            this.gbxResourceRef.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxSituationType;
        private System.Windows.Forms.ComboBox cbxSource;
        private System.Windows.Forms.Label lblSituationType;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSourceType;
        private System.Windows.Forms.GroupBox gbxResourceRef;
        private System.Windows.Forms.CheckBox chbxEnabled;
        private System.Windows.Forms.Label lblType;
    }
}