using System;
using System.Collections.Generic;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            SortedDictionary<char, int> charOccurrences = new SortedDictionary<char, int>();

            foreach (var character in text)
            {
                if (!charOccurrences.ContainsKey(character))
                {
                    charOccurrences.Add(character, 0);
                }

                charOccurrences[character]++;
            }
            
            foreach (var entry in charOccurrences)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value} time/s" );
            }            
        }
    }
}