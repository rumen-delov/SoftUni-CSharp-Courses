using System;

namespace FruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the type of food
            string food = Console.ReadLine();

            switch (food)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    Console.WriteLine("fruit");
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
