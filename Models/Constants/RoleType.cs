using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Bakery.Models.Constants
{
    internal class RoleType : Enumeration<RoleType>
    {
        public static readonly RoleType Admin = new RoleType(1, "Admin");
        public static readonly RoleType Accounting = new RoleType(2, "Accounting");
        public static readonly RoleType Cashier = new RoleType(3, "Cashier");

        public RoleType(int id, string name) : base(id, name)
        {
        }
    }
}
