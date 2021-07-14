using System;

namespace Workout
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberDaysRunning = int.Parse(Console.ReadLine());
            double kmCoveredFirstDay = double.Parse(Console.ReadLine());

            double dailyKmCovered = kmCoveredFirstDay;
            double totalKmCovered = kmCoveredFirstDay;

            for(int i = 1; i <= numberDaysRunning; i++)
            {
                int dailyPercentageGain = int.Parse(Console.ReadLine());
                dailyKmCovered += dailyKmCovered * dailyPercentageGain / 100;
                totalKmCovered += dailyKmCovered;
            }

            if (totalKmCovered >= 1000)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(totalKmCovered - 1000)} more kilometers!");
            }
            else
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - totalKmCovered)} more kilometers");
            }

        }
    }
}
