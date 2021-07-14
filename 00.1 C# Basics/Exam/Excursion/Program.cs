using System;

namespace Excursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberFriends = int.Parse(Console.ReadLine());
            int numberNights = int.Parse(Console.ReadLine());
            int numberPublicTransportTickets = int.Parse(Console.ReadLine());
            int numberMuseumTickets = int.Parse(Console.ReadLine());

            double groupCosts = numberFriends * ((numberNights * 20) + (numberPublicTransportTickets * 1.60) + (numberMuseumTickets * 6)); 
            groupCosts += groupCosts * 0.25;

            Console.WriteLine($"{groupCosts:F2}");
        }
    }
}
