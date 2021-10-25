using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Count the quantity of each resource 
            Dictionary<string, long> resuorceCount = new Dictionary<string, long>();
            
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }

                string resource = input; // e.g. Gold, Silver, Copper, and so on
                long quantity = long.Parse(Console.ReadLine()); // The quantities will be in the range [1...2 000 000 000]

                if (resuorceCount.ContainsKey(resource))
                {
                    resuorceCount[resource] += quantity;
                }
                else
                {
                    resuorceCount.Add(resource, quantity);
                }
            }

            foreach (var dictRecord in resuorceCount)
            {
                Console.WriteLine($"{dictRecord.Key} -> {dictRecord.Value}");
            }
        }
    }
}
