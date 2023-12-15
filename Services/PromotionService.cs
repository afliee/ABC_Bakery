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
    internal class PromotionService
    {
        private static PromotionService _instance = null;
        private readonly PromotionRepository _repository;

        private PromotionService()
        {
            DatabaseContext db = SingletonContext.GetInstance().GetDatabaseContext();
            _repository = new PromotionRepository(db);
        }

        public static PromotionService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new PromotionService();
            }
            return _instance;
        }

        public List<Promotion> GetAll()
        {
            return _repository.FindAll();
        }

        public bool Create(string name, string code, int ratio, DateTime expiredAt)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(code) || ratio < 1 || ratio > 100 || expiredAt < DateTime.Now)
            {
                return false;
            }

            var existPromotion = _repository.FindByName(name);
            if (existPromotion != null)
            {
                return false;
            }

            existPromotion = _repository.FindByCodeExistBeforeOrEqualDate(code, expiredAt);
            if (existPromotion != null)
            {
                return false;
            }

            var promotion = new Promotion()
            {
                Name = name,
                Code = code,
                Ratio = ratio,
                ExpiredAt = expiredAt,
                IsActived = true
            };
            return _repository.Create(promotion);
        }

        public Promotion FindById(int id)
        {
            return _repository.Find(id);
        }

        public bool Update(int id, string name, string code, int ratio, DateTime expiredAt)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(code) || ratio < 1 || ratio > 100 || expiredAt < DateTime.Now)
            {
                return false;
            }

            var existPromotion = _repository.FindByName(name);
            if (existPromotion != null && existPromotion.Id != id)
            {
                return false;
            }

            existPromotion = _repository.FindByCodeExistBeforeOrEqualDate(code, expiredAt);
            if (existPromotion != null && existPromotion.Id != id)
            {
                return false;
            }

            var promotion = _repository.Find(id);
            if (promotion == null)
            {
                return false;
            }

            promotion.Name = name;
            promotion.Code = code;
            promotion.Ratio = ratio;
            promotion.ExpiredAt = expiredAt;
            return _repository.Update(promotion);
        }

        public bool UpdateStatus(int id, bool status)
        {
            return _repository.UpdateStatus(id, status);
        }

        public bool CheckCodeExist(string code)
        {
            return _repository.FindByCode(code) != null;
        }

        public bool CheckCodeExistBeforeOrEqualDate(string code, DateTime date)
        {
            return _repository.FindByCodeExistBeforeOrEqualDate(code, date) != null;
        }

        public Promotion FindByCode(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                return null;
            }

            return _repository.FindByCode(code);
        }
    }
}
