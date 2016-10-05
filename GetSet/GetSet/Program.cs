using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
	class Program
	{
		static void Main(string[] args)
		{
			Weight weight = new Weight();
			Console.WriteLine("Please type in your weight ");

			weight.YourWeight = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Your weight is " + weight.YourWeight + " kg");

		}
	}
}
