using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABC_Bakery.Models;
using ABC_Bakery.Helpers;
using ABC_Bakery.Models.Constants;

namespace ABC_Bakery.Repositories
{
    internal class ReceiptRepository : Repository<Receipt>
    {
        private readonly DatabaseContext _db;

        public ReceiptRepository(DatabaseContext db)
        {
            _db = db;
        }

        public bool Create(Receipt obj)
        {
            try
            {
                this._db.Receipts.Add(obj);
                return this._db.SaveChanges() > 0;
            } catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        public bool Delete(Receipt obj)
        {
            throw new NotImplementedException();
        }

        public Receipt Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<Receipt> FindAll()
        {
            return this._db.Receipts.ToList();
        }

        public List<Receipt> FindAllByReceiptType(int type)
        {
            return this._db.Receipts.Where(r => r.ReceiptType == (ReceiptType)type).ToList();
        }

        public bool Update(Receipt obj)
        {
            throw new NotImplementedException();
        }

        public Receipt FindByCreatedDayAndReceiptType(DateTime date, int type)
        {
            List<Receipt> ret = this.FindAll();
            string dateStr = date.ToString("dd/MM/yyyy");
            return ret.FirstOrDefault(r => r.CreatedAt.ToString("dd/MM/yyyy").Equals(dateStr) && r.ReceiptType == (ReceiptType)type);
        }
    }
}
