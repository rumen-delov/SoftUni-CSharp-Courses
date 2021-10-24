using System;
using System.Collections.Generic;

namespace ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read a number n  
            int numberOfLines = int.Parse(Console.ReadLine());
            // Create a new list for storing the products
            List<string> productsList = new List<string>();

            // Read n lines of products 
            for (int i = 0; i < numberOfLines; i++)
            {
                string currentProduct = Console.ReadLine();

                productsList.Add(currentProduct);
            }

            // Sort the list of producs alphabetically
            productsList.Sort();

            // Print a numbered list of all the products ordered by name
            for (int i = 0; i < productsList.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{productsList[i]}");
            }
        }
    }
}
