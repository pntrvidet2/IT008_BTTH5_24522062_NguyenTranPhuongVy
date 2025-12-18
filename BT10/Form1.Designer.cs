namespace BT10
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
            this.cboDashStyle = new System.Windows.Forms.ComboBox();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.cboEndCap = new System.Windows.Forms.ComboBox();
            this.cboStartCap = new System.Windows.Forms.ComboBox();
            this.cboDashCap = new System.Windows.Forms.ComboBox();
            this.cboLineJoin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDashStyle
            // 
            this.cboDashStyle.FormattingEnabled = true;
            this.cboDashStyle.Location = new System.Drawing.Point(159, 24);
            this.cboDashStyle.Name = "cboDashStyle";
            this.cboDashStyle.Size = new System.Drawing.Size(121, 24);
            this.cboDashStyle.TabIndex = 0;
            this.cboDashStyle.SelectedIndexChanged += new System.EventHandler(this.AnyChanged);
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(158, 68);
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(120, 22);
            this.numWidth.TabIndex = 1;
            this.numWidth.ValueChanged += new System.EventHandler(this.AnyChanged);
            // 
            // pnlDraw
            // 
            this.pnlDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDraw.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDraw.Location = new System.Drawing.Point(332, 0);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(468, 403);
            this.pnlDraw.TabIndex = 2;
            this.pnlDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDraw_Paint);
            // 
            // cboEndCap
            // 
            this.cboEndCap.FormattingEnabled = true;
            this.cboEndCap.Location = new System.Drawing.Point(158, 234);
            this.cboEndCap.Name = "cboEndCap";
            this.cboEndCap.Size = new System.Drawing.Size(121, 24);
            this.cboEndCap.TabIndex = 3;
            this.cboEndCap.SelectedIndexChanged += new System.EventHandler(this.AnyChanged);
            // 
            // cboStartCap
            // 
            this.cboStartCap.FormattingEnabled = true;
            this.cboStartCap.Location = new System.Drawing.Point(158, 192);
            this.cboStartCap.Name = "cboStartCap";
            this.cboStartCap.Size = new System.Drawing.Size(121, 24);
            this.cboStartCap.TabIndex = 4;
            this.cboStartCap.SelectedValueChanged += new System.EventHandler(this.AnyChanged);
            // 
            // cboDashCap
            // 
            this.cboDashCap.FormattingEnabled = true;
            this.cboDashCap.Location = new System.Drawing.Point(159, 149);
            this.cboDashCap.Name = "cboDashCap";
            this.cboDashCap.Size = new System.Drawing.Size(121, 24);
            this.cboDashCap.TabIndex = 5;
            this.cboDashCap.SelectedIndexChanged += new System.EventHandler(this.AnyChanged);
            // 
            // cboLineJoin
            // 
            this.cboLineJoin.FormattingEnabled = true;
            this.cboLineJoin.Location = new System.Drawing.Point(159, 108);
            this.cboLineJoin.Name = "cboLineJoin";
            this.cboLineJoin.Size = new System.Drawing.Size(121, 24);
            this.cboLineJoin.TabIndex = 6;
            this.cboLineJoin.SelectedIndexChanged += new System.EventHandler(this.AnyChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dash Style:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Start Cap";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Line Join:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Width:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dash Cap";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "End Cap";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboLineJoin);
            this.Controls.Add(this.cboDashCap);
            this.Controls.Add(this.cboStartCap);
            this.Controls.Add(this.cboEndCap);
            this.Controls.Add(this.pnlDraw);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.cboDashStyle);
            this.Name = "Form1";
            this.Text = "Pen Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDashStyle;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Panel pnlDraw;
        private System.Windows.Forms.ComboBox cboEndCap;
        private System.Windows.Forms.ComboBox cboStartCap;
        private System.Windows.Forms.ComboBox cboDashCap;
        private System.Windows.Forms.ComboBox cboLineJoin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}

