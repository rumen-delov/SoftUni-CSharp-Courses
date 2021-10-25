using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter a day number [1...7]
            int dayNumber = int.Parse(Console.ReadLine());

            // Option 1 with arrays
            
            // string[] days = new string[7] 
            // or 
            // string[] days = new string[]
            // or 
            string[] days =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            // Print the name of the day if valid, 
            // otherwise print "Invalid day!"
            if (dayNumber < 1 || dayNumber > days.Length)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(days[dayNumber - 1]);
            }

            // Another way

            //if (dayNumber-1 >= 0 && dayNumber-1 < days.Length)
            //{
            //    Console.WriteLine(days[dayNumber - 1]);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid day!");
            //}


            // Option 2 with switch expression

            //switch (dayNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid day!");
            //        break;
            //}
        }
    }
}
