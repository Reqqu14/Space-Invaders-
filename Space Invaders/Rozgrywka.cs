using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramZaliczeniowy
{
     class Rozgrywka
    {   const int StatekStartX = 55;
        const int StatekStartY = 28;
        const int PotworyPozycjaStartowa = 0;
        
        readonly int SzerokoscKonsoli = Console.WindowWidth;
        readonly int WysokoscKonsoli = Console.WindowHeight;
        int szybkoscPotwora;
        bool Koniec;
        Random rnd = new Random();
        ConsoleKeyInfo klawisz;

        
        ObiektyGry statek = new Statek(StatekStartX, StatekStartY);
        ObiektyGry naboj;
        public List<ObiektyGry> PotworyL { get; set; } // Lista do ktorej bd zapisywane potwory

        public void Graj()
        {
            Gracz gracz = new Gracz();
            Console.ResetColor();
            Console.Clear();
            szybkoscPotwora = 15;
            naboj = new Naboj(statek.PozycjaX, statek.PozycjaY);
            PotworyL = new List<ObiektyGry>();
            gracz.Nazwa = "";
            gracz.Wynik = 0;
            Rysowanie.RysujWpisywanieDanych(gracz);  // Wypisywanie danych gracza
            PotworyL.Clear(); // Czyszczenie listy
            Koniec = false;
            int zmiennaSpawnuPotwora = 1;
            Muzyka.GrajMuzyka();
            while (klawisz.Key != ConsoleKey.Escape && Koniec == false)
            {
                Console.SetWindowSize(SzerokoscKonsoli, WysokoscKonsoli);
                Rysowanie.CzyscPostac(statek);  // Czyszczenie statku i pocisku, zeby nie nakładały sie na siebie przy rysowaniu
                Rysowanie.CzyscPostac(naboj);

                statek.Ruch();
                (naboj as IUstawialny).UstawPozycjeStartowa(statek.PozycjaX, statek.PozycjaY);
                naboj.Ruch();

                Rysowanie.RysujPostac(statek); // Rysowanie statku i pocisku
                Rysowanie.RysujPostac(naboj);

                if (gracz.Wynik == 25)
                {
                    szybkoscPotwora = 10;
                }
                if (gracz.Wynik == 45)
                {
                    szybkoscPotwora = 5;
                }

                if (zmiennaSpawnuPotwora%30==0) // Żeby potworów nie było za dużo, ograniczenie ich spawnu
                {
                    ObiektyGry potwor1;
                    if (rnd.Next(-1, 1)==0){ 
                        potwor1 = new Potwor(rnd.Next(4, 114), PotworyPozycjaStartowa, szybkoscPotwora*2); // Różna prędkość różnych potworów
                    }
                    else
                    {
                        potwor1 = new Potwor(rnd.Next(4, 114), PotworyPozycjaStartowa, szybkoscPotwora, "[&&&]");
                    }
                    PotworyL.Add(potwor1); // Dodanie potwora do listy
                }
                foreach (Potwor item in PotworyL)
                {
                    // Trafienie potwora a nie obok niego, trafienie potwora na calej szerokosci zalicza,  trafienie potwora na jego wysokosci na ktorej sie znajduje
                    if ((naboj.PozycjaX >= item.PozycjaX - 1 && naboj.PozycjaX <= item.PozycjaX + 5) && naboj.PozycjaY == item.PozycjaY  && item.Zycie == true)
                    {
                        gracz.Wynik++;
                        item.Zycie = false;
                        (naboj as IUstawialny).UstawPozycjeStartowa(statek.PozycjaX, statek.PozycjaY, item);
                    }
                    if (item.Zycie == true && item.PozycjaY == StatekStartY) // jak potwór zejdzie dokladnie tak nisko jak moj statek
                    {
                        Muzyka.GrajEnd();
                        System.Threading.Thread.Sleep(4000);
                        Koniec =true;
                    }
                    if (item.Zycie == true)   // Potwór sie rusza i usuwana jest poprzednia pozycja
                    {
                        Rysowanie.CzyscPostac(item);
                        item.Ruch();
                        Rysowanie.RysujPostac(item);
                    }
                    if (item.Zycie == false)
                    {
                        Rysowanie.CzyscPostac(item);  // Cos w stylu destruktora, usuwa potwora po trafieniu
                    }
                }

                System.Threading.Thread.Sleep(40);// Coś jak FPS, wywolywanie petli co 40 milisekund
                zmiennaSpawnuPotwora++;
            }
            
            Rysowanie.RysujWyniki(gracz);
            System.Threading.Thread.Sleep(4000);
            gracz = null;
            Console.ReadKey();
        }
    }
}
