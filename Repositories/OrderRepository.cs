using ABC_Bakery.Helpers;
using ABC_Bakery.Models;
using ABC_Bakery.Models.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Bakery.Repositories
{
    internal class OrderRepository : Repository<Order>
    {
        private readonly DatabaseContext _context;
        private readonly ProductRepository _productRepository;
        private readonly OrderDetailRepository _orderDetailRepository;

        public OrderRepository(DatabaseContext context)
        {
            _context = context;
            _productRepository = new ProductRepository(context);
        }
        public bool Create(Order obj)
        {
            try
            {
                switch (obj.RecordType)
                {
                    case (int)OrderRecordType.Direct:
                    case (int)OrderRecordType.Equipment:
                        if (obj.Type == (int)OrderType.Paid || obj.Type == (int)OrderType.Completed)
                        {
                            if (obj.OrderDetails != null)
                            {
                                foreach (var orderDetail in obj.OrderDetails)
                                {
                                    // update product quantity
                                    Product product = _productRepository.Find(orderDetail.ProductId);
                                    if (product != null && orderDetail != null)
                                    {
                                        product.Amount -= orderDetail.Quantity;
                                        _productRepository.Update(product);
                                    }
                                }
                            }
                        }
                        break;
                }
                _context.Orders.Add(obj);

                return _context.SaveChanges() > 0;
            }
            catch (Exception e)
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
            }
            catch (Exception e)
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
            try
            {
                if (obj.Type == (int)OrderType.Paid || obj.Type == (int)OrderType.Completed)
                {
                    if (obj.OrderDetails != null)
                    {
                        foreach (var orderDetail in obj.OrderDetails)
                        {
                            // update product quantity
                            Product product = _productRepository.Find(orderDetail.ProductId);
                            if (product != null && orderDetail != null)
                            {
                                product.Amount -= orderDetail.Quantity;
                                _productRepository.Update(product);
                            }
                        }
                    }
                }

                _context.Orders.Update(obj);

                return _context.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public List<Order> FindAllByReceiptId(int receiptId)
        {
            try
            {
                return _context.Orders.Where(o => o.ReceiptId == receiptId).ToList();
            }
            catch (Exception e)
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
                return _context.Orders.Where(o => o.Type == type).OrderByDescending(o => o.CreatedAt).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public List<Order> FindAllByRecordType(int recordType)
        {
            try
            {
                // find and sort by created_at desc
                return _context.Orders.Where(o => o.RecordType == recordType).OrderByDescending(o => o.CreatedAt).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public List<Order> FindAllByRecordTypeAndType(int recordType, int type)
        {
            try
            {
                // find and sort by created_at desc
                return _context.Orders.Where(o => o.RecordType == recordType && o.Type == type).OrderByDescending(o => o.CreatedAt).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public List<Order> FindAllByRepordTypeAndTypeInDate(int recordType, int type, DateTime date)
        {
            try
            {

                // format datetime to yyyy-MM-dd
                string dateStr = date.ToString("dd/MM/yyyy");
                List<Order> orders = FindAllByRecordType(recordType);
                // find and sort by created_at desc
                // find all by repord type and type with date in this 
                return orders.Where(o => o.CreatedAt.ToString("dd/MM/yyyy").Equals(dateStr) && o.Type == type).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public int Count()
        {
            return _context.Orders.Count();
        }
    }
}
