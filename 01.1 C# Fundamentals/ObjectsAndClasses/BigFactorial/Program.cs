using System;
using System.Numerics;


namespace BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // A number in the range [0...1000] as an input
            int number = int.Parse(Console.ReadLine());

            // Use the class BigInteger from the built-in .NET library System.Numerics.dll
            // Import the namespace “System.Numerics"
            BigInteger factorial = 1;

            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);           
        }
    }
}
 