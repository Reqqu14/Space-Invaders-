
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramZaliczeniowy
{
    abstract class ObiektyGry
    {
        public int PozycjaX { get; set; }
        public int PozycjaY { get; set; }
        public string WygladGora { get; set; }
        public string WygladDol { get; set; }

        public virtual void Ruch() { }
    }
}
