using ABC_Bakery.Helpers;
using ABC_Bakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Bakery.Repositories
{
    internal class CategoryRepository : Repository<Category>
    {
        private readonly DatabaseContext context;

        public CategoryRepository(DatabaseContext db)
        {
            context = db;
        }

        public bool Create(Category obj)
        {
            try
            {
                context.Categories.Add(obj);
                return context.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                Console.Write(e);
                return false;
            }
        }

        public bool Delete(Category obj)
        {
            throw new NotImplementedException();
        }

        public Category Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> FindAll()
        {
            try
            {
                return context.Categories.ToList();
            }
            catch (Exception e)
            {
                Console.Write(e);
                return null;
            }
        }

        public bool Update(Category obj)
        {
            try
            {
                context.Categories.Update(obj);
                return context.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                Console.Write(e);
                return false;
            }
        }

        public Category FindByName(string name)
        {
            return context.Categories.Where(c => c.Name == name).FirstOrDefault();
        }

        public bool Save() => context.SaveChanges() > 0;
    }
}
