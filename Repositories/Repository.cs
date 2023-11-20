using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ABC_Bakery.Repositories
{
    internal interface Repository<T>
    {
        public bool Create(T obj);
        public bool Update(T obj);
        public bool Delete(T obj);
        public T Find(int id);
        public List<T> FindAll();
    }
}
