using System;

namespace FootballKit
{
    class Program
    {
        static void Main(string[] args)
        {
            double jerseyPrice = double.Parse(Console.ReadLine());
            double freeBallValue = double.Parse(Console.ReadLine());

            double shortsPrice = jerseyPrice * 0.75;
            double socksPrice = shortsPrice * 0.20;
            double footballShoesPrice = 2 * (jerseyPrice + shortsPrice);

            double totalCosts = jerseyPrice + shortsPrice + socksPrice + footballShoesPrice;
            // after 15% discount
            totalCosts -= totalCosts * 0.15; 

            if (totalCosts >= freeBallValue)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {totalCosts:F2} lv.");
            }
            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {freeBallValue - totalCosts:F2} lv. more.");
            }
        }
    }
}
