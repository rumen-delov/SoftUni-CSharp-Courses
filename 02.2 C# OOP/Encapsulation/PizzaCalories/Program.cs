using System;

namespace PizzaCalories
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string pizzaName = Console.ReadLine()
                .Split()[1]; // = second element of the first line input
                //.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1]; // = second element of the first line input

            string[] doughData = Console.ReadLine()
                .Split();
                //.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string flourType = doughData[1];
            string bakingTechique = doughData[2];
            int doughWeight = int.Parse(doughData[3]);

            try
            {
                Dough dough = new Dough(flourType, bakingTechique, doughWeight);
                Pizza pizza = new Pizza(pizzaName, dough);

                while (true)
                {
                    string input = Console.ReadLine();

                    if (input == "END")
                    {
                        break;
                    }

                    string[] toppingData = input
                        .Split();
                        //.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    string toppingType = toppingData[1];
                    int toppingWeight = int.Parse(toppingData[2]);

                    Topping topping = new Topping(toppingType, toppingWeight);

                    pizza.AddTopping(topping);
                }

                Console.WriteLine($"{pizza.Name} - {pizza.CalculateCalories():F2} Calories.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
