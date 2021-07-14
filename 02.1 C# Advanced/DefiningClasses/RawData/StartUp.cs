using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numOfCars = int.Parse(Console.ReadLine());
            const int NUM_OF_TIRES = 4;
            Car[] cars = new Car[numOfCars];

            for (int i = 0; i < numOfCars; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = carInfo[0];

                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                // Create new engine with the given parameters
                Engine engine = new Engine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                // Create new cargo with the given parameters
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                // Create a collection of 4 tires
                Tire[] tires = new Tire[NUM_OF_TIRES];

                // Fill the parameters for each of the 4 tires
                for (int j = 0; j < NUM_OF_TIRES; j++)
                {
                    int k = j + 2;

                    double tirePessure = double.Parse(carInfo[j + k + 3]);
                    int tireAge = int.Parse(carInfo[j + k + 4]);

                    // Fill the array of tires with a newly created tire
                    tires[j] = new Tire(tirePessure, tireAge);
                }

                // Fill the array of cars with a newly created car
                cars[i] = new Car(model, engine, cargo, tires);
            }

            string command = Console.ReadLine();

            switch (command)
            {
                case "fragile":
                    cars
                        .Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pessure < 1))
                        .Select(c => c.Model)
                        .ToList()
                        .ForEach(Console.WriteLine);                    
                    break;
                case "flamable":
                    cars
                        .Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250)
                        .Select(c => c.Model)
                        .ToList()
                        .ForEach(Console.WriteLine);
                    break;
                default:
                    break;
            }
        }
    }
}
