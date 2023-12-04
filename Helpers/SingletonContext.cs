using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Bakery.Helpers
{
    internal class SingletonContext
    {
        private static SingletonContext _instance = null;
        private readonly DatabaseContext _db;

        private SingletonContext()
        {
            _db = new DatabaseContext();
        }

        public static SingletonContext GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SingletonContext();
            }
            return _instance;
        }

        public DatabaseContext GetDatabaseContext()
        {
            return _db;
        }
    }
}
