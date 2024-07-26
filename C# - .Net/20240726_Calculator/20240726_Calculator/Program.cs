using System;
using System.Collections.Generic;
using System.Linq;
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
                if (!isInt) Console.WriteLine("It is not a number");                            //O ponto de exclamaÇao significa not.
            }
            while (!isInt);
            return ivalue02;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello!!!");                                                      //Comando usado para escrever alguma coisa na tela.

            int value02 = RichiediValoreNumerico("Enter the first number:");


            int value03 = RichiediValoreNumerico("Enter the second number:");

            
            Console.WriteLine("Select operator: ");
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
                    Console.WriteLine("Errore");
                    break;
            }

            Console.WriteLine("The result is " + value04 + ".");

            Console.ReadLine();                                         //Foi adicionado para o console nao fechar.
        }
    }
}