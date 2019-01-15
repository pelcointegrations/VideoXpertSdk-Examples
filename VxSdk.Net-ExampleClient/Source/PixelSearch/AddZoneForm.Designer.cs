namespace ExampleClient.Source
{
    partial class AddZoneForm
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
            this.nudLeft = new System.Windows.Forms.NumericUpDown();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.nudTop = new System.Windows.Forms.NumericUpDown();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblTop = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.pnlFrame = new System.Windows.Forms.Panel();
            this.pnlSelection = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            this.pnlFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(158, 239);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(239, 239);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // nudLeft
            // 
            this.nudLeft.Location = new System.Drawing.Point(142, 7);
            this.nudLeft.Maximum = new decimal(new int[] {
            998,
            0,
            0,
            0});
            this.nudLeft.Name = "nudLeft";
            this.nudLeft.Size = new System.Drawing.Size(53, 20);
            this.nudLeft.TabIndex = 33;
            this.nudLeft.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudLeft.ValueChanged += new System.EventHandler(this.NumericUpDownTopLeft_ValueChanged);
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(261, 7);
            this.nudWidth.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(53, 20);
            this.nudWidth.TabIndex = 34;
            this.nudWidth.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.nudWidth.ValueChanged += new System.EventHandler(this.NumericUpDownTopLeft_ValueChanged);
            // 
            // nudTop
            // 
            this.nudTop.Location = new System.Drawing.Point(55, 33);
            this.nudTop.Maximum = new decimal(new int[] {
            998,
            0,
            0,
            0});
            this.nudTop.Name = "nudTop";
            this.nudTop.Size = new System.Drawing.Size(53, 20);
            this.nudTop.TabIndex = 35;
            this.nudTop.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudTop.ValueChanged += new System.EventHandler(this.NumericUpDownTopHeight_ValueChanged);
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(55, 72);
            this.nudHeight.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(53, 20);
            this.nudHeight.TabIndex = 36;
            this.nudHeight.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.nudHeight.ValueChanged += new System.EventHandler(this.NumericUpDownTopHeight_ValueChanged);
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(111, 9);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(25, 13);
            this.lblLeft.TabIndex = 37;
            this.lblLeft.Text = "Left";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(220, 9);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 38;
            this.lblWidth.Text = "Width";
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Location = new System.Drawing.Point(23, 35);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(26, 13);
            this.lblTop.TabIndex = 39;
            this.lblTop.Text = "Top";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(11, 74);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 40;
            this.lblHeight.Text = "Height";
            // 
            // pnlFrame
            // 
            this.pnlFrame.BackColor = System.Drawing.Color.White;
            this.pnlFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFrame.Controls.Add(this.pnlSelection);
            this.pnlFrame.Location = new System.Drawing.Point(114, 33);
            this.pnlFrame.Name = "pnlFrame";
            this.pnlFrame.Size = new System.Drawing.Size(200, 200);
            this.pnlFrame.TabIndex = 41;
            // 
            // pnlSelection
            // 
            this.pnlSelection.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSelection.Location = new System.Drawing.Point(40, 40);
            this.pnlSelection.Name = "pnlSelection";
            this.pnlSelection.Size = new System.Drawing.Size(120, 120);
            this.pnlSelection.TabIndex = 0;
            // 
            // AddZoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 273);
            this.Controls.Add(this.pnlFrame);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.nudHeight);
            this.Controls.Add(this.nudTop);
            this.Controls.Add(this.nudWidth);
            this.Controls.Add(this.nudLeft);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddZoneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Zone";
            ((System.ComponentModel.ISupportInitialize)(this.nudLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            this.pnlFrame.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nudLeft;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudTop;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Panel pnlFrame;
        private System.Windows.Forms.Panel pnlSelection;
    }
}