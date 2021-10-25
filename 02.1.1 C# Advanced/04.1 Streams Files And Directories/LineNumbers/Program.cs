using System;
using System.IO;
using System.Linq;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("text.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                string currentLine = lines[i];
                int lettersCount = CountLetters(currentLine);
                int punctuationMarksCount = CountPunctuationMarks(currentLine);

                lines[i] = $"Line {i + 1}: {currentLine} ({lettersCount})({punctuationMarksCount})";
            }

            File.WriteAllLines("../../../output.txt", lines);
        }

        private static int CountPunctuationMarks(string line)
        {
            int punctuationMarksCounter = 0;

            for (int i = 0; i < line.Length; i++)
            {
                char currentChar = line[i];

                if (char.IsPunctuation(currentChar))
                {
                    punctuationMarksCounter++;
                }
            }

            return punctuationMarksCounter;
        }

        private static int CountLetters(string line)
        {
            int letterCounter = 0;
            
            for (int i = 0; i < line.Length; i++)
            {
                char currentChar = line[i];
                
                if (char.IsLetter(currentChar))
                {
                    letterCounter++;
                }
            }

            return letterCounter;
        }
    }
}
