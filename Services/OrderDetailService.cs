using ABC_Bakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Bakery.Services
{
    internal class OrderDetailService
    {
        private static OrderDetailService _instance = null;
        private readonly Repositories.OrderDetailRepository _orderDetailRepository;
        private readonly Repositories.ProductRepository _productRepository;
        private readonly Helpers.DatabaseContext _db;

        private OrderDetailService()
        {
            _db = new Helpers.DatabaseContext();
            _orderDetailRepository = new Repositories.OrderDetailRepository(_db);
            _productRepository = new Repositories.ProductRepository(_db);
        }

        public static OrderDetailService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new OrderDetailService();
            }
            return _instance;
        }

        public bool Create(Models.OrderDetail obj)
        {
            return _orderDetailRepository.Create(obj);
        }

        public List<OrderDetail> FindByOrderId(int id)
        {
            return _orderDetailRepository.FindByOrderId(id);
        }

        public List<Product> FindAllProductsByOrderId(int order_id)
        {
            List<Product> products = new List<Product>();
            List<OrderDetail> orderDetails = FindByOrderId(order_id);
            foreach (OrderDetail orderDetail in orderDetails)
            {
                Product product = _productRepository.Find(orderDetail.ProductId);
                products.Add(product);
            }

            return products;
        }
    }
}
