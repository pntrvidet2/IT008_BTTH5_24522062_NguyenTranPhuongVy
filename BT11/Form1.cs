using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BT11
{
    public partial class Form1 : Form
    {
        private Color _penColor = Color.Green;   
        private bool _isDrawing = false;
        private Point _start;
        private Point _current;

        private Bitmap _canvas;        
        private Bitmap _textureBitmap; 

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Text = "Bai Thi";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            radLine.Checked = true;
            radHatchBrush.Checked = true;
            txtWidth.Text = "1";

            btnColor.BackColor = _penColor;

     
            _canvas = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(_canvas))
                g.Clear(Color.White);
            picCanvas.Image = _canvas;

          
            _textureBitmap = CreateTextureBitmap(90, 90);

      
            picCanvas.Resize += picCanvas_Resize;
        }

        private void picCanvas_Resize(object sender, EventArgs e)
        {
            if (picCanvas.Width <= 0 || picCanvas.Height <= 0) return;

            Bitmap newBmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(newBmp))
            {
                g.Clear(Color.White);
                if (_canvas != null)
                    g.DrawImageUnscaled(_canvas, 0, 0);
            }

            if (_canvas != null) _canvas.Dispose();
            _canvas = newBmp;
            picCanvas.Image = _canvas;

            picCanvas.Invalidate();
        }

      
        private void btnColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                dlg.Color = _penColor;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _penColor = dlg.Color;
                    btnColor.BackColor = _penColor;
                }
            }
        }


        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            _isDrawing = true;
            _start = e.Location;
            _current = e.Location;
            picCanvas.Capture = true;
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isDrawing) return;

            _current = e.Location;
            picCanvas.Invalidate();
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (!_isDrawing) return;

            _isDrawing = false;
            picCanvas.Capture = false;
            _current = e.Location;

       
            using (Graphics g = Graphics.FromImage(_canvas))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                DrawShape(g, _start, _current, isPreview: false);
            }

            picCanvas.Invalidate();
        }

  
        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (!_isDrawing) return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            DrawShape(e.Graphics, _start, _current, isPreview: true);
        }

        private void DrawShape(Graphics g, Point p1, Point p2, bool isPreview)
        {
            float w = GetPenWidth();

            if (radLine.Checked)
            {
                using (Pen pen = new Pen(_penColor, w))
                {
                    pen.StartCap = LineCap.Round;
                    pen.EndCap = LineCap.Round;
                    g.DrawLine(pen, p1, p2);
                }
                return;
            }

      
            Rectangle rect = GetRect(p1, p2);
            if (rect.Width < 2 || rect.Height < 2) return;

            using (Brush br = CreateFillBrush(rect))
            {
                if (radRectangle.Checked)
                    g.FillRectangle(br, rect);
                else if (radEllipse.Checked)
                    g.FillEllipse(br, rect);
            }

        
            using (Pen border = new Pen(Color.Black, 1))
            {
                border.DashStyle = isPreview ? DashStyle.Dash : DashStyle.Solid;

                if (radRectangle.Checked)
                    g.DrawRectangle(border, rect);
                else if (radEllipse.Checked)
                    g.DrawEllipse(border, rect);
            }
        }

        private Brush CreateFillBrush(Rectangle rect)
        {
            if (radSolidBrush.Checked)
            {
           
                return new SolidBrush(Color.Green);
            }

            if (radHatchBrush.Checked)
            {
                return new HatchBrush(HatchStyle.Horizontal, Color.Blue, Color.Green);
            }

            if (radTextureBrush.Checked)
            {
               
                return new TextureBrush(_textureBitmap, WrapMode.Tile);
            }

        
            return new LinearGradientBrush(rect, Color.Red, Color.Green, LinearGradientMode.Vertical);
        }


        private float GetPenWidth()
        {
            float w;
            if (!float.TryParse(txtWidth.Text.Trim(), out w)) w = 1f;
            if (w < 1f) w = 1f;
            if (w > 50f) w = 50f;
            return w;
        }

        private Rectangle GetRect(Point a, Point b)
        {
            int x1 = Math.Min(a.X, b.X);
            int y1 = Math.Min(a.Y, b.Y);
            int x2 = Math.Max(a.X, b.X);
            int y2 = Math.Max(a.Y, b.Y);
            return new Rectangle(x1, y1, x2 - x1, y2 - y1);
        }

 
        private Bitmap CreateTextureBitmap(int w, int h)
        {
            Bitmap bmp = new Bitmap(w, h);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.White);

                using (Pen p = new Pen(Color.SteelBlue, 2))
                {
            
                    for (int y = 0; y < h; y += 18)
                        for (int x = 0; x < w; x += 18)
                            g.DrawEllipse(p, x, y, 16, 16);
                }
            }
            return bmp;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (_canvas != null) _canvas.Dispose();
            if (_textureBitmap != null) _textureBitmap.Dispose();
            base.OnFormClosed(e);
        }
    }
}
