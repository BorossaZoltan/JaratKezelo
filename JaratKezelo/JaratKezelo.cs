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
                    item.Keses += keses;
                }
            }
        }

        public DateTime MikorIndul(string jaratszam)
        {
            foreach (var item in lista)
            {
                if (item.JaratSzam == jaratszam)
                {
                    return item.Indulas;
                }
            }

            
        }

        public List<string> JaratokRepuloterrol(string repter)
        {

        }


    }
}
