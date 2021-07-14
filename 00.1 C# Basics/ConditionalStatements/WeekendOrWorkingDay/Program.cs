using System;

namespace WeekendOrWorkingDay
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the day of the week
            string weekDay = Console.ReadLine();

            switch (weekDay)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    Console.WriteLine("Working day");
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
