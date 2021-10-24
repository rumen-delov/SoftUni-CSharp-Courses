using System;

namespace IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read four integer numbers, 
            // all of them will in the range [-2,147,483,648… 2,147,483,647]
            // which is between the min value and max value of the type integer 

            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int num3 = int.Parse(Console.ReadLine());
            //int num4 = int.Parse(Console.ReadLine());

            // variable num1 and variable num2 are from type int, 
            // so when we sum the two int variables the result is also from type int
            // even before we assign it

            //long result = (num1 + num2) / num3 * num4;

            // or cast it

            //long result = (long)(num1 + num2) / num3 * num4;

            // A way around is to add a number of type long like  
            // so that the whole sum becomes of type long.
            // 0L means a zero of type long (zero with a suffix L)

            // long result = (num1 + 0L + num2) / num3 * num4;

            long num1 = long.Parse(Console.ReadLine());
            long num2 = long.Parse(Console.ReadLine());
            long num3 = long.Parse(Console.ReadLine());
            long num4 = long.Parse(Console.ReadLine());

            long result = (num1 + num2) / num3 * num4;

            Console.WriteLine(result);

            //// Test with all max values

            //long num1MaxValue = int.MaxValue;
            //long num2MaxValue = int.MaxValue;
            //long num3MaxValue = int.MaxValue;
            //long num4MaxValue = int.MaxValue;

            //long resultMaxExtreme = (num1MaxValue + num2MaxValue) / num3MaxValue * num4MaxValue;

            //Console.WriteLine(resultMaxExtreme);

            //// Test with the max result
            //// which is sum of two max values mulptiplied by a max value
            //// that implies that the sum is divided by 1

            //resultMaxExtreme = (num1MaxValue + num2MaxValue) / 1 * num4MaxValue;

            //Console.WriteLine(resultMaxExtreme);
        }
    }
}
