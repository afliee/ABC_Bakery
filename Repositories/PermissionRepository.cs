using ABC_Bakery.Helpers;
using ABC_Bakery.Models;
using ABC_Bakery.Models.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ABC_Bakery.Repositories
{
    internal class PermissionRepository : Repository<Permission>
    {
        private readonly DatabaseContext _context;

        public PermissionRepository(DatabaseContext context)
        {
            _context = context;
        }

        public bool Create(Permission obj)
        {
            try
            {
                _context.Permissions.Add(obj);
                return _context.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Delete(Permission obj)
        {
            try
            {
                _context.Permissions.Remove(obj);
                return _context.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Permission Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<Permission> FindAll()
        {
            return _context.Permissions.ToList();
        }

        public bool Update(Permission obj)
        {
            throw new NotImplementedException();
        }

        public List<Permission> FindAllByRole(Role role)
        {
            return _context.Permissions
                .Where(p => p.Roles.Any(rp => rp.RoleId == role.Id))
                .ToList();
        }

        public List<Permission> FindByGroup(PermissionGroupType group)
        {
            return _context.Permissions
                .Where(p => p.Group.Equals(group))
                .ToList();
        }

        public void Initialize()
        {
            if (FindAll().Count > 0) return;

            Create(new Permission { Name = "Xem người dùng", Group = PermissionGroupType.UserManagement.Name });
            Create(new Permission { Name = "Thêm người dùng", Group = PermissionGroupType.UserManagement.Name });
            Create(new Permission { Name = "Sửa người dùng", Group = PermissionGroupType.UserManagement.Name });
            Create(new Permission { Name = "Xóa người dùng", Group = PermissionGroupType.UserManagement.Name });

            Create(new Permission { Name = "Xem vai trò", Group = PermissionGroupType.RoleManagement.Name });
            Create(new Permission { Name = "Thêm vai trò", Group = PermissionGroupType.RoleManagement.Name });
            Create(new Permission { Name = "Sửa vai trò", Group = PermissionGroupType.RoleManagement.Name });
            Create(new Permission { Name = "Xóa vai trò", Group = PermissionGroupType.RoleManagement.Name });

            Create(new Permission { Name = "Xem sản phẩm", Group = PermissionGroupType.ProductManagement.Name });
            Create(new Permission { Name = "Thêm sản phẩm", Group = PermissionGroupType.ProductManagement.Name });
            Create(new Permission { Name = "Sửa sản phẩm", Group = PermissionGroupType.ProductManagement.Name });
            Create(new Permission { Name = "Xóa sản phẩm", Group = PermissionGroupType.ProductManagement.Name });

            Create(new Permission { Name = "Xem đơn hàng", Group = PermissionGroupType.OrderManagement.Name });
            Create(new Permission { Name = "Thêm đơn hàng", Group = PermissionGroupType.OrderManagement.Name });
            Create(new Permission { Name = "Sửa đơn hàng", Group = PermissionGroupType.OrderManagement.Name });
            Create(new Permission { Name = "Xóa đơn hàng", Group = PermissionGroupType.OrderManagement.Name });

            Create(new Permission { Name = "Thống kê báo cáo", Group = PermissionGroupType.ReportManagement.Name });
            Create(new Permission { Name = "Xem thống kê báo cáo", Group = PermissionGroupType.ReportManagement.Name });

            MessageBox.Show("Create permission successfull");
        }
    }
}
