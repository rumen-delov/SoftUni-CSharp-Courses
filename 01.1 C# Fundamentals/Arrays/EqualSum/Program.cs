using System;
using System.Linq;

namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read an integer "array"
            int[] numArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            // Determine if there exists an element in the array such that 
            // the sum of the elements on its left is equal to 
            // the sum of the elements on its right 
            // (there will never be more than 1 element like that).
            // If there are no elements to the left / right, their sum is considered to be 0
            bool isEqualSum = false;

            for (int i = 0; i < numArr.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                
                for (int j = 0; j < i; j++)
                {
                    leftSum += numArr[j];
                }

                for (int k = i + 1; k < numArr.Length; k++)
                {
                    rightSum += numArr[k];
                }

                if (leftSum == rightSum)
                {
                    isEqualSum = true;
                    Console.WriteLine(i);
                    break;
                }
            }

            // Print the index that satisfies the required condition or
            // "no" if there is no such index.
            if (!isEqualSum)
            {
                Console.WriteLine("no");
            }
        }
    }
}
