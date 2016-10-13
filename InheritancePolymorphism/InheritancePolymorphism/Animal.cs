using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
	class Animal
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public double Weight { get; set; }



		public virtual string GetBaseInfoAboutAnimal()
		{
			return string.Format("The name is {0}, and it is {1}years old, and is as heavy as {2} kg ",
				Name, Age, Weight);
			
		}

	}
}
