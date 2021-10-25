using System;
using System.Linq;

namespace SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read an array of integers from the console 
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)               
                .ToArray();

            // Sum only the even numbers
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
