namespace BT09
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
            this.cboShape = new System.Windows.Forms.ComboBox();
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cboShape
            // 
            this.cboShape.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboShape.FormattingEnabled = true;
            this.cboShape.Location = new System.Drawing.Point(0, 0);
            this.cboShape.Name = "cboShape";
            this.cboShape.Size = new System.Drawing.Size(800, 24);
            this.cboShape.TabIndex = 0;
            this.cboShape.SelectedIndexChanged += new System.EventHandler(this.cboShape_SelectedIndexChanged);
            // 
            // pnlDraw
            // 
            this.pnlDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDraw.Location = new System.Drawing.Point(0, 24);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(800, 426);
            this.pnlDraw.TabIndex = 1;
            this.pnlDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDraw_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlDraw);
            this.Controls.Add(this.cboShape);
            this.Name = "Form1";
            this.Text = "Pan Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboShape;
        private System.Windows.Forms.Panel pnlDraw;
    }
}

