using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the input 
            int lengthFishTank = int.Parse(Console.ReadLine()); // (in cm)
            int widthFishTank = int.Parse(Console.ReadLine()); // (in cm)
            int heigthFishTank = int.Parse(Console.ReadLine()); // (in cm)
            double percentFishTankAllocatedSpace = double.Parse(Console.ReadLine());

            // Calculate the free space in the fish tank in litres
            int fishTankVolume = lengthFishTank * widthFishTank * heigthFishTank; // (in cubic cm)
            double fishTankVolumeLitre = fishTankVolume * 0.001;
            double fishTankFreeSpace = fishTankVolumeLitre - (fishTankVolumeLitre * percentFishTankAllocatedSpace * 0.01);

            // Write the result
            Console.WriteLine(fishTankFreeSpace);
        }
    }
}
