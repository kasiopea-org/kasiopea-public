#include <iostream>
#include <fstream>
#include <string>

// Pro použití šablony ulož vstupní soubor do stejné složky jako šablonu
// a pojmenuj jej "A.txt". Šablona sama vstup načte, spočítá výsledky
// pomocí tvého kódu níže a výstup uloží do souboru "A-vysledek.txt".

/**
 * Funkce s Tvým kódem, která řeší jeden problém.
 *
 * Můžeš využít všechny parametry funkce: cena_velkeho, objem_velkeho, cena_maleho, objem_maleho */
std::string spocitej_vysledek(int cena_velkeho, int objem_velkeho, int cena_maleho, int objem_maleho) {
    std::string vysledek;

    int velke_na_litr = 0; // Vypočítej, kolik stojí velké balení na litr.
    int male_na_litr = 0; // Vypočítej, kolik stojí malé balení na litr.

    // Urči, která z cen je výhodnější
    if (velke_na_litr <= male_na_litr) {
        vysledek = "NEVIM"; // Změň mě
    } else {
        vysledek = "NEVIM"; // Změň mě
    }

    return vysledek;
}



//###########################################################################################
// Všechen kód pod tímto komentářem slouží jen k načítání vstupu a není třeba ho upravovat. #
//###########################################################################################

int main() {
    std::ifstream input("A.txt");
    std::ofstream output("A-vysledek.txt");

    int T;
    input >> T;

    for (int t = 0; t < T; t++) {
        int cena_velkeho, objem_velkeho, cena_maleho, objem_maleho;

        input >> cena_velkeho >> objem_velkeho >> cena_maleho >> objem_maleho;
        std::string vysledek = spocitej_vysledek(cena_velkeho, objem_velkeho, cena_maleho, objem_maleho);
        output << vysledek << std::endl;
    }

    return 0;
}
