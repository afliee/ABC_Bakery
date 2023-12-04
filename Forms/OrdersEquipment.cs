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
using MessageBox = ABC_Bakery.Helpers.UI.MessageBox;

namespace ABC_Bakery.Forms
{
    public partial class OrdersEquipment : Form
    {
        private OrderService _orderService;
        private ProductService _productService;
        private int _orderIndex = 0;
        public OrdersEquipment()
        {
            InitializeComponent();
            _orderService = OrderService.GetInstance();
            _productService = ProductService.GetInstance();
        }

        private void dgOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _orderIndex = e.RowIndex;
            var orderPrefix = Models.Order.PREFIX;
            int orderId = int.Parse(dgOrders.Rows[_orderIndex].Cells[1].Value.ToString().Replace(orderPrefix, ""));

            // get order details by order id
            List<Models.OrderDetail> orderDetails = OrderDetailService.GetInstance().FindByOrderId(orderId);
            var orderEntity = _orderService.FindById(orderId);
            if (orderEntity != null)
            {
                switch (orderEntity.Type)
                {
                    case (int)Models.Constants.OrderType.Prepay:
                        rb_not_done.Checked = true;
                        break;
                    case (int)Models.Constants.OrderType.Completed:
                        rb_done.Checked = true;
                        break;
                }
            }
            // load order details to dgOrderDetail
            dgOrderDetail.Rows.Clear();
            foreach (OrderDetail orderDetail in orderDetails)
            {
                var product = _productService.FindById(orderDetail.ProductId);
                dgOrderDetail.Rows.Add(product.Name, orderDetail.Quantity, new TextCurrency
                {
                    CultureInfor = TextCurrency.VIETNAM,
                    Value = orderDetail.Price,
                    Format = TextCurrency.NO_DECIMAL
                });
            }
        }

        private void Load_Order()
        {
            dgOrders.Rows.Clear();
            dgOrderDetail.Rows.Clear();
            DateTime now = dt_date.Value;
            List<Models.Order> ordersPaid = _orderService.FindAllOrderEquip(now);
            if (ordersPaid == null || ordersPaid.Count() == 0)
            {

                MessageBox.Show($"Không có dữ liệu cho ngày {now.ToString("dd/MM/yyyy")}", "Thông báo");
                return;
            }
            int i = 0;
            double total = 0;
            foreach (Models.Order order in ordersPaid)
            {
                total += order.Price;
                dgOrders.Rows.Add(i + 1,
                    $"{Models.Order.PREFIX}{order.Id}",
                    order.CreatedAt,
                    order.RefundedAt,
                    new TextCurrency
                    {
                        CultureInfor = TextCurrency.VIETNAM,
                        Value = order.Price,
                        Format = TextCurrency.NO_DECIMAL
                    },
                    order.Note); ;
                i++;
            }

            lb_total_day.Text = new TextCurrency
            {
                CultureInfor = TextCurrency.VIETNAM,
                Value = total,
                Format = TextCurrency.NO_DECIMAL
            }.ToString();

            lb_order_paid.Text = ordersPaid.Count().ToString();

        }

        private void OrdersEquipment_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            Load_Order();
        }

        private void dt_date_ValueChanged(object sender, EventArgs e)
        {
            Load_Order();
        }
    }
}
