using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Bakery.Models.Constants
{
    internal abstract class Enumeration<T> : IComparable where T : Enumeration<T>
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        protected Enumeration(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString() => Name;

        public int CompareTo(object obj) => Id.CompareTo(((T)obj).Id);

        public static IEnumerable<T> GetAll() => typeof(T).GetFields().Where(f => f.FieldType == typeof(T)).Select(f => (T)f.GetValue(null));

        public static T FromId(int id) => GetAll().FirstOrDefault(e => e.Id == id);

        public static T FromName(string name) => GetAll().FirstOrDefault(e => e.Name == name);
    }
}
