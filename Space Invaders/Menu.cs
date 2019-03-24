using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramZaliczeniowy
{
    class Menu
    {
        public string Start { get; set; }
        public string MuzykaON { get; set; }
        public string MuzykaOFF { get; set; }
        public string Wyjscie { get; set; }
        public int Wybor { get; set; }
        Rozgrywka gra = new Rozgrywka();

        public Menu()
        {
            Start =     " Rozpocznij gre! ";
            MuzykaON =  "   Dzwieki: ON   ";
            MuzykaOFF = "   Dzwieki: OFF  ";
            Wyjscie =   "     Wyjscie     ";
            Wybor = 1;
        }
        public void RuchWGore()
        {
            if (Wybor == 1)
            {
                Wybor = 1;
            }
            else { Wybor--; }
        }
        public void RuchWDol()
        {
            if (Wybor == 3)
            {
                Wybor = 3;
            }
            else { Wybor++; }
        }
        public void Wybierz()
        {
            Console.ResetColor();
            switch (Wybor)
            {
                case 1:
                    gra.Graj();
                    break;
                case 2:
                    if (Muzyka.MuzykaOnOff == true)
                    {
                        Muzyka.MuzykaOnOff = false;
                    }else
                    {
                        Muzyka.MuzykaOnOff= true;
                    } 

                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }
            
        }
    }
}
