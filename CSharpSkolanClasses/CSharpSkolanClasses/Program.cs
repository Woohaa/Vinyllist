using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSkolanClasses
{
	class Program
	{
		static void Main(string[] args)
		{

			//BMI funkar nu men den är i "meter" inte cm, fixas om tid
			//Koden är lite tunnare med

			
			Person personOne = new Person();

			Console.WriteLine("Type in your name please");
			string Name = Console.ReadLine();
			Console.WriteLine("Type in your surname please");
			string SurName = Console.ReadLine();
			personOne.NameAndSurname(Name, SurName);
			Console.WriteLine("Type in your age please");
			int age = int.Parse(Console.ReadLine());
			Console.WriteLine("Please type in your weight");
			double Weight = double.Parse(Console.ReadLine());
			Console.WriteLine("Please type in your height");
			double Height = double.Parse(Console.ReadLine());
			personOne.BodyMassIndex(Weight, Height);
			Console.WriteLine("Your full name is: " + personOne.FullName);
			Console.WriteLine("And your age is " + personOne.IsAgeRight(age));
			Console.WriteLine("Your BMI is " + personOne.Bmi);
			Console.Read();
		}
	}
}
