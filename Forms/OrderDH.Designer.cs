using ABC_Bakery.Helpers.UI;

namespace ABC_Bakery.Forms
{
    partial class OrderDH
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
            DataGridViewCellStyle dataGridViewCellStyle31 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle35 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle36 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle32 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle33 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle34 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle37 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle43 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle44 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle45 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle38 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle39 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle40 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle41 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle42 = new DataGridViewCellStyle();
            btnSave = new Helpers.UI.RoundedButton();
            label2 = new Label();
            roundedPanel6 = new Helpers.UI.RoundedPanel();
            metroDivider1 = new ReaLTaiizor.Controls.MetroDivider();
            panel1 = new Panel();
            dgOrderDetail = new DataGridView();
            order_name = new DataGridViewTextBoxColumn();
            order_quantity = new DataGridViewTextBoxColumn();
            order_total = new DataGridViewTextBoxColumn();
            oderDetail_Id = new DataGridViewTextBoxColumn();
            panel6 = new Panel();
            parrotGroupBox2 = new ReaLTaiizor.Controls.ParrotGroupBox();
            rb_not_delivery = new ReaLTaiizor.Controls.CyberRadioButton();
            rb_delivery = new ReaLTaiizor.Controls.CyberRadioButton();
            metroDivider2 = new ReaLTaiizor.Controls.MetroDivider();
            parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            rb_not_done = new ReaLTaiizor.Controls.CyberRadioButton();
            rb_done = new ReaLTaiizor.Controls.CyberRadioButton();
            roundedPanel5 = new Helpers.UI.RoundedPanel();
            roundedPanel1 = new Helpers.UI.RoundedPanel();
            panel3 = new Panel();
            label1 = new Label();
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
            roundedPanel6.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgOrderDetail).BeginInit();
            panel6.SuspendLayout();
            parrotGroupBox2.SuspendLayout();
            parrotGroupBox1.SuspendLayout();
            roundedPanel5.SuspendLayout();
            roundedPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            roundedPanel4.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            roundedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgOrders).BeginInit();
            roundedPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.FromArgb(154, 59, 59);
            btnSave.Dock = DockStyle.Bottom;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(3, 662);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(385, 54);
            btnSave.TabIndex = 5;
            btnSave.Text = "LƯU BIÊN NHẬN";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(127, 12);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(157, 22);
            label2.TabIndex = 1;
            label2.Text = "Chi tiết hóa đơn";
            // 
            // roundedPanel6
            // 
            roundedPanel6.BackColor = System.Drawing.Color.FromArgb(249, 245, 220);
            roundedPanel6.Controls.Add(label2);
            roundedPanel6.Controls.Add(metroDivider1);
            roundedPanel6.Dock = DockStyle.Top;
            roundedPanel6.ForeColor = System.Drawing.Color.White;
            roundedPanel6.Location = new System.Drawing.Point(3, 3);
            roundedPanel6.Margin = new Padding(3, 3, 3, 50);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new System.Drawing.Size(385, 65);
            roundedPanel6.TabIndex = 6;
            // 
            // metroDivider1
            // 
            metroDivider1.IsDerivedStyle = true;
            metroDivider1.Location = new System.Drawing.Point(3, 49);
            metroDivider1.Name = "metroDivider1";
            metroDivider1.Orientation = ReaLTaiizor.Enum.Metro.DividerStyle.Horizontal;
            metroDivider1.Size = new System.Drawing.Size(378, 4);
            metroDivider1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroDivider1.StyleManager = null;
            metroDivider1.TabIndex = 3;
            metroDivider1.Text = "metroDivider1";
            metroDivider1.ThemeAuthor = "Taiizor";
            metroDivider1.ThemeName = "MetroLight";
            metroDivider1.Thickness = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgOrderDetail);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(parrotGroupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(3, 68);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(385, 594);
            panel1.TabIndex = 8;
            // 
            // dgOrderDetail
            // 
            dgOrderDetail.AllowUserToAddRows = false;
            dgOrderDetail.AllowUserToDeleteRows = false;
            dgOrderDetail.AllowUserToOrderColumns = true;
            dgOrderDetail.BackgroundColor = System.Drawing.Color.FromArgb(249, 245, 220);
            dgOrderDetail.BorderStyle = BorderStyle.None;
            dgOrderDetail.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgOrderDetail.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle31.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(249, 245, 220);
            dataGridViewCellStyle31.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle31.Padding = new Padding(0, 10, 0, 0);
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(249, 245, 220);
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle31.WrapMode = DataGridViewTriState.True;
            dgOrderDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            dgOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOrderDetail.Columns.AddRange(new DataGridViewColumn[] { order_name, order_quantity, order_total, oderDetail_Id });
            dataGridViewCellStyle35.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle35.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = DataGridViewTriState.False;
            dgOrderDetail.DefaultCellStyle = dataGridViewCellStyle35;
            dgOrderDetail.Dock = DockStyle.Fill;
            dgOrderDetail.EnableHeadersVisualStyles = false;
            dgOrderDetail.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
            dgOrderDetail.Location = new System.Drawing.Point(0, 0);
            dgOrderDetail.Name = "dgOrderDetail";
            dgOrderDetail.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgOrderDetail.RowHeadersVisible = false;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(249, 245, 220);
            dataGridViewCellStyle36.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(249, 245, 220);
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.Black;
            dgOrderDetail.RowsDefaultCellStyle = dataGridViewCellStyle36;
            dgOrderDetail.RowTemplate.Height = 40;
            dgOrderDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgOrderDetail.Size = new System.Drawing.Size(385, 389);
            dgOrderDetail.TabIndex = 6;
            dgOrderDetail.CellContentClick += dgOrderDetail_CellContentClick;
            dgOrderDetail.CellEndEdit += dgOrderDetail_CellEndEdit;
            // 
            // order_name
            // 
            order_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle32.Alignment = DataGridViewContentAlignment.MiddleLeft;
            order_name.DefaultCellStyle = dataGridViewCellStyle32;
            order_name.HeaderText = "Tên";
            order_name.Name = "order_name";
            order_name.ReadOnly = true;
            // 
            // order_quantity
            // 
            dataGridViewCellStyle33.Alignment = DataGridViewContentAlignment.MiddleLeft;
            order_quantity.DefaultCellStyle = dataGridViewCellStyle33;
            order_quantity.HeaderText = "SL";
            order_quantity.Name = "order_quantity";
            order_quantity.Width = 65;
            // 
            // order_total
            // 
            dataGridViewCellStyle34.Alignment = DataGridViewContentAlignment.MiddleLeft;
            order_total.DefaultCellStyle = dataGridViewCellStyle34;
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
            // panel6
            // 
            panel6.Controls.Add(parrotGroupBox2);
            panel6.Controls.Add(metroDivider2);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new System.Drawing.Point(0, 389);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(385, 88);
            panel6.TabIndex = 3;
            // 
            // parrotGroupBox2
            // 
            parrotGroupBox2.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            parrotGroupBox2.BorderWidth = 0;
            parrotGroupBox2.Controls.Add(rb_not_delivery);
            parrotGroupBox2.Controls.Add(rb_delivery);
            parrotGroupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            parrotGroupBox2.Location = new System.Drawing.Point(3, 14);
            parrotGroupBox2.Name = "parrotGroupBox2";
            parrotGroupBox2.ShowText = true;
            parrotGroupBox2.Size = new System.Drawing.Size(385, 74);
            parrotGroupBox2.TabIndex = 3;
            parrotGroupBox2.TabStop = false;
            parrotGroupBox2.Text = "Giao hàng";
            parrotGroupBox2.TextColor = System.Drawing.Color.Black;
            // 
            // rb_not_delivery
            // 
            rb_not_delivery.BackColor = System.Drawing.Color.Transparent;
            rb_not_delivery.Background = true;
            rb_not_delivery.Background_WidthPen = 2F;
            rb_not_delivery.BackgroundPen = true;
            rb_not_delivery.Checked = false;
            rb_not_delivery.Color_1_Background_value = System.Drawing.Color.Empty;
            rb_not_delivery.Color_2_Background_value = System.Drawing.Color.Empty;
            rb_not_delivery.ColorBackground = System.Drawing.Color.FromArgb(37, 52, 68);
            rb_not_delivery.ColorBackground_1 = System.Drawing.Color.FromArgb(37, 52, 68);
            rb_not_delivery.ColorBackground_2 = System.Drawing.Color.FromArgb(41, 63, 86);
            rb_not_delivery.ColorBackground_Pen = System.Drawing.Color.FromArgb(29, 200, 238);
            rb_not_delivery.ColorChecked = System.Drawing.Color.FromArgb(154, 59, 59);
            rb_not_delivery.ColorPen_1 = System.Drawing.Color.FromArgb(37, 52, 68);
            rb_not_delivery.ColorPen_2 = System.Drawing.Color.FromArgb(41, 63, 86);
            rb_not_delivery.CyberRadioButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            rb_not_delivery.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(29, 200, 238);
            rb_not_delivery.Effect_1_Transparency = 25;
            rb_not_delivery.Effect_2 = true;
            rb_not_delivery.Effect_2_ColorBackground = System.Drawing.Color.White;
            rb_not_delivery.Effect_2_Transparency = 15;
            rb_not_delivery.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rb_not_delivery.ForeColor = System.Drawing.Color.Black;
            rb_not_delivery.LinearGradient_Background = false;
            rb_not_delivery.LinearGradient_Value = false;
            rb_not_delivery.LinearGradientPen = false;
            rb_not_delivery.Location = new System.Drawing.Point(196, 32);
            rb_not_delivery.Name = "rb_not_delivery";
            rb_not_delivery.RGB = false;
            rb_not_delivery.Rounding = true;
            rb_not_delivery.RoundingInt = 100;
            rb_not_delivery.Size = new System.Drawing.Size(180, 45);
            rb_not_delivery.SizeChecked = 8;
            rb_not_delivery.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            rb_not_delivery.TabIndex = 1;
            rb_not_delivery.Tag = "Cyber";
            rb_not_delivery.TextButton = "Chưa giao";
            rb_not_delivery.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            rb_not_delivery.Timer_Effect_1 = 1;
            rb_not_delivery.Timer_RGB = 300;
            rb_not_delivery.Click += rb_not_delivery_Click;
            // 
            // rb_delivery
            // 
            rb_delivery.BackColor = System.Drawing.Color.Transparent;
            rb_delivery.Background = true;
            rb_delivery.Background_WidthPen = 2F;
            rb_delivery.BackgroundPen = true;
            rb_delivery.Checked = false;
            rb_delivery.Color_1_Background_value = System.Drawing.Color.Empty;
            rb_delivery.Color_2_Background_value = System.Drawing.Color.Empty;
            rb_delivery.ColorBackground = System.Drawing.Color.FromArgb(37, 52, 68);
            rb_delivery.ColorBackground_1 = System.Drawing.Color.FromArgb(37, 52, 68);
            rb_delivery.ColorBackground_2 = System.Drawing.Color.FromArgb(41, 63, 86);
            rb_delivery.ColorBackground_Pen = System.Drawing.Color.FromArgb(29, 200, 238);
            rb_delivery.ColorChecked = System.Drawing.Color.FromArgb(154, 59, 59);
            rb_delivery.ColorPen_1 = System.Drawing.Color.FromArgb(37, 52, 68);
            rb_delivery.ColorPen_2 = System.Drawing.Color.FromArgb(41, 63, 86);
            rb_delivery.CyberRadioButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            rb_delivery.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(29, 200, 238);
            rb_delivery.Effect_1_Transparency = 25;
            rb_delivery.Effect_2 = true;
            rb_delivery.Effect_2_ColorBackground = System.Drawing.Color.Black;
            rb_delivery.Effect_2_Transparency = 15;
            rb_delivery.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rb_delivery.ForeColor = System.Drawing.Color.Black;
            rb_delivery.LinearGradient_Background = false;
            rb_delivery.LinearGradient_Value = false;
            rb_delivery.LinearGradientPen = false;
            rb_delivery.Location = new System.Drawing.Point(10, 32);
            rb_delivery.Name = "rb_delivery";
            rb_delivery.RGB = false;
            rb_delivery.Rounding = true;
            rb_delivery.RoundingInt = 100;
            rb_delivery.Size = new System.Drawing.Size(180, 45);
            rb_delivery.SizeChecked = 8;
            rb_delivery.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            rb_delivery.TabIndex = 1;
            rb_delivery.Tag = "Cyber";
            rb_delivery.TextButton = "Đã giao";
            rb_delivery.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            rb_delivery.Timer_Effect_1 = 1;
            rb_delivery.Timer_RGB = 300;
            rb_delivery.Click += rb_delivery_Click;
            // 
            // metroDivider2
            // 
            metroDivider2.IsDerivedStyle = true;
            metroDivider2.Location = new System.Drawing.Point(13, 3);
            metroDivider2.Name = "metroDivider2";
            metroDivider2.Orientation = ReaLTaiizor.Enum.Metro.DividerStyle.Horizontal;
            metroDivider2.Size = new System.Drawing.Size(366, 4);
            metroDivider2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroDivider2.StyleManager = null;
            metroDivider2.TabIndex = 2;
            metroDivider2.Text = "metroDivider2";
            metroDivider2.ThemeAuthor = "Taiizor";
            metroDivider2.ThemeName = "MetroLight";
            metroDivider2.Thickness = 2;
            // 
            // parrotGroupBox1
            // 
            parrotGroupBox1.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            parrotGroupBox1.BorderWidth = 0;
            parrotGroupBox1.Controls.Add(rb_not_done);
            parrotGroupBox1.Controls.Add(rb_done);
            parrotGroupBox1.Dock = DockStyle.Bottom;
            parrotGroupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            parrotGroupBox1.Location = new System.Drawing.Point(0, 477);
            parrotGroupBox1.Name = "parrotGroupBox1";
            parrotGroupBox1.ShowText = true;
            parrotGroupBox1.Size = new System.Drawing.Size(385, 117);
            parrotGroupBox1.TabIndex = 2;
            parrotGroupBox1.TabStop = false;
            parrotGroupBox1.Text = "Thanh toán";
            parrotGroupBox1.TextColor = System.Drawing.Color.Black;
            // 
            // rb_not_done
            // 
            rb_not_done.BackColor = System.Drawing.Color.Transparent;
            rb_not_done.Background = true;
            rb_not_done.Background_WidthPen = 2F;
            rb_not_done.BackgroundPen = true;
            rb_not_done.Checked = false;
            rb_not_done.Color_1_Background_value = System.Drawing.Color.Empty;
            rb_not_done.Color_2_Background_value = System.Drawing.Color.Empty;
            rb_not_done.ColorBackground = System.Drawing.Color.FromArgb(37, 52, 68);
            rb_not_done.ColorBackground_1 = System.Drawing.Color.FromArgb(37, 52, 68);
            rb_not_done.ColorBackground_2 = System.Drawing.Color.FromArgb(41, 63, 86);
            rb_not_done.ColorBackground_Pen = System.Drawing.Color.FromArgb(29, 200, 238);
            rb_not_done.ColorChecked = System.Drawing.Color.FromArgb(154, 59, 59);
            rb_not_done.ColorPen_1 = System.Drawing.Color.FromArgb(37, 52, 68);
            rb_not_done.ColorPen_2 = System.Drawing.Color.FromArgb(41, 63, 86);
            rb_not_done.CyberRadioButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            rb_not_done.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(29, 200, 238);
            rb_not_done.Effect_1_Transparency = 25;
            rb_not_done.Effect_2 = true;
            rb_not_done.Effect_2_ColorBackground = System.Drawing.Color.White;
            rb_not_done.Effect_2_Transparency = 15;
            rb_not_done.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rb_not_done.ForeColor = System.Drawing.Color.Black;
            rb_not_done.LinearGradient_Background = false;
            rb_not_done.LinearGradient_Value = false;
            rb_not_done.LinearGradientPen = false;
            rb_not_done.Location = new System.Drawing.Point(199, 32);
            rb_not_done.Name = "rb_not_done";
            rb_not_done.RGB = false;
            rb_not_done.Rounding = true;
            rb_not_done.RoundingInt = 100;
            rb_not_done.Size = new System.Drawing.Size(180, 45);
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
            rb_done.BackColor = System.Drawing.Color.Transparent;
            rb_done.Background = true;
            rb_done.Background_WidthPen = 2F;
            rb_done.BackgroundPen = true;
            rb_done.Checked = false;
            rb_done.Color_1_Background_value = System.Drawing.Color.Empty;
            rb_done.Color_2_Background_value = System.Drawing.Color.Empty;
            rb_done.ColorBackground = System.Drawing.Color.FromArgb(37, 52, 68);
            rb_done.ColorBackground_1 = System.Drawing.Color.FromArgb(37, 52, 68);
            rb_done.ColorBackground_2 = System.Drawing.Color.FromArgb(41, 63, 86);
            rb_done.ColorBackground_Pen = System.Drawing.Color.FromArgb(29, 200, 238);
            rb_done.ColorChecked = System.Drawing.Color.FromArgb(154, 59, 59);
            rb_done.ColorPen_1 = System.Drawing.Color.FromArgb(37, 52, 68);
            rb_done.ColorPen_2 = System.Drawing.Color.FromArgb(41, 63, 86);
            rb_done.CyberRadioButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            rb_done.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(29, 200, 238);
            rb_done.Effect_1_Transparency = 25;
            rb_done.Effect_2 = true;
            rb_done.Effect_2_ColorBackground = System.Drawing.Color.Black;
            rb_done.Effect_2_Transparency = 15;
            rb_done.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rb_done.ForeColor = System.Drawing.Color.Black;
            rb_done.LinearGradient_Background = false;
            rb_done.LinearGradient_Value = false;
            rb_done.LinearGradientPen = false;
            rb_done.Location = new System.Drawing.Point(13, 32);
            rb_done.Name = "rb_done";
            rb_done.RGB = false;
            rb_done.Rounding = true;
            rb_done.RoundingInt = 100;
            rb_done.Size = new System.Drawing.Size(180, 45);
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
            // roundedPanel5
            // 
            roundedPanel5.BackColor = System.Drawing.Color.FromArgb(249, 245, 220);
            roundedPanel5.Controls.Add(panel1);
            roundedPanel5.Controls.Add(roundedPanel6);
            roundedPanel5.Controls.Add(btnSave);
            roundedPanel5.Dock = DockStyle.Fill;
            roundedPanel5.ForeColor = System.Drawing.Color.White;
            roundedPanel5.Location = new System.Drawing.Point(5, 3);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Padding = new Padding(3);
            roundedPanel5.Size = new System.Drawing.Size(391, 719);
            roundedPanel5.TabIndex = 0;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            roundedPanel1.Controls.Add(roundedPanel5);
            roundedPanel1.Dock = DockStyle.Right;
            roundedPanel1.ForeColor = System.Drawing.Color.White;
            roundedPanel1.Location = new System.Drawing.Point(1194, 65);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Padding = new Padding(5, 3, 5, 25);
            roundedPanel1.Size = new System.Drawing.Size(401, 747);
            roundedPanel1.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new System.Drawing.Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(1595, 65);
            panel3.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Arial Narrow", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(15, 18);
            label1.Margin = new Padding(15);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new System.Drawing.Size(458, 33);
            label1.TabIndex = 9;
            label1.Text = "Biên nhận đơn đặt hàng chưa thanh toán";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            panel2.Controls.Add(roundedPanel4);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new System.Drawing.Point(1194, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new System.Drawing.Size(401, 65);
            panel2.TabIndex = 10;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = System.Drawing.Color.FromArgb(154, 59, 59);
            roundedPanel4.Controls.Add(dt_date);
            roundedPanel4.Dock = DockStyle.Fill;
            roundedPanel4.ForeColor = System.Drawing.Color.White;
            roundedPanel4.Location = new System.Drawing.Point(5, 5);
            roundedPanel4.Margin = new Padding(3, 15, 3, 3);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new System.Drawing.Size(391, 55);
            roundedPanel4.TabIndex = 6;
            // 
            // dt_date
            // 
            dt_date.BorderColor = System.Drawing.Color.FromArgb(154, 59, 59);
            dt_date.BorderSize = 3;
            dt_date.CalendarFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dt_date.CustomFormat = "dddd , dd MMMM yyyy";
            dt_date.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dt_date.Location = new System.Drawing.Point(16, 2);
            dt_date.MinimumSize = new System.Drawing.Size(4, 50);
            dt_date.Name = "dt_date";
            dt_date.Size = new System.Drawing.Size(366, 50);
            dt_date.SkinColor = System.Drawing.Color.FromArgb(154, 59, 59);
            dt_date.TabIndex = 1;
            dt_date.TextColor = System.Drawing.Color.White;
            dt_date.ValueChanged += dt_date_ValueChanged;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(roundedPanel2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new System.Drawing.Point(0, 65);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(15, 3, 15, 15);
            panel4.Size = new System.Drawing.Size(1194, 747);
            panel4.TabIndex = 17;
            // 
            // panel5
            // 
            panel5.Controls.Add(roundedPanel3);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new System.Drawing.Point(15, 59);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 10, 0, 10);
            panel5.Size = new System.Drawing.Size(1164, 673);
            panel5.TabIndex = 6;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            roundedPanel3.Controls.Add(dgOrders);
            roundedPanel3.Dock = DockStyle.Fill;
            roundedPanel3.ForeColor = System.Drawing.Color.White;
            roundedPanel3.Location = new System.Drawing.Point(0, 10);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new System.Drawing.Size(1164, 653);
            roundedPanel3.TabIndex = 0;
            // 
            // dgOrders
            // 
            dgOrders.AllowUserToAddRows = false;
            dgOrders.BackgroundColor = System.Drawing.Color.FromArgb(249, 245, 220);
            dgOrders.BorderStyle = BorderStyle.None;
            dgOrders.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgOrders.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgOrders.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle37.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle37.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle37.NullValue = "dasd";
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle37.WrapMode = DataGridViewTriState.True;
            dgOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            dgOrders.ColumnHeadersHeight = 58;
            dgOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgOrders.Columns.AddRange(new DataGridViewColumn[] { stt, maBienBhna, orderDate, total, deposit, note });
            dataGridViewCellStyle43.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle43.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle43.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle43.WrapMode = DataGridViewTriState.False;
            dgOrders.DefaultCellStyle = dataGridViewCellStyle43;
            dgOrders.Dock = DockStyle.Fill;
            dgOrders.EnableHeadersVisualStyles = false;
            dgOrders.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
            dgOrders.Location = new System.Drawing.Point(0, 0);
            dgOrders.Margin = new Padding(0);
            dgOrders.MultiSelect = false;
            dgOrders.Name = "dgOrders";
            dgOrders.ReadOnly = true;
            dgOrders.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle44.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle44.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle44.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle44.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle44.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle44.WrapMode = DataGridViewTriState.True;
            dgOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle44;
            dgOrders.RowHeadersVisible = false;
            dgOrders.RowHeadersWidth = 51;
            dataGridViewCellStyle45.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle45.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle45.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.Color.FromArgb(226, 199, 153);
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.Color.Black;
            dgOrders.RowsDefaultCellStyle = dataGridViewCellStyle45;
            dgOrders.RowTemplate.Height = 50;
            dgOrders.ScrollBars = ScrollBars.None;
            dgOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgOrders.Size = new System.Drawing.Size(1164, 653);
            dgOrders.TabIndex = 3;
            dgOrders.CellContentClick += dgOrders_CellContentClick;
            // 
            // stt
            // 
            dataGridViewCellStyle38.Alignment = DataGridViewContentAlignment.MiddleCenter;
            stt.DefaultCellStyle = dataGridViewCellStyle38;
            stt.HeaderText = "STT";
            stt.Name = "stt";
            stt.ReadOnly = true;
            // 
            // maBienBhna
            // 
            dataGridViewCellStyle39.Alignment = DataGridViewContentAlignment.MiddleCenter;
            maBienBhna.DefaultCellStyle = dataGridViewCellStyle39;
            maBienBhna.HeaderText = "Mã Biên Nhận";
            maBienBhna.Name = "maBienBhna";
            maBienBhna.ReadOnly = true;
            maBienBhna.Width = 150;
            // 
            // orderDate
            // 
            dataGridViewCellStyle40.Alignment = DataGridViewContentAlignment.MiddleLeft;
            orderDate.DefaultCellStyle = dataGridViewCellStyle40;
            orderDate.HeaderText = "Ngày Đặt";
            orderDate.Name = "orderDate";
            orderDate.ReadOnly = true;
            orderDate.Width = 250;
            // 
            // total
            // 
            dataGridViewCellStyle41.Alignment = DataGridViewContentAlignment.MiddleCenter;
            total.DefaultCellStyle = dataGridViewCellStyle41;
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
            dataGridViewCellStyle42.Alignment = DataGridViewContentAlignment.MiddleCenter;
            note.DefaultCellStyle = dataGridViewCellStyle42;
            note.HeaderText = "Ghi Chú";
            note.Name = "note";
            note.ReadOnly = true;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = System.Drawing.Color.FromArgb(249, 245, 220);
            roundedPanel2.Controls.Add(label6);
            roundedPanel2.Dock = DockStyle.Top;
            roundedPanel2.ForeColor = System.Drawing.Color.Black;
            roundedPanel2.Location = new System.Drawing.Point(15, 3);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new System.Drawing.Size(1164, 56);
            roundedPanel2.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(5, 15);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(104, 22);
            label6.TabIndex = 0;
            label6.Text = "Biên nhận";
            // 
            // OrderDH
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1595, 812);
            Controls.Add(panel4);
            Controls.Add(roundedPanel1);
            Controls.Add(panel3);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderDH";
            Text = "OrderDH";
            WindowState = FormWindowState.Maximized;
            Activated += OrderDH_Activated;
            Load += OrderDH_Load;
            roundedPanel6.ResumeLayout(false);
            roundedPanel6.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgOrderDetail).EndInit();
            panel6.ResumeLayout(false);
            parrotGroupBox2.ResumeLayout(false);
            parrotGroupBox2.PerformLayout();
            parrotGroupBox1.ResumeLayout(false);
            parrotGroupBox1.PerformLayout();
            roundedPanel5.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
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
            ResumeLayout(false);
        }

        #endregion

        private RoundedButton btnSave;
        private Label label2;
        private RoundedPanel roundedPanel6;
        private ReaLTaiizor.Controls.MetroDivider metroDivider1;
        private Panel panel1;
        private RoundedPanel roundedPanel5;
        private RoundedPanel roundedPanel1;
        private Panel panel3;
        private Label label1;
        private Panel panel2;
        private RoundedPanel roundedPanel4;
        private DatetimePickerCustom dt_date;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        private ReaLTaiizor.Controls.CyberRadioButton rb_not_done;
        private ReaLTaiizor.Controls.CyberRadioButton rb_done;
        private Panel panel6;
        private ReaLTaiizor.Controls.MetroDivider metroDivider2;
        private Panel panel4;
        private Panel panel5;
        private RoundedPanel roundedPanel3;
        private DataGridView dgOrders;
        private RoundedPanel roundedPanel2;
        private Label label6;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox2;
        private ReaLTaiizor.Controls.CyberRadioButton rb_not_delivery;
        private ReaLTaiizor.Controls.CyberRadioButton rb_delivery;
        private DataGridView dgOrderDetail;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn maBienBhna;
        private DataGridViewTextBoxColumn orderDate;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn deposit;
        private DataGridViewTextBoxColumn note;
        private DataGridViewTextBoxColumn order_name;
        private DataGridViewTextBoxColumn order_quantity;
        private DataGridViewTextBoxColumn order_total;
        private DataGridViewTextBoxColumn oderDetail_Id;
    }
}