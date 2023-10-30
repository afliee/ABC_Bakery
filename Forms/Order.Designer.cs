namespace ABC_Bakery.Forms
{
    partial class Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel7 = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            pictureBox1 = new PictureBox();
            dateTime = new DateTimePicker();
            panel4 = new Panel();
            panel9 = new Panel();
            panel8 = new Panel();
            panel10 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 128);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(1275, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(3, 34);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(249, 555);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(nightControlBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1414, 34);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(1414, 91);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // panel7
            // 
            panel7.Controls.Add(label3);
            panel7.Controls.Add(label2);
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(346, 91);
            panel7.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(24, 51);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 1;
            label3.Text = "No. 01010110\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(24, 3);
            label2.Name = "label2";
            label2.Size = new Size(139, 37);
            label2.TabIndex = 0;
            label2.Text = "Biên Nhận";
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(999, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(415, 91);
            panel5.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel6.AutoScroll = true;
            panel6.AutoSize = true;
            panel6.BackColor = Color.FromArgb(154, 59, 59);
            panel6.Controls.Add(pictureBox1);
            panel6.Controls.Add(dateTime);
            panel6.Location = new Point(3, 21);
            panel6.Name = "panel6";
            panel6.Size = new Size(384, 64);
            panel6.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = Properties.Resources.calender;
            pictureBox1.Location = new Point(17, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // dateTime
            // 
            dateTime.CalendarFont = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dateTime.CalendarForeColor = Color.FromArgb(154, 59, 59);
            dateTime.CalendarMonthBackground = Color.FromArgb(154, 59, 59);
            dateTime.CalendarTitleBackColor = Color.FromArgb(154, 59, 59);
            dateTime.CalendarTitleForeColor = Color.FromArgb(154, 59, 59);
            dateTime.CalendarTrailingForeColor = Color.FromArgb(154, 59, 59);
            dateTime.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dateTime.Location = new Point(112, 12);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(269, 43);
            dateTime.TabIndex = 0;
            dateTime.ValueChanged += dateTime_ValueChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel9);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 125);
            panel4.Name = "panel4";
            panel4.Size = new Size(1386, 798);
            panel4.TabIndex = 6;
            // 
            // panel9
            // 
            panel9.AutoScroll = true;
            panel9.AutoSize = true;
            panel9.BackColor = Color.FromArgb(249, 245, 220);
            panel9.Location = new Point(24, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(793, 710);
            panel9.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel10);
            panel8.Dock = DockStyle.Right;
            panel8.Location = new Point(999, 125);
            panel8.Name = "panel8";
            panel8.Size = new Size(415, 798);
            panel8.TabIndex = 7;
            // 
            // panel10
            // 
            panel10.AutoScroll = true;
            panel10.AutoSize = true;
            panel10.BackColor = Color.FromArgb(249, 245, 220);
            panel10.Location = new Point(7, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(380, 713);
            panel10.TabIndex = 0;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1414, 923);
            Controls.Add(panel8);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Order";
            Text = "Order";
            WindowState = FormWindowState.Maximized;
            Load += Order_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel6;
        private PictureBox pictureBox1;
        private DateTimePicker dateTime;
        private Panel panel7;
        private Label label3;
        private Label label2;
        private Panel panel4;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
    }
}