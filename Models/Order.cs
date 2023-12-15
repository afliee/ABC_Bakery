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
        public static readonly string PREFIX = "OD";
        public int Id { get; set; }
        public int? PromotionId { get; set; }
        public int? ReceiptId { get; set; }
        public int? CashierId { get; set; }
        public double Price { get; set; }
        public double Deposit { get; set; }
        public string Note { get; set; }
        public required string Name { get; set; }
        public required string Address { get; set; }
        public required int Type { get; set; }
        public required int Status { get; set; }
        public required int RecordType { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime RefundedAt { get; set; }

        public virtual Promotion Promotion { get; set; }
        public virtual Receipt? Receipt { get; set; }
        public virtual User? Cashier { get; set; }
        public virtual ICollection<OrderDetail>? OrderDetails { get; set; }

        public Order()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
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
                .Property(o => o.RefundedAt)
                .HasDefaultValueSql("getdate()");
            // allow null for promotion attribute
            //modelBuilder.Entity<Order>()
            //    .Property(o => o.PromotionId)
            //    .IsRequired(false);

            //modelBuilder.Entity<Order>()
            //    .HasOne(o => o.Promotion)
            //    .WithMany(p => p.Orders)
            //    .HasForeignKey(o => o.PromotionId);

            //modelBuilder.Entity<Order>()
            //    .HasOne(o => o.Receipt)
            //    .WithMany(r => r.Orders)
            //    .HasForeignKey(o => o.ReceiptId);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Cashier)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.CashierId);

            //modelBuilder.Entity<Order>()
            //    .HasMany(o => o.OrderDetails)
            //    .WithOne(od => od.Order)
            //    .HasForeignKey(od => od.OrderId);
        }

        public override string ToString()
        {
            if (OrderDetails != null)
            {
                string orderDetails = "";
                foreach (OrderDetail orderDetail in OrderDetails)
                {
                    orderDetails += orderDetail.ToString();
                }
                return $"Order: {Id}, {Name}, {Address}, {Type}, {CreatedAt}, {UpdatedAt}, {orderDetails}";
            }
            else
            {
                return $"Order: {Id}, {Name}, {Address}, {Type}, {CreatedAt}, {UpdatedAt}, ";
            }
        }
    }
}
