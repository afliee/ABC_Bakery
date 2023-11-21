using Color = System.Drawing.Color;
using Image = System.Drawing.Image;
using RectangleF = System.Drawing.RectangleF;
using Rectangle = System.Drawing.Rectangle;
using Size = System.Drawing.Size;
using Point = System.Drawing.Point;
using SizeF = System.Drawing.SizeF;

namespace ABC_Bakery.Forms
{
    partial class CreateProduct
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProduct));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            roundedPanel1 = new Helpers.UI.RoundedPanel();
            datetimePickerCustom1 = new Helpers.UI.DatetimePickerCustom();
            pictureBox1 = new PictureBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            roundedPanel4 = new Helpers.UI.RoundedPanel();
            panel9 = new Panel();
            tbSearch = new Helpers.UI.RJTextBox();
            pictureBox2 = new PictureBox();
            dungeonHeaderLabel2 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            pnProductBoundary = new Panel();
            roundedPanel2 = new Helpers.UI.RoundedPanel();
            dgProducts = new DataGridView();
            stt = new DataGridViewTextBoxColumn();
            barcode = new DataGridViewImageColumn();
            name = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            status = new DataGridViewCheckBoxColumn();
            delete = new DataGridViewButtonColumn();
            pnProducts = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            parrotGroupBox3 = new ReaLTaiizor.Controls.ParrotGroupBox();
            tbPrice = new Helpers.UI.RJTextBox();
            parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            tbName = new Helpers.UI.RJTextBox();
            parrotGroupBox2 = new ReaLTaiizor.Controls.ParrotGroupBox();
            roundedPanel3 = new Helpers.UI.RoundedPanel();
            cbCategory = new CustomControls.RJControls.RJComboBox();
            parrotGroupBox4 = new ReaLTaiizor.Controls.ParrotGroupBox();
            tbQuantity = new Helpers.UI.RJTextBox();
            roundedPanel5 = new Helpers.UI.RoundedPanel();
            parrotGroupBox5 = new ReaLTaiizor.Controls.ParrotGroupBox();
            tbDescription = new Helpers.UI.RJTextBox();
            btnSave = new Helpers.UI.RJButton();
            showProducts = new System.Windows.Forms.Timer(components);
            delayTextChanged = new System.Windows.Forms.Timer(components);
            error = new ErrorProvider(components);
            pnInfoBounary = new Helpers.UI.RoundedPanel();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            roundedPanel4.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnProductBoundary.SuspendLayout();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
            pnProducts.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            parrotGroupBox3.SuspendLayout();
            parrotGroupBox1.SuspendLayout();
            parrotGroupBox2.SuspendLayout();
            roundedPanel3.SuspendLayout();
            parrotGroupBox4.SuspendLayout();
            roundedPanel5.SuspendLayout();
            parrotGroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)error).BeginInit();
            pnInfoBounary.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel1.Controls.Add(bigLabel1);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1421, 116);
            panel1.TabIndex = 0;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.ImageAlign = ContentAlignment.MiddleLeft;
            bigLabel1.Location = new Point(0, 25);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(325, 57);
            bigLabel1.TabIndex = 2;
            bigLabel1.Text = "Thêm Sản Phẩm";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(roundedPanel1);
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(979, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(442, 116);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(154, 59, 59);
            roundedPanel1.Controls.Add(datetimePickerCustom1);
            roundedPanel1.Controls.Add(pictureBox1);
            roundedPanel1.ForeColor = Color.White;
            roundedPanel1.Location = new Point(3, 20);
            roundedPanel1.Margin = new Padding(3, 20, 3, 4);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(424, 72);
            roundedPanel1.TabIndex = 5;
            // 
            // datetimePickerCustom1
            // 
            datetimePickerCustom1.BorderColor = Color.FromArgb(154, 59, 59);
            datetimePickerCustom1.BorderSize = 3;
            datetimePickerCustom1.CustomFormat = "dddd , dd MMMM yyyy";
            datetimePickerCustom1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            datetimePickerCustom1.Location = new Point(72, 5);
            datetimePickerCustom1.Margin = new Padding(3, 4, 3, 4);
            datetimePickerCustom1.MinimumSize = new Size(4, 50);
            datetimePickerCustom1.Name = "datetimePickerCustom1";
            datetimePickerCustom1.Size = new Size(421, 50);
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
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(0, 0, 0, 0);
            flowLayoutPanel2.Dock = DockStyle.Right;
            flowLayoutPanel2.Location = new Point(1421, 116);
            flowLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(0, 973);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.FromArgb(242, 236, 190);
            roundedPanel4.Controls.Add(panel9);
            roundedPanel4.Controls.Add(dungeonHeaderLabel2);
            roundedPanel4.Dock = DockStyle.Top;
            roundedPanel4.ForeColor = Color.White;
            roundedPanel4.Location = new Point(11, 0);
            roundedPanel4.Margin = new Padding(3, 4, 3, 4);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(1399, 84);
            roundedPanel4.TabIndex = 3;
            // 
            // panel9
            // 
            panel9.Controls.Add(tbSearch);
            panel9.Controls.Add(pictureBox2);
            panel9.Dock = DockStyle.Right;
            panel9.Location = new Point(874, 0);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(525, 84);
            panel9.TabIndex = 4;
            // 
            // tbSearch
            // 
            tbSearch.BackColor = SystemColors.Window;
            tbSearch.BorderColor = Color.FromArgb(154, 59, 59);
            tbSearch.BorderFocusColor = Color.HotPink;
            tbSearch.BorderRadius = 10;
            tbSearch.BorderSize = 2;
            tbSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbSearch.ForeColor = Color.FromArgb(64, 64, 64);
            tbSearch.Location = new Point(89, 12);
            tbSearch.Margin = new Padding(5);
            tbSearch.Multiline = false;
            tbSearch.Name = "tbSearch";
            tbSearch.Padding = new Padding(11, 9, 11, 9);
            tbSearch.PasswordChar = false;
            tbSearch.PlaceholderColor = Color.DarkGray;
            tbSearch.PlaceholderText = "";
            tbSearch.Size = new Size(427, 60);
            tbSearch.TabIndex = 3;
            tbSearch.TextAlign = HorizontalAlignment.Left;
            tbSearch.Texts = "";
            tbSearch.UnderlinedStyle = false;
            tbSearch._TextChanged += tbSearch__TextChanged;
            tbSearch.Enter += tbSearch_Enter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.find;
            pictureBox2.Location = new Point(50, 23);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // dungeonHeaderLabel2
            // 
            dungeonHeaderLabel2.AutoSize = true;
            dungeonHeaderLabel2.BackColor = Color.Transparent;
            dungeonHeaderLabel2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dungeonHeaderLabel2.ForeColor = Color.FromArgb(76, 76, 77);
            dungeonHeaderLabel2.ImageAlign = ContentAlignment.MiddleLeft;
            dungeonHeaderLabel2.Location = new Point(3, 23);
            dungeonHeaderLabel2.Name = "dungeonHeaderLabel2";
            dungeonHeaderLabel2.Size = new Size(256, 37);
            dungeonHeaderLabel2.TabIndex = 1;
            dungeonHeaderLabel2.Text = "Sản phẩm đã thêm";
            // 
            // pnProductBoundary
            // 
            pnProductBoundary.Controls.Add(roundedPanel2);
            pnProductBoundary.Dock = DockStyle.Fill;
            pnProductBoundary.Location = new Point(11, 84);
            pnProductBoundary.Margin = new Padding(3, 4, 3, 4);
            pnProductBoundary.Name = "pnProductBoundary";
            pnProductBoundary.Padding = new Padding(0, 13, 0, 0);
            pnProductBoundary.Size = new Size(1399, 235);
            pnProductBoundary.TabIndex = 4;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.FromArgb(154, 59, 59);
            roundedPanel2.Controls.Add(dgProducts);
            roundedPanel2.Dock = DockStyle.Fill;
            roundedPanel2.ForeColor = Color.White;
            roundedPanel2.Location = new Point(0, 13);
            roundedPanel2.Margin = new Padding(3, 4, 3, 4);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(1399, 222);
            roundedPanel2.TabIndex = 0;
            // 
            // dgProducts
            // 
            dgProducts.AllowUserToAddRows = false;
            dgProducts.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgProducts.BorderStyle = BorderStyle.None;
            dgProducts.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgProducts.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgProducts.ColumnHeadersHeight = 55;
            dgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgProducts.Columns.AddRange(new DataGridViewColumn[] { stt, barcode, name, price, quantity, status, delete });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.RosyBrown;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgProducts.DefaultCellStyle = dataGridViewCellStyle5;
            dgProducts.Dock = DockStyle.Fill;
            dgProducts.EnableHeadersVisualStyles = false;
            dgProducts.GridColor = Color.FromArgb(224, 224, 224);
            dgProducts.Location = new Point(0, 0);
            dgProducts.Margin = new Padding(0);
            dgProducts.MultiSelect = false;
            dgProducts.Name = "dgProducts";
            dgProducts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgProducts.RowHeadersVisible = false;
            dgProducts.RowHeadersWidth = 50;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(226, 199, 153);
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dgProducts.RowsDefaultCellStyle = dataGridViewCellStyle7;
            dgProducts.RowTemplate.Height = 50;
            dgProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProducts.Size = new Size(1399, 222);
            dgProducts.TabIndex = 5;
            dgProducts.CellContentClick += dgProducts_CellContentClick;
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
            stt.HeaderText = "STT";
            stt.MinimumWidth = 6;
            stt.Name = "stt";
            stt.ReadOnly = true;
            stt.Resizable = DataGridViewTriState.True;
            stt.Width = 74;
            // 
            // barcode
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = resources.GetObject("dataGridViewCellStyle3.NullValue");
            dataGridViewCellStyle3.Padding = new Padding(5);
            barcode.DefaultCellStyle = dataGridViewCellStyle3;
            barcode.HeaderText = "Barcode";
            barcode.ImageLayout = DataGridViewImageCellLayout.Zoom;
            barcode.MinimumWidth = 6;
            barcode.Name = "barcode";
            barcode.ReadOnly = true;
            barcode.Width = 200;
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
            price.Width = 125;
            // 
            // quantity
            // 
            quantity.FillWeight = 4.35844231F;
            quantity.HeaderText = "Số lượng";
            quantity.MinimumWidth = 6;
            quantity.Name = "quantity";
            quantity.Width = 125;
            // 
            // status
            // 
            status.FillWeight = 10.3512993F;
            status.HeaderText = "Trạng Thái (Ẩn/ Hiện)";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.Resizable = DataGridViewTriState.True;
            status.SortMode = DataGridViewColumnSortMode.Automatic;
            status.Width = 200;
            // 
            // delete
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.Padding = new Padding(10);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            delete.DefaultCellStyle = dataGridViewCellStyle4;
            delete.FillWeight = 142.421158F;
            delete.HeaderText = "Xóa Sản Phẩm";
            delete.MinimumWidth = 6;
            delete.Name = "delete";
            delete.Resizable = DataGridViewTriState.True;
            delete.SortMode = DataGridViewColumnSortMode.Automatic;
            delete.Text = "Xóa";
            delete.ToolTipText = "Xóa sản phẩm";
            delete.UseColumnTextForButtonValue = true;
            delete.Width = 125;
            // 
            // pnProducts
            // 
            pnProducts.BackColor = Color.FromArgb(0, 0, 0, 0);
            pnProducts.Controls.Add(pnProductBoundary);
            pnProducts.Controls.Add(roundedPanel4);
            pnProducts.Dock = DockStyle.Top;
            pnProducts.Location = new Point(0, 116);
            pnProducts.Margin = new Padding(3, 4, 3, 4);
            pnProducts.Name = "pnProducts";
            pnProducts.Padding = new Padding(11, 0, 11, 0);
            pnProducts.Size = new Size(1421, 319);
            pnProducts.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(0, 0, 0, 0);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(parrotGroupBox3, 0, 1);
            tableLayoutPanel1.Controls.Add(parrotGroupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(parrotGroupBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(parrotGroupBox4, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(5, 5);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(11, 13, 11, 13);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 133F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 133F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1390, 283);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // parrotGroupBox3
            // 
            parrotGroupBox3.BorderColor = Color.FromArgb(0, 0, 0, 0);
            parrotGroupBox3.BorderWidth = 1;
            parrotGroupBox3.Controls.Add(tbPrice);
            parrotGroupBox3.Dock = DockStyle.Fill;
            parrotGroupBox3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            parrotGroupBox3.Location = new Point(14, 150);
            parrotGroupBox3.Margin = new Padding(3, 4, 3, 4);
            parrotGroupBox3.Name = "parrotGroupBox3";
            parrotGroupBox3.Padding = new Padding(3, 4, 3, 4);
            parrotGroupBox3.ShowText = true;
            parrotGroupBox3.Size = new Size(678, 125);
            parrotGroupBox3.TabIndex = 2;
            parrotGroupBox3.TabStop = false;
            parrotGroupBox3.Text = "Giá sản phẩm";
            parrotGroupBox3.TextColor = Color.White;
            // 
            // tbPrice
            // 
            tbPrice.BackColor = Color.FromArgb(255, 224, 192);
            tbPrice.BorderColor = Color.FromArgb(154, 59, 59);
            tbPrice.BorderFocusColor = Color.FromArgb(192, 130, 97);
            tbPrice.BorderRadius = 5;
            tbPrice.BorderSize = 2;
            tbPrice.Dock = DockStyle.Fill;
            tbPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbPrice.ForeColor = Color.FromArgb(64, 64, 64);
            tbPrice.Location = new Point(3, 40);
            tbPrice.Margin = new Padding(5);
            tbPrice.Multiline = true;
            tbPrice.Name = "tbPrice";
            tbPrice.Padding = new Padding(11, 9, 11, 9);
            tbPrice.PasswordChar = false;
            tbPrice.PlaceholderColor = Color.DarkGray;
            tbPrice.PlaceholderText = "Nhập giá tiền. VD: 10000 = 10.000VND";
            tbPrice.Size = new Size(672, 81);
            tbPrice.TabIndex = 1;
            tbPrice.TextAlign = HorizontalAlignment.Left;
            tbPrice.Texts = "";
            tbPrice.UnderlinedStyle = false;
            tbPrice._TextChanged += tbPrice__TextChanged;
            // 
            // parrotGroupBox1
            // 
            parrotGroupBox1.BorderColor = Color.FromArgb(0, 0, 0, 0);
            parrotGroupBox1.BorderWidth = 0;
            parrotGroupBox1.Controls.Add(tbName);
            parrotGroupBox1.Dock = DockStyle.Fill;
            parrotGroupBox1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            parrotGroupBox1.Location = new Point(14, 17);
            parrotGroupBox1.Margin = new Padding(3, 4, 3, 4);
            parrotGroupBox1.Name = "parrotGroupBox1";
            parrotGroupBox1.Padding = new Padding(3, 4, 3, 4);
            parrotGroupBox1.ShowText = true;
            parrotGroupBox1.Size = new Size(678, 125);
            parrotGroupBox1.TabIndex = 0;
            parrotGroupBox1.TabStop = false;
            parrotGroupBox1.Text = "Tên sản phẩm";
            parrotGroupBox1.TextColor = Color.White;
            // 
            // tbName
            // 
            tbName.BackColor = Color.FromArgb(255, 224, 192);
            tbName.BorderColor = Color.FromArgb(154, 59, 59);
            tbName.BorderFocusColor = Color.FromArgb(192, 130, 97);
            tbName.BorderRadius = 5;
            tbName.BorderSize = 2;
            tbName.Dock = DockStyle.Fill;
            tbName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbName.ForeColor = Color.FromArgb(64, 64, 64);
            tbName.Location = new Point(3, 40);
            tbName.Margin = new Padding(5);
            tbName.Multiline = true;
            tbName.Name = "tbName";
            tbName.Padding = new Padding(11, 9, 11, 9);
            tbName.PasswordChar = false;
            tbName.PlaceholderColor = Color.DarkGray;
            tbName.PlaceholderText = "Nhập tên sản phẩm";
            tbName.Size = new Size(672, 81);
            tbName.TabIndex = 1;
            tbName.TextAlign = HorizontalAlignment.Left;
            tbName.Texts = "";
            tbName.UnderlinedStyle = false;
            tbName._TextChanged += tbName__TextChanged;
            // 
            // parrotGroupBox2
            // 
            parrotGroupBox2.BorderColor = Color.FromArgb(0, 0, 0, 0);
            parrotGroupBox2.BorderWidth = 1;
            parrotGroupBox2.Controls.Add(roundedPanel3);
            parrotGroupBox2.Dock = DockStyle.Fill;
            parrotGroupBox2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            parrotGroupBox2.Location = new Point(698, 17);
            parrotGroupBox2.Margin = new Padding(3, 4, 3, 4);
            parrotGroupBox2.Name = "parrotGroupBox2";
            parrotGroupBox2.Padding = new Padding(3, 4, 3, 4);
            parrotGroupBox2.ShowText = true;
            parrotGroupBox2.Size = new Size(678, 125);
            parrotGroupBox2.TabIndex = 1;
            parrotGroupBox2.TabStop = false;
            parrotGroupBox2.Text = "Thể loại";
            parrotGroupBox2.TextColor = Color.White;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.FromArgb(0, 0, 0, 0);
            roundedPanel3.Controls.Add(cbCategory);
            roundedPanel3.Dock = DockStyle.Fill;
            roundedPanel3.ForeColor = Color.White;
            roundedPanel3.Location = new Point(3, 40);
            roundedPanel3.Margin = new Padding(3, 4, 3, 4);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(672, 81);
            roundedPanel3.TabIndex = 3;
            // 
            // cbCategory
            // 
            cbCategory.BackColor = Color.FromArgb(255, 224, 192);
            cbCategory.BorderColor = Color.FromArgb(154, 59, 59);
            cbCategory.BorderSize = 2;
            cbCategory.Dock = DockStyle.Fill;
            cbCategory.DropDownStyle = ComboBoxStyle.DropDown;
            cbCategory.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategory.ForeColor = Color.DimGray;
            cbCategory.IconColor = Color.MediumSlateBlue;
            cbCategory.ListBackColor = Color.FromArgb(230, 228, 245);
            cbCategory.ListTextColor = Color.DimGray;
            cbCategory.Location = new Point(0, 0);
            cbCategory.Margin = new Padding(3, 4, 3, 4);
            cbCategory.MinimumSize = new Size(229, 40);
            cbCategory.Name = "cbCategory";
            cbCategory.Padding = new Padding(2, 3, 2, 3);
            cbCategory.Size = new Size(672, 81);
            cbCategory.TabIndex = 0;
            cbCategory.Texts = "";
            // 
            // parrotGroupBox4
            // 
            parrotGroupBox4.BorderColor = Color.FromArgb(0, 0, 0, 0);
            parrotGroupBox4.BorderWidth = 1;
            parrotGroupBox4.Controls.Add(tbQuantity);
            parrotGroupBox4.Dock = DockStyle.Fill;
            parrotGroupBox4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            parrotGroupBox4.Location = new Point(698, 150);
            parrotGroupBox4.Margin = new Padding(3, 4, 3, 4);
            parrotGroupBox4.Name = "parrotGroupBox4";
            parrotGroupBox4.Padding = new Padding(3, 4, 3, 4);
            parrotGroupBox4.ShowText = true;
            parrotGroupBox4.Size = new Size(678, 125);
            parrotGroupBox4.TabIndex = 3;
            parrotGroupBox4.TabStop = false;
            parrotGroupBox4.Text = "Số lượng sản phẩm";
            parrotGroupBox4.TextColor = Color.White;
            // 
            // tbQuantity
            // 
            tbQuantity.BackColor = Color.FromArgb(255, 224, 192);
            tbQuantity.BorderColor = Color.FromArgb(154, 59, 59);
            tbQuantity.BorderFocusColor = Color.FromArgb(192, 130, 97);
            tbQuantity.BorderRadius = 5;
            tbQuantity.BorderSize = 2;
            tbQuantity.Dock = DockStyle.Fill;
            tbQuantity.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbQuantity.ForeColor = Color.FromArgb(64, 64, 64);
            tbQuantity.Location = new Point(3, 40);
            tbQuantity.Margin = new Padding(5);
            tbQuantity.Multiline = true;
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Padding = new Padding(11, 9, 11, 9);
            tbQuantity.PasswordChar = false;
            tbQuantity.PlaceholderColor = Color.DarkGray;
            tbQuantity.PlaceholderText = "Nhập số lượng sản phẩm";
            tbQuantity.Size = new Size(672, 81);
            tbQuantity.TabIndex = 1;
            tbQuantity.TextAlign = HorizontalAlignment.Left;
            tbQuantity.Texts = "";
            tbQuantity.UnderlinedStyle = false;
            tbQuantity._TextChanged += tbQuantity__TextChanged;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.FromArgb(0, 0, 0, 0);
            roundedPanel5.Controls.Add(parrotGroupBox5);
            roundedPanel5.Dock = DockStyle.Bottom;
            roundedPanel5.ForeColor = Color.White;
            roundedPanel5.Location = new Point(5, 283);
            roundedPanel5.Margin = new Padding(3, 4, 3, 4);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Padding = new Padding(11, 13, 11, 13);
            roundedPanel5.Size = new Size(1390, 235);
            roundedPanel5.TabIndex = 4;
            // 
            // parrotGroupBox5
            // 
            parrotGroupBox5.BorderColor = Color.FromArgb(0, 0, 0, 0);
            parrotGroupBox5.BorderWidth = 1;
            parrotGroupBox5.Controls.Add(tbDescription);
            parrotGroupBox5.Dock = DockStyle.Fill;
            parrotGroupBox5.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            parrotGroupBox5.Location = new Point(11, 13);
            parrotGroupBox5.Margin = new Padding(3, 4, 3, 4);
            parrotGroupBox5.Name = "parrotGroupBox5";
            parrotGroupBox5.Padding = new Padding(6, 7, 6, 7);
            parrotGroupBox5.ShowText = true;
            parrotGroupBox5.Size = new Size(1368, 209);
            parrotGroupBox5.TabIndex = 0;
            parrotGroupBox5.TabStop = false;
            parrotGroupBox5.Text = "Mô tả sản phẩm";
            parrotGroupBox5.TextColor = Color.White;
            // 
            // tbDescription
            // 
            tbDescription.BackColor = Color.FromArgb(255, 224, 192);
            tbDescription.BorderColor = Color.FromArgb(154, 59, 59);
            tbDescription.BorderFocusColor = Color.FromArgb(192, 130, 97);
            tbDescription.BorderRadius = 5;
            tbDescription.BorderSize = 2;
            tbDescription.Dock = DockStyle.Fill;
            tbDescription.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbDescription.ForeColor = Color.FromArgb(64, 64, 64);
            tbDescription.Location = new Point(6, 43);
            tbDescription.Margin = new Padding(5);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Padding = new Padding(11, 9, 11, 9);
            tbDescription.PasswordChar = false;
            tbDescription.PlaceholderColor = Color.DarkGray;
            tbDescription.PlaceholderText = "Nhập mô tả của sản phẩm";
            tbDescription.Size = new Size(1356, 159);
            tbDescription.TabIndex = 1;
            tbDescription.TextAlign = HorizontalAlignment.Left;
            tbDescription.Texts = "";
            tbDescription.UnderlinedStyle = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(154, 59, 59);
            btnSave.BackgroundColor = Color.FromArgb(154, 59, 59);
            btnSave.BorderColor = Color.PaleVioletRed;
            btnSave.BorderRadius = 5;
            btnSave.BorderSize = 0;
            btnSave.Dock = DockStyle.Bottom;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(0, 1016);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(1421, 73);
            btnSave.TabIndex = 5;
            btnSave.Text = "LƯU THÔNG TIN SẢN PHẨM";
            btnSave.TextColor = Color.White;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // showProducts
            // 
            showProducts.Interval = 3;
            showProducts.Tick += showProducts_Tick;
            // 
            // delayTextChanged
            // 
            delayTextChanged.Interval = 500;
            delayTextChanged.Tick += delayTextChanged_Tick;
            // 
            // error
            // 
            error.ContainerControl = this;
            // 
            // pnInfoBounary
            // 
            pnInfoBounary.AutoScroll = true;
            pnInfoBounary.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnInfoBounary.BackColor = Color.FromArgb(0, 0, 0, 0);
            pnInfoBounary.Controls.Add(tableLayoutPanel1);
            pnInfoBounary.Controls.Add(roundedPanel5);
            pnInfoBounary.Dock = DockStyle.Top;
            pnInfoBounary.ForeColor = Color.White;
            pnInfoBounary.Location = new Point(0, 435);
            pnInfoBounary.Name = "pnInfoBounary";
            pnInfoBounary.Padding = new Padding(5);
            pnInfoBounary.Size = new Size(1421, 465);
            pnInfoBounary.TabIndex = 6;
            // 
            // CreateProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1421, 1089);
            Controls.Add(pnInfoBounary);
            Controls.Add(btnSave);
            Controls.Add(pnProducts);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreateProduct";
            Text = "CreateProduct";
            Load += CreateProduct_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnProductBoundary.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgProducts).EndInit();
            pnProducts.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            parrotGroupBox3.ResumeLayout(false);
            parrotGroupBox1.ResumeLayout(false);
            parrotGroupBox1.PerformLayout();
            parrotGroupBox2.ResumeLayout(false);
            parrotGroupBox2.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            parrotGroupBox4.ResumeLayout(false);
            roundedPanel5.ResumeLayout(false);
            parrotGroupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)error).EndInit();
            pnInfoBounary.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Helpers.UI.RoundedPanel roundedPanel1;
        private Helpers.UI.DatetimePickerCustom datetimePickerCustom1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Helpers.UI.RoundedPanel roundedPanel4;
        private Panel panel9;
        private Helpers.UI.RJTextBox tbSearch;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel2;
        private Panel pnProductBoundary;
        private Helpers.UI.RoundedPanel roundedPanel2;
        private DataGridView dgProducts;
        private Panel pnProducts;
        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        private Helpers.UI.RJTextBox tbName;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox2;
        private Helpers.UI.RoundedPanel roundedPanel3;
        private CustomControls.RJControls.RJComboBox cbCategory;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox3;
        private Helpers.UI.RJTextBox tbPrice;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox4;
        private Helpers.UI.RJTextBox tbQuantity;
        private Helpers.UI.RoundedPanel roundedPanel5;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox5;
        private Helpers.UI.RJTextBox tbDescription;
        private Helpers.UI.RJButton btnSave;
        private System.Windows.Forms.Timer showProducts;
        private System.Windows.Forms.Timer delayTextChanged;
        private ErrorProvider error;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewImageColumn barcode;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewCheckBoxColumn status;
        private DataGridViewButtonColumn delete;
        private Helpers.UI.RoundedPanel pnInfoBounary;
    }
}