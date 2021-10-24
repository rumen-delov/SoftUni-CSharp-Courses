using System;

namespace CatFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCats = int.Parse(Console.ReadLine());

            int catsGroup1 = 0;
            int catsGroup2 = 0;
            int catsGroup3 = 0;

            double totalGramsCatFood = 0;

            for (int i = 1; i <= numberCats; i++)
            {
                double gramsCatFood = double.Parse(Console.ReadLine());
                totalGramsCatFood += gramsCatFood;

                if (gramsCatFood >= 100 && gramsCatFood < 200)
                {
                    catsGroup1++;
                }
                else if (gramsCatFood >= 200 && gramsCatFood < 300)
                {
                    catsGroup2++; 
                }
                else if (gramsCatFood >= 300 && gramsCatFood < 400)
                {
                    catsGroup3++;
                }
            }

            double catsFoodPricePerDay = totalGramsCatFood / 1000 * 12.45;

            Console.WriteLine($"Group 1: {catsGroup1} cats.");
            Console.WriteLine($"Group 2: {catsGroup2} cats.");
            Console.WriteLine($"Group 3: {catsGroup3} cats.");
            Console.WriteLine($"Price for food per day: {catsFoodPricePerDay:F2} lv.");
        }
    }
}
