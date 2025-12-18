using System;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace BT06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
             lstFonts.DrawMode = DrawMode.OwnerDrawFixed;
            lstFonts.ItemHeight = 30;
            lstFonts.DrawItem += lstFonts_DrawItem;

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var fonts = new InstalledFontCollection().Families
                .Select(f => f.Name)
                .OrderBy(x => x)
                .ToArray();

            lstFonts.Items.Clear();
            lstFonts.Items.AddRange(fonts);
        }

        private void lstFonts_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index < 0) return;

            string fontName = lstFonts.Items[e.Index].ToString();

            bool selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            Brush br;
            if (selected)
                br = new SolidBrush(SystemColors.HighlightText);
            else
                br = new SolidBrush(SystemColors.ControlText);

            Font f;
            try
            {
                f = new Font(fontName, 14f);
            }
            catch
            {
                f = e.Font;
            }

            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            e.Graphics.DrawString(fontName, f, br,
                e.Bounds.Left + 6,
                e.Bounds.Top + 5);

            f.Dispose();
            br.Dispose();

            e.DrawFocusRectangle();
        }

    }
}
