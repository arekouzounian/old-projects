using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArekSwapping
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user how many numbers they would like to enter
            //then store this many numbers into a list
            //once youve stored this many numbers, then show the user the numbers all in 1 line
            //EX: 1 2 3 4
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            bool wantsToRestart = false;
            while (wantsToRestart == false)
            {
                List<int> intList = new List<int>();
                Console.WriteLine("Please enter the number for how many numbers you would like to enter.");
                int UserNums = int.Parse(Console.ReadLine());
                for (int i = 0; i < UserNums; i++)
                {
                    Console.WriteLine("Please enter a number");
                    int userInput = int.Parse(Console.ReadLine());
                    intList.Add(userInput);
                }
                for (int i = 0; i < UserNums; i++)
                {
                    Console.Write(intList[i] + " ");
                }
                //after you show the user the numbers, ask them what they would like to do
                //either:
                //1) swap 2 numbers in the sequence (ask them which two numbers to swap and then swap those two)
                //2) reverse the sequence (if 12345, 54321)
                //3) scramble the sequence (change around all the places of the numbers)
                //4) randomize the sequence (make all the numbers random)
                //5) exit
                bool isDone = false;
                while (isDone == false)
                {
                    Console.WriteLine("What would you like to do? \n1) Swap 2 numbers in the sequence \n2) Reverse the sequence \n3) Scramble the sequence \n4) Randomize the sequence \n5) Exit");
                    int userChoice = int.Parse(Console.ReadLine());
                    if (userChoice == 1)
                    {
                        Console.WriteLine("Which two numbers would you like to swap?");
                        int userInput1 = int.Parse(Console.ReadLine());
                        int userInput2 = int.Parse(Console.ReadLine());
                        int tempSwap = 0;
                        tempSwap = intList[userInput1 - 1];
                        intList[userInput1 - 1] = intList[userInput2 - 1];
                        intList[userInput2 - 1] = tempSwap;
                        for (int i = 0; i < UserNums; i++)
                        {
                            Console.Write(intList[i] + " ");
                        }

                    }
                    else if (userChoice == 2)
                    {
                        //swap 1 and 5, move inward, etc
                        int tempSwap = 0;
                        int index1 = 0;
                        int index2 = intList.Count - 1;
                        for (int i = 0; i < intList.Count / 2; i++)
                        {
                            tempSwap = intList[index1];
                            intList[index1] = intList[index2];
                            intList[index2] = tempSwap;
                            index1++;
                            index2--;
                        }
                        for (int i = 0; i < intList.Count; i++)
                        {
                            Console.Write(intList[i] + " ");
                        }
                    }
                    else if (userChoice == 3)
                    {
                        int tempSwap = 0;
                        int index1 = 0;
                        int index2 = 0;
                        Random gen = new Random();
                        int randomIndex = gen.Next(0, intList.Count);
                        for (int i = 0; i < randomIndex; i++)
                        {
                            index1 = gen.Next(0, intList.Count);
                            index2 = gen.Next(0, intList.Count);
                            tempSwap = intList[index1];
                            intList[index1] = intList[index2];
                            intList[index2] = tempSwap;
                        }
                        for (int i = 0; i < intList.Count; i++)
                        {
                            Console.Write(intList[i] + " ");
                        }
                    }
                    else if (userChoice == 4)
                    {
                        Random gen = new Random();
                        for (int i = 0; i < UserNums; i++)
                        {
                            intList[i] = gen.Next(0, 100);
                        }
                        for (int i = 0; i < UserNums; i++)
                        {
                            Console.Write(intList[i] + " ");
                        }
                    }
                    else if (userChoice == 5)
                    {
                        Console.WriteLine("Are you sure you would like to (L)eave? Or would you rather (E)nter a new sequence of numbers?");
                        string userInput = Console.ReadLine();
                        if (userInput == "L")
                        {
                            Console.WriteLine("Press any key to exit...");
                            isDone = true;
                            wantsToRestart = true;
                        }
                        else if (userInput == "E")
                        {
                            wantsToRestart = false;
                            isDone = true;
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
