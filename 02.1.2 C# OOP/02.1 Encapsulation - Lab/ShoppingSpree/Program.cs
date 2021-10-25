using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();
            
            string[] personInfo = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries);

            string[] productInfo = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries);

            try
            {
                foreach (var info in personInfo)
                {
                    string[] tokens = info.Split('=', StringSplitOptions.RemoveEmptyEntries);

                    string name = tokens[0];
                    decimal money = decimal.Parse(tokens[1]);

                    persons.Add(new Person(name, money));
                }

                foreach (var info in productInfo)
                {
                    string[] tokens = info.Split('=', StringSplitOptions.RemoveEmptyEntries);

                    string name = tokens[0];
                    decimal cost = decimal.Parse(tokens[1]);

                    products.Add(new Product(name, cost));
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] tokens = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string personName = tokens[0];
                string productName = tokens[1];

                // Single() throws an exception whenA
                // the sequence does not contain exactly one element that
                // satisfies the condition
                //Person person = persons.Single(p => p.Name == personName);
                //Product product = products.Single(p => p.Name == productName);

                // or
                Person person = persons.FirstOrDefault(p => p.Name == personName);
                Product product = products.FirstOrDefault(p => p.Name == productName);

                if (person.AddProduct(product))
                {
                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} can't afford {product.Name}");
                }
            }

            foreach (Person person in persons)
            {
                string productsBought = person.BagOfProducts.Count == 0 ? 
                                        "Nothing bought" : 
                                        string.Join(", ", person.BagOfProducts.Select(p => p.Name));
                Console.WriteLine($"{person.Name} - {productsBought}");
            }
        }
    }
}
