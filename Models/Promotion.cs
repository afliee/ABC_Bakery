using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Bakery.Models
{
    internal class Promotion
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Code { get; set; }
        public int Ratio { get; set; }
        public Boolean IsActived { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        
        public virtual ICollection<Order>? Orders { get; set; }

        public Promotion()
        {
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
        }

        public static void Config(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Promotion>()
                .Property(p => p.CreatedAt)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Promotion>()
                .Property(p => p.UpdatedAt)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Promotion>()
                .HasMany(p => p.Orders)
                .WithOne(o => o.Promotion)
                .HasForeignKey(o => o.PromotionId);
        }
    }
}
