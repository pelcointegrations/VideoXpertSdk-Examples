namespace ExampleClient.Source
{
    partial class ModifyPtzConfigForm
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
            this.rbDisabled = new System.Windows.Forms.RadioButton();
            this.rbCoaxitron = new System.Windows.Forms.RadioButton();
            this.rbProtocolD = new System.Windows.Forms.RadioButton();
            this.rbExtendedCoaxitron = new System.Windows.Forms.RadioButton();
            this.rbProtocolP = new System.Windows.Forms.RadioButton();
            this.gbxPtzControlProtocol = new System.Windows.Forms.GroupBox();
            this.gbxPtzControlProtocol.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(10, 163);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(91, 163);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // rbDisabled
            // 
            this.rbDisabled.AutoSize = true;
            this.rbDisabled.Location = new System.Drawing.Point(6, 19);
            this.rbDisabled.Name = "rbDisabled";
            this.rbDisabled.Size = new System.Drawing.Size(66, 17);
            this.rbDisabled.TabIndex = 40;
            this.rbDisabled.TabStop = true;
            this.rbDisabled.Text = "Disabled";
            this.rbDisabled.UseVisualStyleBackColor = true;
            // 
            // rbCoaxitron
            // 
            this.rbCoaxitron.AutoSize = true;
            this.rbCoaxitron.Location = new System.Drawing.Point(6, 42);
            this.rbCoaxitron.Name = "rbCoaxitron";
            this.rbCoaxitron.Size = new System.Drawing.Size(69, 17);
            this.rbCoaxitron.TabIndex = 41;
            this.rbCoaxitron.TabStop = true;
            this.rbCoaxitron.Text = "Coaxitron";
            this.rbCoaxitron.UseVisualStyleBackColor = true;
            // 
            // rbProtocolD
            // 
            this.rbProtocolD.AutoSize = true;
            this.rbProtocolD.Location = new System.Drawing.Point(6, 65);
            this.rbProtocolD.Name = "rbProtocolD";
            this.rbProtocolD.Size = new System.Drawing.Size(74, 17);
            this.rbProtocolD.TabIndex = 42;
            this.rbProtocolD.TabStop = true;
            this.rbProtocolD.Text = "D protocol";
            this.rbProtocolD.UseVisualStyleBackColor = true;
            // 
            // rbExtendedCoaxitron
            // 
            this.rbExtendedCoaxitron.AutoSize = true;
            this.rbExtendedCoaxitron.Location = new System.Drawing.Point(6, 88);
            this.rbExtendedCoaxitron.Name = "rbExtendedCoaxitron";
            this.rbExtendedCoaxitron.Size = new System.Drawing.Size(117, 17);
            this.rbExtendedCoaxitron.TabIndex = 44;
            this.rbExtendedCoaxitron.TabStop = true;
            this.rbExtendedCoaxitron.Text = "Extended Coaxitron";
            this.rbExtendedCoaxitron.UseVisualStyleBackColor = true;
            // 
            // rbProtocolP
            // 
            this.rbProtocolP.AutoSize = true;
            this.rbProtocolP.Location = new System.Drawing.Point(6, 111);
            this.rbProtocolP.Name = "rbProtocolP";
            this.rbProtocolP.Size = new System.Drawing.Size(73, 17);
            this.rbProtocolP.TabIndex = 45;
            this.rbProtocolP.TabStop = true;
            this.rbProtocolP.Text = "P protocol";
            this.rbProtocolP.UseVisualStyleBackColor = true;
            // 
            // gbxPtzControlProtocol
            // 
            this.gbxPtzControlProtocol.Controls.Add(this.rbDisabled);
            this.gbxPtzControlProtocol.Controls.Add(this.rbProtocolP);
            this.gbxPtzControlProtocol.Controls.Add(this.rbCoaxitron);
            this.gbxPtzControlProtocol.Controls.Add(this.rbExtendedCoaxitron);
            this.gbxPtzControlProtocol.Controls.Add(this.rbProtocolD);
            this.gbxPtzControlProtocol.Location = new System.Drawing.Point(10, 13);
            this.gbxPtzControlProtocol.Name = "gbxPtzControlProtocol";
            this.gbxPtzControlProtocol.Size = new System.Drawing.Size(141, 144);
            this.gbxPtzControlProtocol.TabIndex = 46;
            this.gbxPtzControlProtocol.TabStop = false;
            this.gbxPtzControlProtocol.Text = "PTZ Control Protocol";
            // 
            // ModifyPtzConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(161, 193);
            this.Controls.Add(this.gbxPtzControlProtocol);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyPtzConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modify PTZ Config";
            this.gbxPtzControlProtocol.ResumeLayout(false);
            this.gbxPtzControlProtocol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rbDisabled;
        private System.Windows.Forms.RadioButton rbProtocolD;
        private System.Windows.Forms.RadioButton rbCoaxitron;
        private System.Windows.Forms.RadioButton rbExtendedCoaxitron;
        private System.Windows.Forms.RadioButton rbProtocolP;
        private System.Windows.Forms.GroupBox gbxPtzControlProtocol;
    }
}