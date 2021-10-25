using System;

namespace GoldMine
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLocations = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberLocations; i++)
            {
                double avgGoldPerDayExpected = double.Parse(Console.ReadLine());
                int numberDaysPerLocation = int.Parse(Console.ReadLine());

                double goldYieldForCurrentLocation = 0;

                for (int j = 1; j <= numberDaysPerLocation; j++)
                {
                    double goldYield = double.Parse(Console.ReadLine());
                    goldYieldForCurrentLocation += goldYield;
                }

                double avgGoldPerDayYieldForCurrentLocation = goldYieldForCurrentLocation / numberDaysPerLocation;
                
                if (avgGoldPerDayYieldForCurrentLocation >= avgGoldPerDayExpected)
                {
                    Console.WriteLine($"Good job! Average gold per day: {avgGoldPerDayYieldForCurrentLocation:F2}.");
                }
                else
                {
                    Console.WriteLine($"You need {Math.Abs(avgGoldPerDayYieldForCurrentLocation - avgGoldPerDayExpected):F2} gold.");
                }
            }
        }
    }
}
