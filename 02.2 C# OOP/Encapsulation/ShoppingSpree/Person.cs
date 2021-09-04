using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bagOfProducts;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            // TODO: This way or with a property?
            this.bagOfProducts = new List<Product>();
        }

        public string Name
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"Name cannot be empty");
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get => this.money;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Money cannot be negative");
                }

                this.money = value;
            }
        }

        public IReadOnlyCollection<Product> BagOfProducts
        {
            get => this.bagOfProducts.AsReadOnly(); 
        }

        public bool AddProduct(Product product)
        {
            if (this.Money >= product.Cost )
            {
                this.Money -= product.Cost;
                this.bagOfProducts.Add(product);
                return true;
            }

            return false;
        }
    }
}
