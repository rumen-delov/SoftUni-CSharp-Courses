using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read a list of wagons (integers) on the first line 
            // Every integer represents the number of passengers that are currently in each of the wagons
            List<int> passengersByWagonList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxWagonCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "Add")
                {
                    passengersByWagonList.Add(int.Parse(tokens[1]));
                }
                else
                {
                    int passengersToFit = int.Parse(tokens[0]);

                    for (int i = 0; i < passengersByWagonList.Count; i++)
                    {
                        if (passengersByWagonList[i] + passengersToFit <= maxWagonCapacity)
                        {
                            passengersByWagonList[i] += passengersToFit;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(' ', passengersByWagonList));
        }
    }
}
