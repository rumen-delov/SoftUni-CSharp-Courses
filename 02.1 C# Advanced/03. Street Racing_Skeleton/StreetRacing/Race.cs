using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StreetRacing
{
    public class Race
    {
        //private List<Car> Participants; // dict or hashset?

        public Race(string name, string type, int laps, int capacity, int maxHorsePower)
        {
            this.Name = name;
            this.Type = type;
            this.Laps = laps;
            this.Capacity = capacity;
            this.MaxHorsePower = maxHorsePower;
            this.Participants = new List<Car>();
        }

        public List<Car> Participants { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public int Laps { get; set; }

        // the maximum allowed number of participants in the race
        public int Capacity { get; set; }

        // the maximum allowed Horse Power of a Car in the Race
        public int MaxHorsePower { get; set; }

        // returns the count of the currently enrolled participants
        public int Count { get => Participants.Count; }


        public void Add(Car car)
        {
            if (FindParticipant(car.LicensePlate) == null &&
                this.Count < this.Capacity &&
                car.HorsePower <= this.MaxHorsePower)
            {
                Participants.Add(car);
            }
        }

        public bool Remove(string licensePlate)
        {
            Car carToRemove = FindParticipant(licensePlate);

            if (carToRemove == null)
            {
                return false;
            }

            Participants.Remove(carToRemove);
            return true;
        }

        public Car FindParticipant(string licensePlate)
        {
            return Participants.FirstOrDefault(p => p.LicensePlate == licensePlate);
        }

        public Car GetMostPowerfulCar()
        {
            return Participants.OrderByDescending(p => p.HorsePower).FirstOrDefault();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Race: {this.Name} - Type: {this.Type} (Laps: {this.Laps})");

            foreach (Car car in Participants)
            {
                sb.AppendLine(car.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}