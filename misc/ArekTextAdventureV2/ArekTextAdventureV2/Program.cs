using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArekTextAdventureV2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isDone = false;
            while (isDone == false)
            {
                Console.WriteLine("Welcome to your adventure!");
                Console.WriteLine("You approach a dark alley.");
                Console.WriteLine("1) Back out of the alley \n2) Run blindly into the alley \n3) Cautiously approach the alley \n4) Stand still");
                int userInput = int.Parse(Console.ReadLine());
                if (userInput == 1)
                {
                    Console.WriteLine("You try to back out of the alley, but find that there is a brick wall behind you.");
                    Console.WriteLine("1) Try to climb up the wall \n2) Go into the alley.");
                    userInput = int.Parse(Console.ReadLine());
                    if (userInput == 1)
                    {
                        Console.WriteLine("You try to climb up the wall, but it is too slick and you fall back down. As you reluctantly walk down the alley, you find a hole.");
                        Console.WriteLine("1) Go into the hole \n2) Try to jump over the hole");
                        userInput = int.Parse(Console.ReadLine());
                        if (userInput == 1)
                        {
                            Console.WriteLine("You drop down into the hole and find you are in a room with a single chair in the middle.");
                            Console.WriteLine("1) Sit on the chair \n2) Climb back out of the hole");
                            userInput = int.Parse(Console.ReadLine());
                            if (userInput == 1)
                            {
                                Console.WriteLine("You sit on the chair and are instantly transported onto a deserted street. As you walk down the street, you find two houses; one on the Right, and one on the Left.");
                                Console.WriteLine("1) Go to the Right \n2) Go to the Left");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    Console.WriteLine("You go to the Right, and inside you find a table with a single mirror on it, facedown.");
                                    Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        Console.WriteLine("You pick up the mirror, and you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, but the brick wall has been removed. You can finally leave.");
                                        Console.WriteLine("Thanks for playing! \n1) Play again \n2) Exit");
                                        userInput = int.Parse(Console.ReadLine());
                                        if (userInput == 1)
                                        {
                                            isDone = false;
                                        }
                                        else if (userInput == 2)
                                        {
                                            Console.WriteLine("Press any key to exit...");
                                            break;
                                        }
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("You turn around to leave, but find that the door has disappeared, trapping you in the house. As you pick up the mirror, you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, with the brick wall now removed. You can finally leave.");
                                        Console.WriteLine("Thanks for playing! \n1) Play again \n2) Exit");
                                        userInput = int.Parse(Console.ReadLine());
                                        if (userInput == 1)
                                        {
                                            isDone = false;
                                        }
                                        else if (userInput == 2)
                                        {
                                            Console.WriteLine("Press any key to exit...");
                                            break;
                                        }
                                    }
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("You try the Left, but the door is locked. As you go to the Right, you find a table with a single mirror on it, facedown.");
                                    Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        Console.WriteLine("You pick up the mirror, and you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, but the brick wall has been removed. You can finally leave.");
                                        Console.WriteLine("Thanks for playing! \n1) Play again \n2)Exit");
                                        userInput = int.Parse(Console.ReadLine());
                                        if (userInput == 1)
                                        {
                                            isDone = false;
                                        }
                                        else if (userInput == 2)
                                        {
                                            Console.WriteLine("Press any key to exit...");
                                            break;
                                        }
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("You turn around to leave, but find that the door has disappeared, trapping you in the house. As you pick up the mirror, you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, with the brick wall now removed. You can finally leave.");
                                        Console.WriteLine("Thanks for playing! \n1) Play again \n2) Exit");
                                        userInput = int.Parse(Console.ReadLine());
                                        if (userInput == 1)
                                        {
                                            isDone = false;
                                        }
                                        else if (userInput == 2)
                                        {
                                            Console.WriteLine("Press any key to exit...");
                                            break;
                                        }
                                    }
                                }
                            }
                            else if (userInput == 2)
                            {
                                Console.WriteLine("You try to climb out of the hole, but you realize the hole has disappeared, leaving only the chair. As you reluctantly sit on the chair, you are instantly transported onto a deserted street. As you walk along the street, you notice two houses, one on the Right, and one on the Left.");
                                Console.WriteLine("1) Go to the Right \n2) Go to the Left");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    Console.WriteLine("You go to the Right, and inside you find a table with a single mirror on it, facedown.");
                                    Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        Console.WriteLine("You pick up the mirror, and you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, but the brick wall has been removed. You can finally leave.");
                                        Console.WriteLine("Thanks for playing! \n1) Play again \n2)Exit");
                                        userInput = int.Parse(Console.ReadLine());
                                        if (userInput == 1)
                                        {
                                            isDone = false;
                                        }
                                        else if (userInput == 2)
                                        {
                                            Console.WriteLine("Press any key to exit...");
                                            break;
                                        }
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("You turn around to leave, but find that the door has disappeared, trapping you in the house. As you pick up the mirror, you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, with the brick wall now removed. You can finally leave.");
                                        Console.WriteLine("Thanks for playing! \n1) Play again \n2) Exit");
                                        userInput = int.Parse(Console.ReadLine());
                                        if (userInput == 1)
                                        {
                                            isDone = false;
                                        }
                                        else if (userInput == 2)
                                        {
                                            Console.WriteLine("Press any key to exit...");
                                            break;
                                        }
                                    }
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("You try the Left, but the door is locked. As you go to the Right, you find a table with a single mirror on it, facedown.");
                                    Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        Console.WriteLine("You pick up the mirror, and you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, but the brick wall has been removed. You can finally leave.");
                                        Console.WriteLine("Thanks for playing! \n1) Play again \n2)Exit");
                                        userInput = int.Parse(Console.ReadLine());
                                        if (userInput == 1)
                                        {
                                            isDone = false;
                                        }
                                        else if (userInput == 2)
                                        {
                                            Console.WriteLine("Press any key to exit...");
                                            break;
                                        }
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("You turn around to leave, but find that the door has disappeared, trapping you in the house. As you pick up the mirror, you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, with the brick wall now removed. You can finally leave.");
                                        Console.WriteLine("Thanks for playing! \n1) Play again \n2) Exit");
                                        userInput = int.Parse(Console.ReadLine());
                                        if (userInput == 1)
                                        {
                                            isDone = false;
                                        }
                                        else if (userInput == 2)
                                        {
                                            Console.WriteLine("Press any key to exit...");
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        else if (userInput == 2)
                        {
                            Console.WriteLine("You try jumping over the hole, but find that it is a lot longer than you can see or jump over. As you fall down into the hole, you notice you are in a room with a single chair in the middle.");
                            Console.WriteLine("1) Sit in the chair \n2) Climb back out of the hole");
                            userInput = int.Parse(Console.ReadLine());
                            if (userInput == 1)
                            {
                                Console.WriteLine("You sit on the chair and are instantly transported onto a deserted street. As you walk down the street, you find two houses; one on the Right, and one on the Left.");
                                Console.WriteLine("1) Go to the Right \n2) Go to the Left");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    Console.WriteLine("You go to the Right, and inside you find a table with a single mirror on it, facedown.");
                                    Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        Console.WriteLine("You pick up the mirror, and you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, but the brick wall has been removed. You can finally leave.");
                                        Console.WriteLine("Thanks for playing! \n1) Play again \n2)Exit");
                                        userInput = int.Parse(Console.ReadLine());
                                        if (userInput == 1)
                                        {
                                            isDone = false;
                                        }
                                        else if (userInput == 2)
                                        {
                                            Console.WriteLine("Press any key to exit...");
                                            break;
                                        }
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("You turn around to leave, but find that the door has disappeared, trapping you in the house. As you pick up the mirror, you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, with the brick wall now removed. You can finally leave.");
                                        Console.WriteLine("Thanks for playing! \n1) Play again \n2) Exit");
                                        userInput = int.Parse(Console.ReadLine());
                                        if (userInput == 1)
                                        {
                                            isDone = false;
                                        }
                                        else if (userInput == 2)
                                        {
                                            Console.WriteLine("Press any key to exit...");
                                            break;
                                        }
                                    }
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("You try the Left, but the door is locked. As you go to the Right, you find a table with a single mirror on it, facedown.");
                                    Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        Console.WriteLine("You pick up the mirror, and you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, but the brick wall has been removed. You can finally leave.");
                                        Console.WriteLine("Thanks for playing! \n1) Play again \n2)Exit");
                                        userInput = int.Parse(Console.ReadLine());
                                        if (userInput == 1)
                                        {
                                            isDone = false;
                                        }
                                        else if (userInput == 2)
                                        {
                                            Console.WriteLine("Press any key to exit...");
                                            break;
                                        }
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("You turn around to leave, but find that the door has disappeared, trapping you in the house. As you pick up the mirror, you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, with the brick wall now removed. You can finally leave.");
                                        Console.WriteLine("Thanks for playing! \n1) Play again \n2) Exit");
                                        userInput = int.Parse(Console.ReadLine());
                                        if (userInput == 1)
                                        {
                                            isDone = false;
                                        }
                                        else if (userInput == 2)
                                        {
                                            Console.WriteLine("Press any key to exit...");
                                            break;
                                        }
                                    }
                                }
                            }
                            else if (userInput == 2)
                            {
                                Console.WriteLine("You try to climb out of the hole, but you realize the hole has disappeared, leaving only the chair. As you reluctantly sit on the chair, you are instantly transported onto a deserted street. As you walk along the street, you notice two houses, one on the Right, and one on the Left.");
                                Console.WriteLine("1) Go to the Right \n2) Go to the Left");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    Console.WriteLine("You go to the Right, and inside you find a table with a single mirror on it, facedown.");
                                    Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        Console.WriteLine("You pick up the mirror, and you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, but the brick wall has been removed. You can finally leave.");
                                        Console.WriteLine("Thanks for playing! \n1) Play again \n2)Exit");
                                        userInput = int.Parse(Console.ReadLine());
                                        if (userInput == 1)
                                        {
                                            isDone = false;
                                        }
                                        else if (userInput == 2)
                                        {
                                            Console.WriteLine("Press any key to exit...");
                                            break;
                                        }
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("You turn around to leave, but find that the door has disappeared, trapping you in the house. As you pick up the mirror, you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, with the brick wall now removed. You can finally leave.");
                                        Console.WriteLine("Thanks for playing! \n1) Play again \n2) Exit");
                                        userInput = int.Parse(Console.ReadLine());
                                        if (userInput == 1)
                                        {
                                            isDone = false;
                                        }
                                        else if (userInput == 2)
                                        {
                                            Console.WriteLine("Press any key to exit...");
                                            break;
                                        }
                                    }
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("You try the Left, but the door is locked. As you go to the Right, you find a table with a single mirror on it, facedown.");
                                    Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        Console.WriteLine("You pick up the mirror, and you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, but the brick wall has been removed. You can finally leave.");
                                        Console.WriteLine("Thanks for playing! \n1) Play again \n2)Exit");
                                        userInput = int.Parse(Console.ReadLine());
                                        if (userInput == 1)
                                        {
                                            isDone = false;
                                        }
                                        else if (userInput == 2)
                                        {
                                            Console.WriteLine("Press any key to exit...");
                                            break;
                                        }
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("You turn around to leave, but find that the door has disappeared, trapping you in the house. As you pick up the mirror, you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, with the brick wall now removed. You can finally leave.");
                                        Console.WriteLine("Thanks for playing! \n1) Play again \n2) Exit");
                                        userInput = int.Parse(Console.ReadLine());
                                        if (userInput == 1)
                                        {
                                            isDone = false;
                                        }
                                        else if (userInput == 2)
                                        {
                                            Console.WriteLine("Press any key to exit...");
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (userInput == 2)
                    {
                        Console.WriteLine("You walk into the alley and find a hole.");
                        Console.WriteLine("1) Jump down into the hole \n2) Try to jump over the hole");
                        userInput = int.Parse(Console.ReadLine());
                        if (userInput == 1)
                        {
                            Console.WriteLine("As you jump down into the hole, you find that you are in a room with a single chair in the middle.");
                            Console.WriteLine("1) Sit in the chair \n2) Try climbing back out of the hole");
                            userInput = int.Parse(Console.ReadLine());
                        }
                        else if (userInput == 2)
                        {
                            Console.WriteLine("You try to climb out of the hole, but realize that the hole has disappeared, leaving only the chair. As you sit in the chair, you are instantly transported onto a deserted street. After walking for a little bit, you notice two houses; one on the Right, and one on the Left.");
                            Console.WriteLine("1) Go to the Right \n2) Go to the Left");
                            userInput = int.Parse(Console.ReadLine());
                            if (userInput == 1)
                            {
                                Console.WriteLine("You go to the Right, and inside you find a table with a single mirror on it, facedown.");
                                Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    Console.WriteLine("You pick up the mirror, and you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, but the brick wall has been removed. You can finally leave.");
                                    Console.WriteLine("Thanks for playing! \n1) Play again \n2)Exit");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        isDone = false;
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("Press any key to exit...");
                                        break;
                                    }
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("You turn around to leave, but find that the door has disappeared, trapping you in the house. As you pick up the mirror, you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, with the brick wall now removed. You can finally leave.");
                                    Console.WriteLine("Thanks for playing! \n1) Play again \n2) Exit");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        isDone = false;
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("Press any key to exit...");
                                        break;
                                    }
                                }
                            }
                            else if (userInput == 2)
                            {
                                Console.WriteLine("You try the Left, but the door is locked. As you go to the Right, you find a table with a single mirror on it, facedown.");
                                Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    Console.WriteLine("You pick up the mirror, and you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, but the brick wall has been removed. You can finally leave.");
                                    Console.WriteLine("Thanks for playing! \n1) Play again \n2)Exit");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        isDone = false;
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("Press any key to exit...");
                                        break;
                                    }
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("You turn around to leave, but find that the door has disappeared, trapping you in the house. As you pick up the mirror, you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, with the brick wall now removed. You can finally leave.");
                                    Console.WriteLine("Thanks for playing! \n1) Play again \n2) Exit");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        isDone = false;
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("Press any key to exit...");
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                else if (userInput == 2)
                {
                    Console.WriteLine("You run blindly into the alley and fall down into a hole. Getting up, you realize you are in a room with a single chair.");
                    Console.WriteLine("1) Sit in the chair \n2) Climb back out of the hole");
                    userInput = int.Parse(Console.ReadLine());
                    if (userInput == 1)
                    {
                        Console.WriteLine("As you sit in the chair, you are instantly transported onto a deserted street. As you walk down the street, you notice two houses; one on the Right, and one on the Left. ");
                        Console.WriteLine("1) Go to the Right \n2) Go to the Left");
                        userInput = int.Parse(Console.ReadLine());
                        if (userInput == 1)
                        {
                            Console.WriteLine("You go to the Right, and inside you find a table with a single mirror on it, facedown.");
                            Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                            userInput = int.Parse(Console.ReadLine());
                            if (userInput == 1)
                            {
                                Console.WriteLine("You pick up the mirror, and you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, but the brick wall has been removed. You can finally leave.");
                                Console.WriteLine("Thanks for playing! \n1) Play again \n2)Exit");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    isDone = false;
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("Press any key to exit...");
                                    break;
                                }
                            }
                            else if (userInput == 2)
                            {
                                Console.WriteLine("You turn around to leave, but find that the door has disappeared, trapping you in the house. As you pick up the mirror, you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, with the brick wall now removed. You can finally leave.");
                                Console.WriteLine("Thanks for playing! \n1) Play again \n2) Exit");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    isDone = false;
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("Press any key to exit...");
                                    break;
                                }
                            }
                        }
                        else if (userInput == 2)
                        {
                            Console.WriteLine("You try the Left, but the door is locked. As you go to the Right, you find a table with a single mirror on it, facedown.");
                            Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                            userInput = int.Parse(Console.ReadLine());
                            if (userInput == 1)
                            {
                                Console.WriteLine("You pick up the mirror, and you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, but the brick wall has been removed. You can finally leave.");
                                Console.WriteLine("Thanks for playing! \n1) Play again \n2)Exit");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    isDone = false;
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("Press any key to exit...");
                                    break;
                                }
                            }
                            else if (userInput == 2)
                            {
                                Console.WriteLine("You turn around to leave, but find that the door has disappeared, trapping you in the house. As you pick up the mirror, you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, with the brick wall now removed. You can finally leave.");
                                Console.WriteLine("Thanks for playing! \n1) Play again \n2) Exit");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    isDone = false;
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("Press any key to exit...");
                                    break;
                                }
                            }
                        }
                    }
                    else if (userInput == 2)
                    {
                        Console.WriteLine("You try to climb out of the hole, but find that the hole has disappeared, and you are stuck in the room. As you sit on the chair, you are instantly transported onto a deserted street. As you walk down the street, you notice two houses; one on the Right and one on the Left.");
                        Console.WriteLine("1) Go the the Right \n2) Go to the Left");
                        userInput = int.Parse(Console.ReadLine());
                        if (userInput == 1)
                        {
                            Console.WriteLine("You go to the Right and find a table with a single mirror on it, facedown.");
                            Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                            userInput = int.Parse(Console.ReadLine());
                            if (userInput == 1)
                            {
                                Console.WriteLine("You pick up the mirror, and you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, but the brick wall has been removed. You can finally leave.");
                                Console.WriteLine("Thanks for playing! \n1) Play again \n2)Exit");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    isDone = false;
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("Press any key to exit...");
                                    break;
                                }
                            }
                            else if (userInput == 2)
                            {
                                Console.WriteLine("You turn around to leave, but find that the door has disappeared, trapping you in the house. As you pick up the mirror, you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, with the brick wall now removed. You can finally leave.");
                                Console.WriteLine("Thanks for playing! \n1) Play again \n2) Exit");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    isDone = false;
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("Press any key to exit...");
                                    break;
                                }
                            }
                        }
                        else if (userInput == 2)
                        {
                            Console.WriteLine("You try the Left, but find that it is locked. As you go to the Right, you find a table with a single mirror on it.");
                            Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                            userInput = int.Parse(Console.ReadLine());
                            if (userInput == 1)
                            {
                                Console.WriteLine("You pick up the mirror, and you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, but the brick wall has been removed. You can finally leave.");
                                Console.WriteLine("Thanks for playing! \n1) Play again \n2)Exit");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    isDone = false;
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("Press any key to exit...");
                                    break;
                                }
                            }
                            else if (userInput == 2)
                            {
                                Console.WriteLine("You turn around to leave, but find that the door has disappeared, trapping you in the house. As you pick up the mirror, you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, with the brick wall now removed. You can finally leave.");
                                Console.WriteLine("Thanks for playing! \n1) Play again \n2) Exit");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    isDone = false;
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("Press any key to exit...");
                                    break;
                                }
                            }
                        }
                    }
                }
                else if (userInput == 3)
                {
                    Console.WriteLine("You cautiously approach the alley and find a hole.");
                    Console.WriteLine("1) Go into the hole \n2) Try to jump over the hole");
                    userInput = int.Parse(Console.ReadLine());
                    if (userInput == 1)
                    {
                        Console.WriteLine("You go into the hole, and find yourself in a room with a single chair in the middle.");
                        Console.WriteLine("1) Sit in the chair \n2) Try to climb back out of the hole");
                        userInput = int.Parse(Console.ReadLine());
                        if (userInput == 1)
                        {
                            Console.WriteLine("As you sit in the chair, you are instantly transported onto a deserted street. Walking down the street, you find two houses; one on the Right, and one on the Left.");
                            Console.WriteLine("1) Go to the Right \n2) Go to the Left");
                            userInput = int.Parse(Console.ReadLine());
                            if (userInput == 1)
                            {
                                Console.WriteLine("You go to the Right and find a table with a single mirror on it, facedown.");
                                Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    Console.WriteLine("You pick up the mirror, and you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, but the brick wall has been removed. You can finally leave.");
                                    Console.WriteLine("Thanks for playing! \n1) Play again \n2)Exit");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        isDone = false;
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("Press any key to exit...");
                                        break;
                                    }
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("You turn around to leave, but find that the door has disappeared, trapping you in the house. As you pick up the mirror, you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, with the brick wall now removed. You can finally leave.");
                                    Console.WriteLine("Thanks for playing! \n1) Play again \n2) Exit");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        isDone = false;
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("Press any key to exit...");
                                        break;
                                    }
                                }
                            }
                            else if (userInput == 2)
                            {
                                Console.WriteLine("You try the Left, but the door is locked. As you go to the Right, you find a table with a single mirror on it, facedown.");
                                Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    Console.WriteLine("You pick up the mirror, and you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, but the brick wall has been removed. You can finally leave.");
                                    Console.WriteLine("Thanks for playing! \n1) Play again \n2)Exit");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        isDone = false;
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("Press any key to exit...");
                                        break;
                                    }
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("You turn around to leave, but find that the door has disappeared, trapping you in the house. As you pick up the mirror, you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, with the brick wall now removed. You can finally leave.");
                                    Console.WriteLine("Thanks for playing! \n1) Play again \n2) Exit");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        isDone = false;
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("Press any key to exit...");
                                        break;
                                    }
                                }
                            }
                        }
                        else if (userInput == 2)
                        {
                            Console.WriteLine("You try to climb back out of the hole, but you realize that the hole has disappeared, leaving you stuck in the room. As you reluctantly sit on the chair, you are transported onto a deserted street. Walking along the street, you notice two houses; one on the Right, and one on the Left.");
                            Console.WriteLine("1) Go to the Right \n2) Go to the Left");
                            userInput = int.Parse(Console.ReadLine());
                            if (userInput == 1)
                            {
                                Console.WriteLine("You go to the Right and find a table with a single mirror on it, facedown.");
                                Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    Console.WriteLine("You pick up the mirror, and you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, but the brick wall has been removed. You can finally leave.");
                                    Console.WriteLine("Thanks for playing! \n1) Play again \n2)Exit");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        isDone = false;
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("Press any key to exit...");
                                        break;
                                    }
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("You turn around to leave, but find that the door has disappeared, trapping you in the house. As you pick up the mirror, you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, with the brick wall now removed. You can finally leave.");
                                    Console.WriteLine("Thanks for playing! \n1) Play again \n2) Exit");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        isDone = false;
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("Press any key to exit...");
                                        break;
                                    }
                                }
                            }
                            else if (userInput == 2)
                            {
                                Console.WriteLine("You try the Left, but the door is locked. As you go to the Right, you find a table with a single mirror on it, facedown.");
                                Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    Console.WriteLine("You pick up the mirror, and you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, but the brick wall has been removed. You can finally leave.");
                                    Console.WriteLine("Thanks for playing! \n1) Play again \n2)Exit");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        isDone = false;
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("Press any key to exit...");
                                        break;
                                    }
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("You turn around to leave, but find that the door has disappeared, trapping you in the house. As you pick up the mirror, you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, with the brick wall now removed. You can finally leave.");
                                    Console.WriteLine("Thanks for playing! \n1) Play again \n2) Exit");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        isDone = false;
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("Press any key to exit...");
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    else if (userInput == 2)
                    {
                        Console.WriteLine("You try to jump over the hole, but find that it is a lot longer than you can see or jump over, and you fall into it. As you get up, you realize you are in a room with a single chair.");
                        Console.WriteLine("1) Sit in the chair \n2) Try to climb back out of the hole");
                        userInput = int.Parse(Console.ReadLine());
                        if (userInput == 1)
                        {
                            Console.WriteLine("As you sit in the chair, you are instantly transported onto a deserted street. As you walk down the street, you notice two houses; one on the Right, and one on the Left.");
                            Console.WriteLine("1) Go to the Right \n2) Go to the Left");
                            userInput = int.Parse(Console.ReadLine());
                            if (userInput == 1)
                            {
                                Console.WriteLine("You go to the Right and find a table with a single mirror on it, facedown.");
                                Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    Console.WriteLine("You pick up the mirror, and you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, but the brick wall has been removed. You can finally leave.");
                                    Console.WriteLine("Thanks for playing! \n1) Play again \n2)Exit");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        isDone = false;
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("Press any key to exit...");
                                        break;
                                    }
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("You turn around to leave, but find that the door has disappeared, trapping you in the house. As you pick up the mirror, you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, with the brick wall now removed. You can finally leave.");
                                    Console.WriteLine("Thanks for playing! \n1) Play again \n2) Exit");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        isDone = false;
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("Press any key to exit...");
                                        break;
                                    }
                                }
                            }
                            else if (userInput == 2)
                            {
                                Console.WriteLine("You try the Left, but the door is locked. As you go to the Right, you find a table with a single mirror on it, facedown.");
                                Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    Console.WriteLine("You pick up the mirror, and you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, but the brick wall has been removed. You can finally leave.");
                                    Console.WriteLine("Thanks for playing! \n1) Play again \n2)Exit");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        isDone = false;
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("Press any key to exit...");
                                        break;
                                    }
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("You turn around to leave, but find that the door has disappeared, trapping you in the house. As you pick up the mirror, you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, with the brick wall now removed. You can finally leave.");
                                    Console.WriteLine("Thanks for playing! \n1) Play again \n2) Exit");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        isDone = false;
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("Press any key to exit...");
                                        break;
                                    }
                                }
                            }
                        }
                        else if (userInput == 2)
                        {
                            Console.WriteLine("You try to climb back out of the hole, but find that the hole has disappeared, leaving only the chair. As you reluctantly sit in the chair, you are instantly transported onto a deserted street. As you walk along this street, you see two houses; one on the Right, and one on the Left.");
                            Console.WriteLine("1) Go to the Right \n2) Go to the Left");
                            userInput = int.Parse(Console.ReadLine());
                            if (userInput == 1)
                            {
                                Console.WriteLine("You go to the Right and find a table with a single mirror on it, facedown.");
                                Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    Console.WriteLine("You pick up the mirror, and you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, but the brick wall has been removed. You can finally leave.");
                                    Console.WriteLine("Thanks for playing! \n1) Play again \n2)Exit");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        isDone = false;
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("Press any key to exit...");
                                        break;
                                    }
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("You turn around to leave, but find that the door has disappeared, trapping you in the house. As you pick up the mirror, you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, with the brick wall now removed. You can finally leave.");
                                    Console.WriteLine("Thanks for playing! \n1) Play again \n2) Exit");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        isDone = false;
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("Press any key to exit...");
                                        break;
                                    }
                                }
                            }
                            else if (userInput == 2)
                            {
                                Console.WriteLine("You try the Left, but the door is locked. As you go to the Right, you find a table with a single mirror on it, facedown.");
                                Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    Console.WriteLine("You pick up the mirror, and you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, but the brick wall has been removed. You can finally leave.");
                                    Console.WriteLine("Thanks for playing! \n1) Play again \n2)Exit");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        isDone = false;
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("Press any key to exit...");
                                        break;
                                    }
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("You turn around to leave, but find that the door has disappeared, trapping you in the house. As you pick up the mirror, you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, with the brick wall now removed. You can finally leave.");
                                    Console.WriteLine("Thanks for playing! \n1) Play again \n2) Exit");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        isDone = false;
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("Press any key to exit...");
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                else if (userInput == 4)
                {
                    Console.WriteLine("You stand still, thinking about what to do, when suddenly an invisible pair of hands pushes you. Frightened, you run into the alley and fall into a hole. Getting up, you realize you are in a room with a single chair.");
                    Console.WriteLine("1) Sit in the chair \n2) Climb back out of hole");
                    userInput = int.Parse(Console.ReadLine());
                    if (userInput == 1)
                    {
                        Console.WriteLine("You sit in the chair, and are instantly transported onto a deserted street. Walking down the street, you find two houses;  one on the Right, and one on the Left.");
                        Console.WriteLine("1) Go to the Right \n2) Go to the Left");
                        userInput = int.Parse(Console.ReadLine());
                        if (userInput == 1)
                        {
                            Console.WriteLine("You go to the Right and find a table with a single mirror on it, facedown.");
                            Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                            userInput = int.Parse(Console.ReadLine());
                            if (userInput == 1)
                            {
                                Console.WriteLine("You pick up the mirror, and you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, but the brick wall has been removed. You can finally leave.");
                                Console.WriteLine("Thanks for playing! \n1) Play again \n2)Exit");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    isDone = false;
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("Press any key to exit...");
                                    break;
                                }
                            }
                            else if (userInput == 2)
                            {
                                Console.WriteLine("You turn around to leave, but find that the door has disappeared, trapping you in the house. As you pick up the mirror, you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, with the brick wall now removed. You can finally leave.");
                                Console.WriteLine("Thanks for playing! \n1) Play again \n2) Exit");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    isDone = false;
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("Press any key to exit...");
                                    break;
                                }
                            }
                        }
                        else if (userInput == 2)
                        {
                            Console.WriteLine("You try the Left house, but find that it is locked. Upon going into the Right house, you find a table with a single mirror, facedown.");
                            Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                            userInput = int.Parse(Console.ReadLine());
                            if (userInput == 1)
                            {
                                Console.WriteLine("You pick up the mirror, and you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, but the brick wall has been removed. You can finally leave.");
                                Console.WriteLine("Thanks for playing! \n1) Play again \n2)Exit");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    isDone = false;
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("Press any key to exit...");
                                    break;
                                }
                            }
                            else if (userInput == 2)
                            {
                                Console.WriteLine("You turn around to leave, but find that the door has disappeared, trapping you in the house. As you pick up the mirror, you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, with the brick wall now removed. You can finally leave.");
                                Console.WriteLine("Thanks for playing! \n1) Play again \n2) Exit");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    isDone = false;
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("Press any key to exit...");
                                    break;
                                }
                            } 
                        }
                    }
                    else if (userInput == 2)
                    {
                        Console.WriteLine("You try climbing out of the hole, but realize that the hole has disappeared and you are stuck in the room. As you sit in the chair, you are instantly transported onto a deserted street. As you walk down the street, you find two houses; one on the Right, and one on the Left.");
                        Console.WriteLine("1) Go to the Right \n2) Go to the Left");
                        userInput = int.Parse(Console.ReadLine());
                        if (userInput == 1)
                        {
                            Console.WriteLine("You go to the Right and find a table with a single mirror on it, facedown.");
                            Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                            userInput = int.Parse(Console.ReadLine());
                            if (userInput == 1)
                            {
                                Console.WriteLine("You pick up the mirror, and you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, but the brick wall has been removed. You can finally leave.");
                                Console.WriteLine("Thanks for playing! \n1) Play again \n2)Exit");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    isDone = false;
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("Press any key to exit...");
                                    break;
                                }
                            }
                            else if (userInput == 2)
                            {
                                Console.WriteLine("You turn around to leave, but find that the door has disappeared, trapping you in the house. As you pick up the mirror, you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, with the brick wall now removed. You can finally leave.");
                                Console.WriteLine("Thanks for playing! \n1) Play again \n2) Exit");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    isDone = false;
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("Press any key to exit...");
                                    break;
                                }
                            }
                        }
                        else if (userInput == 2)
                        {
                            Console.WriteLine("You try the Left house, but find that it is locked. Upon going into the Right house, you find a table with a single mirror, facedown.");
                            Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                            userInput = int.Parse(Console.ReadLine());
                            if (userInput == 1)
                            {
                                Console.WriteLine("You pick up the mirror, and you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, but the brick wall has been removed. You can finally leave.");
                                Console.WriteLine("Thanks for playing! \n1) Play again \n2)Exit");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    isDone = false;
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("Press any key to exit...");
                                    break;
                                }
                            }
                            else if (userInput == 2)
                            {
                                Console.WriteLine("You turn around to leave, but find that the door has disappeared, trapping you in the house. As you pick up the mirror, you see the dark alley from the beginning. In a sudden flash of light, you are transported back into the alley, with the brick wall now removed. You can finally leave.");
                                Console.WriteLine("Thanks for playing! \n1) Play again \n2) Exit");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    isDone = false;
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("Press any key to exit...");
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
