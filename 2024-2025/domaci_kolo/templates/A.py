#!/usr/bin/env python3
import sys


def minimalni_cas(pocet_karticek, strihacka_cas, nuzky_cas, nuzky_pocet):
    """TODO: Uprav tuto funkci"""

    return 5  # Vrať celkový potřebný čás


# Načítání vstupu


def precti_vstup(input, output):
    pocet_problemu = int(input.readline())

    for _ in range(pocet_problemu):
        pocet_karticek, strihacka_cas, nuzky_cas, nuzky_pocet = map(int, input.readline().split())

        reseni = minimalni_cas(pocet_karticek, strihacka_cas, nuzky_cas, nuzky_pocet)

        output.write(f"{reseni}\n")


NAZVY_SOUBORU = [
    ("A-lehky.txt", "A-lehky-vystup.txt"),
    ("A-tezky.txt", "A-tezky-vystup.txt"),
]

soubor_nalezen = False

for nazev_vstupu, nazev_vystupu in NAZVY_SOUBORU:
    try:
        with open(nazev_vstupu, "r", 1, "utf-8") as vstup:
            with open(nazev_vystupu, "w", 1, "utf-8") as vystup:
                precti_vstup(vstup, vystup)

        soubor_nalezen = True

    except FileNotFoundError:
        pass

if not soubor_nalezen:
    precti_vstup(sys.stdin, sys.stdout)
