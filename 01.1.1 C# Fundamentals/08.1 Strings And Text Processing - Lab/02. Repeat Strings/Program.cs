using System;

namespace RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read an array of strings 
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string repeatedWords = string.Empty;

            // Each string is repeated n times, where n is the length of the string 
            foreach (var word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    repeatedWords += word;
                }
            }            
            
            // Print the concatenated string
            Console.WriteLine(repeatedWords);
        }
    }
}
