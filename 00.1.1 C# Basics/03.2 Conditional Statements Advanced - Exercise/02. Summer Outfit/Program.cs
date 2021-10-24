using System;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            // THERE IS ALSO ANOTHER VERSION WHERE WE GROUP
            // THE TEMPERATURE AND THE TIME OF THE DAY THAT BELONG TO THE SAME OUTFIT AND THE SHOES
            // Read the temperature and the time of the day
            int temperatureDegrees = int.Parse(Console.ReadLine());
            string timeOfTheDay = Console.ReadLine();

            string outfit = "";
            string shoes = "";

            if (timeOfTheDay == "Morning")
            {
                if (temperatureDegrees >= 10 && temperatureDegrees <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (temperatureDegrees > 18 && temperatureDegrees <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (temperatureDegrees >= 25)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (timeOfTheDay == "Afternoon")
            {
                if (temperatureDegrees >= 10 && temperatureDegrees <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (temperatureDegrees > 18 && temperatureDegrees <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (temperatureDegrees >= 25)
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            else if (timeOfTheDay == "Evening")
            {
                if (temperatureDegrees >= 10 && temperatureDegrees <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (temperatureDegrees > 18 && temperatureDegrees <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (temperatureDegrees >= 25)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }

            Console.WriteLine($"It's {temperatureDegrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}
