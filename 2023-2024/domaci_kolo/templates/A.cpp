#include <bits/stdc++.h>

uint32_t nejkratsi_vzdalenost(uint32_t sirka, uint32_t delka, uint32_t predni, uint32_t zadni) {
    uint32_t zleva = 0;  // Vypočítejte cestu zleva
    uint32_t zprava = 0; // Vypočítejte cestu zprava

    return 0; // Určete kratší vzdálenost
}

// Načítání vstupu

template <typename I, typename O>
void precti_vstup(I &vstup, O &vystup) {
    vstup.exceptions(std::ios::badbit | std::ios::failbit);
    vystup.exceptions(std::ios::badbit | std::ios::failbit);

    size_t pocet_problemu;
    vstup >> pocet_problemu;

    for (size_t i = 0; i < pocet_problemu; i++) {
        uint32_t sirka, delka, predni, zadni;
        vstup >> sirka >> delka >> predni >> zadni;

        vystup << nejkratsi_vzdalenost(sirka, delka, predni, zadni) << std::endl;
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
