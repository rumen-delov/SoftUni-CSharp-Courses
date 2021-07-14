using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Receive an array and number of rotations you have to perform (first element goes at the end)
            int[] numArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rotations = int.Parse(Console.ReadLine());

            // Option 1

            // Put the first element on the last position in the array
            // and move all other elements one position to the left 
            //for (int i = 0; i < rotations; i++)
            //{
            //    
            //    
            //}

            // Option 2

            // Find the result of rotations % numArr.Length
            int appearingRotations = rotations % numArr.Length;

            // If the result > 0 
            if (appearingRotations > 0)
            {
                // Create a resulting array 
                int[] resultingArr = new int[numArr.Length];

                // Put the first {result of rotations % numArr.Length} elements of the original array 
                // at the last positions (which are computed as element position + (numArr.Length - rotations)) of the resulting array 
                for (int i = 0; i < appearingRotations; i++)
                {
                    resultingArr[i + (numArr.Length - appearingRotations)] = numArr[i]; 
                }

                // Put the last {numArr.Length - appearingRotations} elements of the original array
                // at the first positions (which are computed as element position + the number of appearingRotations) of the resulting array
                for (int i = 0; i < (numArr.Length - appearingRotations); i++)
                {
                    resultingArr[i] = numArr[i + appearingRotations];
                }

                // Print the resulting array 
                Console.WriteLine(string.Join(' ', resultingArr));
            }
            else
            {
                // Print the resulting array which is the original array
                Console.WriteLine(string.Join(' ', numArr));
            }
        }
    }
}
