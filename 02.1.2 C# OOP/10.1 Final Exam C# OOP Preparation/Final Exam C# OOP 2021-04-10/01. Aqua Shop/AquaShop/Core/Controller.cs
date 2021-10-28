using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish;
using AquaShop.Repositories;
using AquaShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        private DecorationRepository decorations;
        private List<IAquarium> aquariums;

        public Controller()
        {
            this.decorations = new DecorationRepository();
            this.aquariums = new List<IAquarium>();
        }

        public string AddAquarium(string aquariumType, string aquariumName)
        {
            if (aquariumType == "FreshwaterAquarium")
            {
                aquariums.Add(new FreshwaterAquarium(aquariumName));
            }
            else if (aquariumType == "SaltwaterAquarium")
            {
                aquariums.Add(new SaltwaterAquarium(aquariumName));
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAquariumType); 
            }

            return string.Format(OutputMessages.SuccessfullyAdded, aquariumType);
        }

        public string AddDecoration(string decorationType)
        {
            if (decorationType == "Ornament")
            {
                decorations.Add(new Ornament());
            }
            else if (decorationType == "Plant")
            {
                decorations.Add(new Plant());
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidDecorationType);
            }

            return string.Format(OutputMessages.SuccessfullyAdded, decorationType);
        }

        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            IAquarium selectedAquarium = aquariums.First(a => a.Name == aquariumName);
            
            if (fishType == "FreshwaterFish")
            {
                if (selectedAquarium.GetType().Name == "FreshwaterAquarium")
                {
                    selectedAquarium.AddFish(new FreshwaterFish(fishName, fishSpecies, price));
                    return string.Format(OutputMessages.EntityAddedToAquarium, fishType, aquariumName);
                }
                else
                {
                    return string.Format(OutputMessages.UnsuitableWater);
                }
            }
            else if (fishType == "SaltwaterFish")
            {
                if (selectedAquarium.GetType().Name == "SaltwaterAquarium")
                {
                    selectedAquarium.AddFish(new SaltwaterFish(fishName, fishSpecies, price));
                    return string.Format(OutputMessages.EntityAddedToAquarium, fishType, aquariumName);
                }
                else
                {
                    return string.Format(OutputMessages.UnsuitableWater);
                }                
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidFishType);
            }                     
        }

        public string CalculateValue(string aquariumName)
        {
            IAquarium selectedAquarium = aquariums.FirstOrDefault(a => a.Name == aquariumName);

            decimal aquariumValue = selectedAquarium.Fish.Sum(f => f.Price) + 
                                    selectedAquarium.Decorations.Sum(d => d.Price); 
            
            return string.Format(OutputMessages.AquariumValue, aquariumName, aquariumValue);
        }

        public string FeedFish(string aquariumName)
        {
            IAquarium selectedAquarium = aquariums.FirstOrDefault(a => a.Name == aquariumName);
            selectedAquarium.Feed();

            return string.Format(OutputMessages.FishFed, selectedAquarium.Fish.Count);
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            IAquarium selectedAquarium = aquariums.FirstOrDefault(a => a.Name == aquariumName);
            IDecoration selectedDecoration = decorations.FindByType(decorationType);

            if (selectedDecoration == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InexistentDecoration, decorationType));
            }

            selectedAquarium.AddDecoration(selectedDecoration);
            decorations.Remove(selectedDecoration);

            return string.Format(OutputMessages.EntityAddedToAquarium, decorationType, aquariumName);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            
            foreach (IAquarium aquarium in aquariums)
            {
                sb.AppendLine(aquarium.GetInfo());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
