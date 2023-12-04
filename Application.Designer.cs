using Color = System.Drawing.Color;
using Image = System.Drawing.Image;
using RectangleF = System.Drawing.RectangleF;
using Rectangle = System.Drawing.Rectangle;
using Size = System.Drawing.Size;
using Point = System.Drawing.Point;
using SizeF = System.Drawing.SizeF;

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
            sidebarContainer = new FlowLayoutPanel();
            pnLogo = new Panel();
            pictureBox1 = new PictureBox();
            panel23 = new Panel();
            receiptContainer = new FlowLayoutPanel();
            pnReceipt = new Panel();
            receipts = new Button();
            panel14 = new Panel();
            button12 = new Button();
            panel15 = new Panel();
            button13 = new Button();
            panel20 = new Panel();
            orderContainer = new FlowLayoutPanel();
            pnOrder = new Panel();
            orders = new Button();
            panel8 = new Panel();
            orders_equip = new Button();
            panel2 = new Panel();
            btnOrderDirect = new Button();
            panel7 = new Panel();
            btnOrdersPrePlaced = new Button();
            panel21 = new Panel();
            followReceiptContainer = new FlowLayoutPanel();
            pnFollowReceipt = new Panel();
            receiptFollow = new Button();
            panel19 = new Panel();
            btnOrderTCNoPayment = new Button();
            panel24 = new Panel();
            btnCreateOrderNoPayment = new Button();
            panel9 = new Panel();
            ordersDH = new Button();
            panel11 = new Panel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            panel3 = new Panel();
            button3 = new Button();
            panel10 = new Panel();
            btnCreateOrder = new Button();
            panel25 = new Panel();
            btnCreateDH = new Button();
            panel12 = new Panel();
            btnCreatePlaceTCOrder = new Button();
            panel17 = new Panel();
            btnCreateCategory = new Button();
            panel13 = new Panel();
            btnCreateProduct = new Button();
            orderTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            receiptTransition = new System.Windows.Forms.Timer(components);
            panel4 = new Panel();
            followReceipt = new Button();
            panel5 = new Panel();
            button4 = new Button();
            panel6 = new Panel();
            button5 = new Button();
            panel16 = new Panel();
            button11 = new Button();
            followReceiptTransition = new System.Windows.Forms.Timer(components);
            sidebarContainer.SuspendLayout();
            pnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            receiptContainer.SuspendLayout();
            pnReceipt.SuspendLayout();
            panel14.SuspendLayout();
            panel15.SuspendLayout();
            orderContainer.SuspendLayout();
            pnOrder.SuspendLayout();
            panel8.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            followReceiptContainer.SuspendLayout();
            pnFollowReceipt.SuspendLayout();
            panel19.SuspendLayout();
            panel24.SuspendLayout();
            panel9.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            panel3.SuspendLayout();
            panel10.SuspendLayout();
            panel25.SuspendLayout();
            panel12.SuspendLayout();
            panel17.SuspendLayout();
            panel13.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel16.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarContainer
            // 
            sidebarContainer.AutoScroll = true;
            sidebarContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sidebarContainer.BackColor = Color.FromArgb(226, 199, 153);
            sidebarContainer.Controls.Add(pnLogo);
            sidebarContainer.Controls.Add(panel23);
            sidebarContainer.Controls.Add(receiptContainer);
            sidebarContainer.Controls.Add(panel20);
            sidebarContainer.Controls.Add(orderContainer);
            sidebarContainer.Controls.Add(panel21);
            sidebarContainer.Controls.Add(followReceiptContainer);
            sidebarContainer.Controls.Add(panel11);
            sidebarContainer.Controls.Add(flowLayoutPanel3);
            sidebarContainer.Dock = DockStyle.Left;
            sidebarContainer.FlowDirection = FlowDirection.TopDown;
            sidebarContainer.Location = new Point(0, 0);
            sidebarContainer.Name = "sidebarContainer";
            sidebarContainer.Size = new Size(292, 825);
            sidebarContainer.TabIndex = 1;
            sidebarContainer.WrapContents = false;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.FromArgb(0, 0, 0, 0);
            pnLogo.Controls.Add(pictureBox1);
            pnLogo.Location = new Point(3, 3);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(288, 59);
            pnLogo.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(291, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel23
            // 
            panel23.BackColor = Color.Black;
            panel23.Location = new Point(3, 68);
            panel23.Name = "panel23";
            panel23.Size = new Size(288, 3);
            panel23.TabIndex = 3;
            // 
            // receiptContainer
            // 
            receiptContainer.Controls.Add(pnReceipt);
            receiptContainer.Controls.Add(panel14);
            receiptContainer.Controls.Add(panel15);
            receiptContainer.Location = new Point(0, 74);
            receiptContainer.Margin = new Padding(0);
            receiptContainer.Name = "receiptContainer";
            receiptContainer.Size = new Size(288, 139);
            receiptContainer.TabIndex = 4;
            // 
            // pnReceipt
            // 
            pnReceipt.Controls.Add(receipts);
            pnReceipt.Location = new Point(0, 0);
            pnReceipt.Margin = new Padding(0);
            pnReceipt.Name = "pnReceipt";
            pnReceipt.RightToLeft = RightToLeft.Yes;
            pnReceipt.Size = new Size(288, 46);
            pnReceipt.TabIndex = 2;
            // 
            // receipts
            // 
            receipts.BackColor = Color.FromArgb(192, 130, 97);
            receipts.FlatAppearance.MouseDownBackColor = Color.FromArgb(219, 149, 112);
            receipts.FlatAppearance.MouseOverBackColor = Color.FromArgb(219, 149, 112);
            receipts.FlatStyle = FlatStyle.Flat;
            receipts.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            receipts.ForeColor = Color.Black;
            receipts.Image = (Image)resources.GetObject("receipts.Image");
            receipts.ImageAlign = ContentAlignment.MiddleLeft;
            receipts.Location = new Point(-19, -11);
            receipts.Name = "receipts";
            receipts.Padding = new Padding(25, 0, 0, 0);
            receipts.RightToLeft = RightToLeft.No;
            receipts.Size = new Size(317, 68);
            receipts.TabIndex = 3;
            receipts.Text = "       Phiếu thu chi";
            receipts.TextAlign = ContentAlignment.MiddleLeft;
            receipts.UseVisualStyleBackColor = false;
            receipts.Click += receipts_Click;
            // 
            // panel14
            // 
            panel14.Controls.Add(button12);
            panel14.Location = new Point(0, 46);
            panel14.Margin = new Padding(0);
            panel14.Name = "panel14";
            panel14.RightToLeft = RightToLeft.Yes;
            panel14.Size = new Size(288, 46);
            panel14.TabIndex = 2;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(226, 199, 153);
            button12.FlatAppearance.MouseDownBackColor = Color.FromArgb(207, 184, 145);
            button12.FlatAppearance.MouseOverBackColor = Color.FromArgb(207, 184, 145);
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button12.ForeColor = SystemColors.ControlText;
            button12.Image = (Image)resources.GetObject("button12.Image");
            button12.ImageAlign = ContentAlignment.MiddleLeft;
            button12.Location = new Point(-19, -11);
            button12.Name = "button12";
            button12.Padding = new Padding(25, 0, 0, 0);
            button12.RightToLeft = RightToLeft.No;
            button12.Size = new Size(317, 67);
            button12.TabIndex = 3;
            button12.Text = "       Phiếu chi";
            button12.TextAlign = ContentAlignment.MiddleLeft;
            button12.UseVisualStyleBackColor = false;
            button12.Click += btnReceipt_Click;
            // 
            // panel15
            // 
            panel15.Controls.Add(button13);
            panel15.Location = new Point(0, 92);
            panel15.Margin = new Padding(0);
            panel15.Name = "panel15";
            panel15.RightToLeft = RightToLeft.Yes;
            panel15.Size = new Size(288, 46);
            panel15.TabIndex = 2;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(226, 199, 153);
            button13.FlatAppearance.MouseDownBackColor = Color.FromArgb(207, 184, 145);
            button13.FlatAppearance.MouseOverBackColor = Color.FromArgb(207, 184, 145);
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button13.ForeColor = SystemColors.ControlText;
            button13.Image = (Image)resources.GetObject("button13.Image");
            button13.ImageAlign = ContentAlignment.MiddleLeft;
            button13.Location = new Point(-19, -11);
            button13.Name = "button13";
            button13.Padding = new Padding(25, 0, 0, 0);
            button13.RightToLeft = RightToLeft.No;
            button13.Size = new Size(317, 67);
            button13.TabIndex = 3;
            button13.Text = "       Phiếu thu";
            button13.TextAlign = ContentAlignment.MiddleLeft;
            button13.UseVisualStyleBackColor = false;
            button13.Click += btnReceive_Click;
            // 
            // panel20
            // 
            panel20.BackColor = Color.Black;
            panel20.Location = new Point(3, 216);
            panel20.Name = "panel20";
            panel20.Size = new Size(288, 3);
            panel20.TabIndex = 2;
            // 
            // orderContainer
            // 
            orderContainer.Controls.Add(pnOrder);
            orderContainer.Controls.Add(panel8);
            orderContainer.Controls.Add(panel2);
            orderContainer.Controls.Add(panel7);
            orderContainer.Location = new Point(0, 222);
            orderContainer.Margin = new Padding(0);
            orderContainer.Name = "orderContainer";
            orderContainer.Size = new Size(288, 184);
            orderContainer.TabIndex = 3;
            // 
            // pnOrder
            // 
            pnOrder.Controls.Add(orders);
            pnOrder.Location = new Point(0, 0);
            pnOrder.Margin = new Padding(0);
            pnOrder.Name = "pnOrder";
            pnOrder.RightToLeft = RightToLeft.Yes;
            pnOrder.Size = new Size(288, 46);
            pnOrder.TabIndex = 2;
            // 
            // orders
            // 
            orders.BackColor = Color.FromArgb(192, 130, 97);
            orders.FlatAppearance.MouseDownBackColor = Color.FromArgb(219, 149, 112);
            orders.FlatAppearance.MouseOverBackColor = Color.FromArgb(219, 149, 112);
            orders.FlatStyle = FlatStyle.Flat;
            orders.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            orders.ForeColor = Color.Black;
            orders.Image = (Image)resources.GetObject("orders.Image");
            orders.ImageAlign = ContentAlignment.MiddleLeft;
            orders.Location = new Point(-19, -4);
            orders.Name = "orders";
            orders.Padding = new Padding(25, 0, 0, 0);
            orders.RightToLeft = RightToLeft.No;
            orders.Size = new Size(317, 53);
            orders.TabIndex = 3;
            orders.Text = "       Biên nhận";
            orders.TextAlign = ContentAlignment.MiddleLeft;
            orders.UseVisualStyleBackColor = false;
            orders.Click += orders_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(orders_equip);
            panel8.Location = new Point(0, 46);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.RightToLeft = RightToLeft.Yes;
            panel8.Size = new Size(288, 46);
            panel8.TabIndex = 2;
            // 
            // orders_equip
            // 
            orders_equip.BackColor = Color.FromArgb(226, 199, 153);
            orders_equip.FlatAppearance.MouseDownBackColor = Color.FromArgb(207, 184, 145);
            orders_equip.FlatAppearance.MouseOverBackColor = Color.FromArgb(207, 184, 145);
            orders_equip.FlatStyle = FlatStyle.Flat;
            orders_equip.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            orders_equip.ForeColor = SystemColors.ControlText;
            orders_equip.Image = (Image)resources.GetObject("orders_equip.Image");
            orders_equip.ImageAlign = ContentAlignment.MiddleLeft;
            orders_equip.Location = new Point(-19, -11);
            orders_equip.Name = "orders_equip";
            orders_equip.Padding = new Padding(25, 0, 0, 0);
            orders_equip.RightToLeft = RightToLeft.No;
            orders_equip.Size = new Size(317, 67);
            orders_equip.TabIndex = 3;
            orders_equip.Text = "       Biên nhận thế chân";
            orders_equip.TextAlign = ContentAlignment.MiddleLeft;
            orders_equip.UseVisualStyleBackColor = false;
            orders_equip.Click += orders_equip_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnOrderDirect);
            panel2.Location = new Point(0, 92);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.RightToLeft = RightToLeft.Yes;
            panel2.Size = new Size(288, 46);
            panel2.TabIndex = 2;
            // 
            // btnOrderDirect
            // 
            btnOrderDirect.BackColor = Color.FromArgb(226, 199, 153);
            btnOrderDirect.FlatAppearance.MouseDownBackColor = Color.FromArgb(207, 184, 145);
            btnOrderDirect.FlatAppearance.MouseOverBackColor = Color.FromArgb(207, 184, 145);
            btnOrderDirect.FlatStyle = FlatStyle.Flat;
            btnOrderDirect.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrderDirect.ForeColor = SystemColors.ControlText;
            btnOrderDirect.Image = (Image)resources.GetObject("btnOrderDirect.Image");
            btnOrderDirect.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrderDirect.Location = new Point(-19, -11);
            btnOrderDirect.Margin = new Padding(0);
            btnOrderDirect.Name = "btnOrderDirect";
            btnOrderDirect.Padding = new Padding(25, 0, 0, 0);
            btnOrderDirect.RightToLeft = RightToLeft.No;
            btnOrderDirect.Size = new Size(317, 67);
            btnOrderDirect.TabIndex = 3;
            btnOrderDirect.Text = "       Biên nhận đặt tại quầy";
            btnOrderDirect.TextAlign = ContentAlignment.MiddleLeft;
            btnOrderDirect.UseVisualStyleBackColor = false;
            btnOrderDirect.Click += btnOrderDirect_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnOrdersPrePlaced);
            panel7.Location = new Point(0, 138);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.RightToLeft = RightToLeft.Yes;
            panel7.Size = new Size(288, 46);
            panel7.TabIndex = 2;
            // 
            // btnOrdersPrePlaced
            // 
            btnOrdersPrePlaced.BackColor = Color.FromArgb(226, 199, 153);
            btnOrdersPrePlaced.FlatAppearance.MouseDownBackColor = Color.FromArgb(207, 184, 145);
            btnOrdersPrePlaced.FlatAppearance.MouseOverBackColor = Color.FromArgb(207, 184, 145);
            btnOrdersPrePlaced.FlatStyle = FlatStyle.Flat;
            btnOrdersPrePlaced.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrdersPrePlaced.ForeColor = SystemColors.ControlText;
            btnOrdersPrePlaced.Image = (Image)resources.GetObject("btnOrdersPrePlaced.Image");
            btnOrdersPrePlaced.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrdersPrePlaced.Location = new Point(-19, -11);
            btnOrdersPrePlaced.Name = "btnOrdersPrePlaced";
            btnOrdersPrePlaced.Padding = new Padding(25, 0, 0, 0);
            btnOrdersPrePlaced.RightToLeft = RightToLeft.No;
            btnOrdersPrePlaced.Size = new Size(317, 67);
            btnOrdersPrePlaced.TabIndex = 3;
            btnOrdersPrePlaced.Text = "       Biên nhận bánh đặt trước";
            btnOrdersPrePlaced.TextAlign = ContentAlignment.MiddleLeft;
            btnOrdersPrePlaced.UseVisualStyleBackColor = false;
            btnOrdersPrePlaced.Click += btnOrdersPrePlaced_Click;
            // 
            // panel21
            // 
            panel21.BackColor = Color.Black;
            panel21.Location = new Point(3, 409);
            panel21.Name = "panel21";
            panel21.Size = new Size(288, 3);
            panel21.TabIndex = 2;
            // 
            // followReceiptContainer
            // 
            followReceiptContainer.Controls.Add(pnFollowReceipt);
            followReceiptContainer.Controls.Add(panel19);
            followReceiptContainer.Controls.Add(panel24);
            followReceiptContainer.Controls.Add(panel9);
            followReceiptContainer.Location = new Point(0, 415);
            followReceiptContainer.Margin = new Padding(0);
            followReceiptContainer.Name = "followReceiptContainer";
            followReceiptContainer.Size = new Size(288, 184);
            followReceiptContainer.TabIndex = 4;
            // 
            // pnFollowReceipt
            // 
            pnFollowReceipt.Controls.Add(receiptFollow);
            pnFollowReceipt.Location = new Point(0, 0);
            pnFollowReceipt.Margin = new Padding(0);
            pnFollowReceipt.Name = "pnFollowReceipt";
            pnFollowReceipt.RightToLeft = RightToLeft.Yes;
            pnFollowReceipt.Size = new Size(288, 46);
            pnFollowReceipt.TabIndex = 2;
            // 
            // receiptFollow
            // 
            receiptFollow.BackColor = Color.FromArgb(192, 130, 97);
            receiptFollow.FlatAppearance.MouseDownBackColor = Color.FromArgb(219, 149, 112);
            receiptFollow.FlatAppearance.MouseOverBackColor = Color.FromArgb(219, 149, 112);
            receiptFollow.FlatStyle = FlatStyle.Flat;
            receiptFollow.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            receiptFollow.ForeColor = Color.Black;
            receiptFollow.Image = (Image)resources.GetObject("receiptFollow.Image");
            receiptFollow.ImageAlign = ContentAlignment.MiddleLeft;
            receiptFollow.Location = new Point(-15, -11);
            receiptFollow.Name = "receiptFollow";
            receiptFollow.Padding = new Padding(25, 0, 0, 0);
            receiptFollow.RightToLeft = RightToLeft.No;
            receiptFollow.Size = new Size(309, 71);
            receiptFollow.TabIndex = 3;
            receiptFollow.Text = "       Theo dỗi biên nhận";
            receiptFollow.TextAlign = ContentAlignment.MiddleLeft;
            receiptFollow.UseVisualStyleBackColor = false;
            receiptFollow.Click += receiptFollow_Click;
            // 
            // panel19
            // 
            panel19.Controls.Add(btnOrderTCNoPayment);
            panel19.Location = new Point(0, 46);
            panel19.Margin = new Padding(0);
            panel19.Name = "panel19";
            panel19.RightToLeft = RightToLeft.Yes;
            panel19.Size = new Size(288, 46);
            panel19.TabIndex = 2;
            // 
            // btnOrderTCNoPayment
            // 
            btnOrderTCNoPayment.BackColor = Color.FromArgb(226, 199, 153);
            btnOrderTCNoPayment.FlatAppearance.MouseDownBackColor = Color.FromArgb(207, 184, 145);
            btnOrderTCNoPayment.FlatAppearance.MouseOverBackColor = Color.FromArgb(207, 184, 145);
            btnOrderTCNoPayment.FlatStyle = FlatStyle.Flat;
            btnOrderTCNoPayment.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrderTCNoPayment.ForeColor = SystemColors.ControlText;
            btnOrderTCNoPayment.Image = (Image)resources.GetObject("btnOrderTCNoPayment.Image");
            btnOrderTCNoPayment.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrderTCNoPayment.Location = new Point(-19, -11);
            btnOrderTCNoPayment.Name = "btnOrderTCNoPayment";
            btnOrderTCNoPayment.Padding = new Padding(25, 0, 0, 0);
            btnOrderTCNoPayment.RightToLeft = RightToLeft.No;
            btnOrderTCNoPayment.Size = new Size(313, 67);
            btnOrderTCNoPayment.TabIndex = 3;
            btnOrderTCNoPayment.Text = "       BN TC chưa thanh toán";
            btnOrderTCNoPayment.TextAlign = ContentAlignment.MiddleLeft;
            btnOrderTCNoPayment.UseVisualStyleBackColor = false;
            btnOrderTCNoPayment.Click += btnOrderTCNoPayment_Click;
            // 
            // panel24
            // 
            panel24.Controls.Add(btnCreateOrderNoPayment);
            panel24.Location = new Point(0, 92);
            panel24.Margin = new Padding(0);
            panel24.Name = "panel24";
            panel24.RightToLeft = RightToLeft.Yes;
            panel24.Size = new Size(288, 46);
            panel24.TabIndex = 2;
            // 
            // btnCreateOrderNoPayment
            // 
            btnCreateOrderNoPayment.BackColor = Color.FromArgb(226, 199, 153);
            btnCreateOrderNoPayment.FlatAppearance.MouseDownBackColor = Color.FromArgb(207, 184, 145);
            btnCreateOrderNoPayment.FlatAppearance.MouseOverBackColor = Color.FromArgb(207, 184, 145);
            btnCreateOrderNoPayment.FlatStyle = FlatStyle.Flat;
            btnCreateOrderNoPayment.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateOrderNoPayment.ForeColor = SystemColors.ControlText;
            btnCreateOrderNoPayment.Image = (Image)resources.GetObject("btnCreateOrderNoPayment.Image");
            btnCreateOrderNoPayment.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateOrderNoPayment.Location = new Point(-15, -8);
            btnCreateOrderNoPayment.Margin = new Padding(3, 2, 3, 2);
            btnCreateOrderNoPayment.Name = "btnCreateOrderNoPayment";
            btnCreateOrderNoPayment.Padding = new Padding(22, 0, 0, 0);
            btnCreateOrderNoPayment.RightToLeft = RightToLeft.No;
            btnCreateOrderNoPayment.Size = new Size(309, 59);
            btnCreateOrderNoPayment.TabIndex = 3;
            btnCreateOrderNoPayment.Text = "       BN Chưa thanh toán";
            btnCreateOrderNoPayment.TextAlign = ContentAlignment.MiddleLeft;
            btnCreateOrderNoPayment.UseVisualStyleBackColor = false;
            btnCreateOrderNoPayment.Click += btnCreateOrderNoPayment_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(ordersDH);
            panel9.Location = new Point(0, 138);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.RightToLeft = RightToLeft.Yes;
            panel9.Size = new Size(288, 46);
            panel9.TabIndex = 2;
            // 
            // ordersDH
            // 
            ordersDH.BackColor = Color.FromArgb(226, 199, 153);
            ordersDH.FlatAppearance.MouseDownBackColor = Color.FromArgb(207, 184, 145);
            ordersDH.FlatAppearance.MouseOverBackColor = Color.FromArgb(207, 184, 145);
            ordersDH.FlatStyle = FlatStyle.Flat;
            ordersDH.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ordersDH.ForeColor = SystemColors.ControlText;
            ordersDH.Image = (Image)resources.GetObject("ordersDH.Image");
            ordersDH.ImageAlign = ContentAlignment.MiddleLeft;
            ordersDH.Location = new Point(-19, -11);
            ordersDH.Name = "ordersDH";
            ordersDH.Padding = new Padding(25, 0, 0, 0);
            ordersDH.RightToLeft = RightToLeft.No;
            ordersDH.Size = new Size(317, 69);
            ordersDH.TabIndex = 3;
            ordersDH.Text = "       Các đơn đặt hàng";
            ordersDH.TextAlign = ContentAlignment.MiddleLeft;
            ordersDH.UseVisualStyleBackColor = false;
            ordersDH.Click += ordersDH_Click;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Black;
            panel11.Location = new Point(3, 602);
            panel11.Name = "panel11";
            panel11.Size = new Size(288, 3);
            panel11.TabIndex = 2;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(panel3);
            flowLayoutPanel3.Controls.Add(panel10);
            flowLayoutPanel3.Controls.Add(panel25);
            flowLayoutPanel3.Controls.Add(panel12);
            flowLayoutPanel3.Controls.Add(panel17);
            flowLayoutPanel3.Controls.Add(panel13);
            flowLayoutPanel3.Location = new Point(0, 608);
            flowLayoutPanel3.Margin = new Padding(0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(290, 279);
            flowLayoutPanel3.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.Controls.Add(button3);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.RightToLeft = RightToLeft.Yes;
            panel3.Size = new Size(288, 46);
            panel3.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 130, 97);
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(219, 149, 112);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(219, 149, 112);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-19, -11);
            button3.Name = "button3";
            button3.Padding = new Padding(25, 0, 0, 0);
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(313, 67);
            button3.TabIndex = 3;
            button3.Text = "       Thao tác";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            panel10.Controls.Add(btnCreateOrder);
            panel10.Location = new Point(0, 46);
            panel10.Margin = new Padding(0);
            panel10.Name = "panel10";
            panel10.RightToLeft = RightToLeft.Yes;
            panel10.Size = new Size(288, 46);
            panel10.TabIndex = 2;
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.BackColor = Color.FromArgb(226, 199, 153);
            btnCreateOrder.FlatAppearance.MouseDownBackColor = Color.FromArgb(207, 184, 145);
            btnCreateOrder.FlatAppearance.MouseOverBackColor = Color.FromArgb(207, 184, 145);
            btnCreateOrder.FlatStyle = FlatStyle.Flat;
            btnCreateOrder.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateOrder.ForeColor = SystemColors.ControlText;
            btnCreateOrder.Image = (Image)resources.GetObject("btnCreateOrder.Image");
            btnCreateOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateOrder.Location = new Point(-19, -11);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Padding = new Padding(25, 0, 0, 0);
            btnCreateOrder.RightToLeft = RightToLeft.No;
            btnCreateOrder.Size = new Size(317, 67);
            btnCreateOrder.TabIndex = 3;
            btnCreateOrder.Text = "       Tạo phiếu mua hàng";
            btnCreateOrder.TextAlign = ContentAlignment.MiddleLeft;
            btnCreateOrder.UseVisualStyleBackColor = false;
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // panel25
            // 
            panel25.Controls.Add(btnCreateDH);
            panel25.Location = new Point(0, 92);
            panel25.Margin = new Padding(0);
            panel25.Name = "panel25";
            panel25.RightToLeft = RightToLeft.Yes;
            panel25.Size = new Size(290, 46);
            panel25.TabIndex = 2;
            // 
            // btnCreateDH
            // 
            btnCreateDH.BackColor = Color.FromArgb(226, 199, 153);
            btnCreateDH.FlatAppearance.MouseDownBackColor = Color.FromArgb(207, 184, 145);
            btnCreateDH.FlatAppearance.MouseOverBackColor = Color.FromArgb(207, 184, 145);
            btnCreateDH.FlatStyle = FlatStyle.Flat;
            btnCreateDH.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateDH.ForeColor = SystemColors.ControlText;
            btnCreateDH.Image = (Image)resources.GetObject("btnCreateDH.Image");
            btnCreateDH.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateDH.Location = new Point(-19, -5);
            btnCreateDH.Margin = new Padding(3, 2, 3, 2);
            btnCreateDH.Name = "btnCreateDH";
            btnCreateDH.Padding = new Padding(22, 0, 0, 0);
            btnCreateDH.RightToLeft = RightToLeft.No;
            btnCreateDH.Size = new Size(317, 57);
            btnCreateDH.TabIndex = 3;
            btnCreateDH.Text = "       Tạo Đơn đặt hàng";
            btnCreateDH.TextAlign = ContentAlignment.MiddleLeft;
            btnCreateDH.UseVisualStyleBackColor = false;
            btnCreateDH.Click += btnCreateDH_Click;
            // 
            // panel12
            // 
            panel12.Controls.Add(btnCreatePlaceTCOrder);
            panel12.Location = new Point(0, 138);
            panel12.Margin = new Padding(0);
            panel12.Name = "panel12";
            panel12.RightToLeft = RightToLeft.Yes;
            panel12.Size = new Size(290, 46);
            panel12.TabIndex = 4;
            // 
            // btnCreatePlaceTCOrder
            // 
            btnCreatePlaceTCOrder.BackColor = Color.FromArgb(226, 199, 153);
            btnCreatePlaceTCOrder.FlatAppearance.MouseDownBackColor = Color.FromArgb(207, 184, 145);
            btnCreatePlaceTCOrder.FlatAppearance.MouseOverBackColor = Color.FromArgb(207, 184, 145);
            btnCreatePlaceTCOrder.FlatStyle = FlatStyle.Flat;
            btnCreatePlaceTCOrder.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreatePlaceTCOrder.ForeColor = SystemColors.ControlText;
            btnCreatePlaceTCOrder.Image = (Image)resources.GetObject("btnCreatePlaceTCOrder.Image");
            btnCreatePlaceTCOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreatePlaceTCOrder.Location = new Point(-19, -5);
            btnCreatePlaceTCOrder.Margin = new Padding(3, 2, 3, 2);
            btnCreatePlaceTCOrder.Name = "btnCreatePlaceTCOrder";
            btnCreatePlaceTCOrder.Padding = new Padding(22, 0, 0, 0);
            btnCreatePlaceTCOrder.RightToLeft = RightToLeft.No;
            btnCreatePlaceTCOrder.Size = new Size(317, 57);
            btnCreatePlaceTCOrder.TabIndex = 3;
            btnCreatePlaceTCOrder.Text = "       Tạo Đơn đặt thiết bị";
            btnCreatePlaceTCOrder.TextAlign = ContentAlignment.MiddleLeft;
            btnCreatePlaceTCOrder.UseVisualStyleBackColor = false;
            btnCreatePlaceTCOrder.Click += btnCreatePlaceTCOrder_Click;
            // 
            // panel17
            // 
            panel17.Controls.Add(btnCreateCategory);
            panel17.Location = new Point(0, 184);
            panel17.Margin = new Padding(0);
            panel17.Name = "panel17";
            panel17.RightToLeft = RightToLeft.Yes;
            panel17.Size = new Size(288, 46);
            panel17.TabIndex = 2;
            // 
            // btnCreateCategory
            // 
            btnCreateCategory.BackColor = Color.FromArgb(226, 199, 153);
            btnCreateCategory.FlatAppearance.MouseDownBackColor = Color.FromArgb(207, 184, 145);
            btnCreateCategory.FlatAppearance.MouseOverBackColor = Color.FromArgb(207, 184, 145);
            btnCreateCategory.FlatStyle = FlatStyle.Flat;
            btnCreateCategory.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateCategory.ForeColor = SystemColors.ControlText;
            btnCreateCategory.Image = (Image)resources.GetObject("btnCreateCategory.Image");
            btnCreateCategory.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateCategory.Location = new Point(-19, -11);
            btnCreateCategory.Name = "btnCreateCategory";
            btnCreateCategory.Padding = new Padding(25, 0, 0, 0);
            btnCreateCategory.RightToLeft = RightToLeft.No;
            btnCreateCategory.Size = new Size(317, 67);
            btnCreateCategory.TabIndex = 3;
            btnCreateCategory.Text = "       Tạo Danh Mục";
            btnCreateCategory.TextAlign = ContentAlignment.MiddleLeft;
            btnCreateCategory.UseVisualStyleBackColor = false;
            btnCreateCategory.Click += btnCreateCategory_Click;
            // 
            // panel13
            // 
            panel13.Controls.Add(btnCreateProduct);
            panel13.Location = new Point(0, 230);
            panel13.Margin = new Padding(0);
            panel13.Name = "panel13";
            panel13.RightToLeft = RightToLeft.Yes;
            panel13.Size = new Size(288, 46);
            panel13.TabIndex = 2;
            // 
            // btnCreateProduct
            // 
            btnCreateProduct.BackColor = Color.FromArgb(226, 199, 153);
            btnCreateProduct.FlatAppearance.MouseDownBackColor = Color.FromArgb(207, 184, 145);
            btnCreateProduct.FlatAppearance.MouseOverBackColor = Color.FromArgb(207, 184, 145);
            btnCreateProduct.FlatStyle = FlatStyle.Flat;
            btnCreateProduct.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateProduct.ForeColor = SystemColors.ControlText;
            btnCreateProduct.Image = (Image)resources.GetObject("btnCreateProduct.Image");
            btnCreateProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateProduct.Location = new Point(-19, -11);
            btnCreateProduct.Name = "btnCreateProduct";
            btnCreateProduct.Padding = new Padding(25, 0, 0, 0);
            btnCreateProduct.RightToLeft = RightToLeft.No;
            btnCreateProduct.Size = new Size(317, 67);
            btnCreateProduct.TabIndex = 3;
            btnCreateProduct.Text = "       Thêm sản phẩm";
            btnCreateProduct.TextAlign = ContentAlignment.MiddleLeft;
            btnCreateProduct.UseVisualStyleBackColor = false;
            btnCreateProduct.Click += btnCreateProduct_Click;
            // 
            // orderTransition
            // 
            orderTransition.Interval = 15;
            orderTransition.Tick += orderTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 5;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // receiptTransition
            // 
            receiptTransition.Interval = 15;
            receiptTransition.Tick += receiptTransition_Tick;
            // 
            // panel4
            // 
            panel4.Controls.Add(followReceipt);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.RightToLeft = RightToLeft.Yes;
            panel4.Size = new Size(288, 59);
            panel4.TabIndex = 2;
            // 
            // followReceipt
            // 
            followReceipt.BackColor = Color.FromArgb(192, 130, 97);
            followReceipt.FlatAppearance.MouseDownBackColor = Color.FromArgb(219, 149, 112);
            followReceipt.FlatAppearance.MouseOverBackColor = Color.FromArgb(219, 149, 112);
            followReceipt.FlatStyle = FlatStyle.Flat;
            followReceipt.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            followReceipt.ForeColor = Color.Black;
            followReceipt.Image = (Image)resources.GetObject("followReceipt.Image");
            followReceipt.ImageAlign = ContentAlignment.MiddleLeft;
            followReceipt.Location = new Point(-24, -11);
            followReceipt.Name = "followReceipt";
            followReceipt.Padding = new Padding(25, 0, 0, 0);
            followReceipt.RightToLeft = RightToLeft.No;
            followReceipt.Size = new Size(317, 76);
            followReceipt.TabIndex = 3;
            followReceipt.Text = "Theo dỗi biên nhận";
            followReceipt.UseVisualStyleBackColor = false;
            followReceipt.Click += receipts_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(button4);
            panel5.Location = new Point(0, 59);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.RightToLeft = RightToLeft.Yes;
            panel5.Size = new Size(288, 53);
            panel5.TabIndex = 2;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(226, 199, 153);
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(207, 184, 145);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(207, 184, 145);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ControlText;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-24, -11);
            button4.Name = "button4";
            button4.Padding = new Padding(25, 0, 0, 0);
            button4.RightToLeft = RightToLeft.No;
            button4.Size = new Size(317, 76);
            button4.TabIndex = 3;
            button4.Text = "BN chưa thanh toán";
            button4.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(button5);
            panel6.Location = new Point(0, 112);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.RightToLeft = RightToLeft.Yes;
            panel6.Size = new Size(288, 53);
            panel6.TabIndex = 2;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(226, 199, 153);
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(207, 184, 145);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(207, 184, 145);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ControlText;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-24, -11);
            button5.Name = "button5";
            button5.Padding = new Padding(25, 0, 0, 0);
            button5.RightToLeft = RightToLeft.No;
            button5.Size = new Size(317, 76);
            button5.TabIndex = 3;
            button5.Text = "BN TC chưa thanh toán";
            button5.UseVisualStyleBackColor = false;
            // 
            // panel16
            // 
            panel16.Controls.Add(button11);
            panel16.Location = new Point(0, 165);
            panel16.Margin = new Padding(0);
            panel16.Name = "panel16";
            panel16.RightToLeft = RightToLeft.Yes;
            panel16.Size = new Size(288, 53);
            panel16.TabIndex = 2;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(226, 199, 153);
            button11.FlatAppearance.MouseDownBackColor = Color.FromArgb(207, 184, 145);
            button11.FlatAppearance.MouseOverBackColor = Color.FromArgb(207, 184, 145);
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button11.ForeColor = SystemColors.ControlText;
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.Location = new Point(-24, -11);
            button11.Name = "button11";
            button11.Padding = new Padding(25, 0, 0, 0);
            button11.RightToLeft = RightToLeft.No;
            button11.Size = new Size(317, 76);
            button11.TabIndex = 3;
            button11.Text = "Các biên nhận";
            button11.UseVisualStyleBackColor = false;
            // 
            // followReceiptTransition
            // 
            followReceiptTransition.Interval = 15;
            followReceiptTransition.Tick += followReceiptTransition_Tick;
            // 
            // Application
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 825);
            Controls.Add(sidebarContainer);
            IsMdiContainer = true;
            Name = "Application";
            Text = " ";
            WindowState = FormWindowState.Maximized;
            Load += Application_Load;
            sidebarContainer.ResumeLayout(false);
            pnLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            receiptContainer.ResumeLayout(false);
            pnReceipt.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel15.ResumeLayout(false);
            orderContainer.ResumeLayout(false);
            pnOrder.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            followReceiptContainer.ResumeLayout(false);
            pnFollowReceipt.ResumeLayout(false);
            panel19.ResumeLayout(false);
            panel24.ResumeLayout(false);
            panel9.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel25.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel16.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel sidebarContainer;
        private FlowLayoutPanel orderContainer;
        private Panel panel2;
        private Button btnOrderDirect;
        private Panel pnOrder;
        private Button orders;
        private Panel panel7;
        private Button btnOrdersPrePlaced;
        private Panel panel8;
        private Button orders_equip;
        private System.Windows.Forms.Timer orderTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private FlowLayoutPanel follow_oders;
        private Panel pnLogo;
        private Button button8;
        private Button button9;
        private Panel panel12;
        private Button button10;
        private Panel panel11;
        private FlowLayoutPanel receiptContainer;
        private Panel pnReceipt;
        private Button receipts;
        private Panel panel14;
        private Button button12;
        private Panel panel15;
        private Button button13;
        private System.Windows.Forms.Timer receiptTransition;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel4;
        private Button followReceipt;
        private Panel panel5;
        private Button button4;
        private Panel panel6;
        private Button button5;
        private Panel panel16;
        private Button button11;
        private System.Windows.Forms.Timer followReceiptTransition;
        private FlowLayoutPanel followReceiptContainer;
        private Panel pnFollowReceipt;
        private Button receiptFollow;
        private Panel panel19;
        private Button btnOrderTCNoPayment;
        private Panel panel9;
        private Button ordersDH;
        private Panel panel20;
        private Panel panel21;
        private Panel panel23;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel3;
        private Panel panel3;
        private Button button3;
        private Panel panel10;
        private Button btnCreateOrder;
        private Panel panel13;
        private Button btnCreateProduct;
        private Panel panel17;
        private Button btnCreateCategory;
        private Panel panel24;
        private Button btnCreateOrderNoPayment;
        private Panel panel25;
        private Button btnCreateDH;
        private Button btnCreatePlaceTCOrder;
    }
}