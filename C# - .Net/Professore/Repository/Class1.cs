using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsempioClassiNetStd;

namespace Repository
{
    public class RepositoryProdotti
    {
        private readonly string _pathfile;

        public RepositoryProdotti(string pathfile)
        {
            _pathfile=pathfile;
        }

        public void Inserisci(string pathfile, Prodotto p) {
            throw new NotImplementedException();
            
        }
        public void Modifica(string pathfile, Prodotto pDaModificare, Prodotto nuovoValore) { 
            throw new NotImplementedException();
        }
        public void Cancella(string pathfile,Prodotto pDaCancellare) {
            throw new NotImplementedException();
        }
        public ICollection<Prodotto> LeggiTutto(string pathfile) { 
            throw new NotImplementedException();
        }

    }
}
