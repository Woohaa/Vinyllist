using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
	class RunProgram
	{

		public void ProgramRun()
		{
			Eagle eagle = new Eagle()
			{
				Age = 5,
				Name = "Bolt",
				Weight = 1.8,
				Color = "Black",
				CanFly = true,
				FlyingHeight = 4000

			};

			Cat cat = new Cat()
			{
				Age = 2,
				Name = "Furball",
				Weight = 3,
				NumberOfLegs = 4,
				MovingSpeed = 45,
				WhatBreed = "Holy Birma"
			};

			Shark shark = new Shark()
			{
				Age = 43,
				Name = "Razor",
				Weight = 2300,
				CanSwim = true,
				WhatDoesItEat = "Meat",
				TeethSize = 53
			};

			Console.WriteLine(eagle.GetBaseInfoAboutAnimal());
			Console.WriteLine();
			Console.ReadLine();
			Console.WriteLine(cat.GetBaseInfoAboutAnimal());
			Console.WriteLine();
			Console.ReadLine();
			Console.WriteLine(shark.GetBaseInfoAboutAnimal());
			Console.WriteLine();
			Console.ReadLine();
		}

	}
}
