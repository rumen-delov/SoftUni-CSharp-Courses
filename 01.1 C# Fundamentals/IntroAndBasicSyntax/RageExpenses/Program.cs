using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetsTrashed = 0;
            int miceTrashed = 0;
            int keyboardsTrashed = 0;
            int displaysTrashed = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    headsetsTrashed += 1;
                }

                if (i % 3 == 0)
                {
                    miceTrashed += 1;
                }

                if (i % 6 == 0)
                {
                    keyboardsTrashed += 1;
                }

                if (i % 12 == 0)
                {
                    displaysTrashed += 1;
                }
            }

            // Another solution

            //int headsetsTrashed = lostgames / 2;
            //int miceTrashed = lostgames / 3;
            //int keyboardsTrashed = lostgames / (2 * 3);
            //int displaysTrashed = lostgames / (2 * 2 * 3);

            double rageExpenses = headsetsTrashed * headsetPrice + 
                miceTrashed * mousePrice + 
                keyboardsTrashed * keyboardPrice + 
                displaysTrashed * displayPrice; 

            Console.WriteLine($"Rage expenses: {rageExpenses:F2} lv.");
        }
    }
}
