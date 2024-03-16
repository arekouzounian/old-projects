using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArekNumberStats
{
    class Program
    {
        static void Main(string[] args)
        {
            //first store 5 random numbers into an array
            //then print them out for the user
            //after you show the numbers to the user, find which is the highest and lowest number in the array, and show then to the user
            Random gen = new Random();
            int[] randomNumArray = new int[5];
            for (int i = 0; i < 5; i++)
            {
                randomNumArray[i] = gen.Next(0,100);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(randomNumArray[i]);
            }
            int biggestNum = randomNumArray[0];
            int smallNum = randomNumArray[0];
            int avg = 0;
            for (int i = 0; i < 5; i++)
            {
                
                
                if (randomNumArray[i] > biggestNum)
                {
                    biggestNum = randomNumArray[i];
                }
                
                
                if (randomNumArray[i] < smallNum)
                {
                    smallNum = randomNumArray[i]; 
                }

                avg = avg + randomNumArray[i];
            }
            Console.WriteLine($"The biggest number is: {biggestNum} \nThe smallest number is: {smallNum} \nThe average of all the numbers is: {avg / 5}");
            Console.ReadKey();
        }
    }
}
