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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
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
            rjTextBox3 = new Helpers.UI.RJTextBox();
            label8 = new Label();
            label9 = new Label();
            roundedPanel8 = new Helpers.UI.RoundedPanel();
            rjTextBox4 = new Helpers.UI.RJTextBox();
            label10 = new Label();
            label11 = new Label();
            roundedPanel5 = new Helpers.UI.RoundedPanel();
            rjTextBox2 = new Helpers.UI.RJTextBox();
            label5 = new Label();
            roundedPanel6 = new Helpers.UI.RoundedPanel();
            rjTextBox1 = new Helpers.UI.RJTextBox();
            label7 = new Label();
            label6 = new Label();
            roundedPanel9 = new Helpers.UI.RoundedPanel();
            rjTextBox5 = new Helpers.UI.RJTextBox();
            label12 = new Label();
            label13 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            roundedPanel10 = new Helpers.UI.RoundedPanel();
            parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            rjTextBox6 = new Helpers.UI.RJTextBox();
            panel2 = new Panel();
            roundedButton1 = new Helpers.UI.RoundedButton();
            panel3 = new Panel();
            panel8 = new Panel();
            dataGridView3 = new DataGridView();
            stt = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            action = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel5 = new Panel();
            rjButton2 = new Helpers.UI.RJButton();
            rjButton1 = new Helpers.UI.RJButton();
            panel6 = new Panel();
            rjButton3 = new Helpers.UI.RJButton();
            panel7 = new Panel();
            rjButton4 = new Helpers.UI.RJButton();
            roundedPanel4 = new Helpers.UI.RoundedPanel();
            panel9 = new Panel();
            tbSearch = new Helpers.UI.RJTextBox();
            pictureBox2 = new PictureBox();
            dungeonHeaderLabel2 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            roundedPanel4.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel1.Controls.Add(dungeonHeaderLabel1);
            panel1.Controls.Add(bigLabel1);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 87);
            panel1.TabIndex = 0;
            // 
            // dungeonHeaderLabel1
            // 
            dungeonHeaderLabel1.AutoSize = true;
            dungeonHeaderLabel1.BackColor = Color.Transparent;
            dungeonHeaderLabel1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            dungeonHeaderLabel1.ForeColor = Color.White;
            dungeonHeaderLabel1.Location = new Point(10, 49);
            dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            dungeonHeaderLabel1.Size = new Size(83, 20);
            dungeonHeaderLabel1.TabIndex = 1;
            dungeonHeaderLabel1.Text = "No. 00001";
            dungeonHeaderLabel1.TextAlign = ContentAlignment.MiddleLeft;
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
            roundedPanel2.BackColor = Color.FromArgb(242, 236, 190);
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
            roundedPanel3.BackColor = Color.FromArgb(242, 236, 190);
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
            datetimePickerCustom2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            datetimePickerCustom2.Location = new Point(127, 0);
            datetimePickerCustom2.MinimumSize = new Size(4, 60);
            datetimePickerCustom2.Name = "datetimePickerCustom2";
            datetimePickerCustom2.Size = new Size(244, 60);
            datetimePickerCustom2.SkinColor = Color.FromArgb(242, 236, 190);
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
            roundedPanel7.BackColor = Color.FromArgb(242, 236, 190);
            roundedPanel7.Controls.Add(rjTextBox3);
            roundedPanel7.Controls.Add(label8);
            roundedPanel7.Controls.Add(label9);
            roundedPanel7.ForeColor = Color.White;
            roundedPanel7.Location = new Point(3, 281);
            roundedPanel7.Name = "roundedPanel7";
            roundedPanel7.Size = new Size(374, 60);
            roundedPanel7.TabIndex = 5;
            // 
            // rjTextBox3
            // 
            rjTextBox3.BackColor = SystemColors.Window;
            rjTextBox3.BorderColor = Color.FromArgb(154, 59, 59);
            rjTextBox3.BorderFocusColor = Color.HotPink;
            rjTextBox3.BorderRadius = 10;
            rjTextBox3.BorderSize = 2;
            rjTextBox3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rjTextBox3.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox3.Location = new Point(106, 6);
            rjTextBox3.Margin = new Padding(4);
            rjTextBox3.Multiline = false;
            rjTextBox3.Name = "rjTextBox3";
            rjTextBox3.Padding = new Padding(10, 7, 10, 7);
            rjTextBox3.PasswordChar = false;
            rjTextBox3.PlaceholderColor = Color.DarkGray;
            rjTextBox3.PlaceholderText = "";
            rjTextBox3.Size = new Size(216, 47);
            rjTextBox3.TabIndex = 3;
            rjTextBox3.Texts = "";
            rjTextBox3.UnderlinedStyle = false;
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
            roundedPanel8.BackColor = Color.FromArgb(242, 236, 190);
            roundedPanel8.Controls.Add(rjTextBox4);
            roundedPanel8.Controls.Add(label10);
            roundedPanel8.Controls.Add(label11);
            roundedPanel8.ForeColor = Color.White;
            roundedPanel8.Location = new Point(3, 347);
            roundedPanel8.Name = "roundedPanel8";
            roundedPanel8.Size = new Size(374, 60);
            roundedPanel8.TabIndex = 6;
            // 
            // rjTextBox4
            // 
            rjTextBox4.BackColor = SystemColors.Window;
            rjTextBox4.BorderColor = Color.FromArgb(154, 59, 59);
            rjTextBox4.BorderFocusColor = Color.HotPink;
            rjTextBox4.BorderRadius = 10;
            rjTextBox4.BorderSize = 2;
            rjTextBox4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rjTextBox4.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox4.Location = new Point(106, 6);
            rjTextBox4.Margin = new Padding(4);
            rjTextBox4.Multiline = false;
            rjTextBox4.Name = "rjTextBox4";
            rjTextBox4.Padding = new Padding(10, 7, 10, 7);
            rjTextBox4.PasswordChar = false;
            rjTextBox4.PlaceholderColor = Color.DarkGray;
            rjTextBox4.PlaceholderText = "";
            rjTextBox4.Size = new Size(216, 47);
            rjTextBox4.TabIndex = 4;
            rjTextBox4.Texts = "";
            rjTextBox4.UnderlinedStyle = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(320, 16);
            label10.Name = "label10";
            label10.Size = new Size(54, 25);
            label10.TabIndex = 2;
            label10.Text = "VND";
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
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.FromArgb(242, 236, 190);
            roundedPanel5.Controls.Add(rjTextBox2);
            roundedPanel5.Controls.Add(label5);
            roundedPanel5.ForeColor = Color.White;
            roundedPanel5.Location = new Point(3, 149);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(374, 60);
            roundedPanel5.TabIndex = 3;
            // 
            // rjTextBox2
            // 
            rjTextBox2.BackColor = SystemColors.Window;
            rjTextBox2.BorderColor = Color.FromArgb(154, 59, 59);
            rjTextBox2.BorderFocusColor = Color.HotPink;
            rjTextBox2.BorderRadius = 10;
            rjTextBox2.BorderSize = 2;
            rjTextBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rjTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox2.Location = new Point(145, 6);
            rjTextBox2.Margin = new Padding(4);
            rjTextBox2.Multiline = false;
            rjTextBox2.Name = "rjTextBox2";
            rjTextBox2.Padding = new Padding(10, 7, 10, 7);
            rjTextBox2.PasswordChar = false;
            rjTextBox2.PlaceholderColor = Color.DarkGray;
            rjTextBox2.PlaceholderText = "";
            rjTextBox2.Size = new Size(225, 47);
            rjTextBox2.TabIndex = 1;
            rjTextBox2.Texts = "";
            rjTextBox2.UnderlinedStyle = false;
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
            roundedPanel6.BackColor = Color.FromArgb(242, 236, 190);
            roundedPanel6.Controls.Add(rjTextBox1);
            roundedPanel6.Controls.Add(label7);
            roundedPanel6.Controls.Add(label6);
            roundedPanel6.ForeColor = Color.White;
            roundedPanel6.Location = new Point(3, 215);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new Size(374, 60);
            roundedPanel6.TabIndex = 4;
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = SystemColors.Window;
            rjTextBox1.BorderColor = Color.FromArgb(154, 59, 59);
            rjTextBox1.BorderFocusColor = Color.HotPink;
            rjTextBox1.BorderRadius = 10;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rjTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox1.Location = new Point(106, 6);
            rjTextBox1.Margin = new Padding(4);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "";
            rjTextBox1.Size = new Size(216, 47);
            rjTextBox1.TabIndex = 2;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
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
            roundedPanel9.BackColor = Color.FromArgb(242, 236, 190);
            roundedPanel9.Controls.Add(rjTextBox5);
            roundedPanel9.Controls.Add(label12);
            roundedPanel9.Controls.Add(label13);
            roundedPanel9.ForeColor = Color.White;
            roundedPanel9.Location = new Point(3, 413);
            roundedPanel9.Margin = new Padding(3, 3, 3, 15);
            roundedPanel9.Name = "roundedPanel9";
            roundedPanel9.Size = new Size(374, 60);
            roundedPanel9.TabIndex = 7;
            // 
            // rjTextBox5
            // 
            rjTextBox5.BackColor = SystemColors.Window;
            rjTextBox5.BorderColor = Color.FromArgb(154, 59, 59);
            rjTextBox5.BorderFocusColor = Color.HotPink;
            rjTextBox5.BorderRadius = 10;
            rjTextBox5.BorderSize = 2;
            rjTextBox5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rjTextBox5.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox5.Location = new Point(106, 6);
            rjTextBox5.Margin = new Padding(4);
            rjTextBox5.Multiline = false;
            rjTextBox5.Name = "rjTextBox5";
            rjTextBox5.Padding = new Padding(10, 7, 10, 7);
            rjTextBox5.PasswordChar = false;
            rjTextBox5.PlaceholderColor = Color.DarkGray;
            rjTextBox5.PlaceholderText = "";
            rjTextBox5.Size = new Size(216, 47);
            rjTextBox5.TabIndex = 5;
            rjTextBox5.Texts = "";
            rjTextBox5.UnderlinedStyle = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(320, 16);
            label12.Name = "label12";
            label12.Size = new Size(54, 25);
            label12.TabIndex = 2;
            label12.Text = "VND";
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
            parrotGroupBox1.Controls.Add(rjTextBox6);
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
            // rjTextBox6
            // 
            rjTextBox6.BackColor = SystemColors.Window;
            rjTextBox6.BorderColor = Color.FromArgb(154, 59, 59);
            rjTextBox6.BorderFocusColor = Color.HotPink;
            rjTextBox6.BorderRadius = 5;
            rjTextBox6.BorderSize = 2;
            rjTextBox6.Dock = DockStyle.Fill;
            rjTextBox6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rjTextBox6.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox6.Location = new Point(5, 31);
            rjTextBox6.Margin = new Padding(0);
            rjTextBox6.Multiline = true;
            rjTextBox6.Name = "rjTextBox6";
            rjTextBox6.Padding = new Padding(10, 7, 10, 7);
            rjTextBox6.PasswordChar = false;
            rjTextBox6.PlaceholderColor = Color.DarkGray;
            rjTextBox6.PlaceholderText = "";
            rjTextBox6.Size = new Size(364, 184);
            rjTextBox6.TabIndex = 9;
            rjTextBox6.Texts = "";
            rjTextBox6.UnderlinedStyle = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel2.Controls.Add(roundedButton1);
            panel2.Location = new Point(3, 724);
            panel2.Name = "panel2";
            panel2.Size = new Size(377, 64);
            panel2.TabIndex = 17;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.FromArgb(154, 59, 59);
            roundedButton1.Dock = DockStyle.Fill;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(0, 0);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(377, 64);
            roundedButton1.TabIndex = 16;
            roundedButton1.Text = "LƯU BIÊN NHẬN";
            roundedButton1.UseVisualStyleBackColor = false;
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
            panel8.Controls.Add(dataGridView3);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(10, 66);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(0, 10, 0, 0);
            panel8.Size = new Size(857, 778);
            panel8.TabIndex = 5;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridView3.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.NullValue = "dasd";
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView3.ColumnHeadersHeight = 54;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { stt, name, price, quantity, total, action });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle8.SelectionBackColor = Color.RosyBrown;
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView3.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.GridColor = Color.FromArgb(224, 224, 224);
            dataGridView3.Location = new Point(0, 10);
            dataGridView3.Margin = new Padding(0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(255, 224, 192);
            dataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.ScrollBars = ScrollBars.None;
            dataGridView3.Size = new Size(857, 768);
            dataGridView3.TabIndex = 4;
            // 
            // stt
            // 
            stt.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle7.BackColor = Color.Red;
            dataGridViewCellStyle7.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.White;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            stt.DefaultCellStyle = dataGridViewCellStyle7;
            stt.Frozen = true;
            stt.HeaderText = "STT";
            stt.MinimumWidth = 6;
            stt.Name = "stt";
            stt.Resizable = DataGridViewTriState.True;
            stt.Width = 60;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            name.FillWeight = 273.6842F;
            name.HeaderText = "Tên Sản Phẩm";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.Width = 170;
            // 
            // price
            // 
            price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            price.FillWeight = 42.1052666F;
            price.HeaderText = "Giá Tiền";
            price.MinimumWidth = 6;
            price.Name = "price";
            // 
            // quantity
            // 
            quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            quantity.FillWeight = 42.1052666F;
            quantity.HeaderText = "Số lượng";
            quantity.MinimumWidth = 6;
            quantity.Name = "quantity";
            // 
            // total
            // 
            total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            total.FillWeight = 42.1052666F;
            total.HeaderText = "Tổng Tiền";
            total.MinimumWidth = 6;
            total.Name = "total";
            // 
            // action
            // 
            action.HeaderText = "Thao Tác";
            action.Name = "action";
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
            panel5.Controls.Add(rjButton2);
            panel5.Controls.Add(rjButton1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(279, 58);
            panel5.TabIndex = 0;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.FromArgb(154, 59, 59);
            rjButton2.BackgroundColor = Color.FromArgb(154, 59, 59);
            rjButton2.BorderColor = Color.PaleVioletRed;
            rjButton2.BorderRadius = 5;
            rjButton2.BorderSize = 0;
            rjButton2.Dock = DockStyle.Fill;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rjButton2.ForeColor = Color.White;
            rjButton2.Location = new Point(0, 0);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(279, 58);
            rjButton2.TabIndex = 1;
            rjButton2.Text = "THÊM PHIẾU";
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
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
            panel6.Controls.Add(rjButton3);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(288, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(279, 58);
            panel6.TabIndex = 1;
            // 
            // rjButton3
            // 
            rjButton3.BackColor = Color.FromArgb(154, 59, 59);
            rjButton3.BackgroundColor = Color.FromArgb(154, 59, 59);
            rjButton3.BorderColor = Color.PaleVioletRed;
            rjButton3.BorderRadius = 5;
            rjButton3.BorderSize = 0;
            rjButton3.Dock = DockStyle.Fill;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.FlatStyle = FlatStyle.Flat;
            rjButton3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rjButton3.ForeColor = Color.White;
            rjButton3.Location = new Point(0, 0);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(279, 58);
            rjButton3.TabIndex = 2;
            rjButton3.Text = "HỦY PHIẾU";
            rjButton3.TextColor = Color.White;
            rjButton3.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(rjButton4);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(573, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(281, 58);
            panel7.TabIndex = 2;
            // 
            // rjButton4
            // 
            rjButton4.BackColor = Color.FromArgb(154, 59, 59);
            rjButton4.BackgroundColor = Color.FromArgb(154, 59, 59);
            rjButton4.BorderColor = Color.PaleVioletRed;
            rjButton4.BorderRadius = 5;
            rjButton4.BorderSize = 0;
            rjButton4.Dock = DockStyle.Fill;
            rjButton4.FlatAppearance.BorderSize = 0;
            rjButton4.FlatStyle = FlatStyle.Flat;
            rjButton4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rjButton4.ForeColor = Color.White;
            rjButton4.Location = new Point(0, 0);
            rjButton4.Name = "rjButton4";
            rjButton4.Size = new Size(281, 58);
            rjButton4.TabIndex = 2;
            rjButton4.Text = "IN PHIẾU";
            rjButton4.TextColor = Color.White;
            rjButton4.UseVisualStyleBackColor = false;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.FromArgb(242, 236, 190);
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
            panel9.Controls.Add(tbSearch);
            panel9.Controls.Add(pictureBox2);
            panel9.Dock = DockStyle.Right;
            panel9.Location = new Point(502, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(355, 63);
            panel9.TabIndex = 4;
            // 
            // tbSearch
            // 
            tbSearch.BackColor = SystemColors.Window;
            tbSearch.BorderColor = Color.FromArgb(154, 59, 59);
            tbSearch.BorderFocusColor = Color.HotPink;
            tbSearch.BorderRadius = 10;
            tbSearch.BorderSize = 2;
            tbSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbSearch.ForeColor = Color.FromArgb(64, 64, 64);
            tbSearch.Location = new Point(78, 9);
            tbSearch.Margin = new Padding(4);
            tbSearch.Multiline = false;
            tbSearch.Name = "tbSearch";
            tbSearch.Padding = new Padding(10, 7, 10, 7);
            tbSearch.PasswordChar = false;
            tbSearch.PlaceholderColor = Color.DarkGray;
            tbSearch.PlaceholderText = "";
            tbSearch.Size = new Size(267, 47);
            tbSearch.TabIndex = 3;
            tbSearch.Texts = "";
            tbSearch.UnderlinedStyle = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.find;
            pictureBox2.Location = new Point(44, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            panel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Helpers.UI.RJTextBox rjTextBox2;
        private Helpers.UI.RoundedPanel roundedPanel6;
        private Label label6;
        private Label label7;
        private Helpers.UI.RoundedPanel roundedPanel7;
        private Label label8;
        private Label label9;
        private Helpers.UI.RoundedPanel roundedPanel8;
        private Label label10;
        private Label label11;
        private Helpers.UI.RoundedPanel roundedPanel9;
        private Label label12;
        private Label label13;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Helpers.UI.RoundedPanel roundedPanel10;
        private Helpers.UI.RJTextBox rjTextBox1;
        private Helpers.UI.RJTextBox rjTextBox3;
        private Helpers.UI.RJTextBox rjTextBox4;
        private Helpers.UI.RJTextBox rjTextBox5;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        private Helpers.UI.RJTextBox rjTextBox6;
        private Helpers.UI.RoundedButton roundedButton1;
        private Panel panel2;
        private Panel panel3;
        private Helpers.UI.RoundedPanel roundedPanel4;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel2;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel3;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel5;
        private Helpers.UI.RJButton rjButton2;
        private Helpers.UI.RJButton rjButton1;
        private Panel panel6;
        private Helpers.UI.RJButton rjButton3;
        private Panel panel7;
        private Helpers.UI.RJButton rjButton4;
        private Panel panel8;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn action;
        private PictureBox pictureBox2;
        private Helpers.UI.RJTextBox tbSearch;
        private Panel panel9;
    }
}