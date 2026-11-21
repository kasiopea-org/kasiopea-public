#include <array>
#include <fstream>
#include <iostream>
#include <string>
#include <utility>

int nejmensi_pocet_skartovani(int sirka_papiru, int vyska_papiru, int pozadovana_delka) {
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
        int sirka_papiru, vyska_papiru, pozadovana_delka;
        vstup >> sirka_papiru >> vyska_papiru >> pozadovana_delka;

        vystup << nejmensi_pocet_skartovani(sirka_papiru, vyska_papiru, pozadovana_delka) << std::endl;
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
