using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS_Esempi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!!");                        //Comando usado para escrever alguma coisa na tela.
            Console.WriteLine("What's your name?");
            string valore01 = Console.ReadLine();                       //Leitura da resposta e armazenamento na variavel.
            Console.WriteLine("Nice to meet you " + valore01 + ".");
            Console.ReadLine();                                         //Foi adicionado para o console nao fechar.
                                                                        //Se nao for adicionado o console fecha sem ter tempo de ler.

                                                                        //Fazer o input de dois numero e imprimir a soma.
        }
    }
}
