using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArekFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //print 1-100

            //int number = 1;
            //while (number < 101)
            //{
            //    Console.WriteLine(number);
            //    number = number + 1;
                //number++;
            //}

            //create & set variable; check variable; increment variable
            //for (int i = 0; i < 101; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //write a for loop that counts down from 100 to zero
           /* for (int countDown = 100; countDown != 0; countDown = countDown - 1) 
            {
                Console.WriteLine(countDown);
;           } */
            //print 50 - 1, 5 times
            for (int numberOfTimes = 0; numberOfTimes != 5; numberOfTimes++)
            {
                for(int fifty = 50; fifty != 0; fifty = fifty - 1)
                {
                    Console.WriteLine(fifty);
                }
            }
           

            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
