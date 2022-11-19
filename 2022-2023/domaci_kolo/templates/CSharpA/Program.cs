using System.IO;

// Pro použití šablony ulož vstupní soubor do stejné složky jako šablonu
// a pojmenuj jej "A.txt". Šablona sama vstup načte, spočítá výsledky
// pomocí tvého kódu níže a výstup uloží do souboru "A-vysledek.txt".


namespace A
{
	class Program
	{
		/**
		* Funkce s Tvým kódem, která řeší jeden problém.
		*
		* Můžeš využít všechny parametry funkce: cenaVelkeho, objemVelkeho, cenaMaleho, objemMaleho
		*/
		static string SpocitejVysledek(int cenaVelkeho, int objemVelkeho, int cenaMaleho, int objemMaleho)
		{
			string vysledek;

			int velkeNaLitr = 0;  // Vypočítej, kolik stojí velké balení na litr
			int maleNaLitr = 0; // Vypočítej, kolik stojí malé balení na litr.

			// Urči, která z cen je výhodnější
			if (velkeNaLitr <= maleNaLitr) {
				vysledek = "NEVIM"; // Změň mě
			} else {
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
						int cenaVelkeho = int.Parse(r.ReadLine());
						int objemVelkeho = int.Parse(r.ReadLine());
						int cenaMaleho = int.Parse(r.ReadLine());
						int objemMaleho = int.Parse(r.ReadLine());

						string vysledek = SpocitejVysledek(cenaVelkeho, objemVelkeho, cenaMaleho, objemMaleho);

						w.WriteLine(vysledek);
					}
				}
			}
		}
	}
}
