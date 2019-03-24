using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramZaliczeniowy
{
    class Statek:ObiektyGry
    {
        const int MinimalnaPozycjaStatku = 5;
        const int MaksymalnaPozycjaStatku = 110;

        private int szybkosc;

        public Statek(int x,int y)
        {
            PozycjaX = x;
            PozycjaY = y;
            szybkosc = 2;
            WygladGora = "^^|^^";
            WygladDol ="|O#O|";
        }
        public override void Ruch()
        {
            base.Ruch();
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo klawisz = Console.ReadKey(true);

                if (klawisz.Key == ConsoleKey.RightArrow)
                {
                    if (PozycjaX < MaksymalnaPozycjaStatku)
                    {
                        PozycjaX += 1 * szybkosc;
                    }
                    else
                    {
                        PozycjaX = MaksymalnaPozycjaStatku;
                    };
                }
                    
                if (klawisz.Key == ConsoleKey.LeftArrow)
                {
                    if (PozycjaX > MinimalnaPozycjaStatku)
                    {
                        PozycjaX -= 1 * szybkosc;
                    }
                    else
                    {
                        PozycjaX = MinimalnaPozycjaStatku;
                    }
                }
                    
            }
        }
    }
}
