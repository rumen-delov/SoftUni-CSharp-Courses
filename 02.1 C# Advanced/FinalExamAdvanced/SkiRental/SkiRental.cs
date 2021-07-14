using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiRental
{
    public class SkiRental
    {
        private HashSet<Ski> data;

        public SkiRental(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new HashSet<Ski>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count { get => data.Count; } 

        public void Add(Ski ski)
        {
            if (Count < Capacity)
            {
                data.Add(ski);
            }            
        }

        public bool Remove(string manufacturer, string model)
        {
            return data.Remove(GetSki(manufacturer, model));
        }

        public Ski GetNewestSki()
        {
            return data.OrderByDescending(s => s.Year).FirstOrDefault();
        }

        public Ski GetSki(string manufacturer, string model)
        {
            return data.FirstOrDefault(s => s.Manufacturer == manufacturer && s.Model == model);
        }

        public string GetStatistics()
        {
            return $"The skis stored in {Name}:{Environment.NewLine}{string.Join(Environment.NewLine, data)}";

        }
    }
}
