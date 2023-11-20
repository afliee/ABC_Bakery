using ABC_Bakery.Models.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Bakery.Models
{
    internal class Receipt
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required double Recieved { get; set; }
        public required double Expense { get; set; }
        public required double Total { get; set; }
        public required ReceiptType ReceiptType { get; set; }
        public DateTime CreatedAt { get; set; }
        public static readonly string Prefix = "R";
        public virtual required ICollection<Order> Orders { get; set; }

        public Receipt()
        {
            this.CreatedAt = DateTime.Now;
            this.Orders = new HashSet<Order>();
            this.ReceiptType = ReceiptType.Import;
        }

        public static void Config(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Receipt>()
                .Property(r => r.CreatedAt)
                .HasDefaultValueSql("getdate()");

            //modelBuilder.Entity<Receipt>()
            //    .Property(r => r.Recieved)
            //    .HasConversion<double>()
            //    .HasColumnType("decimal(18,2)");

            //modelBuilder.Entity<Receipt>()
            //    .Property(r => r.Expense)
            //    .HasConversion<decimal>()
            //    .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Receipt>()
                .Property(r => r.Total)
                .HasConversion<double>();

            modelBuilder
                .Entity<Receipt>()
                .HasMany(r => r.Orders)
                .WithOne(o => o.Receipt)
                .HasForeignKey(o => o.ReceiptId);

            //modelBuilder.Entity<Receipt>()
            //    .Property(r => r.ReceiptType)
            //    .HasDefaultValueSql(ReceiptType.Import.ToString());

        }
    }
}
