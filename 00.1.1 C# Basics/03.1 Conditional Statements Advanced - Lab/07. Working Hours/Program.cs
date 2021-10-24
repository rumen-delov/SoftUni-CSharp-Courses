using System;

namespace WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the hour and the day of the week
            int hour = int.Parse(Console.ReadLine());
            string weekDay = Console.ReadLine();
            
            // Opening hours Mo-Sa 10h-18h
            if ((weekDay == "Monday" || weekDay == "Tuesday" || weekDay == "Wednesday" || weekDay == "Thursday" || weekDay == "Friday" || weekDay == "Saturday") && (hour >= 10 && hour <= 18))
            {
                Console.WriteLine("open");
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
