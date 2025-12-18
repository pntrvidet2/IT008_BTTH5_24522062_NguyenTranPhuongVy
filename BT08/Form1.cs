using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BT08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;   
            timer1.Enabled = true;
            this.Invalidate();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pnlClock.Invalidate();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.Black);

            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;
            int r = Math.Min(w, h) / 2 - 20;
            Point c = new Point(w / 2, h / 2);


            for (int i = 0; i < 60; i++)
            {
                double a = (Math.PI * 2) * i / 60.0 - Math.PI / 2;

                int dot = (i % 5 == 0) ? 7 : 2;
                int rr = (i % 5 == 0) ? r : (r - 6);

                int x = c.X + (int)(Math.Cos(a) * rr);
                int y = c.Y + (int)(Math.Sin(a) * rr);

                using (Brush b = new SolidBrush(Color.White))
                {
                    g.FillEllipse(b, x - dot, y - dot, dot * 2, dot * 2);
                }
            }


            DateTime now = DateTime.Now;
            double ms = now.Millisecond / 1000.0;

            double sec = now.Second + ms;                    
            double min = now.Minute + sec / 60.0;           
            double hour = (now.Hour % 12) + min / 60.0;     

            double secA = (Math.PI * 2) * sec / 60.0 - Math.PI / 2;
            double minA = (Math.PI * 2) * min / 60.0 - Math.PI / 2;
            double hourA = (Math.PI * 2) * hour / 12.0 - Math.PI / 2;

          
            DrawHand(g, c, hourA, (int)(r * 0.45), 6, Color.White);
            DrawHand(g, c, minA, (int)(r * 0.68), 4, Color.White);
            DrawHand(g, c, secA, (int)(r * 0.80), 2, Color.LightGray);

          
            using (Brush center = new SolidBrush(Color.White))
            {
                g.FillEllipse(center, c.X - 6, c.Y - 6, 12, 12);
            }
        }

        private void DrawHand(Graphics g, Point center, double angle, int length, int width, Color color)
        {
            int x = center.X + (int)(Math.Cos(angle) * length);
            int y = center.Y + (int)(Math.Sin(angle) * length);

            using (Pen pen = new Pen(color, width))
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                g.DrawLine(pen, center, new Point(x, y));
            }
        }
    }
}
