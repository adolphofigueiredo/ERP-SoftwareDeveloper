using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EsempioClassiCA.PC.Computer;

namespace EsempioClassiCA
{

    public class Veicolo                                                //Criaçãde uma CLASSE
                                                                        //Se nao definir a visibilidade no inicio é assumido privado,
                                                                        //mas neste caso foi colocado como publico

    {
        public int NumeroDiRuote { get; set; }                          //Criação de uma PROPRIEDADE da classe, ou seja, as propriedades
                                                                        //são agrupadas dentro das classes que possuem propositos especificos.
                                                                        
                                                                        //Repare que esta classe possui um tipo, que neste caso é integer,
                                                                        //mas pode ser boleano, sttring e etc...
    }
                                                                        //É importante perceber que dentro das propriedades sao incluidas
                                                                        //as funcoes de acesso get e set, a get significa que ela pode
                                                                        //acessar os dados e set pode escrever os dados.

                                                                        //Repare que esta propriedade esta como PUBLIC. Isso pode ser
                                                                        //um grande problema de seguranca, pois qualquer um poderia
                                                                        //acessar esta informaçùoes e alterar sem utilisar os METODOS
                                                                        //adequados, criados e fornecidos dentro desta classe.

    public interface IVeicoloAMotore                                    //Criaçãde uma CLASSE
    {
        bool MotoreAvviato { get; }                                     //Criação de uma PROPRIEDADE da classe, ou seja, as propriedades
                                                                        //são agrupadas dentro das classes que possuem propositos especificos.
        string TipoCarburante { get; set; }                     
                                                                        //Repare que esta classe possui um tipo, que neste caso é integer,
        int NumeroDiRuote { get; set; }                                 //mas pode ser boleano, sttring e etc...

                                                                        //É importante perceber que dentro das propriedades sao incluidas
                                                                        //as funcoes de acesso get e set, a get significa que ela pode
                                                                        //acessar os dados e set pode escrever os dados.

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

        public void ApriLePorte()                                       //Criacao de um METODO, ou seja, açoes e comportamentos
                                                                        //realizados por esta classe.

                                                                        //E importante lembrar que o void quer dizer vazio, ou seja,
                                                                        //significa que as funções não retornam qualquer valor. A
                                                                        //funçao void nos permite fazer funções que não retornam nada
                                                                        //e funções que não têm parâmetros.
        {
            if (MotoreAvviato == true) throw new Exception("Impossibile aprire le porte a motore avviato!");
        }
        public void ChiudiLePorte()                                     //Criacao de um METODO, ou seja, açoes e comportamentos
                                                                        //realizados por esta classe.

                                                                        //E importante lembrar que o void quer dizer vazio, ou seja,
                                                                        //significa que as funções não retornam qualquer valor. A
                                                                        //funçao void nos permite fazer funções que não retornam nada
                                                                        //e funções que não têm parâmetros.
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
