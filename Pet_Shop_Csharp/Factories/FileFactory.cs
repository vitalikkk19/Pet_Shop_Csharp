using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet_Shop_Csharp.Repository;
using Pet_Shop_Csharp.FileRepository;

namespace Pet_Shop_Csharp.Factories
{
    class FileFactory : IFactory
    {
        public IAnimalRepository GetAnimalRepository()
        {
            return new AnimalFileRepository();
        }

        public IPetShopRepository GetPetShopRepository()
        {
            return new PetShopFileRepository();
        }
    }
}
