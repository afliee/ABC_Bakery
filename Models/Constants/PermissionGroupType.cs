using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Bakery.Models.Constants
{
    internal class PermissionGroupType : Enumeration<PermissionGroupType>
    {
        public static readonly PermissionGroupType UserManagement = new PermissionGroupType(1, "Quản lý người dùng");
        public static readonly PermissionGroupType RoleManagement = new PermissionGroupType(2, "Quản lý vai trò");
        public static readonly PermissionGroupType ProductManagement = new PermissionGroupType(2, "Quản lý sản phẩm");
        public static readonly PermissionGroupType OrderManagement = new PermissionGroupType(3, "Quản lý biên nhận");
        public static readonly PermissionGroupType ReportManagement = new PermissionGroupType(4, "Quản lý báo cáo thống kê");

        private PermissionGroupType(int id, string name) : base(id, name)
        {
        }
    }
}
