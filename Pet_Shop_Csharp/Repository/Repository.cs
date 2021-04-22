using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop_Csharp.Repository
{
    public class Repository<T> : IRepository<T>
    {
        public List<T> Data { get; } = new List<T>();

        public void Add(T tmp)
        {
            Data.Add(tmp);
        }
        public void Remove(short ind)
        {
            Data.RemoveAt(ind);
        }
    }
}
