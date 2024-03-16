using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArekMasterMinds
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an array, fill it with random numbers
            //
            UniqueRandom gen = new UniqueRandom();

            int[] randomNumbers = new int[4];

            randomNumbers[0] = gen.Random(1, 9);
            randomNumbers[1] = gen.Random(1, 9);
            randomNumbers[2] = gen.Random(1, 9);
            randomNumbers[3] = gen.Random(1, 9);

            bool isDone = false;
            while (!isDone)
            {

                int[] userNum = new int[4];



                // Ask the user to enter 4 unique random numbers
                // Is A: The number in the right spot
                // B: The number exists, but in the wrong spot
                // C: The entered number doesnt exist in the generated array

                // 5489 // generated
                // 5492 // user entered

                // 5 Is in the correct spot
                // 4 is in the correct spot
                // 9 exists, but is in the wrong spot
                // 2 does not exist
                for (int i = 0; i < randomNumbers.Length; i++)
                {
                    Console.WriteLine("Please enter a number: ");
                    userNum[i] = int.Parse(Console.ReadLine());
                }
                int correctNums = 0;
                for (int j = 0; j < randomNumbers.Length; j++) //checks if the number is in the wrong place 
                {
                    bool didFind = false;
                    for (int i = 0; i < randomNumbers.Length; i++) //checks if the number exists
                    {
                        if (randomNumbers[i] == userNum[j])
                        {
                            if (i == j)
                            {
                                Console.WriteLine($"{userNum[j]} is in the correct spot.");
                                correctNums++;
                            }
                            else
                            {
                                Console.WriteLine($"{userNum[j]} exists, but is in the wrong spot.");
                            }
                            didFind = true;
                        }
                        // if item at i == item at j
                    }
                    // IF did not find, does not exist
                    if (!didFind)
                    {
                        Console.WriteLine($"{userNum[j]} does not exist.");
                    }
                }
                if(correctNums == 4)
                {
                    isDone = true; 
                }
            } //end of while loop
            Console.ReadKey();
        }
    }
}
