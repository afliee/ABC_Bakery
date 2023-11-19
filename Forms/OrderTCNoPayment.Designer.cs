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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderTCNoPayment));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            datetimePickerCustom1 = new Helpers.UI.DatetimePickerCustom();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            panel3 = new Panel();
            roundedButton1 = new Helpers.UI.RoundedButton();
            roundedPanel2 = new Helpers.UI.RoundedPanel();
            label6 = new Label();
            dataGridView3 = new DataGridView();
            stt = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            ten = new DataGridViewTextBoxColumn();
            SL = new DataGridViewTextBoxColumn();
            Thanhtien = new DataGridViewTextBoxColumn();
            flowLayoutPanel1 = new FlowLayoutPanel();
            roundedPanel1 = new Helpers.UI.RoundedPanel();
            label3 = new Label();
            panel6 = new Panel();
            label10 = new Label();
            label9 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel8 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label11 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            roundedPanel1.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(1434, 70);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 43);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 2;
            label2.Text = "No. 0001";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 10);
            label1.Margin = new Padding(15);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(405, 33);
            label1.TabIndex = 2;
            label1.Text = "Biên nhận thế chân chưa thanh toán";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(154, 59, 59);
            panel2.Controls.Add(datetimePickerCustom1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1031, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(393, 50);
            panel2.TabIndex = 1;
            // 
            // datetimePickerCustom1
            // 
            datetimePickerCustom1.BorderColor = Color.FromArgb(154, 59, 59);
            datetimePickerCustom1.BorderSize = 0;
            datetimePickerCustom1.CustomFormat = "dd/MM/yyyy";
            datetimePickerCustom1.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            datetimePickerCustom1.Location = new Point(262, 7);
            datetimePickerCustom1.MinimumSize = new Size(0, 35);
            datetimePickerCustom1.Name = "datetimePickerCustom1";
            datetimePickerCustom1.Size = new Size(120, 35);
            datetimePickerCustom1.SkinColor = Color.FromArgb(226, 199, 153);
            datetimePickerCustom1.TabIndex = 2;
            datetimePickerCustom1.TextColor = Color.White;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(roundedPanel2);
            panel4.Controls.Add(dataGridView3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 70);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(15, 3, 15, 15);
            panel4.Size = new Size(1026, 732);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(roundedButton1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(15, 640);
            panel3.Name = "panel3";
            panel3.Size = new Size(996, 77);
            panel3.TabIndex = 5;
            // 
            // roundedButton1
            // 
            roundedButton1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            roundedButton1.BackColor = Color.FromArgb(154, 59, 59);
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(-2, 11);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(1001, 63);
            roundedButton1.TabIndex = 0;
            roundedButton1.Text = "LƯU THÔNG TIN BIÊN NHẬN";
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.FromArgb(255, 224, 192);
            roundedPanel2.Controls.Add(label6);
            roundedPanel2.Dock = DockStyle.Top;
            roundedPanel2.ForeColor = Color.Black;
            roundedPanel2.Location = new Point(15, 3);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(996, 56);
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
            // dataGridView3
            // 
            dataGridView3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView3.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridView3.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.NullValue = "dasd";
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView3.ColumnHeadersHeight = 54;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { stt, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle3.SelectionBackColor = Color.RosyBrown;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView3.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.GridColor = Color.FromArgb(224, 224, 224);
            dataGridView3.Location = new Point(15, 67);
            dataGridView3.Margin = new Padding(0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 224, 192);
            dataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.ScrollBars = ScrollBars.None;
            dataGridView3.Size = new Size(996, 573);
            dataGridView3.TabIndex = 2;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // stt
            // 
            stt.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.BackColor = Color.Red;
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            stt.DefaultCellStyle = dataGridViewCellStyle2;
            stt.Frozen = true;
            stt.HeaderText = "STT";
            stt.MinimumWidth = 6;
            stt.Name = "stt";
            stt.Resizable = DataGridViewTriState.True;
            stt.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn2.FillWeight = 273.6842F;
            dataGridViewTextBoxColumn2.HeaderText = "Mã Biên Nhận";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 170;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.FillWeight = 42.1052666F;
            dataGridViewTextBoxColumn3.HeaderText = "Ngày đặt";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.FillWeight = 42.1052666F;
            dataGridViewTextBoxColumn4.HeaderText = "Tổng tiền";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.FillWeight = 42.1052666F;
            dataGridViewTextBoxColumn5.HeaderText = "Ghi chú";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle6.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.ColumnHeadersHeight = 54;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ten, SL, Thanhtien });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle7.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(5, 67);
            dataGridView1.Margin = new Padding(5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle8.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(255, 224, 192);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(398, 268);
            dataGridView1.TabIndex = 0;
            // 
            // ten
            // 
            ten.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ten.Frozen = true;
            ten.HeaderText = "Tên";
            ten.MinimumWidth = 6;
            ten.Name = "ten";
            ten.ReadOnly = true;
            ten.Width = 196;
            // 
            // SL
            // 
            SL.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            SL.Frozen = true;
            SL.HeaderText = "SL";
            SL.MinimumWidth = 6;
            SL.Name = "SL";
            SL.ReadOnly = true;
            SL.Width = 56;
            // 
            // Thanhtien
            // 
            Thanhtien.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Thanhtien.Frozen = true;
            Thanhtien.HeaderText = "Thành tiền";
            Thanhtien.MinimumWidth = 6;
            Thanhtien.Name = "Thanhtien";
            Thanhtien.ReadOnly = true;
            Thanhtien.Width = 202;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(0, 0, 0, 0);
            flowLayoutPanel1.Controls.Add(roundedPanel1);
            flowLayoutPanel1.Controls.Add(dataGridView1);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(panel8);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            flowLayoutPanel1.Location = new Point(1026, 70);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(408, 732);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(255, 224, 192);
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.ForeColor = Color.White;
            roundedPanel1.Location = new Point(3, 3);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(400, 56);
            roundedPanel1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(6, 17);
            label3.Name = "label3";
            label3.Size = new Size(157, 22);
            label3.TabIndex = 0;
            label3.Text = "Chi tiết hóa đơn";
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(label10);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(3, 342);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(406, 72);
            panel6.TabIndex = 3;
            // 
            // label10
            // 
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(233, 39);
            label10.Name = "label10";
            label10.Size = new Size(149, 19);
            label10.TabIndex = 3;
            label10.Text = "15990000009";
            label10.TextAlign = ContentAlignment.MiddleRight;
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(242, 13);
            label9.Name = "label9";
            label9.Size = new Size(140, 19);
            label9.TabIndex = 2;
            label9.Text = "100000";
            label9.TextAlign = ContentAlignment.MiddleRight;
            label9.Click += label9_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(4, 38);
            label5.Name = "label5";
            label5.Size = new Size(112, 22);
            label5.TabIndex = 1;
            label5.Text = "Tiền phải trả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(4, 12);
            label4.Name = "label4";
            label4.Size = new Size(82, 22);
            label4.TabIndex = 0;
            label4.Text = "Tiền cọc";
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(radioButton2);
            panel8.Controls.Add(radioButton1);
            panel8.Controls.Add(label11);
            panel8.Location = new Point(3, 418);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(405, 56);
            panel8.TabIndex = 4;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(195, 29);
            radioButton2.Margin = new Padding(3, 2, 3, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(145, 22);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Chưa hoàn thành";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(25, 29);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(104, 22);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Hoàn thành";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(18, -2);
            label11.Name = "label11";
            label11.Size = new Size(132, 27);
            label11.TabIndex = 0;
            label11.Text = "Thanh toán";
            // 
            // OrderTCNoPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Bg;
            ClientSize = new Size(1434, 802);
            Controls.Add(panel4);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderTCNoPayment";
            Text = "OrderNoPayment";
            WindowState = FormWindowState.Maximized;
            Load += OrderTCNoPayment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Panel panel4;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ten;
        private DataGridViewTextBoxColumn SL;
        private DataGridViewTextBoxColumn Thanhtien;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel6;
        private Label label10;
        private Label label9;
        private Label label5;
        private Label label4;
        private Panel panel8;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label11;
        private Helpers.UI.RoundedPanel roundedPanel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Helpers.UI.RoundedPanel roundedPanel2;
        private Label label6;
        private Label label3;
        private Helpers.UI.DatetimePickerCustom datetimePickerCustom1;
        private Panel panel3;
        private Helpers.UI.RoundedButton roundedButton1;
    }
}