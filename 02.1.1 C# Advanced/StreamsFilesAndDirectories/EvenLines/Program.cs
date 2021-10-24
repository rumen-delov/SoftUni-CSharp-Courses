using System;
using System.IO;
using System.Linq;
using System.Text;

namespace EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Copy the text file "text.txt" in the working directory
            // In the (VS2019) properties of the file select "Copy if newer" or "Copy always"

            char[] charactersToReplace = { '-', ',', '.', '!', '?' }; 
            // Read a text file
            using StreamReader reader = new StreamReader("text.txt");

            int counter = 0;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (line == null)
                {
                    break;
                }

                // Print its even lines on the console, but first
                // replace {"-", ",", ".", "!", "?"} with "@" and
                // reverse the order of the words.
                if (counter % 2 == 0)
                {
                    line = ReplaceCharacters(charactersToReplace, '@', line);
                    line = ReverseWordsOrder(line);
                    Console.WriteLine(line);
                }

                counter++;
            }
        }

        private static string ReverseWordsOrder(string line)
        {
            StringBuilder sb = new StringBuilder();
            string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < words.Length; i++)
            {
                sb.Append(words[words.Length - i - 1]);
                sb.Append(' ');
            }

            return sb.ToString().TrimEnd();
        }

        private static string ReplaceCharacters(char[] charArray, char replacingChar, string line)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < line.Length; i++)
            {
                char currentSymbol = line[i];

                if (charArray.Contains(currentSymbol))
                {
                    sb.Append(replacingChar);
                }
                else
                {
                    sb.Append(currentSymbol);
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
