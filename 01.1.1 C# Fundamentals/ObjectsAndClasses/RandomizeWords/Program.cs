using System;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            // List of words in one line as an input
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // Create a random number generator - an object of type Random
            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                // Use rnd.Next(minValue, maxValue)
                // minValue is inclusive, but 
                // maxValue is exclusive

                // here minValue is the default one which is 0
                // so we set only the maxValue
                int randomPosition = rnd.Next(words.Length); 
                
                // Swap a word at index i with a word at random index
                string word = words[i];
                words[i] = words[randomPosition];
                words[randomPosition] = word;                  
            }

            // Print each word at a separate line
            Console.WriteLine(string.Join(Environment.NewLine, words));
            // or use new line character '\n'
            //Console.WriteLine(string.Join('\n', words));
        }
    }
}
 