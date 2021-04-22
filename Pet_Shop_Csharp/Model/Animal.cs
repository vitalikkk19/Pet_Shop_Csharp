using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop_Csharp.Model
{
    public class Animal
    {
		public string Kind { get; set; }
		public string Model { get; set; }
		public string Color { get; set; }

		public string FullName => $"Animal info: {Kind} {Model} {Color}";

		public string F => Kind;

		public Animal(string kind, string model, string color)
		{
			Kind = kind;
			Model = model;
			Color = color;
		}

		public override string ToString()
		{
			return $"{Kind} {Model} {Color}";
		}

		public string GetKind()
		{
			return Kind;
		}
	}
}
