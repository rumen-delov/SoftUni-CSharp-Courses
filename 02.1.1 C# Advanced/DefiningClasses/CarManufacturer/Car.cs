using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        // Task 1
        private string make;
        private string model;
        private int year;
        // Task 2
        private double fuelQuantity;
        private double fuelConsumption;
        // Task 4
        private Engine engine;
        private Tire[] tires;

        // Task 3
        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        public Car(string make, string model, int year)
            : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        // Task 4
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption,
            Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }

        // Task 1
        public string Make
        {
            get { return this.make; }  // get => this.make;
            set { this.make = value; } // set => this.make = value;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        // Task 2
        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set { this.fuelQuantity = value; }
        }

        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }

        // Task 4

        public Engine Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }

        public Tire[] Tires
        {
            get { return this.tires; }
            set { this.tires = value; }
        }

        // Task 2
        public void Drive(double distance)
        {
            double remainingFuel = this.FuelQuantity - (distance * this.FuelConsumption / 100);

            if (remainingFuel > 0)
            {
                this.FuelQuantity = remainingFuel;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make: {Make}\nModel: {Model}\nYear: {Year}\nHorsePowers: {Engine.HorsePower}\nFuelQuantity: {FuelQuantity}";

            // Task 2
            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine($"Make: {this.Make}");
            //sb.AppendLine($"Model: {this.Model}");
            //sb.AppendLine($"Year: {this.Year}");
            // Task 5
            //sb.AppendLine($"HorsePowers: {this.Engine.HorsePower}");
            //sb.AppendLine($"FuelQuantity: {this.FuelQuantity}");

            // Task 2
            //sb.AppendLine($"Fuel: {this.FuelQuantity:F2}L");

            //return sb.ToString();
        }
    }
}