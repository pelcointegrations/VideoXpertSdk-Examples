namespace ExampleClient.Source
{
    partial class ModifyDrawingForm
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
            this.pbxMain = new System.Windows.Forms.PictureBox();
            this.lvDataSources = new System.Windows.Forms.ListView();
            this.colHeadName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeadId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSetImage = new System.Windows.Forms.Button();
            this.btnClearImage = new System.Windows.Forms.Button();
            this.ofdSelectImage = new System.Windows.Forms.OpenFileDialog();
            this.btnRename = new System.Windows.Forms.Button();
            this.clrdlgMapBgColor = new System.Windows.Forms.ColorDialog();
            this.pnlMapBgColor = new System.Windows.Forms.Panel();
            this.tbrMapBgAlpha = new System.Windows.Forms.TrackBar();
            this.nudMapBgAlpha = new System.Windows.Forms.NumericUpDown();
            this.gbxMapBackgroundColor = new System.Windows.Forms.GroupBox();
            this.lblMapBgAlpha = new System.Windows.Forms.Label();
            this.lblMapBgColor = new System.Windows.Forms.Label();
            this.gbxCameraNumberColor = new System.Windows.Forms.GroupBox();
            this.cbxShowCameraNumbers = new System.Windows.Forms.CheckBox();
            this.lblNumberAlpha = new System.Windows.Forms.Label();
            this.lblNumberColor = new System.Windows.Forms.Label();
            this.nudNumberAlpha = new System.Windows.Forms.NumericUpDown();
            this.tbrNumberAlpha = new System.Windows.Forms.TrackBar();
            this.pnlNumberColor = new System.Windows.Forms.Panel();
            this.gbxMarkerSize = new System.Windows.Forms.GroupBox();
            this.nudMarkerSize = new System.Windows.Forms.NumericUpDown();
            this.tbrMarkerSize = new System.Windows.Forms.TrackBar();
            this.clrdlgNumberColor = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrMapBgAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMapBgAlpha)).BeginInit();
            this.gbxMapBackgroundColor.SuspendLayout();
            this.gbxCameraNumberColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrNumberAlpha)).BeginInit();
            this.gbxMarkerSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMarkerSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrMarkerSize)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxMain
            // 
            this.pbxMain.Location = new System.Drawing.Point(3, 3);
            this.pbxMain.Name = "pbxMain";
            this.pbxMain.Size = new System.Drawing.Size(649, 662);
            this.pbxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMain.TabIndex = 0;
            this.pbxMain.TabStop = false;
            this.pbxMain.DragDrop += new System.Windows.Forms.DragEventHandler(this.PictureBoxMain_OnDragDrop);
            this.pbxMain.DragEnter += new System.Windows.Forms.DragEventHandler(this.PictureBoxMain_OnDragEnter);
            // 
            // lvDataSources
            // 
            this.lvDataSources.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadName,
            this.colHeadId});
            this.lvDataSources.FullRowSelect = true;
            this.lvDataSources.HideSelection = false;
            this.lvDataSources.Location = new System.Drawing.Point(658, 3);
            this.lvDataSources.MultiSelect = false;
            this.lvDataSources.Name = "lvDataSources";
            this.lvDataSources.Size = new System.Drawing.Size(320, 436);
            this.lvDataSources.TabIndex = 2;
            this.lvDataSources.UseCompatibleStateImageBehavior = false;
            this.lvDataSources.View = System.Windows.Forms.View.Details;
            this.lvDataSources.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.ListViewDataSources_OnItemDrag);
            // 
            // colHeadName
            // 
            this.colHeadName.Text = "Name";
            this.colHeadName.Width = 255;
            // 
            // colHeadId
            // 
            this.colHeadId.Text = "Id";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(925, 642);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(870, 642);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSetImage
            // 
            this.btnSetImage.Location = new System.Drawing.Point(734, 642);
            this.btnSetImage.Name = "btnSetImage";
            this.btnSetImage.Size = new System.Drawing.Size(71, 23);
            this.btnSetImage.TabIndex = 5;
            this.btnSetImage.Text = "Set Image";
            this.btnSetImage.UseVisualStyleBackColor = true;
            this.btnSetImage.Click += new System.EventHandler(this.ButtonSetImage_Click);
            // 
            // btnClearImage
            // 
            this.btnClearImage.Location = new System.Drawing.Point(658, 642);
            this.btnClearImage.Name = "btnClearImage";
            this.btnClearImage.Size = new System.Drawing.Size(71, 23);
            this.btnClearImage.TabIndex = 6;
            this.btnClearImage.Text = "Clear Image";
            this.btnClearImage.UseVisualStyleBackColor = true;
            this.btnClearImage.Click += new System.EventHandler(this.ButtonClearImage_Click);
            // 
            // ofdSelectImage
            // 
            this.ofdSelectImage.Filter = "Image Files (*.dwg, *.jpg, *.png)|*.dwg;*.jpg;*.png";
            this.ofdSelectImage.Title = "Select Image";
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(810, 642);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(55, 23);
            this.btnRename.TabIndex = 7;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.ButtonRename_Click);
            // 
            // pnlMapBgColor
            // 
            this.pnlMapBgColor.Location = new System.Drawing.Point(46, 21);
            this.pnlMapBgColor.Name = "pnlMapBgColor";
            this.pnlMapBgColor.Size = new System.Drawing.Size(43, 23);
            this.pnlMapBgColor.TabIndex = 9;
            this.pnlMapBgColor.Click += new System.EventHandler(this.PanelMapBgColor_Click);
            // 
            // tbrMapBgAlpha
            // 
            this.tbrMapBgAlpha.AutoSize = false;
            this.tbrMapBgAlpha.Location = new System.Drawing.Point(124, 21);
            this.tbrMapBgAlpha.Maximum = 255;
            this.tbrMapBgAlpha.Name = "tbrMapBgAlpha";
            this.tbrMapBgAlpha.Size = new System.Drawing.Size(83, 23);
            this.tbrMapBgAlpha.TabIndex = 10;
            this.tbrMapBgAlpha.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbrMapBgAlpha.ValueChanged += new System.EventHandler(this.TrackBarBgColorAlpha_ValueChanged);
            // 
            // nudMapBgAlpha
            // 
            this.nudMapBgAlpha.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudMapBgAlpha.InterceptArrowKeys = false;
            this.nudMapBgAlpha.Location = new System.Drawing.Point(207, 22);
            this.nudMapBgAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMapBgAlpha.Name = "nudMapBgAlpha";
            this.nudMapBgAlpha.ReadOnly = true;
            this.nudMapBgAlpha.Size = new System.Drawing.Size(45, 20);
            this.nudMapBgAlpha.TabIndex = 11;
            this.nudMapBgAlpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbxMapBackgroundColor
            // 
            this.gbxMapBackgroundColor.Controls.Add(this.lblMapBgAlpha);
            this.gbxMapBackgroundColor.Controls.Add(this.lblMapBgColor);
            this.gbxMapBackgroundColor.Controls.Add(this.nudMapBgAlpha);
            this.gbxMapBackgroundColor.Controls.Add(this.tbrMapBgAlpha);
            this.gbxMapBackgroundColor.Controls.Add(this.pnlMapBgColor);
            this.gbxMapBackgroundColor.Location = new System.Drawing.Point(658, 445);
            this.gbxMapBackgroundColor.Name = "gbxMapBackgroundColor";
            this.gbxMapBackgroundColor.Size = new System.Drawing.Size(320, 58);
            this.gbxMapBackgroundColor.TabIndex = 12;
            this.gbxMapBackgroundColor.TabStop = false;
            this.gbxMapBackgroundColor.Text = "Map Background Color";
            // 
            // lblMapBgAlpha
            // 
            this.lblMapBgAlpha.AutoSize = true;
            this.lblMapBgAlpha.Location = new System.Drawing.Point(92, 26);
            this.lblMapBgAlpha.Name = "lblMapBgAlpha";
            this.lblMapBgAlpha.Size = new System.Drawing.Size(37, 13);
            this.lblMapBgAlpha.TabIndex = 13;
            this.lblMapBgAlpha.Text = "Alpha:";
            // 
            // lblMapBgColor
            // 
            this.lblMapBgColor.AutoSize = true;
            this.lblMapBgColor.Location = new System.Drawing.Point(9, 26);
            this.lblMapBgColor.Name = "lblMapBgColor";
            this.lblMapBgColor.Size = new System.Drawing.Size(34, 13);
            this.lblMapBgColor.TabIndex = 12;
            this.lblMapBgColor.Text = "Color:";
            // 
            // gbxCameraNumberColor
            // 
            this.gbxCameraNumberColor.Controls.Add(this.cbxShowCameraNumbers);
            this.gbxCameraNumberColor.Controls.Add(this.lblNumberAlpha);
            this.gbxCameraNumberColor.Controls.Add(this.lblNumberColor);
            this.gbxCameraNumberColor.Controls.Add(this.nudNumberAlpha);
            this.gbxCameraNumberColor.Controls.Add(this.tbrNumberAlpha);
            this.gbxCameraNumberColor.Controls.Add(this.pnlNumberColor);
            this.gbxCameraNumberColor.Location = new System.Drawing.Point(658, 509);
            this.gbxCameraNumberColor.Name = "gbxCameraNumberColor";
            this.gbxCameraNumberColor.Size = new System.Drawing.Size(320, 71);
            this.gbxCameraNumberColor.TabIndex = 14;
            this.gbxCameraNumberColor.TabStop = false;
            this.gbxCameraNumberColor.Text = "Camera Numbers";
            // 
            // cbxShowCameraNumbers
            // 
            this.cbxShowCameraNumbers.AutoSize = true;
            this.cbxShowCameraNumbers.Location = new System.Drawing.Point(10, 19);
            this.cbxShowCameraNumbers.Name = "cbxShowCameraNumbers";
            this.cbxShowCameraNumbers.Size = new System.Drawing.Size(137, 17);
            this.cbxShowCameraNumbers.TabIndex = 14;
            this.cbxShowCameraNumbers.Text = "Show Camera Numbers";
            this.cbxShowCameraNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxShowCameraNumbers.UseVisualStyleBackColor = true;
            this.cbxShowCameraNumbers.CheckedChanged += new System.EventHandler(this.CheckBoxShowCameraNumbers_CheckedChanged);
            // 
            // lblNumberAlpha
            // 
            this.lblNumberAlpha.AutoSize = true;
            this.lblNumberAlpha.Location = new System.Drawing.Point(90, 44);
            this.lblNumberAlpha.Name = "lblNumberAlpha";
            this.lblNumberAlpha.Size = new System.Drawing.Size(37, 13);
            this.lblNumberAlpha.TabIndex = 13;
            this.lblNumberAlpha.Text = "Alpha:";
            // 
            // lblNumberColor
            // 
            this.lblNumberColor.AutoSize = true;
            this.lblNumberColor.Location = new System.Drawing.Point(7, 44);
            this.lblNumberColor.Name = "lblNumberColor";
            this.lblNumberColor.Size = new System.Drawing.Size(34, 13);
            this.lblNumberColor.TabIndex = 12;
            this.lblNumberColor.Text = "Color:";
            // 
            // nudNumberAlpha
            // 
            this.nudNumberAlpha.Location = new System.Drawing.Point(205, 40);
            this.nudNumberAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudNumberAlpha.Name = "nudNumberAlpha";
            this.nudNumberAlpha.ReadOnly = true;
            this.nudNumberAlpha.Size = new System.Drawing.Size(45, 20);
            this.nudNumberAlpha.TabIndex = 11;
            this.nudNumberAlpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbrNumberAlpha
            // 
            this.tbrNumberAlpha.AutoSize = false;
            this.tbrNumberAlpha.Location = new System.Drawing.Point(122, 39);
            this.tbrNumberAlpha.Maximum = 255;
            this.tbrNumberAlpha.Name = "tbrNumberAlpha";
            this.tbrNumberAlpha.Size = new System.Drawing.Size(83, 23);
            this.tbrNumberAlpha.TabIndex = 10;
            this.tbrNumberAlpha.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbrNumberAlpha.ValueChanged += new System.EventHandler(this.TrackBarNumberAlpha_ValueChanged);
            // 
            // pnlNumberColor
            // 
            this.pnlNumberColor.Location = new System.Drawing.Point(44, 39);
            this.pnlNumberColor.Name = "pnlNumberColor";
            this.pnlNumberColor.Size = new System.Drawing.Size(43, 23);
            this.pnlNumberColor.TabIndex = 9;
            this.pnlNumberColor.Click += new System.EventHandler(this.PanelNumberColor_Click);
            // 
            // gbxMarkerSize
            // 
            this.gbxMarkerSize.Controls.Add(this.nudMarkerSize);
            this.gbxMarkerSize.Controls.Add(this.tbrMarkerSize);
            this.gbxMarkerSize.Location = new System.Drawing.Point(658, 586);
            this.gbxMarkerSize.Name = "gbxMarkerSize";
            this.gbxMarkerSize.Size = new System.Drawing.Size(320, 50);
            this.gbxMarkerSize.TabIndex = 15;
            this.gbxMarkerSize.TabStop = false;
            this.gbxMarkerSize.Text = "Marker Size";
            // 
            // nudMarkerSize
            // 
            this.nudMarkerSize.Location = new System.Drawing.Point(207, 19);
            this.nudMarkerSize.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudMarkerSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMarkerSize.Name = "nudMarkerSize";
            this.nudMarkerSize.ReadOnly = true;
            this.nudMarkerSize.Size = new System.Drawing.Size(45, 20);
            this.nudMarkerSize.TabIndex = 14;
            this.nudMarkerSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMarkerSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbrMarkerSize
            // 
            this.tbrMarkerSize.AutoSize = false;
            this.tbrMarkerSize.Location = new System.Drawing.Point(12, 19);
            this.tbrMarkerSize.Maximum = 500;
            this.tbrMarkerSize.Minimum = 1;
            this.tbrMarkerSize.Name = "tbrMarkerSize";
            this.tbrMarkerSize.Size = new System.Drawing.Size(189, 23);
            this.tbrMarkerSize.TabIndex = 14;
            this.tbrMarkerSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbrMarkerSize.Value = 1;
            this.tbrMarkerSize.ValueChanged += new System.EventHandler(this.TrackBarMarkerSize_ValueChanged);
            // 
            // ModifyDrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 669);
            this.Controls.Add(this.gbxMarkerSize);
            this.Controls.Add(this.gbxCameraNumberColor);
            this.Controls.Add(this.gbxMapBackgroundColor);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnClearImage);
            this.Controls.Add(this.btnSetImage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lvDataSources);
            this.Controls.Add(this.pbxMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyDrawingForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit";
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrMapBgAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMapBgAlpha)).EndInit();
            this.gbxMapBackgroundColor.ResumeLayout(false);
            this.gbxMapBackgroundColor.PerformLayout();
            this.gbxCameraNumberColor.ResumeLayout(false);
            this.gbxCameraNumberColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrNumberAlpha)).EndInit();
            this.gbxMarkerSize.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMarkerSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrMarkerSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxMain;
        public System.Windows.Forms.ListView lvDataSources;
        private System.Windows.Forms.ColumnHeader colHeadName;
        private System.Windows.Forms.ColumnHeader colHeadId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSetImage;
        private System.Windows.Forms.Button btnClearImage;
        private System.Windows.Forms.OpenFileDialog ofdSelectImage;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.ColorDialog clrdlgMapBgColor;
        private System.Windows.Forms.Panel pnlMapBgColor;
        private System.Windows.Forms.TrackBar tbrMapBgAlpha;
        private System.Windows.Forms.NumericUpDown nudMapBgAlpha;
        private System.Windows.Forms.GroupBox gbxMapBackgroundColor;
        private System.Windows.Forms.Label lblMapBgAlpha;
        private System.Windows.Forms.Label lblMapBgColor;
        private System.Windows.Forms.GroupBox gbxCameraNumberColor;
        private System.Windows.Forms.Label lblNumberAlpha;
        private System.Windows.Forms.Label lblNumberColor;
        private System.Windows.Forms.NumericUpDown nudNumberAlpha;
        private System.Windows.Forms.TrackBar tbrNumberAlpha;
        private System.Windows.Forms.Panel pnlNumberColor;
        private System.Windows.Forms.GroupBox gbxMarkerSize;
        private System.Windows.Forms.NumericUpDown nudMarkerSize;
        private System.Windows.Forms.TrackBar tbrMarkerSize;
        private System.Windows.Forms.ColorDialog clrdlgNumberColor;
        private System.Windows.Forms.CheckBox cbxShowCameraNumbers;
    }
}