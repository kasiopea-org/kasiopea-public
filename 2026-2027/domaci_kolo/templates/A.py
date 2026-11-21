#!/usr/bin/env python3
import sys


def nejmensi_pocet_skartovani(sirka_papiru, vyska_papiru, pozadovana_delka):
    """TODO: Uprav tuto funkci"""

    return 5  # Vrať minimální počet skartovaných papírů


# Načítání vstupu


def precti_vstup(input, output):
    pocet_problemu = int(input.readline())

    for _ in range(pocet_problemu):
        sirka_papiru, vyska_papiru, pozadovana_delka = map(int, input.readline().split())

        reseni = nejmensi_pocet_skartovani(sirka_papiru, vyska_papiru, pozadovana_delka)

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
