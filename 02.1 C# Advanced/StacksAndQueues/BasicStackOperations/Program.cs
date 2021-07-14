using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int numOfElementsToPush = inputs[0];
            int numOfElementsToPop = inputs[1];
            int elementToCheck = inputs[2];

            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < numOfElementsToPush; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < numOfElementsToPop; i++)
            {
                stack.Pop();
            }

            Console.WriteLine(stack.Count == 0 ? "0" : stack.Contains(elementToCheck) ? "true" : $"{stack.Min()}");

            //if (stack.Count == 0) // or stack.Any()
            //{
            //    Console.WriteLine("0");
            //}
            //else if (stack.Contains(elementToCheck))
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine(stack.Min()); 
            //}            
        }
    }
}
