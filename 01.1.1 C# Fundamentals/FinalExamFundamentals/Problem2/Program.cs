using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Indicates how many inputes to receive
            int n = int.Parse(Console.ReadLine());

            Regex regex = new Regex(@"(\*|@)([A-Z][a-z]{2,})\1:\s\[([A-Za-z])\]\|\[([A-Za-z])\]\|\[([A-Za-z])\]\|$");

            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();
                Match match = regex.Match(message);

                if (match.Success)
                {
                    // Option 1
                    Console.Write($"{match.Groups[2].Value}: ");

                    // Option 2
                    //StringBuilder sb = new StringBuilder();                   
                    //sb.Append(match.Groups[2].Value + ": ");

                    for (int j = 3; j <= 5; j++)
                    {
                        char item = char.Parse(match.Groups[j].Value);
                        int ASCIICode = item;
                        // Option 1
                        Console.Write($"{ASCIICode} ");
                        // Option 2
                        //sb.Append(ASCIICode + " ");                       
                    }

                    // Option 1
                    Console.WriteLine();

                    // Option 2
                    //string result = sb.ToString().Trim(); // Should be ok in the judge system also without the method Trim()
                    //Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }


        }
    }
}
