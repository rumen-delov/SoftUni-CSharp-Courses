using System;

namespace Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double spaceshipWidth = double.Parse(Console.ReadLine());
            double spaceshipLength = double.Parse(Console.ReadLine());
            double spaceshipHeight = double.Parse(Console.ReadLine());
            double astronautsAvgHeight = double.Parse(Console.ReadLine());

            double spaceshipVolume = spaceshipWidth * spaceshipLength * spaceshipHeight;
            double roomVolume = 2 * 2 * (astronautsAvgHeight + 0.40);

            double numberAstronauts = Math.Floor(spaceshipVolume / roomVolume);
            //Console.WriteLine(numberAstronauts);

            if (numberAstronauts < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (numberAstronauts > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
            else
            {
                Console.WriteLine($"The spacecraft holds {numberAstronauts} astronauts.");
            }
        }
    }
}
