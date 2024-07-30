using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcolatrice_CA
{
    internal class Program
    {
        static string RichiediOperazione()
        {
            string operazione = "";
            bool operazioneAbilitata = false;
            do
            {
                Console.WriteLine("Inserisci l'operazione che vuoi effettuare:[+,-,*,/]");
                operazione = Console.ReadLine();
                List<string> operazioniDisponibili = new List<string>(){
                    "+","-","*","/"
                };
                operazioneAbilitata = operazioniDisponibili.Contains(operazione);
                if (!operazioneAbilitata) Console.WriteLine("operazione non disponibile!");
            }
            while (!operazioneAbilitata);
            return operazione;
        }

        static int RichiediValoreNumerico(string messaggio)
        {
            int iNumero = 0;
            string sNumero = "";
            bool eUnNumeroIntero = false;
            do
            {
                Console.WriteLine(messaggio);
                sNumero = Console.ReadLine();
                eUnNumeroIntero = int.TryParse(sNumero, out iNumero);
                if (!eUnNumeroIntero) Console.WriteLine("Input non corretto!");
            }
            while (!eUnNumeroIntero);
            return iNumero;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("CALCOLATRICE:");
            string operazione = RichiediOperazione();
            int n1 = RichiediValoreNumerico("Inserisci il primo numero");
            int n2 = RichiediValoreNumerico("Inserisci il secondo numero");
            int r = 0;
            switch (operazione)
            {
                case "+": r = n1 + n2; break;
                case "-": r = n1 - n2; break;
                case "*": r = n1 * n2; break;
                case "/": r = n1 / n2; break;
            }

            Console.WriteLine("risultato: " + r + " - è un numero " + (r % 2 == 0 ? "PARI" : "DISPARI"));
            Console.ReadLine();

        }
    }
}
