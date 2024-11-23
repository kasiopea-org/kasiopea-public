// TODO: Uprav tuto funkci
int MinimalniCas(int pocetKarticek, int strihackaCas, int nuzkyCas, int nuzkyPocet)
{
    return 5;  // Vrať celkový potřebný čás
}

// Načítání vstupu

void PrectiVstup(TextReader vstup, TextWriter vystup)
{
    int pocetProblemu = int.Parse(vstup.ReadLine()!);

    for (int i = 0; i < pocetProblemu; i++)
    {
        string[] problem = vstup.ReadLine()!.Split(' ');
        int pocetKarticek = int.Parse(problem[0]);
        int strihackaCas = int.Parse(problem[1]);
        int nuzkyCas = int.Parse(problem[2]);
        int nuzkyPocet = int.Parse(problem[3]);

        vystup.WriteLine(MinimalniCas(pocetKarticek, strihackaCas, nuzkyCas, nuzkyPocet));
    }
}

(string, string)[] nazvySouboru = {
    ("A-lehky.txt", "A-lehky-vystup.txt"),
    ("A-tezky.txt", "A-tezky-vystup.txt"),
};

bool souborNalezen = false;

foreach (var (nazevVstupu, nazevVystupu) in nazvySouboru)
{
    try
    {
        using var vstup = new StreamReader(File.OpenRead(nazevVstupu));
        using var vystup = new StreamWriter(File.OpenWrite(nazevVystupu));

        PrectiVstup(vstup, vystup);

        souborNalezen = true;
    }
    catch (FileNotFoundException) { }
}

if (!souborNalezen)
{
    PrectiVstup(Console.In, Console.Out);
}
