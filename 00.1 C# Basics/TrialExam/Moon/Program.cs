using System;

namespace Moon
{
    class Program
    {
        static void Main(string[] args)
        {
            double avgSpeed = double.Parse(Console.ReadLine());
            double litreFuelPer100km = double.Parse(Console.ReadLine());

            double flightTime = (384400 * 2) / avgSpeed;
            double litreFuelUsed = (litreFuelPer100km * 384400 *2) / 100;

            double flghtTimeTotal = Math.Ceiling(flightTime) + 3;
            //Console.WriteLine(flightTime);
            //Console.WriteLine(Math.Ceiling(flightTime));

            Console.WriteLine(flghtTimeTotal);
            Console.WriteLine(litreFuelUsed);
        }
    }
}
