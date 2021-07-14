using System;
using System.Linq;

namespace PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Number of lines to be read as an input
            int numberOfLines = int.Parse(Console.ReadLine());

            // Create an array of integers for saving the numbers to be read
            int[] numbers = new int[numberOfLines];

            // Read the numbers and fill the array
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }

            // Print the array in reverse order

            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(numbers[i] + " ");
            //}

            // Another way
            Console.WriteLine(string.Join(' ', numbers.Reverse()));
        }
    }
}
