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
using MessageBox = ABC_Bakery.Helpers.UI.MessageBox;
namespace ABC_Bakery.Forms
{
    public partial class SearchForm : Form
    {
        private readonly ProductService _productService = ProductService.GetInstance();
        private readonly Order _orderForm;
        private readonly PrePlaceOrder _prePlaceOrder;
        private readonly PlaceOrderTC _placeOrderTC;
        public SearchForm()
        {
            InitializeComponent();
        }

        public SearchForm(Order order)
        {
            InitializeComponent();
            this._orderForm = order;
            this._placeOrderTC = null;
            this._prePlaceOrder = null;
        }

        public SearchForm(PrePlaceOrder prePlaceOrder)
        {
            InitializeComponent();
            this._prePlaceOrder = prePlaceOrder;
            this._placeOrderTC = null;
            this._orderForm = null;
        }

        public SearchForm(PlaceOrderTC placeOrderTC)
        {
            InitializeComponent();
            this._placeOrderTC = placeOrderTC;
            this._prePlaceOrder = null;
            this._orderForm = null;
        }
        private void tbSearch__TextChanged(object sender, EventArgs e)
        {
            delayTextChanged.Stop();
            delayTextChanged.Start();
        }

        private void delayTextChanged_Tick(object sender, EventArgs e)
        {
            delayTextChanged.Stop();
            FindProduct();
        }

        private void FindProduct()
        {
            var search = tbSearch.Texts;
            dgvProduct.Rows.Clear();
            if (string.IsNullOrEmpty(search) || string.IsNullOrWhiteSpace(search))
            {
                var products = _productService.GetAll();
                products.ForEach(product =>
                {
                    if (product.Amount > 0 || product.IsActived)
                    {
                        Image barcode = _productService.GetBarcode(product.Id);
                        dgvProduct.Rows.Add(
                            $"{Product.Prefix}_{product.Id}",
                            barcode
                            , product.Name,
                            new TextCurrency
                            {
                                CultureInfor = TextCurrency.VIETNAM,
                                Value = product.Price,
                                Format = TextCurrency.NO_DECIMAL
                            }
                        );
                    }
                });
                return;
            }
            else
            {
                var products = _productService.FindByNameContains(search);
                products.ForEach(product =>
                {
                    if (product.Amount > 0 || product.IsActived)
                    {
                        Image barcode = _productService.GetBarcode(product.Id);
                        DataGridViewCheckBoxCell cell = new DataGridViewCheckBoxCell();
                        dgvProduct.Rows.Add(
                            $"{Product.Prefix}_{product.Id}",
                            barcode,
                            product.Name,
                            new TextCurrency
                            {
                                CultureInfor = TextCurrency.VIETNAM,
                                Value = product.Price,
                                Format = TextCurrency.NO_DECIMAL
                            }
                        );
                    }
                });
            }
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // check if click to  datagridviewcheckboxcell
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                               e.RowIndex >= 0)
            {
                string idMixed = senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                string id = idMixed.Replace($"{Product.Prefix}_", "");

                Add_Product(int.Parse(id));
            }

        }

        private void Add_Product(int id)
        {
            var product = _productService.Find(id);
            if (product == null)
            {
                MessageBox.Show("Không tìm thấy sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (product.Amount <= 0)
            {
                MessageBox.Show("Sản phẩm đã hết hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!product.IsActived)
            {
                MessageBox.Show("Sản phẩm đã bị khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Add_Product(product);
        }

        private void Add_Product(Product product)
        {
            // check if product is exist in list 

            DataGridViewRowCollection rows;
            DataGridView grid;
            if (this._orderForm != null)
            {
                grid = this._orderForm.GetDataGridView();
                rows = this._orderForm.GetDataGridView().Rows;
            }
            else if (this._prePlaceOrder != null)
            {
                grid = this._prePlaceOrder.GetDataGridView();
                rows = this._prePlaceOrder.GetDataGridView().Rows;
            }
            else
            {
                grid = this._placeOrderTC.GetDataGridView();
                rows = this._placeOrderTC.GetDataGridView().Rows;
            }

            foreach (DataGridViewRow row in rows)
            {
                string name = row.Cells[2].Value.ToString();
                if (name.Equals(product.Name))
                {
                    // increase quantity

                    //int price = int.Parse(row.Cells[2].Value.ToString());
                    int quantity = int.Parse(row.Cells[4].Value.ToString());
                    row.Cells[4].Value = quantity + 1;
                    //// increase total price
                    TextCurrency totalObj = row.Cells[5].Value as TextCurrency;
                    totalObj.Value = (quantity + 1) * product.Price;

                    row.Cells[5].Value = totalObj;

                    grid.Refresh();
                    tbSearch.ClearText();
                    tbSearch.Focus();
                    Update_Total();
                    return;
                }
            }

            // add new product
            Image image = _productService.GetBarcode(product.Id);
            TextCurrency priceString = new TextCurrency
            {
                Format = TextCurrency.NO_DECIMAL,
                Value = product.Price,
                CultureInfor = TextCurrency.VIETNAM
            };

            grid.Rows.Add(string.Format("{0}_{1}", Product.Prefix, product.Id), image, product.Name, priceString, 1, priceString.Clone());
            tbSearch.ClearText();
            tbSearch.Focus();

            Update_Total();
        }

        private void Update_Total()
        {
            if (this._orderForm != null)
            {
                this._orderForm.UpdateTotal();
            }
            else if (this._prePlaceOrder != null)
            {
                this._prePlaceOrder.UpdateTotal();
            }
            else
            {
                this._placeOrderTC.UpdateTotal();
            }
        }
    }
}
