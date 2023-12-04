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
            _db = SingletonContext.GetInstance().GetDatabaseContext();
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

        public void InitToday()
        {
            DateTime now = DateTime.Now;
            Receipt importReceipt = FindByCreatedDayAndReceiptType(now, (int)ReceiptType.Import);
            Receipt exportReceipt = FindByCreatedDayAndReceiptType(now, (int)ReceiptType.Export);
            //if (importReceipt != null)
            //{
            //    MessageBox.Show("Hóa đơn thu đã được tạo hôm nay", "Thông báo");
            //}
            //if (exportReceipt != null)
            //{
            //    MessageBox.Show("Hóa đơn chi đã được tạo hôm nay", "Thông báo");
            //}
            if (importReceipt == null)
            {
                importReceipt = new Receipt
                {
                    Name = $"Hóa đơn thu ngày {now.ToString("dd/MM/yyyy")}",
                    Expense = 0,
                    Recieved = 0,
                    Total = 0,
                    Orders = new List<Order>(),
                    ReceiptType = ReceiptType.Import
                };
                bool importReceiptRs = Create(importReceipt);
                if (!importReceiptRs)
                {
                    MessageBox.Show("Không thể tạo hóa đơn thu", "Thông báo");
                }
            }

            if (exportReceipt == null)
            {
                exportReceipt = new Receipt
                {
                    Name = $"Hóa đơn chi ngày {now.ToString("dd/MM/yyyy")}",
                    Expense = 0,
                    Recieved = 0,
                    Total = 0,
                    Orders = new List<Order>(),
                    ReceiptType = ReceiptType.Export
                };
                bool exportReceiptRs = Create(exportReceipt);
                if (!exportReceiptRs)
                {
                    MessageBox.Show("Không thể tạo hóa đơn chi", "Thông báo");
                }
            }
        }

        public Receipt FindByCreatedDayAndReceiptType(DateTime date, int type)
        {
            return _receiptRepository.FindByCreatedDayAndReceiptType(date, type);
        }

        public List<Receipt> FindAll()
        {
            return _receiptRepository.FindAll();
        }

        public List<Receipt> FindAllByReceiptType(int type)
        {
            return _receiptRepository.FindAllByReceiptType(type);
        }
    }
}
