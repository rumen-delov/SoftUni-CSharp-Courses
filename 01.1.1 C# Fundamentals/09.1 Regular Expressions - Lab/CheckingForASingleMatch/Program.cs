using System;
using System.Text.RegularExpressions;

namespace CheckingForASingleMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Nakov: 123, Branson: 456";
            string pattern = @"([A-Z][a-z]+): (\d+)";

            Regex regex = new Regex(pattern);
            Match match = regex.Match(text); // returns the first match of given pattern

            Console.WriteLine(match.Groups.Count);
            Console.WriteLine("Matched text: \"{0}\"", match.Groups[0]); // match.Groups[0] is the whole match
            Console.WriteLine("Name: {0}", match.Groups[1]); // match.Groups[1] is the first group 
            Console.WriteLine("Number: {0}", match.Groups[2]); // match.Groups[2] is the second group
        }
    }
}
