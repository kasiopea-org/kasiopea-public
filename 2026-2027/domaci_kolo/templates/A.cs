// TODO: Uprav tuto funkci
int NejmensiPocetSkartovani(int sirkaPapiru, int vyskaPapiru, int pozadovanaDelka)
{
    return 5;  // Vrať minimální počet skartovaných papírů
}

// Načítání vstupu

void PrectiVstup(TextReader vstup, TextWriter vystup)
{
    int pocetProblemu = int.Parse(vstup.ReadLine()!);

    for (int i = 0; i < pocetProblemu; i++)
    {
        string[] problem = vstup.ReadLine()!.Split(' ');
        int sirkaPapiru = int.Parse(problem[0]);
        int vyskaPapiru = int.Parse(problem[1]);
        int pozadovanaDelka = int.Parse(problem[2]);

        vystup.WriteLine(NejmensiPocetSkartovani(sirkaPapiru, vyskaPapiru, pozadovanaDelka));
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
        using var vystup = new StreamWriter(File.Create(nazevVystupu));

        PrectiVstup(vstup, vystup);

        souborNalezen = true;
    }
    catch (FileNotFoundException) { }
}

if (!souborNalezen)
{
    PrectiVstup(Console.In, Console.Out);
}
