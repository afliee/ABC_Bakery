namespace ABC_Bakery.Forms
{
    partial class PromotionForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel9 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            tbSearch = new Helpers.UI.RJTextBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            tbCode = new Helpers.UI.RJTextBox();
            table_infor = new TableLayoutPanel();
            parrotGroupBox4 = new ReaLTaiizor.Controls.ParrotGroupBox();
            tbName = new Helpers.UI.RJTextBox();
            parrotGroupBox3 = new ReaLTaiizor.Controls.ParrotGroupBox();
            roundedPanel1 = new Helpers.UI.RoundedPanel();
            dt_date = new Helpers.UI.DatetimePickerCustom();
            parrotGroupBox2 = new ReaLTaiizor.Controls.ParrotGroupBox();
            tbRatio = new Helpers.UI.RJTextBox();
            tooltip = new ReaLTaiizor.Controls.PoisonToolTip();
            btnSave = new Helpers.UI.RJButton();
            pnProductBoundary = new Panel();
            roundedPanel2 = new Helpers.UI.RoundedPanel();
            dgPromotions = new DataGridView();
            stt = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            ratio = new DataGridViewTextBoxColumn();
            date_expiration = new DataGridViewTextBoxColumn();
            status = new DataGridViewCheckBoxColumn();
            cb_select = new DataGridViewButtonColumn();
            id = new DataGridViewTextBoxColumn();
            delayTextChanged = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            parrotGroupBox1.SuspendLayout();
            table_infor.SuspendLayout();
            parrotGroupBox4.SuspendLayout();
            parrotGroupBox3.SuspendLayout();
            roundedPanel1.SuspendLayout();
            parrotGroupBox2.SuspendLayout();
            pnProductBoundary.SuspendLayout();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPromotions).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(bigLabel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1150, 68);
            panel1.TabIndex = 3;
            // 
            // panel9
            // 
            panel9.Controls.Add(iconPictureBox1);
            panel9.Controls.Add(tbSearch);
            panel9.Dock = DockStyle.Right;
            panel9.Location = new System.Drawing.Point(691, 0);
            panel9.Name = "panel9";
            panel9.Size = new System.Drawing.Size(459, 68);
            panel9.TabIndex = 5;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.FilterCircleDollar;
            iconPictureBox1.IconColor = System.Drawing.Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new System.Drawing.Point(27, 19);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            iconPictureBox1.TabIndex = 4;
            iconPictureBox1.TabStop = false;
            // 
            // tbSearch
            // 
            tbSearch.BackColor = SystemColors.Window;
            tbSearch.BorderColor = System.Drawing.Color.FromArgb(154, 59, 59);
            tbSearch.BorderFocusColor = System.Drawing.Color.HotPink;
            tbSearch.BorderRadius = 10;
            tbSearch.BorderSize = 2;
            tbSearch.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbSearch.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            tbSearch.Location = new System.Drawing.Point(78, 9);
            tbSearch.Margin = new Padding(4);
            tbSearch.Multiline = false;
            tbSearch.Name = "tbSearch";
            tbSearch.Padding = new Padding(10, 7, 10, 7);
            tbSearch.PasswordChar = false;
            tbSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            tbSearch.PlaceholderText = "Tìm kiếm tại đây";
            tbSearch.Size = new System.Drawing.Size(374, 47);
            tbSearch.TabIndex = 3;
            tbSearch.TextAlign = HorizontalAlignment.Left;
            tbSearch.Texts = "";
            tbSearch.UnderlinedStyle = false;
            tbSearch._TextChanged += tbSearch__TextChanged;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = System.Drawing.Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            bigLabel1.ForeColor = System.Drawing.Color.White;
            bigLabel1.ImageAlign = ContentAlignment.MiddleLeft;
            bigLabel1.Location = new System.Drawing.Point(3, 19);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new System.Drawing.Size(350, 32);
            bigLabel1.TabIndex = 2;
            bigLabel1.Text = "DANH SÁCH MÃ KHUYẾN MÃI";
            // 
            // parrotGroupBox1
            // 
            parrotGroupBox1.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            parrotGroupBox1.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            parrotGroupBox1.BorderWidth = 0;
            parrotGroupBox1.Controls.Add(tbCode);
            parrotGroupBox1.Dock = DockStyle.Fill;
            parrotGroupBox1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            parrotGroupBox1.Location = new System.Drawing.Point(3, 3);
            parrotGroupBox1.Name = "parrotGroupBox1";
            parrotGroupBox1.ShowText = true;
            parrotGroupBox1.Size = new System.Drawing.Size(569, 99);
            parrotGroupBox1.TabIndex = 4;
            parrotGroupBox1.TabStop = false;
            parrotGroupBox1.Text = "Mã Khuyến Mãi";
            parrotGroupBox1.TextColor = System.Drawing.Color.White;
            // 
            // tbCode
            // 
            tbCode.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            tbCode.BorderColor = System.Drawing.Color.FromArgb(154, 59, 59);
            tbCode.BorderFocusColor = System.Drawing.Color.FromArgb(192, 130, 97);
            tbCode.BorderRadius = 5;
            tbCode.BorderSize = 2;
            tbCode.Dock = DockStyle.Fill;
            tbCode.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbCode.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            tbCode.Location = new System.Drawing.Point(3, 32);
            tbCode.Margin = new Padding(4);
            tbCode.Multiline = true;
            tbCode.Name = "tbCode";
            tbCode.Padding = new Padding(10, 7, 10, 7);
            tbCode.PasswordChar = false;
            tbCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            tbCode.PlaceholderText = "Nhập mã khuyến mãi (tất cả nên được viết hoa)";
            tbCode.Size = new System.Drawing.Size(563, 64);
            tbCode.TabIndex = 1;
            tbCode.TextAlign = HorizontalAlignment.Left;
            tbCode.Texts = "";
            tbCode.UnderlinedStyle = false;
            tbCode._TextChanged += tbCode__TextChanged;
            tbCode.MouseMove += tbCode_MouseMove;
            // 
            // table_infor
            // 
            table_infor.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            table_infor.ColumnCount = 2;
            table_infor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            table_infor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            table_infor.Controls.Add(parrotGroupBox4, 0, 1);
            table_infor.Controls.Add(parrotGroupBox3, 0, 1);
            table_infor.Controls.Add(parrotGroupBox2, 1, 0);
            table_infor.Controls.Add(parrotGroupBox1, 0, 0);
            table_infor.Dock = DockStyle.Top;
            table_infor.Location = new System.Drawing.Point(0, 68);
            table_infor.Name = "table_infor";
            table_infor.RowCount = 2;
            table_infor.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table_infor.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            table_infor.Size = new System.Drawing.Size(1150, 210);
            table_infor.TabIndex = 5;
            // 
            // parrotGroupBox4
            // 
            parrotGroupBox4.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            parrotGroupBox4.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            parrotGroupBox4.BorderWidth = 0;
            parrotGroupBox4.Controls.Add(tbName);
            parrotGroupBox4.Dock = DockStyle.Fill;
            parrotGroupBox4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            parrotGroupBox4.Location = new System.Drawing.Point(3, 108);
            parrotGroupBox4.Name = "parrotGroupBox4";
            parrotGroupBox4.ShowText = true;
            parrotGroupBox4.Size = new System.Drawing.Size(569, 99);
            parrotGroupBox4.TabIndex = 7;
            parrotGroupBox4.TabStop = false;
            parrotGroupBox4.Text = "Tên mô tả ngắn";
            parrotGroupBox4.TextColor = System.Drawing.Color.White;
            // 
            // tbName
            // 
            tbName.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            tbName.BorderColor = System.Drawing.Color.FromArgb(154, 59, 59);
            tbName.BorderFocusColor = System.Drawing.Color.FromArgb(192, 130, 97);
            tbName.BorderRadius = 5;
            tbName.BorderSize = 2;
            tbName.Dock = DockStyle.Fill;
            tbName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbName.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            tbName.Location = new System.Drawing.Point(3, 32);
            tbName.Margin = new Padding(4);
            tbName.Multiline = true;
            tbName.Name = "tbName";
            tbName.Padding = new Padding(10, 7, 10, 7);
            tbName.PasswordChar = false;
            tbName.PlaceholderColor = System.Drawing.Color.DarkGray;
            tbName.PlaceholderText = "Nhập tên mô tả";
            tbName.Size = new System.Drawing.Size(563, 64);
            tbName.TabIndex = 1;
            tbName.TextAlign = HorizontalAlignment.Left;
            tbName.Texts = "";
            tbName.UnderlinedStyle = false;
            tbName._TextChanged += tbName__TextChanged;
            tbName.MouseMove += tbName_MouseMove;
            // 
            // parrotGroupBox3
            // 
            parrotGroupBox3.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            parrotGroupBox3.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            parrotGroupBox3.BorderWidth = 0;
            parrotGroupBox3.Controls.Add(roundedPanel1);
            parrotGroupBox3.Dock = DockStyle.Fill;
            parrotGroupBox3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            parrotGroupBox3.Location = new System.Drawing.Point(578, 108);
            parrotGroupBox3.Name = "parrotGroupBox3";
            parrotGroupBox3.ShowText = true;
            parrotGroupBox3.Size = new System.Drawing.Size(569, 99);
            parrotGroupBox3.TabIndex = 6;
            parrotGroupBox3.TabStop = false;
            parrotGroupBox3.Text = "Ngày hết hạn";
            parrotGroupBox3.TextColor = System.Drawing.Color.White;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            roundedPanel1.Controls.Add(dt_date);
            roundedPanel1.Dock = DockStyle.Fill;
            roundedPanel1.ForeColor = System.Drawing.Color.White;
            roundedPanel1.Location = new System.Drawing.Point(3, 32);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new System.Drawing.Size(563, 64);
            roundedPanel1.TabIndex = 3;
            // 
            // dt_date
            // 
            dt_date.BorderColor = System.Drawing.Color.FromArgb(154, 59, 59);
            dt_date.BorderSize = 0;
            dt_date.CalendarFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dt_date.CustomFormat = "dddd , dd MMMM yyyy";
            dt_date.Dock = DockStyle.Bottom;
            dt_date.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dt_date.Location = new System.Drawing.Point(0, 14);
            dt_date.MinimumSize = new System.Drawing.Size(4, 50);
            dt_date.Name = "dt_date";
            dt_date.Size = new System.Drawing.Size(563, 50);
            dt_date.SkinColor = System.Drawing.Color.FromArgb(255, 224, 192);
            dt_date.TabIndex = 5;
            dt_date.TextColor = System.Drawing.Color.DarkGray;
            // 
            // parrotGroupBox2
            // 
            parrotGroupBox2.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            parrotGroupBox2.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            parrotGroupBox2.BorderWidth = 0;
            parrotGroupBox2.Controls.Add(tbRatio);
            parrotGroupBox2.Dock = DockStyle.Fill;
            parrotGroupBox2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            parrotGroupBox2.Location = new System.Drawing.Point(578, 3);
            parrotGroupBox2.Name = "parrotGroupBox2";
            parrotGroupBox2.ShowText = true;
            parrotGroupBox2.Size = new System.Drawing.Size(569, 99);
            parrotGroupBox2.TabIndex = 5;
            parrotGroupBox2.TabStop = false;
            parrotGroupBox2.Text = "Tỉ lệ khuyến mãi";
            parrotGroupBox2.TextColor = System.Drawing.Color.White;
            // 
            // tbRatio
            // 
            tbRatio.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            tbRatio.BorderColor = System.Drawing.Color.FromArgb(154, 59, 59);
            tbRatio.BorderFocusColor = System.Drawing.Color.FromArgb(192, 130, 97);
            tbRatio.BorderRadius = 5;
            tbRatio.BorderSize = 2;
            tbRatio.Dock = DockStyle.Fill;
            tbRatio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbRatio.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            tbRatio.Location = new System.Drawing.Point(3, 32);
            tbRatio.Margin = new Padding(4);
            tbRatio.Multiline = true;
            tbRatio.Name = "tbRatio";
            tbRatio.Padding = new Padding(10, 7, 10, 7);
            tbRatio.PasswordChar = false;
            tbRatio.PlaceholderColor = System.Drawing.Color.DarkGray;
            tbRatio.PlaceholderText = "Nhập tỉ lệ khuyến mãi (0 đến 100)";
            tbRatio.Size = new System.Drawing.Size(563, 64);
            tbRatio.TabIndex = 1;
            tbRatio.TextAlign = HorizontalAlignment.Left;
            tbRatio.Texts = "";
            tbRatio.UnderlinedStyle = false;
            tbRatio._TextChanged += tbRatio__TextChanged;
            tbRatio.MouseMove += tbRatio_MouseMove;
            // 
            // tooltip
            // 
            tooltip.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            tooltip.StyleManager = null;
            tooltip.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
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
            btnSave.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(0, 669);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(1150, 55);
            btnSave.TabIndex = 8;
            btnSave.Text = "LƯU THÔNG TIN KHUYẾN MÃI";
            btnSave.TextColor = System.Drawing.Color.White;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // pnProductBoundary
            // 
            pnProductBoundary.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            pnProductBoundary.Controls.Add(roundedPanel2);
            pnProductBoundary.Dock = DockStyle.Fill;
            pnProductBoundary.Location = new System.Drawing.Point(0, 278);
            pnProductBoundary.Name = "pnProductBoundary";
            pnProductBoundary.Padding = new Padding(10);
            pnProductBoundary.Size = new System.Drawing.Size(1150, 391);
            pnProductBoundary.TabIndex = 9;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = System.Drawing.Color.FromArgb(154, 59, 59);
            roundedPanel2.Controls.Add(dgPromotions);
            roundedPanel2.Dock = DockStyle.Fill;
            roundedPanel2.ForeColor = System.Drawing.Color.White;
            roundedPanel2.Location = new System.Drawing.Point(10, 10);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new System.Drawing.Size(1130, 371);
            roundedPanel2.TabIndex = 0;
            // 
            // dgPromotions
            // 
            dgPromotions.AllowUserToAddRows = false;
            dgPromotions.BackgroundColor = System.Drawing.Color.FromArgb(255, 224, 192);
            dgPromotions.BorderStyle = BorderStyle.None;
            dgPromotions.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgPromotions.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgPromotions.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgPromotions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgPromotions.ColumnHeadersHeight = 55;
            dgPromotions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgPromotions.Columns.AddRange(new DataGridViewColumn[] { stt, name, price, ratio, date_expiration, status, cb_select, id });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgPromotions.DefaultCellStyle = dataGridViewCellStyle5;
            dgPromotions.Dock = DockStyle.Fill;
            dgPromotions.EnableHeadersVisualStyles = false;
            dgPromotions.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
            dgPromotions.Location = new System.Drawing.Point(0, 0);
            dgPromotions.Margin = new Padding(0);
            dgPromotions.MultiSelect = false;
            dgPromotions.Name = "dgPromotions";
            dgPromotions.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgPromotions.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgPromotions.RowHeadersVisible = false;
            dgPromotions.RowHeadersWidth = 50;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(226, 199, 153);
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dgPromotions.RowsDefaultCellStyle = dataGridViewCellStyle7;
            dgPromotions.RowTemplate.Height = 50;
            dgPromotions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPromotions.Size = new System.Drawing.Size(1130, 371);
            dgPromotions.TabIndex = 5;
            dgPromotions.CellContentClick += dgPromotions_CellContentClick;
            // 
            // stt
            // 
            stt.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            stt.DefaultCellStyle = dataGridViewCellStyle2;
            stt.HeaderText = "STT";
            stt.MinimumWidth = 6;
            stt.Name = "stt";
            stt.ReadOnly = true;
            stt.Resizable = DataGridViewTriState.True;
            stt.Width = 65;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.FillWeight = 28.3298721F;
            name.HeaderText = "Tên Mô Tả";
            name.MinimumWidth = 6;
            name.Name = "name";
            // 
            // price
            // 
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            price.DefaultCellStyle = dataGridViewCellStyle3;
            price.FillWeight = 4.35844231F;
            price.HeaderText = "Mã Khuyến Mãi";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.Width = 200;
            // 
            // ratio
            // 
            ratio.HeaderText = "Tỉ lệ KM";
            ratio.Name = "ratio";
            ratio.Width = 150;
            // 
            // date_expiration
            // 
            date_expiration.HeaderText = "Ngày Hết Hạn";
            date_expiration.Name = "date_expiration";
            date_expiration.ReadOnly = true;
            date_expiration.Width = 200;
            // 
            // status
            // 
            status.HeaderText = "Hiển/ Ẩn";
            status.Name = "status";
            status.Resizable = DataGridViewTriState.True;
            status.SortMode = DataGridViewColumnSortMode.Automatic;
            status.Width = 150;
            // 
            // cb_select
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Padding = new Padding(0, 5, 0, 5);
            cb_select.DefaultCellStyle = dataGridViewCellStyle4;
            cb_select.HeaderText = "Chọn";
            cb_select.Name = "cb_select";
            cb_select.Resizable = DataGridViewTriState.True;
            cb_select.Text = "Chọn";
            cb_select.ToolTipText = "Chọn";
            cb_select.UseColumnTextForButtonValue = true;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 5;
            // 
            // delayTextChanged
            // 
            delayTextChanged.Interval = 500;
            delayTextChanged.Tick += delayTextChanged_Tick;
            // 
            // PromotionForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1150, 724);
            Controls.Add(pnProductBoundary);
            Controls.Add(btnSave);
            Controls.Add(table_infor);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "PromotionForm";
            Text = "PromotionForm";
            Load += PromotionForm_Load;
            Shown += PromotionForm_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            parrotGroupBox1.ResumeLayout(false);
            parrotGroupBox1.PerformLayout();
            table_infor.ResumeLayout(false);
            parrotGroupBox4.ResumeLayout(false);
            parrotGroupBox4.PerformLayout();
            parrotGroupBox3.ResumeLayout(false);
            parrotGroupBox3.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            parrotGroupBox2.ResumeLayout(false);
            parrotGroupBox2.PerformLayout();
            pnProductBoundary.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgPromotions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel9;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Helpers.UI.RJTextBox tbSearch;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        private Helpers.UI.RJTextBox tbCode;
        private TableLayoutPanel table_infor;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox2;
        private Helpers.UI.RJTextBox tbRatio;
        private ReaLTaiizor.Controls.PoisonToolTip tooltip;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox4;
        private Helpers.UI.RJTextBox tbName;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox3;
        private Helpers.UI.RoundedPanel roundedPanel1;
        private Helpers.UI.RJButton btnSave;
        private Helpers.UI.DatetimePickerCustom dt_date;
        private Panel pnProductBoundary;
        private Helpers.UI.RoundedPanel roundedPanel2;
        private DataGridView dgPromotions;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn ratio;
        private DataGridViewTextBoxColumn date_expiration;
        private DataGridViewCheckBoxColumn status;
        private DataGridViewButtonColumn cb_select;
        private DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Timer delayTextChanged;
    }
}