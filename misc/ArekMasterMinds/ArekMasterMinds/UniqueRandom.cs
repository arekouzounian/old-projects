using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArekMasterMinds
{
    class UniqueRandom : Random
    {
        int[] usedNumbers;

        public UniqueRandom()
        {
            usedNumbers = new int[0];
        }

        public int Random(int low, int high)
        {
            //pick a random number
            //check if that number exists in usedNumbers
            //if it does, repeat picking a random number until it does not exist in the array

            int rand = 0;
            do
            {
                rand = Next(low, high + 1);
            } while (Contains(rand));

            Add(rand);

            return rand;
        }

        private void Add(int addNum)
        {
            int[] newArray = new int[usedNumbers.Length + 1];
            for (int i = 0; i < usedNumbers.Length; i++)
            {
                newArray[i] = usedNumbers[i];
            }
            newArray[newArray.Length - 1] = addNum;
            usedNumbers = newArray;
        }

        public void Clear()
        {
            //emptys used number array
            usedNumbers = new int[0];
        }

        private bool Contains(int number)
        {
            //checks if number is inside usedNumbers
            for (int i = 0; i < usedNumbers.Length; i++)
            {
                if (usedNumbers[i] == number)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
