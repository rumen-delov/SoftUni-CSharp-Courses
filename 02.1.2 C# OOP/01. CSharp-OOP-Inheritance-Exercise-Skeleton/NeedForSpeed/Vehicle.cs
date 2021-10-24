using System;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;

        public Vehicle(int horsePower, double fuel)
        {        
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        public int HorsePower { get; set; }

        public double Fuel { get; set; }

        public virtual double FuelConsumption => DefaultFuelConsumption;  // per kilometer?

        public virtual void Drive(double kilometers)
        {
            if (Fuel >= FuelConsumption * kilometers)
            {
                Fuel -= FuelConsumption * kilometers;
                Console.WriteLine($"Drive for {kilometers} km.");
            }
            else
            {
                Console.WriteLine($"You can drive only {Fuel/FuelConsumption:F3} km and not {kilometers:F3} km.");
            }
        }
    }
}
