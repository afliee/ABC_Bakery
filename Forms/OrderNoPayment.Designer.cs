using ABC_Bakery.Helpers.UI;
using Color = System.Drawing.Color;
using Image = System.Drawing.Image;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;

namespace ABC_Bakery.Forms
{
    partial class OrderNoPayment
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            label1 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            roundedPanel4 = new Helpers.UI.RoundedPanel();
            dt_date = new Helpers.UI.DatetimePickerCustom();
            panel4 = new Panel();
            panel5 = new Panel();
            roundedPanel3 = new Helpers.UI.RoundedPanel();
            dgOrders = new DataGridView();
            stt = new DataGridViewTextBoxColumn();
            maBienBhna = new DataGridViewTextBoxColumn();
            orderDate = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            deposit = new DataGridViewTextBoxColumn();
            note = new DataGridViewTextBoxColumn();
            roundedPanel2 = new Helpers.UI.RoundedPanel();
            label6 = new Label();
            roundedPanel1 = new Helpers.UI.RoundedPanel();
            roundedPanel5 = new Helpers.UI.RoundedPanel();
            panel1 = new Panel();
            dgOrderDetail = new DataGridView();
            order_name = new DataGridViewTextBoxColumn();
            order_quantity = new DataGridViewTextBoxColumn();
            order_total = new DataGridViewTextBoxColumn();
            oderDetail_Id = new DataGridViewTextBoxColumn();
            parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            rb_not_done = new ReaLTaiizor.Controls.CyberRadioButton();
            rb_done = new ReaLTaiizor.Controls.CyberRadioButton();
            roundedPanel6 = new Helpers.UI.RoundedPanel();
            label2 = new Label();
            metroDivider1 = new ReaLTaiizor.Controls.MetroDivider();
            btnSave = new Helpers.UI.RoundedButton();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            roundedPanel4.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            roundedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgOrders).BeginInit();
            roundedPanel2.SuspendLayout();
            roundedPanel1.SuspendLayout();
            roundedPanel5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgOrderDetail).BeginInit();
            parrotGroupBox1.SuspendLayout();
            roundedPanel6.SuspendLayout();
            SuspendLayout();
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
            label1.Size = new Size(400, 33);
            label1.TabIndex = 9;
            label1.Text = "Biên nhận tại quầy chưa thanh toán";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1457, 65);
            panel3.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel2.Controls.Add(roundedPanel4);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1056, 0);
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
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(roundedPanel2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 65);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(15, 3, 15, 15);
            panel4.Size = new Size(1056, 766);
            panel4.TabIndex = 14;
            // 
            // panel5
            // 
            panel5.Controls.Add(roundedPanel3);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(15, 59);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 10, 0, 10);
            panel5.Size = new Size(1026, 692);
            panel5.TabIndex = 7;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.FromArgb(0, 0, 0, 0);
            roundedPanel3.Controls.Add(dgOrders);
            roundedPanel3.Dock = DockStyle.Fill;
            roundedPanel3.ForeColor = Color.White;
            roundedPanel3.Location = new Point(0, 10);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(1026, 672);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.NullValue = "dasd";
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgOrders.ColumnHeadersHeight = 58;
            dgOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgOrders.Columns.AddRange(new DataGridViewColumn[] { stt, maBienBhna, orderDate, total, deposit, note });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.RosyBrown;
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgOrders.DefaultCellStyle = dataGridViewCellStyle7;
            dgOrders.Dock = DockStyle.Fill;
            dgOrders.EnableHeadersVisualStyles = false;
            dgOrders.GridColor = Color.FromArgb(224, 224, 224);
            dgOrders.Location = new Point(0, 0);
            dgOrders.Margin = new Padding(0);
            dgOrders.MultiSelect = false;
            dgOrders.Name = "dgOrders";
            dgOrders.ReadOnly = true;
            dgOrders.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgOrders.RowHeadersVisible = false;
            dgOrders.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(226, 199, 153);
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dgOrders.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dgOrders.RowTemplate.Height = 50;
            dgOrders.ScrollBars = ScrollBars.None;
            dgOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgOrders.Size = new Size(1026, 672);
            dgOrders.TabIndex = 3;
            dgOrders.CellContentClick += dgOrders_CellContentClick;
            // 
            // stt
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            stt.DefaultCellStyle = dataGridViewCellStyle2;
            stt.HeaderText = "STT";
            stt.Name = "stt";
            stt.ReadOnly = true;
            // 
            // maBienBhna
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            maBienBhna.DefaultCellStyle = dataGridViewCellStyle3;
            maBienBhna.HeaderText = "Mã Biên Nhận";
            maBienBhna.Name = "maBienBhna";
            maBienBhna.ReadOnly = true;
            maBienBhna.Width = 150;
            // 
            // orderDate
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            orderDate.DefaultCellStyle = dataGridViewCellStyle4;
            orderDate.HeaderText = "Ngày Đặt";
            orderDate.Name = "orderDate";
            orderDate.ReadOnly = true;
            orderDate.Width = 250;
            // 
            // total
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            total.DefaultCellStyle = dataGridViewCellStyle5;
            total.HeaderText = "Tổng Tiền";
            total.Name = "total";
            total.ReadOnly = true;
            total.Width = 200;
            // 
            // deposit
            // 
            deposit.HeaderText = "Tiền cọc";
            deposit.Name = "deposit";
            deposit.ReadOnly = true;
            // 
            // note
            // 
            note.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            note.DefaultCellStyle = dataGridViewCellStyle6;
            note.HeaderText = "Ghi Chú";
            note.Name = "note";
            note.ReadOnly = true;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.FromArgb(249, 245, 220);
            roundedPanel2.Controls.Add(label6);
            roundedPanel2.Dock = DockStyle.Top;
            roundedPanel2.ForeColor = Color.Black;
            roundedPanel2.Location = new Point(15, 3);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(1026, 56);
            roundedPanel2.TabIndex = 4;
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
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(0, 0, 0, 0);
            roundedPanel1.Controls.Add(roundedPanel5);
            roundedPanel1.Dock = DockStyle.Right;
            roundedPanel1.ForeColor = Color.White;
            roundedPanel1.Location = new Point(1056, 65);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Padding = new Padding(5, 3, 5, 25);
            roundedPanel1.Size = new Size(401, 766);
            roundedPanel1.TabIndex = 13;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.FromArgb(249, 245, 220);
            roundedPanel5.Controls.Add(panel1);
            roundedPanel5.Controls.Add(roundedPanel6);
            roundedPanel5.Controls.Add(btnSave);
            roundedPanel5.Dock = DockStyle.Fill;
            roundedPanel5.ForeColor = Color.White;
            roundedPanel5.Location = new Point(5, 3);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Padding = new Padding(3);
            roundedPanel5.Size = new Size(391, 738);
            roundedPanel5.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgOrderDetail);
            panel1.Controls.Add(parrotGroupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 613);
            panel1.TabIndex = 8;
            // 
            // dgOrderDetail
            // 
            dgOrderDetail.AllowUserToAddRows = false;
            dgOrderDetail.AllowUserToDeleteRows = false;
            dgOrderDetail.AllowUserToOrderColumns = true;
            dgOrderDetail.BackgroundColor = Color.FromArgb(249, 245, 220);
            dgOrderDetail.BorderStyle = BorderStyle.None;
            dgOrderDetail.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgOrderDetail.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(249, 245, 220);
            dataGridViewCellStyle10.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.Padding = new Padding(0, 10, 0, 0);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(249, 245, 220);
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgOrderDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOrderDetail.Columns.AddRange(new DataGridViewColumn[] { order_name, order_quantity, order_total, oderDetail_Id });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = Color.White;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dgOrderDetail.DefaultCellStyle = dataGridViewCellStyle14;
            dgOrderDetail.Dock = DockStyle.Fill;
            dgOrderDetail.EnableHeadersVisualStyles = false;
            dgOrderDetail.GridColor = Color.FromArgb(224, 224, 224);
            dgOrderDetail.Location = new Point(0, 0);
            dgOrderDetail.Name = "dgOrderDetail";
            dgOrderDetail.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgOrderDetail.RowHeadersVisible = false;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(249, 245, 220);
            dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(249, 245, 220);
            dataGridViewCellStyle15.SelectionForeColor = Color.Black;
            dgOrderDetail.RowsDefaultCellStyle = dataGridViewCellStyle15;
            dgOrderDetail.RowTemplate.Height = 40;
            dgOrderDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgOrderDetail.Size = new Size(385, 502);
            dgOrderDetail.TabIndex = 6;
            dgOrderDetail.CellEndEdit += dgOrderDetail_CellEndEdit;
            // 
            // order_name
            // 
            order_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            order_name.DefaultCellStyle = dataGridViewCellStyle11;
            order_name.HeaderText = "Tên";
            order_name.Name = "order_name";
            order_name.ReadOnly = true;
            // 
            // order_quantity
            // 
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            order_quantity.DefaultCellStyle = dataGridViewCellStyle12;
            order_quantity.HeaderText = "SL";
            order_quantity.Name = "order_quantity";
            order_quantity.Width = 65;
            // 
            // order_total
            // 
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            order_total.DefaultCellStyle = dataGridViewCellStyle13;
            order_total.HeaderText = "Thành tiền";
            order_total.Name = "order_total";
            order_total.ReadOnly = true;
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
            // parrotGroupBox1
            // 
            parrotGroupBox1.BorderColor = Color.FromArgb(0, 0, 0, 0);
            parrotGroupBox1.BorderWidth = 0;
            parrotGroupBox1.Controls.Add(rb_not_done);
            parrotGroupBox1.Controls.Add(rb_done);
            parrotGroupBox1.Dock = DockStyle.Bottom;
            parrotGroupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            parrotGroupBox1.Location = new Point(0, 502);
            parrotGroupBox1.Name = "parrotGroupBox1";
            parrotGroupBox1.ShowText = true;
            parrotGroupBox1.Size = new Size(385, 111);
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
            rb_not_done.Load += rb_not_done_Load;
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
            btnSave.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(3, 681);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(385, 54);
            btnSave.TabIndex = 5;
            btnSave.Text = "LƯU BIÊN NHẬN";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // OrderNoPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1457, 831);
            Controls.Add(panel4);
            Controls.Add(roundedPanel1);
            Controls.Add(panel3);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderNoPayment";
            Text = "OrderNoPayment";
            Load += OrderNoPayment_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            roundedPanel4.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            roundedPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgOrders).EndInit();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            roundedPanel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgOrderDetail).EndInit();
            parrotGroupBox1.ResumeLayout(false);
            parrotGroupBox1.PerformLayout();
            roundedPanel6.ResumeLayout(false);
            roundedPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private RoundedPanel roundedPanel2;
        private Label label6;
        private RoundedPanel roundedPanel1;
        private Panel panel5;
        private RoundedPanel roundedPanel3;
        private DataGridView dgOrders;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn maBienBhna;
        private DataGridViewTextBoxColumn orderDate;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn deposit;
        private DataGridViewTextBoxColumn note;
        private Panel panel2;
        private RoundedPanel roundedPanel4;
        private DatetimePickerCustom dt_date;
        private RoundedPanel roundedPanel5;
        private Panel panel1;
        private DataGridView dgOrderDetail;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        private RoundedPanel roundedPanel6;
        private Label label2;
        private ReaLTaiizor.Controls.MetroDivider metroDivider1;
        private RoundedButton btnSave;
        private ReaLTaiizor.Controls.CyberRadioButton rb_not_done;
        private ReaLTaiizor.Controls.CyberRadioButton rb_done;
        private DataGridViewTextBoxColumn order_name;
        private DataGridViewTextBoxColumn order_quantity;
        private DataGridViewTextBoxColumn order_total;
        private DataGridViewTextBoxColumn oderDetail_Id;
    }
}