﻿using Color = System.Drawing.Color;
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            panel2 = new Panel();
            roundedPanel4 = new Helpers.UI.RoundedPanel();
            pictureBox1 = new PictureBox();
            datetimePickerCustom1 = new Helpers.UI.DatetimePickerCustom();
            label1 = new Label();
            panel3 = new Panel();
            roundedPanel1 = new Helpers.UI.RoundedPanel();
            roundedPanel7 = new Helpers.UI.RoundedPanel();
            roundedPanel8 = new Helpers.UI.RoundedPanel();
            dataGridView1 = new DataGridView();
            ten = new DataGridViewTextBoxColumn();
            SL = new DataGridViewTextBoxColumn();
            Thanhtien = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel8 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label11 = new Label();
            roundedPanel6 = new Helpers.UI.RoundedPanel();
            roundedPanel9 = new Helpers.UI.RoundedPanel();
            btnSaveOrderNoPayment = new RJCodeAdvance.RJControls.RJButton();
            roundedPanel5 = new Helpers.UI.RoundedPanel();
            label3 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            roundedPanel3 = new Helpers.UI.RoundedPanel();
            dataGridView3 = new DataGridView();
            roundedPanel2 = new Helpers.UI.RoundedPanel();
            label6 = new Label();
            stt = new DataGridViewTextBoxColumn();
            maBienBhna = new DataGridViewTextBoxColumn();
            orderDate = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            note = new DataGridViewTextBoxColumn();
            mail = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            roundedPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            roundedPanel1.SuspendLayout();
            roundedPanel7.SuspendLayout();
            roundedPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            roundedPanel6.SuspendLayout();
            roundedPanel9.SuspendLayout();
            roundedPanel5.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            roundedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            roundedPanel2.SuspendLayout();
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
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(0, 0, 0, 0);
            roundedPanel1.Controls.Add(roundedPanel7);
            roundedPanel1.Controls.Add(panel1);
            roundedPanel1.Controls.Add(roundedPanel6);
            roundedPanel1.Controls.Add(roundedPanel5);
            roundedPanel1.Dock = DockStyle.Right;
            roundedPanel1.ForeColor = Color.White;
            roundedPanel1.Location = new Point(1056, 65);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Padding = new Padding(5, 5, 5, 15);
            roundedPanel1.Size = new Size(401, 766);
            roundedPanel1.TabIndex = 13;
            // 
            // roundedPanel7
            // 
            roundedPanel7.BackColor = Color.FromArgb(0, 0, 0, 0);
            roundedPanel7.Controls.Add(roundedPanel8);
            roundedPanel7.Dock = DockStyle.Fill;
            roundedPanel7.ForeColor = Color.White;
            roundedPanel7.Location = new Point(5, 61);
            roundedPanel7.Name = "roundedPanel7";
            roundedPanel7.Padding = new Padding(0, 10, 0, 10);
            roundedPanel7.Size = new Size(391, 487);
            roundedPanel7.TabIndex = 11;
            // 
            // roundedPanel8
            // 
            roundedPanel8.BackColor = Color.FromArgb(255, 224, 192);
            roundedPanel8.Controls.Add(dataGridView1);
            roundedPanel8.Dock = DockStyle.Fill;
            roundedPanel8.ForeColor = Color.White;
            roundedPanel8.Location = new Point(0, 10);
            roundedPanel8.Name = "roundedPanel8";
            roundedPanel8.Size = new Size(391, 467);
            roundedPanel8.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ten, SL, Thanhtien });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle3.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 224, 192);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(391, 467);
            dataGridView1.TabIndex = 1;
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
            SL.Width = 57;
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
            // panel1
            // 
            panel1.Controls.Add(panel8);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(5, 548);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 113);
            panel1.TabIndex = 10;
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(radioButton2);
            panel8.Controls.Add(radioButton1);
            panel8.Controls.Add(label11);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(0, 0, 0, 20);
            panel8.Size = new Size(391, 113);
            panel8.TabIndex = 5;
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
            // roundedPanel6
            // 
            roundedPanel6.BackColor = Color.FromArgb(0, 0, 0, 0);
            roundedPanel6.Controls.Add(roundedPanel9);
            roundedPanel6.Dock = DockStyle.Bottom;
            roundedPanel6.ForeColor = Color.White;
            roundedPanel6.Location = new Point(5, 661);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Padding = new Padding(0, 10, 0, 10);
            roundedPanel6.Size = new Size(391, 90);
            roundedPanel6.TabIndex = 9;
            // 
            // roundedPanel9
            // 
            roundedPanel9.BackColor = Color.FromArgb(0, 0, 0, 0);
            roundedPanel9.Controls.Add(btnSaveOrderNoPayment);
            roundedPanel9.Dock = DockStyle.Fill;
            roundedPanel9.ForeColor = Color.White;
            roundedPanel9.Location = new Point(0, 10);
            roundedPanel9.Name = "roundedPanel9";
            roundedPanel9.Size = new Size(391, 70);
            roundedPanel9.TabIndex = 0;
            // 
            // btnSaveOrderNoPayment
            // 
            btnSaveOrderNoPayment.BackColor = Color.FromArgb(154, 59, 59);
            btnSaveOrderNoPayment.BackgroundColor = Color.FromArgb(154, 59, 59);
            btnSaveOrderNoPayment.BorderColor = Color.PaleVioletRed;
            btnSaveOrderNoPayment.BorderRadius = 0;
            btnSaveOrderNoPayment.BorderSize = 0;
            btnSaveOrderNoPayment.Dock = DockStyle.Fill;
            btnSaveOrderNoPayment.FlatAppearance.BorderSize = 0;
            btnSaveOrderNoPayment.FlatStyle = FlatStyle.Flat;
            btnSaveOrderNoPayment.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveOrderNoPayment.ForeColor = Color.White;
            btnSaveOrderNoPayment.Location = new Point(0, 0);
            btnSaveOrderNoPayment.Name = "btnSaveOrderNoPayment";
            btnSaveOrderNoPayment.Size = new Size(391, 70);
            btnSaveOrderNoPayment.TabIndex = 0;
            btnSaveOrderNoPayment.Text = "Lưu Biên Nhận";
            btnSaveOrderNoPayment.TextColor = Color.White;
            btnSaveOrderNoPayment.UseVisualStyleBackColor = false;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.FromArgb(255, 224, 192);
            roundedPanel5.Controls.Add(label3);
            roundedPanel5.Dock = DockStyle.Top;
            roundedPanel5.ForeColor = Color.White;
            roundedPanel5.Location = new Point(5, 5);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(391, 56);
            roundedPanel5.TabIndex = 8;
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
            dataGridView3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView3.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView3.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.NullValue = "dasd";
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView3.ColumnHeadersHeight = 58;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { stt, maBienBhna, orderDate, total, note, mail });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.RosyBrown;
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dataGridView3.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.GridColor = Color.FromArgb(224, 224, 224);
            dataGridView3.Location = new Point(-3, -6);
            dataGridView3.Margin = new Padding(0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(255, 224, 192);
            dataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.ScrollBars = ScrollBars.None;
            dataGridView3.Size = new Size(1822, 1145);
            dataGridView3.TabIndex = 3;
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
            // stt
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.TopCenter;
            stt.DefaultCellStyle = dataGridViewCellStyle6;
            stt.HeaderText = "STT";
            stt.Name = "stt";
            stt.ReadOnly = true;
            // 
            // maBienBhna
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.TopCenter;
            maBienBhna.DefaultCellStyle = dataGridViewCellStyle7;
            maBienBhna.HeaderText = "Mã Biên Nhận";
            maBienBhna.Name = "maBienBhna";
            maBienBhna.ReadOnly = true;
            maBienBhna.Width = 200;
            // 
            // orderDate
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.TopCenter;
            orderDate.DefaultCellStyle = dataGridViewCellStyle8;
            orderDate.HeaderText = "Ngày Đặt";
            orderDate.Name = "orderDate";
            orderDate.ReadOnly = true;
            orderDate.Width = 200;
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
            WindowState = FormWindowState.Maximized;
            Load += OrderNoPayment_Load;
            panel2.ResumeLayout(false);
            roundedPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            roundedPanel7.ResumeLayout(false);
            roundedPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            roundedPanel6.ResumeLayout(false);
            roundedPanel9.ResumeLayout(false);
            roundedPanel5.ResumeLayout(false);
            roundedPanel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            roundedPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Helpers.UI.RoundedPanel roundedPanel4;
        private Panel panel3;
        private Helpers.UI.DatetimePickerCustom datetimePickerCustom1;
        private PictureBox pictureBox1;
        private Helpers.UI.RoundedPanel roundedPanel1;
        private Helpers.UI.RoundedPanel roundedPanel5;
        private Label label3;
        private Helpers.UI.RoundedPanel roundedPanel6;
        private Panel panel4;
        private Panel panel5;
        private Helpers.UI.RoundedPanel roundedPanel3;
        private DataGridView dataGridView3;
        private Helpers.UI.RoundedPanel roundedPanel2;
        private Label label6;
        private Helpers.UI.RoundedPanel roundedPanel7;
        private Panel panel1;
        private Panel panel8;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label11;
        private Helpers.UI.RoundedPanel roundedPanel8;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ten;
        private DataGridViewTextBoxColumn SL;
        private DataGridViewTextBoxColumn Thanhtien;
        private Helpers.UI.RoundedPanel roundedPanel9;
        private RJCodeAdvance.RJControls.RJButton btnSaveOrderNoPayment;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn maBienBhna;
        private DataGridViewTextBoxColumn orderDate;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn note;
        private DataGridViewTextBoxColumn mail;
    }
}