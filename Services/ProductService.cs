using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABC_Bakery.Helpers;
using ABC_Bakery.Repositories;
using ABC_Bakery.Models;
using IronBarCode;
using Image = System.Drawing.Image;
namespace ABC_Bakery.Services
{
    internal enum TextSearchFlag
    {
        TEXT_NORMAL = 1,
        TEXT_IGNORE_CASE = 2,
        TEXT_CONTAINS = 3
    }

    internal class ProductService
    {
        private static ProductService _instance = null;
        private readonly DatabaseContext _db;
        private readonly ProductRepository _productRepository;

        
        private ProductService()
        {
            _db = new DatabaseContext();
            _productRepository = new ProductRepository(_db);
        }

        public static ProductService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ProductService();
            }
            return _instance;
        }

        public List<Product> GetAll()
        {
            return _productRepository.FindAll();
        }

        public Product FindById(int id)
        {
            return _productRepository.Find(id);
        }

        public Product? FindByBarcode(string barcode)
        {
            if (barcode == null) return null;
            if (string.IsNullOrEmpty(barcode)) return null;
            string id = barcode.Substring(Product.Prefix.Length + 1);

            // check id is number
            if (!int.TryParse(id, out int result)) return null;

            var product = _productRepository.Find(result);
            return product.IsActived ? product : null;
        }

        public Image GetBarcode(int id)
        {
            GeneratedBarcode barcode = BarcodeWriter.CreateBarcode(string.Format("{0}_{1}", Product.Prefix, id), BarcodeWriterEncoding.Code128, 200, 60);

            // convert barcode to image
            Image barcodeImage = barcode.Image;
            
            return barcodeImage;
        }

        public List<Product> FindByIdIn(List<int> ids)
        {
            return _productRepository.FindByIdIn(ids);
        }

        public bool Create(Product obj)
        {
            return _productRepository.Create(obj);
        }

        public Product Find(int id)
        {
            return _productRepository.Find(id);
        }

        public Product FindByName(string name)
        {
            return _productRepository.FindByName(name);
        }

        public List<Product> FindByNameContains(string name)
        {
            return _productRepository.FindByNameContains(name);
        }

        public List<Product> FindProductNearExpired()
        {
            return _productRepository.FindProductNearExpired();
        }

        public List<Product> FindProductNearMinimumQuantity()
        {
            return _productRepository.FindProductNearMinimumQuantity();
        }
    }
}
