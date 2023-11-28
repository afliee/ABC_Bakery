using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace ABC_Bakery.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }

        public required string Name { get; set; }
        public required string Description { get; set; }
        public required double Price { get; set; }
        public required int Amount { get; set; }
        public required DateTime ExpiredDate { get; set; }
        public static readonly string Prefix = "SP";
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Boolean IsAvailable { get; set; }
        public Boolean IsActived { get; set; }

        public virtual required Category Category { get; set; }
        public virtual ICollection<Image>? Images { get; set; }
        public virtual ICollection<ImportProduct> ImportDetails { get; set; }
        public virtual ICollection<OrderDetail>? OrderDetails { get; set; }

        public Product()
        {
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            this.IsAvailable = true;
            this.IsActived = true;
        }

        public static void Config(ModelBuilder modelBuilder) { 
            modelBuilder.Entity<Product>()
                .Property(p => p.CreatedAt)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Product>()
                .Property(p => p.UpdatedAt)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Product>()
                .HasMany(p => p.Images)
                .WithOne(i => i.Product)
                .HasForeignKey(i => i.ProductId);

            modelBuilder.Entity<Product>()
                .HasMany(p => p.ImportDetails)
                .WithOne(i => i.Product)
                .HasForeignKey(i => i.ProductId);

            //modelBuilder.Entity<Product>()
            //    .HasMany(p => p.OrderDetails)
            //    .WithOne(o => o.Product)
            //    .HasForeignKey(o => o.ProductId);
        }
    }
}