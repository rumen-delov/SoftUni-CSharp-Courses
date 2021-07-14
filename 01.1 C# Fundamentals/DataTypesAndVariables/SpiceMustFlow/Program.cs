using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            // The starting yield will be a positive integer within range [0...2147483647]
            uint startingYield = uint.Parse(Console.ReadLine());

            // The total amount of spice should be of type long or ulong, 
            // because we add daily yields which could be close to the max value
            ulong totalAmount = 0;
            uint daysOperated = 0;
            byte workersConsumption = 26;

            if (startingYield >= 100)
            {
                while (startingYield >= 100)
                {
                    // The variable totalAmount is of type ulong and
                    // the sum totalAmount += startingYield - workersConsumption; is actually
                    // totalAmount = totalAmount + startingYield - workersConsumption;
                    // which means we have ulong type in the summation and the sum is then of type ulong
                    // otherwise for type int for example we would have had overflow

                    totalAmount += startingYield - workersConsumption; 
                    startingYield -= 10;
                    daysOperated++;
                }

                totalAmount -= workersConsumption;
            }

            Console.WriteLine(daysOperated);
            Console.WriteLine(totalAmount);
        }
    }
}
