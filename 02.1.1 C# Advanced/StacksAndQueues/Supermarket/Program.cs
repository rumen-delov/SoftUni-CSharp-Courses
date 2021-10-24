using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> customerNames = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                if (input == "Paid")
                {
                    while (customerNames.Count > 0)
                    {
                        Console.WriteLine(customerNames.Dequeue());
                    }          
                }
                else
                {
                    customerNames.Enqueue(input);
                }
            }

            Console.WriteLine($"{customerNames.Count} people remaining.");
        }
    }
}