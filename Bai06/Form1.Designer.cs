namespace Bai06
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox grpShapes;
        private System.Windows.Forms.RadioButton rdLine;
        private System.Windows.Forms.RadioButton rdRectangle;
        private System.Windows.Forms.RadioButton rdEllipse;
        private System.Windows.Forms.GroupBox grpPen;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.GroupBox grpBrushes;
        private System.Windows.Forms.RadioButton rdSolidBrush;
        private System.Windows.Forms.RadioButton rdHatchBrush;
        private System.Windows.Forms.RadioButton rdTextureBrush;
        private System.Windows.Forms.RadioButton rdLinearGradient;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.grpBrushes = new System.Windows.Forms.GroupBox();
            this.rdLinearGradient = new System.Windows.Forms.RadioButton();
            this.rdTextureBrush = new System.Windows.Forms.RadioButton();
            this.rdHatchBrush = new System.Windows.Forms.RadioButton();
            this.rdSolidBrush = new System.Windows.Forms.RadioButton();
            this.grpPen = new System.Windows.Forms.GroupBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.grpShapes = new System.Windows.Forms.GroupBox();
            this.rdEllipse = new System.Windows.Forms.RadioButton();
            this.rdRectangle = new System.Windows.Forms.RadioButton();
            this.rdLine = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.grpBrushes.SuspendLayout();
            this.grpPen.SuspendLayout();
            this.grpShapes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(250, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(784, 561);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.panelLeft.Controls.Add(this.grpBrushes);
            this.panelLeft.Controls.Add(this.grpPen);
            this.panelLeft.Controls.Add(this.grpShapes);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(250, 561);
            this.panelLeft.TabIndex = 1;
            // 
            // grpBrushes
            // 
            this.grpBrushes.Controls.Add(this.rdLinearGradient);
            this.grpBrushes.Controls.Add(this.rdTextureBrush);
            this.grpBrushes.Controls.Add(this.rdHatchBrush);
            this.grpBrushes.Controls.Add(this.rdSolidBrush);
            this.grpBrushes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpBrushes.Location = new System.Drawing.Point(12, 280);
            this.grpBrushes.Name = "grpBrushes";
            this.grpBrushes.Size = new System.Drawing.Size(225, 180);
            this.grpBrushes.TabIndex = 2;
            this.grpBrushes.TabStop = false;
            this.grpBrushes.Text = "Brushes";
            // 
            // rdLinearGradient
            // 
            this.rdLinearGradient.AutoSize = true;
            this.rdLinearGradient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdLinearGradient.Location = new System.Drawing.Point(15, 135);
            this.rdLinearGradient.Name = "rdLinearGradient";
            this.rdLinearGradient.Size = new System.Drawing.Size(145, 19);
            this.rdLinearGradient.TabIndex = 3;
            this.rdLinearGradient.Text = "LinearGradientBrush";
            this.rdLinearGradient.UseVisualStyleBackColor = true;
            // 
            // rdTextureBrush
            // 
            this.rdTextureBrush.AutoSize = true;
            this.rdTextureBrush.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdTextureBrush.Location = new System.Drawing.Point(15, 100);
            this.rdTextureBrush.Name = "rdTextureBrush";
            this.rdTextureBrush.Size = new System.Drawing.Size(101, 19);
            this.rdTextureBrush.TabIndex = 2;
            this.rdTextureBrush.Text = "TextureBrush";
            this.rdTextureBrush.UseVisualStyleBackColor = true;
            // 
            // rdHatchBrush
            // 
            this.rdHatchBrush.AutoSize = true;
            this.rdHatchBrush.Checked = true;
            this.rdHatchBrush.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdHatchBrush.Location = new System.Drawing.Point(15, 65);
            this.rdHatchBrush.Name = "rdHatchBrush";
            this.rdHatchBrush.Size = new System.Drawing.Size(92, 19);
            this.rdHatchBrush.TabIndex = 1;
            this.rdHatchBrush.TabStop = true;
            this.rdHatchBrush.Text = "HatchBrush";
            this.rdHatchBrush.UseVisualStyleBackColor = true;
            // 
            // rdSolidBrush
            // 
            this.rdSolidBrush.AutoSize = true;
            this.rdSolidBrush.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdSolidBrush.Location = new System.Drawing.Point(15, 30);
            this.rdSolidBrush.Name = "rdSolidBrush";
            this.rdSolidBrush.Size = new System.Drawing.Size(85, 19);
            this.rdSolidBrush.TabIndex = 0;
            this.rdSolidBrush.Text = "SolidBrush";
            this.rdSolidBrush.UseVisualStyleBackColor = true;
            // 
            // grpPen
            // 
            this.grpPen.Controls.Add(this.btnColor);
            this.grpPen.Controls.Add(this.txtWidth);
            this.grpPen.Controls.Add(this.lblWidth);
            this.grpPen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpPen.Location = new System.Drawing.Point(12, 160);
            this.grpPen.Name = "grpPen";
            this.grpPen.Size = new System.Drawing.Size(225, 100);
            this.grpPen.TabIndex = 1;
            this.grpPen.TabStop = false;
            this.grpPen.Text = "Pen";
            // 
            // btnColor
            // 
            this.btnColor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnColor.Location = new System.Drawing.Point(60, 60);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(100, 28);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "Color...";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtWidth.Location = new System.Drawing.Point(80, 25);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(80, 23);
            this.txtWidth.TabIndex = 1;
            this.txtWidth.Text = "1";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblWidth.Location = new System.Drawing.Point(15, 28);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(45, 15);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "Width :";
            // 
            // grpShapes
            // 
            this.grpShapes.Controls.Add(this.rdEllipse);
            this.grpShapes.Controls.Add(this.rdRectangle);
            this.grpShapes.Controls.Add(this.rdLine);
            this.grpShapes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpShapes.Location = new System.Drawing.Point(12, 20);
            this.grpShapes.Name = "grpShapes";
            this.grpShapes.Size = new System.Drawing.Size(225, 120);
            this.grpShapes.TabIndex = 0;
            this.grpShapes.TabStop = false;
            this.grpShapes.Text = "Shapes";
            // 
            // rdEllipse
            // 
            this.rdEllipse.AutoSize = true;
            this.rdEllipse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdEllipse.Location = new System.Drawing.Point(15, 85);
            this.rdEllipse.Name = "rdEllipse";
            this.rdEllipse.Size = new System.Drawing.Size(59, 19);
            this.rdEllipse.TabIndex = 2;
            this.rdEllipse.Text = "Ellipse";
            this.rdEllipse.UseVisualStyleBackColor = true;
            // 
            // rdRectangle
            // 
            this.rdRectangle.AutoSize = true;
            this.rdRectangle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdRectangle.Location = new System.Drawing.Point(15, 55);
            this.rdRectangle.Name = "rdRectangle";
            this.rdRectangle.Size = new System.Drawing.Size(79, 19);
            this.rdRectangle.TabIndex = 1;
            this.rdRectangle.Text = "Rectangle";
            this.rdRectangle.UseVisualStyleBackColor = true;
            // 
            // rdLine
            // 
            this.rdLine.AutoSize = true;
            this.rdLine.Checked = true;
            this.rdLine.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdLine.Location = new System.Drawing.Point(15, 25);
            this.rdLine.Name = "rdLine";
            this.rdLine.Size = new System.Drawing.Size(46, 19);
            this.rdLine.TabIndex = 0;
            this.rdLine.TabStop = true;
            this.rdLine.Text = "Line";
            this.rdLine.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai Thi";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.grpBrushes.ResumeLayout(false);
            this.grpBrushes.PerformLayout();
            this.grpPen.ResumeLayout(false);
            this.grpPen.PerformLayout();
            this.grpShapes.ResumeLayout(false);
            this.grpShapes.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}