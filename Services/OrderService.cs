using ABC_Bakery.Helpers;
using ABC_Bakery.Repositories;
using ABC_Bakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABC_Bakery.Models.Constants;

namespace ABC_Bakery.Services
{
    internal class OrderService
    {
        private static OrderService _instance = null;
        private readonly DatabaseContext _db;
        private readonly OrderRepository _orderRepository;

        private OrderService()
        {
            _db = SingletonContext.GetInstance().GetDatabaseContext();
            _orderRepository = new OrderRepository(_db);
        }

        public static OrderService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new OrderService();
            }
            return _instance;
        }

        public bool Create(Models.Order obj)
        {
            return _orderRepository.Create(obj);
        }

        public bool Update(Models.Order obj)
        {
            return _orderRepository.Update(obj);
        }

        public bool UpdatePrice(int id, double price)
        {
            var order = _orderRepository.Find(id);
            order.Price = price;
            return _orderRepository.Update(order);
        }

        public List<Order> FindAllByReceiptId(int receiptId)
        {
            return _orderRepository.FindAllByReceiptId(receiptId);
        }

        public List<Order> FindAllByType(int type)
        {
            return _orderRepository.FindAllByType(type);
        }

        public List<Order> FindAllOrderDirectNoPayment(DateTime date)
        {
            return _orderRepository.FindAllByRepordTypeAndTypeInDate((int)OrderRecordType.Direct, (int)OrderType.Prepay, date);
        }


        public List<Order> FindAllOrderPrePlaceNoPayment(DateTime date)
        {
            return _orderRepository.FindAllByRepordTypeAndTypeInDate((int)OrderRecordType.PreOrder, (int)OrderType.Prepay, date);
        }

        public List<Order> FindAllOrderEquipNoPayment(DateTime date)
        {
            return _orderRepository.FindAllByRepordTypeAndTypeInDate((int)OrderRecordType.Equipment, (int)OrderType.Prepay, date);
        }

        public List<Order> FindAllOrderDirect(DateTime date)
        {
            return _orderRepository.FindAllByRepordTypeAndTypeInDate((int)OrderRecordType.Direct, (int)OrderType.Completed, date);
        }


        public List<Order> FindAllOrderPrePlace(DateTime date)
        {
            return _orderRepository.FindAllByRepordTypeAndTypeInDate((int)OrderRecordType.PreOrder, (int)OrderType.Completed, date);
        }


        public List<Order> FindAllOrderEquip(DateTime date)
        {
            return _orderRepository.FindAllByRepordTypeAndTypeInDate((int)OrderRecordType.Equipment, (int)OrderType.Completed, date);
        }
        public Order FindById(int id)
        {
            return _orderRepository.Find(id);
        }

        public int Count()
        {
            return _orderRepository.Count();
        }
    }
}
