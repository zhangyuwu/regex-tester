namespace regex
{
    partial class MainForm
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
            this.groupBox_Pattern = new System.Windows.Forms.GroupBox();
            this.checkBox_CultureInvariant = new System.Windows.Forms.CheckBox();
            this.checkBox_ECMAScript = new System.Windows.Forms.CheckBox();
            this.checkBox_RightToLeft = new System.Windows.Forms.CheckBox();
            this.checkBox_IgnorePatternWhitespace = new System.Windows.Forms.CheckBox();
            this.checkBox_Singleline = new System.Windows.Forms.CheckBox();
            this.checkBox_ExplicitCapture = new System.Windows.Forms.CheckBox();
            this.checkBox_Multiline = new System.Windows.Forms.CheckBox();
            this.checkBox_IgnoreCase = new System.Windows.Forms.CheckBox();
            this.textBox_Pattern = new System.Windows.Forms.TextBox();
            this.groupBox_SourceText = new System.Windows.Forms.GroupBox();
            this.richTextBox_Source = new System.Windows.Forms.RichTextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox_Pattern.SuspendLayout();
            this.groupBox_SourceText.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Pattern
            // 
            this.groupBox_Pattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Pattern.Controls.Add(this.checkBox_CultureInvariant);
            this.groupBox_Pattern.Controls.Add(this.checkBox_ECMAScript);
            this.groupBox_Pattern.Controls.Add(this.checkBox_RightToLeft);
            this.groupBox_Pattern.Controls.Add(this.checkBox_IgnorePatternWhitespace);
            this.groupBox_Pattern.Controls.Add(this.checkBox_Singleline);
            this.groupBox_Pattern.Controls.Add(this.checkBox_ExplicitCapture);
            this.groupBox_Pattern.Controls.Add(this.checkBox_Multiline);
            this.groupBox_Pattern.Controls.Add(this.checkBox_IgnoreCase);
            this.groupBox_Pattern.Controls.Add(this.textBox_Pattern);
            this.groupBox_Pattern.Location = new System.Drawing.Point(16, 9);
            this.groupBox_Pattern.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Pattern.Name = "groupBox_Pattern";
            this.groupBox_Pattern.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Pattern.Size = new System.Drawing.Size(624, 126);
            this.groupBox_Pattern.TabIndex = 2;
            this.groupBox_Pattern.TabStop = false;
            this.groupBox_Pattern.Text = "Pattern";
            // 
            // checkBox_CultureInvariant
            // 
            this.checkBox_CultureInvariant.AutoSize = true;
            this.checkBox_CultureInvariant.Location = new System.Drawing.Point(284, 52);
            this.checkBox_CultureInvariant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_CultureInvariant.Name = "checkBox_CultureInvariant";
            this.checkBox_CultureInvariant.Size = new System.Drawing.Size(129, 21);
            this.checkBox_CultureInvariant.TabIndex = 7;
            this.checkBox_CultureInvariant.Text = "CultureInvariant";
            this.checkBox_CultureInvariant.UseVisualStyleBackColor = true;
            this.checkBox_CultureInvariant.CheckedChanged += new System.EventHandler(this.checkBox_CultureInvariant_CheckedChanged);
            // 
            // checkBox_ECMAScript
            // 
            this.checkBox_ECMAScript.AutoSize = true;
            this.checkBox_ECMAScript.Location = new System.Drawing.Point(152, 52);
            this.checkBox_ECMAScript.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_ECMAScript.Name = "checkBox_ECMAScript";
            this.checkBox_ECMAScript.Size = new System.Drawing.Size(104, 21);
            this.checkBox_ECMAScript.TabIndex = 6;
            this.checkBox_ECMAScript.Text = "ECMAScript";
            this.checkBox_ECMAScript.UseVisualStyleBackColor = true;
            this.checkBox_ECMAScript.CheckedChanged += new System.EventHandler(this.checkBox_ECMAScript_CheckedChanged);
            // 
            // checkBox_RightToLeft
            // 
            this.checkBox_RightToLeft.AutoSize = true;
            this.checkBox_RightToLeft.Location = new System.Drawing.Point(23, 52);
            this.checkBox_RightToLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_RightToLeft.Name = "checkBox_RightToLeft";
            this.checkBox_RightToLeft.Size = new System.Drawing.Size(104, 21);
            this.checkBox_RightToLeft.TabIndex = 5;
            this.checkBox_RightToLeft.Text = "RightToLeft";
            this.checkBox_RightToLeft.UseVisualStyleBackColor = true;
            this.checkBox_RightToLeft.CheckedChanged += new System.EventHandler(this.checkBox_RightToLeft_CheckedChanged);
            // 
            // checkBox_IgnorePatternWhitespace
            // 
            this.checkBox_IgnorePatternWhitespace.AutoSize = true;
            this.checkBox_IgnorePatternWhitespace.Location = new System.Drawing.Point(425, 23);
            this.checkBox_IgnorePatternWhitespace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_IgnorePatternWhitespace.Name = "checkBox_IgnorePatternWhitespace";
            this.checkBox_IgnorePatternWhitespace.Size = new System.Drawing.Size(190, 21);
            this.checkBox_IgnorePatternWhitespace.TabIndex = 4;
            this.checkBox_IgnorePatternWhitespace.Text = "IgnorePatternWhitespace";
            this.checkBox_IgnorePatternWhitespace.UseVisualStyleBackColor = true;
            this.checkBox_IgnorePatternWhitespace.CheckedChanged += new System.EventHandler(this.checkBox_IgnorePatternWhitespace_CheckedChanged);
            // 
            // checkBox_Singleline
            // 
            this.checkBox_Singleline.AutoSize = true;
            this.checkBox_Singleline.Location = new System.Drawing.Point(425, 52);
            this.checkBox_Singleline.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_Singleline.Name = "checkBox_Singleline";
            this.checkBox_Singleline.Size = new System.Drawing.Size(91, 21);
            this.checkBox_Singleline.TabIndex = 8;
            this.checkBox_Singleline.Text = "Singleline";
            this.checkBox_Singleline.UseVisualStyleBackColor = true;
            this.checkBox_Singleline.CheckedChanged += new System.EventHandler(this.checkBox_Singleline_CheckedChanged);
            // 
            // checkBox_ExplicitCapture
            // 
            this.checkBox_ExplicitCapture.AutoSize = true;
            this.checkBox_ExplicitCapture.Location = new System.Drawing.Point(284, 23);
            this.checkBox_ExplicitCapture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_ExplicitCapture.Name = "checkBox_ExplicitCapture";
            this.checkBox_ExplicitCapture.Size = new System.Drawing.Size(123, 21);
            this.checkBox_ExplicitCapture.TabIndex = 3;
            this.checkBox_ExplicitCapture.Text = "ExplicitCapture";
            this.checkBox_ExplicitCapture.UseVisualStyleBackColor = true;
            this.checkBox_ExplicitCapture.CheckedChanged += new System.EventHandler(this.checkBox_ExplicitCapture_CheckedChanged);
            // 
            // checkBox_Multiline
            // 
            this.checkBox_Multiline.AutoSize = true;
            this.checkBox_Multiline.Location = new System.Drawing.Point(152, 23);
            this.checkBox_Multiline.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_Multiline.Name = "checkBox_Multiline";
            this.checkBox_Multiline.Size = new System.Drawing.Size(81, 21);
            this.checkBox_Multiline.TabIndex = 2;
            this.checkBox_Multiline.Text = "Multiline";
            this.checkBox_Multiline.UseVisualStyleBackColor = true;
            this.checkBox_Multiline.CheckedChanged += new System.EventHandler(this.checkBox_Multiline_CheckedChanged);
            // 
            // checkBox_IgnoreCase
            // 
            this.checkBox_IgnoreCase.AutoSize = true;
            this.checkBox_IgnoreCase.Location = new System.Drawing.Point(23, 23);
            this.checkBox_IgnoreCase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_IgnoreCase.Name = "checkBox_IgnoreCase";
            this.checkBox_IgnoreCase.Size = new System.Drawing.Size(102, 21);
            this.checkBox_IgnoreCase.TabIndex = 1;
            this.checkBox_IgnoreCase.Text = "IgnoreCase";
            this.checkBox_IgnoreCase.UseVisualStyleBackColor = true;
            this.checkBox_IgnoreCase.CheckedChanged += new System.EventHandler(this.checkBox_IgnoreCase_CheckedChanged);
            // 
            // textBox_Pattern
            // 
            this.textBox_Pattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Pattern.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Pattern.Location = new System.Drawing.Point(23, 84);
            this.textBox_Pattern.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Pattern.Name = "textBox_Pattern";
            this.textBox_Pattern.Size = new System.Drawing.Size(575, 23);
            this.textBox_Pattern.TabIndex = 0;
            this.textBox_Pattern.TextChanged += new System.EventHandler(this.textBox_Pattern_TextChanged);
            this.textBox_Pattern.MouseHover += new System.EventHandler(this.textBox_Pattern_MouseHover);
            // 
            // groupBox_SourceText
            // 
            this.groupBox_SourceText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_SourceText.Controls.Add(this.richTextBox_Source);
            this.groupBox_SourceText.Location = new System.Drawing.Point(16, 143);
            this.groupBox_SourceText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_SourceText.Name = "groupBox_SourceText";
            this.groupBox_SourceText.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_SourceText.Size = new System.Drawing.Size(624, 218);
            this.groupBox_SourceText.TabIndex = 1;
            this.groupBox_SourceText.TabStop = false;
            this.groupBox_SourceText.Text = "Source";
            // 
            // richTextBox_Source
            // 
            this.richTextBox_Source.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_Source.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Source.Location = new System.Drawing.Point(23, 23);
            this.richTextBox_Source.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox_Source.Name = "richTextBox_Source";
            this.richTextBox_Source.Size = new System.Drawing.Size(575, 173);
            this.richTextBox_Source.TabIndex = 0;
            this.richTextBox_Source.Text = "";
            this.richTextBox_Source.TextChanged += new System.EventHandler(this.richTextBox_Source_TextChanged);
            this.richTextBox_Source.MouseHover += new System.EventHandler(this.richTextBox_Source_MouseHover);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 376);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(656, 22);
            this.statusStrip.TabIndex = 3;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 398);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox_SourceText);
            this.Controls.Add(this.groupBox_Pattern);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(661, 420);
            this.Name = "MainForm";
            this.Text = "Regex Tester";
            this.groupBox_Pattern.ResumeLayout(false);
            this.groupBox_Pattern.PerformLayout();
            this.groupBox_SourceText.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Pattern;
        private System.Windows.Forms.GroupBox groupBox_SourceText;
        private System.Windows.Forms.TextBox textBox_Pattern;
        private System.Windows.Forms.RichTextBox richTextBox_Source;
        private System.Windows.Forms.CheckBox checkBox_IgnoreCase;
        private System.Windows.Forms.CheckBox checkBox_Singleline;
        private System.Windows.Forms.CheckBox checkBox_ExplicitCapture;
        private System.Windows.Forms.CheckBox checkBox_Multiline;
        private System.Windows.Forms.CheckBox checkBox_IgnorePatternWhitespace;
        private System.Windows.Forms.CheckBox checkBox_RightToLeft;
        private System.Windows.Forms.CheckBox checkBox_CultureInvariant;
        private System.Windows.Forms.CheckBox checkBox_ECMAScript;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}

