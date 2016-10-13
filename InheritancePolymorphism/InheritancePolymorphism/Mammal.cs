using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
	class Mammal: Animal
	{
		public int NumberOfLegs { get; set; }
		public int MovingSpeed { get; set; }

		public override string GetBaseInfoAboutAnimal()
		{
			return string.Format("{0} it has {1} number of legs and moves at a speed of {2} kmp/h",
				base.GetBaseInfoAboutAnimal(), NumberOfLegs, MovingSpeed);
			
		}
	}
}
