using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArekGuessingGame
{
    class Program
    {
        // Have the computer randomly generate a number
        // Ask the user for a number
        // Tell user if number is less then generated, greater then, or is the right number
        // Repeat until the right number is guessed
        static void Main(string[] args)
        {
            Random gen = new Random();
            int computerNum = gen.Next(0, 11);
            bool isFinished = false;

            while(isFinished == false)
            {
                Console.WriteLine("Please enter a number: ");
                int userNum = int.Parse(Console.ReadLine());
                if (userNum == computerNum)
                {
                    Console.WriteLine("You Guessed Correctly!");
                    isFinished = true;
                }
                else if (userNum < computerNum)
                {
                    Console.WriteLine("Your number is too small.");
                }
                else if (userNum > computerNum)
                {
                    Console.WriteLine("Your number is too big.");
                }

            }
            Console.ReadLine();
        }
    }
}
