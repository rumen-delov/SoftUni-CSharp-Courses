using System;

namespace PizzaCalories
{
    public class Dough
    {
        private const int MinWeight = 1;
        private const int MaxWeight = 200;
        private const string InvalidDoughExceptionMessage = "Invalid type of dough.";
        private const int BaseCaloriesPerGram = 2;

        private string flourType;
        private string bakingTechnique;
        private int weight;


        public Dough(string flourType, string bakingTechnique, int weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public string FlourType
        {
            get => this.flourType;

            private set
            {
                if (value.ToLower() != "white" &&
                    value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException(InvalidDoughExceptionMessage);
                }

                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get => this.bakingTechnique;

            private set
            {
                if (value.ToLower() != "crispy" &&
                    value.ToLower() != "chewy" &&
                    value.ToLower() != "homemade")
                {
                    throw new ArgumentException(InvalidDoughExceptionMessage);
                }

                this.bakingTechnique = value;
            }
        }

        public int Weight
        {
            get => this.weight;

            private set
            {
                if (value < MinWeight || value > MaxWeight)
                {
                    throw new ArgumentException($"Dough weight should be in the range [{MinWeight}..{MaxWeight}].");
                }

                this.weight = value;
            }
        }

        public double CalculateCalories()
        {
            double flourTypeModifier = GetFlourTypeModifier();
            double bakingTechiqueModifier = GetBakingTechiqueModifier();

            return this.Weight * BaseCaloriesPerGram * flourTypeModifier * bakingTechiqueModifier;
        }

        private double GetBakingTechiqueModifier()
        {
            if (this.BakingTechnique.ToLower() == "crispy")
            {
                return 0.9;
            }

            if (this.BakingTechnique.ToLower() == "chewy")
            {
                return 1.1;
            }

            return 1;
        }

        private double GetFlourTypeModifier()
        {
            if (this.FlourType.ToLower() == "white")
            {
                return 1.5;  
            }

            return 1;
        }
    }
}
