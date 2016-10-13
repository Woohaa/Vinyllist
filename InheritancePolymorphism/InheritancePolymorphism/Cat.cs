using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
	class Cat: Mammal
	{

		public string WhatBreed { get; set; }

		public override string GetBaseInfoAboutAnimal()
		{
			return string.Format("{0}, and it's breed is {1}", base.GetBaseInfoAboutAnimal(), WhatBreed);
		}

	}
}
