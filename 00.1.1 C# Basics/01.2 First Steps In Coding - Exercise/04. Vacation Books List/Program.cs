using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int pagesInTheCurrentBook = int.Parse(Console.ReadLine());
            double pagesPerHourReading = double.Parse(Console.ReadLine());
            int daysToReadTheBook = int.Parse(Console.ReadLine());

            double timeToFinishTheBook = pagesInTheCurrentBook / pagesPerHourReading;
            double hoursPerDayReading = timeToFinishTheBook / daysToReadTheBook;

            Console.WriteLine(hoursPerDayReading);
        }
    }
}
