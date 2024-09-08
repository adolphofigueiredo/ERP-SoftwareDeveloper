using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsempioClassiNetStd;

namespace EsempioClassiCA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prezzo p = new Prezzo();
            p.SetValore(-10);

            Console.WriteLine(p.GetValore());

            if (p.GetValore() < 0)
            {
                Console.WriteLine("é uno sconto");
            }
            else
            {
                Console.WriteLine("é uno prezzo");
            }

            if (p.GetESconto())
            {
                Console.WriteLine("é uno sconto");
            }
            else
            {
                Console.WriteLine("é uno prezzo");
            }

            Console.ReadLine();

        }
    }
}
