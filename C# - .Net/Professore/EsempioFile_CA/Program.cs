using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsempioFile_CA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ESEMPIO FILE");
            string filePathName = "./prova.txt";

            if (!File.Exists(filePathName))
                Console.WriteLine($"il file:'{filePathName}' non esiste!");

            Scrivi(filePathName,
                $"ciao mondo {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}",
                true);
            var contenuto = Leggi(filePathName);

            Console.WriteLine($"Il contenuto del file:");
            Console.WriteLine($"{contenuto}");
            Console.WriteLine($"::FINE CONTENUTO");

            Console.ReadLine();



        }

        public static void Scrivi(string filepath, string contenuto, bool append = false)
        {
            using (var sw = new StreamWriter(filepath, append))
            {
                sw.WriteLine(contenuto);
                sw.Close();
            }
        }
        public static string Leggi(string filepath)
        {
            string c = string.Empty;
            using (var sr = new StreamReader(filepath))
            {
                c = sr.ReadToEnd();
                sr.Close();
            }

            return c;
        }
    }
}
