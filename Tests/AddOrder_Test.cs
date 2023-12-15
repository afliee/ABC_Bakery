using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Windows.Forms.VisualStyles;
using NUnit.Framework.Legacy;
using ABC_Bakery.Models;
using ABC_Bakery.Services;
using ABC_Bakery.Models.Constants;

namespace ABC_Bakery.Tests
{
    [TestFixture]
    internal class AddOrder_Test
    {
        private OrderService _orderService;
        private ReceiptService _receiptService;
        [SetUp]
        public void Setup()
        {
            _orderService = OrderService.GetInstance();
            _receiptService = ReceiptService.GetInstance();
        }

        [Test]
        public void AddDirectOrder()
        {
            // arrange
            OrderType orderType = OrderType.Completed;
            string note = "Test";
            int deposit = 0;
            int total = 0;

            // act
            Receipt receipt = ReceiptService.GetInstance().FindByCreatedDayAndReceiptType(DateTime.Now, (int)ReceiptType.Import);
            if (receipt == null)
            {
                receipt = new Receipt
                {
                    Id = 1,
                    Name = string.Format("Hóa đơn thu ngày {0}", DateTime.Now.ToString("dd/MM/yyyy")),
                    Recieved = 0,
                    Expense = 0,
                    Total = 0,
                    ReceiptType = ReceiptType.Import,
                    Orders = new List<Order>()
                };
            }

            Product product = ProductService.GetInstance().FindById(1);
            User cashier = UserService.GetInstance().FindFirstCashier();
            Order orderEntity = new Order
            {
                Address = "",
                CashierId = cashier.Id,
                ReceiptId = receipt.Id,
                Name = string.Format("Hóa Đơn Mã {0}_{1}", Receipt.Prefix, receipt.Id),
                Type = (int)orderType,
                Note = note,
                Deposit = deposit,
                Price = product.Price,
                Status = (int)OrderStatus.Completed,
                RecordType = (int)OrderRecordType.Direct,
            };

            orderEntity.OrderDetails = new List<OrderDetail>
            {
                new OrderDetail
                {
                    OrderId = orderEntity.Id,
                    ProductId = product.Id,
                    Quantity = 1,
                    Price = product.Price,
                    Total = product.Price
                }
            };

            receipt.Orders.Add(orderEntity);

            // assert
            // assert order has been added
            ClassicAssert.AreEqual(1, receipt.Orders.Count);
        }

        [Test]
        public void AddPrePlaceOrder_Test()
        {
            OrderType orderType = OrderType.Completed;
            string note = "Test";
            int deposit = 0;
            int total = 0;

            // act
            Receipt receipt = ReceiptService.GetInstance().FindByCreatedDayAndReceiptType(DateTime.Now, (int)ReceiptType.Import);
            if (receipt == null)
            {
                receipt = new Receipt
                {
                    Id = 1,
                    Name = string.Format("Hóa đơn thu ngày {0}", DateTime.Now.ToString("dd/MM/yyyy")),
                    Recieved = 0,
                    Expense = 0,
                    Total = 0,
                    ReceiptType = ReceiptType.Import,
                    Orders = new List<Order>()
                };
            }

            Product product = ProductService.GetInstance().FindById(1);
            User cashier = UserService.GetInstance().FindFirstCashier();
            Order orderEntity = new Order
            {
                Address = "",
                CashierId = cashier.Id,
                ReceiptId = receipt.Id,
                Name = string.Format("Hóa Đơn Mã {0}_{1}", Receipt.Prefix, receipt.Id),
                Type = (int)orderType,
                Note = note,
                Deposit = deposit,
                Price = product.Price,
                Status = (int)OrderStatus.Completed,
                RecordType = (int)OrderRecordType.PreOrder,
            };

            orderEntity.OrderDetails = new List<OrderDetail>
            {
                new OrderDetail
                {
                    OrderId = orderEntity.Id,
                    ProductId = product.Id,
                    Quantity = 1,
                    Price = product.Price,
                    Total = product.Price
                }
            };

            receipt.Orders.Add(orderEntity);

            // assert
            // assert order has been added
            ClassicAssert.AreEqual((int)OrderType.Completed, orderEntity.Type);
            //assert type of order is PreOrder
            ClassicAssert.AreEqual((int)OrderRecordType.PreOrder, orderEntity.RecordType);
        }
    }
}
