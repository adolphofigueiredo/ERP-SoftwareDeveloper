using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240724_Hello_World
{
    internal class Program
    {

        static int RichiediValoreNumerico(string messaggio)
        {
            int ivalue02 = 0;
            string value02 = "";
            bool isInt = false;
            do
            {                                                               //Ciclo criado para verificar se o usuario
                                                                            //digita algo que nao seja um numero.
                Console.WriteLine(messaggio);
                value02 = Console.ReadLine();                               //Fazer o input de um numero.
                isInt = int.TryParse(value02, out ivalue02);
                if (!isInt) Console.WriteLine("It is not a number");        //O ponto de exclamaÇao significa not.
            }
            while (!isInt);
            return ivalue02;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!!");                           //Comando usado para escrever alguma coisa na tela.







            Console.WriteLine("What's your name?");
            string value01 = Console.ReadLine();                           //Leitura da resposta e armazenamento na variavel.







            Console.WriteLine("Nice to meet you " + value01 + ".");
            Console.ReadLine();                                            //Foi adicionado para o console nao fechar.



            int value02 = RichiediValoreNumerico("Enter the first number:");

            int value03 = RichiediValoreNumerico("Enter the second number:");


            //            int ivalue02 = 0;
            //            string value02 = "";
            //            bool isInt = false;
            //            do
            //            {                                                               //Ciclo criado para verificar se o usuario
            //digita algo que nao seja um numero.
            //            Console.WriteLine("Enter the first number:");
            //            value02 = Console.ReadLine();                                   //Fazer o input de um numero.
            //            isInt = int.TryParse(value02, out ivalue02);
            //            if (!isInt) Console.WriteLine("It is not a number");        //O ponto de exclamaÇao significa not.
            //            }
            //            while (!isInt);






            //  int ivalue03 = 0;
            // string value03 = "";
            // isInt = false;                                                  //Nao declarei como boleano pois ja fiz isso antes
            //agora apenas so coloquei o valor de falso
            //novamente para poder entrar no ciclo.
            // do
            // {                                                               //Ciclo criado para verificar se o usuario
            //digita algo que nao seja um numero.
            // Console.WriteLine("Enter the second number:");
            // value03 = Console.ReadLine();                               //Fazer o input de um numero.
            // isInt = int.TryParse(value03, out ivalue03);
            // if (!isInt) Console.WriteLine("It is not a number");        //O ponto de exclamaÇao significa not.
            // }
            //while (!isInt);






            // int value04 = int.Parse(value02) + int.Parse(value03);         //Criacao da variavel para fazer a soma.

            int value04 = value02 + value03;         //Criacao da variavel para fazer a soma.




            Console.WriteLine(value01 + ", the sum of the numbers " + value02 + " and " + value03 + " is " + value04 + ".");






            if (value04 % 2 == 0)                                          //Condicao criada para saber se o resultado da soma e impar ou par.
            {
                Console.WriteLine("The sum is even.");
            }
            else
            {
                Console.WriteLine("The sum is odd");
            }

            //Feito de um outro jeito

            Console.WriteLine("The sum is " + (value04 % 2 == 0 ? "even." : "odd."));    //Uma condicao muito mais compacta.

            Console.ReadLine();                                         //Foi adicionado para o console nao fechar.
        }
    }
}
