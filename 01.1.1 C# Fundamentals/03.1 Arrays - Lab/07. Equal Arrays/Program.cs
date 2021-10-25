using System;
using System.Linq;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read two arrays and print on the console whether they are identical or not
            int[] numArr1 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] numArr2 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sum = 0;

            // Arrays are identical if their elements are equal
            for (int i = 0; i < numArr1.Length; i++)
            {
                // Find the first index where the arrays differ and print a message on the console 
                if (numArr1[i] != numArr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                else
                {
                    // If the arrays are identical find the sum of the first array and 
                    // print a message on the console 
                    sum += numArr1[i];

                    if (i == numArr1.Length - 1)
                    {
                        Console.WriteLine($"Arrays are identical. Sum: {sum}");
                    }
                }
            }
        }
    }
}
