using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
	class Bird: Animal
	{

		public string Color { get; set; }
		public bool CanFly { get; set; }

		public override string GetBaseInfoAboutAnimal()
		{
			return string.Format("{0}, it's color is {1}, and it can fly {2}",
				base.GetBaseInfoAboutAnimal(), Color, CanFly);
		}

	}
		
			
		}

	

