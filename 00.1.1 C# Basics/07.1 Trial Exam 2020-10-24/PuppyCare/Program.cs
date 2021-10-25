using System;

namespace PuppyCare
{
    class Program
    {
        static void Main(string[] args)
        {
            int kgDogFood = int.Parse(Console.ReadLine());

            int gramsDogFoodEaten = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Adopted")
                {
                    break;
                }
                gramsDogFoodEaten += int.Parse(input); 
            }

            if ((kgDogFood * 1000) >= gramsDogFoodEaten)
            {
                Console.WriteLine($"Food is enough! Leftovers: {(kgDogFood * 1000) - gramsDogFoodEaten} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs((kgDogFood * 1000) - gramsDogFoodEaten)} grams more.");
            }
        }
    }
}
