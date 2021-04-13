using System;
using System.Windows.Forms;

namespace ExampleClient.Source
{
    partial class PtzControlForm
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
            this.gbPatterns = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.cbxPatterns = new System.Windows.Forms.ComboBox();
            this.btnTriggerPattern = new System.Windows.Forms.Button();
            this.gbPresets = new System.Windows.Forms.GroupBox();
            this.btnRepositionPreset = new System.Windows.Forms.Button();
            this.btnNewPreset = new System.Windows.Forms.Button();
            this.btnDeletePreset = new System.Windows.Forms.Button();
            this.cbxPresets = new System.Windows.Forms.ComboBox();
            this.btnTriggerPreset = new System.Windows.Forms.Button();
            this.btnPtzZoomOut = new System.Windows.Forms.Button();
            this.btnPtzZoomIn = new System.Windows.Forms.Button();
            this.btnPtzUR = new System.Windows.Forms.Button();
            this.btnPtzUL = new System.Windows.Forms.Button();
            this.btnPtzDL = new System.Windows.Forms.Button();
            this.btnPtzDR = new System.Windows.Forms.Button();
            this.btnPtzD = new System.Windows.Forms.Button();
            this.btnPtzR = new System.Windows.Forms.Button();
            this.btnPtzL = new System.Windows.Forms.Button();
            this.btnPtzU = new System.Windows.Forms.Button();
            this.btnPtzFocusFar = new System.Windows.Forms.Button();
            this.btnPtzIrisClose = new System.Windows.Forms.Button();
            this.btnPtzIrisOpen = new System.Windows.Forms.Button();
            this.btnPtzFocusNear = new System.Windows.Forms.Button();
            this.lblZoom = new System.Windows.Forms.Label();
            this.lblFocus = new System.Windows.Forms.Label();
            this.lblIris = new System.Windows.Forms.Label();
            this.gbAbsoluteMove = new System.Windows.Forms.GroupBox();
            this.btnSetPosition = new System.Windows.Forms.Button();
            this.btnGetPosition = new System.Windows.Forms.Button();
            this.lblAbsZ = new System.Windows.Forms.Label();
            this.lblAbsY = new System.Windows.Forms.Label();
            this.lblAbsX = new System.Windows.Forms.Label();
            this.gbRelativeMove = new System.Windows.Forms.GroupBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.lblRelZ = new System.Windows.Forms.Label();
            this.lblRelY = new System.Windows.Forms.Label();
            this.lblRelX = new System.Windows.Forms.Label();
            this.txbxRelZ = new System.Windows.Forms.TextBox();
            this.txbxRelY = new System.Windows.Forms.TextBox();
            this.txbxRelX = new System.Windows.Forms.TextBox();
            this.gbPtzLock = new System.Windows.Forms.GroupBox();
            this.lblExpireTime = new System.Windows.Forms.Label();
            this.lblLockOwner = new System.Windows.Forms.Label();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnRefreshLock = new System.Windows.Forms.Button();
            this.btnStopFocusSpeed = new System.Windows.Forms.Button();
            this.btnExecuteFocusSpeed = new System.Windows.Forms.Button();
            this.gbFocusSpeed = new System.Windows.Forms.GroupBox();
            this.nudFocusSpeed = new System.Windows.Forms.NumericUpDown();
            this.lblFocusSpeedMax = new System.Windows.Forms.Label();
            this.lblFocusSpeedMin = new System.Windows.Forms.Label();
            this.tbFocusSpeed = new System.Windows.Forms.TrackBar();
            this.gbIrisSpeed = new System.Windows.Forms.GroupBox();
            this.nudIrisSpeed = new System.Windows.Forms.NumericUpDown();
            this.btnStopIrisSpeed = new System.Windows.Forms.Button();
            this.lblIrisSpeedMax = new System.Windows.Forms.Label();
            this.btnExecuteIrisSpeed = new System.Windows.Forms.Button();
            this.lblIrisSpeedMin = new System.Windows.Forms.Label();
            this.tbIrisSpeed = new System.Windows.Forms.TrackBar();
            this.btnExpander = new System.Windows.Forms.Button();
            this.tlpAdvanced = new System.Windows.Forms.TableLayoutPanel();
            this.gbMoveSpeed = new System.Windows.Forms.GroupBox();
            this.gbZoomSpeed = new System.Windows.Forms.GroupBox();
            this.nudZoomSpeed = new System.Windows.Forms.NumericUpDown();
            this.lblZoomSpeedMax = new System.Windows.Forms.Label();
            this.lblZoomSpeedMin = new System.Windows.Forms.Label();
            this.tbZoomSpeed = new System.Windows.Forms.TrackBar();
            this.btnStopSpeed = new System.Windows.Forms.Button();
            this.gbTiltSpeed = new System.Windows.Forms.GroupBox();
            this.nudTiltSpeed = new System.Windows.Forms.NumericUpDown();
            this.lblTiltSpeedMax = new System.Windows.Forms.Label();
            this.lblTiltSpeedMin = new System.Windows.Forms.Label();
            this.tbTiltSpeed = new System.Windows.Forms.TrackBar();
            this.btnExecuteSpeed = new System.Windows.Forms.Button();
            this.gbPanSpeed = new System.Windows.Forms.GroupBox();
            this.nudPanSpeed = new System.Windows.Forms.NumericUpDown();
            this.lblPanSpeedMax = new System.Windows.Forms.Label();
            this.lblPanSpeedMin = new System.Windows.Forms.Label();
            this.tbPanSpeed = new System.Windows.Forms.TrackBar();
            this.pnlMainControls = new System.Windows.Forms.Panel();
            this.tlpMainWindow = new System.Windows.Forms.TableLayoutPanel();
            this.txbxAbsZ = new System.Windows.Forms.TextBox();
            this.txbxAbsY = new System.Windows.Forms.TextBox();
            this.txbxAbsX = new System.Windows.Forms.TextBox();
            this.gbPatterns.SuspendLayout();
            this.gbPresets.SuspendLayout();
            this.gbAbsoluteMove.SuspendLayout();
            this.gbRelativeMove.SuspendLayout();
            this.gbPtzLock.SuspendLayout();
            this.gbFocusSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFocusSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFocusSpeed)).BeginInit();
            this.gbIrisSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIrisSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbIrisSpeed)).BeginInit();
            this.tlpAdvanced.SuspendLayout();
            this.gbMoveSpeed.SuspendLayout();
            this.gbZoomSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudZoomSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoomSpeed)).BeginInit();
            this.gbTiltSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTiltSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTiltSpeed)).BeginInit();
            this.gbPanSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPanSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPanSpeed)).BeginInit();
            this.pnlMainControls.SuspendLayout();
            this.tlpMainWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPatterns
            // 
            this.gbPatterns.Controls.Add(this.btnStop);
            this.gbPatterns.Controls.Add(this.cbxPatterns);
            this.gbPatterns.Controls.Add(this.btnTriggerPattern);
            this.gbPatterns.Location = new System.Drawing.Point(3, 182);
            this.gbPatterns.Name = "gbPatterns";
            this.gbPatterns.Size = new System.Drawing.Size(226, 78);
            this.gbPatterns.TabIndex = 46;
            this.gbPatterns.TabStop = false;
            this.gbPatterns.Text = "Patterns";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(94, 45);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(60, 23);
            this.btnStop.TabIndex = 33;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StopPtz);
            // 
            // cbxPatterns
            // 
            this.cbxPatterns.FormattingEnabled = true;
            this.cbxPatterns.Location = new System.Drawing.Point(8, 19);
            this.cbxPatterns.Name = "cbxPatterns";
            this.cbxPatterns.Size = new System.Drawing.Size(212, 21);
            this.cbxPatterns.TabIndex = 31;
            // 
            // btnTriggerPattern
            // 
            this.btnTriggerPattern.Location = new System.Drawing.Point(160, 45);
            this.btnTriggerPattern.Name = "btnTriggerPattern";
            this.btnTriggerPattern.Size = new System.Drawing.Size(60, 23);
            this.btnTriggerPattern.TabIndex = 32;
            this.btnTriggerPattern.Text = "Trigger";
            this.btnTriggerPattern.UseVisualStyleBackColor = true;
            this.btnTriggerPattern.Click += new System.EventHandler(this.ButtonTriggerPattern_Click);
            // 
            // gbPresets
            // 
            this.gbPresets.Controls.Add(this.btnRepositionPreset);
            this.gbPresets.Controls.Add(this.btnNewPreset);
            this.gbPresets.Controls.Add(this.btnDeletePreset);
            this.gbPresets.Controls.Add(this.cbxPresets);
            this.gbPresets.Controls.Add(this.btnTriggerPreset);
            this.gbPresets.Location = new System.Drawing.Point(3, 98);
            this.gbPresets.Name = "gbPresets";
            this.gbPresets.Size = new System.Drawing.Size(226, 78);
            this.gbPresets.TabIndex = 45;
            this.gbPresets.TabStop = false;
            this.gbPresets.Text = "Presets";
            // 
            // btnRepositionPreset
            // 
            this.btnRepositionPreset.Location = new System.Drawing.Point(102, 45);
            this.btnRepositionPreset.Name = "btnRepositionPreset";
            this.btnRepositionPreset.Size = new System.Drawing.Size(67, 23);
            this.btnRepositionPreset.TabIndex = 35;
            this.btnRepositionPreset.Text = "Reposition";
            this.btnRepositionPreset.UseVisualStyleBackColor = true;
            this.btnRepositionPreset.Click += new System.EventHandler(this.ButtonRepositionPreset_Click);
            // 
            // btnNewPreset
            // 
            this.btnNewPreset.Location = new System.Drawing.Point(7, 45);
            this.btnNewPreset.Name = "btnNewPreset";
            this.btnNewPreset.Size = new System.Drawing.Size(40, 23);
            this.btnNewPreset.TabIndex = 34;
            this.btnNewPreset.Text = "New";
            this.btnNewPreset.UseVisualStyleBackColor = true;
            this.btnNewPreset.Click += new System.EventHandler(this.ButtonNewPreset_Click);
            // 
            // btnDeletePreset
            // 
            this.btnDeletePreset.Location = new System.Drawing.Point(50, 45);
            this.btnDeletePreset.Name = "btnDeletePreset";
            this.btnDeletePreset.Size = new System.Drawing.Size(50, 23);
            this.btnDeletePreset.TabIndex = 33;
            this.btnDeletePreset.Text = "Delete";
            this.btnDeletePreset.UseVisualStyleBackColor = true;
            this.btnDeletePreset.Click += new System.EventHandler(this.ButtonDeletePreset_Click);
            // 
            // cbxPresets
            // 
            this.cbxPresets.FormattingEnabled = true;
            this.cbxPresets.Location = new System.Drawing.Point(8, 19);
            this.cbxPresets.Name = "cbxPresets";
            this.cbxPresets.Size = new System.Drawing.Size(212, 21);
            this.cbxPresets.TabIndex = 31;
            // 
            // btnTriggerPreset
            // 
            this.btnTriggerPreset.Location = new System.Drawing.Point(171, 45);
            this.btnTriggerPreset.Name = "btnTriggerPreset";
            this.btnTriggerPreset.Size = new System.Drawing.Size(49, 23);
            this.btnTriggerPreset.TabIndex = 32;
            this.btnTriggerPreset.Text = "Trigger";
            this.btnTriggerPreset.UseVisualStyleBackColor = true;
            this.btnTriggerPreset.Click += new System.EventHandler(this.ButtonTriggerPreset_Click);
            // 
            // btnPtzZoomOut
            // 
            this.btnPtzZoomOut.Location = new System.Drawing.Point(108, 62);
            this.btnPtzZoomOut.Name = "btnPtzZoomOut";
            this.btnPtzZoomOut.Size = new System.Drawing.Size(31, 30);
            this.btnPtzZoomOut.TabIndex = 44;
            this.btnPtzZoomOut.Text = "-";
            this.btnPtzZoomOut.UseVisualStyleBackColor = true;
            this.btnPtzZoomOut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPtzControl_Click);
            this.btnPtzZoomOut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopPtz);
            // 
            // btnPtzZoomIn
            // 
            this.btnPtzZoomIn.Location = new System.Drawing.Point(108, 4);
            this.btnPtzZoomIn.Name = "btnPtzZoomIn";
            this.btnPtzZoomIn.Size = new System.Drawing.Size(31, 30);
            this.btnPtzZoomIn.TabIndex = 43;
            this.btnPtzZoomIn.Text = "+";
            this.btnPtzZoomIn.UseVisualStyleBackColor = true;
            this.btnPtzZoomIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPtzControl_Click);
            this.btnPtzZoomIn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopPtz);
            // 
            // btnPtzUR
            // 
            this.btnPtzUR.Location = new System.Drawing.Point(61, 4);
            this.btnPtzUR.Name = "btnPtzUR";
            this.btnPtzUR.Size = new System.Drawing.Size(31, 30);
            this.btnPtzUR.TabIndex = 42;
            this.btnPtzUR.Text = "UR";
            this.btnPtzUR.UseVisualStyleBackColor = true;
            this.btnPtzUR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPtzControl_Click);
            this.btnPtzUR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopPtz);
            // 
            // btnPtzUL
            // 
            this.btnPtzUL.Location = new System.Drawing.Point(3, 4);
            this.btnPtzUL.Name = "btnPtzUL";
            this.btnPtzUL.Size = new System.Drawing.Size(30, 30);
            this.btnPtzUL.TabIndex = 41;
            this.btnPtzUL.Text = "UL";
            this.btnPtzUL.UseVisualStyleBackColor = true;
            this.btnPtzUL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPtzControl_Click);
            this.btnPtzUL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopPtz);
            // 
            // btnPtzDL
            // 
            this.btnPtzDL.Location = new System.Drawing.Point(3, 62);
            this.btnPtzDL.Name = "btnPtzDL";
            this.btnPtzDL.Size = new System.Drawing.Size(30, 30);
            this.btnPtzDL.TabIndex = 40;
            this.btnPtzDL.Text = "DL";
            this.btnPtzDL.UseVisualStyleBackColor = true;
            this.btnPtzDL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPtzControl_Click);
            this.btnPtzDL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopPtz);
            // 
            // btnPtzDR
            // 
            this.btnPtzDR.Location = new System.Drawing.Point(61, 62);
            this.btnPtzDR.Name = "btnPtzDR";
            this.btnPtzDR.Size = new System.Drawing.Size(31, 30);
            this.btnPtzDR.TabIndex = 39;
            this.btnPtzDR.Text = "DR";
            this.btnPtzDR.UseVisualStyleBackColor = true;
            this.btnPtzDR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPtzControl_Click);
            this.btnPtzDR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopPtz);
            // 
            // btnPtzD
            // 
            this.btnPtzD.Location = new System.Drawing.Point(32, 62);
            this.btnPtzD.Name = "btnPtzD";
            this.btnPtzD.Size = new System.Drawing.Size(30, 30);
            this.btnPtzD.TabIndex = 38;
            this.btnPtzD.Text = "D";
            this.btnPtzD.UseVisualStyleBackColor = true;
            this.btnPtzD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPtzControl_Click);
            this.btnPtzD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopPtz);
            // 
            // btnPtzR
            // 
            this.btnPtzR.Location = new System.Drawing.Point(61, 33);
            this.btnPtzR.Name = "btnPtzR";
            this.btnPtzR.Size = new System.Drawing.Size(31, 30);
            this.btnPtzR.TabIndex = 37;
            this.btnPtzR.Text = "R";
            this.btnPtzR.UseVisualStyleBackColor = true;
            this.btnPtzR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPtzControl_Click);
            this.btnPtzR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopPtz);
            // 
            // btnPtzL
            // 
            this.btnPtzL.Location = new System.Drawing.Point(3, 33);
            this.btnPtzL.Name = "btnPtzL";
            this.btnPtzL.Size = new System.Drawing.Size(30, 30);
            this.btnPtzL.TabIndex = 36;
            this.btnPtzL.Text = "L";
            this.btnPtzL.UseVisualStyleBackColor = true;
            this.btnPtzL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPtzControl_Click);
            this.btnPtzL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopPtz);
            // 
            // btnPtzU
            // 
            this.btnPtzU.Location = new System.Drawing.Point(32, 4);
            this.btnPtzU.Name = "btnPtzU";
            this.btnPtzU.Size = new System.Drawing.Size(30, 30);
            this.btnPtzU.TabIndex = 35;
            this.btnPtzU.Text = "U";
            this.btnPtzU.UseVisualStyleBackColor = true;
            this.btnPtzU.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPtzControl_Click);
            this.btnPtzU.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopPtz);
            // 
            // btnPtzFocusFar
            // 
            this.btnPtzFocusFar.Location = new System.Drawing.Point(153, 62);
            this.btnPtzFocusFar.Name = "btnPtzFocusFar";
            this.btnPtzFocusFar.Size = new System.Drawing.Size(31, 30);
            this.btnPtzFocusFar.TabIndex = 47;
            this.btnPtzFocusFar.Text = "-";
            this.btnPtzFocusFar.UseVisualStyleBackColor = true;
            this.btnPtzFocusFar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPtzControl_Click);
            this.btnPtzFocusFar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopPtz);
            // 
            // btnPtzIrisClose
            // 
            this.btnPtzIrisClose.Location = new System.Drawing.Point(198, 62);
            this.btnPtzIrisClose.Name = "btnPtzIrisClose";
            this.btnPtzIrisClose.Size = new System.Drawing.Size(31, 30);
            this.btnPtzIrisClose.TabIndex = 48;
            this.btnPtzIrisClose.Text = "-";
            this.btnPtzIrisClose.UseVisualStyleBackColor = true;
            this.btnPtzIrisClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPtzControl_Click);
            this.btnPtzIrisClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopPtz);
            // 
            // btnPtzIrisOpen
            // 
            this.btnPtzIrisOpen.Location = new System.Drawing.Point(198, 4);
            this.btnPtzIrisOpen.Name = "btnPtzIrisOpen";
            this.btnPtzIrisOpen.Size = new System.Drawing.Size(31, 30);
            this.btnPtzIrisOpen.TabIndex = 50;
            this.btnPtzIrisOpen.Text = "+";
            this.btnPtzIrisOpen.UseVisualStyleBackColor = true;
            this.btnPtzIrisOpen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPtzControl_Click);
            this.btnPtzIrisOpen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopPtz);
            // 
            // btnPtzFocusNear
            // 
            this.btnPtzFocusNear.Location = new System.Drawing.Point(153, 4);
            this.btnPtzFocusNear.Name = "btnPtzFocusNear";
            this.btnPtzFocusNear.Size = new System.Drawing.Size(31, 30);
            this.btnPtzFocusNear.TabIndex = 49;
            this.btnPtzFocusNear.Text = "+";
            this.btnPtzFocusNear.UseVisualStyleBackColor = true;
            this.btnPtzFocusNear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPtzControl_Click);
            this.btnPtzFocusNear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopPtz);
            // 
            // lblZoom
            // 
            this.lblZoom.AutoSize = true;
            this.lblZoom.Location = new System.Drawing.Point(106, 41);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(34, 13);
            this.lblZoom.TabIndex = 51;
            this.lblZoom.Text = "Zoom";
            // 
            // lblFocus
            // 
            this.lblFocus.AutoSize = true;
            this.lblFocus.Location = new System.Drawing.Point(150, 41);
            this.lblFocus.Name = "lblFocus";
            this.lblFocus.Size = new System.Drawing.Size(36, 13);
            this.lblFocus.TabIndex = 52;
            this.lblFocus.Text = "Focus";
            // 
            // lblIris
            // 
            this.lblIris.AutoSize = true;
            this.lblIris.Location = new System.Drawing.Point(203, 41);
            this.lblIris.Name = "lblIris";
            this.lblIris.Size = new System.Drawing.Size(20, 13);
            this.lblIris.TabIndex = 53;
            this.lblIris.Text = "Iris";
            // 
            // gbAbsoluteMove
            // 
            this.gbAbsoluteMove.Controls.Add(this.btnSetPosition);
            this.gbAbsoluteMove.Controls.Add(this.btnGetPosition);
            this.gbAbsoluteMove.Controls.Add(this.lblAbsZ);
            this.gbAbsoluteMove.Controls.Add(this.lblAbsY);
            this.gbAbsoluteMove.Controls.Add(this.lblAbsX);
            this.gbAbsoluteMove.Controls.Add(this.txbxAbsZ);
            this.gbAbsoluteMove.Controls.Add(this.txbxAbsY);
            this.gbAbsoluteMove.Controls.Add(this.txbxAbsX);
            this.gbAbsoluteMove.Location = new System.Drawing.Point(3, 3);
            this.gbAbsoluteMove.Name = "gbAbsoluteMove";
            this.gbAbsoluteMove.Size = new System.Drawing.Size(226, 78);
            this.gbAbsoluteMove.TabIndex = 54;
            this.gbAbsoluteMove.TabStop = false;
            this.gbAbsoluteMove.Text = "Absolute Move";
            // 
            // btnSetPosition
            // 
            this.btnSetPosition.Location = new System.Drawing.Point(143, 45);
            this.btnSetPosition.Name = "btnSetPosition";
            this.btnSetPosition.Size = new System.Drawing.Size(75, 23);
            this.btnSetPosition.TabIndex = 7;
            this.btnSetPosition.Text = "Set Position";
            this.btnSetPosition.UseVisualStyleBackColor = true;
            this.btnSetPosition.Click += new System.EventHandler(this.ButtonSetPosition_Click);
            // 
            // btnGetPosition
            // 
            this.btnGetPosition.Location = new System.Drawing.Point(61, 45);
            this.btnGetPosition.Name = "btnGetPosition";
            this.btnGetPosition.Size = new System.Drawing.Size(75, 23);
            this.btnGetPosition.TabIndex = 6;
            this.btnGetPosition.Text = "Get Position";
            this.btnGetPosition.UseVisualStyleBackColor = true;
            this.btnGetPosition.Click += new System.EventHandler(this.ButtonGetPosition_Click);
            // 
            // lblAbsZ
            // 
            this.lblAbsZ.AutoSize = true;
            this.lblAbsZ.Location = new System.Drawing.Point(154, 22);
            this.lblAbsZ.Name = "lblAbsZ";
            this.lblAbsZ.Size = new System.Drawing.Size(14, 13);
            this.lblAbsZ.TabIndex = 5;
            this.lblAbsZ.Text = "Z";
            // 
            // lblAbsY
            // 
            this.lblAbsY.AutoSize = true;
            this.lblAbsY.Location = new System.Drawing.Point(81, 22);
            this.lblAbsY.Name = "lblAbsY";
            this.lblAbsY.Size = new System.Drawing.Size(14, 13);
            this.lblAbsY.TabIndex = 4;
            this.lblAbsY.Text = "Y";
            // 
            // lblAbsX
            // 
            this.lblAbsX.AutoSize = true;
            this.lblAbsX.Location = new System.Drawing.Point(8, 22);
            this.lblAbsX.Name = "lblAbsX";
            this.lblAbsX.Size = new System.Drawing.Size(14, 13);
            this.lblAbsX.TabIndex = 3;
            this.lblAbsX.Text = "X";
            // 
            // gbRelativeMove
            // 
            this.gbRelativeMove.Controls.Add(this.btnMove);
            this.gbRelativeMove.Controls.Add(this.lblRelZ);
            this.gbRelativeMove.Controls.Add(this.lblRelY);
            this.gbRelativeMove.Controls.Add(this.lblRelX);
            this.gbRelativeMove.Controls.Add(this.txbxRelZ);
            this.gbRelativeMove.Controls.Add(this.txbxRelY);
            this.gbRelativeMove.Controls.Add(this.txbxRelX);
            this.gbRelativeMove.Location = new System.Drawing.Point(235, 3);
            this.gbRelativeMove.Name = "gbRelativeMove";
            this.gbRelativeMove.Size = new System.Drawing.Size(226, 78);
            this.gbRelativeMove.TabIndex = 55;
            this.gbRelativeMove.TabStop = false;
            this.gbRelativeMove.Text = "Relative Move";
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(163, 45);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(55, 23);
            this.btnMove.TabIndex = 7;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // lblRelZ
            // 
            this.lblRelZ.AutoSize = true;
            this.lblRelZ.Location = new System.Drawing.Point(154, 22);
            this.lblRelZ.Name = "lblRelZ";
            this.lblRelZ.Size = new System.Drawing.Size(14, 13);
            this.lblRelZ.TabIndex = 5;
            this.lblRelZ.Text = "Z";
            // 
            // lblRelY
            // 
            this.lblRelY.AutoSize = true;
            this.lblRelY.Location = new System.Drawing.Point(81, 22);
            this.lblRelY.Name = "lblRelY";
            this.lblRelY.Size = new System.Drawing.Size(14, 13);
            this.lblRelY.TabIndex = 4;
            this.lblRelY.Text = "Y";
            // 
            // lblRelX
            // 
            this.lblRelX.AutoSize = true;
            this.lblRelX.Location = new System.Drawing.Point(8, 22);
            this.lblRelX.Name = "lblRelX";
            this.lblRelX.Size = new System.Drawing.Size(14, 13);
            this.lblRelX.TabIndex = 3;
            this.lblRelX.Text = "X";
            // 
            // txbxRelZ
            // 
            this.txbxRelZ.Location = new System.Drawing.Point(178, 19);
            this.txbxRelZ.Name = "txbxRelZ";
            this.txbxRelZ.Size = new System.Drawing.Size(39, 20);
            this.txbxRelZ.TabIndex = 2;
            this.txbxRelZ.Text = "0";
            // 
            // txbxRelY
            // 
            this.txbxRelY.Location = new System.Drawing.Point(105, 19);
            this.txbxRelY.Name = "txbxRelY";
            this.txbxRelY.Size = new System.Drawing.Size(39, 20);
            this.txbxRelY.TabIndex = 1;
            this.txbxRelY.Text = "0";
            // 
            // txbxRelX
            // 
            this.txbxRelX.Location = new System.Drawing.Point(32, 19);
            this.txbxRelX.Name = "txbxRelX";
            this.txbxRelX.Size = new System.Drawing.Size(39, 20);
            this.txbxRelX.TabIndex = 0;
            this.txbxRelX.Text = "0";
            // 
            // gbPtzLock
            // 
            this.gbPtzLock.Controls.Add(this.lblExpireTime);
            this.gbPtzLock.Controls.Add(this.lblLockOwner);
            this.gbPtzLock.Controls.Add(this.btnLock);
            this.gbPtzLock.Controls.Add(this.btnRefreshLock);
            this.gbPtzLock.Location = new System.Drawing.Point(3, 266);
            this.gbPtzLock.Name = "gbPtzLock";
            this.gbPtzLock.Size = new System.Drawing.Size(226, 77);
            this.gbPtzLock.TabIndex = 56;
            this.gbPtzLock.TabStop = false;
            this.gbPtzLock.Text = "PTZ Lock";
            // 
            // lblExpireTime
            // 
            this.lblExpireTime.AutoSize = true;
            this.lblExpireTime.Location = new System.Drawing.Point(73, 53);
            this.lblExpireTime.Name = "lblExpireTime";
            this.lblExpireTime.Size = new System.Drawing.Size(47, 13);
            this.lblExpireTime.TabIndex = 12;
            this.lblExpireTime.Text = "Expires: ";
            // 
            // lblLockOwner
            // 
            this.lblLockOwner.AutoSize = true;
            this.lblLockOwner.Location = new System.Drawing.Point(76, 24);
            this.lblLockOwner.Name = "lblLockOwner";
            this.lblLockOwner.Size = new System.Drawing.Size(44, 13);
            this.lblLockOwner.TabIndex = 11;
            this.lblLockOwner.Text = "Owner: ";
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(6, 19);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(55, 23);
            this.btnLock.TabIndex = 10;
            this.btnLock.Text = "Lock";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.ButtonLockClick);
            // 
            // btnRefreshLock
            // 
            this.btnRefreshLock.Location = new System.Drawing.Point(6, 48);
            this.btnRefreshLock.Name = "btnRefreshLock";
            this.btnRefreshLock.Size = new System.Drawing.Size(55, 23);
            this.btnRefreshLock.TabIndex = 8;
            this.btnRefreshLock.Text = "Refresh";
            this.btnRefreshLock.UseVisualStyleBackColor = true;
            this.btnRefreshLock.Click += new System.EventHandler(this.ButtonRefreshLock_Click);
            // 
            // btnStopFocusSpeed
            // 
            this.btnStopFocusSpeed.Location = new System.Drawing.Point(104, 64);
            this.btnStopFocusSpeed.Name = "btnStopFocusSpeed";
            this.btnStopFocusSpeed.Size = new System.Drawing.Size(55, 23);
            this.btnStopFocusSpeed.TabIndex = 64;
            this.btnStopFocusSpeed.Text = "Stop";
            this.btnStopFocusSpeed.UseVisualStyleBackColor = true;
            this.btnStopFocusSpeed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StopPtz);
            // 
            // btnExecuteFocusSpeed
            // 
            this.btnExecuteFocusSpeed.Location = new System.Drawing.Point(165, 64);
            this.btnExecuteFocusSpeed.Name = "btnExecuteFocusSpeed";
            this.btnExecuteFocusSpeed.Size = new System.Drawing.Size(55, 23);
            this.btnExecuteFocusSpeed.TabIndex = 63;
            this.btnExecuteFocusSpeed.Text = "Execute";
            this.btnExecuteFocusSpeed.UseVisualStyleBackColor = true;
            this.btnExecuteFocusSpeed.Click += new System.EventHandler(this.ButtonExecute_Click);
            // 
            // gbFocusSpeed
            // 
            this.gbFocusSpeed.Controls.Add(this.nudFocusSpeed);
            this.gbFocusSpeed.Controls.Add(this.btnStopFocusSpeed);
            this.gbFocusSpeed.Controls.Add(this.lblFocusSpeedMax);
            this.gbFocusSpeed.Controls.Add(this.btnExecuteFocusSpeed);
            this.gbFocusSpeed.Controls.Add(this.lblFocusSpeedMin);
            this.gbFocusSpeed.Controls.Add(this.tbFocusSpeed);
            this.gbFocusSpeed.Location = new System.Drawing.Point(3, 87);
            this.gbFocusSpeed.Name = "gbFocusSpeed";
            this.gbFocusSpeed.Size = new System.Drawing.Size(226, 93);
            this.gbFocusSpeed.TabIndex = 75;
            this.gbFocusSpeed.TabStop = false;
            this.gbFocusSpeed.Text = "Focus At Speed";
            // 
            // nudFocusSpeed
            // 
            this.nudFocusSpeed.Location = new System.Drawing.Point(76, 39);
            this.nudFocusSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudFocusSpeed.Name = "nudFocusSpeed";
            this.nudFocusSpeed.Size = new System.Drawing.Size(75, 20);
            this.nudFocusSpeed.TabIndex = 62;
            this.nudFocusSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudFocusSpeed.ValueChanged += new System.EventHandler(this.NumericUpDownSpeed_ValueChanged);
            // 
            // lblFocusSpeedMax
            // 
            this.lblFocusSpeedMax.Location = new System.Drawing.Point(153, 37);
            this.lblFocusSpeedMax.Name = "lblFocusSpeedMax";
            this.lblFocusSpeedMax.Size = new System.Drawing.Size(60, 13);
            this.lblFocusSpeedMax.TabIndex = 60;
            this.lblFocusSpeedMax.Text = "0";
            this.lblFocusSpeedMax.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFocusSpeedMin
            // 
            this.lblFocusSpeedMin.Location = new System.Drawing.Point(14, 37);
            this.lblFocusSpeedMin.Name = "lblFocusSpeedMin";
            this.lblFocusSpeedMin.Size = new System.Drawing.Size(60, 13);
            this.lblFocusSpeedMin.TabIndex = 59;
            this.lblFocusSpeedMin.Text = "0";
            this.lblFocusSpeedMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbFocusSpeed
            // 
            this.tbFocusSpeed.Location = new System.Drawing.Point(31, 15);
            this.tbFocusSpeed.Minimum = -10;
            this.tbFocusSpeed.Name = "tbFocusSpeed";
            this.tbFocusSpeed.Size = new System.Drawing.Size(168, 45);
            this.tbFocusSpeed.TabIndex = 57;
            this.tbFocusSpeed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbFocusSpeed.Scroll += new System.EventHandler(this.TrackBarSpeed_Scroll);
            // 
            // gbIrisSpeed
            // 
            this.gbIrisSpeed.Controls.Add(this.nudIrisSpeed);
            this.gbIrisSpeed.Controls.Add(this.btnStopIrisSpeed);
            this.gbIrisSpeed.Controls.Add(this.lblIrisSpeedMax);
            this.gbIrisSpeed.Controls.Add(this.btnExecuteIrisSpeed);
            this.gbIrisSpeed.Controls.Add(this.lblIrisSpeedMin);
            this.gbIrisSpeed.Controls.Add(this.tbIrisSpeed);
            this.gbIrisSpeed.Location = new System.Drawing.Point(235, 87);
            this.gbIrisSpeed.Name = "gbIrisSpeed";
            this.gbIrisSpeed.Size = new System.Drawing.Size(226, 93);
            this.gbIrisSpeed.TabIndex = 76;
            this.gbIrisSpeed.TabStop = false;
            this.gbIrisSpeed.Text = "Iris At Speed";
            // 
            // nudIrisSpeed
            // 
            this.nudIrisSpeed.Location = new System.Drawing.Point(76, 39);
            this.nudIrisSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudIrisSpeed.Name = "nudIrisSpeed";
            this.nudIrisSpeed.Size = new System.Drawing.Size(75, 20);
            this.nudIrisSpeed.TabIndex = 62;
            this.nudIrisSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudIrisSpeed.ValueChanged += new System.EventHandler(this.NumericUpDownSpeed_ValueChanged);
            // 
            // btnStopIrisSpeed
            // 
            this.btnStopIrisSpeed.Location = new System.Drawing.Point(104, 64);
            this.btnStopIrisSpeed.Name = "btnStopIrisSpeed";
            this.btnStopIrisSpeed.Size = new System.Drawing.Size(55, 23);
            this.btnStopIrisSpeed.TabIndex = 64;
            this.btnStopIrisSpeed.Text = "Stop";
            this.btnStopIrisSpeed.UseVisualStyleBackColor = true;
            this.btnStopIrisSpeed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StopPtz);
            // 
            // lblIrisSpeedMax
            // 
            this.lblIrisSpeedMax.Location = new System.Drawing.Point(153, 37);
            this.lblIrisSpeedMax.Name = "lblIrisSpeedMax";
            this.lblIrisSpeedMax.Size = new System.Drawing.Size(60, 13);
            this.lblIrisSpeedMax.TabIndex = 60;
            this.lblIrisSpeedMax.Text = "0";
            this.lblIrisSpeedMax.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExecuteIrisSpeed
            // 
            this.btnExecuteIrisSpeed.Location = new System.Drawing.Point(165, 64);
            this.btnExecuteIrisSpeed.Name = "btnExecuteIrisSpeed";
            this.btnExecuteIrisSpeed.Size = new System.Drawing.Size(55, 23);
            this.btnExecuteIrisSpeed.TabIndex = 63;
            this.btnExecuteIrisSpeed.Text = "Execute";
            this.btnExecuteIrisSpeed.UseVisualStyleBackColor = true;
            this.btnExecuteIrisSpeed.Click += new System.EventHandler(this.ButtonExecute_Click);
            // 
            // lblIrisSpeedMin
            // 
            this.lblIrisSpeedMin.Location = new System.Drawing.Point(14, 37);
            this.lblIrisSpeedMin.Name = "lblIrisSpeedMin";
            this.lblIrisSpeedMin.Size = new System.Drawing.Size(60, 13);
            this.lblIrisSpeedMin.TabIndex = 59;
            this.lblIrisSpeedMin.Text = "0";
            this.lblIrisSpeedMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbIrisSpeed
            // 
            this.tbIrisSpeed.Location = new System.Drawing.Point(31, 15);
            this.tbIrisSpeed.Minimum = -10;
            this.tbIrisSpeed.Name = "tbIrisSpeed";
            this.tbIrisSpeed.Size = new System.Drawing.Size(168, 45);
            this.tbIrisSpeed.TabIndex = 57;
            this.tbIrisSpeed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbIrisSpeed.Scroll += new System.EventHandler(this.TrackBarSpeed_Scroll);
            // 
            // btnExpander
            // 
            this.btnExpander.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExpander.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExpander.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExpander.Location = new System.Drawing.Point(231, 143);
            this.btnExpander.Name = "btnExpander";
            this.btnExpander.Size = new System.Drawing.Size(16, 70);
            this.btnExpander.TabIndex = 78;
            this.btnExpander.Text = "▶";
            this.btnExpander.Click += new System.EventHandler(this.ButtonExpander_Click);
            // 
            // tlpAdvanced
            // 
            this.tlpAdvanced.AutoSize = true;
            this.tlpAdvanced.ColumnCount = 2;
            this.tlpAdvanced.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpAdvanced.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpAdvanced.Controls.Add(this.gbRelativeMove, 1, 0);
            this.tlpAdvanced.Controls.Add(this.gbAbsoluteMove, 0, 0);
            this.tlpAdvanced.Controls.Add(this.gbMoveSpeed, 0, 2);
            this.tlpAdvanced.Controls.Add(this.gbIrisSpeed, 1, 1);
            this.tlpAdvanced.Controls.Add(this.gbFocusSpeed, 0, 1);
            this.tlpAdvanced.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAdvanced.Location = new System.Drawing.Point(248, 0);
            this.tlpAdvanced.Margin = new System.Windows.Forms.Padding(0);
            this.tlpAdvanced.Name = "tlpAdvanced";
            this.tlpAdvanced.RowCount = 3;
            this.tlpAdvanced.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAdvanced.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAdvanced.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAdvanced.Size = new System.Drawing.Size(465, 348);
            this.tlpAdvanced.TabIndex = 78;
            this.tlpAdvanced.Visible = false;
            // 
            // gbMoveSpeed
            // 
            this.tlpAdvanced.SetColumnSpan(this.gbMoveSpeed, 2);
            this.gbMoveSpeed.Controls.Add(this.gbZoomSpeed);
            this.gbMoveSpeed.Controls.Add(this.btnStopSpeed);
            this.gbMoveSpeed.Controls.Add(this.gbTiltSpeed);
            this.gbMoveSpeed.Controls.Add(this.btnExecuteSpeed);
            this.gbMoveSpeed.Controls.Add(this.gbPanSpeed);
            this.gbMoveSpeed.Location = new System.Drawing.Point(3, 186);
            this.gbMoveSpeed.Name = "gbMoveSpeed";
            this.gbMoveSpeed.Size = new System.Drawing.Size(458, 159);
            this.gbMoveSpeed.TabIndex = 76;
            this.gbMoveSpeed.TabStop = false;
            this.gbMoveSpeed.Text = "Continuous Move At Speed";
            // 
            // gbZoomSpeed
            // 
            this.gbZoomSpeed.Controls.Add(this.nudZoomSpeed);
            this.gbZoomSpeed.Controls.Add(this.lblZoomSpeedMax);
            this.gbZoomSpeed.Controls.Add(this.lblZoomSpeedMin);
            this.gbZoomSpeed.Controls.Add(this.tbZoomSpeed);
            this.gbZoomSpeed.Location = new System.Drawing.Point(6, 85);
            this.gbZoomSpeed.Name = "gbZoomSpeed";
            this.gbZoomSpeed.Size = new System.Drawing.Size(211, 70);
            this.gbZoomSpeed.TabIndex = 77;
            this.gbZoomSpeed.TabStop = false;
            this.gbZoomSpeed.Text = "Zoom";
            // 
            // nudZoomSpeed
            // 
            this.nudZoomSpeed.Location = new System.Drawing.Point(68, 41);
            this.nudZoomSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudZoomSpeed.Name = "nudZoomSpeed";
            this.nudZoomSpeed.Size = new System.Drawing.Size(75, 20);
            this.nudZoomSpeed.TabIndex = 74;
            this.nudZoomSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudZoomSpeed.ValueChanged += new System.EventHandler(this.NumericUpDownSpeed_ValueChanged);
            // 
            // lblZoomSpeedMax
            // 
            this.lblZoomSpeedMax.Location = new System.Drawing.Point(145, 39);
            this.lblZoomSpeedMax.Name = "lblZoomSpeedMax";
            this.lblZoomSpeedMax.Size = new System.Drawing.Size(60, 13);
            this.lblZoomSpeedMax.TabIndex = 73;
            this.lblZoomSpeedMax.Text = "0";
            this.lblZoomSpeedMax.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblZoomSpeedMin
            // 
            this.lblZoomSpeedMin.Location = new System.Drawing.Point(3, 39);
            this.lblZoomSpeedMin.Name = "lblZoomSpeedMin";
            this.lblZoomSpeedMin.Size = new System.Drawing.Size(60, 13);
            this.lblZoomSpeedMin.TabIndex = 72;
            this.lblZoomSpeedMin.Text = "0";
            this.lblZoomSpeedMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbZoomSpeed
            // 
            this.tbZoomSpeed.Location = new System.Drawing.Point(23, 16);
            this.tbZoomSpeed.Minimum = -10;
            this.tbZoomSpeed.Name = "tbZoomSpeed";
            this.tbZoomSpeed.Size = new System.Drawing.Size(168, 45);
            this.tbZoomSpeed.TabIndex = 70;
            this.tbZoomSpeed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbZoomSpeed.Scroll += new System.EventHandler(this.TrackBarSpeed_Scroll);
            // 
            // btnStopSpeed
            // 
            this.btnStopSpeed.Location = new System.Drawing.Point(336, 130);
            this.btnStopSpeed.Name = "btnStopSpeed";
            this.btnStopSpeed.Size = new System.Drawing.Size(55, 23);
            this.btnStopSpeed.TabIndex = 64;
            this.btnStopSpeed.Text = "Stop";
            this.btnStopSpeed.UseVisualStyleBackColor = true;
            this.btnStopSpeed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StopPtz);
            // 
            // gbTiltSpeed
            // 
            this.gbTiltSpeed.Controls.Add(this.nudTiltSpeed);
            this.gbTiltSpeed.Controls.Add(this.lblTiltSpeedMax);
            this.gbTiltSpeed.Controls.Add(this.lblTiltSpeedMin);
            this.gbTiltSpeed.Controls.Add(this.tbTiltSpeed);
            this.gbTiltSpeed.Location = new System.Drawing.Point(238, 15);
            this.gbTiltSpeed.Name = "gbTiltSpeed";
            this.gbTiltSpeed.Size = new System.Drawing.Size(211, 70);
            this.gbTiltSpeed.TabIndex = 77;
            this.gbTiltSpeed.TabStop = false;
            this.gbTiltSpeed.Text = "Tilt";
            // 
            // nudTiltSpeed
            // 
            this.nudTiltSpeed.Location = new System.Drawing.Point(68, 42);
            this.nudTiltSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudTiltSpeed.Name = "nudTiltSpeed";
            this.nudTiltSpeed.Size = new System.Drawing.Size(75, 20);
            this.nudTiltSpeed.TabIndex = 69;
            this.nudTiltSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTiltSpeed.ValueChanged += new System.EventHandler(this.NumericUpDownSpeed_ValueChanged);
            // 
            // lblTiltSpeedMax
            // 
            this.lblTiltSpeedMax.Location = new System.Drawing.Point(145, 39);
            this.lblTiltSpeedMax.Name = "lblTiltSpeedMax";
            this.lblTiltSpeedMax.Size = new System.Drawing.Size(60, 13);
            this.lblTiltSpeedMax.TabIndex = 68;
            this.lblTiltSpeedMax.Text = "0";
            this.lblTiltSpeedMax.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTiltSpeedMin
            // 
            this.lblTiltSpeedMin.Location = new System.Drawing.Point(3, 39);
            this.lblTiltSpeedMin.Name = "lblTiltSpeedMin";
            this.lblTiltSpeedMin.Size = new System.Drawing.Size(60, 13);
            this.lblTiltSpeedMin.TabIndex = 67;
            this.lblTiltSpeedMin.Text = "0";
            this.lblTiltSpeedMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbTiltSpeed
            // 
            this.tbTiltSpeed.Location = new System.Drawing.Point(20, 16);
            this.tbTiltSpeed.Minimum = -10;
            this.tbTiltSpeed.Name = "tbTiltSpeed";
            this.tbTiltSpeed.Size = new System.Drawing.Size(171, 45);
            this.tbTiltSpeed.TabIndex = 65;
            this.tbTiltSpeed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbTiltSpeed.Scroll += new System.EventHandler(this.TrackBarSpeed_Scroll);
            // 
            // btnExecuteSpeed
            // 
            this.btnExecuteSpeed.Location = new System.Drawing.Point(397, 130);
            this.btnExecuteSpeed.Name = "btnExecuteSpeed";
            this.btnExecuteSpeed.Size = new System.Drawing.Size(55, 23);
            this.btnExecuteSpeed.TabIndex = 63;
            this.btnExecuteSpeed.Text = "Execute";
            this.btnExecuteSpeed.UseVisualStyleBackColor = true;
            this.btnExecuteSpeed.Click += new System.EventHandler(this.ButtonExecute_Click);
            // 
            // gbPanSpeed
            // 
            this.gbPanSpeed.Controls.Add(this.nudPanSpeed);
            this.gbPanSpeed.Controls.Add(this.lblPanSpeedMax);
            this.gbPanSpeed.Controls.Add(this.lblPanSpeedMin);
            this.gbPanSpeed.Controls.Add(this.tbPanSpeed);
            this.gbPanSpeed.Location = new System.Drawing.Point(6, 15);
            this.gbPanSpeed.Name = "gbPanSpeed";
            this.gbPanSpeed.Size = new System.Drawing.Size(211, 70);
            this.gbPanSpeed.TabIndex = 75;
            this.gbPanSpeed.TabStop = false;
            this.gbPanSpeed.Text = "Pan";
            // 
            // nudPanSpeed
            // 
            this.nudPanSpeed.Location = new System.Drawing.Point(68, 39);
            this.nudPanSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudPanSpeed.Name = "nudPanSpeed";
            this.nudPanSpeed.Size = new System.Drawing.Size(75, 20);
            this.nudPanSpeed.TabIndex = 62;
            this.nudPanSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPanSpeed.ValueChanged += new System.EventHandler(this.NumericUpDownSpeed_ValueChanged);
            // 
            // lblPanSpeedMax
            // 
            this.lblPanSpeedMax.Location = new System.Drawing.Point(145, 37);
            this.lblPanSpeedMax.Name = "lblPanSpeedMax";
            this.lblPanSpeedMax.Size = new System.Drawing.Size(60, 13);
            this.lblPanSpeedMax.TabIndex = 60;
            this.lblPanSpeedMax.Text = "0";
            this.lblPanSpeedMax.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPanSpeedMin
            // 
            this.lblPanSpeedMin.Location = new System.Drawing.Point(6, 37);
            this.lblPanSpeedMin.Name = "lblPanSpeedMin";
            this.lblPanSpeedMin.Size = new System.Drawing.Size(60, 13);
            this.lblPanSpeedMin.TabIndex = 59;
            this.lblPanSpeedMin.Text = "0";
            this.lblPanSpeedMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbPanSpeed
            // 
            this.tbPanSpeed.Location = new System.Drawing.Point(23, 15);
            this.tbPanSpeed.Minimum = -10;
            this.tbPanSpeed.Name = "tbPanSpeed";
            this.tbPanSpeed.Size = new System.Drawing.Size(168, 45);
            this.tbPanSpeed.TabIndex = 57;
            this.tbPanSpeed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbPanSpeed.Scroll += new System.EventHandler(this.TrackBarSpeed_Scroll);
            // 
            // pnlMainControls
            // 
            this.pnlMainControls.Controls.Add(this.btnPtzUL);
            this.pnlMainControls.Controls.Add(this.btnExpander);
            this.pnlMainControls.Controls.Add(this.lblZoom);
            this.pnlMainControls.Controls.Add(this.btnPtzU);
            this.pnlMainControls.Controls.Add(this.btnPtzZoomIn);
            this.pnlMainControls.Controls.Add(this.btnPtzZoomOut);
            this.pnlMainControls.Controls.Add(this.btnPtzL);
            this.pnlMainControls.Controls.Add(this.lblFocus);
            this.pnlMainControls.Controls.Add(this.btnPtzIrisOpen);
            this.pnlMainControls.Controls.Add(this.btnPtzR);
            this.pnlMainControls.Controls.Add(this.btnPtzUR);
            this.pnlMainControls.Controls.Add(this.gbPtzLock);
            this.pnlMainControls.Controls.Add(this.gbPresets);
            this.pnlMainControls.Controls.Add(this.btnPtzFocusFar);
            this.pnlMainControls.Controls.Add(this.lblIris);
            this.pnlMainControls.Controls.Add(this.btnPtzD);
            this.pnlMainControls.Controls.Add(this.btnPtzFocusNear);
            this.pnlMainControls.Controls.Add(this.btnPtzIrisClose);
            this.pnlMainControls.Controls.Add(this.btnPtzDL);
            this.pnlMainControls.Controls.Add(this.btnPtzDR);
            this.pnlMainControls.Controls.Add(this.gbPatterns);
            this.pnlMainControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainControls.Location = new System.Drawing.Point(0, 0);
            this.pnlMainControls.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMainControls.Name = "pnlMainControls";
            this.pnlMainControls.Size = new System.Drawing.Size(248, 348);
            this.pnlMainControls.TabIndex = 79;
            // 
            // tlpMainWindow
            // 
            this.tlpMainWindow.AutoSize = true;
            this.tlpMainWindow.ColumnCount = 2;
            this.tlpMainWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMainWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMainWindow.Controls.Add(this.pnlMainControls, 0, 0);
            this.tlpMainWindow.Controls.Add(this.tlpAdvanced, 1, 0);
            this.tlpMainWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainWindow.Location = new System.Drawing.Point(0, 0);
            this.tlpMainWindow.Name = "tlpMainWindow";
            this.tlpMainWindow.RowCount = 1;
            this.tlpMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMainWindow.Size = new System.Drawing.Size(713, 344);
            this.tlpMainWindow.TabIndex = 80;
            // 
            // txbxAbsZ
            // 
            this.txbxAbsZ.Location = new System.Drawing.Point(178, 19);
            this.txbxAbsZ.Name = "txbxAbsZ";
            this.txbxAbsZ.Size = new System.Drawing.Size(39, 20);
            this.txbxAbsZ.TabIndex = 2;
            // 
            // txbxAbsY
            // 
            this.txbxAbsY.Location = new System.Drawing.Point(105, 19);
            this.txbxAbsY.Name = "txbxAbsY";
            this.txbxAbsY.Size = new System.Drawing.Size(39, 20);
            this.txbxAbsY.TabIndex = 1;
            // 
            // txbxAbsX
            // 
            this.txbxAbsX.Location = new System.Drawing.Point(32, 19);
            this.txbxAbsX.Name = "txbxAbsX";
            this.txbxAbsX.Size = new System.Drawing.Size(39, 20);
            this.txbxAbsX.TabIndex = 0;
            // 
            // PtzControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(713, 344);
            this.Controls.Add(this.tlpMainWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "PtzControlForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PTZ Control";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.gbPatterns.ResumeLayout(false);
            this.gbPresets.ResumeLayout(false);
            this.gbAbsoluteMove.ResumeLayout(false);
            this.gbAbsoluteMove.PerformLayout();
            this.gbRelativeMove.ResumeLayout(false);
            this.gbRelativeMove.PerformLayout();
            this.gbPtzLock.ResumeLayout(false);
            this.gbPtzLock.PerformLayout();
            this.gbFocusSpeed.ResumeLayout(false);
            this.gbFocusSpeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFocusSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFocusSpeed)).EndInit();
            this.gbIrisSpeed.ResumeLayout(false);
            this.gbIrisSpeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIrisSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbIrisSpeed)).EndInit();
            this.tlpAdvanced.ResumeLayout(false);
            this.gbMoveSpeed.ResumeLayout(false);
            this.gbZoomSpeed.ResumeLayout(false);
            this.gbZoomSpeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudZoomSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoomSpeed)).EndInit();
            this.gbTiltSpeed.ResumeLayout(false);
            this.gbTiltSpeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTiltSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTiltSpeed)).EndInit();
            this.gbPanSpeed.ResumeLayout(false);
            this.gbPanSpeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPanSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPanSpeed)).EndInit();
            this.pnlMainControls.ResumeLayout(false);
            this.pnlMainControls.PerformLayout();
            this.tlpMainWindow.ResumeLayout(false);
            this.tlpMainWindow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPatterns;
        private System.Windows.Forms.ComboBox cbxPatterns;
        private System.Windows.Forms.Button btnTriggerPattern;
        private System.Windows.Forms.GroupBox gbPresets;
        private System.Windows.Forms.ComboBox cbxPresets;
        private System.Windows.Forms.Button btnTriggerPreset;
        private System.Windows.Forms.Button btnPtzZoomOut;
        private System.Windows.Forms.Button btnPtzZoomIn;
        private System.Windows.Forms.Button btnPtzUR;
        private System.Windows.Forms.Button btnPtzUL;
        private System.Windows.Forms.Button btnPtzDL;
        private System.Windows.Forms.Button btnPtzDR;
        private System.Windows.Forms.Button btnPtzD;
        private System.Windows.Forms.Button btnPtzR;
        private System.Windows.Forms.Button btnPtzL;
        private System.Windows.Forms.Button btnPtzU;
        private Button btnPtzFocusFar;
        private Button btnPtzIrisClose;
        private Button btnPtzIrisOpen;
        private Button btnPtzFocusNear;
        private Label lblZoom;
        private Label lblFocus;
        private Label lblIris;
        private GroupBox gbAbsoluteMove;
        private Label lblAbsZ;
        private Label lblAbsY;
        private Label lblAbsX;
        private Button btnSetPosition;
        private Button btnGetPosition;
        private GroupBox gbRelativeMove;
        private Button btnMove;
        private Label lblRelZ;
        private Label lblRelY;
        private Label lblRelX;
        private TextBox txbxRelZ;
        private TextBox txbxRelY;
        private Button btnStop;
        private TextBox txbxRelX;
        private GroupBox gbPtzLock;
        private Button btnLock;
        private Button btnRefreshLock;
        private Label lblExpireTime;
        private Label lblLockOwner;
        private Button btnNewPreset;
        private Button btnDeletePreset;
        private Button btnRepositionPreset;
        private Button btnStopFocusSpeed;
        private Button btnExecuteFocusSpeed;
        private GroupBox gbFocusSpeed;
        private NumericUpDown nudFocusSpeed;
        private Label lblFocusSpeedMax;
        private Label lblFocusSpeedMin;
        private TrackBar tbFocusSpeed;
        private GroupBox gbIrisSpeed;
        private NumericUpDown nudIrisSpeed;
        private Button btnStopIrisSpeed;
        private Label lblIrisSpeedMax;
        private Button btnExecuteIrisSpeed;
        private Label lblIrisSpeedMin;
        private TrackBar tbIrisSpeed;
        private Button btnExpander;
        private TableLayoutPanel tlpAdvanced;
        private GroupBox gbMoveSpeed;
        private GroupBox gbZoomSpeed;
        private NumericUpDown nudZoomSpeed;
        private Label lblZoomSpeedMax;
        private Label lblZoomSpeedMin;
        private TrackBar tbZoomSpeed;
        private Button btnStopSpeed;
        private GroupBox gbTiltSpeed;
        private NumericUpDown nudTiltSpeed;
        private Label lblTiltSpeedMax;
        private Label lblTiltSpeedMin;
        private TrackBar tbTiltSpeed;
        private Button btnExecuteSpeed;
        private GroupBox gbPanSpeed;
        private NumericUpDown nudPanSpeed;
        private Label lblPanSpeedMax;
        private Label lblPanSpeedMin;
        private TrackBar tbPanSpeed;
        private Panel pnlMainControls;
        private TableLayoutPanel tlpMainWindow;
        private TextBox txbxAbsZ;
        private TextBox txbxAbsY;
        private TextBox txbxAbsX;
    }
}