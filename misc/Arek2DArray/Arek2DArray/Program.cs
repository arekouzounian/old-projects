using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arek2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gen = new Random();
            int[,] numbers = new int[8, 9];

            int numRows = numbers.GetLength(0);
            int numCols = numbers.GetLength(1);
            
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    numbers[i, j] = gen.Next(0, 101);
                    Console.Write(numbers[i, j] +"\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
