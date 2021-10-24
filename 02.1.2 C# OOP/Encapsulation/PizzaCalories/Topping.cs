using System;

namespace PizzaCalories
{
    public class Topping
    {
        private const int MinWeight = 1; 
        private const int MaxWeight = 50;
        private const int BaseCaloriesPerGram = 2;

        private string type; 
        private int weight; 

        public Topping(string type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public string Type
        {
            get => this.type;

            private set
            {
                if (value.ToLower() != "meat" &&
                    value.ToLower() != "veggies" &&
                    value.ToLower() != "cheese" &&
                    value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.type = value;
            }
        }

        public int Weight
        {
            get => this.weight;

            private set
            {
                if (value < MinWeight || value > MaxWeight)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [{MinWeight}..{MaxWeight}].");
                }

                this.weight = value;
            }
        }

        public double CalculateCalories()
        {
            double toppingTypeModifier = GetToppingTypeModifier();

            return this.Weight * BaseCaloriesPerGram * toppingTypeModifier;
        }

        private double GetToppingTypeModifier()
        {
            if (this.Type.ToLower() == "meat")
            {
                return 1.2;
            }

            if (this.Type.ToLower() == "veggies")
            {
                return 0.8;
            }

            if (this.Type.ToLower() == "cheese")
            {
                return 1.1;
            }

            return 0.9;
        }
    }
}
