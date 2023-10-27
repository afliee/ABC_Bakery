using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABC_Bakery.Models.Constants;
using Microsoft.EntityFrameworkCore;

namespace ABC_Bakery.Models
{
    internal class Permission
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public required string Group { get; set; }
        public virtual ICollection<RolePermission> Roles { get; set; }

        public static void Config(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Permission>()
                .Property(p => p.Name)
                .IsRequired();

            modelBuilder.Entity<Permission>()
                .HasIndex(p => p.Name)
                .IsUnique();

            modelBuilder.Entity<Permission>()
                .HasMany(p => p.Roles)
                .WithOne(rp => rp.Permission)
                .HasForeignKey(rp => rp.PermissionId);

            modelBuilder.Entity<Permission>()
                .Property(p => p.Group)
            .HasConversion<string>();
        }
    }
}
