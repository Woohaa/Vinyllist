using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
	class Eagle: Bird
	{

		public int FlyingHeight { get; set; }

		public override string GetBaseInfoAboutAnimal()
		{
			return string.Format("{0}, and it can fly as high as {1} m",
				base.GetBaseInfoAboutAnimal(), FlyingHeight);
		}
		
			
		}

	}

