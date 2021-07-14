namespace NeedForSpeed
{
    class Vehicle
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
            if (Fuel > 0)
            {
                Fuel -= FuelConsumption * kilometers;
            }          
        }
    }
}
