// TODO: Uprav tuto funkci
int MinimalniCas(int startovniPatro, int cilovePatro, int patroVytahu, int casNaPatro)
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
        int startovniPatro = int.Parse(problem[0]);
        int cilovePatro = int.Parse(problem[1]);
        int patroVytahu = int.Parse(problem[2]);
        int casNaPatro = int.Parse(problem[3]);

        vystup.WriteLine(MinimalniCas(startovniPatro, cilovePatro, patroVytahu, casNaPatro));
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
