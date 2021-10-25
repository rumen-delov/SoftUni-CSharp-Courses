using CarRacing.Models.Maps.Contracts;
using CarRacing.Models.Racers.Contracts;
using CarRacing.Utilities.Messages;

namespace CarRacing.Models.Maps
{
    public class Map : IMap
    {
        public string StartRace(IRacer racerOne, IRacer racerTwo)
        {
            if ((!racerOne.IsAvailable()) && (!racerTwo.IsAvailable()))
            {
                return OutputMessages.RaceCannotBeCompleted;
            }

            if ((racerOne.IsAvailable()) && (!racerTwo.IsAvailable()))
            {
                return string.Format(OutputMessages.OneRacerIsNotAvailable, racerOne, racerTwo);
            }

            if ((!racerOne.IsAvailable()) && (racerTwo.IsAvailable()))
            {
                return string.Format(OutputMessages.OneRacerIsNotAvailable, racerTwo, racerOne);
            }

            racerOne.Race();
            racerTwo.Race();

            var chanceOfWinningR1 = racerOne.Car.HorsePower * racerOne.DrivingExperience * racerOne.racingBehaviorMultiplier;
            var chanceOfWinningR1 = racerOne.Car.HorsePower * racerOne.DrivingExperience * racerOne.racingBehaviorMultiplier;

            IRacer winner; 

            return string.Format(OutputMessages.RacerWinsRace, racerOne, racerTwo, winner);

        }
    }
}
