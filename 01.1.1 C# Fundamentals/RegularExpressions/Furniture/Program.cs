using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            // For the line to be valid it should be in the following format:
            // ">>{furniture name}<<{price}!{quantity}"
            Regex regex = new Regex(@">>(?<name>[A-Za-z]+)<<(?<price>\d+\.?\d*?)!(?<quantity>\d+)");

            double totalCost = 0;
            List<string> furnitureTypes = new List<string>();
            
            while (true)
            {
                // Read lines of input until you receive the line "Purchase"
                string input = Console.ReadLine();

                if (input == "Purchase")
                {
                    break;
                }

                Match match = regex.Match(input);

                // If the match is not valid (successful) continue with the next input

                if (!regex.IsMatch(input))
                {
                    continue;
                }

                // or
                
                //if (!match.Success)
                //{
                //    continue;
                //}

                string furnitureName = match.Groups["name"].Value;
                double furniturePrice = double.Parse(match.Groups["price"].Value);
                int furnitureQuantity = int.Parse(match.Groups["quantity"].Value);

                // Store the name of the current furniture
                furnitureTypes.Add(furnitureName);

                // Calculate the cost of the current furniture
                double furnitureCost = furniturePrice * furnitureQuantity;

                // Calculate the total cost of different types of furniture
                totalCost += furnitureCost;
            }

            Console.WriteLine("Bought furniture:");

            foreach (string furniture in furnitureTypes)
            {
                Console.WriteLine(furniture);
            }

            Console.WriteLine($"Total money spend: {totalCost:F2}");
        }
    }
}
