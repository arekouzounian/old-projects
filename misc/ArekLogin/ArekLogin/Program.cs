using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArekLogin
{

    //class Account
    //{
    //    public string username;
    //    public string password;

    //    public Account(string user, string pass)
    //    {
    //        username = user;
    //        password = pass;
    //    }

    //}


    class Program
    {
        // Create a username variable and a password 
        // Ask the user to enter a username and password, and see if the entered ones match the ones in the computer
        // Print logged in if correct, fail
        // Add another user and pass
        // if the user puts in one set of user and pass correctly, greet the user according to what set of user and pass they inputted
        // display the amount of money that each user has when they log in
        static void Main(string[] args)
        {
            Account[] myAccounts = new Account[5];
            myAccounts[0] = new Account("bob123", "password123", 8.43);
            myAccounts[1] = new Account("marley321", "password321", 60.00);
            myAccounts[2] = new Account("username", "password", 100.00);
            myAccounts[3] = new Account("username3", "password3", 64.75);
            myAccounts[4] = new Account("username4", "password4", 143.91);


        

            for (int timesFailed = 0; timesFailed < 3; )
            {
                Console.WriteLine("Enter your username and password.");
                string inputUser = Console.ReadLine();
                string inputPass = Console.ReadLine();
                bool loggedIn = false;
                for (int index = 0; index < myAccounts.Length; index++)
                {

                    if (myAccounts[index].Username == inputUser && myAccounts[index].Password == inputPass)
                    {
                        loggedIn = true;
                        Console.WriteLine($"Correct. Greetings, {myAccounts[index].Username}. \nYour money: {myAccounts[index].Money}");
                        timesFailed = 3;
                        break;
                    }
                }
                if (!loggedIn)
                {
                    Console.WriteLine("Incorrect username or password. Please Try again.");
                    timesFailed++;
                }
            }
            //check if we login, if we are, show the message outside the loop so it doesnt show multiple times

            //if ((inputUser == username) && (inputPass == password))
            //{
            //    Console.WriteLine("Correct. Greetings, bob123.");
            //}
            //else if ((inputUser == username1) && (inputPass == password1))
            //{
            //    Console.WriteLine("Correct. Greetings, marley321.");
            //}
            //else if ((inputUser == username2) && (inputPass == password2))
            //{
            //    Console.WriteLine("Correct. Greetings, marley321.");
            //}
            //else if ((inputUser == username3) && (inputPass == password3))
            //{
            //    Console.WriteLine("Correct. Greetings, marley321.");
            //}
            //else if ((inputUser == username4) && (inputPass == password4))
            //{
            //    Console.WriteLine("Correct. Greetings, marley321.");
            //}


            Console.ReadKey();
        }
    }
}
