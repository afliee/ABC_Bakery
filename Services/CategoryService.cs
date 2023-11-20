using ABC_Bakery.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABC_Bakery.Helpers;
using ABC_Bakery.Repositories;
using ABC_Bakery.Models;
namespace ABC_Bakery.Services
{
    internal sealed class CategoryService
    {
        private static CategoryService _instance = null;
        private readonly DatabaseContext _db;
        private readonly CategoryRepository _categoryRepository;
        private CategoryService()
        {
            _db = new DatabaseContext();
            _categoryRepository = new CategoryRepository(_db);
        }

        public static CategoryService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CategoryService();
            }
            return _instance;
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.FindAll();
        }

        public bool Create(String name)
        {
            if (String.IsNullOrEmpty(name))
            {
                return false;
            }

            Category existCategory = _categoryRepository.FindByName(name);
            if (existCategory != null)
            {
                return false;
            }

            var category = new Category()
            {
                Name = name,
                Products = new List<Product>()
            };
            return _categoryRepository.Create(category);
        }

        public Category FindByname(string name)
        {
            return _categoryRepository.FindByName(name);
        }
    }
}
