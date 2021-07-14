using System;

namespace ExcursionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPeople = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double priceFivePeopleOrLess = 0;
            double priceOverFivePeople = 0;

            double excursionPrice = 0;

            switch (season)
            {
                case "spring":
                    priceFivePeopleOrLess = 50;
                    priceOverFivePeople = 48;
                    break;
                case "summer":
                    priceFivePeopleOrLess = 48.50;
                    priceOverFivePeople = 45;
                    break;
                case "autumn":
                    priceFivePeopleOrLess = 60;
                    priceOverFivePeople = 49.5;
                    break;
                case "winter":
                    priceFivePeopleOrLess = 86;
                    priceOverFivePeople = 85;
                    break;
            }

            if (numberPeople <= 5)
            {
                excursionPrice = numberPeople * priceFivePeopleOrLess;
            }
            else
            {
                excursionPrice = numberPeople * priceOverFivePeople;
            }

            if (season == "summer")
            {
                excursionPrice -= excursionPrice * 0.15;
            }
            else if (season == "winter")
            {
                excursionPrice += excursionPrice * 0.08;
            }

            Console.WriteLine($"{excursionPrice:F2} leva.");
        }
    }
}
