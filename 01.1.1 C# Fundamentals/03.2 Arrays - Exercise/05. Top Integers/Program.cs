using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find all the top integers in an array 
            // A top integer is an integer which is bigger than all the elements to its right
            int[] intArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < intArr.Length; i++)
            {
                int currentNumber = intArr[i];
                bool isTopNumber = true;

                for (int j = i + 1; j < intArr.Length; j++)
                {
                    int rightNumber = intArr[j];

                    if (currentNumber <= rightNumber)
                    {
                        isTopNumber = false;
                        break;
                    }
                }

                //Print the top integers
                if (isTopNumber)
                {                  
                    Console.Write($"{currentNumber} ");
                }
            }
        }
    }
}
