using ABC_Bakery.Models;
using ABC_Bakery.Services;
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
using ABC_Bakery.Helpers.Utils;
using System.Xml.Linq;
using ABC_Bakery.Models.Constants;
using System.Drawing.Printing;
using Color = System.Drawing.Color;
namespace ABC_Bakery.Forms
{
    public partial class Order : Form
    {
        private ProductService _productService;
        private OrderDetailService _orderDetailService;
        private TextCurrency _total;
        private TextCurrency _moneyChange;
        private Models.Order _order;
        public Order()
        {
            //this.BackgroundImage = Properties.Resources.Bg;
            InitializeComponent();
            //this.ControlBox = false;
            //this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            _productService = ProductService.GetInstance();
            _orderDetailService = OrderDetailService.GetInstance();
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
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // get the value of barcode scanner
            if (e.KeyCode == Keys.Enter)
            {
                if (!tbSearch.Focused)
                {
                    MessageBox.Show("Ấn hoặc Nhập vào ô tìm kiếm để tìm sản phẩm", "Thông Báo");
                    tbSearch.Focus();
                    return;
                }
            }
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
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Order_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void tbSearch__TextChanged(object sender, EventArgs e)
        {
            string text = tbSearch.Texts;
            // get value of keypress
            if (!(text.Length > 0)) return;

            //if (text.Contains(Keys.Enter.ToString()))
            //{
            //    MessageBox.Show("Enter pressed");
            //}
            //else
            //{
            //    MessageBox.Show("Enter not pressed");
            //}
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
                    MessageBox.Show("Không tìm thấy sản phẩm", "Thông Báo");
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
            lbTotal.Text = _total.ToString();
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
                    Helpers.UI.MessageBox.Show("Giá tiền không hợp lệ", "Lỗi cú pháp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (moneyReceived < total)
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
            Models.Order orderEntity = new Models.Order
            {
                Address = "",
                CashierId = cashier.Id,
                ReceiptId = receipt.Id,
                Name = string.Format("Hóa Đơn Mã {0}_{1}", Models.Receipt.Prefix, receipt.Id),
                Type = (int)OrderType.Paid,
                Note = note,
                Price = _total.Value,
                Status = (int)OrderStatus.Completed
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
                    PrintReceipt();
                }
                else if (dialogResult == DialogResult.No)
                {
                    // do something else
                    btnCanceled.Enabled = false;
                    btnRenew_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại", "Thông Báo");
            }
        }

        private void btnRenew_Click(object sender, EventArgs e)
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
                //graphic.DrawString(orderDetail.Product.Name, font, new SolidBrush(Color.Black), startX, startY + offset * (8 + i));
                //graphic.DrawString(orderDetail.Quantity.ToString(), font, new SolidBrush(Color.Black), startX + 200, startY + offset * (8 + i));
                //graphic.DrawString(orderDetail.Price.ToString(), font, new SolidBrush(Color.Black), startX + 300, startY + offset * (8 + i));
                //graphic.DrawString(orderDetail.Total.ToString(), font, new SolidBrush(Color.Black), startX + 400, startY + offset * (8 + i));

                i++;
            }

            graphic.DrawString("Tổng Tiền: " + _order.Price.ToString(), font, new SolidBrush(Color.Black), startX, startY + offset * (8 + i));
            
            graphic.DrawString("Cảm ơn quý khách", font, new SolidBrush(Color.Black), startX, startY + offset * (9 + i));

            print_order.PrintPage += new PrintPageEventHandler(print_order_PrintPage);
            print_order.Print();

        }
    }
}
