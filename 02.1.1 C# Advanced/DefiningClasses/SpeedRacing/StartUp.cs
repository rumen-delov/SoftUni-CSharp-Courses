using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numOfCars; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = carInfo[0]; // each model that is given in the input is unique
                decimal fuelAmount = decimal.Parse(carInfo[1]);
                decimal fuelConsumption = decimal.Parse(carInfo[2]); // fuel consumption per km

                cars.Add(new Car(model, fuelAmount, fuelConsumption)); 
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input.ToUpper() == "END")
                {
                    break;
                }

                string[] commandTokens = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                // The input of the command data is assured to be valid
                // but in case it is not, continue with the next command 
                //string command = commandTokens[0];
                //if (command != "Drive")
                //{
                //    continue;
                //}

                string model = commandTokens[1];
                decimal distance = decimal.Parse(commandTokens[2]);

                cars.Where(car => car.Model == model).ToList().ForEach(selectedCar => selectedCar.Drive(distance));

                // or

                //foreach (var selectedCar in cars)
                //{
                //    if (selectedCar.Model == model)
                //    {
                //        selectedCar.Drive(distance);
                //    }
                //}
            }

            cars.ForEach(Console.WriteLine);
        }
    }
}
