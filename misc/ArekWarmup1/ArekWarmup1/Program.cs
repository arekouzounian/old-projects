using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArekWarmup1
{
    class Program
    {
        static void Main(string[] args)
        {
            //user types in a sentence, and then the program finds the largest word in that sentence
            Console.WriteLine("Please enter a sentence.");
            string userInput = Console.ReadLine();
            int sentenceLength = userInput.Length;
            int currentLongest = 0;
            int letterCount = 0;
            string longestWord = "";
            string currentWord = "";
            for (int i = 0; i < sentenceLength; i++)
            {
                if(userInput[i] == ' ')
                {

                     if (letterCount > currentLongest)
                     {
                        currentLongest = letterCount;
                        longestWord = currentWord; 
                     }
                    currentWord = "";
                    letterCount = 0;

                }
                else if (userInput[i] != ' ')
                {
                    letterCount++;
                    currentWord += userInput[i];
                }
                
               
            }
            Console.WriteLine(longestWord);
            Console.ReadKey();
        }
    }
}
