using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240725_Hello_World_III
{
    internal class Hello_World_III                                          //E a abertura do programa, repare nos nomes daqui e do programa.
    {
        private static void Main()                                          //E o primeiro metodo utilizado na hora da compilacao
        {
            Console.WriteLine("Digite o seu nome: ");                       //A diferenòa entre o comando WriteLine e so o Write e que no
                                                                            //WriteLine ele termina e pula a linha, mas no Write ele continua
                                                                            //na mesma linha. A Mesma coisa acontece no ReadLine e Read.
            string name = Console.ReadLine();
            Console.WriteLine($"Oi {name}!");
            Console.Write("Digite o ano do seu nascimento: ");
            int year = int.Parse(Console.ReadLine());                       //Este comando parse converte string em int, mas so se o usuario
                                                                            //inserir o valor correto.
            int age = 2024 - year;
            Console.WriteLine($"Voce tem {age} anos.");

            if (age >= 18)                                                  //Se eu quisesse usar o and na condiòùao do if deveria usar "&&",
                                                                            //mas se quisesse usar o ou na condiòùao deveria usar "||".
            {
                Console.WriteLine("Voce e maior de idade!!");           
            }

            else
            {
                Console.WriteLine("Voce e menor de idade!!");
            }

            Console.WriteLine("------------------------------");

           string[] names = { name, "Adolpho", "Leila" };                   //Estou inicializando uma array e usei uma variavel no primeiro registro

            Console.Write(names[0] + " ");                                  //Comecei a imprimir a array, poderia usar um ciclo mas ainda nao vou fazer isso
            Console.Write(names[1] + " - ");
            Console.WriteLine(names[2]);

            Console.WriteLine("------------------------------");

            for (int i = 0; i < names.Length; i++)                          //A propriedade conta o numero de elementos da array e assim o codigo fica mais flexivel
            {
                Console.Write(names[i] + " | ");                            //Agora sim fazendo a mesma coisa usando um ciclo.
            }
            Console.WriteLine("");
            Console.WriteLine("------------------------------");

            Console.ReadLine();
        }
    }
}
