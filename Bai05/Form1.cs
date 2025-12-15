using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeCustomSettings();
        }

        private void InitializeCustomSettings()
        {
            // Khởi tạo giá trị mặc định
            cmbDashStyle.SelectedIndex = 0;
            cmbWidth.SelectedIndex = 2; // Width = 3
            cmbLineJoin.SelectedIndex = 0;
            cmbDashCap.SelectedIndex = 0;
            cmbStartCap.SelectedIndex = 0;
            cmbEndCap.SelectedIndex = 0;
        }

        private void panelCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            // Tạo Pen với các thuộc tính đã chọn
            Pen pen = new Pen(Color.Red, float.Parse(cmbWidth.Text));

            // Thiết lập DashStyle
            if (cmbDashStyle.Text == "Custom")
            {
                pen.DashStyle = DashStyle.Custom;
                pen.DashPattern = new float[] { 4, 2, 1, 2 }; // Custom pattern: dash-gap-dot-gap
            }
            else
            {
                pen.DashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), cmbDashStyle.Text);
            }

            // Thiết lập Line Join
            pen.LineJoin = (LineJoin)Enum.Parse(typeof(LineJoin), cmbLineJoin.Text);

            // Thiết lập Dash Cap
            pen.DashCap = (DashCap)Enum.Parse(typeof(DashCap), cmbDashCap.Text);

            // Thiết lập Start Cap
            pen.StartCap = (LineCap)Enum.Parse(typeof(LineCap), cmbStartCap.Text);

            // Thiết lập End Cap
            pen.EndCap = (LineCap)Enum.Parse(typeof(LineCap), cmbEndCap.Text);

            // VẼ ĐƯỜNG THẲNG XIÊN (Start Cap)
            g.DrawLine(pen, 50, 50, 350, 150);

            // VẼ ĐƯỜNG GẤP KHÚC (End Cap và Line Join)
            Point[] points1 = new Point[]
            {
                new Point(50, 200),
                new Point(100, 250),
                new Point(150, 200),
                new Point(200, 280),
                new Point(250, 220),
                new Point(300, 300),
                new Point(350, 250)
            };
            g.DrawLines(pen, points1);

            // VẼ ĐƯỜNG GẤP KHÚC THỨ 2 (Dash Style)
            Point[] points2 = new Point[]
            {
                new Point(50, 350),
                new Point(80, 380),
                new Point(110, 350),
                new Point(140, 400),
                new Point(170, 360),
                new Point(200, 420),
                new Point(230, 370),
                new Point(260, 440),
                new Point(290, 380),
                new Point(320, 450),
                new Point(350, 400)
            };
            g.DrawLines(pen, points2);

            pen.Dispose();
        }

        private void OnSettingChanged(object sender, EventArgs e)
        {
            // Vẽ lại khi có thay đổi
            panelCanvas.Invalidate();
        }
    }
}