using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            // PROBLEM WITH THE MULTIPLICATION OF THE FLOATING NUMBERS, THE RESULT IS NOT EXACT IN SOME CASES
            // Read the item, the city and the quantity
            string item = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;

            if (city == "Sofia")
            {
                if (item == "coffee")
                {
                    price = quantity * 0.5;
                }
                else if (item == "water")
                {
                    price = quantity * 0.8;
                }
                else if (item == "beer")
                {
                    price = quantity * 1.2;
                }
                else if (item == "sweets")
                {
                    price = quantity * 1.45;
                }
                else if (item == "peanuts")
                {
                    price = quantity * 1.6;
                }
            }
            else if (city == "Plovdiv")
            {
                if (item == "coffee")
                {
                    price = quantity * 0.4;
                }
                else if (item == "water")
                {
                    price = quantity * 0.7;
                }
                else if (item == "beer")
                {
                    price = quantity * 1.15;
                }
                else if (item == "sweets")
                {
                    price = quantity * 1.3;
                }
                else if (item == "peanuts")
                {
                    price = quantity * 1.5;
                }
            }
            else if (city == "Varna")
            {
                if (item == "coffee")
                {
                    price = quantity * 0.45;
                }
                else if (item == "water")
                {
                    price = quantity * 0.7;
                }
                else if (item == "beer")
                {
                    price = quantity * 1.1;
                }
                else if (item == "sweets")
                {
                    price = quantity * 1.35;
                }
                else if (item == "peanuts")
                {
                    price = quantity * 1.55;
                }
            }
            Console.WriteLine(price);
        }
    }
}
