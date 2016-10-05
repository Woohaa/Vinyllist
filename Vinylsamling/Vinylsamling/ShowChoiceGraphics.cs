using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinylsamling
{
	class ShowChoiceGraphics
	{

		public static void ShowChoiceMenu()
		{
			Console.Clear();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("*******************************************************".PadLeft(85));
			Console.WriteLine("*******************************************************".PadLeft(85));
			Console.WriteLine("***                Choose one option                ***".PadLeft(85));
			Console.WriteLine("***                                                 ***".PadLeft(85));
			Console.WriteLine("***              1.Add items to List                ***".PadLeft(85));
			Console.WriteLine("***              2.Show Vinyl List                  ***".PadLeft(85));
			Console.WriteLine("***              3.Save List                        ***".PadLeft(85));
			Console.WriteLine("***              4.Edit List                        ***".PadLeft(85));
			Console.WriteLine("***              5.Quit                             ***".PadLeft(85));
			Console.WriteLine("***                                                 ***".PadLeft(85));
			Console.WriteLine("*******************************************************".PadLeft(85));
			Console.WriteLine("*******************************************************".PadLeft(85));
			Console.WriteLine();
			ChosingAnOptionFromMainMenu();
		}

		public static void ChosingAnOptionFromMainMenu()
		{
			string MainMenuChoice = (Console.ReadLine());
			switch (MainMenuChoice)
			{
				case "1": AddOrEditVinyls.AddVinylToList(); break;
				case "2": Program.ShowVinylInList(); break;
				case "3": Program.SaveVinylToList(); break;
				case "4": ChoseAnOptionToEditVinylList(); break;
				case "5": Console.WriteLine("Thanks for using the VinylSorter 1.0...Have a nice day!");
					    Console.WriteLine();
					Environment.Exit(0);
					break;
				default:
					while (MainMenuChoice != "1" && MainMenuChoice != "2" && MainMenuChoice!= "3" && MainMenuChoice != "4")
					{
						ShowChoiceMenu();
					}
					break;

			}
		}
		public static void ChoseAnOptionToEditVinylList()
		{
			Console.Clear();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("*******************************************************".PadLeft(85));
			Console.WriteLine("*******************************************************".PadLeft(85));
			Console.WriteLine("***                Choose one option                ***".PadLeft(85));
			Console.WriteLine("***                                                 ***".PadLeft(85));
			Console.WriteLine("***                     1.Add                       ***".PadLeft(85));
			Console.WriteLine("***                     2.Delete                    ***".PadLeft(85));
			Console.WriteLine("***                     3.Edit                      ***".PadLeft(85));
			Console.WriteLine("***                     4.Back                      ***".PadLeft(85));
			Console.WriteLine("***                                                 ***".PadLeft(85));
			Console.WriteLine("***        You may only choose between 1 and 3      ***".PadLeft(85));
			Console.WriteLine("*******************************************************".PadLeft(85));
			Console.WriteLine("*******************************************************".PadLeft(85));
			Console.WriteLine();
			ChosingAnOptionFromEditMenu();
		}

		public static void ChosingAnOptionFromEditMenu()
		{
			string EditMenuChoice = (Console.ReadLine());
			switch (EditMenuChoice)
			{
				case "1": AddOrEditVinyls.AddVinylToList(); break;
				case "2": Program.RemoveFromVinylList(); break;
				case "3": AddOrEditVinyls.EditVinylList(); break;
				case "4": ShowChoiceMenu(); break;
				default: while(EditMenuChoice != "1" && EditMenuChoice != "2" && EditMenuChoice != "3" && EditMenuChoice != "4")
					{
						ChoseAnOptionToEditVinylList();
					}
					break;

			}
		}

	}
}


