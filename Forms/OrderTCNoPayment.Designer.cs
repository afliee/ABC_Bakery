using ABC_Bakery.Helpers.UI;
using Color = System.Drawing.Color;
using Image = System.Drawing.Image;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;

namespace ABC_Bakery.Forms
{
    partial class OrderTCNoPayment
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
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
            label6 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            roundedPanel4 = new Helpers.UI.RoundedPanel();
            dt_date = new Helpers.UI.DatetimePickerCustom();
            roundedPanel2 = new Helpers.UI.RoundedPanel();
            panel4 = new Panel();
            panel5 = new Panel();
            roundedPanel3 = new Helpers.UI.RoundedPanel();
            dgOrders = new DataGridView();
            stt = new DataGridViewTextBoxColumn();
            maBienNhan = new DataGridViewTextBoxColumn();
            orderDate = new DataGridViewTextBoxColumn();
            refund_date = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            note = new DataGridViewTextBoxColumn();
            roundedPanel1 = new Helpers.UI.RoundedPanel();
            roundedPanel5 = new Helpers.UI.RoundedPanel();
            panel1 = new Panel();
            dgOrderDetail = new DataGridView();
            order_name = new DataGridViewTextBoxColumn();
            order_quantity = new DataGridViewTextBoxColumn();
            order_total = new DataGridViewTextBoxColumn();
            oderDetail_Id = new DataGridViewTextBoxColumn();
            panel6 = new Panel();
            metroDivider2 = new ReaLTaiizor.Controls.MetroDivider();
            lb_pay = new ReaLTaiizor.Controls.MetroLabel();
            lb_deposit = new ReaLTaiizor.Controls.MetroLabel();
            dungeonLabel2 = new ReaLTaiizor.Controls.DungeonLabel();
            dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            rb_not_done = new ReaLTaiizor.Controls.CyberRadioButton();
            rb_done = new ReaLTaiizor.Controls.CyberRadioButton();
            roundedPanel6 = new Helpers.UI.RoundedPanel();
            label2 = new Label();
            metroDivider1 = new ReaLTaiizor.Controls.MetroDivider();
            btnSave = new Helpers.UI.RoundedButton();
            panel3 = new Panel();
            panel2.SuspendLayout();
            roundedPanel4.SuspendLayout();
            roundedPanel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            roundedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgOrders).BeginInit();
            roundedPanel1.SuspendLayout();
            roundedPanel5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgOrderDetail).BeginInit();
            panel6.SuspendLayout();
            parrotGroupBox1.SuspendLayout();
            roundedPanel6.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(5, 15);
            label6.Name = "label6";
            label6.Size = new Size(104, 22);
            label6.TabIndex = 0;
            label6.Text = "Biên nhận";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Arial Narrow", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 8);
            label1.Margin = new Padding(15);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(405, 33);
            label1.TabIndex = 9;
            label1.Text = "Biên nhận thế chân chưa thanh toán";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel2.Controls.Add(roundedPanel4);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1033, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(401, 65);
            panel2.TabIndex = 10;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.FromArgb(154, 59, 59);
            roundedPanel4.Controls.Add(dt_date);
            roundedPanel4.Dock = DockStyle.Fill;
            roundedPanel4.ForeColor = Color.White;
            roundedPanel4.Location = new Point(5, 5);
            roundedPanel4.Margin = new Padding(3, 15, 3, 3);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(391, 55);
            roundedPanel4.TabIndex = 7;
            // 
            // dt_date
            // 
            dt_date.BorderColor = Color.FromArgb(154, 59, 59);
            dt_date.BorderSize = 3;
            dt_date.CalendarFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dt_date.CustomFormat = "dddd , dd MMMM yyyy";
            dt_date.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dt_date.Location = new Point(16, 2);
            dt_date.MinimumSize = new Size(4, 50);
            dt_date.Name = "dt_date";
            dt_date.Size = new Size(366, 50);
            dt_date.SkinColor = Color.FromArgb(154, 59, 59);
            dt_date.TabIndex = 1;
            dt_date.TextColor = Color.White;
            dt_date.ValueChanged += dt_date_ValueChanged;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.FromArgb(249, 245, 220);
            roundedPanel2.Controls.Add(label6);
            roundedPanel2.Dock = DockStyle.Top;
            roundedPanel2.ForeColor = Color.Black;
            roundedPanel2.Location = new Point(15, 3);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(1003, 56);
            roundedPanel2.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(roundedPanel2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 65);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(15, 3, 15, 15);
            panel4.Size = new Size(1033, 737);
            panel4.TabIndex = 20;
            // 
            // panel5
            // 
            panel5.Controls.Add(roundedPanel3);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(15, 59);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 10, 0, 10);
            panel5.Size = new Size(1003, 663);
            panel5.TabIndex = 8;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.FromArgb(0, 0, 0, 0);
            roundedPanel3.Controls.Add(dgOrders);
            roundedPanel3.Dock = DockStyle.Fill;
            roundedPanel3.ForeColor = Color.White;
            roundedPanel3.Location = new Point(0, 10);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(1003, 643);
            roundedPanel3.TabIndex = 0;
            // 
            // dgOrders
            // 
            dgOrders.AllowUserToAddRows = false;
            dgOrders.BackgroundColor = Color.FromArgb(249, 245, 220);
            dgOrders.BorderStyle = BorderStyle.None;
            dgOrders.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgOrders.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgOrders.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle16.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = Color.White;
            dataGridViewCellStyle16.NullValue = "dasd";
            dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle16.SelectionForeColor = Color.White;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            dgOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            dgOrders.ColumnHeadersHeight = 58;
            dgOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgOrders.Columns.AddRange(new DataGridViewColumn[] { stt, maBienNhan, orderDate, refund_date, total, note });
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle22.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle22.ForeColor = Color.White;
            dataGridViewCellStyle22.SelectionBackColor = Color.RosyBrown;
            dataGridViewCellStyle22.SelectionForeColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.False;
            dgOrders.DefaultCellStyle = dataGridViewCellStyle22;
            dgOrders.Dock = DockStyle.Fill;
            dgOrders.EnableHeadersVisualStyles = false;
            dgOrders.GridColor = Color.FromArgb(224, 224, 224);
            dgOrders.Location = new Point(0, 0);
            dgOrders.Margin = new Padding(0);
            dgOrders.MultiSelect = false;
            dgOrders.Name = "dgOrders";
            dgOrders.ReadOnly = true;
            dgOrders.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle23.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle23.ForeColor = Color.White;
            dataGridViewCellStyle23.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.True;
            dgOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            dgOrders.RowHeadersVisible = false;
            dgOrders.RowHeadersWidth = 51;
            dataGridViewCellStyle24.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle24.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle24.ForeColor = Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = Color.FromArgb(226, 199, 153);
            dataGridViewCellStyle24.SelectionForeColor = Color.Black;
            dgOrders.RowsDefaultCellStyle = dataGridViewCellStyle24;
            dgOrders.RowTemplate.Height = 50;
            dgOrders.ScrollBars = ScrollBars.None;
            dgOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgOrders.Size = new Size(1003, 643);
            dgOrders.TabIndex = 3;
            dgOrders.CellContentClick += dgOrders_CellContentClick;
            // 
            // stt
            // 
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            stt.DefaultCellStyle = dataGridViewCellStyle17;
            stt.HeaderText = "STT";
            stt.Name = "stt";
            stt.ReadOnly = true;
            // 
            // maBienNhan
            // 
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            maBienNhan.DefaultCellStyle = dataGridViewCellStyle18;
            maBienNhan.HeaderText = "Mã BN";
            maBienNhan.Name = "maBienNhan";
            maBienNhan.ReadOnly = true;
            maBienNhan.Width = 150;
            // 
            // orderDate
            // 
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            orderDate.DefaultCellStyle = dataGridViewCellStyle19;
            orderDate.HeaderText = "Ngày Đặt";
            orderDate.Name = "orderDate";
            orderDate.ReadOnly = true;
            orderDate.Width = 200;
            // 
            // refund_date
            // 
            refund_date.HeaderText = "Ngày trả";
            refund_date.Name = "refund_date";
            refund_date.ReadOnly = true;
            refund_date.Width = 150;
            // 
            // total
            // 
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleCenter;
            total.DefaultCellStyle = dataGridViewCellStyle20;
            total.HeaderText = "Tổng Tiền";
            total.Name = "total";
            total.ReadOnly = true;
            total.Width = 200;
            // 
            // note
            // 
            note.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleCenter;
            note.DefaultCellStyle = dataGridViewCellStyle21;
            note.HeaderText = "Ghi Chú";
            note.Name = "note";
            note.ReadOnly = true;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(0, 0, 0, 0);
            roundedPanel1.Controls.Add(roundedPanel5);
            roundedPanel1.Dock = DockStyle.Right;
            roundedPanel1.ForeColor = Color.White;
            roundedPanel1.Location = new Point(1033, 65);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Padding = new Padding(5, 3, 5, 25);
            roundedPanel1.Size = new Size(401, 737);
            roundedPanel1.TabIndex = 19;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.FromArgb(255, 224, 192);
            roundedPanel5.Controls.Add(panel1);
            roundedPanel5.Controls.Add(roundedPanel6);
            roundedPanel5.Controls.Add(btnSave);
            roundedPanel5.Dock = DockStyle.Fill;
            roundedPanel5.ForeColor = Color.White;
            roundedPanel5.Location = new Point(5, 3);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Padding = new Padding(3);
            roundedPanel5.Size = new Size(391, 709);
            roundedPanel5.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgOrderDetail);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(parrotGroupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 584);
            panel1.TabIndex = 8;
            // 
            // dgOrderDetail
            // 
            dgOrderDetail.AllowUserToAddRows = false;
            dgOrderDetail.BackgroundColor = Color.FromArgb(249, 245, 220);
            dgOrderDetail.BorderStyle = BorderStyle.None;
            dgOrderDetail.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgOrderDetail.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = Color.FromArgb(249, 245, 220);
            dataGridViewCellStyle25.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle25.ForeColor = Color.Black;
            dataGridViewCellStyle25.Padding = new Padding(0, 10, 0, 0);
            dataGridViewCellStyle25.SelectionBackColor = Color.FromArgb(249, 245, 220);
            dataGridViewCellStyle25.SelectionForeColor = Color.Black;
            dataGridViewCellStyle25.WrapMode = DataGridViewTriState.True;
            dgOrderDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            dgOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOrderDetail.Columns.AddRange(new DataGridViewColumn[] { order_name, order_quantity, order_total, oderDetail_Id });
            dataGridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = Color.FromArgb(249, 245, 220);
            dataGridViewCellStyle29.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle29.ForeColor = Color.White;
            dataGridViewCellStyle29.SelectionBackColor = Color.FromArgb(249, 245, 220);
            dataGridViewCellStyle29.SelectionForeColor = Color.Black;
            dataGridViewCellStyle29.WrapMode = DataGridViewTriState.False;
            dgOrderDetail.DefaultCellStyle = dataGridViewCellStyle29;
            dgOrderDetail.Dock = DockStyle.Fill;
            dgOrderDetail.EnableHeadersVisualStyles = false;
            dgOrderDetail.GridColor = Color.FromArgb(224, 224, 224);
            dgOrderDetail.Location = new Point(0, 0);
            dgOrderDetail.Name = "dgOrderDetail";
            dgOrderDetail.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgOrderDetail.RowHeadersVisible = false;
            dataGridViewCellStyle30.BackColor = Color.FromArgb(249, 245, 220);
            dataGridViewCellStyle30.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle30.ForeColor = Color.Black;
            dataGridViewCellStyle30.SelectionBackColor = Color.FromArgb(249, 245, 220);
            dataGridViewCellStyle30.SelectionForeColor = Color.Black;
            dgOrderDetail.RowsDefaultCellStyle = dataGridViewCellStyle30;
            dgOrderDetail.RowTemplate.Height = 42;
            dgOrderDetail.Size = new Size(385, 377);
            dgOrderDetail.TabIndex = 6;
            dgOrderDetail.CellEndEdit += dgOrderDetail_CellEndEdit;
            // 
            // order_name
            // 
            order_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleLeft;
            order_name.DefaultCellStyle = dataGridViewCellStyle26;
            order_name.HeaderText = "Tên";
            order_name.Name = "order_name";
            // 
            // order_quantity
            // 
            dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleLeft;
            order_quantity.DefaultCellStyle = dataGridViewCellStyle27;
            order_quantity.HeaderText = "SL";
            order_quantity.Name = "order_quantity";
            order_quantity.Width = 65;
            // 
            // order_total
            // 
            dataGridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleLeft;
            order_total.DefaultCellStyle = dataGridViewCellStyle28;
            order_total.HeaderText = "Thành tiền";
            order_total.Name = "order_total";
            order_total.Width = 150;
            // 
            // oderDetail_Id
            // 
            oderDetail_Id.HeaderText = "";
            oderDetail_Id.Name = "oderDetail_Id";
            oderDetail_Id.ReadOnly = true;
            oderDetail_Id.Visible = false;
            oderDetail_Id.Width = 5;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(249, 245, 220);
            panel6.Controls.Add(metroDivider2);
            panel6.Controls.Add(lb_pay);
            panel6.Controls.Add(lb_deposit);
            panel6.Controls.Add(dungeonLabel2);
            panel6.Controls.Add(dungeonLabel1);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 377);
            panel6.Name = "panel6";
            panel6.Size = new Size(385, 90);
            panel6.TabIndex = 3;
            // 
            // metroDivider2
            // 
            metroDivider2.IsDerivedStyle = true;
            metroDivider2.Location = new Point(13, 79);
            metroDivider2.Name = "metroDivider2";
            metroDivider2.Orientation = ReaLTaiizor.Enum.Metro.DividerStyle.Horizontal;
            metroDivider2.Size = new Size(362, 4);
            metroDivider2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroDivider2.StyleManager = null;
            metroDivider2.TabIndex = 2;
            metroDivider2.Text = "metroDivider2";
            metroDivider2.ThemeAuthor = "Taiizor";
            metroDivider2.ThemeName = "MetroLight";
            metroDivider2.Thickness = 2;
            // 
            // lb_pay
            // 
            lb_pay.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_pay.IsDerivedStyle = true;
            lb_pay.Location = new Point(275, 52);
            lb_pay.Name = "lb_pay";
            lb_pay.Size = new Size(100, 23);
            lb_pay.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            lb_pay.StyleManager = null;
            lb_pay.TabIndex = 1;
            lb_pay.Text = "0đ";
            lb_pay.TextAlign = ContentAlignment.MiddleRight;
            lb_pay.ThemeAuthor = "Taiizor";
            lb_pay.ThemeName = "MetroLight";
            // 
            // lb_deposit
            // 
            lb_deposit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_deposit.IsDerivedStyle = true;
            lb_deposit.Location = new Point(278, 8);
            lb_deposit.Name = "lb_deposit";
            lb_deposit.Size = new Size(97, 23);
            lb_deposit.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            lb_deposit.StyleManager = null;
            lb_deposit.TabIndex = 1;
            lb_deposit.Text = "0đ";
            lb_deposit.TextAlign = ContentAlignment.MiddleRight;
            lb_deposit.ThemeAuthor = "Taiizor";
            lb_deposit.ThemeName = "MetroLight";
            // 
            // dungeonLabel2
            // 
            dungeonLabel2.AutoSize = true;
            dungeonLabel2.BackColor = Color.Transparent;
            dungeonLabel2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dungeonLabel2.ForeColor = Color.Black;
            dungeonLabel2.Location = new Point(10, 50);
            dungeonLabel2.Name = "dungeonLabel2";
            dungeonLabel2.Size = new Size(123, 25);
            dungeonLabel2.TabIndex = 0;
            dungeonLabel2.Text = "Tiền phải trả";
            // 
            // dungeonLabel1
            // 
            dungeonLabel1.AutoSize = true;
            dungeonLabel1.BackColor = Color.Transparent;
            dungeonLabel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dungeonLabel1.ForeColor = Color.Black;
            dungeonLabel1.Location = new Point(10, 6);
            dungeonLabel1.Name = "dungeonLabel1";
            dungeonLabel1.Size = new Size(85, 25);
            dungeonLabel1.TabIndex = 0;
            dungeonLabel1.Text = "Tiền cọc";
            // 
            // parrotGroupBox1
            // 
            parrotGroupBox1.BackColor = Color.FromArgb(249, 245, 220);
            parrotGroupBox1.BorderColor = Color.FromArgb(0, 0, 0, 0);
            parrotGroupBox1.BorderWidth = 0;
            parrotGroupBox1.Controls.Add(rb_not_done);
            parrotGroupBox1.Controls.Add(rb_done);
            parrotGroupBox1.Dock = DockStyle.Bottom;
            parrotGroupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            parrotGroupBox1.Location = new Point(0, 467);
            parrotGroupBox1.Name = "parrotGroupBox1";
            parrotGroupBox1.ShowText = true;
            parrotGroupBox1.Size = new Size(385, 117);
            parrotGroupBox1.TabIndex = 2;
            parrotGroupBox1.TabStop = false;
            parrotGroupBox1.Text = "Thanh toán";
            parrotGroupBox1.TextColor = Color.Black;
            // 
            // rb_not_done
            // 
            rb_not_done.BackColor = Color.Transparent;
            rb_not_done.Background = true;
            rb_not_done.Background_WidthPen = 2F;
            rb_not_done.BackgroundPen = true;
            rb_not_done.Checked = false;
            rb_not_done.Color_1_Background_value = Color.Empty;
            rb_not_done.Color_2_Background_value = Color.Empty;
            rb_not_done.ColorBackground = Color.FromArgb(37, 52, 68);
            rb_not_done.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            rb_not_done.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            rb_not_done.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            rb_not_done.ColorChecked = Color.FromArgb(154, 59, 59);
            rb_not_done.ColorPen_1 = Color.FromArgb(37, 52, 68);
            rb_not_done.ColorPen_2 = Color.FromArgb(41, 63, 86);
            rb_not_done.CyberRadioButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            rb_not_done.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            rb_not_done.Effect_1_Transparency = 25;
            rb_not_done.Effect_2 = true;
            rb_not_done.Effect_2_ColorBackground = Color.White;
            rb_not_done.Effect_2_Transparency = 15;
            rb_not_done.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rb_not_done.ForeColor = Color.Black;
            rb_not_done.LinearGradient_Background = false;
            rb_not_done.LinearGradient_Value = false;
            rb_not_done.LinearGradientPen = false;
            rb_not_done.Location = new Point(199, 32);
            rb_not_done.Name = "rb_not_done";
            rb_not_done.RGB = false;
            rb_not_done.Rounding = true;
            rb_not_done.RoundingInt = 100;
            rb_not_done.Size = new Size(180, 45);
            rb_not_done.SizeChecked = 8;
            rb_not_done.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            rb_not_done.TabIndex = 1;
            rb_not_done.Tag = "Cyber";
            rb_not_done.TextButton = "Chưa hoàn thành";
            rb_not_done.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            rb_not_done.Timer_Effect_1 = 1;
            rb_not_done.Timer_RGB = 300;
            rb_not_done.Click += rb_not_done_Click;
            // 
            // rb_done
            // 
            rb_done.BackColor = Color.Transparent;
            rb_done.Background = true;
            rb_done.Background_WidthPen = 2F;
            rb_done.BackgroundPen = true;
            rb_done.Checked = false;
            rb_done.Color_1_Background_value = Color.Empty;
            rb_done.Color_2_Background_value = Color.Empty;
            rb_done.ColorBackground = Color.FromArgb(37, 52, 68);
            rb_done.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            rb_done.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            rb_done.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            rb_done.ColorChecked = Color.FromArgb(154, 59, 59);
            rb_done.ColorPen_1 = Color.FromArgb(37, 52, 68);
            rb_done.ColorPen_2 = Color.FromArgb(41, 63, 86);
            rb_done.CyberRadioButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            rb_done.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            rb_done.Effect_1_Transparency = 25;
            rb_done.Effect_2 = true;
            rb_done.Effect_2_ColorBackground = Color.Black;
            rb_done.Effect_2_Transparency = 15;
            rb_done.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rb_done.ForeColor = Color.Black;
            rb_done.LinearGradient_Background = false;
            rb_done.LinearGradient_Value = false;
            rb_done.LinearGradientPen = false;
            rb_done.Location = new Point(13, 32);
            rb_done.Name = "rb_done";
            rb_done.RGB = false;
            rb_done.Rounding = true;
            rb_done.RoundingInt = 100;
            rb_done.Size = new Size(180, 45);
            rb_done.SizeChecked = 8;
            rb_done.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            rb_done.TabIndex = 1;
            rb_done.Tag = "Cyber";
            rb_done.TextButton = "Hoàn thành";
            rb_done.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            rb_done.Timer_Effect_1 = 1;
            rb_done.Timer_RGB = 300;
            rb_done.Click += rb_done_Click;
            // 
            // roundedPanel6
            // 
            roundedPanel6.BackColor = Color.FromArgb(249, 245, 220);
            roundedPanel6.Controls.Add(label2);
            roundedPanel6.Controls.Add(metroDivider1);
            roundedPanel6.Dock = DockStyle.Top;
            roundedPanel6.ForeColor = Color.White;
            roundedPanel6.Location = new Point(3, 3);
            roundedPanel6.Margin = new Padding(3, 3, 3, 50);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new Size(385, 65);
            roundedPanel6.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(127, 12);
            label2.Name = "label2";
            label2.Size = new Size(157, 22);
            label2.TabIndex = 1;
            label2.Text = "Chi tiết hóa đơn";
            // 
            // metroDivider1
            // 
            metroDivider1.IsDerivedStyle = true;
            metroDivider1.Location = new Point(3, 49);
            metroDivider1.Name = "metroDivider1";
            metroDivider1.Orientation = ReaLTaiizor.Enum.Metro.DividerStyle.Horizontal;
            metroDivider1.Size = new Size(378, 4);
            metroDivider1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroDivider1.StyleManager = null;
            metroDivider1.TabIndex = 3;
            metroDivider1.Text = "metroDivider1";
            metroDivider1.ThemeAuthor = "Taiizor";
            metroDivider1.ThemeName = "MetroLight";
            metroDivider1.Thickness = 1;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(154, 59, 59);
            btnSave.Dock = DockStyle.Bottom;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(3, 652);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(385, 54);
            btnSave.TabIndex = 5;
            btnSave.Text = "LƯU BIÊN NHẬN";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1434, 65);
            panel3.TabIndex = 18;
            // 
            // OrderTCNoPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Bg;
            ClientSize = new Size(1434, 802);
            Controls.Add(panel4);
            Controls.Add(roundedPanel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderTCNoPayment";
            Text = "OrderNoPayment";
            WindowState = FormWindowState.Maximized;
            Load += OrderTCNoPayment_Load;
            panel2.ResumeLayout(false);
            roundedPanel4.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            roundedPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgOrders).EndInit();
            roundedPanel1.ResumeLayout(false);
            roundedPanel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgOrderDetail).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            parrotGroupBox1.ResumeLayout(false);
            parrotGroupBox1.PerformLayout();
            roundedPanel6.ResumeLayout(false);
            roundedPanel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label6;
        private Label label1;
        private Panel panel2;
        private RoundedPanel roundedPanel2;
        private Panel panel4;
        private RoundedPanel roundedPanel1;
        private RoundedPanel roundedPanel5;
        private Panel panel1;
        private Panel panel6;
        private ReaLTaiizor.Controls.MetroDivider metroDivider2;
        private ReaLTaiizor.Controls.MetroLabel lb_pay;
        private ReaLTaiizor.Controls.MetroLabel lb_deposit;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel2;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        private ReaLTaiizor.Controls.CyberRadioButton rb_not_done;
        private ReaLTaiizor.Controls.CyberRadioButton rb_done;
        private RoundedPanel roundedPanel6;
        private Label label2;
        private ReaLTaiizor.Controls.MetroDivider metroDivider1;
        private RoundedButton btnSave;
        private Panel panel3;
        private DataGridView dgOrderDetail;
        private RoundedPanel roundedPanel4;
        private DatetimePickerCustom dt_date;
        private Panel panel5;
        private RoundedPanel roundedPanel3;
        private DataGridView dgOrders;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn maBienNhan;
        private DataGridViewTextBoxColumn orderDate;
        private DataGridViewTextBoxColumn refund_date;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn note;
        private DataGridViewTextBoxColumn order_name;
        private DataGridViewTextBoxColumn order_quantity;
        private DataGridViewTextBoxColumn order_total;
        private DataGridViewTextBoxColumn oderDetail_Id;
    }
}