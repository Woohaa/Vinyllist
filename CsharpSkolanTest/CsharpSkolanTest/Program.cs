using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpSkolanTest
{
	class Program
	{

		static Random randomizer = new Random();
	


		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("Chose a number of times you want to throw the dice");
				Console.WriteLine("Chose how many sides the dice has");
				string throwDice = Console.ReadLine().ToLower();
				RollDice(throwDice);
				Console.WriteLine("And your total sum is: " + RollDice(throwDice));
				Console.ReadLine();
			}


		}

		public static int RollDice(int diceRolls)
		{

			return randomizer.Next(diceRolls) + 1;
			

		}

		public static int RollDice(int diceRolls, int numberOfSides)
		{
		
			int diceSides = randomizer.Next(numberOfSides) + 1;
			int result = diceSides * diceRolls;
			return result;

		}


		public static int RollDice(string rollDice)
		{
			//Hehe
		    var t = rollDice.Split('t');
			int diceRolls = int.Parse(t[0]);
			int numberOfSides = int.Parse(t[1]);
			return RollDice(diceRolls, numberOfSides);
			
		}


	}
}
