using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinylsamling
{
	class AddOrEditVinyls
	{
		static string AlbumName { get; set; }
		static string ArtistName { get; set; }
		static int yearOfRelease;
		static string inputYear { get; set; }
		static int rewievScore;


		public static void AddVinylToList()
		{
			Console.WriteLine("Please type in the name of the artist: ");
			AlbumName = (Console.ReadLine());

			Console.WriteLine("Please type in the name of the album: ");
			ArtistName = (Console.ReadLine());

			Console.WriteLine("Please type in the release year of the album: ");
			string inputYear = (Console.ReadLine());
			if (!int.TryParse(inputYear, out yearOfRelease))
			Console.WriteLine("{0} is not a number", inputYear);
	
	        Console.WriteLine("Please type in the rewiev score 1 to 5: ");
			string inputRewiev = Console.ReadLine();
			if (!int.TryParse(inputRewiev, out rewievScore))
			Console.WriteLine("{0} is not a number", inputRewiev);
			
		    Program.vinylList.Add(AlbumName + " " + ArtistName + " " + yearOfRelease + " " + rewievScore);
			Program.SaveVinylToList();

		}

		public static void EditVinylList()
		{
			bool editVinylListLoop = true;
			while (editVinylListLoop)
			{
				Program.ShowVinylInList();
				Console.WriteLine("Which Row do you wish to replace?");
				try
				{
					int editInput = Convert.ToInt32(Console.ReadLine());

					Console.WriteLine("Please type in the name of the artist: ");
					AlbumName = (Console.ReadLine());

					Console.WriteLine("Please type in the name of the album: ");
					ArtistName = (Console.ReadLine());

					Console.WriteLine("Please type in the release year of the album: ");
					string inputYear = (Console.ReadLine());
					if (!int.TryParse(inputYear, out yearOfRelease))
						Console.WriteLine("{0} is not a number", inputYear);

					Console.WriteLine("Please type in the rewiev score 1 to 5: ");
					string inputRewiev = Console.ReadLine();
					if (!int.TryParse(inputRewiev, out rewievScore))
						Console.WriteLine("{0} is not a number", inputRewiev);

					Program.vinylList[editInput - 1] = AlbumName + " " + ArtistName + " " + yearOfRelease + " " + rewievScore;
					Program.SaveVinylToList();
					Console.WriteLine("Press enter to continue, or press e to exit!");
					if (Console.ReadLine() == "e")
						editVinylListLoop = false;
					else
						Console.WriteLine("You must press e");
				}
				catch (Exception)
				{
					Console.WriteLine("Type in a valid number!");
				}
			}
		}


	}
}
