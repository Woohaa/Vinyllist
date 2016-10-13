using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
	class Fish: Animal
	{

		public bool CanSwim { get; set; }
		public string WhatDoesItEat { get; set; }

		public override string GetBaseInfoAboutAnimal()
		{
			return string.Format("{0}, it can swim {1}, and it eats {2}",
				base.GetBaseInfoAboutAnimal(), CanSwim, WhatDoesItEat);
		}

	}
}
