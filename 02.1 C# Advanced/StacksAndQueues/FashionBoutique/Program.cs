using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesValues = ReadIntArrayFromConsole(); // each value could be between 0 and 20 but smaller than rackCapacity; no more than 50 clothes
            int rackCapacity = int.Parse(Console.ReadLine()); // 0...20
            Stack<int> clothesBox = new Stack<int>(clothesValues);

            int valuesSum = 0;
            int racksCount = 1;

            //if (clothesBox.Sum() == 0)
            //{
            //    Console.WriteLine(racksCount);
            //    return;
            //}

            //if (rackCapacity > 0 && clothesBox.Sum() > 0)
            //{
            //    racksCount = 1;
            //}
            //else
            //{
            //    Console.WriteLine(racksCount);
            //    return;
            //}

            while (clothesBox.Count > 0)
            {
                int capacityCheck = valuesSum + clothesBox.Peek();

                if (capacityCheck < rackCapacity)
                {
                    valuesSum += clothesBox.Pop();
                }
                else if (capacityCheck == rackCapacity)
                {
                    clothesBox.Pop();
                    valuesSum = 0;
                    if (clothesBox.Any()) // or if (clothesBox.Count > 0)
                    {                      
                        racksCount++;
                    }
                }
                else if (capacityCheck > rackCapacity)
                {
                    valuesSum = 0;
                    racksCount++;
                }
            }

            // Print the nuber of racks used
            Console.WriteLine(racksCount);
        }

        private static int[] ReadIntArrayFromConsole()
        {
            return Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
