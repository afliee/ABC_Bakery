using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Bakery.Models
{
    internal class Role
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        
        public virtual  ICollection<User> Users { get; set; }
        public virtual  ICollection<RolePermission> Permissions { get; set; } = new List<RolePermission>();
        

        public static void Config(ModelBuilder modelBuilder)
        {
            // id identify auto increment
            modelBuilder.Entity<Role>()
                .Property(r => r.Id)
                .ValueGeneratedOnAdd();
      
            modelBuilder.Entity<Role>()
                .Property(r => r.Name)
                .IsRequired();

            // name unique
            modelBuilder.Entity<Role>()
                .HasIndex(r => r.Name)
                .IsUnique();

            modelBuilder.Entity<Role>()
                .HasMany(r => r.Users)
                .WithOne(u => u.Role)
                .HasForeignKey(u => u.RoleId);

            modelBuilder.Entity<Role>()
                .HasMany(r => r.Permissions)
                .WithOne(rp => rp.Role)
                .HasForeignKey(rp => rp.RoleId);

        }

    }
}
