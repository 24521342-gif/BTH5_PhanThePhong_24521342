namespace Bai05
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblDashStyle = new System.Windows.Forms.Label();
            this.cmbDashStyle = new System.Windows.Forms.ComboBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.cmbWidth = new System.Windows.Forms.ComboBox();
            this.lblLineJoin = new System.Windows.Forms.Label();
            this.cmbLineJoin = new System.Windows.Forms.ComboBox();
            this.lblDashCap = new System.Windows.Forms.Label();
            this.cmbDashCap = new System.Windows.Forms.ComboBox();
            this.lblStartCap = new System.Windows.Forms.Label();
            this.cmbStartCap = new System.Windows.Forms.ComboBox();
            this.lblEndCap = new System.Windows.Forms.Label();
            this.cmbEndCap = new System.Windows.Forms.ComboBox();
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblDashStyle
            // 
            this.lblDashStyle.AutoSize = true;
            this.lblDashStyle.Location = new System.Drawing.Point(15, 20);
            this.lblDashStyle.Name = "lblDashStyle";
            this.lblDashStyle.Size = new System.Drawing.Size(70, 15);
            this.lblDashStyle.TabIndex = 0;
            this.lblDashStyle.Text = "Dash Style :";
            // 
            // cmbDashStyle
            // 
            this.cmbDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDashStyle.FormattingEnabled = true;
            this.cmbDashStyle.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "DashDot",
            "DashDotDot",
            "Custom"});
            this.cmbDashStyle.Location = new System.Drawing.Point(100, 17);
            this.cmbDashStyle.Name = "cmbDashStyle";
            this.cmbDashStyle.Size = new System.Drawing.Size(200, 23);
            this.cmbDashStyle.TabIndex = 1;
            this.cmbDashStyle.SelectedIndexChanged += new System.EventHandler(this.OnSettingChanged);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(15, 60);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(45, 15);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Width :";
            // 
            // cmbWidth
            // 
            this.cmbWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWidth.FormattingEnabled = true;
            this.cmbWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "5",
            "8",
            "10",
            "15"});
            this.cmbWidth.Location = new System.Drawing.Point(100, 57);
            this.cmbWidth.Name = "cmbWidth";
            this.cmbWidth.Size = new System.Drawing.Size(200, 23);
            this.cmbWidth.TabIndex = 3;
            this.cmbWidth.SelectedIndexChanged += new System.EventHandler(this.OnSettingChanged);
            // 
            // lblLineJoin
            // 
            this.lblLineJoin.AutoSize = true;
            this.lblLineJoin.Location = new System.Drawing.Point(15, 100);
            this.lblLineJoin.Name = "lblLineJoin";
            this.lblLineJoin.Size = new System.Drawing.Size(63, 15);
            this.lblLineJoin.TabIndex = 4;
            this.lblLineJoin.Text = "Line Join :";
            // 
            // cmbLineJoin
            // 
            this.cmbLineJoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLineJoin.FormattingEnabled = true;
            this.cmbLineJoin.Items.AddRange(new object[] {
            "Miter",
            "Bevel",
            "Round",
            "MiterClipped"});
            this.cmbLineJoin.Location = new System.Drawing.Point(100, 97);
            this.cmbLineJoin.Name = "cmbLineJoin";
            this.cmbLineJoin.Size = new System.Drawing.Size(200, 23);
            this.cmbLineJoin.TabIndex = 5;
            this.cmbLineJoin.SelectedIndexChanged += new System.EventHandler(this.OnSettingChanged);
            // 
            // lblDashCap
            // 
            this.lblDashCap.AutoSize = true;
            this.lblDashCap.Location = new System.Drawing.Point(15, 140);
            this.lblDashCap.Name = "lblDashCap";
            this.lblDashCap.Size = new System.Drawing.Size(68, 15);
            this.lblDashCap.TabIndex = 6;
            this.lblDashCap.Text = "Dash Cap :";
            // 
            // cmbDashCap
            // 
            this.cmbDashCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDashCap.FormattingEnabled = true;
            this.cmbDashCap.Items.AddRange(new object[] {
            "Flat",
            "Round",
            "Triangle"});
            this.cmbDashCap.Location = new System.Drawing.Point(100, 137);
            this.cmbDashCap.Name = "cmbDashCap";
            this.cmbDashCap.Size = new System.Drawing.Size(200, 23);
            this.cmbDashCap.TabIndex = 7;
            this.cmbDashCap.SelectedIndexChanged += new System.EventHandler(this.OnSettingChanged);
            // 
            // lblStartCap
            // 
            this.lblStartCap.AutoSize = true;
            this.lblStartCap.Location = new System.Drawing.Point(15, 180);
            this.lblStartCap.Name = "lblStartCap";
            this.lblStartCap.Size = new System.Drawing.Size(65, 15);
            this.lblStartCap.TabIndex = 8;
            this.lblStartCap.Text = "Start Cap :";
            // 
            // cmbStartCap
            // 
            this.cmbStartCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartCap.FormattingEnabled = true;
            this.cmbStartCap.Items.AddRange(new object[] {
            "Flat",
            "Square",
            "Round",
            "Triangle",
            "NoAnchor",
            "SquareAnchor",
            "RoundAnchor",
            "DiamondAnchor",
            "ArrowAnchor"});
            this.cmbStartCap.Location = new System.Drawing.Point(100, 177);
            this.cmbStartCap.Name = "cmbStartCap";
            this.cmbStartCap.Size = new System.Drawing.Size(200, 23);
            this.cmbStartCap.TabIndex = 9;
            this.cmbStartCap.SelectedIndexChanged += new System.EventHandler(this.OnSettingChanged);
            // 
            // lblEndCap
            // 
            this.lblEndCap.AutoSize = true;
            this.lblEndCap.Location = new System.Drawing.Point(15, 220);
            this.lblEndCap.Name = "lblEndCap";
            this.lblEndCap.Size = new System.Drawing.Size(60, 15);
            this.lblEndCap.TabIndex = 10;
            this.lblEndCap.Text = "End Cap :";
            // 
            // cmbEndCap
            // 
            this.cmbEndCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEndCap.FormattingEnabled = true;
            this.cmbEndCap.Items.AddRange(new object[] {
            "Flat",
            "Square",
            "Round",
            "Triangle",
            "NoAnchor",
            "SquareAnchor",
            "RoundAnchor",
            "DiamondAnchor",
            "ArrowAnchor"});
            this.cmbEndCap.Location = new System.Drawing.Point(100, 217);
            this.cmbEndCap.Name = "cmbEndCap";
            this.cmbEndCap.Size = new System.Drawing.Size(200, 23);
            this.cmbEndCap.TabIndex = 11;
            this.cmbEndCap.SelectedIndexChanged += new System.EventHandler(this.OnSettingChanged);
            // 
            // panelCanvas
            // 
            this.panelCanvas.BackColor = System.Drawing.Color.White;
            this.panelCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCanvas.Location = new System.Drawing.Point(330, 17);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(420, 500);
            this.panelCanvas.TabIndex = 12;
            this.panelCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCanvas_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 540);
            this.Controls.Add(this.panelCanvas);
            this.Controls.Add(this.cmbEndCap);
            this.Controls.Add(this.lblEndCap);
            this.Controls.Add(this.cmbStartCap);
            this.Controls.Add(this.lblStartCap);
            this.Controls.Add(this.cmbDashCap);
            this.Controls.Add(this.lblDashCap);
            this.Controls.Add(this.cmbLineJoin);
            this.Controls.Add(this.lblLineJoin);
            this.Controls.Add(this.cmbWidth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.cmbDashStyle);
            this.Controls.Add(this.lblDashStyle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pen Demo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblDashStyle;
        private System.Windows.Forms.ComboBox cmbDashStyle;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.ComboBox cmbWidth;
        private System.Windows.Forms.Label lblLineJoin;
        private System.Windows.Forms.ComboBox cmbLineJoin;
        private System.Windows.Forms.Label lblDashCap;
        private System.Windows.Forms.ComboBox cmbDashCap;
        private System.Windows.Forms.Label lblStartCap;
        private System.Windows.Forms.ComboBox cmbStartCap;
        private System.Windows.Forms.Label lblEndCap;
        private System.Windows.Forms.ComboBox cmbEndCap;
        private System.Windows.Forms.Panel panelCanvas;
    }
}