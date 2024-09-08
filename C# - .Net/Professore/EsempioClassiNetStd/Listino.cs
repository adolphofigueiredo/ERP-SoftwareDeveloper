using System;
using System.Collections.Generic;
using System.Text;

namespace EsempioClassiNetStd
{
    public class Listino
    {
        public DateTime ValidoDa { get; set; }

        public DateTime? ValidoA { get; set; }


        private DateTime? _validoA;
        public DateTime? GetValidoA() { return _validoA; }
        public void SetValidoA(DateTime? value) { _validoA = value; }

        public ICollection<RigaListino> RigheListino { get; set; }
        //public Nullable<DateTime> ValidoA { get; set; }
    }
}
