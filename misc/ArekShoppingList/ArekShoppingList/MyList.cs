using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArekShoppingList
{
    class MyList
    {
        string[] items;

        public MyList()
        {
            items = new string[0];
        }

        public void Add(string addItem)
        {
            // Create a new array 1 item larger
            // Copy old array into the new array
            // Add new item to end of new array
            // Set old array variable to new array
            if(Contains(addItem))
            {
                Console.WriteLine("This item is already on your list.");
                return;
            }
            string[] newArray = new string[items.Length + 1];
            for (int i = 0; i < items.Length; i++)
            {
                newArray[i] = items[i];
            }
           
            newArray[newArray.Length - 1] = addItem;


            items = newArray;
        }

        public void Remove(string removeItem)
        {
            //Create a new array 1 item smaller
            //ask the user what item they want to remove 
            //then transfer items normally
            //while transfering check if the item you are currently about to transfer is = the item we want to remove
            //if it is, skip over it, and transfer the next item instead
            //once finished transferring, set old array = new array
            if (!Contains(removeItem))
            {
                Console.WriteLine("You can't remove an item that's not on your shopping list!");
                return; 
            }
            string[] newArray = new string[items.Length - 1];
            // i = old array variables, j = new array variables
            for (int i = 0, j = 0; i < items.Length; i++)
            {
                if (items[i] == removeItem)
                {
                    continue;
                }
                newArray[j] = items[i];
                j++;
            }
            items = newArray;
        }

        public bool Contains(string item)
        {
            for(int i = 0; i < items.Length; i++)
            {
                if (items[i] == item)
                {
                    return true; 
                }
            }
            return false; 
        }

        public void Print()
        {
            for(int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }


    }
}
