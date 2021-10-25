using System;
using System.Text.RegularExpressions;

namespace CheckingForMatches
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Nakov: 123, Branson: 456";
            string pattern = @"([A-Z][a-z]+): (\d+)";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            Console.WriteLine($"Found {matches.Count} matches");

            foreach (Match match in matches)
            {
                Console.WriteLine($"Name: {match.Groups[1]}");
            }
        }
    }
}
