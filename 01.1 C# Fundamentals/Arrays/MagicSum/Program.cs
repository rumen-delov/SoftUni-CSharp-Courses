using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find and print all unique pairs in an array of integers whose 
            // sum is equal to a given number
            int[] intArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int targetNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < intArr.Length - 1; i++)
            {
                int currentNumber = intArr[i];

                for (int j = i + 1; j < intArr.Length; j++)
                {
                    int secondNumber = intArr[j];
                    int pairSum = currentNumber + secondNumber;

                    if (pairSum == targetNumber)
                    {
                        Console.WriteLine($"{currentNumber} {secondNumber}");
                        break;
                    }
                }
            }
        }
    }
}
