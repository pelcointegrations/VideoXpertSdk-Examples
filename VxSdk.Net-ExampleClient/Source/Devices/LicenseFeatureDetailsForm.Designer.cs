namespace ExampleClient.Source
{
    partial class LicenseFeatureDetailsForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lvLicenseFeatureDetails = new System.Windows.Forms.ListView();
            this.chBlank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(410, 367);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lvLicenseFeatureDetails
            // 
            this.lvLicenseFeatureDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBlank,
            this.chName});
            this.lvLicenseFeatureDetails.GridLines = true;
            this.lvLicenseFeatureDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvLicenseFeatureDetails.HideSelection = false;
            this.lvLicenseFeatureDetails.Location = new System.Drawing.Point(12, 12);
            this.lvLicenseFeatureDetails.MultiSelect = false;
            this.lvLicenseFeatureDetails.Name = "lvLicenseFeatureDetails";
            this.lvLicenseFeatureDetails.Size = new System.Drawing.Size(473, 349);
            this.lvLicenseFeatureDetails.TabIndex = 4;
            this.lvLicenseFeatureDetails.UseCompatibleStateImageBehavior = false;
            this.lvLicenseFeatureDetails.View = System.Windows.Forms.View.Details;
            // 
            // chBlank
            // 
            this.chBlank.Text = "";
            this.chBlank.Width = 0;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 469;
            // 
            // LicenseFeatureDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 401);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lvLicenseFeatureDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LicenseFeatureDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "License Feature Details";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListView lvLicenseFeatureDetails;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chBlank;
    }
}