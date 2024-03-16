using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArekShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {

            //ask the user to enter a number of items /
            //then, create an array of strings that is that big
            //and store all the words that the user wants to enter into the array
            //lastly, show the user the items before showing them the menu
            Console.WriteLine("Please enter the amount of items you would like to add to your Shopping List.");
            int count = int.Parse(Console.ReadLine());
            MyList ShoppingList = new MyList();
            //string[] shoppingList = new string[];
            for(int shoppingListItemNum = 0; shoppingListItemNum < count; shoppingListItemNum++)
            {
                Console.WriteLine("Please Enter an Item:"); 
                ShoppingList.Add(Console.ReadLine());
            }
            Console.WriteLine("Here are the items you have entered:");
            ShoppingList.Print();

            
            


            bool isDone = true;
            Console.WriteLine("Welcome to your Shopping List!");
            while(isDone)
            {
                Console.WriteLine("1) View List \n2) Add \n3)Remove \n4)Exit");
                int userInput = int.Parse(Console.ReadLine());
                if (userInput == 1)
                {
                    ShoppingList.Print();
                } 
                else if (userInput == 2)
                {
                    Console.WriteLine("Please Enter your new item:");
                    string itemToAdd = Console.ReadLine();
                    ShoppingList.Add(itemToAdd);
                }
                else if(userInput == 3)
                {
                    Console.WriteLine("What item would you like to remove?");
                    string removeItem = Console.ReadLine();
                    ShoppingList.Remove(removeItem);
                }
                else if(userInput == 4)
                {
                    Console.WriteLine("Press any key to exit.");
                    isDone = false; 
                }
            }

            
            Console.ReadKey();
        }
    }
}
