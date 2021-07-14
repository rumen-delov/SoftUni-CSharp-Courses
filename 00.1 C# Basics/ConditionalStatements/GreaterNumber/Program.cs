using System;

namespace GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the two numbers
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            // Condition
            if (firstNumber > secondNumber) 
            {
                Console.WriteLine(firstNumber);
            }
            else
            {
                Console.WriteLine(secondNumber);
            }
        }
    }
}
