using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            // Task 1/2
            //Car car = new Car();

            // Task 1/2
            //car.Make = "VW";
            //car.Model = "MK3";
            //car.Year = 1992;
            // Task 2
            //car.FuelQuantity = 200;
            //car.FuelConsumption = 200;
            //car.Drive(2000);

            // Task 1
            //Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");

            // Task 2
            //Console.WriteLine(car.WhoAmI());

            // Task 3
            //string make = Console.ReadLine();
            //string model = Console.ReadLine();
            //int year = int.Parse(Console.ReadLine());
            //double fuelQuantity = double.Parse(Console.ReadLine());
            //double fuelConsumption = double.Parse(Console.ReadLine());

            //Car firstCar = new Car();
            //Car secondCar = new Car(make, model, year);
            //Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);

            // For my testing 
            //Console.WriteLine(firstCar.WhoAmI());
            //Console.WriteLine(secondCar.WhoAmI());
            //Console.WriteLine(thirdCar.WhoAmI());

            // Task 4
            // var tires = new Tire[4]
            // {
            //     new Tire(1, 2.5),
            //     new Tire(1, 2.1),
            //     new Tire(2, 0.5),
            //     new Tire(2, 2.3),
            // };
            //
            // var engine = new Engine(560, 6300);
            //
            // var car = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);

            // For my testing 
            //Console.WriteLine(car.WhoAmI());

            // Task 5
            List<Tire[]> tires = new List<Tire[]>();
            string input = Console.ReadLine();

            while (input != "No more tires")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Tire[] setOfTires = new Tire[4];

                for (int i = 0; i < setOfTires.Length; i++)
                {
                    setOfTires[i] = new Tire(int.Parse(tokens[i * 2]), double.Parse(tokens[i * 2 + 1]));
                }

                tires.Add(setOfTires);

                input = Console.ReadLine();
            }

            List<Engine> engines = new List<Engine>();
            input = Console.ReadLine();

            while (input != "Engines done")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int horsePower = int.Parse(tokens[0]);
                double cubicCapacity = double.Parse(tokens[1]);

                engines.Add(new Engine(horsePower, cubicCapacity));

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            List<Car> cars = new List<Car>();

            while (input != "Show special")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string make = tokens[0];
                string model = tokens[1];
                int year = int.Parse(tokens[2]);
                double fuelQuantity = double.Parse(tokens[3]);
                double fuelConsumption = double.Parse(tokens[4]);
                int engineIndex = int.Parse(tokens[5]);
                int tiresIndex = int.Parse(tokens[6]);

                cars.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]));

                input = Console.ReadLine();
            }

            List<Car> specialCars = cars.Where(c => c.Year >= 2017)
                .Where(c => c.Engine.HorsePower > 330)
                .Where(c => (c.Tires.Select(t => t.Pressure).Sum() >= 9 && c.Tires.Select(t => t.Pressure).Sum() <= 10))
                .ToList();

            double distance = 20;
            foreach (var car in specialCars)
            {
                car.Drive(distance);
                Console.WriteLine(car.WhoAmI());
            }
        }
    }
}
