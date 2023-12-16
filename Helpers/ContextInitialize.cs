using ABC_Bakery.Models;
using ABC_Bakery.Models.Constants;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Bakery.Helpers
{
    internal class ContextInitialize
    {
        private readonly ModelBuilder ModelBuilder;

        public ContextInitialize(ModelBuilder modelBuilder)
        {
            ModelBuilder = modelBuilder;
        }

        public void Seed()
        {
            Console.WriteLine("ContextInitialize.Seed()");
            ModelBuilder.Entity<Role>().HasData(
                new Role { Name = "Admin", Id = 1 },
                new Role { Name = "Cashier", Id = 2 },
                new Role { Name = "Accounting", Id = 3 }
            );

            ModelBuilder.Entity<User>().HasData(
                    new User
                    {
                        Name = "Admin",
                        Password = "admin",
                        RoleId = 1,
                        Id = 1
                    },
                    new User
                    {
                        Name = "Cashier",
                        Password = "cashier",
                        RoleId = 2,
                        Id = 2
                    },
                    new User
                    {
                        Name = "Accounting",
                        Password = "accounting",
                        RoleId = 3,
                        Id = 3
                    }
                );

            ModelBuilder.Entity<Category>().HasData(
                    new Category { Name = "Bánh Mì", Products = new List<Product>(), Id = 1 },
                    new Category { Name = "Bánh Ngọt", Products = new List<Product>(), Id = 2 },
                    new Category { Name = "Bánh Kem Nhỏ", Products = new List<Product>(), Id = 3 },
                    new Category { Name = "Bánh Kem", Products = new List<Product>(), Id = 4 },
                    new Category { Name = "Bánh Đóng Gói", Products = new List<Product>(), Id = 5 },
                    new Category { Name = "Bánh Bao", Products = new List<Product>(), Id = 6 },
                    new Category { Name = "Bánh Theo Mùa", Products = new List<Product>(), Id = 7 },
                    new Category { Name = "Thiết bị, Dụng cụ", Products = new List<Product>(), Id = 8 }
                );

            ModelBuilder.Entity<Promotion>().HasData(
                    new Promotion { Name = "Không có", Code = "NONE", Ratio = 0, IsActived = true, ExpiredAt = DateTime.Now.AddDays(6), Id = 1 },
                    new Promotion { Name = "Giảm 10%", Code = "ABCNGON", Ratio = 10, IsActived = true, ExpiredAt = DateTime.Now.AddDays(6), Id = 2 },
                    new Promotion { Name = "Giảm 20%", Code = "LATEAM", Ratio = 20, IsActived = true, ExpiredAt = DateTime.Now.AddDays(6), Id = 3 }
                );

            ModelBuilder.Entity<Receipt>().HasData(
                new Receipt
                {
                    Id = 1,
                    Name = string.Format("Hóa đơn thu ngày {0}", DateTime.Now.ToString("dd/MM/yyyy")),
                    Recieved = 0,
                    Expense = 0,
                    Total = 0,
                    ReceiptType = ReceiptType.Import,
                    Orders = new List<Order>()
                },
            new Receipt
            {
                Id = 2,
                Name = string.Format("Hóa đơn chi ngày {0}", DateTime.Now.ToString("dd/MM/yyyy")),
                Recieved = 0,
                Expense = 0,
                Total = 0,
                ReceiptType = ReceiptType.Export,
                Orders = new List<Order>()
            },
            new Receipt
            {
                Id = 3,
                Name = string.Format("Hóa đơn thu ngày {0}", DateTime.Now.AddDays(1).ToString("dd/MM/yyyy")),
                Recieved = 0,
                Expense = 0,
                Total = 0,
                ReceiptType = ReceiptType.Import,
                Orders = new List<Order>()
            },

            new Receipt
            {
                Id = 4,
                Name = string.Format("Hóa đơn chi ngày {0}", DateTime.Now.AddDays(1).ToString("dd/MM/yyyy")),
                Recieved = 0,
                Expense = 0,
                Total = 0,
                ReceiptType = ReceiptType.Export,
                Orders = new List<Order>()
            }
            );

            ModelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Amount = 50,
                    CategoryId = 1,
                    Description = "Bánh mì thịt nguội",
                    Name = "Bánh mì thịt nguội",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 2,
                    Amount = 50,
                    CategoryId = 1,
                    Name = "Bánh mì que",
                    Description = "Bánh mì que",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 3,
                    Amount = 50,
                    CategoryId = 1,
                    Name = "Bánh mì phô mai",
                    Description = "Bánh mì phô mai",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 4,
                    Amount = 10,
                    CategoryId = 8,
                    Name = "Bộ đồ làm bánh",
                    Description = "Bộ đồ làm bánh",
                    Price = 100000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                { 
                    Amount = 50,
                    Id = 5,
                    CategoryId = 1,
                    Name = "Bánh Mì Salad",
                    Description = "Bánh Mì Salad",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 6,
                    Amount = 50,
                    CategoryId = 1,
                    Name = "Bánh Mì Salad Kẹp",
                    Description = "Bánh Mì Salad Kẹp",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 7,
                    Amount = 50,
                    CategoryId = 1,
                    Name = "Bánh Đan Mạch Xúc Xích",
                    Description = "Bánh Đan Mạch Xúc Xích",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 8,
                    Amount = 50,
                    CategoryId = 1,
                    Name = "Bánh Mì Châu Âu",
                    Description = "Bánh Mì Châu Âu",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 9,
                    Amount = 50,
                    CategoryId = 1,
                    Name = "Pizza Xúc Xích",
                    Description = "Pizza Xúc Xích",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 10,
                    Amount = 50,
                    CategoryId = 1,
                    Name = "Bánh Mì Sốt Nắm",
                    Description = "Bánh Mì Sốt Nắm",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 11,
                    Amount = 50,
                    CategoryId = 1,
                    Name = "Jambon Phô Mai",
                    Description = "Jambon Phô Mai",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 12,
                    Amount = 50,
                    CategoryId = 1,
                    Name = "Pizza ABC",
                    Description = "Pizza ABC",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 13,
                    Amount = 50,
                    CategoryId = 1,
                    Name = "Bánh Mì",
                    Description = "Bánh Mì",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 14,
                    Amount = 50,
                    CategoryId = 2,
                    Name = "Đan Mạch Hạnh Nhân",
                    Description = "Đan Mạch Hạnh Nhân",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 15,
                    Amount = 50,
                    CategoryId = 2,
                    Name = "Đan Mạch Socola Bar",
                    Description = "Đan Mạch Socola Bar",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 16,
                    Amount = 50,
                    CategoryId = 2,
                    Name = "Đậu Xanh Blueberry",
                    Description = "Đậu Xanh Blueberry",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 17,
                    Amount = 50,
                    CategoryId = 2,
                    Name = "Sữa Môn",
                    Description = "Sữa Môn",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 18,
                    Amount = 50,
                    CategoryId = 2,
                    Name = "Sú Chocolate Chip",
                    Description = "Sú Chocolate Chip",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 19,
                    Amount = 50,
                    CategoryId = 2,
                    Name = "Sâu Kem",
                    Description = "Sâu Kem",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 20,
                    Amount = 50,
                    CategoryId = 2,
                    Name = "Lưới Dừa",
                    Description = "Lưới Dừa",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 21,
                    Amount = 50,
                    CategoryId = 2,
                    Name = "Su Kem",
                    Description = "Su Kem",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 22,
                    Amount = 50,
                    CategoryId = 2,
                    Name = "Croissant",
                    Description = "Croissant",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 23,
                    Amount = 50,
                    CategoryId = 3,
                    Name = "Orange Vani",
                    Description = "Orange Vani",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 24,
                    Amount = 50,
                    CategoryId = 3,
                    Name = "Blueberry Vani",
                    Description = "Blueberry Vani",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 25,
                    Amount = 50,
                    CategoryId = 3,
                    Name = "Strawberry Dome",
                    Description = "Strawberry Dome",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 26,
                    Amount = 50,
                    CategoryId = 3,
                    Name = "Chocolate Cocoa",
                    Description = "Chocolate Cocoa",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 27,
                    Amount = 50,
                    CategoryId = 3,
                    Name = "Bánh Cà Rốt",
                    Description = "Bánh Cà Rốt",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 28,
                    Amount = 50,
                    CategoryId = 3,
                    Name = "Mini Black Forest",
                    Description = "Mini Black Forest",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 29,
                    Amount = 50,
                    CategoryId = 3,
                    Name = "Marble Cheesecake",
                    Description = "Marble Cheesecake",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 30,
                    Amount = 50,
                    CategoryId = 3,
                    Name = "Lemon Cream Cake",
                    Description = "Lemon Cream Cake",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 31,
                    Amount = 50,
                    CategoryId = 3,
                    Name = "Chocolate Almond Cake",
                    Description = "Chocolate Almond Cake",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 32,
                    Amount = 50,
                    CategoryId = 5,
                    Name = "Sandwich",
                    Description = "Sandwich",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 33,
                    Amount = 50,
                    CategoryId = 5,
                    Name = "Bánh Mì Lúa Mạch",
                    Description = "Bánh Mì Lúa Mạch",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 34,
                    Amount = 50,
                    CategoryId = 5,
                    Name = "Bánh Mì Hamburger",
                    Description = "Bánh Mì Hamburger",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 35,
                    Amount = 50,
                    CategoryId = 5,
                    Name = "Lexus",
                    Description = "Lexus",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 36,
                    Amount = 50,
                    CategoryId = 5,
                    Name = "Bánh Cua Mini",
                    Description = "Bánh Cua Mini",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 37,
                    Amount = 50,
                    CategoryId = 5,
                    Name = "Bánh Mì Sáu Múi",
                    Description = "Bánh Mì Sáu Múi",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 38,
                    Amount = 50,
                    CategoryId = 5,
                    Name = "Cookies Dừa",
                    Description = "Cookies Dừa",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 39,
                    Amount = 50,
                    CategoryId = 5,
                    Name = "Financier",
                    Description = "Financier",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                },
                new Product
                {
                    Id = 40,
                    Amount = 50,
                    CategoryId = 5,
                    Name = "Bánh mì 10 loại",
                    Description = "Bánh mì 10 loại",
                    Price = 10000,
                    ExpiredDate = DateTime.Now.AddDays(1),
                }
            );
        }
    }
}
