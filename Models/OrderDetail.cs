using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Bakery.Models
{
    internal class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Order? Order { get; set; }
        public virtual Product? Product { get; set; }

        public OrderDetail()
        {
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
        }


        public static void Config(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>()
                .Property(od => od.CreatedAt)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<OrderDetail>()
                .Property(od => od.UpdatedAt)
                .HasDefaultValueSql("getdate()");

            //modelBuilder.Entity<OrderDetail>()
            //    .HasKey(od => new { od.OrderId, od.ProductId });

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderId);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Product)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(od => od.ProductId);
        }

        public override string ToString()
        {
            return $"OrderDetail: Id={Id}, OrderId={OrderId}, ProductId={ProductId}, Quantity={Quantity}, Price={Price}, Total={Total}, CreatedAt={CreatedAt}, UpdatedAt={UpdatedAt}";
        }
    }
}
