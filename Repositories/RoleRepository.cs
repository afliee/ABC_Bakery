using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABC_Bakery.Models.Constants;
using ABC_Bakery.Helpers;
using ABC_Bakery.Models;

namespace ABC_Bakery.Repositories
{
    internal class RoleRepository : Repository<Role>
    {
        private readonly DatabaseContext _context;
        private readonly PermissionRepository _permissionRepository;

        public RoleRepository(DatabaseContext context)
        {
            _context = context;
            _permissionRepository = new PermissionRepository(context);
        }

        public bool Create(Role obj)
        {
            try
            {
                if (obj == null)
                {
                    return false;
                }

                var role = FindByName(obj.Name);
                if (role != null)
                {
                    return false;
                }

                _context.Roles.Add(obj);
                return _context.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                return false;
            }

        }


        public bool Delete(Role obj)
        {
            _context.Roles.Remove(obj);
            return _context.SaveChanges() > 0;
        }

        public bool Update(Role obj)
        {
            Role role = Find(obj.Id);
            role.Name = obj.Name;
            _context.Roles.Update(role);
            _context.Entry(role).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }

        public Role? Find(int id)
        {
            try
            {
                return _context.Roles
                    .Where(r => r.Id == id)
                    .First();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public List<Role> FindAll()
        {
            return _context.Roles.ToList();
        }

        public void Initialize()
        {
            if (_context.Roles.Count() == 0)
            {
                Create(new Role { Name = "Admin" });
                Create(new Role { Name = "Accounting" });
                Create(new Role { Name = "Cashier" });


                var userPerrmissions = _permissionRepository.FindByGroup(PermissionGroupType.UserManagement);
                var productPerrmissions = _permissionRepository.FindByGroup(PermissionGroupType.ProductManagement);
                var orderPerrmissions = _permissionRepository.FindByGroup(PermissionGroupType.OrderManagement);
                var reportPerrmissions = _permissionRepository.FindByGroup(PermissionGroupType.ReportManagement);

                Role Admin = FindByName(RoleType.Admin.ToString());
                Role Accounting = FindByName(RoleType.Accounting.ToString());
                Role Cashier = FindByName(RoleType.Cashier.ToString());
                string message = "";
                message = $"Admin: {Admin.Name}\nAccounting: {Accounting.Name}\nCashier: {Cashier.Name}";
                MessageBox.Show(message);

                message = $"User: {userPerrmissions.Count}\nProduct: {productPerrmissions.Count}\nOrder: {orderPerrmissions.Count}\nReport: {reportPerrmissions.Count}";
                MessageBox.Show(message);
                AddPermissions(Admin, userPerrmissions);
                AddPermissions(Admin, productPerrmissions);
                AddPermissions(Admin, orderPerrmissions);
                AddPermissions(Admin, reportPerrmissions);

                AddPermissions(Accounting, userPerrmissions);
                AddPermissions(Accounting, productPerrmissions);
                AddPermissions(Accounting, orderPerrmissions);

                AddPermissions(Cashier, userPerrmissions);
                AddPermissions(Cashier, productPerrmissions);
                AddPermissions(Cashier, orderPerrmissions);
                MessageBox.Show("Roles initialized");
            }
        }

        public Role? FindByName(string name)
        {
            try
            {
                return _context.Roles
                    .Where(r => r.Name == name)
                    .First();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool AddPermission(Role role, Permission permission)
        {
            try
            {
                RolePermission rolePermission = new RolePermission(role, permission);
                _context.RolePermissions.Add(rolePermission);
                role.Permissions.Add(rolePermission);
                permission.Roles.Add(rolePermission);

                _context.Permissions.Update(permission);
                _context.Roles.Update(role);
                return _context.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool AddPermissions(Role role, List<Permission> permissions)
        {
            try
            {
                foreach (var permission in permissions)
                {
                    MessageBox.Show($"Add permission {permission.Name} to role {role.Name}");
                    AddPermission(role, permission);
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
