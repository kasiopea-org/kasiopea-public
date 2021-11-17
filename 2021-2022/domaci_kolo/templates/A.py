#!/usr/bin/python3


def spocitej_vysledek(cena_nakupu, koruny, dvoukoruny, petikoruny, desetikoruny, dvacetikoruny, padesatikoruny):
    """
    Funkce s Tvým kódem, která řeší jeden problém.

    Můžeš využít všechny parametry funkce: cena_nakupu, koruny, dvoukoruny, petikoruny, desetikoruny, dvacetikoruny, padesatikoruny
    """

    # Zjisti, kolik má Honza vlastně peněz
    celkem_penez = 0  # Změň mě

    # Poté to porovnej s cenou nákupu a zjisti výsledek
    if celkem_penez < cena_nakupu:
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
            cena_nakupu = int(vstup.readline())  # načti cenu nákupu

            koruny, dvoukoruny, petikoruny, desetikoruny, dvacetikoruny, padesatikoruny = [
                int(x) for x in vstup.readline().split()
            ]  # načtení vstupu

            vysledek = spocitej_vysledek(cena_nakupu, koruny, dvoukoruny, petikoruny, desetikoruny, dvacetikoruny, padesatikoruny)

            print(vysledek, file=vystup)
