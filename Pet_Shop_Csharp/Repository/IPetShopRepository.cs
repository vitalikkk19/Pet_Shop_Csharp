using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet_Shop_Csharp.Model;

namespace Pet_Shop_Csharp.Repository
{
    public interface IPetShopRepository : IRepository<PetShop>
    {
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        void Add(PetShop tmp);
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
    }
}
