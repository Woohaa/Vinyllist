using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	class Program
	{
		static int result = 0;
		static bool isSucessfull = false;
		
		static void Main(string[] args)
		{

			//string input = Console.ReadLine();

			//if (input == "y")
			//	Console.WriteLine("HEJHEJ");
			//else if (input == "n")
			//	Console.WriteLine("HEPP FUUU");
			//else
			//	Console.WriteLine("FU");

			string input = Console.ReadLine();
			int.TryParse(input, out result);

			

			while (!isSucessfull)
			{
				
				isSucessfull = int.TryParse(input, out result);
				Console.WriteLine(result);
				Console.ReadLine();
			}


		}
	}
}
