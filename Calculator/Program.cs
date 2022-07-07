using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            char type = ' ';
            double firstNumber = 0;
            double secondNumber = 0;
            double result = 0;

            Console.WriteLine("What type of calculation would you like to preform? (+,-,*, or /)");
            type = Console.ReadKey().KeyChar;
            do
            {
                if (type == '+')
                {
                    Console.WriteLine("Okay Your wanting to add please put the first number");
                    firstNumber = Console.Read();
                    Console.WriteLine("Okay now put in the second one");
                    secondNumber = Console.Read();
                    result = firstNumber + secondNumber;
                }
                else if (type == '-')
                {
                    Console.WriteLine("Okay Your wanting to subtract please put the first number");
                    firstNumber = Console.Read();
                    Console.WriteLine("Okay now put in the second one");
                    secondNumber = Console.Read();
                    result = firstNumber - secondNumber;
                }
                else if (type == '*')
                {
                    Console.WriteLine("Okay Your wanting to times please put the first number");
                    firstNumber = Console.Read();
                    Console.WriteLine("Okay now put in the second one");
                    secondNumber = Console.Read();
                    result = firstNumber * secondNumber;
                }
                else if (type == '/')
                {
                    Console.WriteLine("Okay Your wanting to divide please put the first number");
                    firstNumber = Console.Read();
                    Console.WriteLine("Okay now put in the second one");
                    secondNumber = Console.Read();
                    result = firstNumber / secondNumber;
                }
                else
                {
                    Console.WriteLine("Bruh Thats not one of the the things I can do...");
                }
            }
            while (true);
        }
    }
}