namespace ExampleClient.Source
{
    partial class LimitDetailsForm
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
            this.tvLimits = new System.Windows.Forms.TreeView();
            this.btnExpandAll = new System.Windows.Forms.Button();
            this.btnCollapseAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(433, 299);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // tvLimits
            // 
            this.tvLimits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvLimits.Location = new System.Drawing.Point(12, 12);
            this.tvLimits.Name = "tvLimits";
            this.tvLimits.Size = new System.Drawing.Size(496, 281);
            this.tvLimits.TabIndex = 6;
            // 
            // btnExpandAll
            // 
            this.btnExpandAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExpandAll.Location = new System.Drawing.Point(12, 299);
            this.btnExpandAll.Name = "btnExpandAll";
            this.btnExpandAll.Size = new System.Drawing.Size(75, 23);
            this.btnExpandAll.TabIndex = 7;
            this.btnExpandAll.Text = "Expand All";
            this.btnExpandAll.UseVisualStyleBackColor = true;
            this.btnExpandAll.Click += new System.EventHandler(this.ButtonExpandAll_Click);
            // 
            // btnCollapseAll
            // 
            this.btnCollapseAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCollapseAll.Location = new System.Drawing.Point(93, 299);
            this.btnCollapseAll.Name = "btnCollapseAll";
            this.btnCollapseAll.Size = new System.Drawing.Size(75, 23);
            this.btnCollapseAll.TabIndex = 8;
            this.btnCollapseAll.Text = "Collapse All";
            this.btnCollapseAll.UseVisualStyleBackColor = true;
            this.btnCollapseAll.Click += new System.EventHandler(this.ButtonCollapseAll_Click);
            // 
            // LimitDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 330);
            this.Controls.Add(this.btnCollapseAll);
            this.Controls.Add(this.btnExpandAll);
            this.Controls.Add(this.tvLimits);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LimitDetailsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Limit Details";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TreeView tvLimits;
        private System.Windows.Forms.Button btnExpandAll;
        private System.Windows.Forms.Button btnCollapseAll;
    }
}