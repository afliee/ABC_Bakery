﻿using ABC_Bakery.Helpers;
using ABC_Bakery.Repositories;
using ABC_Bakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Bakery.Services
{
    internal class OrderService
    {
        private static OrderService _instance = null;
        private readonly DatabaseContext _db;
        private readonly OrderRepository _orderRepository;

        private OrderService()
        {
            _db = new DatabaseContext();
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

        public List<Order> FindAllByReceiptId(int receiptId)
        {
            return _orderRepository.FindAllByReceiptId(receiptId);
        }

        public List<Order> FindAllByType(int type)
        {
            return _orderRepository.FindAllByType(type);
        }

        public Order FindById(int id)
        {
            return _orderRepository.Find(id);
        }
    }
}
