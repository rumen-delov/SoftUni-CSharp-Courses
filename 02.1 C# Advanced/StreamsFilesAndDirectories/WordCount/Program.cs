using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordOccurences = new Dictionary<string, int>();

            using StreamReader wordReader = new StreamReader("words.txt");
           
            while(!wordReader.EndOfStream)
            {
                string line = wordReader.ReadLine();

                if (line == null)
                {
                    break;
                }
                
                string word = line.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray()[0]
                    .ToLower();

                if (!wordOccurences.ContainsKey(word))
                {
                    wordOccurences[word] = 0;
                }
            }

            using StreamReader textReader = new StreamReader("text.txt");

            while (!textReader.EndOfStream)
            {
                string line = textReader.ReadLine();

                if (line == null)
                {
                    break;
                }

                string[] words = line
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
					.Select(w => w.Trim(new char[] { '-', ',', '.', '!', '?'}))
                    // .Select(w => w.TrimStart(new char[] { '-', ',', '.', '!', '?'}))
                    // .Select(w => w.TrimEnd(new char[] { '-', ',', '.', '!', '?' }))
                    .Select(w => w.ToLower())
                    .ToArray();
                  
                foreach (string word in words)
                {
                    if (wordOccurences.ContainsKey(word))
                    {
                        wordOccurences[word]++;
                    }
                }
            }

			using StreamWriter writer = new StreamWriter("../../../actualResult.txt");

            foreach (var element in wordOccurences.OrderByDescending(w => w.Value))
            {
                writer.WriteLine($"{element.Key} - {element.Value}");
            }

        }
    }
}
