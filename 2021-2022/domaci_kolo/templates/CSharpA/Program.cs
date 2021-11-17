using System.IO;

namespace A
{
	class Program
	{
		/**
		* Funkce s Tvým kódem, která řeší jeden problém.
		*
		* Můžeš využít všechny parametry funkce: cenaNakupu, koruny, dvoukoruny, petikoruny, desetikoruny, dvacetikoruny, padesatikoruny
		*/
		static string SpocitejVysledek(int cenaNakupu, int koruny, int dvoukoruny, int petikoruny, int desetikoruny, int dvacetikoruny, int padesatikoruny)
		{
			int celkemPenez;
			string vysledek;

			// Zjisti, kolik má Honza vlastně peněz
			celkemPenez = 0; // Změň mě

			// Poté to porovnej s cenou nákupu a zjisti výsledek
			if (celkemPenez < cenaNakupu)
			{
				vysledek = "NEVIM"; // Změň mě
			}
			else
			{
				vysledek = "NEVIM"; // Změň mě
			}

			return vysledek;
		}


		//###########################################################################################
		// Všechen kód pod tímto komentářem slouží jen k načítání vstupu a není třeba ho upravovat. #
		//###########################################################################################

		static void Main(string[] args)
		{
			using (StreamReader r = new StreamReader("A.txt"))
			{
				using (StreamWriter w = new StreamWriter("A-vysledek.txt"))
				{
					int T = int.Parse(r.ReadLine());
					for (int t = 0; t < T; t++)
					{
						int cenaNakupu = int.Parse(r.ReadLine());
						string line = r.ReadLine();
						string[] tokens = line.Split(' ');

						int koruny = int.Parse(tokens[0]);
						int dvoukoruny = int.Parse(tokens[1]);
						int petikoruny = int.Parse(tokens[2]);
						int desetikoruny = int.Parse(tokens[3]);
						int dvacetikoruny = int.Parse(tokens[4]);
						int padesatikoruny = int.Parse(tokens[5]);

						string vysledek = SpocitejVysledek(cenaNakupu, koruny, dvoukoruny, petikoruny, desetikoruny, dvacetikoruny, padesatikoruny);

						w.WriteLine(vysledek);
					}
				}
			}
		}
	}
}
