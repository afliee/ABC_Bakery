using ABC_Bakery.Helpers;
using ABC_Bakery.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Bakery.Repositories
{
    internal class PromotionRepository : Repository<Promotion>
    {
        private readonly DatabaseContext _context;

        public PromotionRepository(DatabaseContext context)
        {
            _context = context;
        }

        public bool Create(Promotion obj)
        {
            try
            {
                _context.Promotions.Add(obj);
                _context.SaveChanges();
                return true;
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool Delete(Promotion obj)
        {
            throw new NotImplementedException();
        }

        public Promotion Find(int id)
        {
            return _context.Promotions.Find(id);
        }

        public List<Promotion> FindAll()
        {
            return _context.Promotions.ToList();
        }

        public bool Update(Promotion obj)
        {
            try
            {
                this._context.Promotions.Update(obj);
                this._context.SaveChanges();
                return true;
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public Promotion FindByName(string name)
        {
            return _context.Promotions.Where(p => p.Name == name).FirstOrDefault();
        }

        public Promotion FindByNameToLower(string name)
        {
            return _context.Promotions.Where(p => p.Name.ToLower().Equals(name.ToLower())).FirstOrDefault();
        }

        public Promotion FindByCode(string code)
        {
            var promotions = _context.Promotions.Where(p => p.Code == code).ToList();
            if (promotions.Count == 0)
            {
                return null;
            }

            if (promotions.Count == 1)
            {
                return promotions.First();
            }

            var promotion = promotions.Where(p => p.ExpiredAt >= DateTime.Now).FirstOrDefault();
            if (promotion == null)
            {
                return null;
            }
            return promotion;
        }

        public Promotion FindByCodeExistBeforeOrEqualDate(string code, DateTime date)
        {
            return _context.Promotions.Where(p => p.Code == code && p.ExpiredAt >= date).FirstOrDefault();
        }

        public bool UpdateStatus(int id, bool status)
        {
            try
            {
                //var promotion = this._context.Promotions.Where(p => p.Id == id).ExecuteUpdate(p => p.SetProperty(x => x.IsActived, status));

                //return true;
                var promotion = Find(id);
                if (promotion == null)
                {
                    return false;
                }

                promotion.IsActived = status;
                this._context.Promotions.Update(promotion);
                this._context.SaveChanges();
                return true;
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
