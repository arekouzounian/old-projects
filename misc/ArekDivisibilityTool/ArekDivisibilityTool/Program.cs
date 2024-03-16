using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArekDivisibilityTool
{
    class Program
    {
        static void Main(string[] args)
        {
            // the program takes in two user numbers and tells the user if num1 is divisible by num2 
            // EDIT: This program works, but has a major flaw; the program can only use ints, but not float values.
            Console.WriteLine("This tool will help you to see if something is divisible or not.");
            Console.WriteLine("Please Enter a number.");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Another Number that you would like to have the first number divided by.");
            int secondNum = int.Parse(Console.ReadLine());
            if ((firstNum % secondNum) == 0)
            {
                Console.WriteLine("Your first number divided by your second number has a remainder of 0, so it is divisble.");
            }
            else
            {
                Console.WriteLine($"Your first number divided by your second number has a remainder of {firstNum % secondNum}, so it is not divisible.");
            }
            Console.ReadKey();
        }
    } 
}
