using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            // A valid full name has the following characteristics:
            // - It consists of two words.
            // - Each word starts with a capital letter.
            // - After the first letter, it only contains lowercase letters afterwards.
            // - Each of the two words should be at least two letters long.
            // - The two words are separated by a single space.

            string listOfNames = Console.ReadLine();

            // Use a verbatim string (@ in front of the string literal) to
            // store regular expressions, since characters like the backslash “\” can clash with string escaping.
            string validNamePattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            // Instantiate a Regex object
            Regex regex = new Regex(validNamePattern);
            MatchCollection matchedValidNames = regex.Matches(listOfNames);

            // or
            
            // use only the static method
            //MatchCollection matchedValidNames = Regex.Matches(listOfNames, validNamesPattern);

            foreach (Match name in matchedValidNames)
            {
                Console.Write(name.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
