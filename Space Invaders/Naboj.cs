using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramZaliczeniowy
{
    class Naboj : ObiektyGry, IUstawialny
    {
        private int pozycjaStartowaY;
        private int pozycjaStartowaX;
        private bool zycie = true;

        public Naboj(int x, int y) // Konstruktor pocisku, ustawienie miejsca wylotu pocisku z lufy
        {
            PozycjaX = x + 2;
            PozycjaY = y - 1;
            WygladGora = "*";
        }
        public void UstawPozycjeStartowa(int x, int y)
        {
            pozycjaStartowaY = y - 1;
            pozycjaStartowaX = x + 2;
        }
        public void UstawPozycjeStartowa(int x, int y, Potwor potwor)
        {
            pozycjaStartowaY = y - 1;
            pozycjaStartowaX = x + 2;
            zycie = potwor.Zycie;
        }
        public override void Ruch() // Nadpisanie metody wirtualnej, ruch pocisku
        {

            if (PozycjaY == 0 || zycie == false)   // Jezeli pocisk osiagnie krawedz gorna ekranu lub zycie potwora = false
            {
                PozycjaX = pozycjaStartowaX; // Ustaw pozycje startwą pocisku tj lufa
                PozycjaY = pozycjaStartowaY;
                zycie = true;             
            }
            PozycjaY--; // Przesuwanie pocisku w gore

        }
    }
}
