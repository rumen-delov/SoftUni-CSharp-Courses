using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {
        private int capacity;
        private int maxAlcoholLevel;

        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.MaxAlcoholLevel = maxAlcoholLevel;
            this.Ingredients = new HashSet<Ingredient>();
        }

        public HashSet<Ingredient> Ingredients { get; private set; }

        public string Name { get; private set; }

        // the maximum allowed number of ingredients in the cocktail
        public int Capacity
        {
            get => this.capacity;
            private set
            {
                if (value > 0)
                {
                    this.capacity = value;
                }
            }
        }
        //public int Capacity { get; set; }

        // the maximum allowed amount of alcohol in the cocktail
        public int MaxAlcoholLevel
        {
            get => this.maxAlcoholLevel;
            private set
            {
                if (value >= 0)
                {
                    this.maxAlcoholLevel = value;
                }
            }
        }
        //public int MaxAlcoholLevel { get; set; }

        public int CurrentAlcoholLevel
        {
            get => Ingredients.Sum(i => i.Alcohol);
        }

        public void Add(Ingredient ingredient)
        {
            if (!Ingredients.Any(i => i.Name == ingredient.Name) &&
                this.Capacity > 0 &&
                ingredient.Alcohol < MaxAlcoholLevel )
            {
                this.Ingredients.Add(ingredient);
                Capacity--;
                MaxAlcoholLevel -= ingredient.Alcohol;
            }
        }

        public bool Remove(string name)
        {
            Ingredient ingredientToRemove = FindIngredient(name);

            if (ingredientToRemove == null)
            {
                return false;
            }
           
            this.Capacity++;
            MaxAlcoholLevel += ingredientToRemove.Alcohol;
            Ingredients.Remove(ingredientToRemove);

            return true;
        }

        public Ingredient FindIngredient(string name)
        {
            return Ingredients.FirstOrDefault(i => i.Name == name); // Single() ?
        }

        public Ingredient GetMostAlcoholicIngredient()
        {
            return Ingredients.OrderByDescending(i => i.Alcohol).FirstOrDefault();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cocktail: {this.Name} - Current Alcohol Level: {this.CurrentAlcoholLevel}");

            foreach (Ingredient ingredient in Ingredients)
            {
                sb.AppendLine(ingredient.ToString());
            }

            return sb.ToString().TrimEnd(); // TrimEnd() is important because of the every new line that gets appended
        }
    }
}
