#!/usr/bin/python3

# Pro použití šablony ulož vstupní soubor do stejné složky jako šablonu
# a pojmenuj jej "A.txt". Šablona sama vstup načte, spočítá výsledky
# pomocí tvého kódu níže a výstup uloží do souboru "A-vysledek.txt".

def spocitej_vysledek(cena_velkeho, objem_velkeho, cena_maleho, objem_maleho):
    """
    Funkce s Tvým kódem, která řeší jeden problém.

    Můžeš využít všechny parametry funkce: cena_velkeho, objem_velkeho,
    cena_maleho, objem_maleho
    """

    # Vypočítej, kolik stojí velké balení na litr, počítej celočíselně
    velke_na_litr = 0

    # Vypočítej, kolik stojí malé balení na litr, počítej celočíselně
    male_na_litr = 0

    # Urči, která z cen je výhodnější
    if velke_na_litr <= male_na_litr:
        vysledek = "NEVIM"  # Změň mě
    else:
        vysledek = "NEVIM"  # Změň mě

    return vysledek





############################################################################################
# Všechen kód pod tímto komentářem slouží jen k načítání vstupu a není třeba ho upravovat. #
############################################################################################

with open("A.txt", "r") as vstup:
    with open("A-vysledek.txt", "w") as vystup:
        T = int(vstup.readline())  # načti počet problémů
        for _ in range(T):
            cena_velkeho = int(vstup.readline())
            objem_velkeho = int(vstup.readline())
            cena_maleho = int(vstup.readline())
            objem_maleho = int(vstup.readline())

            vysledek = spocitej_vysledek(cena_velkeho, objem_velkeho, cena_maleho, objem_maleho)

            print(vysledek, file=vystup)
