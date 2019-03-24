using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramZaliczeniowy
{
    static class Rysowanie
    {
        const int PozycjaMenuX = 7;
        const int PozycjaMenuY = 3;

        public static void RysujPostac(ObiektyGry postac)
        {
            Console.SetCursorPosition(postac.PozycjaX, postac.PozycjaY);
            Console.Write(postac.WygladGora);
            if (postac.WygladDol != null)
            {
                Console.SetCursorPosition(postac.PozycjaX, postac.PozycjaY + 1);
                Console.Write(postac.WygladDol);
            }
        }
        public static void CzyscPostac(ObiektyGry postac)  // Pseudo destruktor 
        {
            Console.SetCursorPosition(postac.PozycjaX, postac.PozycjaY);
            Console.Write("     ");
            if (postac.WygladDol != null)
            {
                Console.SetCursorPosition(postac.PozycjaX, postac.PozycjaY + 1);
                Console.Write("     ");
            }
        }
        public static void RysujMenu(Menu menu)
        {           
            Console.ResetColor();
            Console.Clear();
            Console.CursorVisible = false;
            Console.SetWindowSize(30, 8);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            for (int i = 0; i <= PozycjaMenuY + 5; i++)  // Rysowanie czerwonego tła pod menu
            {
                Console.WriteLine("                              ");
            }
            Console.SetCursorPosition(PozycjaMenuX, PozycjaMenuY);  // Menu - podświetlanie wyborów
            if (menu.Wybor == 1)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(menu.Start);               
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(menu.Start);
            }
            Console.SetCursorPosition(PozycjaMenuX, PozycjaMenuY + 1);
            if (menu.Wybor == 2)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                if (Muzyka.MuzykaOnOff==true)
                {
                    Console.WriteLine(menu.MuzykaON);
                }
                if (Muzyka.MuzykaOnOff==false)
                {
                    Console.WriteLine(menu.MuzykaOFF);
                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                if (Muzyka.MuzykaOnOff == true)
                {
                    Console.WriteLine(menu.MuzykaON);
                }
                if (Muzyka.MuzykaOnOff == false)
                {
                    Console.WriteLine(menu.MuzykaOFF);
                }
            }
            Console.SetCursorPosition(PozycjaMenuX, PozycjaMenuY + 2);
            if (menu.Wybor == 3)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(menu.Wyjscie);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(menu.Wyjscie);
            }
            Console.SetCursorPosition(PozycjaMenuX+2, PozycjaMenuY - 2 );
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" GRA THE GRA! ");
            Console.SetCursorPosition(0, 0);        
        }
        public static void RysujWpisywanieDanych(Gracz gracz)
        {
            do
            {
            Console.ResetColor();
            Console.Clear();
            Console.CursorVisible = false;
            Console.SetWindowSize(30, 8);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            for (int i = 0; i <= PozycjaMenuY + 8; i++)   // Rysowanie tła 
                {
                Console.WriteLine("                              ");
            }
            Console.SetCursorPosition(0, 0);
            Console.SetCursorPosition(PozycjaMenuX, PozycjaMenuY - 1);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Wpisz nazwe gracza:");
            Console.SetCursorPosition(PozycjaMenuX, PozycjaMenuY);
            Console.CursorVisible = true;
            Console.Write("                   ");
            Console.SetCursorPosition(PozycjaMenuX, PozycjaMenuY);
            gracz.Nazwa = Console.ReadLine();

                if (gracz.Nazwa == null)
            {
               Muzyka.GrajBlad();
                Console.SetCursorPosition(PozycjaMenuX-3, PozycjaMenuY + 2);
                Console.WriteLine("          Błąd          ");
                Console.SetCursorPosition(PozycjaMenuX-3, PozycjaMenuY + 3);
                Console.WriteLine("Imie nie może być puste.");
                Console.ReadKey();
            }
            } while (gracz.Nazwa == null);
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);
            Muzyka.GrajClick();
        }
        public static void RysujWyniki(Gracz gracz)
        {
            Console.ResetColor();
            Console.Clear();
            Console.CursorVisible = false;
            Console.SetWindowSize(30, 8);
            Console.BackgroundColor = ConsoleColor.DarkRed; 
            for (int i = 0; i <= PozycjaMenuY + 5; i++)
            {
                Console.WriteLine("                              ");
            }
            Console.SetCursorPosition(PozycjaMenuX, PozycjaMenuY - 2);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Gratulacje {0} ! ", gracz.Nazwa);
            Console.SetCursorPosition(PozycjaMenuX, PozycjaMenuY);
            Console.Write(" Twój wynik to: {0} ", gracz.Wynik);
            Console.SetCursorPosition(PozycjaMenuX-5, PozycjaMenuY + 3);
            Console.Write("Wcisnij dowolny klawisz...");
            Console.SetCursorPosition(0, 0);
        }      
    }
}
