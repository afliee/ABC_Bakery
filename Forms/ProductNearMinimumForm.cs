using ABC_Bakery.Helpers.Utils;
using ABC_Bakery.Models;
using ABC_Bakery.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Image = System.Drawing.Image;
namespace ABC_Bakery.Forms
{
    public partial class ProductNearMinimumForm : Form
    {
        private ProductService _productService = ProductService.GetInstance();

        public ProductNearMinimumForm()
        {
            InitializeComponent();
        }

        private void Load_Product()
        {
            var products = _productService.FindProductNearMinimumQuantity();
            dgvProduct.Rows.Clear();
            if (products == null)
            {
                // show one row with message "No product near minimum quantity"
                dgvProduct.Rows.Add(null, null, "Không có sản phẩm nào gần hết hàng", null, null);
                return;
            }
            foreach (Product product in products)
            {
                Image image = _productService.GetBarcode(product.Id);
                dgvProduct.Rows.Add(product.Id, image, product.Name, new TextCurrency
                {
                    CultureInfor = TextCurrency.VIETNAM,
                    Value = product.Price,
                    Format = TextCurrency.NO_DECIMAL
                }, product.Amount);
            }
        }
        private void ProductNearMinimumForm_Load(object sender, EventArgs e)
        {
            Load_Product();
        }
    }
}
