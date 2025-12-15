using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        private string selectedShape = "Filled Ellipse";

        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            // Thêm các lựa chọn vào ComboBox
            cmbShapes.Items.AddRange(new string[]
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

            // Chọn mặc định
            cmbShapes.SelectedIndex = 6; // Filled Ellipse
        }

        private void cmbShapes_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedShape = cmbShapes.SelectedItem.ToString();
            panelDraw.Invalidate(); // Vẽ lại panel
        }

        private void panelDraw_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Tính toán vị trí và kích thước để vẽ hình ở giữa
            int width = panelDraw.Width;
            int height = panelDraw.Height;
            int centerX = width / 2;
            int centerY = height / 2;

            // Kích thước hình
            int shapeWidth = 200;
            int shapeHeight = 150;

            // Rectangle cho hình
            Rectangle rect = new Rectangle(
                centerX - shapeWidth / 2,
                centerY - shapeHeight / 2,
                shapeWidth,
                shapeHeight
            );

            // Màu vẽ
            Color fillColor = Color.DarkRed;
            Pen pen = new Pen(Color.Black, 2);
            Brush brush = new SolidBrush(fillColor);

            // Vẽ hình tùy theo lựa chọn
            switch (selectedShape)
            {
                case "Circle":
                    int circleDiameter = Math.Min(shapeWidth, shapeHeight);
                    Rectangle circleRect = new Rectangle(
                        centerX - circleDiameter / 2,
                        centerY - circleDiameter / 2,
                        circleDiameter,
                        circleDiameter
                    );
                    g.DrawEllipse(pen, circleRect);
                    break;

                case "Square":
                    int squareSize = Math.Min(shapeWidth, shapeHeight);
                    Rectangle squareRect = new Rectangle(
                        centerX - squareSize / 2,
                        centerY - squareSize / 2,
                        squareSize,
                        squareSize
                    );
                    g.DrawRectangle(pen, squareRect);
                    break;

                case "Ellipse":
                    g.DrawEllipse(pen, rect);
                    break;

                case "Pie":
                    g.DrawPie(pen, rect, 0, 270); // Vẽ 3/4 hình tròn
                    break;

                case "Filled Circle":
                    int filledCircleDiameter = Math.Min(shapeWidth, shapeHeight);
                    Rectangle filledCircleRect = new Rectangle(
                        centerX - filledCircleDiameter / 2,
                        centerY - filledCircleDiameter / 2,
                        filledCircleDiameter,
                        filledCircleDiameter
                    );
                    g.FillEllipse(brush, filledCircleRect);
                    break;

                case "Filled Square":
                    int filledSquareSize = Math.Min(shapeWidth, shapeHeight);
                    Rectangle filledSquareRect = new Rectangle(
                        centerX - filledSquareSize / 2,
                        centerY - filledSquareSize / 2,
                        filledSquareSize,
                        filledSquareSize
                    );
                    g.FillRectangle(brush, filledSquareRect);
                    break;

                case "Filled Ellipse":
                    g.FillEllipse(brush, rect);
                    break;

                case "Filled Pie":
                    g.FillPie(brush, rect, 0, 270); // Vẽ 3/4 hình tròn tô màu
                    break;
            }

            pen.Dispose();
            brush.Dispose();
        }
    }
}