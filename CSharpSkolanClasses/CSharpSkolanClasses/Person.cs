using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSkolanClasses
{
	class Person
	{

		public string FullName { get; set; }
		DateTime age = new DateTime(1985, 05, 22);
		public double Bmi { get; set; }

		
		
		public string NameAndSurname(string Name, string SurName)
		{

			FullName = Name + " " + SurName;
			return FullName;
		}

		public bool IsAgeRight(int age)
		{
			if (age >= 18)
				return true;
			else
				return false;
		}

		public double BodyMassIndex(double Weight, double Height)
		{
			Bmi = Weight / (Height * Height);
			return Bmi;
		}

	}
}
