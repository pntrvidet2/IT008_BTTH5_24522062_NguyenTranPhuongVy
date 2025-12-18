namespace BT06
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
            this.lstFonts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstFonts
            // 
            this.lstFonts.BackColor = System.Drawing.Color.GhostWhite;
            this.lstFonts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstFonts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFonts.FormattingEnabled = true;
            this.lstFonts.ItemHeight = 16;
            this.lstFonts.Location = new System.Drawing.Point(0, 0);
            this.lstFonts.Name = "lstFonts";
            this.lstFonts.Size = new System.Drawing.Size(382, 403);
            this.lstFonts.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 403);
            this.Controls.Add(this.lstFonts);
            this.Name = "Form1";
            this.Text = "All Fonts";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstFonts;
    }
}

