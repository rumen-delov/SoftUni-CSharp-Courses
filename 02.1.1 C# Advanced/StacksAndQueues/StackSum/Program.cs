using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(numbers);

            // or

            //Stack<int> stack = new Stack<int>();
            //
            //foreach (var num in numbers)
            //{
            //    stack.Push(num);
            //}

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0].ToUpper();

                if (command == "ADD")
                {
                    int firstNumber = int.Parse(tokens[1]);
                    int secondNumber = int.Parse(tokens[2]);

                    stack.Push(firstNumber);
                    stack.Push(secondNumber);
                }
                else if (command == "REMOVE")
                {
                    int numbersCount = int.Parse(tokens[1]);

                    if (stack.Count >= numbersCount)
                    {
                        for (int i = 0; i < numbersCount; i++)
                        {
                            stack.Pop();
                        }
                    }             
                }
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
            
            // or
            
            //int stackSum = 0;
            //
            //foreach (int element in stack)
            //{
            //    stackSum += element; 
            //}
            //Console.WriteLine($"Sum: {stackSum}");
        }
    }
}