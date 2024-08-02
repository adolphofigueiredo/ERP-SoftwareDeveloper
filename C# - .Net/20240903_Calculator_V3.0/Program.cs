using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240903_Calculator_V3._0
{
    internal class Program
    {
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
                {
                    Console.WriteLine("\r\n------------------------------------------------------------------------");
                    Console.WriteLine("                        ERROR! - Incorrect input!                       ");
                    Console.WriteLine("------------------------------------------------------------------------");
                }
            }
            while (!IsIntegerNumber);
            return iNumber;
        }

        static string RequestOperation(string Message)
        {
            string Operation = "";
            bool OperationEnabled = false;
            do
            {
                Console.WriteLine(Message);
                Operation = Console.ReadLine();

                List<string> AvailableOperations = new List<string>(){
                    "+","-","*","/","="
                };
                OperationEnabled = AvailableOperations.Contains(Operation);
                if (!OperationEnabled) {
                    Console.WriteLine("\r\n------------------------------------------------------------------------");
                    Console.WriteLine("                    ERROR! - Operation not available!                   ");
                    Console.WriteLine("------------------------------------------------------------------------");
                }
            }
            while (!OperationEnabled);
            return Operation;
        }

        static int RequestCalculation(string Operation , int Number01, int Number02)
        {
            int Result = 0;

            switch (Operation)
            {
                case "+":
                    Result = Number01 + Number02;
                    break;
                case "-":
                    Result = Number01 - Number02;
                    break;
                case "*":
                        Result = Number01 * Number02;
                    break;
                case "/":
                    if (Number02 == 0)
                    {
                        Result = Number01;
                        Console.WriteLine("\r\n-----------------------------------------------------------------------------");
                        Console.WriteLine("                        Impossible - Division by zero!                     ");
                        Console.WriteLine("------------------------------------------------------------------------------");
                    }
                    else
                    {
                        Result = Number01 / Number02;
                    }
                    break;
            }
            return Result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("                                  CALCULATOR                                  ");
            Console.WriteLine("------------------------------------------------------------------------------");
            
            int Number01 = RequestNumber("\r\nEnter the first number:");

            string Operation = RequestOperation("\r\nEnter the operation you want to perform [+,-,*,/]:");

            int Number02 = RequestNumber("\r\nEnter the second number:");

            int Result = RequestCalculation(Operation, Number01, Number02);

            Console.WriteLine("\r\n------------------------------------------------------------------------------");
            Console.WriteLine(" Partial Result: " + Result);
            Console.WriteLine("------------------------------------------------------------------------------");

            do
            {
                Operation = RequestOperation("\r\nEnter the operation you want to perform [+,-,*,/] or press [=] to finalize:");
                if (Operation == "=") break;
                
                int Number03 = RequestNumber("\r\nEnter the next number:");

                Result = RequestCalculation(Operation, Result, Number03);

                Console.WriteLine("\r\n------------------------------------------------------------------------------");
                Console.WriteLine(" Partial Result: " + Result);
                Console.WriteLine("------------------------------------------------------------------------------");
            }
            while (Operation != "=");
            Console.WriteLine("\r\n------------------------------------------------------------------------------");
            Console.WriteLine(" Final Result: " + Result);
            if (Result % 3 == 0)
            {
                Console.WriteLine(" The result is a multiple of 3.");
            }
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.ReadLine() ;
        }
    }
}
