using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read an array of integers 
            int[] numArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            // Condense them by summing adjacent couples of elements until a single integer is obtained
            while (numArr.Length > 1)
            {
                int[] condensedArr = new int[numArr.Length - 1];

                for (int i = 0; i < numArr.Length - 1; i++)
                {
                    condensedArr[i] = numArr[i] + numArr[i + 1];
                }

                numArr = condensedArr;
            }
            
            Console.WriteLine(numArr[0]);
        }
    }
}
