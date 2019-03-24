using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace ProgramZaliczeniowy
{
    static class Muzyka
    {
        public static bool MuzykaOnOff { get; set; }

        public static void GrajMuzyka()
        {
            SoundPlayer nuta = new SoundPlayer();
            nuta.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Extreme Metal - Wars of Power.wav";
            if (MuzykaOnOff == true)
            {
                nuta.Play();
            }
        }
        public static void GrajBlad()
        {
            SoundPlayer blad = new SoundPlayer();
            blad.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\blad.wav";
            if (MuzykaOnOff == true)
            {
                blad.Play();
            }
        }
        public static void GrajUpDown()
        {
            SoundPlayer upDown = new SoundPlayer();
            upDown.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\upDown.wav";
            if (MuzykaOnOff == true)
            { 
                upDown.Play();
            }                    
        }
        public static void GrajClick()
        {
            SoundPlayer click = new SoundPlayer();
            click.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\click.wav";
            if (MuzykaOnOff == true)
            {
                click.Play();
            }
            Console.ResetColor();
            Console.Clear();
            System.Threading.Thread.Sleep(600);
        }
        public static void GrajEnd()
        { 
            SoundPlayer end = new SoundPlayer();
            end.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\end.wav";
            if (MuzykaOnOff == true)
            {
                end.Play();
            }
        }

    }
}
