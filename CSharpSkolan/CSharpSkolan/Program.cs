using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSkolan
{
	class Program
	{

		static double farenheit;
		static void Main(string[] args)
		{
			while (true)
			{

				Console.WriteLine("Please type in a Celsius value!");
				double celsius = Convert.ToDouble(Console.ReadLine());
				CelsiusToFarenheit(celsius);
				Console.WriteLine(farenheit);
				Console.ReadLine();
			}
		}

		static public double CelsiusToFarenheit(double celsius)
		{
			farenheit = (celsius / 5.0) * 9 + 32;
			return farenheit;		
		}

	//	Övning 1
 //   Skriv ett program där du deklarerar och använder en egen metod CelsiusTillFarenheit.
 //   Metoden skall omvandla grader Celsius till grader Farenheit.
	//Metoden behöver alltså en inparameter av typen double och en utprameter av typen double.
	//Du skickar in grader i Celsius och vill få ut ett resultat i Farenheit istället.
	//Formeln för omvandling som du måste använda är: Farenheit = (Celsius / 5.0) * 9 + 32.

	}
}

