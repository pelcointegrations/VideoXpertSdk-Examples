namespace ExampleClient.Source
{
    partial class ModifySmartCompressionConfigForm
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
            this.nudPrimary = new System.Windows.Forms.NumericUpDown();
            this.lblPrimary = new System.Windows.Forms.Label();
            this.nudSecondary = new System.Windows.Forms.NumericUpDown();
            this.nudTertiary = new System.Windows.Forms.NumericUpDown();
            this.nudQuaternary = new System.Windows.Forms.NumericUpDown();
            this.nudQuinary = new System.Windows.Forms.NumericUpDown();
            this.nudSenary = new System.Windows.Forms.NumericUpDown();
            this.nudSeptenary = new System.Windows.Forms.NumericUpDown();
            this.nudOctonary = new System.Windows.Forms.NumericUpDown();
            this.nudNonary = new System.Windows.Forms.NumericUpDown();
            this.nudDenary = new System.Windows.Forms.NumericUpDown();
            this.cbxLevel = new System.Windows.Forms.ComboBox();
            this.gbxLevel = new System.Windows.Forms.GroupBox();
            this.ckbxPrimary = new System.Windows.Forms.CheckBox();
            this.ckbxSecondary = new System.Windows.Forms.CheckBox();
            this.ckbxTertiary = new System.Windows.Forms.CheckBox();
            this.ckbxQuinary = new System.Windows.Forms.CheckBox();
            this.ckbxQuaternary = new System.Windows.Forms.CheckBox();
            this.ckbxSenary = new System.Windows.Forms.CheckBox();
            this.ckbxSeptenary = new System.Windows.Forms.CheckBox();
            this.ckbxOctonary = new System.Windows.Forms.CheckBox();
            this.ckbxDenary = new System.Windows.Forms.CheckBox();
            this.ckbxNonary = new System.Windows.Forms.CheckBox();
            this.lblSecondary = new System.Windows.Forms.Label();
            this.lblTertiary = new System.Windows.Forms.Label();
            this.lblQuaternary = new System.Windows.Forms.Label();
            this.lblQuinary = new System.Windows.Forms.Label();
            this.lblSenary = new System.Windows.Forms.Label();
            this.lblSeptenary = new System.Windows.Forms.Label();
            this.lblOctonary = new System.Windows.Forms.Label();
            this.lblNonary = new System.Windows.Forms.Label();
            this.lblDenary = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrimary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecondary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTertiary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuaternary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuinary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSenary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeptenary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOctonary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNonary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDenary)).BeginInit();
            this.gbxLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 570);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(179, 570);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // nudPrimary
            // 
            this.nudPrimary.Location = new System.Drawing.Point(172, 93);
            this.nudPrimary.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudPrimary.Name = "nudPrimary";
            this.nudPrimary.Size = new System.Drawing.Size(48, 20);
            this.nudPrimary.TabIndex = 33;
            this.nudPrimary.Visible = false;
            // 
            // lblPrimary
            // 
            this.lblPrimary.AutoSize = true;
            this.lblPrimary.Location = new System.Drawing.Point(74, 95);
            this.lblPrimary.Name = "lblPrimary";
            this.lblPrimary.Size = new System.Drawing.Size(92, 13);
            this.lblPrimary.TabIndex = 34;
            this.lblPrimary.Text = "Max GOP Length:";
            this.lblPrimary.Visible = false;
            // 
            // nudSecondary
            // 
            this.nudSecondary.Location = new System.Drawing.Point(172, 142);
            this.nudSecondary.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudSecondary.Name = "nudSecondary";
            this.nudSecondary.Size = new System.Drawing.Size(48, 20);
            this.nudSecondary.TabIndex = 35;
            this.nudSecondary.Visible = false;
            // 
            // nudTertiary
            // 
            this.nudTertiary.Location = new System.Drawing.Point(172, 191);
            this.nudTertiary.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudTertiary.Name = "nudTertiary";
            this.nudTertiary.Size = new System.Drawing.Size(48, 20);
            this.nudTertiary.TabIndex = 37;
            this.nudTertiary.Visible = false;
            // 
            // nudQuaternary
            // 
            this.nudQuaternary.Location = new System.Drawing.Point(172, 240);
            this.nudQuaternary.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudQuaternary.Name = "nudQuaternary";
            this.nudQuaternary.Size = new System.Drawing.Size(48, 20);
            this.nudQuaternary.TabIndex = 39;
            this.nudQuaternary.Visible = false;
            // 
            // nudQuinary
            // 
            this.nudQuinary.Location = new System.Drawing.Point(172, 289);
            this.nudQuinary.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudQuinary.Name = "nudQuinary";
            this.nudQuinary.Size = new System.Drawing.Size(48, 20);
            this.nudQuinary.TabIndex = 41;
            this.nudQuinary.Visible = false;
            // 
            // nudSenary
            // 
            this.nudSenary.Location = new System.Drawing.Point(172, 338);
            this.nudSenary.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudSenary.Name = "nudSenary";
            this.nudSenary.Size = new System.Drawing.Size(48, 20);
            this.nudSenary.TabIndex = 43;
            this.nudSenary.Visible = false;
            // 
            // nudSeptenary
            // 
            this.nudSeptenary.Location = new System.Drawing.Point(172, 387);
            this.nudSeptenary.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudSeptenary.Name = "nudSeptenary";
            this.nudSeptenary.Size = new System.Drawing.Size(48, 20);
            this.nudSeptenary.TabIndex = 45;
            this.nudSeptenary.Visible = false;
            // 
            // nudOctonary
            // 
            this.nudOctonary.Location = new System.Drawing.Point(172, 436);
            this.nudOctonary.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudOctonary.Name = "nudOctonary";
            this.nudOctonary.Size = new System.Drawing.Size(48, 20);
            this.nudOctonary.TabIndex = 47;
            this.nudOctonary.Visible = false;
            // 
            // nudNonary
            // 
            this.nudNonary.Location = new System.Drawing.Point(172, 485);
            this.nudNonary.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudNonary.Name = "nudNonary";
            this.nudNonary.Size = new System.Drawing.Size(48, 20);
            this.nudNonary.TabIndex = 49;
            this.nudNonary.Visible = false;
            // 
            // nudDenary
            // 
            this.nudDenary.Location = new System.Drawing.Point(172, 534);
            this.nudDenary.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudDenary.Name = "nudDenary";
            this.nudDenary.Size = new System.Drawing.Size(48, 20);
            this.nudDenary.TabIndex = 51;
            this.nudDenary.Visible = false;
            // 
            // cbxLevel
            // 
            this.cbxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLevel.FormattingEnabled = true;
            this.cbxLevel.Items.AddRange(new object[] {
            "Disabled",
            "Low",
            "Medium",
            "High"});
            this.cbxLevel.Location = new System.Drawing.Point(6, 19);
            this.cbxLevel.Name = "cbxLevel";
            this.cbxLevel.Size = new System.Drawing.Size(198, 21);
            this.cbxLevel.TabIndex = 53;
            this.cbxLevel.SelectedIndexChanged += new System.EventHandler(this.ComboboxLevel_SelectedIndexChanged);
            // 
            // gbxLevel
            // 
            this.gbxLevel.Controls.Add(this.cbxLevel);
            this.gbxLevel.Location = new System.Drawing.Point(20, 12);
            this.gbxLevel.Name = "gbxLevel";
            this.gbxLevel.Size = new System.Drawing.Size(210, 52);
            this.gbxLevel.TabIndex = 56;
            this.gbxLevel.TabStop = false;
            this.gbxLevel.Text = "Smart Compression Level";
            // 
            // ckbxPrimary
            // 
            this.ckbxPrimary.AutoSize = true;
            this.ckbxPrimary.Location = new System.Drawing.Point(12, 70);
            this.ckbxPrimary.Name = "ckbxPrimary";
            this.ckbxPrimary.Size = new System.Drawing.Size(208, 17);
            this.ckbxPrimary.TabIndex = 53;
            this.ckbxPrimary.Text = "Primary Stream Dynamic GOP Enabled";
            this.ckbxPrimary.UseVisualStyleBackColor = true;
            this.ckbxPrimary.Visible = false;
            this.ckbxPrimary.CheckedChanged += new System.EventHandler(this.CheckboxEnabled_CheckedChanged);
            // 
            // ckbxSecondary
            // 
            this.ckbxSecondary.AutoSize = true;
            this.ckbxSecondary.Location = new System.Drawing.Point(12, 119);
            this.ckbxSecondary.Name = "ckbxSecondary";
            this.ckbxSecondary.Size = new System.Drawing.Size(225, 17);
            this.ckbxSecondary.TabIndex = 54;
            this.ckbxSecondary.Text = "Secondary Stream Dynamic GOP Enabled";
            this.ckbxSecondary.UseVisualStyleBackColor = true;
            this.ckbxSecondary.Visible = false;
            this.ckbxSecondary.CheckedChanged += new System.EventHandler(this.CheckboxEnabled_CheckedChanged);
            // 
            // ckbxTertiary
            // 
            this.ckbxTertiary.AutoSize = true;
            this.ckbxTertiary.Location = new System.Drawing.Point(12, 168);
            this.ckbxTertiary.Name = "ckbxTertiary";
            this.ckbxTertiary.Size = new System.Drawing.Size(209, 17);
            this.ckbxTertiary.TabIndex = 55;
            this.ckbxTertiary.Text = "Tertiary Stream Dynamic GOP Enabled";
            this.ckbxTertiary.UseVisualStyleBackColor = true;
            this.ckbxTertiary.Visible = false;
            this.ckbxTertiary.CheckedChanged += new System.EventHandler(this.CheckboxEnabled_CheckedChanged);
            // 
            // ckbxQuinary
            // 
            this.ckbxQuinary.AutoSize = true;
            this.ckbxQuinary.Location = new System.Drawing.Point(12, 266);
            this.ckbxQuinary.Name = "ckbxQuinary";
            this.ckbxQuinary.Size = new System.Drawing.Size(210, 17);
            this.ckbxQuinary.TabIndex = 56;
            this.ckbxQuinary.Text = "Quinary Stream Dynamic GOP Enabled";
            this.ckbxQuinary.UseVisualStyleBackColor = true;
            this.ckbxQuinary.Visible = false;
            this.ckbxQuinary.CheckedChanged += new System.EventHandler(this.CheckboxEnabled_CheckedChanged);
            // 
            // ckbxQuaternary
            // 
            this.ckbxQuaternary.AutoSize = true;
            this.ckbxQuaternary.Location = new System.Drawing.Point(12, 217);
            this.ckbxQuaternary.Name = "ckbxQuaternary";
            this.ckbxQuaternary.Size = new System.Drawing.Size(226, 17);
            this.ckbxQuaternary.TabIndex = 57;
            this.ckbxQuaternary.Text = "Quaternary Stream Dynamic GOP Enabled";
            this.ckbxQuaternary.UseVisualStyleBackColor = true;
            this.ckbxQuaternary.Visible = false;
            this.ckbxQuaternary.CheckedChanged += new System.EventHandler(this.CheckboxEnabled_CheckedChanged);
            // 
            // ckbxSenary
            // 
            this.ckbxSenary.AutoSize = true;
            this.ckbxSenary.Location = new System.Drawing.Point(12, 315);
            this.ckbxSenary.Name = "ckbxSenary";
            this.ckbxSenary.Size = new System.Drawing.Size(207, 17);
            this.ckbxSenary.TabIndex = 58;
            this.ckbxSenary.Text = "Senary Stream Dynamic GOP Enabled";
            this.ckbxSenary.UseVisualStyleBackColor = true;
            this.ckbxSenary.Visible = false;
            this.ckbxSenary.CheckedChanged += new System.EventHandler(this.CheckboxEnabled_CheckedChanged);
            // 
            // ckbxSeptenary
            // 
            this.ckbxSeptenary.AutoSize = true;
            this.ckbxSeptenary.Location = new System.Drawing.Point(12, 364);
            this.ckbxSeptenary.Name = "ckbxSeptenary";
            this.ckbxSeptenary.Size = new System.Drawing.Size(222, 17);
            this.ckbxSeptenary.TabIndex = 59;
            this.ckbxSeptenary.Text = "Septenary Stream Dynamic GOP Enabled";
            this.ckbxSeptenary.UseVisualStyleBackColor = true;
            this.ckbxSeptenary.Visible = false;
            this.ckbxSeptenary.CheckedChanged += new System.EventHandler(this.CheckboxEnabled_CheckedChanged);
            // 
            // ckbxOctonary
            // 
            this.ckbxOctonary.AutoSize = true;
            this.ckbxOctonary.Location = new System.Drawing.Point(12, 413);
            this.ckbxOctonary.Name = "ckbxOctonary";
            this.ckbxOctonary.Size = new System.Drawing.Size(217, 17);
            this.ckbxOctonary.TabIndex = 60;
            this.ckbxOctonary.Text = "Octonary Stream Dynamic GOP Enabled";
            this.ckbxOctonary.UseVisualStyleBackColor = true;
            this.ckbxOctonary.Visible = false;
            this.ckbxOctonary.CheckedChanged += new System.EventHandler(this.CheckboxEnabled_CheckedChanged);
            // 
            // ckbxDenary
            // 
            this.ckbxDenary.AutoSize = true;
            this.ckbxDenary.Location = new System.Drawing.Point(12, 511);
            this.ckbxDenary.Name = "ckbxDenary";
            this.ckbxDenary.Size = new System.Drawing.Size(208, 17);
            this.ckbxDenary.TabIndex = 61;
            this.ckbxDenary.Text = "Denary Stream Dynamic GOP Enabled";
            this.ckbxDenary.UseVisualStyleBackColor = true;
            this.ckbxDenary.Visible = false;
            this.ckbxDenary.CheckedChanged += new System.EventHandler(this.CheckboxEnabled_CheckedChanged);
            // 
            // ckbxNonary
            // 
            this.ckbxNonary.AutoSize = true;
            this.ckbxNonary.Location = new System.Drawing.Point(12, 462);
            this.ckbxNonary.Name = "ckbxNonary";
            this.ckbxNonary.Size = new System.Drawing.Size(208, 17);
            this.ckbxNonary.TabIndex = 62;
            this.ckbxNonary.Text = "Nonary Stream Dynamic GOP Enabled";
            this.ckbxNonary.UseVisualStyleBackColor = true;
            this.ckbxNonary.Visible = false;
            this.ckbxNonary.CheckedChanged += new System.EventHandler(this.CheckboxEnabled_CheckedChanged);
            // 
            // lblSecondary
            // 
            this.lblSecondary.AutoSize = true;
            this.lblSecondary.Location = new System.Drawing.Point(74, 144);
            this.lblSecondary.Name = "lblSecondary";
            this.lblSecondary.Size = new System.Drawing.Size(92, 13);
            this.lblSecondary.TabIndex = 63;
            this.lblSecondary.Text = "Max GOP Length:";
            this.lblSecondary.Visible = false;
            // 
            // lblTertiary
            // 
            this.lblTertiary.AutoSize = true;
            this.lblTertiary.Location = new System.Drawing.Point(74, 193);
            this.lblTertiary.Name = "lblTertiary";
            this.lblTertiary.Size = new System.Drawing.Size(92, 13);
            this.lblTertiary.TabIndex = 64;
            this.lblTertiary.Text = "Max GOP Length:";
            this.lblTertiary.Visible = false;
            // 
            // lblQuaternary
            // 
            this.lblQuaternary.AutoSize = true;
            this.lblQuaternary.Location = new System.Drawing.Point(74, 242);
            this.lblQuaternary.Name = "lblQuaternary";
            this.lblQuaternary.Size = new System.Drawing.Size(92, 13);
            this.lblQuaternary.TabIndex = 65;
            this.lblQuaternary.Text = "Max GOP Length:";
            this.lblQuaternary.Visible = false;
            // 
            // lblQuinary
            // 
            this.lblQuinary.AutoSize = true;
            this.lblQuinary.Location = new System.Drawing.Point(74, 291);
            this.lblQuinary.Name = "lblQuinary";
            this.lblQuinary.Size = new System.Drawing.Size(92, 13);
            this.lblQuinary.TabIndex = 66;
            this.lblQuinary.Text = "Max GOP Length:";
            this.lblQuinary.Visible = false;
            // 
            // lblSenary
            // 
            this.lblSenary.AutoSize = true;
            this.lblSenary.Location = new System.Drawing.Point(74, 340);
            this.lblSenary.Name = "lblSenary";
            this.lblSenary.Size = new System.Drawing.Size(92, 13);
            this.lblSenary.TabIndex = 67;
            this.lblSenary.Text = "Max GOP Length:";
            this.lblSenary.Visible = false;
            // 
            // lblSeptenary
            // 
            this.lblSeptenary.AutoSize = true;
            this.lblSeptenary.Location = new System.Drawing.Point(74, 389);
            this.lblSeptenary.Name = "lblSeptenary";
            this.lblSeptenary.Size = new System.Drawing.Size(92, 13);
            this.lblSeptenary.TabIndex = 68;
            this.lblSeptenary.Text = "Max GOP Length:";
            this.lblSeptenary.Visible = false;
            // 
            // lblOctonary
            // 
            this.lblOctonary.AutoSize = true;
            this.lblOctonary.Location = new System.Drawing.Point(74, 438);
            this.lblOctonary.Name = "lblOctonary";
            this.lblOctonary.Size = new System.Drawing.Size(92, 13);
            this.lblOctonary.TabIndex = 69;
            this.lblOctonary.Text = "Max GOP Length:";
            this.lblOctonary.Visible = false;
            // 
            // lblNonary
            // 
            this.lblNonary.AutoSize = true;
            this.lblNonary.Location = new System.Drawing.Point(74, 487);
            this.lblNonary.Name = "lblNonary";
            this.lblNonary.Size = new System.Drawing.Size(92, 13);
            this.lblNonary.TabIndex = 70;
            this.lblNonary.Text = "Max GOP Length:";
            this.lblNonary.Visible = false;
            // 
            // lblDenary
            // 
            this.lblDenary.AutoSize = true;
            this.lblDenary.Location = new System.Drawing.Point(74, 536);
            this.lblDenary.Name = "lblDenary";
            this.lblDenary.Size = new System.Drawing.Size(92, 13);
            this.lblDenary.TabIndex = 71;
            this.lblDenary.Text = "Max GOP Length:";
            this.lblDenary.Visible = false;
            // 
            // ModifySmartCompressionConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 605);
            this.Controls.Add(this.lblDenary);
            this.Controls.Add(this.gbxLevel);
            this.Controls.Add(this.lblNonary);
            this.Controls.Add(this.lblOctonary);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblSeptenary);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSenary);
            this.Controls.Add(this.ckbxPrimary);
            this.Controls.Add(this.lblQuinary);
            this.Controls.Add(this.nudSenary);
            this.Controls.Add(this.lblQuaternary);
            this.Controls.Add(this.nudSeptenary);
            this.Controls.Add(this.lblTertiary);
            this.Controls.Add(this.nudQuinary);
            this.Controls.Add(this.lblSecondary);
            this.Controls.Add(this.nudOctonary);
            this.Controls.Add(this.ckbxNonary);
            this.Controls.Add(this.nudQuaternary);
            this.Controls.Add(this.ckbxDenary);
            this.Controls.Add(this.nudNonary);
            this.Controls.Add(this.ckbxOctonary);
            this.Controls.Add(this.nudTertiary);
            this.Controls.Add(this.ckbxSeptenary);
            this.Controls.Add(this.nudDenary);
            this.Controls.Add(this.ckbxSenary);
            this.Controls.Add(this.nudSecondary);
            this.Controls.Add(this.ckbxQuaternary);
            this.Controls.Add(this.lblPrimary);
            this.Controls.Add(this.ckbxQuinary);
            this.Controls.Add(this.nudPrimary);
            this.Controls.Add(this.ckbxTertiary);
            this.Controls.Add(this.ckbxSecondary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifySmartCompressionConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modify Smart Compression";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrimary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecondary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTertiary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuaternary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuinary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSenary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeptenary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOctonary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNonary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDenary)).EndInit();
            this.gbxLevel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nudPrimary;
        private System.Windows.Forms.Label lblPrimary;
        private System.Windows.Forms.NumericUpDown nudSecondary;
        private System.Windows.Forms.NumericUpDown nudTertiary;
        private System.Windows.Forms.NumericUpDown nudQuaternary;
        private System.Windows.Forms.NumericUpDown nudQuinary;
        private System.Windows.Forms.NumericUpDown nudSenary;
        private System.Windows.Forms.NumericUpDown nudSeptenary;
        private System.Windows.Forms.NumericUpDown nudOctonary;
        private System.Windows.Forms.NumericUpDown nudNonary;
        private System.Windows.Forms.NumericUpDown nudDenary;
        private System.Windows.Forms.ComboBox cbxLevel;
        private System.Windows.Forms.GroupBox gbxLevel;
        private System.Windows.Forms.Label lblDenary;
        private System.Windows.Forms.Label lblNonary;
        private System.Windows.Forms.Label lblOctonary;
        private System.Windows.Forms.Label lblSeptenary;
        private System.Windows.Forms.Label lblSenary;
        private System.Windows.Forms.Label lblQuinary;
        private System.Windows.Forms.Label lblQuaternary;
        private System.Windows.Forms.Label lblTertiary;
        private System.Windows.Forms.Label lblSecondary;
        private System.Windows.Forms.CheckBox ckbxNonary;
        private System.Windows.Forms.CheckBox ckbxDenary;
        private System.Windows.Forms.CheckBox ckbxOctonary;
        private System.Windows.Forms.CheckBox ckbxSeptenary;
        private System.Windows.Forms.CheckBox ckbxSenary;
        private System.Windows.Forms.CheckBox ckbxQuaternary;
        private System.Windows.Forms.CheckBox ckbxQuinary;
        private System.Windows.Forms.CheckBox ckbxTertiary;
        private System.Windows.Forms.CheckBox ckbxSecondary;
        private System.Windows.Forms.CheckBox ckbxPrimary;
    }
}