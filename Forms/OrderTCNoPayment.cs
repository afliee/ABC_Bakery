using ABC_Bakery.Helpers.Utils;
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
using Color = System.Drawing.Color;
using MessageBox = ABC_Bakery.Helpers.UI.MessageBox;

namespace ABC_Bakery.Forms
{
    public partial class OrderTCNoPayment : Form
    {
        private OrderService _orderService;
        private ProductService _productService;
        private OrderDetailService _orderDetailService;
        private int _orderIndex = 0;
        private double _totalPrice = 0.0;
        private Models.Order _orderEntity;
        public OrderTCNoPayment()
        {
            InitializeComponent();
            //this.ControlBox = false;
            Init();
            _orderService = OrderService.GetInstance();
            _productService = ProductService.GetInstance();
            _orderDetailService = OrderDetailService.GetInstance();
        }

        private void Init()
        {
            stt.DefaultCellStyle.BackColor = Color.White;
        }

        private void OrderTCNoPayment_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            rb_done.Checked = false;
            rb_not_done.Checked = false;
            Load_Order();
        }

        private void Load_Order()
        {
            // clear data in dgOrders and dgOrderDetail
            dgOrders.Rows.Clear();
            dgOrderDetail.Rows.Clear();

            DateTime now = dt_date.Value;
            List<Models.Order> ordersPaid = _orderService.FindAllOrderEquipNoPayment(now);
            if (ordersPaid == null || ordersPaid.Count() == 0)
            {

                MessageBox.Show($"Không có dữ liệu cho ngày {now.ToString("dd/MM/yyyy")}", "Thông báo");
                return;
            }
            int i = 0;
            foreach (Models.Order order in ordersPaid)
            {
                dgOrders.Rows.Add(
                    i + 1,
                    $"{Models.Order.PREFIX}{order.Id}",
                    order.CreatedAt,
                    order.RefundedAt,
                    new TextCurrency
                    {
                        CultureInfor = TextCurrency.VIETNAM,
                        Value = order.Price,
                        Format = TextCurrency.NO_DECIMAL
                    },
                    order.Note
                );
                i++;
                //MessageBox.Show(order.ToString());
            }
        }

        private void dgOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // get order id from row selected
            _orderIndex = e.RowIndex;
            var orderPrefix = Models.Order.PREFIX;
            int orderId = int.Parse(dgOrders.Rows[_orderIndex].Cells[1].Value.ToString().Replace(orderPrefix, ""));

            // get order details by order id
            List<Models.OrderDetail> orderDetails = OrderDetailService.GetInstance().FindByOrderId(orderId);
            var orderEntity = _orderService.FindById(orderId);
            if (orderEntity != null)
            {
                _orderEntity = orderEntity;
                switch (orderEntity.Type)
                {
                    case (int)Models.Constants.OrderType.Prepay:
                        rb_not_done.Checked = true;
                        rb_done.Checked = false;
                        break;
                    case (int)Models.Constants.OrderType.Completed:
                        rb_done.Checked = true;
                        rb_not_done.Checked = false;
                        break;
                }
            }
            // load order details to dgOrderDetail
            dgOrderDetail.Rows.Clear();
            foreach (OrderDetail orderDetail in orderDetails)
            {
                var product = _productService.FindById(orderDetail.ProductId);
                dgOrderDetail.Rows.Add(
                    product.Name,
                    orderDetail.Quantity,
                    new TextCurrency
                    {
                        CultureInfor = TextCurrency.VIETNAM,
                        Value = orderDetail.Total,
                        Format = TextCurrency.NO_DECIMAL
                    },
                    orderDetail.Id
                );
            }

            lb_deposit.Text = new TextCurrency
            {
                CultureInfor = TextCurrency.VIETNAM,
                Value = orderEntity.Deposit,
                Format = TextCurrency.NO_DECIMAL
            }.ToString();

            lb_pay.Text = new TextCurrency
            {
                CultureInfor = TextCurrency.VIETNAM,
                Value = orderEntity.Price - orderEntity.Deposit,
                Format = TextCurrency.NO_DECIMAL
            }.ToString();
        }

        private void dt_date_ValueChanged(object sender, EventArgs e)
        {
            Load_Order();
        }

        private void dgOrderDetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // check if cell clicked is quantity column
            var colClicked = e.ColumnIndex;
            if (colClicked != 1)
            {
                return;
            }

            // get value from cell
            var rowClicked = e.RowIndex;
            var quantity = dgOrderDetail.Rows[rowClicked].Cells[colClicked].Value as string;
            if (string.IsNullOrEmpty(quantity))
            {
                MessageBox.Show("Số lượng không được để trống", "Thông báo");
                // set quantity to 1
                dgOrderDetail.Rows[rowClicked].Cells[colClicked].Value = 1;
                return;
            }

            quantity = quantity.ToString().Trim();
            // check quantity is number
            if (!int.TryParse(quantity, out int result))
            {
                MessageBox.Show("Số lượng phải là số", "Thông báo");
                dgOrderDetail.Rows[rowClicked].Cells[colClicked].Value = 1;
                return;
            }
            var productName = dgOrderDetail.Rows[rowClicked].Cells[0].Value.ToString();
            var product = _productService.FindByName(productName);
            if (product == null)
            {
                MessageBox.Show($"Không tìm thấy sản phẩm {productName}", "Thông báo");
                return;
            }

            // check if quantity is greater than quantity in stock
            if (result > product.Amount)
            {
                MessageBox.Show($"Số lượng sản phẩm {productName} trong kho không đủ", "Thông báo");
                dgOrderDetail.Rows[rowClicked].Cells[colClicked].Value = 1;
                return;
            }

            // update quantity in order detail
            var orderDetailId = int.Parse(dgOrderDetail.Rows[rowClicked].Cells[3].Value.ToString());
            MessageBox.Show($"Cap nhat so luong cua order Detail voi Id: {orderDetailId}");
            bool updateStatus = _orderDetailService.UpdateQuantity(orderDetailId, result);
            if (!updateStatus)
            {
                MessageBox.Show("Cập nhật số lượng thất bại", "Thông báo");
                return;
            }

            var price = product.Price;

            var totalPrice = price * result;
            dgOrderDetail.Rows[rowClicked].Cells[2].Value = new TextCurrency
            {
                CultureInfor = TextCurrency.VIETNAM,
                Value = totalPrice,
                Format = TextCurrency.NO_DECIMAL
            };

            // update total price in order
            var totalPriceOrder = 0.0;
            foreach (DataGridViewRow item in dgOrderDetail.Rows)
            {
                var priceCol = item.Cells[2].Value as TextCurrency;
                totalPriceOrder += priceCol.Value;
            }

            dgOrders.Rows[_orderIndex].Cells[4].Value = new TextCurrency
            {
                CultureInfor = TextCurrency.VIETNAM,
                Value = totalPriceOrder,
                Format = TextCurrency.NO_DECIMAL
            };

            var orderPrefix = Models.Order.PREFIX;
            int orderId = int.Parse(dgOrders.Rows[_orderIndex].Cells[1].Value.ToString().Replace(orderPrefix, ""));

            // update price in order
            bool updatePriceStatus = _orderService.UpdatePrice(orderId, totalPriceOrder);

            if (!updatePriceStatus)
            {
                MessageBox.Show("Cập nhật tổng tiền thất bại", "Thông báo");
                return;
            }
            _totalPrice = totalPriceOrder;
            lb_pay.Text = new TextCurrency
            {
                CultureInfor = TextCurrency.VIETNAM,
                Value = _totalPrice - _orderEntity.Deposit,
                Format = TextCurrency.NO_DECIMAL
            }.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // get order id from row selected
            var orderPrefix = Models.Order.PREFIX;
            int orderId = int.Parse(dgOrders.Rows[_orderIndex].Cells[1].Value.ToString().Replace(orderPrefix, ""));
            var orderEntity = _orderService.FindById(orderId);
            if (orderEntity == null)
            {
                MessageBox.Show("Không tìm thấy đơn hàng", "Thông báo");
                return;
            }

            // get order details by order id
            List<OrderDetail> orders = _orderDetailService.FindByOrderId(orderId);
            if (orders == null || orders.Count() == 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm trong đơn hàng", "Thông báo");
                return;
            }

            orderEntity.Status = rb_done.Checked ? (int)Models.Constants.OrderStatus.Completed : (int)Models.Constants.OrderStatus.Delivered;

            orderEntity.Type = rb_not_done.Checked ? (int)Models.Constants.OrderType.Prepay : (int)Models.Constants.OrderType.Completed;

            var totalPriceCol = dgOrders.Rows[_orderIndex].Cells[3].Value as TextCurrency;
            orderEntity.Price = totalPriceCol.Value;

            bool updateStatus = _orderService.Update(orderEntity);
            if (!updateStatus)
            {
                MessageBox.Show("Cập nhật đơn hàng thất bại", "Thông báo");
                return;
            }

            MessageBox.Show("Cập nhật đơn hàng thành công", "Thông báo");
            Load_Order();
        }

        private void rb_done_Click(object sender, EventArgs e)
        {
            if (rb_not_done.Checked)
            {
                rb_not_done.Checked = false;
                rb_done.Checked = true;
            }
        }

        private void rb_not_done_Click(object sender, EventArgs e)
        {
            if (rb_done.Checked)
            {
                rb_done.Checked = false;
                rb_not_done.Checked = true;
            }
        }
    }
}
