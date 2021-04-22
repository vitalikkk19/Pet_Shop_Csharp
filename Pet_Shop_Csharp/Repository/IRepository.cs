using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop_Csharp.Repository
{
    public interface IRepository<T>
    {
        List<T> Data { get; }
        void Add(T tmp);
        void Remove(short ind);
    }
}
