using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        private bool isDrawing = false;
        private Point startPoint;
        private Color penColor = Color.Black;
        private Bitmap canvasBitmap;
        private Graphics canvasGraphics;

        public Form1()
        {
            InitializeComponent();
            InitializeCanvas();
        }

        private void InitializeCanvas()
        {
            canvasBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            canvasGraphics = Graphics.FromImage(canvasBitmap);
            canvasGraphics.Clear(Color.White);
            pictureBox.Image = canvasBitmap;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                penColor = colorDialog.Color;
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                startPoint = e.Location;
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                // Redraw the canvas
                pictureBox.Invalidate();
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                isDrawing = false;
                Point endPoint = e.Location;

                // Draw on the bitmap permanently
                DrawShape(canvasGraphics, startPoint, endPoint);
                pictureBox.Image = canvasBitmap;
            }
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (isDrawing)
            {
                Point currentPoint = pictureBox.PointToClient(Cursor.Position);
                DrawShape(e.Graphics, startPoint, currentPoint);
            }
        }

        private void DrawShape(Graphics g, Point start, Point end)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            if (rdLine.Checked)
            {
                // Draw Line
                int width = 1;
                if (!string.IsNullOrWhiteSpace(txtWidth.Text))
                {
                    int.TryParse(txtWidth.Text, out width);
                }
                
                using (Pen pen = new Pen(penColor, width))
                {
                    g.DrawLine(pen, start, end);
                }
            }
            else
            {
                // Calculate rectangle bounds
                int x = Math.Min(start.X, end.X);
                int y = Math.Min(start.Y, end.Y);
                int width = Math.Abs(end.X - start.X);
                int height = Math.Abs(end.Y - start.Y);
                Rectangle rect = new Rectangle(x, y, width, height);

                if (width > 0 && height > 0)
                {
                    Brush brush = GetSelectedBrush(rect);
                    
                    if (rdRectangle.Checked)
                    {
                        g.FillRectangle(brush, rect);
                    }
                    else if (rdEllipse.Checked)
                    {
                        g.FillEllipse(brush, rect);
                    }
                    
                    brush.Dispose();
                }
            }
        }

        private Brush GetSelectedBrush(Rectangle rect)
        {
            if (rdSolidBrush.Checked)
            {
                return new SolidBrush(Color.Green);
            }
            else if (rdHatchBrush.Checked)
            {
                return new HatchBrush(HatchStyle.Horizontal, Color.Blue, Color.Green);
            }
            else if (rdTextureBrush.Checked)
            {
                // Create a simple pattern bitmap
                Bitmap textureBitmap = new Bitmap(16, 16);
                using (Graphics g = Graphics.FromImage(textureBitmap))
                {
                    g.Clear(Color.White);
                    using (Pen pen = new Pen(Color.Blue, 1))
                    {
                        // Draw a simple pattern
                        for (int i = 0; i < 16; i += 4)
                        {
                            g.DrawLine(pen, i, 0, i, 16);
                            g.DrawLine(pen, 0, i, 16, i);
                        }
                        // Draw diagonal crosses
                        g.DrawLine(pen, 0, 0, 16, 16);
                        g.DrawLine(pen, 16, 0, 0, 16);
                    }
                }
                return new TextureBrush(textureBitmap);
            }
            else if (rdLinearGradient.Checked)
            {
                if (rect.Height > 0)
                {
                    return new LinearGradientBrush(rect, Color.Red, Color.Green, LinearGradientMode.Vertical);
                }
                return new SolidBrush(Color.Green);
            }

            return new SolidBrush(Color.Green);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Set default selections
            rdLine.Checked = true;
            rdHatchBrush.Checked = true;
            txtWidth.Text = "1";
        }
    }
}