using System;
using System.Text;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read a string from the console 
            string repeatingCharacters = Console.ReadLine();

            char prevSymbol = '\0'; // previous symbol is empty char meaning begining of the string 
            StringBuilder result = new StringBuilder();

            // Replace any sequence of the same letters with a single corresponding letter
            foreach (var currentSymbol in repeatingCharacters)
            {
                if (currentSymbol != prevSymbol)
                {
                    result.Append(currentSymbol);
                }

                prevSymbol = currentSymbol;
            }

            Console.WriteLine(result);
        }
    }
}
