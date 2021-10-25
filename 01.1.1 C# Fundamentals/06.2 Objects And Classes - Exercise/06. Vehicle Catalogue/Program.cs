using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue2._0
{
    class Program
    {
        public class VehicleCatalogue
        {
            public VehicleCatalogue()
            {
                Vehicles = new List<Vehicle>();
            }
            
            public List<Vehicle> Vehicles { get; set; }
        }
        
        public class Vehicle
        {
            public string Type { get; set; }

            public string Model { get; set; }

            public string Color { get; set; }

            public int Horsepower { get; set; }
        }
        
        static void Main(string[] args)
        {
            VehicleCatalogue vehicleCatalogue = new VehicleCatalogue();
            
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] tokens = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string type = tokens[0];
                string model = tokens[1];
                string color = tokens[2];
                int horsepower = int.Parse(tokens[3]); // integer in the range [1...1000]

                vehicleCatalogue.Vehicles.Add(new Vehicle()
                {
                    Type = type,
                    Model = model,
                    Color = color,
                    Horsepower = horsepower
                });
            }

            while (true)
            {
                string input = Console.ReadLine();
 
                if (input == "Close the Catalogue")
                {
                    break;
                }
                
                string model = input;

                Vehicle selectedVehicle = GetVehicleByModel(vehicleCatalogue.Vehicles, model);

                if (selectedVehicle == null)
                {
                    continue;
                }

                if (selectedVehicle.Type == "car")
                {
                    Console.WriteLine($"Type: Car");
                }
                else
                {
                    Console.WriteLine($"Type: Truck");
                }
                
                Console.WriteLine($"Model: {selectedVehicle.Model}");
                Console.WriteLine($"Color: {selectedVehicle.Color}");
                Console.WriteLine($"Horsepower: {selectedVehicle.Horsepower}");
            }

            // Calculate the average horsepower
            // average horsepower =
            // sum of the horsepower of all vehicles from the certain type /
            // total count of vehicles from the same type

            List<Vehicle> cars = vehicleCatalogue.Vehicles
                .Where(v => v.Type == "car")
                .ToList();

            double carsAvgHorsepower = CalculateAvgHorsepower(cars);
            Console.WriteLine($"Cars have average horsepower of: {carsAvgHorsepower:F2}.");

            List<Vehicle> trucks = vehicleCatalogue.Vehicles
                .Where(v => v.Type == "truck")
                .ToList();

            double trucksAvgHorsepower = CalculateAvgHorsepower(trucks);
            Console.WriteLine($"Trucks have average horsepower of: {trucksAvgHorsepower:F2}.");
        }

        private static double CalculateAvgHorsepower(List<Vehicle> vehicles)
        {
            double sum = 0;
            double avgHorsePower = 0;

            foreach (var vehicle in vehicles)
            {
                sum += vehicle.Horsepower; 
            }

            if (vehicles.Count > 0)
            {
                avgHorsePower = sum / vehicles.Count;
            }
            
            return avgHorsePower;
        }

        private static Vehicle GetVehicleByModel(List<Vehicle> vehicles, string model)
        {
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.Model == model)
                {
                    return vehicle;
                }
            }

            return null;
        }
    }
}
