using System;
using System.Collections.Generic;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            SortedSet<string> chemicalElements = new SortedSet<string>();  

            for (int i = 0; i < inputCount; i++)
            {
                string[] components = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (var element in components)
                {
                    chemicalElements.Add(element);
                }                
            }

            Console.WriteLine(string.Join(' ', chemicalElements));
        }
    }
}