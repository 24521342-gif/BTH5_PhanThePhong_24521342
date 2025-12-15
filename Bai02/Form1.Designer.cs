namespace Bai02
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstFonts;

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
            this.lstFonts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            
            // lstFonts
            this.lstFonts.BackColor = System.Drawing.Color.White;
            this.lstFonts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstFonts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFonts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lstFonts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstFonts.FormattingEnabled = true;
            this.lstFonts.ItemHeight = 35;
            this.lstFonts.Location = new System.Drawing.Point(10, 10);
            this.lstFonts.Name = "lstFonts";
            this.lstFonts.Size = new System.Drawing.Size(644, 441);
            this.lstFonts.TabIndex = 0;
            this.lstFonts.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstFonts_DrawItem);
            this.lstFonts.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lstFonts_MeasureItem);
            this.lstFonts.SelectedIndexChanged += new System.EventHandler(this.lstFonts_SelectedIndexChanged);
            
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(664, 461);
            this.Controls.Add(this.lstFonts);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Fonts";
            this.ResumeLayout(false);
        }
    }
}