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
    internal class RolePermissionRepository : Repository<RolePermission>
    {
        private readonly DatabaseContext _context;
        private readonly PermissionRepository _permissionRepository;
        private readonly RoleRepository _roleRepository;

        public RolePermissionRepository(DatabaseContext context)
        {
            _context = context;
            _permissionRepository = new PermissionRepository(context);
            _roleRepository = new RoleRepository(context);
        }

        public bool Create(RolePermission obj)
        {
            try
            {
                this._context.RolePermissions.Add(obj);
                return this._context.SaveChanges() > 0;
            } catch (Exception e)
            {
                return false;
            }
        }

        public bool Delete(RolePermission obj)
        {
            throw new NotImplementedException();
        }

        public RolePermission Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<RolePermission> FindAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(RolePermission obj)
        {
            throw new NotImplementedException();
        }

        public void Initialize()
        {
            if (this._permissionRepository != null)
            {
                  if (this._permissionRepository.FindAll().Count > 0) return;
            }

            if (this._roleRepository != null)
            {
                if (this._roleRepository.FindAll().Count > 0) return;
            }

            Role Admin = _roleRepository.FindByName(RoleType.Admin.ToString());
            Role Accounting = _roleRepository.FindByName(RoleType.Accounting.ToString());
            Role Cashier = _roleRepository.FindByName(RoleType.Cashier.ToString());

            var userPerrmissions = _permissionRepository.FindByGroup(PermissionGroupType.UserManagement);
            var productPerrmissions = _permissionRepository.FindByGroup(PermissionGroupType.ProductManagement);
            var orderPerrmissions = _permissionRepository.FindByGroup(PermissionGroupType.OrderManagement);
            var reportPerrmissions = _permissionRepository.FindByGroup(PermissionGroupType.ReportManagement);

            foreach (var permission in userPerrmissions)
            {
                this.Create(new RolePermission(Admin, permission));
            }

            foreach (var permission in productPerrmissions)
            {
                this.Create(new RolePermission(Admin, permission));
                this.Create(new RolePermission(Accounting, permission));
            }

            foreach (var permission in orderPerrmissions)
            {
                this.Create(new RolePermission(Admin, permission));
                this.Create(new RolePermission(Accounting, permission));
                this.Create(new RolePermission(Cashier, permission));
            }

            MessageBox.Show("Role Permission Initialized");
        }
    }
}
