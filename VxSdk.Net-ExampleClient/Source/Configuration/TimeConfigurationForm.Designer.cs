namespace ExampleClient.Source
{
    partial class TimeConfigurationForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.cbxTimeZone = new System.Windows.Forms.ComboBox();
            this.gbxExternalTimeServers = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lvExternalTimeServers = new System.Windows.Forms.ListView();
            this.chHost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxTimeZone = new System.Windows.Forms.GroupBox();
            this.gbxTimeServerSource = new System.Windows.Forms.GroupBox();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.gbxExternalTimeServers.SuspendLayout();
            this.gbxTimeZone.SuspendLayout();
            this.gbxTimeServerSource.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(181, 382);
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
            this.btnCancel.Location = new System.Drawing.Point(100, 382);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbxTimeZone
            // 
            this.cbxTimeZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTimeZone.FormattingEnabled = true;
            this.cbxTimeZone.Location = new System.Drawing.Point(6, 19);
            this.cbxTimeZone.Name = "cbxTimeZone";
            this.cbxTimeZone.Size = new System.Drawing.Size(238, 21);
            this.cbxTimeZone.TabIndex = 32;
            // 
            // gbxExternalTimeServers
            // 
            this.gbxExternalTimeServers.Controls.Add(this.btnDelete);
            this.gbxExternalTimeServers.Controls.Add(this.btnEdit);
            this.gbxExternalTimeServers.Controls.Add(this.lvExternalTimeServers);
            this.gbxExternalTimeServers.Controls.Add(this.btnAdd);
            this.gbxExternalTimeServers.Location = new System.Drawing.Point(6, 134);
            this.gbxExternalTimeServers.Name = "gbxExternalTimeServers";
            this.gbxExternalTimeServers.Size = new System.Drawing.Size(250, 242);
            this.gbxExternalTimeServers.TabIndex = 36;
            this.gbxExternalTimeServers.TabStop = false;
            this.gbxExternalTimeServers.Text = "External Time Servers";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(169, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(88, 19);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 34;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // lvExternalTimeServers
            // 
            this.lvExternalTimeServers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chHost});
            this.lvExternalTimeServers.HideSelection = false;
            this.lvExternalTimeServers.Location = new System.Drawing.Point(7, 53);
            this.lvExternalTimeServers.Name = "lvExternalTimeServers";
            this.lvExternalTimeServers.Size = new System.Drawing.Size(237, 183);
            this.lvExternalTimeServers.TabIndex = 3;
            this.lvExternalTimeServers.UseCompatibleStateImageBehavior = false;
            this.lvExternalTimeServers.View = System.Windows.Forms.View.Details;
            // 
            // chHost
            // 
            this.chHost.Text = "Host Address";
            this.chHost.Width = 233;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // gbxTimeZone
            // 
            this.gbxTimeZone.Controls.Add(this.cbxTimeZone);
            this.gbxTimeZone.Location = new System.Drawing.Point(6, 73);
            this.gbxTimeZone.Name = "gbxTimeZone";
            this.gbxTimeZone.Size = new System.Drawing.Size(250, 55);
            this.gbxTimeZone.TabIndex = 37;
            this.gbxTimeZone.TabStop = false;
            this.gbxTimeZone.Text = "Time Zone";
            // 
            // gbxTimeServerSource
            // 
            this.gbxTimeServerSource.Controls.Add(this.rbNone);
            this.gbxTimeServerSource.Controls.Add(this.rbManual);
            this.gbxTimeServerSource.Controls.Add(this.rbAuto);
            this.gbxTimeServerSource.Location = new System.Drawing.Point(6, 12);
            this.gbxTimeServerSource.Name = "gbxTimeServerSource";
            this.gbxTimeServerSource.Size = new System.Drawing.Size(250, 55);
            this.gbxTimeServerSource.TabIndex = 38;
            this.gbxTimeServerSource.TabStop = false;
            this.gbxTimeServerSource.Text = "Time Server Source";
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Location = new System.Drawing.Point(193, 23);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(51, 17);
            this.rbNone.TabIndex = 2;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            this.rbNone.CheckedChanged += new System.EventHandler(this.RadioButtonSourceType_CheckedChanged);
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Location = new System.Drawing.Point(98, 23);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(60, 17);
            this.rbManual.TabIndex = 1;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Manual";
            this.rbManual.UseVisualStyleBackColor = true;
            this.rbManual.CheckedChanged += new System.EventHandler(this.RadioButtonSourceType_CheckedChanged);
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.Location = new System.Drawing.Point(16, 23);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Size = new System.Drawing.Size(47, 17);
            this.rbAuto.TabIndex = 0;
            this.rbAuto.TabStop = true;
            this.rbAuto.Text = "Auto";
            this.rbAuto.UseVisualStyleBackColor = true;
            this.rbAuto.CheckedChanged += new System.EventHandler(this.RadioButtonSourceType_CheckedChanged);
            // 
            // TimeConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 411);
            this.Controls.Add(this.gbxTimeServerSource);
            this.Controls.Add(this.gbxTimeZone);
            this.Controls.Add(this.gbxExternalTimeServers);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimeConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Time Configuration";
            this.gbxExternalTimeServers.ResumeLayout(false);
            this.gbxTimeZone.ResumeLayout(false);
            this.gbxTimeServerSource.ResumeLayout(false);
            this.gbxTimeServerSource.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ComboBox cbxTimeZone;
        private System.Windows.Forms.GroupBox gbxExternalTimeServers;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ListView lvExternalTimeServers;
        private System.Windows.Forms.ColumnHeader chHost;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxTimeZone;
        private System.Windows.Forms.GroupBox gbxTimeServerSource;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.RadioButton rbAuto;
    }
}