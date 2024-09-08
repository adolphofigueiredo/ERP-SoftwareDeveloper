using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsempioClassiCA.EsempiDiClassi
{
    public class Veicolo
    {
        // proprieta in sola Lettura
        public int NumeroDiRuote { get; }

        // proprietà in lettura e scrittura
        public string Colore { get; set; }

        // costrututtore dell'oggetto veicolo
        public Veicolo(int numeroDiRuote)
        {
            // inizializzo la proprieta dell'oggetto
            // con il valore passato dal parametro in input
            this.NumeroDiRuote = numeroDiRuote;
        }
    }
}
