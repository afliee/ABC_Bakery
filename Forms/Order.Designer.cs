using Color = System.Drawing.Color;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lb_index = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            roundedPanel1 = new Helpers.UI.RoundedPanel();
            datetimePickerCustom1 = new Helpers.UI.DatetimePickerCustom();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            roundedPanel2 = new Helpers.UI.RoundedPanel();
            dungeonHeaderLabel3 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            roundedPanel3 = new Helpers.UI.RoundedPanel();
            datetimePickerCustom2 = new Helpers.UI.DatetimePickerCustom();
            label4 = new Label();
            roundedPanel7 = new Helpers.UI.RoundedPanel();
            tbReceived = new Helpers.UI.RJTextBox();
            label8 = new Label();
            label11 = new Label();
            label9 = new Label();
            roundedPanel8 = new Helpers.UI.RoundedPanel();
            lbTotal = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            roundedPanel5 = new Helpers.UI.RoundedPanel();
            tbDiscount = new Helpers.UI.RJTextBox();
            label5 = new Label();
            roundedPanel6 = new Helpers.UI.RoundedPanel();
            tbSurcharge = new Helpers.UI.RJTextBox();
            label7 = new Label();
            label6 = new Label();
            roundedPanel9 = new Helpers.UI.RoundedPanel();
            lbMoneyChange = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            label13 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            roundedPanel10 = new Helpers.UI.RoundedPanel();
            parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            tbNote = new Helpers.UI.RJTextBox();
            panel2 = new Panel();
            btnSave = new Helpers.UI.RoundedButton();
            panel3 = new Panel();
            panel8 = new Panel();
            roundedPanel11 = new Helpers.UI.RoundedPanel();
            dgProducts = new DataGridView();
            panel4 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel5 = new Panel();
            btnRenew = new Helpers.UI.RJButton();
            rjButton1 = new Helpers.UI.RJButton();
            panel6 = new Panel();
            btnCanceled = new Helpers.UI.RJButton();
            panel7 = new Panel();
            btnPrint = new Helpers.UI.RJButton();
            roundedPanel4 = new Helpers.UI.RoundedPanel();
            panel9 = new Panel();
            filter = new FontAwesome.Sharp.IconPictureBox();
            tbSearch = new Helpers.UI.RJTextBox();
            dungeonHeaderLabel2 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            print_review_order = new PrintPreviewDialog();
            print_order = new System.Drawing.Printing.PrintDocument();
            id = new DataGridViewTextBoxColumn();
            barcode = new DataGridViewImageColumn();
            name = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            delete = new DataGridViewButtonColumn();
            product_id = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            roundedPanel2.SuspendLayout();
            roundedPanel3.SuspendLayout();
            roundedPanel7.SuspendLayout();
            roundedPanel8.SuspendLayout();
            roundedPanel5.SuspendLayout();
            roundedPanel6.SuspendLayout();
            roundedPanel9.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            parrotGroupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            roundedPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            roundedPanel4.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)filter).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel1.Controls.Add(lb_index);
            panel1.Controls.Add(bigLabel1);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 87);
            panel1.TabIndex = 0;
            // 
            // lb_index
            // 
            lb_index.AutoSize = true;
            lb_index.BackColor = Color.Transparent;
            lb_index.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lb_index.ForeColor = Color.White;
            lb_index.Location = new Point(10, 49);
            lb_index.Name = "lb_index";
            lb_index.Size = new Size(83, 20);
            lb_index.TabIndex = 1;
            lb_index.Text = "No. 00001";
            lb_index.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.ImageAlign = ContentAlignment.MiddleLeft;
            bigLabel1.Location = new Point(0, 0);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(261, 46);
            bigLabel1.TabIndex = 1;
            bigLabel1.Text = "Phiếu mua hàng";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(roundedPanel1);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(877, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(387, 87);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(154, 59, 59);
            roundedPanel1.Controls.Add(datetimePickerCustom1);
            roundedPanel1.Controls.Add(pictureBox1);
            roundedPanel1.ForeColor = Color.White;
            roundedPanel1.Location = new Point(3, 15);
            roundedPanel1.Margin = new Padding(3, 15, 3, 3);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(377, 54);
            roundedPanel1.TabIndex = 5;
            // 
            // datetimePickerCustom1
            // 
            datetimePickerCustom1.BorderColor = Color.FromArgb(154, 59, 59);
            datetimePickerCustom1.BorderSize = 3;
            datetimePickerCustom1.CustomFormat = "dddd , dd MMMM yyyy";
            datetimePickerCustom1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            datetimePickerCustom1.Location = new Point(63, 4);
            datetimePickerCustom1.MinimumSize = new Size(4, 50);
            datetimePickerCustom1.Name = "datetimePickerCustom1";
            datetimePickerCustom1.Size = new Size(369, 50);
            datetimePickerCustom1.SkinColor = Color.FromArgb(154, 59, 59);
            datetimePickerCustom1.TabIndex = 1;
            datetimePickerCustom1.TextColor = Color.White;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.calender;
            pictureBox1.Location = new Point(3, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.FromArgb(249, 245, 220);
            roundedPanel2.Controls.Add(dungeonHeaderLabel3);
            roundedPanel2.ForeColor = Color.White;
            roundedPanel2.Location = new Point(3, 3);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(377, 63);
            roundedPanel2.TabIndex = 2;
            // 
            // dungeonHeaderLabel3
            // 
            dungeonHeaderLabel3.AutoSize = true;
            dungeonHeaderLabel3.BackColor = Color.Transparent;
            dungeonHeaderLabel3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dungeonHeaderLabel3.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel3.ImageAlign = ContentAlignment.MiddleLeft;
            dungeonHeaderLabel3.Location = new Point(12, 17);
            dungeonHeaderLabel3.Name = "dungeonHeaderLabel3";
            dungeonHeaderLabel3.Size = new Size(172, 30);
            dungeonHeaderLabel3.TabIndex = 2;
            dungeonHeaderLabel3.Text = "Chi tiết hóa đơn";
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.FromArgb(249, 245, 220);
            roundedPanel3.Controls.Add(datetimePickerCustom2);
            roundedPanel3.Controls.Add(label4);
            roundedPanel3.ForeColor = Color.White;
            roundedPanel3.Location = new Point(3, 83);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(374, 60);
            roundedPanel3.TabIndex = 2;
            // 
            // datetimePickerCustom2
            // 
            datetimePickerCustom2.BorderColor = Color.FromArgb(242, 236, 190);
            datetimePickerCustom2.BorderSize = 3;
            datetimePickerCustom2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            datetimePickerCustom2.Location = new Point(127, 0);
            datetimePickerCustom2.MinimumSize = new Size(4, 60);
            datetimePickerCustom2.Name = "datetimePickerCustom2";
            datetimePickerCustom2.Size = new Size(244, 60);
            datetimePickerCustom2.SkinColor = Color.FromArgb(249, 245, 220);
            datetimePickerCustom2.TabIndex = 0;
            datetimePickerCustom2.TextColor = Color.Black;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 15);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 0;
            label4.Text = "Ngày đặt";
            // 
            // roundedPanel7
            // 
            roundedPanel7.BackColor = Color.FromArgb(249, 245, 220);
            roundedPanel7.Controls.Add(tbReceived);
            roundedPanel7.Controls.Add(label8);
            roundedPanel7.Controls.Add(label11);
            roundedPanel7.ForeColor = Color.White;
            roundedPanel7.Location = new Point(3, 281);
            roundedPanel7.Name = "roundedPanel7";
            roundedPanel7.Size = new Size(374, 60);
            roundedPanel7.TabIndex = 5;
            // 
            // tbReceived
            // 
            tbReceived.BackColor = SystemColors.Window;
            tbReceived.BorderColor = Color.FromArgb(154, 59, 59);
            tbReceived.BorderFocusColor = Color.HotPink;
            tbReceived.BorderRadius = 10;
            tbReceived.BorderSize = 2;
            tbReceived.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbReceived.ForeColor = Color.FromArgb(64, 64, 64);
            tbReceived.Location = new Point(106, 6);
            tbReceived.Margin = new Padding(4);
            tbReceived.Multiline = false;
            tbReceived.Name = "tbReceived";
            tbReceived.Padding = new Padding(10, 7, 10, 7);
            tbReceived.PasswordChar = false;
            tbReceived.PlaceholderColor = Color.DarkGray;
            tbReceived.PlaceholderText = "";
            tbReceived.Size = new Size(216, 47);
            tbReceived.TabIndex = 3;
            tbReceived.TextAlign = HorizontalAlignment.Left;
            tbReceived.Texts = "0";
            tbReceived.UnderlinedStyle = false;
            tbReceived._TextChanged += tbReceived__TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(320, 16);
            label8.Name = "label8";
            label8.Size = new Size(54, 25);
            label8.TabIndex = 2;
            label8.Text = "VND";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(12, 16);
            label11.Name = "label11";
            label11.Size = new Size(96, 25);
            label11.TabIndex = 0;
            label11.Text = "Tiền nhận";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(12, 16);
            label9.Name = "label9";
            label9.Size = new Size(92, 25);
            label9.TabIndex = 0;
            label9.Text = "Tổng tiền";
            // 
            // roundedPanel8
            // 
            roundedPanel8.BackColor = Color.FromArgb(249, 245, 220);
            roundedPanel8.Controls.Add(lbTotal);
            roundedPanel8.Controls.Add(label9);
            roundedPanel8.ForeColor = Color.White;
            roundedPanel8.Location = new Point(3, 347);
            roundedPanel8.Name = "roundedPanel8";
            roundedPanel8.Size = new Size(374, 60);
            roundedPanel8.TabIndex = 6;
            // 
            // lbTotal
            // 
            lbTotal.BackColor = Color.Transparent;
            lbTotal.Dock = DockStyle.Right;
            lbTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotal.ForeColor = Color.FromArgb(76, 76, 77);
            lbTotal.Location = new Point(251, 0);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(123, 60);
            lbTotal.TabIndex = 1;
            lbTotal.Text = "0";
            lbTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.FromArgb(249, 245, 220);
            roundedPanel5.Controls.Add(tbDiscount);
            roundedPanel5.Controls.Add(label5);
            roundedPanel5.ForeColor = Color.White;
            roundedPanel5.Location = new Point(3, 149);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(374, 60);
            roundedPanel5.TabIndex = 3;
            // 
            // tbDiscount
            // 
            tbDiscount.BackColor = SystemColors.Window;
            tbDiscount.BorderColor = Color.FromArgb(154, 59, 59);
            tbDiscount.BorderFocusColor = Color.HotPink;
            tbDiscount.BorderRadius = 10;
            tbDiscount.BorderSize = 2;
            tbDiscount.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbDiscount.ForeColor = Color.FromArgb(64, 64, 64);
            tbDiscount.Location = new Point(145, 6);
            tbDiscount.Margin = new Padding(4);
            tbDiscount.Multiline = false;
            tbDiscount.Name = "tbDiscount";
            tbDiscount.Padding = new Padding(10, 7, 10, 7);
            tbDiscount.PasswordChar = false;
            tbDiscount.PlaceholderColor = Color.DarkGray;
            tbDiscount.PlaceholderText = "";
            tbDiscount.Size = new Size(225, 47);
            tbDiscount.TabIndex = 1;
            tbDiscount.TextAlign = HorizontalAlignment.Left;
            tbDiscount.Texts = "";
            tbDiscount.UnderlinedStyle = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(12, 19);
            label5.Name = "label5";
            label5.Size = new Size(117, 25);
            label5.TabIndex = 0;
            label5.Text = "Mã giảm giá";
            // 
            // roundedPanel6
            // 
            roundedPanel6.BackColor = Color.FromArgb(249, 245, 220);
            roundedPanel6.Controls.Add(tbSurcharge);
            roundedPanel6.Controls.Add(label7);
            roundedPanel6.Controls.Add(label6);
            roundedPanel6.ForeColor = Color.White;
            roundedPanel6.Location = new Point(3, 215);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new Size(374, 60);
            roundedPanel6.TabIndex = 4;
            // 
            // tbSurcharge
            // 
            tbSurcharge.BackColor = SystemColors.Window;
            tbSurcharge.BorderColor = Color.FromArgb(154, 59, 59);
            tbSurcharge.BorderFocusColor = Color.HotPink;
            tbSurcharge.BorderRadius = 10;
            tbSurcharge.BorderSize = 2;
            tbSurcharge.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbSurcharge.ForeColor = Color.FromArgb(64, 64, 64);
            tbSurcharge.Location = new Point(106, 6);
            tbSurcharge.Margin = new Padding(4);
            tbSurcharge.Multiline = false;
            tbSurcharge.Name = "tbSurcharge";
            tbSurcharge.Padding = new Padding(10, 7, 10, 7);
            tbSurcharge.PasswordChar = false;
            tbSurcharge.PlaceholderColor = Color.DarkGray;
            tbSurcharge.PlaceholderText = "";
            tbSurcharge.Size = new Size(216, 47);
            tbSurcharge.TabIndex = 2;
            tbSurcharge.TextAlign = HorizontalAlignment.Left;
            tbSurcharge.Texts = "0";
            tbSurcharge.UnderlinedStyle = false;
            tbSurcharge._TextChanged += tbSurcharge__TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(320, 16);
            label7.Name = "label7";
            label7.Size = new Size(54, 25);
            label7.TabIndex = 2;
            label7.Text = "VND";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(12, 16);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 0;
            label6.Text = "Phụ thu";
            // 
            // roundedPanel9
            // 
            roundedPanel9.BackColor = Color.FromArgb(249, 245, 220);
            roundedPanel9.Controls.Add(lbMoneyChange);
            roundedPanel9.Controls.Add(label13);
            roundedPanel9.ForeColor = Color.White;
            roundedPanel9.Location = new Point(3, 413);
            roundedPanel9.Margin = new Padding(3, 3, 3, 15);
            roundedPanel9.Name = "roundedPanel9";
            roundedPanel9.Size = new Size(374, 60);
            roundedPanel9.TabIndex = 7;
            // 
            // lbMoneyChange
            // 
            lbMoneyChange.BackColor = Color.Transparent;
            lbMoneyChange.Dock = DockStyle.Right;
            lbMoneyChange.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbMoneyChange.ForeColor = Color.FromArgb(76, 76, 77);
            lbMoneyChange.Location = new Point(242, 0);
            lbMoneyChange.Name = "lbMoneyChange";
            lbMoneyChange.Size = new Size(132, 60);
            lbMoneyChange.TabIndex = 1;
            lbMoneyChange.Text = "0";
            lbMoneyChange.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(15, 16);
            label13.Name = "label13";
            label13.Size = new Size(91, 25);
            label13.TabIndex = 0;
            label13.Text = "Tiền thừa";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(0, 0, 0, 0);
            flowLayoutPanel2.Controls.Add(roundedPanel2);
            flowLayoutPanel2.Controls.Add(roundedPanel10);
            flowLayoutPanel2.Controls.Add(roundedPanel3);
            flowLayoutPanel2.Controls.Add(roundedPanel5);
            flowLayoutPanel2.Controls.Add(roundedPanel6);
            flowLayoutPanel2.Controls.Add(roundedPanel7);
            flowLayoutPanel2.Controls.Add(roundedPanel8);
            flowLayoutPanel2.Controls.Add(roundedPanel9);
            flowLayoutPanel2.Controls.Add(parrotGroupBox1);
            flowLayoutPanel2.Controls.Add(panel2);
            flowLayoutPanel2.Dock = DockStyle.Right;
            flowLayoutPanel2.Location = new Point(877, 87);
            flowLayoutPanel2.Margin = new Padding(10, 3, 10, 50);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(387, 930);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // roundedPanel10
            // 
            roundedPanel10.BackColor = Color.FromArgb(154, 59, 59);
            roundedPanel10.ForeColor = Color.White;
            roundedPanel10.Location = new Point(3, 72);
            roundedPanel10.Name = "roundedPanel10";
            roundedPanel10.Size = new Size(372, 5);
            roundedPanel10.TabIndex = 3;
            // 
            // parrotGroupBox1
            // 
            parrotGroupBox1.BorderColor = Color.FromArgb(154, 59, 59);
            parrotGroupBox1.BorderWidth = 2;
            parrotGroupBox1.Controls.Add(tbNote);
            parrotGroupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            parrotGroupBox1.Location = new Point(3, 491);
            parrotGroupBox1.Margin = new Padding(3, 3, 3, 10);
            parrotGroupBox1.Name = "parrotGroupBox1";
            parrotGroupBox1.Padding = new Padding(5);
            parrotGroupBox1.ShowText = true;
            parrotGroupBox1.Size = new Size(374, 220);
            parrotGroupBox1.TabIndex = 15;
            parrotGroupBox1.TabStop = false;
            parrotGroupBox1.Text = "Ghi chú";
            parrotGroupBox1.TextColor = Color.White;
            // 
            // tbNote
            // 
            tbNote.BackColor = SystemColors.Window;
            tbNote.BorderColor = Color.FromArgb(154, 59, 59);
            tbNote.BorderFocusColor = Color.HotPink;
            tbNote.BorderRadius = 5;
            tbNote.BorderSize = 2;
            tbNote.Dock = DockStyle.Fill;
            tbNote.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbNote.ForeColor = Color.FromArgb(64, 64, 64);
            tbNote.Location = new Point(5, 31);
            tbNote.Margin = new Padding(0);
            tbNote.Multiline = true;
            tbNote.Name = "tbNote";
            tbNote.Padding = new Padding(10, 7, 10, 7);
            tbNote.PasswordChar = false;
            tbNote.PlaceholderColor = Color.DarkGray;
            tbNote.PlaceholderText = "";
            tbNote.Size = new Size(364, 184);
            tbNote.TabIndex = 9;
            tbNote.TextAlign = HorizontalAlignment.Left;
            tbNote.Texts = "";
            tbNote.UnderlinedStyle = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel2.Controls.Add(btnSave);
            panel2.Location = new Point(3, 724);
            panel2.Name = "panel2";
            panel2.Size = new Size(377, 64);
            panel2.TabIndex = 17;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(154, 59, 59);
            btnSave.Dock = DockStyle.Fill;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(0, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(377, 64);
            btnSave.TabIndex = 16;
            btnSave.Text = "LƯU BIÊN NHẬN";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(roundedPanel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 87);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10, 3, 10, 10);
            panel3.Size = new Size(877, 930);
            panel3.TabIndex = 9;
            // 
            // panel8
            // 
            panel8.Controls.Add(roundedPanel11);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(10, 66);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(0, 10, 0, 10);
            panel8.Size = new Size(857, 778);
            panel8.TabIndex = 5;
            // 
            // roundedPanel11
            // 
            roundedPanel11.BackColor = Color.FromArgb(0, 0, 0, 0);
            roundedPanel11.Controls.Add(dgProducts);
            roundedPanel11.Dock = DockStyle.Fill;
            roundedPanel11.ForeColor = Color.White;
            roundedPanel11.Location = new Point(0, 10);
            roundedPanel11.Name = "roundedPanel11";
            roundedPanel11.Size = new Size(857, 758);
            roundedPanel11.TabIndex = 0;
            // 
            // dgProducts
            // 
            dgProducts.AllowUserToAddRows = false;
            dgProducts.BackgroundColor = Color.FromArgb(249, 245, 220);
            dgProducts.BorderStyle = BorderStyle.None;
            dgProducts.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgProducts.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgProducts.ColumnHeadersHeight = 55;
            dgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgProducts.Columns.AddRange(new DataGridViewColumn[] { id, barcode, name, price, quantity, total, delete, product_id });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.RosyBrown;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgProducts.DefaultCellStyle = dataGridViewCellStyle4;
            dgProducts.Dock = DockStyle.Fill;
            dgProducts.EnableHeadersVisualStyles = false;
            dgProducts.GridColor = Color.FromArgb(224, 224, 224);
            dgProducts.Location = new Point(0, 0);
            dgProducts.Margin = new Padding(0);
            dgProducts.MultiSelect = false;
            dgProducts.Name = "dgProducts";
            dgProducts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgProducts.RowHeadersVisible = false;
            dgProducts.RowHeadersWidth = 50;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(226, 199, 153);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dgProducts.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgProducts.RowTemplate.Height = 50;
            dgProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProducts.Size = new Size(857, 758);
            dgProducts.TabIndex = 6;
            dgProducts.CellContentClick += dgProducts_CellContentClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanel1);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(10, 844);
            panel4.Name = "panel4";
            panel4.Size = new Size(857, 76);
            panel4.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(panel5, 0, 0);
            tableLayoutPanel1.Controls.Add(panel6, 1, 0);
            tableLayoutPanel1.Controls.Add(panel7, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(857, 64);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnRenew);
            panel5.Controls.Add(rjButton1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(279, 58);
            panel5.TabIndex = 0;
            // 
            // btnRenew
            // 
            btnRenew.BackColor = Color.FromArgb(154, 59, 59);
            btnRenew.BackgroundColor = Color.FromArgb(154, 59, 59);
            btnRenew.BorderColor = Color.PaleVioletRed;
            btnRenew.BorderRadius = 5;
            btnRenew.BorderSize = 0;
            btnRenew.Dock = DockStyle.Fill;
            btnRenew.FlatAppearance.BorderSize = 0;
            btnRenew.FlatStyle = FlatStyle.Flat;
            btnRenew.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRenew.ForeColor = Color.White;
            btnRenew.Location = new Point(0, 0);
            btnRenew.Name = "btnRenew";
            btnRenew.Size = new Size(279, 58);
            btnRenew.TabIndex = 1;
            btnRenew.Text = "THÊM PHIẾU";
            btnRenew.TextColor = Color.White;
            btnRenew.UseVisualStyleBackColor = false;
            btnRenew.Click += btnRenew_Click;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(154, 59, 59);
            rjButton1.BackgroundColor = Color.FromArgb(154, 59, 59);
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 5;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(0, 28);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(279, 40);
            rjButton1.TabIndex = 0;
            rjButton1.Text = "THÊM PHIẾU";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnCanceled);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(288, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(279, 58);
            panel6.TabIndex = 1;
            // 
            // btnCanceled
            // 
            btnCanceled.BackColor = Color.FromArgb(154, 59, 59);
            btnCanceled.BackgroundColor = Color.FromArgb(154, 59, 59);
            btnCanceled.BorderColor = Color.PaleVioletRed;
            btnCanceled.BorderRadius = 5;
            btnCanceled.BorderSize = 0;
            btnCanceled.Dock = DockStyle.Fill;
            btnCanceled.FlatAppearance.BorderSize = 0;
            btnCanceled.FlatStyle = FlatStyle.Flat;
            btnCanceled.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCanceled.ForeColor = Color.White;
            btnCanceled.Location = new Point(0, 0);
            btnCanceled.Name = "btnCanceled";
            btnCanceled.Size = new Size(279, 58);
            btnCanceled.TabIndex = 2;
            btnCanceled.Text = "HỦY PHIẾU";
            btnCanceled.TextColor = Color.White;
            btnCanceled.UseVisualStyleBackColor = false;
            btnCanceled.Click += btnCanceled_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnPrint);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(573, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(281, 58);
            panel7.TabIndex = 2;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(154, 59, 59);
            btnPrint.BackgroundColor = Color.FromArgb(154, 59, 59);
            btnPrint.BorderColor = Color.PaleVioletRed;
            btnPrint.BorderRadius = 5;
            btnPrint.BorderSize = 0;
            btnPrint.Dock = DockStyle.Fill;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(0, 0);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(281, 58);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "IN PHIẾU";
            btnPrint.TextColor = Color.White;
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.FromArgb(249, 245, 220);
            roundedPanel4.Controls.Add(panel9);
            roundedPanel4.Controls.Add(dungeonHeaderLabel2);
            roundedPanel4.Dock = DockStyle.Top;
            roundedPanel4.ForeColor = Color.White;
            roundedPanel4.Location = new Point(10, 3);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(857, 63);
            roundedPanel4.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(filter);
            panel9.Controls.Add(tbSearch);
            panel9.Dock = DockStyle.Right;
            panel9.Location = new Point(502, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(355, 63);
            panel9.TabIndex = 4;
            // 
            // filter
            // 
            filter.BackColor = Color.FromArgb(249, 245, 220);
            filter.ForeColor = Color.Black;
            filter.IconChar = FontAwesome.Sharp.IconChar.Filter;
            filter.IconColor = Color.Black;
            filter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            filter.Location = new Point(33, 15);
            filter.Name = "filter";
            filter.Size = new Size(32, 32);
            filter.TabIndex = 4;
            filter.TabStop = false;
            filter.Click += filter_Click;
            // 
            // tbSearch
            // 
            tbSearch.BackColor = SystemColors.Window;
            tbSearch.BorderColor = Color.FromArgb(154, 59, 59);
            tbSearch.BorderFocusColor = Color.HotPink;
            tbSearch.BorderRadius = 10;
            tbSearch.BorderSize = 2;
            tbSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbSearch.ForeColor = Color.FromArgb(64, 64, 64);
            tbSearch.Location = new Point(78, 10);
            tbSearch.Margin = new Padding(4);
            tbSearch.Multiline = false;
            tbSearch.Name = "tbSearch";
            tbSearch.Padding = new Padding(10, 7, 10, 7);
            tbSearch.PasswordChar = false;
            tbSearch.PlaceholderColor = Color.DarkGray;
            tbSearch.PlaceholderText = "Nhập/ Ấn vào để Scan";
            tbSearch.Size = new Size(267, 40);
            tbSearch.TabIndex = 3;
            tbSearch.TextAlign = HorizontalAlignment.Left;
            tbSearch.Texts = "";
            tbSearch.UnderlinedStyle = false;
            tbSearch._TextChanged += tbSearch__TextChanged;
            tbSearch.KeyDown += tbSearch_KeyDown;
            // 
            // dungeonHeaderLabel2
            // 
            dungeonHeaderLabel2.AutoSize = true;
            dungeonHeaderLabel2.BackColor = Color.Transparent;
            dungeonHeaderLabel2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dungeonHeaderLabel2.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel2.ImageAlign = ContentAlignment.MiddleLeft;
            dungeonHeaderLabel2.Location = new Point(3, 17);
            dungeonHeaderLabel2.Name = "dungeonHeaderLabel2";
            dungeonHeaderLabel2.Size = new Size(198, 30);
            dungeonHeaderLabel2.TabIndex = 1;
            dungeonHeaderLabel2.Text = "Sản phẩm đã thêm";
            // 
            // print_review_order
            // 
            print_review_order.AutoScrollMargin = new Size(0, 0);
            print_review_order.AutoScrollMinSize = new Size(0, 0);
            print_review_order.ClientSize = new Size(400, 300);
            print_review_order.Enabled = true;
            print_review_order.Icon = (Icon)resources.GetObject("print_review_order.Icon");
            print_review_order.Name = "print_review_order";
            print_review_order.Visible = false;
            // 
            // print_order
            // 
            print_order.PrintPage += print_order_PrintPage;
            // 
            // id
            // 
            id.HeaderText = "Mã SP";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // barcode
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = resources.GetObject("dataGridViewCellStyle2.NullValue");
            dataGridViewCellStyle2.Padding = new Padding(5);
            barcode.DefaultCellStyle = dataGridViewCellStyle2;
            barcode.HeaderText = "Barcode";
            barcode.Name = "barcode";
            barcode.ReadOnly = true;
            barcode.Width = 150;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.FillWeight = 28.3298721F;
            name.HeaderText = "Tên Sản Phẩm";
            name.MinimumWidth = 6;
            name.Name = "name";
            // 
            // price
            // 
            price.FillWeight = 4.35844231F;
            price.HeaderText = "Giá Tiền";
            price.MinimumWidth = 6;
            price.Name = "price";
            // 
            // quantity
            // 
            quantity.FillWeight = 4.35844231F;
            quantity.HeaderText = "Số lượng";
            quantity.MinimumWidth = 6;
            quantity.Name = "quantity";
            // 
            // total
            // 
            total.HeaderText = "Tổng Tiền";
            total.Name = "total";
            total.ReadOnly = true;
            // 
            // delete
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Padding = new Padding(10);
            delete.DefaultCellStyle = dataGridViewCellStyle3;
            delete.HeaderText = "Thao Tác";
            delete.Name = "delete";
            delete.Text = "Xóa";
            delete.UseColumnTextForButtonValue = true;
            // 
            // product_id
            // 
            product_id.HeaderText = "id";
            product_id.Name = "product_id";
            product_id.ReadOnly = true;
            product_id.Visible = false;
            product_id.Width = 5;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 1017);
            Controls.Add(panel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Order";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Order";
            WindowState = FormWindowState.Maximized;
            FormClosing += Order_FormClosing;
            Load += Order_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            roundedPanel7.ResumeLayout(false);
            roundedPanel7.PerformLayout();
            roundedPanel8.ResumeLayout(false);
            roundedPanel8.PerformLayout();
            roundedPanel5.ResumeLayout(false);
            roundedPanel5.PerformLayout();
            roundedPanel6.ResumeLayout(false);
            roundedPanel6.PerformLayout();
            roundedPanel9.ResumeLayout(false);
            roundedPanel9.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            parrotGroupBox1.ResumeLayout(false);
            parrotGroupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            roundedPanel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgProducts).EndInit();
            panel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)filter).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Helpers.UI.RoundedPanel roundedPanel1;
        private PictureBox pictureBox1;
        private Helpers.UI.DatetimePickerCustom datetimePickerCustom1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Helpers.UI.RoundedPanel roundedPanel2;
        private Helpers.UI.RoundedPanel roundedPanel3;
        private Label label4;
        private Helpers.UI.DatetimePickerCustom datetimePickerCustom2;
        private Helpers.UI.RoundedPanel roundedPanel5;
        private Label label5;
        private Helpers.UI.RJTextBox tbDiscount;
        private Helpers.UI.RoundedPanel roundedPanel6;
        private Label label6;
        private Label label7;
        private Helpers.UI.RoundedPanel roundedPanel7;
        private Label label8;
        private Label label9;
        private Helpers.UI.RoundedPanel roundedPanel8;
        private Label label11;
        private Helpers.UI.RoundedPanel roundedPanel9;
        private Label label13;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Helpers.UI.RoundedPanel roundedPanel10;
        private Helpers.UI.RJTextBox tbSurcharge;
        private Helpers.UI.RJTextBox tbReceived;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        private Helpers.UI.RJTextBox tbNote;
        private Helpers.UI.RoundedButton btnSave;
        private Panel panel2;
        private Panel panel3;
        private Helpers.UI.RoundedPanel roundedPanel4;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lb_index;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel2;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel3;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel5;
        private Helpers.UI.RJButton btnRenew;
        private Helpers.UI.RJButton rjButton1;
        private Panel panel6;
        private Helpers.UI.RJButton btnCanceled;
        private Panel panel7;
        private Helpers.UI.RJButton btnPrint;
        private Panel panel8;
        private Helpers.UI.RJTextBox tbSearch;
        private Panel panel9;
        private Helpers.UI.RoundedPanel roundedPanel11;
        private DataGridView dgProducts;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lbTotal;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lbMoneyChange;
        private PrintPreviewDialog print_review_order;
        private System.Drawing.Printing.PrintDocument print_order;
        private FontAwesome.Sharp.IconPictureBox filter;
        private DataGridViewTextBoxColumn id;
        private DataGridViewImageColumn barcode;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn total;
        private DataGridViewButtonColumn delete;
        private DataGridViewTextBoxColumn product_id;
    }
}