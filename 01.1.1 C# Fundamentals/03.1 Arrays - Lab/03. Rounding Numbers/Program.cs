using System;
using System.Linq;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Real numbers (on one line) as an input and
            // save as an array
            double[] realNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            // Round the real numbers in "away from 0" style
            // and print the output in the given way
            for (int i = 0; i < realNumbers.Length; i++)
            {
                // Type double can have negative zero (-0)
                // which would be printed later and it is a violation in the judge system
                // so we convert -0 to 0 using that -0 = 0 
                //if (realNumbers[i] == 0)
                //{
                //    realNumbers[i] = 0;
                //}

                // or
                
                // we cast the real numbers to decimal or we use Convert.ToDecimal() 
                // (because decimal is 128-bit type and can save the accuracy of the 64-bit double)
                // and 
                // cast the rounded numbers to int or we use again Convert.ToDecimal() 
                //Console.WriteLine($"{Convert.ToDecimal(realNumbers[i])} => {(int)Math.Round(realNumbers[i], MidpointRounding.AwayFromZero)}");
                Console.WriteLine($"{(decimal)realNumbers[i]} => {(int)Math.Round(realNumbers[i], MidpointRounding.AwayFromZero)}");
            }

            // Option with creating of another array where we store the rounded numbers
            //int[] roundedNumbers = new int[realNumbers.Length];

            //for (int i = 0; i < realNumbers.Length; i++)
            //{
            //    if (realNumbers[i] == 0)
            //    {
            //        realNumbers[i] = 0;
            //    }

            //    roundedNumbers[i] = (int)Math.Round(realNumbers[i], MidpointRounding.AwayFromZero);
            //    Console.WriteLine($"{realNumbers[i]} => {roundedNumbers[i]}");
            //}
        }
    }
}
