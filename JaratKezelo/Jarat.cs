using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaratKezelo
{
    class Jarat
    {
        public string JaratSzam;
        public string HonnanRepter;
        public string HovaRepter;
        public DateTime Indulas;
        public int Keses;

        public Jarat(string jaratSzam, string honnanRepter, string hovaRepter, DateTime indulas, int keses)
        {
            JaratSzam = jaratSzam;
            HonnanRepter = honnanRepter;
            HovaRepter = hovaRepter;
            Indulas = indulas;
            Keses = keses;
        }


    }
}
