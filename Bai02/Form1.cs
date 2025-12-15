using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadAllFonts();
        }

        private void LoadAllFonts()
        {
            try
            {
                // Xóa các item cũ nếu có
                lstFonts.Items.Clear();

                // Lấy tất cả font trong hệ thống
                InstalledFontCollection installedFonts = new InstalledFontCollection();
                
                foreach (FontFamily fontFamily in installedFonts.Families)
                {
                    try
                    {
                        // Thêm font vào ListBox
                        lstFonts.Items.Add(fontFamily.Name);
                    }
                    catch
                    {
                        // Bỏ qua font không hợp lệ
                    }
                }

                // Hiển thị tổng số font
                this.Text = $"All Fonts ({lstFonts.Items.Count} fonts)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải font: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstFonts_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            // Vẽ background
            e.DrawBackground();

            try
            {
                string fontName = lstFonts.Items[e.Index].ToString();
                
                // Tạo font với tên font tương ứng
                Font itemFont = new Font(fontName, 14, FontStyle.Regular);
                
                // Vẽ tên font với chính font đó
                using (SolidBrush brush = new SolidBrush(e.ForeColor))
                {
                    e.Graphics.DrawString("." + fontName, itemFont, brush, e.Bounds.Left + 5, e.Bounds.Top + 2);
                }
                
                itemFont.Dispose();
            }
            catch
            {
                // Nếu font không vẽ được, dùng font mặc định
                using (SolidBrush brush = new SolidBrush(e.ForeColor))
                {
                    e.Graphics.DrawString("." + lstFonts.Items[e.Index].ToString(), 
                        e.Font, brush, e.Bounds.Left + 5, e.Bounds.Top + 2);
                }
            }

            e.DrawFocusRectangle();
        }

        private void lstFonts_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 35;
        }

        private void lstFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFonts.SelectedIndex >= 0)
            {
                string selectedFont = lstFonts.SelectedItem.ToString();
            }
        }
    }
}