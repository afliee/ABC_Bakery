using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Bakery.Models
{
    internal class RolePermission
    {
       public int RoleId { get; set; }
        public int PermissionId { get; set; }

        public virtual  Role Role { get; set; }
        public virtual  Permission Permission { get; set; }

        public RolePermission() { }

        public RolePermission(int roleId, int permissionId)
        {
            RoleId = roleId;
            PermissionId = permissionId;
        }
        public RolePermission(Role role, Permission permission)
        {
            Role = role;
            Permission = permission;
        }

        public static void Config(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RolePermission>()
                .HasKey(rp => new { rp.RoleId, rp.PermissionId });
        }
    }

    
}
