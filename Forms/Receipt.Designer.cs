using Color = System.Drawing.Color;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;

namespace ABC_Bakery.Forms
{
    partial class Receipt
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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dataGridView1 = new DataGridView();
            ten = new DataGridViewTextBoxColumn();
            SL = new DataGridViewTextBoxColumn();
            Thanhtien = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel2 = new Panel();
            roundedPanel1 = new Helpers.UI.RoundedPanel();
            datetime = new Helpers.UI.DatetimePickerCustom();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            roundedPanel2 = new Helpers.UI.RoundedPanel();
            panel8 = new Panel();
            roundedPanel11 = new Helpers.UI.RoundedPanel();
            dgOrders = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            barcode = new DataGridViewImageColumn();
            name = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            delete = new DataGridViewButtonColumn();
            roundedPanel3 = new Helpers.UI.RoundedPanel();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            roundedPanel2.SuspendLayout();
            panel8.SuspendLayout();
            roundedPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgOrders).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(0, 0, 0, 0);
            flowLayoutPanel1.Controls.Add(dataGridView1);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            flowLayoutPanel1.Location = new Point(1026, 70);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(408, 732);
            flowLayoutPanel1.TabIndex = 8;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle11.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridView1.ColumnHeadersHeight = 54;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ten, SL, Thanhtien });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle12.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(5, 5);
            dataGridView1.Margin = new Padding(5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle13.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(255, 224, 192);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle14;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(398, 706);
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(1434, 70);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(roundedPanel1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1026, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(398, 50);
            panel2.TabIndex = 7;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(154, 59, 59);
            roundedPanel1.Controls.Add(datetime);
            roundedPanel1.Controls.Add(pictureBox1);
            roundedPanel1.ForeColor = Color.White;
            roundedPanel1.Location = new Point(10, -2);
            roundedPanel1.Margin = new Padding(3, 15, 3, 3);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(377, 54);
            roundedPanel1.TabIndex = 6;
            // 
            // datetime
            // 
            datetime.BorderColor = Color.FromArgb(154, 59, 59);
            datetime.BorderSize = 3;
            datetime.CustomFormat = "dddd , dd MMMM yyyy";
            datetime.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            datetime.Location = new Point(63, 4);
            datetime.MinimumSize = new Size(4, 50);
            datetime.Name = "datetime";
            datetime.Size = new Size(369, 50);
            datetime.SkinColor = Color.FromArgb(154, 59, 59);
            datetime.TabIndex = 1;
            datetime.TextColor = Color.White;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 17);
            label1.Margin = new Padding(15);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(138, 40);
            label1.TabIndex = 2;
            label1.Text = "Phiếu chi";
            label1.Click += label1_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.FromArgb(0, 0, 0, 0);
            roundedPanel2.Controls.Add(panel8);
            roundedPanel2.Controls.Add(roundedPanel3);
            roundedPanel2.Dock = DockStyle.Fill;
            roundedPanel2.ForeColor = Color.White;
            roundedPanel2.Location = new Point(0, 70);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Padding = new Padding(5);
            roundedPanel2.Size = new Size(1026, 732);
            roundedPanel2.TabIndex = 9;
            // 
            // panel8
            // 
            panel8.Controls.Add(roundedPanel11);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(5, 65);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(0, 10, 0, 10);
            panel8.Size = new Size(1016, 662);
            panel8.TabIndex = 6;
            // 
            // roundedPanel11
            // 
            roundedPanel11.BackColor = Color.FromArgb(0, 0, 0, 0);
            roundedPanel11.Controls.Add(dgOrders);
            roundedPanel11.Dock = DockStyle.Fill;
            roundedPanel11.ForeColor = Color.White;
            roundedPanel11.Location = new Point(0, 10);
            roundedPanel11.Name = "roundedPanel11";
            roundedPanel11.Size = new Size(1016, 642);
            roundedPanel11.TabIndex = 0;
            // 
            // dgOrders
            // 
            dgOrders.AllowUserToAddRows = false;
            dgOrders.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgOrders.BorderStyle = BorderStyle.None;
            dgOrders.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgOrders.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgOrders.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle15.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = Color.White;
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle15.SelectionForeColor = Color.White;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dgOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dgOrders.ColumnHeadersHeight = 55;
            dgOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgOrders.Columns.AddRange(new DataGridViewColumn[] { id, barcode, name, total, delete });
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = Color.White;
            dataGridViewCellStyle18.SelectionBackColor = Color.RosyBrown;
            dataGridViewCellStyle18.SelectionForeColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.False;
            dgOrders.DefaultCellStyle = dataGridViewCellStyle18;
            dgOrders.Dock = DockStyle.Fill;
            dgOrders.EnableHeadersVisualStyles = false;
            dgOrders.GridColor = Color.FromArgb(224, 224, 224);
            dgOrders.Location = new Point(0, 0);
            dgOrders.Margin = new Padding(0);
            dgOrders.MultiSelect = false;
            dgOrders.Name = "dgOrders";
            dgOrders.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle19.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle19.ForeColor = Color.White;
            dataGridViewCellStyle19.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            dgOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dgOrders.RowHeadersVisible = false;
            dgOrders.RowHeadersWidth = 50;
            dataGridViewCellStyle20.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle20.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle20.ForeColor = Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = Color.FromArgb(226, 199, 153);
            dataGridViewCellStyle20.SelectionForeColor = Color.Black;
            dgOrders.RowsDefaultCellStyle = dataGridViewCellStyle20;
            dgOrders.RowTemplate.Height = 50;
            dgOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgOrders.Size = new Size(1016, 642);
            dgOrders.TabIndex = 6;
            // 
            // id
            // 
            id.HeaderText = "STT";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // barcode
            // 
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.NullValue = resources.GetObject("dataGridViewCellStyle16.NullValue");
            dataGridViewCellStyle16.Padding = new Padding(5);
            barcode.DefaultCellStyle = dataGridViewCellStyle16;
            barcode.HeaderText = "Mã Phiếu";
            barcode.Name = "barcode";
            barcode.ReadOnly = true;
            barcode.Width = 150;
            // 
            // name
            // 
            name.FillWeight = 28.3298721F;
            name.HeaderText = "Ngày đặt";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.Width = 200;
            // 
            // total
            // 
            total.HeaderText = "Tổng Tiền";
            total.Name = "total";
            total.ReadOnly = true;
            total.Width = 150;
            // 
            // delete
            // 
            delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Padding = new Padding(10);
            delete.DefaultCellStyle = dataGridViewCellStyle17;
            delete.HeaderText = "Ghi chú";
            delete.Name = "delete";
            delete.Text = "Xóa";
            delete.UseColumnTextForButtonValue = true;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.FromArgb(154, 59, 59);
            roundedPanel3.Dock = DockStyle.Top;
            roundedPanel3.ForeColor = Color.White;
            roundedPanel3.Location = new Point(5, 5);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(1016, 60);
            roundedPanel3.TabIndex = 0;
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Bg;
            ClientSize = new Size(1434, 802);
            Controls.Add(roundedPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Receipt";
            Text = "Receipt";
            Load += Receipt_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            roundedPanel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            roundedPanel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ten;
        private DataGridViewTextBoxColumn SL;
        private DataGridViewTextBoxColumn Thanhtien;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Helpers.UI.RoundedPanel roundedPanel1;
        private Helpers.UI.DatetimePickerCustom datetime;
        private PictureBox pictureBox1;
        private Helpers.UI.RoundedPanel roundedPanel2;
        private Helpers.UI.RoundedPanel roundedPanel3;
        private Panel panel8;
        private Helpers.UI.RoundedPanel roundedPanel11;
        private DataGridView dgOrders;
        private DataGridViewTextBoxColumn id;
        private DataGridViewImageColumn barcode;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn total;
        private DataGridViewButtonColumn delete;
    }
}