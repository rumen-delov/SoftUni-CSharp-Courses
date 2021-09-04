using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem01BirthdayCelebration
{
    class Program
    {
        static void Main(string[] args)
        {            
            int[] eatingCapacity = ReadIntegersFromConsole();
            int[] foodAmount = ReadIntegersFromConsole();

            Queue<int> guests = new Queue<int>(eatingCapacity);
            Stack<int> plates = new Stack<int>(foodAmount);

            int wastedFood = 0;

            while (plates.Any() && guests.Any())
            {
                if (plates.Peek() >= guests.Peek())
                {
                    wastedFood += plates.Pop() - guests.Dequeue();
                }
                else
                {
                    int[] guestsArr = guests.ToArray();
                    guestsArr[0] -= plates.Pop();
                    guests = new Queue<int>(guestsArr);
                }
            }

            if (!guests.Any())
            {
                Console.WriteLine($"Plates: {string.Join(' ', plates)}"); 
            }
            else
            {
                Console.WriteLine($"Guests: {string.Join(' ', guests)}");
            }

            Console.WriteLine($"Wasted grams of food: {wastedFood}");
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
