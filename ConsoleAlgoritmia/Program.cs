using System;
using System.Linq;

namespace ConsoleAlgoritmia
{
    class Program
    {
        static void Main(string[] args)
        {
            printNumbers(130);
        }
        static void printNumbers(int num) 
        {
            if (num <= 1000) 
            {
                for (int i = 1; i <= num; i++)
                {
                    string numText = string.Empty;

                    numText = (i % 2 == 0) ? "Codility" : "";
                    numText = (i % 3 == 0) ? $"{numText}Test" : numText;
                    numText = (i % 5 == 0) ? $"{numText}Coders" : numText;

                    if (string.IsNullOrEmpty(numText))
                        Console.WriteLine(i);
                    else
                        Console.WriteLine(numText);
                }
            }
            else
                Console.WriteLine("The number entered is greater than a thousand");

            Console.ReadLine();
        }
    }
}
