using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaratKezelo
{
    class NegativKesesException : Exception
    {
        public NegativKesesException(string jaratszam, int keses) 
            : base($"Nem lehet negatív a késés szám! {jaratszam} :  késés - ({keses})")
        {
        }
    }
}
