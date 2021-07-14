using System;

namespace PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // start and end integer numbers as an input
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = startNumber; i <= endNumber; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }

            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
