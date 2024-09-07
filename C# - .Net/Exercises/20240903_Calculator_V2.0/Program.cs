using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240903_Calculator_V2._0
{
    internal class Program
    {
        static string RequestOperation()
        {
            string Operation = "";
            bool OperationEnabled = false;
            do
            {
                Console.WriteLine("\r\nEnter the operation you want to perform [+,-,*,/]:");
                Operation = Console.ReadLine();                                              //É importante lembrar que apesar de Operation
                                                                                             //ser usado na função e mais abaixo na função
                                                                                             //Main, são variáveis diferente com o mesmo
                                                                                             //nome, já que a variável operations dentro da
                                                                                             //função não sai de lá.
                List<string> AvailableOperations = new List<string>(){
                    "+","-","*","/"
                };
                OperationEnabled = AvailableOperations.Contains(Operation);
                if (!OperationEnabled)
                    Console.WriteLine("\r\n------------------------------------------------------------" + 
                                      "\r\n              ERROR! - Operation not available!" +
                                      "\r\n------------------------------------------------------------");
            }
            while (!OperationEnabled);
            return Operation;
        }

        static int RequestNumber(string Message)
        {
            int iNumber = 0;
            string NoNumber = "";
            bool IsIntegerNumber = false;
            do
            {
                Console.WriteLine(Message);
                NoNumber = Console.ReadLine();
                IsIntegerNumber = int.TryParse(NoNumber, out iNumber);
                if (!IsIntegerNumber)
                    Console.WriteLine("\r\n------------------------------------------------------------" + 
                                      "\r\n                  ERROR! - Incorrect input!" + 
                                      "\r\n------------------------------------------------------------");
            }
            while (!IsIntegerNumber);
            return iNumber;
        }
        
        static int RequestMultiplication(int Number01, int Number02)
        {
            int Result = 0;
            int i = 0;
            for (i = 0; i < Number01; i++)
            {
                Result += Number02;
            }
            return Result;
        }

        static (int Result , int Remainder) RequestDivision(int Number01, int Number02)
        {
            int Result = 0;
            int Remainder = Number01;
            do
            {
                Remainder = Remainder - Number02;
                Result += 1;
            }
            while (Remainder >= Number02);
            return (Result, Remainder);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("                         CALCULATOR                         ");
            Console.WriteLine("------------------------------------------------------------");
            string Operation = RequestOperation();                                              //É importante lembrar que apesar de Operation
                                                                                                //ser usado na função e aqui são variáveis
                                                                                                //diferente com o mesmo nome, já que a variável
                                                                                                //operations dentro da função não sai de lá.
            int Number01 = RequestNumber("\r\nEnter the first number:");
            int Number02 = RequestNumber("\r\nEnter the second number:");
            int Result = 0;
            int Remainder = 0;

            switch (Operation)
            { 
                case "+":
                    Result = Number01 + Number02;
                    break;
                case "-":
                    Result = Number01 - Number02;
                    break;
                case "*":
                    Result = RequestMultiplication(Number01, Number02);
                    break;
                case "/":
                    if (Number02 != 0)
                    {
                        (Result, Remainder) = RequestDivision(Number01, Number02);
                    }
                    else
                    {
                        Console.WriteLine("\r\n------------------------------------------------------------");
                        Console.WriteLine("                   Impossible - Division by zero!                   ");
                    }
                    break;
            }
            if (Number02 == 0 && Operation == "/") 
            {
                Console.WriteLine("------------------------------------------------------------");
            }
            else{ 
                Console.WriteLine("\r\n------------------------------------------------------------");
                Console.WriteLine(" Result: " + Result + " - It's a " + (Result % 2 == 0 ? "even" : "odd") + " number.");

                if (Operation == "/")
                {
                    Console.WriteLine(" Remainder: " + Remainder);
                }
                Console.WriteLine("------------------------------------------------------------");
            }
            Console.ReadLine();
        }
    }
}
