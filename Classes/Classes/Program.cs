using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	class Program
	{


		static void Main(string[] args)
		{

		Person personOlf = new Person();
	    Person personDolf = new Person();
	    Bil ferrari = new Bil("Ferrari" ,"red", 230,  2010, 600);
		Bil volvo = new Bil("Volvo", "black", 110, 2016, 230);

			Bil[] bilar = new Bil[10];
			for (int i = 0; i < bilar.Length; i++)
			bilar[i] = new Bil("Ford", "blue", 90, 2015, 170);

			bilar[0].CarSpecs();
			bilar[1].CarSpecs();

			Console.WriteLine();
			volvo.CarSpecs();
			volvo.StartTheEngine();
			volvo.Accelerate();
	
			   
		}
	}
}
