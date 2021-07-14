using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> numQueue = new Queue<int>(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numQueue.Peek() % 2 != 0)
                {
                    numQueue.Dequeue();
                }
                else
                {
                    numQueue.Enqueue(numQueue.Dequeue());
                }
            }

            Console.WriteLine(string.Join(", ", numQueue));
        }
    }
}