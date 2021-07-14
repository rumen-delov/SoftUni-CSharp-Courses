using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            // Farm a legendary item

            // The possible items are:
            // - Shadowmourne - requires 250 Shards
            // - Valanyr - requires 250 Fragments
            // - Dragonwrath - requires 250 Motes

            // The key materials are:
            // - Shards
            // - Fragments
            // - Motes
            // Everything else is junk.
            // The first one that reaches the 250 mark, wins the race

            Dictionary<string, int> keyMaterials = new Dictionary<string, int>
            {
                {"shards", 0},
                {"fragments", 0},
                {"motes", 0}
            };
            SortedDictionary<string, int> junkMaterials = new SortedDictionary<string, int>();

            string winnerType = string.Empty;
            string legendaryItem = string.Empty;
            bool isObtained = false;

            while (!isObtained)
            {
                // Read lines of input in the format: {quantity} {material} {quantity} {material} ... {quantity} {material}
                string[] input = Console.ReadLine()
                    .ToLower()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                // Check only even indexes (where the material is stored)
                for (int i = 1; i < input.Length; i += 2)
                {
                    string type = input[i];
                    int quantity = int.Parse(input[i - 1]);

                    if (keyMaterials.ContainsKey(type))
                    {
                        keyMaterials[type] += quantity;

                        if (keyMaterials[type] >= 250)
                        {
                            winnerType = type;
                            keyMaterials[type] -= 250;
                            isObtained = true;
                            break;
                        }
                    }
                    else
                    {
                        if (junkMaterials.ContainsKey(type))
                        {
                            junkMaterials[type] += quantity;
                        }
                        else
                        {
                            junkMaterials.Add(type, quantity);
                        }
                    }
                }
            }

            switch (winnerType)
            {
                case "shards":
                    legendaryItem = "Shadowmourne";
                    break;
                case "fragments":
                    legendaryItem = "Valanyr";
                    break;
                case "motes":
                    legendaryItem = "Dragonwrath";
                    break;
                default:
                    break;
            }

            // Print the corresponding legendary item obtained
            Console.WriteLine($"{legendaryItem} obtained!");

            // Print the remaining shards, fragments, motes, 
            // ordered by quantity in descending order, 
            // then by name in ascending order, each on a new line.
            Dictionary<string, int> sortedKeyMaterials = keyMaterials
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var dictRecord in sortedKeyMaterials)
            {
                Console.WriteLine($"{dictRecord.Key}: {dictRecord.Value}");
            }

            // Finally, print the collected junk items in alphabetical order.
            foreach (var dictRecord in junkMaterials)
            {
                Console.WriteLine($"{dictRecord.Key}: {dictRecord.Value}");
            }
        }
    }
}
