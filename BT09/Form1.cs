using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BT09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboShape.DropDownStyle = ComboBoxStyle.DropDownList;

            cboShape.Items.AddRange(new object[]
            {
                "Circle",
                "Square",
                "Ellipse",
                "Pie",
                "Filled Circle",
                "Filled Square",
                "Filled Ellipse",
                "Filled Pie"
            });

            cboShape.SelectedIndex = 7; // Filled Ellipse giống hình
        }

        private void cboShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlDraw.Invalidate();
        }

        private void pnlDraw_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = GetCenteredRect(pnlDraw.ClientRectangle, 220, 150);

            string mode = cboShape.SelectedItem == null ? "" : cboShape.SelectedItem.ToString();

            using (Pen pen = new Pen(Color.Black, 3))
            using (Brush fill = new SolidBrush(Color.DarkRed))
            {
                switch (mode)
                {
                    case "Circle":
                        rect = MakeSquare(rect);
                        g.DrawEllipse(pen, rect);
                        break;

                    case "Square":
                        rect = MakeSquare(rect);
                        g.DrawRectangle(pen, rect);
                        break;

                    case "Ellipse":
                        g.DrawEllipse(pen, rect);
                        break;

                    case "Pie":
                        g.DrawPie(pen, rect, 30, 300);
                        break;

                    case "Filled Circle":
                        rect = MakeSquare(rect);
                        g.FillEllipse(fill, rect);
                        break;

                    case "Filled Square":
                        rect = MakeSquare(rect);
                        g.FillRectangle(fill, rect);
                        break;

                    case "Filled Ellipse":
                        g.FillEllipse(fill, rect);
                        break;

                    case "Filled Pie":
                        g.FillPie(fill, rect, 30, 300);
                        break;
                }
            }
        }

        private Rectangle GetCenteredRect(Rectangle client, int w, int h)
        {
            int x = client.Left + (client.Width - w) / 2;
            int y = client.Top + (client.Height - h) / 2;
            return new Rectangle(x, y, w, h);
        }

        private Rectangle MakeSquare(Rectangle r)
        {
            int side = Math.Min(r.Width, r.Height);
            int x = r.Left + (r.Width - side) / 2;
            int y = r.Top + (r.Height - side) / 2;
            return new Rectangle(x, y, side, side);
        }
    }
}
