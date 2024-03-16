using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArekTextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a text-adventure program 
            //User will input numbers and it will follow some sort of story 
            Console.WriteLine("Welcome to your Adventure!");
            Console.WriteLine("You approach a dark alley.");
            Console.WriteLine("1) Back out of the alley \n2) Run blindly into the alley \n3) Cautiously approach the alley \n4) Stand still");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                Console.WriteLine("You turn around to find that there is a brick wall that has suddenly appeared behind you.");
                Console.WriteLine("1) Try to climb the wall \n2) Cautiously go down the alley \n3) Run down the alley.");
                userInput = int.Parse(Console.ReadLine());
                if (userInput == 1)
                {
                    Console.WriteLine("You try climbing the wall, but the wall is very slick and you slide right down.");
                    Console.WriteLine("1) Slowly walk down the alley \n2) Blindly run down the alley");
                    userInput = int.Parse(Console.ReadLine());
                    if (userInput == 1)
                    {
                        Console.WriteLine("You slowly walk down the alley and find a large in hole in front of you.");
                        Console.WriteLine("1) Go into the hole \n2)Try to jump over the hole");
                        userInput = int.Parse(Console.ReadLine());
                        if (userInput == 1)
                        {
                            Console.WriteLine("You drop down into the hole and find yourself in a room with a single chair in the middle.");
                            Console.WriteLine("1) Go and sit on the chair \n2)Try to climb back out of the hole");
                            userInput = int.Parse(Console.ReadLine());
                            if (userInput == 1)
                            {
                                Console.WriteLine("You sit in the chair, and find yourself instantly transported to a deserted street. As you walk down the street, you notice two houses. One on the Right, and one on the Left.");
                                Console.WriteLine("1) Go the Right \n2) Go the the Left");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    Console.WriteLine("You go into the house and find a table with a single handheld mirror, facedown.");
                                    Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        Console.WriteLine("You pick up the mirror, and you see the dark alley that you previously approached. In a sudden flash of light, you are transported back to the alley, but the brick wall has been removed. You are free.");
                                        Console.WriteLine("Thanks for Playing! \nPress any key to leave...");
                                        Console.ReadKey();
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("You turn around to find the door has disappeared, and there is only the mirror and table left. As you pick up the mirror, you see the original dark alley. In a flash of light, you are instantly transported back to the alley, but the brick wall is removed. You are free.");
                                        Console.WriteLine("Thanks for playing! \nPress any key to leave...");
                                        Console.ReadKey();
                                    }
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("You try the door, but it is locked. You try the other house, and find a table with a single handheld mirror, facedown.");
                                    Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        Console.WriteLine("You pick up the mirror, and you see the dark alley that you previously approached. In a sudden flash of light, you are transported back to the alley, but the brick wall has been removed. You are free.");
                                        Console.WriteLine("Thanks for Playing! \nPress any key to leave...");
                                        Console.ReadKey();
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("You turn around to find the door has disappeared, and there is only the mirror and table left. As you pick up the mirror, you see the original dark alley. In a flash of light, you are instantly transported back to the alley, but the brick wall is removed. You are free.");
                                        Console.WriteLine("Thanks for playing! \nPress any key to leave...");
                                        Console.ReadKey();
                                    }
                                }
                            }
                            else if (userInput == 2)
                            {
                                Console.WriteLine("You look up to find the hole you fell through, but find that it is actually gone. You reluctantly sit in the chair, and find yourself instantly transported to a deserted street. As you walk down the street, you notice two houses. One on the Right, and one on the Left.");
                                Console.WriteLine("1) Go the Right \n2) Go the the Left");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    Console.WriteLine("You go into the house and find a table with a single handheld mirror, facedown.");
                                    Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        Console.WriteLine("You pick up the mirror, and you see the dark alley that you previously approached. In a sudden flash of light, you are transported back to the alley, but the brick wall has been removed. You are free.");
                                        Console.WriteLine("Thanks for Playing! \nPress any key to leave...");
                                        Console.ReadKey();
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("You turn around to find the door has disappeared, and there is only the mirror and table left. As you pick up the mirror, you see the original dark alley. In a flash of light, you are instantly transported back to the alley, but the brick wall is removed. You are free.");
                                        Console.WriteLine("Thanks for playing! \nPress any key to leave...");
                                        Console.ReadKey();
                                    }
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("You try the door, but it is locked. You try the other house, and find a table with a single handheld mirror, facedown.");
                                    Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        Console.WriteLine("You pick up the mirror, and you see the dark alley that you previously approached. In a sudden flash of light, you are transported back to the alley, but the brick wall has been removed. You are free.");
                                        Console.WriteLine("Thanks for Playing! \nPress any key to leave...");
                                        Console.ReadKey();
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("You turn around to find the door has disappeared, and there is only the mirror and table left. As you pick up the mirror, you see the original dark alley. In a flash of light, you are instantly transported back to the alley, but the brick wall is removed. You are free.");
                                        Console.WriteLine("Thanks for playing! \nPress any key to leave...");
                                        Console.ReadKey();
                                    }

                                }
                            }
                            else if (userInput == 2)
                            {
                                Console.WriteLine("You try jumping over the hole, but find it is a lot longer than you expected, and you fall into the hole. After getting up, you realize you are in a room with a single chair in the middle.");
                                Console.WriteLine("1) Sit in the chair \n2) Try to climb back out of the hole");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    Console.WriteLine("As you sit in the chair, you are instantly transported to a deserted street. As you walk down the street, you begin to see two houses, one on the Right and one on the Left.");
                                    Console.WriteLine("1) Go the the Right \n2) Go to the Left");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        Console.WriteLine("You go into the house and find a table with a single handheld mirror, facedown.");
                                        Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                                        userInput = int.Parse(Console.ReadLine());
                                        if (userInput == 1)
                                        {
                                            Console.WriteLine("You pick up the mirror, and you see the dark alley that you previously approached. In a sudden flash of light, you are transported back to the alley, but the brick wall has been removed. You are free.");
                                            Console.WriteLine("Thanks for Playing! \nPress any key to leave...");
                                            Console.ReadKey();
                                        }
                                        else if (userInput == 2)
                                        {
                                            Console.WriteLine("You turn around to find the door has disappeared, and there is only the mirror and table left. As you pick up the mirror, you see the original dark alley. In a flash of light, you are instantly transported back to the alley, but the brick wall is removed. You are free.");
                                            Console.WriteLine("Thanks for playing! \nPress any key to leave...");
                                            Console.ReadKey();
                                        }
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("You try the door, but it is locked. You try the other house, and find a table with a single handheld mirror, facedown.");
                                        Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                                        userInput = int.Parse(Console.ReadLine());
                                        if (userInput == 1)
                                        {
                                            Console.WriteLine("You pick up the mirror, and you see the dark alley that you previously approached. In a sudden flash of light, you are transported back to the alley, but the brick wall has been removed. You are free.");
                                            Console.WriteLine("Thanks for Playing! \nPress any key to leave...");
                                            Console.ReadKey();
                                        }
                                        else if (userInput == 2)
                                        {
                                            Console.WriteLine("You turn around to find the door has disappeared, and there is only the mirror and table left. As you pick up the mirror, you see the original dark alley. In a flash of light, you are instantly transported back to the alley, but the brick wall is removed. You are free.");
                                            Console.WriteLine("Thanks for playing! \nPress any key to leave...");
                                            Console.ReadKey();
                                        }

                                    }

                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("You look up to find the hole you fell out of, but you notice the hole has disappeared. When you sit in the chair, you ");
                                }
                            }
                        }
                        else if (userInput == 2)
                        {
                            Console.WriteLine("You run into the dark alley, and suddenly fall into a hole. As you get up you realize you are in a room with a single chair in the middle.");
                            Console.WriteLine("1) Sit in the chair \n2) Try to get back out of the hole");
                            userInput = int.Parse(Console.ReadLine());
                            if (userInput == 1)
                            {
                                Console.WriteLine("As you sit in the chair, you are instantly transported onto an empty street. As you walk down the street you discover two houses, one on the Right and one on the Left.");
                                Console.WriteLine("1) Go to the Right \n2) Go to the Left");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    Console.WriteLine("You go into the house and find a table with a single mirror, facedown.");
                                    Console.WriteLine("1)Pick up the mirror \n2) Leave the House");
                                    userInput = int.Parse(Console.ReadLine());
                                    if (userInput == 1)
                                    {
                                        Console.WriteLine("You pick up the mirror, and you see the dark alley in the beginning. There is a sudden flash of light, and you are instantly transported back into the alley, with the brick wall removed. You are free.");
                                        Console.WriteLine("Thanks for playing! \nPress any key to exit...");
                                        Console.ReadKey();
                                    }
                                    else if (userInput == 2)
                                    {
                                        Console.WriteLine("You try to leave the house, but the room has disappeared from around you, leaving only the table and darkness. As you pick up the mirror, you see the dark alley from the beginning, and in a sudden flash of light, you are instantly transported back to the alley, with the brick wall removed. You are free.");
                                        Console.WriteLine("Thanks for playing! \nPress any key to exit...");
                                        Console.ReadKey();
                                    }
                                }
                            }
                            else if (userInput == 2)
                            {
                                Console.WriteLine("You try the house on the Left, but find the door is locked. As you go into the other house, you find a table with a single mirror on it, facedown.");
                                Console.WriteLine("1) Pick up the mirror \n2) Leave the house");
                                userInput = int.Parse(Console.ReadLine());
                                if (userInput == 1)
                                {
                                    Console.WriteLine("You pick up the mirror, and you see the dark alley in the beginning. There is a sudden flash of light, and you are instantly transported back into the alley, with the brick wall removed. You are free.");
                                    Console.WriteLine("Thanks for playing! \nPress any key to exit...");
                                    Console.ReadKey();
                                }
                                else if (userInput == 2)
                                {
                                    Console.WriteLine("You try to leave the house, but the room has disappeared from around you, leaving only the table and darkness. As you pick up the mirror, you see the dark alley from the beginning, and in a sudden flash of light, you are instantly transported back to the alley, with the brick wall removed. You are free.");
                                    Console.WriteLine("Thanks for playing! \nPress any key to exit...");
                                    Console.ReadKey();
                                }
                            }
                        }
                    }
                    else if (userInput == 2)
                    {
                        Console.WriteLine("You cautiously walk down the alley, and find a large hole in the ground in front of you.");
                        Console.WriteLine("1) Go into the hole \n2)Try to jump over the hole");
                        userInput = int.Parse(Console.ReadLine());
                        if (userInput == 1)
                        {
                            Console.WriteLine("You drop down into the hole and find yourself in a room with a single chair in the middle.");
                            Console.WriteLine("1) Go and sit in the chair \n2) Climb back out of the hole");
                            userInput = int.Parse(Console.ReadLine());
                            
                        }
                        else if (userInput == 2)
                        {
                            Console.WriteLine("You try jumping over the hole, but find it is a lot longer than you expected, and you fall into the hole. After getting up, you realize you are in a room with a single chair in the middle.");
                            //Another if statement here
                        }
                    }
                    else if (userInput == 3)
                    {
                        Console.WriteLine("You run down the alley, until you suddenly fall into a hole, falling flat on your face.");
                        Console.WriteLine("1) Get up and look around \n2) Stay Down");
                        userInput = int.Parse(Console.ReadLine());
                        if (userInput == 1)
                        {
                            Console.WriteLine("You notice yourself in a room with a single chair in the middle.");
                            Console.WriteLine("1) Go and sit on the chair \n2) Try to climb out of the hole you fell into");
                            userInput = int.Parse(Console.ReadLine());
                            //Another if statement here
                        }
                        else if (userInput == 2)
                        {
                            Console.WriteLine("The floor beneath you starts to change from concrete to smooth tile, and as you look up, you find yourself in a room with a single chair in the middle.");
                            //Another if statement here
                        }
                    }
                }
                else if (userInput == 2)
                {
                    Console.WriteLine("You start running, until you suddenly fall into a hole and fall flat on your face.");
                    Console.WriteLine("1) Get up and look around \n2) Stay down");
                    userInput = int.Parse(Console.ReadLine());
                    if (userInput == 1)
                    {
                        Console.WriteLine("You get up, and find yourself in a dark room, with a single chair in the center.");
                        //Another if statement here
                    }
                    else if (userInput == 2)
                    {
                        Console.WriteLine("You feel the floor beneath you changing from concrete to smooth tile, and as you look up you see you are in a room with a single chair in the center.");
                        //Another if statement here
                    }
                }
                else if (userInput == 3)
                {
                    Console.WriteLine("You start slowly walking into the alley, and find a large hole in the ground in front of you.");
                    Console.WriteLine("1) Go into the hole \n2) Try jumping over the hole");
                    userInput = int.Parse(Console.ReadLine());
                    if (userInput == 1)
                    {
                        Console.WriteLine("You jump down into the hole and find yourself in a room with a single chair in the center.");
                        //Another if statement here
                    }
                    else if (userInput == 2)
                    {
                        Console.WriteLine("You try jumping over the hole, but find it is a lot longer than expected. As you get up from your fall into the hole, you find yourself in a room with a single chair in the center.");
                        //Another if statement here
                    }
                }
                else if (userInput == 4)
                {
                    Console.WriteLine("You stand still, studying the alley until an invisible pair of hands pushes you from behind and you fall into the alley. Looking back, you see that a brick wall has suddenly appeared behind you, blocking your way.");
                    Console.WriteLine("1) Try climbing the wall \n2) Cautiously walk down the alley \n3)Blindly run down the alley");
                    userInput = int.Parse(Console.ReadLine());
                    if (userInput == 1)
                    {
                        Console.WriteLine("You try to climb the wall, but find it is too slick and you slide down immediately.");
                        //Another if statement here
                    }
                    else if (userInput == 2)
                    {
                        Console.WriteLine("You cautiously walk down the alley, and find a large hole in front of you.");
                        //Another if statement here 
                    }
                }
            }
        }
    }
}

