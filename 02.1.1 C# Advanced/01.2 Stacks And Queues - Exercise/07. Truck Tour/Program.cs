using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPumps = int.Parse(Console.ReadLine()); // number of petrol pumps on the truck tour
            Queue<int[]> pumps = new Queue<int[]>();

            for (int i = 0; i < numberOfPumps; i++)
            {
                int[] pumpsInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                pumps.Enqueue(pumpsInfo);
            }

            int startingPumpIndex = 0;

            while (true)
            {
                int truckFuel = 0;

                foreach (int[] pump in pumps)
                {
                    int pumpAmount = pump[0]; // the amount of petrol that petrol pump will give
                    int distance = pump[1]; // the fuel consumption for the distance between
                                            // that petrol pump and the next petrol pump
                    truckFuel += pumpAmount - distance;

                    if (truckFuel < 0)
                    {
                        pumps.Enqueue(pumps.Dequeue()); // move the current starting pump to the back of the queue
                        startingPumpIndex++; // change the starting index to the one of the next pump
                        break; // break this cycle and start all over from the next pump as the initial one
                    }
                }

                if (truckFuel >= 0)
                {
                    break;
                }
            }

            Console.WriteLine(startingPumpIndex);
        }
    }
}
