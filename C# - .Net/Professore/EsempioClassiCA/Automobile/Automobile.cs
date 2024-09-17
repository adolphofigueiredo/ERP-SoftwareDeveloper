using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EsempioClassiCA.PC.Computer;

namespace EsempioClassiCA
{

    public class Veicolo
    {
        public int NumeroDiRuote { get; set; }
    }

    public interface IVeicoloAMotore
    {
         bool MotoreAvviato { get; }
        string TipoCarburante { get; set; }
        int NumeroDiRuote { get; set; }
        void Avvia();
        void Spegni();

    }

    public class VeicoloAMotore : Veicolo, IVeicoloAMotore
    {
        private bool _motoreAvviato = false;
        public bool MotoreAvviato
        {
            get
            {
                return _motoreAvviato;
            }
            
        }

        public delegate void AccensioneDelegate();
        public event AccensioneDelegate Accensione;

        public delegate void SpegnimentoDelegate();
        public event SpegnimentoDelegate Spegnimento;

        public string TipoCarburante { get; set; }

        public virtual void Avvia()
        {
            if (_motoreAvviato == true) throw new Exception("Motore gia avviato");

            _motoreAvviato = true;
            if (Accensione != null) Accensione();
        }

        public virtual void Spegni()
        {
            if (_motoreAvviato == true)
            {
                _motoreAvviato = false;
                if (Spegnimento != null) Spegnimento();
            }
        }

    }
    public class VeicoloSenzaMotore : Veicolo
    {
        public bool HaIPedali { get; set; }
    }

    public class Automobile : VeicoloAMotore
    {
        private string _marca;
        private string _modello;

        public Automobile(string marca, string modello)
        {
            _marca = marca;
            _modello = modello;
        }

        public void ApriLePorte()
        {
            if (MotoreAvviato == true) throw new Exception("Impossibile aprire le porte a motore avviato!");
        }
        public void ChiudiLePorte()
        {
        }

        // OVER LOAD
        public void CambiaStazioneRadio() { }

        public void CambiaStazioneRadio(string frequenza) { }

        // OVER RIDE
        public override void Avvia()
        {
            base.Avvia(); // logica classe base
            ChiudiLePorte();
        }

        public override void Spegni()
        {
            base.Spegni(); // logica classe base
           ApriLePorte();
        }


    }
}
