using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArekRandomStringChooser
{
    class Program
    {
        static void Main(string[] args)
        {
            //have the user type in some words
            //ask them how many words they want first
            //store all their words into an array
            //show them the words one by one, w/o showing them one that they have seen before
            //you have to check whether or not you have displayed the word before
            Random gen = new Random();
            Console.WriteLine("How many words would you like to enter?");
            int numberOfWords = int.Parse(Console.ReadLine());
            string[] strArray = new string[numberOfWords];
            for (int i = 0; i < numberOfWords; i++)
            {
                Console.WriteLine("Please enter a word: ");
                strArray[i] = Console.ReadLine();
            }
            string[] alreadyUsed = new string[strArray.Length];
            for (int i = 0; i < strArray.Length; i++)
            {
                //alreadyUsed[i] = strArray[gen.Next(0, strArray.Length)];
                //Console.WriteLine(alreadyUsed[i]);
                int random = gen.Next(0, strArray.Length);
                
                if (alreadyUsed.Contains(strArray[random]))
                {
                    i--;
                }
                else
                {
                    alreadyUsed[i] = strArray[random];
                    Console.WriteLine(strArray[random]);
                }
            }
            Console.ReadKey();
        }
    }
}
