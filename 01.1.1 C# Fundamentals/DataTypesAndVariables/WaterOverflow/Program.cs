using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            byte waterTankCapacity = 255;
            ushort currentAmount = 0;
            // The lines to be read should be in the interval [1...20]
            byte linesToRead = byte.Parse(Console.ReadLine());

            for (int line = 1; line <= linesToRead; line++)
            {
                // The liters of water to be poured should be in the interval [1...1000]
                ushort waterToPour = ushort.Parse(Console.ReadLine());
                
                if ((currentAmount + waterToPour) <= waterTankCapacity)
                {
                    currentAmount += waterToPour; 
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }

            }
                       
            Console.WriteLine(currentAmount);
        }
    }
}
