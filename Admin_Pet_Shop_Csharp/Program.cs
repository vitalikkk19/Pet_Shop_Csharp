using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet_Shop_Csharp;

namespace Admin_Pet_Shop_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Command com = new Command();
            while (true)
            {
                Console.WriteLine(@"
                    PET SHOP(Admin)
    Select action:
    1. Add new animal;
    2. Remove animal; 
    3. Print all animal;
    4. Add Pet shop;
    5. All Pet shop;
    0. Exit.
");
                string userInput = Console.ReadLine();
                bool isExit = false;
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Type kind:");
                        string kind = Console.ReadLine();
                        Console.WriteLine("Type model:");
                        string model = Console.ReadLine();
                        Console.WriteLine("Type color:");
                        string color = Console.ReadLine();
                        com.AddAnimal(kind,model,color);
                        break;
                    case "2":
                        for (int i = 0; i < com.animalRepository.Data.Count(); i++)
                        {
                            Console.Write(i + " " + com.AllAnimal(i));
                        }
                        Console.WriteLine("Position of animal:");
                        com.DeleteAnimal(Convert.ToInt16(Console.ReadLine()));
                        Console.WriteLine(":*)");
                        break;
                    case "3":
                        for (int i = 0; i < com.animalRepository.Data.Count(); i++)
                        {
                            Console.Write(com.AllAnimal(i));
                        }

                        break;
                    case "4":
                        Console.WriteLine("Type name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Type city:");
                        string city = Console.ReadLine();
                        Console.WriteLine("Type street:");
                        string street = Console.ReadLine();
                        Console.WriteLine("Type rating:");
                        int rating = Convert.ToInt32(Console.ReadLine());
                        com.AddPetShop(name,city,street,rating);
                        break;
                    case "5":
                        for (int i = 0; i < com.petshopRepository.Data.Count(); i++)
                        {
                            Console.Write(com.AllPetShop(i));
                        }
                        break;
                    case "0":
                        isExit = true;
                        break;
                    default:
                        break;

                }
                if (isExit)
                    break;
            }
        }
    }
}
