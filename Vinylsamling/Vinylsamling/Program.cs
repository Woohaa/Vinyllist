using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Vinylsamling
{
	class Program
	{

		//Welcome! 
		static public List<string> vinylList = new List<string>();
	

		static void Main(string[] args)
		{
			vinylList = File.ReadAllLines(@"C: \Users\wooha\Desktop\Vinyl.txt").ToList();

			do
			{				
				ShowChoiceGraphics.ShowChoiceMenu();
			} while (true);
		}

		public static void ShowVinylInList()
		{
			Console.Clear();
			for (int i = 0; i < vinylList.Count; i++)
			{
				Console.Write("Row:" + (i + 1) + " " + vinylList[i] + "\n");
			}
			Console.WriteLine();
			Console.ReadLine();
		}
		


		public static void RemoveFromVinylList()
		{
			bool removeFromListLoop = true;

			while (removeFromListLoop)
			{
				Console.WriteLine(vinylList.Count());

				ShowVinylInList();
				Console.WriteLine("Select which row you want to remove");
				try
				{
					int input = Convert.ToInt32(Console.ReadLine());
			

					if (input > vinylList.Count || input < 0)
						Console.WriteLine("You may only chose a number within the list!");
					else
					{
						vinylList.RemoveAt(input - 1);
						Console.WriteLine("Removed! Press enter to continue, if you want to go exit press e");
						if (Console.ReadLine() == "e")
							removeFromListLoop = false;
						else
							Console.WriteLine("You must press e");
					}
				}
				catch (Exception)
				{
					Console.WriteLine("Error! You must select a valid row number");
				}
				File.WriteAllLines(@"C:\Users\wooha\Desktop\Vinyl.txt", vinylList);
				Console.WriteLine("Press e to exit or enter to continue");
			}

		}

		public static void SaveVinylToList()
		{
			string saveToListOption;
	
			Console.WriteLine("Do you want to save the list to a textfile? press Y or N");
			//saveToListOption = Console.ReadLine().ToLower();
			do
			{
				saveToListOption = Console.ReadLine().ToLower();
				if (saveToListOption == "y")
				{
					File.WriteAllLines(@"C:\Users\wooha\Desktop\Vinyl.txt", vinylList);
				}
				else if (saveToListOption == "n")
					ShowChoiceGraphics.ShowChoiceMenu();
			} while (saveToListOption != "y" && saveToListOption != "n");


		}

		}


	}