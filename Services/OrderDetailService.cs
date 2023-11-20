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
        private readonly Helpers.DatabaseContext _db;

        private OrderDetailService()
        {
            _db = new Helpers.DatabaseContext();
            _orderDetailRepository = new Repositories.OrderDetailRepository(_db);
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
    }
}
