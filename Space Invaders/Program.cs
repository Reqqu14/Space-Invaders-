using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProgramZaliczeniowy
{
    class Program
    {
        static void Main(string[] args)
        {        
            Rozgrywka gra = new Rozgrywka();
            Menu menu = new Menu();

            while (true)
            {
                Rysowanie.RysujMenu(menu);
                ConsoleKeyInfo k = Console.ReadKey();
                switch (k.Key)
                {
                    case ConsoleKey.UpArrow:
                        Muzyka.GrajUpDown();
                        menu.RuchWGore();
                        break;   
                    case ConsoleKey.DownArrow:
                        Muzyka.GrajUpDown();
                        menu.RuchWDol();
                        break;
                    case ConsoleKey.Enter:
                        Muzyka.GrajClick();
                        menu.Wybierz();
                        break;
                }
             }
        }
    }
}
