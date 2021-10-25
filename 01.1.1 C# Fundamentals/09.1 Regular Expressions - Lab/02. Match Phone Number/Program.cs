using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // A valid phone number from Sofia has the following characteristics:
            // - It starts with "+359"
            // - Then, it is followed by the area code (always 2)
            // - After that, it’s followed by the number itself:
            //   - The number consists of 7 digits (separated in two groups of 3 and 4 digits respectively).
            // - The different parts are separated by either a space or a hyphen('-').
            string phoneNumbers = Console.ReadLine();
            string pattern = @"(?:^|\s)\+359(\s|-)2\1\d{3}\1\d{4}\b";

            Regex regex = new Regex(pattern);
            MatchCollection matchedPhoneNumbers = regex.Matches(phoneNumbers);

            var phoneNumberMatches = matchedPhoneNumbers
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();

            // Print the valid phone numbers on the console, separated by a comma and a space “, ”
            Console.WriteLine(string.Join(", ", phoneNumberMatches));
        }
    }
}
