using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Bakery.Models
{
    internal class ImportProduct
    {
        public int ProductId { get; set; }
        public int ImportId { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }

        public virtual required Product Product { get; set; }
        public virtual required Import Import { get; set; }

        public ImportProduct()
        {
            this.Price = 0;
            this.Amount = 0;
        }

        public static void Config(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ImportProduct>()
                .Property(ip => ip.Price)
                .HasConversion<decimal>()
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<ImportProduct>()
                .HasKey(ip => new { ip.ProductId, ip.ImportId });
        }

    }
}
