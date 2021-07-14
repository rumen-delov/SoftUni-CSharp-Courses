using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            Dictionary<string, int> appearences = new Dictionary<string, int>(); 

            // It is guaranteed that only one of the integer numbers to be received
            // appears an even number of times
            for (int i = 0; i < inputCount; i++)
            {
                string number = Console.ReadLine();
                
                if (!appearences.ContainsKey(number))
                {
                    appearences.Add(number, 0);                    
                }

                appearences[number]++;
            }

            Console.WriteLine(appearences.First(n => n.Value % 2 == 0).Key);

            // Another print option

            //foreach (var kvp in appearences)
            //{
            //    if (kvp.Value % 2 == 0)
            //    {
            //        Console.WriteLine(kvp.Key);
            //        return;
            //    }
            //}
        }
    }
}
