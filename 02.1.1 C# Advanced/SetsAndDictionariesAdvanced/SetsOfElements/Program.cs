using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lengths = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int set1Length = lengths[0];
            int set2Length = lengths[1];

            var set1 = new HashSet<int>();
            var set2 = new HashSet<int>();

            FillSetFromConsoleInput(set1, set1Length);
            FillSetFromConsoleInput(set2, set2Length);
            
            foreach (var num in set1)
            {
                if (set2.Contains(num))
                {
                    Console.Write(num + " ");
                }       
            }
        }

        private static HashSet<int> FillSetFromConsoleInput(HashSet<int> set, int setLength)
        {
            for (int i = 0; i < setLength; i++)
            {
                set.Add(int.Parse(Console.ReadLine()));
            }

            return set;
        }
    }
}
