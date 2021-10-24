using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // number as an input
            int number = int.Parse(Console.ReadLine());
            int temporaryNumber = number;

            int factorialSum = 0;
            

            while (temporaryNumber > 0)
            {
                int lastDigit = temporaryNumber % 10;

                int lastDigitFactorial = 1;

                for (int i = 1; i <= lastDigit; i++)
                {
                    lastDigitFactorial *= i;
                }

                factorialSum += lastDigitFactorial;

                temporaryNumber /= 10;
            }

            if (number == factorialSum)
            {
                Console.WriteLine("yes");
            } 
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
