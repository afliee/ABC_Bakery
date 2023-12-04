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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            panel3 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            roundedPanel4 = new Helpers.UI.RoundedPanel();
            dt_date = new Helpers.UI.DatetimePickerCustom();
            roundedPanel1 = new Helpers.UI.RoundedPanel();
            roundedPanel5 = new Helpers.UI.RoundedPanel();
            panel1 = new Panel();
            dgReceiptDetail = new DataGridView();
            order_name = new DataGridViewTextBoxColumn();
            order_quantity = new DataGridViewTextBoxColumn();
            order_total = new DataGridViewTextBoxColumn();
            oderDetail_Id = new DataGridViewTextBoxColumn();
            roundedPanel6 = new Helpers.UI.RoundedPanel();
            label2 = new Label();
            metroDivider1 = new ReaLTaiizor.Controls.MetroDivider();
            panel4 = new Panel();
            panel5 = new Panel();
            roundedPanel3 = new Helpers.UI.RoundedPanel();
            dgReceipts = new DataGridView();
            roundedPanel2 = new Helpers.UI.RoundedPanel();
            label6 = new Label();
            stt = new DataGridViewTextBoxColumn();
            maPhieu = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            order_paid_quantity = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            roundedPanel4.SuspendLayout();
            roundedPanel1.SuspendLayout();
            roundedPanel5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgReceiptDetail).BeginInit();
            roundedPanel6.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            roundedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgReceipts).BeginInit();
            roundedPanel2.SuspendLayout();
            SuspendLayout();
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
            panel3.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Arial Narrow", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 18);
            label1.Margin = new Padding(15);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(115, 33);
            label1.TabIndex = 9;
            label1.Text = "Phiếu chi";
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
            roundedPanel4.TabIndex = 6;
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
            roundedPanel1.Size = new Size(401, 737);
            roundedPanel1.TabIndex = 17;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.FromArgb(249, 245, 220);
            roundedPanel5.Controls.Add(panel1);
            roundedPanel5.Controls.Add(roundedPanel6);
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
            panel1.Controls.Add(dgReceiptDetail);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 638);
            panel1.TabIndex = 8;
            // 
            // dgReceiptDetail
            // 
            dgReceiptDetail.AllowUserToAddRows = false;
            dgReceiptDetail.AllowUserToDeleteRows = false;
            dgReceiptDetail.AllowUserToOrderColumns = true;
            dgReceiptDetail.BackgroundColor = Color.FromArgb(249, 245, 220);
            dgReceiptDetail.BorderStyle = BorderStyle.None;
            dgReceiptDetail.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgReceiptDetail.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(249, 245, 220);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.Padding = new Padding(0, 10, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(249, 245, 220);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgReceiptDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgReceiptDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgReceiptDetail.Columns.AddRange(new DataGridViewColumn[] { order_name, order_quantity, order_total, oderDetail_Id });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgReceiptDetail.DefaultCellStyle = dataGridViewCellStyle5;
            dgReceiptDetail.Dock = DockStyle.Fill;
            dgReceiptDetail.EnableHeadersVisualStyles = false;
            dgReceiptDetail.GridColor = Color.FromArgb(224, 224, 224);
            dgReceiptDetail.Location = new Point(0, 0);
            dgReceiptDetail.Name = "dgReceiptDetail";
            dgReceiptDetail.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgReceiptDetail.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(249, 245, 220);
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(249, 245, 220);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dgReceiptDetail.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgReceiptDetail.RowTemplate.Height = 40;
            dgReceiptDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgReceiptDetail.Size = new Size(385, 638);
            dgReceiptDetail.TabIndex = 6;
            // 
            // order_name
            // 
            order_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            order_name.DefaultCellStyle = dataGridViewCellStyle2;
            order_name.HeaderText = "Tên";
            order_name.Name = "order_name";
            order_name.ReadOnly = true;
            // 
            // order_quantity
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            order_quantity.DefaultCellStyle = dataGridViewCellStyle3;
            order_quantity.HeaderText = "SL";
            order_quantity.Name = "order_quantity";
            order_quantity.Width = 65;
            // 
            // order_total
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            order_total.DefaultCellStyle = dataGridViewCellStyle4;
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
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(roundedPanel2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 65);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(15, 3, 15, 15);
            panel4.Size = new Size(1056, 737);
            panel4.TabIndex = 18;
            // 
            // panel5
            // 
            panel5.Controls.Add(roundedPanel3);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(15, 59);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 10, 0, 10);
            panel5.Size = new Size(1026, 663);
            panel5.TabIndex = 6;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.FromArgb(0, 0, 0, 0);
            roundedPanel3.Controls.Add(dgReceipts);
            roundedPanel3.Dock = DockStyle.Fill;
            roundedPanel3.ForeColor = Color.White;
            roundedPanel3.Location = new Point(0, 10);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(1026, 643);
            roundedPanel3.TabIndex = 0;
            // 
            // dgReceipts
            // 
            dgReceipts.AllowUserToAddRows = false;
            dgReceipts.BackgroundColor = Color.FromArgb(249, 245, 220);
            dgReceipts.BorderStyle = BorderStyle.None;
            dgReceipts.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgReceipts.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgReceipts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.NullValue = "dasd";
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgReceipts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgReceipts.ColumnHeadersHeight = 58;
            dgReceipts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgReceipts.Columns.AddRange(new DataGridViewColumn[] { stt, maPhieu, date, order_paid_quantity, total, id });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = Color.RosyBrown;
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgReceipts.DefaultCellStyle = dataGridViewCellStyle12;
            dgReceipts.Dock = DockStyle.Fill;
            dgReceipts.EnableHeadersVisualStyles = false;
            dgReceipts.GridColor = Color.FromArgb(224, 224, 224);
            dgReceipts.Location = new Point(0, 0);
            dgReceipts.Margin = new Padding(0);
            dgReceipts.MultiSelect = false;
            dgReceipts.Name = "dgReceipts";
            dgReceipts.ReadOnly = true;
            dgReceipts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.White;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dgReceipts.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dgReceipts.RowHeadersVisible = false;
            dgReceipts.RowHeadersWidth = 51;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(226, 199, 153);
            dataGridViewCellStyle14.SelectionForeColor = Color.Black;
            dgReceipts.RowsDefaultCellStyle = dataGridViewCellStyle14;
            dgReceipts.RowTemplate.Height = 50;
            dgReceipts.ScrollBars = ScrollBars.None;
            dgReceipts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgReceipts.Size = new Size(1026, 643);
            dgReceipts.TabIndex = 3;
            dgReceipts.CellContentClick += dgReceipts_CellContentClick;
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
            // stt
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            stt.DefaultCellStyle = dataGridViewCellStyle8;
            stt.HeaderText = "STT";
            stt.Name = "stt";
            stt.ReadOnly = true;
            // 
            // maPhieu
            // 
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            maPhieu.DefaultCellStyle = dataGridViewCellStyle9;
            maPhieu.HeaderText = "Mã Phiếu";
            maPhieu.Name = "maPhieu";
            maPhieu.ReadOnly = true;
            maPhieu.Width = 150;
            // 
            // date
            // 
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            date.DefaultCellStyle = dataGridViewCellStyle10;
            date.HeaderText = "Ngày";
            date.Name = "date";
            date.ReadOnly = true;
            date.Width = 250;
            // 
            // order_paid_quantity
            // 
            order_paid_quantity.HeaderText = "SL Hóa đơn";
            order_paid_quantity.Name = "order_paid_quantity";
            order_paid_quantity.ReadOnly = true;
            order_paid_quantity.Width = 200;
            // 
            // total
            // 
            total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            total.DefaultCellStyle = dataGridViewCellStyle11;
            total.HeaderText = "Tổng Tiền";
            total.Name = "total";
            total.ReadOnly = true;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 5;
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Bg;
            ClientSize = new Size(1457, 802);
            Controls.Add(panel4);
            Controls.Add(roundedPanel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Receipt";
            Text = "Receipt";
            Load += Receipt_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            roundedPanel4.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            roundedPanel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgReceiptDetail).EndInit();
            roundedPanel6.ResumeLayout(false);
            roundedPanel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            roundedPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgReceipts).EndInit();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label1;
        private Panel panel2;
        private Helpers.UI.RoundedPanel roundedPanel4;
        private Helpers.UI.DatetimePickerCustom dt_date;
        private Helpers.UI.RoundedPanel roundedPanel1;
        private Helpers.UI.RoundedPanel roundedPanel5;
        private Panel panel1;
        private DataGridView dgReceiptDetail;
        private DataGridViewTextBoxColumn order_name;
        private DataGridViewTextBoxColumn order_quantity;
        private DataGridViewTextBoxColumn order_total;
        private DataGridViewTextBoxColumn oderDetail_Id;
        private Helpers.UI.RoundedPanel roundedPanel6;
        private Label label2;
        private ReaLTaiizor.Controls.MetroDivider metroDivider1;
        private Panel panel4;
        private Panel panel5;
        private Helpers.UI.RoundedPanel roundedPanel3;
        private DataGridView dgReceipts;
        private Helpers.UI.RoundedPanel roundedPanel2;
        private Label label6;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn maPhieu;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn order_paid_quantity;
        private DataGridViewTextBoxColumn total;
        private DataGridViewTextBoxColumn id;
    }
}