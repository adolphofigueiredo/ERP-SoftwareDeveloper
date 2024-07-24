using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
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
            string value01 = Console.ReadLine();                        //Leitura da resposta e armazenamento na variavel.
            Console.WriteLine("Nice to meet you " + value01 + ".");
            Console.ReadLine();                                         //Foi adicionado para o console nao fechar.
                                                                        //Se nao for adicionado o console fecha sem ter tempo de ler.
            Console.WriteLine("Enter the first number:");
            int value02 = int.Parse(Console.ReadLine());                //Fazer o input de um numero.

            Console.WriteLine("Enter the second number:");
            int value03 = int.Parse(Console.ReadLine());                //Fazer o input do segunmdo numero.

            int value04 = value02 + value03;                            //Criacao da variavel para fazer a soma.

            Console.WriteLine("The sum of the numbers " + value02 + " and " + value03 + " is " + value04 + ".");

            Console.ReadLine();                                         //Foi adicionado para o console nao fechar.
        }
    }
}
