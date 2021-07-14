using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string substringToRemove = Console.ReadLine();
            string text = Console.ReadLine();

            // Option 1

            // Remove all of the occurrences of the first string in the second until 
            // there is no match

            //int index = text.IndexOf(substringToRemove);

            // The IndexOf method returns - 1 if it does not find a match 

            //while (index != -1)
            //{
            //    text = text.Remove(index, substringToRemove.Length);
            //    index = text.IndexOf(substringToRemove);
            //}

            // Option 2

            while (text.Contains(substringToRemove))
            {
                text = text.Replace(substringToRemove, string.Empty);
            }

            // Print the remaining string
            Console.WriteLine(text);
        }
    }
}
