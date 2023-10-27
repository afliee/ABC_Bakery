namespace ABC_Bakery
{
    partial class Application
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Application));
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            menubar = new PictureBox();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            sidebarContainer = new FlowLayoutPanel();
            orderContainer = new FlowLayoutPanel();
            panel3 = new Panel();
            orders = new Button();
            panel2 = new Panel();
            button1 = new Button();
            panel7 = new Panel();
            button6 = new Button();
            panel8 = new Panel();
            button7 = new Button();
            receipts = new FlowLayoutPanel();
            panel13 = new Panel();
            button11 = new Button();
            panel14 = new Panel();
            button12 = new Button();
            panel15 = new Panel();
            button13 = new Button();
            follow_oders = new FlowLayoutPanel();
            panel9 = new Panel();
            button2 = new Button();
            panel10 = new Panel();
            button8 = new Button();
            panel11 = new Panel();
            button9 = new Button();
            panel12 = new Panel();
            button10 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel5 = new Panel();
            button4 = new Button();
            panel6 = new Panel();
            button5 = new Button();
            orderTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menubar).BeginInit();
            orderContainer.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            receipts.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            panel15.SuspendLayout();
            follow_oders.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menubar);
            panel1.Controls.Add(nightControlBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1475, 34);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(3, 34);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(249, 555);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, -1);
            label1.Name = "label1";
            label1.Size = new Size(115, 32);
            label1.TabIndex = 0;
            label1.Text = "ABC Bakery";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menubar
            // 
            menubar.Image = Properties.Resources.menu_bar;
            menubar.Location = new Point(12, 3);
            menubar.Name = "menubar";
            menubar.Size = new Size(33, 28);
            menubar.SizeMode = PictureBoxSizeMode.Zoom;
            menubar.TabIndex = 1;
            menubar.TabStop = false;
            menubar.Click += menubar_Click;
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
            nightControlBox1.Location = new Point(1336, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 1;
            // 
            // sidebarContainer
            // 
            sidebarContainer.BackColor = Color.FromArgb(226, 199, 153);
            sidebarContainer.Dock = DockStyle.Left;
            sidebarContainer.Location = new Point(0, 34);
            sidebarContainer.Name = "sidebarContainer";
            sidebarContainer.Size = new Size(286, 632);
            sidebarContainer.TabIndex = 1;
            // 
            // orderContainer
            // 
            orderContainer.Controls.Add(panel3);
            orderContainer.Controls.Add(panel2);
            orderContainer.Controls.Add(panel7);
            orderContainer.Controls.Add(panel8);
            orderContainer.Location = new Point(442, 64);
            orderContainer.Name = "orderContainer";
            orderContainer.Size = new Size(285, 53);
            orderContainer.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(orders);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.RightToLeft = RightToLeft.Yes;
            panel3.Size = new Size(277, 53);
            panel3.TabIndex = 2;
            // 
            // orders
            // 
            orders.BackColor = Color.FromArgb(226, 199, 153);
            orders.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            orders.ForeColor = SystemColors.Highlight;
            orders.Image = (Image)resources.GetObject("orders.Image");
            orders.ImageAlign = ContentAlignment.MiddleLeft;
            orders.Location = new Point(-8, -11);
            orders.Name = "orders";
            orders.Padding = new Padding(25, 0, 0, 0);
            orders.RightToLeft = RightToLeft.No;
            orders.Size = new Size(290, 76);
            orders.TabIndex = 3;
            orders.Text = "          Biên nhận";
            orders.TextAlign = ContentAlignment.MiddleLeft;
            orders.UseVisualStyleBackColor = false;
            orders.Click += orders_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 62);
            panel2.Name = "panel2";
            panel2.RightToLeft = RightToLeft.Yes;
            panel2.Size = new Size(277, 53);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(226, 199, 153);
            button1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-8, -11);
            button1.Name = "button1";
            button1.Padding = new Padding(50, 0, 0, 0);
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(306, 76);
            button1.TabIndex = 3;
            button1.Text = "          Biên nhận bánh tại quầy";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(button6);
            panel7.Location = new Point(3, 121);
            panel7.Name = "panel7";
            panel7.RightToLeft = RightToLeft.Yes;
            panel7.Size = new Size(277, 53);
            panel7.TabIndex = 2;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(226, 199, 153);
            button6.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ControlText;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(-8, -11);
            button6.Name = "button6";
            button6.Padding = new Padding(50, 0, 0, 0);
            button6.RightToLeft = RightToLeft.No;
            button6.Size = new Size(290, 76);
            button6.TabIndex = 3;
            button6.Text = "          Biên nhận bánh đặt trước";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(button7);
            panel8.Location = new Point(3, 180);
            panel8.Name = "panel8";
            panel8.RightToLeft = RightToLeft.Yes;
            panel8.Size = new Size(277, 53);
            panel8.TabIndex = 2;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(226, 199, 153);
            button7.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ControlText;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(-8, -11);
            button7.Name = "button7";
            button7.Padding = new Padding(50, 0, 0, 0);
            button7.RightToLeft = RightToLeft.No;
            button7.Size = new Size(290, 76);
            button7.TabIndex = 3;
            button7.Text = "          Biên nhận thế chân";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            // 
            // receipts
            // 
            receipts.Controls.Add(panel13);
            receipts.Controls.Add(panel14);
            receipts.Controls.Add(panel15);
            receipts.Location = new Point(442, 123);
            receipts.Name = "receipts";
            receipts.Size = new Size(285, 183);
            receipts.TabIndex = 4;
            // 
            // panel13
            // 
            panel13.Controls.Add(button11);
            panel13.Location = new Point(3, 3);
            panel13.Name = "panel13";
            panel13.RightToLeft = RightToLeft.Yes;
            panel13.Size = new Size(277, 53);
            panel13.TabIndex = 2;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(226, 199, 153);
            button11.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button11.ForeColor = SystemColors.Highlight;
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.Location = new Point(-8, -11);
            button11.Name = "button11";
            button11.Padding = new Padding(25, 0, 0, 0);
            button11.RightToLeft = RightToLeft.No;
            button11.Size = new Size(290, 76);
            button11.TabIndex = 3;
            button11.Text = "          Phiếu thu chi";
            button11.TextAlign = ContentAlignment.MiddleLeft;
            button11.UseVisualStyleBackColor = false;
            // 
            // panel14
            // 
            panel14.Controls.Add(button12);
            panel14.Location = new Point(3, 62);
            panel14.Name = "panel14";
            panel14.RightToLeft = RightToLeft.Yes;
            panel14.Size = new Size(277, 53);
            panel14.TabIndex = 2;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(226, 199, 153);
            button12.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button12.ForeColor = SystemColors.ControlText;
            button12.Image = (Image)resources.GetObject("button12.Image");
            button12.ImageAlign = ContentAlignment.MiddleLeft;
            button12.Location = new Point(-8, -11);
            button12.Name = "button12";
            button12.Padding = new Padding(50, 0, 0, 0);
            button12.RightToLeft = RightToLeft.No;
            button12.Size = new Size(306, 76);
            button12.TabIndex = 3;
            button12.Text = "          Phiếu thu";
            button12.TextAlign = ContentAlignment.MiddleLeft;
            button12.UseVisualStyleBackColor = false;
            // 
            // panel15
            // 
            panel15.Controls.Add(button13);
            panel15.Location = new Point(3, 121);
            panel15.Name = "panel15";
            panel15.RightToLeft = RightToLeft.Yes;
            panel15.Size = new Size(277, 53);
            panel15.TabIndex = 2;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(226, 199, 153);
            button13.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button13.ForeColor = SystemColors.ControlText;
            button13.Image = (Image)resources.GetObject("button13.Image");
            button13.ImageAlign = ContentAlignment.MiddleLeft;
            button13.Location = new Point(-8, -11);
            button13.Name = "button13";
            button13.Padding = new Padding(50, 0, 0, 0);
            button13.RightToLeft = RightToLeft.No;
            button13.Size = new Size(290, 76);
            button13.TabIndex = 3;
            button13.Text = "          Phiếu chi";
            button13.TextAlign = ContentAlignment.MiddleLeft;
            button13.UseVisualStyleBackColor = false;
            // 
            // follow_oders
            // 
            follow_oders.Controls.Add(panel9);
            follow_oders.Controls.Add(panel10);
            follow_oders.Controls.Add(panel11);
            follow_oders.Controls.Add(panel12);
            follow_oders.Location = new Point(442, 312);
            follow_oders.Name = "follow_oders";
            follow_oders.Size = new Size(285, 237);
            follow_oders.TabIndex = 3;
            // 
            // panel9
            // 
            panel9.Controls.Add(button2);
            panel9.Location = new Point(3, 3);
            panel9.Name = "panel9";
            panel9.RightToLeft = RightToLeft.Yes;
            panel9.Size = new Size(277, 53);
            panel9.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(226, 199, 153);
            button2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Highlight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-8, -11);
            button2.Name = "button2";
            button2.Padding = new Padding(25, 0, 0, 0);
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(290, 76);
            button2.TabIndex = 3;
            button2.Text = "          Theo dỗi biên nhận";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += orders_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(button8);
            panel10.Location = new Point(3, 62);
            panel10.Name = "panel10";
            panel10.RightToLeft = RightToLeft.Yes;
            panel10.Size = new Size(277, 53);
            panel10.TabIndex = 2;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(226, 199, 153);
            button8.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.ControlText;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(-8, -11);
            button8.Name = "button8";
            button8.Padding = new Padding(50, 0, 0, 0);
            button8.RightToLeft = RightToLeft.No;
            button8.Size = new Size(306, 76);
            button8.TabIndex = 3;
            button8.Text = "          BN chưa thanh toán";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            panel11.Controls.Add(button9);
            panel11.Location = new Point(3, 121);
            panel11.Name = "panel11";
            panel11.RightToLeft = RightToLeft.Yes;
            panel11.Size = new Size(277, 53);
            panel11.TabIndex = 2;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(226, 199, 153);
            button9.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = SystemColors.ControlText;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(-8, -11);
            button9.Name = "button9";
            button9.Padding = new Padding(50, 0, 0, 0);
            button9.RightToLeft = RightToLeft.No;
            button9.Size = new Size(290, 76);
            button9.TabIndex = 3;
            button9.Text = "          BN TC chưa thanh toán";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.UseVisualStyleBackColor = false;
            // 
            // panel12
            // 
            panel12.Controls.Add(button10);
            panel12.Location = new Point(3, 180);
            panel12.Name = "panel12";
            panel12.RightToLeft = RightToLeft.Yes;
            panel12.Size = new Size(277, 53);
            panel12.TabIndex = 2;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(226, 199, 153);
            button10.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button10.ForeColor = SystemColors.ControlText;
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.Location = new Point(-8, -11);
            button10.Name = "button10";
            button10.Padding = new Padding(50, 0, 0, 0);
            button10.RightToLeft = RightToLeft.No;
            button10.Size = new Size(290, 76);
            button10.TabIndex = 3;
            button10.Text = "          Các biên nhận";
            button10.TextAlign = ContentAlignment.MiddleLeft;
            button10.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Location = new Point(865, 111);
            panel4.Name = "panel4";
            panel4.RightToLeft = RightToLeft.Yes;
            panel4.Size = new Size(277, 53);
            panel4.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(226, 199, 153);
            button3.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Highlight;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-8, -11);
            button3.Name = "button3";
            button3.Padding = new Padding(25, 0, 0, 0);
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(290, 76);
            button3.TabIndex = 3;
            button3.Text = "          Biên nhận";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(button4);
            panel5.Location = new Point(865, 204);
            panel5.Name = "panel5";
            panel5.RightToLeft = RightToLeft.Yes;
            panel5.Size = new Size(277, 53);
            panel5.TabIndex = 2;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(226, 199, 153);
            button4.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.Highlight;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-8, -11);
            button4.Name = "button4";
            button4.Padding = new Padding(25, 0, 0, 0);
            button4.RightToLeft = RightToLeft.No;
            button4.Size = new Size(290, 76);
            button4.TabIndex = 3;
            button4.Text = "          Biên nhận";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(button5);
            panel6.Location = new Point(865, 305);
            panel6.Name = "panel6";
            panel6.RightToLeft = RightToLeft.Yes;
            panel6.Size = new Size(277, 53);
            panel6.TabIndex = 2;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(226, 199, 153);
            button5.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.Highlight;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-8, -11);
            button5.Name = "button5";
            button5.Padding = new Padding(50, 0, 0, 0);
            button5.RightToLeft = RightToLeft.No;
            button5.Size = new Size(290, 76);
            button5.TabIndex = 3;
            button5.Text = "          Biên nhận";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // orderTransition
            // 
            orderTransition.Interval = 15;
            orderTransition.Tick += orderTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 15;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // Application
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1475, 666);
            Controls.Add(orderContainer);
            Controls.Add(receipts);
            Controls.Add(panel6);
            Controls.Add(follow_oders);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(sidebarContainer);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Application";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Application_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menubar).EndInit();
            orderContainer.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            receipts.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel15.ResumeLayout(false);
            follow_oders.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox menubar;
        private Label label1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel sidebarContainer;
        private FlowLayoutPanel orderContainer;
        private Panel panel2;
        private Button button1;
        private Panel panel4;
        private Button button3;
        private Panel panel5;
        private Button button4;
        private Panel panel3;
        private Button orders;
        private Panel panel6;
        private Button button5;
        private Panel panel7;
        private Button button6;
        private Panel panel8;
        private Button button7;
        private System.Windows.Forms.Timer orderTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private FlowLayoutPanel follow_oders;
        private Panel panel9;
        private Button button2;
        private Panel panel10;
        private Button button8;
        private Button button9;
        private Panel panel12;
        private Button button10;
        private Panel panel11;
        private FlowLayoutPanel receipts;
        private Panel panel13;
        private Button button11;
        private Panel panel14;
        private Button button12;
        private Panel panel15;
        private Button button13;
    }
}