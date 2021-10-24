using System;
using System.Collections.Generic;
using System.Linq;

namespace _20210414Problem01WarmWinter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hats = ReadIntegersFromConsole();
            int[] scarfs = ReadIntegersFromConsole();

            Stack<int> hatStack = new Stack<int>(hats);
            Queue<int> scarfQueue = new Queue<int>(scarfs);

            List<int> sets = new List<int>();

            while (hatStack.Any() && scarfQueue.Any())
            {
                if (hatStack.Peek() > scarfQueue.Peek())
                {
                    sets.Add(hatStack.Pop() + scarfQueue.Dequeue());
                }
                else if (hatStack.Peek() < scarfQueue.Peek())
                {
                    hatStack.Pop();
                }
                else
                {
                    scarfQueue.Dequeue();
                    hatStack.Push(hatStack.Pop() + 1);
                }
            }

            Console.WriteLine($"The most expensive set is: {sets.Max()}");
            Console.WriteLine(string.Join(' ', sets));
        }

        private static int[] ReadIntegersFromConsole()
        {
            return Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
        }
    }
}
