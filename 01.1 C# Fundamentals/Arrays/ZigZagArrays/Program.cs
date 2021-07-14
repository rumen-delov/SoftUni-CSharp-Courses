using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lines to be read
            int linesToRead = int.Parse(Console.ReadLine());

            int[] zigArr = new int[linesToRead];
            int[] zagArr = new int[linesToRead];

            // On the next n lines you get 2 integers
            for (int i = 0; i < linesToRead; i++)
            {
                int[] lineArr = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 == 0) // When the index i is even, the line is odd 
                {
                    zigArr[i] = lineArr[i % 2]; // Set zigArr[i] (odd line) to lineArr[0] (the first element (index 0) of array lineArr) 
                    zagArr[i] = lineArr[i % 2 + 1];
                }
                else
                {
                    zigArr[i] = lineArr[i % 2]; // Set zigArr[i] (even line) to lineArr[1] (the second element (index 1) of array lineArr) 
                    zagArr[i] = lineArr[i % 2 - 1];
                }
            }

            Console.WriteLine(string.Join(' ', zigArr));
            Console.WriteLine(string.Join(' ', zagArr));
        }
    }
}
