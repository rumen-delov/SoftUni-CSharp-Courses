using System;

namespace CinemaTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            // THERE IS ALSO VERSION WITH "OR" (e.g. "Monday" || "Tuesday" and so on) 
            // Read the day of the week
            string weekDay = Console.ReadLine();

            switch (weekDay)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    Console.WriteLine("12");
                    break;
                case "Wednesday":
                case "Thursday":
                    Console.WriteLine("14");
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("16");
                    break;
            } 
        }
    }
}
