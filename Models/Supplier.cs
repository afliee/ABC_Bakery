using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Bakery.Models
{
    internal class Supplier
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Phone { get; set; }
        public required string Address { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual required ICollection<Import> Imports { get; set; }

        public Supplier()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        public static void Config(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Supplier>()
                .Property(s => s.CreatedAt)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Supplier>()
                .Property(s => s.UpdatedAt)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Supplier>()
                .HasMany(s => s.Imports)
                .WithOne(i => i.Supplier)
                .HasForeignKey(i => i.SupplierId);
        }
    }
}
