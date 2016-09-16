using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HangmanSunBETA
{
	class Program
	{
		static string[] wordBank = new string[] { "katt", "olfdolf", "urinera" };
		static string wordToGuess;
		static string[] hiddenWordToGuess;
		static string choice;
		//static int inputDifficultyChoice;
		static string playerName;
		//static int playerLives;
		//static int lives;



		static void Main(string[] args)
		{


			//GameEngine();

			Console.BackgroundColor = ConsoleColor.Black;
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Red;
			HangmanGraphic();
			HangmanStart();
			//GameEngine();
			//WinAndLose();
			DifficultyLevel();
			//StoryLine();


		}

		static void HangmanStart()
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
			Console.WriteLine("***                 Choose one option               ***".PadLeft(85));
			Console.WriteLine("***                                                 ***".PadLeft(85));
			Console.WriteLine("***                     1.Start                     ***".PadLeft(85));
			Console.WriteLine("***                     2.Difficulty                ***".PadLeft(85));
			Console.WriteLine("***                     3.Story                     ***".PadLeft(85));
			Console.WriteLine("***                     4.Info                      ***".PadLeft(85));
			Console.WriteLine("***                     5.Quit                      ***".PadLeft(85));
			Console.WriteLine("***                                                 ***".PadLeft(85));
			Console.WriteLine("***        To choose one option type in a number    ***".PadLeft(85));
			Console.WriteLine("***                  between 1 and 5                ***".PadLeft(85));
			Console.WriteLine("***                                                 ***".PadLeft(85));
			Console.WriteLine("*******************************************************".PadLeft(85));
			Console.WriteLine("*******************************************************".PadLeft(85));
			choice = Console.ReadLine();

			switch (choice)
			{
				case "1": GameEngine(); break;
				case "2": DifficultyLevel(); break;
				//case "3": StoryLine(); break;
				//case "4": Info(); break;
				case "5": Environment.Exit(0); break;
				default: Console.WriteLine("You must pick a choice ranging from 1 to 5".PadLeft(80)); Console.ReadLine(); HangmanStart(); break;
			}

		}

		static void GameEngine()
		{

			//inpuitDifficultyChoice = 1;
			//wordToGuess = wordBank[inpuitDifficultyChoice];
			//hiddenWord = new string[wordToGuess.Length];

			do
			{

				Console.Clear();
				Console.WriteLine("Please type in your name!".PadLeft(70));
				Console.WriteLine();
				Console.WriteLine("Your name must be at least 3 characters".PadLeft(77));
				playerName = Console.ReadLine();


			} while (playerName.Length <= 2);

			Console.Clear();
			Console.WriteLine("                          Welcome " + playerName + " now you have the chance to save the guilty convict!");
			Console.WriteLine();
			Console.WriteLine("Press enter to continue".PadLeft(70));
			Console.ReadLine();

			for (int i = 0; i < wordToGuess.Length; i++)
			{
				Console.Write(hiddenWordToGuess[i] += " _ ");

			}
			//Hej

			bool continueGame = true;
			while (continueGame == true)
			{
				string inputGuess = Console.ReadLine();
				Console.WriteLine("Please guess the right word! You must save Mr.Plugger!".PadLeft(85));
				//string inputGuess = Console.ReadLine();
				for (int i = 0; i < wordToGuess.Length; i++)
				{
					if (inputGuess == wordToGuess[i].ToString())
						hiddenWordToGuess[i] = inputGuess;
				}

				continueGame = false;

				for (int i = 0; i < wordToGuess.Length; i++)
				{
					if (wordToGuess[i].ToString() != hiddenWordToGuess[i]) continueGame = true;
					Console.Write(hiddenWordToGuess[i]);
				}

				if (continueGame == false)
					Console.WriteLine("You saved Mr.Plugger, to thank you he decided to punch you in the face".PadLeft(87));
				Console.ReadLine();
			}






		}





		static void DifficultyLevel()
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
			Console.WriteLine("***              Choose difficulty level            ***".PadLeft(85));
			Console.WriteLine("***                                                 ***".PadLeft(85));
			Console.WriteLine("***                     1.Easy                      ***".PadLeft(85));
			Console.WriteLine("***                     2.Normal                    ***".PadLeft(85));
			Console.WriteLine("***                     3.Hard                      ***".PadLeft(85));
			Console.WriteLine("***                     4.Back                      ***".PadLeft(85));
			Console.WriteLine("***                                                 ***".PadLeft(85));
			Console.WriteLine("***                                                 ***".PadLeft(85));
			Console.WriteLine("***        To choose one option type in a number    ***".PadLeft(85));
			Console.WriteLine("***                  between 1 and 4                ***".PadLeft(85));
			Console.WriteLine("***                                                 ***".PadLeft(85));
			Console.WriteLine("*******************************************************".PadLeft(85));
			Console.WriteLine("*******************************************************".PadLeft(85));
			int inputDifficultyChoice = Convert.ToInt32(Console.ReadLine());


			if (inputDifficultyChoice == 1)
			{
				inputDifficultyChoice = 0;
				wordToGuess = wordBank[inputDifficultyChoice];
				hiddenWordToGuess = new string[wordToGuess.Length];
				HangmanStart();
			}
			else if (inputDifficultyChoice == 2)
			{
				inputDifficultyChoice = 1;
				wordToGuess = wordBank[inputDifficultyChoice];
				hiddenWordToGuess = new string[wordToGuess.Length];
				HangmanStart();
			}
			else if (inputDifficultyChoice == 3)
			{
				inputDifficultyChoice = 2;
				wordToGuess = wordBank[inputDifficultyChoice];
				hiddenWordToGuess = new string[wordToGuess.Length];
				HangmanStart();
			}
			else if (inputDifficultyChoice == 4)
			{
				inputDifficultyChoice = 4;
				HangmanStart();
			}
			else
			{
				while (inputDifficultyChoice > 4 || inputDifficultyChoice < 1)
				{
					Console.WriteLine("Please type in a choice between 1 and 4".PadLeft(76));
					Console.ReadLine();
					DifficultyLevel();

				}
			}


		}


		static void HangmanGraphic()
		{
			var arr = new[]
			{
				   @"                                                                                                             ",
				   @"                                                                                                             ",
				   @"                                                                                                             ",
				   @"                                                                                                             ",
				   @"                                                                                                             ",
				   @"                                                                                                             ",
				   @"                                                                                                             ",
				   @"                                                                                                             ",
				   @"                                             ██╗  ██╗ █████╗ ███╗   ██╗ ██████╗ ███╗   ███╗ █████╗ ███╗   ██╗",
				   @"                                             ██║  ██║██╔══██╗████╗  ██║██╔════╝ ████╗ ████║██╔══██╗████╗  ██║",
				   @"                                             ███████║███████║██╔██╗ ██║██║  ███╗██╔████╔██║███████║██╔██╗ ██║",
				   @"                                             ██╔══██║██╔══██║██║╚██╗██║██║   ██║██║╚██╔╝██║██╔══██║██║╚██╗██║",
				   @"                                             ██║  ██║██║  ██║██║ ╚████║╚██████╔╝██║ ╚═╝ ██║██║  ██║██║ ╚████║",
				   @"                                             ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝ ╚═╝     ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝",
				   @"                                                                                                             ",
				   @"                                                                                                  Version 1.0",
			};

			Console.WindowWidth = 160;
			Console.WriteLine("\n\n");
			foreach (string line in arr)
				Console.WriteLine(line);
			Console.ReadKey();
			Console.Beep(440, 500); Console.Beep(440, 500);
			Console.Beep(440, 500);
			Console.Beep(349, 350); Console.Beep(523, 150);
			Console.Beep(440, 500); Console.Beep(349, 350);
			Console.Beep(523, 150); Console.Beep(440, 1000);
			Console.Beep(659, 500); Console.Beep(659, 500);
			Console.Beep(659, 500); Console.Beep(698, 350);
			Console.Beep(523, 150);
			Console.Beep(415, 500); Console.Beep(349, 350);
			Console.Beep(523, 150); Console.Beep(440, 1000);
			Console.Beep(880, 500); Console.Beep(440, 350);
			Console.Beep(440, 150); Console.Beep(880, 500);
			Console.Beep(830, 250);
			Console.Beep(784, 250);
			Console.Beep(740, 125); Console.Beep(698, 125);
			Console.Beep(740, 250);
			Thread.Sleep(250); // Delay 250 milliseconds !!!!
			Console.Beep(455, 250); Console.Beep(622, 500);
			Console.Beep(587, 250); Console.Beep(554, 250);
			Console.Beep(523, 125); Console.Beep(466, 125);
			Console.Beep(523, 250);
			Thread.Sleep(250); // Delay 250 milliseconds !!!!
			Console.Beep(349, 125); Console.Beep(415, 500);
			Console.Beep(349, 375); Console.Beep(440, 125);
			Console.Beep(523, 500); Console.Beep(440, 375);
			Console.Beep(523, 125); Console.Beep(659, 1000);
			Console.Beep(880, 500); Console.Beep(440, 350);
			Console.Beep(440, 150); Console.Beep(880, 500);
			Console.Beep(830, 250); Console.Beep(784, 250);
			Console.Beep(740, 125); Console.Beep(698, 125);
			Console.Beep(740, 250);
			Thread.Sleep(250);
			Console.Beep(455, 250); Console.Beep(622, 500);
			Console.Beep(587, 250); Console.Beep(554, 250);
			Console.Beep(523, 125); Console.Beep(466, 125);
			Console.Beep(523, 250);
			Thread.Sleep(250);
			Console.Beep(349, 250); Console.Beep(415, 500);
			Console.Beep(349, 375); Console.Beep(523, 125);
			Console.Beep(440, 500); Console.Beep(349, 375);
			Console.Beep(261, 125); Console.Beep(440, 1000);
			Thread.Sleep(100);
			Console.Clear();
		}
		//Hej
		static void StoryLine()
		{
			Console.Clear();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("                        Mr.Plugger är en SKYLDIG stackare som vill komma loss från helvetets gap!");
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("                        Men du kan rädda honom! Är du beredd att skapa orättvisa med att rädda Mr.Plugger?");
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("                        Valet är ditt!");
		}

	}
}
