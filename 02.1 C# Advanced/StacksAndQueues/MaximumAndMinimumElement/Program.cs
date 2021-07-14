using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfQueries = int.Parse(Console.ReadLine()); // 1 <= numOfQueries <= 105
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < numOfQueries; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int query = input[0];

                switch (query)
                {
                    case 1:
                        int elementToPush = input[1]; // 1 <= elementToPush <= 109
                        stack.Push(elementToPush);
                        break;
                    case 2:
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                        }                        
                        break;
                    case 3:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Max());
                        }                        
                        break;
                    case 4:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Min());
                        }                        
                        break;
                    default:
                        break;
                }               
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}