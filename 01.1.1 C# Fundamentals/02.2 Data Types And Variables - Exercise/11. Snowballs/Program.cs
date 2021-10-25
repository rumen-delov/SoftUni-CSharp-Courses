using System;
using System.Numerics; // for using BigInteger

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Allowed memory/time: 16MB/100ms

            // The number of snowballs (N) will be an integer in range [0, 100]
            byte numberOfSnowballs = byte.Parse(Console.ReadLine());

            // The snowballValue is calculated by the following formula
            // (snowballSnow / snowballTime) ^ snowballQuality, so the max value is 
            // (1000 / 1) ^ 100 = 1E+300 which is more than long, so we need the type BigInteger 
            BigInteger highestSnowballValue = -1; // -1, because even the smallest highestSnowballValue, which is 0, is always bigger than it 

            // Option 1
            //ushort snowballSnowWinner = 0; // The snowballSnow is an integer in range [0, 1000]
            //ushort snowballTimeWinner = 1; // The snowballTime is an integer in range [1, 500]
            //byte snowballQualityWinner = 0; // The snowballQuality is an integer in range [0, 100]

            // Option 2
            string highestResultOutput = string.Empty; 

            for (int i = 0; i < numberOfSnowballs; i++)
            {

                ushort snowballSnow = ushort.Parse(Console.ReadLine());
                ushort snowballTime = ushort.Parse(Console.ReadLine());
                byte snowballQuality = byte.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                // Again, what if there are more than one snowballlValue with the same value?

                if (snowballValue > highestSnowballValue)
                {
                    highestSnowballValue = snowballValue;

                    // Option 1
                    //snowballSnowWinner = snowballSnow;
                    //snowballTimeWinner = snowballTime;
                    //snowballQualityWinner = snowballQuality;

                    // Option 2
                    highestResultOutput = $"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})";
                }
            }

            // Option 1
            //Console.WriteLine($"{snowballSnowWinner} : {snowballTimeWinner} = {highestSnowballValue} ({snowballQualityWinner})");

            // Option 2
            Console.WriteLine(highestResultOutput);
        }
    }
}
