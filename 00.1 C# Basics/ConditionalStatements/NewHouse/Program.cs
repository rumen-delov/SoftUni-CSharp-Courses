using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int numberFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double expenses = 0;

            if (flowerType == "Roses")
            {
                expenses = numberFlowers * 5;
                if (numberFlowers > 80)
                {
                    expenses -= expenses * 0.1;
                }
            }
            else if (flowerType == "Dahlias")
            {
                expenses = numberFlowers * 3.80;
                if (numberFlowers > 90)
                {
                    expenses -= expenses * 0.15;
                }
            }
            else if (flowerType == "Tulips")
            {
                expenses = numberFlowers * 2.8;
                if (numberFlowers > 80)
                {
                    expenses -= expenses * 0.15;
                }
            }
            else if (flowerType == "Narcissus")
            {
                expenses = numberFlowers * 3;
                if (numberFlowers < 120)
                {
                    expenses += expenses * 0.15;
                }
            }
            else if (flowerType == "Gladiolus")
            {
                expenses = numberFlowers * 2.5;
                if (numberFlowers < 80)
                {
                    expenses += expenses * 0.2;
                }
            }

            if (budget >= expenses)
            {
                Console.WriteLine($"Hey, you have a great garden with {numberFlowers} {flowerType} and {budget- expenses:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {expenses - budget:F2} leva more.");
            }
        }
    }
}
