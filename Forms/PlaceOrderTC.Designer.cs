namespace ABC_Bakery.Forms
{
    partial class PlaceOrderTC
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaceOrderTC));
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            dgProducts = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            barcode = new DataGridViewImageColumn();
            name = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            delete = new DataGridViewButtonColumn();
            roundedPanel11 = new Helpers.UI.RoundedPanel();
            roundedPanel9 = new Helpers.UI.RoundedPanel();
            tbDiscount = new Helpers.UI.RJTextBox();
            label5 = new Label();
            panel8 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel5 = new Panel();
            btnRenew = new Helpers.UI.RJButton();
            rjButton1 = new Helpers.UI.RJButton();
            panel6 = new Panel();
            btnCanceled = new Helpers.UI.RJButton();
            panel7 = new Panel();
            btnPrint = new Helpers.UI.RJButton();
            roundedPanel4 = new Helpers.UI.RoundedPanel();
            panel9 = new Panel();
            filter = new FontAwesome.Sharp.IconPictureBox();
            tbSearch = new Helpers.UI.RJTextBox();
            dungeonHeaderLabel2 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            roundedPanel10 = new Helpers.UI.RoundedPanel();
            tbSurcharge = new Helpers.UI.RJTextBox();
            label7 = new Label();
            label6 = new Label();
            btnSave = new Helpers.UI.RJButton();
            label2 = new Label();
            roundedPanel6 = new Helpers.UI.RoundedPanel();
            metroDivider1 = new ReaLTaiizor.Controls.MetroDivider();
            roundedPanel13 = new Helpers.UI.RoundedPanel();
            tbDeposit = new Helpers.UI.RJTextBox();
            label9 = new Label();
            label10 = new Label();
            label13 = new Label();
            roundedPanel18 = new Helpers.UI.RoundedPanel();
            datetimePickerCustom4 = new Helpers.UI.DatetimePickerCustom();
            label17 = new Label();
            roundedPanel7 = new Helpers.UI.RoundedPanel();
            dt_refundedTime = new Helpers.UI.DatetimePickerCustom();
            label1 = new Label();
            roundedPanel14 = new Helpers.UI.RoundedPanel();
            tbTotal = new Helpers.UI.RJTextBox();
            label12 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            tbNote = new Helpers.UI.RJTextBox();
            roundedPanel3 = new Helpers.UI.RoundedPanel();
            roundedPanel2 = new Helpers.UI.RoundedPanel();
            datetimePickerCustom1 = new Helpers.UI.DatetimePickerCustom();
            pictureBox1 = new PictureBox();
            roundedPanel1 = new Helpers.UI.RoundedPanel();
            lbIndex = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            print_order = new System.Drawing.Printing.PrintDocument();
            delayTimeDiscount = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
            roundedPanel11.SuspendLayout();
            roundedPanel9.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            roundedPanel4.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)filter).BeginInit();
            roundedPanel10.SuspendLayout();
            roundedPanel6.SuspendLayout();
            roundedPanel13.SuspendLayout();
            roundedPanel18.SuspendLayout();
            roundedPanel7.SuspendLayout();
            roundedPanel14.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            parrotGroupBox1.SuspendLayout();
            roundedPanel3.SuspendLayout();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            roundedPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgProducts
            // 
            dgProducts.AllowUserToAddRows = false;
            dgProducts.BackgroundColor = System.Drawing.Color.FromArgb(249, 245, 220);
            dgProducts.BorderStyle = BorderStyle.None;
            dgProducts.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgProducts.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgProducts.ColumnHeadersHeight = 55;
            dgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgProducts.Columns.AddRange(new DataGridViewColumn[] { id, barcode, name, price, quantity, total, delete });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgProducts.DefaultCellStyle = dataGridViewCellStyle10;
            dgProducts.Dock = DockStyle.Fill;
            dgProducts.EnableHeadersVisualStyles = false;
            dgProducts.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
            dgProducts.Location = new System.Drawing.Point(0, 0);
            dgProducts.Margin = new Padding(0);
            dgProducts.MultiSelect = false;
            dgProducts.Name = "dgProducts";
            dgProducts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgProducts.RowHeadersVisible = false;
            dgProducts.RowHeadersWidth = 50;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(226, 199, 153);
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dgProducts.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dgProducts.RowTemplate.Height = 50;
            dgProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProducts.Size = new System.Drawing.Size(824, 674);
            dgProducts.TabIndex = 6;
            dgProducts.CellContentClick += dgProducts_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "Mã SP";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // barcode
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.NullValue = resources.GetObject("dataGridViewCellStyle8.NullValue");
            dataGridViewCellStyle8.Padding = new Padding(5);
            barcode.DefaultCellStyle = dataGridViewCellStyle8;
            barcode.HeaderText = "Barcode";
            barcode.Name = "barcode";
            barcode.ReadOnly = true;
            barcode.Width = 150;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.FillWeight = 28.3298721F;
            name.HeaderText = "Tên Sản Phẩm";
            name.MinimumWidth = 6;
            name.Name = "name";
            // 
            // price
            // 
            price.FillWeight = 4.35844231F;
            price.HeaderText = "Giá Tiền";
            price.MinimumWidth = 6;
            price.Name = "price";
            // 
            // quantity
            // 
            quantity.FillWeight = 4.35844231F;
            quantity.HeaderText = "Số lượng";
            quantity.MinimumWidth = 6;
            quantity.Name = "quantity";
            // 
            // total
            // 
            total.HeaderText = "Tổng Tiền";
            total.Name = "total";
            total.ReadOnly = true;
            // 
            // delete
            // 
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Padding = new Padding(10);
            delete.DefaultCellStyle = dataGridViewCellStyle9;
            delete.HeaderText = "Thao Tác";
            delete.Name = "delete";
            delete.Text = "Xóa";
            delete.UseColumnTextForButtonValue = true;
            // 
            // roundedPanel11
            // 
            roundedPanel11.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            roundedPanel11.Controls.Add(dgProducts);
            roundedPanel11.Dock = DockStyle.Fill;
            roundedPanel11.ForeColor = System.Drawing.Color.White;
            roundedPanel11.Location = new System.Drawing.Point(0, 10);
            roundedPanel11.Name = "roundedPanel11";
            roundedPanel11.Size = new System.Drawing.Size(824, 674);
            roundedPanel11.TabIndex = 0;
            // 
            // roundedPanel9
            // 
            roundedPanel9.BackColor = System.Drawing.Color.FromArgb(242, 236, 190);
            roundedPanel9.Controls.Add(tbDiscount);
            roundedPanel9.Controls.Add(label5);
            roundedPanel9.ForeColor = System.Drawing.Color.White;
            roundedPanel9.Location = new System.Drawing.Point(3, 135);
            roundedPanel9.Name = "roundedPanel9";
            roundedPanel9.Size = new System.Drawing.Size(374, 60);
            roundedPanel9.TabIndex = 5;
            // 
            // tbDiscount
            // 
            tbDiscount.BackColor = SystemColors.Window;
            tbDiscount.BorderColor = System.Drawing.Color.FromArgb(154, 59, 59);
            tbDiscount.BorderFocusColor = System.Drawing.Color.HotPink;
            tbDiscount.BorderRadius = 10;
            tbDiscount.BorderSize = 2;
            tbDiscount.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbDiscount.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            tbDiscount.Location = new System.Drawing.Point(145, 6);
            tbDiscount.Margin = new Padding(4);
            tbDiscount.Multiline = false;
            tbDiscount.Name = "tbDiscount";
            tbDiscount.Padding = new Padding(10, 7, 10, 7);
            tbDiscount.PasswordChar = false;
            tbDiscount.PlaceholderColor = System.Drawing.Color.DarkGray;
            tbDiscount.PlaceholderText = "";
            tbDiscount.Size = new System.Drawing.Size(225, 47);
            tbDiscount.TabIndex = 1;
            tbDiscount.TextAlign = HorizontalAlignment.Left;
            tbDiscount.Texts = "";
            tbDiscount.UnderlinedStyle = false;
            tbDiscount._TextChanged += tbDiscount__TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(12, 19);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(119, 25);
            label5.TabIndex = 0;
            label5.Text = "Mã giảm giá";
            // 
            // panel8
            // 
            panel8.Controls.Add(roundedPanel11);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new System.Drawing.Point(10, 66);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(0, 10, 0, 10);
            panel8.Size = new System.Drawing.Size(824, 694);
            panel8.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(roundedPanel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(0, 87);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10, 3, 10, 10);
            panel3.Size = new System.Drawing.Size(844, 846);
            panel3.TabIndex = 17;
            // 
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanel1);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new System.Drawing.Point(10, 760);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(824, 76);
            panel4.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(panel5, 0, 0);
            tableLayoutPanel1.Controls.Add(panel6, 1, 0);
            tableLayoutPanel1.Controls.Add(panel7, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(824, 64);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnRenew);
            panel5.Controls.Add(rjButton1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new System.Drawing.Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(268, 58);
            panel5.TabIndex = 0;
            // 
            // btnRenew
            // 
            btnRenew.BackColor = System.Drawing.Color.FromArgb(154, 59, 59);
            btnRenew.BackgroundColor = System.Drawing.Color.FromArgb(154, 59, 59);
            btnRenew.BorderColor = System.Drawing.Color.PaleVioletRed;
            btnRenew.BorderRadius = 5;
            btnRenew.BorderSize = 0;
            btnRenew.Dock = DockStyle.Fill;
            btnRenew.FlatAppearance.BorderSize = 0;
            btnRenew.FlatStyle = FlatStyle.Flat;
            btnRenew.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRenew.ForeColor = System.Drawing.Color.White;
            btnRenew.Location = new System.Drawing.Point(0, 0);
            btnRenew.Name = "btnRenew";
            btnRenew.Size = new System.Drawing.Size(268, 58);
            btnRenew.TabIndex = 1;
            btnRenew.Text = "THÊM PHIẾU";
            btnRenew.TextColor = System.Drawing.Color.White;
            btnRenew.UseVisualStyleBackColor = false;
            btnRenew.Click += btnRenew_Click;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = System.Drawing.Color.FromArgb(154, 59, 59);
            rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(154, 59, 59);
            rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton1.BorderRadius = 5;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rjButton1.ForeColor = System.Drawing.Color.White;
            rjButton1.Location = new System.Drawing.Point(0, 28);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new System.Drawing.Size(279, 40);
            rjButton1.TabIndex = 0;
            rjButton1.Text = "THÊM PHIẾU";
            rjButton1.TextColor = System.Drawing.Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnCanceled);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new System.Drawing.Point(277, 3);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(268, 58);
            panel6.TabIndex = 1;
            // 
            // btnCanceled
            // 
            btnCanceled.BackColor = System.Drawing.Color.FromArgb(154, 59, 59);
            btnCanceled.BackgroundColor = System.Drawing.Color.FromArgb(154, 59, 59);
            btnCanceled.BorderColor = System.Drawing.Color.PaleVioletRed;
            btnCanceled.BorderRadius = 5;
            btnCanceled.BorderSize = 0;
            btnCanceled.Dock = DockStyle.Fill;
            btnCanceled.FlatAppearance.BorderSize = 0;
            btnCanceled.FlatStyle = FlatStyle.Flat;
            btnCanceled.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCanceled.ForeColor = System.Drawing.Color.White;
            btnCanceled.Location = new System.Drawing.Point(0, 0);
            btnCanceled.Name = "btnCanceled";
            btnCanceled.Size = new System.Drawing.Size(268, 58);
            btnCanceled.TabIndex = 2;
            btnCanceled.Text = "HỦY PHIẾU";
            btnCanceled.TextColor = System.Drawing.Color.White;
            btnCanceled.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnPrint);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new System.Drawing.Point(551, 3);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(270, 58);
            panel7.TabIndex = 2;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = System.Drawing.Color.FromArgb(154, 59, 59);
            btnPrint.BackgroundColor = System.Drawing.Color.FromArgb(154, 59, 59);
            btnPrint.BorderColor = System.Drawing.Color.PaleVioletRed;
            btnPrint.BorderRadius = 5;
            btnPrint.BorderSize = 0;
            btnPrint.Dock = DockStyle.Fill;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrint.ForeColor = System.Drawing.Color.White;
            btnPrint.Location = new System.Drawing.Point(0, 0);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new System.Drawing.Size(270, 58);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "IN PHIẾU";
            btnPrint.TextColor = System.Drawing.Color.White;
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = System.Drawing.Color.FromArgb(249, 245, 220);
            roundedPanel4.Controls.Add(panel9);
            roundedPanel4.Controls.Add(dungeonHeaderLabel2);
            roundedPanel4.Dock = DockStyle.Top;
            roundedPanel4.ForeColor = System.Drawing.Color.White;
            roundedPanel4.Location = new System.Drawing.Point(10, 3);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new System.Drawing.Size(824, 63);
            roundedPanel4.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(filter);
            panel9.Controls.Add(tbSearch);
            panel9.Dock = DockStyle.Right;
            panel9.Location = new System.Drawing.Point(469, 0);
            panel9.Name = "panel9";
            panel9.Size = new System.Drawing.Size(355, 63);
            panel9.TabIndex = 4;
            // 
            // filter
            // 
            filter.BackColor = System.Drawing.Color.FromArgb(249, 245, 220);
            filter.ForeColor = System.Drawing.Color.Black;
            filter.IconChar = FontAwesome.Sharp.IconChar.Filter;
            filter.IconColor = System.Drawing.Color.Black;
            filter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            filter.Location = new System.Drawing.Point(24, 17);
            filter.Name = "filter";
            filter.Size = new System.Drawing.Size(32, 32);
            filter.TabIndex = 6;
            filter.TabStop = false;
            filter.Click += filter_Click;
            // 
            // tbSearch
            // 
            tbSearch.BackColor = SystemColors.Window;
            tbSearch.BorderColor = System.Drawing.Color.FromArgb(154, 59, 59);
            tbSearch.BorderFocusColor = System.Drawing.Color.HotPink;
            tbSearch.BorderRadius = 10;
            tbSearch.BorderSize = 2;
            tbSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbSearch.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            tbSearch.Location = new System.Drawing.Point(78, 10);
            tbSearch.Margin = new Padding(4);
            tbSearch.Multiline = false;
            tbSearch.Name = "tbSearch";
            tbSearch.Padding = new Padding(10, 7, 10, 7);
            tbSearch.PasswordChar = false;
            tbSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            tbSearch.PlaceholderText = "Nhập/ Ấn vào để Scan";
            tbSearch.Size = new System.Drawing.Size(267, 40);
            tbSearch.TabIndex = 3;
            tbSearch.TextAlign = HorizontalAlignment.Left;
            tbSearch.Texts = "";
            tbSearch.UnderlinedStyle = false;
            tbSearch._TextChanged += tbSearch__TextChanged;
            tbSearch.KeyDown += tbSearch_KeyDown;
            // 
            // dungeonHeaderLabel2
            // 
            dungeonHeaderLabel2.AutoSize = true;
            dungeonHeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            dungeonHeaderLabel2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dungeonHeaderLabel2.ForeColor = System.Drawing.Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel2.ImageAlign = ContentAlignment.MiddleLeft;
            dungeonHeaderLabel2.Location = new System.Drawing.Point(3, 17);
            dungeonHeaderLabel2.Name = "dungeonHeaderLabel2";
            dungeonHeaderLabel2.Size = new System.Drawing.Size(198, 30);
            dungeonHeaderLabel2.TabIndex = 1;
            dungeonHeaderLabel2.Text = "Sản phẩm đã thêm";
            // 
            // roundedPanel10
            // 
            roundedPanel10.BackColor = System.Drawing.Color.FromArgb(242, 236, 190);
            roundedPanel10.Controls.Add(tbSurcharge);
            roundedPanel10.Controls.Add(label7);
            roundedPanel10.Controls.Add(label6);
            roundedPanel10.ForeColor = System.Drawing.Color.White;
            roundedPanel10.Location = new System.Drawing.Point(3, 201);
            roundedPanel10.Name = "roundedPanel10";
            roundedPanel10.Size = new System.Drawing.Size(374, 60);
            roundedPanel10.TabIndex = 6;
            // 
            // tbSurcharge
            // 
            tbSurcharge.BackColor = SystemColors.Window;
            tbSurcharge.BorderColor = System.Drawing.Color.FromArgb(154, 59, 59);
            tbSurcharge.BorderFocusColor = System.Drawing.Color.HotPink;
            tbSurcharge.BorderRadius = 10;
            tbSurcharge.BorderSize = 2;
            tbSurcharge.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbSurcharge.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            tbSurcharge.Location = new System.Drawing.Point(106, 6);
            tbSurcharge.Margin = new Padding(4);
            tbSurcharge.Multiline = false;
            tbSurcharge.Name = "tbSurcharge";
            tbSurcharge.Padding = new Padding(10, 7, 10, 7);
            tbSurcharge.PasswordChar = false;
            tbSurcharge.PlaceholderColor = System.Drawing.Color.DarkGray;
            tbSurcharge.PlaceholderText = "";
            tbSurcharge.Size = new System.Drawing.Size(216, 47);
            tbSurcharge.TabIndex = 2;
            tbSurcharge.TextAlign = HorizontalAlignment.Left;
            tbSurcharge.Texts = "0";
            tbSurcharge.UnderlinedStyle = false;
            tbSurcharge._TextChanged += tbSurcharge__TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.Black;
            label7.Location = new System.Drawing.Point(320, 16);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(54, 25);
            label7.TabIndex = 2;
            label7.Text = "VND";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.Black;
            label6.Location = new System.Drawing.Point(12, 16);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(79, 25);
            label6.TabIndex = 0;
            label6.Text = "Phụ thu";
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.FromArgb(154, 59, 59);
            btnSave.BackgroundColor = System.Drawing.Color.FromArgb(154, 59, 59);
            btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            btnSave.BorderRadius = 5;
            btnSave.BorderSize = 0;
            btnSave.Dock = DockStyle.Bottom;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(0, 770);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(380, 59);
            btnSave.TabIndex = 0;
            btnSave.Text = "LƯU BIÊN NHẬN";
            btnSave.TextColor = System.Drawing.Color.White;
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
            roundedPanel6.Location = new System.Drawing.Point(0, 0);
            roundedPanel6.Margin = new Padding(3, 3, 3, 50);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new System.Drawing.Size(380, 65);
            roundedPanel6.TabIndex = 7;
            // 
            // metroDivider1
            // 
            metroDivider1.IsDerivedStyle = true;
            metroDivider1.Location = new System.Drawing.Point(-1, 51);
            metroDivider1.Name = "metroDivider1";
            metroDivider1.Orientation = ReaLTaiizor.Enum.Metro.DividerStyle.Horizontal;
            metroDivider1.Size = new System.Drawing.Size(389, 4);
            metroDivider1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroDivider1.StyleManager = null;
            metroDivider1.TabIndex = 3;
            metroDivider1.Text = "metroDivider1";
            metroDivider1.ThemeAuthor = "Taiizor";
            metroDivider1.ThemeName = "MetroLight";
            metroDivider1.Thickness = 1;
            // 
            // roundedPanel13
            // 
            roundedPanel13.BackColor = System.Drawing.Color.FromArgb(242, 236, 190);
            roundedPanel13.Controls.Add(tbDeposit);
            roundedPanel13.Controls.Add(label9);
            roundedPanel13.Controls.Add(label10);
            roundedPanel13.ForeColor = System.Drawing.Color.White;
            roundedPanel13.Location = new System.Drawing.Point(3, 267);
            roundedPanel13.Name = "roundedPanel13";
            roundedPanel13.Size = new System.Drawing.Size(374, 60);
            roundedPanel13.TabIndex = 8;
            // 
            // tbDeposit
            // 
            tbDeposit.BackColor = SystemColors.Window;
            tbDeposit.BorderColor = System.Drawing.Color.FromArgb(154, 59, 59);
            tbDeposit.BorderFocusColor = System.Drawing.Color.HotPink;
            tbDeposit.BorderRadius = 10;
            tbDeposit.BorderSize = 2;
            tbDeposit.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbDeposit.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            tbDeposit.Location = new System.Drawing.Point(106, 6);
            tbDeposit.Margin = new Padding(4);
            tbDeposit.Multiline = false;
            tbDeposit.Name = "tbDeposit";
            tbDeposit.Padding = new Padding(10, 7, 10, 7);
            tbDeposit.PasswordChar = false;
            tbDeposit.PlaceholderColor = System.Drawing.Color.DarkGray;
            tbDeposit.PlaceholderText = "";
            tbDeposit.Size = new System.Drawing.Size(216, 47);
            tbDeposit.TabIndex = 3;
            tbDeposit.TextAlign = HorizontalAlignment.Left;
            tbDeposit.Texts = "0";
            tbDeposit.UnderlinedStyle = false;
            tbDeposit._TextChanged += tbDeposit__TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.Color.Black;
            label9.Location = new System.Drawing.Point(320, 16);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(54, 25);
            label9.TabIndex = 2;
            label9.Text = "VND";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = System.Drawing.Color.Black;
            label10.Location = new System.Drawing.Point(12, 16);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(82, 25);
            label10.TabIndex = 0;
            label10.Text = "Tiền cọc";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = System.Drawing.Color.Black;
            label13.Location = new System.Drawing.Point(12, 16);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(93, 25);
            label13.TabIndex = 0;
            label13.Text = "Tổng tiền";
            // 
            // roundedPanel18
            // 
            roundedPanel18.BackColor = System.Drawing.Color.FromArgb(242, 236, 190);
            roundedPanel18.Controls.Add(datetimePickerCustom4);
            roundedPanel18.Controls.Add(label17);
            roundedPanel18.ForeColor = System.Drawing.Color.White;
            roundedPanel18.Location = new System.Drawing.Point(3, 3);
            roundedPanel18.Name = "roundedPanel18";
            roundedPanel18.Size = new System.Drawing.Size(374, 60);
            roundedPanel18.TabIndex = 4;
            // 
            // datetimePickerCustom4
            // 
            datetimePickerCustom4.BorderColor = System.Drawing.Color.FromArgb(242, 236, 190);
            datetimePickerCustom4.BorderSize = 3;
            datetimePickerCustom4.CustomFormat = "dd/MM/yyyy";
            datetimePickerCustom4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            datetimePickerCustom4.Format = DateTimePickerFormat.Custom;
            datetimePickerCustom4.Location = new System.Drawing.Point(217, 0);
            datetimePickerCustom4.MinimumSize = new System.Drawing.Size(4, 60);
            datetimePickerCustom4.Name = "datetimePickerCustom4";
            datetimePickerCustom4.Size = new System.Drawing.Size(154, 60);
            datetimePickerCustom4.SkinColor = System.Drawing.Color.FromArgb(242, 236, 190);
            datetimePickerCustom4.TabIndex = 0;
            datetimePickerCustom4.TextColor = System.Drawing.Color.Black;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = System.Drawing.Color.Black;
            label17.Location = new System.Drawing.Point(12, 15);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(115, 25);
            label17.TabIndex = 0;
            label17.Text = "Ngày mượn";
            // 
            // roundedPanel7
            // 
            roundedPanel7.BackColor = System.Drawing.Color.FromArgb(242, 236, 190);
            roundedPanel7.Controls.Add(dt_refundedTime);
            roundedPanel7.Controls.Add(label1);
            roundedPanel7.ForeColor = System.Drawing.Color.White;
            roundedPanel7.Location = new System.Drawing.Point(3, 69);
            roundedPanel7.Name = "roundedPanel7";
            roundedPanel7.Size = new System.Drawing.Size(374, 60);
            roundedPanel7.TabIndex = 4;
            // 
            // dt_refundedTime
            // 
            dt_refundedTime.BorderColor = System.Drawing.Color.FromArgb(242, 236, 190);
            dt_refundedTime.BorderSize = 3;
            dt_refundedTime.CustomFormat = "dd/MM/yyyy";
            dt_refundedTime.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dt_refundedTime.Location = new System.Drawing.Point(217, 0);
            dt_refundedTime.MinimumSize = new System.Drawing.Size(4, 60);
            dt_refundedTime.Name = "dt_refundedTime";
            dt_refundedTime.Size = new System.Drawing.Size(154, 60);
            dt_refundedTime.SkinColor = System.Drawing.Color.FromArgb(242, 236, 190);
            dt_refundedTime.TabIndex = 0;
            dt_refundedTime.TextColor = System.Drawing.Color.Black;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(12, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(87, 25);
            label1.TabIndex = 0;
            label1.Text = "Ngày trả";
            // 
            // roundedPanel14
            // 
            roundedPanel14.BackColor = System.Drawing.Color.FromArgb(242, 236, 190);
            roundedPanel14.Controls.Add(tbTotal);
            roundedPanel14.Controls.Add(label12);
            roundedPanel14.Controls.Add(label13);
            roundedPanel14.ForeColor = System.Drawing.Color.White;
            roundedPanel14.Location = new System.Drawing.Point(3, 333);
            roundedPanel14.Name = "roundedPanel14";
            roundedPanel14.Size = new System.Drawing.Size(374, 60);
            roundedPanel14.TabIndex = 9;
            // 
            // tbTotal
            // 
            tbTotal.BackColor = SystemColors.ScrollBar;
            tbTotal.BorderColor = System.Drawing.Color.FromArgb(154, 59, 59);
            tbTotal.BorderFocusColor = System.Drawing.Color.HotPink;
            tbTotal.BorderRadius = 10;
            tbTotal.BorderSize = 2;
            tbTotal.Enabled = false;
            tbTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbTotal.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            tbTotal.Location = new System.Drawing.Point(106, 6);
            tbTotal.Margin = new Padding(4);
            tbTotal.Multiline = false;
            tbTotal.Name = "tbTotal";
            tbTotal.Padding = new Padding(10, 7, 10, 7);
            tbTotal.PasswordChar = false;
            tbTotal.PlaceholderColor = System.Drawing.Color.DarkGray;
            tbTotal.PlaceholderText = "";
            tbTotal.Size = new System.Drawing.Size(216, 47);
            tbTotal.TabIndex = 3;
            tbTotal.TextAlign = HorizontalAlignment.Left;
            tbTotal.Texts = "0";
            tbTotal.UnderlinedStyle = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = System.Drawing.Color.Black;
            label12.Location = new System.Drawing.Point(320, 16);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(54, 25);
            label12.TabIndex = 2;
            label12.Text = "VND";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.Controls.Add(roundedPanel18);
            flowLayoutPanel2.Controls.Add(roundedPanel7);
            flowLayoutPanel2.Controls.Add(roundedPanel9);
            flowLayoutPanel2.Controls.Add(roundedPanel10);
            flowLayoutPanel2.Controls.Add(roundedPanel13);
            flowLayoutPanel2.Controls.Add(roundedPanel14);
            flowLayoutPanel2.Controls.Add(parrotGroupBox1);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new System.Drawing.Point(0, 65);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(380, 705);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // parrotGroupBox1
            // 
            parrotGroupBox1.BorderColor = System.Drawing.Color.FromArgb(154, 59, 59);
            parrotGroupBox1.BorderWidth = 2;
            parrotGroupBox1.Controls.Add(tbNote);
            parrotGroupBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            parrotGroupBox1.Location = new System.Drawing.Point(3, 399);
            parrotGroupBox1.Name = "parrotGroupBox1";
            parrotGroupBox1.ShowText = true;
            parrotGroupBox1.Size = new System.Drawing.Size(374, 166);
            parrotGroupBox1.TabIndex = 10;
            parrotGroupBox1.TabStop = false;
            parrotGroupBox1.Text = "Ghi chú";
            parrotGroupBox1.TextColor = System.Drawing.Color.Black;
            // 
            // tbNote
            // 
            tbNote.BackColor = SystemColors.Window;
            tbNote.BorderColor = System.Drawing.Color.FromArgb(154, 59, 59);
            tbNote.BorderFocusColor = System.Drawing.Color.HotPink;
            tbNote.BorderRadius = 5;
            tbNote.BorderSize = 2;
            tbNote.Dock = DockStyle.Fill;
            tbNote.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbNote.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            tbNote.Location = new System.Drawing.Point(3, 29);
            tbNote.Margin = new Padding(0);
            tbNote.Multiline = true;
            tbNote.Name = "tbNote";
            tbNote.Padding = new Padding(10, 7, 10, 7);
            tbNote.PasswordChar = false;
            tbNote.PlaceholderColor = System.Drawing.Color.DarkGray;
            tbNote.PlaceholderText = "Giờ có thể ghi ở đây";
            tbNote.Size = new System.Drawing.Size(368, 134);
            tbNote.TabIndex = 10;
            tbNote.TextAlign = HorizontalAlignment.Left;
            tbNote.Texts = "";
            tbNote.UnderlinedStyle = false;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = System.Drawing.Color.FromArgb(249, 245, 220);
            roundedPanel3.Controls.Add(flowLayoutPanel2);
            roundedPanel3.Controls.Add(roundedPanel6);
            roundedPanel3.Controls.Add(btnSave);
            roundedPanel3.Dock = DockStyle.Fill;
            roundedPanel3.ForeColor = System.Drawing.Color.White;
            roundedPanel3.Location = new System.Drawing.Point(5, 5);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new System.Drawing.Size(380, 829);
            roundedPanel3.TabIndex = 0;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            roundedPanel2.Controls.Add(roundedPanel3);
            roundedPanel2.Dock = DockStyle.Right;
            roundedPanel2.ForeColor = System.Drawing.Color.White;
            roundedPanel2.Location = new System.Drawing.Point(844, 87);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Padding = new Padding(5, 5, 5, 12);
            roundedPanel2.Size = new System.Drawing.Size(390, 846);
            roundedPanel2.TabIndex = 16;
            // 
            // datetimePickerCustom1
            // 
            datetimePickerCustom1.BorderColor = System.Drawing.Color.FromArgb(154, 59, 59);
            datetimePickerCustom1.BorderSize = 3;
            datetimePickerCustom1.CustomFormat = "dddd , dd MMMM yyyy";
            datetimePickerCustom1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            datetimePickerCustom1.Location = new System.Drawing.Point(63, 4);
            datetimePickerCustom1.MinimumSize = new System.Drawing.Size(4, 50);
            datetimePickerCustom1.Name = "datetimePickerCustom1";
            datetimePickerCustom1.Size = new System.Drawing.Size(369, 50);
            datetimePickerCustom1.SkinColor = System.Drawing.Color.FromArgb(154, 59, 59);
            datetimePickerCustom1.TabIndex = 1;
            datetimePickerCustom1.TextColor = System.Drawing.Color.White;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.calender;
            pictureBox1.Location = new System.Drawing.Point(3, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(54, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = System.Drawing.Color.FromArgb(154, 59, 59);
            roundedPanel1.Controls.Add(datetimePickerCustom1);
            roundedPanel1.Controls.Add(pictureBox1);
            roundedPanel1.ForeColor = System.Drawing.Color.White;
            roundedPanel1.Location = new System.Drawing.Point(3, 15);
            roundedPanel1.Margin = new Padding(3, 15, 3, 3);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new System.Drawing.Size(377, 54);
            roundedPanel1.TabIndex = 5;
            // 
            // lbIndex
            // 
            lbIndex.AutoSize = true;
            lbIndex.BackColor = System.Drawing.Color.Transparent;
            lbIndex.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbIndex.ForeColor = System.Drawing.Color.White;
            lbIndex.Location = new System.Drawing.Point(10, 49);
            lbIndex.Name = "lbIndex";
            lbIndex.Size = new System.Drawing.Size(83, 20);
            lbIndex.TabIndex = 1;
            lbIndex.Text = "No. 00001";
            lbIndex.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = System.Drawing.Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            bigLabel1.ForeColor = System.Drawing.Color.White;
            bigLabel1.ImageAlign = ContentAlignment.MiddleLeft;
            bigLabel1.Location = new System.Drawing.Point(0, 0);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new System.Drawing.Size(276, 46);
            bigLabel1.TabIndex = 1;
            bigLabel1.Text = "Phiếu đặt thiết bị";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(roundedPanel1);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new System.Drawing.Point(842, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(392, 87);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            panel1.Controls.Add(lbIndex);
            panel1.Controls.Add(bigLabel1);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1234, 87);
            panel1.TabIndex = 15;
            // 
            // print_order
            // 
            print_order.PrintPage += print_order_PrintPage;
            // 
            // delayTimeDiscount
            // 
            delayTimeDiscount.Interval = 500;
            delayTimeDiscount.Tick += delayTimeDiscount_Tick;
            // 
            // PlaceOrderTC
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1234, 933);
            Controls.Add(panel3);
            Controls.Add(roundedPanel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "PlaceOrderTC";
            Text = "PlaceOrderTC";
            Load += PlaceOrderTC_Load;
            ((System.ComponentModel.ISupportInitialize)dgProducts).EndInit();
            roundedPanel11.ResumeLayout(false);
            roundedPanel9.ResumeLayout(false);
            roundedPanel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)filter).EndInit();
            roundedPanel10.ResumeLayout(false);
            roundedPanel10.PerformLayout();
            roundedPanel6.ResumeLayout(false);
            roundedPanel6.PerformLayout();
            roundedPanel13.ResumeLayout(false);
            roundedPanel13.PerformLayout();
            roundedPanel18.ResumeLayout(false);
            roundedPanel18.PerformLayout();
            roundedPanel7.ResumeLayout(false);
            roundedPanel7.PerformLayout();
            roundedPanel14.ResumeLayout(false);
            roundedPanel14.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            parrotGroupBox1.ResumeLayout(false);
            parrotGroupBox1.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            roundedPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgProducts;
        private DataGridViewTextBoxColumn id;
        private DataGridViewImageColumn barcode;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn total;
        private DataGridViewButtonColumn delete;
        private Helpers.UI.RoundedPanel roundedPanel11;
        private Helpers.UI.RoundedPanel roundedPanel9;
        private Helpers.UI.RJTextBox tbDiscount;
        private Label label5;
        private Panel panel8;
        private Panel panel3;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel5;
        private Helpers.UI.RJButton btnRenew;
        private Helpers.UI.RJButton rjButton1;
        private Panel panel6;
        private Helpers.UI.RJButton btnCanceled;
        private Panel panel7;
        private Helpers.UI.RJButton btnPrint;
        private Helpers.UI.RoundedPanel roundedPanel4;
        private Panel panel9;
        private Helpers.UI.RJTextBox tbSearch;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel2;
        private Helpers.UI.RoundedPanel roundedPanel10;
        private Helpers.UI.RJTextBox tbSurcharge;
        private Label label7;
        private Label label6;
        private Helpers.UI.RJButton btnSave;
        private Label label2;
        private Helpers.UI.RoundedPanel roundedPanel6;
        private ReaLTaiizor.Controls.MetroDivider metroDivider1;
        private Helpers.UI.RoundedPanel roundedPanel13;
        private Helpers.UI.RJTextBox tbDeposit;
        private Label label9;
        private Label label10;
        private Label label13;
        private Helpers.UI.RoundedPanel roundedPanel18;
        private Helpers.UI.DatetimePickerCustom datetimePickerCustom4;
        private Label label17;
        private Helpers.UI.RoundedPanel roundedPanel7;
        private Helpers.UI.DatetimePickerCustom dt_refundedTime;
        private Label label1;
        private Helpers.UI.RoundedPanel roundedPanel14;
        private Helpers.UI.RJTextBox tbTotal;
        private Label label12;
        private FlowLayoutPanel flowLayoutPanel2;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        private Helpers.UI.RJTextBox tbNote;
        private Helpers.UI.RoundedPanel roundedPanel3;
        private Helpers.UI.RoundedPanel roundedPanel2;
        private Helpers.UI.DatetimePickerCustom datetimePickerCustom1;
        private PictureBox pictureBox1;
        private Helpers.UI.RoundedPanel roundedPanel1;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lbIndex;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private System.Drawing.Printing.PrintDocument print_order;
        private FontAwesome.Sharp.IconPictureBox filter;
        private System.Windows.Forms.Timer delayTimeDiscount;
    }
}