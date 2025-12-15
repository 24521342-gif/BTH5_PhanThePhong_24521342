namespace Bai04
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbShapes;
        private System.Windows.Forms.Panel panelDraw;

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
            this.cmbShapes = new System.Windows.Forms.ComboBox();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            
            // cmbShapes
            this.cmbShapes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShapes.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbShapes.FormattingEnabled = true;
            this.cmbShapes.Location = new System.Drawing.Point(30, 20);
            this.cmbShapes.Name = "cmbShapes";
            this.cmbShapes.Size = new System.Drawing.Size(200, 28);
            this.cmbShapes.TabIndex = 0;
            this.cmbShapes.SelectedIndexChanged += new System.EventHandler(this.cmbShapes_SelectedIndexChanged);
            
            // panelDraw
            this.panelDraw.BackColor = System.Drawing.Color.White;
            this.panelDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDraw.Location = new System.Drawing.Point(30, 60);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(350, 300);
            this.panelDraw.TabIndex = 1;
            this.panelDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDraw_Paint);
            
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 381);
            this.Controls.Add(this.panelDraw);
            this.Controls.Add(this.cmbShapes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBoxTest";
            this.ResumeLayout(false);
        }
    }
}