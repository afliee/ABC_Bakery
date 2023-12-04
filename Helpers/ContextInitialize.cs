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
            this.ModelBuilder = modelBuilder;
        }

        public void Seed()
        {
            Console.WriteLine("ContextInitialize.Seed()");
            ModelBuilder.Entity<Role>().HasData(
                new Role { Name = "Admin", Id = 1 },
                new Role { Name = "Cashier", Id = 2 },
                new Role { Name = "Accounting", Id = 3}
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
                    new Category { Name = "Bánh Mì", Products = new List<Product>(),Id = 1 },
                    new Category { Name = "Bánh Ngọt", Products = new List<Product>(), Id = 2 },
                    new Category { Name = "Bánh Kem Nhỏ", Products = new List<Product>(), Id = 3 },
                    new Category { Name = "Bánh Kem", Products = new List<Product>(), Id = 4 },
                    new Category { Name = "Bánh Đóng Gói", Products = new List<Product>(), Id = 5 },
                    new Category { Name = "Bánh Bao", Products = new List<Product>(), Id = 6 },
                    new Category { Name = "Bánh Theo Mùa", Products = new List<Product>(), Id = 7},
                    new Category { Name = "Thiết bị, Dụng cụ", Products = new List<Product>(), Id = 8}
                );

            ModelBuilder.Entity<Promotion>().HasData(
                    new Promotion { Name = "Không có", Code = "NONE", Ratio = 0, IsActived = true, Id = 1 },
                    new Promotion { Name = "Giảm 10%", Code = "ABCNGON", Ratio = 10, IsActived = true, Id = 2 },
                    new Promotion { Name = "Giảm 20%", Code = "LATEAM", Ratio = 20, IsActived = true, Id = 3}
                );

            ModelBuilder.Entity<Models.Receipt>().HasData(
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
                Name = string.Format("Hóa đơn thu ngày {0}", DateTime.Now.AddDays(1).ToString("dd/MM/yyyy")),
                Recieved = 0,
                Expense = 0,
                Total = 0,
                ReceiptType = ReceiptType.Import,
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
                }
            );
        }
    }
}
