using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet_Shop_Csharp.Repository;

namespace Pet_Shop_Csharp.Factories
{
    class MemoryFactory : IFactory
    {
        public IAnimalRepository GetAnimalRepository()
        {
            return new AnimalRepository();
        }

        public IPetShopRepository GetPetShopRepository()
        {
            return new PetShopRepository();
        }

    }
}
