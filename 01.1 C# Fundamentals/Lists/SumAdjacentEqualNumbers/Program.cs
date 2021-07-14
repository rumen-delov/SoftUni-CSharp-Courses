using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read a list of numbers 
            List<double> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                // Check if the number at the current index is equal to the next number
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] += numbers[i + 1]; // aggregate the numbers
                    numbers.RemoveAt(i + 1);
                    i = -1; // reset the loop
                }
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
