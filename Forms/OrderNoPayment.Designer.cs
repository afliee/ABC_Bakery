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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            panel2 = new Panel();
            roundedPanel4 = new Helpers.UI.RoundedPanel();
            pictureBox1 = new PictureBox();
            datetimePickerCustom1 = new Helpers.UI.DatetimePickerCustom();
            label1 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            roundedPanel3 = new Helpers.UI.RoundedPanel();
            dataGridView3 = new DataGridView();
            stt = new DataGridViewTextBoxColumn();
            maBienBhna = new DataGridViewTextBoxColumn();
            orderDate = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            note = new DataGridViewTextBoxColumn();
            mail = new DataGridViewTextBoxColumn();
            roundedPanel2 = new Helpers.UI.RoundedPanel();
            label6 = new Label();
            roundedPanel1 = new Helpers.UI.RoundedPanel();
            roundedPanel5 = new Helpers.UI.RoundedPanel();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            order_name = new DataGridViewTextBoxColumn();
            order_quantity = new DataGridViewTextBoxColumn();
            order_total = new DataGridViewTextBoxColumn();
            roundedPanel7 = new Helpers.UI.RoundedPanel();
            parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            cyberRadioButton2 = new ReaLTaiizor.Controls.CyberRadioButton();
            cyberRadioButton1 = new ReaLTaiizor.Controls.CyberRadioButton();
            metroDivider2 = new ReaLTaiizor.Controls.MetroDivider();
            roundedPanel6 = new Helpers.UI.RoundedPanel();
            label2 = new Label();
            metroDivider1 = new ReaLTaiizor.Controls.MetroDivider();
            roundedButton1 = new Helpers.UI.RoundedButton();
            panel2.SuspendLayout();
            roundedPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            roundedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            roundedPanel2.SuspendLayout();
            roundedPanel1.SuspendLayout();
            roundedPanel5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            roundedPanel7.SuspendLayout();
            parrotGroupBox1.SuspendLayout();
            roundedPanel6.SuspendLayout();
            SuspendLayout();
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
            label1.Size = new Size(304, 33);
            label1.TabIndex = 9;
            label1.Text = "Biên nhận chưa thanh toán";
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
            panel5.TabIndex = 6;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.FromArgb(0, 0, 0, 0);
            roundedPanel3.Controls.Add(dataGridView3);
            roundedPanel3.Dock = DockStyle.Fill;
            roundedPanel3.ForeColor = Color.White;
            roundedPanel3.Location = new Point(0, 10);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(1026, 672);
            roundedPanel3.TabIndex = 0;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView3.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.NullValue = "dasd";
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView3.ColumnHeadersHeight = 58;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { stt, maBienBhna, orderDate, total, note, mail });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.RosyBrown;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView3.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.GridColor = Color.FromArgb(224, 224, 224);
            dataGridView3.Location = new Point(0, 0);
            dataGridView3.Margin = new Padding(0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(255, 224, 192);
            dataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.ScrollBars = ScrollBars.None;
            dataGridView3.Size = new Size(1026, 672);
            dataGridView3.TabIndex = 3;
            // 
            // stt
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            stt.DefaultCellStyle = dataGridViewCellStyle2;
            stt.HeaderText = "STT";
            stt.Name = "stt";
            stt.ReadOnly = true;
            // 
            // maBienBhna
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            maBienBhna.DefaultCellStyle = dataGridViewCellStyle3;
            maBienBhna.HeaderText = "Mã Biên Nhận";
            maBienBhna.Name = "maBienBhna";
            maBienBhna.ReadOnly = true;
            maBienBhna.Width = 200;
            // 
            // orderDate
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopCenter;
            orderDate.DefaultCellStyle = dataGridViewCellStyle4;
            orderDate.HeaderText = "Ngày Đặt";
            orderDate.Name = "orderDate";
            orderDate.ReadOnly = true;
            orderDate.Width = 200;
            // 
            // total
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.TopCenter;
            total.DefaultCellStyle = dataGridViewCellStyle5;
            total.HeaderText = "Tổng Tiền";
            total.Name = "total";
            total.ReadOnly = true;
            total.Width = 200;
            // 
            // note
            // 
            note.HeaderText = "Ghi Chú";
            note.Name = "note";
            note.ReadOnly = true;
            note.Width = 200;
            // 
            // mail
            // 
            mail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            mail.HeaderText = "";
            mail.Name = "mail";
            mail.ReadOnly = true;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.FromArgb(255, 224, 192);
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
            roundedPanel5.BackColor = Color.FromArgb(255, 224, 192);
            roundedPanel5.Controls.Add(panel1);
            roundedPanel5.Controls.Add(roundedPanel7);
            roundedPanel5.Controls.Add(roundedPanel6);
            roundedPanel5.Controls.Add(roundedButton1);
            roundedPanel5.Dock = DockStyle.Fill;
            roundedPanel5.ForeColor = Color.White;
            roundedPanel5.Location = new Point(5, 3);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Padding = new Padding(3);
            roundedPanel5.Size = new Size(391, 738);
            roundedPanel5.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 503);
            panel1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle9.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.Padding = new Padding(0, 10, 0, 0);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { order_name, order_quantity, order_total });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(224, 224, 224);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(385, 503);
            dataGridView1.TabIndex = 5;
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
            // roundedPanel7
            // 
            roundedPanel7.BackColor = Color.FromArgb(0, 0, 0, 0);
            roundedPanel7.Controls.Add(parrotGroupBox1);
            roundedPanel7.Controls.Add(metroDivider2);
            roundedPanel7.Dock = DockStyle.Bottom;
            roundedPanel7.ForeColor = Color.White;
            roundedPanel7.Location = new Point(3, 571);
            roundedPanel7.Name = "roundedPanel7";
            roundedPanel7.Size = new Size(385, 110);
            roundedPanel7.TabIndex = 7;
            // 
            // parrotGroupBox1
            // 
            parrotGroupBox1.BorderColor = Color.FromArgb(0, 0, 0, 0);
            parrotGroupBox1.BorderWidth = 0;
            parrotGroupBox1.Controls.Add(cyberRadioButton2);
            parrotGroupBox1.Controls.Add(cyberRadioButton1);
            parrotGroupBox1.Dock = DockStyle.Fill;
            parrotGroupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            parrotGroupBox1.Location = new Point(0, 0);
            parrotGroupBox1.Name = "parrotGroupBox1";
            parrotGroupBox1.ShowText = true;
            parrotGroupBox1.Size = new Size(385, 110);
            parrotGroupBox1.TabIndex = 1;
            parrotGroupBox1.TabStop = false;
            parrotGroupBox1.Text = "Thanh toán";
            parrotGroupBox1.TextColor = Color.Black;
            // 
            // cyberRadioButton2
            // 
            cyberRadioButton2.BackColor = Color.Transparent;
            cyberRadioButton2.Background = true;
            cyberRadioButton2.Background_WidthPen = 2F;
            cyberRadioButton2.BackgroundPen = true;
            cyberRadioButton2.Checked = false;
            cyberRadioButton2.Color_1_Background_value = Color.Empty;
            cyberRadioButton2.Color_2_Background_value = Color.Empty;
            cyberRadioButton2.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberRadioButton2.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberRadioButton2.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberRadioButton2.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberRadioButton2.ColorChecked = Color.FromArgb(154, 59, 59);
            cyberRadioButton2.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberRadioButton2.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberRadioButton2.CyberRadioButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberRadioButton2.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberRadioButton2.Effect_1_Transparency = 25;
            cyberRadioButton2.Effect_2 = true;
            cyberRadioButton2.Effect_2_ColorBackground = Color.White;
            cyberRadioButton2.Effect_2_Transparency = 15;
            cyberRadioButton2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cyberRadioButton2.ForeColor = Color.Black;
            cyberRadioButton2.LinearGradient_Background = false;
            cyberRadioButton2.LinearGradient_Value = false;
            cyberRadioButton2.LinearGradientPen = false;
            cyberRadioButton2.Location = new Point(199, 32);
            cyberRadioButton2.Name = "cyberRadioButton2";
            cyberRadioButton2.RGB = false;
            cyberRadioButton2.Rounding = true;
            cyberRadioButton2.RoundingInt = 100;
            cyberRadioButton2.Size = new Size(180, 45);
            cyberRadioButton2.SizeChecked = 8;
            cyberRadioButton2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberRadioButton2.TabIndex = 1;
            cyberRadioButton2.Tag = "Cyber";
            cyberRadioButton2.TextButton = "Chưa hoàn thành";
            cyberRadioButton2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberRadioButton2.Timer_Effect_1 = 1;
            cyberRadioButton2.Timer_RGB = 300;
            // 
            // cyberRadioButton1
            // 
            cyberRadioButton1.BackColor = Color.Transparent;
            cyberRadioButton1.Background = true;
            cyberRadioButton1.Background_WidthPen = 2F;
            cyberRadioButton1.BackgroundPen = true;
            cyberRadioButton1.Checked = false;
            cyberRadioButton1.Color_1_Background_value = Color.Empty;
            cyberRadioButton1.Color_2_Background_value = Color.Empty;
            cyberRadioButton1.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberRadioButton1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberRadioButton1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberRadioButton1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberRadioButton1.ColorChecked = Color.FromArgb(154, 59, 59);
            cyberRadioButton1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberRadioButton1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberRadioButton1.CyberRadioButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberRadioButton1.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberRadioButton1.Effect_1_Transparency = 25;
            cyberRadioButton1.Effect_2 = true;
            cyberRadioButton1.Effect_2_ColorBackground = Color.Black;
            cyberRadioButton1.Effect_2_Transparency = 15;
            cyberRadioButton1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cyberRadioButton1.ForeColor = Color.Black;
            cyberRadioButton1.LinearGradient_Background = false;
            cyberRadioButton1.LinearGradient_Value = false;
            cyberRadioButton1.LinearGradientPen = false;
            cyberRadioButton1.Location = new Point(13, 32);
            cyberRadioButton1.Name = "cyberRadioButton1";
            cyberRadioButton1.RGB = false;
            cyberRadioButton1.Rounding = true;
            cyberRadioButton1.RoundingInt = 100;
            cyberRadioButton1.Size = new Size(180, 45);
            cyberRadioButton1.SizeChecked = 8;
            cyberRadioButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberRadioButton1.TabIndex = 1;
            cyberRadioButton1.Tag = "Cyber";
            cyberRadioButton1.TextButton = "Hoàn thành";
            cyberRadioButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberRadioButton1.Timer_Effect_1 = 1;
            cyberRadioButton1.Timer_RGB = 300;
            // 
            // metroDivider2
            // 
            metroDivider2.IsDerivedStyle = true;
            metroDivider2.Location = new Point(3, 10);
            metroDivider2.Name = "metroDivider2";
            metroDivider2.Orientation = ReaLTaiizor.Enum.Metro.DividerStyle.Horizontal;
            metroDivider2.Size = new Size(379, 4);
            metroDivider2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroDivider2.StyleManager = null;
            metroDivider2.TabIndex = 0;
            metroDivider2.Text = "metroDivider2";
            metroDivider2.ThemeAuthor = "Taiizor";
            metroDivider2.ThemeName = "MetroLight";
            metroDivider2.Thickness = 1;
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
            roundedButton1.Location = new Point(3, 681);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(385, 54);
            roundedButton1.TabIndex = 5;
            roundedButton1.Text = "Lưu biên nhận";
            roundedButton1.UseVisualStyleBackColor = false;
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
            panel2.ResumeLayout(false);
            roundedPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            roundedPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            roundedPanel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            roundedPanel7.ResumeLayout(false);
            parrotGroupBox1.ResumeLayout(false);
            parrotGroupBox1.PerformLayout();
            roundedPanel6.ResumeLayout(false);
            roundedPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Helpers.UI.RoundedPanel roundedPanel4;
        private Panel panel3;
        private Helpers.UI.DatetimePickerCustom datetimePickerCustom1;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Panel panel5;
        private Helpers.UI.RoundedPanel roundedPanel3;
        private DataGridView dataGridView3;
        private Helpers.UI.RoundedPanel roundedPanel2;
        private Label label6;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn maBienBhna;
        private DataGridViewTextBoxColumn orderDate;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn note;
        private DataGridViewTextBoxColumn mail;
        private Helpers.UI.RoundedPanel roundedPanel1;
        private Helpers.UI.RoundedPanel roundedPanel5;
        private Label label2;
        private ReaLTaiizor.Controls.MetroDivider metroDivider1;
        private Helpers.UI.RoundedPanel roundedPanel6;
        private Helpers.UI.RoundedButton roundedButton1;
        private Helpers.UI.RoundedPanel roundedPanel7;
        private ReaLTaiizor.Controls.MetroDivider metroDivider2;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn order_name;
        private DataGridViewTextBoxColumn order_quantity;
        private DataGridViewTextBoxColumn order_total;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        private ReaLTaiizor.Controls.CyberRadioButton cyberRadioButton2;
        private ReaLTaiizor.Controls.CyberRadioButton cyberRadioButton1;
    }
}