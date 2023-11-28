using ABC_Bakery.Services;
using ABC_Bakery.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABC_Bakery.Helpers.Utils;

namespace ABC_Bakery.Forms
{
    public partial class OrderDH : Form
    {
        private OrderService _orderService;
        private ProductService _productService;
        public OrderDH()
        {
            InitializeComponent();
            _orderService = OrderService.GetInstance();
            _productService = ProductService.GetInstance();
        }
        private void OrderDH_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            Load_Order();
        }

        private void Load_Order()
        {
            List<Models.Order> ordersPaid = _orderService.FindAllByType((int)Models.Constants.OrderType.Paid);
            ordersPaid = ordersPaid.OrderBy(o => o.CreatedAt).ToList();

            dgOrders.Rows.Clear();
            int i = 0;
            foreach (Models.Order order in ordersPaid)
            {
                dgOrders.Rows.Add(i + 1, $"{Models.Order.PREFIX}{order.Id}", order.CreatedAt, new TextCurrency
                {
                    CultureInfor = TextCurrency.VIETNAM,
                    Value = order.Price,
                    Format = TextCurrency.NO_DECIMAL
                }, order.Note); ;
                i++;
                MessageBox.Show(order.ToString());
            }
        }

        private void dgOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // get order id from row selected
            var orderPrefix = Models.Order.PREFIX;
            int orderId = int.Parse(dgOrders.Rows[e.RowIndex].Cells[1].Value.ToString().Substring(orderPrefix.Length));

            // get order details by order id
            List<Models.OrderDetail> orderDetails = OrderDetailService.GetInstance().FindByOrderId(orderId);
            var orderEntity = _orderService.FindById(orderId);
            if (orderEntity != null)
            {
                switch (orderEntity.Status)
                {
                    case (int)Models.Constants.OrderStatus.Completed:
                        rb_done.Checked = true;
                        rb_delivery.Checked = true;
                        break;
                    case (int)Models.Constants.OrderStatus.Delivered:
                        rb_delivery.Checked = true;
                        break;
                    case (int)Models.Constants.OrderStatus.Pending:
                    case (int)Models.Constants.OrderStatus.Canceled:
                        rb_not_delivery.Checked = true;
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

        private void OrderDH_Activated(object sender, EventArgs e)
        {
            // reload order list
            Load_Order();
        }
    }
}
