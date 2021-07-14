using System;
using System.Dynamic;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read from the input
            double strawberryPrice = double.Parse(Console.ReadLine());
            double bananaAmount = double.Parse(Console.ReadLine());
            double orangeAmount = double.Parse(Console.ReadLine());
            double raspberryAmount = double.Parse(Console.ReadLine());
            double strawberryAmount = double.Parse(Console.ReadLine());

            // Calculate the prices of the other fruits depending on the price of the strawberries
            double raspberryPrice = strawberryPrice * 0.5;
            double orangePrice = raspberryPrice - (raspberryPrice * 0.4);
            double bananaPrice = raspberryPrice - (raspberryPrice * 0.8);

            // Alternative way 
            //double orangePrice = raspberryPrice * 0.6;
            //double bananaPrice = raspberryPrice * 0.2;

            // Calculate the cost for the fruits
            double strawberryCost = strawberryAmount * strawberryPrice;
            double bananaCost = bananaAmount * bananaPrice;
            double raspberryCost = raspberryAmount * raspberryPrice;
            double orangeCost = orangeAmount * orangePrice;

            // Calculate the total cost
            double totalCost = strawberryCost + bananaCost + raspberryCost + orangeCost;
            // Write the total cost formatted
            Console.WriteLine($"{totalCost:F2}");
        }
    }
}
