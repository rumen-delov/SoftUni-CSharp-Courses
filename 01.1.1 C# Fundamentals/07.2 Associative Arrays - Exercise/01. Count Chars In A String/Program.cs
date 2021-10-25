using System;
using System.Collections.Generic;

namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> characterOccurrences = new Dictionary<char, int>();

            string word = Console.ReadLine();

            foreach (char character in word)
            {
                if (character == ' ')
                {
                    continue;
                }

                if (characterOccurrences.ContainsKey(character))
                {
                    characterOccurrences[character]++;
                }
                else
                {
                    characterOccurrences.Add(character, 1);
                }
            }

            foreach (KeyValuePair<char, int> dictRecord in characterOccurrences)
            {
                Console.WriteLine($"{dictRecord.Key} -> {dictRecord.Value}");
            }
        }
    }
}
