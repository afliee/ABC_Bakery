using ABC_Bakery.Helpers;
using ABC_Bakery.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Bakery.Repositories
{
    internal class OrderDetailRepository : Repository<OrderDetail>
    {
        private readonly DatabaseContext _context;

        public OrderDetailRepository(DatabaseContext context)
        {
            this._context = context;
        }
        public bool Create(OrderDetail obj)
        {
            try
            {
                this._context.OrderDetails.Add(obj);
                return this._context.SaveChanges() > 0;
            } catch (Exception e)
            {
                Console.Write(e.ToString());
                return false;
            }
        }

        public bool Delete(OrderDetail obj)
        {
            throw new NotImplementedException();
        }

        public OrderDetail Find(int id)
        {
            return this._context.OrderDetails.Find(id);
        }

        public List<OrderDetail> FindAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(OrderDetail obj)
        {
            try
            {
                this._context.OrderDetails.Update(obj);
                return this._context.SaveChanges() > 0;
            } catch (Exception e)
            {
                Console.Write(e.ToString());
                return false;
            }
        }

        public bool UpdateQuantity(int orderDetailId, int quantity)
        {
            try
            {
                var orderDetail = Find(orderDetailId);
                if (orderDetail == null)
                {
                    return false;
                }


                this._context.OrderDetails.Where(od => od.Id == orderDetailId).ExecuteUpdate(entity => entity.SetProperty(od => od.Quantity, quantity));

                this._context.OrderDetails.Where(od => od.Id == orderDetailId).ExecuteUpdate(entity => entity.SetProperty(od => od.Total, quantity * orderDetail.Price));

                return true;
            } catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public List<OrderDetail> FindByOrderId(int orderId)
        {
            return this._context.OrderDetails.Where(od => od.OrderId == orderId).ToList();
        }

        public int CountProductByOrderId(int orderId)
        {
            var ordersDetail = this._context.OrderDetails.Where(od => od.OrderId == orderId).ToList();

            if (ordersDetail == null)
            {
                return 0;
            }

            return ordersDetail.Sum(od => od.Quantity);
        }
    }
}
