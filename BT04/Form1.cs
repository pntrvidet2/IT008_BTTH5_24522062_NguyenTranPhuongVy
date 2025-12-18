using System;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace BT04
{
    public partial class Form1 : Form
    {
        private Color _currentColor = Color.DeepPink;
        private bool _syncing = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load fonts
            var fonts = new InstalledFontCollection().Families
                .Select(f => f.Name).OrderBy(x => x).ToArray();
            cboFont.Items.AddRange(fonts);

            cboSize.Items.AddRange(new object[]
            { "8","9","10","11","12","14","16","18","20","24","28","32","36","48","72" });

            cboFont.SelectedItem = fonts.Contains("Arial") ? "Arial" : fonts.FirstOrDefault();
            cboSize.SelectedItem = "28";

            radCenter.Checked = true;

            btnColor.BackColor = _currentColor;
            btnColor.ForeColor = _currentColor;

            rtbContent.Text = "Hello";
            rtbContent.SelectAll();
            ApplyFormatAll();
            ApplyAlignAll();
            rtbContent.Select(rtbContent.TextLength, 0);
        }

        private void cbFont_SelectedIndexChanged(object sender, EventArgs e) => ApplyFormatAll();
        private void cbSize_SelectedIndexChanged(object sender, EventArgs e) => ApplyFormatAll();

        private void Style_CheckedChanged(object sender, EventArgs e) => ApplyFormatAll();
        private void Align_CheckedChanged(object sender, EventArgs e) => ApplyAlignAll();

        private void BtnColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                dlg.Color = _currentColor;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _currentColor = dlg.Color;
                    btnColor.BackColor = _currentColor;
                    btnColor.ForeColor = _currentColor;
                    ApplyFormatAll();
                }
            }
        }

        private void rtbContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void ApplyFormatAll()
        {
            if (_syncing) return;
            if (string.IsNullOrWhiteSpace(cboFont.Text) || string.IsNullOrWhiteSpace(cboSize.Text))
                return;

            if (!float.TryParse(cboSize.Text, out float size)) size = 12f;

            FontStyle style = FontStyle.Regular;
            if (chkB.Checked) style |= FontStyle.Bold;
            if (chkI.Checked) style |= FontStyle.Italic;
            if (chkU.Checked) style |= FontStyle.Underline;

            int start = rtbContent.SelectionStart;
            int len = rtbContent.SelectionLength;

            _syncing = true;
            rtbContent.SelectAll();
            try { rtbContent.SelectionFont = new Font(cboFont.Text, size, style); }
            catch { rtbContent.SelectionFont = new Font("Arial", size, style); }
            rtbContent.SelectionColor = _currentColor;
            rtbContent.Select(start, len);
            _syncing = false;

            rtbContent.Focus();
        }

        private void ApplyAlignAll()
        {
            int start = rtbContent.SelectionStart;
            int len = rtbContent.SelectionLength;

            rtbContent.SelectAll();
            if (radLeft.Checked) rtbContent.SelectionAlignment = HorizontalAlignment.Left;
            else if (radRight.Checked) rtbContent.SelectionAlignment = HorizontalAlignment.Right;
            else rtbContent.SelectionAlignment = HorizontalAlignment.Center;

            rtbContent.Select(start, len);
            rtbContent.Focus();
        }

        private void SyncControlsWithCaret()
        {
            var f = rtbContent.SelectionFont;
            if (f == null) return;

            _syncing = true;
            chkB.Checked = f.Bold;
            chkI.Checked = f.Italic;
            chkU.Checked = f.Underline;

            cboFont.Text = f.FontFamily.Name;
            cboSize.Text = ((int)f.Size).ToString();

            _currentColor = rtbContent.SelectionColor;
            btnColor.BackColor = _currentColor;
            btnColor.ForeColor = _currentColor;
            _syncing = false;
        }
    }
}
