using System;
using System.Collections.Generic;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> charStack = new Stack<char>();

            foreach (var character in input)
            {
                charStack.Push(character);
            }

            while (charStack.Count > 0)
            {
                Console.Write(charStack.Pop());
            }

            Console.WriteLine();
        }
    }
}
