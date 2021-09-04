using SpaceStation.Models.Astronauts;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Repositories
{
    public class AstronautRepository : IRepository<IAstronaut>
    {
        private List<IAstronaut> astronauts;

        public AstronautRepository()
        {
            astronauts = new List<IAstronaut>();
        }
        
        public IReadOnlyCollection<IAstronaut> Models { get; private set; } = new List<IAstronaut>();

        public void Add(IAstronaut model)
        {
            astronauts.Add(model);
            this.Models = this.astronauts;
        }

        public IAstronaut FindByName(string name)
        {
            return astronauts.FirstOrDefault(x => x.Name == name);
        }

        public bool Remove(IAstronaut model)
        {
            if (astronauts.Contains(model))
            {
                astronauts.Remove(model);

                this.Models = this.astronauts;

                return true;
            }

            return false;
        }
    }
}
