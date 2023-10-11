using ABC_Bakery.Models.Constants;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Bakery.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public int PromotionId { get; set; }
        public int ReceiptId { get; set; }
        public int CashierId { get; set; }
        public double Price { get; set; }
        public required string Name { get; set; }
        public required string Address { get; set; }
        public required OrderType Type { get; set; }
        public required DateTime CreatedAt { get; set; }
        public required DateTime UpdatedAt { get; set; }

        public virtual Promotion Promotion { get; set; }
        public virtual required Receipt Receipt { get; set; }
        public virtual required User Cashier { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public Order()
        {
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
        }

        public static void Config(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .Property(o => o.CreatedAt)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Order>()
                .Property(o => o.UpdatedAt)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Promotion)
                .WithMany(p => p.Orders)
                .HasForeignKey(o => o.PromotionId);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Receipt)
                .WithMany(r => r.Orders)
                .HasForeignKey(o => o.ReceiptId);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Cashier)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.CashierId);

            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderDetails)
                .WithOne(od => od.Order)
                .HasForeignKey(od => od.OrderId);
        }
    }
}
