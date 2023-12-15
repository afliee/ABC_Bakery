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
using MessageBox = ABC_Bakery.Helpers.UI.MessageBox;
using Image = System.Drawing.Image;
using System.Xml.Linq;
using System.Drawing.Printing;
using Color = System.Drawing.Color;
using ABC_Bakery.Helpers.UI;
using ABC_Bakery.Services;
using ABC_Bakery.Models.Constants;
using ABC_Bakery.Models;
using ABC_Bakery.Helpers.Utils;

namespace ABC_Bakery.Forms
{
    public partial class Order : Form
    {
        private ProductService _productService;
        private OrderDetailService _orderDetailService;
        private OrderService _orderService;
        private TextCurrency _total;
        private TextCurrency _moneyChange;
        private TextCurrency _moneyRecieved;
        private Models.Order _order;
        private SearchForm _searchForm;
        private Promotion _promotion;
        private PromotionService _promotionService;
        public Order()
        {
            //this.BackgroundImage = Properties.Resources.Bg;
            InitializeComponent();
            _productService = ProductService.GetInstance();
            _orderDetailService = OrderDetailService.GetInstance();
            _orderService = OrderService.GetInstance();
            _promotionService = PromotionService.GetInstance();
            _total = new TextCurrency
            {
                Format = TextCurrency.NO_DECIMAL,
                Value = 0,
                CultureInfor = TextCurrency.VIETNAM
            };

            _moneyChange = new TextCurrency
            {
                Format = TextCurrency.NO_DECIMAL,
                Value = 0,
                CultureInfor = TextCurrency.VIETNAM
            };

            _moneyRecieved = new TextCurrency
            {
                Format = TextCurrency.NO_DECIMAL,
                Value = 0,
                CultureInfor = TextCurrency.VIETNAM
            };
        }

        private void Order_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            lbTotal.Text = new TextCurrency
            {
                Format = TextCurrency.NO_DECIMAL,
                Value = 0,
                CultureInfor = TextCurrency.VIETNAM
            }.ToString();

            lbMoneyChange.Text = new TextCurrency
            {
                Format = TextCurrency.NO_DECIMAL,
                Value = 0,
                CultureInfor = TextCurrency.VIETNAM
            }.ToString();

            btnCanceled.Enabled = false;
            btnPrint.Enabled = false;
            btnRenew.Enabled = false;
            tbSearch.Focus();
            lb_index.Text = $"No. {Models.Order.PREFIX}{_orderService.Count() - 1}";
        }

        private void Order_FormClosing(object sender, FormClosingEventArgs e)
        {

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

            if (_promotion != null)
            {
                total = total * (100 - _promotion.Ratio) / 100;
            }


            _total.Value = total;
            lbTotal.Text = _total.ToString();
            Calculate_Change();
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
                    MessageBox.Show("Giá tiền không hợp lệ", "Lỗi cú pháp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void tbReceived__TextChanged(object sender, EventArgs e)
        {
            string text = tbReceived.Texts;
            if (string.IsNullOrWhiteSpace(text))
            {
                return;
            }

            if (text.Length == 0)
            {
                tbReceived.Texts = "0";
                return;
            }

            if (text.StartsWith("0"))
            {
                tbReceived.Texts = text.Substring(1);
            }

            if (text.Length > 0)
            {
                if (text.All(char.IsDigit))
                {
                    Calculate_Change();

                    return;
                }
                else
                {
                    MessageBox.Show("Giá tiền không hợp lệ", "Lỗi cú pháp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (text.Length == 1)
                    {
                        tbReceived.Texts = "0";
                    }
                    else
                    {
                        tbReceived.Texts = text.Substring(0, text.Length - 1);
                    }
                }
            }
        }

        private void Calculate_Change()
        {
            string moneyReceivedText = tbReceived.Texts;
            if (string.IsNullOrWhiteSpace(moneyReceivedText))
            {
                return;
            }

            if (moneyReceivedText.Length == 0)
            {
                tbReceived.Texts = "0";
                return;
            }

            double moneyReceived = double.Parse(moneyReceivedText);
            double total = _total.Value;
            _moneyRecieved.Value = moneyReceived;

            if (moneyReceived <= total)
            {
                lbMoneyChange.Text = new TextCurrency
                {
                    Format = TextCurrency.NO_DECIMAL,
                    Value = 0,
                    CultureInfor = TextCurrency.VIETNAM
                }.ToString();
                return;
            }

            _moneyChange.Value = moneyReceived - total;

            lbMoneyChange.Text = new TextCurrency
            {
                Format = TextCurrency.NO_DECIMAL,
                Value = moneyReceived - total,
                CultureInfor = TextCurrency.VIETNAM
            }.ToString();

        }

        public void SaveOrder()
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
            User cashier = UserService.GetInstance().FindFirstCashier();
            Models.Receipt receipt = ReceiptService.GetInstance().FindByCreatedDayAndReceiptType(DateTime.Now, (int)ReceiptType.Import);
            OrderType orderType;
            double deposit = 0;
            if (_moneyRecieved.Value < _total.Value)
            {
                orderType = OrderType.Prepay;
                deposit = _moneyRecieved.Value;
            }
            else
            {
                orderType = OrderType.Completed;
            }
            
            MessageBox.Show(string.Format("Tổng tiền: {0}\nNhận: {1}\nTrả lại: {2}\nDeposit: {3}", _total.ToString(), _moneyRecieved.ToString(), _moneyChange.ToString(), deposit), "Thông Báo");
            
            if (_promotion != null)
            {
                note += string.Format(" Khuyến mãi: {0} - {1}%\n", _promotion.Name, _promotion.Ratio);
            }
            Models.Order orderEntity = new Models.Order
            {
                Address = "",
                CashierId = cashier.Id,
                ReceiptId = receipt.Id,
                Name = string.Format("Hóa Đơn Mã {0}_{1}", Models.Receipt.Prefix, receipt.Id),
                Type = (int)orderType,
                Note = note,
                Deposit = deposit,
                Price = _total.Value,
                Status = (int)OrderStatus.Completed,
                RecordType = (int)OrderRecordType.Direct
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

                if (orderType == OrderType.Prepay)
                {
                    MessageBox.Show("Đặt cọc thành công", "Thông Báo");
                }
                else
                {
                    MessageBox.Show("Thanh toán thành công", "Thông Báo");
                }
                _order = orderEntity;
                // show message box to ask print receipt
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn in hóa đơn không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    // print receipt
                    PrintReceipt();
                    btnRenew.Enabled = true;
                    btnPrint.Enabled = true;
                    btnCanceled.Enabled = false;
                }
                else if (dialogResult == DialogResult.No)
                {
                    // do something else
                    btnCanceled.Enabled = false;
                    //btnRenew_Click(sender, e);
                    btnPrint.Enabled = false;
                    btnRenew.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại", "Thông Báo");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveOrder();
        }


        public void ClearInput()
        {
            dgProducts.Rows.Clear();
            tbSearch.ClearText();
            tbSurcharge.ClearText();
            tbReceived.ClearText();
            tbNote.ClearText();
            lbTotal.Text = new TextCurrency
            {
                Format = TextCurrency.NO_DECIMAL,
                Value = 0,
                CultureInfor = TextCurrency.VIETNAM
            }.ToString();

            lbMoneyChange.Text = new TextCurrency
            {
                Format = TextCurrency.NO_DECIMAL,
                Value = 0,
                CultureInfor = TextCurrency.VIETNAM
            }.ToString();
            lb_index.Text = $"No. {Models.Order.PREFIX}{_orderService.Count() - 1}";
        }
        private void btnRenew_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void btnCanceled_Click(object sender, EventArgs e)
        {
            btnRenew_Click(sender, e);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // get order

        }

        private void PrintReceipt()
        {
            print_order.Print();
        }

        private void print_order_PrintPage(object sender, PrintPageEventArgs e)
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

            // set graphic to print
            //e.HasMorePages = false;
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

        public Label GetTotalLabel()
        {
            return lbTotal;
        }

        public RJTextBox GetTbSurcharge()
        {
            return tbSurcharge;
        }

        public void UpdateTotal()
        {
            Update_Total();
        }

        private void tbDiscount__TextChanged(object sender, EventArgs e)
        {
            string discount = tbDiscount.Texts;

            if (string.IsNullOrWhiteSpace(discount))
            {
                return;
            }

            if (discount.Length == 0)
            {
                tbDiscount.Texts = "0";
                return;
            }

            if (discount.Length < 6)
            {
                return;
            }
            delayTimeDiscount.Stop();
            delayTimeDiscount.Start();
        }

        private void ValidateDiscount()
        {
            DateTime now = DateTime.Now;
            string discount = tbDiscount.Texts;

            var isExist = _promotionService.CheckCodeExistBeforeOrEqualDate(discount, now);
            if (!isExist)
            {
                tbDiscount.BorderColor = Color.Red;
                tbDiscount.ForeColor = Color.Red;
            }
            else
            {
                tbDiscount.BorderColor = Color.Green;
                tbDiscount.ForeColor = Color.Green;
                _promotion = _promotionService.FindByCode(discount);
                UpdateTotal();
            }
        }

        private void delayTimeDiscount_Tick(object sender, EventArgs e)
        {
            delayTimeDiscount.Stop();
            ValidateDiscount();
        }

    }
}
