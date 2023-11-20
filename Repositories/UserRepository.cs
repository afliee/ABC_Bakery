using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABC_Bakery.Models;
using ABC_Bakery.Helpers;

namespace ABC_Bakery.Repositories
{
    internal class UserRepository : Repository<Models.User>
    {
        private readonly DatabaseContext _context;
        private readonly RoleRepository _roleRepository;

        public UserRepository(DatabaseContext context)
        {
            this._context = context;
            this._roleRepository = new RoleRepository(context);
        }

        public bool Create(User obj)
        {
            try
            {
                var role = this._roleRepository.Find(obj.RoleId);
                if (role == null)
                {
                    return false;
                }

                obj.Role = role;
                this._context.Users.Add(obj);
                return this._context.SaveChanges() > 0;
            } catch (Exception e)
            {
                Console.Write(e.ToString());
                return false;
            }
        }

        public bool Delete(User obj)
        {
            throw new NotImplementedException();
        }

        public User Find(int id)
        {
            return this._context.Users.Find(id);
        }

        public List<User> FindAll()
        {
            return this._context.Users.ToList();
        }

        public bool Update(User obj)
        {
            throw new NotImplementedException();
        }

        public User FindByName(string user_name)
        {
            try
            {
                this._context.Users.ToList();
                return _context.Users
                    .Where(u => u.Name.Equals(user_name))
                    .FirstOrDefault();
            } catch (Exception e)
            {
                Console.Write(e.ToString());
                return null;
            } 
        }
    }
}
