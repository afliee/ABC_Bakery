using ABC_Bakery.Helpers;
using ABC_Bakery.Models;
using ABC_Bakery.Repositories;
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
        private readonly OrderDetailRepository _orderDetailRepository;
        private readonly ProductRepository _productRepository;
        private readonly DatabaseContext _db;

        private OrderDetailService()
        {
            //_db = new Helpers.DatabaseContext();
            _db = SingletonContext.GetInstance().GetDatabaseContext();
            _orderDetailRepository = new OrderDetailRepository(_db);
            _productRepository = new ProductRepository(_db);
        }

        public static OrderDetailService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new OrderDetailService();
            }
            return _instance;
        }

        public bool Create(OrderDetail obj)
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

        public bool UpdateQuantity(int orderDetailId, int quantity)
        {
            return _orderDetailRepository.UpdateQuantity(orderDetailId, quantity);
        }

        public int CountProductByOrderId(int orderId)
        {
            return _orderDetailRepository.CountProductByOrderId(orderId);
        }
    }
}
