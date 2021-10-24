using System;
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            // Each valid order should have a customer, product, count and a price:
            //  - Valid customer's name should be surrounded by '%' and must start with a capital letter, 
            // followed by lower-case letters
            //  - Valid product contains any word character and must be surrounded by '<' and '>'
            //  - Valid count is an integer, surrounded by '|'
            //  - Valid price is any real number followed by '$'
            // The parts of a valid order should appear in the order given: customer, product, count and a price.
            // Between each part there can be other symbols, except ('|', '$', '%' and '.')

            //Regex regex = new Regex(@"%([A-Z][a-z]+)%[^\|\$%\.]*<(\w+)>[^\|\$%\.]*\|(\d+)\|[^\|\$%\.]*?(\d+\.?\d*)\$");
            // or 
            // with named capturing groups
            Regex regex = new Regex(@"%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+\.?\d*)\$");


            double totalIncome = 0;

            // Until you receive a line with text "end of shift" you will be given lines of input
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of shift")
                {
                    break;
                }

                Match match = regex.Match(input);

                if (!match.Success)
                {
                    continue;                    
                }

                //string customerName = match.Groups[1].Value;
                //string product = match.Groups[2].Value;
                //int count = int.Parse(match.Groups[3].Value);
                //double price = double.Parse(match.Groups[4].Value);

                string customerName = match.Groups["customer"].Value;
                string product = match.Groups["product"].Value;
                int count = int.Parse(match.Groups["count"].Value);
                double price = double.Parse(match.Groups["price"].Value);

                double totalPrice = count * price;

                Console.WriteLine($"{customerName}: {product} - {totalPrice:F2}");

                totalIncome += totalPrice;
            }

            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
