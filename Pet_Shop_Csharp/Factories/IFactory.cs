using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet_Shop_Csharp.Repository;

namespace Pet_Shop_Csharp.Factories
{
    public interface IFactory
    {
        IPetShopRepository GetPetShopRepository();
        IAnimalRepository GetAnimalRepository();
    }
}
