using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExampleClient.Source
{
    /// <summary>
    /// The InputBox class.
    /// </summary>
    /// <remarks>Provides a reusable dialog window for entering a numeric value.</remarks>
    public static class InputBox
    {
        #region Public Methods

        /// <summary>
        /// The Show method.
        /// </summary>
        /// <param name="title">The title of the dialog window.</param>
        /// <param name="prompt">The text to show inside of the dialog window.</param>
        /// <param name="value">The value entered.</param>
        /// <param name="min">The minimum value that can be entered.</param>
        /// <param name="max">The max value that can be entered.</param>
        /// <returns>The result of the dialog.</returns>
        public static DialogResult Show(string title, string prompt, ref decimal value, int min = 0, int max = 100)
        {
            var form = new Form();
            var label = new Label();
            var numericUpDown = new NumericUpDown();
            var buttonOk = new Button();
            var buttonCancel = new Button();

            form.Text = title;
            label.Text = prompt;
            numericUpDown.Minimum = min;
            numericUpDown.Maximum = max;
            numericUpDown.Value = value;

            buttonOk.Text = @"OK";
            buttonCancel.Text = @"Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            if (prompt.Contains("\n"))
            {
                label.SetBounds(9, 10, 372, 26);
                numericUpDown.SetBounds(12, 50, 372, 20);
            }
            else
            {
                label.SetBounds(9, 20, 372, 13);
                numericUpDown.SetBounds(12, 36, 372, 20);
            }

            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            numericUpDown.Anchor = numericUpDown.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, numericUpDown, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            var dialogResult = form.ShowDialog();
            value = numericUpDown.Value;
            return dialogResult;
        }

        /// <summary>
        /// The Show method.
        /// </summary>
        /// <param name="title">The title of the dialog window.</param>
        /// <param name="label1">The label for the first value.</param>
        /// <param name="label2">The label for the second value.</param>
        /// <param name="value1">The first value entered.</param>
        /// <param name="value2">The seconds value entered.</param>
        /// <param name="min">The minimum value that can be entered.</param>
        /// <param name="max">The max value that can be entered.</param>
        /// <returns>The result of the dialog.</returns>
        public static DialogResult Show(string title, string label1, string label2, ref decimal value1, ref decimal value2, int min = 0, int max = 100)
        {
            var form = new Form();
            var valueLabel1 = new Label();
            var valueLabel2 = new Label();
            var numericUpDown1 = new NumericUpDown();
            var numericUpDown2 = new NumericUpDown();
            var buttonOk = new Button();
            var buttonCancel = new Button();

            form.Text = title;
            valueLabel1.Text = label1;
            valueLabel2.Text = label2;
            numericUpDown1.Minimum = min;
            numericUpDown1.Maximum = max;
            numericUpDown1.Value = value1;

            numericUpDown2.Minimum = min;
            numericUpDown2.Maximum = max;
            numericUpDown2.Value = value2;

            buttonOk.Text = @"OK";
            buttonCancel.Text = @"Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            valueLabel1.AutoSize = true;
            valueLabel2.AutoSize = true;

            valueLabel1.SetBounds(12, 12, 0, 0);
            valueLabel2.SetBounds(12, 35, 150, 20);

            form.Controls.AddRange(new Control[] { valueLabel1, valueLabel2 });

            numericUpDown1.SetBounds(valueLabel1.Right + 8, 12, 100, 20);
            numericUpDown2.SetBounds(valueLabel2.Right + 8, 35, 100, 20);

            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);


            numericUpDown1.Anchor = numericUpDown1.Anchor | AnchorStyles.Right;
            numericUpDown2.Anchor = numericUpDown2.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { valueLabel1, valueLabel2, numericUpDown1, numericUpDown2, buttonOk, buttonCancel });
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            var dialogResult = form.ShowDialog();
            value1 = numericUpDown1.Value;
            value2 = numericUpDown2.Value;
            return dialogResult;
        }

        /// <summary>
        /// The Show method.
        /// </summary>
        /// <param name="title">The title of the dialog window.</param>
        /// <param name="prompt">The text to show inside of the dialog window.</param>
        /// <param name="selections">The minimum value that can be entered.</param>
        /// <param name="value">The value entered.</param>
        /// <returns>The result of the dialog.</returns>
        public static DialogResult Show(string title, string prompt, ComboBox selections, ref int value)
        {
            var form = new Form();
            var label = new Label();
            var buttonOk = new Button();
            var buttonCancel = new Button();

            form.Text = title;
            label.Text = prompt;

            buttonOk.Text = @"OK";
            buttonCancel.Text = @"Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            if (prompt.Contains("\n"))
            {
                label.SetBounds(9, 10, 372, 26);
                selections.SetBounds(12, 50, 372, 20);
            }
            else
            {
                label.SetBounds(9, 20, 372, 13);
                selections.SetBounds(12, 36, 372, 20);
            }

            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            selections.Anchor = selections.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, selections, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            var dialogResult = form.ShowDialog();
            value = selections.SelectedIndex;
            return dialogResult;
        }

        /// <summary>
        /// The Show method.
        /// </summary>
        /// <param name="title">The title of the dialog window.</param>
        /// <param name="prompt">The text to show inside of the dialog window.</param>
        /// <param name="value">The value entered.</param>
        /// <returns>The result of the dialog.</returns>
        public static DialogResult Show(string title, string prompt, ref string value)
        {
            var form = new Form();
            var label = new Label();
            var buttonOk = new Button();
            var buttonCancel = new Button();
            var textBox = new TextBox();

            form.Text = title;
            label.Text = prompt;

            buttonOk.Text = @"OK";
            buttonCancel.Text = @"Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            if (prompt.Contains("\n"))
            {
                label.SetBounds(9, 10, 372, 26);
                textBox.SetBounds(12, 50, 372, 20);
            }
            else
            {
                label.SetBounds(9, 20, 372, 13);
                textBox.SetBounds(12, 36, 372, 20);
            }

            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            var dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        #endregion Public Methods
    }
}