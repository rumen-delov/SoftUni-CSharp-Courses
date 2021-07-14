using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double puzzlePrice = 2.60;
            double dollPrice = 3;
            double teddyBearPrice =  4.10;
            double minionPrice =  8.20;
            double truckToyPrice =  2;

            double holidayCost = double.Parse(Console.ReadLine());
            int puzzleSales = int.Parse(Console.ReadLine());
            int dollSales = int.Parse(Console.ReadLine());
            int teddyBearSales = int.Parse(Console.ReadLine());
            int minionSales = int.Parse(Console.ReadLine());
            int truckToySales = int.Parse(Console.ReadLine());

            double totalRevenue = puzzlePrice * puzzleSales + dollPrice*dollSales + 
                                  teddyBearPrice*teddyBearSales + minionPrice*minionSales + truckToyPrice*truckToySales;

            int totalToySales = puzzleSales + dollSales + teddyBearSales + minionSales + truckToySales;

            //Console.WriteLine($"Total revenue: {totalRevenue} lv.");
            //Console.WriteLine($"Total toy sales: {totalToySales}");

            if (totalToySales >= 50)
            {
                totalRevenue -= totalRevenue*0.25;
                //Console.WriteLine($"Total revenue: {totalRevenue} lv.");
            } 
            //else
            //{
            //    Console.WriteLine($"Total revenue: {totalRevenue} lv.");
            //}

            totalRevenue -= totalRevenue * 0.1;
            //Console.WriteLine($"Total revenue after paying the rent: {totalRevenue} lv.");

            if (totalRevenue >= holidayCost)
            {
                Console.WriteLine($"Yes! {totalRevenue-holidayCost:F2} lv left.");
            } else
            {
                Console.WriteLine($"Not enough money! {holidayCost-totalRevenue:F2} lv needed.");
            }
        }
    }
}
