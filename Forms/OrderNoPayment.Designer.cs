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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderNoPayment));
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            ten = new DataGridViewTextBoxColumn();
            SL = new DataGridViewTextBoxColumn();
            Thanhtien = new DataGridViewTextBoxColumn();
            panel6 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label4 = new Label();
            panel7 = new Panel();
            panel8 = new Panel();
            label5 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            label6 = new Label();
            dataGridView3 = new DataGridView();
            stt = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1256, 54);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 28);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 2;
            label2.Text = "No. 0001";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(230, 25);
            label1.TabIndex = 2;
            label1.Text = "Biên nhận chưa thanh toán";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(154, 59, 59);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(848, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(408, 54);
            panel2.TabIndex = 1;
            // 
            // label8
            // 
            label8.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(257, 21);
            label8.Name = "label8";
            label8.Size = new Size(140, 19);
            label8.TabIndex = 2;
            label8.Text = "0002311455";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(93, 21);
            label7.Name = "label7";
            label7.Size = new Size(159, 19);
            label7.TabIndex = 1;
            label7.Text = "Lý Thất Dạ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(255, 224, 192);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(dataGridView1);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(panel7);
            flowLayoutPanel1.Controls.Add(panel8);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            flowLayoutPanel1.Location = new Point(848, 54);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(408, 564);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(408, 34);
            panel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 8);
            label3.Name = "label3";
            label3.Size = new Size(142, 22);
            label3.TabIndex = 0;
            label3.Text = "Chi tiết hóa đơn";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle9.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.ColumnHeadersHeight = 54;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ten, SL, Thanhtien });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 34);
            dataGridView1.Margin = new Padding(0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle11.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(255, 224, 192);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(408, 369);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(radioButton2);
            panel6.Controls.Add(radioButton1);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(3, 405);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(403, 56);
            panel6.TabIndex = 1;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            radioButton1.Location = new Point(25, 29);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(104, 22);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Hoàn thành";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(18, -2);
            label4.Name = "label4";
            label4.Size = new Size(132, 27);
            label4.TabIndex = 0;
            label4.Text = "Thanh toán";
            label4.Click += label4_Click;
            // 
            // panel7
            // 
            panel7.Location = new Point(3, 465);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(405, 34);
            panel7.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(255, 224, 192);
            panel8.Controls.Add(label5);
            panel8.Location = new Point(3, 503);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(368, 37);
            panel8.TabIndex = 3;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.BackColor = Color.FromArgb(154, 59, 59);
            label5.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(66, -2);
            label5.Name = "label5";
            label5.Size = new Size(287, 39);
            label5.TabIndex = 2;
            label5.Text = "LƯU BIÊN NHẬN";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 224, 192);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(dataGridView3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 54);
            panel4.Name = "panel4";
            panel4.Size = new Size(848, 564);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 224, 192);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(665, 34);
            panel5.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(10, 10);
            label6.Name = "label6";
            label6.Size = new Size(77, 18);
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
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle13.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle13.NullValue = "dasd";
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dataGridView3.ColumnHeadersHeight = 54;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { stt, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle14.SelectionBackColor = Color.RosyBrown;
            dataGridViewCellStyle14.SelectionForeColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dataGridView3.DefaultCellStyle = dataGridViewCellStyle14;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.GridColor = Color.FromArgb(224, 224, 224);
            dataGridView3.Location = new Point(0, 34);
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
            dataGridView3.Size = new Size(848, 427);
            dataGridView3.TabIndex = 2;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // stt
            // 
            stt.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            stt.Frozen = true;
            stt.HeaderText = "STT";
            stt.MinimumWidth = 6;
            stt.Name = "stt";
            stt.Resizable = DataGridViewTriState.True;
            stt.Width = 130;
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
            // OrderNoPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 618);
            Controls.Add(panel4);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderNoPayment";
            Text = "OrderNoPayment";
            WindowState = FormWindowState.Maximized;
            Load += OrderNoPayment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel8.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;
        private Panel panel4;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Panel panel5;
        private Label label6;
        private Panel panel3;
        private Label label3;
        private DataGridView dataGridView1;
        private Panel panel6;
        private Label label4;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Panel panel7;
        private Panel panel8;
        private Label label5;
        private Label label7;
        private PictureBox pictureBox1;
        private Label label8;
        private DataGridViewTextBoxColumn ten;
        private DataGridViewTextBoxColumn SL;
        private DataGridViewTextBoxColumn Thanhtien;
    }
}