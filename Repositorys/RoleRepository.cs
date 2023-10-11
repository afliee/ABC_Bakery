using Microsoft.EntityFrameworkCore;
using ABC_Bakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABC_Bakery.Helpers;

namespace ABC_Bakery.Repositorys
{
    internal class RoleRepository : Repository<Role>
    {
        private readonly DatabaseContext _context;
        public RoleRepository(DatabaseContext context)
        {
            _context = context;
        }

        public bool Create(Role obj)
        {
            try
            {
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

        public Role Find(int id)
        {
            return _context.Roles.Find(id);
        }

        public List<Role> FindAll()
        {
            return _context.Roles.ToList();
        }

        
    }
}
