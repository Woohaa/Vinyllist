using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
	class Shark:Fish
	{

		public int TeethSize { get; set; }

		public override string GetBaseInfoAboutAnimal()
		{
			return string.Format("{0}, it's teeht size is {1} mm", base.GetBaseInfoAboutAnimal(), TeethSize);

		}

	}
}
