﻿namespace ExampleClient.Source
{
    partial class ModifyAlarmInputForm
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(93, 121);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(174, 121);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(7, 47);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(61, 13);
            this.lblDescription.TabIndex = 33;
            this.lblDescription.Text = "Description: ";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(74, 12);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(175, 20);
            this.tbxName.TabIndex = 36;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(7, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 13);
            this.lblName.TabIndex = 35;
            this.lblName.Text = "Name: ";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(74, 43);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(175, 20);
            this.tbxDescription.TabIndex = 37;
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "Unknown",
            "Alarm",
            "Fire"});
            this.cbxType.Location = new System.Drawing.Point(74, 78);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(175, 21);
            this.cbxType.TabIndex = 38;
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(7, 81);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(61, 13);
            this.lblType.TabIndex = 39;
            this.lblType.Text = "Type: ";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ModifyAlarmInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 156);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyAlarmInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modify Alarm Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label lblType;
    }
}