﻿namespace ExampleClient.Source
{
    partial class RelationDetailsForm
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
            this.lvRelationInfo = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvRelationInfo
            // 
            this.lvRelationInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chId});
            this.lvRelationInfo.FullRowSelect = true;
            this.lvRelationInfo.Location = new System.Drawing.Point(12, 12);
            this.lvRelationInfo.MultiSelect = false;
            this.lvRelationInfo.Name = "lvRelationInfo";
            this.lvRelationInfo.Size = new System.Drawing.Size(506, 297);
            this.lvRelationInfo.TabIndex = 9;
            this.lvRelationInfo.UseCompatibleStateImageBehavior = false;
            this.lvRelationInfo.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 250;
            // 
            // chId
            // 
            this.chId.Text = "ID";
            this.chId.Width = 250;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(443, 316);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(362, 315);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // RelationDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 351);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lvRelationInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RelationDetailsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Relation Details";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvRelationInfo;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
    }
}