using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {
        public class Truck
        {
            public string Brand { get; set; }

            public string Model { get; set; }

            public int Weight { get; set; }
        }

        public class Car
        {
            public string Brand { get; set; }

            public string Model { get; set; }

            public int HorsePower { get; set; }
        }

        public class CatalogueVehicle
        {
            // Option 1
            // Create instance of the list Cars and instance of the list Trucks in the constructor
            public CatalogueVehicle()
            {
                Cars = new List<Car>();
                Trucks = new List<Truck>();
            }

            public List<Truck> Trucks { get; set; }

            public List<Car> Cars { get; set; }
        }

        static void Main(string[] args)
        {
            CatalogueVehicle vehicleCatalogue = new CatalogueVehicle();
            // Option 2
            //vehicleCatalogue.Cars = new List<Car>();
            //vehicleCatalogue.Trucks = new List<Truck>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] tokens = input
                    .Split('/', StringSplitOptions.RemoveEmptyEntries);

                string type = tokens[0];

                switch (type)
                {
                    case "Truck":
                        string truckBrand = tokens[1];
                        string truckModel = tokens[2];
                        int truckWeight = int.Parse(tokens[3]);
                        vehicleCatalogue.Trucks.Add(new Truck()
                        {
                            Brand = truckBrand,
                            Model = truckModel,
                            Weight = truckWeight
                        });
                        break;
                    case "Car":
                        string carBrand = tokens[1];
                        string carModel = tokens[2];
                        int carHorsePower = int.Parse(tokens[3]);
                        vehicleCatalogue.Cars.Add(new Car()
                        {
                            Brand = carBrand,
                            Model = carModel,
                            HorsePower = carHorsePower
                        });
                        break;
                    default:
                        break;
                }
            }

            if (vehicleCatalogue.Cars.Count > 0)
            {
                List<Car> carsOrderedByBrand = vehicleCatalogue.Cars
                    .OrderBy(c => c.Brand)
                    .ToList();

                Console.WriteLine("Cars:");

                foreach (Car car in carsOrderedByBrand)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (vehicleCatalogue.Trucks.Count > 0)
            {
                List<Truck> trucksOrderedByBrand = vehicleCatalogue.Trucks
                    .OrderBy(t => t.Brand)
                    .ToList();

                Console.WriteLine("Trucks:");

                foreach (Truck truck in trucksOrderedByBrand)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
