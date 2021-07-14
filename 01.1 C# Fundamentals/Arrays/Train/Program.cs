using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfWagons = byte.Parse(Console.ReadLine());
            int[] trainPassengers = new int[numberOfWagons];
            int passengersCount = 0;

            for (int i = 0; i < numberOfWagons; i++)
            {
                int wagonPassengers = int.Parse(Console.ReadLine());
                trainPassengers[i] = wagonPassengers;
                
                passengersCount += wagonPassengers;
            }

            for (int i = 0; i < trainPassengers.Length; i++)
            {
                Console.Write($"{trainPassengers[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine(passengersCount);
        }
    }
}
