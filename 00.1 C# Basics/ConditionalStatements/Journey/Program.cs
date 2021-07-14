using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string accommodationType = "";
            double expenses = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    expenses = budget * 0.3;
                }
                else if (season == "winter")
                {
                    expenses = budget * 0.7;
                }
            } 
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    expenses = budget * 0.4;
                }
                else if (season == "winter")
                {
                    expenses = budget * 0.8;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                expenses = budget * 0.9;
            }
            
            if (season == "summer" && destination != "Europe")
            {
                accommodationType = "Camp";
            }
            else if (season == "winter" || destination == "Europe")
            {
                accommodationType = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{accommodationType} - {expenses:F2} ");
        }
    }
}
