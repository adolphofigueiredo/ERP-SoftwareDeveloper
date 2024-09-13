using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsempioClassiCA.Cellulare
{
    public class Cellulare
    {
        private bool _sonoInChiamata = false;

        public delegate void ChiamataIniziataDelegate();
        public event ChiamataIniziataDelegate ChiamataIniziata;

        public delegate void ChiamataTerminataDelegate();
        public event ChiamataTerminataDelegate ChiamataTerminata;

        public Schermo Schermo { get; set; }
        public Batteria Batteria { get; set; }
        public Fotocamera Fotocamera { get; set; }


        public void Chiama(string nTel)
        {
            if (_sonoInChiamata == true) throw new Exception("Operazione non consentita");
            _sonoInChiamata = true;

            if(ChiamataIniziata!=null) ChiamataIniziata();
        }

        public void HangUp()
        {
            if (_sonoInChiamata == true)
                _sonoInChiamata = false;

            if (ChiamataTerminata != null) ChiamataTerminata();
        }
    }
}
