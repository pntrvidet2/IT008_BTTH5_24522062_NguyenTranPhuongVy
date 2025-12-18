using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BT10
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
           
            cboDashStyle.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDashStyle.Items.AddRange(Enum.GetNames(typeof(DashStyle)));

          
            cboLineJoin.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLineJoin.Items.AddRange(Enum.GetNames(typeof(LineJoin)));

        
            cboDashCap.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDashCap.Items.AddRange(Enum.GetNames(typeof(DashCap)));

          
            cboStartCap.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEndCap.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStartCap.Items.AddRange(Enum.GetNames(typeof(LineCap)));
            cboEndCap.Items.AddRange(Enum.GetNames(typeof(LineCap)));

            cboDashStyle.SelectedItem = "DashDot";
            cboLineJoin.SelectedItem = "Round";
            cboDashCap.SelectedItem = "Triangle";
            cboStartCap.SelectedItem = "Triangle";
            cboEndCap.SelectedItem = "RoundAnchor";

            numWidth.Minimum = 1;
            numWidth.Maximum = 30;
            numWidth.Value = 9;

            cboDashStyle.SelectedIndexChanged += AnyChanged;
            cboLineJoin.SelectedIndexChanged += AnyChanged;
            cboDashCap.SelectedIndexChanged += AnyChanged;
            cboStartCap.SelectedIndexChanged += AnyChanged;
            cboEndCap.SelectedIndexChanged += AnyChanged;
            numWidth.ValueChanged += AnyChanged;
        }

        private void AnyChanged(object sender, EventArgs e)
        {
            pnlDraw.Invalidate();
        }

        private void pnlDraw_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);

     
            var dashStyle = (System.Drawing.Drawing2D.DashStyle)Enum.Parse(typeof(System.Drawing.Drawing2D.DashStyle), cboDashStyle.Text);
            var lineJoin = (System.Drawing.Drawing2D.LineJoin)Enum.Parse(typeof(System.Drawing.Drawing2D.LineJoin), cboLineJoin.Text);
            var dashCap = (System.Drawing.Drawing2D.DashCap)Enum.Parse(typeof(System.Drawing.Drawing2D.DashCap), cboDashCap.Text);
            var startCap = (System.Drawing.Drawing2D.LineCap)Enum.Parse(typeof(System.Drawing.Drawing2D.LineCap), cboStartCap.Text);
            var endCap = (System.Drawing.Drawing2D.LineCap)Enum.Parse(typeof(System.Drawing.Drawing2D.LineCap), cboEndCap.Text);
            float width = (float)numWidth.Value;

            using (var pen = new Pen(Color.Red, width))
            {
                pen.DashStyle = dashStyle;
                pen.LineJoin = lineJoin;
                pen.DashCap = dashCap;
                pen.StartCap = startCap;
                pen.EndCap = endCap;

                
                pen.MiterLimit = 10f;

                Rectangle rc = pnlDraw.ClientRectangle;
                int pad = 20;

                Point a1 = new Point(rc.Left + pad, rc.Top + pad);
                Point a2 = new Point(rc.Left + rc.Width / 2 - pad, rc.Top + rc.Height / 2 - pad);
                g.DrawLine(pen, a1, a2);

                Point v1 = new Point(rc.Left + rc.Width / 2 + 30, rc.Top + rc.Height / 2 - 10);
                Point v2 = new Point(rc.Right - pad, rc.Bottom - pad);
                Point v3 = new Point(rc.Left + rc.Width / 2 + 60, rc.Bottom - pad);

                g.DrawLines(pen, new Point[] { v1, v2, v3 });
            }
        }

    }
}
