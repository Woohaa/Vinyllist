using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	class Bil
	{
		string Brand{ get; set; }
	    string Color { get; set; }
		int Speed { get; set; }
		int YearModel { get; set; }
		int HorsePower { get; set; }

		public Bil(string brand, string color, int speed, int yearModel, int horsePower)
		{
			this.Brand = brand;
			this.Color = color;
			this.Speed = speed;
			this.YearModel = yearModel;
			this.HorsePower = horsePower;
		}

		public void StartTheEngine()
		{
			Console.WriteLine("Engine started...");
		}

		public void Accelerate()
		{

			Console.WriteLine("The car is accelerating");
			Console.Read();

		}

		public void CarSpecs()
		{
			Console.WriteLine("The brand of the car is " + Brand);
			Console.WriteLine("The color of the car is " + Color);
			Console.WriteLine("The speed of the car is " + Speed);
			Console.WriteLine("The year model of the car is " + YearModel);
			Console.WriteLine("The car has " + HorsePower + " horsepower");
			Console.Read();
		}

	}


}
