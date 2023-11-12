// Upravte tuto funkci
int NejkratsiVzdalenost(int sirka, int delka, int predni, int zadni)
{
    int zleva = 0; // Vypočítejte cestu zleva
    int zprava = 0; // Vypočítejte cestu zprava

    return 0; // Určete kratší vzdálenost
}

// Načítání vstupu

void PrectiVstup(TextReader vstup, TextWriter vystup)
{
    int pocetProblemu = int.Parse(vstup.ReadLine()!);

    for (int i = 0; i < pocetProblemu; i++)
    {
        int sirka = int.Parse(vstup.ReadLine()!);
        int delka = int.Parse(vstup.ReadLine()!);
        int predni = int.Parse(vstup.ReadLine()!);
        int zadni = int.Parse(vstup.ReadLine()!);

        vystup.WriteLine(NejkratsiVzdalenost(sirka, delka, predni, zadni));
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
