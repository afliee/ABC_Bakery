﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABC_Bakery.Models;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace ABC_Bakery.Helpers
{
    internal class DatabaseContext : DbContext
    {
        private static readonly string CONNECTION_STRING = "Data Source=ALFIE;Initial Catalog=ABC_Bakery;Persist Security Info=True;Encrypt=False;User ID=sa;Password=123456";
           
        public DatabaseContext() : base()
        {
            if (!Database.CanConnect())
            {
                Database.EnsureCreated();
            } else
            {
                Database.Migrate();
            }
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) 
        { 
               
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CONNECTION_STRING);
        }


        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Import> Imports { get; set; }
        public DbSet<ImportProduct> ImportDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Models.Image> Images { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            Console.WriteLine("DatabaseContext.OnModelCreating()");
            Role.Config(modelBuilder);
            Permission.Config(modelBuilder);
            RolePermission.Config(modelBuilder);
            User.Config(modelBuilder);
            //Supplier.Config(modelBuilder);
            //Import.Config(modelBuilder);
            ImportProduct.Config(modelBuilder);
            //Product.Config(modelBuilder);
            //Receipt.Config(modelBuilder);
            //Order.Config(modelBuilder);
            OrderDetail.Config(modelBuilder);
            //Promotion.Config(modelBuilder);
            //Models.Image.Config(modelBuilder);

            base.OnModelCreating(modelBuilder);

        }
    }
}