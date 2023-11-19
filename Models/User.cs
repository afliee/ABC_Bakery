using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Bakery.Models
{
    internal class User
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Password { get; set; } // TODO: Hash this
        public DateTime CreateAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public required int RoleId { get; set; }

        public virtual  Role Role { get; set; }
        public virtual  ICollection<Order> Orders { get; set; }
        public virtual  ICollection<Import> Imports { get; set; }

        public User()
        {
            this.CreateAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
        }

        public static void Config(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.Name)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.Password)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.CreateAt)
                .HasConversion(
                    v => v.ToString("yyyy-MM-dd HH:mm:ss"),
                    v => DateTime.Parse(v)
                )
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<User>()
                .Property(u => u.UpdatedAt)
                .HasConversion(
                    v => v.ToString("yyyy-MM-dd HH:mm:ss"),
                    v => DateTime.Parse(v)
                )
                .HasDefaultValueSql("getdate()");
            
            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId);

            modelBuilder.Entity<User>()
                .HasMany(o => o.Orders)
                .WithOne(u => u.Cashier)
                .HasForeignKey(u => u.CashierId);
                
        }

    }
}
