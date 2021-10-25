using System;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read a string of banned words separated by a comma and space ", "
            string[] bannedWords = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (var bannedWord in bannedWords)
            {
                // Works also without the if statement, but
                // probably is faster if we use first the Contains() method
                if (text.Contains(bannedWord))
                {
                    // new string(char ch, int repeatCount)
                    text = text.Replace(bannedWord, new string('*', bannedWord.Length));
                }
            }
           
            Console.WriteLine(text);
        }
    }
}
