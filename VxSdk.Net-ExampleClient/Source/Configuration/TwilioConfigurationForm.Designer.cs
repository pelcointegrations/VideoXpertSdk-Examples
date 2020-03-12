namespace ExampleClient.Source.Misc
{
    partial class TwilioConfigurationForm
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
            this.cbxEnabled = new System.Windows.Forms.CheckBox();
            this.tbxFromNumber = new System.Windows.Forms.TextBox();
            this.tbxAccountSid = new System.Windows.Forms.TextBox();
            this.lblFromNumber = new System.Windows.Forms.Label();
            this.lblAccountSid = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.lblAuthToken = new System.Windows.Forms.Label();
            this.tbxAuthToken = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbxEnabled
            // 
            this.cbxEnabled.AutoSize = true;
            this.cbxEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxEnabled.Location = new System.Drawing.Point(12, 12);
            this.cbxEnabled.Name = "cbxEnabled";
            this.cbxEnabled.Size = new System.Drawing.Size(172, 17);
            this.cbxEnabled.TabIndex = 1;
            this.cbxEnabled.Text = "Enable Twilio SMS Messaging:";
            this.cbxEnabled.UseVisualStyleBackColor = true;
            this.cbxEnabled.CheckedChanged += new System.EventHandler(this.CheckBoxEnabled_CheckedChanged);
            // 
            // tbxFromNumber
            // 
            this.tbxFromNumber.Enabled = false;
            this.tbxFromNumber.Location = new System.Drawing.Point(168, 87);
            this.tbxFromNumber.Name = "tbxFromNumber";
            this.tbxFromNumber.Size = new System.Drawing.Size(192, 20);
            this.tbxFromNumber.TabIndex = 7;
            // 
            // tbxAccountSid
            // 
            this.tbxAccountSid.Enabled = false;
            this.tbxAccountSid.Location = new System.Drawing.Point(168, 35);
            this.tbxAccountSid.Name = "tbxAccountSid";
            this.tbxAccountSid.Size = new System.Drawing.Size(192, 20);
            this.tbxAccountSid.TabIndex = 8;
            // 
            // lblFromNumber
            // 
            this.lblFromNumber.AutoSize = true;
            this.lblFromNumber.Location = new System.Drawing.Point(51, 90);
            this.lblFromNumber.Name = "lblFromNumber";
            this.lblFromNumber.Size = new System.Drawing.Size(114, 13);
            this.lblFromNumber.TabIndex = 16;
            this.lblFromNumber.Text = "Twilio Sender Number:";
            // 
            // lblAccountSid
            // 
            this.lblAccountSid.AutoSize = true;
            this.lblAccountSid.Location = new System.Drawing.Point(64, 38);
            this.lblAccountSid.Name = "lblAccountSid";
            this.lblAccountSid.Size = new System.Drawing.Size(101, 13);
            this.lblAccountSid.TabIndex = 17;
            this.lblAccountSid.Text = "Twilio Account SID:";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(285, 119);
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
            this.btnCancel.Location = new System.Drawing.Point(204, 119);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnValidate
            // 
            this.btnValidate.Enabled = false;
            this.btnValidate.Location = new System.Drawing.Point(12, 119);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(108, 23);
            this.btnValidate.TabIndex = 27;
            this.btnValidate.Text = "Send Test SMS";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.ButtonValidate_Click);
            // 
            // lblAuthToken
            // 
            this.lblAuthToken.AutoSize = true;
            this.lblAuthToken.Location = new System.Drawing.Point(71, 64);
            this.lblAuthToken.Name = "lblAuthToken";
            this.lblAuthToken.Size = new System.Drawing.Size(96, 13);
            this.lblAuthToken.TabIndex = 31;
            this.lblAuthToken.Text = "Twilio Auth Token:";
            // 
            // tbxAuthToken
            // 
            this.tbxAuthToken.Enabled = false;
            this.tbxAuthToken.Location = new System.Drawing.Point(168, 61);
            this.tbxAuthToken.Name = "tbxAuthToken";
            this.tbxAuthToken.Size = new System.Drawing.Size(192, 20);
            this.tbxAuthToken.TabIndex = 29;
            // 
            // TwilioConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 147);
            this.Controls.Add(this.tbxFromNumber);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.lblFromNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxAuthToken);
            this.Controls.Add(this.lblAccountSid);
            this.Controls.Add(this.lblAuthToken);
            this.Controls.Add(this.tbxAccountSid);
            this.Controls.Add(this.cbxEnabled);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TwilioConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Twilio SMS Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbxEnabled;
        private System.Windows.Forms.TextBox tbxFromNumber;
        private System.Windows.Forms.TextBox tbxAccountSid;
        private System.Windows.Forms.Label lblFromNumber;
        private System.Windows.Forms.Label lblAccountSid;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label lblAuthToken;
        private System.Windows.Forms.TextBox tbxAuthToken;
    }
}