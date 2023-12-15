using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABC_Bakery.Helpers;
using ABC_Bakery.Models;

namespace ABC_Bakery.Repositories
{
    internal class UserRepository : Repository<User>
    {
        private readonly DatabaseContext _context;
        private readonly RoleRepository _roleRepository;

        public UserRepository(DatabaseContext context)
        {
            _context = context;
            _roleRepository = new RoleRepository(context);
        }

        public bool Create(User obj)
        {
            try
            {
                var role = _roleRepository.Find(obj.RoleId);
                if (role == null)
                {
                    return false;
                }

                obj.Role = role;
                _context.Users.Add(obj);
                return _context.SaveChanges() > 0;
            }
            catch (Exception e)
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
            return _context.Users.Find(id);
        }

        public List<User> FindAll()
        {
            return _context.Users.ToList();
        }

        public bool Update(User obj)
        {
            throw new NotImplementedException();
        }

        public User FindByName(string user_name)
        {
            try
            {
                _context.Users.ToList();
                return _context.Users
                    .Where(u => u.Name.Equals(user_name))
                    .FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
                return null;
            }
        }

        public User FindFirstCashier()
        {
            try
            {
                _context.Users.ToList();
                var role = _roleRepository.FindByName("Cashier");
                if (role == null)
                {
                    return null;
                }

                return _context.Users
                    .Where(u => u.RoleId == role.Id)
                    .FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
                return null;
            }
        }
    }
}
