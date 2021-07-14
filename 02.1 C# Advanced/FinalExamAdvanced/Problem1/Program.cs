using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> ingredientsQueue = new Queue<int>(FillFromConsole());
            Stack<int> freshnessStack = new Stack<int>(FillFromConsole());

            // freshness level -> dish 
            Dictionary<int, string> dishByFreshness = new Dictionary<int, string>()
            {
                { 150, "Dipping sauce" },
                { 250, "Green salad" },
                { 300, "Chocolate cake" },
                { 400,  "Lobster" }
            };

            // dish -> count of the its preparations
            Dictionary<string, int> preparedDishes = new Dictionary<string, int>()
            {
                { "Dipping sauce", 0 },
                { "Green salad", 0 },
                { "Chocolate cake", 0 },
                { "Lobster", 0 }
            };

            // Stop cooking only when you run out of ingredients or freshness level values
            while (freshnessStack.Any() && ingredientsQueue.Any())
            {
                // Remove an ingredient with value 0 and continue cooking
                if (ingredientsQueue.Peek() == 0)
                {
                    ingredientsQueue.Dequeue();
                    continue;
                }

                // The total freshness level is calculated by the multiplication of
                // the first ingredient value and the last freshness level value
                int currentTotalFreshness = freshnessStack.Peek() * ingredientsQueue.Peek();

                // If the total freshness level equals one of the levels in the dictionary,
                if (dishByFreshness.ContainsKey(currentTotalFreshness))
                {
                    // you make the dish and ...
                    string currentDish = dishByFreshness[currentTotalFreshness];
                    preparedDishes[currentDish]++;

                    // ... remove both ingredient and freshness value
                    freshnessStack.Pop();
                    ingredientsQueue.Dequeue();
                }
                else
                {
                    freshnessStack.Pop();
                    ingredientsQueue.Enqueue(ingredientsQueue.Dequeue() + 5);
                }
            }

            // Print if you've succeeded in preparing the dishes
            if (preparedDishes.ContainsValue(0))
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }
            else
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }

            // Print the sum of the ingredients only if they are left any
            if (ingredientsQueue.Any())
            {
                Console.WriteLine($"Ingredients left: {ingredientsQueue.Sum()}");
            }

            // Print the dishes you have made ordered alphabetically,
            // but only the ones that were made at least once
            foreach (var entry in preparedDishes.Where(d => d.Value > 0).OrderBy(d => d.Key))
            {
                Console.WriteLine($" # {entry.Key} --> {entry.Value}");
            }
        }

        private static IEnumerable<int> FillFromConsole()
        {
            return Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);
        }
    }
}
