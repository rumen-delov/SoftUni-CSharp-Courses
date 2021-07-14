using System;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the number
            int number = int.Parse(Console.ReadLine());

            // Condition
            if (number % 2 == 0) 
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }    
        }
    }
}
