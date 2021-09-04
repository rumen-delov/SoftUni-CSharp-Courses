using System;
using System.Collections.Generic;
using System.Linq;

namespace _20210220Problem01TheFightForGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWaves = int.Parse(Console.ReadLine());

            Queue<int> plates = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            bool defended = true;
            string output = string.Empty;

            for (int i = 1; i <= numberOfWaves; i++)
            {
                Stack<int> orcs = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

                if (i % 3 == 0)
                {
                    int extraPlate = int.Parse(Console.ReadLine());
                    plates.Enqueue(extraPlate);
                }

                while (orcs.Any())
                {
                    if (plates.Any() == false)
                    {
                        break;
                    }
                    
                    if (orcs.Peek() > plates.Peek())
                    {
                        orcs.Push(orcs.Pop() - plates.Dequeue());
                    }
                    else if (orcs.Peek() < plates.Peek())
                    {
                        int[] platesArr = plates.ToArray();
                        platesArr[0] -= orcs.Pop();
                        plates = new Queue<int>(platesArr);
                    }
                    else
                    {
                        orcs.Pop();
                        plates.Dequeue();
                    }
                }

                if (plates.Any() == false)
                {
                    defended = false;
                    output = string.Join(", ", orcs);
                    break;
                }
            }

            if (defended)
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }
            else
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {output}");
            }
        }
    }
}
