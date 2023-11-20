using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Bakery.Models
{
    internal class Category
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual required ICollection<Product> Products { get; set; }

        public Category()
        {
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            Products = new List<Product>();
        }

        public static void Config(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(c => c.CreatedAt)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Category>()
                .Property(c => c.UpdatedAt)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Category>()
                .Property(c => c.Name)
                .IsRequired();
        }

        public override string ToString() => this.Name;
    }
}
