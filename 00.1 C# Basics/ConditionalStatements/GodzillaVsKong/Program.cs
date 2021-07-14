using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the movie budget, number of extras, cost for the extras wardrobe
            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double costWardrobePerExtra = double.Parse(Console.ReadLine());

            double decorCost = budget * 0.1;

            if (extras >= 150)
            {
                costWardrobePerExtra -= costWardrobePerExtra * 0.1;
            }

            double totalCost = decorCost + (extras * costWardrobePerExtra);

            if (totalCost > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalCost-budget:F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalCost:F2} leva left.");
            }
        }
    }
}
