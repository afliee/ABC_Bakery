using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using ABC_Bakery.Models.Constants;
using ABC_Bakery.Services;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace ABC_Bakery.Tests
{
    [TestFixture]
    internal class UpdateOrder_Test
    {
        private OrderService _orderService;

        [SetUp]
        public void Setup()
        {
            _orderService = OrderService.GetInstance();
        }

        [Test]
        public void UpdateOrderNoPayment_Test()
        {
            DateTime now = DateTime.Now;
            var orders = _orderService.FindAllOrderDirect(now);
            if (orders.Count == 0)
            {
                Assert.Pass("No Order");
                return;
            }

            var firstOrder = orders.First();
            var order = _orderService.FindById(firstOrder.Id);

            if (order == null)
            {
                Assert.Pass("Order Not Found");
                return;
            }

            order.Type = (int)OrderType.Completed;
            order.Note = "Test";
            order.Address = "Test";

            _orderService.Update(order);

            var updatedOrder = _orderService.FindById(order.Id);

            ClassicAssert.AreEqual(order.Type, updatedOrder.Type);
            ClassicAssert.AreEqual(order.Note, updatedOrder.Note);
            ClassicAssert.AreEqual(order.Address, updatedOrder.Address);
        }


        [Test]
        public void UpdateOrderPrePlaceNoPayment_Test()
        {
            DateTime now = DateTime.Now;
            var orders = _orderService.FindAllOrderPrePlaceNoPayment(now);
            if (orders.Count == 0)
            {
                Assert.Pass("No Order");
                return;
            }

            var firstOrder = orders.First();
            var order = _orderService.FindById(firstOrder.Id);

            if (order == null)
            {
                Assert.Pass("Order Not Found");
                return;
            }

            order.Type = (int)OrderType.Completed;
            order.Status = (int)OrderStatus.Completed;
            order.Note = "Test";
            order.Address = "Test";

            _orderService.Update(order);

            var updatedOrder = _orderService.FindById(order.Id);

            ClassicAssert.AreEqual(order.Type, updatedOrder.Type);
            ClassicAssert.AreEqual(order.Note, updatedOrder.Note);
            ClassicAssert.AreEqual(order.Address, updatedOrder.Address);
            ClassicAssert.AreEqual(order.Status, updatedOrder.Status);
        }

        [Test]
        public void UpdateOrderEquipNoPayment_Test()
        {
            DateTime now = DateTime.Now;
            var orders = _orderService.FindAllOrderEquipNoPayment(now);
            if (orders.Count == 0)
            {
                Assert.Pass("No Order");
                return;
            }

            var firstOrder = orders.First();
            var order = _orderService.FindById(firstOrder.Id);

            if (order == null)
            {
                Assert.Pass("Order Not Found");
                return;
            }

            order.Type = (int)OrderType.Completed;
            order.Status = (int)OrderStatus.Completed;
            order.Note = "Test";
            order.Address = "Test";

            _orderService.Update(order);

            var updatedOrder = _orderService.FindById(order.Id);

            ClassicAssert.AreEqual(order.Type, updatedOrder.Type);
            ClassicAssert.AreEqual(order.Note, updatedOrder.Note);
            ClassicAssert.AreEqual(order.Address, updatedOrder.Address);
            ClassicAssert.AreEqual(order.Status, updatedOrder.Status);
        }
    }
}
