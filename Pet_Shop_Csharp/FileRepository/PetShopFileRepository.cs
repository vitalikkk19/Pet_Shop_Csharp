using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Pet_Shop_Csharp.Repository;
using Pet_Shop_Csharp.Model;

namespace Pet_Shop_Csharp.FileRepository
{
    public class PetShopFileRepository : FileRepository<PetShop>, IPetShopRepository
    {
        public PetShopFileRepository(string filePath = @"G:\Visual projects\2 course (ll)\Practice_C#\Pet_Shop_Csharp\Pet_Shop_Csharp\Data\PetShop.txt")
        {
            base.filePath = filePath;
            ReadFromFile();
        }

        ~PetShopFileRepository()
        {
            Writetofile();
        }

        protected override void ConvertToObject(List<string> strObjItems)
        {
            foreach (string line in strObjItems)
            {
                string[] tmp = line.Split();

                string name = tmp[0];
                string city = tmp[1];
                string street = tmp[2];
                int rating = Convert.ToInt32(tmp[3]);
                PetShop t = new PetShop(name,city,street,rating);
                base.Add(t);
            }
        }

        protected override void WriteObj(StreamWriter sw)
        {
            for (int i = 0; i < Data.Count; i++)
            {
                sw.WriteLine(Data[i].ToString());
            }
            sw.Close();
        }
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        public void Remove(short ind)
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
        {
            base.Remove(ind);
        }
    }
}
