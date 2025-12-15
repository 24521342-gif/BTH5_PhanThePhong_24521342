using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadSystemFonts();
            InitializeFontSizes();
            UpdateTextPreview();
        }

        private void LoadSystemFonts()
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                cmbFont.Items.Add(font.Name);
            }
            cmbFont.SelectedIndex = cmbFont.Items.IndexOf("Arial");
        }

        private void InitializeFontSizes()
        {
            int[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36 };
            foreach (int size in sizes)
            {
                cmbSize.Items.Add(size);
            }
            cmbSize.SelectedItem = 28;
        }

        private void UpdateTextPreview()
        {
            try
            {
                string fontName = cmbFont.SelectedItem?.ToString() ?? "Arial";
                float fontSize = cmbSize.SelectedItem != null ? 
                    Convert.ToSingle(cmbSize.SelectedItem) : 28f;

                FontStyle style = FontStyle.Regular;
                if (chkBold.Checked) style |= FontStyle.Bold;
                if (chkItalic.Checked) style |= FontStyle.Italic;
                if (chkUnderline.Checked) style |= FontStyle.Underline;

                txtPreview.Font = new Font(fontName, fontSize, style);
                txtPreview.ForeColor = btnColor.BackColor;

                if (rbLeft.Checked)
                    txtPreview.TextAlign = HorizontalAlignment.Left;
                else if (rbCenter.Checked)
                    txtPreview.TextAlign = HorizontalAlignment.Center;
                else if (rbRight.Checked)
                    txtPreview.TextAlign = HorizontalAlignment.Right;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Tự động điều chỉnh chiều cao TextBox theo font size
            using (Graphics g = txtPreview.CreateGraphics())
            {
                SizeF textSize = g.MeasureString(txtPreview.Text, txtPreview.Font);
                int newHeight = (int)(textSize.Height);
                txtPreview.Height = Math.Max(newHeight, 50); // Tối thiểu 50px
            }
        }

        private void cmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTextPreview();
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTextPreview();
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTextPreview();
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTextPreview();
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTextPreview();
        }

        private void rbLeft_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTextPreview();
        }

        private void rbCenter_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTextPreview();
        }

        private void rbRight_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTextPreview();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = btnColor.BackColor;
            
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = colorDialog.Color;
                UpdateTextPreview();
            }
        }
    }
}