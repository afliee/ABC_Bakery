using ABC_Bakery.Helpers;
using ABC_Bakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Bakery.Repositories
{
    internal class OrderRepository : Repository<Models.Order>
    {
        private readonly DatabaseContext _context;

        public OrderRepository(DatabaseContext context)
        {
            this._context = context;
        }
        public bool Create(Order obj)
        {
            try
            {
                this._context.Orders.Add(obj);
                return this._context.SaveChanges() > 0;
            } catch (Exception e)
            {
                // alert log
                Console.WriteLine(e);
                return false;
            }
        }

        public bool Delete(Order obj)
        {
            throw new NotImplementedException();
        }

        public Order Find(int id)
        {
            try
            {
                return _context.Orders.Find(id);
            } catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public List<Order> FindAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Order obj)
        {
            throw new NotImplementedException();
        }

        public List<Order> FindAllByReceiptId(int receiptId)
        {
            try {
                return this._context.Orders.Where(o => o.ReceiptId == receiptId).ToList();
            } catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public List<Order> FindAllByType(int type)
        {
            try
            {
                // find and sort by created_at desc
                return this._context.Orders.Where(o => o.Type == type).OrderByDescending(o => o.CreatedAt).ToList();
            } catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}
