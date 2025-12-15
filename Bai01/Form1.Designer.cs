namespace Bai01
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.ComboBox cmbFont;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkUnderline;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.GroupBox grpAlign;
        private System.Windows.Forms.RadioButton rbLeft;
        private System.Windows.Forms.RadioButton rbCenter;
        private System.Windows.Forms.RadioButton rbRight;
        private System.Windows.Forms.TextBox txtPreview;

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
            this.lblFont = new System.Windows.Forms.Label();
            this.cmbFont = new System.Windows.Forms.ComboBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkUnderline = new System.Windows.Forms.CheckBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.grpAlign = new System.Windows.Forms.GroupBox();
            this.rbLeft = new System.Windows.Forms.RadioButton();
            this.rbCenter = new System.Windows.Forms.RadioButton();
            this.rbRight = new System.Windows.Forms.RadioButton();
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.grpAlign.SuspendLayout();
            this.SuspendLayout();
            
            // lblFont
            this.lblFont.AutoSize = true;
            this.lblFont.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFont.Location = new System.Drawing.Point(30, 30);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(36, 19);
            this.lblFont.TabIndex = 0;
            this.lblFont.Text = "Font";
            
            // cmbFont
            this.cmbFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFont.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbFont.FormattingEnabled = true;
            this.cmbFont.Location = new System.Drawing.Point(80, 28);
            this.cmbFont.Name = "cmbFont";
            this.cmbFont.Size = new System.Drawing.Size(200, 23);
            this.cmbFont.TabIndex = 1;
            this.cmbFont.SelectedIndexChanged += new System.EventHandler(this.cmbFont_SelectedIndexChanged);
            
            // lblSize
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSize.Location = new System.Drawing.Point(320, 30);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(33, 19);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Size";
            
            // cmbSize
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Location = new System.Drawing.Point(370, 28);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(100, 23);
            this.cmbSize.TabIndex = 3;
            this.cmbSize.SelectedIndexChanged += new System.EventHandler(this.cmbSize_SelectedIndexChanged);
            
            // chkBold
            this.chkBold.AutoSize = true;
            this.chkBold.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.chkBold.Location = new System.Drawing.Point(30, 75);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(35, 23);
            this.chkBold.TabIndex = 4;
            this.chkBold.Text = "B";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            
            // chkItalic
            this.chkItalic.AutoSize = true;
            this.chkItalic.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.chkItalic.Location = new System.Drawing.Point(90, 75);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(30, 23);
            this.chkItalic.TabIndex = 5;
            this.chkItalic.Text = "I";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            
            // chkUnderline
            this.chkUnderline.AutoSize = true;
            this.chkUnderline.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline);
            this.chkUnderline.Location = new System.Drawing.Point(150, 75);
            this.chkUnderline.Name = "chkUnderline";
            this.chkUnderline.Size = new System.Drawing.Size(36, 23);
            this.chkUnderline.TabIndex = 6;
            this.chkUnderline.Text = "U";
            this.chkUnderline.UseVisualStyleBackColor = true;
            this.chkUnderline.CheckedChanged += new System.EventHandler(this.chkUnderline_CheckedChanged);
            
            // lblColor
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblColor.Location = new System.Drawing.Point(310, 76);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(42, 19);
            this.lblColor.TabIndex = 7;
            this.lblColor.Text = "Color";
            
            // btnColor
            this.btnColor.BackColor = System.Drawing.Color.Black;
            this.btnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Location = new System.Drawing.Point(370, 70);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(80, 30);
            this.btnColor.TabIndex = 8;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            
            // grpAlign
            this.grpAlign.Controls.Add(this.rbLeft);
            this.grpAlign.Controls.Add(this.rbCenter);
            this.grpAlign.Controls.Add(this.rbRight);
            this.grpAlign.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpAlign.Location = new System.Drawing.Point(30, 120);
            this.grpAlign.Name = "grpAlign";
            this.grpAlign.Size = new System.Drawing.Size(200, 120);
            this.grpAlign.TabIndex = 9;
            this.grpAlign.TabStop = false;
            this.grpAlign.Text = "Align Text";
            
            // rbLeft
            this.rbLeft.AutoSize = true;
            this.rbLeft.Location = new System.Drawing.Point(20, 30);
            this.rbLeft.Name = "rbLeft";
            this.rbLeft.Size = new System.Drawing.Size(45, 19);
            this.rbLeft.TabIndex = 0;
            this.rbLeft.Text = "Left";
            this.rbLeft.UseVisualStyleBackColor = true;
            this.rbLeft.CheckedChanged += new System.EventHandler(this.rbLeft_CheckedChanged);
            
            // rbCenter
            this.rbCenter.AutoSize = true;
            this.rbCenter.Checked = true;
            this.rbCenter.Location = new System.Drawing.Point(20, 60);
            this.rbCenter.Name = "rbCenter";
            this.rbCenter.Size = new System.Drawing.Size(61, 19);
            this.rbCenter.TabIndex = 1;
            this.rbCenter.TabStop = true;
            this.rbCenter.Text = "Center";
            this.rbCenter.UseVisualStyleBackColor = true;
            this.rbCenter.CheckedChanged += new System.EventHandler(this.rbCenter_CheckedChanged);
            
            // rbRight
            this.rbRight.AutoSize = true;
            this.rbRight.Location = new System.Drawing.Point(20, 90);
            this.rbRight.Name = "rbRight";
            this.rbRight.Size = new System.Drawing.Size(54, 19);
            this.rbRight.TabIndex = 2;
            this.rbRight.Text = "Right";
            this.rbRight.UseVisualStyleBackColor = true;
            this.rbRight.CheckedChanged += new System.EventHandler(this.rbRight_CheckedChanged);
            
            // txtPreview
            this.txtPreview.BackColor = System.Drawing.Color.White;
            this.txtPreview.ForeColor = System.Drawing.Color.Black;
            this.txtPreview.Location = new System.Drawing.Point(250, 140);
            this.txtPreview.Multiline = true;
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.Size = new System.Drawing.Size(300, 10);
            this.txtPreview.TabIndex = 10;
            this.txtPreview.Text = "Hello";
            this.txtPreview.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 281);
            this.Controls.Add(this.txtPreview);
            this.Controls.Add(this.grpAlign);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.chkUnderline);
            this.Controls.Add(this.chkItalic);
            this.Controls.Add(this.chkBold);
            this.Controls.Add(this.cmbSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.cmbFont);
            this.Controls.Add(this.lblFont);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Font Text Editor";
            this.grpAlign.ResumeLayout(false);
            this.grpAlign.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}