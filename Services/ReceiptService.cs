using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABC_Bakery.Models;
using ABC_Bakery.Helpers;
using ABC_Bakery.Repositories;
using ABC_Bakery.Models.Constants;

namespace ABC_Bakery.Services
{
    internal class ReceiptService
    {
        private readonly DatabaseContext _db;
        private static ReceiptService _instance;
        private readonly ReceiptRepository _receiptRepository;
        private ReceiptService()
        {
            _db = new DatabaseContext();
            _receiptRepository = new ReceiptRepository(_db);
        }

        public static ReceiptService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ReceiptService();
            }
            return _instance;
        }

        public bool Create(Receipt obj)
        {
            return _receiptRepository.Create(obj);
        }

        public Receipt FindByCreatedDayAndReceiptType(DateTime date, int type)
        {
            return _receiptRepository.FindByCreatedDayAndReceiptType(date, type);
        }
    }
}
