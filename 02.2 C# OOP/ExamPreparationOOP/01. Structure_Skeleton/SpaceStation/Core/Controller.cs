using SpaceStation.Core.Contracts;
using SpaceStation.Models.Astronauts;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission;
using SpaceStation.Models.Mission.Contracts;
using SpaceStation.Models.Planets;
using SpaceStation.Models.Planets.Contracts;
using SpaceStation.Repositories;
using SpaceStation.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Core
{
    public class Controller : IController
    {
        private AstronautRepository astronauts;
        private PlanetRepository planets;

        public Controller()
        {
            astronauts = new AstronautRepository();
            planets = new PlanetRepository();
        }
        
        public string AddAstronaut(string type, string astronautName)
        {
            IAstronaut astronaut = null;

            if (type == "Biologist")
            {
                astronaut = new Biologist(astronautName);
            }
            else if (type == "Geodesist")
            {
                astronaut = new Geodesist(astronautName);
            }
            else if (type == "Meteorologist")
            {
                astronaut = new Meteorologist(astronautName);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAstronautType);
            }

            astronauts.Add(astronaut);

            return $"Successfully added {type}: {astronautName}!";
        }

        public string AddPlanet(string planetName, params string[] items)
        {
            IPlanet planet = new Planet(planetName);
            planet.Items.Add(items);

            planets.Add(planet);

            return $"Successfully added Planet: {planetName}!";
        }

        public string ExplorePlanet(string planetName)
        {
            IPlanet planet = planets.FindByName(planetName);
            IMission mission = new Mission();

            List<IAstronaut> suitableAstronauts = astronauts.Models.Where(x => x.Oxygen > 60).ToList();

            if (suitableAstronauts.Any() == false)
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAstronautCount);
            }

            mission.Explore(planet, suitableAstronauts);

            List<IAstronaut> deadAstronauts = suitableAstronauts.Where(x => x.Oxygen == 0).ToList();

            return $"Planet: {planetName} was explored! Exploration finished with {deadAstronauts} dead astronauts!";
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{planets.Models.Count} planets were explored!");
            sb.AppendLine("Astronauts info:");

            foreach (IAstronaut astronaut in astronauts.Models)
            {
                sb.AppendLine($"Name: {astronaut.Name}");
                sb.AppendLine($"Oxygen: {astronaut.Oxygen}");
                if (astronaut.Bag.Items.Count == 0)
                {
                    sb.AppendLine("none");
                }
                else
                {
                    sb.AppendLine($"Bag items: {string.Join(", ", astronaut.Bag.Items)}");
                }
            }

            return sb.ToString().TrimEnd();
        }

        public string RetireAstronaut(string astronautName)
        {
            IAstronaut astronaut = astronauts.FindByName(astronautName);

            if (astronaut == null)
            {
                throw new InvalidOperationException($"Astronaut {astronautName} doesn't exists!");
            }

            astronauts.Remove(astronaut);
            return $"Astronaut {astronautName} was retired!";
        }
    }
}
