#include <bits/stdc++.h>

int minimalni_cas(int pocet_karticek, int strihacka_cas, int nuzky_cas, int nuzky_pocet) {
    // TODO: Uprav tuto funkci

    return 5;  // Vrať celkový potřebný čás
}

// Načítání vstupu

template <typename I, typename O>
void precti_vstup(I &vstup, O &vystup) {
    vstup.exceptions(std::ios::badbit | std::ios::failbit);
    vystup.exceptions(std::ios::badbit | std::ios::failbit);

    int pocet_problemu;
    vstup >> pocet_problemu;

    for (int i = 0; i < pocet_problemu; i++) {
        int pocet_karticek, strihacka_cas, nuzky_cas, nuzky_pocet;
        vstup >> pocet_karticek >> strihacka_cas >> nuzky_cas >> nuzky_pocet;

        vystup << minimalni_cas(pocet_karticek, strihacka_cas, nuzky_cas, nuzky_pocet) << std::endl;
    }
}

const std::array<std::pair<std::string, std::string>, 2> nazvy_souboru = {
    std::make_pair("A-lehky.txt", "A-lehky-vystup.txt"),
    std::make_pair("A-tezky.txt", "A-tezky-vystup.txt"),
};

int main() {
    bool soubor_nalezen = false;

    for (auto nazvy : nazvy_souboru) {
        std::ifstream vstup(nazvy.first);
        if (vstup.fail())
            continue;

        std::ofstream vystup(nazvy.second);

        precti_vstup(vstup, vystup);

        soubor_nalezen = true;
    }

    if (!soubor_nalezen)
        precti_vstup(std::cin, std::cout);
}
