using System.Text;

namespace CocktailParty
{
    public class Ingredient
    {
        public Ingredient(string name, int alcohol, int quantity)
        {
            this.Name = name;
            this.Alcohol = alcohol;
            this.Quantity = quantity;
        }

        public string Name { get; set; }

        public int Alcohol { get; set; }

        public int Quantity { get; set; }

        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine($"Ingredient: {this.Name}")
                .AppendLine($"Quantity: {this.Quantity}")
                .Append($"Alcohol: {this.Alcohol}")
                .ToString();
                // TrimEnd() is not needed here cause the last Append() method does not append new line
        }
    }
}
