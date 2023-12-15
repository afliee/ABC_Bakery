using ABC_Bakery.Helpers.UI;

namespace ABC_Bakery.Forms
{
    partial class CreateCategory
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel9 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            tbSearch = new Helpers.UI.RJTextBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            tbName = new Helpers.UI.RJTextBox();
            roundedPanel1 = new Helpers.UI.RoundedPanel();
            btnClose = new ReaLTaiizor.Controls.RibbonButtonLeft();
            btnSave = new ReaLTaiizor.Controls.RibbonButtonRight();
            roundedPanel2 = new Helpers.UI.RoundedPanel();
            dgProducts = new DataGridView();
            stt = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            delete = new DataGridViewButtonColumn();
            delayTextChanged = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            parrotGroupBox1.SuspendLayout();
            roundedPanel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
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
            panel1.Size = new System.Drawing.Size(862, 68);
            panel1.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.Controls.Add(iconPictureBox1);
            panel9.Controls.Add(tbSearch);
            panel9.Dock = DockStyle.Right;
            panel9.Location = new System.Drawing.Point(403, 0);
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
            bigLabel1.Anchor = AnchorStyles.None;
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = System.Drawing.Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            bigLabel1.ForeColor = System.Drawing.Color.White;
            bigLabel1.ImageAlign = ContentAlignment.MiddleLeft;
            bigLabel1.Location = new System.Drawing.Point(3, 19);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new System.Drawing.Size(289, 32);
            bigLabel1.TabIndex = 2;
            bigLabel1.Text = "DANH SÁCH DANH MỤC";
            // 
            // parrotGroupBox1
            // 
            parrotGroupBox1.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            parrotGroupBox1.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            parrotGroupBox1.BorderWidth = 0;
            parrotGroupBox1.Controls.Add(tbName);
            parrotGroupBox1.Dock = DockStyle.Top;
            parrotGroupBox1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            parrotGroupBox1.Location = new System.Drawing.Point(0, 68);
            parrotGroupBox1.Name = "parrotGroupBox1";
            parrotGroupBox1.ShowText = true;
            parrotGroupBox1.Size = new System.Drawing.Size(862, 94);
            parrotGroupBox1.TabIndex = 3;
            parrotGroupBox1.TabStop = false;
            parrotGroupBox1.Text = "Tên danh mục";
            parrotGroupBox1.TextColor = System.Drawing.Color.White;
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
            tbName.PlaceholderText = "Nhập tên danh mục";
            tbName.Size = new System.Drawing.Size(856, 59);
            tbName.TabIndex = 1;
            tbName.TextAlign = HorizontalAlignment.Left;
            tbName.Texts = "";
            tbName.UnderlinedStyle = false;
            tbName._TextChanged += tbName__TextChanged;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            roundedPanel1.Controls.Add(btnClose);
            roundedPanel1.Controls.Add(btnSave);
            roundedPanel1.Dock = DockStyle.Top;
            roundedPanel1.ForeColor = System.Drawing.Color.White;
            roundedPanel1.Location = new System.Drawing.Point(0, 162);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Padding = new Padding(5);
            roundedPanel1.Size = new System.Drawing.Size(862, 56);
            roundedPanel1.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.Transparent;
            btnClose.BaseColorA = System.Drawing.Color.FromArgb(203, 201, 205);
            btnClose.BaseColorB = System.Drawing.Color.FromArgb(188, 186, 190);
            btnClose.BorderColorA = System.Drawing.Color.FromArgb(117, 120, 117);
            btnClose.BorderColorB = System.Drawing.Color.FromArgb(75, 255, 255, 255);
            btnClose.DownBaseColorA = System.Drawing.Color.FromArgb(203, 201, 205);
            btnClose.DownBaseColorB = System.Drawing.Color.FromArgb(188, 186, 190);
            btnClose.DownBorderColorA = System.Drawing.Color.FromArgb(117, 120, 117);
            btnClose.DownBorderColorB = System.Drawing.Color.FromArgb(75, 255, 255, 255);
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            btnClose.HoverBaseColorA = System.Drawing.Color.FromArgb(193, 191, 195);
            btnClose.HoverBaseColorB = System.Drawing.Color.FromArgb(194, 192, 196);
            btnClose.HoverBorderColorA = System.Drawing.Color.FromArgb(117, 120, 117);
            btnClose.HoverBorderColorB = System.Drawing.Color.FromArgb(75, 255, 255, 255);
            btnClose.Location = new System.Drawing.Point(481, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(185, 40);
            btnClose.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnClose.TabIndex = 3;
            btnClose.Text = "Thoát";
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.Transparent;
            btnSave.BaseColorA = System.Drawing.Color.FromArgb(123, 190, 216);
            btnSave.BaseColorB = System.Drawing.Color.FromArgb(108, 175, 201);
            btnSave.BorderColorA = System.Drawing.Color.FromArgb(60, 113, 132);
            btnSave.BorderColorB = System.Drawing.Color.FromArgb(75, 255, 255, 255);
            btnSave.DownBaseColorA = System.Drawing.Color.FromArgb(123, 190, 216);
            btnSave.DownBaseColorB = System.Drawing.Color.FromArgb(108, 175, 201);
            btnSave.DownBorderColorA = System.Drawing.Color.FromArgb(60, 113, 132);
            btnSave.DownBorderColorB = System.Drawing.Color.FromArgb(75, 255, 255, 255);
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = System.Drawing.Color.Black;
            btnSave.HoverBaseColorA = System.Drawing.Color.FromArgb(113, 180, 206);
            btnSave.HoverBaseColorB = System.Drawing.Color.FromArgb(114, 181, 207);
            btnSave.HoverBorderColorA = System.Drawing.Color.FromArgb(60, 113, 132);
            btnSave.HoverBorderColorB = System.Drawing.Color.FromArgb(75, 255, 255, 255);
            btnSave.Location = new System.Drawing.Point(672, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(187, 40);
            btnSave.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSave.TabIndex = 2;
            btnSave.Text = "Lưu thông tin";
            btnSave.Click += btnSave_Click;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            roundedPanel2.Controls.Add(dgProducts);
            roundedPanel2.Dock = DockStyle.Fill;
            roundedPanel2.ForeColor = System.Drawing.Color.White;
            roundedPanel2.Location = new System.Drawing.Point(0, 218);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new System.Drawing.Size(862, 275);
            roundedPanel2.TabIndex = 5;
            // 
            // dgProducts
            // 
            dgProducts.AllowUserToAddRows = false;
            dgProducts.BackgroundColor = System.Drawing.Color.FromArgb(255, 224, 192);
            dgProducts.BorderStyle = BorderStyle.None;
            dgProducts.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgProducts.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgProducts.ColumnHeadersHeight = 55;
            dgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgProducts.Columns.AddRange(new DataGridViewColumn[] { stt, name, delete });
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
            dgProducts.Size = new System.Drawing.Size(862, 275);
            dgProducts.TabIndex = 6;
            // 
            // stt
            // 
            stt.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            stt.DefaultCellStyle = dataGridViewCellStyle8;
            stt.HeaderText = "STT";
            stt.MinimumWidth = 6;
            stt.Name = "stt";
            stt.ReadOnly = true;
            stt.Resizable = DataGridViewTriState.True;
            stt.Width = 60;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.FillWeight = 28.3298721F;
            name.HeaderText = "Tên Sản Phẩm";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // delete
            // 
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Padding = new Padding(5);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            delete.DefaultCellStyle = dataGridViewCellStyle9;
            delete.FillWeight = 142.421158F;
            delete.HeaderText = "Xóa Sản Phẩm";
            delete.MinimumWidth = 6;
            delete.Name = "delete";
            delete.Resizable = DataGridViewTriState.True;
            delete.SortMode = DataGridViewColumnSortMode.Automatic;
            delete.Text = "Xóa";
            delete.ToolTipText = "Xóa sản phẩm";
            delete.UseColumnTextForButtonValue = true;
            delete.Width = 200;
            // 
            // delayTextChanged
            // 
            delayTextChanged.Interval = 500;
            delayTextChanged.Tick += delayTextChanged_Tick;
            // 
            // CreateCategory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(862, 493);
            Controls.Add(roundedPanel2);
            Controls.Add(roundedPanel1);
            Controls.Add(parrotGroupBox1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "CreateCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateCategory";
            Load += CreateCategory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            parrotGroupBox1.ResumeLayout(false);
            parrotGroupBox1.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel9;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Helpers.UI.RJTextBox tbSearch;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        private Helpers.UI.RJTextBox tbName;
        private RoundedPanel roundedPanel1;
        private ReaLTaiizor.Controls.RibbonButtonLeft btnClose;
        private ReaLTaiizor.Controls.RibbonButtonRight btnSave;
        private RoundedPanel roundedPanel2;
        private DataGridView dgProducts;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn name;
        private DataGridViewButtonColumn delete;
        private System.Windows.Forms.Timer delayTextChanged;
    }
}