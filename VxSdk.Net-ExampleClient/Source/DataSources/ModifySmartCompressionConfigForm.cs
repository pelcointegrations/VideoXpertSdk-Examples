using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The ModifySmartCompressionConfigForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to modify the smart compression config for a data source.</remarks>
    public partial class ModifySmartCompressionConfigForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifySmartCompressionConfigForm" /> class.
        /// </summary>
        /// <param name="smartCompressionConfig">The <paramref name="smartCompressionConfig"/> parameter.</param>
        public ModifySmartCompressionConfigForm(DataSourceConfig.SmartCompression smartCompressionConfig)
        {
            InitializeComponent();
            SelectedSmartCompressionConfig = smartCompressionConfig;
            switch (smartCompressionConfig.Level)
            {
                case DataSourceConfig.SmartCompressionLevel.High:
                    cbxLevel.SelectedIndex = 3;
                    break;
                case DataSourceConfig.SmartCompressionLevel.Low:
                    cbxLevel.SelectedIndex = 1;
                    break;
                case DataSourceConfig.SmartCompressionLevel.Medium:
                    cbxLevel.SelectedIndex = 2;
                    break;
                default:
                    cbxLevel.SelectedIndex = 0;
                    break;
            }

            Height = 160;
            foreach (var integerLimit in smartCompressionConfig.Limits.IntegerLimits)
            {
                if (integerLimit.FieldName.ToLower().Contains("primary"))
                    SetLimit(ckbxPrimary, lblPrimary, nudPrimary, smartCompressionConfig.PrimaryDynamicGop, integerLimit);
                else if (integerLimit.FieldName.ToLower().Contains("secondary"))
                    SetLimit(ckbxSecondary, lblSecondary, nudSecondary, smartCompressionConfig.SecondaryDynamicGop, integerLimit);
                else if (integerLimit.FieldName.ToLower().Contains("tertiary"))
                    SetLimit(ckbxTertiary, lblTertiary, nudTertiary, smartCompressionConfig.TertiaryDynamicGop, integerLimit);
                else if (integerLimit.FieldName.ToLower().Contains("quaternary"))
                    SetLimit(ckbxQuaternary, lblQuaternary, nudQuaternary, smartCompressionConfig.QuaternaryDynamicGop, integerLimit);
                else if (integerLimit.FieldName.ToLower().Contains("quinary"))
                    SetLimit(ckbxQuinary, lblQuinary, nudQuinary, smartCompressionConfig.QuinaryDynamicGop, integerLimit);
                else if (integerLimit.FieldName.ToLower().Contains("senary"))
                    SetLimit(ckbxSenary, lblSenary, nudSenary, smartCompressionConfig.SenaryDynamicGop, integerLimit);
                else if (integerLimit.FieldName.ToLower().Contains("septenary"))
                    SetLimit(ckbxSeptenary, lblSeptenary, nudSeptenary, smartCompressionConfig.SeptenaryDynamicGop, integerLimit);
                else if (integerLimit.FieldName.ToLower().Contains("octonary"))
                    SetLimit(ckbxOctonary, lblOctonary, nudOctonary, smartCompressionConfig.OctonaryDynamicGop, integerLimit);
                else if (integerLimit.FieldName.ToLower().Contains("nonary"))
                    SetLimit(ckbxNonary, lblNonary, nudNonary, smartCompressionConfig.NonaryDynamicGop, integerLimit);
                else if (integerLimit.FieldName.ToLower().Contains("denary"))
                    SetLimit(ckbxDenary, lblDenary, nudDenary, smartCompressionConfig.DenaryDynamicGop, integerLimit);
            }
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Gets or sets the SelectedSmartCompressionConfig property.
        /// </summary>
        /// <value>The currently selected smart compression config.</value>
        private DataSourceConfig.SmartCompression SelectedSmartCompressionConfig { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonSave_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            if (cbxLevel.SelectedIndex == 0 && SelectedSmartCompressionConfig.Level != DataSourceConfig.SmartCompressionLevel.Disabled)
                SelectedSmartCompressionConfig.Level = DataSourceConfig.SmartCompressionLevel.Disabled;
            else if (cbxLevel.SelectedIndex == 1 && SelectedSmartCompressionConfig.Level != DataSourceConfig.SmartCompressionLevel.Low)
                SelectedSmartCompressionConfig.Level = DataSourceConfig.SmartCompressionLevel.Low;
            else if (cbxLevel.SelectedIndex == 2 && SelectedSmartCompressionConfig.Level != DataSourceConfig.SmartCompressionLevel.Medium)
                SelectedSmartCompressionConfig.Level = DataSourceConfig.SmartCompressionLevel.Medium;
            else if (cbxLevel.SelectedIndex == 3 && SelectedSmartCompressionConfig.Level != DataSourceConfig.SmartCompressionLevel.High)
                SelectedSmartCompressionConfig.Level = DataSourceConfig.SmartCompressionLevel.High;

            if (cbxLevel.SelectedIndex <= 0)
                return;

            if (ckbxPrimary.Visible && !ckbxPrimary.Checked && SelectedSmartCompressionConfig.PrimaryDynamicGop > 0)
                SelectedSmartCompressionConfig.PrimaryDynamicGop = 0;
            else if (ckbxPrimary.Checked && nudPrimary.Value != SelectedSmartCompressionConfig.PrimaryDynamicGop)
                SelectedSmartCompressionConfig.PrimaryDynamicGop = (int) nudPrimary.Value;

            if (ckbxSecondary.Visible && !ckbxSecondary.Checked && SelectedSmartCompressionConfig.SecondaryDynamicGop > 0)
                SelectedSmartCompressionConfig.SecondaryDynamicGop = 0;
            else if (ckbxSecondary.Checked && nudSecondary.Value != SelectedSmartCompressionConfig.SecondaryDynamicGop)
                SelectedSmartCompressionConfig.SecondaryDynamicGop = (int) nudSecondary.Value;

            if (ckbxTertiary.Visible && !ckbxTertiary.Checked && SelectedSmartCompressionConfig.TertiaryDynamicGop > 0)
                SelectedSmartCompressionConfig.TertiaryDynamicGop = 0;
            else if (ckbxTertiary.Checked && nudTertiary.Value != SelectedSmartCompressionConfig.TertiaryDynamicGop)
                SelectedSmartCompressionConfig.TertiaryDynamicGop = (int) nudTertiary.Value;

            if (ckbxQuaternary.Visible && !ckbxQuaternary.Checked && SelectedSmartCompressionConfig.QuaternaryDynamicGop > 0)
                SelectedSmartCompressionConfig.QuaternaryDynamicGop = 0;
            else if (ckbxQuaternary.Checked && nudQuaternary.Value != SelectedSmartCompressionConfig.QuaternaryDynamicGop)
                SelectedSmartCompressionConfig.QuaternaryDynamicGop = (int) nudQuaternary.Value;

            if (ckbxQuinary.Visible && !ckbxQuinary.Checked && SelectedSmartCompressionConfig.QuinaryDynamicGop > 0)
                SelectedSmartCompressionConfig.QuinaryDynamicGop = 0;
            else if (ckbxQuinary.Checked && nudQuinary.Value != SelectedSmartCompressionConfig.QuinaryDynamicGop)
                SelectedSmartCompressionConfig.QuinaryDynamicGop = (int) nudQuinary.Value;

            if (ckbxSenary.Visible && !ckbxSenary.Checked && SelectedSmartCompressionConfig.SenaryDynamicGop > 0)
                SelectedSmartCompressionConfig.SenaryDynamicGop = 0;
            else if (ckbxSenary.Checked && nudSenary.Value != SelectedSmartCompressionConfig.SenaryDynamicGop)
                SelectedSmartCompressionConfig.SenaryDynamicGop = (int) nudSenary.Value;

            if (ckbxSeptenary.Visible && !ckbxSeptenary.Checked && SelectedSmartCompressionConfig.SeptenaryDynamicGop > 0)
                SelectedSmartCompressionConfig.SeptenaryDynamicGop = 0;
            else if (ckbxSeptenary.Checked && nudSeptenary.Value != SelectedSmartCompressionConfig.SeptenaryDynamicGop)
                SelectedSmartCompressionConfig.SeptenaryDynamicGop = (int) nudSeptenary.Value;

            if (ckbxOctonary.Visible && !ckbxOctonary.Checked && SelectedSmartCompressionConfig.OctonaryDynamicGop > 0)
                SelectedSmartCompressionConfig.OctonaryDynamicGop = 0;
            else if (ckbxOctonary.Checked && nudOctonary.Value != SelectedSmartCompressionConfig.OctonaryDynamicGop)
                SelectedSmartCompressionConfig.OctonaryDynamicGop = (int) nudOctonary.Value;

            if (ckbxNonary.Visible && !ckbxNonary.Checked && SelectedSmartCompressionConfig.NonaryDynamicGop > 0)
                SelectedSmartCompressionConfig.NonaryDynamicGop = 0;
            else if (ckbxNonary.Checked && nudNonary.Value != SelectedSmartCompressionConfig.NonaryDynamicGop)
                SelectedSmartCompressionConfig.NonaryDynamicGop = (int) nudNonary.Value;

            if (ckbxDenary.Visible && !ckbxDenary.Checked && SelectedSmartCompressionConfig.DenaryDynamicGop > 0)
                SelectedSmartCompressionConfig.DenaryDynamicGop = 0;
            else if (ckbxDenary.Checked && nudDenary.Value != SelectedSmartCompressionConfig.DenaryDynamicGop)
                SelectedSmartCompressionConfig.DenaryDynamicGop = (int) nudDenary.Value;
        }

        /// <summary>
        /// The CheckboxEnabled_CheckedChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void CheckboxEnabled_CheckedChanged(object sender, EventArgs args)
        {
            var checkbox = sender as CheckBox;
            if (checkbox == null)
                return;

            if (checkbox.Name.ToLower().Contains("primary"))
                lblPrimary.Visible = nudPrimary.Visible = checkbox.Checked;
            else if (checkbox.Name.ToLower().Contains("secondary"))
                lblSecondary.Visible = nudSecondary.Visible = checkbox.Checked;
            else if (checkbox.Name.ToLower().Contains("tertiary"))
                lblTertiary.Visible = nudTertiary.Visible = checkbox.Checked;
            else if (checkbox.Name.ToLower().Contains("quaternary"))
                lblQuaternary.Visible = nudQuaternary.Visible = checkbox.Checked;
            else if (checkbox.Name.ToLower().Contains("quinary"))
                lblQuinary.Visible = nudQuinary.Visible = checkbox.Checked;
            else if (checkbox.Name.ToLower().Contains("senary"))
                lblSenary.Visible = nudSenary.Visible = checkbox.Checked;
            else if (checkbox.Name.ToLower().Contains("septenary"))
                lblSeptenary.Visible = nudSeptenary.Visible = checkbox.Checked;
            else if (checkbox.Name.ToLower().Contains("octonary"))
                lblOctonary.Visible = nudOctonary.Visible = checkbox.Checked;
            else if (checkbox.Name.ToLower().Contains("nonary"))
                lblNonary.Visible = nudNonary.Visible = checkbox.Checked;
            else if (checkbox.Name.ToLower().Contains("denary"))
                lblDenary.Visible = nudDenary.Visible = checkbox.Checked;
        }

        /// <summary>
        /// The ComboboxLevel_SelectedIndexChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ComboboxLevel_SelectedIndexChanged(object sender, EventArgs args)
        {
            lblPrimary.Enabled = nudPrimary.Enabled = ckbxPrimary.Enabled = cbxLevel.SelectedIndex > 0;
            lblSecondary.Enabled = nudSecondary.Enabled = ckbxSecondary.Enabled = cbxLevel.SelectedIndex > 0;
            lblTertiary.Enabled = nudTertiary.Enabled = ckbxTertiary.Enabled = cbxLevel.SelectedIndex > 0;
            lblQuaternary.Enabled = nudQuaternary.Enabled = ckbxQuaternary.Enabled = cbxLevel.SelectedIndex > 0;
            lblQuinary.Enabled = nudQuinary.Enabled = ckbxQuinary.Enabled = cbxLevel.SelectedIndex > 0;
            lblSenary.Enabled = nudSenary.Enabled = ckbxSenary.Enabled = cbxLevel.SelectedIndex > 0;
            lblSeptenary.Enabled = nudSeptenary.Enabled = ckbxSeptenary.Enabled = cbxLevel.SelectedIndex > 0;
            lblOctonary.Enabled = nudOctonary.Enabled = ckbxOctonary.Enabled = cbxLevel.SelectedIndex > 0;
            lblNonary.Enabled = nudNonary.Enabled = ckbxNonary.Enabled = cbxLevel.SelectedIndex > 0;
            lblDenary.Enabled = nudDenary.Enabled = ckbxDenary.Enabled = cbxLevel.SelectedIndex > 0;
        }

        /// <summary>
        /// The SetLimit method.
        /// </summary>
        /// <param name="checkbox">The <paramref name="checkbox"/> parameter.</param>
        /// <param name="label">The <paramref name="label"/> parameter.</param>
        /// <param name="nud">The <paramref name="nud"/> parameter.</param>
        /// <param name="gop">The <paramref name="gop"/> parameter.</param>
        /// <param name="integerLimit">The <paramref name="integerLimit"/> parameter.</param>
        private void SetLimit(CheckBox checkbox, Label label, NumericUpDown nud, int gop, ResourceLimits.IntegerLimit integerLimit)
        {
            checkbox.Visible = true;
            label.Visible = nud.Visible = checkbox.Checked = gop > 0;
            if (gop < integerLimit.MinValue || gop > integerLimit.MaxValue)
                nud.Value = integerLimit.MinValue;
            else
                nud.Value = gop;

            nud.Minimum = integerLimit.MinValue;
            nud.Maximum = integerLimit.MaxValue;
            this.Height += 48;
        }

        #endregion Private Methods
    }
}