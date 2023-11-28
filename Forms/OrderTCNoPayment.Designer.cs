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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            label6 = new Label();
            mail = new DataGridViewTextBoxColumn();
            note = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            orderDate = new DataGridViewTextBoxColumn();
            maBienBhna = new DataGridViewTextBoxColumn();
            stt = new DataGridViewTextBoxColumn();
            dataGridView3 = new DataGridView();
            roundedPanel3 = new Helpers.UI.RoundedPanel();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            datetimePickerCustom1 = new Helpers.UI.DatetimePickerCustom();
            roundedPanel4 = new Helpers.UI.RoundedPanel();
            label1 = new Label();
            panel2 = new Panel();
            roundedPanel2 = new Helpers.UI.RoundedPanel();
            panel4 = new Panel();
            roundedPanel1 = new Helpers.UI.RoundedPanel();
            roundedPanel5 = new Helpers.UI.RoundedPanel();
            panel1 = new Panel();
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
            roundedButton1 = new Helpers.UI.RoundedButton();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            order_name = new DataGridViewTextBoxColumn();
            order_quantity = new DataGridViewTextBoxColumn();
            order_total = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            roundedPanel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            roundedPanel4.SuspendLayout();
            panel2.SuspendLayout();
            roundedPanel2.SuspendLayout();
            panel4.SuspendLayout();
            roundedPanel1.SuspendLayout();
            roundedPanel5.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            parrotGroupBox1.SuspendLayout();
            roundedPanel6.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // mail
            // 
            mail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            mail.HeaderText = "";
            mail.Name = "mail";
            mail.ReadOnly = true;
            // 
            // note
            // 
            note.HeaderText = "Ghi Chú";
            note.Name = "note";
            note.ReadOnly = true;
            note.Width = 200;
            // 
            // total
            // 
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.TopCenter;
            total.DefaultCellStyle = dataGridViewCellStyle9;
            total.HeaderText = "Tổng Tiền";
            total.Name = "total";
            total.ReadOnly = true;
            total.Width = 200;
            // 
            // orderDate
            // 
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.TopCenter;
            orderDate.DefaultCellStyle = dataGridViewCellStyle10;
            orderDate.HeaderText = "Ngày Đặt";
            orderDate.Name = "orderDate";
            orderDate.ReadOnly = true;
            orderDate.Width = 200;
            // 
            // maBienBhna
            // 
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.TopCenter;
            maBienBhna.DefaultCellStyle = dataGridViewCellStyle11;
            maBienBhna.HeaderText = "Mã Biên Nhận";
            maBienBhna.Name = "maBienBhna";
            maBienBhna.ReadOnly = true;
            maBienBhna.Width = 200;
            // 
            // stt
            // 
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.TopCenter;
            stt.DefaultCellStyle = dataGridViewCellStyle12;
            stt.HeaderText = "STT";
            stt.Name = "stt";
            stt.ReadOnly = true;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView3.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle13.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.White;
            dataGridViewCellStyle13.NullValue = "dasd";
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dataGridView3.ColumnHeadersHeight = 58;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { stt, maBienBhna, orderDate, total, note, mail });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = Color.White;
            dataGridViewCellStyle14.SelectionBackColor = Color.RosyBrown;
            dataGridViewCellStyle14.SelectionForeColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dataGridView3.DefaultCellStyle = dataGridViewCellStyle14;
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.GridColor = Color.FromArgb(224, 224, 224);
            dataGridView3.Location = new Point(0, 0);
            dataGridView3.Margin = new Padding(0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = Color.White;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowHeadersWidth = 51;
            dataGridViewCellStyle16.BackColor = Color.FromArgb(255, 224, 192);
            dataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle16;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.ScrollBars = ScrollBars.None;
            dataGridView3.Size = new Size(1003, 643);
            dataGridView3.TabIndex = 3;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.FromArgb(0, 0, 0, 0);
            roundedPanel3.Controls.Add(dataGridView3);
            roundedPanel3.Dock = DockStyle.Fill;
            roundedPanel3.ForeColor = Color.White;
            roundedPanel3.Location = new Point(0, 10);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(1003, 643);
            roundedPanel3.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(roundedPanel3);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(15, 59);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 10, 0, 10);
            panel5.Size = new Size(1003, 663);
            panel5.TabIndex = 6;
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
            // datetimePickerCustom1
            // 
            datetimePickerCustom1.BorderColor = Color.FromArgb(154, 59, 59);
            datetimePickerCustom1.BorderSize = 3;
            datetimePickerCustom1.CustomFormat = "dddd , dd MMMM yyyy";
            datetimePickerCustom1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            datetimePickerCustom1.Location = new Point(109, 3);
            datetimePickerCustom1.MinimumSize = new Size(4, 50);
            datetimePickerCustom1.Name = "datetimePickerCustom1";
            datetimePickerCustom1.Size = new Size(328, 50);
            datetimePickerCustom1.SkinColor = Color.FromArgb(154, 59, 59);
            datetimePickerCustom1.TabIndex = 1;
            datetimePickerCustom1.TextColor = Color.White;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.FromArgb(154, 59, 59);
            roundedPanel4.Controls.Add(pictureBox1);
            roundedPanel4.Controls.Add(datetimePickerCustom1);
            roundedPanel4.Dock = DockStyle.Fill;
            roundedPanel4.ForeColor = Color.White;
            roundedPanel4.Location = new Point(5, 5);
            roundedPanel4.Margin = new Padding(3, 15, 3, 3);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(391, 55);
            roundedPanel4.TabIndex = 6;
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
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.FromArgb(255, 224, 192);
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
            roundedPanel5.Controls.Add(roundedButton1);
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
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(parrotGroupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 584);
            panel1.TabIndex = 8;
            // 
            // panel6
            // 
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
            lb_pay.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
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
            lb_deposit.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lb_deposit.IsDerivedStyle = true;
            lb_deposit.Location = new Point(278, 8);
            lb_deposit.Name = "lb_deposit";
            lb_deposit.Size = new Size(100, 23);
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
            // 
            // roundedPanel6
            // 
            roundedPanel6.BackColor = Color.FromArgb(255, 224, 192);
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
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.FromArgb(154, 59, 59);
            roundedButton1.Dock = DockStyle.Bottom;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(3, 652);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(385, 54);
            roundedButton1.TabIndex = 5;
            roundedButton1.Text = "Lưu biên nhận";
            roundedButton1.UseVisualStyleBackColor = false;
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle17.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = Color.Black;
            dataGridViewCellStyle17.Padding = new Padding(0, 10, 0, 0);
            dataGridViewCellStyle17.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle17.SelectionForeColor = Color.Black;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { order_name, order_quantity, order_total });
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = Color.White;
            dataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle18;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(224, 224, 224);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(385, 377);
            dataGridView1.TabIndex = 6;
            // 
            // order_name
            // 
            order_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            order_name.HeaderText = "Tên";
            order_name.Name = "order_name";
            // 
            // order_quantity
            // 
            order_quantity.HeaderText = "SL";
            order_quantity.Name = "order_quantity";
            order_quantity.Width = 65;
            // 
            // order_total
            // 
            order_total.HeaderText = "Thành tiền";
            order_total.Name = "order_total";
            order_total.Width = 150;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            roundedPanel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            roundedPanel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            panel4.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            roundedPanel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            parrotGroupBox1.ResumeLayout(false);
            parrotGroupBox1.PerformLayout();
            roundedPanel6.ResumeLayout(false);
            roundedPanel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label6;
        private DataGridViewTextBoxColumn mail;
        private DataGridViewTextBoxColumn note;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn orderDate;
        private DataGridViewTextBoxColumn maBienBhna;
        private DataGridViewTextBoxColumn stt;
        private DataGridView dataGridView3;
        private Helpers.UI.RoundedPanel roundedPanel3;
        private Panel panel5;
        private PictureBox pictureBox1;
        private Helpers.UI.DatetimePickerCustom datetimePickerCustom1;
        private Helpers.UI.RoundedPanel roundedPanel4;
        private Label label1;
        private Panel panel2;
        private Helpers.UI.RoundedPanel roundedPanel2;
        private Panel panel4;
        private Helpers.UI.RoundedPanel roundedPanel1;
        private Helpers.UI.RoundedPanel roundedPanel5;
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
        private Helpers.UI.RoundedPanel roundedPanel6;
        private Label label2;
        private ReaLTaiizor.Controls.MetroDivider metroDivider1;
        private Helpers.UI.RoundedButton roundedButton1;
        private Panel panel3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn order_name;
        private DataGridViewTextBoxColumn order_quantity;
        private DataGridViewTextBoxColumn order_total;
    }
}