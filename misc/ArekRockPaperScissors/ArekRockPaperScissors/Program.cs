using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArekRockPaperScissors
{
    class Program
    {

        static string convertToRSC(int inputNumber)
        {
            string convertedNum = "Rock";
            if (inputNumber == 1)
            {
                convertedNum = "Rock";
            }
            else if (inputNumber == 2)
            {
                convertedNum = "Paper";
            }
            else if (inputNumber == 3)
            {
                convertedNum = "Scissors";
            }
            return convertedNum;
        }


        static void Main(string[] args)
        {
            //User inputs 1 , 2 or 3
            //1 is rock, 2 is paper, 3 is scissors
            //Computer generates num between 1, 2 or 3
            //Who wins
            //Ask if they would like to play again
            //A score for every time you tie, lose, and win
            //display computer num and a conversion
            //display usernum and a conversion
            Random rand = new Random();
            int tieScore = 0;
            int winScore = 0;
            int loseScore = 0;
            bool isDone = false;

            while (isDone == false)
            {
                int computerNum = rand.Next(1, 4);

                Console.WriteLine("Let's Play Rock, Paper, Scissors!\n");
                Console.WriteLine("Type '1' for Rock, '2' for Paper, and '3' for scissors.");
                int userNum = int.Parse(Console.ReadLine());
                string computerPrintNum = convertToRSC(computerNum);
                string userPrintNumber = convertToRSC(userNum);
                
                
                Console.WriteLine($"The Number you Entered is equivalent to {userPrintNumber}. \nThe number the computer Entered is equivalent to {computerPrintNum}");


                if (userNum == computerNum)
                {
                    Console.WriteLine("Draw! Try Again.");
                    tieScore++;
                }
                else if ((userNum == 1) && (computerNum == 2))
                {
                    Console.WriteLine("You Lose! Paper beats Rock.");
                    loseScore++;
                }
                else if ((userNum == 2) && (computerNum == 1))
                {
                    Console.WriteLine("You Win! Paper beats Rock.");
                    winScore++;
                }
                else if ((userNum == 1) && (computerNum == 3))
                {
                    Console.WriteLine("You Win! Rock beats scissors.");
                    winScore++;
                }
                else if ((userNum == 3) && (computerNum == 1))
                {
                    Console.WriteLine("You Lose! Rock beats scissors.");
                    loseScore++;
                }
                else if ((userNum == 2) && (computerNum == 3))
                {
                    Console.WriteLine("You Lose! Scissors beats Paper!");
                    loseScore++;
                }
                else if ((userNum == 3) && (computerNum == 2))
                {
                    Console.WriteLine("You Win! Scissors beats Paper!");
                    winScore++;
                }
                Console.WriteLine($"Wins: {winScore} \nLosses: {loseScore} \nTies: {tieScore} \n");
                Console.WriteLine("Would you like to play again? Type 'yes' if yes or 'no' if not. ");
                string yesOrNo = Console.ReadLine();                

                if (yesOrNo != "yes")
                {
                    isDone = true;
                }
            }
           
        }
    }
}
