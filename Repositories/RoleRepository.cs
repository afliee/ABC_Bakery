using Microsoft.EntityFrameworkCore;
using ABC_Bakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABC_Bakery.Helpers;
using ABC_Bakery.Models.Constants;

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

                var role = this.FindByName(obj.Name);
                if (role != null)
                {
                    return false;
                }

                this._context.Roles.Add(obj);
                return this._context.SaveChanges() > 0;
            } catch (Exception e)
            {
                return false;
            }
            
        }


        public bool Delete(Role obj)
        {
            this._context.Roles.Remove(obj);
            return this._context.SaveChanges() > 0;
        }

        public bool Update(Role obj)
        {
            Role role = this.Find(obj.Id);
            role.Name = obj.Name;
            this._context.Roles.Update(role);
            this._context.Entry(role).State = EntityState.Modified;
            return this._context.SaveChanges() > 0;
        }

        public Role? Find(int id)
        {
            try
            {
                return this._context.Roles
                    .Where(r => r.Id == id)
                    .First();
            } catch (Exception e)
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
            if (this._context.Roles.Count() == 0)
            {
                this.Create(new Role { Name = "Admin" });
                this.Create(new Role { Name = "Accounting" });
                this.Create(new Role { Name = "Cashier" });


                var userPerrmissions = _permissionRepository.FindByGroup(PermissionGroupType.UserManagement);
                var productPerrmissions = _permissionRepository.FindByGroup(PermissionGroupType.ProductManagement);
                var orderPerrmissions = _permissionRepository.FindByGroup(PermissionGroupType.OrderManagement);
                var reportPerrmissions = _permissionRepository.FindByGroup(PermissionGroupType.ReportManagement);

                Role Admin = this.FindByName(RoleType.Admin.ToString());
                Role Accounting = this.FindByName(RoleType.Accounting.ToString());
                Role Cashier = this.FindByName(RoleType.Cashier.ToString());
                string message = "";
                message = $"Admin: {Admin.Name}\nAccounting: {Accounting.Name}\nCashier: {Cashier.Name}";
                MessageBox.Show(message);

                message = $"User: {userPerrmissions.Count}\nProduct: {productPerrmissions.Count}\nOrder: {orderPerrmissions.Count}\nReport: {reportPerrmissions.Count}";
                MessageBox.Show(message);
                this.AddPermissions(Admin, userPerrmissions);
                this.AddPermissions(Admin, productPerrmissions);
                this.AddPermissions(Admin, orderPerrmissions);
                this.AddPermissions(Admin, reportPerrmissions);

                this.AddPermissions(Accounting, userPerrmissions);
                this.AddPermissions(Accounting, productPerrmissions);
                this.AddPermissions(Accounting, orderPerrmissions);

                this.AddPermissions(Cashier, userPerrmissions);
                this.AddPermissions(Cashier, productPerrmissions);
                this.AddPermissions(Cashier, orderPerrmissions);
                MessageBox.Show("Roles initialized");
            }
        }

        public Role? FindByName(string name)
        {
            try
            {
                return this._context.Roles
                    .Where(r => r.Name == name)
                    .First();
            } catch (Exception e)
            {
                return null;
            }
        }

        public bool AddPermission(Role role, Permission permission)
        {
            try
            {
                RolePermission rolePermission = new RolePermission(role, permission);
                this._context.RolePermissions.Add(rolePermission);
                role.Permissions.Add(rolePermission);
                permission.Roles.Add(rolePermission);

                this._context.Permissions.Update(permission);
                this._context.Roles.Update(role);
                return this._context.SaveChanges() > 0;
            } catch (Exception e)
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
                    this.AddPermission(role, permission);
                }
                return true;
            } catch (Exception e)
            {
                return false;
            }
        }
    }
}
