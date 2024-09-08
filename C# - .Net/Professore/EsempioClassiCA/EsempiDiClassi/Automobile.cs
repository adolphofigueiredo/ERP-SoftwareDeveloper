using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsempioClassiCA.EsempiDiClassi
{
    public class Automobile : VeicoloAMotore
    {
        public int NumeroDiPorte { get; private set; }
        public Automobile(int cilindrataCC, int numeroDiPorte) : base(4, cilindrataCC)
        {
            NumeroDiPorte = numeroDiPorte;
        }
    }
}
