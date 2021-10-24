using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string screening = Console.ReadLine(); // screening = cinema show
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double ticketsIncome = 0;
            int spectators = rows * columns;

            switch (screening)
            {
                case "Premiere":
                    ticketsIncome = spectators * 12;
                    break;
                case "Normal":
                    ticketsIncome = spectators * 7.5;
                    break;
                case "Discount":
                    ticketsIncome = spectators * 5;
                    break;
            }
            Console.WriteLine($"{ticketsIncome:F2} leva");
        }
    }
}
