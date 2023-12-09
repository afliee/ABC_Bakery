using ABC_Bakery.Helpers;
using ABC_Bakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ABC_Bakery.Repositories
{
    internal class ProductRepository : Repository<Product>
    {
        private const int NEAR_EXPIRED_DAYS = 7;
        private const int MINIMUM_QUANTITY = 10;
        private readonly DatabaseContext context;

        public ProductRepository(DatabaseContext db)
        {
            this.context = db;
        }

        public bool Create(Product obj)
        {
            try
            {
                this.context.Products.Add(obj);
                return this.context.SaveChanges() > 0;
            } catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool Delete(Product obj)
        {
            try
            {
                this.context.Products.Remove(obj);
                return this.context.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            } 
        }

        public Product Find(int id)
        {
            return this.context.Products.Find(id);
        }

        public List<Product> FindAll()
        {
            return this.context.Products.ToList();  
        }

        public bool Update(Product obj)
        {
            try
            {
                this.context.Products.Update(obj);
                return this.context.SaveChanges() > 0;
            } catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public Product FindByName(string name)
        {
               return this.context.Products.Where(p => p.Name.Equals(name)).FirstOrDefault();
        }

        public List<Product> FindByNameContains(string name)
        {
            return this.context.Products.Where(p => p.Name.Contains(name)).ToList();
        }

        public List<Product> FindByIdIn(List<int> ids)
        {
            return this.context.Products.Where(p => ids.Contains(p.Id)).ToList();
        }

        public List<Product> FindByNameIgnoreCase(string name)
        {
            return this.context.Products.Where(p => p.Name.ToLower().Equals(name.ToLower())).ToList();
        }
    
        public List<Product> FindProductNearExpired()
        {
            return this.context.Products.Where(p => p.ExpiredDate != null && p.ExpiredDate.Subtract(DateTime.Now).Days <= NEAR_EXPIRED_DAYS).ToList();
        }

        public List<Product> FindProductNearMinimumQuantity()
        {
            return this.context.Products.Where(p => p.Amount <= MINIMUM_QUANTITY).ToList();
        }
    }
}
