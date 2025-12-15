using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Bai03
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private Point centerPoint;
        private int clockRadius;

        public Form1()
        {
            InitializeComponent();
            InitializeClock();
        }

        private void InitializeClock()
        {
            // Thiết lập Timer để cập nhật mỗi giây
            timer = new Timer();
            timer.Interval = 1000; // 1 giây
            timer.Tick += Timer_Tick;
            timer.Start();

            // Thiết lập DoubleBuffered để tránh nháy hình
            this.SetStyle(ControlStyles.DoubleBuffer | 
                         ControlStyles.UserPaint | 
                         ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Vẽ lại đồng hồ mỗi giây
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Tính toán tâm và bán kính đồng hồ
            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height;
            centerPoint = new Point(width / 2, height / 2);
            clockRadius = Math.Min(width, height) / 2 - 20;

            // Vẽ đồng hồ
            DrawClockFace(g);
            DrawClockHands(g);
        }

        private void DrawClockFace(Graphics g)
        {
            // Vẽ nền đen
            g.Clear(Color.Black);

            // Vẽ các chấm giờ (12 chấm lớn)
            for (int i = 0; i < 12; i++)
            {
                double angle = i * 30 * Math.PI / 180; // 30 độ mỗi giờ
                
                // Vị trí chấm lớn
                int x = centerPoint.X + (int)(clockRadius * Math.Sin(angle));
                int y = centerPoint.Y - (int)(clockRadius * Math.Cos(angle));
                
                // Vẽ chấm lớn (hình tròn trắng)
                int dotSize = 20;
                g.FillEllipse(Brushes.White, x - dotSize / 2, y - dotSize / 2, dotSize, dotSize);
            }

            // Vẽ các chấm phút (60 chấm nhỏ, trừ 12 vị trí đã có chấm lớn)
            for (int i = 0; i < 60; i++)
            {
                if (i % 5 != 0) // Bỏ qua vị trí đã có chấm giờ
                {
                    double angle = i * 6 * Math.PI / 180; // 6 độ mỗi phút
                    
                    // Vị trí chấm nhỏ
                    int x = centerPoint.X + (int)(clockRadius * Math.Sin(angle));
                    int y = centerPoint.Y - (int)(clockRadius * Math.Cos(angle));
                    
                    // Vẽ chấm nhỏ
                    int dotSize = 6;
                    g.FillEllipse(Brushes.White, x - dotSize / 2, y - dotSize / 2, dotSize, dotSize);
                }
            }
        }

        private void DrawClockHands(Graphics g)
        {
            DateTime now = DateTime.Now;
            
            // Góc cho từng kim (tính từ 12 giờ, theo chiều kim đồng hồ)
            double hourAngle = (now.Hour % 12 + now.Minute / 60.0) * 30 * Math.PI / 180;
            double minuteAngle = (now.Minute + now.Second / 60.0) * 6 * Math.PI / 180;
            double secondAngle = now.Second * 6 * Math.PI / 180;

            // Vẽ kim giờ (ngắn, dày)
            DrawHand(g, hourAngle, clockRadius * 0.5, 8, Color.White);
            
            // Vẽ kim phút (dài hơn, mỏng hơn)
            DrawHand(g, minuteAngle, clockRadius * 0.7, 6, Color.White);
            
            // Vẽ kim giây (dài nhất, mỏng nhất)
            DrawHand(g, secondAngle, clockRadius * 0.8, 2, Color.White);

            // Vẽ tâm đồng hồ
            g.FillEllipse(Brushes.White, centerPoint.X - 8, centerPoint.Y - 8, 16, 16);
        }

        private void DrawHand(Graphics g, double angle, double length, int width, Color color)
        {
            // Tính điểm cuối của kim
            int x = centerPoint.X + (int)(length * Math.Sin(angle));
            int y = centerPoint.Y - (int)(length * Math.Cos(angle));

            // Vẽ kim với độ dày tùy chỉnh
            using (Pen pen = new Pen(color, width))
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                g.DrawLine(pen, centerPoint, new Point(x, y));
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
            }
            base.OnFormClosing(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate(); // Vẽ lại khi thay đổi kích thước
        }
    }
}