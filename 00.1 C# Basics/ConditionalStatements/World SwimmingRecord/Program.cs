using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the swimming record to beat (in seconds), the swimming distance (in meters), and the time to swim 1 meter (in seconds)
            double worldSwimmingRecord = double.Parse(Console.ReadLine());
            double swimmingDistance = double.Parse(Console.ReadLine());
            double timeNeededToSwimOneMeter = double.Parse(Console.ReadLine());

            double waterResistanceDelay = Math.Floor(swimmingDistance / 15)*12.5;
            double ivansSwimmingTime = swimmingDistance * timeNeededToSwimOneMeter + waterResistanceDelay;

            if (ivansSwimmingTime < worldSwimmingRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {ivansSwimmingTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {ivansSwimmingTime - worldSwimmingRecord:F2} seconds slower.");
            }
        }
    }
}
