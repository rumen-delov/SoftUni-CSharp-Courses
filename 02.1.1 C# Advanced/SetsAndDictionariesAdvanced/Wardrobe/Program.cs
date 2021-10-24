using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Number of inputs
            int numOfInputs = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numOfInputs; i++)
            {
                // Clothes of the same color as input
                string[] input = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string color = input[0];
                string[] clothes = input[1]
                    .Split(',', StringSplitOptions.RemoveEmptyEntries);

                // If there is no such color in the dictionary
                // add the color as a key and
                // create new inner dictionary for the items and their count 
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                // Check each item of the current color 
                for (int item = 0; item < clothes.Length; item++)
                {
                    // If for the current color there is no such clothing item in the inner dictionary
                    // add one and set the number of pieces initially to zero 
                    if (!wardrobe[color].ContainsKey(clothes[item]))
                    {
                        wardrobe[color].Add(clothes[item], 0);
                    }

                    // Increase the number of the current clothing item of the current color
                    wardrobe[color][clothes[item]]++;                   
                }
            }

            // Look for a clothing of the given color in the wardrobe
            string[] query = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string colorQuery = query[0];
            string clothingQuery = query[1];

            // Print all the clothing items and their count for each color
            // and if you find the item you are looking for, print "(found!)" next to it
            foreach (var entry in wardrobe)
            {
                Console.WriteLine($"{entry.Key} clothes:");

                foreach (var item in entry.Value)
                {
                    Console.Write($"* {item.Key} - {item.Value}");

                    if (entry.Key == colorQuery && item.Key == clothingQuery)
                    {
                        Console.Write(" (found!)");
                    }
                    
                    Console.WriteLine();
                }
            }
        }
    }
}
