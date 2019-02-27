using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace regex
{
    public partial class MainForm : Form
    {
        Font _normalFont;
        Font _highFont;
        bool _richBoxDirty = true;
        string _richBoxText = "";

        public MainForm()
        {
            InitializeComponent();
            _normalFont = richTextBox_Source.SelectionFont;
            _highFont = new Font(_normalFont, FontStyle.Underline);
        }

        private void SetRichBoxDirty(bool dirty) {
            _richBoxDirty = dirty;
        }

        private void CleanRichBoxSelection() {
            if (_richBoxDirty) {
                richTextBox_Source.SelectAll();
                richTextBox_Source.SelectionColor = Color.Black;
                richTextBox_Source.SelectionBackColor = Color.White;
                richTextBox_Source.SelectionFont = _normalFont;
                SetRichBoxDirty(false);
            }
        }

        private void onRegexChanged()
        {
            try
            {
                int offset = richTextBox_Source.SelectionStart;
                int length = richTextBox_Source.SelectionLength;

                var regopt = RegexOptions.None;

                if (checkBox_CultureInvariant.Checked)
                    regopt |= RegexOptions.CultureInvariant;
                if (checkBox_ECMAScript.Checked)
                    regopt |= RegexOptions.ECMAScript;
                if (checkBox_ExplicitCapture.Checked)
                    regopt |= RegexOptions.ExplicitCapture;
                if (checkBox_IgnoreCase.Checked)
                    regopt |= RegexOptions.IgnoreCase;
                if (checkBox_IgnorePatternWhitespace.Checked)
                    regopt |= RegexOptions.IgnorePatternWhitespace;
                if (checkBox_Multiline.Checked)
                    regopt |= RegexOptions.Multiline;
                if (checkBox_RightToLeft.Checked)
                    regopt |= RegexOptions.RightToLeft;
                if (checkBox_Singleline.Checked)
                    regopt |= RegexOptions.Singleline;

                CleanRichBoxSelection();

                if (textBox_Pattern.Text.Length > 0) {
                    var regex = new Regex(textBox_Pattern.Text, regopt);
                    var mcoll = regex.Matches(richTextBox_Source.Text);

                    if (mcoll.Count > 0) {
                        int i = 0;
                        foreach (Match m in mcoll) {
                            richTextBox_Source.Select(m.Index, m.Length);
                            richTextBox_Source.SelectionColor = Color.Blue;
                            richTextBox_Source.SelectionBackColor = i++ % 2 != 0 ? Color.LightGreen : Color.Yellow;
                            richTextBox_Source.SelectionFont = _highFont;
                            SetRichBoxDirty(true);
                        }
                    }
                    this.toolStripStatusLabel.Text = string.Format("Total {0} matches.", mcoll.Count); ;
                }

                richTextBox_Source.SelectionStart = offset;
                richTextBox_Source.SelectionLength = length;
            }
            catch {
                // ignore exceptions
            }
        }

        private void textBox_Pattern_TextChanged(object sender, EventArgs e)
        {
            onRegexChanged();
        }

        private void richTextBox_Source_TextChanged(object sender, EventArgs e)
        {
            if (_richBoxText != richTextBox_Source.Text) {
                onRegexChanged();
                _richBoxText = richTextBox_Source.Text;
            }
        }

        private void checkBox_IgnoreCase_CheckedChanged(object sender, EventArgs e)
        {
            onRegexChanged();
        }

        private void checkBox_Multiline_CheckedChanged(object sender, EventArgs e)
        {
            onRegexChanged();
        }

        private void checkBox_ExplicitCapture_CheckedChanged(object sender, EventArgs e)
        {
            onRegexChanged();
        }

        private void checkBox_IgnorePatternWhitespace_CheckedChanged(object sender, EventArgs e)
        {
            onRegexChanged();
        }

        private void checkBox_RightToLeft_CheckedChanged(object sender, EventArgs e)
        {
            onRegexChanged();
        }

        private void checkBox_ECMAScript_CheckedChanged(object sender, EventArgs e)
        {
            onRegexChanged();
        }

        private void checkBox_CultureInvariant_CheckedChanged(object sender, EventArgs e)
        {
            onRegexChanged();
        }

        private void checkBox_Singleline_CheckedChanged(object sender, EventArgs e)
        {
            onRegexChanged();
        }

        private void textBox_Pattern_MouseHover(object sender, EventArgs e)
        {
            textBox_Pattern.Focus();
        }

        private void richTextBox_Source_MouseHover(object sender, EventArgs e)
        {
            richTextBox_Source.Focus();
        }
    }
}
