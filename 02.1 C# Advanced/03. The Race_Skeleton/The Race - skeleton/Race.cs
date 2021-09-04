using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        private List<Racer> data;

        public Race(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new List<Racer>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        // returns the number of Racers
        public int Count { get => data.Count; }

        public void Add(Racer Racer)
        {
            if (this.Count < this.Capacity)
            {
                data.Add(Racer);
            }
        }

        public bool Remove(string name)
        {
            Racer racerToRemove = GetRacer(name);

            if (racerToRemove == null)
            {
                return false;
            }

            data.Remove(racerToRemove);
            return true;
        }

        public Racer GetOldestRacer()
        {
            return data.OrderByDescending(r => r.Age).FirstOrDefault();
        }

        public Racer GetRacer(string name)
        {
            return data.FirstOrDefault(r => r.Name == name);
        }

        public Racer GetFastestRacer()
        {
            return data.OrderByDescending(r => r.Car.Speed).FirstOrDefault();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Racers participating at {this.Name}:");

            foreach (Racer racer in data)
            {
                sb.AppendLine(racer.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}