using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABC_Bakery.Models;
using ABC_Bakery.Services;
using ABC_Bakery.Models;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace ABC_Bakery.Tests
{
    [TestFixture]
    internal class AddProduct_Test
    {
        private ProductService _productService;
        private CategoryService _categoryService;
        [SetUp]
        public void Setup()
        {
            _productService = ProductService.GetInstance();
            _categoryService = CategoryService.GetInstance();
        }

        [Test]
        public void AddNewProduct_Test()
        {
            string Product_Name = "Bánh Mì Kem Dừa";

            var category = _categoryService.FindByname("Bánh Mì");
            if (category == null)
            {
                category = new Category
                {
                    Id = 1,
                    Name = "Bánh Mì",
                    Products = new List<Product>()
                };
            }

            var product = _productService.FindByName(Product_Name);
            if (product != null)
            {
                // pass
                Assert.Pass("Product Already Exist");
                return;
            }


            product = new Product
            {
                Name = Product_Name,
                Price = 10000,
                CategoryId = category.Id,
                Amount = 50,
                Description = "Bánh Mì Kem Dừa",
                ExpiredDate = DateTime.Now.AddDays(7),
            };

            _productService.Create(product);

            // assert
            var productCreated = _productService.FindByName(Product_Name);
            ClassicAssert.AreEqual(productCreated.Name, Product_Name);
        }

        [Test]
        public void FindAllProductNearMinimumQuantity_Test()
        {
            // arrange
            int minimumQuantity = 10;

            // act
            var products = _productService.FindProductNearMinimumQuantity();


            // assert
            foreach (var product in products)
            {
                ClassicAssert.IsTrue(product.Amount <= minimumQuantity);
            }
        }
    }
}
