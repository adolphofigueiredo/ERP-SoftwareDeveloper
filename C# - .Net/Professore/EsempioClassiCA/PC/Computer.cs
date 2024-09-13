using System;

namespace EsempioClassiCA.PC
{
    public class Computer
    {
        private bool _pcAcceso;
        private bool _pcInStandBy;

        public delegate void AccensioneDelegate();
        public event AccensioneDelegate Accensione;

        public delegate void SpegnimentoDelegate();
        public event SpegnimentoDelegate Spegnimento;

        public Hd Hd { get; set; }
        public Ram Ram { get; set; }
        public SchedaVideo SchedaVideo { get; set; }

        public Computer()
        {
            
        }

        public void Accendi()
        {
            if (_pcAcceso == false)
            {
                _pcAcceso = true;
                if (Accensione != null) Accensione();
            }
        }

        public void Spegni()
        {
            if (_pcAcceso == true)
            {
                _pcAcceso = false;
                if (Spegnimento != null) Spegnimento();
            }

        }

        public void StandBy()
        {
            if (_pcAcceso == false)
                throw new Exception("Impossibile mettere in standby un pc spento");

            _pcInStandBy = true;
        }
    }


}
