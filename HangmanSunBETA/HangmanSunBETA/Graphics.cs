using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace HangmanSunBETA
{
	class Graphics
	{
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
			Console.WriteLine("***                  between 1 and 4                ***".PadLeft(80));
			Console.WriteLine("***                                                 ***".PadLeft(80));
			Console.WriteLine("*******************************************************".PadLeft(80));
			Console.WriteLine("*******************************************************".PadLeft(80));
		}

		private static void ShowInfoGraphics()
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
		}

		static void TypeYourNameGraphic()
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
		}

		static void GameplayGraphics()
		{
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
		}

		static void DifficultyLevelGraphics()
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
		}
}