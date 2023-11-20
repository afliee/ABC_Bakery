using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABC_Bakery.Helpers;
using ABC_Bakery.Models;
using ABC_Bakery.Repositories;
using Microsoft.IdentityModel.Tokens;
using MessageBox = ABC_Bakery.Helpers.UI.MessageBox;
using IronBarCode;
using ABC_Bakery.Services;
using Image = System.Drawing.Image;
namespace ABC_Bakery.Forms
{
    public partial class CreateProduct : Form
    {
        private Boolean IsShowProducts = false;
        private CategoryRepository categoryRepository;
        private ProductRepository productRepository;
        public CreateProduct()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            var db = new DatabaseContext();
            categoryRepository = new CategoryRepository(db);
            productRepository = new ProductRepository(db);

            Category category = categoryRepository.FindByName("Bánh mì");
            if (category == null)
            {
                var banhmi = new Category
                {
                    Name = "Bánh mì",
                    Products = new List<Product>()
                };

                bool result = this.categoryRepository.Create(banhmi);
                if (!result)
                {
                    MessageBox.Show("Create category failed");
                }
                else
                {
                    MessageBox.Show("Create category success");
                }


            }

            List<Category> categories = this.categoryRepository.FindAll();
            this.cbCategory.Items.Add("Chọn Danh Mục");
            foreach (Category category1 in categories)
            {
                this.cbCategory.Items.Add(category1);
            }

            this.cbCategory.SelectedIndex = 0;

            Load_Data();
            Category test = categoryRepository.FindByName("Bánh mì");

        }
        private void CreateProduct_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            string text = tbSearch.Text;
            //this.pnProductBoundary.Visible = true;
            this.IsShowProducts = true;
            // set default data for data grid view is emtpy data
            // show text with "No data found" in data grid view
            this.dgProducts.DataSource = null;
        }

        private void showProducts_Tick(object sender, EventArgs e)
        {
            if (IsShowProducts)
            {
                this.pnProducts.Height += 10;
                if (pnProducts.Height >= 295)
                {
                    showProducts.Stop();
                    IsShowProducts = false;
                    this.pnProductBoundary.Visible = true;
                }
            }
            else
            {
                this.pnProducts.Height -= 10;
                if (pnProducts.Height <= 70)
                {
                    showProducts.Stop();
                    IsShowProducts = true;
                    this.pnProductBoundary.Visible = false;
                }
            }
        }

        private void tbSearch__TextChanged(object sender, EventArgs e)
        {
            delayTextChanged.Stop();
            delayTextChanged.Start();
        }

        private void delayTextChanged_Tick(object sender, EventArgs e)
        {
            delayTextChanged.Stop();
            FindAndFillProduct();
        }

        private void FindAndFillProduct()
        {
            string text = tbSearch.Texts;

            if (text.Length == 0)
            {
                dgProducts.Rows.Clear();
                Load_Data();
                return;
            }

            List<Product> products = productRepository.FindByNameContains(text);
            if (products.Count == 0)
            {
                dgProducts.Rows.Clear();
                return;
            }
            else
            {
                dgProducts.Rows.Clear();
                products.ForEach(product =>
                {
                    Image barcode = ProductService.GetInstance().GetBarcode(product.Id);
                    dgProducts.Rows.Add(product.Id,barcode, product.Name, product.Price, product.Amount, product.IsActived);
                });
            }
        }

        private void tbPrice__TextChanged(object sender, EventArgs e)
        {
            string text = tbPrice.Texts;

            if (string.IsNullOrWhiteSpace(text))
            {
                return;
            }

            if (text.Length == 0)
            {
                return;
            }

            if (text.StartsWith("0"))
            {
                tbPrice.Texts = text.Substring(1);
            }

            if (text.Length > 0)
            {
                if (text.All(char.IsDigit))
                {
                    return;
                }
                else
                {
                    Helpers.UI.MessageBox.Show("Giá tiền không hợp lệ", "Lỗi cú pháp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (text.Length == 1)
                    {
                        tbPrice.Texts = "1";
                    }
                    else
                    {
                        tbPrice.Texts = text.Substring(0, text.Length - 1);
                    }
                }
            }
        }

        private void tbName__TextChanged(object sender, EventArgs e)
        {
            string text = tbName.Texts;
            if (string.IsNullOrWhiteSpace(text))
            {
                return;
            }


            if (text.Length == 0)
            {
                return;
            }

            if (text.Length > 0)
            {
                if (text.All(char.IsDigit))
                {
                    Helpers.UI.MessageBox.Show("Tên sản phẩm không hợp lệ. Vui lòng xóa và nhập lại", "Lỗi cú pháp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (text.Length == 1)
                    {
                        return;
                    }
                    else
                    {
                        tbName.Texts = text.Substring(0, text.Length - 1);
                    }
                }
            }
        }

        private void tbQuantity__TextChanged(object sender, EventArgs e)
        {
            string text = tbQuantity.Texts;

            if (string.IsNullOrWhiteSpace(text))
            {
                return;
            }

            if (text.Length == 0)
            {
                return;
            }

            if (text.StartsWith("0"))
            {
                tbQuantity.Texts = text.Substring(1);
            }

            if (text.Length > 0)
            {
                if (text.All(char.IsDigit))
                {
                    return;
                }
                else
                {
                    Helpers.UI.MessageBox.Show("Giá tiền không hợp lệ", "Lỗi cú pháp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (text.Length == 1)
                    {
                        tbQuantity.Texts = "1";
                    }
                    else
                    {
                        tbQuantity.Texts = text.Substring(0, text.Length - 1);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = tbName.Texts;
            string price = tbPrice.Texts;
            string quantity = tbQuantity.Texts;
            string description = tbDescription.Texts;
            Category category = cbCategory.SelectedItem as Category;

            if (string.IsNullOrWhiteSpace(name))
            {
                Helpers.UI.MessageBox.Show("Tên sản phẩm không được để trống", "Lỗi cú pháp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(price))
            {
                Helpers.UI.MessageBox.Show("Giá sản phẩm không được để trống", "Lỗi cú pháp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(quantity))
            {
                Helpers.UI.MessageBox.Show("Số lượng sản phẩm không được để trống", "Lỗi cú pháp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (category == null)
            {
                Helpers.UI.MessageBox.Show("Danh mục sản phẩm không được để trống", "Lỗi cú pháp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                Helpers.UI.MessageBox.Show("Mô tả sản phẩm không được để trống", "Lỗi cú pháp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Product existProduct = productRepository.FindByName(name);
            if (existProduct != null)
            {
                Helpers.UI.MessageBox.Show("Tên sản phẩm đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbName.Focus();
                return;
            }
            Product product = new Product
            {
                Name = name,
                Price = Int32.Parse(price),
                Amount = Int32.Parse(quantity),
                Description = description,
                Category = category,
                ExpiredDate = DateTime.Now
            };

            category.Products.Add(product);

            bool result = this.productRepository.Create(product);
            if (result)
            {
                result = this.categoryRepository.Update(category);
            }
            if (!result)
            {
                Helpers.UI.MessageBox.Show("Thêm sản phẩm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Helpers.UI.MessageBox.Show("Thêm sản phẩm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgProducts.Rows.Clear();
                Load_Data();
                return;
            }
        }

        private void Load_Data()
        {
            List<Product> products = productRepository.FindAll();

            var dt = new DataTable();
            products.ForEach(product =>
            {
                GeneratedBarcode barcode = BarcodeWriter.CreateBarcode(string.Format("{0}_{1}", Product.Prefix, product.Id), BarcodeWriterEncoding.Code128, 200, 60);

                // convert barcode to image
                System.Drawing.Image barcodeImage = barcode.Image;

                dgProducts.Rows.Add(product.Id, barcodeImage, product.Name, product.Price, product.Amount, product.IsActived);
            });
        }

        private void dgProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // get value of cell
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {

                // get id of product
                int id = Int32.Parse(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                Product product = productRepository.Find(id);
                if (product == null)
                {
                    Helpers.UI.MessageBox.Show("Không tìm thấy sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Handle_Delete_Product(product);
            }

            // get event when user click checkbox in datagridview
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                // get id of product
                int id = Int32.Parse(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                Product product = productRepository.Find(id);
                if (product == null)
                {
                    Helpers.UI.MessageBox.Show("Không tìm thấy sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // update status of product
                product.IsActived = !product.IsActived;
                bool result = productRepository.Update(product);
                if (!result)
                {
                    Helpers.UI.MessageBox.Show("Cập nhật trạng thái sản phẩm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    Helpers.UI.MessageBox.Show("Cập nhật trạng thái sản phẩm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgProducts.Rows.Clear();
                    Load_Data();
                    return;
                }
            }
        }

        private void Handle_Delete_Product(Product product)
        {
            DialogResult dialogResult = Helpers.UI.MessageBox.Show(
                               string.Format("Bạn có chắc chắn muốn xóa sản phẩm {0} không?", product.Name)
                                              , "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                bool result = productRepository.Delete(product);
                if (!result)
                {
                    Helpers.UI.MessageBox.Show("Xóa sản phẩm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    Helpers.UI.MessageBox.Show(
                        string.Format("Xóa sản phẩm {0} thành công", product.Name)
                        , "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgProducts.Rows.Clear();
                    Load_Data();
                }
            }
        }
    }
}
