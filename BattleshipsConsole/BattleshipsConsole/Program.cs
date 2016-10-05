using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsConsole
{
	class Program
	{
		static string playerName;
		static int[,] sea = new int[10,10];

		static void Main(string[] args)
		{

			  ChoseToStartTheGame();
			  ChoseYourShipsPositions(char[,] Board);
			//TypeInPositionToBomb();
			//WhatHappensWhenYouWin();
			//WhatHappensWhenYouLose();

		}

		static void ChoseToStartTheGame()
		{
			Console.WriteLine("Please type in your name: ");
			playerName = Console.ReadLine();

		}

		static void ChoseYourShipsPositions(char[,] Board)
		{
				
			int Row;
			int Column;

			Console.WriteLine("  ¦ 0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("--+--------------------");
			for (Row = 0; Row <= 9; Row++)
			{
				Console.Write((Row).ToString() + " ¦ ");
				for (Column = 0; Column <= 9; Column++)
				{
					Console.Write(Board[Column, Row] + " ");
				}
				Console.WriteLine();
			}

			Console.WriteLine("\n");
		}
	}

}



