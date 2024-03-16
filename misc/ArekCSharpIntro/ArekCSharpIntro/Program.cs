using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArekCSharpIntro
{
    class Program
    {
        // Read 3 numbers
        // Add the 2nd number to the first number, then subtract the 3rd number from
        // that result, and print the final number
        static void Main(string[] args)
        {
            // if user tries to divide by zero, then print an error

            bool showResult = true; 

            Console.WriteLine("Please enter a number: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter an operation (add, subtract, etc.):");
            string userOperation = Console.ReadLine();

            float result = 0;



            if ("add" == userOperation)
            {
                result = num1 + num2;
            }
            else if ("subtract" == userOperation)
            {
                result = num1 - num2;
            }
            else if ("divide" == userOperation)
            {
                
                if ((num1 == 0) || (num2 == 0))
                {
                    Console.WriteLine("You can't divide by zero!");
                    showResult = false;

                }
                else {
                    result = num1 / num2;
                }
                
            }
            else if ("multiply" == userOperation)
            {
                result = num1 * num2;
            }
            if (showResult)
            {
                Console.WriteLine(result);
            }
            
            

            /*
            int mynumber = int.Parse(Console.ReadLine());
            Console.WriteLine(mynumber );
            */

            /*
            string numS = Console.ReadLine();
            int num = int.Parse(numS);
            */
            /*
            Console.WriteLine("Please enter a verb: \n");
            string userVerb = Console.ReadLine();
            Console.WriteLine("Please enter an adjective: \n");
            string userAdj = Console.ReadLine();
            Console.WriteLine("Please enter a noun: \n");
            string userNoun = Console.ReadLine();
            Console.WriteLine("Your Sentence is: " + userNoun + " is " + userVerb + " at " + userAdj);

            Console.WriteLine($"Your Sentence is: {userNoun} is {userVerb} at {userAdj}");

            */


            /* Console.WriteLine("Hello from C#");
            string mystring = "My first string ";
            string mysecondstring = "the first part " + mystring + "My second string ";
            Console.WriteLine(mysecondstring);
            string myConsoleString = Console.ReadLine();
            Console.WriteLine(myConsoleString); */

            //These are what stop my console from exiting.
            //Use either one of these
            //Console.ReadLine();
            Console.ReadKey();
        }
    }
}
