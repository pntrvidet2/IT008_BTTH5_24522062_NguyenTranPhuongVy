namespace BT11
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
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.radRectangle = new System.Windows.Forms.RadioButton();
            this.radEllipse = new System.Windows.Forms.RadioButton();
            this.radLine = new System.Windows.Forms.RadioButton();
            this.btnColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radLinearGradientBrush = new System.Windows.Forms.RadioButton();
            this.radTextureBrush = new System.Windows.Forms.RadioButton();
            this.radHatchBrush = new System.Windows.Forms.RadioButton();
            this.radSolidBrush = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCanvas.Dock = System.Windows.Forms.DockStyle.Right;
            this.picCanvas.Location = new System.Drawing.Point(234, 0);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(519, 450);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
            this.picCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseDown);
            this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseMove);
            this.picCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseUp);
            // 
            // radRectangle
            // 
            this.radRectangle.AutoSize = true;
            this.radRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRectangle.Location = new System.Drawing.Point(12, 42);
            this.radRectangle.Name = "radRectangle";
            this.radRectangle.Size = new System.Drawing.Size(104, 22);
            this.radRectangle.TabIndex = 4;
            this.radRectangle.Text = "Rectangle";
            this.radRectangle.UseVisualStyleBackColor = true;
            // 
            // radEllipse
            // 
            this.radEllipse.AutoSize = true;
            this.radEllipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEllipse.Location = new System.Drawing.Point(12, 65);
            this.radEllipse.Name = "radEllipse";
            this.radEllipse.Size = new System.Drawing.Size(79, 22);
            this.radEllipse.TabIndex = 5;
            this.radEllipse.Text = "Ellipse";
            this.radEllipse.UseVisualStyleBackColor = true;
            // 
            // radLine
            // 
            this.radLine.AutoSize = true;
            this.radLine.Checked = true;
            this.radLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLine.Location = new System.Drawing.Point(12, 21);
            this.radLine.Name = "radLine";
            this.radLine.Size = new System.Drawing.Size(60, 22);
            this.radLine.TabIndex = 3;
            this.radLine.TabStop = true;
            this.radLine.Text = "Line";
            this.radLine.UseVisualStyleBackColor = true;
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.Location = new System.Drawing.Point(58, 62);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(68, 32);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "Color..";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Width";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(71, 21);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(123, 22);
            this.txtWidth.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radLine);
            this.groupBox1.Controls.Add(this.radRectangle);
            this.groupBox1.Controls.Add(this.radEllipse);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtWidth);
            this.groupBox2.Controls.Add(this.btnColor);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(0, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pen";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radLinearGradientBrush);
            this.groupBox3.Controls.Add(this.radTextureBrush);
            this.groupBox3.Controls.Add(this.radHatchBrush);
            this.groupBox3.Controls.Add(this.radSolidBrush);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 245);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 193);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Brushed";
            // 
            // radLinearGradientBrush
            // 
            this.radLinearGradientBrush.AutoSize = true;
            this.radLinearGradientBrush.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLinearGradientBrush.Location = new System.Drawing.Point(15, 132);
            this.radLinearGradientBrush.Name = "radLinearGradientBrush";
            this.radLinearGradientBrush.Size = new System.Drawing.Size(183, 22);
            this.radLinearGradientBrush.TabIndex = 9;
            this.radLinearGradientBrush.Text = "LinearGradientBrush";
            this.radLinearGradientBrush.UseVisualStyleBackColor = true;
            // 
            // radTextureBrush
            // 
            this.radTextureBrush.AutoSize = true;
            this.radTextureBrush.Checked = true;
            this.radTextureBrush.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTextureBrush.Location = new System.Drawing.Point(15, 95);
            this.radTextureBrush.Name = "radTextureBrush";
            this.radTextureBrush.Size = new System.Drawing.Size(129, 22);
            this.radTextureBrush.TabIndex = 8;
            this.radTextureBrush.TabStop = true;
            this.radTextureBrush.Text = "TextureBrush";
            this.radTextureBrush.UseVisualStyleBackColor = true;
            // 
            // radHatchBrush
            // 
            this.radHatchBrush.AutoSize = true;
            this.radHatchBrush.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHatchBrush.Location = new System.Drawing.Point(15, 58);
            this.radHatchBrush.Name = "radHatchBrush";
            this.radHatchBrush.Size = new System.Drawing.Size(117, 22);
            this.radHatchBrush.TabIndex = 7;
            this.radHatchBrush.Text = "HatchBrush";
            this.radHatchBrush.UseVisualStyleBackColor = true;
            // 
            // radSolidBrush
            // 
            this.radSolidBrush.AutoSize = true;
            this.radSolidBrush.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSolidBrush.Location = new System.Drawing.Point(15, 21);
            this.radSolidBrush.Name = "radSolidBrush";
            this.radSolidBrush.Size = new System.Drawing.Size(111, 22);
            this.radSolidBrush.TabIndex = 6;
            this.radSolidBrush.Text = "SolidBrush";
            this.radSolidBrush.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picCanvas);
            this.Name = "Form1";
            this.Text = "Bai Thi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.RadioButton radRectangle;
        private System.Windows.Forms.RadioButton radEllipse;
        private System.Windows.Forms.RadioButton radLine;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radLinearGradientBrush;
        private System.Windows.Forms.RadioButton radTextureBrush;
        private System.Windows.Forms.RadioButton radHatchBrush;
        private System.Windows.Forms.RadioButton radSolidBrush;
    }
}

