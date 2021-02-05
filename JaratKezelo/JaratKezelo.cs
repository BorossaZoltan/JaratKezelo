using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaratKezelo
{
    public class JaratKezelo
    {
        List<Jarat> lista;

        public JaratKezelo()
        {
            this.lista = new List<Jarat>();
        }

        public void UjJarat(string jaratSzam, string repterHonnan, string repterHova, DateTime indulas)
        {
            foreach (var item in lista)
            {
                if (item.JaratSzam.Equals(jaratSzam))
                {
                    throw new ArgumentException($"Ezzel a járatszámmal már létezik járat ({jaratSzam})");

                }
            }
            Jarat j = new Jarat(jaratSzam, repterHonnan, repterHova, indulas);
        }

        public void Keses(string jaratSzam, int keses)
        {
            foreach (var item in lista)
            {
                if (item.JaratSzam == jaratSzam)
                {
                    if (item.Keses+keses >= 0)
                    {
                        item.Keses += keses;
                    }
                    else
                    {
                        throw new NegativKesesException(jaratSzam, keses);
                    }

                }
            }
        }

        public DateTime MikorIndul(string jaratSzam)
        {
            foreach (var item in lista)
            {
                if (item.JaratSzam == jaratSzam)
                {
                    return item.Indulas.AddMinutes(item.Keses);
                }
            }
            throw new ArgumentException($"Ezzel a járatszámmal nincs járat: ({jaratSzam})");

        }

        public List<string> JaratokRepuloterrol(string repter)
        {
            List<string> jaratSzamok = new List<string>();
            foreach (var item in lista)
            {
                if (item.HonnanRepter == repter)
                {
                    jaratSzamok.Add(item.JaratSzam);
                }
            }
            return jaratSzamok;
        }


    }
}
