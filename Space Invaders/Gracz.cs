using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramZaliczeniowy
{
    class Gracz
    {
        public int Wynik { get; set; }
        
        private string nazwa;
        public string Nazwa
        {
            get { return nazwa; }
            set
            {
                if (value.Length>0 && value.Length<10) // Sprawdzanie czy nazwa gracza jest odpowiednio dluga
                {
                    nazwa = value;
                    
                }
            }
        }

    }
}
