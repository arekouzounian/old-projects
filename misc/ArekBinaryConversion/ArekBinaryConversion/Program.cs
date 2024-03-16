using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArekBinaryConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a binary code to be converted.");
            string userInput = Console.ReadLine();
            double number = 0;
            for (int i = 0, j = userInput.Length-1; i < userInput.Length; i++, j--)
            {
                
                if(userInput[i] == '1')
                {
                    number += Math.Pow(2, j);
                }
            }
            Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
