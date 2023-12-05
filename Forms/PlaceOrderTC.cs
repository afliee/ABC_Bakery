using ABC_Bakery.Helpers.Utils;
using ABC_Bakery.Models;
using ABC_Bakery.Models.Constants;
using ABC_Bakery.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Image = System.Drawing.Image;
using MessageBox = ABC_Bakery.Helpers.UI.MessageBox;
using Color = System.Drawing.Color;
using ABC_Bakery.Helpers.UI;

namespace ABC_Bakery.Forms
{
    public partial class PlaceOrderTC : Form
    {
        private readonly ProductService _productService;
        private OrderDetailService _orderDetailService;
        private OrderService _orderService;
        private Models.Order _order;
        private SearchForm _searchForm;
        private readonly TextCurrency _total = new TextCurrency
        {
            Format = TextCurrency.NO_DECIMAL,
            CultureInfor = TextCurrency.VIETNAM,
            Value = 0
        };
        public PlaceOrderTC()
        {
            InitializeComponent();
            _productService = ProductService.GetInstance();
            _orderDetailService = OrderDetailService.GetInstance();
            _orderService = OrderService.GetInstance();
        }

        private void PlaceOrderTC_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.ControlBox = false;
            btnCanceled.Enabled = false;
            btnPrint.Enabled = false;
            btnRenew.Enabled = false;
            tbSearch.Focus();
            lbIndex.Text = $"No. {Models.Order.PREFIX}{_orderService.Count() - 1}";
        }

        private void tbSearch__TextChanged(object sender, EventArgs e)
        {
            string text = tbSearch.Texts;
            // get value of keypress
            if (!(text.Length > 0)) return;
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                //MessageBox.Show(string.Format("You pressed enter in textbox {0}", tbSearch.Texts));
                string barcodeText = tbSearch.Texts;
                Product product = _productService.FindByBarcode(barcodeText);
                if (product == null)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm hoặc không khả dụng", "Thông Báo");
                    return;
                }
                else
                {
                    Add_Product(product);
                }
            }
        }

        private void Add_Product(Product product)
        {
            // check if product is exist in list 
            var rows = dgProducts.Rows;

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

                    dgProducts.Refresh();
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

            dgProducts.Rows.Add(string.Format("{0}_{1}", Product.Prefix, product.Id), image, product.Name, priceString, 1, priceString.Clone());
            tbSearch.ClearText();
            tbSearch.Focus();

            Update_Total();
        }

        private void Update_Total()
        {
            double total = 0;
            foreach (DataGridViewRow row in dgProducts.Rows)
            {
                TextCurrency totalObj = row.Cells[5].Value as TextCurrency;
                total += totalObj.Value;
            }
            string surchargeText = tbSurcharge.Texts;
            if (!string.IsNullOrWhiteSpace(surchargeText))
            {
                total += double.Parse(surchargeText);
            }
            _total.Value = total;
            tbTotal.Texts = _total.ToString();
        }

        private void tbSurcharge__TextChanged(object sender, EventArgs e)
        {
            string text = tbSurcharge.Texts;
            if (string.IsNullOrWhiteSpace(text))
            {
                return;
            }

            if (text.Length == 0)
            {
                tbSurcharge.Texts = "0";
                return;
            }

            if (text.StartsWith("0"))
            {
                tbSurcharge.Texts = text.Substring(1);
            }

            if (text.Length > 0)
            {
                if (text.All(char.IsDigit))
                {
                    Update_Total();
                    return;
                }
                else
                {
                    Helpers.UI.MessageBox.Show("Giá tiền không hợp lệ", "Lỗi cú pháp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (text.Length == 1)
                    {
                        tbSurcharge.Texts = "0";
                    }
                    else
                    {
                        tbSurcharge.Texts = text.Substring(0, text.Length - 1);
                    }
                }
            }
        }

        private void tbDeposit__TextChanged(object sender, EventArgs e)
        {
            string text = tbSurcharge.Texts;
            if (string.IsNullOrWhiteSpace(text))
            {
                return;
            }

            if (text.Length == 0)
            {
                tbSurcharge.Texts = "0";
                return;
            }

            if (text.StartsWith("0"))
            {
                tbSurcharge.Texts = text.Substring(1);
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
                        tbSurcharge.Texts = "0";
                    }
                    else
                    {
                        tbSurcharge.Texts = text.Substring(0, text.Length - 1);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgProducts.Rows.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào để thanh toán", "Thông Báo");
                return;
            }

            if (_total.Value == 0)
            {
                MessageBox.Show("Không có sản phẩm nào để thanh toán", "Thông Báo");
                return;
            }

            string note = tbNote.Texts;
            User cashier = UserService.GetInstance().Find(1);
            Models.Receipt receipt = ReceiptService.GetInstance().FindByCreatedDayAndReceiptType(DateTime.Now, (int)ReceiptType.Import);
            double deposit = double.Parse(tbDeposit.Texts);
            MessageBox.Show(string.Format("Tổng tiền: {0}\nĐặt cọc: {1}\nCòn lại: {2}", _total.Value, deposit, _total.Value - deposit), "Thông Báo");

            OrderType orderType;
            if (deposit < _total.Value)
            {
                orderType = OrderType.Prepay;
            }
            else
            {
                deposit = Math.Min(deposit, _total.Value);
                orderType = OrderType.Completed;
            }

            Models.Order orderEntity = new Models.Order
            {
                Address = "",
                CashierId = cashier.Id,
                ReceiptId = receipt.Id,
                Name = string.Format("Hóa Đơn Mã {0}_{1}", Models.Receipt.Prefix, receipt.Id),
                Type = (int)orderType,
                Note = note,
                Price = _total.Value,
                Deposit = deposit,
                Status = (int)OrderStatus.Processing,
                RecordType = (int)OrderRecordType.Equipment,
                RefundedAt = dt_refundedTime.Value
            };
            List<OrderDetail> orders = new List<OrderDetail>();
            foreach (DataGridViewRow row in dgProducts.Rows)
            {
                TextCurrency priceCol = row.Cells[3].Value as TextCurrency;
                int quantity = int.Parse(row.Cells[4].Value.ToString());
                string productId = row.Cells[0].Value.ToString();

                Product product = _productService.Find(int.Parse(productId.Substring(Product.Prefix.Length + 1)));
                OrderDetail orderDetail = new OrderDetail
                {
                    OrderId = orderEntity.Id,
                    ProductId = product.Id,
                    Price = priceCol.Value,
                    Quantity = quantity,
                    Total = priceCol.Value * quantity
                };

                OrderDetailService.GetInstance().Create(orderDetail);
                orders.Add(orderDetail);
            }

            orderEntity.OrderDetails = orders;

            if (OrderService.GetInstance().Create(orderEntity))
            {

                MessageBox.Show("Thanh toán thành công", "Thông Báo");
                _order = orderEntity;
                // show message box to ask print receipt
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn in hóa đơn không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    // print receipt
                    print_order.Print();
                    btnPrint.Enabled = true;
                    btnRenew.Enabled = true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    // do something else
                    btnCanceled.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại", "Thông Báo");
            }
        }

        private void dgProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // remove product with index = e.RowIndex
            // check if user click on remove button
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                dgProducts.Rows.RemoveAt(e.RowIndex);
                Update_Total();
            }
        }

        private void print_order_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            print_order.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1170);
            e.Graphics.Clear(Color.White);
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12);
            float fontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString("ABC Bakery", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);

            graphic.DrawString("Số Điện Thoại: 0123456789", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString("Địa Chỉ: 123 Nguyễn Văn Cừ, Quận 5, TP.HCM", font, new SolidBrush(Color.Black), startX, startY + offset * 2);
            graphic.DrawString("Ngày: " + DateTime.Now.ToString("dd/MM/yyyy"), font, new SolidBrush(Color.Black), startX, startY + offset * 3);
            graphic.DrawString("Giờ: " + DateTime.Now.ToString("HH:mm:ss"), font, new SolidBrush(Color.Black), startX, startY + offset * 4);
            //graphic.DrawString("Nhân Viên: " + _order.Cashier.Name, font, new SolidBrush(Color.Black), startX, startY + offset * 5);
            graphic.DrawString("Hóa Đơn: " + _order.Name, font, new SolidBrush(Color.Black), startX, startY + offset * 6);
            // show products
            graphic.DrawString("Sản Phẩm", font, new SolidBrush(Color.Black), startX, startY + offset * 7);
            graphic.DrawString("Số Lượng", font, new SolidBrush(Color.Black), startX + 200, startY + offset * 7);
            graphic.DrawString("Đơn Giá", font, new SolidBrush(Color.Black), startX + 300, startY + offset * 7);
            graphic.DrawString("Thành Tiền", font, new SolidBrush(Color.Black), startX + 400, startY + offset * 7);

            int i = 0;
            var orderDetails = _orderDetailService.FindByOrderId(_order.Id);
            foreach (OrderDetail orderDetail in orderDetails)
            {
                var product = _productService.FindById(orderDetail.ProductId);

                graphic.DrawString(product.Name, font, new SolidBrush(Color.Black), startX, startY + offset * (8 + i));
                graphic.DrawString(orderDetail.Quantity.ToString(), font, new SolidBrush(Color.Black), startX + 200, startY + offset * (8 + i));
                graphic.DrawString(new TextCurrency
                {
                    CultureInfor = TextCurrency.VIETNAM,
                    Value = orderDetail.Price,
                    Format = TextCurrency.NO_DECIMAL
                }.ToString(), font, new SolidBrush(Color.Black), startX + 300, startY + offset * (8 + i));

                graphic.DrawString(new TextCurrency
                {
                    CultureInfor = TextCurrency.VIETNAM,
                    Value = orderDetail.Total,
                    Format = TextCurrency.NO_DECIMAL
                }.ToString(), font, new SolidBrush(Color.Black), startX + 400, startY + offset * (8 + i));
                i++;
            }
            graphic.DrawString(string.Format("Tổng tiền: {0}", new TextCurrency
            {
                CultureInfor = TextCurrency.VIETNAM,
                Value = _order.Price,
                Format = TextCurrency.NO_DECIMAL
            }).ToString(), font, new SolidBrush(Color.Black), startX, startY + offset * (8 + i));

            graphic.DrawString("Cảm ơn quý khách", font, new SolidBrush(Color.Black), startX, startY + offset * (9 + i));
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            dgProducts.Rows.Clear();
            tbSearch.ClearText();
            tbSurcharge.ClearText();
            tbDeposit.ClearText();
            tbNote.ClearText();
            tbTotal.Texts = new TextCurrency
            {
                Format = TextCurrency.NO_DECIMAL,
                Value = 0,
                CultureInfor = TextCurrency.VIETNAM
            }.ToString();

            lbIndex.Text = $"No. {Models.Order.PREFIX}{_orderService.Count() - 1}";

            btnCanceled.Enabled = false;
            btnPrint.Enabled = false;
        }

        private void filter_Click(object sender, EventArgs e)
        {
            if (_searchForm == null)
            {
                _searchForm = new SearchForm(this);
            }

            // check _searchForm is disposed
            if (_searchForm.IsDisposed)
            {
                _searchForm = new SearchForm(this);
            }

            _searchForm.Show();
        }

        public DataGridView GetDataGridView()
        {
            return dgProducts;
        }

        public RJTextBox GetTbSurcharge()
        {
            return tbSurcharge;
        }

        public void UpdateTotal()
        {
            Update_Total();
        }
    }
}
