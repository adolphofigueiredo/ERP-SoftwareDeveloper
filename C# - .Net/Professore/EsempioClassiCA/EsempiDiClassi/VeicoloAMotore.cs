using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsempioClassiCA.EsempiDiClassi
{
    // dichiarazione dell'oggetto VeicoloAMotore che deriva dall'oggetto
    // veicolo ereditandone tutte le proprietà, metodi ed eventi
    public class VeicoloAMotore : Veicolo
    {
        // variabile di classe (interno allo stato dell'oggetto)
        private bool _motoreEAcceso = false;

        // delegato puntatore a funzione definisce come deve essere
        // la firma della funzione che dovrà essere invocata 
        public delegate void AccesioneDelegate(DateTime dataOraAccensione);

        // evento che viene invocato dall'oggetto VeicoloAMotore se definito
        // l'invocazione eseguirà una funziona con firma conforme al delegato. 
        public event AccesioneDelegate Accesione;
        
        // proprieta in sola lettura 
        public int CilindrataCC { get; }
        
        // costruttore dell'oggetto che richiama il costruttore dell'oggetto padre
        public VeicoloAMotore(int numeroDiRuote, int cilindrataCC) : base(numeroDiRuote)
        {
            this.CilindrataCC = cilindrataCC;
        }

        // metodo pubblico che modifica
        // lo stato dell'oggetto ed emette un evento 
        public void AccendiIlMotore()
        {
            if (_motoreEAcceso) throw new Exception("Il motore è gia acceso");

            // modifico lo stato interno (le proprieta pubbliche o private) dell'oggetto
            _motoreEAcceso = true;

            // se all'evento è assegnato una funziona
            // allora emetto l'evento (invoco la funzione)
            if (Accesione != null) Accesione(DateTime.Now);
        }
    }
}
