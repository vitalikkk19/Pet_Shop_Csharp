using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet_Shop_Csharp.Repository;
using Pet_Shop_Csharp.Factories;
using Pet_Shop_Csharp.FileRepository;
using Pet_Shop_Csharp.Model;

namespace Admin_Pet_Shop_Csharp
{
    class Command
    {
        public IAnimalRepository animalRepository = FactoryProvider.GetFactory().GetAnimalRepository();
        public IPetShopRepository petshopRepository = FactoryProvider.GetFactory().GetPetShopRepository();

        public void AddPetShop(string name, string city, string street, int rating)
        {

            //cout << "Type name:"; cin >> name;
            //cout << "Type surname:"; cin >> surname;
            //cout << "Type stag:"; cin >> stag;
            //int rating = 0;

            PetShop petshopp;
            petshopp = new PetShop(name,city,street,rating);

            petshopRepository.Add(petshopp);
        }
        public void AddAnimal(string kind, string model, string color)
        {
            
            // cout << "Type name:"; cin >> name;
            //cout << "Type surname:"; cin >> surname;
          

            Animal tech;
            tech = new Animal(kind, model, color);

            animalRepository.Add(tech);

        }
        public string AllPetShop(int i)
        {

            string str = "";
            str = petshopRepository.Data[i].ToString() + "\n";
            return str;

        }
        public string AllAnimal(int i)
        {
            string str = "";
            str = animalRepository.Data[i].ToString() + "\n";
            return str;
        }
        
        public void DeleteAnimal(short i)
        {
            animalRepository.Remove(i);
        }
    }
}
