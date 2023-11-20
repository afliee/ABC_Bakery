using ABC_Bakery.Helpers;
using ABC_Bakery.Models;
using ABC_Bakery.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Bakery.Services
{
    internal class UserService
    {
        private static UserService _instance = null;
        private readonly DatabaseContext _db;
        private readonly UserRepository _userRepository;

        private UserService()
        {
            _db = new DatabaseContext();
            _userRepository = new UserRepository(_db);
        }

        public static UserService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new UserService();
            }
            return _instance;
        }

        public User Find(int id )
        {
            return _userRepository.Find(id);
        }
    }
}
