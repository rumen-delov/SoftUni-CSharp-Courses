using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public Car(string model, decimal fuelAmount, decimal fuelConsumption)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumption;
            TravelledDistance = 0;
        }

        public string Model { get; }// set; }

        public decimal FuelAmount { get; private set; }

        public decimal FuelConsumptionPerKilometer { get; } // set; }

        public decimal TravelledDistance { get; private set; }

        public void Drive(decimal distance)
        {
            decimal remainingFuel = FuelAmount - (distance * FuelConsumptionPerKilometer);

            if (remainingFuel >= 0)
            {
                FuelAmount = remainingFuel;
                TravelledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{Model} {FuelAmount:F2} {TravelledDistance}";
        }
    }
}
