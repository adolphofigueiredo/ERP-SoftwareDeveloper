using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using EsempioClassiCA.LogApplicativo;
using EsempioClassiNetStd;

namespace EsempioClassiCA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automobile panda = new Automobile("FIAT", "PANDA HYBRID");
            panda.NumeroDiRuote = 4;
            try
            {
                panda.Avvia();
                panda.Avvia();
            }
            catch (Exception e)
            {
                //e.Message  // 'Motore gia avviato' 
                throw;
            }


            /*using (Logger logger = new Logger("./miolog.txt"))
            {




                logger.WriteLog("messaggio di log");
                Console.ReadLine();
            }*/

            Console.ReadLine();
        }


    }
}
