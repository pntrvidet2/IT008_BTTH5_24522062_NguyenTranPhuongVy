namespace BT04
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboFont = new System.Windows.Forms.ComboBox();
            this.chkU = new System.Windows.Forms.CheckBox();
            this.grpAlign = new System.Windows.Forms.GroupBox();
            this.radRight = new System.Windows.Forms.RadioButton();
            this.radCenter = new System.Windows.Forms.RadioButton();
            this.radLeft = new System.Windows.Forms.RadioButton();
            this.chkB = new System.Windows.Forms.CheckBox();
            this.chkI = new System.Windows.Forms.CheckBox();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.grpAlign.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "FONT";
            // 
            // cboFont
            // 
            this.cboFont.FormattingEnabled = true;
            this.cboFont.Location = new System.Drawing.Point(112, 42);
            this.cboFont.Name = "cboFont";
            this.cboFont.Size = new System.Drawing.Size(121, 24);
            this.cboFont.TabIndex = 1;
            this.cboFont.SelectedIndexChanged += new System.EventHandler(this.cbFont_SelectedIndexChanged);
            // 
            // chkU
            // 
            this.chkU.AutoSize = true;
            this.chkU.Font = new System.Drawing.Font("Arial Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkU.Location = new System.Drawing.Point(53, 150);
            this.chkU.Name = "chkU";
            this.chkU.Size = new System.Drawing.Size(41, 22);
            this.chkU.TabIndex = 2;
            this.chkU.Text = "U";
            this.chkU.UseVisualStyleBackColor = true;
            this.chkU.CheckedChanged += new System.EventHandler(this.Style_CheckedChanged);
            // 
            // grpAlign
            // 
            this.grpAlign.Controls.Add(this.radRight);
            this.grpAlign.Controls.Add(this.radCenter);
            this.grpAlign.Controls.Add(this.radLeft);
            this.grpAlign.Location = new System.Drawing.Point(33, 176);
            this.grpAlign.Name = "grpAlign";
            this.grpAlign.Size = new System.Drawing.Size(200, 100);
            this.grpAlign.TabIndex = 3;
            this.grpAlign.TabStop = false;
            this.grpAlign.Text = "Align Text";
            // 
            // radRight
            // 
            this.radRight.AutoSize = true;
            this.radRight.Location = new System.Drawing.Point(26, 73);
            this.radRight.Name = "radRight";
            this.radRight.Size = new System.Drawing.Size(59, 20);
            this.radRight.TabIndex = 2;
            this.radRight.TabStop = true;
            this.radRight.Text = "Right";
            this.radRight.UseVisualStyleBackColor = true;
            this.radRight.CheckedChanged += new System.EventHandler(this.Align_CheckedChanged);
            // 
            // radCenter
            // 
            this.radCenter.AutoSize = true;
            this.radCenter.Location = new System.Drawing.Point(26, 47);
            this.radCenter.Name = "radCenter";
            this.radCenter.Size = new System.Drawing.Size(67, 20);
            this.radCenter.TabIndex = 1;
            this.radCenter.TabStop = true;
            this.radCenter.Text = "Center";
            this.radCenter.UseVisualStyleBackColor = true;
            this.radCenter.CheckedChanged += new System.EventHandler(this.Align_CheckedChanged);
            // 
            // radLeft
            // 
            this.radLeft.AutoSize = true;
            this.radLeft.Location = new System.Drawing.Point(26, 21);
            this.radLeft.Name = "radLeft";
            this.radLeft.Size = new System.Drawing.Size(49, 20);
            this.radLeft.TabIndex = 0;
            this.radLeft.TabStop = true;
            this.radLeft.Text = "Left";
            this.radLeft.UseVisualStyleBackColor = true;
            this.radLeft.CheckedChanged += new System.EventHandler(this.Align_CheckedChanged);
            // 
            // chkB
            // 
            this.chkB.AutoSize = true;
            this.chkB.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkB.Location = new System.Drawing.Point(53, 98);
            this.chkB.Name = "chkB";
            this.chkB.Size = new System.Drawing.Size(40, 22);
            this.chkB.TabIndex = 4;
            this.chkB.Text = "B";
            this.chkB.UseVisualStyleBackColor = true;
            this.chkB.CheckedChanged += new System.EventHandler(this.Style_CheckedChanged);
            // 
            // chkI
            // 
            this.chkI.AutoSize = true;
            this.chkI.Font = new System.Drawing.Font("Arial Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkI.Location = new System.Drawing.Point(53, 124);
            this.chkI.Name = "chkI";
            this.chkI.Size = new System.Drawing.Size(35, 22);
            this.chkI.TabIndex = 5;
            this.chkI.Text = "I";
            this.chkI.UseVisualStyleBackColor = true;
            this.chkI.CheckedChanged += new System.EventHandler(this.Style_CheckedChanged);
            // 
            // cboSize
            // 
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Location = new System.Drawing.Point(334, 42);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(121, 24);
            this.cboSize.TabIndex = 6;
            this.cboSize.SelectedIndexChanged += new System.EventHandler(this.cbSize_SelectedIndexChanged);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Fuchsia;
            this.btnColor.Location = new System.Drawing.Point(334, 95);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(30, 23);
            this.btnColor.TabIndex = 8;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "COLOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "SIZE";
            // 
            // rtbContent
            // 
            this.rtbContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbContent.Location = new System.Drawing.Point(257, 196);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(198, 72);
            this.rtbContent.TabIndex = 1;
            this.rtbContent.Text = "";
            this.rtbContent.TextChanged += new System.EventHandler(this.rtbContent_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 353);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.cboSize);
            this.Controls.Add(this.chkI);
            this.Controls.Add(this.chkB);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.grpAlign);
            this.Controls.Add(this.chkU);
            this.Controls.Add(this.cboFont);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAlign.ResumeLayout(false);
            this.grpAlign.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFont;
        private System.Windows.Forms.CheckBox chkU;
        private System.Windows.Forms.GroupBox grpAlign;
        private System.Windows.Forms.RadioButton radRight;
        private System.Windows.Forms.RadioButton radCenter;
        private System.Windows.Forms.RadioButton radLeft;
        private System.Windows.Forms.CheckBox chkB;
        private System.Windows.Forms.CheckBox chkI;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbContent;
    }
}

