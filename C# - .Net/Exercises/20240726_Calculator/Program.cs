using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _20240726_Calculator
{
    internal class Program
    {
        static int RichiediValoreNumerico(string messaggio)
        {
            int ivalue02 = 0;
            string value02 = "";
            bool isInt = false;
            do
            {                                                                                   //Ciclo criado para verificar se o usuario
                                                                                                //digita algo que nao seja um numero.
                Console.WriteLine(messaggio);
                value02 = Console.ReadLine();                                                   //Fazer o input de um numero.
                isInt = int.TryParse(value02, out ivalue02);
                if (!isInt) Console.WriteLine("\r\nIt is not a number");                        //O ponto de exclamaÇao significa not.
            }
            while (!isInt);
            return ivalue02;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\r\n          CALCULATOR\r\n");                                          //Comando usado para escrever alguma coisa na tela.

            int value02 = RichiediValoreNumerico("\r\nEnter the first number:");

            int value03 = RichiediValoreNumerico("\r\nEnter the second number:");
            
            Console.WriteLine("\r\nSelect operator: ");
            string operation = Console.ReadLine();

            int value04 = 0;

            switch (operation)
            {
                case "+":
                    value04 = value02 + value03;
                    break;

                case "-":
                    value04 = value02 - value03;
                    break;

                case "/":
                    value04 = value02 / value03;
                    break;

                case "*":
                    value04 = value02 * value03;
                    break;

                default:
                    Console.WriteLine("\r\nErrore");
                    break;
            }

            Console.WriteLine("\r\nThe result is " + value04 + ".");

            Console.ReadLine();                                         //Foi adicionado para o console nao fechar.
        }
    }
}



// fazer uma calculadora que faca varias operacoes
// usar a multiplicacao fazendo varias somas 
// fazer a divisao usando a subtracao
