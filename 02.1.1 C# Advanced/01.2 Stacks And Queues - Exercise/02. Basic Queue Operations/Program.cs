using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int numOfElementsToEnqueue = inputs[0];
            int numOfElementsToDequeue = inputs[1];
            int elementToCheck = inputs[2];

            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < numOfElementsToEnqueue; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < numOfElementsToDequeue; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if (queue.Contains(elementToCheck))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}