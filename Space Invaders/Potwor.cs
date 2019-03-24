using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramZaliczeniowy
{
    class Potwor: ObiektyGry // Dziedziczenie z abstrakcyjnej klasy z obiektami gry 
    {
        const int DomyslnaSzybkosc = 3;

        private int spowolnienie;
        private int szybkosc=10;
        public bool Zycie { get; set; }

        public Potwor(int x, int y, int spowolnienie)
        {
            Zycie = true;
            WygladGora = "|**#**|";    // Dziedziczenie z klasy Obiekty
            PozycjaX = x;
            PozycjaY = y;
            this.spowolnienie = spowolnienie; // definiuje z jakim opoznieniem spada potworek
        }
        public Potwor(int x, int y, int spowolnienie, string wyglad)  // Przeciazenie konstruktora w celu stworzenia innego potwora
        {
            Zycie = true;
            WygladGora = wyglad;
            PozycjaX = x;
            PozycjaY = y;
            this.spowolnienie = spowolnienie; // definiuje z jakim opoznieniem spada potworek
        }
        public override void Ruch()  // Nadpisanie metody virtualnej
        {
            base.Ruch();
            if (PozycjaY != 29)  // Pozycja potwora inna niż krawędź dolna konsoli
            {
                if (szybkosc % spowolnienie  == 0)
                {
                    PozycjaY += 1;
                    szybkosc++;                   
                }
                else
                {
                    szybkosc++;
                }
                if (szybkosc >= 100)
                {
                    szybkosc = 1;
                }
            }
            
        }       
    }
}
