using System;

namespace FootballSouvenirs
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            string souvenirType = Console.ReadLine();
            int souvenirsBought = int.Parse(Console.ReadLine());

            double totalCost = 0;

            if (team == "Argentina")
            {
                if (souvenirType == "flags")
                {
                    totalCost = souvenirsBought * 3.25;
                }
                else if (souvenirType == "caps")
                {
                    totalCost = souvenirsBought * 7.20;
                }
                else if (souvenirType == "posters")
                {
                    totalCost = souvenirsBought * 5.10;
                }
                else if (souvenirType == "stickers")
                {
                    totalCost = souvenirsBought * 1.25;
                }
            }
            else if (team == "Brazil")
            {
                if (souvenirType == "flags")
                {
                    totalCost = souvenirsBought * 4.20;
                }
                else if (souvenirType == "caps")
                {
                    totalCost = souvenirsBought * 8.50;
                }
                else if (souvenirType == "posters")
                {
                    totalCost = souvenirsBought * 5.35;
                }
                else if (souvenirType == "stickers")
                {
                    totalCost = souvenirsBought * 1.20;
                }
            }
            else if (team == "Croatia")
            {
                if (souvenirType == "flags")
                {
                    totalCost = souvenirsBought * 2.75;
                }
                else if (souvenirType == "caps")
                {
                    totalCost = souvenirsBought * 6.90;
                }
                else if (souvenirType == "posters")
                {
                    totalCost = souvenirsBought * 4.95;
                }
                else if (souvenirType == "stickers")
                {
                    totalCost = souvenirsBought * 1.10;
                }
            }
            else if (team == "Denmark")
            {
                if (souvenirType == "flags")
                {
                    totalCost = souvenirsBought * 3.10;
                }
                else if (souvenirType == "caps")
                {
                    totalCost = souvenirsBought * 6.50;
                }
                else if (souvenirType == "posters")
                {
                    totalCost = souvenirsBought * 4.80;
                }
                else if (souvenirType == "stickers")
                {
                    totalCost = souvenirsBought * 0.90;
                }
            }

            if (team != "Argentina" && team != "Brazil" && team != "Croatia" && team != "Denmark")
            {
                Console.WriteLine("Invalid country!");
            }
            else if (souvenirType != "flags" && souvenirType != "caps" && souvenirType != "posters" && souvenirType != "stickers")
            {
                Console.WriteLine("Invalid stock!");
            }
            else
            {
                Console.WriteLine($"Pepi bought {souvenirsBought} {souvenirType} of {team} for {totalCost:F2} lv.");
            }

        }
    }
}
