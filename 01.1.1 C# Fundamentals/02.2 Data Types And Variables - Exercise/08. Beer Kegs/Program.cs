using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            // The number of beer kegs should be in the interval [1...10]
            byte numberOfBeerKegs = byte.Parse(Console.ReadLine());
            string biggestKegModel = string.Empty; // or ""
            double biggestKegVolume = 0;

            for (int i = 0; i < numberOfBeerKegs; i++)
            {
                // The radius will be a floating-point number in the interval [1…3.402823E+38] 
                // which is the range of the float type floating-point numbers.
                // The height will be an integer in the interval [1…2147483647]

                string kegModel = Console.ReadLine();
                float kegRadius = float.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());

                double kegVolume = Math.PI * Math.Pow(kegRadius, 2) * kegHeight;

                // What if we have two or more kegs with the same volume?
                // It is not explained in the task!
                
                if(kegVolume > biggestKegVolume)
                {
                    biggestKegVolume = kegVolume;
                    biggestKegModel = kegModel;
                }
            }

            Console.WriteLine(biggestKegModel);
        }
    }
}
