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
            throw new NotImplementedException();
        }

        public List<Order> FindAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Order obj)
        {
            throw new NotImplementedException();
        }
    }
}
