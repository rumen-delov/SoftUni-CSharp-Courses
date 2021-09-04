using SpaceStation.Models.Planets;
using SpaceStation.Models.Planets.Contracts;
using SpaceStation.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Repositories
{
    public class PlanetRepository : IRepository<IPlanet>
    {
        private List<IPlanet> planets;

        public PlanetRepository()
        {
            planets = new List<IPlanet>();
        }

        public IReadOnlyCollection<IPlanet> Models { get; private set; } = new List<IPlanet>();

        public void Add(IPlanet model)
        {
            planets.Add(model);
            this.Models = this.planets;
        }

        public IPlanet FindByName(string name)
        {
            return planets.FirstOrDefault(x => x.Name == name);
        }

        public bool Remove(IPlanet model)
        {
            if (planets.Contains(model))
            {
                planets.Remove(model);

                this.Models = this.planets;

                return true;
            }

            return false;
        }
    }
}
