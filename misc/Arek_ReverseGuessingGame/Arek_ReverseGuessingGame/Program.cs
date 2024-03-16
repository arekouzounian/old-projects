using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arek_ReverseGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //you think of a number 1-100
            //computer picks a random number 1-100
            //computer tells you the number
            //user types in 1 for too high, 2 for too low, 3 for correct
            //if user puts in 1, computer changes high var, and vice versa
            //ask if user would like to play again
            Console.WriteLine("Think of a number!");
            int low = 1;
            int high = 101;
            Random random = new Random();
            int userInput = 0;
            // make the first guess random
            // every guess after that should use binary search
            // move the line with 'int computer...' outside of the loop
            int computer = random.Next(low, high);
            while (userInput != 3)
            {
                if (userInput != 0)
                {
                    computer = (low + high) / 2;
                }
                // calculate average
                Console.WriteLine("The Computer Generated Number is: " + computer);
                Console.WriteLine("Enter '1' if this number is too high, '2' if this number is too low, and '3' if this number is the number you thought of.");
                userInput = int.Parse(Console.ReadLine());

                if (userInput == 1)
                {
                    //computer = (low + high) / 2;
                    high = computer;
                }
                else if (userInput == 2)
                {
                    low = computer;
                }
                else if (userInput == 3)
                {
                    Console.WriteLine("Nice Job! Would you like to play again?");
                    Console.WriteLine("If you would like to play again, type 'yes.' If not, type 'no.' ");
                    string yesOrNo = "yes";
                    yesOrNo = Console.ReadLine();
                    if (yesOrNo == "yes")
                    {
                        userInput = 0;
                    }
                    else if (yesOrNo == "no")
                    {
                        userInput = 3;
                    } else
                    {
                        userInput = 3;
                    }

                }


            }

            Console.ReadKey();
        }
    }
}
