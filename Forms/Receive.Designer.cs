using Color = System.Drawing.Color;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using SizeF = System.Drawing.SizeF;

namespace ABC_Bakery.Forms
{
    partial class Receive
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label6 = new Label();
            ten = new DataGridViewTextBoxColumn();
            SL = new DataGridViewTextBoxColumn();
            Thanhtien = new DataGridViewTextBoxColumn();
            flowLayoutPanel1 = new FlowLayoutPanel();
            roundedPanel1 = new Helpers.UI.RoundedPanel();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            panel5 = new Panel();
            roundedPanel3 = new Helpers.UI.RoundedPanel();
            dataGridView3 = new DataGridView();
            stt = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            roundedPanel2 = new Helpers.UI.RoundedPanel();
            panel4 = new Panel();
            panel2 = new Panel();
            roundedPanel4 = new Helpers.UI.RoundedPanel();
            datetimePickerCustom1 = new Helpers.UI.DatetimePickerCustom();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            flowLayoutPanel1.SuspendLayout();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            roundedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            roundedPanel2.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            roundedPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(6, 20);
            label6.Name = "label6";
            label6.Size = new Size(121, 29);
            label6.TabIndex = 0;
            label6.Text = "Phiếu chi";
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
            SL.Width = 68;
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
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            flowLayoutPanel1.Location = new Point(1173, 93);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(466, 976);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(255, 224, 192);
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.ForeColor = Color.White;
            roundedPanel1.Location = new Point(3, 4);
            roundedPanel1.Margin = new Padding(3, 4, 3, 4);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(457, 75);
            roundedPanel1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(7, 23);
            label3.Name = "label3";
            label3.Size = new Size(199, 29);
            label3.TabIndex = 0;
            label3.Text = "Chi tiết hóa đơn";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 54;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ten, SL, Thanhtien });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(6, 90);
            dataGridView1.Margin = new Padding(6, 7, 6, 7);
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
            dataGridView1.Size = new Size(455, 853);
            dataGridView1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(roundedPanel3);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(17, 79);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 13, 0, 13);
            panel5.Size = new Size(1605, 877);
            panel5.TabIndex = 6;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.FromArgb(0, 0, 0, 0);
            roundedPanel3.Controls.Add(dataGridView3);
            roundedPanel3.Dock = DockStyle.Fill;
            roundedPanel3.ForeColor = Color.White;
            roundedPanel3.Location = new Point(0, 13);
            roundedPanel3.Margin = new Padding(3, 4, 3, 4);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(1605, 851);
            roundedPanel3.TabIndex = 0;
            // 
            // dataGridView3
            // 
            dataGridView3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView3.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridView3.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.NullValue = "dasd";
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView3.ColumnHeadersHeight = 54;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { stt, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.RosyBrown;
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridView3.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.GridColor = Color.FromArgb(224, 224, 224);
            dataGridView3.Location = new Point(-2, 0);
            dataGridView3.Margin = new Padding(0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(255, 224, 192);
            dataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.ScrollBars = ScrollBars.None;
            dataGridView3.Size = new Size(1158, 954);
            dataGridView3.TabIndex = 3;
            // 
            // stt
            // 
            stt.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle6.BackColor = Color.Red;
            dataGridViewCellStyle6.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            stt.DefaultCellStyle = dataGridViewCellStyle6;
            stt.Frozen = true;
            stt.HeaderText = "STT";
            stt.MinimumWidth = 6;
            stt.Name = "stt";
            stt.Resizable = DataGridViewTriState.True;
            stt.Width = 74;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn2.FillWeight = 273.6842F;
            dataGridViewTextBoxColumn2.HeaderText = "Mã Phiếu";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 170;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.FillWeight = 42.1052666F;
            dataGridViewTextBoxColumn3.HeaderText = "Ngày";
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
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.FromArgb(255, 224, 192);
            roundedPanel2.Controls.Add(label6);
            roundedPanel2.Dock = DockStyle.Top;
            roundedPanel2.ForeColor = Color.Black;
            roundedPanel2.Location = new Point(17, 4);
            roundedPanel2.Margin = new Padding(3, 4, 3, 4);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(1605, 75);
            roundedPanel2.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(roundedPanel2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 93);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(17, 4, 17, 20);
            panel4.Size = new Size(1639, 976);
            panel4.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(roundedPanel4);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1173, 13);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(455, 67);
            panel2.TabIndex = 7;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.FromArgb(154, 59, 59);
            roundedPanel4.Controls.Add(datetimePickerCustom1);
            roundedPanel4.Controls.Add(pictureBox1);
            roundedPanel4.Dock = DockStyle.Fill;
            roundedPanel4.ForeColor = Color.White;
            roundedPanel4.Location = new Point(0, 0);
            roundedPanel4.Margin = new Padding(3, 20, 3, 4);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(455, 67);
            roundedPanel4.TabIndex = 6;
            // 
            // datetimePickerCustom1
            // 
            datetimePickerCustom1.BorderColor = Color.FromArgb(154, 59, 59);
            datetimePickerCustom1.BorderSize = 3;
            datetimePickerCustom1.CustomFormat = "dddd , dd MMMM yyyy";
            datetimePickerCustom1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            datetimePickerCustom1.Location = new Point(71, 11);
            datetimePickerCustom1.Margin = new Padding(3, 4, 3, 4);
            datetimePickerCustom1.MinimumSize = new Size(4, 50);
            datetimePickerCustom1.Name = "datetimePickerCustom1";
            datetimePickerCustom1.Size = new Size(374, 50);
            datetimePickerCustom1.SkinColor = Color.FromArgb(154, 59, 59);
            datetimePickerCustom1.TabIndex = 1;
            datetimePickerCustom1.TextColor = Color.White;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.calender;
            pictureBox1.Location = new Point(3, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 26);
            label1.Margin = new Padding(17, 20, 17, 20);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(148, 43);
            label1.TabIndex = 2;
            label1.Text = "Phiếu chi";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(11, 13, 11, 13);
            panel1.Size = new Size(1639, 93);
            panel1.TabIndex = 3;
            // 
            // Receive
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Bg;
            ClientSize = new Size(1639, 1069);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Receive";
            Text = "Receive";
            flowLayoutPanel1.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            roundedPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            roundedPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label6;
        private DataGridViewTextBoxColumn ten;
        private DataGridViewTextBoxColumn SL;
        private DataGridViewTextBoxColumn Thanhtien;
        private FlowLayoutPanel flowLayoutPanel1;
        private Helpers.UI.RoundedPanel roundedPanel1;
        private Label label3;
        private DataGridView dataGridView1;
        private Panel panel5;
        private Helpers.UI.RoundedPanel roundedPanel3;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Helpers.UI.RoundedPanel roundedPanel2;
        private Panel panel4;
        private Panel panel2;
        private Helpers.UI.RoundedPanel roundedPanel4;
        private Helpers.UI.DatetimePickerCustom datetimePickerCustom1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
    }
}