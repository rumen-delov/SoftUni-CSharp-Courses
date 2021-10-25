using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            // My tests
            Motorcycle motor = new Motorcycle(250, 125);
            Console.WriteLine($"Your initial fuel load is {motor.Fuel:F2} liter.");
            motor.Drive(75);
            Console.WriteLine($"Your current fuel load is {motor.Fuel:F2} liter.");
        }
    }
}
