using System;
using System.Collections.Generic;
using System.Text;

namespace EsempioClassiNetStd
{
    public class Prezzo
    {
        private bool _eSconto = false;
        public bool GetESconto() { return _eSconto; }

        private decimal _valore = 0;
        public decimal GetValore() { return _valore; }
        public void SetValore(decimal valore)
        {
            _valore = valore;
            _eSconto = valore < 0;
        }

    }
}
