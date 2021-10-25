using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            // On the first line you will be given list of participants in a race separated by ", ".
            // At the beginning we set the covered distance of each racer to zero
            Dictionary<string, int> raceData = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToDictionary(x => x, x => 0);

            Regex regexLetters = new Regex(@"[A-Za-z]+");
            Regex regexDigits = new Regex(@"\d");

            // On the next few lines until you receive a line "end of race" 
            // you will be given some info which will be some alphanumeric characters
            while (true)
            {
                string input = Console.ReadLine();

                // If the input is not "end of race" ...
                if (input == "end of race")
                {
                    break;
                }

                // ... the input is some alphanumeric characters.
                // In between them you could have some extra characters which you should ignore 
                MatchCollection matchedLetters = regexLetters.Matches(input);
                MatchCollection matchedDigits = regexDigits.Matches(input);

                string racerName = GetName(matchedLetters);              
                // If the name of the current racer is not on the participants' list
                // continue with the next one
                if (!raceData.ContainsKey(racerName))
                {
                    continue;
                }

                int coveredDistance = GetSum(matchedDigits);
                // Add up the covered distance to the current racer 
                raceData[racerName] += coveredDistance;
            }
            
            string[] topThreeRacers = raceData
                .OrderByDescending(pair => pair.Value)
                .Take(3)
                .Select(pair => pair.Key)
                .ToArray();

            Console.WriteLine($"1st place: {topThreeRacers[0]}");
            Console.WriteLine($"2nd place: {topThreeRacers[1]}");
            Console.WriteLine($"3rd place: {topThreeRacers[2]}");
        }

        private static int GetSum(MatchCollection matches)
        {
            int sum = 0;
            
            foreach (Match match in matches)
            {
                sum += int.Parse(match.Value);
            }

            return sum;
        }

        private static string GetName(MatchCollection matches)
        {
            StringBuilder sb = new StringBuilder();
            
            foreach (Match match in matches)
            {
                sb.Append(match.Value);
            }

            return sb.ToString();
        }
    }
}
