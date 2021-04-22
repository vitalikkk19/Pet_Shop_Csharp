using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop_Csharp.Model
{
    public class PetShop
    {
        public string name { get; }
        public string city { get; }
        public string street { get; set; }
        public int rating { get; }
        public PetShop(string name, string city, string street, int rating = 0)
        {
            this.name = name;
            this.city = city;
            this.street = street;
            this.rating = rating;
        }
        public override string ToString()
        {
            return $"{name} {city} {street} {rating}";
        }

        public string Writejustbike()
        {
            return $"Pet shop info:{name} {city} {street} {rating}\n";
        }
        public string Write()
        {
            return $"Street:{street}\n  Pet shop info:{name} {rating}\n";
        }
    }
}
