using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_CA
{
    /*internal class Program
    {        
        static int RichiediValoreNumerico(string messaggio)
        {
            int iAddendo1 = 0;
            string addendo1 = "";
            bool isInt = false;
            do
            {
                Console.WriteLine(messaggio);
                addendo1 = Console.ReadLine();
                isInt = int.TryParse(addendo1, out iAddendo1);
                if (!isInt) Console.WriteLine("Input non corretto!");
            }
            while (!isInt);

            return iAddendo1;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("---- sommiamo 2 numeri ----");

            int iAddendo1 = RichiediValoreNumerico("Inserisci il primo addendo:");
            int iAddendo2 = RichiediValoreNumerico("Inserisci il secondo addendo:");

            int risultato = iAddendo1 + iAddendo2;

            Console.WriteLine("il risultato è:" + risultato);

            if (risultato % 2 == 0)
            {
                Console.WriteLine("il risultato è: PARI");
            }
            else
            {
                Console.WriteLine("il risultato è: DISPARI");
            }

            // altro modo:
            Console.WriteLine("il risultato è:" + (risultato % 2 == 0 ? "PARI" : "DISPARI"));

            Console.ReadLine();


        }
    }*/
}
