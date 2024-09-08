using System;
using System.Collections.Generic;
using System.Text;

namespace EsempioClassiNetStd
{
    public enum UnitaDiMisuraEnum
    {
        mm,
        cm,
        dm,
        m,
        km,

        mg,
        dg,
        g,
        hg,
        kg,

        mmq,
        cmq,
        dmq,
        mq,
        kmq
    }
    public class Dimensione
    {
        public decimal Valore { get; set; }
        public UnitaDiMisuraEnum UnitaMisura { get; set; }
    }
}
