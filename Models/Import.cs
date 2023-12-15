using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Bakery.Models
{
    internal class Import
    {
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public int UserId { get; set; }
        public int Total { get; set; }
        public bool IsInternal { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public required virtual Supplier Supplier { get; set; }
        public required virtual User User { get; set; }
        public virtual required ICollection<ImportProduct> ImportDetails { get; set; }

        public Import()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        public static void Config(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Import>()
                .Property(i => i.CreatedAt)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Import>()
                .Property(i => i.UpdatedAt)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Import>()
                .HasMany(i => i.ImportDetails)
                .WithOne(ip => ip.Import)
                .HasForeignKey(ip => ip.ImportId);

            modelBuilder.Entity<Import>()
                .HasOne(i => i.Supplier)
                .WithMany(s => s.Imports)
                .HasForeignKey(i => i.SupplierId);
        }
    }
}
