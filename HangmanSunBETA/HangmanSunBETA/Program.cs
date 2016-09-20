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
		static int inputDifficultyChoice;
		static bool continueGame = true;
		static string playerName;
		static int playerLives;
		static string contin;




		static void Main(string[] args)
		{
			while (continueGame)

			{

				PrepareTheGameScreen();
				HangmanMusicGraphics();
				ShowStartMenu();
			}
		}

		private static void ContinueGame()
		{
			Console.WriteLine("Press enter to continue".PadLeft(80));
			Console.ReadLine();
			ShowStartMenu();
		}

		private static void ExitGame()
		{
			Console.WriteLine("Sorry to see you go...".PadLeft(64));
			Console.ReadLine();
			Environment.Exit(0);
		}

		private static void PrepareTheGameScreen()
		{
			wordToGuess = "";
			choice = "";
			inputDifficultyChoice = 0;
			playerName = "";

			Console.WindowWidth = 110;
			Console.WindowHeight = 30;
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Yellow;
		}


		static void GameMusic()
		{

			{
				System.Threading.Thread thread = new System.Threading.Thread(
			 new System.Threading.ThreadStart(
			 delegate ()
			 {
				 while (continueGame)
				 {
					 Console.Beep(659, 125);
					 Console.Beep(659, 125);
					 Thread.Sleep(125);
					 Console.Beep(659, 125);
					 Thread.Sleep(167);
					 Console.Beep(523, 125);
					 Console.Beep(659, 125);
					 Thread.Sleep(125);
					 Console.Beep(784, 125);
					 Thread.Sleep(375);
					 Console.Beep(392, 125);
					 Thread.Sleep(375);
					 Console.Beep(523, 125);
					 Thread.Sleep(250);
					 Console.Beep(392, 125);
					 Thread.Sleep(250);
					 Console.Beep(330, 125);
					 Thread.Sleep(250);
					 Console.Beep(440, 125);
					 Thread.Sleep(125);
					 Console.Beep(494, 125);
					 Thread.Sleep(125);
					 Console.Beep(466, 125);
					 Thread.Sleep(42);
					 Console.Beep(440, 125);
					 Thread.Sleep(125);
					 Console.Beep(392, 125);
					 Thread.Sleep(125);
					 Console.Beep(659, 125);
					 Thread.Sleep(125);
					 Console.Beep(784, 125);
					 Thread.Sleep(125);
					 Console.Beep(880, 125);
					 Thread.Sleep(125);
					 Console.Beep(698, 125);
					 Console.Beep(784, 125);
					 Thread.Sleep(125);
					 Console.Beep(659, 125);
					 Thread.Sleep(125);
					 Console.Beep(523, 125);
					 Thread.Sleep(125);
					 Console.Beep(587, 125);
					 Console.Beep(494, 125);
					 Thread.Sleep(125);
					 Console.Beep(523, 125);
					 Thread.Sleep(250);
					 Console.Beep(392, 125);
					 Thread.Sleep(250);
					 Console.Beep(330, 125);
					 Thread.Sleep(250);
					 Console.Beep(440, 125);
					 Thread.Sleep(125);
					 Console.Beep(494, 125);
					 Thread.Sleep(125);
					 Console.Beep(466, 125);
					 Thread.Sleep(42);
					 Console.Beep(440, 125);
					 Thread.Sleep(125);
					 Console.Beep(392, 125);
					 Thread.Sleep(125);
					 Console.Beep(659, 125);
					 Thread.Sleep(125);
					 Console.Beep(784, 125);
					 Thread.Sleep(125);
					 Console.Beep(880, 125);
					 Thread.Sleep(125);
					 Console.Beep(698, 125);
					 Console.Beep(784, 125);
					 Thread.Sleep(125);
					 Console.Beep(659, 125);
					 Thread.Sleep(125);
					 Console.Beep(523, 125);
					 Thread.Sleep(125);
					 Console.Beep(587, 125);
					 Console.Beep(494, 125);
					 Thread.Sleep(375);
					 Console.Beep(784, 125);
					 Console.Beep(740, 125);
					 Console.Beep(698, 125);
					 Thread.Sleep(42);
					 Console.Beep(622, 125);
					 Thread.Sleep(125);
					 Console.Beep(659, 125);
					 Thread.Sleep(167);
					 Console.Beep(415, 125);
					 Console.Beep(440, 125);
					 Console.Beep(523, 125);
					 Thread.Sleep(125);
					 Console.Beep(440, 125);
					 Console.Beep(523, 125);
					 Console.Beep(587, 125);
					 Thread.Sleep(250);
					 Console.Beep(784, 125);
					 Console.Beep(740, 125);
					 Console.Beep(698, 125);
					 Thread.Sleep(42);
					 Console.Beep(622, 125);
					 Thread.Sleep(125);
					 Console.Beep(659, 125);
					 Thread.Sleep(167);
					 Console.Beep(698, 125);
					 Thread.Sleep(125);
					 Console.Beep(698, 125);
					 Console.Beep(698, 125);
					 Thread.Sleep(625);
					 Console.Beep(784, 125);
					 Console.Beep(740, 125);
					 Console.Beep(698, 125);
					 Thread.Sleep(42);
					 Console.Beep(622, 125);
					 Thread.Sleep(125);
					 Console.Beep(659, 125);
					 Thread.Sleep(167);
					 Console.Beep(415, 125);
					 Console.Beep(440, 125);
					 Console.Beep(523, 125);
					 Thread.Sleep(125);
					 Console.Beep(440, 125);
					 Console.Beep(523, 125);
					 Console.Beep(587, 125);
					 Thread.Sleep(250);
					 Console.Beep(622, 125);
					 Thread.Sleep(250);
					 Console.Beep(587, 125);
					 Thread.Sleep(250);
					 Console.Beep(523, 125);
					 Thread.Sleep(1125);
					 Console.Beep(784, 125);
					 Console.Beep(740, 125);
					 Console.Beep(698, 125);
					 Thread.Sleep(42);
					 Console.Beep(622, 125);
					 Thread.Sleep(125);
					 Console.Beep(659, 125);
					 Thread.Sleep(167);
					 Console.Beep(415, 125);
					 Console.Beep(440, 125);
					 Console.Beep(523, 125);
					 Thread.Sleep(125);
					 Console.Beep(440, 125);
					 Console.Beep(523, 125);
					 Console.Beep(587, 125);
					 Thread.Sleep(250);
					 Console.Beep(784, 125);
					 Console.Beep(740, 125);
					 Console.Beep(698, 125);
					 Thread.Sleep(42);
					 Console.Beep(622, 125);
					 Thread.Sleep(125);
					 Console.Beep(659, 125);
					 Thread.Sleep(167);
					 Console.Beep(698, 125);
					 Thread.Sleep(125);
					 Console.Beep(698, 125);
					 Console.Beep(698, 125);
					 Thread.Sleep(625);
					 Console.Beep(784, 125);
					 Console.Beep(740, 125);
					 Console.Beep(698, 125);
					 Thread.Sleep(42);
					 Console.Beep(622, 125);
					 Thread.Sleep(125);
					 Console.Beep(659, 125);
					 Thread.Sleep(167);
					 Console.Beep(415, 125);
					 Console.Beep(440, 125);
					 Console.Beep(523, 125);
					 Thread.Sleep(125);
					 Console.Beep(440, 125);
					 Console.Beep(523, 125);
					 Console.Beep(587, 125);
					 Thread.Sleep(250);
					 Console.Beep(622, 125);
					 Thread.Sleep(250);
					 Console.Beep(587, 125);
					 Thread.Sleep(250);
					 Console.Beep(523, 125);
					 Thread.Sleep(625);

				 }
			 }
			 ));

				thread.Start();
			}

		}





		static void ShowStartMenu()
		{
			Console.Clear();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("*******************************************************".PadLeft(80));
			Console.WriteLine("*******************************************************".PadLeft(80));
			Console.WriteLine("***                 Choose one option               ***".PadLeft(80));
			Console.WriteLine("***                                                 ***".PadLeft(80));
			Console.WriteLine("***                     1.Start                     ***".PadLeft(80));
			Console.WriteLine("***                     2.Storyline                 ***".PadLeft(80));
			Console.WriteLine("***                     3.Info                      ***".PadLeft(80));
			Console.WriteLine("***                     4.Quit                      ***".PadLeft(80));
			Console.WriteLine("***                                                 ***".PadLeft(80));
			Console.WriteLine("***        To choose one option type in a number    ***".PadLeft(80));
			Console.WriteLine("***                  between 1 and 5                ***".PadLeft(80));
			Console.WriteLine("***                                                 ***".PadLeft(80));
			Console.WriteLine("*******************************************************".PadLeft(80));
			Console.WriteLine("*******************************************************".PadLeft(80));
			choice = Console.ReadLine();

			switch (choice)
			{
				case "1": CollectDataAndStartTheGame(); break;
				case "2": StoryLine(); break;
				case "3": Info(); break;
				case "4": ExitGame(); break;
				default:
					Console.WriteLine("You must pick a choice ranging from 1 to 5".PadLeft(73)); Console.ReadLine();
					ShowStartMenu(); break;
			}
		}
		private static void Info()
		{
			Console.Clear();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("*******************************************************".PadLeft(80));
			Console.WriteLine("*******************************************************".PadLeft(80));
			Console.WriteLine("***                                                 ***".PadLeft(80));
			Console.WriteLine("***                                                 ***".PadLeft(80));
			Console.WriteLine("***                                                 ***".PadLeft(80));
			Console.WriteLine("***          Here there will be som guidence        ***".PadLeft(80));
			Console.WriteLine("***                                                 ***".PadLeft(80));
			Console.WriteLine("***                                                 ***".PadLeft(80));
			Console.WriteLine("***                                                 ***".PadLeft(80));
			Console.WriteLine("***                                                 ***".PadLeft(80));
			Console.WriteLine("***                                                 ***".PadLeft(80));
			Console.WriteLine("***                                                 ***".PadLeft(80));
			Console.WriteLine("*******************************************************".PadLeft(80));
			Console.WriteLine("*******************************************************".PadLeft(80));
			ContinueGame();
		}
		private static void CollectDataAndStartTheGame()
		{
			do
			{

				Console.Clear();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine("*******************************************************".PadLeft(80));
				Console.WriteLine("*******************************************************".PadLeft(80));
				Console.WriteLine("***                                                 ***".PadLeft(80));
				Console.WriteLine("***                                                 ***".PadLeft(80));
				Console.WriteLine("***                                                 ***".PadLeft(80));
				Console.WriteLine("***            Please type in your name!            ***".PadLeft(80));
				Console.WriteLine("***                                                 ***".PadLeft(80));
				Console.WriteLine("***                                                 ***".PadLeft(80));
				Console.WriteLine("***                                                 ***".PadLeft(80));
				Console.WriteLine("***     Your name must be at least 3 characters!    ***".PadLeft(80));
				Console.WriteLine("***                                                 ***".PadLeft(80));
				Console.WriteLine("***                                                 ***".PadLeft(80));
				Console.WriteLine("*******************************************************".PadLeft(80));
				Console.WriteLine("*******************************************************".PadLeft(80));


				Console.WriteLine();
				//Console.WriteLine("".PadLeft(77));
				playerName = Console.ReadLine();



			} while (playerName.Length <= 2);

			DifficultyLevel();
			PlayHangman();
		}






		static void PlayHangman()
		{



			if (continueGame == true)
			{
				GameMusic();
			}



			for (int i = 0; i < wordToGuess.Length; i++)
			{
				Console.Write(hiddenWordToGuess[i] += "-");
			}



			while (continueGame == true)
			{
				string inputGuess = Console.ReadLine().ToLower();
				Console.Clear();
				Console.WriteLine();
				Console.WriteLine("                                                Welcome " + playerName);
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine("*******************************************************".PadLeft(80));
				Console.WriteLine("*******************************************************".PadLeft(80));
				Console.WriteLine("***                                                 ***".PadLeft(80));
				Console.WriteLine("***                                                 ***".PadLeft(80));
				Console.WriteLine("***                                                 ***".PadLeft(80));
				Console.WriteLine("***            Now you have the chance to           ***".PadLeft(80));
				Console.WriteLine("***                                                 ***".PadLeft(80));
				Console.WriteLine("***             save the guilty convict!            ***".PadLeft(80));
				Console.WriteLine("***                                                 ***".PadLeft(80));
				Console.WriteLine("***                                                 ***".PadLeft(80));
				Console.WriteLine("***                                                 ***".PadLeft(80));
				Console.WriteLine("***                                                 ***".PadLeft(80));
				Console.WriteLine("*******************************************************".PadLeft(80));
				Console.WriteLine("*******************************************************".PadLeft(80));
				Console.WriteLine();
				Console.WriteLine("Please take another guess!".PadLeft(65));
				Console.WriteLine("                                         You have " + playerLives + " lives left!");
				playerLives--;
				MrPluggerGraphic();



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


				Console.WriteLine();
				if (continueGame == false)
				{
					Console.WriteLine();
					Console.WriteLine();
					Console.WriteLine("You saved Mr.Plugger, to thank you he decided to punch you in the face!!!".PadLeft(89));
					Console.WriteLine();
					Console.WriteLine("Would you like to play again? Y/N".PadLeft(68));
					string contin = Console.ReadLine().ToLower();


					{
						while (contin != "n")
						{

							Console.WriteLine();
							Console.WriteLine("Would you like to play again? Y/N".PadLeft(68));
							contin = Console.ReadLine();
							if (contin == "y")
							{
								continueGame = true;
								ShowStartMenu();
							}
						}
						continueGame = false;
						ExitGame();
					}
				}
				else if (playerLives <= 0)
				{
					Console.WriteLine();
					Console.WriteLine("OH NOES! You killed poor Mr.Plugger!".PadLeft(70));

					{
						while (contin != "n")
						{

							Console.WriteLine();
							Console.WriteLine("Would you like to play again? Y/N".PadLeft(68));
							contin = Console.ReadLine();
							if (contin == "y")
							{
								continueGame = true;
								ShowStartMenu();
							}
						}
						continueGame = false;
						ExitGame();
					}





				}

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
			Console.WriteLine("*******************************************************".PadLeft(80));
			Console.WriteLine("*******************************************************".PadLeft(80));
			Console.WriteLine("***              Choose difficulty level            ***".PadLeft(80));
			Console.WriteLine("***                                                 ***".PadLeft(80));
			Console.WriteLine("***                     1.Easy                      ***".PadLeft(80));
			Console.WriteLine("***                     2.Normal                    ***".PadLeft(80));
			Console.WriteLine("***                     3.Hard                      ***".PadLeft(80));
			Console.WriteLine("***                     4.Back                      ***".PadLeft(80));
			Console.WriteLine("***                                                 ***".PadLeft(80));
			Console.WriteLine("***                                                 ***".PadLeft(80));
			Console.WriteLine("***        To choose one option type in a number    ***".PadLeft(80));
			Console.WriteLine("***                  between 1 and 4                ***".PadLeft(80));
			Console.WriteLine("***                                                 ***".PadLeft(80));
			Console.WriteLine("*******************************************************".PadLeft(80));
			Console.WriteLine("*******************************************************".PadLeft(80));


			string inputChoice = Console.ReadLine();
			if (inputChoice == "1")
			{
				inputDifficultyChoice = 0;
				wordToGuess = wordBank[inputDifficultyChoice];
				hiddenWordToGuess = new string[wordToGuess.Length];
				playerLives = 10;
				PlayHangman();
			}
			else if (inputChoice == "2")
			{
				inputDifficultyChoice = 1;
				wordToGuess = wordBank[inputDifficultyChoice];
				hiddenWordToGuess = new string[wordToGuess.Length];
				playerLives = 7;
				PlayHangman();
			}
			else if (inputChoice == "3")
			{
				inputDifficultyChoice = 2;
				wordToGuess = wordBank[inputDifficultyChoice];
				hiddenWordToGuess = new string[wordToGuess.Length];
				playerLives = 5;
				PlayHangman();
			}
			else if (inputChoice == "4")
			{
				inputDifficultyChoice = 4;
				ShowStartMenu();
			}
			else
			{
				while (inputChoice != "1" && inputChoice != "2" && inputChoice != "3" && inputChoice != "4")
				{
					Console.WriteLine("Please type in a choice between 1 and 4".PadLeft(76));
					DifficultyLevel();
				}
			}
		}


		static void HangmanMusicGraphics()
		{


			Thread.Sleep(1000);

			Console.Clear();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine(@"██╗  ██╗ █████╗ ".PadLeft(65));
			Console.WriteLine(@"██║  ██║██╔══██╗".PadLeft(65));
			Console.WriteLine(@"███████║███████║".PadLeft(65));
			Console.WriteLine(@"██╔══██║██╔══██║".PadLeft(65));
			Console.WriteLine(@"██║  ██║██║  ██║".PadLeft(65));
			Console.WriteLine(@"╚═╝  ╚═╝╚═╝  ╚═╝".PadLeft(65));

			Console.Beep(440, 500);   //
			Console.Beep(440, 500);
			Console.Clear();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine(@"██╗  ██╗ █████╗ ███╗   ██╗ ██████╗ ".PadLeft(70));
			Console.WriteLine(@"██║  ██║██╔══██╗████╗  ██║██╔════╝ ".PadLeft(70));
			Console.WriteLine(@"███████║███████║██╔██╗ ██║██║  ███╗".PadLeft(70));
			Console.WriteLine(@"██╔══██║██╔══██║██║╚██╗██║██║   ██║".PadLeft(70));
			Console.WriteLine(@"██║  ██║██║  ██║██║ ╚████║╚██████╔╝".PadLeft(70));
			Console.WriteLine(@"╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝ ".PadLeft(70));


			Console.Beep(440, 500); //
			Console.Beep(349, 350);
			Console.Beep(523, 150);

			Console.Clear();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine(@"██╗  ██╗ █████╗ ███╗   ██╗ ██████╗ ███╗   ███╗ █████╗ ".PadLeft(80));
			Console.WriteLine(@"██║  ██║██╔══██╗████╗  ██║██╔════╝ ████╗ ████║██╔══██╗".PadLeft(80));
			Console.WriteLine(@"███████║███████║██╔██╗ ██║██║  ███╗██╔████╔██║███████║".PadLeft(80));
			Console.WriteLine(@"██╔══██║██╔══██║██║╚██╗██║██║   ██║██║╚██╔╝██║██╔══██║".PadLeft(80));
			Console.WriteLine(@"██║  ██║██║  ██║██║ ╚████║╚██████╔╝██║ ╚═╝ ██║██║  ██║".PadLeft(80));
			Console.WriteLine(@"╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝ ╚═╝     ╚═╝╚═╝  ╚═╝".PadLeft(80));
			Console.Beep(440, 500); //

			Console.Beep(349, 350);
			Console.Beep(523, 150);
			Console.Clear();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine(@"██╗  ██╗ █████╗ ███╗   ██╗ ██████╗ ███╗   ███╗ █████╗ ███╗   ██╗".PadLeft(85));
			Console.WriteLine(@"██║  ██║██╔══██╗████╗  ██║██╔════╝ ████╗ ████║██╔══██╗████╗  ██║".PadLeft(85));
			Console.WriteLine(@"███████║███████║██╔██╗ ██║██║  ███╗██╔████╔██║███████║██╔██╗ ██║".PadLeft(85));
			Console.WriteLine(@"██╔══██║██╔══██║██║╚██╗██║██║   ██║██║╚██╔╝██║██╔══██║██║╚██╗██║".PadLeft(85));
			Console.WriteLine(@"██║  ██║██║  ██║██║ ╚████║╚██████╔╝██║ ╚═╝ ██║██║  ██║██║ ╚████║".PadLeft(85));
			Console.WriteLine(@"╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝ ╚═╝     ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝".PadLeft(85));
			Console.WriteLine(@"                                                                ".PadLeft(85));
			Console.WriteLine(@"                                                     Version 1.0".PadLeft(85));
			Console.Beep(440, 1000); //
			Console.WriteLine("Welcome to Hangman The Game".PadLeft(65));

			Console.Beep(659, 500);//
			Console.Beep(659, 500);
			Console.WriteLine("Now we will have some fun!".PadLeft(65));
			Console.Beep(659, 500);//
			Console.Beep(698, 350);
			Console.Beep(523, 150);
			Console.WriteLine();
			Console.WriteLine("Try to save Mr.Plugger".PadLeft(62));
			Console.Beep(415, 500);//
			Console.Beep(349, 350);
			Console.Beep(523, 150);
			Console.WriteLine("by guessing the right word!".PadLeft(66));
			Console.Beep(440, 1000);//
			Console.WriteLine();
			Console.WriteLine("Press enter to continue".PadLeft(67));


		}

		static void StoryLine()
		{
			Console.Clear();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("*******************************************************".PadLeft(80));
			Console.WriteLine("*******************************************************".PadLeft(80));
			Console.WriteLine("***                                                 ***".PadLeft(80));
			Console.WriteLine("***    Mr.Plugger is a GUILTY bastard that wants    ***".PadLeft(80));
			Console.WriteLine("***                                                 ***".PadLeft(80));
			Console.WriteLine("***       to escape the clutches of hell, but       ***".PadLeft(80));
			Console.WriteLine("***                                                 ***".PadLeft(80));
			Console.WriteLine("***                can you save him?                ***".PadLeft(80));
			Console.WriteLine("***                                                 ***".PadLeft(80));
			Console.WriteLine("***        Are you ready to create injustice?       ***".PadLeft(80));
			Console.WriteLine("***                                                 ***".PadLeft(80));
			Console.WriteLine("***              by saving Mr.Plugger?              ***".PadLeft(80));
			Console.WriteLine("***                                                 ***".PadLeft(80));
			Console.WriteLine("*******************************************************".PadLeft(80));
			Console.WriteLine("*******************************************************".PadLeft(80));
			ContinueGame();
		}


		static void MrPluggerGraphic()
		{

			if (playerLives == 10)
			{
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
			}
			else if (playerLives == 9)
			{
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine(@"                                         __________ _________ ");

			}
			else if (playerLives == 8)
			{
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine(@"                                                          ");
				Console.WriteLine(@"                                                          ");
				Console.WriteLine(@"                                                          ");
				Console.WriteLine(@"                                                          ");
				Console.WriteLine(@"                                                          ");
				Console.WriteLine(@"                                                          ");
				Console.WriteLine(@"                                                          ");
				Console.WriteLine(@"                                                   ");
				Console.WriteLine(@"                                                   ");
				Console.WriteLine(@"                                        __________ _________ ");
			}
			else if (playerLives == 7)
			{
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine(@"                                                             ");
				Console.WriteLine(@"                                                  |          ");
				Console.WriteLine(@"                                                  |          ");
				Console.WriteLine(@"                                                  |          ");
				Console.WriteLine(@"                                                  |           ");
				Console.WriteLine(@"                                                  |           ");
				Console.WriteLine(@"                                                  |          ");
				Console.WriteLine(@"                                                  |");
				Console.WriteLine(@"                                                  |");
				Console.WriteLine(@"                                        __________|_________ ");
			}
			else if (playerLives == 6)
			{
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine(@"                                                   _________ ");
				Console.WriteLine(@"                                                  |          ");
				Console.WriteLine(@"                                                  |          ");
				Console.WriteLine(@"                                                  |          ");
				Console.WriteLine(@"                                                  |           ");
				Console.WriteLine(@"                                                  |           ");
				Console.WriteLine(@"                                                  |          ");
				Console.WriteLine(@"                                                  |");
				Console.WriteLine(@"                                                  |");
				Console.WriteLine(@"                                        __________|_________ ");
			}
			else if (playerLives == 5)
			{
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine(@"                                                   _________ ");
				Console.WriteLine(@"                                                  |         |");
				Console.WriteLine(@"                                                  |         |");
				Console.WriteLine(@"                                                  |         O");
				Console.WriteLine(@"                                                  |           ");
				Console.WriteLine(@"                                                  |           ");
				Console.WriteLine(@"                                                  |          ");
				Console.WriteLine(@"                                                  |");
				Console.WriteLine(@"                                                  |");
				Console.WriteLine(@"                                        __________|_________ ");
			}
			else if (playerLives == 4)
			{
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine(@"                                                   _________ ");
				Console.WriteLine(@"                                                  |         |");
				Console.WriteLine(@"                                                  |         |");
				Console.WriteLine(@"                                                  |         O");
				Console.WriteLine(@"                                                  |         | ");
				Console.WriteLine(@"                                                  |           ");
				Console.WriteLine(@"                                                  |          ");
				Console.WriteLine(@"                                                  |");
				Console.WriteLine(@"                                                  |");
				Console.WriteLine(@"                                        __________|_________ ");
			}
			else if (playerLives == 3)
			{
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine(@"                                                   _________ ");
				Console.WriteLine(@"                                                  |         |");
				Console.WriteLine(@"                                                  |         |");
				Console.WriteLine(@"                                                  |         O");
				Console.WriteLine(@"                                                  |        /| ");
				Console.WriteLine(@"                                                  |           ");
				Console.WriteLine(@"                                                  |          ");
				Console.WriteLine(@"                                                  |");
				Console.WriteLine(@"                                                  |");
				Console.WriteLine(@"                                        __________|_________ ");
			}
			else if (playerLives == 2)
			{
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine(@"                                                   _________ ");
				Console.WriteLine(@"                                                  |         |");
				Console.WriteLine(@"                                                  |         |");
				Console.WriteLine(@"                                                  |         O");
				Console.WriteLine(@"                                                  |        /|\");
				Console.WriteLine(@"                                                  |           ");
				Console.WriteLine(@"                                                  |          ");
				Console.WriteLine(@"                                                  |");
				Console.WriteLine(@"                                                  |");
				Console.WriteLine(@"                                        __________|_________ ");
			}
			else if (playerLives == 1)
			{
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine(@"                                                   _________ ");
				Console.WriteLine(@"                                                  |         |");
				Console.WriteLine(@"                                                  |         |");
				Console.WriteLine(@"                                                  |         O");
				Console.WriteLine(@"                                                  |        /|\");
				Console.WriteLine(@"                                                  |        /  ");
				Console.WriteLine(@"                                                  |          ");
				Console.WriteLine(@"                                                  |");
				Console.WriteLine(@"                                                  |");
				Console.WriteLine(@"                                        __________|_________ ");
			}
			else if (playerLives == 0)
			{
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine(@"                                                   _________ ");
				Console.WriteLine(@"                                                  |         |");
				Console.WriteLine(@"                                                  |         |");
				Console.WriteLine(@"                                                  |         O");
				Console.WriteLine(@"                                                  |        /|\");
				Console.WriteLine(@"                                                  |        /|\");
				Console.WriteLine(@"                                                  |         |");
				Console.WriteLine(@"                                                  |");
				Console.WriteLine(@"                                                  |");
				Console.WriteLine(@"                                        __________|_________ ");
			}

		}
	}
	}
