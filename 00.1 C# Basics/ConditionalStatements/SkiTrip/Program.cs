using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string review = Console.ReadLine();

            double price = 0;
            int nights = days - 1;

            if (roomType == "room for one person")
            {
                price = nights * 18;
            }
            else if (roomType == "apartment") 
            {
                if (days < 10)
                {
                    price = (nights * 25);
                    price -= price * 0.3;
                }
                else if (days >= 10 && days <= 15)
                {
                    price = (nights * 25);
                    price -= price * 0.35;
                }
                else if (days > 15)
                {
                    price = (nights * 25);
                    price -= price * 0.50;
                }
            }
            else if (roomType == "president apartment")
            {
                if (days < 10)
                {
                    price = (nights * 35);
                    price -= price * 0.1;
                }
                else if (days >= 10 && days <= 15)
                {
                    price = (nights * 35);
                    price -= price * 0.15;
                }
                else if (days > 15)
                {
                    price = (nights * 35);
                    price -= price * 0.20;
                }
            }

            if (review == "positive")
            {
                price += price * 0.25;
            }
            else if (review == "negative")
            {
                price -= price * 0.1;
            }

            Console.WriteLine($"{price:F2}");
        }
    }
}
