using ABC_Bakery.Helpers.UI;

namespace ABC_Bakery.Forms
{
    partial class ProductNearMinimumForm
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductNearMinimumForm));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            pnProductBoundary = new Panel();
            roundedPanel2 = new Helpers.UI.RoundedPanel();
            dgvProduct = new DataGridView();
            stt = new DataGridViewTextBoxColumn();
            barcode = new DataGridViewImageColumn();
            name = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            pnProductBoundary.SuspendLayout();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            panel1.Controls.Add(bigLabel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(800, 68);
            panel1.TabIndex = 2;
            // 
            // bigLabel1
            // 
            bigLabel1.Anchor = AnchorStyles.None;
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = System.Drawing.Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            bigLabel1.ForeColor = System.Drawing.Color.White;
            bigLabel1.ImageAlign = ContentAlignment.MiddleLeft;
            bigLabel1.Location = new System.Drawing.Point(187, 21);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new System.Drawing.Size(442, 32);
            bigLabel1.TabIndex = 2;
            bigLabel1.Text = "DANH SÁCH SẢN PHẨM SẮP HẾT HẠN";
            // 
            // pnProductBoundary
            // 
            pnProductBoundary.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            pnProductBoundary.Controls.Add(roundedPanel2);
            pnProductBoundary.Dock = DockStyle.Fill;
            pnProductBoundary.Location = new System.Drawing.Point(0, 68);
            pnProductBoundary.Name = "pnProductBoundary";
            pnProductBoundary.Padding = new Padding(10);
            pnProductBoundary.Size = new System.Drawing.Size(800, 382);
            pnProductBoundary.TabIndex = 7;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = System.Drawing.Color.FromArgb(154, 59, 59);
            roundedPanel2.Controls.Add(dgvProduct);
            roundedPanel2.Dock = DockStyle.Fill;
            roundedPanel2.ForeColor = System.Drawing.Color.White;
            roundedPanel2.Location = new System.Drawing.Point(10, 10);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new System.Drawing.Size(780, 362);
            roundedPanel2.TabIndex = 0;
            // 
            // dgvProduct
            // 
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.BackgroundColor = System.Drawing.Color.FromArgb(255, 224, 192);
            dgvProduct.BorderStyle = BorderStyle.None;
            dgvProduct.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgvProduct.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgvProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(154, 59, 59);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProduct.ColumnHeadersHeight = 55;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProduct.Columns.AddRange(new DataGridViewColumn[] { stt, barcode, name, price, quantity, id });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvProduct.DefaultCellStyle = dataGridViewCellStyle5;
            dgvProduct.Dock = DockStyle.Fill;
            dgvProduct.EnableHeadersVisualStyles = false;
            dgvProduct.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
            dgvProduct.Location = new System.Drawing.Point(0, 0);
            dgvProduct.Margin = new Padding(0);
            dgvProduct.MultiSelect = false;
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvProduct.RowHeadersVisible = false;
            dgvProduct.RowHeadersWidth = 50;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(226, 199, 153);
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dgvProduct.RowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvProduct.RowTemplate.Height = 50;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.Size = new System.Drawing.Size(780, 362);
            dgvProduct.TabIndex = 5;
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
            dataGridViewCellStyle4.Padding = new Padding(0, 5, 0, 5);
            quantity.DefaultCellStyle = dataGridViewCellStyle4;
            quantity.HeaderText = "Số lượng";
            quantity.Name = "quantity";
            quantity.Resizable = DataGridViewTriState.True;
            quantity.SortMode = DataGridViewColumnSortMode.NotSortable;
            quantity.ToolTipText = "Số lượng";
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 5;
            // 
            // ProductNearMinimumForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(pnProductBoundary);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "ProductNearMinimumForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "`";
            Load += ProductNearMinimumForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnProductBoundary.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Panel pnProductBoundary;
        private RoundedPanel roundedPanel2;
        private DataGridView dgvProduct;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewImageColumn barcode;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn id;
    }
}