using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read a list of integers
            List<int> intList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            // Remove all negative numbers from it
            for (int i = 0; i < intList.Count; i++)
            {
                if (intList[i] < 0)
                {
                    intList.RemoveAt(i);
                    i--;
                    // Or quicker like this
                    // intList.RemoveAt(i--);
                }
            }

            // Print the remaining elements in reversed order. 
            // In case there are no elements left in the list, print "empty"

            intList.Reverse();

            if (intList.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(' ', intList));
            }
        }
    }
}
