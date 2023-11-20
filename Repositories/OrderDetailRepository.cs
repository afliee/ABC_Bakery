using ABC_Bakery.Helpers;
using ABC_Bakery.Models;
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
            throw new NotImplementedException();
        }

        public List<OrderDetail> FindAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(OrderDetail obj)
        {
            throw new NotImplementedException();
        }
    }
}
