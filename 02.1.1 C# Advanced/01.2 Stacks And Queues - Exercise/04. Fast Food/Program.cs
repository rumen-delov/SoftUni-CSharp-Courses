using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine()); // 0...1000
            int[] orders = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> queue = new Queue<int>(orders);

            Console.WriteLine(queue.Max());

            while (queue.Count > 0)
            {
                int currentOrder = queue.Peek();

                if (foodQuantity >= currentOrder)
                {
                    foodQuantity -= queue.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(' ', queue)}");
                    return;
                }
            }

            Console.WriteLine("Orders complete");
        }
    }
}
