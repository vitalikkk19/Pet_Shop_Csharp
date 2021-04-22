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
    public class AnimalFileRepository : FileRepository<Animal>, IAnimalRepository
    {
        public AnimalFileRepository(string filePath = @"G:\Visual projects\2 course (ll)\Practice_C#\Pet_Shop_Csharp\Pet_Shop_Csharp\Data\Animal.txt")
        {
            base.filePath = filePath;
            ReadFromFile();
        }

        ~AnimalFileRepository()
        {
            Writetofile();
        }

        protected override void ConvertToObject(List<string> strObjItems)
        {
            foreach (string line in strObjItems)
            {
                string[] tmp = line.Split();

                string kind = tmp[0];
                string model = tmp[1];
                string color = tmp[2];
                Animal t = new Animal(kind,model,color);
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
